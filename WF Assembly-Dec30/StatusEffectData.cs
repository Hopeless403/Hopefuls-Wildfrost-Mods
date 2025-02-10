// Decompiled with JetBrains decompiler
// Type: StatusEffectData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Localization;

#nullable disable
public class StatusEffectData : ScriptableObject
{
  private static readonly System.IntPtr NativeFieldInfoPtr_idCurrent;
  private static readonly System.IntPtr NativeFieldInfoPtr_id;
  private static readonly System.IntPtr NativeFieldInfoPtr_original;
  private static readonly System.IntPtr NativeFieldInfoPtr_isClone;
  private static readonly System.IntPtr NativeFieldInfoPtr_isStatus;
  private static readonly System.IntPtr NativeFieldInfoPtr_isReaction;
  private static readonly System.IntPtr NativeFieldInfoPtr_isKeyword;
  private static readonly System.IntPtr NativeFieldInfoPtr_type;
  private static readonly System.IntPtr NativeFieldInfoPtr_keyword;
  private static readonly System.IntPtr NativeFieldInfoPtr_iconGroupName;
  private static readonly System.IntPtr NativeFieldInfoPtr_visible;
  private static readonly System.IntPtr NativeFieldInfoPtr_stackable;
  private static readonly System.IntPtr NativeFieldInfoPtr_offensive;
  private static readonly System.IntPtr NativeFieldInfoPtr_makesOffensive;
  private static readonly System.IntPtr NativeFieldInfoPtr_doesDamage;
  private static readonly System.IntPtr NativeFieldInfoPtr_canBeBoosted;
  private static readonly System.IntPtr NativeFieldInfoPtr_textKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_textInsert;
  private static readonly System.IntPtr NativeFieldInfoPtr_textOrder;
  private static readonly System.IntPtr NativeFieldInfoPtr_desc;
  private static readonly System.IntPtr NativeFieldInfoPtr_descColorHex;
  private static readonly System.IntPtr NativeFieldInfoPtr_descOrder;
  private static readonly System.IntPtr NativeFieldInfoPtr_hiddenKeywords;
  private static readonly System.IntPtr NativeFieldInfoPtr_applyFormat;
  private static readonly System.IntPtr NativeFieldInfoPtr_applyFormatKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_affectedBySnow;
  private static readonly System.IntPtr NativeFieldInfoPtr_eventPriority;
  private static readonly System.IntPtr NativeFieldInfoPtr_removeOnDiscard;
  private static readonly System.IntPtr NativeFieldInfoPtr_preventDeath;
  private static readonly System.IntPtr NativeFieldInfoPtr_targetConstraints;
  private static readonly System.IntPtr NativeFieldInfoPtr_removing;
  private static readonly System.IntPtr NativeFieldInfoPtr_temporary;
  private static readonly System.IntPtr NativeFieldInfoPtr_OnBegin;
  private static readonly System.IntPtr NativeFieldInfoPtr_OnEnd;
  private static readonly System.IntPtr NativeFieldInfoPtr_OnEnable;
  private static readonly System.IntPtr NativeFieldInfoPtr_OnDisable;
  private static readonly System.IntPtr NativeFieldInfoPtr_OnStack;
  private static readonly System.IntPtr NativeFieldInfoPtr_OnTurnStart;
  private static readonly System.IntPtr NativeFieldInfoPtr_OnTurn;
  private static readonly System.IntPtr NativeFieldInfoPtr_OnTurnEnd;
  private static readonly System.IntPtr NativeFieldInfoPtr_PreAttack;
  private static readonly System.IntPtr NativeFieldInfoPtr_OnHit;
  private static readonly System.IntPtr NativeFieldInfoPtr_PostHit;
  private static readonly System.IntPtr NativeFieldInfoPtr_PostAttack;
  private static readonly System.IntPtr NativeFieldInfoPtr_OnApplyStatus;
  private static readonly System.IntPtr NativeFieldInfoPtr_PostApplyStatus;
  private static readonly System.IntPtr NativeFieldInfoPtr_OnEntityDestroyed;
  private static readonly System.IntPtr NativeFieldInfoPtr_OnCardMove;
  private static readonly System.IntPtr NativeFieldInfoPtr_PreTrigger;
  private static readonly System.IntPtr NativeFieldInfoPtr_PreCardPlayed;
  private static readonly System.IntPtr NativeFieldInfoPtr_OnCardPlayed;
  private static readonly System.IntPtr NativeFieldInfoPtr_OnEffectBonusChanged;
  private static readonly System.IntPtr NativeFieldInfoPtr_OnActionPerformed;
  private static readonly System.IntPtr NativeFieldInfoPtr_OnBuild;
  private static readonly System.IntPtr NativeFieldInfoPtr_applier;
  private static readonly System.IntPtr NativeFieldInfoPtr_applierOwner;
  private static readonly System.IntPtr NativeFieldInfoPtr_target;
  private static readonly System.IntPtr NativeFieldInfoPtr_count;
  private static readonly System.IntPtr NativeMethodInfoPtr_Instantiate_Internal_StatusEffectData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetOriginal_Public_StatusEffectData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_HasDesc_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_HasDescOrIsKeyword_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDesc_Public_String_Int32_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPlainDesc_Public_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetApplyFormat_Public_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetMidBattleData_Public_Virtual_New_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RestoreMidBattleData_Public_Virtual_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Instant_Public_Virtual_New_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CanStackActions_Public_Virtual_New_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CanPlayOn_Public_Boolean_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CanTrigger_Protected_Virtual_New_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_add_OnBegin_Protected_add_Void_EffectEventHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnBegin_Protected_rem_Void_EffectEventHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_add_OnEnd_Protected_add_Void_EffectEventHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnEnd_Protected_rem_Void_EffectEventHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_add_OnEnable_Protected_add_Void_EffectEntityEventHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnEnable_Protected_rem_Void_EffectEntityEventHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_add_OnDisable_Protected_add_Void_EffectEntityEventHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnDisable_Protected_rem_Void_EffectEntityEventHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_add_OnStack_Protected_add_Void_EffectStackEventHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnStack_Protected_rem_Void_EffectStackEventHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_add_OnTurnStart_Protected_add_Void_EffectEntityEventHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnTurnStart_Protected_rem_Void_EffectEntityEventHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_add_OnTurn_Protected_add_Void_EffectEntityEventHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnTurn_Protected_rem_Void_EffectEntityEventHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_add_OnTurnEnd_Protected_add_Void_EffectEntityEventHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnTurnEnd_Protected_rem_Void_EffectEntityEventHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_add_PreAttack_Protected_add_Void_EffectHitEventHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_remove_PreAttack_Protected_rem_Void_EffectHitEventHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_add_OnHit_Protected_add_Void_EffectHitEventHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnHit_Protected_rem_Void_EffectHitEventHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_add_PostHit_Protected_add_Void_EffectHitEventHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_remove_PostHit_Protected_rem_Void_EffectHitEventHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_add_PostAttack_Protected_add_Void_EffectHitEventHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_remove_PostAttack_Protected_rem_Void_EffectHitEventHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_add_OnApplyStatus_Protected_add_Void_EffectApplyEventHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnApplyStatus_Protected_rem_Void_EffectApplyEventHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_add_PostApplyStatus_Protected_add_Void_EffectApplyEventHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_remove_PostApplyStatus_Protected_rem_Void_EffectApplyEventHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_add_OnEntityDestroyed_Protected_add_Void_EffectEntityDeathEventHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnEntityDestroyed_Protected_rem_Void_EffectEntityDeathEventHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_add_OnCardMove_Protected_add_Void_EffectEntityEventHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnCardMove_Protected_rem_Void_EffectEntityEventHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_add_PreTrigger_Protected_add_Void_EffectTriggerEventHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_remove_PreTrigger_Protected_rem_Void_EffectTriggerEventHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_add_PreCardPlayed_Protected_add_Void_EffectCardPlayEventHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_remove_PreCardPlayed_Protected_rem_Void_EffectCardPlayEventHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_add_OnCardPlayed_Protected_add_Void_EffectCardPlayEventHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnCardPlayed_Protected_rem_Void_EffectCardPlayEventHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_add_OnEffectBonusChanged_Protected_add_Void_EffectEventHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnEffectBonusChanged_Protected_rem_Void_EffectEventHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_add_OnActionPerformed_Protected_add_Void_EffectActionPerformedHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnActionPerformed_Protected_rem_Void_EffectActionPerformedHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_add_OnBuild_Protected_add_Void_EffectEntityEventHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnBuild_Protected_rem_Void_EffectEntityEventHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_HasBeginRoutine_Public_Virtual_New_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_HasEndRoutine_Public_Virtual_New_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_HasEnableRoutine_Public_Virtual_New_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_HasDisableRoutine_Public_Virtual_New_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_HasStackRoutine_Public_Virtual_New_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_HasTurnStartRoutine_Public_Virtual_New_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_HasTurnRoutine_Public_Virtual_New_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_HasTurnEndRoutine_Public_Virtual_New_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_HasPreAttackRoutine_Public_Virtual_New_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_HasHitRoutine_Public_Virtual_New_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_HasPostHitRoutine_Public_Virtual_New_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_HasPostAttackRoutine_Public_Virtual_New_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_HasApplyStatusRoutine_Public_Virtual_New_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_HasPostApplyStatusRoutine_Public_Virtual_New_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_HasEntityDestroyedRoutine_Public_Virtual_New_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_HasPreTriggerRoutine_Public_Virtual_New_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_HasPreCardPlayedRoutine_Public_Virtual_New_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_HasCardMoveRoutine_Public_Virtual_New_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_HasCardPlayedRoutine_Public_Virtual_New_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_HasEffectBonusChangedRoutine_Public_Virtual_New_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_HasActionPerformedRoutine_Public_Virtual_New_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_HasBuildRoutine_Public_Virtual_New_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RunBeginEvent_Public_Virtual_New_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RunEndEvent_Public_Virtual_New_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RunEnableEvent_Public_Virtual_New_Boolean_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RunDisableEvent_Public_Virtual_New_Boolean_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RunStackEvent_Public_Virtual_New_Boolean_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RunTurnStartEvent_Public_Virtual_New_Boolean_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RunTurnEvent_Public_Virtual_New_Boolean_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RunTurnEndEvent_Public_Virtual_New_Boolean_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RunPreAttackEvent_Public_Virtual_New_Boolean_Hit_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RunHitEvent_Public_Virtual_New_Boolean_Hit_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RunPostHitEvent_Public_Virtual_New_Boolean_Hit_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RunPostAttackEvent_Public_Virtual_New_Boolean_Hit_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RunApplyStatusEvent_Public_Virtual_New_Boolean_StatusEffectApply_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RunPostApplyStatusEvent_Public_Virtual_New_Boolean_StatusEffectApply_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RunEntityDestroyedEvent_Public_Virtual_New_Boolean_Entity_DeathType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RunCardMoveEvent_Public_Virtual_New_Boolean_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RunPreTriggerEvent_Public_Virtual_New_Boolean_Trigger_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RunPreCardPlayedEvent_Public_Virtual_New_Boolean_Entity_Il2CppReferenceArray_1_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RunCardPlayedEvent_Public_Virtual_New_Boolean_Entity_Il2CppReferenceArray_1_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RunEffectBonusChangedEvent_Public_Virtual_New_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RunActionPerformedEvent_Public_Virtual_New_Boolean_PlayAction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RunBuildEvent_Public_Virtual_New_Boolean_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_HasActiveTarget_Private_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BeginRoutine_Public_Virtual_New_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EndRoutine_Public_Virtual_New_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EnableRoutine_Public_Virtual_New_IEnumerator_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DisableRoutine_Public_Virtual_New_IEnumerator_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StackRoutine_Public_Virtual_New_IEnumerator_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TurnStartRoutine_Public_Virtual_New_IEnumerator_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TurnRoutine_Public_Virtual_New_IEnumerator_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TurnEndRoutine_Public_Virtual_New_IEnumerator_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PreAttackRoutine_Public_Virtual_New_IEnumerator_Hit_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HitRoutine_Public_Virtual_New_IEnumerator_Hit_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PostHitRoutine_Public_Virtual_New_IEnumerator_Hit_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PostAttackRoutine_Public_Virtual_New_IEnumerator_Hit_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ApplyStatusRoutine_Public_Virtual_New_IEnumerator_StatusEffectApply_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PostApplyStatusRoutine_Public_Virtual_New_IEnumerator_StatusEffectApply_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntityDestroyedRoutine_Public_Virtual_New_IEnumerator_Entity_DeathType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CardMoveRoutine_Public_Virtual_New_IEnumerator_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PreTriggerRoutine_Public_Virtual_New_IEnumerator_Trigger_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PreCardPlayedRoutine_Public_Virtual_New_IEnumerator_Entity_Il2CppReferenceArray_1_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CardPlayedRoutine_Public_Virtual_New_IEnumerator_Entity_Il2CppReferenceArray_1_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EffectBonusChangedRoutine_Public_Virtual_New_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ActionPerformedRoutine_Public_Virtual_New_IEnumerator_PlayAction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BuildRoutine_Public_Virtual_New_IEnumerator_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Apply_Public_Void_Int32_Entity_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CountDown_Protected_IEnumerator_Entity_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveStacks_Public_Virtual_New_IEnumerator_Int32_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Remove_Public_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetAmount_Protected_Virtual_New_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDamager_Protected_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTargetContainers_Protected_Il2CppReferenceArray_1_CardContainer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTargetActualContainers_Protected_Il2CppReferenceArray_1_CardContainer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110277, XrefRangeEnd = 110289, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StatusEffectData Instantiate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_Instantiate_Internal_StatusEffectData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (StatusEffectData) null : new StatusEffectData(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 110289, RefRangeEnd = 110290, XrefRangeStart = 110289, XrefRangeEnd = 110289, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StatusEffectData GetOriginal()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_GetOriginal_Public_StatusEffectData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (StatusEffectData) null : new StatusEffectData(pointer);
  }

  public unsafe bool HasDesc
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 110290, RefRangeEnd = 110292, XrefRangeStart = 110290, XrefRangeEnd = 110290, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_get_HasDesc_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public unsafe bool HasDescOrIsKeyword
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 110292, RefRangeEnd = 110294, XrefRangeStart = 110292, XrefRangeEnd = 110292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_get_HasDescOrIsKeyword_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 110322, RefRangeEnd = 110325, XrefRangeStart = 110294, XrefRangeEnd = 110322, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe string GetDesc(int amount, bool silenced = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &amount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &silenced;
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_GetDesc_Public_String_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(0)]
  public unsafe string GetPlainDesc()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_GetPlainDesc_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 110331, RefRangeEnd = 110332, XrefRangeStart = 110325, XrefRangeEnd = 110331, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe string GetApplyFormat()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_GetApplyFormat_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(44)]
  [CachedScanResults(RefRangeStart = 26224, RefRangeEnd = 26268, XrefRangeStart = 26224, XrefRangeEnd = 26268, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Il2CppSystem.Object GetMidBattleData()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_GetMidBattleData_Public_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
  }

  [CallerCount(12611)]
  [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void RestoreMidBattleData(Il2CppSystem.Object data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_RestoreMidBattleData_Public_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  public virtual unsafe bool Instant
  {
    [CallerCount(126), CachedScanResults(RefRangeStart = 15285, RefRangeEnd = 15411, XrefRangeStart = 15285, XrefRangeEnd = 15411, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_get_Instant_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public virtual unsafe bool CanStackActions
  {
    [CallerCount(14), CachedScanResults(RefRangeStart = 24612, RefRangeEnd = 24626, XrefRangeStart = 24612, XrefRangeEnd = 24626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_get_CanStackActions_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(12)]
  [CachedScanResults(RefRangeStart = 110333, RefRangeEnd = 110345, XrefRangeStart = 110332, XrefRangeEnd = 110333, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool CanPlayOn(Entity target)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_CanPlayOn_Public_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 110347, RefRangeEnd = 110350, XrefRangeStart = 110345, XrefRangeEnd = 110347, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool CanTrigger()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_CanTrigger_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 110354, RefRangeEnd = 110358, XrefRangeStart = 110350, XrefRangeEnd = 110354, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void add_OnBegin(StatusEffectData.EffectEventHandler value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_add_OnBegin_Protected_add_Void_EffectEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110358, XrefRangeEnd = 110362, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void remove_OnBegin(StatusEffectData.EffectEventHandler value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_remove_OnBegin_Protected_rem_Void_EffectEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110362, XrefRangeEnd = 110366, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void add_OnEnd(StatusEffectData.EffectEventHandler value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_add_OnEnd_Protected_add_Void_EffectEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110366, XrefRangeEnd = 110370, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void remove_OnEnd(StatusEffectData.EffectEventHandler value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_remove_OnEnd_Protected_rem_Void_EffectEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 110374, RefRangeEnd = 110381, XrefRangeStart = 110370, XrefRangeEnd = 110374, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void add_OnEnable(StatusEffectData.EffectEntityEventHandler value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_add_OnEnable_Protected_add_Void_EffectEntityEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110381, XrefRangeEnd = 110385, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void remove_OnEnable(StatusEffectData.EffectEntityEventHandler value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_remove_OnEnable_Protected_rem_Void_EffectEntityEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 110389, RefRangeEnd = 110391, XrefRangeStart = 110385, XrefRangeEnd = 110389, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void add_OnDisable(StatusEffectData.EffectEntityEventHandler value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_add_OnDisable_Protected_add_Void_EffectEntityEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110391, XrefRangeEnd = 110395, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void remove_OnDisable(StatusEffectData.EffectEntityEventHandler value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_remove_OnDisable_Protected_rem_Void_EffectEntityEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 110399, RefRangeEnd = 110400, XrefRangeStart = 110395, XrefRangeEnd = 110399, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void add_OnStack(StatusEffectData.EffectStackEventHandler value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_add_OnStack_Protected_add_Void_EffectStackEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110400, XrefRangeEnd = 110404, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void remove_OnStack(StatusEffectData.EffectStackEventHandler value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_remove_OnStack_Protected_rem_Void_EffectStackEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 110408, RefRangeEnd = 110409, XrefRangeStart = 110404, XrefRangeEnd = 110408, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void add_OnTurnStart(StatusEffectData.EffectEntityEventHandler value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_add_OnTurnStart_Protected_add_Void_EffectEntityEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110409, XrefRangeEnd = 110413, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void remove_OnTurnStart(StatusEffectData.EffectEntityEventHandler value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_remove_OnTurnStart_Protected_rem_Void_EffectEntityEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 110417, RefRangeEnd = 110419, XrefRangeStart = 110413, XrefRangeEnd = 110417, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void add_OnTurn(StatusEffectData.EffectEntityEventHandler value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_add_OnTurn_Protected_add_Void_EffectEntityEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110419, XrefRangeEnd = 110423, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void remove_OnTurn(StatusEffectData.EffectEntityEventHandler value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_remove_OnTurn_Protected_rem_Void_EffectEntityEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 110427, RefRangeEnd = 110432, XrefRangeStart = 110423, XrefRangeEnd = 110427, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void add_OnTurnEnd(StatusEffectData.EffectEntityEventHandler value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_add_OnTurnEnd_Protected_add_Void_EffectEntityEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110432, XrefRangeEnd = 110436, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void remove_OnTurnEnd(StatusEffectData.EffectEntityEventHandler value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_remove_OnTurnEnd_Protected_rem_Void_EffectEntityEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 110440, RefRangeEnd = 110442, XrefRangeStart = 110436, XrefRangeEnd = 110440, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void add_PreAttack(StatusEffectData.EffectHitEventHandler value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_add_PreAttack_Protected_add_Void_EffectHitEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110442, XrefRangeEnd = 110446, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void remove_PreAttack(StatusEffectData.EffectHitEventHandler value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_remove_PreAttack_Protected_rem_Void_EffectHitEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(10)]
  [CachedScanResults(RefRangeStart = 110450, RefRangeEnd = 110460, XrefRangeStart = 110446, XrefRangeEnd = 110450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void add_OnHit(StatusEffectData.EffectHitEventHandler value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_add_OnHit_Protected_add_Void_EffectHitEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110460, XrefRangeEnd = 110464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void remove_OnHit(StatusEffectData.EffectHitEventHandler value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_remove_OnHit_Protected_rem_Void_EffectHitEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 110468, RefRangeEnd = 110475, XrefRangeStart = 110464, XrefRangeEnd = 110468, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void add_PostHit(StatusEffectData.EffectHitEventHandler value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_add_PostHit_Protected_add_Void_EffectHitEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110475, XrefRangeEnd = 110479, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void remove_PostHit(StatusEffectData.EffectHitEventHandler value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_remove_PostHit_Protected_rem_Void_EffectHitEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 110483, RefRangeEnd = 110486, XrefRangeStart = 110479, XrefRangeEnd = 110483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void add_PostAttack(StatusEffectData.EffectHitEventHandler value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_add_PostAttack_Protected_add_Void_EffectHitEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110486, XrefRangeEnd = 110490, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void remove_PostAttack(StatusEffectData.EffectHitEventHandler value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_remove_PostAttack_Protected_rem_Void_EffectHitEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 110494, RefRangeEnd = 110496, XrefRangeStart = 110490, XrefRangeEnd = 110494, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void add_OnApplyStatus(StatusEffectData.EffectApplyEventHandler value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_add_OnApplyStatus_Protected_add_Void_EffectApplyEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110496, XrefRangeEnd = 110500, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void remove_OnApplyStatus(StatusEffectData.EffectApplyEventHandler value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_remove_OnApplyStatus_Protected_rem_Void_EffectApplyEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 110504, RefRangeEnd = 110509, XrefRangeStart = 110500, XrefRangeEnd = 110504, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void add_PostApplyStatus(StatusEffectData.EffectApplyEventHandler value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_add_PostApplyStatus_Protected_add_Void_EffectApplyEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110509, XrefRangeEnd = 110513, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void remove_PostApplyStatus(StatusEffectData.EffectApplyEventHandler value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_remove_PostApplyStatus_Protected_rem_Void_EffectApplyEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 110517, RefRangeEnd = 110525, XrefRangeStart = 110513, XrefRangeEnd = 110517, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void add_OnEntityDestroyed(
    StatusEffectData.EffectEntityDeathEventHandler value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_add_OnEntityDestroyed_Protected_add_Void_EffectEntityDeathEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110525, XrefRangeEnd = 110529, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void remove_OnEntityDestroyed(
    StatusEffectData.EffectEntityDeathEventHandler value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_remove_OnEntityDestroyed_Protected_rem_Void_EffectEntityDeathEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 110533, RefRangeEnd = 110538, XrefRangeStart = 110529, XrefRangeEnd = 110533, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void add_OnCardMove(StatusEffectData.EffectEntityEventHandler value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_add_OnCardMove_Protected_add_Void_EffectEntityEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110538, XrefRangeEnd = 110542, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void remove_OnCardMove(StatusEffectData.EffectEntityEventHandler value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_remove_OnCardMove_Protected_rem_Void_EffectEntityEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 110546, RefRangeEnd = 110549, XrefRangeStart = 110542, XrefRangeEnd = 110546, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void add_PreTrigger(StatusEffectData.EffectTriggerEventHandler value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_add_PreTrigger_Protected_add_Void_EffectTriggerEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110549, XrefRangeEnd = 110553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void remove_PreTrigger(StatusEffectData.EffectTriggerEventHandler value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_remove_PreTrigger_Protected_rem_Void_EffectTriggerEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 110557, RefRangeEnd = 110561, XrefRangeStart = 110553, XrefRangeEnd = 110557, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void add_PreCardPlayed(StatusEffectData.EffectCardPlayEventHandler value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_add_PreCardPlayed_Protected_add_Void_EffectCardPlayEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110561, XrefRangeEnd = 110565, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void remove_PreCardPlayed(StatusEffectData.EffectCardPlayEventHandler value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_remove_PreCardPlayed_Protected_rem_Void_EffectCardPlayEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(10)]
  [CachedScanResults(RefRangeStart = 110569, RefRangeEnd = 110579, XrefRangeStart = 110565, XrefRangeEnd = 110569, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void add_OnCardPlayed(StatusEffectData.EffectCardPlayEventHandler value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_add_OnCardPlayed_Protected_add_Void_EffectCardPlayEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110579, XrefRangeEnd = 110583, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void remove_OnCardPlayed(StatusEffectData.EffectCardPlayEventHandler value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_remove_OnCardPlayed_Protected_rem_Void_EffectCardPlayEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 110587, RefRangeEnd = 110588, XrefRangeStart = 110583, XrefRangeEnd = 110587, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void add_OnEffectBonusChanged(StatusEffectData.EffectEventHandler value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_add_OnEffectBonusChanged_Protected_add_Void_EffectEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110588, XrefRangeEnd = 110592, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void remove_OnEffectBonusChanged(StatusEffectData.EffectEventHandler value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_remove_OnEffectBonusChanged_Protected_rem_Void_EffectEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 110596, RefRangeEnd = 110600, XrefRangeStart = 110592, XrefRangeEnd = 110596, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void add_OnActionPerformed(
    StatusEffectData.EffectActionPerformedHandler value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_add_OnActionPerformed_Protected_add_Void_EffectActionPerformedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110600, XrefRangeEnd = 110604, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void remove_OnActionPerformed(
    StatusEffectData.EffectActionPerformedHandler value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_remove_OnActionPerformed_Protected_rem_Void_EffectActionPerformedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 110608, RefRangeEnd = 110609, XrefRangeStart = 110604, XrefRangeEnd = 110608, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void add_OnBuild(StatusEffectData.EffectEntityEventHandler value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_add_OnBuild_Protected_add_Void_EffectEntityEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110609, XrefRangeEnd = 110613, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void remove_OnBuild(StatusEffectData.EffectEntityEventHandler value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_remove_OnBuild_Protected_rem_Void_EffectEntityEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  public virtual unsafe bool HasBeginRoutine
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_get_HasBeginRoutine_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public virtual unsafe bool HasEndRoutine
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_get_HasEndRoutine_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public virtual unsafe bool HasEnableRoutine
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_get_HasEnableRoutine_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public virtual unsafe bool HasDisableRoutine
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_get_HasDisableRoutine_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public virtual unsafe bool HasStackRoutine
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_get_HasStackRoutine_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public virtual unsafe bool HasTurnStartRoutine
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_get_HasTurnStartRoutine_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public virtual unsafe bool HasTurnRoutine
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_get_HasTurnRoutine_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public virtual unsafe bool HasTurnEndRoutine
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_get_HasTurnEndRoutine_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public virtual unsafe bool HasPreAttackRoutine
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_get_HasPreAttackRoutine_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public virtual unsafe bool HasHitRoutine
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_get_HasHitRoutine_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public virtual unsafe bool HasPostHitRoutine
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_get_HasPostHitRoutine_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public virtual unsafe bool HasPostAttackRoutine
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_get_HasPostAttackRoutine_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public virtual unsafe bool HasApplyStatusRoutine
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_get_HasApplyStatusRoutine_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public virtual unsafe bool HasPostApplyStatusRoutine
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_get_HasPostApplyStatusRoutine_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public virtual unsafe bool HasEntityDestroyedRoutine
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_get_HasEntityDestroyedRoutine_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public virtual unsafe bool HasPreTriggerRoutine
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_get_HasPreTriggerRoutine_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public virtual unsafe bool HasPreCardPlayedRoutine
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_get_HasPreCardPlayedRoutine_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public virtual unsafe bool HasCardMoveRoutine
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_get_HasCardMoveRoutine_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public virtual unsafe bool HasCardPlayedRoutine
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_get_HasCardPlayedRoutine_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public virtual unsafe bool HasEffectBonusChangedRoutine
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_get_HasEffectBonusChangedRoutine_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public virtual unsafe bool HasActionPerformedRoutine
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_get_HasActionPerformedRoutine_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public virtual unsafe bool HasBuildRoutine
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_get_HasBuildRoutine_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(14)]
  [CachedScanResults(RefRangeStart = 24612, RefRangeEnd = 24626, XrefRangeStart = 24612, XrefRangeEnd = 24626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool RunBeginEvent()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_RunBeginEvent_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(14)]
  [CachedScanResults(RefRangeStart = 24612, RefRangeEnd = 24626, XrefRangeStart = 24612, XrefRangeEnd = 24626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool RunEndEvent()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_RunEndEvent_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(14)]
  [CachedScanResults(RefRangeStart = 24612, RefRangeEnd = 24626, XrefRangeStart = 24612, XrefRangeEnd = 24626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool RunEnableEvent(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_RunEnableEvent_Public_Virtual_New_Boolean_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(14)]
  [CachedScanResults(RefRangeStart = 24612, RefRangeEnd = 24626, XrefRangeStart = 24612, XrefRangeEnd = 24626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool RunDisableEvent(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_RunDisableEvent_Public_Virtual_New_Boolean_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(14)]
  [CachedScanResults(RefRangeStart = 24612, RefRangeEnd = 24626, XrefRangeStart = 24612, XrefRangeEnd = 24626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool RunStackEvent(int stacks)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &stacks
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_RunStackEvent_Public_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(14)]
  [CachedScanResults(RefRangeStart = 24612, RefRangeEnd = 24626, XrefRangeStart = 24612, XrefRangeEnd = 24626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool RunTurnStartEvent(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_RunTurnStartEvent_Public_Virtual_New_Boolean_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(14)]
  [CachedScanResults(RefRangeStart = 24612, RefRangeEnd = 24626, XrefRangeStart = 24612, XrefRangeEnd = 24626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool RunTurnEvent(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_RunTurnEvent_Public_Virtual_New_Boolean_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(14)]
  [CachedScanResults(RefRangeStart = 24612, RefRangeEnd = 24626, XrefRangeStart = 24612, XrefRangeEnd = 24626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool RunTurnEndEvent(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_RunTurnEndEvent_Public_Virtual_New_Boolean_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(14)]
  [CachedScanResults(RefRangeStart = 24612, RefRangeEnd = 24626, XrefRangeStart = 24612, XrefRangeEnd = 24626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool RunPreAttackEvent(Hit hit)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hit)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_RunPreAttackEvent_Public_Virtual_New_Boolean_Hit_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(14)]
  [CachedScanResults(RefRangeStart = 24612, RefRangeEnd = 24626, XrefRangeStart = 24612, XrefRangeEnd = 24626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool RunHitEvent(Hit hit)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hit)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_RunHitEvent_Public_Virtual_New_Boolean_Hit_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(14)]
  [CachedScanResults(RefRangeStart = 24612, RefRangeEnd = 24626, XrefRangeStart = 24612, XrefRangeEnd = 24626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool RunPostHitEvent(Hit hit)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hit)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_RunPostHitEvent_Public_Virtual_New_Boolean_Hit_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(14)]
  [CachedScanResults(RefRangeStart = 24612, RefRangeEnd = 24626, XrefRangeStart = 24612, XrefRangeEnd = 24626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool RunPostAttackEvent(Hit hit)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hit)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_RunPostAttackEvent_Public_Virtual_New_Boolean_Hit_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(14)]
  [CachedScanResults(RefRangeStart = 24612, RefRangeEnd = 24626, XrefRangeStart = 24612, XrefRangeEnd = 24626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool RunApplyStatusEvent(StatusEffectApply apply)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) apply)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_RunApplyStatusEvent_Public_Virtual_New_Boolean_StatusEffectApply_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(14)]
  [CachedScanResults(RefRangeStart = 24612, RefRangeEnd = 24626, XrefRangeStart = 24612, XrefRangeEnd = 24626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool RunPostApplyStatusEvent(StatusEffectApply apply)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) apply)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_RunPostApplyStatusEvent_Public_Virtual_New_Boolean_StatusEffectApply_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(14)]
  [CachedScanResults(RefRangeStart = 24612, RefRangeEnd = 24626, XrefRangeStart = 24612, XrefRangeEnd = 24626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool RunEntityDestroyedEvent(Entity entity, DeathType deathType)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &deathType;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_RunEntityDestroyedEvent_Public_Virtual_New_Boolean_Entity_DeathType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(14)]
  [CachedScanResults(RefRangeStart = 24612, RefRangeEnd = 24626, XrefRangeStart = 24612, XrefRangeEnd = 24626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool RunCardMoveEvent(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_RunCardMoveEvent_Public_Virtual_New_Boolean_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(14)]
  [CachedScanResults(RefRangeStart = 24612, RefRangeEnd = 24626, XrefRangeStart = 24612, XrefRangeEnd = 24626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool RunPreTriggerEvent(Trigger trigger)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) trigger)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_RunPreTriggerEvent_Public_Virtual_New_Boolean_Trigger_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(14)]
  [CachedScanResults(RefRangeStart = 24612, RefRangeEnd = 24626, XrefRangeStart = 24612, XrefRangeEnd = 24626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool RunPreCardPlayedEvent(
    Entity entity,
    Il2CppReferenceArray<Entity> targets)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targets);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_RunPreCardPlayedEvent_Public_Virtual_New_Boolean_Entity_Il2CppReferenceArray_1_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(14)]
  [CachedScanResults(RefRangeStart = 24612, RefRangeEnd = 24626, XrefRangeStart = 24612, XrefRangeEnd = 24626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool RunCardPlayedEvent(Entity entity, Il2CppReferenceArray<Entity> targets)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targets);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_RunCardPlayedEvent_Public_Virtual_New_Boolean_Entity_Il2CppReferenceArray_1_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(14)]
  [CachedScanResults(RefRangeStart = 24612, RefRangeEnd = 24626, XrefRangeStart = 24612, XrefRangeEnd = 24626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool RunEffectBonusChangedEvent()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_RunEffectBonusChangedEvent_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(14)]
  [CachedScanResults(RefRangeStart = 24612, RefRangeEnd = 24626, XrefRangeStart = 24612, XrefRangeEnd = 24626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool RunActionPerformedEvent(PlayAction action)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_RunActionPerformedEvent_Public_Virtual_New_Boolean_PlayAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(14)]
  [CachedScanResults(RefRangeStart = 24612, RefRangeEnd = 24626, XrefRangeStart = 24612, XrefRangeEnd = 24626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool RunBuildEvent(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_RunBuildEvent_Public_Virtual_New_Boolean_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  public unsafe bool HasActiveTarget
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110613, XrefRangeEnd = 110617, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_get_HasActiveTarget_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 110618, RefRangeEnd = 110619, XrefRangeStart = 110617, XrefRangeEnd = 110618, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe IEnumerator BeginRoutine()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_BeginRoutine_Public_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110619, XrefRangeEnd = 110620, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe IEnumerator EndRoutine()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_EndRoutine_Public_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110620, XrefRangeEnd = 110621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe IEnumerator EnableRoutine(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_EnableRoutine_Public_Virtual_New_IEnumerator_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110621, XrefRangeEnd = 110622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe IEnumerator DisableRoutine(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_DisableRoutine_Public_Virtual_New_IEnumerator_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110622, XrefRangeEnd = 110623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe IEnumerator StackRoutine(int stacks)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &stacks
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_StackRoutine_Public_Virtual_New_IEnumerator_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110623, XrefRangeEnd = 110624, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe IEnumerator TurnStartRoutine(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_TurnStartRoutine_Public_Virtual_New_IEnumerator_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110624, XrefRangeEnd = 110625, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe IEnumerator TurnRoutine(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_TurnRoutine_Public_Virtual_New_IEnumerator_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110625, XrefRangeEnd = 110626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe IEnumerator TurnEndRoutine(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_TurnEndRoutine_Public_Virtual_New_IEnumerator_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110626, XrefRangeEnd = 110627, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe IEnumerator PreAttackRoutine(Hit hit)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hit)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_PreAttackRoutine_Public_Virtual_New_IEnumerator_Hit_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110627, XrefRangeEnd = 110628, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe IEnumerator HitRoutine(Hit hit)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hit)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_HitRoutine_Public_Virtual_New_IEnumerator_Hit_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110628, XrefRangeEnd = 110629, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe IEnumerator PostHitRoutine(Hit hit)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hit)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_PostHitRoutine_Public_Virtual_New_IEnumerator_Hit_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110629, XrefRangeEnd = 110630, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe IEnumerator PostAttackRoutine(Hit hit)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hit)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_PostAttackRoutine_Public_Virtual_New_IEnumerator_Hit_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110630, XrefRangeEnd = 110631, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe IEnumerator ApplyStatusRoutine(StatusEffectApply apply)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) apply)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_ApplyStatusRoutine_Public_Virtual_New_IEnumerator_StatusEffectApply_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110631, XrefRangeEnd = 110632, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe IEnumerator PostApplyStatusRoutine(StatusEffectApply apply)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) apply)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_PostApplyStatusRoutine_Public_Virtual_New_IEnumerator_StatusEffectApply_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110632, XrefRangeEnd = 110633, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe IEnumerator EntityDestroyedRoutine(Entity entity, DeathType deathType)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &deathType;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_EntityDestroyedRoutine_Public_Virtual_New_IEnumerator_Entity_DeathType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110633, XrefRangeEnd = 110634, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe IEnumerator CardMoveRoutine(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_CardMoveRoutine_Public_Virtual_New_IEnumerator_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110634, XrefRangeEnd = 110635, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe IEnumerator PreTriggerRoutine(Trigger trigger)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) trigger)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_PreTriggerRoutine_Public_Virtual_New_IEnumerator_Trigger_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110635, XrefRangeEnd = 110636, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe IEnumerator PreCardPlayedRoutine(
    Entity entity,
    Il2CppReferenceArray<Entity> targets)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targets);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_PreCardPlayedRoutine_Public_Virtual_New_IEnumerator_Entity_Il2CppReferenceArray_1_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110636, XrefRangeEnd = 110637, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe IEnumerator CardPlayedRoutine(
    Entity entity,
    Il2CppReferenceArray<Entity> targets)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targets);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_CardPlayedRoutine_Public_Virtual_New_IEnumerator_Entity_Il2CppReferenceArray_1_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110637, XrefRangeEnd = 110638, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe IEnumerator EffectBonusChangedRoutine()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_EffectBonusChangedRoutine_Public_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110638, XrefRangeEnd = 110639, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe IEnumerator ActionPerformedRoutine(PlayAction action)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_ActionPerformedRoutine_Public_Virtual_New_IEnumerator_PlayAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110639, XrefRangeEnd = 110640, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe IEnumerator BuildRoutine(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_BuildRoutine_Public_Virtual_New_IEnumerator_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110640, XrefRangeEnd = 110646, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Apply(int count, Entity target, Entity applier)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &count;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) applier);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_Apply_Public_Void_Int32_Entity_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(12611)]
  [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Init()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_Init_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(12)]
  [CachedScanResults(RefRangeStart = 110652, RefRangeEnd = 110664, XrefRangeStart = 110646, XrefRangeEnd = 110652, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator CountDown(Entity entity, int amount)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &amount;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_CountDown_Protected_IEnumerator_Entity_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 110669, RefRangeEnd = 110670, XrefRangeStart = 110664, XrefRangeEnd = 110669, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe IEnumerator RemoveStacks(int amount, bool removeTemporary)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &amount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &removeTemporary;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_RemoveStacks_Public_Virtual_New_IEnumerator_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(14)]
  [CachedScanResults(RefRangeStart = 110675, RefRangeEnd = 110689, XrefRangeStart = 110670, XrefRangeEnd = 110675, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator Remove()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_Remove_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 110721, RefRangeEnd = 110723, XrefRangeStart = 110689, XrefRangeEnd = 110721, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Destroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_Destroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110723, XrefRangeEnd = 110729, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe int GetAmount()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectData.NativeMethodInfoPtr_GetAmount_Protected_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110729, XrefRangeEnd = 110733, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Entity GetDamager()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_GetDamager_Protected_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 110735, RefRangeEnd = 110737, XrefRangeStart = 110733, XrefRangeEnd = 110735, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Il2CppReferenceArray<CardContainer> GetTargetContainers()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_GetTargetContainers_Protected_Il2CppReferenceArray_1_CardContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr nativeObject = num;
    return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CardContainer>) null : new Il2CppReferenceArray<CardContainer>(nativeObject);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 110741, RefRangeEnd = 110743, XrefRangeStart = 110737, XrefRangeEnd = 110741, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Il2CppReferenceArray<CardContainer> GetTargetActualContainers()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr_GetTargetActualContainers_Protected_Il2CppReferenceArray_1_CardContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr nativeObject = num;
    return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CardContainer>) null : new Il2CppReferenceArray<CardContainer>(nativeObject);
  }

  [CallerCount(103)]
  [CachedScanResults(RefRangeStart = 110744, RefRangeEnd = 110847, XrefRangeStart = 110743, XrefRangeEnd = 110744, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StatusEffectData()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectData.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static StatusEffectData()
  {
    Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (StatusEffectData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr);
    StatusEffectData.NativeFieldInfoPtr_idCurrent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (idCurrent));
    StatusEffectData.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (id));
    StatusEffectData.NativeFieldInfoPtr_original = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (original));
    StatusEffectData.NativeFieldInfoPtr_isClone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (isClone));
    StatusEffectData.NativeFieldInfoPtr_isStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (isStatus));
    StatusEffectData.NativeFieldInfoPtr_isReaction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (isReaction));
    StatusEffectData.NativeFieldInfoPtr_isKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (isKeyword));
    StatusEffectData.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (type));
    StatusEffectData.NativeFieldInfoPtr_keyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (keyword));
    StatusEffectData.NativeFieldInfoPtr_iconGroupName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (iconGroupName));
    StatusEffectData.NativeFieldInfoPtr_visible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (visible));
    StatusEffectData.NativeFieldInfoPtr_stackable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (stackable));
    StatusEffectData.NativeFieldInfoPtr_offensive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (offensive));
    StatusEffectData.NativeFieldInfoPtr_makesOffensive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (makesOffensive));
    StatusEffectData.NativeFieldInfoPtr_doesDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (doesDamage));
    StatusEffectData.NativeFieldInfoPtr_canBeBoosted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (canBeBoosted));
    StatusEffectData.NativeFieldInfoPtr_textKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (textKey));
    StatusEffectData.NativeFieldInfoPtr_textInsert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (textInsert));
    StatusEffectData.NativeFieldInfoPtr_textOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (textOrder));
    StatusEffectData.NativeFieldInfoPtr_desc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (desc));
    StatusEffectData.NativeFieldInfoPtr_descColorHex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (descColorHex));
    StatusEffectData.NativeFieldInfoPtr_descOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (descOrder));
    StatusEffectData.NativeFieldInfoPtr_hiddenKeywords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (hiddenKeywords));
    StatusEffectData.NativeFieldInfoPtr_applyFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (applyFormat));
    StatusEffectData.NativeFieldInfoPtr_applyFormatKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (applyFormatKey));
    StatusEffectData.NativeFieldInfoPtr_affectedBySnow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (affectedBySnow));
    StatusEffectData.NativeFieldInfoPtr_eventPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (eventPriority));
    StatusEffectData.NativeFieldInfoPtr_removeOnDiscard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (removeOnDiscard));
    StatusEffectData.NativeFieldInfoPtr_preventDeath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (preventDeath));
    StatusEffectData.NativeFieldInfoPtr_targetConstraints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (targetConstraints));
    StatusEffectData.NativeFieldInfoPtr_removing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (removing));
    StatusEffectData.NativeFieldInfoPtr_temporary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (temporary));
    StatusEffectData.NativeFieldInfoPtr_OnBegin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (OnBegin));
    StatusEffectData.NativeFieldInfoPtr_OnEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (OnEnd));
    StatusEffectData.NativeFieldInfoPtr_OnEnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (OnEnable));
    StatusEffectData.NativeFieldInfoPtr_OnDisable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (OnDisable));
    StatusEffectData.NativeFieldInfoPtr_OnStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (OnStack));
    StatusEffectData.NativeFieldInfoPtr_OnTurnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (OnTurnStart));
    StatusEffectData.NativeFieldInfoPtr_OnTurn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (OnTurn));
    StatusEffectData.NativeFieldInfoPtr_OnTurnEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (OnTurnEnd));
    StatusEffectData.NativeFieldInfoPtr_PreAttack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (PreAttack));
    StatusEffectData.NativeFieldInfoPtr_OnHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (OnHit));
    StatusEffectData.NativeFieldInfoPtr_PostHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (PostHit));
    StatusEffectData.NativeFieldInfoPtr_PostAttack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (PostAttack));
    StatusEffectData.NativeFieldInfoPtr_OnApplyStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (OnApplyStatus));
    StatusEffectData.NativeFieldInfoPtr_PostApplyStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (PostApplyStatus));
    StatusEffectData.NativeFieldInfoPtr_OnEntityDestroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (OnEntityDestroyed));
    StatusEffectData.NativeFieldInfoPtr_OnCardMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (OnCardMove));
    StatusEffectData.NativeFieldInfoPtr_PreTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (PreTrigger));
    StatusEffectData.NativeFieldInfoPtr_PreCardPlayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (PreCardPlayed));
    StatusEffectData.NativeFieldInfoPtr_OnCardPlayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (OnCardPlayed));
    StatusEffectData.NativeFieldInfoPtr_OnEffectBonusChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (OnEffectBonusChanged));
    StatusEffectData.NativeFieldInfoPtr_OnActionPerformed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (OnActionPerformed));
    StatusEffectData.NativeFieldInfoPtr_OnBuild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (OnBuild));
    StatusEffectData.NativeFieldInfoPtr_applier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (applier));
    StatusEffectData.NativeFieldInfoPtr_applierOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (applierOwner));
    StatusEffectData.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (target));
    StatusEffectData.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (count));
    StatusEffectData.NativeMethodInfoPtr_Instantiate_Internal_StatusEffectData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673454);
    StatusEffectData.NativeMethodInfoPtr_GetOriginal_Public_StatusEffectData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673455);
    StatusEffectData.NativeMethodInfoPtr_get_HasDesc_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673456);
    StatusEffectData.NativeMethodInfoPtr_get_HasDescOrIsKeyword_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673457);
    StatusEffectData.NativeMethodInfoPtr_GetDesc_Public_String_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673458);
    StatusEffectData.NativeMethodInfoPtr_GetPlainDesc_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673459);
    StatusEffectData.NativeMethodInfoPtr_GetApplyFormat_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673460);
    StatusEffectData.NativeMethodInfoPtr_GetMidBattleData_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673461);
    StatusEffectData.NativeMethodInfoPtr_RestoreMidBattleData_Public_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673462);
    StatusEffectData.NativeMethodInfoPtr_get_Instant_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673463);
    StatusEffectData.NativeMethodInfoPtr_get_CanStackActions_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673464);
    StatusEffectData.NativeMethodInfoPtr_CanPlayOn_Public_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673465);
    StatusEffectData.NativeMethodInfoPtr_CanTrigger_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673466);
    StatusEffectData.NativeMethodInfoPtr_add_OnBegin_Protected_add_Void_EffectEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673467);
    StatusEffectData.NativeMethodInfoPtr_remove_OnBegin_Protected_rem_Void_EffectEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673468);
    StatusEffectData.NativeMethodInfoPtr_add_OnEnd_Protected_add_Void_EffectEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673469);
    StatusEffectData.NativeMethodInfoPtr_remove_OnEnd_Protected_rem_Void_EffectEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673470);
    StatusEffectData.NativeMethodInfoPtr_add_OnEnable_Protected_add_Void_EffectEntityEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673471);
    StatusEffectData.NativeMethodInfoPtr_remove_OnEnable_Protected_rem_Void_EffectEntityEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673472);
    StatusEffectData.NativeMethodInfoPtr_add_OnDisable_Protected_add_Void_EffectEntityEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673473);
    StatusEffectData.NativeMethodInfoPtr_remove_OnDisable_Protected_rem_Void_EffectEntityEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673474);
    StatusEffectData.NativeMethodInfoPtr_add_OnStack_Protected_add_Void_EffectStackEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673475);
    StatusEffectData.NativeMethodInfoPtr_remove_OnStack_Protected_rem_Void_EffectStackEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673476);
    StatusEffectData.NativeMethodInfoPtr_add_OnTurnStart_Protected_add_Void_EffectEntityEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673477);
    StatusEffectData.NativeMethodInfoPtr_remove_OnTurnStart_Protected_rem_Void_EffectEntityEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673478);
    StatusEffectData.NativeMethodInfoPtr_add_OnTurn_Protected_add_Void_EffectEntityEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673479);
    StatusEffectData.NativeMethodInfoPtr_remove_OnTurn_Protected_rem_Void_EffectEntityEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673480);
    StatusEffectData.NativeMethodInfoPtr_add_OnTurnEnd_Protected_add_Void_EffectEntityEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673481);
    StatusEffectData.NativeMethodInfoPtr_remove_OnTurnEnd_Protected_rem_Void_EffectEntityEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673482);
    StatusEffectData.NativeMethodInfoPtr_add_PreAttack_Protected_add_Void_EffectHitEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673483);
    StatusEffectData.NativeMethodInfoPtr_remove_PreAttack_Protected_rem_Void_EffectHitEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673484);
    StatusEffectData.NativeMethodInfoPtr_add_OnHit_Protected_add_Void_EffectHitEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673485);
    StatusEffectData.NativeMethodInfoPtr_remove_OnHit_Protected_rem_Void_EffectHitEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673486);
    StatusEffectData.NativeMethodInfoPtr_add_PostHit_Protected_add_Void_EffectHitEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673487);
    StatusEffectData.NativeMethodInfoPtr_remove_PostHit_Protected_rem_Void_EffectHitEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673488);
    StatusEffectData.NativeMethodInfoPtr_add_PostAttack_Protected_add_Void_EffectHitEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673489);
    StatusEffectData.NativeMethodInfoPtr_remove_PostAttack_Protected_rem_Void_EffectHitEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673490);
    StatusEffectData.NativeMethodInfoPtr_add_OnApplyStatus_Protected_add_Void_EffectApplyEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673491);
    StatusEffectData.NativeMethodInfoPtr_remove_OnApplyStatus_Protected_rem_Void_EffectApplyEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673492);
    StatusEffectData.NativeMethodInfoPtr_add_PostApplyStatus_Protected_add_Void_EffectApplyEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673493);
    StatusEffectData.NativeMethodInfoPtr_remove_PostApplyStatus_Protected_rem_Void_EffectApplyEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673494);
    StatusEffectData.NativeMethodInfoPtr_add_OnEntityDestroyed_Protected_add_Void_EffectEntityDeathEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673495);
    StatusEffectData.NativeMethodInfoPtr_remove_OnEntityDestroyed_Protected_rem_Void_EffectEntityDeathEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673496);
    StatusEffectData.NativeMethodInfoPtr_add_OnCardMove_Protected_add_Void_EffectEntityEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673497);
    StatusEffectData.NativeMethodInfoPtr_remove_OnCardMove_Protected_rem_Void_EffectEntityEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673498);
    StatusEffectData.NativeMethodInfoPtr_add_PreTrigger_Protected_add_Void_EffectTriggerEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673499);
    StatusEffectData.NativeMethodInfoPtr_remove_PreTrigger_Protected_rem_Void_EffectTriggerEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673500);
    StatusEffectData.NativeMethodInfoPtr_add_PreCardPlayed_Protected_add_Void_EffectCardPlayEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673501);
    StatusEffectData.NativeMethodInfoPtr_remove_PreCardPlayed_Protected_rem_Void_EffectCardPlayEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673502);
    StatusEffectData.NativeMethodInfoPtr_add_OnCardPlayed_Protected_add_Void_EffectCardPlayEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673503);
    StatusEffectData.NativeMethodInfoPtr_remove_OnCardPlayed_Protected_rem_Void_EffectCardPlayEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673504);
    StatusEffectData.NativeMethodInfoPtr_add_OnEffectBonusChanged_Protected_add_Void_EffectEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673505);
    StatusEffectData.NativeMethodInfoPtr_remove_OnEffectBonusChanged_Protected_rem_Void_EffectEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673506);
    StatusEffectData.NativeMethodInfoPtr_add_OnActionPerformed_Protected_add_Void_EffectActionPerformedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673507);
    StatusEffectData.NativeMethodInfoPtr_remove_OnActionPerformed_Protected_rem_Void_EffectActionPerformedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673508);
    StatusEffectData.NativeMethodInfoPtr_add_OnBuild_Protected_add_Void_EffectEntityEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673509);
    StatusEffectData.NativeMethodInfoPtr_remove_OnBuild_Protected_rem_Void_EffectEntityEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673510);
    StatusEffectData.NativeMethodInfoPtr_get_HasBeginRoutine_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673511);
    StatusEffectData.NativeMethodInfoPtr_get_HasEndRoutine_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673512);
    StatusEffectData.NativeMethodInfoPtr_get_HasEnableRoutine_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673513);
    StatusEffectData.NativeMethodInfoPtr_get_HasDisableRoutine_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673514);
    StatusEffectData.NativeMethodInfoPtr_get_HasStackRoutine_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673515);
    StatusEffectData.NativeMethodInfoPtr_get_HasTurnStartRoutine_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673516);
    StatusEffectData.NativeMethodInfoPtr_get_HasTurnRoutine_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673517);
    StatusEffectData.NativeMethodInfoPtr_get_HasTurnEndRoutine_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673518);
    StatusEffectData.NativeMethodInfoPtr_get_HasPreAttackRoutine_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673519);
    StatusEffectData.NativeMethodInfoPtr_get_HasHitRoutine_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673520);
    StatusEffectData.NativeMethodInfoPtr_get_HasPostHitRoutine_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673521);
    StatusEffectData.NativeMethodInfoPtr_get_HasPostAttackRoutine_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673522);
    StatusEffectData.NativeMethodInfoPtr_get_HasApplyStatusRoutine_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673523);
    StatusEffectData.NativeMethodInfoPtr_get_HasPostApplyStatusRoutine_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673524);
    StatusEffectData.NativeMethodInfoPtr_get_HasEntityDestroyedRoutine_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673525);
    StatusEffectData.NativeMethodInfoPtr_get_HasPreTriggerRoutine_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673526);
    StatusEffectData.NativeMethodInfoPtr_get_HasPreCardPlayedRoutine_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673527);
    StatusEffectData.NativeMethodInfoPtr_get_HasCardMoveRoutine_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673528);
    StatusEffectData.NativeMethodInfoPtr_get_HasCardPlayedRoutine_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673529);
    StatusEffectData.NativeMethodInfoPtr_get_HasEffectBonusChangedRoutine_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673530);
    StatusEffectData.NativeMethodInfoPtr_get_HasActionPerformedRoutine_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673531);
    StatusEffectData.NativeMethodInfoPtr_get_HasBuildRoutine_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673532);
    StatusEffectData.NativeMethodInfoPtr_RunBeginEvent_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673533);
    StatusEffectData.NativeMethodInfoPtr_RunEndEvent_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673534);
    StatusEffectData.NativeMethodInfoPtr_RunEnableEvent_Public_Virtual_New_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673535);
    StatusEffectData.NativeMethodInfoPtr_RunDisableEvent_Public_Virtual_New_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673536);
    StatusEffectData.NativeMethodInfoPtr_RunStackEvent_Public_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673537);
    StatusEffectData.NativeMethodInfoPtr_RunTurnStartEvent_Public_Virtual_New_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673538);
    StatusEffectData.NativeMethodInfoPtr_RunTurnEvent_Public_Virtual_New_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673539);
    StatusEffectData.NativeMethodInfoPtr_RunTurnEndEvent_Public_Virtual_New_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673540);
    StatusEffectData.NativeMethodInfoPtr_RunPreAttackEvent_Public_Virtual_New_Boolean_Hit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673541);
    StatusEffectData.NativeMethodInfoPtr_RunHitEvent_Public_Virtual_New_Boolean_Hit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673542);
    StatusEffectData.NativeMethodInfoPtr_RunPostHitEvent_Public_Virtual_New_Boolean_Hit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673543);
    StatusEffectData.NativeMethodInfoPtr_RunPostAttackEvent_Public_Virtual_New_Boolean_Hit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673544);
    StatusEffectData.NativeMethodInfoPtr_RunApplyStatusEvent_Public_Virtual_New_Boolean_StatusEffectApply_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673545);
    StatusEffectData.NativeMethodInfoPtr_RunPostApplyStatusEvent_Public_Virtual_New_Boolean_StatusEffectApply_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673546);
    StatusEffectData.NativeMethodInfoPtr_RunEntityDestroyedEvent_Public_Virtual_New_Boolean_Entity_DeathType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673547);
    StatusEffectData.NativeMethodInfoPtr_RunCardMoveEvent_Public_Virtual_New_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673548);
    StatusEffectData.NativeMethodInfoPtr_RunPreTriggerEvent_Public_Virtual_New_Boolean_Trigger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673549);
    StatusEffectData.NativeMethodInfoPtr_RunPreCardPlayedEvent_Public_Virtual_New_Boolean_Entity_Il2CppReferenceArray_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673550);
    StatusEffectData.NativeMethodInfoPtr_RunCardPlayedEvent_Public_Virtual_New_Boolean_Entity_Il2CppReferenceArray_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673551);
    StatusEffectData.NativeMethodInfoPtr_RunEffectBonusChangedEvent_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673552);
    StatusEffectData.NativeMethodInfoPtr_RunActionPerformedEvent_Public_Virtual_New_Boolean_PlayAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673553);
    StatusEffectData.NativeMethodInfoPtr_RunBuildEvent_Public_Virtual_New_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673554);
    StatusEffectData.NativeMethodInfoPtr_get_HasActiveTarget_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673555);
    StatusEffectData.NativeMethodInfoPtr_BeginRoutine_Public_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673556);
    StatusEffectData.NativeMethodInfoPtr_EndRoutine_Public_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673557);
    StatusEffectData.NativeMethodInfoPtr_EnableRoutine_Public_Virtual_New_IEnumerator_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673558);
    StatusEffectData.NativeMethodInfoPtr_DisableRoutine_Public_Virtual_New_IEnumerator_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673559);
    StatusEffectData.NativeMethodInfoPtr_StackRoutine_Public_Virtual_New_IEnumerator_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673560);
    StatusEffectData.NativeMethodInfoPtr_TurnStartRoutine_Public_Virtual_New_IEnumerator_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673561);
    StatusEffectData.NativeMethodInfoPtr_TurnRoutine_Public_Virtual_New_IEnumerator_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673562);
    StatusEffectData.NativeMethodInfoPtr_TurnEndRoutine_Public_Virtual_New_IEnumerator_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673563);
    StatusEffectData.NativeMethodInfoPtr_PreAttackRoutine_Public_Virtual_New_IEnumerator_Hit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673564);
    StatusEffectData.NativeMethodInfoPtr_HitRoutine_Public_Virtual_New_IEnumerator_Hit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673565);
    StatusEffectData.NativeMethodInfoPtr_PostHitRoutine_Public_Virtual_New_IEnumerator_Hit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673566);
    StatusEffectData.NativeMethodInfoPtr_PostAttackRoutine_Public_Virtual_New_IEnumerator_Hit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673567);
    StatusEffectData.NativeMethodInfoPtr_ApplyStatusRoutine_Public_Virtual_New_IEnumerator_StatusEffectApply_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673568);
    StatusEffectData.NativeMethodInfoPtr_PostApplyStatusRoutine_Public_Virtual_New_IEnumerator_StatusEffectApply_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673569);
    StatusEffectData.NativeMethodInfoPtr_EntityDestroyedRoutine_Public_Virtual_New_IEnumerator_Entity_DeathType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673570);
    StatusEffectData.NativeMethodInfoPtr_CardMoveRoutine_Public_Virtual_New_IEnumerator_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673571);
    StatusEffectData.NativeMethodInfoPtr_PreTriggerRoutine_Public_Virtual_New_IEnumerator_Trigger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673572);
    StatusEffectData.NativeMethodInfoPtr_PreCardPlayedRoutine_Public_Virtual_New_IEnumerator_Entity_Il2CppReferenceArray_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673573);
    StatusEffectData.NativeMethodInfoPtr_CardPlayedRoutine_Public_Virtual_New_IEnumerator_Entity_Il2CppReferenceArray_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673574);
    StatusEffectData.NativeMethodInfoPtr_EffectBonusChangedRoutine_Public_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673575);
    StatusEffectData.NativeMethodInfoPtr_ActionPerformedRoutine_Public_Virtual_New_IEnumerator_PlayAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673576);
    StatusEffectData.NativeMethodInfoPtr_BuildRoutine_Public_Virtual_New_IEnumerator_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673577);
    StatusEffectData.NativeMethodInfoPtr_Apply_Public_Void_Int32_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673578);
    StatusEffectData.NativeMethodInfoPtr_Init_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673579);
    StatusEffectData.NativeMethodInfoPtr_CountDown_Protected_IEnumerator_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673580);
    StatusEffectData.NativeMethodInfoPtr_RemoveStacks_Public_Virtual_New_IEnumerator_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673581);
    StatusEffectData.NativeMethodInfoPtr_Remove_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673582);
    StatusEffectData.NativeMethodInfoPtr_Destroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673583);
    StatusEffectData.NativeMethodInfoPtr_GetAmount_Protected_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673584);
    StatusEffectData.NativeMethodInfoPtr_GetDamager_Protected_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673585);
    StatusEffectData.NativeMethodInfoPtr_GetTargetContainers_Protected_Il2CppReferenceArray_1_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673586);
    StatusEffectData.NativeMethodInfoPtr_GetTargetActualContainers_Protected_Il2CppReferenceArray_1_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673587);
    StatusEffectData.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, 100673588);
  }

  public StatusEffectData(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe ulong idCurrent
  {
    get
    {
      ulong idCurrent;
      IL2CPP.il2cpp_field_static_get_value(StatusEffectData.NativeFieldInfoPtr_idCurrent, (void*) &idCurrent);
      return idCurrent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(StatusEffectData.NativeFieldInfoPtr_idCurrent, (void*) &value);
    }
  }

  public unsafe ulong id
  {
    get
    {
      return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_id));
    }
    [param: In] set
    {
      *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_id)) = value;
    }
  }

  public unsafe StatusEffectData original
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_original));
      return pointer == System.IntPtr.Zero ? (StatusEffectData) null : new StatusEffectData(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_original), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool isClone
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_isClone));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_isClone)) = value;
    }
  }

  public unsafe bool isStatus
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_isStatus));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_isStatus)) = value;
    }
  }

  public unsafe bool isReaction
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_isReaction));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_isReaction)) = value;
    }
  }

  public unsafe bool isKeyword
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_isKeyword));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_isKeyword)) = value;
    }
  }

  public unsafe string type
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_type)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_type), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string keyword
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_keyword)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_keyword), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string iconGroupName
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_iconGroupName)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_iconGroupName), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe bool visible
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_visible));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_visible)) = value;
    }
  }

  public unsafe bool stackable
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_stackable));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_stackable)) = value;
    }
  }

  public unsafe bool offensive
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_offensive));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_offensive)) = value;
    }
  }

  public unsafe bool makesOffensive
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_makesOffensive));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_makesOffensive)) = value;
    }
  }

  public unsafe bool doesDamage
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_doesDamage));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_doesDamage)) = value;
    }
  }

  public unsafe bool canBeBoosted
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_canBeBoosted));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_canBeBoosted)) = value;
    }
  }

  public unsafe LocalizedString textKey
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_textKey));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_textKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string textInsert
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_textInsert)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_textInsert), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe int textOrder
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_textOrder));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_textOrder)) = value;
    }
  }

  public unsafe string desc
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_desc)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_desc), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string descColorHex
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_descColorHex)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_descColorHex), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe int descOrder
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_descOrder));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_descOrder)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<KeywordData> hiddenKeywords
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_hiddenKeywords));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<KeywordData>) null : new Il2CppReferenceArray<KeywordData>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_hiddenKeywords), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string applyFormat
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_applyFormat)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_applyFormat), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe LocalizedString applyFormatKey
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_applyFormatKey));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_applyFormatKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool affectedBySnow
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_affectedBySnow));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_affectedBySnow)) = value;
    }
  }

  public unsafe int eventPriority
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_eventPriority));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_eventPriority)) = value;
    }
  }

  public unsafe bool removeOnDiscard
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_removeOnDiscard));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_removeOnDiscard)) = value;
    }
  }

  public unsafe bool preventDeath
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_preventDeath));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_preventDeath)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<TargetConstraint> targetConstraints
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_targetConstraints));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<TargetConstraint>) null : new Il2CppReferenceArray<TargetConstraint>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_targetConstraints), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool removing
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_removing));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_removing)) = value;
    }
  }

  public unsafe int temporary
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_temporary));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_temporary)) = value;
    }
  }

  public unsafe StatusEffectData.EffectEventHandler OnBegin
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_OnBegin));
      return pointer == System.IntPtr.Zero ? (StatusEffectData.EffectEventHandler) null : new StatusEffectData.EffectEventHandler(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_OnBegin), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StatusEffectData.EffectEventHandler OnEnd
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_OnEnd));
      return pointer == System.IntPtr.Zero ? (StatusEffectData.EffectEventHandler) null : new StatusEffectData.EffectEventHandler(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_OnEnd), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StatusEffectData.EffectEntityEventHandler OnEnable
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_OnEnable));
      return pointer == System.IntPtr.Zero ? (StatusEffectData.EffectEntityEventHandler) null : new StatusEffectData.EffectEntityEventHandler(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_OnEnable), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StatusEffectData.EffectEntityEventHandler OnDisable
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_OnDisable));
      return pointer == System.IntPtr.Zero ? (StatusEffectData.EffectEntityEventHandler) null : new StatusEffectData.EffectEntityEventHandler(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_OnDisable), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StatusEffectData.EffectStackEventHandler OnStack
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_OnStack));
      return pointer == System.IntPtr.Zero ? (StatusEffectData.EffectStackEventHandler) null : new StatusEffectData.EffectStackEventHandler(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_OnStack), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StatusEffectData.EffectEntityEventHandler OnTurnStart
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_OnTurnStart));
      return pointer == System.IntPtr.Zero ? (StatusEffectData.EffectEntityEventHandler) null : new StatusEffectData.EffectEntityEventHandler(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_OnTurnStart), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StatusEffectData.EffectEntityEventHandler OnTurn
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_OnTurn));
      return pointer == System.IntPtr.Zero ? (StatusEffectData.EffectEntityEventHandler) null : new StatusEffectData.EffectEntityEventHandler(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_OnTurn), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StatusEffectData.EffectEntityEventHandler OnTurnEnd
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_OnTurnEnd));
      return pointer == System.IntPtr.Zero ? (StatusEffectData.EffectEntityEventHandler) null : new StatusEffectData.EffectEntityEventHandler(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_OnTurnEnd), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StatusEffectData.EffectHitEventHandler PreAttack
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_PreAttack));
      return pointer == System.IntPtr.Zero ? (StatusEffectData.EffectHitEventHandler) null : new StatusEffectData.EffectHitEventHandler(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_PreAttack), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StatusEffectData.EffectHitEventHandler OnHit
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_OnHit));
      return pointer == System.IntPtr.Zero ? (StatusEffectData.EffectHitEventHandler) null : new StatusEffectData.EffectHitEventHandler(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_OnHit), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StatusEffectData.EffectHitEventHandler PostHit
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_PostHit));
      return pointer == System.IntPtr.Zero ? (StatusEffectData.EffectHitEventHandler) null : new StatusEffectData.EffectHitEventHandler(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_PostHit), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StatusEffectData.EffectHitEventHandler PostAttack
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_PostAttack));
      return pointer == System.IntPtr.Zero ? (StatusEffectData.EffectHitEventHandler) null : new StatusEffectData.EffectHitEventHandler(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_PostAttack), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StatusEffectData.EffectApplyEventHandler OnApplyStatus
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_OnApplyStatus));
      return pointer == System.IntPtr.Zero ? (StatusEffectData.EffectApplyEventHandler) null : new StatusEffectData.EffectApplyEventHandler(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_OnApplyStatus), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StatusEffectData.EffectApplyEventHandler PostApplyStatus
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_PostApplyStatus));
      return pointer == System.IntPtr.Zero ? (StatusEffectData.EffectApplyEventHandler) null : new StatusEffectData.EffectApplyEventHandler(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_PostApplyStatus), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StatusEffectData.EffectEntityDeathEventHandler OnEntityDestroyed
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_OnEntityDestroyed));
      return pointer == System.IntPtr.Zero ? (StatusEffectData.EffectEntityDeathEventHandler) null : new StatusEffectData.EffectEntityDeathEventHandler(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_OnEntityDestroyed), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StatusEffectData.EffectEntityEventHandler OnCardMove
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_OnCardMove));
      return pointer == System.IntPtr.Zero ? (StatusEffectData.EffectEntityEventHandler) null : new StatusEffectData.EffectEntityEventHandler(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_OnCardMove), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StatusEffectData.EffectTriggerEventHandler PreTrigger
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_PreTrigger));
      return pointer == System.IntPtr.Zero ? (StatusEffectData.EffectTriggerEventHandler) null : new StatusEffectData.EffectTriggerEventHandler(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_PreTrigger), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StatusEffectData.EffectCardPlayEventHandler PreCardPlayed
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_PreCardPlayed));
      return pointer == System.IntPtr.Zero ? (StatusEffectData.EffectCardPlayEventHandler) null : new StatusEffectData.EffectCardPlayEventHandler(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_PreCardPlayed), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StatusEffectData.EffectCardPlayEventHandler OnCardPlayed
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_OnCardPlayed));
      return pointer == System.IntPtr.Zero ? (StatusEffectData.EffectCardPlayEventHandler) null : new StatusEffectData.EffectCardPlayEventHandler(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_OnCardPlayed), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StatusEffectData.EffectEventHandler OnEffectBonusChanged
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_OnEffectBonusChanged));
      return pointer == System.IntPtr.Zero ? (StatusEffectData.EffectEventHandler) null : new StatusEffectData.EffectEventHandler(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_OnEffectBonusChanged), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StatusEffectData.EffectActionPerformedHandler OnActionPerformed
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_OnActionPerformed));
      return pointer == System.IntPtr.Zero ? (StatusEffectData.EffectActionPerformedHandler) null : new StatusEffectData.EffectActionPerformedHandler(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_OnActionPerformed), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StatusEffectData.EffectEntityEventHandler OnBuild
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_OnBuild));
      return pointer == System.IntPtr.Zero ? (StatusEffectData.EffectEntityEventHandler) null : new StatusEffectData.EffectEntityEventHandler(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_OnBuild), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Entity applier
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_applier));
      return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_applier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Character applierOwner
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_applierOwner));
      return pointer == System.IntPtr.Zero ? (Character) null : new Character(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_applierOwner), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Entity target
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_target));
      return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int count
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_count));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData.NativeFieldInfoPtr_count)) = value;
    }
  }

  public sealed class EffectEventHandler : Il2CppSystem.MulticastDelegate
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerator_IAsyncResult_0;

    [CallerCount(136)]
    [CachedScanResults(RefRangeStart = 66997, RefRangeEnd = 67133, XrefRangeStart = 66997, XrefRangeEnd = 67133, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EffectEventHandler(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusEffectData.EffectEventHandler>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatusEffectData.EffectEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe IEnumerator Invoke()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectData.EffectEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 67134, RefRangeEnd = 67135, XrefRangeStart = 67134, XrefRangeEnd = 67135, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
      Il2CppSystem.AsyncCallback callback,
      Il2CppSystem.Object @object)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectData.EffectEventHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 67136, RefRangeEnd = 67137, XrefRangeStart = 67136, XrefRangeEnd = 67137, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe IEnumerator EndInvoke(Il2CppSystem.IAsyncResult result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectData.EffectEventHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerator_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
    }

    static EffectEventHandler()
    {
      Il2CppClassPointerStore<StatusEffectData.EffectEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (EffectEventHandler));
      StatusEffectData.EffectEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData.EffectEventHandler>.NativeClassPtr, 100673589);
      StatusEffectData.EffectEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData.EffectEventHandler>.NativeClassPtr, 100673590);
      StatusEffectData.EffectEventHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData.EffectEventHandler>.NativeClassPtr, 100673591);
      StatusEffectData.EffectEventHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerator_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData.EffectEventHandler>.NativeClassPtr, 100673592);
    }

    public EffectEventHandler(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static implicit operator StatusEffectData.EffectEventHandler([In] System.Func<IEnumerator> obj0)
    {
      return DelegateSupport.ConvertDelegate<StatusEffectData.EffectEventHandler>((System.Delegate) obj0);
    }

    public static StatusEffectData.EffectEventHandler operator +(
      [In] StatusEffectData.EffectEventHandler obj0,
      [In] StatusEffectData.EffectEventHandler obj1)
    {
      return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<StatusEffectData.EffectEventHandler>();
    }

    public static StatusEffectData.EffectEventHandler operator -(
      [In] StatusEffectData.EffectEventHandler obj0,
      [In] StatusEffectData.EffectEventHandler obj1)
    {
      Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
      return (object) @delegate == null ? (StatusEffectData.EffectEventHandler) @delegate : @delegate.Cast<StatusEffectData.EffectEventHandler>();
    }
  }

  public sealed class EffectStackEventHandler : Il2CppSystem.MulticastDelegate
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerator_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_AsyncCallback_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerator_IAsyncResult_0;

    [CallerCount(17)]
    [CachedScanResults(RefRangeStart = 109890, RefRangeEnd = 109907, XrefRangeStart = 109884, XrefRangeEnd = 109890, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EffectStackEventHandler(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusEffectData.EffectStackEventHandler>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatusEffectData.EffectStackEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe IEnumerator Invoke(int stacks)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &stacks
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectData.EffectStackEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerator_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109907, XrefRangeEnd = 109911, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
      int stacks,
      Il2CppSystem.AsyncCallback callback,
      Il2CppSystem.Object @object)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &stacks;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectData.EffectStackEventHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 67136, RefRangeEnd = 67137, XrefRangeStart = 67136, XrefRangeEnd = 67137, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe IEnumerator EndInvoke(Il2CppSystem.IAsyncResult result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectData.EffectStackEventHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerator_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
    }

    static EffectStackEventHandler()
    {
      Il2CppClassPointerStore<StatusEffectData.EffectStackEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (EffectStackEventHandler));
      StatusEffectData.EffectStackEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData.EffectStackEventHandler>.NativeClassPtr, 100673593);
      StatusEffectData.EffectStackEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerator_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData.EffectStackEventHandler>.NativeClassPtr, 100673594);
      StatusEffectData.EffectStackEventHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData.EffectStackEventHandler>.NativeClassPtr, 100673595);
      StatusEffectData.EffectStackEventHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerator_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData.EffectStackEventHandler>.NativeClassPtr, 100673596);
    }

    public EffectStackEventHandler(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static implicit operator StatusEffectData.EffectStackEventHandler(
      [In] System.Func<int, IEnumerator> obj0)
    {
      return DelegateSupport.ConvertDelegate<StatusEffectData.EffectStackEventHandler>((System.Delegate) obj0);
    }

    public static StatusEffectData.EffectStackEventHandler operator +(
      [In] StatusEffectData.EffectStackEventHandler obj0,
      [In] StatusEffectData.EffectStackEventHandler obj1)
    {
      return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<StatusEffectData.EffectStackEventHandler>();
    }

    public static StatusEffectData.EffectStackEventHandler operator -(
      [In] StatusEffectData.EffectStackEventHandler obj0,
      [In] StatusEffectData.EffectStackEventHandler obj1)
    {
      Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
      return (object) @delegate == null ? (StatusEffectData.EffectStackEventHandler) @delegate : @delegate.Cast<StatusEffectData.EffectStackEventHandler>();
    }
  }

  public sealed class EffectCharacterEventHandler : Il2CppSystem.MulticastDelegate
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerator_Character_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Character_AsyncCallback_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerator_IAsyncResult_0;

    [CallerCount(247)]
    [CachedScanResults(RefRangeStart = 109923, RefRangeEnd = 110170, XrefRangeStart = 109911, XrefRangeEnd = 109923, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EffectCharacterEventHandler(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusEffectData.EffectCharacterEventHandler>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatusEffectData.EffectCharacterEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe IEnumerator Invoke(Character character)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) character)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectData.EffectCharacterEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerator_Character_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 74759, RefRangeEnd = 74762, XrefRangeStart = 74759, XrefRangeEnd = 74762, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
      Character character,
      Il2CppSystem.AsyncCallback callback,
      Il2CppSystem.Object @object)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) character);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectData.EffectCharacterEventHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Character_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 67136, RefRangeEnd = 67137, XrefRangeStart = 67136, XrefRangeEnd = 67137, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe IEnumerator EndInvoke(Il2CppSystem.IAsyncResult result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectData.EffectCharacterEventHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerator_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
    }

    static EffectCharacterEventHandler()
    {
      Il2CppClassPointerStore<StatusEffectData.EffectCharacterEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (EffectCharacterEventHandler));
      StatusEffectData.EffectCharacterEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData.EffectCharacterEventHandler>.NativeClassPtr, 100673597);
      StatusEffectData.EffectCharacterEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerator_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData.EffectCharacterEventHandler>.NativeClassPtr, 100673598);
      StatusEffectData.EffectCharacterEventHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Character_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData.EffectCharacterEventHandler>.NativeClassPtr, 100673599);
      StatusEffectData.EffectCharacterEventHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerator_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData.EffectCharacterEventHandler>.NativeClassPtr, 100673600);
    }

    public EffectCharacterEventHandler(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static implicit operator StatusEffectData.EffectCharacterEventHandler(
      [In] System.Func<Character, IEnumerator> obj0)
    {
      return DelegateSupport.ConvertDelegate<StatusEffectData.EffectCharacterEventHandler>((System.Delegate) obj0);
    }

    public static StatusEffectData.EffectCharacterEventHandler operator +(
      [In] StatusEffectData.EffectCharacterEventHandler obj0,
      [In] StatusEffectData.EffectCharacterEventHandler obj1)
    {
      return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<StatusEffectData.EffectCharacterEventHandler>();
    }

    public static StatusEffectData.EffectCharacterEventHandler operator -(
      [In] StatusEffectData.EffectCharacterEventHandler obj0,
      [In] StatusEffectData.EffectCharacterEventHandler obj1)
    {
      Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
      return (object) @delegate == null ? (StatusEffectData.EffectCharacterEventHandler) @delegate : @delegate.Cast<StatusEffectData.EffectCharacterEventHandler>();
    }
  }

  public sealed class EffectEntityEventHandler : Il2CppSystem.MulticastDelegate
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerator_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Entity_AsyncCallback_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerator_IAsyncResult_0;

    [CallerCount(247)]
    [CachedScanResults(RefRangeStart = 109923, RefRangeEnd = 110170, XrefRangeStart = 109923, XrefRangeEnd = 110170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EffectEntityEventHandler(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusEffectData.EffectEntityEventHandler>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatusEffectData.EffectEntityEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe IEnumerator Invoke(Entity entity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectData.EffectEntityEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerator_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 74759, RefRangeEnd = 74762, XrefRangeStart = 74759, XrefRangeEnd = 74762, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
      Entity entity,
      Il2CppSystem.AsyncCallback callback,
      Il2CppSystem.Object @object)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectData.EffectEntityEventHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Entity_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 67136, RefRangeEnd = 67137, XrefRangeStart = 67136, XrefRangeEnd = 67137, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe IEnumerator EndInvoke(Il2CppSystem.IAsyncResult result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectData.EffectEntityEventHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerator_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
    }

    static EffectEntityEventHandler()
    {
      Il2CppClassPointerStore<StatusEffectData.EffectEntityEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (EffectEntityEventHandler));
      StatusEffectData.EffectEntityEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData.EffectEntityEventHandler>.NativeClassPtr, 100673601);
      StatusEffectData.EffectEntityEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerator_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData.EffectEntityEventHandler>.NativeClassPtr, 100673602);
      StatusEffectData.EffectEntityEventHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Entity_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData.EffectEntityEventHandler>.NativeClassPtr, 100673603);
      StatusEffectData.EffectEntityEventHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerator_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData.EffectEntityEventHandler>.NativeClassPtr, 100673604);
    }

    public EffectEntityEventHandler(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static implicit operator StatusEffectData.EffectEntityEventHandler(
      [In] System.Func<Entity, IEnumerator> obj0)
    {
      return DelegateSupport.ConvertDelegate<StatusEffectData.EffectEntityEventHandler>((System.Delegate) obj0);
    }

    public static StatusEffectData.EffectEntityEventHandler operator +(
      [In] StatusEffectData.EffectEntityEventHandler obj0,
      [In] StatusEffectData.EffectEntityEventHandler obj1)
    {
      return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<StatusEffectData.EffectEntityEventHandler>();
    }

    public static StatusEffectData.EffectEntityEventHandler operator -(
      [In] StatusEffectData.EffectEntityEventHandler obj0,
      [In] StatusEffectData.EffectEntityEventHandler obj1)
    {
      Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
      return (object) @delegate == null ? (StatusEffectData.EffectEntityEventHandler) @delegate : @delegate.Cast<StatusEffectData.EffectEntityEventHandler>();
    }
  }

  public sealed class EffectEntityDeathEventHandler : Il2CppSystem.MulticastDelegate
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerator_Entity_DeathType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Entity_DeathType_AsyncCallback_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerator_IAsyncResult_0;

    [CallerCount(10)]
    [CachedScanResults(RefRangeStart = 110182, RefRangeEnd = 110192, XrefRangeStart = 110170, XrefRangeEnd = 110182, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EffectEntityDeathEventHandler(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusEffectData.EffectEntityDeathEventHandler>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatusEffectData.EffectEntityDeathEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe IEnumerator Invoke(Entity entity, DeathType deathType)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &deathType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectData.EffectEntityDeathEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerator_Entity_DeathType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110192, XrefRangeEnd = 110196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
      Entity entity,
      DeathType deathType,
      Il2CppSystem.AsyncCallback callback,
      Il2CppSystem.Object @object)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &deathType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectData.EffectEntityDeathEventHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Entity_DeathType_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 67136, RefRangeEnd = 67137, XrefRangeStart = 67136, XrefRangeEnd = 67137, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe IEnumerator EndInvoke(Il2CppSystem.IAsyncResult result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectData.EffectEntityDeathEventHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerator_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
    }

    static EffectEntityDeathEventHandler()
    {
      Il2CppClassPointerStore<StatusEffectData.EffectEntityDeathEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (EffectEntityDeathEventHandler));
      StatusEffectData.EffectEntityDeathEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData.EffectEntityDeathEventHandler>.NativeClassPtr, 100673605);
      StatusEffectData.EffectEntityDeathEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerator_Entity_DeathType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData.EffectEntityDeathEventHandler>.NativeClassPtr, 100673606);
      StatusEffectData.EffectEntityDeathEventHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Entity_DeathType_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData.EffectEntityDeathEventHandler>.NativeClassPtr, 100673607);
      StatusEffectData.EffectEntityDeathEventHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerator_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData.EffectEntityDeathEventHandler>.NativeClassPtr, 100673608);
    }

    public EffectEntityDeathEventHandler(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static implicit operator StatusEffectData.EffectEntityDeathEventHandler(
      [In] System.Func<Entity, DeathType> obj0)
    {
      return DelegateSupport.ConvertDelegate<StatusEffectData.EffectEntityDeathEventHandler>((System.Delegate) obj0);
    }

    public static StatusEffectData.EffectEntityDeathEventHandler operator +(
      [In] StatusEffectData.EffectEntityDeathEventHandler obj0,
      [In] StatusEffectData.EffectEntityDeathEventHandler obj1)
    {
      return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<StatusEffectData.EffectEntityDeathEventHandler>();
    }

    public static StatusEffectData.EffectEntityDeathEventHandler operator -(
      [In] StatusEffectData.EffectEntityDeathEventHandler obj0,
      [In] StatusEffectData.EffectEntityDeathEventHandler obj1)
    {
      Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
      return (object) @delegate == null ? (StatusEffectData.EffectEntityDeathEventHandler) @delegate : @delegate.Cast<StatusEffectData.EffectEntityDeathEventHandler>();
    }
  }

  public sealed class EffectCardPlayEventHandler : Il2CppSystem.MulticastDelegate
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerator_Entity_Il2CppReferenceArray_1_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Entity_Il2CppReferenceArray_1_Entity_AsyncCallback_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerator_IAsyncResult_0;

    [CallerCount(23)]
    [CachedScanResults(RefRangeStart = 110208, RefRangeEnd = 110231, XrefRangeStart = 110196, XrefRangeEnd = 110208, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EffectCardPlayEventHandler(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusEffectData.EffectCardPlayEventHandler>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatusEffectData.EffectCardPlayEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe IEnumerator Invoke(Entity entity, Il2CppReferenceArray<Entity> targets)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targets);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectData.EffectCardPlayEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerator_Entity_Il2CppReferenceArray_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110231, XrefRangeEnd = 110232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
      Entity entity,
      Il2CppReferenceArray<Entity> targets,
      Il2CppSystem.AsyncCallback callback,
      Il2CppSystem.Object @object)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targets);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectData.EffectCardPlayEventHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Entity_Il2CppReferenceArray_1_Entity_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 67136, RefRangeEnd = 67137, XrefRangeStart = 67136, XrefRangeEnd = 67137, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe IEnumerator EndInvoke(Il2CppSystem.IAsyncResult result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectData.EffectCardPlayEventHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerator_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
    }

    static EffectCardPlayEventHandler()
    {
      Il2CppClassPointerStore<StatusEffectData.EffectCardPlayEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (EffectCardPlayEventHandler));
      StatusEffectData.EffectCardPlayEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData.EffectCardPlayEventHandler>.NativeClassPtr, 100673609);
      StatusEffectData.EffectCardPlayEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerator_Entity_Il2CppReferenceArray_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData.EffectCardPlayEventHandler>.NativeClassPtr, 100673610);
      StatusEffectData.EffectCardPlayEventHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Entity_Il2CppReferenceArray_1_Entity_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData.EffectCardPlayEventHandler>.NativeClassPtr, 100673611);
      StatusEffectData.EffectCardPlayEventHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerator_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData.EffectCardPlayEventHandler>.NativeClassPtr, 100673612);
    }

    public EffectCardPlayEventHandler(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static implicit operator StatusEffectData.EffectCardPlayEventHandler(
      [In] System.Func<Entity, Il2CppReferenceArray<Entity>> obj0)
    {
      return DelegateSupport.ConvertDelegate<StatusEffectData.EffectCardPlayEventHandler>((System.Delegate) obj0);
    }

    public static StatusEffectData.EffectCardPlayEventHandler operator +(
      [In] StatusEffectData.EffectCardPlayEventHandler obj0,
      [In] StatusEffectData.EffectCardPlayEventHandler obj1)
    {
      return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<StatusEffectData.EffectCardPlayEventHandler>();
    }

    public static StatusEffectData.EffectCardPlayEventHandler operator -(
      [In] StatusEffectData.EffectCardPlayEventHandler obj0,
      [In] StatusEffectData.EffectCardPlayEventHandler obj1)
    {
      Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
      return (object) @delegate == null ? (StatusEffectData.EffectCardPlayEventHandler) @delegate : @delegate.Cast<StatusEffectData.EffectCardPlayEventHandler>();
    }
  }

  public sealed class EffectTriggerEventHandler : Il2CppSystem.MulticastDelegate
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerator_Trigger_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Trigger_AsyncCallback_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerator_IAsyncResult_0;

    [CallerCount(247)]
    [CachedScanResults(RefRangeStart = 109923, RefRangeEnd = 110170, XrefRangeStart = 109923, XrefRangeEnd = 110170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EffectTriggerEventHandler(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusEffectData.EffectTriggerEventHandler>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatusEffectData.EffectTriggerEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe IEnumerator Invoke(Trigger trigger)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) trigger)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectData.EffectTriggerEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerator_Trigger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 74759, RefRangeEnd = 74762, XrefRangeStart = 74759, XrefRangeEnd = 74762, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
      Trigger trigger,
      Il2CppSystem.AsyncCallback callback,
      Il2CppSystem.Object @object)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) trigger);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectData.EffectTriggerEventHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Trigger_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 67136, RefRangeEnd = 67137, XrefRangeStart = 67136, XrefRangeEnd = 67137, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe IEnumerator EndInvoke(Il2CppSystem.IAsyncResult result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectData.EffectTriggerEventHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerator_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
    }

    static EffectTriggerEventHandler()
    {
      Il2CppClassPointerStore<StatusEffectData.EffectTriggerEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (EffectTriggerEventHandler));
      StatusEffectData.EffectTriggerEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData.EffectTriggerEventHandler>.NativeClassPtr, 100673613);
      StatusEffectData.EffectTriggerEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerator_Trigger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData.EffectTriggerEventHandler>.NativeClassPtr, 100673614);
      StatusEffectData.EffectTriggerEventHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Trigger_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData.EffectTriggerEventHandler>.NativeClassPtr, 100673615);
      StatusEffectData.EffectTriggerEventHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerator_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData.EffectTriggerEventHandler>.NativeClassPtr, 100673616);
    }

    public EffectTriggerEventHandler(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static implicit operator StatusEffectData.EffectTriggerEventHandler(
      [In] System.Func<Trigger, IEnumerator> obj0)
    {
      return DelegateSupport.ConvertDelegate<StatusEffectData.EffectTriggerEventHandler>((System.Delegate) obj0);
    }

    public static StatusEffectData.EffectTriggerEventHandler operator +(
      [In] StatusEffectData.EffectTriggerEventHandler obj0,
      [In] StatusEffectData.EffectTriggerEventHandler obj1)
    {
      return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<StatusEffectData.EffectTriggerEventHandler>();
    }

    public static StatusEffectData.EffectTriggerEventHandler operator -(
      [In] StatusEffectData.EffectTriggerEventHandler obj0,
      [In] StatusEffectData.EffectTriggerEventHandler obj1)
    {
      Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
      return (object) @delegate == null ? (StatusEffectData.EffectTriggerEventHandler) @delegate : @delegate.Cast<StatusEffectData.EffectTriggerEventHandler>();
    }
  }

  public sealed class EffectCardMoveEventHandler : Il2CppSystem.MulticastDelegate
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerator_Entity_Il2CppReferenceArray_1_CardContainer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Entity_Il2CppReferenceArray_1_CardContainer_AsyncCallback_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerator_IAsyncResult_0;

    [CallerCount(23)]
    [CachedScanResults(RefRangeStart = 110208, RefRangeEnd = 110231, XrefRangeStart = 110208, XrefRangeEnd = 110231, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EffectCardMoveEventHandler(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusEffectData.EffectCardMoveEventHandler>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatusEffectData.EffectCardMoveEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe IEnumerator Invoke(
      Entity entity,
      Il2CppReferenceArray<CardContainer> fromContainers)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) fromContainers);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectData.EffectCardMoveEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerator_Entity_Il2CppReferenceArray_1_CardContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
      Entity entity,
      Il2CppReferenceArray<CardContainer> fromContainers,
      Il2CppSystem.AsyncCallback callback,
      Il2CppSystem.Object @object)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) fromContainers);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectData.EffectCardMoveEventHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Entity_Il2CppReferenceArray_1_CardContainer_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 67136, RefRangeEnd = 67137, XrefRangeStart = 67136, XrefRangeEnd = 67137, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe IEnumerator EndInvoke(Il2CppSystem.IAsyncResult result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectData.EffectCardMoveEventHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerator_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
    }

    static EffectCardMoveEventHandler()
    {
      Il2CppClassPointerStore<StatusEffectData.EffectCardMoveEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (EffectCardMoveEventHandler));
      StatusEffectData.EffectCardMoveEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData.EffectCardMoveEventHandler>.NativeClassPtr, 100673617);
      StatusEffectData.EffectCardMoveEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerator_Entity_Il2CppReferenceArray_1_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData.EffectCardMoveEventHandler>.NativeClassPtr, 100673618);
      StatusEffectData.EffectCardMoveEventHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Entity_Il2CppReferenceArray_1_CardContainer_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData.EffectCardMoveEventHandler>.NativeClassPtr, 100673619);
      StatusEffectData.EffectCardMoveEventHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerator_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData.EffectCardMoveEventHandler>.NativeClassPtr, 100673620);
    }

    public EffectCardMoveEventHandler(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static implicit operator StatusEffectData.EffectCardMoveEventHandler(
      [In] System.Func<Entity, Il2CppReferenceArray<CardContainer>> obj0)
    {
      return DelegateSupport.ConvertDelegate<StatusEffectData.EffectCardMoveEventHandler>((System.Delegate) obj0);
    }

    public static StatusEffectData.EffectCardMoveEventHandler operator +(
      [In] StatusEffectData.EffectCardMoveEventHandler obj0,
      [In] StatusEffectData.EffectCardMoveEventHandler obj1)
    {
      return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<StatusEffectData.EffectCardMoveEventHandler>();
    }

    public static StatusEffectData.EffectCardMoveEventHandler operator -(
      [In] StatusEffectData.EffectCardMoveEventHandler obj0,
      [In] StatusEffectData.EffectCardMoveEventHandler obj1)
    {
      Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
      return (object) @delegate == null ? (StatusEffectData.EffectCardMoveEventHandler) @delegate : @delegate.Cast<StatusEffectData.EffectCardMoveEventHandler>();
    }
  }

  public sealed class EffectHitEventHandler : Il2CppSystem.MulticastDelegate
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerator_Hit_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Hit_AsyncCallback_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerator_IAsyncResult_0;

    [CallerCount(247)]
    [CachedScanResults(RefRangeStart = 109923, RefRangeEnd = 110170, XrefRangeStart = 109923, XrefRangeEnd = 110170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EffectHitEventHandler(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusEffectData.EffectHitEventHandler>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatusEffectData.EffectHitEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe IEnumerator Invoke(Hit hit)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hit)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectData.EffectHitEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerator_Hit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 74759, RefRangeEnd = 74762, XrefRangeStart = 74759, XrefRangeEnd = 74762, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
      Hit hit,
      Il2CppSystem.AsyncCallback callback,
      Il2CppSystem.Object @object)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hit);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectData.EffectHitEventHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Hit_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 67136, RefRangeEnd = 67137, XrefRangeStart = 67136, XrefRangeEnd = 67137, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe IEnumerator EndInvoke(Il2CppSystem.IAsyncResult result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectData.EffectHitEventHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerator_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
    }

    static EffectHitEventHandler()
    {
      Il2CppClassPointerStore<StatusEffectData.EffectHitEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (EffectHitEventHandler));
      StatusEffectData.EffectHitEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData.EffectHitEventHandler>.NativeClassPtr, 100673621);
      StatusEffectData.EffectHitEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerator_Hit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData.EffectHitEventHandler>.NativeClassPtr, 100673622);
      StatusEffectData.EffectHitEventHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Hit_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData.EffectHitEventHandler>.NativeClassPtr, 100673623);
      StatusEffectData.EffectHitEventHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerator_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData.EffectHitEventHandler>.NativeClassPtr, 100673624);
    }

    public EffectHitEventHandler(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static implicit operator StatusEffectData.EffectHitEventHandler(
      [In] System.Func<Hit, IEnumerator> obj0)
    {
      return DelegateSupport.ConvertDelegate<StatusEffectData.EffectHitEventHandler>((System.Delegate) obj0);
    }

    public static StatusEffectData.EffectHitEventHandler operator +(
      [In] StatusEffectData.EffectHitEventHandler obj0,
      [In] StatusEffectData.EffectHitEventHandler obj1)
    {
      return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<StatusEffectData.EffectHitEventHandler>();
    }

    public static StatusEffectData.EffectHitEventHandler operator -(
      [In] StatusEffectData.EffectHitEventHandler obj0,
      [In] StatusEffectData.EffectHitEventHandler obj1)
    {
      Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
      return (object) @delegate == null ? (StatusEffectData.EffectHitEventHandler) @delegate : @delegate.Cast<StatusEffectData.EffectHitEventHandler>();
    }
  }

  public sealed class EffectApplyEventHandler : Il2CppSystem.MulticastDelegate
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerator_StatusEffectApply_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_StatusEffectApply_AsyncCallback_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerator_IAsyncResult_0;

    [CallerCount(247)]
    [CachedScanResults(RefRangeStart = 109923, RefRangeEnd = 110170, XrefRangeStart = 109923, XrefRangeEnd = 110170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EffectApplyEventHandler(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusEffectData.EffectApplyEventHandler>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatusEffectData.EffectApplyEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe IEnumerator Invoke(StatusEffectApply apply)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) apply)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectData.EffectApplyEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerator_StatusEffectApply_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 74759, RefRangeEnd = 74762, XrefRangeStart = 74759, XrefRangeEnd = 74762, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
      StatusEffectApply apply,
      Il2CppSystem.AsyncCallback callback,
      Il2CppSystem.Object @object)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) apply);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectData.EffectApplyEventHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_StatusEffectApply_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 67136, RefRangeEnd = 67137, XrefRangeStart = 67136, XrefRangeEnd = 67137, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe IEnumerator EndInvoke(Il2CppSystem.IAsyncResult result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectData.EffectApplyEventHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerator_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
    }

    static EffectApplyEventHandler()
    {
      Il2CppClassPointerStore<StatusEffectData.EffectApplyEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (EffectApplyEventHandler));
      StatusEffectData.EffectApplyEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData.EffectApplyEventHandler>.NativeClassPtr, 100673625);
      StatusEffectData.EffectApplyEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerator_StatusEffectApply_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData.EffectApplyEventHandler>.NativeClassPtr, 100673626);
      StatusEffectData.EffectApplyEventHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_StatusEffectApply_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData.EffectApplyEventHandler>.NativeClassPtr, 100673627);
      StatusEffectData.EffectApplyEventHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerator_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData.EffectApplyEventHandler>.NativeClassPtr, 100673628);
    }

    public EffectApplyEventHandler(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static implicit operator StatusEffectData.EffectApplyEventHandler(
      [In] System.Func<StatusEffectApply, IEnumerator> obj0)
    {
      return DelegateSupport.ConvertDelegate<StatusEffectData.EffectApplyEventHandler>((System.Delegate) obj0);
    }

    public static StatusEffectData.EffectApplyEventHandler operator +(
      [In] StatusEffectData.EffectApplyEventHandler obj0,
      [In] StatusEffectData.EffectApplyEventHandler obj1)
    {
      return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<StatusEffectData.EffectApplyEventHandler>();
    }

    public static StatusEffectData.EffectApplyEventHandler operator -(
      [In] StatusEffectData.EffectApplyEventHandler obj0,
      [In] StatusEffectData.EffectApplyEventHandler obj1)
    {
      Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
      return (object) @delegate == null ? (StatusEffectData.EffectApplyEventHandler) @delegate : @delegate.Cast<StatusEffectData.EffectApplyEventHandler>();
    }
  }

  public sealed class EffectActionPerformedHandler : Il2CppSystem.MulticastDelegate
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerator_PlayAction_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_PlayAction_AsyncCallback_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerator_IAsyncResult_0;

    [CallerCount(247)]
    [CachedScanResults(RefRangeStart = 109923, RefRangeEnd = 110170, XrefRangeStart = 109923, XrefRangeEnd = 110170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EffectActionPerformedHandler(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusEffectData.EffectActionPerformedHandler>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatusEffectData.EffectActionPerformedHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe IEnumerator Invoke(PlayAction action)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectData.EffectActionPerformedHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerator_PlayAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 74759, RefRangeEnd = 74762, XrefRangeStart = 74759, XrefRangeEnd = 74762, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
      PlayAction action,
      Il2CppSystem.AsyncCallback callback,
      Il2CppSystem.Object @object)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectData.EffectActionPerformedHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_PlayAction_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 67136, RefRangeEnd = 67137, XrefRangeStart = 67136, XrefRangeEnd = 67137, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe IEnumerator EndInvoke(Il2CppSystem.IAsyncResult result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectData.EffectActionPerformedHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerator_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
    }

    static EffectActionPerformedHandler()
    {
      Il2CppClassPointerStore<StatusEffectData.EffectActionPerformedHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, nameof (EffectActionPerformedHandler));
      StatusEffectData.EffectActionPerformedHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData.EffectActionPerformedHandler>.NativeClassPtr, 100673629);
      StatusEffectData.EffectActionPerformedHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerator_PlayAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData.EffectActionPerformedHandler>.NativeClassPtr, 100673630);
      StatusEffectData.EffectActionPerformedHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_PlayAction_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData.EffectActionPerformedHandler>.NativeClassPtr, 100673631);
      StatusEffectData.EffectActionPerformedHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerator_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData.EffectActionPerformedHandler>.NativeClassPtr, 100673632);
    }

    public EffectActionPerformedHandler(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static implicit operator StatusEffectData.EffectActionPerformedHandler(
      [In] System.Func<PlayAction, IEnumerator> obj0)
    {
      return DelegateSupport.ConvertDelegate<StatusEffectData.EffectActionPerformedHandler>((System.Delegate) obj0);
    }

    public static StatusEffectData.EffectActionPerformedHandler operator +(
      [In] StatusEffectData.EffectActionPerformedHandler obj0,
      [In] StatusEffectData.EffectActionPerformedHandler obj1)
    {
      return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<StatusEffectData.EffectActionPerformedHandler>();
    }

    public static StatusEffectData.EffectActionPerformedHandler operator -(
      [In] StatusEffectData.EffectActionPerformedHandler obj0,
      [In] StatusEffectData.EffectActionPerformedHandler obj1)
    {
      Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
      return (object) @delegate == null ? (StatusEffectData.EffectActionPerformedHandler) @delegate : @delegate.Cast<StatusEffectData.EffectActionPerformedHandler>();
    }
  }

  [ObfuscatedName("StatusEffectData/<CountDown>d__222")]
  public sealed class _CountDown_d__222 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_entity;
    private static readonly System.IntPtr NativeFieldInfoPtr_amount;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _CountDown_d__222(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusEffectData._CountDown_d__222>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatusEffectData._CountDown_d__222.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatusEffectData._CountDown_d__222.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110232, XrefRangeEnd = 110241, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectData._CountDown_d__222.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectData._CountDown_d__222.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110241, XrefRangeEnd = 110247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatusEffectData._CountDown_d__222.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectData._CountDown_d__222.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _CountDown_d__222()
    {
      Il2CppClassPointerStore<StatusEffectData._CountDown_d__222>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, "<CountDown>d__222");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusEffectData._CountDown_d__222>.NativeClassPtr);
      StatusEffectData._CountDown_d__222.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData._CountDown_d__222>.NativeClassPtr, "<>1__state");
      StatusEffectData._CountDown_d__222.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData._CountDown_d__222>.NativeClassPtr, "<>2__current");
      StatusEffectData._CountDown_d__222.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData._CountDown_d__222>.NativeClassPtr, "<>4__this");
      StatusEffectData._CountDown_d__222.NativeFieldInfoPtr_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData._CountDown_d__222>.NativeClassPtr, nameof (entity));
      StatusEffectData._CountDown_d__222.NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData._CountDown_d__222>.NativeClassPtr, nameof (amount));
      StatusEffectData._CountDown_d__222.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData._CountDown_d__222>.NativeClassPtr, 100673633);
      StatusEffectData._CountDown_d__222.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData._CountDown_d__222>.NativeClassPtr, 100673634);
      StatusEffectData._CountDown_d__222.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData._CountDown_d__222>.NativeClassPtr, 100673635);
      StatusEffectData._CountDown_d__222.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData._CountDown_d__222>.NativeClassPtr, 100673636);
      StatusEffectData._CountDown_d__222.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData._CountDown_d__222>.NativeClassPtr, 100673637);
      StatusEffectData._CountDown_d__222.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData._CountDown_d__222>.NativeClassPtr, 100673638);
    }

    public _CountDown_d__222(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData._CountDown_d__222.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData._CountDown_d__222.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData._CountDown_d__222.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData._CountDown_d__222.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe StatusEffectData __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData._CountDown_d__222.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (StatusEffectData) null : new StatusEffectData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData._CountDown_d__222.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Entity entity
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData._CountDown_d__222.NativeFieldInfoPtr_entity));
        return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData._CountDown_d__222.NativeFieldInfoPtr_entity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int amount
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData._CountDown_d__222.NativeFieldInfoPtr_amount));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData._CountDown_d__222.NativeFieldInfoPtr_amount)) = value;
      }
    }
  }

  [ObfuscatedName("StatusEffectData/<RemoveStacks>d__223")]
  public sealed class _RemoveStacks_d__223 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_amount;
    private static readonly System.IntPtr NativeFieldInfoPtr_removeTemporary;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _RemoveStacks_d__223(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusEffectData._RemoveStacks_d__223>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatusEffectData._RemoveStacks_d__223.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatusEffectData._RemoveStacks_d__223.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110247, XrefRangeEnd = 110253, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectData._RemoveStacks_d__223.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectData._RemoveStacks_d__223.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110253, XrefRangeEnd = 110259, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatusEffectData._RemoveStacks_d__223.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectData._RemoveStacks_d__223.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _RemoveStacks_d__223()
    {
      Il2CppClassPointerStore<StatusEffectData._RemoveStacks_d__223>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, "<RemoveStacks>d__223");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusEffectData._RemoveStacks_d__223>.NativeClassPtr);
      StatusEffectData._RemoveStacks_d__223.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData._RemoveStacks_d__223>.NativeClassPtr, "<>1__state");
      StatusEffectData._RemoveStacks_d__223.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData._RemoveStacks_d__223>.NativeClassPtr, "<>2__current");
      StatusEffectData._RemoveStacks_d__223.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData._RemoveStacks_d__223>.NativeClassPtr, "<>4__this");
      StatusEffectData._RemoveStacks_d__223.NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData._RemoveStacks_d__223>.NativeClassPtr, nameof (amount));
      StatusEffectData._RemoveStacks_d__223.NativeFieldInfoPtr_removeTemporary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData._RemoveStacks_d__223>.NativeClassPtr, nameof (removeTemporary));
      StatusEffectData._RemoveStacks_d__223.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData._RemoveStacks_d__223>.NativeClassPtr, 100673639);
      StatusEffectData._RemoveStacks_d__223.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData._RemoveStacks_d__223>.NativeClassPtr, 100673640);
      StatusEffectData._RemoveStacks_d__223.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData._RemoveStacks_d__223>.NativeClassPtr, 100673641);
      StatusEffectData._RemoveStacks_d__223.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData._RemoveStacks_d__223>.NativeClassPtr, 100673642);
      StatusEffectData._RemoveStacks_d__223.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData._RemoveStacks_d__223>.NativeClassPtr, 100673643);
      StatusEffectData._RemoveStacks_d__223.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData._RemoveStacks_d__223>.NativeClassPtr, 100673644);
    }

    public _RemoveStacks_d__223(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData._RemoveStacks_d__223.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData._RemoveStacks_d__223.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData._RemoveStacks_d__223.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData._RemoveStacks_d__223.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe StatusEffectData __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData._RemoveStacks_d__223.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (StatusEffectData) null : new StatusEffectData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData._RemoveStacks_d__223.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int amount
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData._RemoveStacks_d__223.NativeFieldInfoPtr_amount));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData._RemoveStacks_d__223.NativeFieldInfoPtr_amount)) = value;
      }
    }

    public unsafe bool removeTemporary
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData._RemoveStacks_d__223.NativeFieldInfoPtr_removeTemporary));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData._RemoveStacks_d__223.NativeFieldInfoPtr_removeTemporary)) = value;
      }
    }
  }

  [ObfuscatedName("StatusEffectData/<Remove>d__224")]
  public sealed class _Remove_d__224 : Il2CppSystem.Object
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
    public unsafe _Remove_d__224(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusEffectData._Remove_d__224>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatusEffectData._Remove_d__224.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatusEffectData._Remove_d__224.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110259, XrefRangeEnd = 110271, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectData._Remove_d__224.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectData._Remove_d__224.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110271, XrefRangeEnd = 110277, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatusEffectData._Remove_d__224.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectData._Remove_d__224.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _Remove_d__224()
    {
      Il2CppClassPointerStore<StatusEffectData._Remove_d__224>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatusEffectData>.NativeClassPtr, "<Remove>d__224");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusEffectData._Remove_d__224>.NativeClassPtr);
      StatusEffectData._Remove_d__224.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData._Remove_d__224>.NativeClassPtr, "<>1__state");
      StatusEffectData._Remove_d__224.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData._Remove_d__224>.NativeClassPtr, "<>2__current");
      StatusEffectData._Remove_d__224.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectData._Remove_d__224>.NativeClassPtr, "<>4__this");
      StatusEffectData._Remove_d__224.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData._Remove_d__224>.NativeClassPtr, 100673645);
      StatusEffectData._Remove_d__224.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData._Remove_d__224>.NativeClassPtr, 100673646);
      StatusEffectData._Remove_d__224.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData._Remove_d__224>.NativeClassPtr, 100673647);
      StatusEffectData._Remove_d__224.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData._Remove_d__224>.NativeClassPtr, 100673648);
      StatusEffectData._Remove_d__224.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData._Remove_d__224>.NativeClassPtr, 100673649);
      StatusEffectData._Remove_d__224.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectData._Remove_d__224>.NativeClassPtr, 100673650);
    }

    public _Remove_d__224(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData._Remove_d__224.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData._Remove_d__224.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData._Remove_d__224.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData._Remove_d__224.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe StatusEffectData __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData._Remove_d__224.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (StatusEffectData) null : new StatusEffectData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectData._Remove_d__224.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
