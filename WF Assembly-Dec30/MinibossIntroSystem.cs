// Decompiled with JetBrains decompiler
// Type: MinibossIntroSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using FMODUnity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

#nullable disable
public class MinibossIntroSystem : GameSystem
{
  private static readonly System.IntPtr NativeFieldInfoPtr_container;
  private static readonly System.IntPtr NativeFieldInfoPtr_focusAmount;
  private static readonly System.IntPtr NativeFieldInfoPtr_zoomAmount;
  private static readonly System.IntPtr NativeFieldInfoPtr_focusTween;
  private static readonly System.IntPtr NativeFieldInfoPtr_unfocusTween;
  private static readonly System.IntPtr NativeFieldInfoPtr_fade;
  private static readonly System.IntPtr NativeFieldInfoPtr_fadeColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_move;
  private static readonly System.IntPtr NativeFieldInfoPtr_moveTween;
  private static readonly System.IntPtr NativeFieldInfoPtr_returnTween;
  private static readonly System.IntPtr NativeFieldInfoPtr_pauseBefore;
  private static readonly System.IntPtr NativeFieldInfoPtr_pauseAfter;
  private static readonly System.IntPtr NativeFieldInfoPtr_delayBefore;
  private static readonly System.IntPtr NativeFieldInfoPtr_delayAfter;
  private static readonly System.IntPtr NativeFieldInfoPtr_defaultAnimation;
  private static readonly System.IntPtr NativeFieldInfoPtr_specificAnimations;
  private static readonly System.IntPtr NativeFieldInfoPtr_zoomSfx;
  private static readonly System.IntPtr NativeFieldInfoPtr_shakeSfx;
  private static readonly System.IntPtr NativeFieldInfoPtr_ignore;
  private static readonly System.IntPtr NativeFieldInfoPtr_animationLookup;
  private static readonly System.IntPtr NativeFieldInfoPtr_target;
  private static readonly System.IntPtr NativeFieldInfoPtr_targetPreviousParent;
  private static readonly System.IntPtr NativeFieldInfoPtr_routine;
  private static readonly System.IntPtr NativeFieldInfoPtr_hasRun;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Ignore_Public_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SceneChanged_Private_Void_Scene_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntityMove_Private_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Activate_Private_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_WaitForRoutineToEnd_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Assign_Private_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnAssign_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Routine_Private_IEnumerator_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64493, XrefRangeEnd = 64519, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MinibossIntroSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64519, XrefRangeEnd = 64550, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MinibossIntroSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 64554, RefRangeEnd = 64556, XrefRangeStart = 64550, XrefRangeEnd = 64554, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Ignore(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MinibossIntroSystem.NativeMethodInfoPtr_Ignore_Public_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64556, XrefRangeEnd = 64558, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SceneChanged(Scene scene)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &scene
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MinibossIntroSystem.NativeMethodInfoPtr_SceneChanged_Private_Void_Scene_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64558, XrefRangeEnd = 64597, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntityMove(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MinibossIntroSystem.NativeMethodInfoPtr_EntityMove_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64597, XrefRangeEnd = 64625, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Activate(Entity target)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MinibossIntroSystem.NativeMethodInfoPtr_Activate_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64625, XrefRangeEnd = 64630, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator WaitForRoutineToEnd()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MinibossIntroSystem.NativeMethodInfoPtr_WaitForRoutineToEnd_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64630, XrefRangeEnd = 64639, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Assign(Entity target)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MinibossIntroSystem.NativeMethodInfoPtr_Assign_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 64647, RefRangeEnd = 64650, XrefRangeStart = 64639, XrefRangeEnd = 64647, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UnAssign()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MinibossIntroSystem.NativeMethodInfoPtr_UnAssign_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64650, XrefRangeEnd = 64656, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator Routine(Entity target)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MinibossIntroSystem.NativeMethodInfoPtr_Routine_Private_IEnumerator_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64656, XrefRangeEnd = 64665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MinibossIntroSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MinibossIntroSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MinibossIntroSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static MinibossIntroSystem()
  {
    Il2CppClassPointerStore<MinibossIntroSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (MinibossIntroSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MinibossIntroSystem>.NativeClassPtr);
    MinibossIntroSystem.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinibossIntroSystem>.NativeClassPtr, nameof (container));
    MinibossIntroSystem.NativeFieldInfoPtr_focusAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinibossIntroSystem>.NativeClassPtr, nameof (focusAmount));
    MinibossIntroSystem.NativeFieldInfoPtr_zoomAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinibossIntroSystem>.NativeClassPtr, nameof (zoomAmount));
    MinibossIntroSystem.NativeFieldInfoPtr_focusTween = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinibossIntroSystem>.NativeClassPtr, nameof (focusTween));
    MinibossIntroSystem.NativeFieldInfoPtr_unfocusTween = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinibossIntroSystem>.NativeClassPtr, nameof (unfocusTween));
    MinibossIntroSystem.NativeFieldInfoPtr_fade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinibossIntroSystem>.NativeClassPtr, nameof (fade));
    MinibossIntroSystem.NativeFieldInfoPtr_fadeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinibossIntroSystem>.NativeClassPtr, nameof (fadeColor));
    MinibossIntroSystem.NativeFieldInfoPtr_move = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinibossIntroSystem>.NativeClassPtr, nameof (move));
    MinibossIntroSystem.NativeFieldInfoPtr_moveTween = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinibossIntroSystem>.NativeClassPtr, nameof (moveTween));
    MinibossIntroSystem.NativeFieldInfoPtr_returnTween = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinibossIntroSystem>.NativeClassPtr, nameof (returnTween));
    MinibossIntroSystem.NativeFieldInfoPtr_pauseBefore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinibossIntroSystem>.NativeClassPtr, nameof (pauseBefore));
    MinibossIntroSystem.NativeFieldInfoPtr_pauseAfter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinibossIntroSystem>.NativeClassPtr, nameof (pauseAfter));
    MinibossIntroSystem.NativeFieldInfoPtr_delayBefore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinibossIntroSystem>.NativeClassPtr, nameof (delayBefore));
    MinibossIntroSystem.NativeFieldInfoPtr_delayAfter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinibossIntroSystem>.NativeClassPtr, nameof (delayAfter));
    MinibossIntroSystem.NativeFieldInfoPtr_defaultAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinibossIntroSystem>.NativeClassPtr, nameof (defaultAnimation));
    MinibossIntroSystem.NativeFieldInfoPtr_specificAnimations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinibossIntroSystem>.NativeClassPtr, nameof (specificAnimations));
    MinibossIntroSystem.NativeFieldInfoPtr_zoomSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinibossIntroSystem>.NativeClassPtr, nameof (zoomSfx));
    MinibossIntroSystem.NativeFieldInfoPtr_shakeSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinibossIntroSystem>.NativeClassPtr, nameof (shakeSfx));
    MinibossIntroSystem.NativeFieldInfoPtr_ignore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinibossIntroSystem>.NativeClassPtr, nameof (ignore));
    MinibossIntroSystem.NativeFieldInfoPtr_animationLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinibossIntroSystem>.NativeClassPtr, nameof (animationLookup));
    MinibossIntroSystem.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinibossIntroSystem>.NativeClassPtr, nameof (target));
    MinibossIntroSystem.NativeFieldInfoPtr_targetPreviousParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinibossIntroSystem>.NativeClassPtr, nameof (targetPreviousParent));
    MinibossIntroSystem.NativeFieldInfoPtr_routine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinibossIntroSystem>.NativeClassPtr, nameof (routine));
    MinibossIntroSystem.NativeFieldInfoPtr_hasRun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinibossIntroSystem>.NativeClassPtr, nameof (hasRun));
    MinibossIntroSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinibossIntroSystem>.NativeClassPtr, 100668564);
    MinibossIntroSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinibossIntroSystem>.NativeClassPtr, 100668565);
    MinibossIntroSystem.NativeMethodInfoPtr_Ignore_Public_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinibossIntroSystem>.NativeClassPtr, 100668566);
    MinibossIntroSystem.NativeMethodInfoPtr_SceneChanged_Private_Void_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinibossIntroSystem>.NativeClassPtr, 100668567);
    MinibossIntroSystem.NativeMethodInfoPtr_EntityMove_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinibossIntroSystem>.NativeClassPtr, 100668568);
    MinibossIntroSystem.NativeMethodInfoPtr_Activate_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinibossIntroSystem>.NativeClassPtr, 100668569);
    MinibossIntroSystem.NativeMethodInfoPtr_WaitForRoutineToEnd_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinibossIntroSystem>.NativeClassPtr, 100668570);
    MinibossIntroSystem.NativeMethodInfoPtr_Assign_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinibossIntroSystem>.NativeClassPtr, 100668571);
    MinibossIntroSystem.NativeMethodInfoPtr_UnAssign_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinibossIntroSystem>.NativeClassPtr, 100668572);
    MinibossIntroSystem.NativeMethodInfoPtr_Routine_Private_IEnumerator_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinibossIntroSystem>.NativeClassPtr, 100668573);
    MinibossIntroSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinibossIntroSystem>.NativeClassPtr, 100668574);
  }

  public MinibossIntroSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Transform container
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem.NativeFieldInfoPtr_container));
      return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float focusAmount
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem.NativeFieldInfoPtr_focusAmount));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem.NativeFieldInfoPtr_focusAmount)) = value;
    }
  }

  public unsafe float zoomAmount
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem.NativeFieldInfoPtr_zoomAmount));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem.NativeFieldInfoPtr_zoomAmount)) = value;
    }
  }

  public CurveProfile focusTween
  {
    get
    {
      System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem.NativeFieldInfoPtr_focusTween);
      return new CurveProfile(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CurveProfile>.NativeClassPtr, data));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem.NativeFieldInfoPtr_focusTween), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CurveProfile>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public CurveProfile unfocusTween
  {
    get
    {
      System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem.NativeFieldInfoPtr_unfocusTween);
      return new CurveProfile(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CurveProfile>.NativeClassPtr, data));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem.NativeFieldInfoPtr_unfocusTween), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CurveProfile>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe Image fade
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem.NativeFieldInfoPtr_fade));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem.NativeFieldInfoPtr_fade), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Color fadeColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem.NativeFieldInfoPtr_fadeColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem.NativeFieldInfoPtr_fadeColor)) = value;
    }
  }

  public unsafe Vector3 move
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem.NativeFieldInfoPtr_move));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem.NativeFieldInfoPtr_move)) = value;
    }
  }

  public CurveProfile moveTween
  {
    get
    {
      System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem.NativeFieldInfoPtr_moveTween);
      return new CurveProfile(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CurveProfile>.NativeClassPtr, data));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem.NativeFieldInfoPtr_moveTween), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CurveProfile>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public CurveProfile returnTween
  {
    get
    {
      System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem.NativeFieldInfoPtr_returnTween);
      return new CurveProfile(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CurveProfile>.NativeClassPtr, data));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem.NativeFieldInfoPtr_returnTween), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CurveProfile>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe float pauseBefore
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem.NativeFieldInfoPtr_pauseBefore));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem.NativeFieldInfoPtr_pauseBefore)) = value;
    }
  }

  public unsafe float pauseAfter
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem.NativeFieldInfoPtr_pauseAfter));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem.NativeFieldInfoPtr_pauseAfter)) = value;
    }
  }

  public unsafe float delayBefore
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem.NativeFieldInfoPtr_delayBefore));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem.NativeFieldInfoPtr_delayBefore)) = value;
    }
  }

  public unsafe float delayAfter
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem.NativeFieldInfoPtr_delayAfter));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem.NativeFieldInfoPtr_delayAfter)) = value;
    }
  }

  public unsafe CardAnimation defaultAnimation
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem.NativeFieldInfoPtr_defaultAnimation));
      return pointer == System.IntPtr.Zero ? (CardAnimation) null : new CardAnimation(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem.NativeFieldInfoPtr_defaultAnimation), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<MinibossIntroSystem.MinibossAnimation> specificAnimations
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem.NativeFieldInfoPtr_specificAnimations));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<MinibossIntroSystem.MinibossAnimation>) null : new Il2CppReferenceArray<MinibossIntroSystem.MinibossAnimation>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem.NativeFieldInfoPtr_specificAnimations), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe EventReference zoomSfx
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem.NativeFieldInfoPtr_zoomSfx));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem.NativeFieldInfoPtr_zoomSfx)) = value;
    }
  }

  public unsafe EventReference shakeSfx
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem.NativeFieldInfoPtr_shakeSfx));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem.NativeFieldInfoPtr_shakeSfx)) = value;
    }
  }

  public unsafe List<Entity> ignore
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem.NativeFieldInfoPtr_ignore));
      return pointer == System.IntPtr.Zero ? (List<Entity>) null : new List<Entity>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem.NativeFieldInfoPtr_ignore), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<string, CardAnimation> animationLookup
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem.NativeFieldInfoPtr_animationLookup));
      return pointer == System.IntPtr.Zero ? (Dictionary<string, CardAnimation>) null : new Dictionary<string, CardAnimation>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem.NativeFieldInfoPtr_animationLookup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Entity target
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem.NativeFieldInfoPtr_target));
      return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform targetPreviousParent
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem.NativeFieldInfoPtr_targetPreviousParent));
      return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem.NativeFieldInfoPtr_targetPreviousParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe global::Routine routine
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem.NativeFieldInfoPtr_routine));
      return pointer == System.IntPtr.Zero ? (global::Routine) null : new global::Routine(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem.NativeFieldInfoPtr_routine), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool hasRun
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem.NativeFieldInfoPtr_hasRun));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem.NativeFieldInfoPtr_hasRun)) = value;
    }
  }

  [Serializable]
  public sealed class MinibossAnimation : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_cardData;
    private static readonly System.IntPtr NativeFieldInfoPtr_animation;

    static MinibossAnimation()
    {
      Il2CppClassPointerStore<MinibossIntroSystem.MinibossAnimation>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MinibossIntroSystem>.NativeClassPtr, nameof (MinibossAnimation));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MinibossIntroSystem.MinibossAnimation>.NativeClassPtr);
      MinibossIntroSystem.MinibossAnimation.NativeFieldInfoPtr_cardData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinibossIntroSystem.MinibossAnimation>.NativeClassPtr, nameof (cardData));
      MinibossIntroSystem.MinibossAnimation.NativeFieldInfoPtr_animation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinibossIntroSystem.MinibossAnimation>.NativeClassPtr, nameof (animation));
    }

    public MinibossAnimation(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public MinibossAnimation()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MinibossIntroSystem.MinibossAnimation>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MinibossIntroSystem.MinibossAnimation>.NativeClassPtr, data));
    }

    public unsafe CardData cardData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem.MinibossAnimation.NativeFieldInfoPtr_cardData));
        return pointer == System.IntPtr.Zero ? (CardData) null : new CardData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem.MinibossAnimation.NativeFieldInfoPtr_cardData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CardAnimation animation
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem.MinibossAnimation.NativeFieldInfoPtr_animation));
        return pointer == System.IntPtr.Zero ? (CardAnimation) null : new CardAnimation(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem.MinibossAnimation.NativeFieldInfoPtr_animation), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("MinibossIntroSystem/<WaitForRoutineToEnd>d__30")]
  public sealed class _WaitForRoutineToEnd_d__30 : Il2CppSystem.Object
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
    public unsafe _WaitForRoutineToEnd_d__30(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MinibossIntroSystem._WaitForRoutineToEnd_d__30>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MinibossIntroSystem._WaitForRoutineToEnd_d__30.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MinibossIntroSystem._WaitForRoutineToEnd_d__30.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64346, XrefRangeEnd = 64348, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MinibossIntroSystem._WaitForRoutineToEnd_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MinibossIntroSystem._WaitForRoutineToEnd_d__30.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64348, XrefRangeEnd = 64354, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MinibossIntroSystem._WaitForRoutineToEnd_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MinibossIntroSystem._WaitForRoutineToEnd_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _WaitForRoutineToEnd_d__30()
    {
      Il2CppClassPointerStore<MinibossIntroSystem._WaitForRoutineToEnd_d__30>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MinibossIntroSystem>.NativeClassPtr, "<WaitForRoutineToEnd>d__30");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MinibossIntroSystem._WaitForRoutineToEnd_d__30>.NativeClassPtr);
      MinibossIntroSystem._WaitForRoutineToEnd_d__30.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinibossIntroSystem._WaitForRoutineToEnd_d__30>.NativeClassPtr, "<>1__state");
      MinibossIntroSystem._WaitForRoutineToEnd_d__30.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinibossIntroSystem._WaitForRoutineToEnd_d__30>.NativeClassPtr, "<>2__current");
      MinibossIntroSystem._WaitForRoutineToEnd_d__30.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinibossIntroSystem._WaitForRoutineToEnd_d__30>.NativeClassPtr, "<>4__this");
      MinibossIntroSystem._WaitForRoutineToEnd_d__30.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinibossIntroSystem._WaitForRoutineToEnd_d__30>.NativeClassPtr, 100668575);
      MinibossIntroSystem._WaitForRoutineToEnd_d__30.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinibossIntroSystem._WaitForRoutineToEnd_d__30>.NativeClassPtr, 100668576);
      MinibossIntroSystem._WaitForRoutineToEnd_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinibossIntroSystem._WaitForRoutineToEnd_d__30>.NativeClassPtr, 100668577);
      MinibossIntroSystem._WaitForRoutineToEnd_d__30.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinibossIntroSystem._WaitForRoutineToEnd_d__30>.NativeClassPtr, 100668578);
      MinibossIntroSystem._WaitForRoutineToEnd_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinibossIntroSystem._WaitForRoutineToEnd_d__30>.NativeClassPtr, 100668579);
      MinibossIntroSystem._WaitForRoutineToEnd_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinibossIntroSystem._WaitForRoutineToEnd_d__30>.NativeClassPtr, 100668580);
    }

    public _WaitForRoutineToEnd_d__30(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem._WaitForRoutineToEnd_d__30.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem._WaitForRoutineToEnd_d__30.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem._WaitForRoutineToEnd_d__30.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem._WaitForRoutineToEnd_d__30.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MinibossIntroSystem __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem._WaitForRoutineToEnd_d__30.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (MinibossIntroSystem) null : new MinibossIntroSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem._WaitForRoutineToEnd_d__30.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("MinibossIntroSystem/<>c__DisplayClass33_0")]
  public sealed class __c__DisplayClass33_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_target;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Routine_b__0_Internal_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Routine_b__1_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Routine_b__2_Internal_Void_Single_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass33_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MinibossIntroSystem.__c__DisplayClass33_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MinibossIntroSystem.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64354, XrefRangeEnd = 64355, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Routine_b__0(float a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &a
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MinibossIntroSystem.__c__DisplayClass33_0.NativeMethodInfoPtr__Routine_b__0_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64355, XrefRangeEnd = 64356, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Routine_b__1()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MinibossIntroSystem.__c__DisplayClass33_0.NativeMethodInfoPtr__Routine_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Routine_b__2(float a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &a
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MinibossIntroSystem.__c__DisplayClass33_0.NativeMethodInfoPtr__Routine_b__2_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static __c__DisplayClass33_0()
    {
      Il2CppClassPointerStore<MinibossIntroSystem.__c__DisplayClass33_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MinibossIntroSystem>.NativeClassPtr, "<>c__DisplayClass33_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MinibossIntroSystem.__c__DisplayClass33_0>.NativeClassPtr);
      MinibossIntroSystem.__c__DisplayClass33_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinibossIntroSystem.__c__DisplayClass33_0>.NativeClassPtr, "<>4__this");
      MinibossIntroSystem.__c__DisplayClass33_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinibossIntroSystem.__c__DisplayClass33_0>.NativeClassPtr, nameof (target));
      MinibossIntroSystem.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinibossIntroSystem.__c__DisplayClass33_0>.NativeClassPtr, 100668581);
      MinibossIntroSystem.__c__DisplayClass33_0.NativeMethodInfoPtr__Routine_b__0_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinibossIntroSystem.__c__DisplayClass33_0>.NativeClassPtr, 100668582);
      MinibossIntroSystem.__c__DisplayClass33_0.NativeMethodInfoPtr__Routine_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinibossIntroSystem.__c__DisplayClass33_0>.NativeClassPtr, 100668583);
      MinibossIntroSystem.__c__DisplayClass33_0.NativeMethodInfoPtr__Routine_b__2_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinibossIntroSystem.__c__DisplayClass33_0>.NativeClassPtr, 100668584);
    }

    public __c__DisplayClass33_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe MinibossIntroSystem __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem.__c__DisplayClass33_0.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (MinibossIntroSystem) null : new MinibossIntroSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem.__c__DisplayClass33_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Entity target
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem.__c__DisplayClass33_0.NativeFieldInfoPtr_target));
        return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem.__c__DisplayClass33_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("MinibossIntroSystem/<Routine>d__33")]
  public sealed class _Routine_d__33 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_target;
    private static readonly System.IntPtr NativeFieldInfoPtr___8__1;
    private static readonly System.IntPtr NativeFieldInfoPtr__originalCameraPos_5__2;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _Routine_d__33(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MinibossIntroSystem._Routine_d__33>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MinibossIntroSystem._Routine_d__33.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MinibossIntroSystem._Routine_d__33.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64356, XrefRangeEnd = 64487, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MinibossIntroSystem._Routine_d__33.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MinibossIntroSystem._Routine_d__33.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64487, XrefRangeEnd = 64493, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MinibossIntroSystem._Routine_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MinibossIntroSystem._Routine_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _Routine_d__33()
    {
      Il2CppClassPointerStore<MinibossIntroSystem._Routine_d__33>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MinibossIntroSystem>.NativeClassPtr, "<Routine>d__33");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MinibossIntroSystem._Routine_d__33>.NativeClassPtr);
      MinibossIntroSystem._Routine_d__33.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinibossIntroSystem._Routine_d__33>.NativeClassPtr, "<>1__state");
      MinibossIntroSystem._Routine_d__33.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinibossIntroSystem._Routine_d__33>.NativeClassPtr, "<>2__current");
      MinibossIntroSystem._Routine_d__33.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinibossIntroSystem._Routine_d__33>.NativeClassPtr, "<>4__this");
      MinibossIntroSystem._Routine_d__33.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinibossIntroSystem._Routine_d__33>.NativeClassPtr, nameof (target));
      MinibossIntroSystem._Routine_d__33.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinibossIntroSystem._Routine_d__33>.NativeClassPtr, "<>8__1");
      MinibossIntroSystem._Routine_d__33.NativeFieldInfoPtr__originalCameraPos_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinibossIntroSystem._Routine_d__33>.NativeClassPtr, "<originalCameraPos>5__2");
      MinibossIntroSystem._Routine_d__33.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinibossIntroSystem._Routine_d__33>.NativeClassPtr, 100668585);
      MinibossIntroSystem._Routine_d__33.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinibossIntroSystem._Routine_d__33>.NativeClassPtr, 100668586);
      MinibossIntroSystem._Routine_d__33.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinibossIntroSystem._Routine_d__33>.NativeClassPtr, 100668587);
      MinibossIntroSystem._Routine_d__33.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinibossIntroSystem._Routine_d__33>.NativeClassPtr, 100668588);
      MinibossIntroSystem._Routine_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinibossIntroSystem._Routine_d__33>.NativeClassPtr, 100668589);
      MinibossIntroSystem._Routine_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinibossIntroSystem._Routine_d__33>.NativeClassPtr, 100668590);
    }

    public _Routine_d__33(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem._Routine_d__33.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem._Routine_d__33.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem._Routine_d__33.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem._Routine_d__33.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MinibossIntroSystem __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem._Routine_d__33.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (MinibossIntroSystem) null : new MinibossIntroSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem._Routine_d__33.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Entity target
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem._Routine_d__33.NativeFieldInfoPtr_target));
        return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem._Routine_d__33.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MinibossIntroSystem.__c__DisplayClass33_0 __8__1
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem._Routine_d__33.NativeFieldInfoPtr___8__1));
        return pointer == System.IntPtr.Zero ? (MinibossIntroSystem.__c__DisplayClass33_0) null : new MinibossIntroSystem.__c__DisplayClass33_0(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem._Routine_d__33.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Vector3 _originalCameraPos_5__2
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem._Routine_d__33.NativeFieldInfoPtr__originalCameraPos_5__2));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinibossIntroSystem._Routine_d__33.NativeFieldInfoPtr__originalCameraPos_5__2)) = value;
      }
    }
  }
}
