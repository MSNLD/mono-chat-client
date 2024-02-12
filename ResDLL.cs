using Microsoft.Win32.SafeHandles;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Windows.Win32;
using Windows.Win32.Foundation;
using Windows.Win32.System.LibraryLoader;

namespace mono_chat_client
{
  internal static class ResDLL
  {
    private static HMODULE resDLL = (HMODULE)0x0;

    internal unsafe static void load(string filename)
    {
      var unsafeFileName = Marshal.StringToCoTaskMemAuto(filename);
      var hModule = PInvoke.LoadLibraryExW(
        (PCWSTR)unsafeFileName.ToPointer(),
        default,
        LOAD_LIBRARY_FLAGS.LOAD_LIBRARY_SEARCH_APPLICATION_DIR | LOAD_LIBRARY_FLAGS.LOAD_LIBRARY_AS_DATAFILE);
      if (hModule.Value != (HMODULE)0x0) // Successful load
      {
        unload(); // Unload the previous DLL
        resDLL = hModule; // Set the new DLL
      }
      Marshal.FreeCoTaskMem(unsafeFileName);
    }

    internal static void unload()
    {
      PInvoke.FreeLibrary(resDLL);
      resDLL = (HMODULE)0x0;
    }

    internal static HMODULE get()
    {
      return resDLL;
    }

    internal static string getMax()
    {
      unsafe
      {
        PInvoke.GetModuleInformation(
          new SafeProcessHandle(Process.GetCurrentProcess().Handle, true),
          new SafeProcessHandle(resDLL, false),
          out var moduleInfo,
          (uint)sizeof(Windows.Win32.System.ProcessStatus.MODULEINFO));
        return $"{moduleInfo.SizeOfImage}";
      }

    }
  }
}
