// Decompiled with JetBrains decompiler
// Type: NexPlugin.CoreErrorCode.ErrorCode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

namespace NexPlugin.CoreErrorCode
{
  public enum ErrorCode
  {
    Unknown = 1,
    NotImplemented = 2,
    InvalidPointer = 3,
    OperationAborted = 4,
    Exception = 5,
    AccessDenied = 6,
    InvalidIndex = 8,
    OutOfMemory = 9,
    InvalidArgument = 10, // 0x0000000A
    Timeout = 11, // 0x0000000B
    InitializationFailure = 12, // 0x0000000C
    CallInitiationFailure = 13, // 0x0000000D
    RegistrationError = 14, // 0x0000000E
    BufferOverflow = 15, // 0x0000000F
    InvalidLockState = 16, // 0x00000010
    InvalidSequence = 17, // 0x00000011
    SystemError = 18, // 0x00000012
    Cancelled = 19, // 0x00000013
  }
}
