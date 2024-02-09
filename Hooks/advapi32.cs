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
      var result = PInvoke.RegOpenKeyExA(hKey, lpSubKey, ulOptions, samDesired, phkResult);
      //Debug.WriteLine($"RegOpenKeyEx: {{ hKey: {hKey}, lpSubKey: {lpSubKey}, ulOptions: {ulOptions}, samDesired: {samDesired}, phkResult: {*phkResult} }}: {result}");

      if (lpSubKey.ToString() == "CLSID\\{F58E1CEF-A068-4C15-BA5E-587CAF3EE8C6}")
      {
        if (result != WIN32_ERROR.ERROR_SUCCESS)
        {
          // We don't have (or have access to) the key in the registry, so we'll set this up for interception.
          Marshal.StructureToPtr(HKEY.Null, (IntPtr)phkResult, false);
          return WIN32_ERROR.ERROR_FILE_NOT_FOUND;
        }
        else
        {
          return result;
        }
      }
      else
      {
        return result;
      }
    }

    internal static void createRegQueryValueExAHook()
    {
      var address = LocalHook.GetProcAddress("advapi32.dll", "RegQueryValueExA");
      var hook = LocalHook.Create(address, new RegQueryValueExADelegate(RegQueryValueExAHook), null);
      hook.ThreadACL.SetInclusiveACL(new Int32[] { 0 });
    }

    public delegate WIN32_ERROR RegQueryValueExADelegate(HKEY hKey, PCSTR lpValueName, uint* lpReserved, REG_VALUE_TYPE* lpType, byte* lpData, uint* lpcbData);

    public static WIN32_ERROR RegQueryValueExAHook(HKEY hKey, PCSTR lpValueName, uint* lpReserved, REG_VALUE_TYPE* lpType, byte* lpData, uint* lpcbData)
    {
      var result = PInvoke.RegQueryValueExA(hKey, lpValueName, lpReserved, lpType, lpData, lpcbData);
      Debug.WriteLine($"RegQueryValueEx: {{ hKey: {hKey}, lpValueName: {lpValueName}, lpReserved: {0x00}, lpType: {*lpType}, lpData: {*lpData}, lpcbData: {*lpcbData} }}: {result}");
      if (hKey.IsNull) // This isn't a valid hKey, so we know it's a key we can intercept.
      {
        if (lpValueName.ToString() == "{E113C6A6-D44A-4639-A40E-3B6DE32A1A40}")
        {
          *lpType = REG_VALUE_TYPE.REG_BINARY;
          var guid = new Guid("{00000000-0000-0000-0000-000000000045}");
          Marshal.StructureToPtr<Guid>(guid, (IntPtr)lpData, false);
          return WIN32_ERROR.ERROR_SUCCESS;
        }
        else if (lpValueName.ToString() == "{5954F421-4768-46bc-B331-3DC37B1E7048}")
        {
          Debug.WriteLine("*** (Hook) Intercepted RegQueryValueEx for {5954F421-4768-46bc-B331-3DC37B1E7048}");
          *lpType = REG_VALUE_TYPE.REG_NONE;
          return WIN32_ERROR.ERROR_FILE_NOT_FOUND;
        }
        else
        {
          return result;
        }
      }
      return result;
    }
  }
}
