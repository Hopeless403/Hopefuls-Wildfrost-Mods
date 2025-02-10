// Decompiled with JetBrains decompiler
// Type: LorePageManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using FMODUnity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.AddressableAssets;

#nullable disable
public class LorePageManager : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_focusLayer;
  private static readonly IntPtr NativeFieldInfoPtr_focusLayerPageHolder;
  private static readonly IntPtr NativeFieldInfoPtr_pages;
  private static readonly IntPtr NativeFieldInfoPtr_assetReleaser;
  private static readonly IntPtr NativeFieldInfoPtr_selectSfxEvent;
  private static readonly IntPtr NativeFieldInfoPtr_deselectSfxEvent;
  private static readonly IntPtr NativeFieldInfoPtr_newSfxEvent;
  private static readonly IntPtr NativeFieldInfoPtr_newLoop;
  private static readonly IntPtr NativeFieldInfoPtr_pageObjects;
  private static readonly IntPtr NativeFieldInfoPtr_current;
  private static readonly IntPtr NativeFieldInfoPtr_focus;
  private static readonly IntPtr NativeFieldInfoPtr_focusLayerActive;
  private static readonly IntPtr NativeFieldInfoPtr_inspected;
  private static readonly IntPtr NativeFieldInfoPtr_newCount;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Populate_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Void_LorePage_0;
  private static readonly IntPtr NativeMethodInfoPtr_DisableFocusLayer_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91572, XrefRangeEnd = 91590, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LorePageManager.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91590, XrefRangeEnd = 91608, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LorePageManager.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 91650, RefRangeEnd = 91651, XrefRangeStart = 91608, XrefRangeEnd = 91650, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Populate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LorePageManager.NativeMethodInfoPtr_Populate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 91702, RefRangeEnd = 91703, XrefRangeStart = 91651, XrefRangeEnd = 91702, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Select(LorePage lorePage)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) lorePage)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LorePageManager.NativeMethodInfoPtr_Select_Public_Void_LorePage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 91738, RefRangeEnd = 91739, XrefRangeStart = 91703, XrefRangeEnd = 91738, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DisableFocusLayer()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LorePageManager.NativeMethodInfoPtr_DisableFocusLayer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91739, XrefRangeEnd = 91748, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LorePageManager()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LorePageManager>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LorePageManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static LorePageManager()
  {
    Il2CppClassPointerStore<LorePageManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (LorePageManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LorePageManager>.NativeClassPtr);
    LorePageManager.NativeFieldInfoPtr_focusLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LorePageManager>.NativeClassPtr, nameof (focusLayer));
    LorePageManager.NativeFieldInfoPtr_focusLayerPageHolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LorePageManager>.NativeClassPtr, nameof (focusLayerPageHolder));
    LorePageManager.NativeFieldInfoPtr_pages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LorePageManager>.NativeClassPtr, nameof (pages));
    LorePageManager.NativeFieldInfoPtr_assetReleaser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LorePageManager>.NativeClassPtr, nameof (assetReleaser));
    LorePageManager.NativeFieldInfoPtr_selectSfxEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LorePageManager>.NativeClassPtr, nameof (selectSfxEvent));
    LorePageManager.NativeFieldInfoPtr_deselectSfxEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LorePageManager>.NativeClassPtr, nameof (deselectSfxEvent));
    LorePageManager.NativeFieldInfoPtr_newSfxEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LorePageManager>.NativeClassPtr, nameof (newSfxEvent));
    LorePageManager.NativeFieldInfoPtr_newLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LorePageManager>.NativeClassPtr, nameof (newLoop));
    LorePageManager.NativeFieldInfoPtr_pageObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LorePageManager>.NativeClassPtr, nameof (pageObjects));
    LorePageManager.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LorePageManager>.NativeClassPtr, nameof (current));
    LorePageManager.NativeFieldInfoPtr_focus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LorePageManager>.NativeClassPtr, nameof (focus));
    LorePageManager.NativeFieldInfoPtr_focusLayerActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LorePageManager>.NativeClassPtr, nameof (focusLayerActive));
    LorePageManager.NativeFieldInfoPtr_inspected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LorePageManager>.NativeClassPtr, nameof (inspected));
    LorePageManager.NativeFieldInfoPtr_newCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LorePageManager>.NativeClassPtr, nameof (newCount));
    LorePageManager.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LorePageManager>.NativeClassPtr, 100671183);
    LorePageManager.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LorePageManager>.NativeClassPtr, 100671184);
    LorePageManager.NativeMethodInfoPtr_Populate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LorePageManager>.NativeClassPtr, 100671185);
    LorePageManager.NativeMethodInfoPtr_Select_Public_Void_LorePage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LorePageManager>.NativeClassPtr, 100671186);
    LorePageManager.NativeMethodInfoPtr_DisableFocusLayer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LorePageManager>.NativeClassPtr, 100671187);
    LorePageManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LorePageManager>.NativeClassPtr, 100671188);
  }

  public LorePageManager(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe GameObject focusLayer
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LorePageManager.NativeFieldInfoPtr_focusLayer));
      return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LorePageManager.NativeFieldInfoPtr_focusLayer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform focusLayerPageHolder
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LorePageManager.NativeFieldInfoPtr_focusLayerPageHolder));
      return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LorePageManager.NativeFieldInfoPtr_focusLayerPageHolder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<AssetReferenceT<JournalPageData>> pages
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LorePageManager.NativeFieldInfoPtr_pages));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<AssetReferenceT<JournalPageData>>) null : new Il2CppReferenceArray<AssetReferenceT<JournalPageData>>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LorePageManager.NativeFieldInfoPtr_pages), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AddressableReleaser assetReleaser
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LorePageManager.NativeFieldInfoPtr_assetReleaser));
      return pointer == IntPtr.Zero ? (AddressableReleaser) null : new AddressableReleaser(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LorePageManager.NativeFieldInfoPtr_assetReleaser), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe EventReference selectSfxEvent
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LorePageManager.NativeFieldInfoPtr_selectSfxEvent));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LorePageManager.NativeFieldInfoPtr_selectSfxEvent)) = value;
    }
  }

  public unsafe EventReference deselectSfxEvent
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LorePageManager.NativeFieldInfoPtr_deselectSfxEvent));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LorePageManager.NativeFieldInfoPtr_deselectSfxEvent)) = value;
    }
  }

  public unsafe EventReference newSfxEvent
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LorePageManager.NativeFieldInfoPtr_newSfxEvent));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LorePageManager.NativeFieldInfoPtr_newSfxEvent)) = value;
    }
  }

  public unsafe SfxLoop newLoop
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LorePageManager.NativeFieldInfoPtr_newLoop));
      return pointer == IntPtr.Zero ? (SfxLoop) null : new SfxLoop(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LorePageManager.NativeFieldInfoPtr_newLoop), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<GameObject> pageObjects
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LorePageManager.NativeFieldInfoPtr_pageObjects));
      return pointer == IntPtr.Zero ? (List<GameObject>) null : new List<GameObject>(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LorePageManager.NativeFieldInfoPtr_pageObjects), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LorePage current
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LorePageManager.NativeFieldInfoPtr_current));
      return pointer == IntPtr.Zero ? (LorePage) null : new LorePage(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LorePageManager.NativeFieldInfoPtr_current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Canvas focus
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LorePageManager.NativeFieldInfoPtr_focus));
      return pointer == IntPtr.Zero ? (Canvas) null : new Canvas(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LorePageManager.NativeFieldInfoPtr_focus), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool focusLayerActive
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LorePageManager.NativeFieldInfoPtr_focusLayerActive));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LorePageManager.NativeFieldInfoPtr_focusLayerActive)) = value;
    }
  }

  public unsafe List<string> inspected
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LorePageManager.NativeFieldInfoPtr_inspected));
      return pointer == IntPtr.Zero ? (List<string>) null : new List<string>(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LorePageManager.NativeFieldInfoPtr_inspected), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int newCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LorePageManager.NativeFieldInfoPtr_newCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LorePageManager.NativeFieldInfoPtr_newCount)) = value;
    }
  }
}
