using EasyHook;
using Microsoft.Win32.SafeHandles;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using Windows.Win32;
using Windows.Win32.Foundation;

namespace mono_chat_client.Hooks
{
  internal static class kernel32
  {
    [DllImport("KERNEL32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
    internal static extern IntPtr FindResourceA(HMODULE hModule, IntPtr lpName, IntPtr lpType);

    internal static void createFindResourceAHook()
    {
      var address = LocalHook.GetProcAddress("kernel32.dll", "FindResourceA");
      var findResourceHook = LocalHook.Create(address, new FindResourceADelegate(FindResourceAHook), null);
      findResourceHook.ThreadACL.SetInclusiveACL(new Int32[] { 0 });
    }

    public delegate IntPtr FindResourceADelegate(HMODULE hModule, IntPtr lpName, IntPtr lpType);

    public static IntPtr FindResourceAHook(HMODULE hModule, IntPtr lpName, IntPtr lpType)
    {
      var IS_INTRESOURCE = (IntPtr _r) => (_r >> 16) == 0;

      var _lpName = IS_INTRESOURCE(lpName) ? lpName.ToString() : Marshal.PtrToStringAuto(lpName);
      var _lpType = IS_INTRESOURCE(lpType) ? lpType.ToString() : Marshal.PtrToStringAuto(lpType);
      
      // TODO: Use PInvoke.FindResourceA (CsWin32) instead of a direct DLLImport to FindResourceA
      var result = FindResourceA(hModule, lpName, lpType);
      //Debug.WriteLine($"FindResource: {{ hModule: {hModule}, lpName: {_lpName}, lpType: {_lpType} }}: {result}");

      return result;
    }
  }
}
