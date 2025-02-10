// Decompiled with JetBrains decompiler
// Type: CardInspector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class CardInspector : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_animatePopUps;
  private static readonly System.IntPtr NativeFieldInfoPtr_ignoreTimeScale;
  private static readonly System.IntPtr NativeFieldInfoPtr_showHiddenKeywords;
  private static readonly System.IntPtr NativeFieldInfoPtr_injuredKeyword;
  private static readonly System.IntPtr NativeFieldInfoPtr_leftPopGroup;
  private static readonly System.IntPtr NativeFieldInfoPtr_leftOverflowPopGroup;
  private static readonly System.IntPtr NativeFieldInfoPtr_rightPopGroup;
  private static readonly System.IntPtr NativeFieldInfoPtr_rightOverflowPopGroup;
  private static readonly System.IntPtr NativeFieldInfoPtr_bottomPopGroup;
  private static readonly System.IntPtr NativeFieldInfoPtr_overflowOrder;
  private static readonly System.IntPtr NativeFieldInfoPtr_popUpPrefab;
  private static readonly System.IntPtr NativeFieldInfoPtr_cardTooltipPrefab;
  private static readonly System.IntPtr NativeFieldInfoPtr_layoutsToFix;
  private static readonly System.IntPtr NativeFieldInfoPtr_popups;
  private static readonly System.IntPtr NativeFieldInfoPtr_currentPoppedKeywords;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreatePopups_Public_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateIconPopups_Private_Void_RectTransform_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClearPopups_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FixLayoutsAfterFrame_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FixLayouts_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckOverflow_Private_Boolean_Il2CppReferenceArray_1_RectTransform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckCollide_Private_Static_Boolean_RectTransform_IEnumerable_1_RectTransform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RectOverlap_Private_Static_Boolean_RectTransform_RectTransform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Popup_Private_CardPopUpPanel_KeywordData_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Popup_Private_CardTooltip_CardData_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 35641, RefRangeEnd = 35642, XrefRangeStart = 35582, XrefRangeEnd = 35641, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CreatePopups(Entity inspect)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inspect)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardInspector.NativeMethodInfoPtr_CreatePopups_Public_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 35648, RefRangeEnd = 35651, XrefRangeStart = 35642, XrefRangeEnd = 35648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CreateIconPopups(RectTransform iconLayoutGroup, Transform popGroup)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) iconLayoutGroup);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) popGroup);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardInspector.NativeMethodInfoPtr_CreateIconPopups_Private_Void_RectTransform_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 35671, RefRangeEnd = 35673, XrefRangeStart = 35651, XrefRangeEnd = 35671, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ClearPopups()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardInspector.NativeMethodInfoPtr_ClearPopups_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35673, XrefRangeEnd = 35678, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator FixLayoutsAfterFrame()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardInspector.NativeMethodInfoPtr_FixLayoutsAfterFrame_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35678, XrefRangeEnd = 35683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator FixLayouts()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardInspector.NativeMethodInfoPtr_FixLayouts_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35683, XrefRangeEnd = 35690, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardInspector.NativeMethodInfoPtr_CheckOverflow_Private_Boolean_Il2CppReferenceArray_1_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 35727, RefRangeEnd = 35728, XrefRangeStart = 35690, XrefRangeEnd = 35727, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool CheckCollide(RectTransform target, IEnumerable<RectTransform> checks)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) checks);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardInspector.NativeMethodInfoPtr_CheckCollide_Private_Static_Boolean_RectTransform_IEnumerable_1_RectTransform_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35728, XrefRangeEnd = 35739, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool RectOverlap(RectTransform a, RectTransform b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) b);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardInspector.NativeMethodInfoPtr_RectOverlap_Private_Static_Boolean_RectTransform_RectTransform_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 35752, RefRangeEnd = 35757, XrefRangeStart = 35739, XrefRangeEnd = 35752, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardPopUpPanel Popup(KeywordData keyword, Transform group)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) keyword);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) group);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardInspector.NativeMethodInfoPtr_Popup_Private_CardPopUpPanel_KeywordData_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (CardPopUpPanel) null : new CardPopUpPanel(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 35788, RefRangeEnd = 35789, XrefRangeStart = 35757, XrefRangeEnd = 35788, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardTooltip Popup(CardData cardData, Transform group)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cardData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) group);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardInspector.NativeMethodInfoPtr_Popup_Private_CardTooltip_CardData_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (CardTooltip) null : new CardTooltip(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35789, XrefRangeEnd = 35805, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardInspector()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardInspector>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardInspector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  public bool CheckOverflow(params RectTransform[] checkCollide)
  {
    return this.CheckOverflow(new Il2CppReferenceArray<RectTransform>(checkCollide));
  }

  static CardInspector()
  {
    Il2CppClassPointerStore<CardInspector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CardInspector));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardInspector>.NativeClassPtr);
    CardInspector.NativeFieldInfoPtr_animatePopUps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardInspector>.NativeClassPtr, nameof (animatePopUps));
    CardInspector.NativeFieldInfoPtr_ignoreTimeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardInspector>.NativeClassPtr, nameof (ignoreTimeScale));
    CardInspector.NativeFieldInfoPtr_showHiddenKeywords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardInspector>.NativeClassPtr, nameof (showHiddenKeywords));
    CardInspector.NativeFieldInfoPtr_injuredKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardInspector>.NativeClassPtr, nameof (injuredKeyword));
    CardInspector.NativeFieldInfoPtr_leftPopGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardInspector>.NativeClassPtr, nameof (leftPopGroup));
    CardInspector.NativeFieldInfoPtr_leftOverflowPopGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardInspector>.NativeClassPtr, nameof (leftOverflowPopGroup));
    CardInspector.NativeFieldInfoPtr_rightPopGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardInspector>.NativeClassPtr, nameof (rightPopGroup));
    CardInspector.NativeFieldInfoPtr_rightOverflowPopGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardInspector>.NativeClassPtr, nameof (rightOverflowPopGroup));
    CardInspector.NativeFieldInfoPtr_bottomPopGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardInspector>.NativeClassPtr, nameof (bottomPopGroup));
    CardInspector.NativeFieldInfoPtr_overflowOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardInspector>.NativeClassPtr, nameof (overflowOrder));
    CardInspector.NativeFieldInfoPtr_popUpPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardInspector>.NativeClassPtr, nameof (popUpPrefab));
    CardInspector.NativeFieldInfoPtr_cardTooltipPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardInspector>.NativeClassPtr, nameof (cardTooltipPrefab));
    CardInspector.NativeFieldInfoPtr_layoutsToFix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardInspector>.NativeClassPtr, nameof (layoutsToFix));
    CardInspector.NativeFieldInfoPtr_popups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardInspector>.NativeClassPtr, nameof (popups));
    CardInspector.NativeFieldInfoPtr_currentPoppedKeywords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardInspector>.NativeClassPtr, nameof (currentPoppedKeywords));
    CardInspector.NativeMethodInfoPtr_CreatePopups_Public_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardInspector>.NativeClassPtr, 100665656);
    CardInspector.NativeMethodInfoPtr_CreateIconPopups_Private_Void_RectTransform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardInspector>.NativeClassPtr, 100665657);
    CardInspector.NativeMethodInfoPtr_ClearPopups_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardInspector>.NativeClassPtr, 100665658);
    CardInspector.NativeMethodInfoPtr_FixLayoutsAfterFrame_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardInspector>.NativeClassPtr, 100665659);
    CardInspector.NativeMethodInfoPtr_FixLayouts_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardInspector>.NativeClassPtr, 100665660);
    CardInspector.NativeMethodInfoPtr_CheckOverflow_Private_Boolean_Il2CppReferenceArray_1_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardInspector>.NativeClassPtr, 100665661);
    CardInspector.NativeMethodInfoPtr_CheckCollide_Private_Static_Boolean_RectTransform_IEnumerable_1_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardInspector>.NativeClassPtr, 100665662);
    CardInspector.NativeMethodInfoPtr_RectOverlap_Private_Static_Boolean_RectTransform_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardInspector>.NativeClassPtr, 100665663);
    CardInspector.NativeMethodInfoPtr_Popup_Private_CardPopUpPanel_KeywordData_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardInspector>.NativeClassPtr, 100665664);
    CardInspector.NativeMethodInfoPtr_Popup_Private_CardTooltip_CardData_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardInspector>.NativeClassPtr, 100665665);
    CardInspector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardInspector>.NativeClassPtr, 100665666);
  }

  public CardInspector(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe bool animatePopUps
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardInspector.NativeFieldInfoPtr_animatePopUps));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardInspector.NativeFieldInfoPtr_animatePopUps)) = value;
    }
  }

  public unsafe bool ignoreTimeScale
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardInspector.NativeFieldInfoPtr_ignoreTimeScale));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardInspector.NativeFieldInfoPtr_ignoreTimeScale)) = value;
    }
  }

  public unsafe bool showHiddenKeywords
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardInspector.NativeFieldInfoPtr_showHiddenKeywords));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardInspector.NativeFieldInfoPtr_showHiddenKeywords)) = value;
    }
  }

  public unsafe KeywordData injuredKeyword
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardInspector.NativeFieldInfoPtr_injuredKeyword));
      return pointer == System.IntPtr.Zero ? (KeywordData) null : new KeywordData(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardInspector.NativeFieldInfoPtr_injuredKeyword), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform leftPopGroup
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardInspector.NativeFieldInfoPtr_leftPopGroup));
      return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardInspector.NativeFieldInfoPtr_leftPopGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform leftOverflowPopGroup
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardInspector.NativeFieldInfoPtr_leftOverflowPopGroup));
      return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardInspector.NativeFieldInfoPtr_leftOverflowPopGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform rightPopGroup
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardInspector.NativeFieldInfoPtr_rightPopGroup));
      return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardInspector.NativeFieldInfoPtr_rightPopGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform rightOverflowPopGroup
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardInspector.NativeFieldInfoPtr_rightOverflowPopGroup));
      return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardInspector.NativeFieldInfoPtr_rightOverflowPopGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform bottomPopGroup
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardInspector.NativeFieldInfoPtr_bottomPopGroup));
      return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardInspector.NativeFieldInfoPtr_bottomPopGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<RectTransform> overflowOrder
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardInspector.NativeFieldInfoPtr_overflowOrder));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<RectTransform>) null : new Il2CppReferenceArray<RectTransform>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardInspector.NativeFieldInfoPtr_overflowOrder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CardPopUpPanel popUpPrefab
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardInspector.NativeFieldInfoPtr_popUpPrefab));
      return pointer == System.IntPtr.Zero ? (CardPopUpPanel) null : new CardPopUpPanel(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardInspector.NativeFieldInfoPtr_popUpPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CardTooltip cardTooltipPrefab
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardInspector.NativeFieldInfoPtr_cardTooltipPrefab));
      return pointer == System.IntPtr.Zero ? (CardTooltip) null : new CardTooltip(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardInspector.NativeFieldInfoPtr_cardTooltipPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<LayoutGroup> layoutsToFix
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardInspector.NativeFieldInfoPtr_layoutsToFix));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<LayoutGroup>) null : new Il2CppReferenceArray<LayoutGroup>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardInspector.NativeFieldInfoPtr_layoutsToFix), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<Tooltip> popups
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardInspector.NativeFieldInfoPtr_popups));
      return pointer == System.IntPtr.Zero ? (List<Tooltip>) null : new List<Tooltip>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardInspector.NativeFieldInfoPtr_popups), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<KeywordData> currentPoppedKeywords
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardInspector.NativeFieldInfoPtr_currentPoppedKeywords));
      return pointer == System.IntPtr.Zero ? (List<KeywordData>) null : new List<KeywordData>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardInspector.NativeFieldInfoPtr_currentPoppedKeywords), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("CardInspector/<FixLayoutsAfterFrame>d__18")]
  public sealed class _FixLayoutsAfterFrame_d__18 : Il2CppSystem.Object
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
    public unsafe _FixLayoutsAfterFrame_d__18(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardInspector._FixLayoutsAfterFrame_d__18>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardInspector._FixLayoutsAfterFrame_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardInspector._FixLayoutsAfterFrame_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardInspector._FixLayoutsAfterFrame_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardInspector._FixLayoutsAfterFrame_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35567, XrefRangeEnd = 35573, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardInspector._FixLayoutsAfterFrame_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardInspector._FixLayoutsAfterFrame_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _FixLayoutsAfterFrame_d__18()
    {
      Il2CppClassPointerStore<CardInspector._FixLayoutsAfterFrame_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CardInspector>.NativeClassPtr, "<FixLayoutsAfterFrame>d__18");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardInspector._FixLayoutsAfterFrame_d__18>.NativeClassPtr);
      CardInspector._FixLayoutsAfterFrame_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardInspector._FixLayoutsAfterFrame_d__18>.NativeClassPtr, "<>1__state");
      CardInspector._FixLayoutsAfterFrame_d__18.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardInspector._FixLayoutsAfterFrame_d__18>.NativeClassPtr, "<>2__current");
      CardInspector._FixLayoutsAfterFrame_d__18.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardInspector._FixLayoutsAfterFrame_d__18>.NativeClassPtr, "<>4__this");
      CardInspector._FixLayoutsAfterFrame_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardInspector._FixLayoutsAfterFrame_d__18>.NativeClassPtr, 100665667);
      CardInspector._FixLayoutsAfterFrame_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardInspector._FixLayoutsAfterFrame_d__18>.NativeClassPtr, 100665668);
      CardInspector._FixLayoutsAfterFrame_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardInspector._FixLayoutsAfterFrame_d__18>.NativeClassPtr, 100665669);
      CardInspector._FixLayoutsAfterFrame_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardInspector._FixLayoutsAfterFrame_d__18>.NativeClassPtr, 100665670);
      CardInspector._FixLayoutsAfterFrame_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardInspector._FixLayoutsAfterFrame_d__18>.NativeClassPtr, 100665671);
      CardInspector._FixLayoutsAfterFrame_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardInspector._FixLayoutsAfterFrame_d__18>.NativeClassPtr, 100665672);
    }

    public _FixLayoutsAfterFrame_d__18(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardInspector._FixLayoutsAfterFrame_d__18.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardInspector._FixLayoutsAfterFrame_d__18.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardInspector._FixLayoutsAfterFrame_d__18.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardInspector._FixLayoutsAfterFrame_d__18.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CardInspector __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardInspector._FixLayoutsAfterFrame_d__18.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (CardInspector) null : new CardInspector(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardInspector._FixLayoutsAfterFrame_d__18.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("CardInspector/<FixLayouts>d__19")]
  public sealed class _FixLayouts_d__19 : Il2CppSystem.Object
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
    public unsafe _FixLayouts_d__19(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardInspector._FixLayouts_d__19>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardInspector._FixLayouts_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardInspector._FixLayouts_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35573, XrefRangeEnd = 35576, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardInspector._FixLayouts_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardInspector._FixLayouts_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35576, XrefRangeEnd = 35582, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardInspector._FixLayouts_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardInspector._FixLayouts_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _FixLayouts_d__19()
    {
      Il2CppClassPointerStore<CardInspector._FixLayouts_d__19>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CardInspector>.NativeClassPtr, "<FixLayouts>d__19");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardInspector._FixLayouts_d__19>.NativeClassPtr);
      CardInspector._FixLayouts_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardInspector._FixLayouts_d__19>.NativeClassPtr, "<>1__state");
      CardInspector._FixLayouts_d__19.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardInspector._FixLayouts_d__19>.NativeClassPtr, "<>2__current");
      CardInspector._FixLayouts_d__19.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardInspector._FixLayouts_d__19>.NativeClassPtr, "<>4__this");
      CardInspector._FixLayouts_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardInspector._FixLayouts_d__19>.NativeClassPtr, 100665673);
      CardInspector._FixLayouts_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardInspector._FixLayouts_d__19>.NativeClassPtr, 100665674);
      CardInspector._FixLayouts_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardInspector._FixLayouts_d__19>.NativeClassPtr, 100665675);
      CardInspector._FixLayouts_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardInspector._FixLayouts_d__19>.NativeClassPtr, 100665676);
      CardInspector._FixLayouts_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardInspector._FixLayouts_d__19>.NativeClassPtr, 100665677);
      CardInspector._FixLayouts_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardInspector._FixLayouts_d__19>.NativeClassPtr, 100665678);
    }

    public _FixLayouts_d__19(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardInspector._FixLayouts_d__19.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardInspector._FixLayouts_d__19.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardInspector._FixLayouts_d__19.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardInspector._FixLayouts_d__19.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CardInspector __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardInspector._FixLayouts_d__19.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (CardInspector) null : new CardInspector(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardInspector._FixLayouts_d__19.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
