// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenHit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class StatusEffectApplyXWhenHit : StatusEffectApplyX
{
  private static readonly IntPtr NativeFieldInfoPtr_attackerConstraints;
  private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_RunPostHitEvent_Public_Virtual_Boolean_Hit_0;
  private static readonly IntPtr NativeMethodInfoPtr_CheckHit_Private_IEnumerator_Hit_0;
  private static readonly IntPtr NativeMethodInfoPtr_CheckAttackerConstraints_Private_Boolean_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122853, XrefRangeEnd = 122861, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Init()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectApplyXWhenHit.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122861, XrefRangeEnd = 122869, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool RunPostHitEvent(Hit hit)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hit)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectApplyXWhenHit.NativeMethodInfoPtr_RunPostHitEvent_Public_Virtual_Boolean_Hit_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122869, XrefRangeEnd = 122874, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator CheckHit(Hit hit)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hit)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectApplyXWhenHit.NativeMethodInfoPtr_CheckHit_Private_IEnumerator_Hit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    IntPtr pointer = num;
    return pointer == IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122874, XrefRangeEnd = 122875, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool CheckAttackerConstraints(Entity attacker)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attacker)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectApplyXWhenHit.NativeMethodInfoPtr_CheckAttackerConstraints_Private_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StatusEffectApplyXWhenHit()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusEffectApplyXWhenHit>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectApplyXWhenHit.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static StatusEffectApplyXWhenHit()
  {
    Il2CppClassPointerStore<StatusEffectApplyXWhenHit>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (StatusEffectApplyXWhenHit));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusEffectApplyXWhenHit>.NativeClassPtr);
    StatusEffectApplyXWhenHit.NativeFieldInfoPtr_attackerConstraints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectApplyXWhenHit>.NativeClassPtr, nameof (attackerConstraints));
    StatusEffectApplyXWhenHit.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectApplyXWhenHit>.NativeClassPtr, 100675592);
    StatusEffectApplyXWhenHit.NativeMethodInfoPtr_RunPostHitEvent_Public_Virtual_Boolean_Hit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectApplyXWhenHit>.NativeClassPtr, 100675593);
    StatusEffectApplyXWhenHit.NativeMethodInfoPtr_CheckHit_Private_IEnumerator_Hit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectApplyXWhenHit>.NativeClassPtr, 100675594);
    StatusEffectApplyXWhenHit.NativeMethodInfoPtr_CheckAttackerConstraints_Private_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectApplyXWhenHit>.NativeClassPtr, 100675595);
    StatusEffectApplyXWhenHit.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectApplyXWhenHit>.NativeClassPtr, 100675596);
  }

  public StatusEffectApplyXWhenHit(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Il2CppReferenceArray<TargetConstraint> attackerConstraints
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectApplyXWhenHit.NativeFieldInfoPtr_attackerConstraints));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<TargetConstraint>) null : new Il2CppReferenceArray<TargetConstraint>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectApplyXWhenHit.NativeFieldInfoPtr_attackerConstraints), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
