using System;
using System.Runtime.InteropServices;
using System.IO;
using System.ComponentModel;
using System.Security;
using System.Threading;
using Microsoft.Win32.SafeHandles;
using System.Runtime.ConstrainedExecution;
using System.Security.Permissions;

namespace mono_chat_client
{
  public sealed partial class SafeHandle2 : SafeHandle
  {
    public SafeHandle2(IntPtr preexistingHandle, bool ownsHandle) : base(preexistingHandle, ownsHandle)
    {
      SetHandle(preexistingHandle);
    }

    override protected bool ReleaseHandle()
    {
      return NativeMethods.CloseHandle(handle);
    }

    public override bool IsInvalid { get { return false; } }
  }

  [SuppressUnmanagedCodeSecurity()]
  internal static class NativeMethods
  {
    // Free the kernel's file object (close the file).
    [DllImport("kernel32", SetLastError = true)]
    internal extern static bool CloseHandle(IntPtr handle);
  }
}
