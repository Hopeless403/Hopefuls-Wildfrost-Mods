// Decompiled with JetBrains decompiler
// Type: SfxSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using FMOD;
using FMOD.Studio;
using FMODUnity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class SfxSystem : GameSystem
{
  private static readonly System.IntPtr NativeFieldInfoPtr_instance;
  private static readonly System.IntPtr NativeFieldInfoPtr_DRAG_THRESHOLD;
  private static readonly System.IntPtr NativeFieldInfoPtr_cooldownTimers;
  private static readonly System.IntPtr NativeFieldInfoPtr_cooldowns;
  private static readonly System.IntPtr NativeFieldInfoPtr_pathRevealPitch;
  private static readonly System.IntPtr NativeFieldInfoPtr_test;
  private static readonly System.IntPtr NativeFieldInfoPtr_running;
  private static readonly System.IntPtr NativeFieldInfoPtr_dragging;
  private static readonly System.IntPtr NativeFieldInfoPtr_draggingItem;
  private static readonly System.IntPtr NativeFieldInfoPtr_dragTrigger;
  private static readonly System.IntPtr NativeFieldInfoPtr_dragFrom;
  private static readonly System.IntPtr NativeFieldInfoPtr_itemAim;
  private static readonly System.IntPtr NativeFieldInfoPtr_revealActionsInQueue;
  private static readonly System.IntPtr NativeFieldInfoPtr_flipMulti;
  private static readonly System.IntPtr NativeFieldInfoPtr_transitionSnow;
  private static readonly System.IntPtr NativeFieldInfoPtr_goldCounter;
  private static readonly System.IntPtr NativeFieldInfoPtr_muncherFeed;
  private static readonly System.IntPtr NativeFieldInfoPtr_drawMulti;
  private static readonly System.IntPtr NativeFieldInfoPtr_townProgressionLoop;
  private static readonly System.IntPtr NativeFieldInfoPtr_goldDisplay;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OneShot_Public_Static_EventInstance_EventReference_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OneShot_Public_Static_EventInstance_GUID_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OneShot_Public_Static_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OneShotCheckCooldown_Private_Static_Void_String_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OneShot_Private_Static_Void_String_Il2CppReferenceArray_1_Param_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Play_Private_EventInstance_String_Il2CppReferenceArray_1_Param_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Play_Private_EventInstance_EventReference_Il2CppReferenceArray_1_Param_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetParam_Public_Static_Void_EventInstance_String_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Stop_Public_Static_Void_EventInstance_STOP_MODE_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsRunning_Private_Static_Boolean_EventInstance_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetCooldown_Private_Static_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckCooldown_Private_Static_Boolean_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetGlobalParam_Public_Static_Void_String_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Loop_Public_Static_EventInstance_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Loop_Public_Static_EventInstance_EventReference_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EndLoop_Public_Static_Void_Nullable_1_EventInstance_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHitPower_Private_Static_Int32_Hit_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntityHit_Private_Static_Void_Hit_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntityHover_Private_Static_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntityKilled_Private_Static_Void_Entity_DeathType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntitySelect_Private_Static_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntityDrag_Private_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntityRelease_Private_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntityPlace_Private_Static_Void_Entity_Il2CppReferenceArray_1_CardContainer_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntityFlipUp_Private_Static_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntityFlipDown_Private_Static_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntityTrigger_Private_Static_Void_byref_Trigger_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntityMove_Private_Static_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Focus_Private_Static_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntityEnterPocket_Private_Static_Void_Entity_CardPocket_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntityEnterBackpack_Private_Static_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_NoomlinShow_Private_Static_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_NoomlinUsed_Private_Static_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BattlePhaseStart_Private_Static_Void_Phase_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StatusApplied_Private_Static_Void_StatusEffectApply_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CardDraw_Private_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CardDrawEnd_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StatusIconChanged_Private_Static_Void_StatusIcon_Stat_Stat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DropGold_Private_Static_Void_Int32_String_Character_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GoldFlyToBag_Private_Static_Void_Int32_Character_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CollectGold_Private_Static_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DeckpackOpen_Private_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DeckpackClose_Private_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MapPathReveal_Private_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MapPathRevealRoutine_Private_IEnumerator_EventInstance_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MapNodeReveal_Private_Static_Void_MapNode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MapNodeHover_Private_Static_Void_MapNode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MapNodeSelect_Private_Static_Void_MapNode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ActionQueued_Private_Void_PlayAction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ActionPerform_Private_Void_PlayAction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ActionFinished_Private_Void_PlayAction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TransitionStart_Private_Void_TransitionType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TransitionEnd_Private_Void_TransitionType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GoldCounterStart_Private_Void_GoldDisplay_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GoldCounterStop_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MuncherDrag_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MuncherDragEnd_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MuncherFeed_Private_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BombardShoot_Private_Static_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BombardRocketFall_Private_Static_Void_BombardRocket_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BombardRocketExplode_Private_Static_Void_BombardRocket_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ButtonHover_Private_Static_Void_ButtonType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ButtonPress_Private_Static_Void_ButtonType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProgressStart_Private_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProgressUpdate_Private_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProgressStop_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProgressDing_Private_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProgressBlip_Private_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TownUnlockPopUp_Private_Static_Void_UnlockData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpgradeHover_Private_Static_Void_UpgradeDisplay_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpgradePickup_Private_Static_Void_UpgradeDisplay_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpgradeDrop_Private_Static_Void_UpgradeDisplay_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpgradeAssign_Private_Static_Void_Entity_CardUpgradeData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ShopItemHover_Private_Static_Void_ShopItem_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AbilityTargetAdd_Private_Static_Void_CardContainer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntityPing_Private_Static_Void_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StopAll_Private_Void_STOP_MODE_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71795, XrefRangeEnd = 72208, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72208, XrefRangeEnd = 72579, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72579, XrefRangeEnd = 72637, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(52)]
  [CachedScanResults(RefRangeStart = 72645, RefRangeEnd = 72697, XrefRangeStart = 72637, XrefRangeEnd = 72645, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe EventInstance OneShot(EventReference eventRef)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &eventRef
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_OneShot_Public_Static_EventInstance_EventReference_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(EventInstance*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 72702, RefRangeEnd = 72703, XrefRangeStart = 72697, XrefRangeEnd = 72702, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe EventInstance OneShot(GUID guid)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &guid
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_OneShot_Public_Static_EventInstance_GUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(EventInstance*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(56)]
  [CachedScanResults(RefRangeStart = 72707, RefRangeEnd = 72763, XrefRangeStart = 72703, XrefRangeEnd = 72707, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OneShot(string eventName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(eventName)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_OneShot_Public_Static_Void_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 72785, RefRangeEnd = 72792, XrefRangeStart = 72763, XrefRangeEnd = 72785, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OneShotCheckCooldown(string eventName, bool resetCooldown = true)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(eventName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &resetCooldown;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_OneShotCheckCooldown_Private_Static_Void_String_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 72800, RefRangeEnd = 72802, XrefRangeStart = 72792, XrefRangeEnd = 72800, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OneShot(
    string eventName,
    [Optional] Il2CppReferenceArray<SfxSystem.Param> parameters)
  {
    if (parameters == null)
      parameters = (Il2CppReferenceArray<SfxSystem.Param>) new Il2CppStructArray<SfxSystem.Param>(0L);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(eventName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parameters);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_OneShot_Private_Static_Void_String_Il2CppReferenceArray_1_Param_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(9)]
  [CachedScanResults(RefRangeStart = 72816, RefRangeEnd = 72825, XrefRangeStart = 72802, XrefRangeEnd = 72816, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe EventInstance Play(
    string eventPath,
    [Optional] Il2CppReferenceArray<SfxSystem.Param> parameters)
  {
    if (parameters == null)
      parameters = (Il2CppReferenceArray<SfxSystem.Param>) new Il2CppStructArray<SfxSystem.Param>(0L);
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(eventPath);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parameters);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_Play_Private_EventInstance_String_Il2CppReferenceArray_1_Param_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(EventInstance*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 72839, RefRangeEnd = 72840, XrefRangeStart = 72825, XrefRangeEnd = 72839, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe EventInstance Play(
    EventReference eventRef,
    [Optional] Il2CppReferenceArray<SfxSystem.Param> parameters)
  {
    if (parameters == null)
      parameters = (Il2CppReferenceArray<SfxSystem.Param>) new Il2CppStructArray<SfxSystem.Param>(0L);
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &eventRef;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parameters);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_Play_Private_EventInstance_EventReference_Il2CppReferenceArray_1_Param_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(EventInstance*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(11)]
  [CachedScanResults(RefRangeStart = 72846, RefRangeEnd = 72857, XrefRangeStart = 72840, XrefRangeEnd = 72846, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetParam(EventInstance eventInstance, string param, float value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &eventInstance;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(param);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_SetParam_Public_Static_Void_EventInstance_String_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(12)]
  [CachedScanResults(RefRangeStart = 72864, RefRangeEnd = 72876, XrefRangeStart = 72857, XrefRangeEnd = 72864, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Stop(EventInstance eventInstance, FMOD.Studio.STOP_MODE stopMode = FMOD.Studio.STOP_MODE.ALLOWFADEOUT)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &eventInstance;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &stopMode;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_Stop_Public_Static_Void_EventInstance_STOP_MODE_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsRunning(EventInstance eventInstance)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &eventInstance
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_IsRunning_Private_Static_Boolean_EventInstance_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 72889, RefRangeEnd = 72891, XrefRangeStart = 72876, XrefRangeEnd = 72889, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetCooldown(string eventName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(eventName)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_SetCooldown_Private_Static_Void_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72891, XrefRangeEnd = 72899, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool CheckCooldown(string eventName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(eventName)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_CheckCooldown_Private_Static_Boolean_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 72904, RefRangeEnd = 72905, XrefRangeStart = 72899, XrefRangeEnd = 72904, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetGlobalParam(string paramName, float value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(paramName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_SetGlobalParam_Public_Static_Void_String_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72905, XrefRangeEnd = 72914, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe EventInstance Loop(string eventName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(eventName)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_Loop_Public_Static_EventInstance_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(EventInstance*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 72922, RefRangeEnd = 72924, XrefRangeStart = 72914, XrefRangeEnd = 72922, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe EventInstance Loop(EventReference eventRef)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &eventRef
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_Loop_Public_Static_EventInstance_EventReference_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(EventInstance*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 72934, RefRangeEnd = 72936, XrefRangeStart = 72924, XrefRangeEnd = 72934, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void EndLoop(Il2CppSystem.Nullable<EventInstance> inst)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) inst))
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_EndLoop_Public_Static_Void_Nullable_1_EventInstance_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public static unsafe int GetHitPower(Hit hit)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hit)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_GetHitPower_Private_Static_Int32_Hit_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72936, XrefRangeEnd = 72964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void EntityHit(Hit hit)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hit)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_EntityHit_Private_Static_Void_Hit_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72964, XrefRangeEnd = 72970, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void EntityHover(Entity entity)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_EntityHover_Private_Static_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72970, XrefRangeEnd = 72988, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void EntityKilled(Entity entity, DeathType deathType)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &deathType;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_EntityKilled_Private_Static_Void_Entity_DeathType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72988, XrefRangeEnd = 72997, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void EntitySelect(Entity entity)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_EntitySelect_Private_Static_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72997, XrefRangeEnd = 73010, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntityDrag(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_EntityDrag_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73010, XrefRangeEnd = 73034, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntityRelease(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_EntityRelease_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73034, XrefRangeEnd = 73043, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void EntityPlace(
    Entity entity,
    Il2CppReferenceArray<CardContainer> containers,
    bool freeMove)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) containers);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &freeMove;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_EntityPlace_Private_Static_Void_Entity_Il2CppReferenceArray_1_CardContainer_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73043, XrefRangeEnd = 73049, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void EntityFlipUp(Entity entity)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_EntityFlipUp_Private_Static_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73049, XrefRangeEnd = 73055, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void EntityFlipDown(Entity entity)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_EntityFlipDown_Private_Static_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73055, XrefRangeEnd = 73065, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void EntityTrigger(ref Trigger trigger)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
    System.IntPtr* numPtr2 = numPtr1;
    System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) trigger);
    System.IntPtr* numPtr3 = &ptr;
    *numPtr2 = (System.IntPtr) numPtr3;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_EntityTrigger_Private_Static_Void_byref_Trigger_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    ref Trigger local = ref trigger;
    System.IntPtr pointer = ptr;
    Trigger trigger1 = pointer == System.IntPtr.Zero ? (Trigger) null : new Trigger(pointer);
    local = trigger1;
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73065, XrefRangeEnd = 73081, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void EntityMove(Entity entity)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_EntityMove_Private_Static_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73081, XrefRangeEnd = 73090, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Focus(Entity entity)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_Focus_Private_Static_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73090, XrefRangeEnd = 73096, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void EntityEnterPocket(Entity entity, CardPocket pocket)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pocket);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_EntityEnterPocket_Private_Static_Void_Entity_CardPocket_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73096, XrefRangeEnd = 73102, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void EntityEnterBackpack(Entity entity)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_EntityEnterBackpack_Private_Static_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73102, XrefRangeEnd = 73108, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void NoomlinShow(Entity entity)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_NoomlinShow_Private_Static_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73108, XrefRangeEnd = 73114, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void NoomlinUsed(Entity entity)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_NoomlinUsed_Private_Static_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73114, XrefRangeEnd = 73127, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void BattlePhaseStart(Battle.Phase phase)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &phase
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_BattlePhaseStart_Private_Static_Void_Phase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73127, XrefRangeEnd = 73178, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void StatusApplied(StatusEffectApply apply)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) apply)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_StatusApplied_Private_Static_Void_StatusEffectApply_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73178, XrefRangeEnd = 73192, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CardDraw(int amount)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &amount
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_CardDraw_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73192, XrefRangeEnd = 73202, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CardDrawEnd()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_CardDrawEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73202, XrefRangeEnd = 73224, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void StatusIconChanged(StatusIcon icon, Stat previousValue, Stat newValue)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) icon);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &previousValue;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &newValue;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_StatusIconChanged_Private_Static_Void_StatusIcon_Stat_Stat_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73224, XrefRangeEnd = 73250, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DropGold(int amount, string source, Character owner, Vector3 position)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &amount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(source);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) owner);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_DropGold_Private_Static_Void_Int32_String_Character_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73250, XrefRangeEnd = 73259, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GoldFlyToBag(int amount, Character owner, Vector3 position)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &amount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) owner);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_GoldFlyToBag_Private_Static_Void_Int32_Character_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73259, XrefRangeEnd = 73268, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CollectGold(int amount)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &amount
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_CollectGold_Private_Static_Void_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73268, XrefRangeEnd = 73277, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DeckpackOpen()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_DeckpackOpen_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73277, XrefRangeEnd = 73286, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DeckpackClose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_DeckpackClose_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73286, XrefRangeEnd = 73305, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void MapPathReveal(float totalTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &totalTime
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_MapPathReveal_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73305, XrefRangeEnd = 73310, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator MapPathRevealRoutine(EventInstance mapPathReveal, float totalTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &mapPathReveal;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &totalTime;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_MapPathRevealRoutine_Private_IEnumerator_EventInstance_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73310, XrefRangeEnd = 73319, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void MapNodeReveal(MapNode node)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_MapNodeReveal_Private_Static_Void_MapNode_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73319, XrefRangeEnd = 73328, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void MapNodeHover(MapNode node)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_MapNodeHover_Private_Static_Void_MapNode_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73328, XrefRangeEnd = 73341, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void MapNodeSelect(MapNode node)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_MapNodeSelect_Private_Static_Void_MapNode_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73341, XrefRangeEnd = 73343, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ActionQueued(PlayAction action)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_ActionQueued_Private_Void_PlayAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73343, XrefRangeEnd = 73356, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ActionPerform(PlayAction action)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_ActionPerform_Private_Void_PlayAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73356, XrefRangeEnd = 73364, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ActionFinished(PlayAction action)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_ActionFinished_Private_Void_PlayAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73364, XrefRangeEnd = 73372, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void TransitionStart(TransitionType transition)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transition)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_TransitionStart_Private_Void_TransitionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73372, XrefRangeEnd = 73384, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void TransitionEnd(TransitionType transition)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transition)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_TransitionEnd_Private_Void_TransitionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73384, XrefRangeEnd = 73405, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void GoldCounterStart(GoldDisplay display, float addAmount)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) display);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &addAmount;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_GoldCounterStart_Private_Void_GoldDisplay_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73405, XrefRangeEnd = 73413, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void GoldCounterStop()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_GoldCounterStop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73413, XrefRangeEnd = 73419, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void MuncherDrag()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_MuncherDrag_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73419, XrefRangeEnd = 73427, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void MuncherDragEnd()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_MuncherDragEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73427, XrefRangeEnd = 73438, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void MuncherFeed(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_MuncherFeed_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73438, XrefRangeEnd = 73447, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void BombardShoot(Entity entity)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_BombardShoot_Private_Static_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73447, XrefRangeEnd = 73456, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void BombardRocketFall(BombardRocket rocket)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rocket)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_BombardRocketFall_Private_Static_Void_BombardRocket_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73456, XrefRangeEnd = 73465, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void BombardRocketExplode(BombardRocket rocket)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rocket)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_BombardRocketExplode_Private_Static_Void_BombardRocket_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73465, XrefRangeEnd = 73475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ButtonHover(ButtonType buttonType)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &buttonType
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_ButtonHover_Private_Static_Void_ButtonType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73475, XrefRangeEnd = 73489, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ButtonPress(ButtonType buttonType)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &buttonType
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_ButtonPress_Private_Static_Void_ButtonType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73489, XrefRangeEnd = 73506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ProgressStart(float fill)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &fill
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_ProgressStart_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73506, XrefRangeEnd = 73516, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ProgressUpdate(float fill)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &fill
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_ProgressUpdate_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73516, XrefRangeEnd = 73520, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ProgressStop()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_ProgressStop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73520, XrefRangeEnd = 73529, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ProgressDing()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_ProgressDing_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73529, XrefRangeEnd = 73538, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ProgressBlip()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_ProgressBlip_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73538, XrefRangeEnd = 73547, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void TownUnlockPopUp(UnlockData unlockData)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) unlockData)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_TownUnlockPopUp_Private_Static_Void_UnlockData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73547, XrefRangeEnd = 73558, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void UpgradeHover(UpgradeDisplay upgradeDisplay)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) upgradeDisplay)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_UpgradeHover_Private_Static_Void_UpgradeDisplay_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73558, XrefRangeEnd = 73682, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void UpgradePickup(UpgradeDisplay upgradeDisplay)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) upgradeDisplay)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_UpgradePickup_Private_Static_Void_UpgradeDisplay_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73682, XrefRangeEnd = 73693, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void UpgradeDrop(UpgradeDisplay upgradeDisplay)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) upgradeDisplay)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_UpgradeDrop_Private_Static_Void_UpgradeDisplay_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73693, XrefRangeEnd = 73699, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void UpgradeAssign(Entity entity, CardUpgradeData upgradeData)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) upgradeData);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_UpgradeAssign_Private_Static_Void_Entity_CardUpgradeData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73699, XrefRangeEnd = 73711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ShopItemHover(ShopItem shopItem)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) shopItem)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_ShopItemHover_Private_Static_Void_ShopItem_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73711, XrefRangeEnd = 73720, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void AbilityTargetAdd(CardContainer container)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_AbilityTargetAdd_Private_Static_Void_CardContainer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73720, XrefRangeEnd = 73729, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void EntityPing(GameObject obj)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_EntityPing_Private_Static_Void_GameObject_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 73752, RefRangeEnd = 73753, XrefRangeStart = 73729, XrefRangeEnd = 73752, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StopAll(FMOD.Studio.STOP_MODE stopMode = FMOD.Studio.STOP_MODE.IMMEDIATE)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &stopMode
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr_StopAll_Private_Void_STOP_MODE_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 21168, RefRangeEnd = 21171, XrefRangeStart = 21168, XrefRangeEnd = 21171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SfxSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SfxSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  public static void OneShot(string eventName, params SfxSystem.Param[] parameters)
  {
    SfxSystem.OneShot(eventName, new Il2CppReferenceArray<SfxSystem.Param>(parameters));
  }

  public EventInstance Play(string eventPath, params SfxSystem.Param[] parameters)
  {
    return this.Play(eventPath, new Il2CppReferenceArray<SfxSystem.Param>(parameters));
  }

  public EventInstance Play(EventReference eventRef, params SfxSystem.Param[] parameters)
  {
    return this.Play(eventRef, new Il2CppReferenceArray<SfxSystem.Param>(parameters));
  }

  static SfxSystem()
  {
    Il2CppClassPointerStore<SfxSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (SfxSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr);
    SfxSystem.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, nameof (instance));
    SfxSystem.NativeFieldInfoPtr_DRAG_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, nameof (DRAG_THRESHOLD));
    SfxSystem.NativeFieldInfoPtr_cooldownTimers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, nameof (cooldownTimers));
    SfxSystem.NativeFieldInfoPtr_cooldowns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, nameof (cooldowns));
    SfxSystem.NativeFieldInfoPtr_pathRevealPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, nameof (pathRevealPitch));
    SfxSystem.NativeFieldInfoPtr_test = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, nameof (test));
    SfxSystem.NativeFieldInfoPtr_running = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, nameof (running));
    SfxSystem.NativeFieldInfoPtr_dragging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, nameof (dragging));
    SfxSystem.NativeFieldInfoPtr_draggingItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, nameof (draggingItem));
    SfxSystem.NativeFieldInfoPtr_dragTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, nameof (dragTrigger));
    SfxSystem.NativeFieldInfoPtr_dragFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, nameof (dragFrom));
    SfxSystem.NativeFieldInfoPtr_itemAim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, nameof (itemAim));
    SfxSystem.NativeFieldInfoPtr_revealActionsInQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, nameof (revealActionsInQueue));
    SfxSystem.NativeFieldInfoPtr_flipMulti = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, nameof (flipMulti));
    SfxSystem.NativeFieldInfoPtr_transitionSnow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, nameof (transitionSnow));
    SfxSystem.NativeFieldInfoPtr_goldCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, nameof (goldCounter));
    SfxSystem.NativeFieldInfoPtr_muncherFeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, nameof (muncherFeed));
    SfxSystem.NativeFieldInfoPtr_drawMulti = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, nameof (drawMulti));
    SfxSystem.NativeFieldInfoPtr_townProgressionLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, nameof (townProgressionLoop));
    SfxSystem.NativeFieldInfoPtr_goldDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, nameof (goldDisplay));
    SfxSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669190);
    SfxSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669191);
    SfxSystem.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669192);
    SfxSystem.NativeMethodInfoPtr_OneShot_Public_Static_EventInstance_EventReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669193);
    SfxSystem.NativeMethodInfoPtr_OneShot_Public_Static_EventInstance_GUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669194);
    SfxSystem.NativeMethodInfoPtr_OneShot_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669195);
    SfxSystem.NativeMethodInfoPtr_OneShotCheckCooldown_Private_Static_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669196);
    SfxSystem.NativeMethodInfoPtr_OneShot_Private_Static_Void_String_Il2CppReferenceArray_1_Param_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669197);
    SfxSystem.NativeMethodInfoPtr_Play_Private_EventInstance_String_Il2CppReferenceArray_1_Param_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669198);
    SfxSystem.NativeMethodInfoPtr_Play_Private_EventInstance_EventReference_Il2CppReferenceArray_1_Param_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669199);
    SfxSystem.NativeMethodInfoPtr_SetParam_Public_Static_Void_EventInstance_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669200);
    SfxSystem.NativeMethodInfoPtr_Stop_Public_Static_Void_EventInstance_STOP_MODE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669201);
    SfxSystem.NativeMethodInfoPtr_IsRunning_Private_Static_Boolean_EventInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669202);
    SfxSystem.NativeMethodInfoPtr_SetCooldown_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669203);
    SfxSystem.NativeMethodInfoPtr_CheckCooldown_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669204);
    SfxSystem.NativeMethodInfoPtr_SetGlobalParam_Public_Static_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669205);
    SfxSystem.NativeMethodInfoPtr_Loop_Public_Static_EventInstance_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669206);
    SfxSystem.NativeMethodInfoPtr_Loop_Public_Static_EventInstance_EventReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669207);
    SfxSystem.NativeMethodInfoPtr_EndLoop_Public_Static_Void_Nullable_1_EventInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669208);
    SfxSystem.NativeMethodInfoPtr_GetHitPower_Private_Static_Int32_Hit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669209);
    SfxSystem.NativeMethodInfoPtr_EntityHit_Private_Static_Void_Hit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669210);
    SfxSystem.NativeMethodInfoPtr_EntityHover_Private_Static_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669211);
    SfxSystem.NativeMethodInfoPtr_EntityKilled_Private_Static_Void_Entity_DeathType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669212);
    SfxSystem.NativeMethodInfoPtr_EntitySelect_Private_Static_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669213);
    SfxSystem.NativeMethodInfoPtr_EntityDrag_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669214);
    SfxSystem.NativeMethodInfoPtr_EntityRelease_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669215);
    SfxSystem.NativeMethodInfoPtr_EntityPlace_Private_Static_Void_Entity_Il2CppReferenceArray_1_CardContainer_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669216);
    SfxSystem.NativeMethodInfoPtr_EntityFlipUp_Private_Static_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669217);
    SfxSystem.NativeMethodInfoPtr_EntityFlipDown_Private_Static_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669218);
    SfxSystem.NativeMethodInfoPtr_EntityTrigger_Private_Static_Void_byref_Trigger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669219);
    SfxSystem.NativeMethodInfoPtr_EntityMove_Private_Static_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669220);
    SfxSystem.NativeMethodInfoPtr_Focus_Private_Static_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669221);
    SfxSystem.NativeMethodInfoPtr_EntityEnterPocket_Private_Static_Void_Entity_CardPocket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669222);
    SfxSystem.NativeMethodInfoPtr_EntityEnterBackpack_Private_Static_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669223);
    SfxSystem.NativeMethodInfoPtr_NoomlinShow_Private_Static_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669224);
    SfxSystem.NativeMethodInfoPtr_NoomlinUsed_Private_Static_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669225);
    SfxSystem.NativeMethodInfoPtr_BattlePhaseStart_Private_Static_Void_Phase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669226);
    SfxSystem.NativeMethodInfoPtr_StatusApplied_Private_Static_Void_StatusEffectApply_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669227);
    SfxSystem.NativeMethodInfoPtr_CardDraw_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669228);
    SfxSystem.NativeMethodInfoPtr_CardDrawEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669229);
    SfxSystem.NativeMethodInfoPtr_StatusIconChanged_Private_Static_Void_StatusIcon_Stat_Stat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669230);
    SfxSystem.NativeMethodInfoPtr_DropGold_Private_Static_Void_Int32_String_Character_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669231);
    SfxSystem.NativeMethodInfoPtr_GoldFlyToBag_Private_Static_Void_Int32_Character_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669232);
    SfxSystem.NativeMethodInfoPtr_CollectGold_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669233);
    SfxSystem.NativeMethodInfoPtr_DeckpackOpen_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669234);
    SfxSystem.NativeMethodInfoPtr_DeckpackClose_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669235);
    SfxSystem.NativeMethodInfoPtr_MapPathReveal_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669236);
    SfxSystem.NativeMethodInfoPtr_MapPathRevealRoutine_Private_IEnumerator_EventInstance_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669237);
    SfxSystem.NativeMethodInfoPtr_MapNodeReveal_Private_Static_Void_MapNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669238);
    SfxSystem.NativeMethodInfoPtr_MapNodeHover_Private_Static_Void_MapNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669239);
    SfxSystem.NativeMethodInfoPtr_MapNodeSelect_Private_Static_Void_MapNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669240);
    SfxSystem.NativeMethodInfoPtr_ActionQueued_Private_Void_PlayAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669241);
    SfxSystem.NativeMethodInfoPtr_ActionPerform_Private_Void_PlayAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669242);
    SfxSystem.NativeMethodInfoPtr_ActionFinished_Private_Void_PlayAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669243);
    SfxSystem.NativeMethodInfoPtr_TransitionStart_Private_Void_TransitionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669244);
    SfxSystem.NativeMethodInfoPtr_TransitionEnd_Private_Void_TransitionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669245);
    SfxSystem.NativeMethodInfoPtr_GoldCounterStart_Private_Void_GoldDisplay_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669246);
    SfxSystem.NativeMethodInfoPtr_GoldCounterStop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669247);
    SfxSystem.NativeMethodInfoPtr_MuncherDrag_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669248);
    SfxSystem.NativeMethodInfoPtr_MuncherDragEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669249);
    SfxSystem.NativeMethodInfoPtr_MuncherFeed_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669250);
    SfxSystem.NativeMethodInfoPtr_BombardShoot_Private_Static_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669251);
    SfxSystem.NativeMethodInfoPtr_BombardRocketFall_Private_Static_Void_BombardRocket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669252);
    SfxSystem.NativeMethodInfoPtr_BombardRocketExplode_Private_Static_Void_BombardRocket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669253);
    SfxSystem.NativeMethodInfoPtr_ButtonHover_Private_Static_Void_ButtonType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669254);
    SfxSystem.NativeMethodInfoPtr_ButtonPress_Private_Static_Void_ButtonType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669255);
    SfxSystem.NativeMethodInfoPtr_ProgressStart_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669256);
    SfxSystem.NativeMethodInfoPtr_ProgressUpdate_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669257);
    SfxSystem.NativeMethodInfoPtr_ProgressStop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669258);
    SfxSystem.NativeMethodInfoPtr_ProgressDing_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669259);
    SfxSystem.NativeMethodInfoPtr_ProgressBlip_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669260);
    SfxSystem.NativeMethodInfoPtr_TownUnlockPopUp_Private_Static_Void_UnlockData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669261);
    SfxSystem.NativeMethodInfoPtr_UpgradeHover_Private_Static_Void_UpgradeDisplay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669262);
    SfxSystem.NativeMethodInfoPtr_UpgradePickup_Private_Static_Void_UpgradeDisplay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669263);
    SfxSystem.NativeMethodInfoPtr_UpgradeDrop_Private_Static_Void_UpgradeDisplay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669264);
    SfxSystem.NativeMethodInfoPtr_UpgradeAssign_Private_Static_Void_Entity_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669265);
    SfxSystem.NativeMethodInfoPtr_ShopItemHover_Private_Static_Void_ShopItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669266);
    SfxSystem.NativeMethodInfoPtr_AbilityTargetAdd_Private_Static_Void_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669267);
    SfxSystem.NativeMethodInfoPtr_EntityPing_Private_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669268);
    SfxSystem.NativeMethodInfoPtr_StopAll_Private_Void_STOP_MODE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669269);
    SfxSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, 100669270);
  }

  public SfxSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe SfxSystem instance
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(SfxSystem.NativeFieldInfoPtr_instance, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (SfxSystem) null : new SfxSystem(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SfxSystem.NativeFieldInfoPtr_instance, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe float DRAG_THRESHOLD
  {
    get
    {
      float dragThreshold;
      IL2CPP.il2cpp_field_static_get_value(SfxSystem.NativeFieldInfoPtr_DRAG_THRESHOLD, (void*) &dragThreshold);
      return dragThreshold;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SfxSystem.NativeFieldInfoPtr_DRAG_THRESHOLD, (void*) &value);
    }
  }

  public static unsafe Dictionary<string, float> cooldownTimers
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(SfxSystem.NativeFieldInfoPtr_cooldownTimers, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Dictionary<string, float>) null : new Dictionary<string, float>(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SfxSystem.NativeFieldInfoPtr_cooldownTimers, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Dictionary<string, SfxSystem.Cooldown> cooldowns
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(SfxSystem.NativeFieldInfoPtr_cooldowns, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Dictionary<string, SfxSystem.Cooldown>) null : new Dictionary<string, SfxSystem.Cooldown>(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SfxSystem.NativeFieldInfoPtr_cooldowns, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve pathRevealPitch
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxSystem.NativeFieldInfoPtr_pathRevealPitch));
      return pointer == System.IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SfxSystem.NativeFieldInfoPtr_pathRevealPitch), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe EventReference test
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxSystem.NativeFieldInfoPtr_test));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxSystem.NativeFieldInfoPtr_test)) = value;
    }
  }

  public unsafe List<EventInstance> running
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxSystem.NativeFieldInfoPtr_running));
      return pointer == System.IntPtr.Zero ? (List<EventInstance>) null : new List<EventInstance>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SfxSystem.NativeFieldInfoPtr_running), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Entity dragging
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxSystem.NativeFieldInfoPtr_dragging));
      return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SfxSystem.NativeFieldInfoPtr_dragging), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Entity draggingItem
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxSystem.NativeFieldInfoPtr_draggingItem));
      return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SfxSystem.NativeFieldInfoPtr_draggingItem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool dragTrigger
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxSystem.NativeFieldInfoPtr_dragTrigger));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxSystem.NativeFieldInfoPtr_dragTrigger)) = value;
    }
  }

  public unsafe Vector2 dragFrom
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxSystem.NativeFieldInfoPtr_dragFrom));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxSystem.NativeFieldInfoPtr_dragFrom)) = value;
    }
  }

  public unsafe EventInstance itemAim
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxSystem.NativeFieldInfoPtr_itemAim));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxSystem.NativeFieldInfoPtr_itemAim)) = value;
    }
  }

  public unsafe int revealActionsInQueue
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxSystem.NativeFieldInfoPtr_revealActionsInQueue));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxSystem.NativeFieldInfoPtr_revealActionsInQueue)) = value;
    }
  }

  public unsafe EventInstance flipMulti
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxSystem.NativeFieldInfoPtr_flipMulti));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxSystem.NativeFieldInfoPtr_flipMulti)) = value;
    }
  }

  public unsafe EventInstance transitionSnow
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxSystem.NativeFieldInfoPtr_transitionSnow));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxSystem.NativeFieldInfoPtr_transitionSnow)) = value;
    }
  }

  public unsafe EventInstance goldCounter
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxSystem.NativeFieldInfoPtr_goldCounter));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxSystem.NativeFieldInfoPtr_goldCounter)) = value;
    }
  }

  public unsafe EventInstance muncherFeed
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxSystem.NativeFieldInfoPtr_muncherFeed));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxSystem.NativeFieldInfoPtr_muncherFeed)) = value;
    }
  }

  public unsafe EventInstance drawMulti
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxSystem.NativeFieldInfoPtr_drawMulti));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxSystem.NativeFieldInfoPtr_drawMulti)) = value;
    }
  }

  public unsafe EventInstance townProgressionLoop
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxSystem.NativeFieldInfoPtr_townProgressionLoop));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxSystem.NativeFieldInfoPtr_townProgressionLoop)) = value;
    }
  }

  public unsafe GoldDisplay goldDisplay
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxSystem.NativeFieldInfoPtr_goldDisplay));
      return pointer == System.IntPtr.Zero ? (GoldDisplay) null : new GoldDisplay(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SfxSystem.NativeFieldInfoPtr_goldDisplay), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public sealed class Param : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_name;
    private static readonly System.IntPtr NativeFieldInfoPtr_value;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Single_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71772, XrefRangeEnd = 71773, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Param(string name, float value)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SfxSystem.Param>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SfxSystem.Param.NativeMethodInfoPtr__ctor_Public_Void_String_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Param()
    {
      Il2CppClassPointerStore<SfxSystem.Param>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, nameof (Param));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SfxSystem.Param>.NativeClassPtr);
      SfxSystem.Param.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SfxSystem.Param>.NativeClassPtr, nameof (name));
      SfxSystem.Param.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SfxSystem.Param>.NativeClassPtr, nameof (value));
      SfxSystem.Param.NativeMethodInfoPtr__ctor_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem.Param>.NativeClassPtr, 100669272);
    }

    public Param(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Param()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SfxSystem.Param>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SfxSystem.Param>.NativeClassPtr, data));
    }

    public unsafe string name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxSystem.Param.NativeFieldInfoPtr_name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SfxSystem.Param.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe float value
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxSystem.Param.NativeFieldInfoPtr_value));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxSystem.Param.NativeFieldInfoPtr_value)) = value;
      }
    }
  }

  public class Cooldown : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_eventName;
    private static readonly System.IntPtr NativeFieldInfoPtr_current;
    private static readonly System.IntPtr NativeFieldInfoPtr_max;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Max_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71773, XrefRangeEnd = 71775, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Cooldown(string eventName, float value)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SfxSystem.Cooldown>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(eventName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SfxSystem.Cooldown.NativeMethodInfoPtr__ctor_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void Max()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SfxSystem.Cooldown.NativeMethodInfoPtr_Max_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Cooldown()
    {
      Il2CppClassPointerStore<SfxSystem.Cooldown>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, nameof (Cooldown));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SfxSystem.Cooldown>.NativeClassPtr);
      SfxSystem.Cooldown.NativeFieldInfoPtr_eventName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SfxSystem.Cooldown>.NativeClassPtr, nameof (eventName));
      SfxSystem.Cooldown.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SfxSystem.Cooldown>.NativeClassPtr, nameof (current));
      SfxSystem.Cooldown.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SfxSystem.Cooldown>.NativeClassPtr, nameof (max));
      SfxSystem.Cooldown.NativeMethodInfoPtr__ctor_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem.Cooldown>.NativeClassPtr, 100669273);
      SfxSystem.Cooldown.NativeMethodInfoPtr_Max_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem.Cooldown>.NativeClassPtr, 100669274);
    }

    public Cooldown(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string eventName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxSystem.Cooldown.NativeFieldInfoPtr_eventName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SfxSystem.Cooldown.NativeFieldInfoPtr_eventName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe float current
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxSystem.Cooldown.NativeFieldInfoPtr_current));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxSystem.Cooldown.NativeFieldInfoPtr_current)) = value;
      }
    }

    public unsafe float max
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxSystem.Cooldown.NativeFieldInfoPtr_max));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxSystem.Cooldown.NativeFieldInfoPtr_max)) = value;
      }
    }
  }

  [ObfuscatedName("SfxSystem/<MapPathRevealRoutine>d__67")]
  public sealed class _MapPathRevealRoutine_d__67 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr_mapPathReveal;
    private static readonly System.IntPtr NativeFieldInfoPtr_totalTime;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr__time_5__2;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _MapPathRevealRoutine_d__67(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SfxSystem._MapPathRevealRoutine_d__67>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SfxSystem._MapPathRevealRoutine_d__67.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SfxSystem._MapPathRevealRoutine_d__67.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71775, XrefRangeEnd = 71789, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SfxSystem._MapPathRevealRoutine_d__67.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SfxSystem._MapPathRevealRoutine_d__67.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71789, XrefRangeEnd = 71795, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SfxSystem._MapPathRevealRoutine_d__67.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SfxSystem._MapPathRevealRoutine_d__67.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _MapPathRevealRoutine_d__67()
    {
      Il2CppClassPointerStore<SfxSystem._MapPathRevealRoutine_d__67>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SfxSystem>.NativeClassPtr, "<MapPathRevealRoutine>d__67");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SfxSystem._MapPathRevealRoutine_d__67>.NativeClassPtr);
      SfxSystem._MapPathRevealRoutine_d__67.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SfxSystem._MapPathRevealRoutine_d__67>.NativeClassPtr, "<>1__state");
      SfxSystem._MapPathRevealRoutine_d__67.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SfxSystem._MapPathRevealRoutine_d__67>.NativeClassPtr, "<>2__current");
      SfxSystem._MapPathRevealRoutine_d__67.NativeFieldInfoPtr_mapPathReveal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SfxSystem._MapPathRevealRoutine_d__67>.NativeClassPtr, nameof (mapPathReveal));
      SfxSystem._MapPathRevealRoutine_d__67.NativeFieldInfoPtr_totalTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SfxSystem._MapPathRevealRoutine_d__67>.NativeClassPtr, nameof (totalTime));
      SfxSystem._MapPathRevealRoutine_d__67.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SfxSystem._MapPathRevealRoutine_d__67>.NativeClassPtr, "<>4__this");
      SfxSystem._MapPathRevealRoutine_d__67.NativeFieldInfoPtr__time_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SfxSystem._MapPathRevealRoutine_d__67>.NativeClassPtr, "<time>5__2");
      SfxSystem._MapPathRevealRoutine_d__67.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem._MapPathRevealRoutine_d__67>.NativeClassPtr, 100669275);
      SfxSystem._MapPathRevealRoutine_d__67.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem._MapPathRevealRoutine_d__67>.NativeClassPtr, 100669276);
      SfxSystem._MapPathRevealRoutine_d__67.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem._MapPathRevealRoutine_d__67>.NativeClassPtr, 100669277);
      SfxSystem._MapPathRevealRoutine_d__67.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem._MapPathRevealRoutine_d__67>.NativeClassPtr, 100669278);
      SfxSystem._MapPathRevealRoutine_d__67.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem._MapPathRevealRoutine_d__67>.NativeClassPtr, 100669279);
      SfxSystem._MapPathRevealRoutine_d__67.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SfxSystem._MapPathRevealRoutine_d__67>.NativeClassPtr, 100669280);
    }

    public _MapPathRevealRoutine_d__67(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxSystem._MapPathRevealRoutine_d__67.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxSystem._MapPathRevealRoutine_d__67.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxSystem._MapPathRevealRoutine_d__67.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SfxSystem._MapPathRevealRoutine_d__67.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EventInstance mapPathReveal
    {
      get
      {
        return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxSystem._MapPathRevealRoutine_d__67.NativeFieldInfoPtr_mapPathReveal));
      }
      [param: In] set
      {
        *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxSystem._MapPathRevealRoutine_d__67.NativeFieldInfoPtr_mapPathReveal)) = value;
      }
    }

    public unsafe float totalTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxSystem._MapPathRevealRoutine_d__67.NativeFieldInfoPtr_totalTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxSystem._MapPathRevealRoutine_d__67.NativeFieldInfoPtr_totalTime)) = value;
      }
    }

    public unsafe SfxSystem __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxSystem._MapPathRevealRoutine_d__67.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (SfxSystem) null : new SfxSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SfxSystem._MapPathRevealRoutine_d__67.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float _time_5__2
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxSystem._MapPathRevealRoutine_d__67.NativeFieldInfoPtr__time_5__2));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SfxSystem._MapPathRevealRoutine_d__67.NativeFieldInfoPtr__time_5__2)) = value;
      }
    }
  }
}
