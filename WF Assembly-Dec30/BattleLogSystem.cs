// Decompiled with JetBrains decompiler
// Type: BattleLogSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine.Localization;

#nullable disable
public class BattleLogSystem : GameSystem
{
  private static readonly System.IntPtr NativeFieldInfoPtr_list;
  private static readonly System.IntPtr NativeFieldInfoPtr_damageTypes;
  private static readonly System.IntPtr NativeFieldInfoPtr_logTurnKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_logHitKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_logDamageKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_logSpecialDamageKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_logDestroyKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_logConsumedKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_logEatenKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_logSacrificedKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_logBlockKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_logStatusKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_logStatusFromKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_logHealKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_logRestoredKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_logBoostKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_logDamageUpKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_logDamageUpSelfKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_logDamageDownKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_logDamageDownSelfKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_logHealthUpKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_logHealthUpSelfKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_logHealthDownKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_logHealthDownSelfKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_logCounterUpKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_logCounterUpSelfKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_logCounterDownKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_logCounterDownSelfKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_logEnterBattleKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_logRecalledKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_logSummonedKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_logBattleWinKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_logBattleLoseKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_logFleeKey;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BattlePhaseStart_Private_Void_Phase_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TurnEnd_Private_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Hit_Private_Void_Hit_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntityMove_Private_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StatusApplied_Private_Void_StatusEffectApply_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PostHit_Private_Void_Hit_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntityKilled_Private_Void_Entity_DeathType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntityFlee_Private_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BattleEnd_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogHit_Private_Void_Entity_Entity_Int32_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogDamage_Private_Void_Entity_Int32_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogBlock_Private_Void_Entity_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogStatus_Private_Void_Entity_Entity_StatusEffectData_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogHeal_Private_Void_Entity_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogRestore_Private_Void_Entity_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogDamageUp_Private_Void_Entity_Entity_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogDamageDown_Private_Void_Entity_Entity_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogHealthUp_Private_Void_Entity_Entity_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogHealthDown_Private_Void_Entity_Entity_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogCounterUp_Private_Void_Entity_Entity_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogCounterDown_Private_Void_Entity_Entity_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Log_Private_Void_LocalizedString_BattleLogType_Il2CppReferenceArray_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetBattleEntity_Private_Static_BattleEntity_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55203, XrefRangeEnd = 55265, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleLogSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55265, XrefRangeEnd = 55327, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleLogSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55327, XrefRangeEnd = 55329, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BattlePhaseStart(Battle.Phase phase)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &phase
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleLogSystem.NativeMethodInfoPtr_BattlePhaseStart_Private_Void_Phase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55329, XrefRangeEnd = 55341, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void TurnEnd(int turnNumber)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &turnNumber
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleLogSystem.NativeMethodInfoPtr_TurnEnd_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55341, XrefRangeEnd = 55350, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Hit(global::Hit hit)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hit)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleLogSystem.NativeMethodInfoPtr_Hit_Private_Void_Hit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55350, XrefRangeEnd = 55366, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntityMove(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleLogSystem.NativeMethodInfoPtr_EntityMove_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55366, XrefRangeEnd = 55420, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StatusApplied(StatusEffectApply apply)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) apply)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleLogSystem.NativeMethodInfoPtr_StatusApplied_Private_Void_StatusEffectApply_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55420, XrefRangeEnd = 55438, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PostHit(global::Hit hit)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hit)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleLogSystem.NativeMethodInfoPtr_PostHit_Private_Void_Hit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55438, XrefRangeEnd = 55451, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntityKilled(Entity entity, DeathType deathType)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &deathType;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleLogSystem.NativeMethodInfoPtr_EntityKilled_Private_Void_Entity_DeathType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55451, XrefRangeEnd = 55464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntityFlee(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleLogSystem.NativeMethodInfoPtr_EntityFlee_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55464, XrefRangeEnd = 55475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BattleEnd()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleLogSystem.NativeMethodInfoPtr_BattleEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 55502, RefRangeEnd = 55503, XrefRangeStart = 55475, XrefRangeEnd = 55502, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LogHit(Entity attacker, Entity target, int damage, string damageType)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attacker);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &damage;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(damageType);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleLogSystem.NativeMethodInfoPtr_LogHit_Private_Void_Entity_Entity_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55503, XrefRangeEnd = 55527, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LogDamage(Entity target, int damage, string damageType)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &damage;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(damageType);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleLogSystem.NativeMethodInfoPtr_LogDamage_Private_Void_Entity_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55527, XrefRangeEnd = 55545, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LogBlock(Entity target, int damageBlocked)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &damageBlocked;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleLogSystem.NativeMethodInfoPtr_LogBlock_Private_Void_Entity_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 55574, RefRangeEnd = 55575, XrefRangeStart = 55545, XrefRangeEnd = 55574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LogStatus(Entity applier, Entity target, StatusEffectData status, int count)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) applier);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) status);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleLogSystem.NativeMethodInfoPtr_LogStatus_Private_Void_Entity_Entity_StatusEffectData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55575, XrefRangeEnd = 55593, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LogHeal(Entity healer, Entity target)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) healer);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleLogSystem.NativeMethodInfoPtr_LogHeal_Private_Void_Entity_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55593, XrefRangeEnd = 55611, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LogRestore(Entity target, int amount)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &amount;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleLogSystem.NativeMethodInfoPtr_LogRestore_Private_Void_Entity_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55611, XrefRangeEnd = 55641, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LogDamageUp(Entity applier, Entity target, int amount)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) applier);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &amount;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleLogSystem.NativeMethodInfoPtr_LogDamageUp_Private_Void_Entity_Entity_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55641, XrefRangeEnd = 55671, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LogDamageDown(Entity applier, Entity target, int amount)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) applier);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &amount;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleLogSystem.NativeMethodInfoPtr_LogDamageDown_Private_Void_Entity_Entity_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 55701, RefRangeEnd = 55702, XrefRangeStart = 55671, XrefRangeEnd = 55701, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LogHealthUp(Entity applier, Entity target, int amount)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) applier);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &amount;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleLogSystem.NativeMethodInfoPtr_LogHealthUp_Private_Void_Entity_Entity_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 55732, RefRangeEnd = 55733, XrefRangeStart = 55702, XrefRangeEnd = 55732, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LogHealthDown(Entity applier, Entity target, int amount)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) applier);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &amount;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleLogSystem.NativeMethodInfoPtr_LogHealthDown_Private_Void_Entity_Entity_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55733, XrefRangeEnd = 55763, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LogCounterUp(Entity applier, Entity target, int amount)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) applier);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &amount;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleLogSystem.NativeMethodInfoPtr_LogCounterUp_Private_Void_Entity_Entity_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 55793, RefRangeEnd = 55794, XrefRangeStart = 55763, XrefRangeEnd = 55793, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LogCounterDown(Entity applier, Entity target, int amount)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) applier);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &amount;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleLogSystem.NativeMethodInfoPtr_LogCounterDown_Private_Void_Entity_Entity_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(19)]
  [CachedScanResults(RefRangeStart = 55798, RefRangeEnd = 55817, XrefRangeStart = 55794, XrefRangeEnd = 55798, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Log(
    LocalizedString textKey,
    BattleLogType type,
    [Optional] Il2CppReferenceArray<Il2CppSystem.Object> args)
  {
    if (args == null)
      args = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) textKey);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &type;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) args);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleLogSystem.NativeMethodInfoPtr_Log_Private_Void_LocalizedString_BattleLogType_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(27)]
  [CachedScanResults(RefRangeStart = 55825, RefRangeEnd = 55852, XrefRangeStart = 55817, XrefRangeEnd = 55825, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe BattleEntity GetBattleEntity(Entity entity)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(BattleLogSystem.NativeMethodInfoPtr_GetBattleEntity_Private_Static_BattleEntity_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return new BattleEntity(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55852, XrefRangeEnd = 55861, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BattleLogSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleLogSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  public void Log(LocalizedString textKey, BattleLogType type, params Il2CppSystem.Object[] args)
  {
    this.Log(textKey, type, new Il2CppReferenceArray<Il2CppSystem.Object>(args));
  }

  static BattleLogSystem()
  {
    Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (BattleLogSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr);
    BattleLogSystem.NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, nameof (list));
    BattleLogSystem.NativeFieldInfoPtr_damageTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, nameof (damageTypes));
    BattleLogSystem.NativeFieldInfoPtr_logTurnKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, nameof (logTurnKey));
    BattleLogSystem.NativeFieldInfoPtr_logHitKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, nameof (logHitKey));
    BattleLogSystem.NativeFieldInfoPtr_logDamageKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, nameof (logDamageKey));
    BattleLogSystem.NativeFieldInfoPtr_logSpecialDamageKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, nameof (logSpecialDamageKey));
    BattleLogSystem.NativeFieldInfoPtr_logDestroyKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, nameof (logDestroyKey));
    BattleLogSystem.NativeFieldInfoPtr_logConsumedKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, nameof (logConsumedKey));
    BattleLogSystem.NativeFieldInfoPtr_logEatenKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, nameof (logEatenKey));
    BattleLogSystem.NativeFieldInfoPtr_logSacrificedKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, nameof (logSacrificedKey));
    BattleLogSystem.NativeFieldInfoPtr_logBlockKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, nameof (logBlockKey));
    BattleLogSystem.NativeFieldInfoPtr_logStatusKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, nameof (logStatusKey));
    BattleLogSystem.NativeFieldInfoPtr_logStatusFromKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, nameof (logStatusFromKey));
    BattleLogSystem.NativeFieldInfoPtr_logHealKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, nameof (logHealKey));
    BattleLogSystem.NativeFieldInfoPtr_logRestoredKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, nameof (logRestoredKey));
    BattleLogSystem.NativeFieldInfoPtr_logBoostKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, nameof (logBoostKey));
    BattleLogSystem.NativeFieldInfoPtr_logDamageUpKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, nameof (logDamageUpKey));
    BattleLogSystem.NativeFieldInfoPtr_logDamageUpSelfKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, nameof (logDamageUpSelfKey));
    BattleLogSystem.NativeFieldInfoPtr_logDamageDownKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, nameof (logDamageDownKey));
    BattleLogSystem.NativeFieldInfoPtr_logDamageDownSelfKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, nameof (logDamageDownSelfKey));
    BattleLogSystem.NativeFieldInfoPtr_logHealthUpKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, nameof (logHealthUpKey));
    BattleLogSystem.NativeFieldInfoPtr_logHealthUpSelfKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, nameof (logHealthUpSelfKey));
    BattleLogSystem.NativeFieldInfoPtr_logHealthDownKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, nameof (logHealthDownKey));
    BattleLogSystem.NativeFieldInfoPtr_logHealthDownSelfKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, nameof (logHealthDownSelfKey));
    BattleLogSystem.NativeFieldInfoPtr_logCounterUpKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, nameof (logCounterUpKey));
    BattleLogSystem.NativeFieldInfoPtr_logCounterUpSelfKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, nameof (logCounterUpSelfKey));
    BattleLogSystem.NativeFieldInfoPtr_logCounterDownKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, nameof (logCounterDownKey));
    BattleLogSystem.NativeFieldInfoPtr_logCounterDownSelfKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, nameof (logCounterDownSelfKey));
    BattleLogSystem.NativeFieldInfoPtr_logEnterBattleKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, nameof (logEnterBattleKey));
    BattleLogSystem.NativeFieldInfoPtr_logRecalledKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, nameof (logRecalledKey));
    BattleLogSystem.NativeFieldInfoPtr_logSummonedKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, nameof (logSummonedKey));
    BattleLogSystem.NativeFieldInfoPtr_logBattleWinKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, nameof (logBattleWinKey));
    BattleLogSystem.NativeFieldInfoPtr_logBattleLoseKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, nameof (logBattleLoseKey));
    BattleLogSystem.NativeFieldInfoPtr_logFleeKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, nameof (logFleeKey));
    BattleLogSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, 100667835);
    BattleLogSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, 100667836);
    BattleLogSystem.NativeMethodInfoPtr_BattlePhaseStart_Private_Void_Phase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, 100667837);
    BattleLogSystem.NativeMethodInfoPtr_TurnEnd_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, 100667838);
    BattleLogSystem.NativeMethodInfoPtr_Hit_Private_Void_Hit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, 100667839);
    BattleLogSystem.NativeMethodInfoPtr_EntityMove_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, 100667840);
    BattleLogSystem.NativeMethodInfoPtr_StatusApplied_Private_Void_StatusEffectApply_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, 100667841);
    BattleLogSystem.NativeMethodInfoPtr_PostHit_Private_Void_Hit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, 100667842);
    BattleLogSystem.NativeMethodInfoPtr_EntityKilled_Private_Void_Entity_DeathType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, 100667843);
    BattleLogSystem.NativeMethodInfoPtr_EntityFlee_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, 100667844);
    BattleLogSystem.NativeMethodInfoPtr_BattleEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, 100667845);
    BattleLogSystem.NativeMethodInfoPtr_LogHit_Private_Void_Entity_Entity_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, 100667846);
    BattleLogSystem.NativeMethodInfoPtr_LogDamage_Private_Void_Entity_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, 100667847);
    BattleLogSystem.NativeMethodInfoPtr_LogBlock_Private_Void_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, 100667848);
    BattleLogSystem.NativeMethodInfoPtr_LogStatus_Private_Void_Entity_Entity_StatusEffectData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, 100667849);
    BattleLogSystem.NativeMethodInfoPtr_LogHeal_Private_Void_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, 100667850);
    BattleLogSystem.NativeMethodInfoPtr_LogRestore_Private_Void_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, 100667851);
    BattleLogSystem.NativeMethodInfoPtr_LogDamageUp_Private_Void_Entity_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, 100667852);
    BattleLogSystem.NativeMethodInfoPtr_LogDamageDown_Private_Void_Entity_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, 100667853);
    BattleLogSystem.NativeMethodInfoPtr_LogHealthUp_Private_Void_Entity_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, 100667854);
    BattleLogSystem.NativeMethodInfoPtr_LogHealthDown_Private_Void_Entity_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, 100667855);
    BattleLogSystem.NativeMethodInfoPtr_LogCounterUp_Private_Void_Entity_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, 100667856);
    BattleLogSystem.NativeMethodInfoPtr_LogCounterDown_Private_Void_Entity_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, 100667857);
    BattleLogSystem.NativeMethodInfoPtr_Log_Private_Void_LocalizedString_BattleLogType_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, 100667858);
    BattleLogSystem.NativeMethodInfoPtr_GetBattleEntity_Private_Static_BattleEntity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, 100667859);
    BattleLogSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogSystem>.NativeClassPtr, 100667860);
  }

  public BattleLogSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe List<BattleLog> list
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_list));
      return pointer == System.IntPtr.Zero ? (List<BattleLog>) null : new List<BattleLog>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_list), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Dictionary<string, string> damageTypes
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(BattleLogSystem.NativeFieldInfoPtr_damageTypes, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Dictionary<string, string>) null : new Dictionary<string, string>(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(BattleLogSystem.NativeFieldInfoPtr_damageTypes, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString logTurnKey
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logTurnKey));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logTurnKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString logHitKey
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logHitKey));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logHitKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString logDamageKey
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logDamageKey));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logDamageKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString logSpecialDamageKey
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logSpecialDamageKey));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logSpecialDamageKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString logDestroyKey
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logDestroyKey));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logDestroyKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString logConsumedKey
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logConsumedKey));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logConsumedKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString logEatenKey
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logEatenKey));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logEatenKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString logSacrificedKey
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logSacrificedKey));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logSacrificedKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString logBlockKey
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logBlockKey));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logBlockKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString logStatusKey
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logStatusKey));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logStatusKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString logStatusFromKey
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logStatusFromKey));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logStatusFromKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString logHealKey
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logHealKey));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logHealKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString logRestoredKey
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logRestoredKey));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logRestoredKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString logBoostKey
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logBoostKey));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logBoostKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString logDamageUpKey
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logDamageUpKey));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logDamageUpKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString logDamageUpSelfKey
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logDamageUpSelfKey));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logDamageUpSelfKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString logDamageDownKey
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logDamageDownKey));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logDamageDownKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString logDamageDownSelfKey
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logDamageDownSelfKey));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logDamageDownSelfKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString logHealthUpKey
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logHealthUpKey));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logHealthUpKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString logHealthUpSelfKey
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logHealthUpSelfKey));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logHealthUpSelfKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString logHealthDownKey
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logHealthDownKey));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logHealthDownKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString logHealthDownSelfKey
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logHealthDownSelfKey));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logHealthDownSelfKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString logCounterUpKey
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logCounterUpKey));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logCounterUpKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString logCounterUpSelfKey
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logCounterUpSelfKey));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logCounterUpSelfKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString logCounterDownKey
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logCounterDownKey));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logCounterDownKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString logCounterDownSelfKey
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logCounterDownSelfKey));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logCounterDownSelfKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString logEnterBattleKey
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logEnterBattleKey));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logEnterBattleKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString logRecalledKey
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logRecalledKey));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logRecalledKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString logSummonedKey
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logSummonedKey));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logSummonedKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString logBattleWinKey
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logBattleWinKey));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logBattleWinKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString logBattleLoseKey
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logBattleLoseKey));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logBattleLoseKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString logFleeKey
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logFleeKey));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogSystem.NativeFieldInfoPtr_logFleeKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
