﻿// Decompiled with JetBrains decompiler
// Type: NexPlugin.RankingErrorCode.ErrorCode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

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
