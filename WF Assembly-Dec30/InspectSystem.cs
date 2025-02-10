// Decompiled with JetBrains decompiler
// Type: InspectSystem
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
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class InspectSystem : GameSystem
{
  private static readonly System.IntPtr NativeFieldInfoPtr_container;
  private static readonly System.IntPtr NativeFieldInfoPtr_cardHolder;
  private static readonly System.IntPtr NativeFieldInfoPtr_openInput;
  private static readonly System.IntPtr NativeFieldInfoPtr_closeInputs;
  private static readonly System.IntPtr NativeFieldInfoPtr_inspectCharmsInput;
  private static readonly System.IntPtr NativeFieldInfoPtr_cardScale;
  private static readonly System.IntPtr NativeFieldInfoPtr_cardRandomAngle;
  private static readonly System.IntPtr NativeFieldInfoPtr_hover;
  private static readonly System.IntPtr NativeFieldInfoPtr_idleAnimation;
  private static readonly System.IntPtr NativeFieldInfoPtr_idleAnimationFactor;
  private static readonly System.IntPtr NativeFieldInfoPtr_canInspectDelay;
  private static readonly System.IntPtr NativeFieldInfoPtr_canEndDelay;
  private static readonly System.IntPtr NativeFieldInfoPtr_injuredKeyword;
  private static readonly System.IntPtr NativeFieldInfoPtr_wait;
  private static readonly System.IntPtr NativeFieldInfoPtr_inspectCharmsLayout;
  private static readonly System.IntPtr NativeFieldInfoPtr_inspectCharmsSystem;
  private static readonly System.IntPtr NativeFieldInfoPtr_leftPopGroup;
  private static readonly System.IntPtr NativeFieldInfoPtr_leftOverflowPopGroup;
  private static readonly System.IntPtr NativeFieldInfoPtr_rightPopGroup;
  private static readonly System.IntPtr NativeFieldInfoPtr_rightOverflowPopGroup;
  private static readonly System.IntPtr NativeFieldInfoPtr_bottomPopGroup;
  private static readonly System.IntPtr NativeFieldInfoPtr_notePopGroup;
  private static readonly System.IntPtr NativeFieldInfoPtr_overflowOrder;
  private static readonly System.IntPtr NativeFieldInfoPtr_popUpPrefab;
  private static readonly System.IntPtr NativeFieldInfoPtr_cardTooltipPrefab;
  private static readonly System.IntPtr NativeFieldInfoPtr_layoutsToFix;
  private static readonly System.IntPtr NativeFieldInfoPtr_backgroundFade;
  private static readonly System.IntPtr NativeFieldInfoPtr_cardInfoFade;
  private static readonly System.IntPtr NativeFieldInfoPtr_fadeInDur;
  private static readonly System.IntPtr NativeFieldInfoPtr_fadeOutDur;
  private static readonly System.IntPtr NativeFieldInfoPtr_fade;
  private static readonly System.IntPtr NativeFieldInfoPtr_nameText;
  private static readonly System.IntPtr NativeFieldInfoPtr_typeIcon;
  private static readonly System.IntPtr NativeFieldInfoPtr_typeText;
  private static readonly System.IntPtr NativeFieldInfoPtr_flagImage;
  private static readonly System.IntPtr NativeFieldInfoPtr_drag;
  private static readonly System.IntPtr NativeFieldInfoPtr_press;
  private static readonly System.IntPtr NativeFieldInfoPtr__inspect_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr_previousParent;
  private static readonly System.IntPtr NativeFieldInfoPtr_previousChildIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_enableAnimationDelay;
  private static readonly System.IntPtr NativeFieldInfoPtr_enableAnimationTimer;
  private static readonly System.IntPtr NativeFieldInfoPtr_currentIdleAnimationFactor;
  private static readonly System.IntPtr NativeFieldInfoPtr_hasAnyCharms;
  private static readonly System.IntPtr NativeFieldInfoPtr_popups;
  private static readonly System.IntPtr NativeFieldInfoPtr_currentPoppedKeywords;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_inspect_Public_get_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_inspect_Public_set_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsActive_Public_Static_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Inspect_Public_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetFlag_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetClass_Private_Static_ClassData_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryInspectEnd_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InspectEnd_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FadeIn_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FadeOut_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateFade_Private_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreatePopups_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateIconPopups_Private_Void_RectTransform_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClearPopups_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FixLayoutsAfterFrame_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FixLayouts_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckOverflow_Private_Boolean_Il2CppReferenceArray_1_RectTransform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckCollide_Private_Static_Boolean_RectTransform_IEnumerable_1_RectTransform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RectOverlap_Private_Static_Boolean_RectTransform_RectTransform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Popup_Private_CardPopUpPanel_KeywordData_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Popup_Private_CardTooltip_CardData_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EnableIdleAnimation_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DisableIdleAnimation_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntityHover_Private_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntityUnHover_Private_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntityDrag_Private_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntityRelease_Private_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe Entity inspect
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InspectSystem.NativeMethodInfoPtr_get_inspect_Public_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62148, XrefRangeEnd = 62149, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InspectSystem.NativeMethodInfoPtr_set_inspect_Public_set_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 62156, RefRangeEnd = 62159, XrefRangeStart = 62149, XrefRangeEnd = 62156, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsActive()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InspectSystem.NativeMethodInfoPtr_IsActive_Public_Static_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62159, XrefRangeEnd = 62190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InspectSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62190, XrefRangeEnd = 62221, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InspectSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62221, XrefRangeEnd = 62257, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InspectSystem.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 62314, RefRangeEnd = 62315, XrefRangeStart = 62257, XrefRangeEnd = 62314, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Inspect(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InspectSystem.NativeMethodInfoPtr_Inspect_Public_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62315, XrefRangeEnd = 62326, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetFlag()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InspectSystem.NativeMethodInfoPtr_SetFlag_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 62366, RefRangeEnd = 62368, XrefRangeStart = 62326, XrefRangeEnd = 62366, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ClassData GetClass(CardData cardData)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cardData)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InspectSystem.NativeMethodInfoPtr_GetClass_Private_Static_ClassData_CardData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (ClassData) null : new ClassData(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62368, XrefRangeEnd = 62369, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void TryInspectEnd()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InspectSystem.NativeMethodInfoPtr_TryInspectEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 62395, RefRangeEnd = 62396, XrefRangeStart = 62369, XrefRangeEnd = 62395, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void InspectEnd()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InspectSystem.NativeMethodInfoPtr_InspectEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62396, XrefRangeEnd = 62401, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator FadeIn()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InspectSystem.NativeMethodInfoPtr_FadeIn_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62401, XrefRangeEnd = 62406, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator FadeOut()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InspectSystem.NativeMethodInfoPtr_FadeOut_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62406, XrefRangeEnd = 62409, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateFade(float value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InspectSystem.NativeMethodInfoPtr_UpdateFade_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 62467, RefRangeEnd = 62469, XrefRangeStart = 62409, XrefRangeEnd = 62467, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CreatePopups()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InspectSystem.NativeMethodInfoPtr_CreatePopups_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 62475, RefRangeEnd = 62478, XrefRangeStart = 62469, XrefRangeEnd = 62475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CreateIconPopups(RectTransform iconLayoutGroup, Transform popGroup)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) iconLayoutGroup);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) popGroup);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InspectSystem.NativeMethodInfoPtr_CreateIconPopups_Private_Void_RectTransform_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 62498, RefRangeEnd = 62500, XrefRangeStart = 62478, XrefRangeEnd = 62498, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ClearPopups()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InspectSystem.NativeMethodInfoPtr_ClearPopups_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62500, XrefRangeEnd = 62505, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator FixLayoutsAfterFrame()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InspectSystem.NativeMethodInfoPtr_FixLayoutsAfterFrame_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62505, XrefRangeEnd = 62510, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator FixLayouts()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InspectSystem.NativeMethodInfoPtr_FixLayouts_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62510, XrefRangeEnd = 62517, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool CheckOverflow([Optional] Il2CppReferenceArray<RectTransform> checkCollide)
  {
    if (checkCollide == null)
      checkCollide = new Il2CppReferenceArray<RectTransform>(0L);
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) checkCollide)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InspectSystem.NativeMethodInfoPtr_CheckOverflow_Private_Boolean_Il2CppReferenceArray_1_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 62554, RefRangeEnd = 62555, XrefRangeStart = 62517, XrefRangeEnd = 62554, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool CheckCollide(RectTransform target, IEnumerable<RectTransform> checks)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) checks);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InspectSystem.NativeMethodInfoPtr_CheckCollide_Private_Static_Boolean_RectTransform_IEnumerable_1_RectTransform_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool RectOverlap(RectTransform a, RectTransform b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) b);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InspectSystem.NativeMethodInfoPtr_RectOverlap_Private_Static_Boolean_RectTransform_RectTransform_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 62568, RefRangeEnd = 62573, XrefRangeStart = 62555, XrefRangeEnd = 62568, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardPopUpPanel Popup(KeywordData keyword, Transform group)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) keyword);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) group);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InspectSystem.NativeMethodInfoPtr_Popup_Private_CardPopUpPanel_KeywordData_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (CardPopUpPanel) null : new CardPopUpPanel(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 62604, RefRangeEnd = 62605, XrefRangeStart = 62573, XrefRangeEnd = 62604, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardTooltip Popup(CardData cardData, Transform group)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cardData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) group);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InspectSystem.NativeMethodInfoPtr_Popup_Private_CardTooltip_CardData_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (CardTooltip) null : new CardTooltip(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 62620, RefRangeEnd = 62621, XrefRangeStart = 62605, XrefRangeEnd = 62620, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EnableIdleAnimation()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InspectSystem.NativeMethodInfoPtr_EnableIdleAnimation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62621, XrefRangeEnd = 62632, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DisableIdleAnimation()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InspectSystem.NativeMethodInfoPtr_DisableIdleAnimation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62632, XrefRangeEnd = 62638, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntityHover(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InspectSystem.NativeMethodInfoPtr_EntityHover_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62638, XrefRangeEnd = 62642, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntityUnHover(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InspectSystem.NativeMethodInfoPtr_EntityUnHover_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62642, XrefRangeEnd = 62643, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntityDrag(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InspectSystem.NativeMethodInfoPtr_EntityDrag_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62643, XrefRangeEnd = 62648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntityRelease(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InspectSystem.NativeMethodInfoPtr_EntityRelease_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62648, XrefRangeEnd = 62704, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe InspectSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InspectSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  public bool CheckOverflow(params RectTransform[] checkCollide)
  {
    return this.CheckOverflow(new Il2CppReferenceArray<RectTransform>(checkCollide));
  }

  static InspectSystem()
  {
    Il2CppClassPointerStore<InspectSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (InspectSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr);
    InspectSystem.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, nameof (container));
    InspectSystem.NativeFieldInfoPtr_cardHolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, nameof (cardHolder));
    InspectSystem.NativeFieldInfoPtr_openInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, nameof (openInput));
    InspectSystem.NativeFieldInfoPtr_closeInputs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, nameof (closeInputs));
    InspectSystem.NativeFieldInfoPtr_inspectCharmsInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, nameof (inspectCharmsInput));
    InspectSystem.NativeFieldInfoPtr_cardScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, nameof (cardScale));
    InspectSystem.NativeFieldInfoPtr_cardRandomAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, nameof (cardRandomAngle));
    InspectSystem.NativeFieldInfoPtr_hover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, nameof (hover));
    InspectSystem.NativeFieldInfoPtr_idleAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, nameof (idleAnimation));
    InspectSystem.NativeFieldInfoPtr_idleAnimationFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, nameof (idleAnimationFactor));
    InspectSystem.NativeFieldInfoPtr_canInspectDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, nameof (canInspectDelay));
    InspectSystem.NativeFieldInfoPtr_canEndDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, nameof (canEndDelay));
    InspectSystem.NativeFieldInfoPtr_injuredKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, nameof (injuredKeyword));
    InspectSystem.NativeFieldInfoPtr_wait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, nameof (wait));
    InspectSystem.NativeFieldInfoPtr_inspectCharmsLayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, nameof (inspectCharmsLayout));
    InspectSystem.NativeFieldInfoPtr_inspectCharmsSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, nameof (inspectCharmsSystem));
    InspectSystem.NativeFieldInfoPtr_leftPopGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, nameof (leftPopGroup));
    InspectSystem.NativeFieldInfoPtr_leftOverflowPopGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, nameof (leftOverflowPopGroup));
    InspectSystem.NativeFieldInfoPtr_rightPopGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, nameof (rightPopGroup));
    InspectSystem.NativeFieldInfoPtr_rightOverflowPopGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, nameof (rightOverflowPopGroup));
    InspectSystem.NativeFieldInfoPtr_bottomPopGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, nameof (bottomPopGroup));
    InspectSystem.NativeFieldInfoPtr_notePopGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, nameof (notePopGroup));
    InspectSystem.NativeFieldInfoPtr_overflowOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, nameof (overflowOrder));
    InspectSystem.NativeFieldInfoPtr_popUpPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, nameof (popUpPrefab));
    InspectSystem.NativeFieldInfoPtr_cardTooltipPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, nameof (cardTooltipPrefab));
    InspectSystem.NativeFieldInfoPtr_layoutsToFix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, nameof (layoutsToFix));
    InspectSystem.NativeFieldInfoPtr_backgroundFade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, nameof (backgroundFade));
    InspectSystem.NativeFieldInfoPtr_cardInfoFade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, nameof (cardInfoFade));
    InspectSystem.NativeFieldInfoPtr_fadeInDur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, nameof (fadeInDur));
    InspectSystem.NativeFieldInfoPtr_fadeOutDur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, nameof (fadeOutDur));
    InspectSystem.NativeFieldInfoPtr_fade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, nameof (fade));
    InspectSystem.NativeFieldInfoPtr_nameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, nameof (nameText));
    InspectSystem.NativeFieldInfoPtr_typeIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, nameof (typeIcon));
    InspectSystem.NativeFieldInfoPtr_typeText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, nameof (typeText));
    InspectSystem.NativeFieldInfoPtr_flagImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, nameof (flagImage));
    InspectSystem.NativeFieldInfoPtr_drag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, nameof (drag));
    InspectSystem.NativeFieldInfoPtr_press = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, nameof (press));
    InspectSystem.NativeFieldInfoPtr__inspect_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, "<inspect>k__BackingField");
    InspectSystem.NativeFieldInfoPtr_previousParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, nameof (previousParent));
    InspectSystem.NativeFieldInfoPtr_previousChildIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, nameof (previousChildIndex));
    InspectSystem.NativeFieldInfoPtr_enableAnimationDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, nameof (enableAnimationDelay));
    InspectSystem.NativeFieldInfoPtr_enableAnimationTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, nameof (enableAnimationTimer));
    InspectSystem.NativeFieldInfoPtr_currentIdleAnimationFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, nameof (currentIdleAnimationFactor));
    InspectSystem.NativeFieldInfoPtr_hasAnyCharms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, nameof (hasAnyCharms));
    InspectSystem.NativeFieldInfoPtr_popups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, nameof (popups));
    InspectSystem.NativeFieldInfoPtr_currentPoppedKeywords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, nameof (currentPoppedKeywords));
    InspectSystem.NativeMethodInfoPtr_get_inspect_Public_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, 100668352);
    InspectSystem.NativeMethodInfoPtr_set_inspect_Public_set_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, 100668353);
    InspectSystem.NativeMethodInfoPtr_IsActive_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, 100668354);
    InspectSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, 100668355);
    InspectSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, 100668356);
    InspectSystem.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, 100668357);
    InspectSystem.NativeMethodInfoPtr_Inspect_Public_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, 100668358);
    InspectSystem.NativeMethodInfoPtr_SetFlag_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, 100668359);
    InspectSystem.NativeMethodInfoPtr_GetClass_Private_Static_ClassData_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, 100668360);
    InspectSystem.NativeMethodInfoPtr_TryInspectEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, 100668361);
    InspectSystem.NativeMethodInfoPtr_InspectEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, 100668362);
    InspectSystem.NativeMethodInfoPtr_FadeIn_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, 100668363);
    InspectSystem.NativeMethodInfoPtr_FadeOut_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, 100668364);
    InspectSystem.NativeMethodInfoPtr_UpdateFade_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, 100668365);
    InspectSystem.NativeMethodInfoPtr_CreatePopups_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, 100668366);
    InspectSystem.NativeMethodInfoPtr_CreateIconPopups_Private_Void_RectTransform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, 100668367);
    InspectSystem.NativeMethodInfoPtr_ClearPopups_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, 100668368);
    InspectSystem.NativeMethodInfoPtr_FixLayoutsAfterFrame_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, 100668369);
    InspectSystem.NativeMethodInfoPtr_FixLayouts_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, 100668370);
    InspectSystem.NativeMethodInfoPtr_CheckOverflow_Private_Boolean_Il2CppReferenceArray_1_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, 100668371);
    InspectSystem.NativeMethodInfoPtr_CheckCollide_Private_Static_Boolean_RectTransform_IEnumerable_1_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, 100668372);
    InspectSystem.NativeMethodInfoPtr_RectOverlap_Private_Static_Boolean_RectTransform_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, 100668373);
    InspectSystem.NativeMethodInfoPtr_Popup_Private_CardPopUpPanel_KeywordData_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, 100668374);
    InspectSystem.NativeMethodInfoPtr_Popup_Private_CardTooltip_CardData_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, 100668375);
    InspectSystem.NativeMethodInfoPtr_EnableIdleAnimation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, 100668376);
    InspectSystem.NativeMethodInfoPtr_DisableIdleAnimation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, 100668377);
    InspectSystem.NativeMethodInfoPtr_EntityHover_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, 100668378);
    InspectSystem.NativeMethodInfoPtr_EntityUnHover_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, 100668379);
    InspectSystem.NativeMethodInfoPtr_EntityDrag_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, 100668380);
    InspectSystem.NativeMethodInfoPtr_EntityRelease_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, 100668381);
    InspectSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, 100668382);
  }

  public InspectSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe GameObject container
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_container));
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform cardHolder
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_cardHolder));
      return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_cardHolder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string openInput
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_openInput)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_openInput), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe Il2CppStringArray closeInputs
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_closeInputs));
      return pointer == System.IntPtr.Zero ? (Il2CppStringArray) null : new Il2CppStringArray(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_closeInputs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string inspectCharmsInput
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_inspectCharmsInput)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_inspectCharmsInput), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe float cardScale
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_cardScale));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_cardScale)) = value;
    }
  }

  public unsafe Vector2 cardRandomAngle
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_cardRandomAngle));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_cardRandomAngle)) = value;
    }
  }

  public unsafe List<Entity> hover
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_hover));
      return pointer == System.IntPtr.Zero ? (List<Entity>) null : new List<Entity>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_hover), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool idleAnimation
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_idleAnimation));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_idleAnimation)) = value;
    }
  }

  public unsafe float idleAnimationFactor
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_idleAnimationFactor));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_idleAnimationFactor)) = value;
    }
  }

  public unsafe float canInspectDelay
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_canInspectDelay));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_canInspectDelay)) = value;
    }
  }

  public unsafe float canEndDelay
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_canEndDelay));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_canEndDelay)) = value;
    }
  }

  public unsafe KeywordData injuredKeyword
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_injuredKeyword));
      return pointer == System.IntPtr.Zero ? (KeywordData) null : new KeywordData(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_injuredKeyword), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float wait
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_wait));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_wait)) = value;
    }
  }

  public unsafe GameObject inspectCharmsLayout
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_inspectCharmsLayout));
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_inspectCharmsLayout), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe InspectCharmsSystem inspectCharmsSystem
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_inspectCharmsSystem));
      return pointer == System.IntPtr.Zero ? (InspectCharmsSystem) null : new InspectCharmsSystem(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_inspectCharmsSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform leftPopGroup
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_leftPopGroup));
      return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_leftPopGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform leftOverflowPopGroup
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_leftOverflowPopGroup));
      return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_leftOverflowPopGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform rightPopGroup
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_rightPopGroup));
      return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_rightPopGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform rightOverflowPopGroup
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_rightOverflowPopGroup));
      return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_rightOverflowPopGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform bottomPopGroup
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_bottomPopGroup));
      return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_bottomPopGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform notePopGroup
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_notePopGroup));
      return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_notePopGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<RectTransform> overflowOrder
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_overflowOrder));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<RectTransform>) null : new Il2CppReferenceArray<RectTransform>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_overflowOrder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CardPopUpPanel popUpPrefab
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_popUpPrefab));
      return pointer == System.IntPtr.Zero ? (CardPopUpPanel) null : new CardPopUpPanel(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_popUpPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CardTooltip cardTooltipPrefab
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_cardTooltipPrefab));
      return pointer == System.IntPtr.Zero ? (CardTooltip) null : new CardTooltip(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_cardTooltipPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<LayoutGroup> layoutsToFix
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_layoutsToFix));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<LayoutGroup>) null : new Il2CppReferenceArray<LayoutGroup>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_layoutsToFix), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CanvasGroup backgroundFade
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_backgroundFade));
      return pointer == System.IntPtr.Zero ? (CanvasGroup) null : new CanvasGroup(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_backgroundFade), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CanvasGroup cardInfoFade
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_cardInfoFade));
      return pointer == System.IntPtr.Zero ? (CanvasGroup) null : new CanvasGroup(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_cardInfoFade), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float fadeInDur
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_fadeInDur));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_fadeInDur)) = value;
    }
  }

  public unsafe float fadeOutDur
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_fadeOutDur));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_fadeOutDur)) = value;
    }
  }

  public unsafe float fade
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_fade));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_fade)) = value;
    }
  }

  public unsafe TMP_Text nameText
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_nameText));
      return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_nameText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ImageSprite typeIcon
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_typeIcon));
      return pointer == System.IntPtr.Zero ? (ImageSprite) null : new ImageSprite(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_typeIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text typeText
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_typeText));
      return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_typeText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image flagImage
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_flagImage));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_flagImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Entity drag
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_drag));
      return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_drag), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Entity press
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_press));
      return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_press), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Entity _inspect_k__BackingField
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr__inspect_k__BackingField));
      return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr__inspect_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform previousParent
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_previousParent));
      return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_previousParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int previousChildIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_previousChildIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_previousChildIndex)) = value;
    }
  }

  public static unsafe float enableAnimationDelay
  {
    get
    {
      float enableAnimationDelay;
      IL2CPP.il2cpp_field_static_get_value(InspectSystem.NativeFieldInfoPtr_enableAnimationDelay, (void*) &enableAnimationDelay);
      return enableAnimationDelay;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(InspectSystem.NativeFieldInfoPtr_enableAnimationDelay, (void*) &value);
    }
  }

  public unsafe float enableAnimationTimer
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_enableAnimationTimer));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_enableAnimationTimer)) = value;
    }
  }

  public unsafe float currentIdleAnimationFactor
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_currentIdleAnimationFactor));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_currentIdleAnimationFactor)) = value;
    }
  }

  public unsafe bool hasAnyCharms
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_hasAnyCharms));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_hasAnyCharms)) = value;
    }
  }

  public unsafe List<Tooltip> popups
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_popups));
      return pointer == System.IntPtr.Zero ? (List<Tooltip>) null : new List<Tooltip>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_popups), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<KeywordData> currentPoppedKeywords
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_currentPoppedKeywords));
      return pointer == System.IntPtr.Zero ? (List<KeywordData>) null : new List<KeywordData>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem.NativeFieldInfoPtr_currentPoppedKeywords), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("InspectSystem/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__52_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Update_b__52_0_Internal_Boolean_String_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InspectSystem.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InspectSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62093, XrefRangeEnd = 62097, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _Update_b__52_0(string i)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(i)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InspectSystem.__c.NativeMethodInfoPtr__Update_b__52_0_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c()
    {
      Il2CppClassPointerStore<InspectSystem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InspectSystem.__c>.NativeClassPtr);
      InspectSystem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem.__c>.NativeClassPtr, "<>9");
      InspectSystem.__c.NativeFieldInfoPtr___9__52_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem.__c>.NativeClassPtr, "<>9__52_0");
      InspectSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem.__c>.NativeClassPtr, 100668384);
      InspectSystem.__c.NativeMethodInfoPtr__Update_b__52_0_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem.__c>.NativeClassPtr, 100668385);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe InspectSystem.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(InspectSystem.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (InspectSystem.__c) null : new InspectSystem.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(InspectSystem.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<string, bool> __9__52_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(InspectSystem.__c.NativeFieldInfoPtr___9__52_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<string, bool>) null : new Il2CppSystem.Func<string, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(InspectSystem.__c.NativeFieldInfoPtr___9__52_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("InspectSystem/<FadeIn>d__58")]
  public sealed class _FadeIn_d__58 : Il2CppSystem.Object
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
    public unsafe _FadeIn_d__58(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InspectSystem._FadeIn_d__58>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InspectSystem._FadeIn_d__58.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InspectSystem._FadeIn_d__58.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62097, XrefRangeEnd = 62115, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InspectSystem._FadeIn_d__58.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InspectSystem._FadeIn_d__58.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62115, XrefRangeEnd = 62121, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InspectSystem._FadeIn_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InspectSystem._FadeIn_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _FadeIn_d__58()
    {
      Il2CppClassPointerStore<InspectSystem._FadeIn_d__58>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, "<FadeIn>d__58");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InspectSystem._FadeIn_d__58>.NativeClassPtr);
      InspectSystem._FadeIn_d__58.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem._FadeIn_d__58>.NativeClassPtr, "<>1__state");
      InspectSystem._FadeIn_d__58.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem._FadeIn_d__58>.NativeClassPtr, "<>2__current");
      InspectSystem._FadeIn_d__58.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem._FadeIn_d__58>.NativeClassPtr, "<>4__this");
      InspectSystem._FadeIn_d__58.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem._FadeIn_d__58>.NativeClassPtr, 100668386);
      InspectSystem._FadeIn_d__58.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem._FadeIn_d__58>.NativeClassPtr, 100668387);
      InspectSystem._FadeIn_d__58.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem._FadeIn_d__58>.NativeClassPtr, 100668388);
      InspectSystem._FadeIn_d__58.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem._FadeIn_d__58>.NativeClassPtr, 100668389);
      InspectSystem._FadeIn_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem._FadeIn_d__58>.NativeClassPtr, 100668390);
      InspectSystem._FadeIn_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem._FadeIn_d__58>.NativeClassPtr, 100668391);
    }

    public _FadeIn_d__58(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem._FadeIn_d__58.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem._FadeIn_d__58.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem._FadeIn_d__58.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem._FadeIn_d__58.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InspectSystem __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem._FadeIn_d__58.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (InspectSystem) null : new InspectSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem._FadeIn_d__58.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("InspectSystem/<FadeOut>d__59")]
  public sealed class _FadeOut_d__59 : Il2CppSystem.Object
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
    public unsafe _FadeOut_d__59(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InspectSystem._FadeOut_d__59>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InspectSystem._FadeOut_d__59.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InspectSystem._FadeOut_d__59.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62121, XrefRangeEnd = 62127, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InspectSystem._FadeOut_d__59.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InspectSystem._FadeOut_d__59.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62127, XrefRangeEnd = 62133, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InspectSystem._FadeOut_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InspectSystem._FadeOut_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _FadeOut_d__59()
    {
      Il2CppClassPointerStore<InspectSystem._FadeOut_d__59>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, "<FadeOut>d__59");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InspectSystem._FadeOut_d__59>.NativeClassPtr);
      InspectSystem._FadeOut_d__59.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem._FadeOut_d__59>.NativeClassPtr, "<>1__state");
      InspectSystem._FadeOut_d__59.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem._FadeOut_d__59>.NativeClassPtr, "<>2__current");
      InspectSystem._FadeOut_d__59.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem._FadeOut_d__59>.NativeClassPtr, "<>4__this");
      InspectSystem._FadeOut_d__59.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem._FadeOut_d__59>.NativeClassPtr, 100668392);
      InspectSystem._FadeOut_d__59.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem._FadeOut_d__59>.NativeClassPtr, 100668393);
      InspectSystem._FadeOut_d__59.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem._FadeOut_d__59>.NativeClassPtr, 100668394);
      InspectSystem._FadeOut_d__59.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem._FadeOut_d__59>.NativeClassPtr, 100668395);
      InspectSystem._FadeOut_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem._FadeOut_d__59>.NativeClassPtr, 100668396);
      InspectSystem._FadeOut_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem._FadeOut_d__59>.NativeClassPtr, 100668397);
    }

    public _FadeOut_d__59(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem._FadeOut_d__59.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem._FadeOut_d__59.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem._FadeOut_d__59.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem._FadeOut_d__59.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InspectSystem __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem._FadeOut_d__59.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (InspectSystem) null : new InspectSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem._FadeOut_d__59.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("InspectSystem/<FixLayoutsAfterFrame>d__64")]
  public sealed class _FixLayoutsAfterFrame_d__64 : Il2CppSystem.Object
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
    public unsafe _FixLayoutsAfterFrame_d__64(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InspectSystem._FixLayoutsAfterFrame_d__64>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InspectSystem._FixLayoutsAfterFrame_d__64.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InspectSystem._FixLayoutsAfterFrame_d__64.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InspectSystem._FixLayoutsAfterFrame_d__64.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InspectSystem._FixLayoutsAfterFrame_d__64.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62133, XrefRangeEnd = 62139, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InspectSystem._FixLayoutsAfterFrame_d__64.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InspectSystem._FixLayoutsAfterFrame_d__64.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _FixLayoutsAfterFrame_d__64()
    {
      Il2CppClassPointerStore<InspectSystem._FixLayoutsAfterFrame_d__64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, "<FixLayoutsAfterFrame>d__64");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InspectSystem._FixLayoutsAfterFrame_d__64>.NativeClassPtr);
      InspectSystem._FixLayoutsAfterFrame_d__64.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem._FixLayoutsAfterFrame_d__64>.NativeClassPtr, "<>1__state");
      InspectSystem._FixLayoutsAfterFrame_d__64.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem._FixLayoutsAfterFrame_d__64>.NativeClassPtr, "<>2__current");
      InspectSystem._FixLayoutsAfterFrame_d__64.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem._FixLayoutsAfterFrame_d__64>.NativeClassPtr, "<>4__this");
      InspectSystem._FixLayoutsAfterFrame_d__64.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem._FixLayoutsAfterFrame_d__64>.NativeClassPtr, 100668398);
      InspectSystem._FixLayoutsAfterFrame_d__64.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem._FixLayoutsAfterFrame_d__64>.NativeClassPtr, 100668399);
      InspectSystem._FixLayoutsAfterFrame_d__64.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem._FixLayoutsAfterFrame_d__64>.NativeClassPtr, 100668400);
      InspectSystem._FixLayoutsAfterFrame_d__64.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem._FixLayoutsAfterFrame_d__64>.NativeClassPtr, 100668401);
      InspectSystem._FixLayoutsAfterFrame_d__64.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem._FixLayoutsAfterFrame_d__64>.NativeClassPtr, 100668402);
      InspectSystem._FixLayoutsAfterFrame_d__64.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem._FixLayoutsAfterFrame_d__64>.NativeClassPtr, 100668403);
    }

    public _FixLayoutsAfterFrame_d__64(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem._FixLayoutsAfterFrame_d__64.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem._FixLayoutsAfterFrame_d__64.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem._FixLayoutsAfterFrame_d__64.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem._FixLayoutsAfterFrame_d__64.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InspectSystem __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem._FixLayoutsAfterFrame_d__64.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (InspectSystem) null : new InspectSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem._FixLayoutsAfterFrame_d__64.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("InspectSystem/<FixLayouts>d__65")]
  public sealed class _FixLayouts_d__65 : Il2CppSystem.Object
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
    public unsafe _FixLayouts_d__65(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InspectSystem._FixLayouts_d__65>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InspectSystem._FixLayouts_d__65.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InspectSystem._FixLayouts_d__65.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62139, XrefRangeEnd = 62142, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InspectSystem._FixLayouts_d__65.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InspectSystem._FixLayouts_d__65.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62142, XrefRangeEnd = 62148, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InspectSystem._FixLayouts_d__65.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InspectSystem._FixLayouts_d__65.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _FixLayouts_d__65()
    {
      Il2CppClassPointerStore<InspectSystem._FixLayouts_d__65>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InspectSystem>.NativeClassPtr, "<FixLayouts>d__65");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InspectSystem._FixLayouts_d__65>.NativeClassPtr);
      InspectSystem._FixLayouts_d__65.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem._FixLayouts_d__65>.NativeClassPtr, "<>1__state");
      InspectSystem._FixLayouts_d__65.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem._FixLayouts_d__65>.NativeClassPtr, "<>2__current");
      InspectSystem._FixLayouts_d__65.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectSystem._FixLayouts_d__65>.NativeClassPtr, "<>4__this");
      InspectSystem._FixLayouts_d__65.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem._FixLayouts_d__65>.NativeClassPtr, 100668404);
      InspectSystem._FixLayouts_d__65.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem._FixLayouts_d__65>.NativeClassPtr, 100668405);
      InspectSystem._FixLayouts_d__65.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem._FixLayouts_d__65>.NativeClassPtr, 100668406);
      InspectSystem._FixLayouts_d__65.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem._FixLayouts_d__65>.NativeClassPtr, 100668407);
      InspectSystem._FixLayouts_d__65.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem._FixLayouts_d__65>.NativeClassPtr, 100668408);
      InspectSystem._FixLayouts_d__65.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectSystem._FixLayouts_d__65>.NativeClassPtr, 100668409);
    }

    public _FixLayouts_d__65(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem._FixLayouts_d__65.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem._FixLayouts_d__65.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem._FixLayouts_d__65.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem._FixLayouts_d__65.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InspectSystem __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem._FixLayouts_d__65.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (InspectSystem) null : new InspectSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectSystem._FixLayouts_d__65.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
