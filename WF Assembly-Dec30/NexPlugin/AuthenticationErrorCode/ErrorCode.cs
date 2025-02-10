// Decompiled with JetBrains decompiler
// Type: NexPlugin.AuthenticationErrorCode.ErrorCode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

#nullable disable
namespace NexPlugin.AuthenticationErrorCode
{
  public enum ErrorCode
  {
    NASAuthenticateError = 1,
    TokenParseError = 2,
    HttpConnectionError = 3,
    HttpDNSError = 4,
    HttpGetProxySetting = 5,
    TokenExpired = 6,
    ValidationFailed = 7,
    InvalidParam = 8,
    PrincipalIdUnmatched = 9,
    MoveCountUnmatch = 10, // 0x0000000A
    UnderMaintenance = 11, // 0x0000000B
    UnsupportedVersion = 12, // 0x0000000C
    ServerVersionIsOld = 13, // 0x0000000D
    Unknown = 14, // 0x0000000E
    ClientVersionIsOld = 15, // 0x0000000F
    AccountLibraryError = 16, // 0x00000010
    ServiceNoLongerAvailable = 17, // 0x00000011
    UnknownApplication = 18, // 0x00000012
    ApplicationVersionIsOld = 19, // 0x00000013
    OutOfService = 20, // 0x00000014
    NetworkServiceLicenseRequired = 21, // 0x00000015
    NetworkServiceLicenseSystemError = 22, // 0x00000016
    NetworkServiceLicenseError3 = 23, // 0x00000017
    NetworkServiceLicenseError4 = 24, // 0x00000018
  }
}
