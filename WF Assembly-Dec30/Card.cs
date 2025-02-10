// Decompiled with JetBrains decompiler
// Type: Card
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
public class Card : EntityDisplay
{
  private static readonly System.IntPtr NativeFieldInfoPtr_baseSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_frameLevel;
  private static readonly System.IntPtr NativeFieldInfoPtr_canvas;
  private static readonly System.IntPtr NativeFieldInfoPtr_canvasGroup;
  private static readonly System.IntPtr NativeFieldInfoPtr_titleText;
  private static readonly System.IntPtr NativeFieldInfoPtr_descText;
  private static readonly System.IntPtr NativeFieldInfoPtr_mainImage;
  private static readonly System.IntPtr NativeFieldInfoPtr_backImage;
  private static readonly System.IntPtr NativeFieldInfoPtr_backgroundImage;
  private static readonly System.IntPtr NativeFieldInfoPtr_frameImage;
  private static readonly System.IntPtr NativeFieldInfoPtr_frameSetter;
  private static readonly System.IntPtr NativeFieldInfoPtr_uINavigationItem;
  private static readonly System.IntPtr NativeFieldInfoPtr_frontGroup;
  private static readonly System.IntPtr NativeFieldInfoPtr_backGroup;
  private static readonly System.IntPtr NativeFieldInfoPtr_charmHolder;
  private static readonly System.IntPtr NativeFieldInfoPtr_tokenHolder;
  private static readonly System.IntPtr NativeFieldInfoPtr_crownHolder;
  private static readonly System.IntPtr NativeFieldInfoPtr_itemHolderPet;
  private static readonly System.IntPtr NativeFieldInfoPtr_scalers;
  private static readonly System.IntPtr NativeFieldInfoPtr_imageIdleAnimator;
  private static readonly System.IntPtr NativeFieldInfoPtr_backgroundIdleAnimator;
  private static readonly System.IntPtr NativeFieldInfoPtr_currentEffectBonus;
  private static readonly System.IntPtr NativeFieldInfoPtr_currentEffectFactor;
  private static readonly System.IntPtr NativeFieldInfoPtr_currentSilenced;
  private static readonly System.IntPtr NativeFieldInfoPtr_keywords;
  private static readonly System.IntPtr NativeFieldInfoPtr_mentionedCards;
  private static readonly System.IntPtr NativeFieldInfoPtr_hasScriptableImage;
  private static readonly System.IntPtr NativeFieldInfoPtr_scriptableImage;
  private static readonly System.IntPtr NativeMethodInfoPtr_FlipUp_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FlipDown_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetCanvas_Public_Virtual_Canvas_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateData_Public_Virtual_IEnumerator_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateDisplay_Public_Virtual_IEnumerator_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetName_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetName_Public_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetDescription_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDescription_Public_Static_String_CardData_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDescription_Private_Static_String_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddAttackEffectText_Private_Static_Void_byref_String_ICollection_1_StatusEffectStacks_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddCustomCardText_Private_Static_Void_byref_String_CardData_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddPassiveEffectText_Private_Static_Void_byref_String_ICollection_1_StatusEffectStacks_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddPassiveEffectText_Private_Static_Void_byref_String_ICollection_1_StatusEffectData_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddUpgradeText_Private_Static_Void_byref_String_CardData_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddTraitText_Private_Static_Void_byref_String_CardData_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddTraitText_Private_Static_Void_byref_String_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTraitSeparator_Private_Static_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTraitText_Private_Static_String_TraitData_Int32_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddInjuryText_Private_Static_Void_byref_String_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnGetFromPool_Public_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnReturnToPool_Public_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr___n__0_Private_IEnumerator_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr___n__1_Private_IEnumerator_Boolean_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43111, XrefRangeEnd = 43114, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FlipUp()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Card.NativeMethodInfoPtr_FlipUp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43114, XrefRangeEnd = 43117, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FlipDown()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Card.NativeMethodInfoPtr_FlipDown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 43117, RefRangeEnd = 43122, XrefRangeStart = 43117, XrefRangeEnd = 43117, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe Canvas GetCanvas()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Card.NativeMethodInfoPtr_GetCanvas_Public_Virtual_Canvas_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (Canvas) null : new Canvas(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43122, XrefRangeEnd = 43127, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe IEnumerator UpdateData(bool doPing = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &doPing
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Card.NativeMethodInfoPtr_UpdateData_Public_Virtual_IEnumerator_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43127, XrefRangeEnd = 43132, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe IEnumerator UpdateDisplay(bool doPing = true)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &doPing
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Card.NativeMethodInfoPtr_UpdateDisplay_Public_Virtual_IEnumerator_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43132, XrefRangeEnd = 43135, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetName()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Card.NativeMethodInfoPtr_SetName_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 43142, RefRangeEnd = 43147, XrefRangeStart = 43135, XrefRangeEnd = 43142, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetName(string name)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(name)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Card.NativeMethodInfoPtr_SetName_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 43185, RefRangeEnd = 43187, XrefRangeStart = 43147, XrefRangeEnd = 43185, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetDescription()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Card.NativeMethodInfoPtr_SetDescription_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 43201, RefRangeEnd = 43202, XrefRangeStart = 43187, XrefRangeEnd = 43201, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetDescription(CardData data, bool silenced = false)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &silenced;
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Card.NativeMethodInfoPtr_GetDescription_Public_Static_String_CardData_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43202, XrefRangeEnd = 43216, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetDescription(Entity entity)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Card.NativeMethodInfoPtr_GetDescription_Private_Static_String_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 43306, RefRangeEnd = 43309, XrefRangeStart = 43216, XrefRangeEnd = 43306, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void AddAttackEffectText(
    ref string text,
    ICollection<CardData.StatusEffectStacks> attackEffects,
    bool silenced = false)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
    System.IntPtr* numPtr2 = numPtr1;
    System.IntPtr il2Cpp = IL2CPP.ManagedStringToIl2Cpp(text);
    System.IntPtr* numPtr3 = &il2Cpp;
    *numPtr2 = (System.IntPtr) numPtr3;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attackEffects);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &silenced;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Card.NativeMethodInfoPtr_AddAttackEffectText_Private_Static_Void_byref_String_ICollection_1_StatusEffectStacks_Boolean_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    text = IL2CPP.Il2CppStringToManaged(il2Cpp);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43309, XrefRangeEnd = 43318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void AddCustomCardText(ref string text, CardData data, bool silenced = false)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
    System.IntPtr* numPtr2 = numPtr1;
    System.IntPtr il2Cpp = IL2CPP.ManagedStringToIl2Cpp(text);
    System.IntPtr* numPtr3 = &il2Cpp;
    *numPtr2 = (System.IntPtr) numPtr3;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &silenced;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Card.NativeMethodInfoPtr_AddCustomCardText_Private_Static_Void_byref_String_CardData_Boolean_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    text = IL2CPP.Il2CppStringToManaged(il2Cpp);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 43348, RefRangeEnd = 43349, XrefRangeStart = 43318, XrefRangeEnd = 43348, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void AddPassiveEffectText(
    ref string text,
    ICollection<CardData.StatusEffectStacks> passiveEffects,
    bool silenced = false)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
    System.IntPtr* numPtr2 = numPtr1;
    System.IntPtr il2Cpp = IL2CPP.ManagedStringToIl2Cpp(text);
    System.IntPtr* numPtr3 = &il2Cpp;
    *numPtr2 = (System.IntPtr) numPtr3;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) passiveEffects);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &silenced;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Card.NativeMethodInfoPtr_AddPassiveEffectText_Private_Static_Void_byref_String_ICollection_1_StatusEffectStacks_Boolean_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    text = IL2CPP.Il2CppStringToManaged(il2Cpp);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 43397, RefRangeEnd = 43399, XrefRangeStart = 43349, XrefRangeEnd = 43397, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void AddPassiveEffectText(
    ref string text,
    ICollection<StatusEffectData> passiveEffects,
    bool silenced = false)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
    System.IntPtr* numPtr2 = numPtr1;
    System.IntPtr il2Cpp = IL2CPP.ManagedStringToIl2Cpp(text);
    System.IntPtr* numPtr3 = &il2Cpp;
    *numPtr2 = (System.IntPtr) numPtr3;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) passiveEffects);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &silenced;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Card.NativeMethodInfoPtr_AddPassiveEffectText_Private_Static_Void_byref_String_ICollection_1_StatusEffectData_Boolean_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    text = IL2CPP.Il2CppStringToManaged(il2Cpp);
  }

  [CallerCount(12611)]
  [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void AddUpgradeText(ref string text, CardData data, bool silenced = false)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
    System.IntPtr* numPtr2 = numPtr1;
    System.IntPtr il2Cpp = IL2CPP.ManagedStringToIl2Cpp(text);
    System.IntPtr* numPtr3 = &il2Cpp;
    *numPtr2 = (System.IntPtr) numPtr3;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &silenced;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Card.NativeMethodInfoPtr_AddUpgradeText_Private_Static_Void_byref_String_CardData_Boolean_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    text = IL2CPP.Il2CppStringToManaged(il2Cpp);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 43428, RefRangeEnd = 43429, XrefRangeStart = 43399, XrefRangeEnd = 43428, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void AddTraitText(ref string text, CardData data, bool silenced = false)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
    System.IntPtr* numPtr2 = numPtr1;
    System.IntPtr il2Cpp = IL2CPP.ManagedStringToIl2Cpp(text);
    System.IntPtr* numPtr3 = &il2Cpp;
    *numPtr2 = (System.IntPtr) numPtr3;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &silenced;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Card.NativeMethodInfoPtr_AddTraitText_Private_Static_Void_byref_String_CardData_Boolean_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    text = IL2CPP.Il2CppStringToManaged(il2Cpp);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 43449, RefRangeEnd = 43451, XrefRangeStart = 43429, XrefRangeEnd = 43449, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void AddTraitText(ref string text, Entity entity)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    System.IntPtr* numPtr2 = numPtr1;
    System.IntPtr il2Cpp = IL2CPP.ManagedStringToIl2Cpp(text);
    System.IntPtr* numPtr3 = &il2Cpp;
    *numPtr2 = (System.IntPtr) numPtr3;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Card.NativeMethodInfoPtr_AddTraitText_Private_Static_Void_byref_String_Entity_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    text = IL2CPP.Il2CppStringToManaged(il2Cpp);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43451, XrefRangeEnd = 43455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetTraitSeparator(int traitCount)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &traitCount
    };
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Card.NativeMethodInfoPtr_GetTraitSeparator_Private_Static_String_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 43464, RefRangeEnd = 43465, XrefRangeStart = 43455, XrefRangeEnd = 43464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetTraitText(TraitData trait, int count, bool silenced = false)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) trait);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &silenced;
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Card.NativeMethodInfoPtr_GetTraitText_Private_Static_String_TraitData_Int32_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 43492, RefRangeEnd = 43493, XrefRangeStart = 43465, XrefRangeEnd = 43492, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void AddInjuryText(ref string text, CardData data)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    System.IntPtr* numPtr2 = numPtr1;
    System.IntPtr il2Cpp = IL2CPP.ManagedStringToIl2Cpp(text);
    System.IntPtr* numPtr3 = &il2Cpp;
    *numPtr2 = (System.IntPtr) numPtr3;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Card.NativeMethodInfoPtr_AddInjuryText_Private_Static_Void_byref_String_CardData_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    text = IL2CPP.Il2CppStringToManaged(il2Cpp);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43493, XrefRangeEnd = 43497, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnGetFromPool()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Card.NativeMethodInfoPtr_OnGetFromPool_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43497, XrefRangeEnd = 43548, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnReturnToPool()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Card.NativeMethodInfoPtr_OnReturnToPool_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43548, XrefRangeEnd = 43578, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDrawGizmos()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Card.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43578, XrefRangeEnd = 43587, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Card()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Card>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Card.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43587, XrefRangeEnd = 43592, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator __n__0(bool doPing)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &doPing
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Card.NativeMethodInfoPtr___n__0_Private_IEnumerator_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43592, XrefRangeEnd = 43597, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator __n__1(bool doPing)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &doPing
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Card.NativeMethodInfoPtr___n__1_Private_IEnumerator_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  static Card()
  {
    Il2CppClassPointerStore<Card>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (Card));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Card>.NativeClassPtr);
    Card.NativeFieldInfoPtr_baseSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Card>.NativeClassPtr, nameof (baseSize));
    Card.NativeFieldInfoPtr_frameLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Card>.NativeClassPtr, nameof (frameLevel));
    Card.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Card>.NativeClassPtr, nameof (canvas));
    Card.NativeFieldInfoPtr_canvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Card>.NativeClassPtr, nameof (canvasGroup));
    Card.NativeFieldInfoPtr_titleText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Card>.NativeClassPtr, nameof (titleText));
    Card.NativeFieldInfoPtr_descText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Card>.NativeClassPtr, nameof (descText));
    Card.NativeFieldInfoPtr_mainImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Card>.NativeClassPtr, nameof (mainImage));
    Card.NativeFieldInfoPtr_backImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Card>.NativeClassPtr, nameof (backImage));
    Card.NativeFieldInfoPtr_backgroundImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Card>.NativeClassPtr, nameof (backgroundImage));
    Card.NativeFieldInfoPtr_frameImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Card>.NativeClassPtr, nameof (frameImage));
    Card.NativeFieldInfoPtr_frameSetter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Card>.NativeClassPtr, nameof (frameSetter));
    Card.NativeFieldInfoPtr_uINavigationItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Card>.NativeClassPtr, nameof (uINavigationItem));
    Card.NativeFieldInfoPtr_frontGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Card>.NativeClassPtr, nameof (frontGroup));
    Card.NativeFieldInfoPtr_backGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Card>.NativeClassPtr, nameof (backGroup));
    Card.NativeFieldInfoPtr_charmHolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Card>.NativeClassPtr, nameof (charmHolder));
    Card.NativeFieldInfoPtr_tokenHolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Card>.NativeClassPtr, nameof (tokenHolder));
    Card.NativeFieldInfoPtr_crownHolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Card>.NativeClassPtr, nameof (crownHolder));
    Card.NativeFieldInfoPtr_itemHolderPet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Card>.NativeClassPtr, nameof (itemHolderPet));
    Card.NativeFieldInfoPtr_scalers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Card>.NativeClassPtr, nameof (scalers));
    Card.NativeFieldInfoPtr_imageIdleAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Card>.NativeClassPtr, nameof (imageIdleAnimator));
    Card.NativeFieldInfoPtr_backgroundIdleAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Card>.NativeClassPtr, nameof (backgroundIdleAnimator));
    Card.NativeFieldInfoPtr_currentEffectBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Card>.NativeClassPtr, nameof (currentEffectBonus));
    Card.NativeFieldInfoPtr_currentEffectFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Card>.NativeClassPtr, nameof (currentEffectFactor));
    Card.NativeFieldInfoPtr_currentSilenced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Card>.NativeClassPtr, nameof (currentSilenced));
    Card.NativeFieldInfoPtr_keywords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Card>.NativeClassPtr, nameof (keywords));
    Card.NativeFieldInfoPtr_mentionedCards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Card>.NativeClassPtr, nameof (mentionedCards));
    Card.NativeFieldInfoPtr_hasScriptableImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Card>.NativeClassPtr, nameof (hasScriptableImage));
    Card.NativeFieldInfoPtr_scriptableImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Card>.NativeClassPtr, nameof (scriptableImage));
    Card.NativeMethodInfoPtr_FlipUp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Card>.NativeClassPtr, 100666499);
    Card.NativeMethodInfoPtr_FlipDown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Card>.NativeClassPtr, 100666500);
    Card.NativeMethodInfoPtr_GetCanvas_Public_Virtual_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Card>.NativeClassPtr, 100666501);
    Card.NativeMethodInfoPtr_UpdateData_Public_Virtual_IEnumerator_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Card>.NativeClassPtr, 100666502);
    Card.NativeMethodInfoPtr_UpdateDisplay_Public_Virtual_IEnumerator_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Card>.NativeClassPtr, 100666503);
    Card.NativeMethodInfoPtr_SetName_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Card>.NativeClassPtr, 100666504);
    Card.NativeMethodInfoPtr_SetName_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Card>.NativeClassPtr, 100666505);
    Card.NativeMethodInfoPtr_SetDescription_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Card>.NativeClassPtr, 100666506);
    Card.NativeMethodInfoPtr_GetDescription_Public_Static_String_CardData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Card>.NativeClassPtr, 100666507);
    Card.NativeMethodInfoPtr_GetDescription_Private_Static_String_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Card>.NativeClassPtr, 100666508);
    Card.NativeMethodInfoPtr_AddAttackEffectText_Private_Static_Void_byref_String_ICollection_1_StatusEffectStacks_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Card>.NativeClassPtr, 100666509);
    Card.NativeMethodInfoPtr_AddCustomCardText_Private_Static_Void_byref_String_CardData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Card>.NativeClassPtr, 100666510);
    Card.NativeMethodInfoPtr_AddPassiveEffectText_Private_Static_Void_byref_String_ICollection_1_StatusEffectStacks_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Card>.NativeClassPtr, 100666511);
    Card.NativeMethodInfoPtr_AddPassiveEffectText_Private_Static_Void_byref_String_ICollection_1_StatusEffectData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Card>.NativeClassPtr, 100666512);
    Card.NativeMethodInfoPtr_AddUpgradeText_Private_Static_Void_byref_String_CardData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Card>.NativeClassPtr, 100666513);
    Card.NativeMethodInfoPtr_AddTraitText_Private_Static_Void_byref_String_CardData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Card>.NativeClassPtr, 100666514);
    Card.NativeMethodInfoPtr_AddTraitText_Private_Static_Void_byref_String_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Card>.NativeClassPtr, 100666515);
    Card.NativeMethodInfoPtr_GetTraitSeparator_Private_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Card>.NativeClassPtr, 100666516);
    Card.NativeMethodInfoPtr_GetTraitText_Private_Static_String_TraitData_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Card>.NativeClassPtr, 100666517);
    Card.NativeMethodInfoPtr_AddInjuryText_Private_Static_Void_byref_String_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Card>.NativeClassPtr, 100666518);
    Card.NativeMethodInfoPtr_OnGetFromPool_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Card>.NativeClassPtr, 100666519);
    Card.NativeMethodInfoPtr_OnReturnToPool_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Card>.NativeClassPtr, 100666520);
    Card.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Card>.NativeClassPtr, 100666521);
    Card.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Card>.NativeClassPtr, 100666522);
    Card.NativeMethodInfoPtr___n__0_Private_IEnumerator_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Card>.NativeClassPtr, 100666523);
    Card.NativeMethodInfoPtr___n__1_Private_IEnumerator_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Card>.NativeClassPtr, 100666524);
  }

  public Card(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Vector2 baseSize
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Card.NativeFieldInfoPtr_baseSize));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Card.NativeFieldInfoPtr_baseSize)) = value;
    }
  }

  public unsafe int frameLevel
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Card.NativeFieldInfoPtr_frameLevel));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Card.NativeFieldInfoPtr_frameLevel)) = value;
    }
  }

  public unsafe Canvas canvas
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Card.NativeFieldInfoPtr_canvas));
      return pointer == System.IntPtr.Zero ? (Canvas) null : new Canvas(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Card.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CanvasGroup canvasGroup
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Card.NativeFieldInfoPtr_canvasGroup));
      return pointer == System.IntPtr.Zero ? (CanvasGroup) null : new CanvasGroup(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Card.NativeFieldInfoPtr_canvasGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TextMeshProUGUI titleText
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Card.NativeFieldInfoPtr_titleText));
      return pointer == System.IntPtr.Zero ? (TextMeshProUGUI) null : new TextMeshProUGUI(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Card.NativeFieldInfoPtr_titleText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TextMeshProUGUI descText
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Card.NativeFieldInfoPtr_descText));
      return pointer == System.IntPtr.Zero ? (TextMeshProUGUI) null : new TextMeshProUGUI(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Card.NativeFieldInfoPtr_descText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image mainImage
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Card.NativeFieldInfoPtr_mainImage));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Card.NativeFieldInfoPtr_mainImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image backImage
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Card.NativeFieldInfoPtr_backImage));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Card.NativeFieldInfoPtr_backImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image backgroundImage
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Card.NativeFieldInfoPtr_backgroundImage));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Card.NativeFieldInfoPtr_backgroundImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image frameImage
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Card.NativeFieldInfoPtr_frameImage));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Card.NativeFieldInfoPtr_frameImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CardFrameSetter frameSetter
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Card.NativeFieldInfoPtr_frameSetter));
      return pointer == System.IntPtr.Zero ? (CardFrameSetter) null : new CardFrameSetter(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Card.NativeFieldInfoPtr_frameSetter), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UINavigationItem uINavigationItem
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Card.NativeFieldInfoPtr_uINavigationItem));
      return pointer == System.IntPtr.Zero ? (UINavigationItem) null : new UINavigationItem(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Card.NativeFieldInfoPtr_uINavigationItem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject frontGroup
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Card.NativeFieldInfoPtr_frontGroup));
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Card.NativeFieldInfoPtr_frontGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject backGroup
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Card.NativeFieldInfoPtr_backGroup));
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Card.NativeFieldInfoPtr_backGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UpgradeHolder charmHolder
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Card.NativeFieldInfoPtr_charmHolder));
      return pointer == System.IntPtr.Zero ? (UpgradeHolder) null : new UpgradeHolder(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Card.NativeFieldInfoPtr_charmHolder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UpgradeHolder tokenHolder
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Card.NativeFieldInfoPtr_tokenHolder));
      return pointer == System.IntPtr.Zero ? (UpgradeHolder) null : new UpgradeHolder(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Card.NativeFieldInfoPtr_tokenHolder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UpgradeHolder crownHolder
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Card.NativeFieldInfoPtr_crownHolder));
      return pointer == System.IntPtr.Zero ? (UpgradeHolder) null : new UpgradeHolder(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Card.NativeFieldInfoPtr_crownHolder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ItemHolderPet itemHolderPet
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Card.NativeFieldInfoPtr_itemHolderPet));
      return pointer == System.IntPtr.Zero ? (ItemHolderPet) null : new ItemHolderPet(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Card.NativeFieldInfoPtr_itemHolderPet), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<LargeUIScaleUpdater> scalers
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Card.NativeFieldInfoPtr_scalers));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<LargeUIScaleUpdater>) null : new Il2CppReferenceArray<LargeUIScaleUpdater>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Card.NativeFieldInfoPtr_scalers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CardIdleAnimation imageIdleAnimator
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Card.NativeFieldInfoPtr_imageIdleAnimator));
      return pointer == System.IntPtr.Zero ? (CardIdleAnimation) null : new CardIdleAnimation(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Card.NativeFieldInfoPtr_imageIdleAnimator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CardIdleAnimation backgroundIdleAnimator
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Card.NativeFieldInfoPtr_backgroundIdleAnimator));
      return pointer == System.IntPtr.Zero ? (CardIdleAnimation) null : new CardIdleAnimation(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Card.NativeFieldInfoPtr_backgroundIdleAnimator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int currentEffectBonus
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Card.NativeFieldInfoPtr_currentEffectBonus));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Card.NativeFieldInfoPtr_currentEffectBonus)) = value;
    }
  }

  public unsafe float currentEffectFactor
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Card.NativeFieldInfoPtr_currentEffectFactor));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Card.NativeFieldInfoPtr_currentEffectFactor)) = value;
    }
  }

  public unsafe bool currentSilenced
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Card.NativeFieldInfoPtr_currentSilenced));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Card.NativeFieldInfoPtr_currentSilenced)) = value;
    }
  }

  public unsafe HashSet<KeywordData> keywords
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Card.NativeFieldInfoPtr_keywords));
      return pointer == System.IntPtr.Zero ? (HashSet<KeywordData>) null : new HashSet<KeywordData>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Card.NativeFieldInfoPtr_keywords), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe HashSet<CardData> mentionedCards
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Card.NativeFieldInfoPtr_mentionedCards));
      return pointer == System.IntPtr.Zero ? (HashSet<CardData>) null : new HashSet<CardData>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Card.NativeFieldInfoPtr_mentionedCards), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool hasScriptableImage
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Card.NativeFieldInfoPtr_hasScriptableImage));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Card.NativeFieldInfoPtr_hasScriptableImage)) = value;
    }
  }

  public unsafe ScriptableCardImage scriptableImage
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Card.NativeFieldInfoPtr_scriptableImage));
      return pointer == System.IntPtr.Zero ? (ScriptableCardImage) null : new ScriptableCardImage(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Card.NativeFieldInfoPtr_scriptableImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public enum PlayType
  {
    None,
    Play,
    Place,
  }

  [ObfuscatedName("Card/<>c")]
  [Serializable]
  public new sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__32_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__42_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__UpdateData_b__32_0_Internal_StatusEffectStacks_StatusEffectStacks_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__AddPassiveEffectText_b__42_0_Internal_Int32_StatusEffectData_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Card.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Card.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42868, XrefRangeEnd = 42870, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CardData.StatusEffectStacks _UpdateData_b__32_0(CardData.StatusEffectStacks a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Card.__c.NativeMethodInfoPtr__UpdateData_b__32_0_Internal_StatusEffectStacks_StatusEffectStacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CardData.StatusEffectStacks) null : new CardData.StatusEffectStacks(pointer);
    }

    [CallerCount(0)]
    public unsafe int _AddPassiveEffectText_b__42_0(StatusEffectData a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Card.__c.NativeMethodInfoPtr__AddPassiveEffectText_b__42_0_Internal_Int32_StatusEffectData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c()
    {
      Il2CppClassPointerStore<Card.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Card>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Card.__c>.NativeClassPtr);
      Card.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Card.__c>.NativeClassPtr, "<>9");
      Card.__c.NativeFieldInfoPtr___9__32_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Card.__c>.NativeClassPtr, "<>9__32_0");
      Card.__c.NativeFieldInfoPtr___9__42_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Card.__c>.NativeClassPtr, "<>9__42_0");
      Card.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Card.__c>.NativeClassPtr, 100666526);
      Card.__c.NativeMethodInfoPtr__UpdateData_b__32_0_Internal_StatusEffectStacks_StatusEffectStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Card.__c>.NativeClassPtr, 100666527);
      Card.__c.NativeMethodInfoPtr__AddPassiveEffectText_b__42_0_Internal_Int32_StatusEffectData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Card.__c>.NativeClassPtr, 100666528);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe Card.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(Card.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Card.__c) null : new Card.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Card.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<CardData.StatusEffectStacks, CardData.StatusEffectStacks> __9__32_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(Card.__c.NativeFieldInfoPtr___9__32_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<CardData.StatusEffectStacks, CardData.StatusEffectStacks>) null : new Il2CppSystem.Func<CardData.StatusEffectStacks, CardData.StatusEffectStacks>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Card.__c.NativeFieldInfoPtr___9__32_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<StatusEffectData, int> __9__42_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(Card.__c.NativeFieldInfoPtr___9__42_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<StatusEffectData, int>) null : new Il2CppSystem.Func<StatusEffectData, int>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Card.__c.NativeFieldInfoPtr___9__42_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("Card/<UpdateData>d__32")]
  public sealed class _UpdateData_d__32 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_doPing;
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
    public unsafe _UpdateData_d__32(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Card._UpdateData_d__32>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Card._UpdateData_d__32.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 42877, RefRangeEnd = 42878, XrefRangeStart = 42870, XrefRangeEnd = 42877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Card._UpdateData_d__32.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42878, XrefRangeEnd = 43092, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Card._UpdateData_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43092, XrefRangeEnd = 43095, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void __m__Finally1()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Card._UpdateData_d__32.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Card._UpdateData_d__32.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43095, XrefRangeEnd = 43101, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Card._UpdateData_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Card._UpdateData_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _UpdateData_d__32()
    {
      Il2CppClassPointerStore<Card._UpdateData_d__32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Card>.NativeClassPtr, "<UpdateData>d__32");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Card._UpdateData_d__32>.NativeClassPtr);
      Card._UpdateData_d__32.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Card._UpdateData_d__32>.NativeClassPtr, "<>1__state");
      Card._UpdateData_d__32.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Card._UpdateData_d__32>.NativeClassPtr, "<>2__current");
      Card._UpdateData_d__32.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Card._UpdateData_d__32>.NativeClassPtr, "<>4__this");
      Card._UpdateData_d__32.NativeFieldInfoPtr_doPing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Card._UpdateData_d__32>.NativeClassPtr, nameof (doPing));
      Card._UpdateData_d__32.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Card._UpdateData_d__32>.NativeClassPtr, "<>7__wrap1");
      Card._UpdateData_d__32.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Card._UpdateData_d__32>.NativeClassPtr, "<>7__wrap2");
      Card._UpdateData_d__32.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Card._UpdateData_d__32>.NativeClassPtr, "<>7__wrap3");
      Card._UpdateData_d__32.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Card._UpdateData_d__32>.NativeClassPtr, 100666529);
      Card._UpdateData_d__32.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Card._UpdateData_d__32>.NativeClassPtr, 100666530);
      Card._UpdateData_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Card._UpdateData_d__32>.NativeClassPtr, 100666531);
      Card._UpdateData_d__32.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Card._UpdateData_d__32>.NativeClassPtr, 100666532);
      Card._UpdateData_d__32.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Card._UpdateData_d__32>.NativeClassPtr, 100666533);
      Card._UpdateData_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Card._UpdateData_d__32>.NativeClassPtr, 100666534);
      Card._UpdateData_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Card._UpdateData_d__32>.NativeClassPtr, 100666535);
    }

    public _UpdateData_d__32(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Card._UpdateData_d__32.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Card._UpdateData_d__32.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Card._UpdateData_d__32.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Card._UpdateData_d__32.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Card __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Card._UpdateData_d__32.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (Card) null : new Card(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Card._UpdateData_d__32.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool doPing
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Card._UpdateData_d__32.NativeFieldInfoPtr_doPing));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Card._UpdateData_d__32.NativeFieldInfoPtr_doPing)) = value;
      }
    }

    public unsafe Il2CppReferenceArray<CardData.StatusEffectStacks> __7__wrap1
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Card._UpdateData_d__32.NativeFieldInfoPtr___7__wrap1));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CardData.StatusEffectStacks>) null : new Il2CppReferenceArray<CardData.StatusEffectStacks>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Card._UpdateData_d__32.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int __7__wrap2
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Card._UpdateData_d__32.NativeFieldInfoPtr___7__wrap2));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Card._UpdateData_d__32.NativeFieldInfoPtr___7__wrap2)) = value;
      }
    }

    public List<CardData.StatusEffectStacks>.Enumerator __7__wrap3
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Card._UpdateData_d__32.NativeFieldInfoPtr___7__wrap3);
        return new List<CardData.StatusEffectStacks>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<CardData.StatusEffectStacks>.Enumerator>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Card._UpdateData_d__32.NativeFieldInfoPtr___7__wrap3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<CardData.StatusEffectStacks>.Enumerator>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  [ObfuscatedName("Card/<UpdateDisplay>d__33")]
  public sealed class _UpdateDisplay_d__33 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_doPing;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _UpdateDisplay_d__33(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Card._UpdateDisplay_d__33>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Card._UpdateDisplay_d__33.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Card._UpdateDisplay_d__33.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43101, XrefRangeEnd = 43105, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Card._UpdateDisplay_d__33.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Card._UpdateDisplay_d__33.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43105, XrefRangeEnd = 43111, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Card._UpdateDisplay_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Card._UpdateDisplay_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _UpdateDisplay_d__33()
    {
      Il2CppClassPointerStore<Card._UpdateDisplay_d__33>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Card>.NativeClassPtr, "<UpdateDisplay>d__33");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Card._UpdateDisplay_d__33>.NativeClassPtr);
      Card._UpdateDisplay_d__33.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Card._UpdateDisplay_d__33>.NativeClassPtr, "<>1__state");
      Card._UpdateDisplay_d__33.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Card._UpdateDisplay_d__33>.NativeClassPtr, "<>2__current");
      Card._UpdateDisplay_d__33.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Card._UpdateDisplay_d__33>.NativeClassPtr, "<>4__this");
      Card._UpdateDisplay_d__33.NativeFieldInfoPtr_doPing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Card._UpdateDisplay_d__33>.NativeClassPtr, nameof (doPing));
      Card._UpdateDisplay_d__33.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Card._UpdateDisplay_d__33>.NativeClassPtr, 100666536);
      Card._UpdateDisplay_d__33.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Card._UpdateDisplay_d__33>.NativeClassPtr, 100666537);
      Card._UpdateDisplay_d__33.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Card._UpdateDisplay_d__33>.NativeClassPtr, 100666538);
      Card._UpdateDisplay_d__33.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Card._UpdateDisplay_d__33>.NativeClassPtr, 100666539);
      Card._UpdateDisplay_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Card._UpdateDisplay_d__33>.NativeClassPtr, 100666540);
      Card._UpdateDisplay_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Card._UpdateDisplay_d__33>.NativeClassPtr, 100666541);
    }

    public _UpdateDisplay_d__33(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Card._UpdateDisplay_d__33.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Card._UpdateDisplay_d__33.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Card._UpdateDisplay_d__33.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Card._UpdateDisplay_d__33.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Card __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Card._UpdateDisplay_d__33.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (Card) null : new Card(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Card._UpdateDisplay_d__33.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool doPing
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Card._UpdateDisplay_d__33.NativeFieldInfoPtr_doPing));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Card._UpdateDisplay_d__33.NativeFieldInfoPtr_doPing)) = value;
      }
    }
  }
}
