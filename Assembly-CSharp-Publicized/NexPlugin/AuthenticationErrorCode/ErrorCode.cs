// Decompiled with JetBrains decompiler
// Type: NexPlugin.AuthenticationErrorCode.ErrorCode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

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
