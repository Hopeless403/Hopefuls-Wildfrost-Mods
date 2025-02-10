// Decompiled with JetBrains decompiler
// Type: NexPlugin.RankingErrorCode.ErrorCode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

#nullable disable
namespace NexPlugin.RankingErrorCode
{
  public enum ErrorCode
  {
    NotInitialized = 1,
    InvalidArgument = 2,
    RegistrationError = 3,
    NotFound = 5,
    InvalidScore = 6,
    InvalidDataSize = 7,
    PermissionDenied = 9,
    Unknown = 10, // 0x0000000A
    NotImplemented = 11, // 0x0000000B
  }
}
