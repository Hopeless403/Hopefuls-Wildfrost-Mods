// Decompiled with JetBrains decompiler
// Type: NexPlugin.RendezVousErrorCode.ErrorCode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

#nullable disable
namespace NexPlugin.RendezVousErrorCode
{
  public enum ErrorCode
  {
    ConnectionFailure = 1,
    NotAuthenticated = 2,
    InvalidUsername = 100, // 0x00000064
    InvalidPassword = 101, // 0x00000065
    UsernameAlreadyExists = 102, // 0x00000066
    AccountDisabled = 103, // 0x00000067
    AccountExpired = 104, // 0x00000068
    ConcurrentLoginDenied = 105, // 0x00000069
    EncryptionFailure = 106, // 0x0000006A
    InvalidPID = 107, // 0x0000006B
    MaxConnectionsReached = 108, // 0x0000006C
    InvalidGID = 109, // 0x0000006D
    InvalidControlScriptID = 110, // 0x0000006E
    InvalidOperationInLiveEnvironment = 111, // 0x0000006F
    DuplicateEntry = 112, // 0x00000070
    ControlScriptFailure = 113, // 0x00000071
    ClassNotFound = 114, // 0x00000072
    SessionVoid = 115, // 0x00000073
    DDLMismatch = 117, // 0x00000075
    InvalidConfiguration = 118, // 0x00000076
    SessionFull = 200, // 0x000000C8
    InvalidGatheringPassword = 201, // 0x000000C9
    WithoutParticipationPeriod = 202, // 0x000000CA
    PersistentGatheringCreationMax = 203, // 0x000000CB
    PersistentGatheringParticipationMax = 204, // 0x000000CC
    DeniedByParticipants = 205, // 0x000000CD
    ParticipantInBlockList = 206, // 0x000000CE
    GameServerMaintenance = 207, // 0x000000CF
    OutOfRatingRange = 209, // 0x000000D1
    ConnectionDisconnected = 210, // 0x000000D2
    InvalidOperation = 211, // 0x000000D3
    NotParticipatedGathering = 212, // 0x000000D4
    MatchmakeSessionUserPasswordUnmatch = 213, // 0x000000D5
    MatchmakeSessionSystemPasswordUnmatch = 214, // 0x000000D6
    UserIsOffline = 215, // 0x000000D7
    AlreadyParticipatedGathering = 216, // 0x000000D8
    PermissionDenied = 217, // 0x000000D9
    NotFriend = 218, // 0x000000DA
    SessionClosed = 219, // 0x000000DB
    DatabaseTemporarilyUnavailable = 220, // 0x000000DC
    InvalidUniqueId = 221, // 0x000000DD
    MatchmakingWithdrawn = 222, // 0x000000DE
    LimitExceeded = 223, // 0x000000DF
    AccountTemporarilyDisabled = 224, // 0x000000E0
    PartiallyServiceClosed = 225, // 0x000000E1
    ConnectionDisconnectedForConcurrentLogin = 226, // 0x000000E2
  }
}
