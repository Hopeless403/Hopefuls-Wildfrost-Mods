// Decompiled with JetBrains decompiler
// Type: CardUpgradeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Localization;

#nullable disable
public class CardUpgradeData : DataFile
{
  private static readonly System.IntPtr NativeFieldInfoPtr_tier;
  private static readonly System.IntPtr NativeFieldInfoPtr_titleKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_textKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_image;
  private static readonly System.IntPtr NativeFieldInfoPtr_type;
  private static readonly System.IntPtr NativeFieldInfoPtr_attackEffects;
  private static readonly System.IntPtr NativeFieldInfoPtr_effects;
  private static readonly System.IntPtr NativeFieldInfoPtr_giveTraits;
  private static readonly System.IntPtr NativeFieldInfoPtr_scripts;
  private static readonly System.IntPtr NativeFieldInfoPtr_becomesTargetedCard;
  private static readonly System.IntPtr NativeFieldInfoPtr_canBeRemoved;
  private static readonly System.IntPtr NativeFieldInfoPtr_targetConstraints;
  private static readonly System.IntPtr NativeFieldInfoPtr_damage;
  private static readonly System.IntPtr NativeFieldInfoPtr_hp;
  private static readonly System.IntPtr NativeFieldInfoPtr_counter;
  private static readonly System.IntPtr NativeFieldInfoPtr_uses;
  private static readonly System.IntPtr NativeFieldInfoPtr_effectBonus;
  private static readonly System.IntPtr NativeFieldInfoPtr_setDamage;
  private static readonly System.IntPtr NativeFieldInfoPtr_setHp;
  private static readonly System.IntPtr NativeFieldInfoPtr_setCounter;
  private static readonly System.IntPtr NativeFieldInfoPtr_setUses;
  private static readonly System.IntPtr NativeFieldInfoPtr_effectsAffected;
  private static readonly System.IntPtr NativeFieldInfoPtr_traitsAffected;
  private static readonly System.IntPtr NativeFieldInfoPtr_attackEffectsApplied;
  private static readonly System.IntPtr NativeFieldInfoPtr_startWithEffectsApplied;
  private static readonly System.IntPtr NativeFieldInfoPtr_damageChange;
  private static readonly System.IntPtr NativeFieldInfoPtr_hpChange;
  private static readonly System.IntPtr NativeFieldInfoPtr_counterChange;
  private static readonly System.IntPtr NativeFieldInfoPtr_usesChange;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_title_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_text_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Assign_Public_Void_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Assign_Public_IEnumerator_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnAssign_Public_Void_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CanAssign_Public_Boolean_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CanAssign_Public_Boolean_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Display_Public_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_CardUpgradeData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Virtual_Final_New_CardUpgradeSaveData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__CanAssign_b__37_2_Private_Boolean_CardUpgradeData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__CanAssign_b__37_3_Private_Boolean_CardUpgradeData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__CanAssign_b__37_4_Private_Boolean_CardUpgradeData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__CanAssign_b__38_2_Private_Boolean_CardUpgradeData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__CanAssign_b__38_3_Private_Boolean_CardUpgradeData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__CanAssign_b__38_4_Private_Boolean_CardUpgradeData_0;

  public unsafe string title
  {
    [CallerCount(8), CachedScanResults(RefRangeStart = 108561, RefRangeEnd = 108569, XrefRangeStart = 108559, XrefRangeEnd = 108561, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.NativeMethodInfoPtr_get_title_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }
  }

  public unsafe string text
  {
    [CallerCount(8), CachedScanResults(RefRangeStart = 108571, RefRangeEnd = 108579, XrefRangeStart = 108569, XrefRangeEnd = 108571, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.NativeMethodInfoPtr_get_text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }
  }

  [CallerCount(10)]
  [CachedScanResults(RefRangeStart = 108716, RefRangeEnd = 108726, XrefRangeStart = 108579, XrefRangeEnd = 108716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Assign(CardData cardData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cardData)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.NativeMethodInfoPtr_Assign_Public_Void_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 108732, RefRangeEnd = 108734, XrefRangeStart = 108726, XrefRangeEnd = 108732, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator Assign(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.NativeMethodInfoPtr_Assign_Public_IEnumerator_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 108815, RefRangeEnd = 108817, XrefRangeStart = 108734, XrefRangeEnd = 108815, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UnAssign(CardData assignedTo)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) assignedTo)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.NativeMethodInfoPtr_UnAssign_Public_Void_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 108881, RefRangeEnd = 108882, XrefRangeStart = 108817, XrefRangeEnd = 108881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool CanAssign(Entity card)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) card)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.NativeMethodInfoPtr_CanAssign_Public_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 108944, RefRangeEnd = 108952, XrefRangeStart = 108882, XrefRangeEnd = 108944, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool CanAssign(CardData cardData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cardData)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.NativeMethodInfoPtr_CanAssign_Public_Boolean_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 108966, RefRangeEnd = 108967, XrefRangeStart = 108952, XrefRangeEnd = 108966, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Display(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.NativeMethodInfoPtr_Display_Public_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(22)]
  [CachedScanResults(RefRangeStart = 108970, RefRangeEnd = 108992, XrefRangeStart = 108967, XrefRangeEnd = 108970, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardUpgradeData Clone()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.NativeMethodInfoPtr_Clone_Public_CardUpgradeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (CardUpgradeData) null : new CardUpgradeData(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108992, XrefRangeEnd = 108997, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe CardUpgradeSaveData Save()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.NativeMethodInfoPtr_Save_Public_Virtual_Final_New_CardUpgradeSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (CardUpgradeSaveData) null : new CardUpgradeSaveData(pointer);
  }

  [CallerCount(110)]
  [CachedScanResults(RefRangeStart = 104608, RefRangeEnd = 104718, XrefRangeStart = 104608, XrefRangeEnd = 104718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardUpgradeData()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public unsafe bool _CanAssign_b__37_2(CardUpgradeData a)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.NativeMethodInfoPtr__CanAssign_b__37_2_Private_Boolean_CardUpgradeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public unsafe bool _CanAssign_b__37_3(CardUpgradeData a)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.NativeMethodInfoPtr__CanAssign_b__37_3_Private_Boolean_CardUpgradeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public unsafe bool _CanAssign_b__37_4(CardUpgradeData a)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.NativeMethodInfoPtr__CanAssign_b__37_4_Private_Boolean_CardUpgradeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public unsafe bool _CanAssign_b__38_2(CardUpgradeData a)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.NativeMethodInfoPtr__CanAssign_b__38_2_Private_Boolean_CardUpgradeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public unsafe bool _CanAssign_b__38_3(CardUpgradeData a)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.NativeMethodInfoPtr__CanAssign_b__38_3_Private_Boolean_CardUpgradeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public unsafe bool _CanAssign_b__38_4(CardUpgradeData a)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.NativeMethodInfoPtr__CanAssign_b__38_4_Private_Boolean_CardUpgradeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  static CardUpgradeData()
  {
    Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CardUpgradeData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr);
    CardUpgradeData.NativeFieldInfoPtr_tier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, nameof (tier));
    CardUpgradeData.NativeFieldInfoPtr_titleKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, nameof (titleKey));
    CardUpgradeData.NativeFieldInfoPtr_textKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, nameof (textKey));
    CardUpgradeData.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, nameof (image));
    CardUpgradeData.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, nameof (type));
    CardUpgradeData.NativeFieldInfoPtr_attackEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, nameof (attackEffects));
    CardUpgradeData.NativeFieldInfoPtr_effects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, nameof (effects));
    CardUpgradeData.NativeFieldInfoPtr_giveTraits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, nameof (giveTraits));
    CardUpgradeData.NativeFieldInfoPtr_scripts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, nameof (scripts));
    CardUpgradeData.NativeFieldInfoPtr_becomesTargetedCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, nameof (becomesTargetedCard));
    CardUpgradeData.NativeFieldInfoPtr_canBeRemoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, nameof (canBeRemoved));
    CardUpgradeData.NativeFieldInfoPtr_targetConstraints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, nameof (targetConstraints));
    CardUpgradeData.NativeFieldInfoPtr_damage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, nameof (damage));
    CardUpgradeData.NativeFieldInfoPtr_hp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, nameof (hp));
    CardUpgradeData.NativeFieldInfoPtr_counter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, nameof (counter));
    CardUpgradeData.NativeFieldInfoPtr_uses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, nameof (uses));
    CardUpgradeData.NativeFieldInfoPtr_effectBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, nameof (effectBonus));
    CardUpgradeData.NativeFieldInfoPtr_setDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, nameof (setDamage));
    CardUpgradeData.NativeFieldInfoPtr_setHp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, nameof (setHp));
    CardUpgradeData.NativeFieldInfoPtr_setCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, nameof (setCounter));
    CardUpgradeData.NativeFieldInfoPtr_setUses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, nameof (setUses));
    CardUpgradeData.NativeFieldInfoPtr_effectsAffected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, nameof (effectsAffected));
    CardUpgradeData.NativeFieldInfoPtr_traitsAffected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, nameof (traitsAffected));
    CardUpgradeData.NativeFieldInfoPtr_attackEffectsApplied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, nameof (attackEffectsApplied));
    CardUpgradeData.NativeFieldInfoPtr_startWithEffectsApplied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, nameof (startWithEffectsApplied));
    CardUpgradeData.NativeFieldInfoPtr_damageChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, nameof (damageChange));
    CardUpgradeData.NativeFieldInfoPtr_hpChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, nameof (hpChange));
    CardUpgradeData.NativeFieldInfoPtr_counterChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, nameof (counterChange));
    CardUpgradeData.NativeFieldInfoPtr_usesChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, nameof (usesChange));
    CardUpgradeData.NativeMethodInfoPtr_get_title_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, 100673288);
    CardUpgradeData.NativeMethodInfoPtr_get_text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, 100673289);
    CardUpgradeData.NativeMethodInfoPtr_Assign_Public_Void_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, 100673290);
    CardUpgradeData.NativeMethodInfoPtr_Assign_Public_IEnumerator_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, 100673291);
    CardUpgradeData.NativeMethodInfoPtr_UnAssign_Public_Void_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, 100673292);
    CardUpgradeData.NativeMethodInfoPtr_CanAssign_Public_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, 100673293);
    CardUpgradeData.NativeMethodInfoPtr_CanAssign_Public_Boolean_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, 100673294);
    CardUpgradeData.NativeMethodInfoPtr_Display_Public_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, 100673295);
    CardUpgradeData.NativeMethodInfoPtr_Clone_Public_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, 100673296);
    CardUpgradeData.NativeMethodInfoPtr_Save_Public_Virtual_Final_New_CardUpgradeSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, 100673297);
    CardUpgradeData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, 100673298);
    CardUpgradeData.NativeMethodInfoPtr__CanAssign_b__37_2_Private_Boolean_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, 100673299);
    CardUpgradeData.NativeMethodInfoPtr__CanAssign_b__37_3_Private_Boolean_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, 100673300);
    CardUpgradeData.NativeMethodInfoPtr__CanAssign_b__37_4_Private_Boolean_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, 100673301);
    CardUpgradeData.NativeMethodInfoPtr__CanAssign_b__38_2_Private_Boolean_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, 100673302);
    CardUpgradeData.NativeMethodInfoPtr__CanAssign_b__38_3_Private_Boolean_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, 100673303);
    CardUpgradeData.NativeMethodInfoPtr__CanAssign_b__38_4_Private_Boolean_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, 100673304);
  }

  public CardUpgradeData(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe int tier
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_tier));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_tier)) = value;
    }
  }

  public unsafe LocalizedString titleKey
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_titleKey));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_titleKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString textKey
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_textKey));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_textKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite image
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_image));
      return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CardUpgradeData.Type type
  {
    get
    {
      return *(CardUpgradeData.Type*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_type));
    }
    [param: In] set
    {
      *(CardUpgradeData.Type*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_type)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<CardData.StatusEffectStacks> attackEffects
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_attackEffects));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CardData.StatusEffectStacks>) null : new Il2CppReferenceArray<CardData.StatusEffectStacks>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_attackEffects), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<CardData.StatusEffectStacks> effects
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_effects));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CardData.StatusEffectStacks>) null : new Il2CppReferenceArray<CardData.StatusEffectStacks>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_effects), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<CardData.TraitStacks> giveTraits
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_giveTraits));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CardData.TraitStacks>) null : new Il2CppReferenceArray<CardData.TraitStacks>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_giveTraits), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<CardScript> scripts
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_scripts));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CardScript>) null : new Il2CppReferenceArray<CardScript>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_scripts), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool becomesTargetedCard
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_becomesTargetedCard));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_becomesTargetedCard)) = value;
    }
  }

  public unsafe bool canBeRemoved
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_canBeRemoved));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_canBeRemoved)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<TargetConstraint> targetConstraints
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_targetConstraints));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<TargetConstraint>) null : new Il2CppReferenceArray<TargetConstraint>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_targetConstraints), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int damage
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_damage));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_damage)) = value;
    }
  }

  public unsafe int hp
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_hp));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_hp)) = value;
    }
  }

  public unsafe int counter
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_counter));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_counter)) = value;
    }
  }

  public unsafe int uses
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_uses));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_uses)) = value;
    }
  }

  public unsafe int effectBonus
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_effectBonus));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_effectBonus)) = value;
    }
  }

  public unsafe bool setDamage
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_setDamage));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_setDamage)) = value;
    }
  }

  public unsafe bool setHp
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_setHp));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_setHp)) = value;
    }
  }

  public unsafe bool setCounter
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_setCounter));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_setCounter)) = value;
    }
  }

  public unsafe bool setUses
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_setUses));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_setUses)) = value;
    }
  }

  public unsafe List<CardData.StatusEffectStacks> effectsAffected
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_effectsAffected));
      return pointer == System.IntPtr.Zero ? (List<CardData.StatusEffectStacks>) null : new List<CardData.StatusEffectStacks>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_effectsAffected), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<CardData.TraitStacks> traitsAffected
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_traitsAffected));
      return pointer == System.IntPtr.Zero ? (List<CardData.TraitStacks>) null : new List<CardData.TraitStacks>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_traitsAffected), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<CardData.StatusEffectStacks> attackEffectsApplied
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_attackEffectsApplied));
      return pointer == System.IntPtr.Zero ? (List<CardData.StatusEffectStacks>) null : new List<CardData.StatusEffectStacks>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_attackEffectsApplied), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<CardData.StatusEffectStacks> startWithEffectsApplied
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_startWithEffectsApplied));
      return pointer == System.IntPtr.Zero ? (List<CardData.StatusEffectStacks>) null : new List<CardData.StatusEffectStacks>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_startWithEffectsApplied), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int damageChange
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_damageChange));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_damageChange)) = value;
    }
  }

  public unsafe int hpChange
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_hpChange));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_hpChange)) = value;
    }
  }

  public unsafe int counterChange
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_counterChange));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_counterChange)) = value;
    }
  }

  public unsafe int usesChange
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_usesChange));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_usesChange)) = value;
    }
  }

  public enum Type
  {
    None,
    Charm,
    Token,
    Crown,
  }

  [ObfuscatedName("CardUpgradeData/<>c__DisplayClass34_0")]
  public sealed class __c__DisplayClass34_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_e;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Assign_b__0_Internal_Boolean_StatusEffectStacks_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Assign_b__1_Internal_Boolean_StatusEffectStacks_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass34_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass34_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108517, XrefRangeEnd = 108522, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _Assign_b__0(CardData.StatusEffectStacks a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.__c__DisplayClass34_0.NativeMethodInfoPtr__Assign_b__0_Internal_Boolean_StatusEffectStacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108522, XrefRangeEnd = 108527, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _Assign_b__1(CardData.StatusEffectStacks a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.__c__DisplayClass34_0.NativeMethodInfoPtr__Assign_b__1_Internal_Boolean_StatusEffectStacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass34_0()
    {
      Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass34_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, "<>c__DisplayClass34_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass34_0>.NativeClassPtr);
      CardUpgradeData.__c__DisplayClass34_0.NativeFieldInfoPtr_e = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass34_0>.NativeClassPtr, nameof (e));
      CardUpgradeData.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass34_0>.NativeClassPtr, 100673305);
      CardUpgradeData.__c__DisplayClass34_0.NativeMethodInfoPtr__Assign_b__0_Internal_Boolean_StatusEffectStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass34_0>.NativeClassPtr, 100673306);
      CardUpgradeData.__c__DisplayClass34_0.NativeMethodInfoPtr__Assign_b__1_Internal_Boolean_StatusEffectStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass34_0>.NativeClassPtr, 100673307);
    }

    public __c__DisplayClass34_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CardData.StatusEffectStacks e
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.__c__DisplayClass34_0.NativeFieldInfoPtr_e));
        return pointer == System.IntPtr.Zero ? (CardData.StatusEffectStacks) null : new CardData.StatusEffectStacks(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.__c__DisplayClass34_0.NativeFieldInfoPtr_e), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("CardUpgradeData/<>c__DisplayClass34_1")]
  public sealed class __c__DisplayClass34_1 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_e;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Assign_b__2_Internal_Boolean_StatusEffectStacks_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Assign_b__3_Internal_Boolean_StatusEffectStacks_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass34_1()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass34_1>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.__c__DisplayClass34_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108527, XrefRangeEnd = 108532, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _Assign_b__2(CardData.StatusEffectStacks a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.__c__DisplayClass34_1.NativeMethodInfoPtr__Assign_b__2_Internal_Boolean_StatusEffectStacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108532, XrefRangeEnd = 108537, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _Assign_b__3(CardData.StatusEffectStacks a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.__c__DisplayClass34_1.NativeMethodInfoPtr__Assign_b__3_Internal_Boolean_StatusEffectStacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass34_1()
    {
      Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass34_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, "<>c__DisplayClass34_1");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass34_1>.NativeClassPtr);
      CardUpgradeData.__c__DisplayClass34_1.NativeFieldInfoPtr_e = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass34_1>.NativeClassPtr, nameof (e));
      CardUpgradeData.__c__DisplayClass34_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass34_1>.NativeClassPtr, 100673308);
      CardUpgradeData.__c__DisplayClass34_1.NativeMethodInfoPtr__Assign_b__2_Internal_Boolean_StatusEffectStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass34_1>.NativeClassPtr, 100673309);
      CardUpgradeData.__c__DisplayClass34_1.NativeMethodInfoPtr__Assign_b__3_Internal_Boolean_StatusEffectStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass34_1>.NativeClassPtr, 100673310);
    }

    public __c__DisplayClass34_1(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CardData.StatusEffectStacks e
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.__c__DisplayClass34_1.NativeFieldInfoPtr_e));
        return pointer == System.IntPtr.Zero ? (CardData.StatusEffectStacks) null : new CardData.StatusEffectStacks(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.__c__DisplayClass34_1.NativeFieldInfoPtr_e), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("CardUpgradeData/<Assign>d__35")]
  public sealed class _Assign_d__35 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr_entity;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _Assign_d__35(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardUpgradeData._Assign_d__35>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardUpgradeData._Assign_d__35.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardUpgradeData._Assign_d__35.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108537, XrefRangeEnd = 108538, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData._Assign_d__35.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData._Assign_d__35.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108538, XrefRangeEnd = 108544, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardUpgradeData._Assign_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData._Assign_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _Assign_d__35()
    {
      Il2CppClassPointerStore<CardUpgradeData._Assign_d__35>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, "<Assign>d__35");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardUpgradeData._Assign_d__35>.NativeClassPtr);
      CardUpgradeData._Assign_d__35.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData._Assign_d__35>.NativeClassPtr, "<>1__state");
      CardUpgradeData._Assign_d__35.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData._Assign_d__35>.NativeClassPtr, "<>2__current");
      CardUpgradeData._Assign_d__35.NativeFieldInfoPtr_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData._Assign_d__35>.NativeClassPtr, nameof (entity));
      CardUpgradeData._Assign_d__35.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData._Assign_d__35>.NativeClassPtr, "<>4__this");
      CardUpgradeData._Assign_d__35.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData._Assign_d__35>.NativeClassPtr, 100673311);
      CardUpgradeData._Assign_d__35.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData._Assign_d__35>.NativeClassPtr, 100673312);
      CardUpgradeData._Assign_d__35.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData._Assign_d__35>.NativeClassPtr, 100673313);
      CardUpgradeData._Assign_d__35.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData._Assign_d__35>.NativeClassPtr, 100673314);
      CardUpgradeData._Assign_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData._Assign_d__35>.NativeClassPtr, 100673315);
      CardUpgradeData._Assign_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData._Assign_d__35>.NativeClassPtr, 100673316);
    }

    public _Assign_d__35(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData._Assign_d__35.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData._Assign_d__35.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData._Assign_d__35.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData._Assign_d__35.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Entity entity
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData._Assign_d__35.NativeFieldInfoPtr_entity));
        return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData._Assign_d__35.NativeFieldInfoPtr_entity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CardUpgradeData __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData._Assign_d__35.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (CardUpgradeData) null : new CardUpgradeData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData._Assign_d__35.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("CardUpgradeData/<>c__DisplayClass36_0")]
  public sealed class __c__DisplayClass36_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_e;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__UnAssign_b__0_Internal_Boolean_StatusEffectStacks_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass36_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass36_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108544, XrefRangeEnd = 108549, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _UnAssign_b__0(CardData.StatusEffectStacks a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.__c__DisplayClass36_0.NativeMethodInfoPtr__UnAssign_b__0_Internal_Boolean_StatusEffectStacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass36_0()
    {
      Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass36_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, "<>c__DisplayClass36_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass36_0>.NativeClassPtr);
      CardUpgradeData.__c__DisplayClass36_0.NativeFieldInfoPtr_e = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass36_0>.NativeClassPtr, nameof (e));
      CardUpgradeData.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass36_0>.NativeClassPtr, 100673317);
      CardUpgradeData.__c__DisplayClass36_0.NativeMethodInfoPtr__UnAssign_b__0_Internal_Boolean_StatusEffectStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass36_0>.NativeClassPtr, 100673318);
    }

    public __c__DisplayClass36_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CardData.StatusEffectStacks e
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.__c__DisplayClass36_0.NativeFieldInfoPtr_e));
        return pointer == System.IntPtr.Zero ? (CardData.StatusEffectStacks) null : new CardData.StatusEffectStacks(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.__c__DisplayClass36_0.NativeFieldInfoPtr_e), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("CardUpgradeData/<>c__DisplayClass36_1")]
  public sealed class __c__DisplayClass36_1 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_e;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__UnAssign_b__1_Internal_Boolean_StatusEffectStacks_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass36_1()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass36_1>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.__c__DisplayClass36_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108549, XrefRangeEnd = 108554, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _UnAssign_b__1(CardData.StatusEffectStacks a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.__c__DisplayClass36_1.NativeMethodInfoPtr__UnAssign_b__1_Internal_Boolean_StatusEffectStacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass36_1()
    {
      Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass36_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, "<>c__DisplayClass36_1");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass36_1>.NativeClassPtr);
      CardUpgradeData.__c__DisplayClass36_1.NativeFieldInfoPtr_e = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass36_1>.NativeClassPtr, nameof (e));
      CardUpgradeData.__c__DisplayClass36_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass36_1>.NativeClassPtr, 100673319);
      CardUpgradeData.__c__DisplayClass36_1.NativeMethodInfoPtr__UnAssign_b__1_Internal_Boolean_StatusEffectStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass36_1>.NativeClassPtr, 100673320);
    }

    public __c__DisplayClass36_1(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CardData.StatusEffectStacks e
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.__c__DisplayClass36_1.NativeFieldInfoPtr_e));
        return pointer == System.IntPtr.Zero ? (CardData.StatusEffectStacks) null : new CardData.StatusEffectStacks(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.__c__DisplayClass36_1.NativeFieldInfoPtr_e), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("CardUpgradeData/<>c__DisplayClass37_0")]
  public sealed class __c__DisplayClass37_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_t;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__CanAssign_b__1_Internal_Boolean_TraitStacks_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass37_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass37_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108554, XrefRangeEnd = 108558, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _CanAssign_b__1(CardData.TraitStacks a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.__c__DisplayClass37_0.NativeMethodInfoPtr__CanAssign_b__1_Internal_Boolean_TraitStacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass37_0()
    {
      Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass37_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, "<>c__DisplayClass37_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass37_0>.NativeClassPtr);
      CardUpgradeData.__c__DisplayClass37_0.NativeFieldInfoPtr_t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass37_0>.NativeClassPtr, nameof (t));
      CardUpgradeData.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass37_0>.NativeClassPtr, 100673321);
      CardUpgradeData.__c__DisplayClass37_0.NativeMethodInfoPtr__CanAssign_b__1_Internal_Boolean_TraitStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass37_0>.NativeClassPtr, 100673322);
    }

    public __c__DisplayClass37_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CardData.TraitStacks t
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.__c__DisplayClass37_0.NativeFieldInfoPtr_t));
        return pointer == System.IntPtr.Zero ? (CardData.TraitStacks) null : new CardData.TraitStacks(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.__c__DisplayClass37_0.NativeFieldInfoPtr_t), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("CardUpgradeData/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__37_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__38_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__CanAssign_b__37_0_Internal_Boolean_TraitStacks_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__CanAssign_b__38_0_Internal_Boolean_TraitStacks_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardUpgradeData.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _CanAssign_b__37_0(CardData.TraitStacks t)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) t)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.__c.NativeMethodInfoPtr__CanAssign_b__37_0_Internal_Boolean_TraitStacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe bool _CanAssign_b__38_0(CardData.TraitStacks t)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) t)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.__c.NativeMethodInfoPtr__CanAssign_b__38_0_Internal_Boolean_TraitStacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c()
    {
      Il2CppClassPointerStore<CardUpgradeData.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardUpgradeData.__c>.NativeClassPtr);
      CardUpgradeData.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData.__c>.NativeClassPtr, "<>9");
      CardUpgradeData.__c.NativeFieldInfoPtr___9__37_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData.__c>.NativeClassPtr, "<>9__37_0");
      CardUpgradeData.__c.NativeFieldInfoPtr___9__38_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData.__c>.NativeClassPtr, "<>9__38_0");
      CardUpgradeData.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData.__c>.NativeClassPtr, 100673324);
      CardUpgradeData.__c.NativeMethodInfoPtr__CanAssign_b__37_0_Internal_Boolean_TraitStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData.__c>.NativeClassPtr, 100673325);
      CardUpgradeData.__c.NativeMethodInfoPtr__CanAssign_b__38_0_Internal_Boolean_TraitStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData.__c>.NativeClassPtr, 100673326);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe CardUpgradeData.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(CardUpgradeData.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (CardUpgradeData.__c) null : new CardUpgradeData.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CardUpgradeData.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<CardData.TraitStacks, bool> __9__37_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(CardUpgradeData.__c.NativeFieldInfoPtr___9__37_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<CardData.TraitStacks, bool>) null : new Il2CppSystem.Func<CardData.TraitStacks, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CardUpgradeData.__c.NativeFieldInfoPtr___9__37_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<CardData.TraitStacks, bool> __9__38_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(CardUpgradeData.__c.NativeFieldInfoPtr___9__38_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<CardData.TraitStacks, bool>) null : new Il2CppSystem.Func<CardData.TraitStacks, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CardUpgradeData.__c.NativeFieldInfoPtr___9__38_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("CardUpgradeData/<>c__DisplayClass38_0")]
  public sealed class __c__DisplayClass38_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_t;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__CanAssign_b__1_Internal_Boolean_TraitStacks_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass38_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass38_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108558, XrefRangeEnd = 108559, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _CanAssign_b__1(CardData.TraitStacks a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.__c__DisplayClass38_0.NativeMethodInfoPtr__CanAssign_b__1_Internal_Boolean_TraitStacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass38_0()
    {
      Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass38_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, "<>c__DisplayClass38_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass38_0>.NativeClassPtr);
      CardUpgradeData.__c__DisplayClass38_0.NativeFieldInfoPtr_t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass38_0>.NativeClassPtr, nameof (t));
      CardUpgradeData.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass38_0>.NativeClassPtr, 100673327);
      CardUpgradeData.__c__DisplayClass38_0.NativeMethodInfoPtr__CanAssign_b__1_Internal_Boolean_TraitStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass38_0>.NativeClassPtr, 100673328);
    }

    public __c__DisplayClass38_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CardData.TraitStacks t
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.__c__DisplayClass38_0.NativeFieldInfoPtr_t));
        return pointer == System.IntPtr.Zero ? (CardData.TraitStacks) null : new CardData.TraitStacks(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardUpgradeData.__c__DisplayClass38_0.NativeFieldInfoPtr_t), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
