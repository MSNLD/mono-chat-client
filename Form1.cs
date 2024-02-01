using AxMSNChat45;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace mono_chat_client
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    void SetTimeout(Action action, int ms)
    {
      Task.Delay(ms).ContinueWith((task) =>
      {
        action();
      }, TaskScheduler.FromCurrentSynchronizationContext());
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      try
      {
        AxMSNChatFrame axChatFrame = new AxMSNChatFrame();
        axChatFrame.OcxCreated += (sender, ocx) =>
        {
          sender.BaseURL = "http://mono.chat/";
          sender.NickName = "JD[mcc45]";
          sender.RoomName = "The Lobby";
          sender.Server = "dir.irc7.com";
          sender.AuditMessage = "For some reason MSN thought it would be cool to show off our IP address in MSN Chat 45... except it shows the Bind IP (%1) rather than the actual IP.";
          sender.MessageOfTheDay = "Mono Chat Client - MSN Chat 4.5";
        };
        axChatFrame.HandleCreated += (sender, e) =>
        {
          new TreeViewManager(treeView1, axChatFrame.Handle);
        };
        axChatFrame.Dock = DockStyle.Fill;
        splitContainer1.Panel2.Controls.Add(axChatFrame);
      }
      catch (System.IO.FileNotFoundException)
      {
        // MsnChat45.ocx is not found locally (SxS Assembly)
        MessageBox.Show("MsnChat45.ocx is missing.\nThis application will now close.");
        Close();
      }
      catch (COMException ex)
      {
        // Class not registered. We shouldn't really hit this if our manifests are doing their job.
        if (ex.ErrorCode == -2147221164)
          MessageBox.Show("MsnChat45.ocx is not installed\nThis application will now close.");
        else
          MessageBox.Show(ex.Message);
        Close();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
        Close();
      }
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Close();
    }
  }
}
