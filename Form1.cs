using AxMSNChat;
using System.Runtime.InteropServices;

namespace mono_chat_client
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      try
      {
        AxMSNChatFrame axChatFrame = new AxMSNChatFrame();
        axChatFrame.OcxCreated += (sender, ocx) =>
        {
          sender.BaseURL = "http://mono.chat/";
          sender.NickName = "JD[mcc]";
          sender.RoomName = "The Lobby";
          sender.Server = "dir.irc7.com";
          //sender.BackColor = Color.Green;
        };

        axChatFrame.Dock = DockStyle.Fill;
        Controls.Add(axChatFrame);
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
  }
}
