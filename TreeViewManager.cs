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

      HWND CWhisperManager = FindWindowEx((HWND)hWnd, (HWND)IntPtr.Zero, "CWhisperManager", null);
      unsafe
      {
        whisperThreadId = GetWindowThreadProcessId(CWhisperManager);
      }
      // Listen for events in the "CWhisperManager" window's thread.
      PInvoke.SetWinEventHook((uint)PInvoke.WindowsEventHookType.EVENT_OBJECT_CREATE, (uint)WindowsEventHookType.EVENT_OBJECT_DESTROY, null, WinEventProc, (uint)Environment.ProcessId, whisperThreadId, (uint)(WindowsEventHookFlags.WINEVENT_OUTOFCONTEXT | WindowsEventHookFlags.WINEVENT_SKIPOWNTHREAD));
    }

    private void EnumChildWindows2(nint hWnd, Func<HWND, LPARAM, BOOL> value)
    {
      throw new NotImplementedException();
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
        var len = GetWindowTextLength(lastHWnd);
        if (len > 0)
        {
          unsafe
          {
            var nMaxCount = len + 1;
            var lpString = stackalloc char[nMaxCount];
            if (GetWindowText(lastHWnd, lpString, nMaxCount) > 0)
              channelName = new string(lpString);
          }
        }
      }
      return channelName;
    }

    private TreeNode addParentNode()
    {
      Debug.WriteLine("addParentNode");
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
      SetWindowText(hWnd, $"{caption} - {parentNode.Text}");
      var node = parentNode.Nodes.Add(caption);
      node.Tag = hWnd;
      if (parentNode.Nodes.Count == 1)
        parentNode.Expand();
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
        GetClassName(hWnd, lpClassName, 256);
        var className = new String(lpClassName);

        if (className == "#32770") // Dialog
        {
          if (@event == (uint)WindowsEventHookType.EVENT_OBJECT_CREATE)
          {
            var windowText = "";
            var len = GetWindowTextLength(hWnd);
            if (len > 0)
            {
              var nMaxCount = len + 1;
              var lpString = stackalloc char[nMaxCount];
              if (GetWindowText(hWnd, lpString, nMaxCount) > 0)
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
  }
}
