// Decompiled with JetBrains decompiler
// Type: SnowBear
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class SnowBear : ScriptableCardImage
{
  private static readonly IntPtr NativeFieldInfoPtr_main;
  private static readonly IntPtr NativeFieldInfoPtr_ball;
  private static readonly IntPtr NativeFieldInfoPtr_curve;
  private static readonly IntPtr NativeFieldInfoPtr_ballScaleCurve;
  private static readonly IntPtr NativeFieldInfoPtr_ballYCurve;
  private static readonly IntPtr NativeFieldInfoPtr_yCurve;
  private static readonly IntPtr NativeFieldInfoPtr_tweenCurve;
  private static readonly IntPtr NativeFieldInfoPtr_tweenDur;
  private static readonly IntPtr NativeFieldInfoPtr_tweenFrom;
  private static readonly IntPtr NativeFieldInfoPtr_tweenTo;
  private static readonly IntPtr NativeFieldInfoPtr_tweenT;
  private static readonly IntPtr NativeFieldInfoPtr_tween;
  private static readonly IntPtr NativeFieldInfoPtr_currentSet;
  private static readonly IntPtr NativeFieldInfoPtr_current;
  private static readonly IntPtr NativeMethodInfoPtr_UpdateEvent_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Set_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_StartTween_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_UpdateValues_Private_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21182, XrefRangeEnd = 21185, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void UpdateEvent()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SnowBear.NativeMethodInfoPtr_UpdateEvent_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21185, XrefRangeEnd = 21186, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SnowBear.NativeMethodInfoPtr_Set_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public unsafe void StartTween()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SnowBear.NativeMethodInfoPtr_StartTween_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21186, XrefRangeEnd = 21198, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SnowBear.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21198, XrefRangeEnd = 21208, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateValues(float progress)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &progress
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SnowBear.NativeMethodInfoPtr_UpdateValues_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 21168, RefRangeEnd = 21171, XrefRangeStart = 21168, XrefRangeEnd = 21171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SnowBear()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SnowBear>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SnowBear.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static SnowBear()
  {
    Il2CppClassPointerStore<SnowBear>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (SnowBear));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SnowBear>.NativeClassPtr);
    SnowBear.NativeFieldInfoPtr_main = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnowBear>.NativeClassPtr, nameof (main));
    SnowBear.NativeFieldInfoPtr_ball = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnowBear>.NativeClassPtr, nameof (ball));
    SnowBear.NativeFieldInfoPtr_curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnowBear>.NativeClassPtr, nameof (curve));
    SnowBear.NativeFieldInfoPtr_ballScaleCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnowBear>.NativeClassPtr, nameof (ballScaleCurve));
    SnowBear.NativeFieldInfoPtr_ballYCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnowBear>.NativeClassPtr, nameof (ballYCurve));
    SnowBear.NativeFieldInfoPtr_yCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnowBear>.NativeClassPtr, nameof (yCurve));
    SnowBear.NativeFieldInfoPtr_tweenCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnowBear>.NativeClassPtr, nameof (tweenCurve));
    SnowBear.NativeFieldInfoPtr_tweenDur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnowBear>.NativeClassPtr, nameof (tweenDur));
    SnowBear.NativeFieldInfoPtr_tweenFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnowBear>.NativeClassPtr, nameof (tweenFrom));
    SnowBear.NativeFieldInfoPtr_tweenTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnowBear>.NativeClassPtr, nameof (tweenTo));
    SnowBear.NativeFieldInfoPtr_tweenT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnowBear>.NativeClassPtr, nameof (tweenT));
    SnowBear.NativeFieldInfoPtr_tween = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnowBear>.NativeClassPtr, nameof (tween));
    SnowBear.NativeFieldInfoPtr_currentSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnowBear>.NativeClassPtr, nameof (currentSet));
    SnowBear.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnowBear>.NativeClassPtr, nameof (current));
    SnowBear.NativeMethodInfoPtr_UpdateEvent_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnowBear>.NativeClassPtr, 100663881);
    SnowBear.NativeMethodInfoPtr_Set_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnowBear>.NativeClassPtr, 100663882);
    SnowBear.NativeMethodInfoPtr_StartTween_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnowBear>.NativeClassPtr, 100663883);
    SnowBear.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnowBear>.NativeClassPtr, 100663884);
    SnowBear.NativeMethodInfoPtr_UpdateValues_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnowBear>.NativeClassPtr, 100663885);
    SnowBear.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnowBear>.NativeClassPtr, 100663886);
  }

  public SnowBear(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Transform main
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowBear.NativeFieldInfoPtr_main));
      return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SnowBear.NativeFieldInfoPtr_main), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform ball
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowBear.NativeFieldInfoPtr_ball));
      return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SnowBear.NativeFieldInfoPtr_ball), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve curve
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowBear.NativeFieldInfoPtr_curve));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SnowBear.NativeFieldInfoPtr_curve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve ballScaleCurve
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowBear.NativeFieldInfoPtr_ballScaleCurve));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SnowBear.NativeFieldInfoPtr_ballScaleCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve ballYCurve
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowBear.NativeFieldInfoPtr_ballYCurve));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SnowBear.NativeFieldInfoPtr_ballYCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve yCurve
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowBear.NativeFieldInfoPtr_yCurve));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SnowBear.NativeFieldInfoPtr_yCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve tweenCurve
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowBear.NativeFieldInfoPtr_tweenCurve));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SnowBear.NativeFieldInfoPtr_tweenCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float tweenDur
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowBear.NativeFieldInfoPtr_tweenDur));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowBear.NativeFieldInfoPtr_tweenDur)) = value;
    }
  }

  public unsafe float tweenFrom
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowBear.NativeFieldInfoPtr_tweenFrom));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowBear.NativeFieldInfoPtr_tweenFrom)) = value;
    }
  }

  public unsafe float tweenTo
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowBear.NativeFieldInfoPtr_tweenTo));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowBear.NativeFieldInfoPtr_tweenTo)) = value;
    }
  }

  public unsafe float tweenT
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowBear.NativeFieldInfoPtr_tweenT));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowBear.NativeFieldInfoPtr_tweenT)) = value;
    }
  }

  public unsafe bool tween
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowBear.NativeFieldInfoPtr_tween));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowBear.NativeFieldInfoPtr_tween)) = value;
    }
  }

  public unsafe bool currentSet
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowBear.NativeFieldInfoPtr_currentSet));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowBear.NativeFieldInfoPtr_currentSet)) = value;
    }
  }

  public unsafe int current
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowBear.NativeFieldInfoPtr_current));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnowBear.NativeFieldInfoPtr_current)) = value;
    }
  }
}
