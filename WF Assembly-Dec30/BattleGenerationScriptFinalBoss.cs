// Decompiled with JetBrains decompiler
// Type: BattleGenerationScriptFinalBoss
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
public class BattleGenerationScriptFinalBoss : BattleGenerationScript
{
  private static readonly System.IntPtr NativeFieldInfoPtr_settings;
  private static readonly System.IntPtr NativeFieldInfoPtr_leaderCardType;
  private static readonly System.IntPtr NativeFieldInfoPtr_enemyCardType;
  private static readonly System.IntPtr NativeFieldInfoPtr_waveCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_leaderWave;
  private static readonly System.IntPtr NativeFieldInfoPtr_bossWave;
  private static readonly System.IntPtr NativeFieldInfoPtr_waveMaxSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_insertBossAtFront;
  private static readonly System.IntPtr NativeFieldInfoPtr_insertLeaderAtFront;
  private static readonly System.IntPtr NativeFieldInfoPtr_bossOptions;
  private static readonly System.IntPtr NativeFieldInfoPtr_leaderNextPhase;
  private static readonly System.IntPtr NativeFieldInfoPtr_defaultLeaderOptions;
  private static readonly System.IntPtr NativeFieldInfoPtr_processDefaultLeader;
  private static readonly System.IntPtr NativeFieldInfoPtr_defaultDeck;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadCards_Public_Il2CppReferenceArray_1_CardData_GameMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetBaseEnemies_Public_Void_Il2CppReferenceArray_1_CardData_Int32_byref_List_1_CardData_byref_Boolean_byref_Boolean_byref_CardData_byref_Boolean_byref_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Run_Public_Virtual_SaveCollection_1_WaveData_BattleData_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 104875, RefRangeEnd = 104876, XrefRangeStart = 104864, XrefRangeEnd = 104875, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Il2CppReferenceArray<CardData> LoadCards(GameMode gameMode)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameMode)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleGenerationScriptFinalBoss.NativeMethodInfoPtr_LoadCards_Public_Il2CppReferenceArray_1_CardData_GameMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr nativeObject = num;
    return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CardData>) null : new Il2CppReferenceArray<CardData>(nativeObject);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 105072, RefRangeEnd = 105074, XrefRangeStart = 104876, XrefRangeEnd = 105072, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void GetBaseEnemies(
    Il2CppReferenceArray<CardData> cardList,
    int seed,
    out List<CardData> enemiesCloned,
    out bool hasStoredCards,
    out bool hasLeader,
    out CardData leaderCloned,
    out bool hasBoss,
    out CardData bossCloned)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[8];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cardList);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &seed;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    System.IntPtr zero1 = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero1;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref hasStoredCards;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref hasLeader;
    System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(5) * sizeof (System.IntPtr));
    System.IntPtr zero2 = System.IntPtr.Zero;
    System.IntPtr* numPtr3 = &zero2;
    *(System.IntPtr*) num2 = (System.IntPtr) numPtr3;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref hasBoss;
    System.IntPtr num3 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(7) * sizeof (System.IntPtr));
    System.IntPtr zero3 = System.IntPtr.Zero;
    System.IntPtr* numPtr4 = &zero3;
    *(System.IntPtr*) num3 = (System.IntPtr) numPtr4;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleGenerationScriptFinalBoss.NativeMethodInfoPtr_GetBaseEnemies_Public_Void_Il2CppReferenceArray_1_CardData_Int32_byref_List_1_CardData_byref_Boolean_byref_Boolean_byref_CardData_byref_Boolean_byref_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    ref List<CardData> local1 = ref enemiesCloned;
    System.IntPtr pointer1 = zero1;
    List<> list = pointer1 == System.IntPtr.Zero ? (List<>) null : new List<>(pointer1);
    local1 = (List<CardData>) list;
    ref CardData local2 = ref leaderCloned;
    System.IntPtr pointer2 = zero2;
    CardData cardData1 = pointer2 == System.IntPtr.Zero ? (CardData) null : new CardData(pointer2);
    local2 = cardData1;
    ref CardData local3 = ref bossCloned;
    System.IntPtr pointer3 = zero3;
    CardData cardData2 = pointer3 == System.IntPtr.Zero ? (CardData) null : new CardData(pointer3);
    local3 = cardData2;
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105074, XrefRangeEnd = 105253, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe SaveCollection<BattleWaveManager.WaveData> Run(
    BattleData battleData,
    int points)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) battleData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &points;
    System.IntPtr exc;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BattleGenerationScriptFinalBoss.NativeMethodInfoPtr_Run_Public_Virtual_SaveCollection_1_WaveData_BattleData_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return new SaveCollection<BattleWaveManager.WaveData>(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105253, XrefRangeEnd = 105261, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BattleGenerationScriptFinalBoss()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleGenerationScriptFinalBoss>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleGenerationScriptFinalBoss.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static BattleGenerationScriptFinalBoss()
  {
    Il2CppClassPointerStore<BattleGenerationScriptFinalBoss>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (BattleGenerationScriptFinalBoss));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleGenerationScriptFinalBoss>.NativeClassPtr);
    BattleGenerationScriptFinalBoss.NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleGenerationScriptFinalBoss>.NativeClassPtr, nameof (settings));
    BattleGenerationScriptFinalBoss.NativeFieldInfoPtr_leaderCardType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleGenerationScriptFinalBoss>.NativeClassPtr, nameof (leaderCardType));
    BattleGenerationScriptFinalBoss.NativeFieldInfoPtr_enemyCardType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleGenerationScriptFinalBoss>.NativeClassPtr, nameof (enemyCardType));
    BattleGenerationScriptFinalBoss.NativeFieldInfoPtr_waveCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleGenerationScriptFinalBoss>.NativeClassPtr, nameof (waveCount));
    BattleGenerationScriptFinalBoss.NativeFieldInfoPtr_leaderWave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleGenerationScriptFinalBoss>.NativeClassPtr, nameof (leaderWave));
    BattleGenerationScriptFinalBoss.NativeFieldInfoPtr_bossWave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleGenerationScriptFinalBoss>.NativeClassPtr, nameof (bossWave));
    BattleGenerationScriptFinalBoss.NativeFieldInfoPtr_waveMaxSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleGenerationScriptFinalBoss>.NativeClassPtr, nameof (waveMaxSize));
    BattleGenerationScriptFinalBoss.NativeFieldInfoPtr_insertBossAtFront = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleGenerationScriptFinalBoss>.NativeClassPtr, nameof (insertBossAtFront));
    BattleGenerationScriptFinalBoss.NativeFieldInfoPtr_insertLeaderAtFront = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleGenerationScriptFinalBoss>.NativeClassPtr, nameof (insertLeaderAtFront));
    BattleGenerationScriptFinalBoss.NativeFieldInfoPtr_bossOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleGenerationScriptFinalBoss>.NativeClassPtr, nameof (bossOptions));
    BattleGenerationScriptFinalBoss.NativeFieldInfoPtr_leaderNextPhase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleGenerationScriptFinalBoss>.NativeClassPtr, nameof (leaderNextPhase));
    BattleGenerationScriptFinalBoss.NativeFieldInfoPtr_defaultLeaderOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleGenerationScriptFinalBoss>.NativeClassPtr, nameof (defaultLeaderOptions));
    BattleGenerationScriptFinalBoss.NativeFieldInfoPtr_processDefaultLeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleGenerationScriptFinalBoss>.NativeClassPtr, nameof (processDefaultLeader));
    BattleGenerationScriptFinalBoss.NativeFieldInfoPtr_defaultDeck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleGenerationScriptFinalBoss>.NativeClassPtr, nameof (defaultDeck));
    BattleGenerationScriptFinalBoss.NativeMethodInfoPtr_LoadCards_Public_Il2CppReferenceArray_1_CardData_GameMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleGenerationScriptFinalBoss>.NativeClassPtr, 100672794);
    BattleGenerationScriptFinalBoss.NativeMethodInfoPtr_GetBaseEnemies_Public_Void_Il2CppReferenceArray_1_CardData_Int32_byref_List_1_CardData_byref_Boolean_byref_Boolean_byref_CardData_byref_Boolean_byref_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleGenerationScriptFinalBoss>.NativeClassPtr, 100672795);
    BattleGenerationScriptFinalBoss.NativeMethodInfoPtr_Run_Public_Virtual_SaveCollection_1_WaveData_BattleData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleGenerationScriptFinalBoss>.NativeClassPtr, 100672796);
    BattleGenerationScriptFinalBoss.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleGenerationScriptFinalBoss>.NativeClassPtr, 100672797);
  }

  public BattleGenerationScriptFinalBoss(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe FinalBossGenerationSettings settings
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleGenerationScriptFinalBoss.NativeFieldInfoPtr_settings));
      return pointer == System.IntPtr.Zero ? (FinalBossGenerationSettings) null : new FinalBossGenerationSettings(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleGenerationScriptFinalBoss.NativeFieldInfoPtr_settings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CardType leaderCardType
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleGenerationScriptFinalBoss.NativeFieldInfoPtr_leaderCardType));
      return pointer == System.IntPtr.Zero ? (CardType) null : new CardType(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleGenerationScriptFinalBoss.NativeFieldInfoPtr_leaderCardType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CardType enemyCardType
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleGenerationScriptFinalBoss.NativeFieldInfoPtr_enemyCardType));
      return pointer == System.IntPtr.Zero ? (CardType) null : new CardType(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleGenerationScriptFinalBoss.NativeFieldInfoPtr_enemyCardType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int waveCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleGenerationScriptFinalBoss.NativeFieldInfoPtr_waveCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleGenerationScriptFinalBoss.NativeFieldInfoPtr_waveCount)) = value;
    }
  }

  public unsafe int leaderWave
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleGenerationScriptFinalBoss.NativeFieldInfoPtr_leaderWave));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleGenerationScriptFinalBoss.NativeFieldInfoPtr_leaderWave)) = value;
    }
  }

  public unsafe int bossWave
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleGenerationScriptFinalBoss.NativeFieldInfoPtr_bossWave));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleGenerationScriptFinalBoss.NativeFieldInfoPtr_bossWave)) = value;
    }
  }

  public unsafe Il2CppStructArray<int> waveMaxSize
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleGenerationScriptFinalBoss.NativeFieldInfoPtr_waveMaxSize));
      return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<int>) null : new Il2CppStructArray<int>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleGenerationScriptFinalBoss.NativeFieldInfoPtr_waveMaxSize), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool insertBossAtFront
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleGenerationScriptFinalBoss.NativeFieldInfoPtr_insertBossAtFront));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleGenerationScriptFinalBoss.NativeFieldInfoPtr_insertBossAtFront)) = value;
    }
  }

  public unsafe bool insertLeaderAtFront
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleGenerationScriptFinalBoss.NativeFieldInfoPtr_insertLeaderAtFront));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleGenerationScriptFinalBoss.NativeFieldInfoPtr_insertLeaderAtFront)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<CardData> bossOptions
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleGenerationScriptFinalBoss.NativeFieldInfoPtr_bossOptions));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CardData>) null : new Il2CppReferenceArray<CardData>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleGenerationScriptFinalBoss.NativeFieldInfoPtr_bossOptions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<StatusEffectData> leaderNextPhase
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleGenerationScriptFinalBoss.NativeFieldInfoPtr_leaderNextPhase));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<StatusEffectData>) null : new Il2CppReferenceArray<StatusEffectData>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleGenerationScriptFinalBoss.NativeFieldInfoPtr_leaderNextPhase), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<CardData> defaultLeaderOptions
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleGenerationScriptFinalBoss.NativeFieldInfoPtr_defaultLeaderOptions));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CardData>) null : new Il2CppReferenceArray<CardData>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleGenerationScriptFinalBoss.NativeFieldInfoPtr_defaultLeaderOptions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool processDefaultLeader
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleGenerationScriptFinalBoss.NativeFieldInfoPtr_processDefaultLeader));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleGenerationScriptFinalBoss.NativeFieldInfoPtr_processDefaultLeader)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<CardData> defaultDeck
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleGenerationScriptFinalBoss.NativeFieldInfoPtr_defaultDeck));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CardData>) null : new Il2CppReferenceArray<CardData>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleGenerationScriptFinalBoss.NativeFieldInfoPtr_defaultDeck), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("BattleGenerationScriptFinalBoss/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__15_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__15_1;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__15_2;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__15_3;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetBaseEnemies_b__15_0_Internal_Boolean_CardData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetBaseEnemies_b__15_1_Internal_CardData_CardData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetBaseEnemies_b__15_2_Internal_Boolean_CardData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetBaseEnemies_b__15_3_Internal_Boolean_CardData_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleGenerationScriptFinalBoss.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleGenerationScriptFinalBoss.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104841, XrefRangeEnd = 104851, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _GetBaseEnemies_b__15_0(CardData a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleGenerationScriptFinalBoss.__c.NativeMethodInfoPtr__GetBaseEnemies_b__15_0_Internal_Boolean_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104851, XrefRangeEnd = 104854, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CardData _GetBaseEnemies_b__15_1(CardData a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleGenerationScriptFinalBoss.__c.NativeMethodInfoPtr__GetBaseEnemies_b__15_1_Internal_CardData_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CardData) null : new CardData(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104854, XrefRangeEnd = 104859, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _GetBaseEnemies_b__15_2(CardData a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleGenerationScriptFinalBoss.__c.NativeMethodInfoPtr__GetBaseEnemies_b__15_2_Internal_Boolean_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104859, XrefRangeEnd = 104864, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _GetBaseEnemies_b__15_3(CardData a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleGenerationScriptFinalBoss.__c.NativeMethodInfoPtr__GetBaseEnemies_b__15_3_Internal_Boolean_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c()
    {
      Il2CppClassPointerStore<BattleGenerationScriptFinalBoss.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleGenerationScriptFinalBoss>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleGenerationScriptFinalBoss.__c>.NativeClassPtr);
      BattleGenerationScriptFinalBoss.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleGenerationScriptFinalBoss.__c>.NativeClassPtr, "<>9");
      BattleGenerationScriptFinalBoss.__c.NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleGenerationScriptFinalBoss.__c>.NativeClassPtr, "<>9__15_0");
      BattleGenerationScriptFinalBoss.__c.NativeFieldInfoPtr___9__15_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleGenerationScriptFinalBoss.__c>.NativeClassPtr, "<>9__15_1");
      BattleGenerationScriptFinalBoss.__c.NativeFieldInfoPtr___9__15_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleGenerationScriptFinalBoss.__c>.NativeClassPtr, "<>9__15_2");
      BattleGenerationScriptFinalBoss.__c.NativeFieldInfoPtr___9__15_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleGenerationScriptFinalBoss.__c>.NativeClassPtr, "<>9__15_3");
      BattleGenerationScriptFinalBoss.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleGenerationScriptFinalBoss.__c>.NativeClassPtr, 100672799);
      BattleGenerationScriptFinalBoss.__c.NativeMethodInfoPtr__GetBaseEnemies_b__15_0_Internal_Boolean_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleGenerationScriptFinalBoss.__c>.NativeClassPtr, 100672800);
      BattleGenerationScriptFinalBoss.__c.NativeMethodInfoPtr__GetBaseEnemies_b__15_1_Internal_CardData_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleGenerationScriptFinalBoss.__c>.NativeClassPtr, 100672801);
      BattleGenerationScriptFinalBoss.__c.NativeMethodInfoPtr__GetBaseEnemies_b__15_2_Internal_Boolean_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleGenerationScriptFinalBoss.__c>.NativeClassPtr, 100672802);
      BattleGenerationScriptFinalBoss.__c.NativeMethodInfoPtr__GetBaseEnemies_b__15_3_Internal_Boolean_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleGenerationScriptFinalBoss.__c>.NativeClassPtr, 100672803);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe BattleGenerationScriptFinalBoss.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(BattleGenerationScriptFinalBoss.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (BattleGenerationScriptFinalBoss.__c) null : new BattleGenerationScriptFinalBoss.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(BattleGenerationScriptFinalBoss.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<CardData, bool> __9__15_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(BattleGenerationScriptFinalBoss.__c.NativeFieldInfoPtr___9__15_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<CardData, bool>) null : new Il2CppSystem.Func<CardData, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(BattleGenerationScriptFinalBoss.__c.NativeFieldInfoPtr___9__15_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<CardData, CardData> __9__15_1
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(BattleGenerationScriptFinalBoss.__c.NativeFieldInfoPtr___9__15_1, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<CardData, CardData>) null : new Il2CppSystem.Func<CardData, CardData>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(BattleGenerationScriptFinalBoss.__c.NativeFieldInfoPtr___9__15_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<CardData, bool> __9__15_2
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(BattleGenerationScriptFinalBoss.__c.NativeFieldInfoPtr___9__15_2, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<CardData, bool>) null : new Il2CppSystem.Func<CardData, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(BattleGenerationScriptFinalBoss.__c.NativeFieldInfoPtr___9__15_2, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<CardData, bool> __9__15_3
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(BattleGenerationScriptFinalBoss.__c.NativeFieldInfoPtr___9__15_3, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<CardData, bool>) null : new Il2CppSystem.Func<CardData, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(BattleGenerationScriptFinalBoss.__c.NativeFieldInfoPtr___9__15_3, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
