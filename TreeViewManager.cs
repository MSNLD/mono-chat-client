using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Windows.Win32;
using Windows.Win32.Foundation;
using Windows.Win32.UI.Accessibility;
using Windows.Win32.UI.WindowsAndMessaging;
using static Windows.Win32.PInvoke;
using static Windows.Win32.UI.WindowsAndMessaging.WINDOW_STYLE;
using static Windows.Win32.UI.WindowsAndMessaging.WINDOW_LONG_PTR_INDEX;
using static Windows.Win32.UI.WindowsAndMessaging.SET_WINDOW_POS_FLAGS;
using static Windows.Win32.UI.WindowsAndMessaging.WINDOW_EX_STYLE;
using System.Drawing;

namespace mono_chat_client
{
  internal class TreeViewManager
  {
    TreeView treeView;
    readonly IntPtr hWnd;
    uint whisperThreadId;

    public TreeViewManager(TreeView treeView, IntPtr hWnd)
    {
      this.treeView = treeView;
      this.hWnd = hWnd;

      addParentNode();

      HWND CWhisperManager = FindWindowExW((HWND)hWnd, (HWND)IntPtr.Zero, "CWhisperManager", null);
      unsafe
      {
        whisperThreadId = GetWindowThreadProcessId(CWhisperManager);
      }
      // Listen for events in the "CWhisperManager" window's thread.
      PInvoke.SetWinEventHook((uint)PInvoke.WindowsEventHookType.EVENT_OBJECT_CREATE, (uint)WindowsEventHookType.EVENT_OBJECT_DESTROY, null, WinEventProc, (uint)Environment.ProcessId, whisperThreadId, (uint)(WindowsEventHookFlags.WINEVENT_OUTOFCONTEXT | WindowsEventHookFlags.WINEVENT_SKIPOWNTHREAD));
    }

    private string getChannelName()
    {
      var channelName = "";
      // TODO: Does FindWindowEx work to find the last window if we supply IntPtr.Zero for hWndAfter? (I doubt it, but worth trying rather than enumerating all windows)
      HWND lastHWnd = (HWND)IntPtr.Zero;
      EnumChildWindows((HWND)hWnd, (hWnd, lParam) =>
      {
        lastHWnd = hWnd;
        return true;
      }, (LPARAM)IntPtr.Zero);
      if (lastHWnd != (HWND)IntPtr.Zero)
      {
        var len = GetWindowTextLengthW(lastHWnd);
        if (len > 0)
        {
          unsafe
          {
            var nMaxCount = len + 1;
            var lpString = stackalloc char[nMaxCount];
            if (GetWindowTextW(lastHWnd, lpString, nMaxCount) > 0)
              channelName = new string(lpString);
          }
        }
      }
      return channelName;
    }

    private TreeNode addParentNode()
    {
      var caption = getChannelName();
      var node = treeView.Nodes.Add((!string.IsNullOrEmpty(caption)) ? caption: "<Unknown>");
      node.Tag = (HWND)hWnd;
      return node;
    }

    private TreeNode? getParentNode()
    {
      if (hWnd == IntPtr.Zero)
        return null;

      foreach (TreeNode node in treeView.Nodes)
      {
        if ((HWND)node.Tag == (HWND)hWnd)
          return node;
      }

      return null;
    }

    // TODO: Call when it closes.
    private void deleteParentNode()
    {
      var parentNode = getParentNode();
      if (parentNode == null)
        return;
      parentNode.Remove();
    }

    private TreeNode? addChildNode(HWND hWnd, string caption)
    {
      var parentNode = getParentNode();
      if (parentNode == null)
        return null;
      // Enhancement: Adds context to the Whisper Window titlebar.
      SetWindowTextW(hWnd, $"{caption} - {parentNode.Text}");
      var node = parentNode.Nodes.Add(caption);
      node.Tag = hWnd;
      if (parentNode.Nodes.Count == 1)
        parentNode.Expand();
      hideTitleBar(hWnd);
      return node;
    }

    private TreeNode? getChildNode(HWND hWnd)
    {
      if (hWnd == IntPtr.Zero)
        return null;

      var parentNode = getParentNode();
      if (parentNode == null)
            return null;

      foreach (TreeNode childNode in parentNode.Nodes)
      {
        if ((HWND)childNode.Tag == (HWND)hWnd)
          return childNode;
      }

      return null;
    }

    private void deleteChildNode(HWND hWnd)
    {
      var childNode = getChildNode(hWnd);
      if (childNode == null)
        return;
      childNode.Remove();
    }

    private unsafe void WinEventProc(HWINEVENTHOOK hWinEventHook, uint @event, HWND hWnd, int idObject, int idChild, uint idEventThread, uint dwmsEventTime)
    {
      if (idObject == (int)OBJECT_IDENTIFIER.OBJID_WINDOW)
      {
        var lpClassName = stackalloc char[256];
        GetClassNameW(hWnd, lpClassName, 256);
        var className = new String(lpClassName);

        if (className == "#32770") // Dialog
        {
          if (@event == (uint)WindowsEventHookType.EVENT_OBJECT_CREATE)
          {
            var windowText = "";
            var len = GetWindowTextLengthW(hWnd);
            if (len > 0)
            {
              var nMaxCount = len + 1;
              var lpString = stackalloc char[nMaxCount];
              if (GetWindowTextW(hWnd, lpString, nMaxCount) > 0)
                windowText = new string(lpString);
            }
            addChildNode(hWnd, windowText);
          }
        }
        else if (@event == (uint)WindowsEventHookType.EVENT_OBJECT_DESTROY)
        {
          deleteChildNode(hWnd);
        }
      }
    }

    private void hideTitleBar(HWND hWnd)
    {
      // Defaults (on Win11)
      // WS: 0x96CF00C4L = WS_POPUP | WS_VISIBLE | WS_CLIPSIBLINGS | WS_CLIPCHILDREN | WS_OVERLAPPEDWINDOW | 0xC4 (App Defined)
      // WS_EX: 0x00010101L = WS_EX_CONTROLPARENT | WS_EX_WINDOWEDGE | WS_EX_DLGMODALFRAME

      // We need this before we remove the titlebar, etc.
      GetClientRect(hWnd, out var rect);

      // Get rid of the title bar and window border.
      var style = (uint)GetWindowLongW(hWnd, GWL_STYLE);
      style ^= (uint)(WS_POPUP | WS_CHILD | WS_OVERLAPPEDWINDOW);
      SetWindowLongW(hWnd, GWL_STYLE, (int)style);

      // Get rid of the Dialog Modal Frame.
      var exStyle = (uint)GetWindowLongW(hWnd, GWL_EXSTYLE);
      exStyle ^= (uint)WS_EX_DLGMODALFRAME;
      SetWindowLongW(hWnd, GWL_EXSTYLE, (int)exStyle);

      // Resize the window to the size of the client area.
      SetWindowPos(hWnd, (HWND)IntPtr.Zero, 0, 0, rect.right, rect.bottom, SWP_NOZORDER | SWP_NOACTIVATE);

      var f = new Form();
      f.Deactivate += (sender, e) => { f.Tag = GetFocus(); }; // Save the focus so we can restore it when the form is activated.
      f.Activated += (sender, e) => { if (f.Tag != null) SetFocus((HWND)f.Tag); }; // Restore the focus.
      SetParent(hWnd, (HWND)f.Handle);
      var title = getChildNode(hWnd);
      f.Text = (title != null) ? title.Text : "<Unknown>";

      // Resize the form to the size of the Whisper window.
      f.ClientSize = new System.Drawing.Size(rect.right, rect.bottom);
      // If our form is resized, we need to resize the Whisper window.
      f.Resize += (object? sender, EventArgs e) => { SetWindowPos(hWnd, (HWND)IntPtr.Zero, 0, 0, f.ClientSize.Width, f.ClientSize.Height, SWP_NOZORDER | SWP_NOACTIVATE); };
      f.Show();

      nuint ICON_SMALL =  0x0;
      nuint ICON_BIG =    0x1;

      nint hIconBig = SendMessageW((HWND)hWnd, WM_GETICON, ICON_BIG, IntPtr.Zero);
      nint hIconSmall = SendMessageW((HWND)hWnd, WM_GETICON, ICON_SMALL2, IntPtr.Zero);
      SendMessageW((HWND)f.Handle, WM_SETICON, ICON_SMALL, hIconSmall);
      SendMessageW((HWND)f.Handle, WM_SETICON, ICON_BIG, hIconBig);
    }
  }
}
