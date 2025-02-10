// Decompiled with JetBrains decompiler
// Type: NexPlugin.Common
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;

namespace NexPlugin
{
  public static class Common
  {
    public const uint INFINITE_TIME_INTERVAL = 2147483647;

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
