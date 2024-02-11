using System.ComponentModel;
using System.Runtime.InteropServices;
using mono_chat_client.MSNChat.MSNChat30;

namespace mono_chat_client.MSNChat.AxMSNChat30
{
    [Clsid("{81361155-faf9-11d3-b0d3-00c04f612ff1}")]
    [DesignTimeVisible(true)]
    public class AxMSNChatFrame : AxHost
    {
        private IChatFrame? ocx;

        [ComAliasName("System.UInt32")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(true)]
        [DispId(-501)]
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

        [ComAliasName("System.UInt32")]
        [DispId(6)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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
        [DispId(7)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

        [DispId(10)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [DispId(12)]
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

        [DispId(13)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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
        public virtual string URLFindUser
        {
            get
            {
                if (ocx == null)
                {
                    throw new InvalidActiveXStateException("URLFindUser", ActiveXInvokeKind.PropertyGet);
                }
                return ocx.URLFindUser;
            }
            set
            {
                if (ocx == null)
                {
                    throw new InvalidActiveXStateException("URLFindUser", ActiveXInvokeKind.PropertySet);
                }
                ocx.URLFindUser = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [DispId(19)]
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

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [DispId(21)]
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

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [ComAliasName("System.UInt32")]
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

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [ComAliasName("System.UInt32")]
        [DispId(23)]
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

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [DispId(25)]
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

        [DispId(27)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

        [DispId(30)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

        [DispId(32)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public virtual int radioID
        {
            get
            {
                if (ocx == null)
                {
                    throw new InvalidActiveXStateException("radioID", ActiveXInvokeKind.PropertyGet);
                }
                return ocx.radioID;
            }
            set
            {
                if (ocx == null)
                {
                    throw new InvalidActiveXStateException("radioID", ActiveXInvokeKind.PropertySet);
                }
                ocx.radioID = value;
            }
        }

        public AxMSNChatFrame()
            : base("81361155-faf9-11d3-b0d3-00c04f612ff1")
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
