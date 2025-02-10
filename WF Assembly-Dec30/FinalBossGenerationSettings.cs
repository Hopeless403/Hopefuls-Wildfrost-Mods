// Decompiled with JetBrains decompiler
// Type: FinalBossGenerationSettings
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
using UnityEngine;

#nullable disable
public class FinalBossGenerationSettings : ScriptableObject
{
  private static readonly System.IntPtr NativeFieldInfoPtr_replaceCards;
  private static readonly System.IntPtr NativeFieldInfoPtr_ignoreUpgrades;
  private static readonly System.IntPtr NativeFieldInfoPtr_ignoreTraits;
  private static readonly System.IntPtr NativeFieldInfoPtr_effectSwappers;
  private static readonly System.IntPtr NativeFieldInfoPtr_runOnAll;
  private static readonly System.IntPtr NativeFieldInfoPtr_cardModifiers;
  private static readonly System.IntPtr NativeFieldInfoPtr_leaderScripts;
  private static readonly System.IntPtr NativeFieldInfoPtr_enemyOptions;
  private static readonly System.IntPtr NativeMethodInfoPtr_ReplaceCards_Public_Void_IList_1_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Process_Public_Void_CardData_IList_1_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GenerateBonusEnemies_Public_IEnumerable_1_CardData_Int32_IEnumerable_1_CardData_Il2CppReferenceArray_1_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveInjuries_Private_Static_Void_IEnumerable_1_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveUpgrades_Private_Void_IList_1_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessEffects_Private_Void_IEnumerable_1_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveTraits_Private_Void_IList_1_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RunScripts_Private_Void_CardData_IList_1_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 109184, RefRangeEnd = 109185, XrefRangeStart = 109145, XrefRangeEnd = 109184, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ReplaceCards(IList<CardData> cards)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cards)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FinalBossGenerationSettings.NativeMethodInfoPtr_ReplaceCards_Public_Void_IList_1_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 109190, RefRangeEnd = 109192, XrefRangeStart = 109185, XrefRangeEnd = 109190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Process(CardData leader, IList<CardData> cards)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) leader);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cards);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FinalBossGenerationSettings.NativeMethodInfoPtr_Process_Public_Void_CardData_IList_1_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 109282, RefRangeEnd = 109283, XrefRangeStart = 109192, XrefRangeEnd = 109282, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerable<CardData> GenerateBonusEnemies(
    int count,
    IEnumerable<CardData> basedOnDeck,
    Il2CppReferenceArray<CardData> defaultEnemies)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &count;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) basedOnDeck);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) defaultEnemies);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FinalBossGenerationSettings.NativeMethodInfoPtr_GenerateBonusEnemies_Public_IEnumerable_1_CardData_Int32_IEnumerable_1_CardData_Il2CppReferenceArray_1_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerable<CardData>) null : new IEnumerable<CardData>(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 109311, RefRangeEnd = 109312, XrefRangeStart = 109283, XrefRangeEnd = 109311, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void RemoveInjuries(IEnumerable<CardData> cards)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cards)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FinalBossGenerationSettings.NativeMethodInfoPtr_RemoveInjuries_Private_Static_Void_IEnumerable_1_CardData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 109344, RefRangeEnd = 109345, XrefRangeStart = 109312, XrefRangeEnd = 109344, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveUpgrades(IList<CardData> cards)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cards)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FinalBossGenerationSettings.NativeMethodInfoPtr_RemoveUpgrades_Private_Void_IList_1_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 109380, RefRangeEnd = 109381, XrefRangeStart = 109345, XrefRangeEnd = 109380, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ProcessEffects(IEnumerable<CardData> cards)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cards)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FinalBossGenerationSettings.NativeMethodInfoPtr_ProcessEffects_Private_Void_IEnumerable_1_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 109424, RefRangeEnd = 109425, XrefRangeStart = 109381, XrefRangeEnd = 109424, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveTraits(IList<CardData> cards)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cards)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FinalBossGenerationSettings.NativeMethodInfoPtr_RemoveTraits_Private_Void_IList_1_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 109489, RefRangeEnd = 109490, XrefRangeStart = 109425, XrefRangeEnd = 109489, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RunScripts(CardData leader, IList<CardData> cards)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) leader);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cards);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FinalBossGenerationSettings.NativeMethodInfoPtr_RunScripts_Private_Void_CardData_IList_1_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(110)]
  [CachedScanResults(RefRangeStart = 104608, RefRangeEnd = 104718, XrefRangeStart = 104608, XrefRangeEnd = 104718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FinalBossGenerationSettings()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FinalBossGenerationSettings>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FinalBossGenerationSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static FinalBossGenerationSettings()
  {
    Il2CppClassPointerStore<FinalBossGenerationSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (FinalBossGenerationSettings));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinalBossGenerationSettings>.NativeClassPtr);
    FinalBossGenerationSettings.NativeFieldInfoPtr_replaceCards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossGenerationSettings>.NativeClassPtr, nameof (replaceCards));
    FinalBossGenerationSettings.NativeFieldInfoPtr_ignoreUpgrades = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossGenerationSettings>.NativeClassPtr, nameof (ignoreUpgrades));
    FinalBossGenerationSettings.NativeFieldInfoPtr_ignoreTraits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossGenerationSettings>.NativeClassPtr, nameof (ignoreTraits));
    FinalBossGenerationSettings.NativeFieldInfoPtr_effectSwappers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossGenerationSettings>.NativeClassPtr, nameof (effectSwappers));
    FinalBossGenerationSettings.NativeFieldInfoPtr_runOnAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossGenerationSettings>.NativeClassPtr, nameof (runOnAll));
    FinalBossGenerationSettings.NativeFieldInfoPtr_cardModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossGenerationSettings>.NativeClassPtr, nameof (cardModifiers));
    FinalBossGenerationSettings.NativeFieldInfoPtr_leaderScripts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossGenerationSettings>.NativeClassPtr, nameof (leaderScripts));
    FinalBossGenerationSettings.NativeFieldInfoPtr_enemyOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossGenerationSettings>.NativeClassPtr, nameof (enemyOptions));
    FinalBossGenerationSettings.NativeMethodInfoPtr_ReplaceCards_Public_Void_IList_1_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossGenerationSettings>.NativeClassPtr, 100673373);
    FinalBossGenerationSettings.NativeMethodInfoPtr_Process_Public_Void_CardData_IList_1_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossGenerationSettings>.NativeClassPtr, 100673374);
    FinalBossGenerationSettings.NativeMethodInfoPtr_GenerateBonusEnemies_Public_IEnumerable_1_CardData_Int32_IEnumerable_1_CardData_Il2CppReferenceArray_1_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossGenerationSettings>.NativeClassPtr, 100673375);
    FinalBossGenerationSettings.NativeMethodInfoPtr_RemoveInjuries_Private_Static_Void_IEnumerable_1_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossGenerationSettings>.NativeClassPtr, 100673376);
    FinalBossGenerationSettings.NativeMethodInfoPtr_RemoveUpgrades_Private_Void_IList_1_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossGenerationSettings>.NativeClassPtr, 100673377);
    FinalBossGenerationSettings.NativeMethodInfoPtr_ProcessEffects_Private_Void_IEnumerable_1_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossGenerationSettings>.NativeClassPtr, 100673378);
    FinalBossGenerationSettings.NativeMethodInfoPtr_RemoveTraits_Private_Void_IList_1_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossGenerationSettings>.NativeClassPtr, 100673379);
    FinalBossGenerationSettings.NativeMethodInfoPtr_RunScripts_Private_Void_CardData_IList_1_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossGenerationSettings>.NativeClassPtr, 100673380);
    FinalBossGenerationSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossGenerationSettings>.NativeClassPtr, 100673381);
  }

  public FinalBossGenerationSettings(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Il2CppReferenceArray<FinalBossGenerationSettings.ReplaceCard> replaceCards
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossGenerationSettings.NativeFieldInfoPtr_replaceCards));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<FinalBossGenerationSettings.ReplaceCard>) null : new Il2CppReferenceArray<FinalBossGenerationSettings.ReplaceCard>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalBossGenerationSettings.NativeFieldInfoPtr_replaceCards), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<CardUpgradeData> ignoreUpgrades
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossGenerationSettings.NativeFieldInfoPtr_ignoreUpgrades));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CardUpgradeData>) null : new Il2CppReferenceArray<CardUpgradeData>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalBossGenerationSettings.NativeFieldInfoPtr_ignoreUpgrades), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<TraitData> ignoreTraits
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossGenerationSettings.NativeFieldInfoPtr_ignoreTraits));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<TraitData>) null : new Il2CppReferenceArray<TraitData>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalBossGenerationSettings.NativeFieldInfoPtr_ignoreTraits), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<FinalBossEffectSwapper> effectSwappers
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossGenerationSettings.NativeFieldInfoPtr_effectSwappers));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<FinalBossEffectSwapper>) null : new Il2CppReferenceArray<FinalBossEffectSwapper>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalBossGenerationSettings.NativeFieldInfoPtr_effectSwappers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<CardScript> runOnAll
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossGenerationSettings.NativeFieldInfoPtr_runOnAll));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CardScript>) null : new Il2CppReferenceArray<CardScript>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalBossGenerationSettings.NativeFieldInfoPtr_runOnAll), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<FinalBossCardModifier> cardModifiers
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossGenerationSettings.NativeFieldInfoPtr_cardModifiers));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<FinalBossCardModifier>) null : new Il2CppReferenceArray<FinalBossCardModifier>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalBossGenerationSettings.NativeFieldInfoPtr_cardModifiers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<CardScript> leaderScripts
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossGenerationSettings.NativeFieldInfoPtr_leaderScripts));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CardScript>) null : new Il2CppReferenceArray<CardScript>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalBossGenerationSettings.NativeFieldInfoPtr_leaderScripts), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<FinalBossEnemyGenerator> enemyOptions
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossGenerationSettings.NativeFieldInfoPtr_enemyOptions));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<FinalBossEnemyGenerator>) null : new Il2CppReferenceArray<FinalBossEnemyGenerator>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalBossGenerationSettings.NativeFieldInfoPtr_enemyOptions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public sealed class ReplaceCard : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_card;
    private static readonly System.IntPtr NativeFieldInfoPtr_options;

    static ReplaceCard()
    {
      Il2CppClassPointerStore<FinalBossGenerationSettings.ReplaceCard>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FinalBossGenerationSettings>.NativeClassPtr, nameof (ReplaceCard));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinalBossGenerationSettings.ReplaceCard>.NativeClassPtr);
      FinalBossGenerationSettings.ReplaceCard.NativeFieldInfoPtr_card = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossGenerationSettings.ReplaceCard>.NativeClassPtr, nameof (card));
      FinalBossGenerationSettings.ReplaceCard.NativeFieldInfoPtr_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossGenerationSettings.ReplaceCard>.NativeClassPtr, nameof (options));
    }

    public ReplaceCard(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public ReplaceCard()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FinalBossGenerationSettings.ReplaceCard>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FinalBossGenerationSettings.ReplaceCard>.NativeClassPtr, data));
    }

    public unsafe CardData card
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossGenerationSettings.ReplaceCard.NativeFieldInfoPtr_card));
        return pointer == System.IntPtr.Zero ? (CardData) null : new CardData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalBossGenerationSettings.ReplaceCard.NativeFieldInfoPtr_card), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<CardData> options
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossGenerationSettings.ReplaceCard.NativeFieldInfoPtr_options));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CardData>) null : new Il2CppReferenceArray<CardData>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalBossGenerationSettings.ReplaceCard.NativeFieldInfoPtr_options), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("FinalBossGenerationSettings/<>c__DisplayClass8_0")]
  public sealed class __c__DisplayClass8_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_replace;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ReplaceCards_b__0_Internal_Boolean_CardData_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass8_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FinalBossGenerationSettings.__c__DisplayClass8_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FinalBossGenerationSettings.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _ReplaceCards_b__0(CardData a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FinalBossGenerationSettings.__c__DisplayClass8_0.NativeMethodInfoPtr__ReplaceCards_b__0_Internal_Boolean_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass8_0()
    {
      Il2CppClassPointerStore<FinalBossGenerationSettings.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FinalBossGenerationSettings>.NativeClassPtr, "<>c__DisplayClass8_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinalBossGenerationSettings.__c__DisplayClass8_0>.NativeClassPtr);
      FinalBossGenerationSettings.__c__DisplayClass8_0.NativeFieldInfoPtr_replace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossGenerationSettings.__c__DisplayClass8_0>.NativeClassPtr, nameof (replace));
      FinalBossGenerationSettings.__c__DisplayClass8_0.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossGenerationSettings.__c__DisplayClass8_0>.NativeClassPtr, "<>9__0");
      FinalBossGenerationSettings.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossGenerationSettings.__c__DisplayClass8_0>.NativeClassPtr, 100673382);
      FinalBossGenerationSettings.__c__DisplayClass8_0.NativeMethodInfoPtr__ReplaceCards_b__0_Internal_Boolean_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossGenerationSettings.__c__DisplayClass8_0>.NativeClassPtr, 100673383);
    }

    public __c__DisplayClass8_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public FinalBossGenerationSettings.ReplaceCard replace
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossGenerationSettings.__c__DisplayClass8_0.NativeFieldInfoPtr_replace);
        return new FinalBossGenerationSettings.ReplaceCard(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FinalBossGenerationSettings.ReplaceCard>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossGenerationSettings.__c__DisplayClass8_0.NativeFieldInfoPtr_replace), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FinalBossGenerationSettings.ReplaceCard>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Il2CppSystem.Func<CardData, bool> __9__0
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossGenerationSettings.__c__DisplayClass8_0.NativeFieldInfoPtr___9__0));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<CardData, bool>) null : new Il2CppSystem.Func<CardData, bool>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalBossGenerationSettings.__c__DisplayClass8_0.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("FinalBossGenerationSettings/<>c__DisplayClass10_0")]
  public sealed class __c__DisplayClass10_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_card;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__1;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GenerateBonusEnemies_b__0_Internal_Boolean_FinalBossEnemyGenerator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GenerateBonusEnemies_b__1_Internal_Boolean_CardData_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass10_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FinalBossGenerationSettings.__c__DisplayClass10_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FinalBossGenerationSettings.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109126, XrefRangeEnd = 109137, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _GenerateBonusEnemies_b__0(FinalBossEnemyGenerator a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FinalBossGenerationSettings.__c__DisplayClass10_0.NativeMethodInfoPtr__GenerateBonusEnemies_b__0_Internal_Boolean_FinalBossEnemyGenerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _GenerateBonusEnemies_b__1(CardData b)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) b)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FinalBossGenerationSettings.__c__DisplayClass10_0.NativeMethodInfoPtr__GenerateBonusEnemies_b__1_Internal_Boolean_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass10_0()
    {
      Il2CppClassPointerStore<FinalBossGenerationSettings.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FinalBossGenerationSettings>.NativeClassPtr, "<>c__DisplayClass10_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinalBossGenerationSettings.__c__DisplayClass10_0>.NativeClassPtr);
      FinalBossGenerationSettings.__c__DisplayClass10_0.NativeFieldInfoPtr_card = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossGenerationSettings.__c__DisplayClass10_0>.NativeClassPtr, nameof (card));
      FinalBossGenerationSettings.__c__DisplayClass10_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossGenerationSettings.__c__DisplayClass10_0>.NativeClassPtr, "<>9__1");
      FinalBossGenerationSettings.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossGenerationSettings.__c__DisplayClass10_0>.NativeClassPtr, 100673384);
      FinalBossGenerationSettings.__c__DisplayClass10_0.NativeMethodInfoPtr__GenerateBonusEnemies_b__0_Internal_Boolean_FinalBossEnemyGenerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossGenerationSettings.__c__DisplayClass10_0>.NativeClassPtr, 100673385);
      FinalBossGenerationSettings.__c__DisplayClass10_0.NativeMethodInfoPtr__GenerateBonusEnemies_b__1_Internal_Boolean_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossGenerationSettings.__c__DisplayClass10_0>.NativeClassPtr, 100673386);
    }

    public __c__DisplayClass10_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CardData card
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossGenerationSettings.__c__DisplayClass10_0.NativeFieldInfoPtr_card));
        return pointer == System.IntPtr.Zero ? (CardData) null : new CardData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalBossGenerationSettings.__c__DisplayClass10_0.NativeFieldInfoPtr_card), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Func<CardData, bool> __9__1
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossGenerationSettings.__c__DisplayClass10_0.NativeFieldInfoPtr___9__1));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<CardData, bool>) null : new Il2CppSystem.Func<CardData, bool>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalBossGenerationSettings.__c__DisplayClass10_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("FinalBossGenerationSettings/<>c__DisplayClass14_0")]
  public sealed class __c__DisplayClass14_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_trait;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__RemoveTraits_b__0_Internal_Boolean_TraitStacks_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass14_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FinalBossGenerationSettings.__c__DisplayClass14_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FinalBossGenerationSettings.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109137, XrefRangeEnd = 109141, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _RemoveTraits_b__0(CardData.TraitStacks a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FinalBossGenerationSettings.__c__DisplayClass14_0.NativeMethodInfoPtr__RemoveTraits_b__0_Internal_Boolean_TraitStacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass14_0()
    {
      Il2CppClassPointerStore<FinalBossGenerationSettings.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FinalBossGenerationSettings>.NativeClassPtr, "<>c__DisplayClass14_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinalBossGenerationSettings.__c__DisplayClass14_0>.NativeClassPtr);
      FinalBossGenerationSettings.__c__DisplayClass14_0.NativeFieldInfoPtr_trait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossGenerationSettings.__c__DisplayClass14_0>.NativeClassPtr, nameof (trait));
      FinalBossGenerationSettings.__c__DisplayClass14_0.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossGenerationSettings.__c__DisplayClass14_0>.NativeClassPtr, "<>9__0");
      FinalBossGenerationSettings.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossGenerationSettings.__c__DisplayClass14_0>.NativeClassPtr, 100673387);
      FinalBossGenerationSettings.__c__DisplayClass14_0.NativeMethodInfoPtr__RemoveTraits_b__0_Internal_Boolean_TraitStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossGenerationSettings.__c__DisplayClass14_0>.NativeClassPtr, 100673388);
    }

    public __c__DisplayClass14_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe TraitData trait
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossGenerationSettings.__c__DisplayClass14_0.NativeFieldInfoPtr_trait));
        return pointer == System.IntPtr.Zero ? (TraitData) null : new TraitData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalBossGenerationSettings.__c__DisplayClass14_0.NativeFieldInfoPtr_trait), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Func<CardData.TraitStacks, bool> __9__0
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossGenerationSettings.__c__DisplayClass14_0.NativeFieldInfoPtr___9__0));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<CardData.TraitStacks, bool>) null : new Il2CppSystem.Func<CardData.TraitStacks, bool>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalBossGenerationSettings.__c__DisplayClass14_0.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("FinalBossGenerationSettings/<>c__DisplayClass15_0")]
  public sealed class __c__DisplayClass15_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_card;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__RunScripts_b__0_Internal_Boolean_FinalBossCardModifier_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass15_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FinalBossGenerationSettings.__c__DisplayClass15_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FinalBossGenerationSettings.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109141, XrefRangeEnd = 109145, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _RunScripts_b__0(FinalBossCardModifier a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FinalBossGenerationSettings.__c__DisplayClass15_0.NativeMethodInfoPtr__RunScripts_b__0_Internal_Boolean_FinalBossCardModifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass15_0()
    {
      Il2CppClassPointerStore<FinalBossGenerationSettings.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FinalBossGenerationSettings>.NativeClassPtr, "<>c__DisplayClass15_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinalBossGenerationSettings.__c__DisplayClass15_0>.NativeClassPtr);
      FinalBossGenerationSettings.__c__DisplayClass15_0.NativeFieldInfoPtr_card = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalBossGenerationSettings.__c__DisplayClass15_0>.NativeClassPtr, nameof (card));
      FinalBossGenerationSettings.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossGenerationSettings.__c__DisplayClass15_0>.NativeClassPtr, 100673389);
      FinalBossGenerationSettings.__c__DisplayClass15_0.NativeMethodInfoPtr__RunScripts_b__0_Internal_Boolean_FinalBossCardModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalBossGenerationSettings.__c__DisplayClass15_0>.NativeClassPtr, 100673390);
    }

    public __c__DisplayClass15_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CardData card
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalBossGenerationSettings.__c__DisplayClass15_0.NativeFieldInfoPtr_card));
        return pointer == System.IntPtr.Zero ? (CardData) null : new CardData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalBossGenerationSettings.__c__DisplayClass15_0.NativeFieldInfoPtr_card), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
