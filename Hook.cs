using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Text;
using EasyHook;
using Microsoft.Win32.SafeHandles;
using Windows.Win32;
using Windows.Win32.Foundation;
using Windows.Win32.Networking.WinSock;
using Windows.Win32.System.Registry;
using Windows.Win32.UI.WindowsAndMessaging;

namespace mono_chat_client
{
  internal class AwesomeHook
  {
    [DllImport("wsock32.dll", SetLastError = true)]
    internal static extern int WSAGetLastError();

    public AwesomeHook()
    {
      createMessageBoxHook();
      createConnectHook();
      createRegistryHooks();
    }

    internal void createConnectHook()
    {
      WSAGetLastError(); // Pre-load wsock32.dll
      var connectHook = LocalHook.Create(
        LocalHook.GetProcAddress("wsock32.dll", "connect"),
        new ConnectDelegate(ConnectHook),
        this);
      connectHook.ThreadACL.SetExclusiveACL(new Int32[] { });
    }

    public delegate int ConnectDelegate(SOCKET s, IntPtr name, int namelen);

    private static void Dump(object o)
    {
      if (o == null)
      {
        Debug.WriteLine("<null>");
        return;
      }

      var type = o.GetType();
      var properties = TypeDescriptor.GetProperties(type);

      Debug.Write('{');
      Debug.Write(type.Name);

      if (properties.Count != 0)
      {
        Debug.Write(' ');

        for (int i = 0, n = properties.Count; i < n; i++)
        {
          if (i != 0)
            Console.Write("; ");

          var property = properties[i];

          Debug.Write(property.Name);
          Debug.Write(" = ");
          Debug.Write(property.GetValue(o));
        }
      }

      Debug.WriteLine('}');
    }

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
        SOCKADDR_IN6 sockAddr_in6 = Marshal.PtrToStructure<SOCKADDR_IN6>(name);
        unsafe
        {
          // I wrote this, and didn't test it. I'm not even sure it will ever be reached - does wsock32.dll even support IPv6?
          var in6_addr = sockAddr_in6.sin6_addr;
          ReadOnlySpan<Byte> addr = new ReadOnlySpan<Byte>(&in6_addr.u.Byte.Value, sockAddr_in6.sin6_addr.u.Byte.Length);
          //byte[] addr = new byte[in6_addr.u.Byte.Length];
          //Marshal.Copy((IntPtr)in6_addr.u.Byte.Value, addr, 0, in6_addr.u.Byte.Length);
          //Debug.WriteLine("IN6_ADDR: " + string.Join(" ", addr));
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
      // We could do some cool stuff here, like redirecting the connection to a different server

      SafeHandle _s = new SafeFileHandle((nint)s.Value, true);
      return PInvoke.connect(_s, sockAddr, namelen);
    }

    internal void createRegistryHooks()
    {
      // TODO: This doesn't work. It does however, cause the OCX to generate random UUIDs.
      var hook = LocalHook.Create(
        LocalHook.GetProcAddress("advapi32.dll", "RegOpenKeyExA"),
        new RegOpenKeyExADelegate(RegOpenKeyExAHook),
        this);
      hook.ThreadACL.SetExclusiveACL(new Int32[] { });
    }

    public unsafe delegate WIN32_ERROR RegOpenKeyExADelegate(
      HKEY hKey,
      string lpSubKey,
      uint ulOptions,
      REG_SAM_FLAGS samDesired,
      IntPtr phkResult);

    public unsafe static WIN32_ERROR RegOpenKeyExAHook(
      HKEY hKey,
        string lpSubKey,
        uint ulOptions,
        REG_SAM_FLAGS samDesired,
        IntPtr phkResult)
    {
      Debug.WriteLine($"RegOpenKeyEx: hKey: {hKey}, lpSubKey: {lpSubKey}, ulOptions: {ulOptions}, samDesired: {samDesired}");
      SafeRegistryHandle _hKey = new SafeRegistryHandle(hKey.Value, false);
      SafeRegistryHandle _phkResult = new SafeRegistryHandle(phkResult, false);
      return PInvoke.RegOpenKeyExA(_hKey, lpSubKey, ulOptions, samDesired, out _phkResult);
    }

    internal void createMessageBoxHook()
    {
      var messageBoxHook = LocalHook.Create(
        LocalHook.GetProcAddress("user32.dll", "MessageBoxW"),
        new MessageBoxDelegate(MessageBoxHook),
        null);
      messageBoxHook.ThreadACL.SetExclusiveACL(new Int32[1] { Environment.CurrentManagedThreadId });
    }

    public delegate MESSAGEBOX_RESULT MessageBoxDelegate(
      HWND hWnd,
      [MarshalAs(UnmanagedType.LPWStr)]
      String lpText,
      [MarshalAs(UnmanagedType.LPWStr)]
      String lpCaption,
      MESSAGEBOX_STYLE uType);

    public static MESSAGEBOX_RESULT MessageBoxHook(
      HWND hWnd,
      [MarshalAs(UnmanagedType.LPWStr)]
      String lpText,
      [MarshalAs(UnmanagedType.LPWStr)]
      String lpCaption,
      MESSAGEBOX_STYLE uType)
    {
      lpCaption = (lpCaption == "MSN Chat") ? "Mono Chat" : lpCaption; // Re-write any "MSN Chat" dialogs as "Mono Chat"
      return PInvoke.MessageBoxA(hWnd, lpText, lpCaption, uType);
    }
  }
}
