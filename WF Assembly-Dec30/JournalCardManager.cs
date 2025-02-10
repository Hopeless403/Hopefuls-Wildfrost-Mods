// Decompiled with JetBrains decompiler
// Type: JournalCardManager
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
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

#nullable disable
public class JournalCardManager : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_categories;
  private static readonly System.IntPtr NativeFieldInfoPtr_cardPrefab;
  private static readonly System.IntPtr NativeFieldInfoPtr_content;
  private static readonly System.IntPtr NativeFieldInfoPtr_scroller;
  private static readonly System.IntPtr NativeFieldInfoPtr_cardDisplay;
  private static readonly System.IntPtr NativeFieldInfoPtr_tabs;
  private static readonly System.IntPtr NativeFieldInfoPtr_tabSelected;
  private static readonly System.IntPtr NativeFieldInfoPtr_hotKeyTabLeft;
  private static readonly System.IntPtr NativeFieldInfoPtr_hotKeyTabRight;
  private static readonly System.IntPtr NativeFieldInfoPtr_selectCardSfxEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_discovered;
  private static readonly System.IntPtr NativeFieldInfoPtr_currentCategory;
  private static readonly System.IntPtr NativeFieldInfoPtr_handles;
  private static readonly System.IntPtr NativeFieldInfoPtr_cardIcons;
  private static readonly System.IntPtr NativeFieldInfoPtr_locale;
  private static readonly System.IntPtr NativeFieldInfoPtr_scaleOverride;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateCards_Public_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateCards_Public_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadCardData_Private_List_1_KeyValuePair_2_String_CardData_Category_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHandles_Private_Void_Category_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClearCurrentHandles_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ScrollToTop_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Select_Public_Void_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SelectTab_Public_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_NextTab_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PreviousTab_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90764, XrefRangeEnd = 90811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JournalCardManager.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90811, XrefRangeEnd = 90830, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JournalCardManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90830, XrefRangeEnd = 90833, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CreateCards(string categoryName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(categoryName)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JournalCardManager.NativeMethodInfoPtr_CreateCards_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 90897, RefRangeEnd = 90902, XrefRangeStart = 90833, XrefRangeEnd = 90897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CreateCards(int categoryIndex)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &categoryIndex
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JournalCardManager.NativeMethodInfoPtr_CreateCards_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 90994, RefRangeEnd = 90995, XrefRangeStart = 90902, XrefRangeEnd = 90994, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe List<KeyValuePair<string, CardData>> LoadCardData(
    JournalCardManager.Category category)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) category))
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JournalCardManager.NativeMethodInfoPtr_LoadCardData_Private_List_1_KeyValuePair_2_String_CardData_Category_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (List<KeyValuePair<string, CardData>>) null : new List<KeyValuePair<string, CardData>>(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90995, XrefRangeEnd = 91018, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void GetHandles(JournalCardManager.Category category)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) category))
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JournalCardManager.NativeMethodInfoPtr_GetHandles_Private_Void_Category_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 91040, RefRangeEnd = 91042, XrefRangeStart = 91018, XrefRangeEnd = 91040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ClearCurrentHandles()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JournalCardManager.NativeMethodInfoPtr_ClearCurrentHandles_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91042, XrefRangeEnd = 91047, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator ScrollToTop()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JournalCardManager.NativeMethodInfoPtr_ScrollToTop_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91047, XrefRangeEnd = 91052, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Select(CardData cardData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cardData)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JournalCardManager.NativeMethodInfoPtr_Select_Public_Void_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 91058, RefRangeEnd = 91059, XrefRangeStart = 91052, XrefRangeEnd = 91058, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SelectTab(int index)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &index
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JournalCardManager.NativeMethodInfoPtr_SelectTab_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91059, XrefRangeEnd = 91061, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void NextTab()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JournalCardManager.NativeMethodInfoPtr_NextTab_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91061, XrefRangeEnd = 91067, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PreviousTab()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JournalCardManager.NativeMethodInfoPtr_PreviousTab_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91067, XrefRangeEnd = 91083, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe JournalCardManager()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JournalCardManager>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JournalCardManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static JournalCardManager()
  {
    Il2CppClassPointerStore<JournalCardManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (JournalCardManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JournalCardManager>.NativeClassPtr);
    JournalCardManager.NativeFieldInfoPtr_categories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCardManager>.NativeClassPtr, nameof (categories));
    JournalCardManager.NativeFieldInfoPtr_cardPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCardManager>.NativeClassPtr, nameof (cardPrefab));
    JournalCardManager.NativeFieldInfoPtr_content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCardManager>.NativeClassPtr, nameof (content));
    JournalCardManager.NativeFieldInfoPtr_scroller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCardManager>.NativeClassPtr, nameof (scroller));
    JournalCardManager.NativeFieldInfoPtr_cardDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCardManager>.NativeClassPtr, nameof (cardDisplay));
    JournalCardManager.NativeFieldInfoPtr_tabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCardManager>.NativeClassPtr, nameof (tabs));
    JournalCardManager.NativeFieldInfoPtr_tabSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCardManager>.NativeClassPtr, nameof (tabSelected));
    JournalCardManager.NativeFieldInfoPtr_hotKeyTabLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCardManager>.NativeClassPtr, nameof (hotKeyTabLeft));
    JournalCardManager.NativeFieldInfoPtr_hotKeyTabRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCardManager>.NativeClassPtr, nameof (hotKeyTabRight));
    JournalCardManager.NativeFieldInfoPtr_selectCardSfxEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCardManager>.NativeClassPtr, nameof (selectCardSfxEvent));
    JournalCardManager.NativeFieldInfoPtr_discovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCardManager>.NativeClassPtr, nameof (discovered));
    JournalCardManager.NativeFieldInfoPtr_currentCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCardManager>.NativeClassPtr, nameof (currentCategory));
    JournalCardManager.NativeFieldInfoPtr_handles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCardManager>.NativeClassPtr, nameof (handles));
    JournalCardManager.NativeFieldInfoPtr_cardIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCardManager>.NativeClassPtr, nameof (cardIcons));
    JournalCardManager.NativeFieldInfoPtr_locale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCardManager>.NativeClassPtr, nameof (locale));
    JournalCardManager.NativeFieldInfoPtr_scaleOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCardManager>.NativeClassPtr, nameof (scaleOverride));
    JournalCardManager.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCardManager>.NativeClassPtr, 100671098);
    JournalCardManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCardManager>.NativeClassPtr, 100671099);
    JournalCardManager.NativeMethodInfoPtr_CreateCards_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCardManager>.NativeClassPtr, 100671100);
    JournalCardManager.NativeMethodInfoPtr_CreateCards_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCardManager>.NativeClassPtr, 100671101);
    JournalCardManager.NativeMethodInfoPtr_LoadCardData_Private_List_1_KeyValuePair_2_String_CardData_Category_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCardManager>.NativeClassPtr, 100671102);
    JournalCardManager.NativeMethodInfoPtr_GetHandles_Private_Void_Category_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCardManager>.NativeClassPtr, 100671103);
    JournalCardManager.NativeMethodInfoPtr_ClearCurrentHandles_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCardManager>.NativeClassPtr, 100671104);
    JournalCardManager.NativeMethodInfoPtr_ScrollToTop_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCardManager>.NativeClassPtr, 100671105);
    JournalCardManager.NativeMethodInfoPtr_Select_Public_Void_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCardManager>.NativeClassPtr, 100671106);
    JournalCardManager.NativeMethodInfoPtr_SelectTab_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCardManager>.NativeClassPtr, 100671107);
    JournalCardManager.NativeMethodInfoPtr_NextTab_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCardManager>.NativeClassPtr, 100671108);
    JournalCardManager.NativeMethodInfoPtr_PreviousTab_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCardManager>.NativeClassPtr, 100671109);
    JournalCardManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCardManager>.NativeClassPtr, 100671110);
  }

  public JournalCardManager(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Il2CppReferenceArray<JournalCardManager.Category> categories
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCardManager.NativeFieldInfoPtr_categories));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<JournalCardManager.Category>) null : new Il2CppReferenceArray<JournalCardManager.Category>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalCardManager.NativeFieldInfoPtr_categories), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe JournalCard cardPrefab
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCardManager.NativeFieldInfoPtr_cardPrefab));
      return pointer == System.IntPtr.Zero ? (JournalCard) null : new JournalCard(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalCardManager.NativeFieldInfoPtr_cardPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform content
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCardManager.NativeFieldInfoPtr_content));
      return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalCardManager.NativeFieldInfoPtr_content), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Scroller scroller
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCardManager.NativeFieldInfoPtr_scroller));
      return pointer == System.IntPtr.Zero ? (Scroller) null : new Scroller(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalCardManager.NativeFieldInfoPtr_scroller), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe JournalCardDisplay cardDisplay
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCardManager.NativeFieldInfoPtr_cardDisplay));
      return pointer == System.IntPtr.Zero ? (JournalCardDisplay) null : new JournalCardDisplay(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalCardManager.NativeFieldInfoPtr_cardDisplay), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<Button> tabs
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCardManager.NativeFieldInfoPtr_tabs));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Button>) null : new Il2CppReferenceArray<Button>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalCardManager.NativeFieldInfoPtr_tabs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<GameObject> tabSelected
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCardManager.NativeFieldInfoPtr_tabSelected));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<GameObject>) null : new Il2CppReferenceArray<GameObject>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalCardManager.NativeFieldInfoPtr_tabSelected), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RewiredHotKeyController hotKeyTabLeft
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCardManager.NativeFieldInfoPtr_hotKeyTabLeft));
      return pointer == System.IntPtr.Zero ? (RewiredHotKeyController) null : new RewiredHotKeyController(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalCardManager.NativeFieldInfoPtr_hotKeyTabLeft), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RewiredHotKeyController hotKeyTabRight
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCardManager.NativeFieldInfoPtr_hotKeyTabRight));
      return pointer == System.IntPtr.Zero ? (RewiredHotKeyController) null : new RewiredHotKeyController(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalCardManager.NativeFieldInfoPtr_hotKeyTabRight), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe EventReference selectCardSfxEvent
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCardManager.NativeFieldInfoPtr_selectCardSfxEvent));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCardManager.NativeFieldInfoPtr_selectCardSfxEvent)) = value;
    }
  }

  public unsafe List<string> discovered
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCardManager.NativeFieldInfoPtr_discovered));
      return pointer == System.IntPtr.Zero ? (List<string>) null : new List<string>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalCardManager.NativeFieldInfoPtr_discovered), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int currentCategory
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCardManager.NativeFieldInfoPtr_currentCategory));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCardManager.NativeFieldInfoPtr_currentCategory)) = value;
    }
  }

  public unsafe List<AsyncOperationHandle<CardData>> handles
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCardManager.NativeFieldInfoPtr_handles));
      return pointer == System.IntPtr.Zero ? (List<AsyncOperationHandle<CardData>>) null : new List<AsyncOperationHandle<CardData>>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalCardManager.NativeFieldInfoPtr_handles), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<JournalCard> cardIcons
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCardManager.NativeFieldInfoPtr_cardIcons));
      return pointer == System.IntPtr.Zero ? (List<JournalCard>) null : new List<JournalCard>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalCardManager.NativeFieldInfoPtr_cardIcons), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEngine.Localization.Locale locale
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCardManager.NativeFieldInfoPtr_locale));
      return pointer == System.IntPtr.Zero ? (UnityEngine.Localization.Locale) null : new UnityEngine.Localization.Locale(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalCardManager.NativeFieldInfoPtr_locale), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Dictionary<string, float> scaleOverride
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(JournalCardManager.NativeFieldInfoPtr_scaleOverride, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Dictionary<string, float>) null : new Dictionary<string, float>(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(JournalCardManager.NativeFieldInfoPtr_scaleOverride, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public sealed class Category : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_name;
    private static readonly System.IntPtr NativeFieldInfoPtr_cards;

    static Category()
    {
      Il2CppClassPointerStore<JournalCardManager.Category>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JournalCardManager>.NativeClassPtr, nameof (Category));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JournalCardManager.Category>.NativeClassPtr);
      JournalCardManager.Category.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCardManager.Category>.NativeClassPtr, nameof (name));
      JournalCardManager.Category.NativeFieldInfoPtr_cards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCardManager.Category>.NativeClassPtr, nameof (cards));
    }

    public Category(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Category()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<JournalCardManager.Category>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JournalCardManager.Category>.NativeClassPtr, data));
    }

    public unsafe string name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCardManager.Category.NativeFieldInfoPtr_name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalCardManager.Category.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe Il2CppReferenceArray<AssetReferenceT<CardData>> cards
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCardManager.Category.NativeFieldInfoPtr_cards));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<AssetReferenceT<CardData>>) null : new Il2CppReferenceArray<AssetReferenceT<CardData>>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalCardManager.Category.NativeFieldInfoPtr_cards), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("JournalCardManager/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__20_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__20_1;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__20_2;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__20_3;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__21_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__LoadCardData_b__20_0_Internal_CardData_AsyncOperationHandle_1_CardData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__LoadCardData_b__20_1_Internal_String_CardData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__LoadCardData_b__20_2_Internal_CardData_CardData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__LoadCardData_b__20_3_Internal_String_KeyValuePair_2_String_CardData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetHandles_b__21_0_Internal_AsyncOperationHandle_1_CardData_AssetReferenceT_1_CardData_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JournalCardManager.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(JournalCardManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90747, XrefRangeEnd = 90750, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CardData _LoadCardData_b__20_0(AsyncOperationHandle<CardData> a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) a))
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JournalCardManager.__c.NativeMethodInfoPtr__LoadCardData_b__20_0_Internal_CardData_AsyncOperationHandle_1_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CardData) null : new CardData(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90750, XrefRangeEnd = 90752, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string _LoadCardData_b__20_1(CardData a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(JournalCardManager.__c.NativeMethodInfoPtr__LoadCardData_b__20_1_Internal_String_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    public unsafe CardData _LoadCardData_b__20_2(CardData a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JournalCardManager.__c.NativeMethodInfoPtr__LoadCardData_b__20_2_Internal_CardData_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CardData) null : new CardData(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90752, XrefRangeEnd = 90753, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string _LoadCardData_b__20_3(KeyValuePair<string, CardData> a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) a))
      };
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(JournalCardManager.__c.NativeMethodInfoPtr__LoadCardData_b__20_3_Internal_String_KeyValuePair_2_String_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    public unsafe AsyncOperationHandle<CardData> _GetHandles_b__21_0(AssetReferenceT<CardData> a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(JournalCardManager.__c.NativeMethodInfoPtr__GetHandles_b__21_0_Internal_AsyncOperationHandle_1_CardData_AssetReferenceT_1_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new AsyncOperationHandle<CardData>(pointer);
    }

    static __c()
    {
      Il2CppClassPointerStore<JournalCardManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JournalCardManager>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JournalCardManager.__c>.NativeClassPtr);
      JournalCardManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCardManager.__c>.NativeClassPtr, "<>9");
      JournalCardManager.__c.NativeFieldInfoPtr___9__20_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCardManager.__c>.NativeClassPtr, "<>9__20_0");
      JournalCardManager.__c.NativeFieldInfoPtr___9__20_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCardManager.__c>.NativeClassPtr, "<>9__20_1");
      JournalCardManager.__c.NativeFieldInfoPtr___9__20_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCardManager.__c>.NativeClassPtr, "<>9__20_2");
      JournalCardManager.__c.NativeFieldInfoPtr___9__20_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCardManager.__c>.NativeClassPtr, "<>9__20_3");
      JournalCardManager.__c.NativeFieldInfoPtr___9__21_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCardManager.__c>.NativeClassPtr, "<>9__21_0");
      JournalCardManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCardManager.__c>.NativeClassPtr, 100671113);
      JournalCardManager.__c.NativeMethodInfoPtr__LoadCardData_b__20_0_Internal_CardData_AsyncOperationHandle_1_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCardManager.__c>.NativeClassPtr, 100671114);
      JournalCardManager.__c.NativeMethodInfoPtr__LoadCardData_b__20_1_Internal_String_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCardManager.__c>.NativeClassPtr, 100671115);
      JournalCardManager.__c.NativeMethodInfoPtr__LoadCardData_b__20_2_Internal_CardData_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCardManager.__c>.NativeClassPtr, 100671116);
      JournalCardManager.__c.NativeMethodInfoPtr__LoadCardData_b__20_3_Internal_String_KeyValuePair_2_String_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCardManager.__c>.NativeClassPtr, 100671117);
      JournalCardManager.__c.NativeMethodInfoPtr__GetHandles_b__21_0_Internal_AsyncOperationHandle_1_CardData_AssetReferenceT_1_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCardManager.__c>.NativeClassPtr, 100671118);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe JournalCardManager.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(JournalCardManager.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (JournalCardManager.__c) null : new JournalCardManager.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(JournalCardManager.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<AsyncOperationHandle<CardData>, CardData> __9__20_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(JournalCardManager.__c.NativeFieldInfoPtr___9__20_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<AsyncOperationHandle<CardData>, CardData>) null : new Il2CppSystem.Func<AsyncOperationHandle<CardData>, CardData>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(JournalCardManager.__c.NativeFieldInfoPtr___9__20_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<CardData, string> __9__20_1
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(JournalCardManager.__c.NativeFieldInfoPtr___9__20_1, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<CardData, string>) null : new Il2CppSystem.Func<CardData, string>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(JournalCardManager.__c.NativeFieldInfoPtr___9__20_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<CardData, CardData> __9__20_2
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(JournalCardManager.__c.NativeFieldInfoPtr___9__20_2, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<CardData, CardData>) null : new Il2CppSystem.Func<CardData, CardData>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(JournalCardManager.__c.NativeFieldInfoPtr___9__20_2, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<KeyValuePair<string, CardData>, string> __9__20_3
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(JournalCardManager.__c.NativeFieldInfoPtr___9__20_3, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<KeyValuePair<string, CardData>, string>) null : new Il2CppSystem.Func<KeyValuePair<string, CardData>, string>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(JournalCardManager.__c.NativeFieldInfoPtr___9__20_3, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<AssetReferenceT<CardData>, AsyncOperationHandle<CardData>> __9__21_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(JournalCardManager.__c.NativeFieldInfoPtr___9__21_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<AssetReferenceT<CardData>, AsyncOperationHandle<CardData>>) null : new Il2CppSystem.Func<AssetReferenceT<CardData>, AsyncOperationHandle<CardData>>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(JournalCardManager.__c.NativeFieldInfoPtr___9__21_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("JournalCardManager/<ScrollToTop>d__23")]
  public sealed class _ScrollToTop_d__23 : Il2CppSystem.Object
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
    public unsafe _ScrollToTop_d__23(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JournalCardManager._ScrollToTop_d__23>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(JournalCardManager._ScrollToTop_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(JournalCardManager._ScrollToTop_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90753, XrefRangeEnd = 90758, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JournalCardManager._ScrollToTop_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JournalCardManager._ScrollToTop_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90758, XrefRangeEnd = 90764, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(JournalCardManager._ScrollToTop_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JournalCardManager._ScrollToTop_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _ScrollToTop_d__23()
    {
      Il2CppClassPointerStore<JournalCardManager._ScrollToTop_d__23>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JournalCardManager>.NativeClassPtr, "<ScrollToTop>d__23");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JournalCardManager._ScrollToTop_d__23>.NativeClassPtr);
      JournalCardManager._ScrollToTop_d__23.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCardManager._ScrollToTop_d__23>.NativeClassPtr, "<>1__state");
      JournalCardManager._ScrollToTop_d__23.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCardManager._ScrollToTop_d__23>.NativeClassPtr, "<>2__current");
      JournalCardManager._ScrollToTop_d__23.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCardManager._ScrollToTop_d__23>.NativeClassPtr, "<>4__this");
      JournalCardManager._ScrollToTop_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCardManager._ScrollToTop_d__23>.NativeClassPtr, 100671119);
      JournalCardManager._ScrollToTop_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCardManager._ScrollToTop_d__23>.NativeClassPtr, 100671120);
      JournalCardManager._ScrollToTop_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCardManager._ScrollToTop_d__23>.NativeClassPtr, 100671121);
      JournalCardManager._ScrollToTop_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCardManager._ScrollToTop_d__23>.NativeClassPtr, 100671122);
      JournalCardManager._ScrollToTop_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCardManager._ScrollToTop_d__23>.NativeClassPtr, 100671123);
      JournalCardManager._ScrollToTop_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCardManager._ScrollToTop_d__23>.NativeClassPtr, 100671124);
    }

    public _ScrollToTop_d__23(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCardManager._ScrollToTop_d__23.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCardManager._ScrollToTop_d__23.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCardManager._ScrollToTop_d__23.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalCardManager._ScrollToTop_d__23.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe JournalCardManager __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCardManager._ScrollToTop_d__23.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (JournalCardManager) null : new JournalCardManager(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalCardManager._ScrollToTop_d__23.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
