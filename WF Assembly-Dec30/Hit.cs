// Decompiled with JetBrains decompiler
// Type: Hit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;

#nullable disable
public class Hit : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_attacker;
  private static readonly System.IntPtr NativeFieldInfoPtr_owner;
  private static readonly System.IntPtr NativeFieldInfoPtr_target;
  private static readonly System.IntPtr NativeFieldInfoPtr_damageType;
  private static readonly System.IntPtr NativeFieldInfoPtr_trigger;
  private static readonly System.IntPtr NativeFieldInfoPtr_damage;
  private static readonly System.IntPtr NativeFieldInfoPtr_damageBlocked;
  private static readonly System.IntPtr NativeFieldInfoPtr__damageDealt_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr_counterReduction;
  private static readonly System.IntPtr NativeFieldInfoPtr_screenShake;
  private static readonly System.IntPtr NativeFieldInfoPtr_countsAsHit;
  private static readonly System.IntPtr NativeFieldInfoPtr_canBeNullified;
  private static readonly System.IntPtr NativeFieldInfoPtr_nullified;
  private static readonly System.IntPtr NativeFieldInfoPtr_statusEffects;
  private static readonly System.IntPtr NativeFieldInfoPtr_doAnimation;
  private static readonly System.IntPtr NativeFieldInfoPtr_canRetaliate;
  private static readonly System.IntPtr NativeFieldInfoPtr_dodged;
  private static readonly System.IntPtr NativeFieldInfoPtr__Offensive_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr_extraOffensiveness;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_damageDealt_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_damageDealt_Private_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Offensive_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Offensive_Private_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetOffensiveness_Public_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Supportive_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSupportiveness_Public_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_BasicHit_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Entity_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Entity_Entity_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddAttackerStatuses_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CalculateAttackEffectAmount_Private_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddStatusEffect_Public_Void_StatusEffectStacks_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddStatusEffect_Public_Void_StatusEffectData_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Process_Public_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FlagAsOffensive_Public_Void_0;

  public unsafe int damageDealt
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Hit.NativeMethodInfoPtr_get_damageDealt_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Hit.NativeMethodInfoPtr_set_damageDealt_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public unsafe bool Offensive
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Hit.NativeMethodInfoPtr_get_Offensive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Hit.NativeMethodInfoPtr_set_Offensive_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 103202, RefRangeEnd = 103204, XrefRangeStart = 103188, XrefRangeEnd = 103202, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int GetOffensiveness()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Hit.NativeMethodInfoPtr_GetOffensiveness_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  public unsafe bool Supportive
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103204, XrefRangeEnd = 103220, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Hit.NativeMethodInfoPtr_get_Supportive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103220, XrefRangeEnd = 103234, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int GetSupportiveness()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Hit.NativeMethodInfoPtr_GetSupportiveness_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  public unsafe bool BasicHit
  {
    [CallerCount(9), CachedScanResults(RefRangeStart = 103237, RefRangeEnd = 103246, XrefRangeStart = 103234, XrefRangeEnd = 103237, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Hit.NativeMethodInfoPtr_get_BasicHit_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 103262, RefRangeEnd = 103268, XrefRangeStart = 103246, XrefRangeEnd = 103262, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Hit(Entity attacker, Entity target)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hit>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attacker);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Hit.NativeMethodInfoPtr__ctor_Public_Void_Entity_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(13)]
  [CachedScanResults(RefRangeStart = 103280, RefRangeEnd = 103293, XrefRangeStart = 103268, XrefRangeEnd = 103280, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Hit(Entity attacker, Entity target, int damage)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hit>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attacker);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &damage;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Hit.NativeMethodInfoPtr__ctor_Public_Void_Entity_Entity_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 103323, RefRangeEnd = 103328, XrefRangeStart = 103293, XrefRangeEnd = 103323, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddAttackerStatuses()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Hit.NativeMethodInfoPtr_AddAttackerStatuses_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103328, XrefRangeEnd = 103329, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int CalculateAttackEffectAmount(int statusEffectStacks)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &statusEffectStacks
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Hit.NativeMethodInfoPtr_CalculateAttackEffectAmount_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103329, XrefRangeEnd = 103339, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddStatusEffect(CardData.StatusEffectStacks statusEffect)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) statusEffect)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Hit.NativeMethodInfoPtr_AddStatusEffect_Public_Void_StatusEffectStacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(9)]
  [CachedScanResults(RefRangeStart = 103354, RefRangeEnd = 103363, XrefRangeStart = 103339, XrefRangeEnd = 103354, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddStatusEffect(StatusEffectData statusEffectData, int count)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) statusEffectData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Hit.NativeMethodInfoPtr_AddStatusEffect_Public_Void_StatusEffectData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(14)]
  [CachedScanResults(RefRangeStart = 103368, RefRangeEnd = 103382, XrefRangeStart = 103363, XrefRangeEnd = 103368, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator Process()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Hit.NativeMethodInfoPtr_Process_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 103382, RefRangeEnd = 103385, XrefRangeStart = 103382, XrefRangeEnd = 103382, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FlagAsOffensive()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Hit.NativeMethodInfoPtr_FlagAsOffensive_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static Hit()
  {
    Il2CppClassPointerStore<Hit>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (Hit));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hit>.NativeClassPtr);
    Hit.NativeFieldInfoPtr_attacker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hit>.NativeClassPtr, nameof (attacker));
    Hit.NativeFieldInfoPtr_owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hit>.NativeClassPtr, nameof (owner));
    Hit.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hit>.NativeClassPtr, nameof (target));
    Hit.NativeFieldInfoPtr_damageType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hit>.NativeClassPtr, nameof (damageType));
    Hit.NativeFieldInfoPtr_trigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hit>.NativeClassPtr, nameof (trigger));
    Hit.NativeFieldInfoPtr_damage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hit>.NativeClassPtr, nameof (damage));
    Hit.NativeFieldInfoPtr_damageBlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hit>.NativeClassPtr, nameof (damageBlocked));
    Hit.NativeFieldInfoPtr__damageDealt_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hit>.NativeClassPtr, "<damageDealt>k__BackingField");
    Hit.NativeFieldInfoPtr_counterReduction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hit>.NativeClassPtr, nameof (counterReduction));
    Hit.NativeFieldInfoPtr_screenShake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hit>.NativeClassPtr, nameof (screenShake));
    Hit.NativeFieldInfoPtr_countsAsHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hit>.NativeClassPtr, nameof (countsAsHit));
    Hit.NativeFieldInfoPtr_canBeNullified = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hit>.NativeClassPtr, nameof (canBeNullified));
    Hit.NativeFieldInfoPtr_nullified = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hit>.NativeClassPtr, nameof (nullified));
    Hit.NativeFieldInfoPtr_statusEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hit>.NativeClassPtr, nameof (statusEffects));
    Hit.NativeFieldInfoPtr_doAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hit>.NativeClassPtr, nameof (doAnimation));
    Hit.NativeFieldInfoPtr_canRetaliate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hit>.NativeClassPtr, nameof (canRetaliate));
    Hit.NativeFieldInfoPtr_dodged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hit>.NativeClassPtr, nameof (dodged));
    Hit.NativeFieldInfoPtr__Offensive_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hit>.NativeClassPtr, "<Offensive>k__BackingField");
    Hit.NativeFieldInfoPtr_extraOffensiveness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hit>.NativeClassPtr, nameof (extraOffensiveness));
    Hit.NativeMethodInfoPtr_get_damageDealt_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hit>.NativeClassPtr, 100672584);
    Hit.NativeMethodInfoPtr_set_damageDealt_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hit>.NativeClassPtr, 100672585);
    Hit.NativeMethodInfoPtr_get_Offensive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hit>.NativeClassPtr, 100672586);
    Hit.NativeMethodInfoPtr_set_Offensive_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hit>.NativeClassPtr, 100672587);
    Hit.NativeMethodInfoPtr_GetOffensiveness_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hit>.NativeClassPtr, 100672588);
    Hit.NativeMethodInfoPtr_get_Supportive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hit>.NativeClassPtr, 100672589);
    Hit.NativeMethodInfoPtr_GetSupportiveness_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hit>.NativeClassPtr, 100672590);
    Hit.NativeMethodInfoPtr_get_BasicHit_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hit>.NativeClassPtr, 100672591);
    Hit.NativeMethodInfoPtr__ctor_Public_Void_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hit>.NativeClassPtr, 100672592);
    Hit.NativeMethodInfoPtr__ctor_Public_Void_Entity_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hit>.NativeClassPtr, 100672593);
    Hit.NativeMethodInfoPtr_AddAttackerStatuses_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hit>.NativeClassPtr, 100672594);
    Hit.NativeMethodInfoPtr_CalculateAttackEffectAmount_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hit>.NativeClassPtr, 100672595);
    Hit.NativeMethodInfoPtr_AddStatusEffect_Public_Void_StatusEffectStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hit>.NativeClassPtr, 100672596);
    Hit.NativeMethodInfoPtr_AddStatusEffect_Public_Void_StatusEffectData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hit>.NativeClassPtr, 100672597);
    Hit.NativeMethodInfoPtr_Process_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hit>.NativeClassPtr, 100672598);
    Hit.NativeMethodInfoPtr_FlagAsOffensive_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hit>.NativeClassPtr, 100672599);
  }

  public Hit(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Entity attacker
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_attacker));
      return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_attacker), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Character owner
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_owner));
      return pointer == System.IntPtr.Zero ? (Character) null : new Character(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_owner), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Entity target
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_target));
      return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string damageType
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_damageType)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_damageType), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe Trigger trigger
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_trigger));
      return pointer == System.IntPtr.Zero ? (Trigger) null : new Trigger(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_trigger), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int damage
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_damage));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_damage)) = value;
    }
  }

  public unsafe int damageBlocked
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_damageBlocked));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_damageBlocked)) = value;
    }
  }

  public unsafe int _damageDealt_k__BackingField
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr__damageDealt_k__BackingField));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr__damageDealt_k__BackingField)) = value;
    }
  }

  public unsafe int counterReduction
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_counterReduction));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_counterReduction)) = value;
    }
  }

  public unsafe float screenShake
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_screenShake));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_screenShake)) = value;
    }
  }

  public unsafe bool countsAsHit
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_countsAsHit));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_countsAsHit)) = value;
    }
  }

  public unsafe bool canBeNullified
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_canBeNullified));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_canBeNullified)) = value;
    }
  }

  public unsafe bool nullified
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_nullified));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_nullified)) = value;
    }
  }

  public unsafe List<CardData.StatusEffectStacks> statusEffects
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_statusEffects));
      return pointer == System.IntPtr.Zero ? (List<CardData.StatusEffectStacks>) null : new List<CardData.StatusEffectStacks>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_statusEffects), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool doAnimation
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_doAnimation));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_doAnimation)) = value;
    }
  }

  public unsafe bool canRetaliate
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_canRetaliate));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_canRetaliate)) = value;
    }
  }

  public unsafe bool dodged
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_dodged));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_dodged)) = value;
    }
  }

  public unsafe bool _Offensive_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr__Offensive_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr__Offensive_k__BackingField)) = value;
    }
  }

  public unsafe int extraOffensiveness
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_extraOffensiveness));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_extraOffensiveness)) = value;
    }
  }

  [ObfuscatedName("Hit/<Process>d__37")]
  public sealed class _Process_d__37 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _Process_d__37(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hit._Process_d__37>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Hit._Process_d__37.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Hit._Process_d__37.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103131, XrefRangeEnd = 103182, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Hit._Process_d__37.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Hit._Process_d__37.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103182, XrefRangeEnd = 103188, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Hit._Process_d__37.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Hit._Process_d__37.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _Process_d__37()
    {
      Il2CppClassPointerStore<Hit._Process_d__37>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Hit>.NativeClassPtr, "<Process>d__37");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hit._Process_d__37>.NativeClassPtr);
      Hit._Process_d__37.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hit._Process_d__37>.NativeClassPtr, "<>1__state");
      Hit._Process_d__37.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hit._Process_d__37>.NativeClassPtr, "<>2__current");
      Hit._Process_d__37.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hit._Process_d__37>.NativeClassPtr, "<>4__this");
      Hit._Process_d__37.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hit._Process_d__37>.NativeClassPtr, 100672600);
      Hit._Process_d__37.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hit._Process_d__37>.NativeClassPtr, 100672601);
      Hit._Process_d__37.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hit._Process_d__37>.NativeClassPtr, 100672602);
      Hit._Process_d__37.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hit._Process_d__37>.NativeClassPtr, 100672603);
      Hit._Process_d__37.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hit._Process_d__37>.NativeClassPtr, 100672604);
      Hit._Process_d__37.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hit._Process_d__37>.NativeClassPtr, 100672605);
    }

    public _Process_d__37(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hit._Process_d__37.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hit._Process_d__37.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hit._Process_d__37.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Hit._Process_d__37.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Hit __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hit._Process_d__37.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (Hit) null : new Hit(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Hit._Process_d__37.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
