// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenYAppliedTo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class StatusEffectApplyXWhenYAppliedTo : StatusEffectApplyX
{
  private static readonly IntPtr NativeFieldInfoPtr_instead;
  private static readonly IntPtr NativeFieldInfoPtr_whenAppliedType;
  private static readonly IntPtr NativeFieldInfoPtr_whenAppliedToFlags;
  private static readonly IntPtr NativeFieldInfoPtr_mustReachAmount;
  private static readonly IntPtr NativeFieldInfoPtr_amountRequired;
  private static readonly IntPtr NativeFieldInfoPtr_adjustAmount;
  private static readonly IntPtr NativeFieldInfoPtr_addAmount;
  private static readonly IntPtr NativeFieldInfoPtr_multiplyAmount;
  private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_RunApplyStatusEvent_Public_Virtual_Boolean_StatusEffectApply_0;
  private static readonly IntPtr NativeMethodInfoPtr_RunPostApplyStatusEvent_Public_Virtual_Boolean_StatusEffectApply_0;
  private static readonly IntPtr NativeMethodInfoPtr_Run_Private_IEnumerator_StatusEffectApply_0;
  private static readonly IntPtr NativeMethodInfoPtr_CheckFlag_Private_Boolean_ApplyToFlags_0;
  private static readonly IntPtr NativeMethodInfoPtr_CheckTarget_Private_Boolean_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_CheckAmount_Private_Boolean_StatusEffectApply_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122964, XrefRangeEnd = 122972, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Init()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectApplyXWhenYAppliedTo.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122972, XrefRangeEnd = 122981, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool RunApplyStatusEvent(StatusEffectApply apply)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) apply)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectApplyXWhenYAppliedTo.NativeMethodInfoPtr_RunApplyStatusEvent_Public_Virtual_Boolean_StatusEffectApply_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122981, XrefRangeEnd = 122993, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool RunPostApplyStatusEvent(StatusEffectApply apply)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) apply)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectApplyXWhenYAppliedTo.NativeMethodInfoPtr_RunPostApplyStatusEvent_Public_Virtual_Boolean_StatusEffectApply_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122993, XrefRangeEnd = 122996, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator Run(StatusEffectApply apply)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) apply)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectApplyXWhenYAppliedTo.NativeMethodInfoPtr_Run_Private_IEnumerator_StatusEffectApply_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    IntPtr pointer = num;
    return pointer == IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  public unsafe bool CheckFlag(StatusEffectApplyX.ApplyToFlags whenAppliedTo)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &whenAppliedTo
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectApplyXWhenYAppliedTo.NativeMethodInfoPtr_CheckFlag_Private_Boolean_ApplyToFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 123007, RefRangeEnd = 123009, XrefRangeStart = 122996, XrefRangeEnd = 123007, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool CheckTarget(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectApplyXWhenYAppliedTo.NativeMethodInfoPtr_CheckTarget_Private_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123009, XrefRangeEnd = 123014, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool CheckAmount(StatusEffectApply apply)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) apply)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectApplyXWhenYAppliedTo.NativeMethodInfoPtr_CheckAmount_Private_Boolean_StatusEffectApply_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123014, XrefRangeEnd = 123019, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StatusEffectApplyXWhenYAppliedTo()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusEffectApplyXWhenYAppliedTo>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectApplyXWhenYAppliedTo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static StatusEffectApplyXWhenYAppliedTo()
  {
    Il2CppClassPointerStore<StatusEffectApplyXWhenYAppliedTo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (StatusEffectApplyXWhenYAppliedTo));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusEffectApplyXWhenYAppliedTo>.NativeClassPtr);
    StatusEffectApplyXWhenYAppliedTo.NativeFieldInfoPtr_instead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectApplyXWhenYAppliedTo>.NativeClassPtr, nameof (instead));
    StatusEffectApplyXWhenYAppliedTo.NativeFieldInfoPtr_whenAppliedType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectApplyXWhenYAppliedTo>.NativeClassPtr, nameof (whenAppliedType));
    StatusEffectApplyXWhenYAppliedTo.NativeFieldInfoPtr_whenAppliedToFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectApplyXWhenYAppliedTo>.NativeClassPtr, nameof (whenAppliedToFlags));
    StatusEffectApplyXWhenYAppliedTo.NativeFieldInfoPtr_mustReachAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectApplyXWhenYAppliedTo>.NativeClassPtr, nameof (mustReachAmount));
    StatusEffectApplyXWhenYAppliedTo.NativeFieldInfoPtr_amountRequired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectApplyXWhenYAppliedTo>.NativeClassPtr, nameof (amountRequired));
    StatusEffectApplyXWhenYAppliedTo.NativeFieldInfoPtr_adjustAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectApplyXWhenYAppliedTo>.NativeClassPtr, nameof (adjustAmount));
    StatusEffectApplyXWhenYAppliedTo.NativeFieldInfoPtr_addAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectApplyXWhenYAppliedTo>.NativeClassPtr, nameof (addAmount));
    StatusEffectApplyXWhenYAppliedTo.NativeFieldInfoPtr_multiplyAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectApplyXWhenYAppliedTo>.NativeClassPtr, nameof (multiplyAmount));
    StatusEffectApplyXWhenYAppliedTo.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectApplyXWhenYAppliedTo>.NativeClassPtr, 100675615);
    StatusEffectApplyXWhenYAppliedTo.NativeMethodInfoPtr_RunApplyStatusEvent_Public_Virtual_Boolean_StatusEffectApply_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectApplyXWhenYAppliedTo>.NativeClassPtr, 100675616);
    StatusEffectApplyXWhenYAppliedTo.NativeMethodInfoPtr_RunPostApplyStatusEvent_Public_Virtual_Boolean_StatusEffectApply_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectApplyXWhenYAppliedTo>.NativeClassPtr, 100675617);
    StatusEffectApplyXWhenYAppliedTo.NativeMethodInfoPtr_Run_Private_IEnumerator_StatusEffectApply_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectApplyXWhenYAppliedTo>.NativeClassPtr, 100675618);
    StatusEffectApplyXWhenYAppliedTo.NativeMethodInfoPtr_CheckFlag_Private_Boolean_ApplyToFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectApplyXWhenYAppliedTo>.NativeClassPtr, 100675619);
    StatusEffectApplyXWhenYAppliedTo.NativeMethodInfoPtr_CheckTarget_Private_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectApplyXWhenYAppliedTo>.NativeClassPtr, 100675620);
    StatusEffectApplyXWhenYAppliedTo.NativeMethodInfoPtr_CheckAmount_Private_Boolean_StatusEffectApply_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectApplyXWhenYAppliedTo>.NativeClassPtr, 100675621);
    StatusEffectApplyXWhenYAppliedTo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectApplyXWhenYAppliedTo>.NativeClassPtr, 100675622);
  }

  public StatusEffectApplyXWhenYAppliedTo(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe bool instead
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectApplyXWhenYAppliedTo.NativeFieldInfoPtr_instead));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectApplyXWhenYAppliedTo.NativeFieldInfoPtr_instead)) = value;
    }
  }

  public unsafe string whenAppliedType
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectApplyXWhenYAppliedTo.NativeFieldInfoPtr_whenAppliedType)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectApplyXWhenYAppliedTo.NativeFieldInfoPtr_whenAppliedType), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe StatusEffectApplyX.ApplyToFlags whenAppliedToFlags
  {
    get
    {
      return *(StatusEffectApplyX.ApplyToFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectApplyXWhenYAppliedTo.NativeFieldInfoPtr_whenAppliedToFlags));
    }
    [param: In] set
    {
      *(StatusEffectApplyX.ApplyToFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectApplyXWhenYAppliedTo.NativeFieldInfoPtr_whenAppliedToFlags)) = value;
    }
  }

  public unsafe bool mustReachAmount
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectApplyXWhenYAppliedTo.NativeFieldInfoPtr_mustReachAmount));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectApplyXWhenYAppliedTo.NativeFieldInfoPtr_mustReachAmount)) = value;
    }
  }

  public unsafe int amountRequired
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectApplyXWhenYAppliedTo.NativeFieldInfoPtr_amountRequired));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectApplyXWhenYAppliedTo.NativeFieldInfoPtr_amountRequired)) = value;
    }
  }

  public unsafe bool adjustAmount
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectApplyXWhenYAppliedTo.NativeFieldInfoPtr_adjustAmount));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectApplyXWhenYAppliedTo.NativeFieldInfoPtr_adjustAmount)) = value;
    }
  }

  public unsafe int addAmount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectApplyXWhenYAppliedTo.NativeFieldInfoPtr_addAmount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectApplyXWhenYAppliedTo.NativeFieldInfoPtr_addAmount)) = value;
    }
  }

  public unsafe float multiplyAmount
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectApplyXWhenYAppliedTo.NativeFieldInfoPtr_multiplyAmount));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectApplyXWhenYAppliedTo.NativeFieldInfoPtr_multiplyAmount)) = value;
    }
  }
}
