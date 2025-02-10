// Decompiled with JetBrains decompiler
// Type: CurveAnimator
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
public class CurveAnimator : MonoBehaviourCacheTransform
{
  private static readonly IntPtr NativeFieldInfoPtr_rotationInfluence;
  private static readonly IntPtr NativeFieldInfoPtr_rotationDurationMod;
  private static readonly IntPtr NativeFieldInfoPtr_moveAnimationDur;
  private static readonly IntPtr NativeFieldInfoPtr_pingDuration;
  private static readonly IntPtr NativeFieldInfoPtr_pingScale;
  private static readonly IntPtr NativeFieldInfoPtr_pingMove;
  private static readonly IntPtr NativeFieldInfoPtr_active;
  private static readonly IntPtr NativeMethodInfoPtr_Move_Public_Single_Vector3_AnimationCurve_Single_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_Rotate_Public_Single_Vector3_AnimationCurve_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_Scale_Public_Single_Vector3_AnimationCurve_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_Ping_Public_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_CancelTween_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnGetFromPool_Public_Virtual_Final_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnReturnToPool_Public_Virtual_Final_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__Move_b__7_0_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__Ping_b__10_0_Private_Void_0;

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 38474, RefRangeEnd = 38479, XrefRangeStart = 38445, XrefRangeEnd = 38474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float Move(
    Vector3 offset,
    AnimationCurve curve,
    float rotationAmount = 1f,
    float duration = 0.667f)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[4];
    numPtr[0] = (IntPtr) &offset;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) curve);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &rotationAmount;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &duration;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(CurveAnimator.NativeMethodInfoPtr_Move_Public_Single_Vector3_AnimationCurve_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 38485, RefRangeEnd = 38486, XrefRangeStart = 38479, XrefRangeEnd = 38485, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float Rotate(Vector3 offset, AnimationCurve curve, float duration)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = (IntPtr) &offset;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) curve);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &duration;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(CurveAnimator.NativeMethodInfoPtr_Rotate_Public_Single_Vector3_AnimationCurve_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38486, XrefRangeEnd = 38493, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float Scale(Vector3 offset, AnimationCurve curve, float duration)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = (IntPtr) &offset;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) curve);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &duration;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(CurveAnimator.NativeMethodInfoPtr_Scale_Public_Single_Vector3_AnimationCurve_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(23)]
  [CachedScanResults(RefRangeStart = 38537, RefRangeEnd = 38560, XrefRangeStart = 38493, XrefRangeEnd = 38537, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float Ping()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(CurveAnimator.NativeMethodInfoPtr_Ping_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 38582, RefRangeEnd = 38586, XrefRangeStart = 38560, XrefRangeEnd = 38582, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CancelTween()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CurveAnimator.NativeMethodInfoPtr_CancelTween_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(12611)]
  [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnGetFromPool()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CurveAnimator.NativeMethodInfoPtr_OnGetFromPool_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 38587, RefRangeEnd = 38588, XrefRangeStart = 38586, XrefRangeEnd = 38587, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnReturnToPool()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CurveAnimator.NativeMethodInfoPtr_OnReturnToPool_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38588, XrefRangeEnd = 38593, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CurveAnimator()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CurveAnimator>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CurveAnimator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public unsafe void _Move_b__7_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CurveAnimator.NativeMethodInfoPtr__Move_b__7_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public unsafe void _Ping_b__10_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CurveAnimator.NativeMethodInfoPtr__Ping_b__10_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CurveAnimator()
  {
    Il2CppClassPointerStore<CurveAnimator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CurveAnimator));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CurveAnimator>.NativeClassPtr);
    CurveAnimator.NativeFieldInfoPtr_rotationInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveAnimator>.NativeClassPtr, nameof (rotationInfluence));
    CurveAnimator.NativeFieldInfoPtr_rotationDurationMod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveAnimator>.NativeClassPtr, nameof (rotationDurationMod));
    CurveAnimator.NativeFieldInfoPtr_moveAnimationDur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveAnimator>.NativeClassPtr, nameof (moveAnimationDur));
    CurveAnimator.NativeFieldInfoPtr_pingDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveAnimator>.NativeClassPtr, nameof (pingDuration));
    CurveAnimator.NativeFieldInfoPtr_pingScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveAnimator>.NativeClassPtr, nameof (pingScale));
    CurveAnimator.NativeFieldInfoPtr_pingMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveAnimator>.NativeClassPtr, nameof (pingMove));
    CurveAnimator.NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveAnimator>.NativeClassPtr, nameof (active));
    CurveAnimator.NativeMethodInfoPtr_Move_Public_Single_Vector3_AnimationCurve_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveAnimator>.NativeClassPtr, 100665908);
    CurveAnimator.NativeMethodInfoPtr_Rotate_Public_Single_Vector3_AnimationCurve_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveAnimator>.NativeClassPtr, 100665909);
    CurveAnimator.NativeMethodInfoPtr_Scale_Public_Single_Vector3_AnimationCurve_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveAnimator>.NativeClassPtr, 100665910);
    CurveAnimator.NativeMethodInfoPtr_Ping_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveAnimator>.NativeClassPtr, 100665911);
    CurveAnimator.NativeMethodInfoPtr_CancelTween_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveAnimator>.NativeClassPtr, 100665912);
    CurveAnimator.NativeMethodInfoPtr_OnGetFromPool_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveAnimator>.NativeClassPtr, 100665913);
    CurveAnimator.NativeMethodInfoPtr_OnReturnToPool_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveAnimator>.NativeClassPtr, 100665914);
    CurveAnimator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveAnimator>.NativeClassPtr, 100665915);
    CurveAnimator.NativeMethodInfoPtr__Move_b__7_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveAnimator>.NativeClassPtr, 100665917);
    CurveAnimator.NativeMethodInfoPtr__Ping_b__10_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveAnimator>.NativeClassPtr, 100665918);
  }

  public CurveAnimator(IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe Vector3 rotationInfluence
  {
    get
    {
      Vector3 rotationInfluence;
      IL2CPP.il2cpp_field_static_get_value(CurveAnimator.NativeFieldInfoPtr_rotationInfluence, (void*) &rotationInfluence);
      return rotationInfluence;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CurveAnimator.NativeFieldInfoPtr_rotationInfluence, (void*) &value);
    }
  }

  public static unsafe float rotationDurationMod
  {
    get
    {
      float rotationDurationMod;
      IL2CPP.il2cpp_field_static_get_value(CurveAnimator.NativeFieldInfoPtr_rotationDurationMod, (void*) &rotationDurationMod);
      return rotationDurationMod;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CurveAnimator.NativeFieldInfoPtr_rotationDurationMod, (void*) &value);
    }
  }

  public static unsafe float moveAnimationDur
  {
    get
    {
      float moveAnimationDur;
      IL2CPP.il2cpp_field_static_get_value(CurveAnimator.NativeFieldInfoPtr_moveAnimationDur, (void*) &moveAnimationDur);
      return moveAnimationDur;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CurveAnimator.NativeFieldInfoPtr_moveAnimationDur, (void*) &value);
    }
  }

  public unsafe float pingDuration
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurveAnimator.NativeFieldInfoPtr_pingDuration));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurveAnimator.NativeFieldInfoPtr_pingDuration)) = value;
    }
  }

  public unsafe Vector3 pingScale
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurveAnimator.NativeFieldInfoPtr_pingScale));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurveAnimator.NativeFieldInfoPtr_pingScale)) = value;
    }
  }

  public unsafe Vector3 pingMove
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurveAnimator.NativeFieldInfoPtr_pingMove));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurveAnimator.NativeFieldInfoPtr_pingMove)) = value;
    }
  }

  public unsafe bool active
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurveAnimator.NativeFieldInfoPtr_active));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurveAnimator.NativeFieldInfoPtr_active)) = value;
    }
  }
}
