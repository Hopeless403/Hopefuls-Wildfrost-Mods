// Decompiled with JetBrains decompiler
// Type: CurveProfile
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
[Serializable]
public sealed class CurveProfile : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_curve;
  private static readonly System.IntPtr NativeFieldInfoPtr_duration;

  static CurveProfile()
  {
    Il2CppClassPointerStore<CurveProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CurveProfile));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CurveProfile>.NativeClassPtr);
    CurveProfile.NativeFieldInfoPtr_curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveProfile>.NativeClassPtr, nameof (curve));
    CurveProfile.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveProfile>.NativeClassPtr, nameof (duration));
  }

  public CurveProfile(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public CurveProfile()
  {
    // ISSUE: cast to a reference type
    // ISSUE: untyped stack allocation
    System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CurveProfile>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    // ISSUE: explicit constructor call
    base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CurveProfile>.NativeClassPtr, data));
  }

  public unsafe AnimationCurve curve
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurveProfile.NativeFieldInfoPtr_curve));
      return pointer == System.IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CurveProfile.NativeFieldInfoPtr_curve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float duration
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurveProfile.NativeFieldInfoPtr_duration));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurveProfile.NativeFieldInfoPtr_duration)) = value;
    }
  }
}
