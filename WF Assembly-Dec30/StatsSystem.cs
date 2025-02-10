// Decompiled with JetBrains decompiler
// Type: StatsSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class StatsSystem : GameSystem
{
  private static readonly System.IntPtr NativeFieldInfoPtr_instance;
  private static readonly System.IntPtr NativeFieldInfoPtr_stats;
  private static readonly System.IntPtr NativeFieldInfoPtr_goldThisBattle;
  private static readonly System.IntPtr NativeFieldInfoPtr_sacrificedThisBattle;
  private static readonly System.IntPtr NativeFieldInfoPtr_kingMokoExists;
  private static readonly System.IntPtr NativeFieldInfoPtr_campaignEnded;
  private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Static_CampaignStats_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Static_Void_CampaignStats_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Stats_Private_get_CampaignStats_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Protected_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Protected_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CampaignEnd_Private_Void_Result_CampaignStats_PlayerData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CampaignSaved_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntityHit_Private_Void_Hit_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PostEntityHit_Private_Void_Hit_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StatusApplied_Private_Void_StatusEffectApply_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntityKilled_Private_Void_Entity_DeathType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntityOffered_Private_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntityChosen_Private_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntityFlee_Private_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntityDiscarded_Private_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntitySummoned_Private_Void_Entity_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntityTriggered_Private_Void_byref_Trigger_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CardInjured_Private_Void_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BattleStart_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BattleEnd_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DropGold_Private_Void_Int32_String_Character_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SpendGold_Private_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ShopItemPurchase_Private_Void_ShopItem_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_KillCombo_Private_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RedrawBellHit_Private_Void_RedrawBellSystem_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BattleTurnStart_Private_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rename_Private_Void_Entity_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MuncherFeed_Private_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpgradeGained_Private_Void_CardUpgradeData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpgradeAssigned_Private_Void_Entity_CardUpgradeData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetBattleName_Private_Static_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 75505, RefRangeEnd = 75512, XrefRangeStart = 75503, XrefRangeEnd = 75505, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe CampaignStats Get()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_Get_Public_Static_CampaignStats_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (CampaignStats) null : new CampaignStats(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 75520, RefRangeEnd = 75522, XrefRangeStart = 75512, XrefRangeEnd = 75520, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Set(CampaignStats stats)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stats)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_Set_Public_Static_Void_CampaignStats_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  public unsafe CampaignStats Stats
  {
    [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_get_Stats_Private_get_CampaignStats_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CampaignStats) null : new CampaignStats(pointer);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75522, XrefRangeEnd = 75693, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_OnEnable_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75693, XrefRangeEnd = 75860, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_OnDisable_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75860, XrefRangeEnd = 75861, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 75861, RefRangeEnd = 75862, XrefRangeStart = 75861, XrefRangeEnd = 75861, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CampaignEnd(
    Campaign.Result result,
    CampaignStats stats,
    PlayerData playerData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &result;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stats);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) playerData);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_CampaignEnd_Private_Void_Result_CampaignStats_PlayerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75862, XrefRangeEnd = 75872, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CampaignSaved()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_CampaignSaved_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75872, XrefRangeEnd = 75906, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntityHit(Hit hit)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hit)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_EntityHit_Private_Void_Hit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75906, XrefRangeEnd = 75930, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PostEntityHit(Hit hit)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hit)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_PostEntityHit_Private_Void_Hit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75930, XrefRangeEnd = 75954, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StatusApplied(StatusEffectApply apply)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) apply)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_StatusApplied_Private_Void_StatusEffectApply_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75954, XrefRangeEnd = 76030, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntityKilled(Entity entity, DeathType deathType)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &deathType;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_EntityKilled_Private_Void_Entity_DeathType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76030, XrefRangeEnd = 76034, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntityOffered(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_EntityOffered_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76034, XrefRangeEnd = 76042, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntityChosen(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_EntityChosen_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76042, XrefRangeEnd = 76052, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntityFlee(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_EntityFlee_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76052, XrefRangeEnd = 76062, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntityDiscarded(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_EntityDiscarded_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76062, XrefRangeEnd = 76066, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntitySummoned(Entity entity, Entity summonedBy)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) summonedBy);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_EntitySummoned_Private_Void_Entity_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76066, XrefRangeEnd = 76080, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntityTriggered(ref Trigger trigger)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
    System.IntPtr* numPtr2 = numPtr1;
    System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) trigger);
    System.IntPtr* numPtr3 = &ptr;
    *numPtr2 = (System.IntPtr) numPtr3;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_EntityTriggered_Private_Void_byref_Trigger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    ref Trigger local = ref trigger;
    System.IntPtr pointer = ptr;
    Trigger trigger1 = pointer == System.IntPtr.Zero ? (Trigger) null : new Trigger(pointer);
    local = trigger1;
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76080, XrefRangeEnd = 76084, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CardInjured(CardData cardData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cardData)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_CardInjured_Private_Void_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76084, XrefRangeEnd = 76109, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BattleStart()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_BattleStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76109, XrefRangeEnd = 76149, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BattleEnd()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_BattleEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76149, XrefRangeEnd = 76152, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DropGold(int amount, string source, Character owner, Vector3 position)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &amount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(source);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) owner);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_DropGold_Private_Void_Int32_String_Character_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76152, XrefRangeEnd = 76156, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SpendGold(int amount)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &amount
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_SpendGold_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76156, XrefRangeEnd = 76198, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ShopItemPurchase(ShopItem item)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) item)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_ShopItemPurchase_Private_Void_ShopItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76198, XrefRangeEnd = 76202, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void KillCombo(int combo)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &combo
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_KillCombo_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76202, XrefRangeEnd = 76206, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RedrawBellHit(RedrawBellSystem redrawBellSystem)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) redrawBellSystem)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_RedrawBellHit_Private_Void_RedrawBellSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76206, XrefRangeEnd = 76210, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BattleTurnStart(int turnCount)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &turnCount
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_BattleTurnStart_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76210, XrefRangeEnd = 76217, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Rename(Entity entity, string newName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(newName);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_Rename_Private_Void_Entity_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76217, XrefRangeEnd = 76242, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void MuncherFeed(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_MuncherFeed_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76242, XrefRangeEnd = 76247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpgradeGained(CardUpgradeData upgradeData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) upgradeData)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_UpgradeGained_Private_Void_CardUpgradeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76247, XrefRangeEnd = 76255, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpgradeAssigned(Entity entity, CardUpgradeData upgradeData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) upgradeData);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_UpgradeAssigned_Private_Void_Entity_CardUpgradeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76255, XrefRangeEnd = 76265, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetBattleName()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_GetBattleName_Private_Static_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 21168, RefRangeEnd = 21171, XrefRangeStart = 21168, XrefRangeEnd = 21171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StatsSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static StatsSystem()
  {
    Il2CppClassPointerStore<StatsSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (StatsSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr);
    StatsSystem.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, nameof (instance));
    StatsSystem.NativeFieldInfoPtr_stats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, nameof (stats));
    StatsSystem.NativeFieldInfoPtr_goldThisBattle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, nameof (goldThisBattle));
    StatsSystem.NativeFieldInfoPtr_sacrificedThisBattle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, nameof (sacrificedThisBattle));
    StatsSystem.NativeFieldInfoPtr_kingMokoExists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, nameof (kingMokoExists));
    StatsSystem.NativeFieldInfoPtr_campaignEnded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, nameof (campaignEnded));
    StatsSystem.NativeMethodInfoPtr_Get_Public_Static_CampaignStats_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669393);
    StatsSystem.NativeMethodInfoPtr_Set_Public_Static_Void_CampaignStats_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669394);
    StatsSystem.NativeMethodInfoPtr_get_Stats_Private_get_CampaignStats_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669395);
    StatsSystem.NativeMethodInfoPtr_OnEnable_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669396);
    StatsSystem.NativeMethodInfoPtr_OnDisable_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669397);
    StatsSystem.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669398);
    StatsSystem.NativeMethodInfoPtr_CampaignEnd_Private_Void_Result_CampaignStats_PlayerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669399);
    StatsSystem.NativeMethodInfoPtr_CampaignSaved_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669400);
    StatsSystem.NativeMethodInfoPtr_EntityHit_Private_Void_Hit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669401);
    StatsSystem.NativeMethodInfoPtr_PostEntityHit_Private_Void_Hit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669402);
    StatsSystem.NativeMethodInfoPtr_StatusApplied_Private_Void_StatusEffectApply_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669403);
    StatsSystem.NativeMethodInfoPtr_EntityKilled_Private_Void_Entity_DeathType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669404);
    StatsSystem.NativeMethodInfoPtr_EntityOffered_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669405);
    StatsSystem.NativeMethodInfoPtr_EntityChosen_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669406);
    StatsSystem.NativeMethodInfoPtr_EntityFlee_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669407);
    StatsSystem.NativeMethodInfoPtr_EntityDiscarded_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669408);
    StatsSystem.NativeMethodInfoPtr_EntitySummoned_Private_Void_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669409);
    StatsSystem.NativeMethodInfoPtr_EntityTriggered_Private_Void_byref_Trigger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669410);
    StatsSystem.NativeMethodInfoPtr_CardInjured_Private_Void_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669411);
    StatsSystem.NativeMethodInfoPtr_BattleStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669412);
    StatsSystem.NativeMethodInfoPtr_BattleEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669413);
    StatsSystem.NativeMethodInfoPtr_DropGold_Private_Void_Int32_String_Character_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669414);
    StatsSystem.NativeMethodInfoPtr_SpendGold_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669415);
    StatsSystem.NativeMethodInfoPtr_ShopItemPurchase_Private_Void_ShopItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669416);
    StatsSystem.NativeMethodInfoPtr_KillCombo_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669417);
    StatsSystem.NativeMethodInfoPtr_RedrawBellHit_Private_Void_RedrawBellSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669418);
    StatsSystem.NativeMethodInfoPtr_BattleTurnStart_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669419);
    StatsSystem.NativeMethodInfoPtr_Rename_Private_Void_Entity_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669420);
    StatsSystem.NativeMethodInfoPtr_MuncherFeed_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669421);
    StatsSystem.NativeMethodInfoPtr_UpgradeGained_Private_Void_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669422);
    StatsSystem.NativeMethodInfoPtr_UpgradeAssigned_Private_Void_Entity_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669423);
    StatsSystem.NativeMethodInfoPtr_GetBattleName_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669424);
    StatsSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669425);
  }

  public StatsSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe StatsSystem instance
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(StatsSystem.NativeFieldInfoPtr_instance, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (StatsSystem) null : new StatsSystem(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(StatsSystem.NativeFieldInfoPtr_instance, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CampaignStats stats
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsSystem.NativeFieldInfoPtr_stats));
      return pointer == System.IntPtr.Zero ? (CampaignStats) null : new CampaignStats(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatsSystem.NativeFieldInfoPtr_stats), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int goldThisBattle
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsSystem.NativeFieldInfoPtr_goldThisBattle));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsSystem.NativeFieldInfoPtr_goldThisBattle)) = value;
    }
  }

  public unsafe int sacrificedThisBattle
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsSystem.NativeFieldInfoPtr_sacrificedThisBattle));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsSystem.NativeFieldInfoPtr_sacrificedThisBattle)) = value;
    }
  }

  public unsafe bool kingMokoExists
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsSystem.NativeFieldInfoPtr_kingMokoExists));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsSystem.NativeFieldInfoPtr_kingMokoExists)) = value;
    }
  }

  public unsafe bool campaignEnded
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsSystem.NativeFieldInfoPtr_campaignEnded));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsSystem.NativeFieldInfoPtr_campaignEnded)) = value;
    }
  }

  [ObfuscatedName("StatsSystem/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__18_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__26_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__EntityKilled_b__18_0_Internal_Boolean_StatusEffectData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__BattleStart_b__26_0_Internal_Boolean_Entity_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatsSystem.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatsSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75498, XrefRangeEnd = 75502, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _EntityKilled_b__18_0(StatusEffectData a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatsSystem.__c.NativeMethodInfoPtr__EntityKilled_b__18_0_Internal_Boolean_StatusEffectData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75502, XrefRangeEnd = 75503, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _BattleStart_b__26_0(Entity a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatsSystem.__c.NativeMethodInfoPtr__BattleStart_b__26_0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c()
    {
      Il2CppClassPointerStore<StatsSystem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatsSystem.__c>.NativeClassPtr);
      StatsSystem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsSystem.__c>.NativeClassPtr, "<>9");
      StatsSystem.__c.NativeFieldInfoPtr___9__18_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsSystem.__c>.NativeClassPtr, "<>9__18_0");
      StatsSystem.__c.NativeFieldInfoPtr___9__26_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsSystem.__c>.NativeClassPtr, "<>9__26_0");
      StatsSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem.__c>.NativeClassPtr, 100669427);
      StatsSystem.__c.NativeMethodInfoPtr__EntityKilled_b__18_0_Internal_Boolean_StatusEffectData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem.__c>.NativeClassPtr, 100669428);
      StatsSystem.__c.NativeMethodInfoPtr__BattleStart_b__26_0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem.__c>.NativeClassPtr, 100669429);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe StatsSystem.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(StatsSystem.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (StatsSystem.__c) null : new StatsSystem.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StatsSystem.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Predicate<StatusEffectData> __9__18_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(StatsSystem.__c.NativeFieldInfoPtr___9__18_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Predicate<StatusEffectData>) null : new Il2CppSystem.Predicate<StatusEffectData>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StatsSystem.__c.NativeFieldInfoPtr___9__18_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<Entity, bool> __9__26_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(StatsSystem.__c.NativeFieldInfoPtr___9__26_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Entity, bool>) null : new Il2CppSystem.Func<Entity, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StatsSystem.__c.NativeFieldInfoPtr___9__26_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
