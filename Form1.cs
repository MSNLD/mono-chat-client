using mono_chat_client.MSNChat.AxMSNChat45;
using System.Net.Http.Json;
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

    public record class IPAddress(string? ip);
    private void Form1_Load(object sender, EventArgs e)
    {
      try
      {
        AxMSNChatFrame axChatFrame = new AxMSNChatFrame();
        axChatFrame.OcxCreated += async (sender, ocx) =>
        {
          sender.BaseURL = "http://mono.chat/";
          sender.NickName = "JD[mcc45]";
          sender.RoomName = "The Lobby";
          sender.Server = "dir.irc7.com";
          sender.AuditMessage = "MSN has detected that you are connected to this chat session from the IP address <B>%1</B>.";
          sender.MessageOfTheDay = "Mono Chat Client - MSN Chat 4.5";
          var x = new AwesomeHook();
          //var httpClient = new HttpClient();
          //IPAddress? ip = await httpClient.GetFromJsonAsync<IPAddress>("https://api64.ipify.org?format=json");
          //if (ip != null && !sender.IsDisposed) sender.AuditMessage = $"Mono.Chat has detected that you are connected to this chat session from the IP address <B>{ip.ip}</B><color #ffffff>(LAN IPv4=%1)</color>";
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
