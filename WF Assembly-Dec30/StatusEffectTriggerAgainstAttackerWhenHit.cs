// Decompiled with JetBrains decompiler
// Type: StatusEffectTriggerAgainstAttackerWhenHit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
public class StatusEffectTriggerAgainstAttackerWhenHit : StatusEffectReaction
{
  private static readonly System.IntPtr NativeFieldInfoPtr_attacker;
  private static readonly System.IntPtr NativeFieldInfoPtr_previousTarget;
  private static readonly System.IntPtr NativeFieldInfoPtr_effectiveHealthState;
  private static readonly System.IntPtr NativeMethodInfoPtr_RunTurnEndEvent_Public_Virtual_Boolean_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RunHitEvent_Public_Virtual_Boolean_Hit_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RunCardPlayedEvent_Public_Virtual_Boolean_Entity_Il2CppReferenceArray_1_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Run_Private_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CalculateEffectiveHealthState_Private_Static_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetEffectiveHealth_Private_Static_Int32_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120532, XrefRangeEnd = 120538, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool RunTurnEndEvent(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectTriggerAgainstAttackerWhenHit.NativeMethodInfoPtr_RunTurnEndEvent_Public_Virtual_Boolean_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120538, XrefRangeEnd = 120553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool RunHitEvent(Hit hit)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hit)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectTriggerAgainstAttackerWhenHit.NativeMethodInfoPtr_RunHitEvent_Public_Virtual_Boolean_Hit_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120553, XrefRangeEnd = 120563, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool RunCardPlayedEvent(
    Entity entity,
    Il2CppReferenceArray<Entity> targets)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targets);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectTriggerAgainstAttackerWhenHit.NativeMethodInfoPtr_RunCardPlayedEvent_Public_Virtual_Boolean_Entity_Il2CppReferenceArray_1_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 120603, RefRangeEnd = 120604, XrefRangeStart = 120563, XrefRangeEnd = 120603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Run(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectTriggerAgainstAttackerWhenHit.NativeMethodInfoPtr_Run_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 120620, RefRangeEnd = 120621, XrefRangeStart = 120604, XrefRangeEnd = 120620, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int CalculateEffectiveHealthState()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectTriggerAgainstAttackerWhenHit.NativeMethodInfoPtr_CalculateEffectiveHealthState_Private_Static_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 120654, RefRangeEnd = 120655, XrefRangeStart = 120621, XrefRangeEnd = 120654, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int GetEffectiveHealth(Entity entity)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectTriggerAgainstAttackerWhenHit.NativeMethodInfoPtr_GetEffectiveHealth_Private_Static_Int32_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(23)]
  [CachedScanResults(RefRangeStart = 118133, RefRangeEnd = 118156, XrefRangeStart = 118133, XrefRangeEnd = 118156, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StatusEffectTriggerAgainstAttackerWhenHit()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusEffectTriggerAgainstAttackerWhenHit>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectTriggerAgainstAttackerWhenHit.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static StatusEffectTriggerAgainstAttackerWhenHit()
  {
    Il2CppClassPointerStore<StatusEffectTriggerAgainstAttackerWhenHit>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (StatusEffectTriggerAgainstAttackerWhenHit));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusEffectTriggerAgainstAttackerWhenHit>.NativeClassPtr);
    StatusEffectTriggerAgainstAttackerWhenHit.NativeFieldInfoPtr_attacker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectTriggerAgainstAttackerWhenHit>.NativeClassPtr, nameof (attacker));
    StatusEffectTriggerAgainstAttackerWhenHit.NativeFieldInfoPtr_previousTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectTriggerAgainstAttackerWhenHit>.NativeClassPtr, nameof (previousTarget));
    StatusEffectTriggerAgainstAttackerWhenHit.NativeFieldInfoPtr_effectiveHealthState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectTriggerAgainstAttackerWhenHit>.NativeClassPtr, nameof (effectiveHealthState));
    StatusEffectTriggerAgainstAttackerWhenHit.NativeMethodInfoPtr_RunTurnEndEvent_Public_Virtual_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectTriggerAgainstAttackerWhenHit>.NativeClassPtr, 100675251);
    StatusEffectTriggerAgainstAttackerWhenHit.NativeMethodInfoPtr_RunHitEvent_Public_Virtual_Boolean_Hit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectTriggerAgainstAttackerWhenHit>.NativeClassPtr, 100675252);
    StatusEffectTriggerAgainstAttackerWhenHit.NativeMethodInfoPtr_RunCardPlayedEvent_Public_Virtual_Boolean_Entity_Il2CppReferenceArray_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectTriggerAgainstAttackerWhenHit>.NativeClassPtr, 100675253);
    StatusEffectTriggerAgainstAttackerWhenHit.NativeMethodInfoPtr_Run_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectTriggerAgainstAttackerWhenHit>.NativeClassPtr, 100675254);
    StatusEffectTriggerAgainstAttackerWhenHit.NativeMethodInfoPtr_CalculateEffectiveHealthState_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectTriggerAgainstAttackerWhenHit>.NativeClassPtr, 100675255);
    StatusEffectTriggerAgainstAttackerWhenHit.NativeMethodInfoPtr_GetEffectiveHealth_Private_Static_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectTriggerAgainstAttackerWhenHit>.NativeClassPtr, 100675256);
    StatusEffectTriggerAgainstAttackerWhenHit.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectTriggerAgainstAttackerWhenHit>.NativeClassPtr, 100675257);
  }

  public StatusEffectTriggerAgainstAttackerWhenHit(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Entity attacker
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectTriggerAgainstAttackerWhenHit.NativeFieldInfoPtr_attacker));
      return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectTriggerAgainstAttackerWhenHit.NativeFieldInfoPtr_attacker), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Entity previousTarget
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectTriggerAgainstAttackerWhenHit.NativeFieldInfoPtr_previousTarget));
      return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectTriggerAgainstAttackerWhenHit.NativeFieldInfoPtr_previousTarget), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public Il2CppSystem.Nullable<int> effectiveHealthState
  {
    get
    {
      System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectTriggerAgainstAttackerWhenHit.NativeFieldInfoPtr_effectiveHealthState);
      return new Il2CppSystem.Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<int>>.NativeClassPtr, data));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectTriggerAgainstAttackerWhenHit.NativeFieldInfoPtr_effectiveHealthState), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }
}
