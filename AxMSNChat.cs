#region Assembly AxMSNChat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Users\jd\Projects\MSNLD\mono-chat-client\AxMSNChat.dll
// Decompiled with ICSharpCode.Decompiler 8.1.1.7464
#endregion

using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MSNChat;

namespace AxMSNChat;

[DesignTimeVisible(true)]
[Clsid("{f58e1cef-a068-4c15-ba5e-587caf3ee8c6}")]
public class AxMSNChatFrame : AxHost
{
  private IChatFrame ocx;

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

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [DispId(5)]
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

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [DispId(6)]
  [ComAliasName("System.UInt32")]
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

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [ComAliasName("System.UInt32")]
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
  [DispId(15)]
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

  [DispId(16)]
  [ComAliasName("System.UInt32")]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [DispId(21)]
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

  [DispId(23)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [ComAliasName("System.UInt32")]
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

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [DispId(28)]
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

  [DispId(33)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

  [DispId(34)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

  [DispId(35)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public virtual string WhisperContent
  {
    get
    {
      if (ocx == null)
      {
        throw new InvalidActiveXStateException("WhisperContent", ActiveXInvokeKind.PropertyGet);
      }

      return ocx.WhisperContent;
    }
    set
    {
      if (ocx == null)
      {
        throw new InvalidActiveXStateException("WhisperContent", ActiveXInvokeKind.PropertySet);
      }

      ocx.WhisperContent = value;
    }
  }

  [DispId(36)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public virtual string UserRole
  {
    get
    {
      if (ocx == null)
      {
        throw new InvalidActiveXStateException("UserRole", ActiveXInvokeKind.PropertyGet);
      }

      return ocx.UserRole;
    }
    set
    {
      if (ocx == null)
      {
        throw new InvalidActiveXStateException("UserRole", ActiveXInvokeKind.PropertySet);
      }

      ocx.UserRole = value;
    }
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [DispId(37)]
  public virtual string AuditMessage
  {
    get
    {
      if (ocx == null)
      {
        throw new InvalidActiveXStateException("AuditMessage", ActiveXInvokeKind.PropertyGet);
      }

      return ocx.AuditMessage;
    }
    set
    {
      if (ocx == null)
      {
        throw new InvalidActiveXStateException("AuditMessage", ActiveXInvokeKind.PropertySet);
      }

      ocx.AuditMessage = value;
    }
  }

  [DispId(38)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public virtual string SubscriberInfo
  {
    get
    {
      if (ocx == null)
      {
        throw new InvalidActiveXStateException("SubscriberInfo", ActiveXInvokeKind.PropertyGet);
      }

      return ocx.SubscriberInfo;
    }
    set
    {
      if (ocx == null)
      {
        throw new InvalidActiveXStateException("SubscriberInfo", ActiveXInvokeKind.PropertySet);
      }

      ocx.SubscriberInfo = value;
    }
  }

  [DispId(39)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public virtual string UpsellURL
  {
    get
    {
      if (ocx == null)
      {
        throw new InvalidActiveXStateException("UpsellURL", ActiveXInvokeKind.PropertyGet);
      }

      return ocx.UpsellURL;
    }
    set
    {
      if (ocx == null)
      {
        throw new InvalidActiveXStateException("UpsellURL", ActiveXInvokeKind.PropertySet);
      }

      ocx.UpsellURL = value;
    }
  }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
  public AxMSNChatFrame()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
      : base("f58e1cef-a068-4c15-ba5e-587caf3ee8c6")
  {
  }

  protected override void AttachInterfaces()
  {
    //IL_0007: Unknown result type (might be due to invalid IL or missing references)
    //IL_0011: Expected O, but got Unknown
    try
    {
      ocx = (IChatFrame)GetOcx();
      // We need to set our params before the ChatFrame is added to the form, so we use a (synchronous) callback to do so.
      OcxCreated?.Invoke(this, ocx);
    }
    catch (Exception)
    {
    }
  }

  public delegate void OcxCreatedHandler(object sender, IChatFrame ocx);

  public event OcxCreatedHandler OcxCreated;
}
#if false // Decompilation log
'188' items in cache
------------------
Resolve: 'System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Found single assembly: 'System.Windows.Forms, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
WARN: Version mismatch. Expected: '4.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.WindowsDesktop.App.Ref\8.0.1\ref\net8.0\System.Windows.Forms.dll'
------------------
Resolve: 'MSNChat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'
Could not find by name: 'MSNChat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'
------------------
Resolve: 'System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Drawing, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '4.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.WindowsDesktop.App.Ref\8.0.1\ref\net8.0\System.Drawing.dll'
------------------
Resolve: 'mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Found single assembly: 'mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\mscorlib.dll'
------------------
Resolve: 'System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Found single assembly: 'System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.dll'
------------------
Resolve: 'System.Windows.Forms.Primitives, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Found single assembly: 'System.Windows.Forms.Primitives, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.WindowsDesktop.App.Ref\8.0.1\ref\net8.0\System.Windows.Forms.Primitives.dll'
------------------
Resolve: 'System.Drawing.Common, Version=8.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Found single assembly: 'System.Drawing.Common, Version=8.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.WindowsDesktop.App.Ref\8.0.1\ref\net8.0\System.Drawing.Common.dll'
------------------
Resolve: 'System.Drawing.Primitives, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Drawing.Primitives, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.Drawing.Primitives.dll'
------------------
Resolve: 'System.ComponentModel.TypeConverter, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.ComponentModel.TypeConverter, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.ComponentModel.TypeConverter.dll'
------------------
Resolve: 'System.Configuration.ConfigurationManager, Version=8.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Found single assembly: 'System.Configuration.ConfigurationManager, Version=8.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.WindowsDesktop.App.Ref\8.0.1\ref\net8.0\System.Configuration.ConfigurationManager.dll'
------------------
Resolve: 'System.Windows.Forms, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Found single assembly: 'System.Windows.Forms, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.WindowsDesktop.App.Ref\8.0.1\ref\net8.0\System.Windows.Forms.dll'
------------------
Resolve: 'System.Windows.Forms.Design, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Found single assembly: 'System.Windows.Forms.Design, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.WindowsDesktop.App.Ref\8.0.1\ref\net8.0\System.Windows.Forms.Design.dll'
------------------
Resolve: 'Microsoft.Win32.Registry, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'Microsoft.Win32.Registry, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\Microsoft.Win32.Registry.dll'
------------------
Resolve: 'System.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Runtime, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.Runtime.dll'
------------------
Resolve: 'System.Security.Principal.Windows, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Security.Principal.Windows, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.Security.Principal.Windows.dll'
------------------
Resolve: 'System.Security.Permissions, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Found single assembly: 'System.Security.Permissions, Version=8.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.WindowsDesktop.App.Ref\8.0.1\ref\net8.0\System.Security.Permissions.dll'
------------------
Resolve: 'System.Collections, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Collections, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.Collections.dll'
------------------
Resolve: 'System.Collections.NonGeneric, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Collections.NonGeneric, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.Collections.NonGeneric.dll'
------------------
Resolve: 'System.Collections.Concurrent, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Collections.Concurrent, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.Collections.Concurrent.dll'
------------------
Resolve: 'System.ObjectModel, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.ObjectModel, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.ObjectModel.dll'
------------------
Resolve: 'System.Console, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Console, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.Console.dll'
------------------
Resolve: 'System.Runtime.InteropServices, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Runtime.InteropServices, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.Runtime.InteropServices.dll'
------------------
Resolve: 'System.Diagnostics.Contracts, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Diagnostics.Contracts, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.Diagnostics.Contracts.dll'
------------------
Resolve: 'System.Diagnostics.StackTrace, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Diagnostics.StackTrace, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.Diagnostics.StackTrace.dll'
------------------
Resolve: 'System.Diagnostics.Tracing, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Diagnostics.Tracing, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.Diagnostics.Tracing.dll'
------------------
Resolve: 'System.IO.FileSystem.DriveInfo, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.IO.FileSystem.DriveInfo, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.IO.FileSystem.DriveInfo.dll'
------------------
Resolve: 'System.IO.IsolatedStorage, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.IO.IsolatedStorage, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.IO.IsolatedStorage.dll'
------------------
Resolve: 'System.ComponentModel, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.ComponentModel, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.ComponentModel.dll'
------------------
Resolve: 'System.Threading.Thread, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Threading.Thread, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.Threading.Thread.dll'
------------------
Resolve: 'System.Reflection.Emit, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Reflection.Emit, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.Reflection.Emit.dll'
------------------
Resolve: 'System.Reflection.Emit.ILGeneration, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Reflection.Emit.ILGeneration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.Reflection.Emit.ILGeneration.dll'
------------------
Resolve: 'System.Reflection.Emit.Lightweight, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Reflection.Emit.Lightweight, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.Reflection.Emit.Lightweight.dll'
------------------
Resolve: 'System.Reflection.Primitives, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Reflection.Primitives, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.Reflection.Primitives.dll'
------------------
Resolve: 'System.Resources.Writer, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Resources.Writer, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.Resources.Writer.dll'
------------------
Resolve: 'System.Runtime.CompilerServices.VisualC, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Runtime.CompilerServices.VisualC, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.Runtime.CompilerServices.VisualC.dll'
------------------
Resolve: 'System.Runtime.Serialization.Formatters, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Runtime.Serialization.Formatters, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.Runtime.Serialization.Formatters.dll'
------------------
Resolve: 'System.Security.AccessControl, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Security.AccessControl, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.Security.AccessControl.dll'
------------------
Resolve: 'System.IO.FileSystem.AccessControl, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.IO.FileSystem.AccessControl, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.IO.FileSystem.AccessControl.dll'
------------------
Resolve: 'System.Threading.AccessControl, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Threading.AccessControl, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.WindowsDesktop.App.Ref\8.0.1\ref\net8.0\System.Threading.AccessControl.dll'
------------------
Resolve: 'System.Security.Claims, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Security.Claims, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.Security.Claims.dll'
------------------
Resolve: 'System.Security.Cryptography, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Security.Cryptography, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.Security.Cryptography.dll'
------------------
Resolve: 'System.Text.Encoding.Extensions, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Text.Encoding.Extensions, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.Text.Encoding.Extensions.dll'
------------------
Resolve: 'System.Threading, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Threading, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.Threading.dll'
------------------
Resolve: 'System.Threading.Overlapped, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Threading.Overlapped, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.Threading.Overlapped.dll'
------------------
Resolve: 'System.Threading.ThreadPool, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Threading.ThreadPool, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.Threading.ThreadPool.dll'
------------------
Resolve: 'System.Threading.Tasks.Parallel, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Threading.Tasks.Parallel, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.Threading.Tasks.Parallel.dll'
------------------
Resolve: 'System.CodeDom, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Found single assembly: 'System.CodeDom, Version=8.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.WindowsDesktop.App.Ref\8.0.1\ref\net8.0\System.CodeDom.dll'
------------------
Resolve: 'Microsoft.Win32.SystemEvents, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Found single assembly: 'Microsoft.Win32.SystemEvents, Version=8.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.WindowsDesktop.App.Ref\8.0.1\ref\net8.0\Microsoft.Win32.SystemEvents.dll'
------------------
Resolve: 'System.Diagnostics.Process, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Diagnostics.Process, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.Diagnostics.Process.dll'
------------------
Resolve: 'System.Collections.Specialized, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Collections.Specialized, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.Collections.Specialized.dll'
------------------
Resolve: 'System.ComponentModel.TypeConverter, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.ComponentModel.TypeConverter, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.ComponentModel.TypeConverter.dll'
------------------
Resolve: 'System.ComponentModel.EventBasedAsync, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.ComponentModel.EventBasedAsync, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.ComponentModel.EventBasedAsync.dll'
------------------
Resolve: 'System.ComponentModel.Primitives, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.ComponentModel.Primitives, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.ComponentModel.Primitives.dll'
------------------
Resolve: 'Microsoft.Win32.Primitives, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'Microsoft.Win32.Primitives, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\Microsoft.Win32.Primitives.dll'
------------------
Resolve: 'System.Configuration.ConfigurationManager, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Found single assembly: 'System.Configuration.ConfigurationManager, Version=8.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.WindowsDesktop.App.Ref\8.0.1\ref\net8.0\System.Configuration.ConfigurationManager.dll'
------------------
Resolve: 'System.Diagnostics.TraceSource, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Diagnostics.TraceSource, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.Diagnostics.TraceSource.dll'
------------------
Resolve: 'System.Diagnostics.TextWriterTraceListener, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Diagnostics.TextWriterTraceListener, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.Diagnostics.TextWriterTraceListener.dll'
------------------
Resolve: 'System.Diagnostics.PerformanceCounter, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Found single assembly: 'System.Diagnostics.PerformanceCounter, Version=8.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.WindowsDesktop.App.Ref\8.0.1\ref\net8.0\System.Diagnostics.PerformanceCounter.dll'
------------------
Resolve: 'System.Diagnostics.EventLog, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Found single assembly: 'System.Diagnostics.EventLog, Version=8.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.WindowsDesktop.App.Ref\8.0.1\ref\net8.0\System.Diagnostics.EventLog.dll'
------------------
Resolve: 'System.Diagnostics.FileVersionInfo, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Diagnostics.FileVersionInfo, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.Diagnostics.FileVersionInfo.dll'
------------------
Resolve: 'System.IO.Compression, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Found single assembly: 'System.IO.Compression, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.IO.Compression.dll'
------------------
Resolve: 'System.IO.FileSystem.Watcher, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.IO.FileSystem.Watcher, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.IO.FileSystem.Watcher.dll'
------------------
Resolve: 'System.IO.Ports, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Could not find by name: 'System.IO.Ports, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
------------------
Resolve: 'System.Windows.Extensions, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Found single assembly: 'System.Windows.Extensions, Version=8.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.WindowsDesktop.App.Ref\8.0.1\ref\net8.0\System.Windows.Extensions.dll'
------------------
Resolve: 'System.Net.Requests, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Net.Requests, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.Net.Requests.dll'
------------------
Resolve: 'System.Net.Primitives, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Net.Primitives, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.Net.Primitives.dll'
------------------
Resolve: 'System.Net.HttpListener, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Found single assembly: 'System.Net.HttpListener, Version=8.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.Net.HttpListener.dll'
------------------
Resolve: 'System.Net.ServicePoint, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Found single assembly: 'System.Net.ServicePoint, Version=8.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.Net.ServicePoint.dll'
------------------
Resolve: 'System.Net.NameResolution, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Net.NameResolution, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.Net.NameResolution.dll'
------------------
Resolve: 'System.Net.WebClient, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Found single assembly: 'System.Net.WebClient, Version=8.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.Net.WebClient.dll'
------------------
Resolve: 'System.Net.WebHeaderCollection, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Net.WebHeaderCollection, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.Net.WebHeaderCollection.dll'
------------------
Resolve: 'System.Net.WebProxy, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Found single assembly: 'System.Net.WebProxy, Version=8.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.Net.WebProxy.dll'
------------------
Resolve: 'System.Net.Mail, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Found single assembly: 'System.Net.Mail, Version=8.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.Net.Mail.dll'
------------------
Resolve: 'System.Net.NetworkInformation, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Net.NetworkInformation, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.Net.NetworkInformation.dll'
------------------
Resolve: 'System.Net.Ping, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Net.Ping, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.Net.Ping.dll'
------------------
Resolve: 'System.Net.Security, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Net.Security, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.Net.Security.dll'
------------------
Resolve: 'System.Net.Sockets, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Net.Sockets, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.Net.Sockets.dll'
------------------
Resolve: 'System.Net.WebSockets.Client, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Net.WebSockets.Client, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.Net.WebSockets.Client.dll'
------------------
Resolve: 'System.Net.WebSockets, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Net.WebSockets, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.Net.WebSockets.dll'
------------------
Resolve: 'System.Text.RegularExpressions, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Text.RegularExpressions, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '8.0.0.0'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.Text.RegularExpressions.dll'
------------------
Resolve: 'System.ComponentModel.Primitives, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.ComponentModel.Primitives, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.ComponentModel.Primitives.dll'
------------------
Resolve: 'System.ObjectModel, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.ObjectModel, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.ObjectModel.dll'
------------------
Resolve: 'System.Runtime, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Runtime, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.Runtime.dll'
------------------
Resolve: 'System.Security.AccessControl, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Security.AccessControl, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.Security.AccessControl.dll'
------------------
Resolve: 'System.Net.WebHeaderCollection, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Net.WebHeaderCollection, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.1\ref\net8.0\System.Net.WebHeaderCollection.dll'
#endif
