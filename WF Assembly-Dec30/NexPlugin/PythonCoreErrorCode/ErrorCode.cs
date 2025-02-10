// Decompiled with JetBrains decompiler
// Type: NexPlugin.PythonCoreErrorCode.ErrorCode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

#nullable disable
namespace NexPlugin.PythonCoreErrorCode
{
  public enum ErrorCode
  {
    Exception = 1,
    TypeError = 2,
    IndexError = 3,
    InvalidReference = 4,
    CallFailure = 5,
    MemoryError = 6,
    KeyError = 7,
    OperationError = 8,
    ConversionError = 9,
    ValidationError = 10, // 0x0000000A
  }
}
