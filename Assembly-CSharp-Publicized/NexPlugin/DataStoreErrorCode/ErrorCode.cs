﻿// Decompiled with JetBrains decompiler
// Type: NexPlugin.DataStoreErrorCode.ErrorCode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

namespace NexPlugin.DataStoreErrorCode
{
  public enum ErrorCode
  {
    Unknown = 1,
    InvalidArgument = 2,
    PermissionDenied = 3,
    NotFound = 4,
    AlreadyLocked = 5,
    UnderReviewing = 6,
    Expired = 7,
    InvalidCheckToken = 8,
    SystemFileError = 9,
    OverCapacity = 10, // 0x0000000A
    OperationNotAllowed = 11, // 0x0000000B
    InvalidPassword = 12, // 0x0000000C
    ValueNotEqual = 13, // 0x0000000D
  }
}
