using AxMSNChat;

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
        axChatFrame.OcxCreated += (ocx) =>
        {
          ocx.BaseURL = "http://mono.chat/";
          ocx.NickName = "JDz";
          ocx.RoomName = "The Lobby";
          ocx.Server = "dir.irc7.com";
        };

        axChatFrame.Visible = true;
        axChatFrame.Dock = DockStyle.Fill;
        Controls.Add(axChatFrame);
      }
      catch (System.IO.FileNotFoundException) // OCX can be installed, or found locally.
      {
        MessageBox.Show("MsnChat45.ocx is missing.\nThis application will now close.");
        Close();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }
  }
}
