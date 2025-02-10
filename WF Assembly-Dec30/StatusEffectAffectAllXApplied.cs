// Decompiled with JetBrains decompiler
// Type: StatusEffectAffectAllXApplied
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class StatusEffectAffectAllXApplied : StatusEffectData
{
  private static readonly IntPtr NativeFieldInfoPtr_effectToAffect;
  private static readonly IntPtr NativeFieldInfoPtr_setToSpecificValue;
  private static readonly IntPtr NativeFieldInfoPtr_specificValue;
  private static readonly IntPtr NativeFieldInfoPtr_add;
  private static readonly IntPtr NativeFieldInfoPtr_multiplyBy;
  private static readonly IntPtr NativeFieldInfoPtr_targetCanBeFriendly;
  private static readonly IntPtr NativeFieldInfoPtr_targetCanBeEnemy;
  private static readonly IntPtr NativeFieldInfoPtr_applierCanBeFriendly;
  private static readonly IntPtr NativeFieldInfoPtr_applierCanBeEnemy;
  private static readonly IntPtr NativeMethodInfoPtr_RunApplyStatusEvent_Public_Virtual_Boolean_StatusEffectApply_0;
  private static readonly IntPtr NativeMethodInfoPtr_CheckTeamOfTarget_Private_Boolean_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_CheckTeamOfApplier_Private_Boolean_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120959, XrefRangeEnd = 120980, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool RunApplyStatusEvent(StatusEffectApply apply)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) apply)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectAffectAllXApplied.NativeMethodInfoPtr_RunApplyStatusEvent_Public_Virtual_Boolean_StatusEffectApply_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120980, XrefRangeEnd = 120984, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool CheckTeamOfTarget(Entity target)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectAffectAllXApplied.NativeMethodInfoPtr_CheckTeamOfTarget_Private_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120984, XrefRangeEnd = 120988, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool CheckTeamOfApplier(Entity applier)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) applier)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectAffectAllXApplied.NativeMethodInfoPtr_CheckTeamOfApplier_Private_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120988, XrefRangeEnd = 120989, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StatusEffectAffectAllXApplied()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusEffectAffectAllXApplied>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectAffectAllXApplied.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static StatusEffectAffectAllXApplied()
  {
    Il2CppClassPointerStore<StatusEffectAffectAllXApplied>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (StatusEffectAffectAllXApplied));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusEffectAffectAllXApplied>.NativeClassPtr);
    StatusEffectAffectAllXApplied.NativeFieldInfoPtr_effectToAffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectAffectAllXApplied>.NativeClassPtr, nameof (effectToAffect));
    StatusEffectAffectAllXApplied.NativeFieldInfoPtr_setToSpecificValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectAffectAllXApplied>.NativeClassPtr, nameof (setToSpecificValue));
    StatusEffectAffectAllXApplied.NativeFieldInfoPtr_specificValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectAffectAllXApplied>.NativeClassPtr, nameof (specificValue));
    StatusEffectAffectAllXApplied.NativeFieldInfoPtr_add = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectAffectAllXApplied>.NativeClassPtr, nameof (add));
    StatusEffectAffectAllXApplied.NativeFieldInfoPtr_multiplyBy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectAffectAllXApplied>.NativeClassPtr, nameof (multiplyBy));
    StatusEffectAffectAllXApplied.NativeFieldInfoPtr_targetCanBeFriendly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectAffectAllXApplied>.NativeClassPtr, nameof (targetCanBeFriendly));
    StatusEffectAffectAllXApplied.NativeFieldInfoPtr_targetCanBeEnemy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectAffectAllXApplied>.NativeClassPtr, nameof (targetCanBeEnemy));
    StatusEffectAffectAllXApplied.NativeFieldInfoPtr_applierCanBeFriendly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectAffectAllXApplied>.NativeClassPtr, nameof (applierCanBeFriendly));
    StatusEffectAffectAllXApplied.NativeFieldInfoPtr_applierCanBeEnemy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectAffectAllXApplied>.NativeClassPtr, nameof (applierCanBeEnemy));
    StatusEffectAffectAllXApplied.NativeMethodInfoPtr_RunApplyStatusEvent_Public_Virtual_Boolean_StatusEffectApply_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectAffectAllXApplied>.NativeClassPtr, 100675301);
    StatusEffectAffectAllXApplied.NativeMethodInfoPtr_CheckTeamOfTarget_Private_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectAffectAllXApplied>.NativeClassPtr, 100675302);
    StatusEffectAffectAllXApplied.NativeMethodInfoPtr_CheckTeamOfApplier_Private_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectAffectAllXApplied>.NativeClassPtr, 100675303);
    StatusEffectAffectAllXApplied.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectAffectAllXApplied>.NativeClassPtr, 100675304);
  }

  public StatusEffectAffectAllXApplied(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe StatusEffectData effectToAffect
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectAffectAllXApplied.NativeFieldInfoPtr_effectToAffect));
      return pointer == IntPtr.Zero ? (StatusEffectData) null : new StatusEffectData(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectAffectAllXApplied.NativeFieldInfoPtr_effectToAffect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool setToSpecificValue
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectAffectAllXApplied.NativeFieldInfoPtr_setToSpecificValue));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectAffectAllXApplied.NativeFieldInfoPtr_setToSpecificValue)) = value;
    }
  }

  public unsafe int specificValue
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectAffectAllXApplied.NativeFieldInfoPtr_specificValue));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectAffectAllXApplied.NativeFieldInfoPtr_specificValue)) = value;
    }
  }

  public unsafe int add
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectAffectAllXApplied.NativeFieldInfoPtr_add));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectAffectAllXApplied.NativeFieldInfoPtr_add)) = value;
    }
  }

  public unsafe float multiplyBy
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectAffectAllXApplied.NativeFieldInfoPtr_multiplyBy));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectAffectAllXApplied.NativeFieldInfoPtr_multiplyBy)) = value;
    }
  }

  public unsafe bool targetCanBeFriendly
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectAffectAllXApplied.NativeFieldInfoPtr_targetCanBeFriendly));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectAffectAllXApplied.NativeFieldInfoPtr_targetCanBeFriendly)) = value;
    }
  }

  public unsafe bool targetCanBeEnemy
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectAffectAllXApplied.NativeFieldInfoPtr_targetCanBeEnemy));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectAffectAllXApplied.NativeFieldInfoPtr_targetCanBeEnemy)) = value;
    }
  }

  public unsafe bool applierCanBeFriendly
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectAffectAllXApplied.NativeFieldInfoPtr_applierCanBeFriendly));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectAffectAllXApplied.NativeFieldInfoPtr_applierCanBeFriendly)) = value;
    }
  }

  public unsafe bool applierCanBeEnemy
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectAffectAllXApplied.NativeFieldInfoPtr_applierCanBeEnemy));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectAffectAllXApplied.NativeFieldInfoPtr_applierCanBeEnemy)) = value;
    }
  }
}
