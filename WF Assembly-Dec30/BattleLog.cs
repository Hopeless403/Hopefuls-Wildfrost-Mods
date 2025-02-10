// Decompiled with JetBrains decompiler
// Type: BattleLog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using UnityEngine.Localization;

#nullable disable
[Serializable]
public sealed class BattleLog : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_textKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_args;
  private static readonly System.IntPtr NativeFieldInfoPtr_type;

  static BattleLog()
  {
    Il2CppClassPointerStore<BattleLog>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (BattleLog));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleLog>.NativeClassPtr);
    BattleLog.NativeFieldInfoPtr_textKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLog>.NativeClassPtr, nameof (textKey));
    BattleLog.NativeFieldInfoPtr_args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLog>.NativeClassPtr, nameof (args));
    BattleLog.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLog>.NativeClassPtr, nameof (type));
  }

  public BattleLog(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public BattleLog()
  {
    // ISSUE: cast to a reference type
    // ISSUE: untyped stack allocation
    System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BattleLog>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    // ISSUE: explicit constructor call
    base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BattleLog>.NativeClassPtr, data));
  }

  public unsafe LocalizedString textKey
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLog.NativeFieldInfoPtr_textKey));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLog.NativeFieldInfoPtr_textKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<Il2CppSystem.Object> args
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLog.NativeFieldInfoPtr_args));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Il2CppSystem.Object>) null : new Il2CppReferenceArray<Il2CppSystem.Object>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLog.NativeFieldInfoPtr_args), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe BattleLogType type
  {
    get
    {
      return *(BattleLogType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLog.NativeFieldInfoPtr_type));
    }
    [param: In] set
    {
      *(BattleLogType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLog.NativeFieldInfoPtr_type)) = value;
    }
  }
}
