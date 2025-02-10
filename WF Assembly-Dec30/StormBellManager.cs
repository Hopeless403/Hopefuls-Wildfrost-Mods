// Decompiled with JetBrains decompiler
// Type: StormBellManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using FMOD.Studio;
using FMODUnity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.Localization;

#nullable disable
public class StormBellManager : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_TrueFinalBossPointThreshold;
  private static readonly System.IntPtr NativeFieldInfoPtr_PointLimit;
  private static readonly System.IntPtr NativeFieldInfoPtr_MaxPointStart;
  private static readonly System.IntPtr NativeFieldInfoPtr_MaxPointIncrease;
  private static readonly System.IntPtr NativeFieldInfoPtr_openButton;
  private static readonly System.IntPtr NativeFieldInfoPtr_bellGroups;
  private static readonly System.IntPtr NativeFieldInfoPtr_bellPrefab;
  private static readonly System.IntPtr NativeFieldInfoPtr_stormBellDisplays;
  private static readonly System.IntPtr NativeFieldInfoPtr_stormBellUnlockDisplay;
  private static readonly System.IntPtr NativeFieldInfoPtr_animator;
  private static readonly System.IntPtr NativeFieldInfoPtr_overcranker;
  private static readonly System.IntPtr NativeFieldInfoPtr_pointLimitDisplay;
  private static readonly System.IntPtr NativeFieldInfoPtr_overcrankDisplay;
  private static readonly System.IntPtr NativeFieldInfoPtr_overcrankUnlockDisplay;
  private static readonly System.IntPtr NativeFieldInfoPtr_backgroundFader;
  private static readonly System.IntPtr NativeFieldInfoPtr_stormStrengthAddString;
  private static readonly System.IntPtr NativeFieldInfoPtr_additionalButtons;
  private static readonly System.IntPtr NativeFieldInfoPtr_normalSmoke;
  private static readonly System.IntPtr NativeFieldInfoPtr_overcrankSmoke;
  private static readonly System.IntPtr NativeFieldInfoPtr_stormLimitAdd;
  private static readonly System.IntPtr NativeFieldInfoPtr_stormLimitAddString;
  private static readonly System.IntPtr NativeFieldInfoPtr_goldFramesRemainingString;
  private static readonly System.IntPtr NativeFieldInfoPtr_stormLimitAddText;
  private static readonly System.IntPtr NativeFieldInfoPtr_stormBellActivateSfx;
  private static readonly System.IntPtr NativeFieldInfoPtr_stormBellActivate10Sfx;
  private static readonly System.IntPtr NativeFieldInfoPtr_stormBellRandomizeSfx;
  private static readonly System.IntPtr NativeFieldInfoPtr_stormBellClearSfx;
  private static readonly System.IntPtr NativeFieldInfoPtr_activeNames;
  private static readonly System.IntPtr NativeFieldInfoPtr_golden;
  private static readonly System.IntPtr NativeFieldInfoPtr_newGolden;
  private static readonly System.IntPtr NativeFieldInfoPtr_active;
  private static readonly System.IntPtr NativeFieldInfoPtr_modifierIcons;
  private static readonly System.IntPtr NativeFieldInfoPtr_unlocked;
  private static readonly System.IntPtr NativeFieldInfoPtr_points;
  private static readonly System.IntPtr NativeFieldInfoPtr_maxPoints;
  private static readonly System.IntPtr NativeFieldInfoPtr_overcrank;
  private static readonly System.IntPtr NativeFieldInfoPtr_stormStrengthAddText;
  private static readonly System.IntPtr NativeFieldInfoPtr_bellActivateSfxInstance;
  private static readonly System.IntPtr NativeFieldInfoPtr_bellActivate10SfxInstance;
  private static readonly System.IntPtr NativeFieldInfoPtr_bellRandomizeSfxInstance;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckStartGoldFrameRoutine_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateBells_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateBell_Private_ModifierIcon_HardModeModifierData_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ConnectBellInputLeft_Private_Static_Void_ModifierIcon_ModifierIcon_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ConnectBellInputRight_Private_Static_Void_ModifierIcon_ModifierIcon_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Toggle_Private_Void_HardModeModifierData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetGlobalStormBellCountParam_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToggleEffect_Private_Void_HardModeModifierData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ForceEnableAllBells_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DisableForcedBells_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdatePointsDisplays_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetActiveStormBells_Public_Static_List_1_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentStormPoints_Public_Static_Int32_List_1_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateAnimator_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToggleOvercrank_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TrueFinalBossPointThresholdReached_Public_Static_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GoldFrameRoutine_Private_IEnumerator_Il2CppStringArray_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Randomize_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClearAndPlaySfx_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__40_1_Private_Boolean_HardModeModifierData_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93387, XrefRangeEnd = 93623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StormBellManager.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93623, XrefRangeEnd = 93624, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StormBellManager.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93624, XrefRangeEnd = 93671, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CheckStartGoldFrameRoutine()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StormBellManager.NativeMethodInfoPtr_CheckStartGoldFrameRoutine_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 93691, RefRangeEnd = 93696, XrefRangeStart = 93671, XrefRangeEnd = 93691, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateBells()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StormBellManager.NativeMethodInfoPtr_UpdateBells_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 93749, RefRangeEnd = 93750, XrefRangeStart = 93696, XrefRangeEnd = 93749, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ModifierIcon CreateBell(HardModeModifierData modifier, int index)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) modifier);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StormBellManager.NativeMethodInfoPtr_CreateBell_Private_ModifierIcon_HardModeModifierData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (ModifierIcon) null : new ModifierIcon(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93750, XrefRangeEnd = 93756, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ConnectBellInputLeft(ModifierIcon from, ModifierIcon to)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) from);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) to);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StormBellManager.NativeMethodInfoPtr_ConnectBellInputLeft_Private_Static_Void_ModifierIcon_ModifierIcon_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93756, XrefRangeEnd = 93762, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ConnectBellInputRight(ModifierIcon from, ModifierIcon to)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) from);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) to);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StormBellManager.NativeMethodInfoPtr_ConnectBellInputRight_Private_Static_Void_ModifierIcon_ModifierIcon_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 93800, RefRangeEnd = 93801, XrefRangeStart = 93762, XrefRangeEnd = 93800, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Toggle(HardModeModifierData modifier)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) modifier)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StormBellManager.NativeMethodInfoPtr_Toggle_Private_Void_HardModeModifierData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 93810, RefRangeEnd = 93814, XrefRangeStart = 93801, XrefRangeEnd = 93810, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetGlobalStormBellCountParam()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StormBellManager.NativeMethodInfoPtr_SetGlobalStormBellCountParam_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 93838, RefRangeEnd = 93842, XrefRangeStart = 93814, XrefRangeEnd = 93838, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ToggleEffect(HardModeModifierData modifier)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) modifier)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StormBellManager.NativeMethodInfoPtr_ToggleEffect_Private_Void_HardModeModifierData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 93896, RefRangeEnd = 93897, XrefRangeStart = 93842, XrefRangeEnd = 93896, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ForceEnableAllBells()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StormBellManager.NativeMethodInfoPtr_ForceEnableAllBells_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 93967, RefRangeEnd = 93968, XrefRangeStart = 93897, XrefRangeEnd = 93967, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DisableForcedBells()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StormBellManager.NativeMethodInfoPtr_DisableForcedBells_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 93991, RefRangeEnd = 93996, XrefRangeStart = 93968, XrefRangeEnd = 93991, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdatePointsDisplays()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StormBellManager.NativeMethodInfoPtr_UpdatePointsDisplays_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 94004, RefRangeEnd = 94006, XrefRangeStart = 93996, XrefRangeEnd = 94004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe List<string> GetActiveStormBells()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StormBellManager.NativeMethodInfoPtr_GetActiveStormBells_Public_Static_List_1_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (List<string>) null : new List<string>(pointer);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 94015, RefRangeEnd = 94018, XrefRangeStart = 94006, XrefRangeEnd = 94015, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int GetCurrentStormPoints(List<string> active)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) active)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StormBellManager.NativeMethodInfoPtr_GetCurrentStormPoints_Public_Static_Int32_List_1_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94018, XrefRangeEnd = 94037, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateAnimator()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StormBellManager.NativeMethodInfoPtr_UpdateAnimator_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94037, XrefRangeEnd = 94086, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ToggleOvercrank()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StormBellManager.NativeMethodInfoPtr_ToggleOvercrank_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 94103, RefRangeEnd = 94104, XrefRangeStart = 94086, XrefRangeEnd = 94103, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TrueFinalBossPointThresholdReached()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StormBellManager.NativeMethodInfoPtr_TrueFinalBossPointThresholdReached_Public_Static_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94104, XrefRangeEnd = 94110, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator GoldFrameRoutine(Il2CppStringArray modifierNames)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) modifierNames)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StormBellManager.NativeMethodInfoPtr_GoldFrameRoutine_Private_IEnumerator_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94110, XrefRangeEnd = 94207, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Randomize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StormBellManager.NativeMethodInfoPtr_Randomize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 94231, RefRangeEnd = 94233, XrefRangeStart = 94207, XrefRangeEnd = 94231, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Clear()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StormBellManager.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94233, XrefRangeEnd = 94242, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ClearAndPlaySfx()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StormBellManager.NativeMethodInfoPtr_ClearAndPlaySfx_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94242, XrefRangeEnd = 94251, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StormBellManager()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StormBellManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94251, XrefRangeEnd = 94256, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool _Awake_b__40_1(HardModeModifierData a)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StormBellManager.NativeMethodInfoPtr__Awake_b__40_1_Private_Boolean_HardModeModifierData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  static StormBellManager()
  {
    Il2CppClassPointerStore<StormBellManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (StormBellManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr);
    StormBellManager.NativeFieldInfoPtr_TrueFinalBossPointThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, nameof (TrueFinalBossPointThreshold));
    StormBellManager.NativeFieldInfoPtr_PointLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, nameof (PointLimit));
    StormBellManager.NativeFieldInfoPtr_MaxPointStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, nameof (MaxPointStart));
    StormBellManager.NativeFieldInfoPtr_MaxPointIncrease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, nameof (MaxPointIncrease));
    StormBellManager.NativeFieldInfoPtr_openButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, nameof (openButton));
    StormBellManager.NativeFieldInfoPtr_bellGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, nameof (bellGroups));
    StormBellManager.NativeFieldInfoPtr_bellPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, nameof (bellPrefab));
    StormBellManager.NativeFieldInfoPtr_stormBellDisplays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, nameof (stormBellDisplays));
    StormBellManager.NativeFieldInfoPtr_stormBellUnlockDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, nameof (stormBellUnlockDisplay));
    StormBellManager.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, nameof (animator));
    StormBellManager.NativeFieldInfoPtr_overcranker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, nameof (overcranker));
    StormBellManager.NativeFieldInfoPtr_pointLimitDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, nameof (pointLimitDisplay));
    StormBellManager.NativeFieldInfoPtr_overcrankDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, nameof (overcrankDisplay));
    StormBellManager.NativeFieldInfoPtr_overcrankUnlockDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, nameof (overcrankUnlockDisplay));
    StormBellManager.NativeFieldInfoPtr_backgroundFader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, nameof (backgroundFader));
    StormBellManager.NativeFieldInfoPtr_stormStrengthAddString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, nameof (stormStrengthAddString));
    StormBellManager.NativeFieldInfoPtr_additionalButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, nameof (additionalButtons));
    StormBellManager.NativeFieldInfoPtr_normalSmoke = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, nameof (normalSmoke));
    StormBellManager.NativeFieldInfoPtr_overcrankSmoke = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, nameof (overcrankSmoke));
    StormBellManager.NativeFieldInfoPtr_stormLimitAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, nameof (stormLimitAdd));
    StormBellManager.NativeFieldInfoPtr_stormLimitAddString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, nameof (stormLimitAddString));
    StormBellManager.NativeFieldInfoPtr_goldFramesRemainingString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, nameof (goldFramesRemainingString));
    StormBellManager.NativeFieldInfoPtr_stormLimitAddText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, nameof (stormLimitAddText));
    StormBellManager.NativeFieldInfoPtr_stormBellActivateSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, nameof (stormBellActivateSfx));
    StormBellManager.NativeFieldInfoPtr_stormBellActivate10Sfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, nameof (stormBellActivate10Sfx));
    StormBellManager.NativeFieldInfoPtr_stormBellRandomizeSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, nameof (stormBellRandomizeSfx));
    StormBellManager.NativeFieldInfoPtr_stormBellClearSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, nameof (stormBellClearSfx));
    StormBellManager.NativeFieldInfoPtr_activeNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, nameof (activeNames));
    StormBellManager.NativeFieldInfoPtr_golden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, nameof (golden));
    StormBellManager.NativeFieldInfoPtr_newGolden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, nameof (newGolden));
    StormBellManager.NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, nameof (active));
    StormBellManager.NativeFieldInfoPtr_modifierIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, nameof (modifierIcons));
    StormBellManager.NativeFieldInfoPtr_unlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, nameof (unlocked));
    StormBellManager.NativeFieldInfoPtr_points = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, nameof (points));
    StormBellManager.NativeFieldInfoPtr_maxPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, nameof (maxPoints));
    StormBellManager.NativeFieldInfoPtr_overcrank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, nameof (overcrank));
    StormBellManager.NativeFieldInfoPtr_stormStrengthAddText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, nameof (stormStrengthAddText));
    StormBellManager.NativeFieldInfoPtr_bellActivateSfxInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, nameof (bellActivateSfxInstance));
    StormBellManager.NativeFieldInfoPtr_bellActivate10SfxInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, nameof (bellActivate10SfxInstance));
    StormBellManager.NativeFieldInfoPtr_bellRandomizeSfxInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, nameof (bellRandomizeSfxInstance));
    StormBellManager.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, 100671368);
    StormBellManager.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, 100671369);
    StormBellManager.NativeMethodInfoPtr_CheckStartGoldFrameRoutine_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, 100671370);
    StormBellManager.NativeMethodInfoPtr_UpdateBells_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, 100671371);
    StormBellManager.NativeMethodInfoPtr_CreateBell_Private_ModifierIcon_HardModeModifierData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, 100671372);
    StormBellManager.NativeMethodInfoPtr_ConnectBellInputLeft_Private_Static_Void_ModifierIcon_ModifierIcon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, 100671373);
    StormBellManager.NativeMethodInfoPtr_ConnectBellInputRight_Private_Static_Void_ModifierIcon_ModifierIcon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, 100671374);
    StormBellManager.NativeMethodInfoPtr_Toggle_Private_Void_HardModeModifierData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, 100671375);
    StormBellManager.NativeMethodInfoPtr_SetGlobalStormBellCountParam_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, 100671376);
    StormBellManager.NativeMethodInfoPtr_ToggleEffect_Private_Void_HardModeModifierData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, 100671377);
    StormBellManager.NativeMethodInfoPtr_ForceEnableAllBells_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, 100671378);
    StormBellManager.NativeMethodInfoPtr_DisableForcedBells_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, 100671379);
    StormBellManager.NativeMethodInfoPtr_UpdatePointsDisplays_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, 100671380);
    StormBellManager.NativeMethodInfoPtr_GetActiveStormBells_Public_Static_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, 100671381);
    StormBellManager.NativeMethodInfoPtr_GetCurrentStormPoints_Public_Static_Int32_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, 100671382);
    StormBellManager.NativeMethodInfoPtr_UpdateAnimator_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, 100671383);
    StormBellManager.NativeMethodInfoPtr_ToggleOvercrank_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, 100671384);
    StormBellManager.NativeMethodInfoPtr_TrueFinalBossPointThresholdReached_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, 100671385);
    StormBellManager.NativeMethodInfoPtr_GoldFrameRoutine_Private_IEnumerator_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, 100671386);
    StormBellManager.NativeMethodInfoPtr_Randomize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, 100671387);
    StormBellManager.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, 100671388);
    StormBellManager.NativeMethodInfoPtr_ClearAndPlaySfx_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, 100671389);
    StormBellManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, 100671390);
    StormBellManager.NativeMethodInfoPtr__Awake_b__40_1_Private_Boolean_HardModeModifierData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, 100671391);
  }

  public StormBellManager(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe int TrueFinalBossPointThreshold
  {
    get
    {
      int bossPointThreshold;
      IL2CPP.il2cpp_field_static_get_value(StormBellManager.NativeFieldInfoPtr_TrueFinalBossPointThreshold, (void*) &bossPointThreshold);
      return bossPointThreshold;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(StormBellManager.NativeFieldInfoPtr_TrueFinalBossPointThreshold, (void*) &value);
    }
  }

  public static unsafe int PointLimit
  {
    get
    {
      int pointLimit;
      IL2CPP.il2cpp_field_static_get_value(StormBellManager.NativeFieldInfoPtr_PointLimit, (void*) &pointLimit);
      return pointLimit;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(StormBellManager.NativeFieldInfoPtr_PointLimit, (void*) &value);
    }
  }

  public static unsafe int MaxPointStart
  {
    get
    {
      int maxPointStart;
      IL2CPP.il2cpp_field_static_get_value(StormBellManager.NativeFieldInfoPtr_MaxPointStart, (void*) &maxPointStart);
      return maxPointStart;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(StormBellManager.NativeFieldInfoPtr_MaxPointStart, (void*) &value);
    }
  }

  public static unsafe int MaxPointIncrease
  {
    get
    {
      int maxPointIncrease;
      IL2CPP.il2cpp_field_static_get_value(StormBellManager.NativeFieldInfoPtr_MaxPointIncrease, (void*) &maxPointIncrease);
      return maxPointIncrease;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(StormBellManager.NativeFieldInfoPtr_MaxPointIncrease, (void*) &value);
    }
  }

  public unsafe GameObject openButton
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_openButton));
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_openButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<Transform> bellGroups
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_bellGroups));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Transform>) null : new Il2CppReferenceArray<Transform>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_bellGroups), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ModifierIcon bellPrefab
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_bellPrefab));
      return pointer == System.IntPtr.Zero ? (ModifierIcon) null : new ModifierIcon(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_bellPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<ModifierIconMultiple> stormBellDisplays
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_stormBellDisplays));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<ModifierIconMultiple>) null : new Il2CppReferenceArray<ModifierIconMultiple>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_stormBellDisplays), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject stormBellUnlockDisplay
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_stormBellUnlockDisplay));
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_stormBellUnlockDisplay), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEngine.Animator animator
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_animator));
      return pointer == System.IntPtr.Zero ? (UnityEngine.Animator) null : new UnityEngine.Animator(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject overcranker
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_overcranker));
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_overcranker), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject pointLimitDisplay
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_pointLimitDisplay));
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_pointLimitDisplay), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject overcrankDisplay
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_overcrankDisplay));
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_overcrankDisplay), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject overcrankUnlockDisplay
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_overcrankUnlockDisplay));
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_overcrankUnlockDisplay), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ColourFader backgroundFader
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_backgroundFader));
      return pointer == System.IntPtr.Zero ? (ColourFader) null : new ColourFader(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_backgroundFader), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString stormStrengthAddString
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_stormStrengthAddString));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_stormStrengthAddString), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject additionalButtons
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_additionalButtons));
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_additionalButtons), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ParticleSystem normalSmoke
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_normalSmoke));
      return pointer == System.IntPtr.Zero ? (ParticleSystem) null : new ParticleSystem(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_normalSmoke), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ParticleSystem overcrankSmoke
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_overcrankSmoke));
      return pointer == System.IntPtr.Zero ? (ParticleSystem) null : new ParticleSystem(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_overcrankSmoke), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject stormLimitAdd
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_stormLimitAdd));
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_stormLimitAdd), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString stormLimitAddString
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_stormLimitAddString));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_stormLimitAddString), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString goldFramesRemainingString
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_goldFramesRemainingString));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_goldFramesRemainingString), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text stormLimitAddText
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_stormLimitAddText));
      return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_stormLimitAddText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe EventReference stormBellActivateSfx
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_stormBellActivateSfx));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_stormBellActivateSfx)) = value;
    }
  }

  public unsafe EventReference stormBellActivate10Sfx
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_stormBellActivate10Sfx));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_stormBellActivate10Sfx)) = value;
    }
  }

  public unsafe EventReference stormBellRandomizeSfx
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_stormBellRandomizeSfx));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_stormBellRandomizeSfx)) = value;
    }
  }

  public unsafe EventReference stormBellClearSfx
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_stormBellClearSfx));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_stormBellClearSfx)) = value;
    }
  }

  public unsafe List<string> activeNames
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_activeNames));
      return pointer == System.IntPtr.Zero ? (List<string>) null : new List<string>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_activeNames), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<string> golden
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_golden));
      return pointer == System.IntPtr.Zero ? (List<string>) null : new List<string>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_golden), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<string> newGolden
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_newGolden));
      return pointer == System.IntPtr.Zero ? (List<string>) null : new List<string>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_newGolden), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<HardModeModifierData> active
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_active));
      return pointer == System.IntPtr.Zero ? (List<HardModeModifierData>) null : new List<HardModeModifierData>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_active), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<ModifierIcon, HardModeModifierData> modifierIcons
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_modifierIcons));
      return pointer == System.IntPtr.Zero ? (Dictionary<ModifierIcon, HardModeModifierData>) null : new Dictionary<ModifierIcon, HardModeModifierData>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_modifierIcons), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool unlocked
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_unlocked));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_unlocked)) = value;
    }
  }

  public unsafe int points
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_points));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_points)) = value;
    }
  }

  public unsafe int maxPoints
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_maxPoints));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_maxPoints)) = value;
    }
  }

  public unsafe bool overcrank
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_overcrank));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_overcrank)) = value;
    }
  }

  public unsafe string stormStrengthAddText
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_stormStrengthAddText)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_stormStrengthAddText), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe EventInstance bellActivateSfxInstance
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_bellActivateSfxInstance));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_bellActivateSfxInstance)) = value;
    }
  }

  public unsafe EventInstance bellActivate10SfxInstance
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_bellActivate10SfxInstance));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_bellActivate10SfxInstance)) = value;
    }
  }

  public unsafe EventInstance bellRandomizeSfxInstance
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_bellRandomizeSfxInstance));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.NativeFieldInfoPtr_bellRandomizeSfxInstance)) = value;
    }
  }

  [ObfuscatedName("StormBellManager/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__40_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__40_0_Internal_String_HardModeModifierData_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StormBellManager.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StormBellManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string _Awake_b__40_0(HardModeModifierData a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(StormBellManager.__c.NativeMethodInfoPtr__Awake_b__40_0_Internal_String_HardModeModifierData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static __c()
    {
      Il2CppClassPointerStore<StormBellManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StormBellManager.__c>.NativeClassPtr);
      StormBellManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellManager.__c>.NativeClassPtr, "<>9");
      StormBellManager.__c.NativeFieldInfoPtr___9__40_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellManager.__c>.NativeClassPtr, "<>9__40_0");
      StormBellManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StormBellManager.__c>.NativeClassPtr, 100671393);
      StormBellManager.__c.NativeMethodInfoPtr__Awake_b__40_0_Internal_String_HardModeModifierData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StormBellManager.__c>.NativeClassPtr, 100671394);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe StormBellManager.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(StormBellManager.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (StormBellManager.__c) null : new StormBellManager.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StormBellManager.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<HardModeModifierData, string> __9__40_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(StormBellManager.__c.NativeFieldInfoPtr___9__40_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<HardModeModifierData, string>) null : new Il2CppSystem.Func<HardModeModifierData, string>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StormBellManager.__c.NativeFieldInfoPtr___9__40_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("StormBellManager/<>c__DisplayClass44_0")]
  public sealed class __c__DisplayClass44_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_modifier;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__CreateBell_b__0_Internal_Void_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass44_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StormBellManager.__c__DisplayClass44_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StormBellManager.__c__DisplayClass44_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93333, XrefRangeEnd = 93335, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _CreateBell_b__0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StormBellManager.__c__DisplayClass44_0.NativeMethodInfoPtr__CreateBell_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static __c__DisplayClass44_0()
    {
      Il2CppClassPointerStore<StormBellManager.__c__DisplayClass44_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, "<>c__DisplayClass44_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StormBellManager.__c__DisplayClass44_0>.NativeClassPtr);
      StormBellManager.__c__DisplayClass44_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellManager.__c__DisplayClass44_0>.NativeClassPtr, "<>4__this");
      StormBellManager.__c__DisplayClass44_0.NativeFieldInfoPtr_modifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellManager.__c__DisplayClass44_0>.NativeClassPtr, nameof (modifier));
      StormBellManager.__c__DisplayClass44_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StormBellManager.__c__DisplayClass44_0>.NativeClassPtr, 100671395);
      StormBellManager.__c__DisplayClass44_0.NativeMethodInfoPtr__CreateBell_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StormBellManager.__c__DisplayClass44_0>.NativeClassPtr, 100671396);
    }

    public __c__DisplayClass44_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe StormBellManager __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.__c__DisplayClass44_0.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (StormBellManager) null : new StormBellManager(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.__c__DisplayClass44_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HardModeModifierData modifier
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.__c__DisplayClass44_0.NativeFieldInfoPtr_modifier));
        return pointer == System.IntPtr.Zero ? (HardModeModifierData) null : new HardModeModifierData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.__c__DisplayClass44_0.NativeFieldInfoPtr_modifier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("StormBellManager/<>c__DisplayClass58_0")]
  public sealed class __c__DisplayClass58_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_modifierName;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GoldFrameRoutine_b__0_Internal_Boolean_KeyValuePair_2_ModifierIcon_HardModeModifierData_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass58_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StormBellManager.__c__DisplayClass58_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StormBellManager.__c__DisplayClass58_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93335, XrefRangeEnd = 93339, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _GoldFrameRoutine_b__0(KeyValuePair<ModifierIcon, HardModeModifierData> p)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) p))
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StormBellManager.__c__DisplayClass58_0.NativeMethodInfoPtr__GoldFrameRoutine_b__0_Internal_Boolean_KeyValuePair_2_ModifierIcon_HardModeModifierData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass58_0()
    {
      Il2CppClassPointerStore<StormBellManager.__c__DisplayClass58_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, "<>c__DisplayClass58_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StormBellManager.__c__DisplayClass58_0>.NativeClassPtr);
      StormBellManager.__c__DisplayClass58_0.NativeFieldInfoPtr_modifierName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellManager.__c__DisplayClass58_0>.NativeClassPtr, nameof (modifierName));
      StormBellManager.__c__DisplayClass58_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StormBellManager.__c__DisplayClass58_0>.NativeClassPtr, 100671397);
      StormBellManager.__c__DisplayClass58_0.NativeMethodInfoPtr__GoldFrameRoutine_b__0_Internal_Boolean_KeyValuePair_2_ModifierIcon_HardModeModifierData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StormBellManager.__c__DisplayClass58_0>.NativeClassPtr, 100671398);
    }

    public __c__DisplayClass58_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string modifierName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.__c__DisplayClass58_0.NativeFieldInfoPtr_modifierName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.__c__DisplayClass58_0.NativeFieldInfoPtr_modifierName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }

  [ObfuscatedName("StormBellManager/<GoldFrameRoutine>d__58")]
  public sealed class _GoldFrameRoutine_d__58 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr_modifierNames;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr___7__wrap1;
    private static readonly System.IntPtr NativeFieldInfoPtr___7__wrap2;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _GoldFrameRoutine_d__58(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StormBellManager._GoldFrameRoutine_d__58>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StormBellManager._GoldFrameRoutine_d__58.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StormBellManager._GoldFrameRoutine_d__58.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93339, XrefRangeEnd = 93376, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StormBellManager._GoldFrameRoutine_d__58.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StormBellManager._GoldFrameRoutine_d__58.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93376, XrefRangeEnd = 93382, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StormBellManager._GoldFrameRoutine_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StormBellManager._GoldFrameRoutine_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _GoldFrameRoutine_d__58()
    {
      Il2CppClassPointerStore<StormBellManager._GoldFrameRoutine_d__58>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, "<GoldFrameRoutine>d__58");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StormBellManager._GoldFrameRoutine_d__58>.NativeClassPtr);
      StormBellManager._GoldFrameRoutine_d__58.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellManager._GoldFrameRoutine_d__58>.NativeClassPtr, "<>1__state");
      StormBellManager._GoldFrameRoutine_d__58.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellManager._GoldFrameRoutine_d__58>.NativeClassPtr, "<>2__current");
      StormBellManager._GoldFrameRoutine_d__58.NativeFieldInfoPtr_modifierNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellManager._GoldFrameRoutine_d__58>.NativeClassPtr, nameof (modifierNames));
      StormBellManager._GoldFrameRoutine_d__58.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellManager._GoldFrameRoutine_d__58>.NativeClassPtr, "<>4__this");
      StormBellManager._GoldFrameRoutine_d__58.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellManager._GoldFrameRoutine_d__58>.NativeClassPtr, "<>7__wrap1");
      StormBellManager._GoldFrameRoutine_d__58.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellManager._GoldFrameRoutine_d__58>.NativeClassPtr, "<>7__wrap2");
      StormBellManager._GoldFrameRoutine_d__58.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StormBellManager._GoldFrameRoutine_d__58>.NativeClassPtr, 100671399);
      StormBellManager._GoldFrameRoutine_d__58.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StormBellManager._GoldFrameRoutine_d__58>.NativeClassPtr, 100671400);
      StormBellManager._GoldFrameRoutine_d__58.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StormBellManager._GoldFrameRoutine_d__58>.NativeClassPtr, 100671401);
      StormBellManager._GoldFrameRoutine_d__58.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StormBellManager._GoldFrameRoutine_d__58>.NativeClassPtr, 100671402);
      StormBellManager._GoldFrameRoutine_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StormBellManager._GoldFrameRoutine_d__58>.NativeClassPtr, 100671403);
      StormBellManager._GoldFrameRoutine_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StormBellManager._GoldFrameRoutine_d__58>.NativeClassPtr, 100671404);
    }

    public _GoldFrameRoutine_d__58(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager._GoldFrameRoutine_d__58.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager._GoldFrameRoutine_d__58.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager._GoldFrameRoutine_d__58.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager._GoldFrameRoutine_d__58.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppStringArray modifierNames
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager._GoldFrameRoutine_d__58.NativeFieldInfoPtr_modifierNames));
        return pointer == System.IntPtr.Zero ? (Il2CppStringArray) null : new Il2CppStringArray(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager._GoldFrameRoutine_d__58.NativeFieldInfoPtr_modifierNames), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe StormBellManager __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager._GoldFrameRoutine_d__58.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (StormBellManager) null : new StormBellManager(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager._GoldFrameRoutine_d__58.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppStringArray __7__wrap1
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager._GoldFrameRoutine_d__58.NativeFieldInfoPtr___7__wrap1));
        return pointer == System.IntPtr.Zero ? (Il2CppStringArray) null : new Il2CppStringArray(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager._GoldFrameRoutine_d__58.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int __7__wrap2
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager._GoldFrameRoutine_d__58.NativeFieldInfoPtr___7__wrap2));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager._GoldFrameRoutine_d__58.NativeFieldInfoPtr___7__wrap2)) = value;
      }
    }
  }

  [ObfuscatedName("StormBellManager/<>c__DisplayClass59_0")]
  public sealed class __c__DisplayClass59_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_modifier;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Randomize_b__0_Internal_Boolean_KeyValuePair_2_ModifierIcon_HardModeModifierData_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass59_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StormBellManager.__c__DisplayClass59_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StormBellManager.__c__DisplayClass59_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93382, XrefRangeEnd = 93387, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _Randomize_b__0(KeyValuePair<ModifierIcon, HardModeModifierData> p)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) p))
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StormBellManager.__c__DisplayClass59_0.NativeMethodInfoPtr__Randomize_b__0_Internal_Boolean_KeyValuePair_2_ModifierIcon_HardModeModifierData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass59_0()
    {
      Il2CppClassPointerStore<StormBellManager.__c__DisplayClass59_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StormBellManager>.NativeClassPtr, "<>c__DisplayClass59_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StormBellManager.__c__DisplayClass59_0>.NativeClassPtr);
      StormBellManager.__c__DisplayClass59_0.NativeFieldInfoPtr_modifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StormBellManager.__c__DisplayClass59_0>.NativeClassPtr, nameof (modifier));
      StormBellManager.__c__DisplayClass59_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StormBellManager.__c__DisplayClass59_0>.NativeClassPtr, 100671405);
      StormBellManager.__c__DisplayClass59_0.NativeMethodInfoPtr__Randomize_b__0_Internal_Boolean_KeyValuePair_2_ModifierIcon_HardModeModifierData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StormBellManager.__c__DisplayClass59_0>.NativeClassPtr, 100671406);
    }

    public __c__DisplayClass59_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe HardModeModifierData modifier
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.__c__DisplayClass59_0.NativeFieldInfoPtr_modifier));
        return pointer == System.IntPtr.Zero ? (HardModeModifierData) null : new HardModeModifierData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StormBellManager.__c__DisplayClass59_0.NativeFieldInfoPtr_modifier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
