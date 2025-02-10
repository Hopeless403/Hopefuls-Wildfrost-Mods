// Decompiled with JetBrains decompiler
// Type: CampaignPopulator
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

#nullable disable
public class CampaignPopulator : ScriptableObject
{
  private static readonly System.IntPtr NativeFieldInfoPtr_removeLockedCards;
  private static readonly System.IntPtr NativeFieldInfoPtr_tiers;
  private static readonly System.IntPtr NativeFieldInfoPtr_playerStartNodeId;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadCharacters_Public_Void_Campaign_Il2CppReferenceArray_1_CharacterSaveData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Populate_Public_IEnumerator_Campaign_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LinkNodes_Private_Static_Dictionary_2_CampaignNode_CampaignNode_List_1_Tier_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 107637, RefRangeEnd = 107638, XrefRangeStart = 107630, XrefRangeEnd = 107637, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LoadCharacters(Campaign campaign, Il2CppReferenceArray<CharacterSaveData> data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) campaign);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CampaignPopulator.NativeMethodInfoPtr_LoadCharacters_Public_Void_Campaign_Il2CppReferenceArray_1_CharacterSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 107644, RefRangeEnd = 107645, XrefRangeStart = 107638, XrefRangeEnd = 107644, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator Populate(Campaign campaign)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) campaign)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CampaignPopulator.NativeMethodInfoPtr_Populate_Public_IEnumerator_Campaign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107645, XrefRangeEnd = 107740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Dictionary<CampaignNode, CampaignNode> LinkNodes(
    List<CampaignPopulator.Tier> currentTiers)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) currentTiers)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CampaignPopulator.NativeMethodInfoPtr_LinkNodes_Private_Static_Dictionary_2_CampaignNode_CampaignNode_List_1_Tier_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (Dictionary<CampaignNode, CampaignNode>) null : new Dictionary<CampaignNode, CampaignNode>(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 107741, RefRangeEnd = 107742, XrefRangeStart = 107740, XrefRangeEnd = 107741, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CampaignPopulator()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CampaignPopulator>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CampaignPopulator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CampaignPopulator()
  {
    Il2CppClassPointerStore<CampaignPopulator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CampaignPopulator));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CampaignPopulator>.NativeClassPtr);
    CampaignPopulator.NativeFieldInfoPtr_removeLockedCards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignPopulator>.NativeClassPtr, nameof (removeLockedCards));
    CampaignPopulator.NativeFieldInfoPtr_tiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignPopulator>.NativeClassPtr, nameof (tiers));
    CampaignPopulator.NativeFieldInfoPtr_playerStartNodeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignPopulator>.NativeClassPtr, nameof (playerStartNodeId));
    CampaignPopulator.NativeMethodInfoPtr_LoadCharacters_Public_Void_Campaign_Il2CppReferenceArray_1_CharacterSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignPopulator>.NativeClassPtr, 100673134);
    CampaignPopulator.NativeMethodInfoPtr_Populate_Public_IEnumerator_Campaign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignPopulator>.NativeClassPtr, 100673135);
    CampaignPopulator.NativeMethodInfoPtr_LinkNodes_Private_Static_Dictionary_2_CampaignNode_CampaignNode_List_1_Tier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignPopulator>.NativeClassPtr, 100673136);
    CampaignPopulator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignPopulator>.NativeClassPtr, 100673137);
  }

  public CampaignPopulator(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe bool removeLockedCards
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignPopulator.NativeFieldInfoPtr_removeLockedCards));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignPopulator.NativeFieldInfoPtr_removeLockedCards)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<CampaignTier> tiers
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignPopulator.NativeFieldInfoPtr_tiers));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CampaignTier>) null : new Il2CppReferenceArray<CampaignTier>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignPopulator.NativeFieldInfoPtr_tiers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int playerStartNodeId
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignPopulator.NativeFieldInfoPtr_playerStartNodeId));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignPopulator.NativeFieldInfoPtr_playerStartNodeId)) = value;
    }
  }

  public class Tier : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_number;
    private static readonly System.IntPtr NativeFieldInfoPtr_nodes;
    private static readonly System.IntPtr NativeFieldInfoPtr_battles;
    private static readonly System.IntPtr NativeFieldInfoPtr_rewards;
    private static readonly System.IntPtr NativeFieldInfoPtr_campaignTier;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_CampaignTier_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PullBattle_Public_BattleData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetBattlePoints_Public_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PullReward_Public_CampaignNodeType_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107498, XrefRangeEnd = 107522, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Tier(int number, CampaignTier campaignTier)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CampaignPopulator.Tier>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &number;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) campaignTier);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CampaignPopulator.Tier.NativeMethodInfoPtr__ctor_Public_Void_Int32_CampaignTier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107522, XrefRangeEnd = 107532, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BattleData PullBattle()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CampaignPopulator.Tier.NativeMethodInfoPtr_PullBattle_Public_BattleData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (BattleData) null : new BattleData(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107532, XrefRangeEnd = 107534, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetBattlePoints()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CampaignPopulator.Tier.NativeMethodInfoPtr_GetBattlePoints_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107534, XrefRangeEnd = 107544, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CampaignNodeType PullReward()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CampaignPopulator.Tier.NativeMethodInfoPtr_PullReward_Public_CampaignNodeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CampaignNodeType) null : new CampaignNodeType(pointer);
    }

    static Tier()
    {
      Il2CppClassPointerStore<CampaignPopulator.Tier>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CampaignPopulator>.NativeClassPtr, nameof (Tier));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CampaignPopulator.Tier>.NativeClassPtr);
      CampaignPopulator.Tier.NativeFieldInfoPtr_number = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignPopulator.Tier>.NativeClassPtr, nameof (number));
      CampaignPopulator.Tier.NativeFieldInfoPtr_nodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignPopulator.Tier>.NativeClassPtr, nameof (nodes));
      CampaignPopulator.Tier.NativeFieldInfoPtr_battles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignPopulator.Tier>.NativeClassPtr, nameof (battles));
      CampaignPopulator.Tier.NativeFieldInfoPtr_rewards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignPopulator.Tier>.NativeClassPtr, nameof (rewards));
      CampaignPopulator.Tier.NativeFieldInfoPtr_campaignTier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignPopulator.Tier>.NativeClassPtr, nameof (campaignTier));
      CampaignPopulator.Tier.NativeMethodInfoPtr__ctor_Public_Void_Int32_CampaignTier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignPopulator.Tier>.NativeClassPtr, 100673138);
      CampaignPopulator.Tier.NativeMethodInfoPtr_PullBattle_Public_BattleData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignPopulator.Tier>.NativeClassPtr, 100673139);
      CampaignPopulator.Tier.NativeMethodInfoPtr_GetBattlePoints_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignPopulator.Tier>.NativeClassPtr, 100673140);
      CampaignPopulator.Tier.NativeMethodInfoPtr_PullReward_Public_CampaignNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignPopulator.Tier>.NativeClassPtr, 100673141);
    }

    public Tier(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int number
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignPopulator.Tier.NativeFieldInfoPtr_number));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignPopulator.Tier.NativeFieldInfoPtr_number)) = value;
      }
    }

    public unsafe List<CampaignNode> nodes
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignPopulator.Tier.NativeFieldInfoPtr_nodes));
        return pointer == System.IntPtr.Zero ? (List<CampaignNode>) null : new List<CampaignNode>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignPopulator.Tier.NativeFieldInfoPtr_nodes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<BattleData> battles
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignPopulator.Tier.NativeFieldInfoPtr_battles));
        return pointer == System.IntPtr.Zero ? (List<BattleData>) null : new List<BattleData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignPopulator.Tier.NativeFieldInfoPtr_battles), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<CampaignNodeType> rewards
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignPopulator.Tier.NativeFieldInfoPtr_rewards));
        return pointer == System.IntPtr.Zero ? (List<CampaignNodeType>) null : new List<CampaignNodeType>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignPopulator.Tier.NativeFieldInfoPtr_rewards), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CampaignTier campaignTier
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignPopulator.Tier.NativeFieldInfoPtr_campaignTier));
        return pointer == System.IntPtr.Zero ? (CampaignTier) null : new CampaignTier(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignPopulator.Tier.NativeFieldInfoPtr_campaignTier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("CampaignPopulator/<>c__DisplayClass4_0")]
  public sealed class __c__DisplayClass4_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_tierNumber;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Populate_b__0_Internal_Boolean_Tier_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass4_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CampaignPopulator.__c__DisplayClass4_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CampaignPopulator.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _Populate_b__0(CampaignPopulator.Tier a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CampaignPopulator.__c__DisplayClass4_0.NativeMethodInfoPtr__Populate_b__0_Internal_Boolean_Tier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass4_0()
    {
      Il2CppClassPointerStore<CampaignPopulator.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CampaignPopulator>.NativeClassPtr, "<>c__DisplayClass4_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CampaignPopulator.__c__DisplayClass4_0>.NativeClassPtr);
      CampaignPopulator.__c__DisplayClass4_0.NativeFieldInfoPtr_tierNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignPopulator.__c__DisplayClass4_0>.NativeClassPtr, nameof (tierNumber));
      CampaignPopulator.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignPopulator.__c__DisplayClass4_0>.NativeClassPtr, 100673142);
      CampaignPopulator.__c__DisplayClass4_0.NativeMethodInfoPtr__Populate_b__0_Internal_Boolean_Tier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignPopulator.__c__DisplayClass4_0>.NativeClassPtr, 100673143);
    }

    public __c__DisplayClass4_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int tierNumber
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignPopulator.__c__DisplayClass4_0.NativeFieldInfoPtr_tierNumber));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignPopulator.__c__DisplayClass4_0.NativeFieldInfoPtr_tierNumber)) = value;
      }
    }
  }

  [ObfuscatedName("CampaignPopulator/<Populate>d__4")]
  public sealed class _Populate_d__4 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_campaign;
    private static readonly System.IntPtr NativeFieldInfoPtr__links_5__2;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _Populate_d__4(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CampaignPopulator._Populate_d__4>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CampaignPopulator._Populate_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CampaignPopulator._Populate_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107544, XrefRangeEnd = 107615, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CampaignPopulator._Populate_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CampaignPopulator._Populate_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107615, XrefRangeEnd = 107621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CampaignPopulator._Populate_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CampaignPopulator._Populate_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _Populate_d__4()
    {
      Il2CppClassPointerStore<CampaignPopulator._Populate_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CampaignPopulator>.NativeClassPtr, "<Populate>d__4");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CampaignPopulator._Populate_d__4>.NativeClassPtr);
      CampaignPopulator._Populate_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignPopulator._Populate_d__4>.NativeClassPtr, "<>1__state");
      CampaignPopulator._Populate_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignPopulator._Populate_d__4>.NativeClassPtr, "<>2__current");
      CampaignPopulator._Populate_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignPopulator._Populate_d__4>.NativeClassPtr, "<>4__this");
      CampaignPopulator._Populate_d__4.NativeFieldInfoPtr_campaign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignPopulator._Populate_d__4>.NativeClassPtr, nameof (campaign));
      CampaignPopulator._Populate_d__4.NativeFieldInfoPtr__links_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignPopulator._Populate_d__4>.NativeClassPtr, "<links>5__2");
      CampaignPopulator._Populate_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignPopulator._Populate_d__4>.NativeClassPtr, 100673144);
      CampaignPopulator._Populate_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignPopulator._Populate_d__4>.NativeClassPtr, 100673145);
      CampaignPopulator._Populate_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignPopulator._Populate_d__4>.NativeClassPtr, 100673146);
      CampaignPopulator._Populate_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignPopulator._Populate_d__4>.NativeClassPtr, 100673147);
      CampaignPopulator._Populate_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignPopulator._Populate_d__4>.NativeClassPtr, 100673148);
      CampaignPopulator._Populate_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignPopulator._Populate_d__4>.NativeClassPtr, 100673149);
    }

    public _Populate_d__4(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignPopulator._Populate_d__4.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignPopulator._Populate_d__4.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignPopulator._Populate_d__4.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignPopulator._Populate_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CampaignPopulator __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignPopulator._Populate_d__4.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (CampaignPopulator) null : new CampaignPopulator(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignPopulator._Populate_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Campaign campaign
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignPopulator._Populate_d__4.NativeFieldInfoPtr_campaign));
        return pointer == System.IntPtr.Zero ? (Campaign) null : new Campaign(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignPopulator._Populate_d__4.NativeFieldInfoPtr_campaign), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<CampaignNode, CampaignNode> _links_5__2
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignPopulator._Populate_d__4.NativeFieldInfoPtr__links_5__2));
        return pointer == System.IntPtr.Zero ? (Dictionary<CampaignNode, CampaignNode>) null : new Dictionary<CampaignNode, CampaignNode>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignPopulator._Populate_d__4.NativeFieldInfoPtr__links_5__2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("CampaignPopulator/<>c__DisplayClass5_0")]
  public sealed class __c__DisplayClass5_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_links;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass5_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CampaignPopulator.__c__DisplayClass5_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CampaignPopulator.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static __c__DisplayClass5_0()
    {
      Il2CppClassPointerStore<CampaignPopulator.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CampaignPopulator>.NativeClassPtr, "<>c__DisplayClass5_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CampaignPopulator.__c__DisplayClass5_0>.NativeClassPtr);
      CampaignPopulator.__c__DisplayClass5_0.NativeFieldInfoPtr_links = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignPopulator.__c__DisplayClass5_0>.NativeClassPtr, nameof (links));
      CampaignPopulator.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignPopulator.__c__DisplayClass5_0>.NativeClassPtr, 100673150);
    }

    public __c__DisplayClass5_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Dictionary<CampaignNode, CampaignNode> links
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignPopulator.__c__DisplayClass5_0.NativeFieldInfoPtr_links));
        return pointer == System.IntPtr.Zero ? (Dictionary<CampaignNode, CampaignNode>) null : new Dictionary<CampaignNode, CampaignNode>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignPopulator.__c__DisplayClass5_0.NativeFieldInfoPtr_links), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("CampaignPopulator/<>c__DisplayClass5_1")]
  public sealed class __c__DisplayClass5_1 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_node;
    private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass5_0_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__LinkNodes_b__0_Internal_Boolean_CampaignNode_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass5_1()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CampaignPopulator.__c__DisplayClass5_1>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CampaignPopulator.__c__DisplayClass5_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107621, XrefRangeEnd = 107630, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _LinkNodes_b__0(CampaignNode a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CampaignPopulator.__c__DisplayClass5_1.NativeMethodInfoPtr__LinkNodes_b__0_Internal_Boolean_CampaignNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass5_1()
    {
      Il2CppClassPointerStore<CampaignPopulator.__c__DisplayClass5_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CampaignPopulator>.NativeClassPtr, "<>c__DisplayClass5_1");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CampaignPopulator.__c__DisplayClass5_1>.NativeClassPtr);
      CampaignPopulator.__c__DisplayClass5_1.NativeFieldInfoPtr_node = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignPopulator.__c__DisplayClass5_1>.NativeClassPtr, nameof (node));
      CampaignPopulator.__c__DisplayClass5_1.NativeFieldInfoPtr_field_Public___c__DisplayClass5_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignPopulator.__c__DisplayClass5_1>.NativeClassPtr, "CS$<>8__locals1");
      CampaignPopulator.__c__DisplayClass5_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignPopulator.__c__DisplayClass5_1>.NativeClassPtr, 100673151);
      CampaignPopulator.__c__DisplayClass5_1.NativeMethodInfoPtr__LinkNodes_b__0_Internal_Boolean_CampaignNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignPopulator.__c__DisplayClass5_1>.NativeClassPtr, 100673152);
    }

    public __c__DisplayClass5_1(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CampaignNode node
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignPopulator.__c__DisplayClass5_1.NativeFieldInfoPtr_node));
        return pointer == System.IntPtr.Zero ? (CampaignNode) null : new CampaignNode(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignPopulator.__c__DisplayClass5_1.NativeFieldInfoPtr_node), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CampaignPopulator.__c__DisplayClass5_0 field_Public___c__DisplayClass5_0_0
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignPopulator.__c__DisplayClass5_1.NativeFieldInfoPtr_field_Public___c__DisplayClass5_0_0));
        return pointer == System.IntPtr.Zero ? (CampaignPopulator.__c__DisplayClass5_0) null : new CampaignPopulator.__c__DisplayClass5_0(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignPopulator.__c__DisplayClass5_1.NativeFieldInfoPtr_field_Public___c__DisplayClass5_0_0), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("CampaignPopulator/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__5_1;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__LinkNodes_b__5_1_Internal_Int32_CampaignNode_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CampaignPopulator.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CampaignPopulator.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe int _LinkNodes_b__5_1(CampaignNode a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CampaignPopulator.__c.NativeMethodInfoPtr__LinkNodes_b__5_1_Internal_Int32_CampaignNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c()
    {
      Il2CppClassPointerStore<CampaignPopulator.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CampaignPopulator>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CampaignPopulator.__c>.NativeClassPtr);
      CampaignPopulator.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignPopulator.__c>.NativeClassPtr, "<>9");
      CampaignPopulator.__c.NativeFieldInfoPtr___9__5_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignPopulator.__c>.NativeClassPtr, "<>9__5_1");
      CampaignPopulator.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignPopulator.__c>.NativeClassPtr, 100673154);
      CampaignPopulator.__c.NativeMethodInfoPtr__LinkNodes_b__5_1_Internal_Int32_CampaignNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignPopulator.__c>.NativeClassPtr, 100673155);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe CampaignPopulator.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(CampaignPopulator.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (CampaignPopulator.__c) null : new CampaignPopulator.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CampaignPopulator.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<CampaignNode, int> __9__5_1
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(CampaignPopulator.__c.NativeFieldInfoPtr___9__5_1, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<CampaignNode, int>) null : new Il2CppSystem.Func<CampaignNode, int>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CampaignPopulator.__c.NativeFieldInfoPtr___9__5_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
