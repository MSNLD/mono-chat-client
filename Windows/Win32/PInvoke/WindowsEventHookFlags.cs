﻿// Copyright © .NET Foundation and Contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Windows.Win32
{
  using System;

  /// <content>Contains the <see cref="WindowsEventHookType" /> nested type.</content>
  internal static partial class PInvoke
  {
    /// <summary>Flag values that specify the location of the hook function and of the events to be skipped. <see cref="SetWinEventHook(WindowsEventHookType, WindowsEventHookType, IntPtr, IntPtr, int, int, WindowsEventHookFlags)" />.</summary>
    [Flags]
    public enum WindowsEventHookFlags
    {
      /// <summary>
      ///     The callback function is not mapped into the address space of the process that generates the
      ///     event. Because the hook function is called across process boundaries, the system must queue
      ///     events. Although this method is asynchronous, events are guaranteed to be in sequential order.
      /// </summary>
      WINEVENT_OUTOFCONTEXT = 0x0000,

      /// <summary>
      ///     Prevents this instance of the hook from receiving the events that are generated by the thread that
      ///     is registering this hook.
      /// </summary>
      WINEVENT_SKIPOWNTHREAD = 0x0001,

      /// <summary>
      ///     Prevents this instance of the hook from receiving the events that are generated by threads in this process.
      ///     This flag does not prevent threads from generating events.
      /// </summary>
      WINEVENT_SKIPOWNPROCESS = 0x0002,

      /// <summary>
      ///     The DLL that contains the callback function is mapped into the address space of the
      ///     process that generates the event. With this flag, the system sends event notifications
      ///     to the callback function as they occur. The hook function must be in a DLL when this flag
      ///     is specified. This flag has no effect when both the calling process and the generating process
      ///     are not 32-bit or 64-bit processes, or when the generating process is a console application.
      /// </summary>
      WINEVENT_INCONTEXT = 0x0004,
    }
  }
}
