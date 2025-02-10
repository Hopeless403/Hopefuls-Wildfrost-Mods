// Decompiled with JetBrains decompiler
// Type: NexPlugin.Common
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace NexPlugin
{
  public static class Common : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_INFINITE_TIME_INTERVAL;

    static Common()
    {
      Il2CppClassPointerStore<Common>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NexPlugin", nameof (Common));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Common>.NativeClassPtr);
      Common.NativeFieldInfoPtr_INFINITE_TIME_INTERVAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Common>.NativeClassPtr, nameof (INFINITE_TIME_INTERVAL));
    }

    public Common(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe uint INFINITE_TIME_INTERVAL
    {
      get
      {
        uint infiniteTimeInterval;
        IL2CPP.il2cpp_field_static_get_value(Common.NativeFieldInfoPtr_INFINITE_TIME_INTERVAL, (void*) &infiniteTimeInterval);
        return infiniteTimeInterval;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Common.NativeFieldInfoPtr_INFINITE_TIME_INTERVAL, (void*) &value);
      }
    }

    [Flags]
    public enum ThreadMode
    {
      ThreadModeSafeTransportBuffer = 1,
      ThreadModeUnsafeTransportBuffer = 2,
    }

    [Flags]
    public enum DispachFlag
    {
      ContinueWhenEmpty = 1,
      DispatchKeepAliveOnly = 2,
    }

    public enum NotificationEvents
    {
      ParticipationEvent = 3,
      OwnershipChangeEvent = 4,
      GatheringUnregistered = 109, // 0x0000006D
      HostChangeEvent = 110, // 0x0000006E
      GameNotificationLogout = 111, // 0x0000006F
      SubscriptionEvent = 112, // 0x00000070
      GameServerMaintenance = 113, // 0x00000071
      MaintenanceAnnouncement = 114, // 0x00000072
      RoundStarted = 116, // 0x00000074
      FirstRoundReportReceived = 117, // 0x00000075
      RoundSummarized = 118, // 0x00000076
      MatchmakeSystemConfigurationNotification = 119, // 0x00000077
      MatchmakeSessionSystemPasswordSet = 120, // 0x00000078
      MatchmakeSessionSystemPasswordClear = 121, // 0x00000079
      AddedToGathering = 122, // 0x0000007A
      UserStatusUpdatedEvent = 128, // 0x00000080
    }

    public enum ParticipationEvents
    {
      Participate = 1,
      Disconnect = 7,
      EndParticipation = 8,
    }
  }
}
