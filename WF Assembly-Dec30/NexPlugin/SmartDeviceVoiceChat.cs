// Decompiled with JetBrains decompiler
// Type: NexPlugin.SmartDeviceVoiceChat
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace NexPlugin
{
  public class SmartDeviceVoiceChat : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_CHANNELID;
    private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_HTTP_THREAD_PRIORITY;
    private static readonly System.IntPtr NativeFieldInfoPtr_INVALID_ROOMID;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SmartDeviceVoiceChat()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmartDeviceVoiceChat>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SmartDeviceVoiceChat.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SmartDeviceVoiceChat()
    {
      Il2CppClassPointerStore<SmartDeviceVoiceChat>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NexPlugin", nameof (SmartDeviceVoiceChat));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmartDeviceVoiceChat>.NativeClassPtr);
      SmartDeviceVoiceChat.NativeFieldInfoPtr_DEFAULT_CHANNELID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmartDeviceVoiceChat>.NativeClassPtr, nameof (DEFAULT_CHANNELID));
      SmartDeviceVoiceChat.NativeFieldInfoPtr_DEFAULT_HTTP_THREAD_PRIORITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmartDeviceVoiceChat>.NativeClassPtr, nameof (DEFAULT_HTTP_THREAD_PRIORITY));
      SmartDeviceVoiceChat.NativeFieldInfoPtr_INVALID_ROOMID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmartDeviceVoiceChat>.NativeClassPtr, nameof (INVALID_ROOMID));
      SmartDeviceVoiceChat.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartDeviceVoiceChat>.NativeClassPtr, 100678366);
    }

    public SmartDeviceVoiceChat(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe uint DEFAULT_CHANNELID
    {
      get
      {
        uint defaultChannelid;
        IL2CPP.il2cpp_field_static_get_value(SmartDeviceVoiceChat.NativeFieldInfoPtr_DEFAULT_CHANNELID, (void*) &defaultChannelid);
        return defaultChannelid;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SmartDeviceVoiceChat.NativeFieldInfoPtr_DEFAULT_CHANNELID, (void*) &value);
      }
    }

    public static unsafe uint DEFAULT_HTTP_THREAD_PRIORITY
    {
      get
      {
        uint httpThreadPriority;
        IL2CPP.il2cpp_field_static_get_value(SmartDeviceVoiceChat.NativeFieldInfoPtr_DEFAULT_HTTP_THREAD_PRIORITY, (void*) &httpThreadPriority);
        return httpThreadPriority;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SmartDeviceVoiceChat.NativeFieldInfoPtr_DEFAULT_HTTP_THREAD_PRIORITY, (void*) &value);
      }
    }

    public static unsafe uint INVALID_ROOMID
    {
      get
      {
        uint invalidRoomid;
        IL2CPP.il2cpp_field_static_get_value(SmartDeviceVoiceChat.NativeFieldInfoPtr_INVALID_ROOMID, (void*) &invalidRoomid);
        return invalidRoomid;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SmartDeviceVoiceChat.NativeFieldInfoPtr_INVALID_ROOMID, (void*) &value);
      }
    }

    public enum ShowAppResultStatus
    {
      SHOW_APP_RESULT_STATUS_ERROR,
      SHOW_APP_RESULT_STATUS_CANCELED,
    }
  }
}
