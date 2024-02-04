using EasyHook;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Windows.Win32;
using Windows.Win32.Foundation;
using Windows.Win32.System.Registry;

namespace mono_chat_client.Hooks
{
  internal unsafe static class advapi32
  {
    internal static void createRegOpenKeyExAHook()
    {
      var address = LocalHook.GetProcAddress("advapi32.dll", "RegOpenKeyExA");
      var hook = LocalHook.Create(address, new RegOpenKeyExADelegate(RegOpenKeyExAHook), null);
      hook.ThreadACL.SetInclusiveACL(new Int32[] { 0 });
    }

    public delegate WIN32_ERROR RegOpenKeyExADelegate(HKEY hKey, PCSTR lpSubKey, uint ulOptions, REG_SAM_FLAGS samDesired, HKEY* phkResult);

    public static WIN32_ERROR RegOpenKeyExAHook(HKEY hKey, PCSTR lpSubKey, uint ulOptions, REG_SAM_FLAGS samDesired, HKEY* phkResult)
    {
      var result = PInvoke.RegOpenKeyExA(hKey, lpSubKey, ulOptions, samDesired, phkResult);
      var _phkResult = Marshal.PtrToStructure<HKEY>((nint)phkResult);
      Debug.WriteLine($"RegOpenKeyEx: {{ hKey: {hKey}, lpSubKey: {lpSubKey}, ulOptions: {ulOptions}, samDesired: {samDesired}, phkResult: {_phkResult} }}: {result}");
      return result;
    }
  }
}
