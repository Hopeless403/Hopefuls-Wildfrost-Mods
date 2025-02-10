// Decompiled with JetBrains decompiler
// Type: NexPlugin.TransportErrorCode.ErrorCode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

#nullable disable
namespace NexPlugin.TransportErrorCode
{
  public enum ErrorCode
  {
    Unknown = 1,
    ConnectionFailure = 2,
    InvalidUrl = 3,
    InvalidKey = 4,
    InvalidURLType = 5,
    DuplicateEndpoint = 6,
    IOError = 7,
    Timeout = 8,
    ConnectionReset = 9,
    IncorrectRemoteAuthentication = 10, // 0x0000000A
    ServerRequestError = 11, // 0x0000000B
    DecompressionFailure = 12, // 0x0000000C
    ReliableSendBufferFullFatal = 13, // 0x0000000D
    UPnPCannotInit = 14, // 0x0000000E
    UPnPCannotAddMapping = 15, // 0x0000000F
    NatPMPCannotInit = 16, // 0x00000010
    NatPMPCannotAddMapping = 17, // 0x00000011
    UnsupportedNAT = 19, // 0x00000013
    DnsError = 20, // 0x00000014
    ProxyError = 21, // 0x00000015
    DataRemaining = 22, // 0x00000016
    NoBuffer = 23, // 0x00000017
    NotFound = 24, // 0x00000018
    TemporaryServerError = 25, // 0x00000019
    PermanentServerError = 26, // 0x0000001A
    ServiceUnavailable = 27, // 0x0000001B
    ReliableSendBufferFull = 28, // 0x0000001C
    InvalidStation = 29, // 0x0000001D
    InvalidSubStreamID = 30, // 0x0000001E
    PacketBufferFull = 31, // 0x0000001F
    NatTraversalError = 32, // 0x00000020
    NatCheckError = 33, // 0x00000021
  }
}
