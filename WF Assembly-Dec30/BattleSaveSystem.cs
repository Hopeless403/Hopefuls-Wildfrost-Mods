// Decompiled with JetBrains decompiler
// Type: BattleSaveSystem
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
using UnityEngine.Events;

#nullable disable
public class BattleSaveSystem : GameSystem
{
  private static readonly System.IntPtr NativeFieldInfoPtr_instance;
  private static readonly System.IntPtr NativeFieldInfoPtr_loading;
  private static readonly System.IntPtr NativeFieldInfoPtr_justLoaded;
  private static readonly System.IntPtr NativeFieldInfoPtr_state;
  private static readonly System.IntPtr NativeFieldInfoPtr_saveRequired;
  private static readonly System.IntPtr NativeFieldInfoPtr_campaignNodeIdSet;
  private static readonly System.IntPtr NativeFieldInfoPtr_campaignNodeId;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetBattleState_Public_Static_BattleSaveData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BattleTurnEnd_Private_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CampaignFinal_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckSave_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Save_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BuildBattleState_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryLoadBattleState_Public_Boolean_CampaignNode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryLoadBattleState_Public_Boolean_BattleSaveData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadRoutine_Public_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateCardsInRows_Private_Static_IEnumerator_IReadOnlyList_1_CardSlotLane_IReadOnlyList_1_Container_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateCards_Private_Static_IEnumerator_CardContainer_IReadOnlyList_1_BattleEntityData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateCard_Private_Static_IEnumerator_BattleEntityData_CardController_Character_UnityAction_1_Card_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCard_Private_Static_IEnumerator_Entity_IReadOnlyDictionary_2_String_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68499, XrefRangeEnd = 68518, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68518, XrefRangeEnd = 68533, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68533, XrefRangeEnd = 68534, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnApplicationQuit()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68534, XrefRangeEnd = 68536, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe BattleSaveData GetBattleState()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.NativeMethodInfoPtr_GetBattleState_Public_Static_BattleSaveData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (BattleSaveData) null : new BattleSaveData(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68536, XrefRangeEnd = 68537, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BattleTurnEnd(int turnCount)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &turnCount
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.NativeMethodInfoPtr_BattleTurnEnd_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CampaignFinal()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.NativeMethodInfoPtr_CampaignFinal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 68562, RefRangeEnd = 68564, XrefRangeStart = 68537, XrefRangeEnd = 68562, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CheckSave()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.NativeMethodInfoPtr_CheckSave_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68564, XrefRangeEnd = 68585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Save()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.NativeMethodInfoPtr_Save_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 68744, RefRangeEnd = 68745, XrefRangeStart = 68585, XrefRangeEnd = 68744, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BuildBattleState()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.NativeMethodInfoPtr_BuildBattleState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68745, XrefRangeEnd = 68757, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool TryLoadBattleState(CampaignNode campaignNode)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) campaignNode)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.NativeMethodInfoPtr_TryLoadBattleState_Public_Boolean_CampaignNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68757, XrefRangeEnd = 68758, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool TryLoadBattleState(BattleSaveData state)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) state)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.NativeMethodInfoPtr_TryLoadBattleState_Public_Boolean_BattleSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68758, XrefRangeEnd = 68763, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator LoadRoutine()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.NativeMethodInfoPtr_LoadRoutine_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 68769, RefRangeEnd = 68771, XrefRangeStart = 68763, XrefRangeEnd = 68769, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe IEnumerator CreateCardsInRows(
    IReadOnlyList<CardSlotLane> rows,
    IReadOnlyList<BattleSaveData.Container> rowSaveDatas)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rows);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rowSaveDatas);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.NativeMethodInfoPtr_CreateCardsInRows_Private_Static_IEnumerator_IReadOnlyList_1_CardSlotLane_IReadOnlyList_1_Container_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 68777, RefRangeEnd = 68782, XrefRangeStart = 68771, XrefRangeEnd = 68777, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe IEnumerator CreateCards(
    CardContainer container,
    IReadOnlyList<BattleEntityData> entitySaveData)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entitySaveData);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.NativeMethodInfoPtr_CreateCards_Private_Static_IEnumerator_CardContainer_IReadOnlyList_1_BattleEntityData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 68790, RefRangeEnd = 68792, XrefRangeStart = 68782, XrefRangeEnd = 68790, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe IEnumerator CreateCard(
    BattleEntityData entityData,
    CardController cardController,
    Character owner,
    UnityAction<Card> onComplete)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entityData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cardController);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) owner);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onComplete);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.NativeMethodInfoPtr_CreateCard_Private_Static_IEnumerator_BattleEntityData_CardController_Character_UnityAction_1_Card_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68792, XrefRangeEnd = 68798, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe IEnumerator UpdateCard(
    Entity card,
    IReadOnlyDictionary<string, Il2CppSystem.Object> customDatas)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) card);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) customDatas);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.NativeMethodInfoPtr_UpdateCard_Private_Static_IEnumerator_Entity_IReadOnlyDictionary_2_String_Object_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 21168, RefRangeEnd = 21171, XrefRangeStart = 21168, XrefRangeEnd = 21171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BattleSaveSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static BattleSaveSystem()
  {
    Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (BattleSaveSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr);
    BattleSaveSystem.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, nameof (instance));
    BattleSaveSystem.NativeFieldInfoPtr_loading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, nameof (loading));
    BattleSaveSystem.NativeFieldInfoPtr_justLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, nameof (justLoaded));
    BattleSaveSystem.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, nameof (state));
    BattleSaveSystem.NativeFieldInfoPtr_saveRequired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, nameof (saveRequired));
    BattleSaveSystem.NativeFieldInfoPtr_campaignNodeIdSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, nameof (campaignNodeIdSet));
    BattleSaveSystem.NativeFieldInfoPtr_campaignNodeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, nameof (campaignNodeId));
    BattleSaveSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, 100668883);
    BattleSaveSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, 100668884);
    BattleSaveSystem.NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, 100668885);
    BattleSaveSystem.NativeMethodInfoPtr_GetBattleState_Public_Static_BattleSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, 100668886);
    BattleSaveSystem.NativeMethodInfoPtr_BattleTurnEnd_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, 100668887);
    BattleSaveSystem.NativeMethodInfoPtr_CampaignFinal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, 100668888);
    BattleSaveSystem.NativeMethodInfoPtr_CheckSave_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, 100668889);
    BattleSaveSystem.NativeMethodInfoPtr_Save_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, 100668890);
    BattleSaveSystem.NativeMethodInfoPtr_BuildBattleState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, 100668891);
    BattleSaveSystem.NativeMethodInfoPtr_TryLoadBattleState_Public_Boolean_CampaignNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, 100668892);
    BattleSaveSystem.NativeMethodInfoPtr_TryLoadBattleState_Public_Boolean_BattleSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, 100668893);
    BattleSaveSystem.NativeMethodInfoPtr_LoadRoutine_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, 100668894);
    BattleSaveSystem.NativeMethodInfoPtr_CreateCardsInRows_Private_Static_IEnumerator_IReadOnlyList_1_CardSlotLane_IReadOnlyList_1_Container_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, 100668895);
    BattleSaveSystem.NativeMethodInfoPtr_CreateCards_Private_Static_IEnumerator_CardContainer_IReadOnlyList_1_BattleEntityData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, 100668896);
    BattleSaveSystem.NativeMethodInfoPtr_CreateCard_Private_Static_IEnumerator_BattleEntityData_CardController_Character_UnityAction_1_Card_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, 100668897);
    BattleSaveSystem.NativeMethodInfoPtr_UpdateCard_Private_Static_IEnumerator_Entity_IReadOnlyDictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, 100668898);
    BattleSaveSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, 100668899);
  }

  public BattleSaveSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe BattleSaveSystem instance
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(BattleSaveSystem.NativeFieldInfoPtr_instance, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (BattleSaveSystem) null : new BattleSaveSystem(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(BattleSaveSystem.NativeFieldInfoPtr_instance, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool loading
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.NativeFieldInfoPtr_loading));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.NativeFieldInfoPtr_loading)) = value;
    }
  }

  public unsafe bool justLoaded
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.NativeFieldInfoPtr_justLoaded));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.NativeFieldInfoPtr_justLoaded)) = value;
    }
  }

  public unsafe BattleSaveData state
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.NativeFieldInfoPtr_state));
      return pointer == System.IntPtr.Zero ? (BattleSaveData) null : new BattleSaveData(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.NativeFieldInfoPtr_state), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool saveRequired
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.NativeFieldInfoPtr_saveRequired));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.NativeFieldInfoPtr_saveRequired)) = value;
    }
  }

  public unsafe bool campaignNodeIdSet
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.NativeFieldInfoPtr_campaignNodeIdSet));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.NativeFieldInfoPtr_campaignNodeIdSet)) = value;
    }
  }

  public unsafe int campaignNodeId
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.NativeFieldInfoPtr_campaignNodeId));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.NativeFieldInfoPtr_campaignNodeId)) = value;
    }
  }

  [ObfuscatedName("BattleSaveSystem/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__15_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__15_1;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__18_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__21_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__BuildBattleState_b__15_0_Internal_Boolean_StatusEffectData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__BuildBattleState_b__15_1_Internal_Status_StatusEffectData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__LoadRoutine_b__18_0_Internal_CardData_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__CreateCard_b__21_0_Internal_StatusEffectStacks_StatusEffectSaveData_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleSaveSystem.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68050, XrefRangeEnd = 68057, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _BuildBattleState_b__15_0(StatusEffectData e)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) e)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.__c.NativeMethodInfoPtr__BuildBattleState_b__15_0_Internal_Boolean_StatusEffectData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68057, XrefRangeEnd = 68061, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BattleSaveData.Status _BuildBattleState_b__15_1(StatusEffectData e)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) e)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.__c.NativeMethodInfoPtr__BuildBattleState_b__15_1_Internal_Status_StatusEffectData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (BattleSaveData.Status) null : new BattleSaveData.Status(pointer);
    }

    [CallerCount(0)]
    public unsafe CardData _LoadRoutine_b__18_0(Entity a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.__c.NativeMethodInfoPtr__LoadRoutine_b__18_0_Internal_CardData_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CardData) null : new CardData(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68061, XrefRangeEnd = 68063, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CardData.StatusEffectStacks _CreateCard_b__21_0(StatusEffectSaveData e)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) e)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.__c.NativeMethodInfoPtr__CreateCard_b__21_0_Internal_StatusEffectStacks_StatusEffectSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CardData.StatusEffectStacks) null : new CardData.StatusEffectStacks(pointer);
    }

    static __c()
    {
      Il2CppClassPointerStore<BattleSaveSystem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleSaveSystem.__c>.NativeClassPtr);
      BattleSaveSystem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem.__c>.NativeClassPtr, "<>9");
      BattleSaveSystem.__c.NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem.__c>.NativeClassPtr, "<>9__15_0");
      BattleSaveSystem.__c.NativeFieldInfoPtr___9__15_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem.__c>.NativeClassPtr, "<>9__15_1");
      BattleSaveSystem.__c.NativeFieldInfoPtr___9__18_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem.__c>.NativeClassPtr, "<>9__18_0");
      BattleSaveSystem.__c.NativeFieldInfoPtr___9__21_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem.__c>.NativeClassPtr, "<>9__21_0");
      BattleSaveSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem.__c>.NativeClassPtr, 100668901);
      BattleSaveSystem.__c.NativeMethodInfoPtr__BuildBattleState_b__15_0_Internal_Boolean_StatusEffectData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem.__c>.NativeClassPtr, 100668902);
      BattleSaveSystem.__c.NativeMethodInfoPtr__BuildBattleState_b__15_1_Internal_Status_StatusEffectData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem.__c>.NativeClassPtr, 100668903);
      BattleSaveSystem.__c.NativeMethodInfoPtr__LoadRoutine_b__18_0_Internal_CardData_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem.__c>.NativeClassPtr, 100668904);
      BattleSaveSystem.__c.NativeMethodInfoPtr__CreateCard_b__21_0_Internal_StatusEffectStacks_StatusEffectSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem.__c>.NativeClassPtr, 100668905);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe BattleSaveSystem.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(BattleSaveSystem.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (BattleSaveSystem.__c) null : new BattleSaveSystem.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(BattleSaveSystem.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<StatusEffectData, bool> __9__15_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(BattleSaveSystem.__c.NativeFieldInfoPtr___9__15_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<StatusEffectData, bool>) null : new Il2CppSystem.Func<StatusEffectData, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(BattleSaveSystem.__c.NativeFieldInfoPtr___9__15_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<StatusEffectData, BattleSaveData.Status> __9__15_1
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(BattleSaveSystem.__c.NativeFieldInfoPtr___9__15_1, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<StatusEffectData, BattleSaveData.Status>) null : new Il2CppSystem.Func<StatusEffectData, BattleSaveData.Status>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(BattleSaveSystem.__c.NativeFieldInfoPtr___9__15_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<Entity, CardData> __9__18_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(BattleSaveSystem.__c.NativeFieldInfoPtr___9__18_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Entity, CardData>) null : new Il2CppSystem.Func<Entity, CardData>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(BattleSaveSystem.__c.NativeFieldInfoPtr___9__18_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<StatusEffectSaveData, CardData.StatusEffectStacks> __9__21_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(BattleSaveSystem.__c.NativeFieldInfoPtr___9__21_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<StatusEffectSaveData, CardData.StatusEffectStacks>) null : new Il2CppSystem.Func<StatusEffectSaveData, CardData.StatusEffectStacks>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(BattleSaveSystem.__c.NativeFieldInfoPtr___9__21_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("BattleSaveSystem/<>c__DisplayClass18_0")]
  public sealed class __c__DisplayClass18_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_status;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__LoadRoutine_b__1_Internal_Boolean_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__LoadRoutine_b__2_Internal_Boolean_Entity_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass18_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass18_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _LoadRoutine_b__1(Entity a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.__c__DisplayClass18_0.NativeMethodInfoPtr__LoadRoutine_b__1_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe bool _LoadRoutine_b__2(Entity a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.__c__DisplayClass18_0.NativeMethodInfoPtr__LoadRoutine_b__2_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass18_0()
    {
      Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, "<>c__DisplayClass18_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass18_0>.NativeClassPtr);
      BattleSaveSystem.__c__DisplayClass18_0.NativeFieldInfoPtr_status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass18_0>.NativeClassPtr, nameof (status));
      BattleSaveSystem.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass18_0>.NativeClassPtr, 100668906);
      BattleSaveSystem.__c__DisplayClass18_0.NativeMethodInfoPtr__LoadRoutine_b__1_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass18_0>.NativeClassPtr, 100668907);
      BattleSaveSystem.__c__DisplayClass18_0.NativeMethodInfoPtr__LoadRoutine_b__2_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass18_0>.NativeClassPtr, 100668908);
    }

    public __c__DisplayClass18_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe BattleSaveData.Status status
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.__c__DisplayClass18_0.NativeFieldInfoPtr_status));
        return pointer == System.IntPtr.Zero ? (BattleSaveData.Status) null : new BattleSaveData.Status(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.__c__DisplayClass18_0.NativeFieldInfoPtr_status), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("BattleSaveSystem/<LoadRoutine>d__18")]
  public sealed class _LoadRoutine_d__18 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr___7__wrap1;
    private static readonly System.IntPtr NativeFieldInfoPtr___7__wrap2;
    private static readonly System.IntPtr NativeFieldInfoPtr___7__wrap3;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _LoadRoutine_d__18(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleSaveSystem._LoadRoutine_d__18>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._LoadRoutine_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 68070, RefRangeEnd = 68072, XrefRangeStart = 68063, XrefRangeEnd = 68070, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._LoadRoutine_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68072, XrefRangeEnd = 68242, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._LoadRoutine_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68242, XrefRangeEnd = 68245, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void __m__Finally1()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._LoadRoutine_d__18.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._LoadRoutine_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68245, XrefRangeEnd = 68251, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._LoadRoutine_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._LoadRoutine_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _LoadRoutine_d__18()
    {
      Il2CppClassPointerStore<BattleSaveSystem._LoadRoutine_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, "<LoadRoutine>d__18");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleSaveSystem._LoadRoutine_d__18>.NativeClassPtr);
      BattleSaveSystem._LoadRoutine_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._LoadRoutine_d__18>.NativeClassPtr, "<>1__state");
      BattleSaveSystem._LoadRoutine_d__18.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._LoadRoutine_d__18>.NativeClassPtr, "<>2__current");
      BattleSaveSystem._LoadRoutine_d__18.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._LoadRoutine_d__18>.NativeClassPtr, "<>4__this");
      BattleSaveSystem._LoadRoutine_d__18.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._LoadRoutine_d__18>.NativeClassPtr, "<>7__wrap1");
      BattleSaveSystem._LoadRoutine_d__18.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._LoadRoutine_d__18>.NativeClassPtr, "<>7__wrap2");
      BattleSaveSystem._LoadRoutine_d__18.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._LoadRoutine_d__18>.NativeClassPtr, "<>7__wrap3");
      BattleSaveSystem._LoadRoutine_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._LoadRoutine_d__18>.NativeClassPtr, 100668909);
      BattleSaveSystem._LoadRoutine_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._LoadRoutine_d__18>.NativeClassPtr, 100668910);
      BattleSaveSystem._LoadRoutine_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._LoadRoutine_d__18>.NativeClassPtr, 100668911);
      BattleSaveSystem._LoadRoutine_d__18.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._LoadRoutine_d__18>.NativeClassPtr, 100668912);
      BattleSaveSystem._LoadRoutine_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._LoadRoutine_d__18>.NativeClassPtr, 100668913);
      BattleSaveSystem._LoadRoutine_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._LoadRoutine_d__18>.NativeClassPtr, 100668914);
      BattleSaveSystem._LoadRoutine_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._LoadRoutine_d__18>.NativeClassPtr, 100668915);
    }

    public _LoadRoutine_d__18(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._LoadRoutine_d__18.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._LoadRoutine_d__18.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._LoadRoutine_d__18.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._LoadRoutine_d__18.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BattleSaveSystem __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._LoadRoutine_d__18.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (BattleSaveSystem) null : new BattleSaveSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._LoadRoutine_d__18.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<BattleSaveData.Status> __7__wrap1
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._LoadRoutine_d__18.NativeFieldInfoPtr___7__wrap1));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<BattleSaveData.Status>) null : new Il2CppReferenceArray<BattleSaveData.Status>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._LoadRoutine_d__18.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int __7__wrap2
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._LoadRoutine_d__18.NativeFieldInfoPtr___7__wrap2));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._LoadRoutine_d__18.NativeFieldInfoPtr___7__wrap2)) = value;
      }
    }

    public List<Entity>.Enumerator __7__wrap3
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._LoadRoutine_d__18.NativeFieldInfoPtr___7__wrap3);
        return new List<Entity>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<Entity>.Enumerator>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._LoadRoutine_d__18.NativeFieldInfoPtr___7__wrap3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<Entity>.Enumerator>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  [ObfuscatedName("BattleSaveSystem/<>c__DisplayClass19_0")]
  public sealed class __c__DisplayClass19_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_entities;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass19_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass19_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static __c__DisplayClass19_0()
    {
      Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass19_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, "<>c__DisplayClass19_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass19_0>.NativeClassPtr);
      BattleSaveSystem.__c__DisplayClass19_0.NativeFieldInfoPtr_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass19_0>.NativeClassPtr, nameof (entities));
      BattleSaveSystem.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass19_0>.NativeClassPtr, 100668916);
    }

    public __c__DisplayClass19_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Dictionary<ulong, Entity> entities
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.__c__DisplayClass19_0.NativeFieldInfoPtr_entities));
        return pointer == System.IntPtr.Zero ? (Dictionary<ulong, Entity>) null : new Dictionary<ulong, Entity>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.__c__DisplayClass19_0.NativeFieldInfoPtr_entities), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("BattleSaveSystem/<>c__DisplayClass19_1")]
  public sealed class __c__DisplayClass19_1 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_row;
    private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass19_0_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass19_1()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass19_1>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.__c__DisplayClass19_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static __c__DisplayClass19_1()
    {
      Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass19_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, "<>c__DisplayClass19_1");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass19_1>.NativeClassPtr);
      BattleSaveSystem.__c__DisplayClass19_1.NativeFieldInfoPtr_row = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass19_1>.NativeClassPtr, nameof (row));
      BattleSaveSystem.__c__DisplayClass19_1.NativeFieldInfoPtr_field_Public___c__DisplayClass19_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass19_1>.NativeClassPtr, "CS$<>8__locals1");
      BattleSaveSystem.__c__DisplayClass19_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass19_1>.NativeClassPtr, 100668917);
    }

    public __c__DisplayClass19_1(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CardSlotLane row
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.__c__DisplayClass19_1.NativeFieldInfoPtr_row));
        return pointer == System.IntPtr.Zero ? (CardSlotLane) null : new CardSlotLane(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.__c__DisplayClass19_1.NativeFieldInfoPtr_row), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BattleSaveSystem.__c__DisplayClass19_0 field_Public___c__DisplayClass19_0_0
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.__c__DisplayClass19_1.NativeFieldInfoPtr_field_Public___c__DisplayClass19_0_0));
        return pointer == System.IntPtr.Zero ? (BattleSaveSystem.__c__DisplayClass19_0) null : new BattleSaveSystem.__c__DisplayClass19_0(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.__c__DisplayClass19_1.NativeFieldInfoPtr_field_Public___c__DisplayClass19_0_0), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("BattleSaveSystem/<>c__DisplayClass19_2")]
  public sealed class __c__DisplayClass19_2 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_d;
    private static readonly System.IntPtr NativeFieldInfoPtr_entityIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass19_1_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__CreateCardsInRows_b__0_Internal_Void_Card_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass19_2()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass19_2>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.__c__DisplayClass19_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68251, XrefRangeEnd = 68258, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _CreateCardsInRows_b__0(Card a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.__c__DisplayClass19_2.NativeMethodInfoPtr__CreateCardsInRows_b__0_Internal_Void_Card_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static __c__DisplayClass19_2()
    {
      Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass19_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, "<>c__DisplayClass19_2");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass19_2>.NativeClassPtr);
      BattleSaveSystem.__c__DisplayClass19_2.NativeFieldInfoPtr_d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass19_2>.NativeClassPtr, nameof (d));
      BattleSaveSystem.__c__DisplayClass19_2.NativeFieldInfoPtr_entityIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass19_2>.NativeClassPtr, nameof (entityIndex));
      BattleSaveSystem.__c__DisplayClass19_2.NativeFieldInfoPtr_field_Public___c__DisplayClass19_1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass19_2>.NativeClassPtr, "CS$<>8__locals2");
      BattleSaveSystem.__c__DisplayClass19_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass19_2>.NativeClassPtr, 100668918);
      BattleSaveSystem.__c__DisplayClass19_2.NativeMethodInfoPtr__CreateCardsInRows_b__0_Internal_Void_Card_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass19_2>.NativeClassPtr, 100668919);
    }

    public __c__DisplayClass19_2(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe BattleEntityData d
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.__c__DisplayClass19_2.NativeFieldInfoPtr_d));
        return pointer == System.IntPtr.Zero ? (BattleEntityData) null : new BattleEntityData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.__c__DisplayClass19_2.NativeFieldInfoPtr_d), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int entityIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.__c__DisplayClass19_2.NativeFieldInfoPtr_entityIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.__c__DisplayClass19_2.NativeFieldInfoPtr_entityIndex)) = value;
      }
    }

    public unsafe BattleSaveSystem.__c__DisplayClass19_1 field_Public___c__DisplayClass19_1_0
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.__c__DisplayClass19_2.NativeFieldInfoPtr_field_Public___c__DisplayClass19_1_0));
        return pointer == System.IntPtr.Zero ? (BattleSaveSystem.__c__DisplayClass19_1) null : new BattleSaveSystem.__c__DisplayClass19_1(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.__c__DisplayClass19_2.NativeFieldInfoPtr_field_Public___c__DisplayClass19_1_0), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("BattleSaveSystem/<CreateCardsInRows>d__19")]
  public sealed class _CreateCardsInRows_d__19 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___8__1;
    private static readonly System.IntPtr NativeFieldInfoPtr_rows;
    private static readonly System.IntPtr NativeFieldInfoPtr_rowSaveDatas;
    private static readonly System.IntPtr NativeFieldInfoPtr__cardController_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr__clump_5__3;
    private static readonly System.IntPtr NativeFieldInfoPtr__rowI_5__4;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _CreateCardsInRows_d__19(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleSaveSystem._CreateCardsInRows_d__19>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._CreateCardsInRows_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._CreateCardsInRows_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68258, XrefRangeEnd = 68331, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._CreateCardsInRows_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._CreateCardsInRows_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68331, XrefRangeEnd = 68337, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._CreateCardsInRows_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._CreateCardsInRows_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _CreateCardsInRows_d__19()
    {
      Il2CppClassPointerStore<BattleSaveSystem._CreateCardsInRows_d__19>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, "<CreateCardsInRows>d__19");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleSaveSystem._CreateCardsInRows_d__19>.NativeClassPtr);
      BattleSaveSystem._CreateCardsInRows_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._CreateCardsInRows_d__19>.NativeClassPtr, "<>1__state");
      BattleSaveSystem._CreateCardsInRows_d__19.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._CreateCardsInRows_d__19>.NativeClassPtr, "<>2__current");
      BattleSaveSystem._CreateCardsInRows_d__19.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._CreateCardsInRows_d__19>.NativeClassPtr, "<>8__1");
      BattleSaveSystem._CreateCardsInRows_d__19.NativeFieldInfoPtr_rows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._CreateCardsInRows_d__19>.NativeClassPtr, nameof (rows));
      BattleSaveSystem._CreateCardsInRows_d__19.NativeFieldInfoPtr_rowSaveDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._CreateCardsInRows_d__19>.NativeClassPtr, nameof (rowSaveDatas));
      BattleSaveSystem._CreateCardsInRows_d__19.NativeFieldInfoPtr__cardController_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._CreateCardsInRows_d__19>.NativeClassPtr, "<cardController>5__2");
      BattleSaveSystem._CreateCardsInRows_d__19.NativeFieldInfoPtr__clump_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._CreateCardsInRows_d__19>.NativeClassPtr, "<clump>5__3");
      BattleSaveSystem._CreateCardsInRows_d__19.NativeFieldInfoPtr__rowI_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._CreateCardsInRows_d__19>.NativeClassPtr, "<rowI>5__4");
      BattleSaveSystem._CreateCardsInRows_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._CreateCardsInRows_d__19>.NativeClassPtr, 100668920);
      BattleSaveSystem._CreateCardsInRows_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._CreateCardsInRows_d__19>.NativeClassPtr, 100668921);
      BattleSaveSystem._CreateCardsInRows_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._CreateCardsInRows_d__19>.NativeClassPtr, 100668922);
      BattleSaveSystem._CreateCardsInRows_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._CreateCardsInRows_d__19>.NativeClassPtr, 100668923);
      BattleSaveSystem._CreateCardsInRows_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._CreateCardsInRows_d__19>.NativeClassPtr, 100668924);
      BattleSaveSystem._CreateCardsInRows_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._CreateCardsInRows_d__19>.NativeClassPtr, 100668925);
    }

    public _CreateCardsInRows_d__19(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCardsInRows_d__19.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCardsInRows_d__19.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCardsInRows_d__19.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCardsInRows_d__19.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BattleSaveSystem.__c__DisplayClass19_0 __8__1
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCardsInRows_d__19.NativeFieldInfoPtr___8__1));
        return pointer == System.IntPtr.Zero ? (BattleSaveSystem.__c__DisplayClass19_0) null : new BattleSaveSystem.__c__DisplayClass19_0(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCardsInRows_d__19.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe IReadOnlyList<CardSlotLane> rows
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCardsInRows_d__19.NativeFieldInfoPtr_rows));
        return pointer == System.IntPtr.Zero ? (IReadOnlyList<CardSlotLane>) null : new IReadOnlyList<CardSlotLane>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCardsInRows_d__19.NativeFieldInfoPtr_rows), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe IReadOnlyList<BattleSaveData.Container> rowSaveDatas
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCardsInRows_d__19.NativeFieldInfoPtr_rowSaveDatas));
        return pointer == System.IntPtr.Zero ? (IReadOnlyList<BattleSaveData.Container>) null : new IReadOnlyList<BattleSaveData.Container>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCardsInRows_d__19.NativeFieldInfoPtr_rowSaveDatas), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CardController _cardController_5__2
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCardsInRows_d__19.NativeFieldInfoPtr__cardController_5__2));
        return pointer == System.IntPtr.Zero ? (CardController) null : new CardController(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCardsInRows_d__19.NativeFieldInfoPtr__cardController_5__2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Routine.Clump _clump_5__3
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCardsInRows_d__19.NativeFieldInfoPtr__clump_5__3));
        return pointer == System.IntPtr.Zero ? (Routine.Clump) null : new Routine.Clump(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCardsInRows_d__19.NativeFieldInfoPtr__clump_5__3), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int _rowI_5__4
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCardsInRows_d__19.NativeFieldInfoPtr__rowI_5__4));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCardsInRows_d__19.NativeFieldInfoPtr__rowI_5__4)) = value;
      }
    }
  }

  [ObfuscatedName("BattleSaveSystem/<>c__DisplayClass20_0")]
  public sealed class __c__DisplayClass20_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_entities;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass20_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass20_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static __c__DisplayClass20_0()
    {
      Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, "<>c__DisplayClass20_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass20_0>.NativeClassPtr);
      BattleSaveSystem.__c__DisplayClass20_0.NativeFieldInfoPtr_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass20_0>.NativeClassPtr, nameof (entities));
      BattleSaveSystem.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass20_0>.NativeClassPtr, 100668926);
    }

    public __c__DisplayClass20_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppReferenceArray<Entity> entities
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.__c__DisplayClass20_0.NativeFieldInfoPtr_entities));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Entity>) null : new Il2CppReferenceArray<Entity>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.__c__DisplayClass20_0.NativeFieldInfoPtr_entities), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("BattleSaveSystem/<>c__DisplayClass20_1")]
  public sealed class __c__DisplayClass20_1 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_arrayIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass20_0_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__CreateCards_b__0_Internal_Void_Card_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass20_1()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass20_1>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.__c__DisplayClass20_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68337, XrefRangeEnd = 68343, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _CreateCards_b__0(Card a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.__c__DisplayClass20_1.NativeMethodInfoPtr__CreateCards_b__0_Internal_Void_Card_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static __c__DisplayClass20_1()
    {
      Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass20_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, "<>c__DisplayClass20_1");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass20_1>.NativeClassPtr);
      BattleSaveSystem.__c__DisplayClass20_1.NativeFieldInfoPtr_arrayIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass20_1>.NativeClassPtr, nameof (arrayIndex));
      BattleSaveSystem.__c__DisplayClass20_1.NativeFieldInfoPtr_field_Public___c__DisplayClass20_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass20_1>.NativeClassPtr, "CS$<>8__locals1");
      BattleSaveSystem.__c__DisplayClass20_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass20_1>.NativeClassPtr, 100668927);
      BattleSaveSystem.__c__DisplayClass20_1.NativeMethodInfoPtr__CreateCards_b__0_Internal_Void_Card_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass20_1>.NativeClassPtr, 100668928);
    }

    public __c__DisplayClass20_1(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int arrayIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.__c__DisplayClass20_1.NativeFieldInfoPtr_arrayIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.__c__DisplayClass20_1.NativeFieldInfoPtr_arrayIndex)) = value;
      }
    }

    public unsafe BattleSaveSystem.__c__DisplayClass20_0 field_Public___c__DisplayClass20_0_0
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.__c__DisplayClass20_1.NativeFieldInfoPtr_field_Public___c__DisplayClass20_0_0));
        return pointer == System.IntPtr.Zero ? (BattleSaveSystem.__c__DisplayClass20_0) null : new BattleSaveSystem.__c__DisplayClass20_0(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.__c__DisplayClass20_1.NativeFieldInfoPtr_field_Public___c__DisplayClass20_0_0), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("BattleSaveSystem/<CreateCards>d__20")]
  public sealed class _CreateCards_d__20 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr_container;
    private static readonly System.IntPtr NativeFieldInfoPtr_entitySaveData;
    private static readonly System.IntPtr NativeFieldInfoPtr___8__1;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _CreateCards_d__20(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleSaveSystem._CreateCards_d__20>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._CreateCards_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._CreateCards_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68343, XrefRangeEnd = 68386, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._CreateCards_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._CreateCards_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68386, XrefRangeEnd = 68392, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._CreateCards_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._CreateCards_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _CreateCards_d__20()
    {
      Il2CppClassPointerStore<BattleSaveSystem._CreateCards_d__20>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, "<CreateCards>d__20");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleSaveSystem._CreateCards_d__20>.NativeClassPtr);
      BattleSaveSystem._CreateCards_d__20.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._CreateCards_d__20>.NativeClassPtr, "<>1__state");
      BattleSaveSystem._CreateCards_d__20.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._CreateCards_d__20>.NativeClassPtr, "<>2__current");
      BattleSaveSystem._CreateCards_d__20.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._CreateCards_d__20>.NativeClassPtr, nameof (container));
      BattleSaveSystem._CreateCards_d__20.NativeFieldInfoPtr_entitySaveData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._CreateCards_d__20>.NativeClassPtr, nameof (entitySaveData));
      BattleSaveSystem._CreateCards_d__20.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._CreateCards_d__20>.NativeClassPtr, "<>8__1");
      BattleSaveSystem._CreateCards_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._CreateCards_d__20>.NativeClassPtr, 100668929);
      BattleSaveSystem._CreateCards_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._CreateCards_d__20>.NativeClassPtr, 100668930);
      BattleSaveSystem._CreateCards_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._CreateCards_d__20>.NativeClassPtr, 100668931);
      BattleSaveSystem._CreateCards_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._CreateCards_d__20>.NativeClassPtr, 100668932);
      BattleSaveSystem._CreateCards_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._CreateCards_d__20>.NativeClassPtr, 100668933);
      BattleSaveSystem._CreateCards_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._CreateCards_d__20>.NativeClassPtr, 100668934);
    }

    public _CreateCards_d__20(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCards_d__20.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCards_d__20.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCards_d__20.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCards_d__20.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CardContainer container
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCards_d__20.NativeFieldInfoPtr_container));
        return pointer == System.IntPtr.Zero ? (CardContainer) null : new CardContainer(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCards_d__20.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe IReadOnlyList<BattleEntityData> entitySaveData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCards_d__20.NativeFieldInfoPtr_entitySaveData));
        return pointer == System.IntPtr.Zero ? (IReadOnlyList<BattleEntityData>) null : new IReadOnlyList<BattleEntityData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCards_d__20.NativeFieldInfoPtr_entitySaveData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BattleSaveSystem.__c__DisplayClass20_0 __8__1
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCards_d__20.NativeFieldInfoPtr___8__1));
        return pointer == System.IntPtr.Zero ? (BattleSaveSystem.__c__DisplayClass20_0) null : new BattleSaveSystem.__c__DisplayClass20_0(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCards_d__20.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("BattleSaveSystem/<CreateCard>d__21")]
  public sealed class _CreateCard_d__21 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr_entityData;
    private static readonly System.IntPtr NativeFieldInfoPtr_cardController;
    private static readonly System.IntPtr NativeFieldInfoPtr_owner;
    private static readonly System.IntPtr NativeFieldInfoPtr_onComplete;
    private static readonly System.IntPtr NativeFieldInfoPtr__entity_5__2;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _CreateCard_d__21(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleSaveSystem._CreateCard_d__21>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._CreateCard_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._CreateCard_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68392, XrefRangeEnd = 68457, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._CreateCard_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._CreateCard_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68457, XrefRangeEnd = 68463, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._CreateCard_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._CreateCard_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _CreateCard_d__21()
    {
      Il2CppClassPointerStore<BattleSaveSystem._CreateCard_d__21>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, "<CreateCard>d__21");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleSaveSystem._CreateCard_d__21>.NativeClassPtr);
      BattleSaveSystem._CreateCard_d__21.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._CreateCard_d__21>.NativeClassPtr, "<>1__state");
      BattleSaveSystem._CreateCard_d__21.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._CreateCard_d__21>.NativeClassPtr, "<>2__current");
      BattleSaveSystem._CreateCard_d__21.NativeFieldInfoPtr_entityData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._CreateCard_d__21>.NativeClassPtr, nameof (entityData));
      BattleSaveSystem._CreateCard_d__21.NativeFieldInfoPtr_cardController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._CreateCard_d__21>.NativeClassPtr, nameof (cardController));
      BattleSaveSystem._CreateCard_d__21.NativeFieldInfoPtr_owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._CreateCard_d__21>.NativeClassPtr, nameof (owner));
      BattleSaveSystem._CreateCard_d__21.NativeFieldInfoPtr_onComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._CreateCard_d__21>.NativeClassPtr, nameof (onComplete));
      BattleSaveSystem._CreateCard_d__21.NativeFieldInfoPtr__entity_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._CreateCard_d__21>.NativeClassPtr, "<entity>5__2");
      BattleSaveSystem._CreateCard_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._CreateCard_d__21>.NativeClassPtr, 100668935);
      BattleSaveSystem._CreateCard_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._CreateCard_d__21>.NativeClassPtr, 100668936);
      BattleSaveSystem._CreateCard_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._CreateCard_d__21>.NativeClassPtr, 100668937);
      BattleSaveSystem._CreateCard_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._CreateCard_d__21>.NativeClassPtr, 100668938);
      BattleSaveSystem._CreateCard_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._CreateCard_d__21>.NativeClassPtr, 100668939);
      BattleSaveSystem._CreateCard_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._CreateCard_d__21>.NativeClassPtr, 100668940);
    }

    public _CreateCard_d__21(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCard_d__21.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCard_d__21.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCard_d__21.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCard_d__21.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BattleEntityData entityData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCard_d__21.NativeFieldInfoPtr_entityData));
        return pointer == System.IntPtr.Zero ? (BattleEntityData) null : new BattleEntityData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCard_d__21.NativeFieldInfoPtr_entityData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CardController cardController
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCard_d__21.NativeFieldInfoPtr_cardController));
        return pointer == System.IntPtr.Zero ? (CardController) null : new CardController(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCard_d__21.NativeFieldInfoPtr_cardController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Character owner
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCard_d__21.NativeFieldInfoPtr_owner));
        return pointer == System.IntPtr.Zero ? (Character) null : new Character(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCard_d__21.NativeFieldInfoPtr_owner), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UnityAction<Card> onComplete
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCard_d__21.NativeFieldInfoPtr_onComplete));
        return pointer == System.IntPtr.Zero ? (UnityAction<Card>) null : new UnityAction<Card>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCard_d__21.NativeFieldInfoPtr_onComplete), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Entity _entity_5__2
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCard_d__21.NativeFieldInfoPtr__entity_5__2));
        return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCard_d__21.NativeFieldInfoPtr__entity_5__2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("BattleSaveSystem/<UpdateCard>d__22")]
  public sealed class _UpdateCard_d__22 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr_card;
    private static readonly System.IntPtr NativeFieldInfoPtr_customDatas;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _UpdateCard_d__22(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleSaveSystem._UpdateCard_d__22>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._UpdateCard_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._UpdateCard_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68463, XrefRangeEnd = 68493, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._UpdateCard_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._UpdateCard_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68493, XrefRangeEnd = 68499, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._UpdateCard_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._UpdateCard_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _UpdateCard_d__22()
    {
      Il2CppClassPointerStore<BattleSaveSystem._UpdateCard_d__22>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, "<UpdateCard>d__22");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleSaveSystem._UpdateCard_d__22>.NativeClassPtr);
      BattleSaveSystem._UpdateCard_d__22.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._UpdateCard_d__22>.NativeClassPtr, "<>1__state");
      BattleSaveSystem._UpdateCard_d__22.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._UpdateCard_d__22>.NativeClassPtr, "<>2__current");
      BattleSaveSystem._UpdateCard_d__22.NativeFieldInfoPtr_card = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._UpdateCard_d__22>.NativeClassPtr, nameof (card));
      BattleSaveSystem._UpdateCard_d__22.NativeFieldInfoPtr_customDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._UpdateCard_d__22>.NativeClassPtr, nameof (customDatas));
      BattleSaveSystem._UpdateCard_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._UpdateCard_d__22>.NativeClassPtr, 100668941);
      BattleSaveSystem._UpdateCard_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._UpdateCard_d__22>.NativeClassPtr, 100668942);
      BattleSaveSystem._UpdateCard_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._UpdateCard_d__22>.NativeClassPtr, 100668943);
      BattleSaveSystem._UpdateCard_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._UpdateCard_d__22>.NativeClassPtr, 100668944);
      BattleSaveSystem._UpdateCard_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._UpdateCard_d__22>.NativeClassPtr, 100668945);
      BattleSaveSystem._UpdateCard_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._UpdateCard_d__22>.NativeClassPtr, 100668946);
    }

    public _UpdateCard_d__22(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._UpdateCard_d__22.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._UpdateCard_d__22.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._UpdateCard_d__22.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._UpdateCard_d__22.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Entity card
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._UpdateCard_d__22.NativeFieldInfoPtr_card));
        return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._UpdateCard_d__22.NativeFieldInfoPtr_card), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe IReadOnlyDictionary<string, Il2CppSystem.Object> customDatas
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._UpdateCard_d__22.NativeFieldInfoPtr_customDatas));
        return pointer == System.IntPtr.Zero ? (IReadOnlyDictionary<string, Il2CppSystem.Object>) null : new IReadOnlyDictionary<string, Il2CppSystem.Object>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._UpdateCard_d__22.NativeFieldInfoPtr_customDatas), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
