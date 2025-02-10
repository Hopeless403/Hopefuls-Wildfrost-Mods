// Decompiled with JetBrains decompiler
// Type: NexPlugin.SmartDeviceVoiceChatErrorCode.ErrorCode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

#nullable disable
namespace NexPlugin.SmartDeviceVoiceChatErrorCode
{
  public enum ErrorCode
  {
    Unknown = 1,
    InvalidArgument = 2,
    InvalidResponse = 3,
    InvalidAccessToken = 4,
    Unauthorized = 5,
    AccessError = 6,
    UserNotFound = 7,
    RoomNotFound = 8,
    RoomNotActivated = 9,
    ApplicationNotSupported = 10, // 0x0000000A
    InternalServerError = 11, // 0x0000000B
    ServiceUnavailable = 12, // 0x0000000C
    UnexpectedError = 13, // 0x0000000D
    UnderMaintenance = 14, // 0x0000000E
    ServiceNoLongerAvailable = 15, // 0x0000000F
    AccountTemporarilyDisabled = 16, // 0x00000010
    PermissionDenied = 17, // 0x00000011
    NetworkServiceLicenseRequired = 18, // 0x00000012
    AccountLibraryError = 19, // 0x00000013
    GameModeNotFound = 20, // 0x00000014
  }
}
