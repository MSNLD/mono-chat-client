using EasyHook;
using System.Runtime.InteropServices;
using Windows.Win32;
using Windows.Win32.Foundation;
using Windows.Win32.UI.WindowsAndMessaging;

namespace mono_chat_client.Hooks
{
  internal static class user32
  {
    internal static void createMessageBoxWHook()
    {
      var address = LocalHook.GetProcAddress("user32.dll", "MessageBoxW");
      var messageBoxHook = LocalHook.Create(address, new MessageBoxWDelegate(MessageBoxWHook), null);
      // Not sure if this will catch all message boxes, as some may be on other threads.
      messageBoxHook.ThreadACL.SetInclusiveACL(new Int32[] { 0 });
    }

    public delegate MESSAGEBOX_RESULT MessageBoxWDelegate(HWND hWnd,
      [MarshalAs(UnmanagedType.LPWStr)] String lpText,
      [MarshalAs(UnmanagedType.LPWStr)] String lpCaption,
      MESSAGEBOX_STYLE uType);

    public static MESSAGEBOX_RESULT MessageBoxWHook(HWND hWnd,
      [MarshalAs(UnmanagedType.LPWStr)] String lpText,
      [MarshalAs(UnmanagedType.LPWStr)] String lpCaption,
      MESSAGEBOX_STYLE uType)
    {
      if (lpCaption == "MSN Chat")
        lpCaption = "Mono Chat"; // Re-write any "MSN Chat" dialogs as "Mono Chat"

      return PInvoke.MessageBoxA(hWnd, lpText, lpCaption, uType);
    }
  }
}
