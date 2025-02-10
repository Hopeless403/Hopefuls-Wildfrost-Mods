// Decompiled with JetBrains decompiler
// Type: HitAnimationSystem
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
public class HitAnimationSystem : GameSystem
{
  private static readonly IntPtr NativeFieldInfoPtr_hitCurve;
  private static readonly IntPtr NativeFieldInfoPtr_strength;
  private static readonly IntPtr NativeFieldInfoPtr_strengthCurve;
  private static readonly IntPtr NativeFieldInfoPtr_duration;
  private static readonly IntPtr NativeFieldInfoPtr_durationCurve;
  private static readonly IntPtr NativeFieldInfoPtr_wobble;
  private static readonly IntPtr NativeFieldInfoPtr_wobbleCurve;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_EntityDodge_Private_Void_Hit_0;
  private static readonly IntPtr NativeMethodInfoPtr_EntityHit_Private_Void_Hit_0;
  private static readonly IntPtr NativeMethodInfoPtr_CardTakeHit_Private_Void_Hit_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetHitDirection_Private_Static_Vector3_Vector3_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60644, XrefRangeEnd = 60658, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HitAnimationSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60658, XrefRangeEnd = 60672, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HitAnimationSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60672, XrefRangeEnd = 60675, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntityDodge(Hit hit)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hit)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HitAnimationSystem.NativeMethodInfoPtr_EntityDodge_Private_Void_Hit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60675, XrefRangeEnd = 60678, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntityHit(Hit hit)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hit)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HitAnimationSystem.NativeMethodInfoPtr_EntityHit_Private_Void_Hit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 60699, RefRangeEnd = 60701, XrefRangeStart = 60678, XrefRangeEnd = 60699, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CardTakeHit(Hit hit)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hit)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HitAnimationSystem.NativeMethodInfoPtr_CardTakeHit_Private_Void_Hit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 GetHitDirection(Vector3 targetPos, Vector3 attackerPos)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &targetPos;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &attackerPos;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(HitAnimationSystem.NativeMethodInfoPtr_GetHitDirection_Private_Static_Vector3_Vector3_Vector3_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60701, XrefRangeEnd = 60702, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe HitAnimationSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HitAnimationSystem>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HitAnimationSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static HitAnimationSystem()
  {
    Il2CppClassPointerStore<HitAnimationSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (HitAnimationSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HitAnimationSystem>.NativeClassPtr);
    HitAnimationSystem.NativeFieldInfoPtr_hitCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitAnimationSystem>.NativeClassPtr, nameof (hitCurve));
    HitAnimationSystem.NativeFieldInfoPtr_strength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitAnimationSystem>.NativeClassPtr, nameof (strength));
    HitAnimationSystem.NativeFieldInfoPtr_strengthCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitAnimationSystem>.NativeClassPtr, nameof (strengthCurve));
    HitAnimationSystem.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitAnimationSystem>.NativeClassPtr, nameof (duration));
    HitAnimationSystem.NativeFieldInfoPtr_durationCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitAnimationSystem>.NativeClassPtr, nameof (durationCurve));
    HitAnimationSystem.NativeFieldInfoPtr_wobble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitAnimationSystem>.NativeClassPtr, nameof (wobble));
    HitAnimationSystem.NativeFieldInfoPtr_wobbleCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitAnimationSystem>.NativeClassPtr, nameof (wobbleCurve));
    HitAnimationSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HitAnimationSystem>.NativeClassPtr, 100668248);
    HitAnimationSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HitAnimationSystem>.NativeClassPtr, 100668249);
    HitAnimationSystem.NativeMethodInfoPtr_EntityDodge_Private_Void_Hit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HitAnimationSystem>.NativeClassPtr, 100668250);
    HitAnimationSystem.NativeMethodInfoPtr_EntityHit_Private_Void_Hit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HitAnimationSystem>.NativeClassPtr, 100668251);
    HitAnimationSystem.NativeMethodInfoPtr_CardTakeHit_Private_Void_Hit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HitAnimationSystem>.NativeClassPtr, 100668252);
    HitAnimationSystem.NativeMethodInfoPtr_GetHitDirection_Private_Static_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HitAnimationSystem>.NativeClassPtr, 100668253);
    HitAnimationSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HitAnimationSystem>.NativeClassPtr, 100668254);
  }

  public HitAnimationSystem(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe AnimationCurve hitCurve
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitAnimationSystem.NativeFieldInfoPtr_hitCurve));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HitAnimationSystem.NativeFieldInfoPtr_hitCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float strength
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitAnimationSystem.NativeFieldInfoPtr_strength));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitAnimationSystem.NativeFieldInfoPtr_strength)) = value;
    }
  }

  public unsafe AnimationCurve strengthCurve
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitAnimationSystem.NativeFieldInfoPtr_strengthCurve));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HitAnimationSystem.NativeFieldInfoPtr_strengthCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float duration
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitAnimationSystem.NativeFieldInfoPtr_duration));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitAnimationSystem.NativeFieldInfoPtr_duration)) = value;
    }
  }

  public unsafe AnimationCurve durationCurve
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitAnimationSystem.NativeFieldInfoPtr_durationCurve));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HitAnimationSystem.NativeFieldInfoPtr_durationCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float wobble
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitAnimationSystem.NativeFieldInfoPtr_wobble));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitAnimationSystem.NativeFieldInfoPtr_wobble)) = value;
    }
  }

  public unsafe AnimationCurve wobbleCurve
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitAnimationSystem.NativeFieldInfoPtr_wobbleCurve));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HitAnimationSystem.NativeFieldInfoPtr_wobbleCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
