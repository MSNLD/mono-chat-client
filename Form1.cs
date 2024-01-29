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
      AxMSNChatFrame axChatFrame = new AxMSNChatFrame();
      axChatFrame.OcxCreated += (sender, ocx) =>
      {
        ocx.BaseURL = "http://mono.chat/";
        ocx.NickName = "JDz";
        ocx.RoomName = "The Lobby";
        ocx.Server = "dir.irc7.com";
      };

      axChatFrame.Visible = true;
      axChatFrame.Dock = DockStyle.Fill;
      try
      {
        Controls.Add(axChatFrame);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }
  }
}
