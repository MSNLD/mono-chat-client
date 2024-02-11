using System.ComponentModel;
using System.Runtime.InteropServices;
using mono_chat_client.MSNChat.MSNChat10;

namespace mono_chat_client.MSNChat.AxMSNChat10
{
  [Clsid("{7944c497-34c7-11d3-b09c-00c04f612ff1}")]
  [DesignTimeVisible(true)]
  public class AxMSNChatFrame : AxHost
  {
    private IChatFrame? ocx;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DispId(-501)]
    [ComAliasName("System.UInt32")]
    [Browsable(true)]
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

    [DispId(2)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

    [DispId(3)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DispId(4)]
    public virtual string Nickname
    {
      get
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("Nickname", ActiveXInvokeKind.PropertyGet);
        }
        return ocx.Nickname;
      }
      set
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("Nickname", ActiveXInvokeKind.PropertySet);
        }
        ocx.Nickname = value;
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

    [DispId(11)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DispId(14)]
    public virtual int NickDate
    {
      get
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("NickDate", ActiveXInvokeKind.PropertyGet);
        }
        return ocx.NickDate;
      }
      set
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("NickDate", ActiveXInvokeKind.PropertySet);
        }
        ocx.NickDate = value;
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

    [DispId(18)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public virtual string MoreRooms
    {
      get
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("MoreRooms", ActiveXInvokeKind.PropertyGet);
        }
        return ocx.MoreRooms;
      }
      set
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("MoreRooms", ActiveXInvokeKind.PropertySet);
        }
        ocx.MoreRooms = value;
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

    [DispId(20)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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
    public virtual string ResLang
    {
      get
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("ResLang", ActiveXInvokeKind.PropertyGet);
        }
        return ocx.ResLang;
      }
      set
      {
        if (ocx == null)
        {
          throw new InvalidActiveXStateException("ResLang", ActiveXInvokeKind.PropertySet);
        }
        ocx.ResLang = value;
      }
    }

    [ComAliasName("System.UInt32")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DispId(22)]
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

    [ComAliasName("System.UInt32")]
    [DispId(23)]
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

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DispId(24)]
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

    [DispId(26)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

    public AxMSNChatFrame()
        : base("7944c497-34c7-11d3-b09c-00c04f612ff1")
    {
    }

    public virtual void Connect()
    {
      if (ocx == null)
      {
        throw new InvalidActiveXStateException("Connect", ActiveXInvokeKind.MethodInvoke);
      }
      ocx.Connect();
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
