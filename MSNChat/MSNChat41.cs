using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mono_chat_client.MSNChat.MSNChat41
{
  [ComImport]
  [InterfaceType(2)]
  [TypeLibType(4096)]
  [Guid("F9D2FF9E-A674-454B-A562-E9A768B09AEF")]
  public interface _ICChatFrameEvents
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [DispId(1)]
    void OnRedirect([In][MarshalAs(UnmanagedType.BStr)] string strUrl);
  }

  [ComImport]
  [CoClass(typeof(ChatSettingsClass))]
  [Guid("2E3B2173-25A5-4E71-9F3C-AA3BE618A11C")]
  public interface ChatSettings : IChatSettings
  {
  }

  [ComImport]
  [ClassInterface(ClassInterfaceType.None)]
  [TypeLibType(2)]
  [Guid("9088E688-063A-4806-A3DB-6522712FC061")]
  public class ChatSettingsClass : IChatSettings, ChatSettings
  {
    [ComAliasName("stdole.OLE_COLOR")]
    [DispId(-501)]
    public virtual extern uint BackColor
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(-501)]
      [return: ComAliasName("stdole.OLE_COLOR")]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(-501)]
      [param: In]
      [param: ComAliasName("stdole.OLE_COLOR")]
      set;
    }

    [ComAliasName("stdole.OLE_COLOR")]
    [DispId(-513)]
    public virtual extern uint ForeColor
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(-513)]
      [return: ComAliasName("stdole.OLE_COLOR")]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(-513)]
      [param: In]
      [param: ComAliasName("stdole.OLE_COLOR")]
      set;
    }

    [DispId(1)]
    public virtual extern string RedirectURL
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(1)]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(1)]
      [param: In]
      [param: MarshalAs(UnmanagedType.BStr)]
      set;
    }

    [DispId(2)]
    public virtual extern string ResDLL
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(2)]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(2)]
      [param: In]
      [param: MarshalAs(UnmanagedType.BStr)]
      set;
    }
  }

  [ComImport]
  [Guid("1B27FF4F-7222-4F64-A431-CD5A163BDE30")]
  [TypeLibType(4160)]
  public interface IChatFrame
  {
    [ComAliasName("stdole.OLE_COLOR")]
    [DispId(-501)]
    uint BackColor
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(-501)]
      [return: ComAliasName("stdole.OLE_COLOR")]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(-501)]
      [param: In]
      [param: ComAliasName("stdole.OLE_COLOR")]
      set;
    }

    [DispId(2)]
    string RoomName
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(2)]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(2)]
      [param: In]
      [param: MarshalAs(UnmanagedType.BStr)]
      set;
    }

    [DispId(3)]
    string HexRoomName
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(3)]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(3)]
      [param: In]
      [param: MarshalAs(UnmanagedType.BStr)]
      set;
    }

    [DispId(4)]
    string NickName
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(4)]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(4)]
      [param: In]
      [param: MarshalAs(UnmanagedType.BStr)]
      set;
    }

    [DispId(5)]
    string Server
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(5)]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(5)]
      [param: In]
      [param: MarshalAs(UnmanagedType.BStr)]
      set;
    }

    [DispId(6)]
    [ComAliasName("stdole.OLE_COLOR")]
    uint BackHighlightColor
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(6)]
      [return: ComAliasName("stdole.OLE_COLOR")]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(6)]
      [param: In]
      [param: ComAliasName("stdole.OLE_COLOR")]
      set;
    }

    [ComAliasName("stdole.OLE_COLOR")]
    [DispId(7)]
    uint ButtonFrameColor
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(7)]
      [return: ComAliasName("stdole.OLE_COLOR")]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(7)]
      [param: In]
      [param: ComAliasName("stdole.OLE_COLOR")]
      set;
    }

    [DispId(8)]
    [ComAliasName("stdole.OLE_COLOR")]
    uint TopBackHighlightColor
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(8)]
      [return: ComAliasName("stdole.OLE_COLOR")]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(8)]
      [param: In]
      [param: ComAliasName("stdole.OLE_COLOR")]
      set;
    }

    [DispId(9)]
    int ChatMode
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(9)]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(9)]
      [param: In]
      set;
    }

    [DispId(10)]
    string URLBack
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(10)]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(10)]
      [param: In]
      [param: MarshalAs(UnmanagedType.BStr)]
      set;
    }

    [DispId(11)]
    string Category
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(11)]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(11)]
      [param: In]
      [param: MarshalAs(UnmanagedType.BStr)]
      set;
    }

    [DispId(12)]
    string Topic
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(12)]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(12)]
      [param: In]
      [param: MarshalAs(UnmanagedType.BStr)]
      set;
    }

    [DispId(13)]
    string WelcomeMsg
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(13)]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(13)]
      [param: In]
      [param: MarshalAs(UnmanagedType.BStr)]
      set;
    }

    [DispId(15)]
    string BaseURL
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(15)]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(15)]
      [param: In]
      [param: MarshalAs(UnmanagedType.BStr)]
      set;
    }

    [ComAliasName("stdole.OLE_COLOR")]
    [DispId(16)]
    uint InputBorderColor
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(16)]
      [return: ComAliasName("stdole.OLE_COLOR")]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(16)]
      [param: In]
      [param: ComAliasName("stdole.OLE_COLOR")]
      set;
    }

    [DispId(17)]
    string CreateRoom
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(17)]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(17)]
      [param: In]
      [param: MarshalAs(UnmanagedType.BStr)]
      set;
    }

    [DispId(19)]
    string ChatHome
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(19)]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(19)]
      [param: In]
      [param: MarshalAs(UnmanagedType.BStr)]
      set;
    }

    [DispId(20)]
    string Locale
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(20)]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(20)]
      [param: In]
      [param: MarshalAs(UnmanagedType.BStr)]
      set;
    }

    [DispId(21)]
    string ResDLL
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(21)]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(21)]
      [param: In]
      [param: MarshalAs(UnmanagedType.BStr)]
      set;
    }

    [ComAliasName("stdole.OLE_COLOR")]
    [DispId(22)]
    uint ButtonTextColor
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(22)]
      [return: ComAliasName("stdole.OLE_COLOR")]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(22)]
      [param: In]
      [param: ComAliasName("stdole.OLE_COLOR")]
      set;
    }

    [ComAliasName("stdole.OLE_COLOR")]
    [DispId(23)]
    uint ButtonBackColor
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(23)]
      [return: ComAliasName("stdole.OLE_COLOR")]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(23)]
      [param: In]
      [param: ComAliasName("stdole.OLE_COLOR")]
      set;
    }

    [DispId(24)]
    string PassportTicket
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(24)]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(24)]
      [param: In]
      [param: MarshalAs(UnmanagedType.BStr)]
      set;
    }

    [DispId(25)]
    string PassportProfile
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(25)]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(25)]
      [param: In]
      [param: MarshalAs(UnmanagedType.BStr)]
      set;
    }

    [DispId(26)]
    uint Feature
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(26)]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(26)]
      [param: In]
      set;
    }

    [DispId(27)]
    string MessageOfTheDay
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(27)]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(27)]
      [param: In]
      [param: MarshalAs(UnmanagedType.BStr)]
      set;
    }

    [DispId(28)]
    string ChannelLanguage
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(28)]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(28)]
      [param: In]
      [param: MarshalAs(UnmanagedType.BStr)]
      set;
    }

    [DispId(29)]
    string InvitationCode
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(29)]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(29)]
      [param: In]
      [param: MarshalAs(UnmanagedType.BStr)]
      set;
    }

    [DispId(30)]
    string NicknameToInvite
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(30)]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(30)]
      [param: In]
      [param: MarshalAs(UnmanagedType.BStr)]
      set;
    }

    [DispId(31)]
    string MSNREGCookie
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(31)]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(31)]
      [param: In]
      [param: MarshalAs(UnmanagedType.BStr)]
      set;
    }

    [DispId(32)]
    int radioID
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(32)]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(32)]
      [param: In]
      set;
    }

    [DispId(33)]
    string CreationModes
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(33)]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(33)]
      [param: In]
      [param: MarshalAs(UnmanagedType.BStr)]
      set;
    }

    [DispId(34)]
    string MSNProfile
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(34)]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(34)]
      [param: In]
      [param: MarshalAs(UnmanagedType.BStr)]
      set;
    }
  }

  [ComImport]
  [Guid("2E3B2173-25A5-4E71-9F3C-AA3BE618A11C")]
  [TypeLibType(4160)]
  public interface IChatSettings
  {
    [DispId(-501)]
    [ComAliasName("stdole.OLE_COLOR")]
    uint BackColor
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(-501)]
      [return: ComAliasName("stdole.OLE_COLOR")]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(-501)]
      [param: In]
      [param: ComAliasName("stdole.OLE_COLOR")]
      set;
    }

    [DispId(-513)]
    [ComAliasName("stdole.OLE_COLOR")]
    uint ForeColor
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(-513)]
      [return: ComAliasName("stdole.OLE_COLOR")]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(-513)]
      [param: In]
      [param: ComAliasName("stdole.OLE_COLOR")]
      set;
    }

    [DispId(1)]
    string RedirectURL
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(1)]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(1)]
      [param: In]
      [param: MarshalAs(UnmanagedType.BStr)]
      set;
    }

    [DispId(2)]
    string ResDLL
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(2)]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(2)]
      [param: In]
      [param: MarshalAs(UnmanagedType.BStr)]
      set;
    }
  }

  [ComImport]
  [Guid("1B27FF4F-7222-4F64-A431-CD5A163BDE30")]
  [CoClass(typeof(MSNChatFrameClass))]
  public interface MSNChatFrame : IChatFrame
  {
  }

  [ComImport]
  [Guid("29C13B62-B9F7-4CD3-8CEF-0A58A1A99441")]
  [ClassInterface(ClassInterfaceType.None)]
  [TypeLibType(2)]
  public class MSNChatFrameClass : IChatFrame, MSNChatFrame
  {
    [DispId(-501)]
    [ComAliasName("stdole.OLE_COLOR")]
    public virtual extern uint BackColor
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(-501)]
      [return: ComAliasName("stdole.OLE_COLOR")]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(-501)]
      [param: In]
      [param: ComAliasName("stdole.OLE_COLOR")]
      set;
    }

    [DispId(2)]
    public virtual extern string RoomName
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(2)]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(2)]
      [param: In]
      [param: MarshalAs(UnmanagedType.BStr)]
      set;
    }

    [DispId(3)]
    public virtual extern string HexRoomName
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(3)]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(3)]
      [param: In]
      [param: MarshalAs(UnmanagedType.BStr)]
      set;
    }

    [DispId(4)]
    public virtual extern string NickName
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(4)]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(4)]
      [param: In]
      [param: MarshalAs(UnmanagedType.BStr)]
      set;
    }

    [DispId(5)]
    public virtual extern string Server
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(5)]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(5)]
      [param: In]
      [param: MarshalAs(UnmanagedType.BStr)]
      set;
    }

    [DispId(6)]
    [ComAliasName("stdole.OLE_COLOR")]
    public virtual extern uint BackHighlightColor
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(6)]
      [return: ComAliasName("stdole.OLE_COLOR")]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(6)]
      [param: In]
      [param: ComAliasName("stdole.OLE_COLOR")]
      set;
    }

    [ComAliasName("stdole.OLE_COLOR")]
    [DispId(7)]
    public virtual extern uint ButtonFrameColor
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(7)]
      [return: ComAliasName("stdole.OLE_COLOR")]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(7)]
      [param: In]
      [param: ComAliasName("stdole.OLE_COLOR")]
      set;
    }

    [DispId(8)]
    [ComAliasName("stdole.OLE_COLOR")]
    public virtual extern uint TopBackHighlightColor
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(8)]
      [return: ComAliasName("stdole.OLE_COLOR")]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(8)]
      [param: In]
      [param: ComAliasName("stdole.OLE_COLOR")]
      set;
    }

    [DispId(9)]
    public virtual extern int ChatMode
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(9)]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(9)]
      [param: In]
      set;
    }

    [DispId(10)]
    public virtual extern string URLBack
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(10)]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(10)]
      [param: In]
      [param: MarshalAs(UnmanagedType.BStr)]
      set;
    }

    [DispId(11)]
    public virtual extern string Category
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(11)]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(11)]
      [param: In]
      [param: MarshalAs(UnmanagedType.BStr)]
      set;
    }

    [DispId(12)]
    public virtual extern string Topic
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(12)]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(12)]
      [param: In]
      [param: MarshalAs(UnmanagedType.BStr)]
      set;
    }

    [DispId(13)]
    public virtual extern string WelcomeMsg
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(13)]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(13)]
      [param: In]
      [param: MarshalAs(UnmanagedType.BStr)]
      set;
    }

    [DispId(15)]
    public virtual extern string BaseURL
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(15)]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(15)]
      [param: In]
      [param: MarshalAs(UnmanagedType.BStr)]
      set;
    }

    [DispId(16)]
    [ComAliasName("stdole.OLE_COLOR")]
    public virtual extern uint InputBorderColor
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(16)]
      [return: ComAliasName("stdole.OLE_COLOR")]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(16)]
      [param: In]
      [param: ComAliasName("stdole.OLE_COLOR")]
      set;
    }

    [DispId(17)]
    public virtual extern string CreateRoom
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(17)]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(17)]
      [param: In]
      [param: MarshalAs(UnmanagedType.BStr)]
      set;
    }

    [DispId(19)]
    public virtual extern string ChatHome
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(19)]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(19)]
      [param: In]
      [param: MarshalAs(UnmanagedType.BStr)]
      set;
    }

    [DispId(20)]
    public virtual extern string Locale
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(20)]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(20)]
      [param: In]
      [param: MarshalAs(UnmanagedType.BStr)]
      set;
    }

    [DispId(21)]
    public virtual extern string ResDLL
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(21)]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(21)]
      [param: In]
      [param: MarshalAs(UnmanagedType.BStr)]
      set;
    }

    [DispId(22)]
    [ComAliasName("stdole.OLE_COLOR")]
    public virtual extern uint ButtonTextColor
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(22)]
      [return: ComAliasName("stdole.OLE_COLOR")]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(22)]
      [param: In]
      [param: ComAliasName("stdole.OLE_COLOR")]
      set;
    }

    [ComAliasName("stdole.OLE_COLOR")]
    [DispId(23)]
    public virtual extern uint ButtonBackColor
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(23)]
      [return: ComAliasName("stdole.OLE_COLOR")]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(23)]
      [param: In]
      [param: ComAliasName("stdole.OLE_COLOR")]
      set;
    }

    [DispId(24)]
    public virtual extern string PassportTicket
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(24)]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(24)]
      [param: In]
      [param: MarshalAs(UnmanagedType.BStr)]
      set;
    }

    [DispId(25)]
    public virtual extern string PassportProfile
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(25)]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(25)]
      [param: In]
      [param: MarshalAs(UnmanagedType.BStr)]
      set;
    }

    [DispId(26)]
    public virtual extern uint Feature
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(26)]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(26)]
      [param: In]
      set;
    }

    [DispId(27)]
    public virtual extern string MessageOfTheDay
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(27)]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(27)]
      [param: In]
      [param: MarshalAs(UnmanagedType.BStr)]
      set;
    }

    [DispId(28)]
    public virtual extern string ChannelLanguage
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(28)]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(28)]
      [param: In]
      [param: MarshalAs(UnmanagedType.BStr)]
      set;
    }

    [DispId(29)]
    public virtual extern string InvitationCode
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(29)]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(29)]
      [param: In]
      [param: MarshalAs(UnmanagedType.BStr)]
      set;
    }

    [DispId(30)]
    public virtual extern string NicknameToInvite
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(30)]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(30)]
      [param: In]
      [param: MarshalAs(UnmanagedType.BStr)]
      set;
    }

    [DispId(31)]
    public virtual extern string MSNREGCookie
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(31)]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(31)]
      [param: In]
      [param: MarshalAs(UnmanagedType.BStr)]
      set;
    }

    [DispId(32)]
    public virtual extern int radioID
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(32)]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(32)]
      [param: In]
      set;
    }

    [DispId(33)]
    public virtual extern string CreationModes
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(33)]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(33)]
      [param: In]
      [param: MarshalAs(UnmanagedType.BStr)]
      set;
    }

    [DispId(34)]
    public virtual extern string MSNProfile
    {
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(34)]
      [return: MarshalAs(UnmanagedType.BStr)]
      get;
      [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
      [DispId(34)]
      [param: In]
      [param: MarshalAs(UnmanagedType.BStr)]
      set;
    }
  }
}
