using System.Diagnostics;
using System.Net;
using System.Runtime.InteropServices;
using EasyHook;
using Windows.Win32;
using Windows.Win32.Foundation;
using Windows.Win32.Networking.WinSock;
using Windows.Win32.UI.WindowsAndMessaging;

namespace mono_chat_client
{
  internal class AwesomeHook
  {
    [DllImport("wsock32.dll", SetLastError = true)]
    internal static extern int connect(IntPtr s, IntPtr name, int namelen);

    [DllImport("wsock32.dll", SetLastError = true)]
    internal static extern int WSAGetLastError();

    public AwesomeHook()
    {
      createMessageBoxHook();
      createConnectHook();
    }

    internal void createConnectHook()
    {
      WSAGetLastError(); // Pre-load wsock32.dll
      var connectHook2 = LocalHook.Create(
        LocalHook.GetProcAddress("wsock32.dll", "connect"),
        new ConnectDelegate(ConnectHook),
        this);
      connectHook2.ThreadACL.SetExclusiveACL(new Int32[] { });
    }

    public delegate int ConnectDelegate(IntPtr s, IntPtr name, int namelen);

    public static int ConnectHook(IntPtr s, IntPtr name, int namelen)
    {
      var sockaddr = Marshal.PtrToStructure<SOCKADDR_IN>(name);
      IPAddress remoteIP = new IPAddress(sockaddr.sin_addr.S_un.S_addr);
      short remotePort = IPAddress.NetworkToHostOrder((short)sockaddr.sin_port);
      ADDRESS_FAMILY addressFamily = sockaddr.sin_family;
      Debug.WriteLine($"Connecting to {remoteIP}:{remotePort} ({addressFamily})");
      // We could do some cool stuff here, like redirecting the connection to a different server
      return connect(s, name, namelen);
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
      return PInvoke.MessageBox(hWnd, lpText, lpCaption, uType);
    }
  }
}
