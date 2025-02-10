// Decompiled with JetBrains decompiler
// Type: StatusEffectTriggerWhenAllyAttacks
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class StatusEffectTriggerWhenAllyAttacks : StatusEffectReaction
{
  private static readonly IntPtr NativeFieldInfoPtr_allyInRow;
  private static readonly IntPtr NativeFieldInfoPtr_againstTarget;
  private static readonly IntPtr NativeFieldInfoPtr_prime;
  private static readonly IntPtr NativeMethodInfoPtr_RunHitEvent_Public_Virtual_Boolean_Hit_0;
  private static readonly IntPtr NativeMethodInfoPtr_RunCardPlayedEvent_Public_Virtual_Boolean_Entity_Il2CppReferenceArray_1_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_Run_Private_Void_Entity_Il2CppReferenceArray_1_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_CheckEntity_Private_Boolean_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_CheckRow_Private_Boolean_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_CheckDuplicate_Private_Boolean_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120655, XrefRangeEnd = 120679, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool RunHitEvent(Hit hit)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hit)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectTriggerWhenAllyAttacks.NativeMethodInfoPtr_RunHitEvent_Public_Virtual_Boolean_Hit_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120679, XrefRangeEnd = 120697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool RunCardPlayedEvent(
    Entity entity,
    Il2CppReferenceArray<Entity> targets)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targets);
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectTriggerWhenAllyAttacks.NativeMethodInfoPtr_RunCardPlayedEvent_Public_Virtual_Boolean_Entity_Il2CppReferenceArray_1_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120697, XrefRangeEnd = 120706, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Run(Entity attacker, Il2CppReferenceArray<Entity> targets)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attacker);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targets);
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectTriggerWhenAllyAttacks.NativeMethodInfoPtr_Run_Private_Void_Entity_Il2CppReferenceArray_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120706, XrefRangeEnd = 120721, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool CheckEntity(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectTriggerWhenAllyAttacks.NativeMethodInfoPtr_CheckEntity_Private_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120721, XrefRangeEnd = 120722, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool CheckRow(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectTriggerWhenAllyAttacks.NativeMethodInfoPtr_CheckRow_Private_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 120736, RefRangeEnd = 120740, XrefRangeStart = 120722, XrefRangeEnd = 120736, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool CheckDuplicate(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectTriggerWhenAllyAttacks.NativeMethodInfoPtr_CheckDuplicate_Private_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120740, XrefRangeEnd = 120749, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StatusEffectTriggerWhenAllyAttacks()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusEffectTriggerWhenAllyAttacks>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectTriggerWhenAllyAttacks.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static StatusEffectTriggerWhenAllyAttacks()
  {
    Il2CppClassPointerStore<StatusEffectTriggerWhenAllyAttacks>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (StatusEffectTriggerWhenAllyAttacks));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusEffectTriggerWhenAllyAttacks>.NativeClassPtr);
    StatusEffectTriggerWhenAllyAttacks.NativeFieldInfoPtr_allyInRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectTriggerWhenAllyAttacks>.NativeClassPtr, nameof (allyInRow));
    StatusEffectTriggerWhenAllyAttacks.NativeFieldInfoPtr_againstTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectTriggerWhenAllyAttacks>.NativeClassPtr, nameof (againstTarget));
    StatusEffectTriggerWhenAllyAttacks.NativeFieldInfoPtr_prime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectTriggerWhenAllyAttacks>.NativeClassPtr, nameof (prime));
    StatusEffectTriggerWhenAllyAttacks.NativeMethodInfoPtr_RunHitEvent_Public_Virtual_Boolean_Hit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectTriggerWhenAllyAttacks>.NativeClassPtr, 100675258);
    StatusEffectTriggerWhenAllyAttacks.NativeMethodInfoPtr_RunCardPlayedEvent_Public_Virtual_Boolean_Entity_Il2CppReferenceArray_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectTriggerWhenAllyAttacks>.NativeClassPtr, 100675259);
    StatusEffectTriggerWhenAllyAttacks.NativeMethodInfoPtr_Run_Private_Void_Entity_Il2CppReferenceArray_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectTriggerWhenAllyAttacks>.NativeClassPtr, 100675260);
    StatusEffectTriggerWhenAllyAttacks.NativeMethodInfoPtr_CheckEntity_Private_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectTriggerWhenAllyAttacks>.NativeClassPtr, 100675261);
    StatusEffectTriggerWhenAllyAttacks.NativeMethodInfoPtr_CheckRow_Private_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectTriggerWhenAllyAttacks>.NativeClassPtr, 100675262);
    StatusEffectTriggerWhenAllyAttacks.NativeMethodInfoPtr_CheckDuplicate_Private_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectTriggerWhenAllyAttacks>.NativeClassPtr, 100675263);
    StatusEffectTriggerWhenAllyAttacks.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectTriggerWhenAllyAttacks>.NativeClassPtr, 100675264);
  }

  public StatusEffectTriggerWhenAllyAttacks(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe bool allyInRow
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectTriggerWhenAllyAttacks.NativeFieldInfoPtr_allyInRow));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectTriggerWhenAllyAttacks.NativeFieldInfoPtr_allyInRow)) = value;
    }
  }

  public unsafe bool againstTarget
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectTriggerWhenAllyAttacks.NativeFieldInfoPtr_againstTarget));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectTriggerWhenAllyAttacks.NativeFieldInfoPtr_againstTarget)) = value;
    }
  }

  public unsafe HashSet<Entity> prime
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectTriggerWhenAllyAttacks.NativeFieldInfoPtr_prime));
      return pointer == IntPtr.Zero ? (HashSet<Entity>) null : new HashSet<Entity>(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectTriggerWhenAllyAttacks.NativeFieldInfoPtr_prime), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
