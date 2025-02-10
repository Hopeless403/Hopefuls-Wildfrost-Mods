// Decompiled with JetBrains decompiler
// Type: UINavigationSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

#nullable disable
public class UINavigationSystem : MonoBehaviourSingleton<UINavigationSystem>
{
  private static readonly System.IntPtr NativeFieldInfoPtr_currentNavigationItem;
  private static readonly System.IntPtr NativeFieldInfoPtr_AvailableNavigationItems;
  private static readonly System.IntPtr NativeFieldInfoPtr_PossibleNavigationItems;
  private static readonly System.IntPtr NativeFieldInfoPtr_NavigationLayers;
  private static readonly System.IntPtr NativeFieldInfoPtr_ActiveNavigationLayer;
  private static readonly System.IntPtr NativeFieldInfoPtr_lastActiveNavigationLayer;
  private static readonly System.IntPtr NativeFieldInfoPtr_navigationControllerDeadzone;
  private static readonly System.IntPtr NativeFieldInfoPtr_lastMove;
  private static readonly System.IntPtr NativeFieldInfoPtr_navigationGridThreshold;
  private static readonly System.IntPtr NativeFieldInfoPtr_minorNavigationGridThreshold;
  private static readonly System.IntPtr NativeFieldInfoPtr_maxAnyItemCheckBeforeLoopMultiplier;
  private static readonly System.IntPtr NativeFieldInfoPtr_anglePriority;
  private static readonly System.IntPtr NativeFieldInfoPtr_disPriority;
  private static readonly System.IntPtr NativeFieldInfoPtr_maxNavAngle;
  private static readonly System.IntPtr NativeFieldInfoPtr_OnNavigate;
  private static readonly System.IntPtr NativeFieldInfoPtr_virtualCursor;
  private static readonly System.IntPtr NativeFieldInfoPtr_eventSystem;
  private static readonly System.IntPtr NativeFieldInfoPtr_eventSystemObj;
  private static readonly System.IntPtr NativeFieldInfoPtr_didNavigate;
  private static readonly System.IntPtr NativeFieldInfoPtr_lastNavigationItemPos;
  private static readonly System.IntPtr NativeFieldInfoPtr_currentNavigationItemChanged;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Events_OnEntityFlipComplete_Private_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Events_OnUINavigationReset_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Events_OnTransitionEnd_Private_Void_TransitionType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveActiveLayer_Internal_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RegisterSelectable_Internal_Void_UINavigationItem_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterSelectable_Internal_Void_UINavigationItem_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RegisterNavigationLayer_Internal_Void_UINavigationLayer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterNavigationLayer_Internal_Void_UINavigationLayer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetCursor_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResetState_Internal_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckForNavigation_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSelectable_Private_UINavigationItem_MoveDirection_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSelectable_Private_UINavigationItem_MoveDirection_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSelectable_Private_UINavigationItem_Vector3_Vector3_Predicate_1_UINavigationItem_Predicate_1_UINavigationItem_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSelectableLoop_Private_UINavigationItem_Vector3_Vector3_Predicate_1_UINavigationItem_Predicate_1_UINavigationItem_Predicate_1_UINavigationItem_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetCurrentNavigationItem_Public_Void_UINavigationItem_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__GetSelectable_b__36_0_Private_Boolean_UINavigationItem_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18628, XrefRangeEnd = 18657, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18657, XrefRangeEnd = 18679, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18679, XrefRangeEnd = 18701, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18701, XrefRangeEnd = 18714, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Events_OnEntityFlipComplete(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.NativeMethodInfoPtr_Events_OnEntityFlipComplete_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18714, XrefRangeEnd = 18715, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Events_OnUINavigationReset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.NativeMethodInfoPtr_Events_OnUINavigationReset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18715, XrefRangeEnd = 18716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Events_OnTransitionEnd(TransitionType transition)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transition)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.NativeMethodInfoPtr_Events_OnTransitionEnd_Private_Void_TransitionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18716, XrefRangeEnd = 18719, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveActiveLayer()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.NativeMethodInfoPtr_RemoveActiveLayer_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 18756, RefRangeEnd = 18757, XrefRangeStart = 18719, XrefRangeEnd = 18756, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RegisterSelectable(UINavigationItem uiNavigationItem)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) uiNavigationItem)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.NativeMethodInfoPtr_RegisterSelectable_Internal_Void_UINavigationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18757, XrefRangeEnd = 18763, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UnregisterSelectable(UINavigationItem uiNavigationItem)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) uiNavigationItem)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.NativeMethodInfoPtr_UnregisterSelectable_Internal_Void_UINavigationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18763, XrefRangeEnd = 18770, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RegisterNavigationLayer(UINavigationLayer navigationLayer)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) navigationLayer)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.NativeMethodInfoPtr_RegisterNavigationLayer_Internal_Void_UINavigationLayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 18859, RefRangeEnd = 18861, XrefRangeStart = 18770, XrefRangeEnd = 18859, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UnregisterNavigationLayer(UINavigationLayer navigationLayer)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) navigationLayer)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.NativeMethodInfoPtr_UnregisterNavigationLayer_Internal_Void_UINavigationLayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18861, XrefRangeEnd = 18888, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18888, XrefRangeEnd = 18899, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetCursor()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.NativeMethodInfoPtr_SetCursor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ResetState()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.NativeMethodInfoPtr_ResetState_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18899, XrefRangeEnd = 18999, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CheckForNavigation()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.NativeMethodInfoPtr_CheckForNavigation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 19023, RefRangeEnd = 19026, XrefRangeStart = 18999, XrefRangeEnd = 19023, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UINavigationItem GetSelectable(MoveDirection moveDirection)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &moveDirection
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.NativeMethodInfoPtr_GetSelectable_Private_UINavigationItem_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (UINavigationItem) null : new UINavigationItem(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 19166, RefRangeEnd = 19167, XrefRangeStart = 19026, XrefRangeEnd = 19166, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UINavigationItem GetSelectable(MoveDirection moveDirection, Vector3 currentPosition)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &moveDirection;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &currentPosition;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.NativeMethodInfoPtr_GetSelectable_Private_UINavigationItem_MoveDirection_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (UINavigationItem) null : new UINavigationItem(pointer);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 19193, RefRangeEnd = 19197, XrefRangeStart = 19167, XrefRangeEnd = 19193, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UINavigationItem GetSelectable(
    Vector3 currentPosition,
    Vector3 direction,
    Il2CppSystem.Predicate<UINavigationItem> directionCheck,
    Il2CppSystem.Predicate<UINavigationItem> alignmentCheck)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &currentPosition;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &direction;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) directionCheck);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) alignmentCheck);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.NativeMethodInfoPtr_GetSelectable_Private_UINavigationItem_Vector3_Vector3_Predicate_1_UINavigationItem_Predicate_1_UINavigationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (UINavigationItem) null : new UINavigationItem(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 19237, RefRangeEnd = 19238, XrefRangeStart = 19197, XrefRangeEnd = 19237, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UINavigationItem GetSelectableLoop(
    Vector3 currentPosition,
    Vector3 direction,
    Il2CppSystem.Predicate<UINavigationItem> directionCheck,
    Il2CppSystem.Predicate<UINavigationItem> alignmentCheck,
    Il2CppSystem.Predicate<UINavigationItem> fallbackCheck)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &currentPosition;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &direction;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) directionCheck);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) alignmentCheck);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) fallbackCheck);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.NativeMethodInfoPtr_GetSelectableLoop_Private_UINavigationItem_Vector3_Vector3_Predicate_1_UINavigationItem_Predicate_1_UINavigationItem_Predicate_1_UINavigationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (UINavigationItem) null : new UINavigationItem(pointer);
  }

  [CallerCount(11)]
  [CachedScanResults(RefRangeStart = 19308, RefRangeEnd = 19319, XrefRangeStart = 19238, XrefRangeEnd = 19308, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetCurrentNavigationItem(UINavigationItem navItem)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) navItem)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.NativeMethodInfoPtr_SetCurrentNavigationItem_Public_Void_UINavigationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19319, XrefRangeEnd = 19342, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UINavigationSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UINavigationSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19342, XrefRangeEnd = 19350, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool _GetSelectable_b__36_0(UINavigationItem x)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.NativeMethodInfoPtr__GetSelectable_b__36_0_Private_Boolean_UINavigationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  static UINavigationSystem()
  {
    Il2CppClassPointerStore<UINavigationSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (UINavigationSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UINavigationSystem>.NativeClassPtr);
    UINavigationSystem.NativeFieldInfoPtr_currentNavigationItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationSystem>.NativeClassPtr, nameof (currentNavigationItem));
    UINavigationSystem.NativeFieldInfoPtr_AvailableNavigationItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationSystem>.NativeClassPtr, nameof (AvailableNavigationItems));
    UINavigationSystem.NativeFieldInfoPtr_PossibleNavigationItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationSystem>.NativeClassPtr, nameof (PossibleNavigationItems));
    UINavigationSystem.NativeFieldInfoPtr_NavigationLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationSystem>.NativeClassPtr, nameof (NavigationLayers));
    UINavigationSystem.NativeFieldInfoPtr_ActiveNavigationLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationSystem>.NativeClassPtr, nameof (ActiveNavigationLayer));
    UINavigationSystem.NativeFieldInfoPtr_lastActiveNavigationLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationSystem>.NativeClassPtr, nameof (lastActiveNavigationLayer));
    UINavigationSystem.NativeFieldInfoPtr_navigationControllerDeadzone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationSystem>.NativeClassPtr, nameof (navigationControllerDeadzone));
    UINavigationSystem.NativeFieldInfoPtr_lastMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationSystem>.NativeClassPtr, nameof (lastMove));
    UINavigationSystem.NativeFieldInfoPtr_navigationGridThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationSystem>.NativeClassPtr, nameof (navigationGridThreshold));
    UINavigationSystem.NativeFieldInfoPtr_minorNavigationGridThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationSystem>.NativeClassPtr, nameof (minorNavigationGridThreshold));
    UINavigationSystem.NativeFieldInfoPtr_maxAnyItemCheckBeforeLoopMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationSystem>.NativeClassPtr, nameof (maxAnyItemCheckBeforeLoopMultiplier));
    UINavigationSystem.NativeFieldInfoPtr_anglePriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationSystem>.NativeClassPtr, nameof (anglePriority));
    UINavigationSystem.NativeFieldInfoPtr_disPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationSystem>.NativeClassPtr, nameof (disPriority));
    UINavigationSystem.NativeFieldInfoPtr_maxNavAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationSystem>.NativeClassPtr, nameof (maxNavAngle));
    UINavigationSystem.NativeFieldInfoPtr_OnNavigate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationSystem>.NativeClassPtr, nameof (OnNavigate));
    UINavigationSystem.NativeFieldInfoPtr_virtualCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationSystem>.NativeClassPtr, nameof (virtualCursor));
    UINavigationSystem.NativeFieldInfoPtr_eventSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationSystem>.NativeClassPtr, nameof (eventSystem));
    UINavigationSystem.NativeFieldInfoPtr_eventSystemObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationSystem>.NativeClassPtr, nameof (eventSystemObj));
    UINavigationSystem.NativeFieldInfoPtr_didNavigate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationSystem>.NativeClassPtr, nameof (didNavigate));
    UINavigationSystem.NativeFieldInfoPtr_lastNavigationItemPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationSystem>.NativeClassPtr, nameof (lastNavigationItemPos));
    UINavigationSystem.NativeFieldInfoPtr_currentNavigationItemChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationSystem>.NativeClassPtr, nameof (currentNavigationItemChanged));
    UINavigationSystem.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem>.NativeClassPtr, 100663568);
    UINavigationSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem>.NativeClassPtr, 100663569);
    UINavigationSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem>.NativeClassPtr, 100663570);
    UINavigationSystem.NativeMethodInfoPtr_Events_OnEntityFlipComplete_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem>.NativeClassPtr, 100663571);
    UINavigationSystem.NativeMethodInfoPtr_Events_OnUINavigationReset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem>.NativeClassPtr, 100663572);
    UINavigationSystem.NativeMethodInfoPtr_Events_OnTransitionEnd_Private_Void_TransitionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem>.NativeClassPtr, 100663573);
    UINavigationSystem.NativeMethodInfoPtr_RemoveActiveLayer_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem>.NativeClassPtr, 100663574);
    UINavigationSystem.NativeMethodInfoPtr_RegisterSelectable_Internal_Void_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem>.NativeClassPtr, 100663575);
    UINavigationSystem.NativeMethodInfoPtr_UnregisterSelectable_Internal_Void_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem>.NativeClassPtr, 100663576);
    UINavigationSystem.NativeMethodInfoPtr_RegisterNavigationLayer_Internal_Void_UINavigationLayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem>.NativeClassPtr, 100663577);
    UINavigationSystem.NativeMethodInfoPtr_UnregisterNavigationLayer_Internal_Void_UINavigationLayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem>.NativeClassPtr, 100663578);
    UINavigationSystem.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem>.NativeClassPtr, 100663579);
    UINavigationSystem.NativeMethodInfoPtr_SetCursor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem>.NativeClassPtr, 100663580);
    UINavigationSystem.NativeMethodInfoPtr_ResetState_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem>.NativeClassPtr, 100663581);
    UINavigationSystem.NativeMethodInfoPtr_CheckForNavigation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem>.NativeClassPtr, 100663582);
    UINavigationSystem.NativeMethodInfoPtr_GetSelectable_Private_UINavigationItem_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem>.NativeClassPtr, 100663583);
    UINavigationSystem.NativeMethodInfoPtr_GetSelectable_Private_UINavigationItem_MoveDirection_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem>.NativeClassPtr, 100663584);
    UINavigationSystem.NativeMethodInfoPtr_GetSelectable_Private_UINavigationItem_Vector3_Vector3_Predicate_1_UINavigationItem_Predicate_1_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem>.NativeClassPtr, 100663585);
    UINavigationSystem.NativeMethodInfoPtr_GetSelectableLoop_Private_UINavigationItem_Vector3_Vector3_Predicate_1_UINavigationItem_Predicate_1_UINavigationItem_Predicate_1_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem>.NativeClassPtr, 100663586);
    UINavigationSystem.NativeMethodInfoPtr_SetCurrentNavigationItem_Public_Void_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem>.NativeClassPtr, 100663587);
    UINavigationSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem>.NativeClassPtr, 100663588);
    UINavigationSystem.NativeMethodInfoPtr__GetSelectable_b__36_0_Private_Boolean_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem>.NativeClassPtr, 100663589);
  }

  public UINavigationSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe UINavigationItem currentNavigationItem
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.NativeFieldInfoPtr_currentNavigationItem));
      return pointer == System.IntPtr.Zero ? (UINavigationItem) null : new UINavigationItem(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.NativeFieldInfoPtr_currentNavigationItem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<UINavigationItem> AvailableNavigationItems
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.NativeFieldInfoPtr_AvailableNavigationItems));
      return pointer == System.IntPtr.Zero ? (List<UINavigationItem>) null : new List<UINavigationItem>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.NativeFieldInfoPtr_AvailableNavigationItems), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<UINavigationItem> PossibleNavigationItems
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.NativeFieldInfoPtr_PossibleNavigationItems));
      return pointer == System.IntPtr.Zero ? (List<UINavigationItem>) null : new List<UINavigationItem>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.NativeFieldInfoPtr_PossibleNavigationItems), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<UINavigationLayer> NavigationLayers
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.NativeFieldInfoPtr_NavigationLayers));
      return pointer == System.IntPtr.Zero ? (List<UINavigationLayer>) null : new List<UINavigationLayer>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.NativeFieldInfoPtr_NavigationLayers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe UINavigationLayer ActiveNavigationLayer
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(UINavigationSystem.NativeFieldInfoPtr_ActiveNavigationLayer, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (UINavigationLayer) null : new UINavigationLayer(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UINavigationSystem.NativeFieldInfoPtr_ActiveNavigationLayer, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UINavigationLayer lastActiveNavigationLayer
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.NativeFieldInfoPtr_lastActiveNavigationLayer));
      return pointer == System.IntPtr.Zero ? (UINavigationLayer) null : new UINavigationLayer(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.NativeFieldInfoPtr_lastActiveNavigationLayer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float navigationControllerDeadzone
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.NativeFieldInfoPtr_navigationControllerDeadzone));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.NativeFieldInfoPtr_navigationControllerDeadzone)) = value;
    }
  }

  public unsafe MoveDirection lastMove
  {
    get
    {
      return *(MoveDirection*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.NativeFieldInfoPtr_lastMove));
    }
    [param: In] set
    {
      *(MoveDirection*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.NativeFieldInfoPtr_lastMove)) = value;
    }
  }

  public unsafe float navigationGridThreshold
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.NativeFieldInfoPtr_navigationGridThreshold));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.NativeFieldInfoPtr_navigationGridThreshold)) = value;
    }
  }

  public unsafe float minorNavigationGridThreshold
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.NativeFieldInfoPtr_minorNavigationGridThreshold));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.NativeFieldInfoPtr_minorNavigationGridThreshold)) = value;
    }
  }

  public unsafe float maxAnyItemCheckBeforeLoopMultiplier
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.NativeFieldInfoPtr_maxAnyItemCheckBeforeLoopMultiplier));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.NativeFieldInfoPtr_maxAnyItemCheckBeforeLoopMultiplier)) = value;
    }
  }

  public unsafe float anglePriority
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.NativeFieldInfoPtr_anglePriority));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.NativeFieldInfoPtr_anglePriority)) = value;
    }
  }

  public unsafe float disPriority
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.NativeFieldInfoPtr_disPriority));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.NativeFieldInfoPtr_disPriority)) = value;
    }
  }

  public unsafe float maxNavAngle
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.NativeFieldInfoPtr_maxNavAngle));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.NativeFieldInfoPtr_maxNavAngle)) = value;
    }
  }

  public unsafe UnityEvent OnNavigate
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.NativeFieldInfoPtr_OnNavigate));
      return pointer == System.IntPtr.Zero ? (UnityEvent) null : new UnityEvent(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.NativeFieldInfoPtr_OnNavigate), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Cursor3d virtualCursor
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.NativeFieldInfoPtr_virtualCursor));
      return pointer == System.IntPtr.Zero ? (Cursor3d) null : new Cursor3d(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.NativeFieldInfoPtr_virtualCursor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CustomEventSystem eventSystem
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.NativeFieldInfoPtr_eventSystem));
      return pointer == System.IntPtr.Zero ? (CustomEventSystem) null : new CustomEventSystem(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.NativeFieldInfoPtr_eventSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject eventSystemObj
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.NativeFieldInfoPtr_eventSystemObj));
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.NativeFieldInfoPtr_eventSystemObj), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool didNavigate
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.NativeFieldInfoPtr_didNavigate));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.NativeFieldInfoPtr_didNavigate)) = value;
    }
  }

  public unsafe Vector3 lastNavigationItemPos
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.NativeFieldInfoPtr_lastNavigationItemPos));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.NativeFieldInfoPtr_lastNavigationItemPos)) = value;
    }
  }

  public unsafe bool currentNavigationItemChanged
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.NativeFieldInfoPtr_currentNavigationItemChanged));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.NativeFieldInfoPtr_currentNavigationItemChanged)) = value;
    }
  }

  [ObfuscatedName("UINavigationSystem/<>c__DisplayClass28_0")]
  public sealed class __c__DisplayClass28_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_uiNavigationItem;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__RegisterSelectable_b__0_Internal_Boolean_UINavigationItem_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass28_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass28_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18478, XrefRangeEnd = 18485, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _RegisterSelectable_b__0(UINavigationItem x)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.__c__DisplayClass28_0.NativeMethodInfoPtr__RegisterSelectable_b__0_Internal_Boolean_UINavigationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass28_0()
    {
      Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass28_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UINavigationSystem>.NativeClassPtr, "<>c__DisplayClass28_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass28_0>.NativeClassPtr);
      UINavigationSystem.__c__DisplayClass28_0.NativeFieldInfoPtr_uiNavigationItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass28_0>.NativeClassPtr, nameof (uiNavigationItem));
      UINavigationSystem.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass28_0>.NativeClassPtr, 100663590);
      UINavigationSystem.__c__DisplayClass28_0.NativeMethodInfoPtr__RegisterSelectable_b__0_Internal_Boolean_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass28_0>.NativeClassPtr, 100663591);
    }

    public __c__DisplayClass28_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe UINavigationItem uiNavigationItem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.__c__DisplayClass28_0.NativeFieldInfoPtr_uiNavigationItem));
        return pointer == System.IntPtr.Zero ? (UINavigationItem) null : new UINavigationItem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.__c__DisplayClass28_0.NativeFieldInfoPtr_uiNavigationItem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("UINavigationSystem/<>c__DisplayClass31_0")]
  public sealed class __c__DisplayClass31_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_navigationLayer;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__1;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__UnregisterNavigationLayer_b__1_Internal_Boolean_UINavigationItem_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass31_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass31_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18485, XrefRangeEnd = 18490, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _UnregisterNavigationLayer_b__1(UINavigationItem item)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) item)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.__c__DisplayClass31_0.NativeMethodInfoPtr__UnregisterNavigationLayer_b__1_Internal_Boolean_UINavigationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass31_0()
    {
      Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass31_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UINavigationSystem>.NativeClassPtr, "<>c__DisplayClass31_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass31_0>.NativeClassPtr);
      UINavigationSystem.__c__DisplayClass31_0.NativeFieldInfoPtr_navigationLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass31_0>.NativeClassPtr, nameof (navigationLayer));
      UINavigationSystem.__c__DisplayClass31_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass31_0>.NativeClassPtr, "<>9__1");
      UINavigationSystem.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass31_0>.NativeClassPtr, 100663592);
      UINavigationSystem.__c__DisplayClass31_0.NativeMethodInfoPtr__UnregisterNavigationLayer_b__1_Internal_Boolean_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass31_0>.NativeClassPtr, 100663593);
    }

    public __c__DisplayClass31_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe UINavigationLayer navigationLayer
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.__c__DisplayClass31_0.NativeFieldInfoPtr_navigationLayer));
        return pointer == System.IntPtr.Zero ? (UINavigationLayer) null : new UINavigationLayer(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.__c__DisplayClass31_0.NativeFieldInfoPtr_navigationLayer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Func<UINavigationItem, bool> __9__1
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.__c__DisplayClass31_0.NativeFieldInfoPtr___9__1));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<UINavigationItem, bool>) null : new Il2CppSystem.Func<UINavigationItem, bool>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.__c__DisplayClass31_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("UINavigationSystem/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__31_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__UnregisterNavigationLayer_b__31_0_Internal_Boolean_UINavigationLayer_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UINavigationSystem.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _UnregisterNavigationLayer_b__31_0(UINavigationLayer x)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.__c.NativeMethodInfoPtr__UnregisterNavigationLayer_b__31_0_Internal_Boolean_UINavigationLayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c()
    {
      Il2CppClassPointerStore<UINavigationSystem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UINavigationSystem>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UINavigationSystem.__c>.NativeClassPtr);
      UINavigationSystem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationSystem.__c>.NativeClassPtr, "<>9");
      UINavigationSystem.__c.NativeFieldInfoPtr___9__31_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationSystem.__c>.NativeClassPtr, "<>9__31_0");
      UINavigationSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem.__c>.NativeClassPtr, 100663595);
      UINavigationSystem.__c.NativeMethodInfoPtr__UnregisterNavigationLayer_b__31_0_Internal_Boolean_UINavigationLayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem.__c>.NativeClassPtr, 100663596);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe UINavigationSystem.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(UINavigationSystem.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (UINavigationSystem.__c) null : new UINavigationSystem.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UINavigationSystem.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<UINavigationLayer, bool> __9__31_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(UINavigationSystem.__c.NativeFieldInfoPtr___9__31_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<UINavigationLayer, bool>) null : new Il2CppSystem.Func<UINavigationLayer, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UINavigationSystem.__c.NativeFieldInfoPtr___9__31_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("UINavigationSystem/<>c__DisplayClass32_0")]
  public sealed class __c__DisplayClass32_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_activeNavigationLayer;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Update_b__0_Internal_Boolean_UINavigationItem_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass32_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass32_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18490, XrefRangeEnd = 18494, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _Update_b__0(UINavigationItem a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.__c__DisplayClass32_0.NativeMethodInfoPtr__Update_b__0_Internal_Boolean_UINavigationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass32_0()
    {
      Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass32_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UINavigationSystem>.NativeClassPtr, "<>c__DisplayClass32_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass32_0>.NativeClassPtr);
      UINavigationSystem.__c__DisplayClass32_0.NativeFieldInfoPtr_activeNavigationLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass32_0>.NativeClassPtr, nameof (activeNavigationLayer));
      UINavigationSystem.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass32_0>.NativeClassPtr, 100663597);
      UINavigationSystem.__c__DisplayClass32_0.NativeMethodInfoPtr__Update_b__0_Internal_Boolean_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass32_0>.NativeClassPtr, 100663598);
    }

    public __c__DisplayClass32_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe UINavigationLayer activeNavigationLayer
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.__c__DisplayClass32_0.NativeFieldInfoPtr_activeNavigationLayer));
        return pointer == System.IntPtr.Zero ? (UINavigationLayer) null : new UINavigationLayer(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.__c__DisplayClass32_0.NativeFieldInfoPtr_activeNavigationLayer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("UINavigationSystem/<>c__DisplayClass37_0")]
  public sealed class __c__DisplayClass37_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_currentPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetSelectable_b__0_Internal_Boolean_UINavigationItem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetSelectable_b__1_Internal_Boolean_UINavigationItem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetSelectable_b__2_Internal_Boolean_UINavigationItem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetSelectable_b__3_Internal_Boolean_UINavigationItem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetSelectable_b__4_Internal_Boolean_UINavigationItem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetSelectable_b__5_Internal_Boolean_UINavigationItem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetSelectable_b__6_Internal_Boolean_UINavigationItem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetSelectable_b__7_Internal_Boolean_UINavigationItem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetSelectable_b__8_Internal_Boolean_UINavigationItem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetSelectable_b__9_Internal_Boolean_UINavigationItem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetSelectable_b__10_Internal_Boolean_UINavigationItem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetSelectable_b__11_Internal_Boolean_UINavigationItem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetSelectable_b__12_Internal_Boolean_UINavigationItem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetSelectable_b__13_Internal_Boolean_UINavigationItem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetSelectable_b__14_Internal_Boolean_UINavigationItem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetSelectable_b__15_Internal_Boolean_UINavigationItem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetSelectable_b__16_Internal_Boolean_UINavigationItem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetSelectable_b__17_Internal_Boolean_UINavigationItem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetSelectable_b__18_Internal_Boolean_UINavigationItem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetSelectable_b__19_Internal_Boolean_UINavigationItem_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass37_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass37_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18494, XrefRangeEnd = 18496, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _GetSelectable_b__0(UINavigationItem a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.__c__DisplayClass37_0.NativeMethodInfoPtr__GetSelectable_b__0_Internal_Boolean_UINavigationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18496, XrefRangeEnd = 18498, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _GetSelectable_b__1(UINavigationItem a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.__c__DisplayClass37_0.NativeMethodInfoPtr__GetSelectable_b__1_Internal_Boolean_UINavigationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18498, XrefRangeEnd = 18500, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _GetSelectable_b__2(UINavigationItem a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.__c__DisplayClass37_0.NativeMethodInfoPtr__GetSelectable_b__2_Internal_Boolean_UINavigationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18500, XrefRangeEnd = 18502, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _GetSelectable_b__3(UINavigationItem a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.__c__DisplayClass37_0.NativeMethodInfoPtr__GetSelectable_b__3_Internal_Boolean_UINavigationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18502, XrefRangeEnd = 18504, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _GetSelectable_b__4(UINavigationItem a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.__c__DisplayClass37_0.NativeMethodInfoPtr__GetSelectable_b__4_Internal_Boolean_UINavigationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _GetSelectable_b__5(UINavigationItem a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.__c__DisplayClass37_0.NativeMethodInfoPtr__GetSelectable_b__5_Internal_Boolean_UINavigationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18504, XrefRangeEnd = 18506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _GetSelectable_b__6(UINavigationItem a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.__c__DisplayClass37_0.NativeMethodInfoPtr__GetSelectable_b__6_Internal_Boolean_UINavigationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _GetSelectable_b__7(UINavigationItem a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.__c__DisplayClass37_0.NativeMethodInfoPtr__GetSelectable_b__7_Internal_Boolean_UINavigationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _GetSelectable_b__8(UINavigationItem a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.__c__DisplayClass37_0.NativeMethodInfoPtr__GetSelectable_b__8_Internal_Boolean_UINavigationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _GetSelectable_b__9(UINavigationItem a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.__c__DisplayClass37_0.NativeMethodInfoPtr__GetSelectable_b__9_Internal_Boolean_UINavigationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18506, XrefRangeEnd = 18508, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _GetSelectable_b__10(UINavigationItem a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.__c__DisplayClass37_0.NativeMethodInfoPtr__GetSelectable_b__10_Internal_Boolean_UINavigationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18508, XrefRangeEnd = 18510, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _GetSelectable_b__11(UINavigationItem a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.__c__DisplayClass37_0.NativeMethodInfoPtr__GetSelectable_b__11_Internal_Boolean_UINavigationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18510, XrefRangeEnd = 18512, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _GetSelectable_b__12(UINavigationItem a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.__c__DisplayClass37_0.NativeMethodInfoPtr__GetSelectable_b__12_Internal_Boolean_UINavigationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18512, XrefRangeEnd = 18514, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _GetSelectable_b__13(UINavigationItem a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.__c__DisplayClass37_0.NativeMethodInfoPtr__GetSelectable_b__13_Internal_Boolean_UINavigationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18514, XrefRangeEnd = 18516, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _GetSelectable_b__14(UINavigationItem a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.__c__DisplayClass37_0.NativeMethodInfoPtr__GetSelectable_b__14_Internal_Boolean_UINavigationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _GetSelectable_b__15(UINavigationItem a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.__c__DisplayClass37_0.NativeMethodInfoPtr__GetSelectable_b__15_Internal_Boolean_UINavigationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18516, XrefRangeEnd = 18518, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _GetSelectable_b__16(UINavigationItem a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.__c__DisplayClass37_0.NativeMethodInfoPtr__GetSelectable_b__16_Internal_Boolean_UINavigationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _GetSelectable_b__17(UINavigationItem a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.__c__DisplayClass37_0.NativeMethodInfoPtr__GetSelectable_b__17_Internal_Boolean_UINavigationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _GetSelectable_b__18(UINavigationItem a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.__c__DisplayClass37_0.NativeMethodInfoPtr__GetSelectable_b__18_Internal_Boolean_UINavigationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _GetSelectable_b__19(UINavigationItem a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.__c__DisplayClass37_0.NativeMethodInfoPtr__GetSelectable_b__19_Internal_Boolean_UINavigationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass37_0()
    {
      Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass37_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UINavigationSystem>.NativeClassPtr, "<>c__DisplayClass37_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass37_0>.NativeClassPtr);
      UINavigationSystem.__c__DisplayClass37_0.NativeFieldInfoPtr_currentPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass37_0>.NativeClassPtr, nameof (currentPosition));
      UINavigationSystem.__c__DisplayClass37_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass37_0>.NativeClassPtr, "<>4__this");
      UINavigationSystem.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass37_0>.NativeClassPtr, 100663599);
      UINavigationSystem.__c__DisplayClass37_0.NativeMethodInfoPtr__GetSelectable_b__0_Internal_Boolean_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass37_0>.NativeClassPtr, 100663600);
      UINavigationSystem.__c__DisplayClass37_0.NativeMethodInfoPtr__GetSelectable_b__1_Internal_Boolean_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass37_0>.NativeClassPtr, 100663601);
      UINavigationSystem.__c__DisplayClass37_0.NativeMethodInfoPtr__GetSelectable_b__2_Internal_Boolean_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass37_0>.NativeClassPtr, 100663602);
      UINavigationSystem.__c__DisplayClass37_0.NativeMethodInfoPtr__GetSelectable_b__3_Internal_Boolean_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass37_0>.NativeClassPtr, 100663603);
      UINavigationSystem.__c__DisplayClass37_0.NativeMethodInfoPtr__GetSelectable_b__4_Internal_Boolean_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass37_0>.NativeClassPtr, 100663604);
      UINavigationSystem.__c__DisplayClass37_0.NativeMethodInfoPtr__GetSelectable_b__5_Internal_Boolean_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass37_0>.NativeClassPtr, 100663605);
      UINavigationSystem.__c__DisplayClass37_0.NativeMethodInfoPtr__GetSelectable_b__6_Internal_Boolean_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass37_0>.NativeClassPtr, 100663606);
      UINavigationSystem.__c__DisplayClass37_0.NativeMethodInfoPtr__GetSelectable_b__7_Internal_Boolean_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass37_0>.NativeClassPtr, 100663607);
      UINavigationSystem.__c__DisplayClass37_0.NativeMethodInfoPtr__GetSelectable_b__8_Internal_Boolean_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass37_0>.NativeClassPtr, 100663608);
      UINavigationSystem.__c__DisplayClass37_0.NativeMethodInfoPtr__GetSelectable_b__9_Internal_Boolean_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass37_0>.NativeClassPtr, 100663609);
      UINavigationSystem.__c__DisplayClass37_0.NativeMethodInfoPtr__GetSelectable_b__10_Internal_Boolean_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass37_0>.NativeClassPtr, 100663610);
      UINavigationSystem.__c__DisplayClass37_0.NativeMethodInfoPtr__GetSelectable_b__11_Internal_Boolean_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass37_0>.NativeClassPtr, 100663611);
      UINavigationSystem.__c__DisplayClass37_0.NativeMethodInfoPtr__GetSelectable_b__12_Internal_Boolean_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass37_0>.NativeClassPtr, 100663612);
      UINavigationSystem.__c__DisplayClass37_0.NativeMethodInfoPtr__GetSelectable_b__13_Internal_Boolean_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass37_0>.NativeClassPtr, 100663613);
      UINavigationSystem.__c__DisplayClass37_0.NativeMethodInfoPtr__GetSelectable_b__14_Internal_Boolean_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass37_0>.NativeClassPtr, 100663614);
      UINavigationSystem.__c__DisplayClass37_0.NativeMethodInfoPtr__GetSelectable_b__15_Internal_Boolean_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass37_0>.NativeClassPtr, 100663615);
      UINavigationSystem.__c__DisplayClass37_0.NativeMethodInfoPtr__GetSelectable_b__16_Internal_Boolean_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass37_0>.NativeClassPtr, 100663616);
      UINavigationSystem.__c__DisplayClass37_0.NativeMethodInfoPtr__GetSelectable_b__17_Internal_Boolean_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass37_0>.NativeClassPtr, 100663617);
      UINavigationSystem.__c__DisplayClass37_0.NativeMethodInfoPtr__GetSelectable_b__18_Internal_Boolean_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass37_0>.NativeClassPtr, 100663618);
      UINavigationSystem.__c__DisplayClass37_0.NativeMethodInfoPtr__GetSelectable_b__19_Internal_Boolean_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass37_0>.NativeClassPtr, 100663619);
    }

    public __c__DisplayClass37_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Vector3 currentPosition
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.__c__DisplayClass37_0.NativeFieldInfoPtr_currentPosition));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.__c__DisplayClass37_0.NativeFieldInfoPtr_currentPosition)) = value;
      }
    }

    public unsafe UINavigationSystem __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.__c__DisplayClass37_0.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (UINavigationSystem) null : new UINavigationSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.__c__DisplayClass37_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("UINavigationSystem/<>c__DisplayClass38_0")]
  public sealed class __c__DisplayClass38_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_directionCheck;
    private static readonly System.IntPtr NativeFieldInfoPtr_alignmentCheck;
    private static readonly System.IntPtr NativeFieldInfoPtr_currentPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_direction;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetSelectable_b__0_Internal_Boolean_UINavigationItem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetSelectable_b__1_Internal_Single_UINavigationItem_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass38_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass38_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _GetSelectable_b__0(UINavigationItem a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.__c__DisplayClass38_0.NativeMethodInfoPtr__GetSelectable_b__0_Internal_Boolean_UINavigationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18518, XrefRangeEnd = 18529, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float _GetSelectable_b__1(UINavigationItem a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.__c__DisplayClass38_0.NativeMethodInfoPtr__GetSelectable_b__1_Internal_Single_UINavigationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass38_0()
    {
      Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass38_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UINavigationSystem>.NativeClassPtr, "<>c__DisplayClass38_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass38_0>.NativeClassPtr);
      UINavigationSystem.__c__DisplayClass38_0.NativeFieldInfoPtr_directionCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass38_0>.NativeClassPtr, nameof (directionCheck));
      UINavigationSystem.__c__DisplayClass38_0.NativeFieldInfoPtr_alignmentCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass38_0>.NativeClassPtr, nameof (alignmentCheck));
      UINavigationSystem.__c__DisplayClass38_0.NativeFieldInfoPtr_currentPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass38_0>.NativeClassPtr, nameof (currentPosition));
      UINavigationSystem.__c__DisplayClass38_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass38_0>.NativeClassPtr, "<>4__this");
      UINavigationSystem.__c__DisplayClass38_0.NativeFieldInfoPtr_direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass38_0>.NativeClassPtr, nameof (direction));
      UINavigationSystem.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass38_0>.NativeClassPtr, 100663620);
      UINavigationSystem.__c__DisplayClass38_0.NativeMethodInfoPtr__GetSelectable_b__0_Internal_Boolean_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass38_0>.NativeClassPtr, 100663621);
      UINavigationSystem.__c__DisplayClass38_0.NativeMethodInfoPtr__GetSelectable_b__1_Internal_Single_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass38_0>.NativeClassPtr, 100663622);
    }

    public __c__DisplayClass38_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppSystem.Predicate<UINavigationItem> directionCheck
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.__c__DisplayClass38_0.NativeFieldInfoPtr_directionCheck));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Predicate<UINavigationItem>) null : new Il2CppSystem.Predicate<UINavigationItem>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.__c__DisplayClass38_0.NativeFieldInfoPtr_directionCheck), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Predicate<UINavigationItem> alignmentCheck
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.__c__DisplayClass38_0.NativeFieldInfoPtr_alignmentCheck));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Predicate<UINavigationItem>) null : new Il2CppSystem.Predicate<UINavigationItem>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.__c__DisplayClass38_0.NativeFieldInfoPtr_alignmentCheck), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Vector3 currentPosition
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.__c__DisplayClass38_0.NativeFieldInfoPtr_currentPosition));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.__c__DisplayClass38_0.NativeFieldInfoPtr_currentPosition)) = value;
      }
    }

    public unsafe UINavigationSystem __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.__c__DisplayClass38_0.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (UINavigationSystem) null : new UINavigationSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.__c__DisplayClass38_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Vector3 direction
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.__c__DisplayClass38_0.NativeFieldInfoPtr_direction));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.__c__DisplayClass38_0.NativeFieldInfoPtr_direction)) = value;
      }
    }
  }

  [ObfuscatedName("UINavigationSystem/<>c__DisplayClass39_0")]
  public sealed class __c__DisplayClass39_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_directionCheck;
    private static readonly System.IntPtr NativeFieldInfoPtr_alignmentCheck;
    private static readonly System.IntPtr NativeFieldInfoPtr_fallbackCheck;
    private static readonly System.IntPtr NativeFieldInfoPtr_currentPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_direction;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetSelectableLoop_b__0_Internal_Boolean_UINavigationItem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetSelectableLoop_b__1_Internal_Boolean_UINavigationItem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetSelectableLoop_b__2_Internal_Single_UINavigationItem_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass39_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass39_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _GetSelectableLoop_b__0(UINavigationItem a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.__c__DisplayClass39_0.NativeMethodInfoPtr__GetSelectableLoop_b__0_Internal_Boolean_UINavigationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18529, XrefRangeEnd = 18530, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _GetSelectableLoop_b__1(UINavigationItem a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.__c__DisplayClass39_0.NativeMethodInfoPtr__GetSelectableLoop_b__1_Internal_Boolean_UINavigationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18530, XrefRangeEnd = 18533, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float _GetSelectableLoop_b__2(UINavigationItem a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.__c__DisplayClass39_0.NativeMethodInfoPtr__GetSelectableLoop_b__2_Internal_Single_UINavigationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass39_0()
    {
      Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass39_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UINavigationSystem>.NativeClassPtr, "<>c__DisplayClass39_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass39_0>.NativeClassPtr);
      UINavigationSystem.__c__DisplayClass39_0.NativeFieldInfoPtr_directionCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass39_0>.NativeClassPtr, nameof (directionCheck));
      UINavigationSystem.__c__DisplayClass39_0.NativeFieldInfoPtr_alignmentCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass39_0>.NativeClassPtr, nameof (alignmentCheck));
      UINavigationSystem.__c__DisplayClass39_0.NativeFieldInfoPtr_fallbackCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass39_0>.NativeClassPtr, nameof (fallbackCheck));
      UINavigationSystem.__c__DisplayClass39_0.NativeFieldInfoPtr_currentPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass39_0>.NativeClassPtr, nameof (currentPosition));
      UINavigationSystem.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass39_0>.NativeClassPtr, "<>4__this");
      UINavigationSystem.__c__DisplayClass39_0.NativeFieldInfoPtr_direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass39_0>.NativeClassPtr, nameof (direction));
      UINavigationSystem.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass39_0>.NativeClassPtr, 100663623);
      UINavigationSystem.__c__DisplayClass39_0.NativeMethodInfoPtr__GetSelectableLoop_b__0_Internal_Boolean_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass39_0>.NativeClassPtr, 100663624);
      UINavigationSystem.__c__DisplayClass39_0.NativeMethodInfoPtr__GetSelectableLoop_b__1_Internal_Boolean_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass39_0>.NativeClassPtr, 100663625);
      UINavigationSystem.__c__DisplayClass39_0.NativeMethodInfoPtr__GetSelectableLoop_b__2_Internal_Single_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass39_0>.NativeClassPtr, 100663626);
    }

    public __c__DisplayClass39_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppSystem.Predicate<UINavigationItem> directionCheck
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.__c__DisplayClass39_0.NativeFieldInfoPtr_directionCheck));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Predicate<UINavigationItem>) null : new Il2CppSystem.Predicate<UINavigationItem>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.__c__DisplayClass39_0.NativeFieldInfoPtr_directionCheck), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Predicate<UINavigationItem> alignmentCheck
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.__c__DisplayClass39_0.NativeFieldInfoPtr_alignmentCheck));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Predicate<UINavigationItem>) null : new Il2CppSystem.Predicate<UINavigationItem>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.__c__DisplayClass39_0.NativeFieldInfoPtr_alignmentCheck), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Predicate<UINavigationItem> fallbackCheck
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.__c__DisplayClass39_0.NativeFieldInfoPtr_fallbackCheck));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Predicate<UINavigationItem>) null : new Il2CppSystem.Predicate<UINavigationItem>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.__c__DisplayClass39_0.NativeFieldInfoPtr_fallbackCheck), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Vector3 currentPosition
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.__c__DisplayClass39_0.NativeFieldInfoPtr_currentPosition));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.__c__DisplayClass39_0.NativeFieldInfoPtr_currentPosition)) = value;
      }
    }

    public unsafe UINavigationSystem __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (UINavigationSystem) null : new UINavigationSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Vector3 direction
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.__c__DisplayClass39_0.NativeFieldInfoPtr_direction));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.__c__DisplayClass39_0.NativeFieldInfoPtr_direction)) = value;
      }
    }
  }

  [ObfuscatedName("UINavigationSystem/<>c__DisplayClass39_1")]
  public sealed class __c__DisplayClass39_1 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_furthestPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass39_0_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetSelectableLoop_b__3_Internal_Single_UINavigationItem_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass39_1()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass39_1>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.__c__DisplayClass39_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18533, XrefRangeEnd = 18544, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float _GetSelectableLoop_b__3(UINavigationItem a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.__c__DisplayClass39_1.NativeMethodInfoPtr__GetSelectableLoop_b__3_Internal_Single_UINavigationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass39_1()
    {
      Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass39_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UINavigationSystem>.NativeClassPtr, "<>c__DisplayClass39_1");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass39_1>.NativeClassPtr);
      UINavigationSystem.__c__DisplayClass39_1.NativeFieldInfoPtr_furthestPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass39_1>.NativeClassPtr, nameof (furthestPosition));
      UINavigationSystem.__c__DisplayClass39_1.NativeFieldInfoPtr_field_Public___c__DisplayClass39_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass39_1>.NativeClassPtr, "CS$<>8__locals1");
      UINavigationSystem.__c__DisplayClass39_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass39_1>.NativeClassPtr, 100663627);
      UINavigationSystem.__c__DisplayClass39_1.NativeMethodInfoPtr__GetSelectableLoop_b__3_Internal_Single_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass39_1>.NativeClassPtr, 100663628);
    }

    public __c__DisplayClass39_1(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Vector3 furthestPosition
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.__c__DisplayClass39_1.NativeFieldInfoPtr_furthestPosition));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.__c__DisplayClass39_1.NativeFieldInfoPtr_furthestPosition)) = value;
      }
    }

    public unsafe UINavigationSystem.__c__DisplayClass39_0 field_Public___c__DisplayClass39_0_0
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.__c__DisplayClass39_1.NativeFieldInfoPtr_field_Public___c__DisplayClass39_0_0));
        return pointer == System.IntPtr.Zero ? (UINavigationSystem.__c__DisplayClass39_0) null : new UINavigationSystem.__c__DisplayClass39_0(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.__c__DisplayClass39_1.NativeFieldInfoPtr_field_Public___c__DisplayClass39_0_0), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("UINavigationSystem/<>c__DisplayClass40_0")]
  public sealed class __c__DisplayClass40_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_navItem;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__SetCurrentNavigationItem_b__0_Internal_Boolean_UINavigationItem_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass40_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass40_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.__c__DisplayClass40_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18544, XrefRangeEnd = 18628, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _SetCurrentNavigationItem_b__0(UINavigationItem a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationSystem.__c__DisplayClass40_0.NativeMethodInfoPtr__SetCurrentNavigationItem_b__0_Internal_Boolean_UINavigationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass40_0()
    {
      Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass40_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UINavigationSystem>.NativeClassPtr, "<>c__DisplayClass40_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass40_0>.NativeClassPtr);
      UINavigationSystem.__c__DisplayClass40_0.NativeFieldInfoPtr_navItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass40_0>.NativeClassPtr, nameof (navItem));
      UINavigationSystem.__c__DisplayClass40_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass40_0>.NativeClassPtr, 100663629);
      UINavigationSystem.__c__DisplayClass40_0.NativeMethodInfoPtr__SetCurrentNavigationItem_b__0_Internal_Boolean_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationSystem.__c__DisplayClass40_0>.NativeClassPtr, 100663630);
    }

    public __c__DisplayClass40_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe UINavigationItem navItem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.__c__DisplayClass40_0.NativeFieldInfoPtr_navItem));
        return pointer == System.IntPtr.Zero ? (UINavigationItem) null : new UINavigationItem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UINavigationSystem.__c__DisplayClass40_0.NativeFieldInfoPtr_navItem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
