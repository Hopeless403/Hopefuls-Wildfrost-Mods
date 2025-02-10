// Decompiled with JetBrains decompiler
// Type: WaveDeploySystemOverflow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

#nullable disable
public class WaveDeploySystemOverflow : GameSystem
{
  private static readonly System.IntPtr NativeFieldInfoPtr_visible;
  private static readonly System.IntPtr NativeFieldInfoPtr_animator;
  private static readonly System.IntPtr NativeFieldInfoPtr_counterText;
  private static readonly System.IntPtr NativeFieldInfoPtr_group;
  private static readonly System.IntPtr NativeFieldInfoPtr_navigationItem;
  private static readonly System.IntPtr NativeFieldInfoPtr_canvasGroup;
  private static readonly System.IntPtr NativeFieldInfoPtr_button;
  private static readonly System.IntPtr NativeFieldInfoPtr_glow;
  private static readonly System.IntPtr NativeFieldInfoPtr_glowColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_glowImminentColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_deployEarlyReward;
  private static readonly System.IntPtr NativeFieldInfoPtr_deployEarlyRewardPerTurn;
  private static readonly System.IntPtr NativeFieldInfoPtr_autoEarlyDeploy;
  private static readonly System.IntPtr NativeFieldInfoPtr_canCallEarly;
  private static readonly System.IntPtr NativeFieldInfoPtr_popupDesc;
  private static readonly System.IntPtr NativeFieldInfoPtr_popupHitDesc;
  private static readonly System.IntPtr NativeFieldInfoPtr_popupOverflowDesc;
  private static readonly System.IntPtr NativeFieldInfoPtr_popupRewardDesc;
  private static readonly System.IntPtr NativeFieldInfoPtr_popup;
  private static readonly System.IntPtr NativeFieldInfoPtr_counterStart;
  private static readonly System.IntPtr NativeFieldInfoPtr_pauseAfterDeploy;
  private static readonly System.IntPtr NativeFieldInfoPtr_inBattle;
  private static readonly System.IntPtr NativeFieldInfoPtr_currentWave;
  private static readonly System.IntPtr NativeFieldInfoPtr_counter;
  private static readonly System.IntPtr NativeFieldInfoPtr_reset;
  private static readonly System.IntPtr NativeFieldInfoPtr_fade;
  private static readonly System.IntPtr NativeFieldInfoPtr_fadeTo;
  private static readonly System.IntPtr NativeFieldInfoPtr_fadeAdd;
  private static readonly System.IntPtr NativeFieldInfoPtr_popped;
  private static readonly System.IntPtr NativeFieldInfoPtr_waves;
  private static readonly System.IntPtr NativeFieldInfoPtr_deployedThisTurn;
  private static readonly System.IntPtr NativeFieldInfoPtr_deployed;
  private static readonly System.IntPtr NativeFieldInfoPtr_overflowWaveIndex;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BattlePhaseStart_Private_Void_Phase_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SceneChanged_Private_Void_Scene_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BattleStart_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BattleEnd_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AssignCardController_Private_Void_CardController_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Show_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Hide_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FadeIn_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FadeOut_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CountDown_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetCounter_Private_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckEarlyDeploy_Private_Static_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Activate_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryDeploy_Private_IEnumerator_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Deploy_Private_Void_Entity_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RevealBoard_Private_Static_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Overflow_Private_Void_IEnumerable_1_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateOverflowWave_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryToAddToOverflow_Private_Boolean_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryEarlyDeploy_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EarlyDeploy_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DropGold_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CountEmptySpacesOnBoard_Private_Static_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Pop_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnPop_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Virtual_Final_New_BattleWaveData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Void_BattleWaveData_IReadOnlyCollection_1_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__TryDeploy_b__52_0_Private_Boolean_CardData_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82353, XrefRangeEnd = 82359, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82359, XrefRangeEnd = 82374, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82374, XrefRangeEnd = 82390, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82390, XrefRangeEnd = 82393, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82393, XrefRangeEnd = 82396, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BattlePhaseStart(Battle.Phase phase)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &phase
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow.NativeMethodInfoPtr_BattlePhaseStart_Private_Void_Phase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82396, XrefRangeEnd = 82405, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SceneChanged(Scene scene)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &scene
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow.NativeMethodInfoPtr_SceneChanged_Private_Void_Scene_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82405, XrefRangeEnd = 82441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BattleStart()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow.NativeMethodInfoPtr_BattleStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82441, XrefRangeEnd = 82444, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BattleEnd()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow.NativeMethodInfoPtr_BattleEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82444, XrefRangeEnd = 82448, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AssignCardController(CardController controller)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) controller)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow.NativeMethodInfoPtr_AssignCardController_Private_Void_CardController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82448, XrefRangeEnd = 82452, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Close()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82452, XrefRangeEnd = 82456, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Open()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 82472, RefRangeEnd = 82473, XrefRangeStart = 82456, XrefRangeEnd = 82472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Show()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow.NativeMethodInfoPtr_Show_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 82476, RefRangeEnd = 82477, XrefRangeStart = 82473, XrefRangeEnd = 82476, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Hide()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow.NativeMethodInfoPtr_Hide_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82477, XrefRangeEnd = 82479, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FadeIn()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow.NativeMethodInfoPtr_FadeIn_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82479, XrefRangeEnd = 82481, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FadeOut()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow.NativeMethodInfoPtr_FadeOut_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 82486, RefRangeEnd = 82488, XrefRangeStart = 82481, XrefRangeEnd = 82486, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator CountDown()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow.NativeMethodInfoPtr_CountDown_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 82490, RefRangeEnd = 82492, XrefRangeStart = 82488, XrefRangeEnd = 82490, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetCounter(int value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow.NativeMethodInfoPtr_SetCounter_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82492, XrefRangeEnd = 82496, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool CheckEarlyDeploy()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow.NativeMethodInfoPtr_CheckEarlyDeploy_Private_Static_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82496, XrefRangeEnd = 82501, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator Activate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow.NativeMethodInfoPtr_Activate_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82501, XrefRangeEnd = 82506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator TryDeploy(int rowIndex)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &rowIndex
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow.NativeMethodInfoPtr_TryDeploy_Private_IEnumerator_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 82536, RefRangeEnd = 82537, XrefRangeStart = 82506, XrefRangeEnd = 82536, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Deploy(Entity entity, int targetRow, int targetColumn)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &targetRow;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &targetColumn;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow.NativeMethodInfoPtr_Deploy_Private_Void_Entity_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82537, XrefRangeEnd = 82541, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe IEnumerator RevealBoard()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow.NativeMethodInfoPtr_RevealBoard_Private_Static_IEnumerator_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 82576, RefRangeEnd = 82577, XrefRangeStart = 82541, XrefRangeEnd = 82576, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Overflow(IEnumerable<Entity> entities)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entities)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow.NativeMethodInfoPtr_Overflow_Private_Void_IEnumerable_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 82605, RefRangeEnd = 82607, XrefRangeStart = 82577, XrefRangeEnd = 82605, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CreateOverflowWave()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow.NativeMethodInfoPtr_CreateOverflowWave_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 82615, RefRangeEnd = 82617, XrefRangeStart = 82607, XrefRangeEnd = 82615, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool TryToAddToOverflow(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow.NativeMethodInfoPtr_TryToAddToOverflow_Private_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82617, XrefRangeEnd = 82641, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void TryEarlyDeploy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow.NativeMethodInfoPtr_TryEarlyDeploy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82641, XrefRangeEnd = 82646, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator EarlyDeploy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow.NativeMethodInfoPtr_EarlyDeploy_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82646, XrefRangeEnd = 82653, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DropGold()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow.NativeMethodInfoPtr_DropGold_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 82675, RefRangeEnd = 82677, XrefRangeStart = 82653, XrefRangeEnd = 82675, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int CountEmptySpacesOnBoard()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow.NativeMethodInfoPtr_CountEmptySpacesOnBoard_Private_Static_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82677, XrefRangeEnd = 82726, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Pop()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow.NativeMethodInfoPtr_Pop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82726, XrefRangeEnd = 82728, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UnPop()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow.NativeMethodInfoPtr_UnPop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 82755, RefRangeEnd = 82756, XrefRangeStart = 82728, XrefRangeEnd = 82755, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe BattleWaveData Save()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow.NativeMethodInfoPtr_Save_Public_Virtual_Final_New_BattleWaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (BattleWaveData) null : new BattleWaveData(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 82824, RefRangeEnd = 82825, XrefRangeStart = 82756, XrefRangeEnd = 82824, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Load(BattleWaveData data, IReadOnlyCollection<CardData> cards)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cards);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow.NativeMethodInfoPtr_Load_Public_Void_BattleWaveData_IReadOnlyCollection_1_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82825, XrefRangeEnd = 82826, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe WaveDeploySystemOverflow()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82826, XrefRangeEnd = 82831, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool _TryDeploy_b__52_0(CardData cardData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cardData)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow.NativeMethodInfoPtr__TryDeploy_b__52_0_Private_Boolean_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  static WaveDeploySystemOverflow()
  {
    Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (WaveDeploySystemOverflow));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr);
    WaveDeploySystemOverflow.NativeFieldInfoPtr_visible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, nameof (visible));
    WaveDeploySystemOverflow.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, nameof (animator));
    WaveDeploySystemOverflow.NativeFieldInfoPtr_counterText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, nameof (counterText));
    WaveDeploySystemOverflow.NativeFieldInfoPtr_group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, nameof (group));
    WaveDeploySystemOverflow.NativeFieldInfoPtr_navigationItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, nameof (navigationItem));
    WaveDeploySystemOverflow.NativeFieldInfoPtr_canvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, nameof (canvasGroup));
    WaveDeploySystemOverflow.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, nameof (button));
    WaveDeploySystemOverflow.NativeFieldInfoPtr_glow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, nameof (glow));
    WaveDeploySystemOverflow.NativeFieldInfoPtr_glowColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, nameof (glowColor));
    WaveDeploySystemOverflow.NativeFieldInfoPtr_glowImminentColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, nameof (glowImminentColor));
    WaveDeploySystemOverflow.NativeFieldInfoPtr_deployEarlyReward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, nameof (deployEarlyReward));
    WaveDeploySystemOverflow.NativeFieldInfoPtr_deployEarlyRewardPerTurn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, nameof (deployEarlyRewardPerTurn));
    WaveDeploySystemOverflow.NativeFieldInfoPtr_autoEarlyDeploy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, nameof (autoEarlyDeploy));
    WaveDeploySystemOverflow.NativeFieldInfoPtr_canCallEarly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, nameof (canCallEarly));
    WaveDeploySystemOverflow.NativeFieldInfoPtr_popupDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, nameof (popupDesc));
    WaveDeploySystemOverflow.NativeFieldInfoPtr_popupHitDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, nameof (popupHitDesc));
    WaveDeploySystemOverflow.NativeFieldInfoPtr_popupOverflowDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, nameof (popupOverflowDesc));
    WaveDeploySystemOverflow.NativeFieldInfoPtr_popupRewardDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, nameof (popupRewardDesc));
    WaveDeploySystemOverflow.NativeFieldInfoPtr_popup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, nameof (popup));
    WaveDeploySystemOverflow.NativeFieldInfoPtr_counterStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, nameof (counterStart));
    WaveDeploySystemOverflow.NativeFieldInfoPtr_pauseAfterDeploy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, nameof (pauseAfterDeploy));
    WaveDeploySystemOverflow.NativeFieldInfoPtr_inBattle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, nameof (inBattle));
    WaveDeploySystemOverflow.NativeFieldInfoPtr_currentWave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, nameof (currentWave));
    WaveDeploySystemOverflow.NativeFieldInfoPtr_counter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, nameof (counter));
    WaveDeploySystemOverflow.NativeFieldInfoPtr_reset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, nameof (reset));
    WaveDeploySystemOverflow.NativeFieldInfoPtr_fade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, nameof (fade));
    WaveDeploySystemOverflow.NativeFieldInfoPtr_fadeTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, nameof (fadeTo));
    WaveDeploySystemOverflow.NativeFieldInfoPtr_fadeAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, nameof (fadeAdd));
    WaveDeploySystemOverflow.NativeFieldInfoPtr_popped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, nameof (popped));
    WaveDeploySystemOverflow.NativeFieldInfoPtr_waves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, nameof (waves));
    WaveDeploySystemOverflow.NativeFieldInfoPtr_deployedThisTurn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, nameof (deployedThisTurn));
    WaveDeploySystemOverflow.NativeFieldInfoPtr_deployed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, nameof (deployed));
    WaveDeploySystemOverflow.NativeFieldInfoPtr_overflowWaveIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, nameof (overflowWaveIndex));
    WaveDeploySystemOverflow.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, 100670063);
    WaveDeploySystemOverflow.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, 100670064);
    WaveDeploySystemOverflow.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, 100670065);
    WaveDeploySystemOverflow.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, 100670066);
    WaveDeploySystemOverflow.NativeMethodInfoPtr_BattlePhaseStart_Private_Void_Phase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, 100670067);
    WaveDeploySystemOverflow.NativeMethodInfoPtr_SceneChanged_Private_Void_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, 100670068);
    WaveDeploySystemOverflow.NativeMethodInfoPtr_BattleStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, 100670069);
    WaveDeploySystemOverflow.NativeMethodInfoPtr_BattleEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, 100670070);
    WaveDeploySystemOverflow.NativeMethodInfoPtr_AssignCardController_Private_Void_CardController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, 100670071);
    WaveDeploySystemOverflow.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, 100670072);
    WaveDeploySystemOverflow.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, 100670073);
    WaveDeploySystemOverflow.NativeMethodInfoPtr_Show_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, 100670074);
    WaveDeploySystemOverflow.NativeMethodInfoPtr_Hide_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, 100670075);
    WaveDeploySystemOverflow.NativeMethodInfoPtr_FadeIn_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, 100670076);
    WaveDeploySystemOverflow.NativeMethodInfoPtr_FadeOut_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, 100670077);
    WaveDeploySystemOverflow.NativeMethodInfoPtr_CountDown_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, 100670078);
    WaveDeploySystemOverflow.NativeMethodInfoPtr_SetCounter_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, 100670079);
    WaveDeploySystemOverflow.NativeMethodInfoPtr_CheckEarlyDeploy_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, 100670080);
    WaveDeploySystemOverflow.NativeMethodInfoPtr_Activate_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, 100670081);
    WaveDeploySystemOverflow.NativeMethodInfoPtr_TryDeploy_Private_IEnumerator_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, 100670082);
    WaveDeploySystemOverflow.NativeMethodInfoPtr_Deploy_Private_Void_Entity_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, 100670083);
    WaveDeploySystemOverflow.NativeMethodInfoPtr_RevealBoard_Private_Static_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, 100670084);
    WaveDeploySystemOverflow.NativeMethodInfoPtr_Overflow_Private_Void_IEnumerable_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, 100670085);
    WaveDeploySystemOverflow.NativeMethodInfoPtr_CreateOverflowWave_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, 100670086);
    WaveDeploySystemOverflow.NativeMethodInfoPtr_TryToAddToOverflow_Private_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, 100670087);
    WaveDeploySystemOverflow.NativeMethodInfoPtr_TryEarlyDeploy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, 100670088);
    WaveDeploySystemOverflow.NativeMethodInfoPtr_EarlyDeploy_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, 100670089);
    WaveDeploySystemOverflow.NativeMethodInfoPtr_DropGold_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, 100670090);
    WaveDeploySystemOverflow.NativeMethodInfoPtr_CountEmptySpacesOnBoard_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, 100670091);
    WaveDeploySystemOverflow.NativeMethodInfoPtr_Pop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, 100670092);
    WaveDeploySystemOverflow.NativeMethodInfoPtr_UnPop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, 100670093);
    WaveDeploySystemOverflow.NativeMethodInfoPtr_Save_Public_Virtual_Final_New_BattleWaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, 100670094);
    WaveDeploySystemOverflow.NativeMethodInfoPtr_Load_Public_Void_BattleWaveData_IReadOnlyCollection_1_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, 100670095);
    WaveDeploySystemOverflow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, 100670096);
    WaveDeploySystemOverflow.NativeMethodInfoPtr__TryDeploy_b__52_0_Private_Boolean_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, 100670097);
  }

  public WaveDeploySystemOverflow(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe bool visible
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_visible));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_visible)) = value;
    }
  }

  public unsafe UnityEngine.Animator animator
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_animator));
      return pointer == System.IntPtr.Zero ? (UnityEngine.Animator) null : new UnityEngine.Animator(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text counterText
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_counterText));
      return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_counterText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject group
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_group));
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_group), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UINavigationItem navigationItem
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_navigationItem));
      return pointer == System.IntPtr.Zero ? (UINavigationItem) null : new UINavigationItem(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_navigationItem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CanvasGroup canvasGroup
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_canvasGroup));
      return pointer == System.IntPtr.Zero ? (CanvasGroup) null : new CanvasGroup(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_canvasGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Button button
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_button));
      return pointer == System.IntPtr.Zero ? (Button) null : new Button(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image glow
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_glow));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_glow), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Color glowColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_glowColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_glowColor)) = value;
    }
  }

  public unsafe Color glowImminentColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_glowImminentColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_glowImminentColor)) = value;
    }
  }

  public unsafe int deployEarlyReward
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_deployEarlyReward));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_deployEarlyReward)) = value;
    }
  }

  public unsafe int deployEarlyRewardPerTurn
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_deployEarlyRewardPerTurn));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_deployEarlyRewardPerTurn)) = value;
    }
  }

  public unsafe bool autoEarlyDeploy
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_autoEarlyDeploy));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_autoEarlyDeploy)) = value;
    }
  }

  public unsafe bool canCallEarly
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_canCallEarly));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_canCallEarly)) = value;
    }
  }

  public unsafe LocalizedString popupDesc
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_popupDesc));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_popupDesc), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString popupHitDesc
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_popupHitDesc));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_popupHitDesc), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString popupOverflowDesc
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_popupOverflowDesc));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_popupOverflowDesc), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString popupRewardDesc
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_popupRewardDesc));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_popupRewardDesc), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe KeywordData popup
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_popup));
      return pointer == System.IntPtr.Zero ? (KeywordData) null : new KeywordData(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_popup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int counterStart
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_counterStart));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_counterStart)) = value;
    }
  }

  public unsafe float pauseAfterDeploy
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_pauseAfterDeploy));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_pauseAfterDeploy)) = value;
    }
  }

  public unsafe bool inBattle
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_inBattle));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_inBattle)) = value;
    }
  }

  public unsafe int currentWave
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_currentWave));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_currentWave)) = value;
    }
  }

  public unsafe int counter
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_counter));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_counter)) = value;
    }
  }

  public unsafe bool reset
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_reset));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_reset)) = value;
    }
  }

  public unsafe float fade
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_fade));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_fade)) = value;
    }
  }

  public unsafe float fadeTo
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_fadeTo));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_fadeTo)) = value;
    }
  }

  public unsafe float fadeAdd
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_fadeAdd));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_fadeAdd)) = value;
    }
  }

  public unsafe bool popped
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_popped));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_popped)) = value;
    }
  }

  public unsafe List<BattleWaveManager.Wave> waves
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_waves));
      return pointer == System.IntPtr.Zero ? (List<BattleWaveManager.Wave>) null : new List<BattleWaveManager.Wave>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_waves), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<Entity> deployedThisTurn
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_deployedThisTurn));
      return pointer == System.IntPtr.Zero ? (List<Entity>) null : new List<Entity>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_deployedThisTurn), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<ulong> deployed
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_deployed));
      return pointer == System.IntPtr.Zero ? (List<ulong>) null : new List<ulong>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_deployed), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int overflowWaveIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_overflowWaveIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.NativeFieldInfoPtr_overflowWaveIndex)) = value;
    }
  }

  [ObfuscatedName("WaveDeploySystemOverflow/<CountDown>d__48")]
  public sealed class _CountDown_d__48 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr__earlyDeploy_5__2;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _CountDown_d__48(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaveDeploySystemOverflow._CountDown_d__48>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow._CountDown_d__48.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow._CountDown_d__48.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82110, XrefRangeEnd = 82140, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow._CountDown_d__48.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow._CountDown_d__48.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82140, XrefRangeEnd = 82146, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow._CountDown_d__48.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow._CountDown_d__48.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _CountDown_d__48()
    {
      Il2CppClassPointerStore<WaveDeploySystemOverflow._CountDown_d__48>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, "<CountDown>d__48");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaveDeploySystemOverflow._CountDown_d__48>.NativeClassPtr);
      WaveDeploySystemOverflow._CountDown_d__48.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow._CountDown_d__48>.NativeClassPtr, "<>1__state");
      WaveDeploySystemOverflow._CountDown_d__48.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow._CountDown_d__48>.NativeClassPtr, "<>2__current");
      WaveDeploySystemOverflow._CountDown_d__48.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow._CountDown_d__48>.NativeClassPtr, "<>4__this");
      WaveDeploySystemOverflow._CountDown_d__48.NativeFieldInfoPtr__earlyDeploy_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow._CountDown_d__48>.NativeClassPtr, "<earlyDeploy>5__2");
      WaveDeploySystemOverflow._CountDown_d__48.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow._CountDown_d__48>.NativeClassPtr, 100670098);
      WaveDeploySystemOverflow._CountDown_d__48.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow._CountDown_d__48>.NativeClassPtr, 100670099);
      WaveDeploySystemOverflow._CountDown_d__48.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow._CountDown_d__48>.NativeClassPtr, 100670100);
      WaveDeploySystemOverflow._CountDown_d__48.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow._CountDown_d__48>.NativeClassPtr, 100670101);
      WaveDeploySystemOverflow._CountDown_d__48.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow._CountDown_d__48>.NativeClassPtr, 100670102);
      WaveDeploySystemOverflow._CountDown_d__48.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow._CountDown_d__48>.NativeClassPtr, 100670103);
    }

    public _CountDown_d__48(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow._CountDown_d__48.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow._CountDown_d__48.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow._CountDown_d__48.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow._CountDown_d__48.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WaveDeploySystemOverflow __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow._CountDown_d__48.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (WaveDeploySystemOverflow) null : new WaveDeploySystemOverflow(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow._CountDown_d__48.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _earlyDeploy_5__2
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow._CountDown_d__48.NativeFieldInfoPtr__earlyDeploy_5__2));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow._CountDown_d__48.NativeFieldInfoPtr__earlyDeploy_5__2)) = value;
      }
    }
  }

  [ObfuscatedName("WaveDeploySystemOverflow/<Activate>d__51")]
  public sealed class _Activate_d__51 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr__targetRow_5__2;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _Activate_d__51(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaveDeploySystemOverflow._Activate_d__51>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow._Activate_d__51.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow._Activate_d__51.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82146, XrefRangeEnd = 82170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow._Activate_d__51.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow._Activate_d__51.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82170, XrefRangeEnd = 82176, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow._Activate_d__51.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow._Activate_d__51.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _Activate_d__51()
    {
      Il2CppClassPointerStore<WaveDeploySystemOverflow._Activate_d__51>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, "<Activate>d__51");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaveDeploySystemOverflow._Activate_d__51>.NativeClassPtr);
      WaveDeploySystemOverflow._Activate_d__51.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow._Activate_d__51>.NativeClassPtr, "<>1__state");
      WaveDeploySystemOverflow._Activate_d__51.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow._Activate_d__51>.NativeClassPtr, "<>2__current");
      WaveDeploySystemOverflow._Activate_d__51.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow._Activate_d__51>.NativeClassPtr, "<>4__this");
      WaveDeploySystemOverflow._Activate_d__51.NativeFieldInfoPtr__targetRow_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow._Activate_d__51>.NativeClassPtr, "<targetRow>5__2");
      WaveDeploySystemOverflow._Activate_d__51.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow._Activate_d__51>.NativeClassPtr, 100670104);
      WaveDeploySystemOverflow._Activate_d__51.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow._Activate_d__51>.NativeClassPtr, 100670105);
      WaveDeploySystemOverflow._Activate_d__51.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow._Activate_d__51>.NativeClassPtr, 100670106);
      WaveDeploySystemOverflow._Activate_d__51.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow._Activate_d__51>.NativeClassPtr, 100670107);
      WaveDeploySystemOverflow._Activate_d__51.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow._Activate_d__51>.NativeClassPtr, 100670108);
      WaveDeploySystemOverflow._Activate_d__51.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow._Activate_d__51>.NativeClassPtr, 100670109);
    }

    public _Activate_d__51(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow._Activate_d__51.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow._Activate_d__51.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow._Activate_d__51.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow._Activate_d__51.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WaveDeploySystemOverflow __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow._Activate_d__51.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (WaveDeploySystemOverflow) null : new WaveDeploySystemOverflow(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow._Activate_d__51.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int _targetRow_5__2
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow._Activate_d__51.NativeFieldInfoPtr__targetRow_5__2));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow._Activate_d__51.NativeFieldInfoPtr__targetRow_5__2)) = value;
      }
    }
  }

  [ObfuscatedName("WaveDeploySystemOverflow/<>c__DisplayClass52_0")]
  public sealed class __c__DisplayClass52_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_cardData;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__TryDeploy_b__1_Internal_Boolean_Entity_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass52_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaveDeploySystemOverflow.__c__DisplayClass52_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow.__c__DisplayClass52_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _TryDeploy_b__1(Entity e)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) e)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow.__c__DisplayClass52_0.NativeMethodInfoPtr__TryDeploy_b__1_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass52_0()
    {
      Il2CppClassPointerStore<WaveDeploySystemOverflow.__c__DisplayClass52_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, "<>c__DisplayClass52_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaveDeploySystemOverflow.__c__DisplayClass52_0>.NativeClassPtr);
      WaveDeploySystemOverflow.__c__DisplayClass52_0.NativeFieldInfoPtr_cardData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow.__c__DisplayClass52_0>.NativeClassPtr, nameof (cardData));
      WaveDeploySystemOverflow.__c__DisplayClass52_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow.__c__DisplayClass52_0>.NativeClassPtr, 100670110);
      WaveDeploySystemOverflow.__c__DisplayClass52_0.NativeMethodInfoPtr__TryDeploy_b__1_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow.__c__DisplayClass52_0>.NativeClassPtr, 100670111);
    }

    public __c__DisplayClass52_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CardData cardData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.__c__DisplayClass52_0.NativeFieldInfoPtr_cardData));
        return pointer == System.IntPtr.Zero ? (CardData) null : new CardData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.__c__DisplayClass52_0.NativeFieldInfoPtr_cardData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("WaveDeploySystemOverflow/<TryDeploy>d__52")]
  public sealed class _TryDeploy_d__52 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_rowIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr__failedToDeploy_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr___7__wrap2;
    private static readonly System.IntPtr NativeFieldInfoPtr__entity_5__4;
    private static readonly System.IntPtr NativeFieldInfoPtr__thisDeployed_5__5;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _TryDeploy_d__52(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaveDeploySystemOverflow._TryDeploy_d__52>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow._TryDeploy_d__52.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 82183, RefRangeEnd = 82184, XrefRangeStart = 82176, XrefRangeEnd = 82183, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow._TryDeploy_d__52.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82184, XrefRangeEnd = 82275, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow._TryDeploy_d__52.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 82278, RefRangeEnd = 82279, XrefRangeStart = 82275, XrefRangeEnd = 82278, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void __m__Finally1()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow._TryDeploy_d__52.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow._TryDeploy_d__52.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82279, XrefRangeEnd = 82285, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow._TryDeploy_d__52.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow._TryDeploy_d__52.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _TryDeploy_d__52()
    {
      Il2CppClassPointerStore<WaveDeploySystemOverflow._TryDeploy_d__52>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, "<TryDeploy>d__52");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaveDeploySystemOverflow._TryDeploy_d__52>.NativeClassPtr);
      WaveDeploySystemOverflow._TryDeploy_d__52.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow._TryDeploy_d__52>.NativeClassPtr, "<>1__state");
      WaveDeploySystemOverflow._TryDeploy_d__52.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow._TryDeploy_d__52>.NativeClassPtr, "<>2__current");
      WaveDeploySystemOverflow._TryDeploy_d__52.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow._TryDeploy_d__52>.NativeClassPtr, "<>4__this");
      WaveDeploySystemOverflow._TryDeploy_d__52.NativeFieldInfoPtr_rowIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow._TryDeploy_d__52>.NativeClassPtr, nameof (rowIndex));
      WaveDeploySystemOverflow._TryDeploy_d__52.NativeFieldInfoPtr__failedToDeploy_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow._TryDeploy_d__52>.NativeClassPtr, "<failedToDeploy>5__2");
      WaveDeploySystemOverflow._TryDeploy_d__52.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow._TryDeploy_d__52>.NativeClassPtr, "<>7__wrap2");
      WaveDeploySystemOverflow._TryDeploy_d__52.NativeFieldInfoPtr__entity_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow._TryDeploy_d__52>.NativeClassPtr, "<entity>5__4");
      WaveDeploySystemOverflow._TryDeploy_d__52.NativeFieldInfoPtr__thisDeployed_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow._TryDeploy_d__52>.NativeClassPtr, "<thisDeployed>5__5");
      WaveDeploySystemOverflow._TryDeploy_d__52.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow._TryDeploy_d__52>.NativeClassPtr, 100670112);
      WaveDeploySystemOverflow._TryDeploy_d__52.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow._TryDeploy_d__52>.NativeClassPtr, 100670113);
      WaveDeploySystemOverflow._TryDeploy_d__52.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow._TryDeploy_d__52>.NativeClassPtr, 100670114);
      WaveDeploySystemOverflow._TryDeploy_d__52.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow._TryDeploy_d__52>.NativeClassPtr, 100670115);
      WaveDeploySystemOverflow._TryDeploy_d__52.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow._TryDeploy_d__52>.NativeClassPtr, 100670116);
      WaveDeploySystemOverflow._TryDeploy_d__52.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow._TryDeploy_d__52>.NativeClassPtr, 100670117);
      WaveDeploySystemOverflow._TryDeploy_d__52.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow._TryDeploy_d__52>.NativeClassPtr, 100670118);
    }

    public _TryDeploy_d__52(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow._TryDeploy_d__52.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow._TryDeploy_d__52.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow._TryDeploy_d__52.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow._TryDeploy_d__52.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WaveDeploySystemOverflow __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow._TryDeploy_d__52.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (WaveDeploySystemOverflow) null : new WaveDeploySystemOverflow(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow._TryDeploy_d__52.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int rowIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow._TryDeploy_d__52.NativeFieldInfoPtr_rowIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow._TryDeploy_d__52.NativeFieldInfoPtr_rowIndex)) = value;
      }
    }

    public unsafe List<Entity> _failedToDeploy_5__2
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow._TryDeploy_d__52.NativeFieldInfoPtr__failedToDeploy_5__2));
        return pointer == System.IntPtr.Zero ? (List<Entity>) null : new List<Entity>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow._TryDeploy_d__52.NativeFieldInfoPtr__failedToDeploy_5__2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe IEnumerator<CardData> __7__wrap2
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow._TryDeploy_d__52.NativeFieldInfoPtr___7__wrap2));
        return pointer == System.IntPtr.Zero ? (IEnumerator<CardData>) null : new IEnumerator<CardData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow._TryDeploy_d__52.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Entity _entity_5__4
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow._TryDeploy_d__52.NativeFieldInfoPtr__entity_5__4));
        return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow._TryDeploy_d__52.NativeFieldInfoPtr__entity_5__4), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _thisDeployed_5__5
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow._TryDeploy_d__52.NativeFieldInfoPtr__thisDeployed_5__5));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow._TryDeploy_d__52.NativeFieldInfoPtr__thisDeployed_5__5)) = value;
      }
    }
  }

  [ObfuscatedName("WaveDeploySystemOverflow/<RevealBoard>d__54")]
  public sealed class _RevealBoard_d__54 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _RevealBoard_d__54(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaveDeploySystemOverflow._RevealBoard_d__54>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow._RevealBoard_d__54.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow._RevealBoard_d__54.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82285, XrefRangeEnd = 82301, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow._RevealBoard_d__54.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow._RevealBoard_d__54.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82301, XrefRangeEnd = 82307, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow._RevealBoard_d__54.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow._RevealBoard_d__54.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _RevealBoard_d__54()
    {
      Il2CppClassPointerStore<WaveDeploySystemOverflow._RevealBoard_d__54>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, "<RevealBoard>d__54");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaveDeploySystemOverflow._RevealBoard_d__54>.NativeClassPtr);
      WaveDeploySystemOverflow._RevealBoard_d__54.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow._RevealBoard_d__54>.NativeClassPtr, "<>1__state");
      WaveDeploySystemOverflow._RevealBoard_d__54.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow._RevealBoard_d__54>.NativeClassPtr, "<>2__current");
      WaveDeploySystemOverflow._RevealBoard_d__54.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow._RevealBoard_d__54>.NativeClassPtr, 100670119);
      WaveDeploySystemOverflow._RevealBoard_d__54.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow._RevealBoard_d__54>.NativeClassPtr, 100670120);
      WaveDeploySystemOverflow._RevealBoard_d__54.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow._RevealBoard_d__54>.NativeClassPtr, 100670121);
      WaveDeploySystemOverflow._RevealBoard_d__54.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow._RevealBoard_d__54>.NativeClassPtr, 100670122);
      WaveDeploySystemOverflow._RevealBoard_d__54.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow._RevealBoard_d__54>.NativeClassPtr, 100670123);
      WaveDeploySystemOverflow._RevealBoard_d__54.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow._RevealBoard_d__54>.NativeClassPtr, 100670124);
    }

    public _RevealBoard_d__54(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow._RevealBoard_d__54.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow._RevealBoard_d__54.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow._RevealBoard_d__54.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow._RevealBoard_d__54.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("WaveDeploySystemOverflow/<EarlyDeploy>d__59")]
  public sealed class _EarlyDeploy_d__59 : Il2CppSystem.Object
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
    public unsafe _EarlyDeploy_d__59(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaveDeploySystemOverflow._EarlyDeploy_d__59>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow._EarlyDeploy_d__59.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow._EarlyDeploy_d__59.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82307, XrefRangeEnd = 82329, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow._EarlyDeploy_d__59.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow._EarlyDeploy_d__59.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82329, XrefRangeEnd = 82335, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow._EarlyDeploy_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow._EarlyDeploy_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _EarlyDeploy_d__59()
    {
      Il2CppClassPointerStore<WaveDeploySystemOverflow._EarlyDeploy_d__59>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, "<EarlyDeploy>d__59");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaveDeploySystemOverflow._EarlyDeploy_d__59>.NativeClassPtr);
      WaveDeploySystemOverflow._EarlyDeploy_d__59.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow._EarlyDeploy_d__59>.NativeClassPtr, "<>1__state");
      WaveDeploySystemOverflow._EarlyDeploy_d__59.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow._EarlyDeploy_d__59>.NativeClassPtr, "<>2__current");
      WaveDeploySystemOverflow._EarlyDeploy_d__59.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow._EarlyDeploy_d__59>.NativeClassPtr, "<>4__this");
      WaveDeploySystemOverflow._EarlyDeploy_d__59.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow._EarlyDeploy_d__59>.NativeClassPtr, 100670125);
      WaveDeploySystemOverflow._EarlyDeploy_d__59.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow._EarlyDeploy_d__59>.NativeClassPtr, 100670126);
      WaveDeploySystemOverflow._EarlyDeploy_d__59.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow._EarlyDeploy_d__59>.NativeClassPtr, 100670127);
      WaveDeploySystemOverflow._EarlyDeploy_d__59.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow._EarlyDeploy_d__59>.NativeClassPtr, 100670128);
      WaveDeploySystemOverflow._EarlyDeploy_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow._EarlyDeploy_d__59>.NativeClassPtr, 100670129);
      WaveDeploySystemOverflow._EarlyDeploy_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow._EarlyDeploy_d__59>.NativeClassPtr, 100670130);
    }

    public _EarlyDeploy_d__59(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow._EarlyDeploy_d__59.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow._EarlyDeploy_d__59.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow._EarlyDeploy_d__59.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow._EarlyDeploy_d__59.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WaveDeploySystemOverflow __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow._EarlyDeploy_d__59.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (WaveDeploySystemOverflow) null : new WaveDeploySystemOverflow(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow._EarlyDeploy_d__59.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("WaveDeploySystemOverflow/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__61_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__CountEmptySpacesOnBoard_b__61_0_Internal_Int32_CardContainer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Save_b__64_0_Internal_Wave_Wave_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaveDeploySystemOverflow.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe int _CountEmptySpacesOnBoard_b__61_0(CardContainer a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow.__c.NativeMethodInfoPtr__CountEmptySpacesOnBoard_b__61_0_Internal_Int32_CardContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82335, XrefRangeEnd = 82339, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BattleWaveData.Wave _Save_b__64_0(BattleWaveManager.Wave a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow.__c.NativeMethodInfoPtr__Save_b__64_0_Internal_Wave_Wave_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (BattleWaveData.Wave) null : new BattleWaveData.Wave(pointer);
    }

    static __c()
    {
      Il2CppClassPointerStore<WaveDeploySystemOverflow.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaveDeploySystemOverflow.__c>.NativeClassPtr);
      WaveDeploySystemOverflow.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow.__c>.NativeClassPtr, "<>9");
      WaveDeploySystemOverflow.__c.NativeFieldInfoPtr___9__61_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow.__c>.NativeClassPtr, "<>9__61_0");
      WaveDeploySystemOverflow.__c.NativeFieldInfoPtr___9__64_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow.__c>.NativeClassPtr, "<>9__64_0");
      WaveDeploySystemOverflow.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow.__c>.NativeClassPtr, 100670132);
      WaveDeploySystemOverflow.__c.NativeMethodInfoPtr__CountEmptySpacesOnBoard_b__61_0_Internal_Int32_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow.__c>.NativeClassPtr, 100670133);
      WaveDeploySystemOverflow.__c.NativeMethodInfoPtr__Save_b__64_0_Internal_Wave_Wave_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow.__c>.NativeClassPtr, 100670134);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe WaveDeploySystemOverflow.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(WaveDeploySystemOverflow.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (WaveDeploySystemOverflow.__c) null : new WaveDeploySystemOverflow.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(WaveDeploySystemOverflow.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<CardContainer, int> __9__61_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(WaveDeploySystemOverflow.__c.NativeFieldInfoPtr___9__61_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<CardContainer, int>) null : new Il2CppSystem.Func<CardContainer, int>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(WaveDeploySystemOverflow.__c.NativeFieldInfoPtr___9__61_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<BattleWaveManager.Wave, BattleWaveData.Wave> __9__64_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(WaveDeploySystemOverflow.__c.NativeFieldInfoPtr___9__64_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<BattleWaveManager.Wave, BattleWaveData.Wave>) null : new Il2CppSystem.Func<BattleWaveManager.Wave, BattleWaveData.Wave>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(WaveDeploySystemOverflow.__c.NativeFieldInfoPtr___9__64_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("WaveDeploySystemOverflow/<>c__DisplayClass65_0")]
  public sealed class __c__DisplayClass65_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_cards;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Load_b__0_Internal_CardData_UInt64_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass65_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaveDeploySystemOverflow.__c__DisplayClass65_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow.__c__DisplayClass65_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82339, XrefRangeEnd = 82353, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CardData _Load_b__0(ulong a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &a
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow.__c__DisplayClass65_0.NativeMethodInfoPtr__Load_b__0_Internal_CardData_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CardData) null : new CardData(pointer);
    }

    static __c__DisplayClass65_0()
    {
      Il2CppClassPointerStore<WaveDeploySystemOverflow.__c__DisplayClass65_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, "<>c__DisplayClass65_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaveDeploySystemOverflow.__c__DisplayClass65_0>.NativeClassPtr);
      WaveDeploySystemOverflow.__c__DisplayClass65_0.NativeFieldInfoPtr_cards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow.__c__DisplayClass65_0>.NativeClassPtr, nameof (cards));
      WaveDeploySystemOverflow.__c__DisplayClass65_0.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow.__c__DisplayClass65_0>.NativeClassPtr, "<>9__0");
      WaveDeploySystemOverflow.__c__DisplayClass65_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow.__c__DisplayClass65_0>.NativeClassPtr, 100670135);
      WaveDeploySystemOverflow.__c__DisplayClass65_0.NativeMethodInfoPtr__Load_b__0_Internal_CardData_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow.__c__DisplayClass65_0>.NativeClassPtr, 100670136);
    }

    public __c__DisplayClass65_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe IReadOnlyCollection<CardData> cards
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.__c__DisplayClass65_0.NativeFieldInfoPtr_cards));
        return pointer == System.IntPtr.Zero ? (IReadOnlyCollection<CardData>) null : new IReadOnlyCollection<CardData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.__c__DisplayClass65_0.NativeFieldInfoPtr_cards), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Func<ulong, CardData> __9__0
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.__c__DisplayClass65_0.NativeFieldInfoPtr___9__0));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<ulong, CardData>) null : new Il2CppSystem.Func<ulong, CardData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.__c__DisplayClass65_0.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("WaveDeploySystemOverflow/<>c__DisplayClass65_1")]
  public sealed class __c__DisplayClass65_1 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_a;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Load_b__1_Internal_Boolean_CardData_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass65_1()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaveDeploySystemOverflow.__c__DisplayClass65_1>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow.__c__DisplayClass65_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _Load_b__1(CardData b)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) b)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WaveDeploySystemOverflow.__c__DisplayClass65_1.NativeMethodInfoPtr__Load_b__1_Internal_Boolean_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass65_1()
    {
      Il2CppClassPointerStore<WaveDeploySystemOverflow.__c__DisplayClass65_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WaveDeploySystemOverflow>.NativeClassPtr, "<>c__DisplayClass65_1");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaveDeploySystemOverflow.__c__DisplayClass65_1>.NativeClassPtr);
      WaveDeploySystemOverflow.__c__DisplayClass65_1.NativeFieldInfoPtr_a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeploySystemOverflow.__c__DisplayClass65_1>.NativeClassPtr, nameof (a));
      WaveDeploySystemOverflow.__c__DisplayClass65_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow.__c__DisplayClass65_1>.NativeClassPtr, 100670137);
      WaveDeploySystemOverflow.__c__DisplayClass65_1.NativeMethodInfoPtr__Load_b__1_Internal_Boolean_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeploySystemOverflow.__c__DisplayClass65_1>.NativeClassPtr, 100670138);
    }

    public __c__DisplayClass65_1(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ulong a
    {
      get
      {
        return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.__c__DisplayClass65_1.NativeFieldInfoPtr_a));
      }
      [param: In] set
      {
        *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeploySystemOverflow.__c__DisplayClass65_1.NativeFieldInfoPtr_a)) = value;
      }
    }
  }
}
