using EasyHook;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using Windows.Win32;
using Windows.Win32.Foundation;
using Windows.Win32.System.Registry;
using Windows.Win32.System.SystemServices;

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
      // TODO: It would be better if we could do this per instance of the chat client, and check the GUID used in AxHost.
      // Currently, we are specifying MSNChat45's GUID explicitly.
      if (lpSubKey.ToString() == "CLSID\\{F58E1CEF-A068-4C15-BA5E-587CAF3EE8C6}")
      {
        // This will cause a random GateKeeper address to be issued on MSNChat45.
        return WIN32_ERROR.ERROR_FILE_NOT_FOUND;
      }
      else
      {
        var result = PInvoke.RegOpenKeyExA(hKey, lpSubKey, ulOptions, samDesired, phkResult);
        var _phkResult = Marshal.PtrToStructure<HKEY>((nint)phkResult);
        Debug.WriteLine($"RegOpenKeyEx: {{ hKey: {hKey}, lpSubKey: {lpSubKey}, ulOptions: {ulOptions}, samDesired: {samDesired}, phkResult: {_phkResult} }}: {result}");
        return result;
      }
    }
  }
}
