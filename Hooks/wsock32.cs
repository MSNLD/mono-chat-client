using EasyHook;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using Windows.Win32;
using Windows.Win32.Foundation;
using Windows.Win32.Networking.WinSock;

namespace mono_chat_client.Hooks
{
  internal static class wsock32
  {
    internal static void createConnectHook()
    {
      IntPtr address = LocalHook.GetProcAddress("wsock32.dll", "connect");
      LocalHook connectHook = LocalHook.Create(address, new ConnectDelegate(ConnectHook), null);
      connectHook.ThreadACL.SetExclusiveACL(new Int32[] { }); // May or may not be on our thread
    }

    public delegate int ConnectDelegate(SOCKET s, IntPtr name, int namelen);

    public static int ConnectHook(SOCKET s, IntPtr name, int namelen)
    {
      IPAddress remoteIP;
      ushort remotePort;

      SOCKADDR sockAddr = Marshal.PtrToStructure<SOCKADDR>(name);
      if (sockAddr.sa_family == ADDRESS_FAMILY.AF_INET)
      {
        SOCKADDR_IN sockAddr_in = Marshal.PtrToStructure<SOCKADDR_IN>(name);
        remoteIP = new IPAddress(sockAddr_in.sin_addr.S_un.S_addr);
        remotePort = (ushort)IPAddress.NetworkToHostOrder((short)sockAddr_in.sin_port);
      }
      else if (sockAddr.sa_family == ADDRESS_FAMILY.AF_INET6)
      {
        // This IPv6 code is untested, you might need to fix it. ~JD (TODO: remove this upon successful testing)
        SOCKADDR_IN6 sockAddr_in6 = Marshal.PtrToStructure<SOCKADDR_IN6>(name);
        unsafe
        {
          var in6_addr = sockAddr_in6.sin6_addr;
          ReadOnlySpan<Byte> addr = new ReadOnlySpan<Byte>(&in6_addr.u.Byte.Value, sockAddr_in6.sin6_addr.u.Byte.Length);
          remoteIP = new IPAddress(addr);
          remotePort = (ushort)IPAddress.NetworkToHostOrder((short)sockAddr_in6.sin6_port);
        }
      }
      else
      {
        remoteIP = IPAddress.None;
        remotePort = 0;
      }
      Debug.WriteLine($"Connecting to {remoteIP.ToString()}:{remotePort}");

      SafeSocketHandle _s = new SafeSocketHandle((IntPtr)s.Value, false);
      return PInvoke.connect(_s, sockAddr, namelen);
    }

    internal static void createRecvHook()
    {
      var address = LocalHook.GetProcAddress("wsock32.dll", "recv");
      var recvHook = LocalHook.Create(address, new RecvDelegate(RecvHook), null);
      recvHook.ThreadACL.SetExclusiveACL(new Int32[] { }); // Will never be on our thread
    }

    public delegate int RecvDelegate(SOCKET s, PSTR buf, int len, SEND_RECV_FLAGS flags);

    public static int RecvHook(SOCKET s, PSTR buf, int len, SEND_RECV_FLAGS flags)
    {
      SafeSocketHandle _s = new SafeSocketHandle((IntPtr)s.Value, false);
#pragma warning disable CA1416 // Validate platform compatibility
      var bytesReceived = PInvoke.recv(_s, buf, len, flags);
#pragma warning restore CA1416 // Validate platform compatibility
      if (bytesReceived > 0)
      {
        unsafe
        {
          var sBuf = new string((sbyte*)buf.Value, 0, bytesReceived, Encoding.Latin1);
          //Debug.WriteLine($"Received {bytesReceived} bytes: " + sBuf);
        }
      }
      return bytesReceived;
    }
  }
}
