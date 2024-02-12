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

    private static Dictionary<nint, HMODULE> hModuleResDLL = new();

    internal static void createFindResourceAHook()
    {
      var address = LocalHook.GetProcAddress("kernel32.dll", "FindResourceA");
      var findResourceAHook = LocalHook.Create(address, new FindResourceADelegate(FindResourceAHook), null);
      //findResourceAHook.ThreadACL.SetInclusiveACL(new Int32[] { 0 });
      findResourceAHook.ThreadACL.SetExclusiveACL(new Int32[] { });
    }

    public delegate IntPtr FindResourceADelegate(HMODULE hModule, IntPtr lpName, IntPtr lpType);

    public static IntPtr FindResourceAHook(HMODULE hModule, IntPtr lpName, IntPtr lpType)
    {
      var IS_INTRESOURCE = (IntPtr _r) => (_r >> 16) == 0;

      var _lpName = IS_INTRESOURCE(lpName) ? lpName.ToString() : Marshal.PtrToStringAuto(lpName);
      var _lpType = IS_INTRESOURCE(lpType) ? lpType.ToString() : Marshal.PtrToStringAuto(lpType);

      // TODO: Use PInvoke.FindResourceA (CsWin32) instead of a direct DLLImport to FindResourceA
      var hModule2 = ResDLL.get();
      if (hModule2 != (HMODULE)0x0) // We have a resource DLL
      {
        var result2 = FindResourceA(hModule2, lpName, lpType);
        if (result2 != IntPtr.Zero)
        {
          Debug.WriteLine($"FindResource2: {{ hModule: {hModule2}, lpName: {lpName}, lpType: {lpType} }}: {result2}");
          hModuleResDLL.Add(result2, hModule2); // Store the result so we can bypass the original DLL's resources
          return result2;
        }
      }

      var result = FindResourceA(hModule, lpName, lpType);
      Debug.WriteLine($"FindResource: {{ hModule: {hModule}, lpName: {_lpName}, lpType: {_lpType} }}: {result}");
      return result;
    }

    internal static void createLoadResourceHook()
    {
      var address = LocalHook.GetProcAddress("kernel32.dll", "LoadResource");
      var loadResourceHook = LocalHook.Create(address, new LoadResourceDelegate(LoadResourceHook), null);
      //loadResourceHook.ThreadACL.SetInclusiveACL(new Int32[] { 0 });
      loadResourceHook.ThreadACL.SetExclusiveACL(new Int32[] { });
    }

    public delegate HGLOBAL LoadResourceDelegate(HMODULE hModule, HRSRC hResInfo);

    public static HGLOBAL LoadResourceHook(HMODULE hMODULE, HRSRC hResInfo)
    {
      if (hModuleResDLL.TryGetValue(hResInfo.Value, out var value)) // Did we cache a result from our resource DLL?
      {
        hMODULE = value;
        hModuleResDLL.Remove(hResInfo.Value);
      }
      var result = PInvoke.LoadResource(hMODULE, hResInfo);
      return result;
    }
  }
}
