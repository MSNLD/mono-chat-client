using System.ComponentModel;
using System.Runtime.InteropServices;
using MSNChat42;

namespace AxMSNChat42
{
  [DesignTimeVisible(true)]
  [Clsid("{71b8f2df-0032-48ba-a784-93d9caaab07d}")]
  public class AxChatSettings : AxHost
  {
    private IChatSettings? ocx;

    [ComAliasName("System.UInt32")]
    [Browsable(true)]
    [DispId(-501)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public override Color BackColor
    {
      get
      {
        if (ocx != null && PropsValid())
        {
          return AxHost.GetColorFromOleColor(ocx.BackColor);
        }
        return base.BackColor;
      }
      set
      {
        base.BackColor = value;
        if (ocx != null)
        {
          ocx.BackColor = AxHost.GetOleColorFromColor(value);
        }
      }
    }

    [ComAliasName("System.UInt32")]
    [DispId(-513)]
    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public override Color ForeColor
    {
      get
      {
        if (ocx != null && PropsValid())
        {
          return AxHost.GetColorFromOleColor(ocx.ForeColor);
        }
        return base.ForeColor;
      }
      set
      {
        base.ForeColor = value;
        if (ocx != null)
        {
          ocx.ForeColor = AxHost.GetOleColorFromColor(value);
        }
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DispId(1)]
    public virtual string RedirectURL
    {
      get
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("RedirectURL", ActiveXInvokeKind.PropertyGet);
        }
        return ocx.RedirectURL;
      }
      set
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("RedirectURL", ActiveXInvokeKind.PropertySet);
        }
        ocx.RedirectURL = value;
      }
    }

    [DispId(2)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public virtual string ResDLL
    {
      get
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("ResDLL", ActiveXInvokeKind.PropertyGet);
        }
        return ocx.ResDLL;
      }
      set
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("ResDLL", ActiveXInvokeKind.PropertySet);
        }
        ocx.ResDLL = value;
      }
    }

    public AxChatSettings()
        : base("71b8f2df-0032-48ba-a784-93d9caaab07d")
    {
    }

    protected override void AttachInterfaces()
    {
      try
      {
        ocx = (IChatSettings)GetOcx();
        OcxCreated?.Invoke(this, ocx);
      }
      catch (Exception)
      {
      }
    }

    public delegate void OcxCreatedHandler(AxChatSettings sender, IChatSettings ocx);

    public event OcxCreatedHandler? OcxCreated;
  }

  [DesignTimeVisible(true)]
  [Clsid("{7a32634b-029c-4836-a023-528983982a49}")]
  public class AxMSNChatFrame : AxHost
  {
    private IChatFrame? ocx;

    [DispId(-501)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(true)]
    [ComAliasName("System.UInt32")]
    public override Color BackColor
    {
      get
      {
        if (ocx != null && PropsValid())
        {
          return AxHost.GetColorFromOleColor(ocx.BackColor);
        }
        return base.BackColor;
      }
      set
      {
        base.BackColor = value;
        if (ocx != null)
        {
          ocx.BackColor = AxHost.GetOleColorFromColor(value);
        }
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DispId(2)]
    public virtual string RoomName
    {
      get
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("RoomName", ActiveXInvokeKind.PropertyGet);
        }
        return ocx.RoomName;
      }
      set
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("RoomName", ActiveXInvokeKind.PropertySet);
        }
        ocx.RoomName = value;
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DispId(3)]
    public virtual string HexRoomName
    {
      get
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("HexRoomName", ActiveXInvokeKind.PropertyGet);
        }
        return ocx.HexRoomName;
      }
      set
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("HexRoomName", ActiveXInvokeKind.PropertySet);
        }
        ocx.HexRoomName = value;
      }
    }

    [DispId(4)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public virtual string NickName
    {
      get
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("NickName", ActiveXInvokeKind.PropertyGet);
        }
        return ocx.NickName;
      }
      set
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("NickName", ActiveXInvokeKind.PropertySet);
        }
        ocx.NickName = value;
      }
    }

    [DispId(5)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public virtual string Server
    {
      get
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("Server", ActiveXInvokeKind.PropertyGet);
        }
        return ocx.Server;
      }
      set
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("Server", ActiveXInvokeKind.PropertySet);
        }
        ocx.Server = value;
      }
    }

    [ComAliasName("System.UInt32")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DispId(6)]
    public virtual Color BackHighlightColor
    {
      get
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("BackHighlightColor", ActiveXInvokeKind.PropertyGet);
        }
        return AxHost.GetColorFromOleColor(ocx.BackHighlightColor);
      }
      set
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("BackHighlightColor", ActiveXInvokeKind.PropertySet);
        }
        ocx.BackHighlightColor = AxHost.GetOleColorFromColor(value);
      }
    }

    [ComAliasName("System.UInt32")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DispId(7)]
    public virtual Color ButtonFrameColor
    {
      get
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("ButtonFrameColor", ActiveXInvokeKind.PropertyGet);
        }
        return AxHost.GetColorFromOleColor(ocx.ButtonFrameColor);
      }
      set
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("ButtonFrameColor", ActiveXInvokeKind.PropertySet);
        }
        ocx.ButtonFrameColor = AxHost.GetOleColorFromColor(value);
      }
    }

    [ComAliasName("System.UInt32")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DispId(8)]
    public virtual Color TopBackHighlightColor
    {
      get
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("TopBackHighlightColor", ActiveXInvokeKind.PropertyGet);
        }
        return AxHost.GetColorFromOleColor(ocx.TopBackHighlightColor);
      }
      set
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("TopBackHighlightColor", ActiveXInvokeKind.PropertySet);
        }
        ocx.TopBackHighlightColor = AxHost.GetOleColorFromColor(value);
      }
    }

    [DispId(9)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public virtual int ChatMode
    {
      get
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("ChatMode", ActiveXInvokeKind.PropertyGet);
        }
        return ocx.ChatMode;
      }
      set
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("ChatMode", ActiveXInvokeKind.PropertySet);
        }
        ocx.ChatMode = value;
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DispId(10)]
    public virtual string URLBack
    {
      get
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("URLBack", ActiveXInvokeKind.PropertyGet);
        }
        return ocx.URLBack;
      }
      set
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("URLBack", ActiveXInvokeKind.PropertySet);
        }
        ocx.URLBack = value;
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DispId(11)]
    public virtual string Category
    {
      get
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("Category", ActiveXInvokeKind.PropertyGet);
        }
        return ocx.Category;
      }
      set
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("Category", ActiveXInvokeKind.PropertySet);
        }
        ocx.Category = value;
      }
    }

    [DispId(12)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public virtual string Topic
    {
      get
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("Topic", ActiveXInvokeKind.PropertyGet);
        }
        return ocx.Topic;
      }
      set
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("Topic", ActiveXInvokeKind.PropertySet);
        }
        ocx.Topic = value;
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DispId(13)]
    public virtual string WelcomeMsg
    {
      get
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("WelcomeMsg", ActiveXInvokeKind.PropertyGet);
        }
        return ocx.WelcomeMsg;
      }
      set
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("WelcomeMsg", ActiveXInvokeKind.PropertySet);
        }
        ocx.WelcomeMsg = value;
      }
    }

    [DispId(15)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public virtual string BaseURL
    {
      get
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("BaseURL", ActiveXInvokeKind.PropertyGet);
        }
        return ocx.BaseURL;
      }
      set
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("BaseURL", ActiveXInvokeKind.PropertySet);
        }
        ocx.BaseURL = value;
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [ComAliasName("System.UInt32")]
    [DispId(16)]
    public virtual Color InputBorderColor
    {
      get
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("InputBorderColor", ActiveXInvokeKind.PropertyGet);
        }
        return AxHost.GetColorFromOleColor(ocx.InputBorderColor);
      }
      set
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("InputBorderColor", ActiveXInvokeKind.PropertySet);
        }
        ocx.InputBorderColor = AxHost.GetOleColorFromColor(value);
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DispId(17)]
    public virtual string CreateRoom
    {
      get
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("CreateRoom", ActiveXInvokeKind.PropertyGet);
        }
        return ocx.CreateRoom;
      }
      set
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("CreateRoom", ActiveXInvokeKind.PropertySet);
        }
        ocx.CreateRoom = value;
      }
    }

    [DispId(19)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public virtual string ChatHome
    {
      get
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("ChatHome", ActiveXInvokeKind.PropertyGet);
        }
        return ocx.ChatHome;
      }
      set
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("ChatHome", ActiveXInvokeKind.PropertySet);
        }
        ocx.ChatHome = value;
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DispId(20)]
    public virtual string Locale
    {
      get
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("Locale", ActiveXInvokeKind.PropertyGet);
        }
        return ocx.Locale;
      }
      set
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("Locale", ActiveXInvokeKind.PropertySet);
        }
        ocx.Locale = value;
      }
    }

    [DispId(21)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public virtual string ResDLL
    {
      get
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("ResDLL", ActiveXInvokeKind.PropertyGet);
        }
        return ocx.ResDLL;
      }
      set
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("ResDLL", ActiveXInvokeKind.PropertySet);
        }
        ocx.ResDLL = value;
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DispId(22)]
    [ComAliasName("System.UInt32")]
    public virtual Color ButtonTextColor
    {
      get
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("ButtonTextColor", ActiveXInvokeKind.PropertyGet);
        }
        return AxHost.GetColorFromOleColor(ocx.ButtonTextColor);
      }
      set
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("ButtonTextColor", ActiveXInvokeKind.PropertySet);
        }
        ocx.ButtonTextColor = AxHost.GetOleColorFromColor(value);
      }
    }

    [DispId(23)]
    [ComAliasName("System.UInt32")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public virtual Color ButtonBackColor
    {
      get
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("ButtonBackColor", ActiveXInvokeKind.PropertyGet);
        }
        return AxHost.GetColorFromOleColor(ocx.ButtonBackColor);
      }
      set
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("ButtonBackColor", ActiveXInvokeKind.PropertySet);
        }
        ocx.ButtonBackColor = AxHost.GetOleColorFromColor(value);
      }
    }

    [DispId(24)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public virtual string PassportTicket
    {
      get
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("PassportTicket", ActiveXInvokeKind.PropertyGet);
        }
        return ocx.PassportTicket;
      }
      set
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("PassportTicket", ActiveXInvokeKind.PropertySet);
        }
        ocx.PassportTicket = value;
      }
    }

    [DispId(25)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public virtual string PassportProfile
    {
      get
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("PassportProfile", ActiveXInvokeKind.PropertyGet);
        }
        return ocx.PassportProfile;
      }
      set
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("PassportProfile", ActiveXInvokeKind.PropertySet);
        }
        ocx.PassportProfile = value;
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DispId(26)]
    public virtual uint Feature
    {
      get
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("Feature", ActiveXInvokeKind.PropertyGet);
        }
        return ocx.Feature;
      }
      set
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("Feature", ActiveXInvokeKind.PropertySet);
        }
        ocx.Feature = value;
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DispId(27)]
    public virtual string MessageOfTheDay
    {
      get
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("MessageOfTheDay", ActiveXInvokeKind.PropertyGet);
        }
        return ocx.MessageOfTheDay;
      }
      set
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("MessageOfTheDay", ActiveXInvokeKind.PropertySet);
        }
        ocx.MessageOfTheDay = value;
      }
    }

    [DispId(28)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public virtual string ChannelLanguage
    {
      get
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("ChannelLanguage", ActiveXInvokeKind.PropertyGet);
        }
        return ocx.ChannelLanguage;
      }
      set
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("ChannelLanguage", ActiveXInvokeKind.PropertySet);
        }
        ocx.ChannelLanguage = value;
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DispId(29)]
    public virtual string InvitationCode
    {
      get
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("InvitationCode", ActiveXInvokeKind.PropertyGet);
        }
        return ocx.InvitationCode;
      }
      set
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("InvitationCode", ActiveXInvokeKind.PropertySet);
        }
        ocx.InvitationCode = value;
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DispId(30)]
    public virtual string NicknameToInvite
    {
      get
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("NicknameToInvite", ActiveXInvokeKind.PropertyGet);
        }
        return ocx.NicknameToInvite;
      }
      set
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("NicknameToInvite", ActiveXInvokeKind.PropertySet);
        }
        ocx.NicknameToInvite = value;
      }
    }

    [DispId(31)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public virtual string MSNREGCookie
    {
      get
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("MSNREGCookie", ActiveXInvokeKind.PropertyGet);
        }
        return ocx.MSNREGCookie;
      }
      set
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("MSNREGCookie", ActiveXInvokeKind.PropertySet);
        }
        ocx.MSNREGCookie = value;
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DispId(32)]
    public virtual string CreationModes
    {
      get
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("CreationModes", ActiveXInvokeKind.PropertyGet);
        }
        return ocx.CreationModes;
      }
      set
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("CreationModes", ActiveXInvokeKind.PropertySet);
        }
        ocx.CreationModes = value;
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DispId(33)]
    public virtual string MSNProfile
    {
      get
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("MSNProfile", ActiveXInvokeKind.PropertyGet);
        }
        return ocx.MSNProfile;
      }
      set
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("MSNProfile", ActiveXInvokeKind.PropertySet);
        }
        ocx.MSNProfile = value;
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DispId(34)]
    public virtual string Market
    {
      get
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("Market", ActiveXInvokeKind.PropertyGet);
        }
        return ocx.Market;
      }
      set
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("Market", ActiveXInvokeKind.PropertySet);
        }
        ocx.Market = value;
      }
    }

    public AxMSNChatFrame()
        : base("7a32634b-029c-4836-a023-528983982a49")
    {
    }

    protected override void AttachInterfaces()
    {
      try
      {
        ocx = (IChatFrame)GetOcx();
        OcxCreated?.Invoke(this, ocx);
      }
      catch (Exception)
      {
      }
    }

    public delegate void OcxCreatedHandler(AxMSNChatFrame sender, IChatFrame ocx);

    public event OcxCreatedHandler? OcxCreated;
  }
}
