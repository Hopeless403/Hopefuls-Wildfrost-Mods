// Decompiled with JetBrains decompiler
// Type: DemoEndSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class DemoEndSequence : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_pages;
  private static readonly IntPtr NativeFieldInfoPtr_pageBlips;
  private static readonly IntPtr NativeFieldInfoPtr_blipActive;
  private static readonly IntPtr NativeFieldInfoPtr_blipInactive;
  private static readonly IntPtr NativeFieldInfoPtr_openURL;
  private static readonly IntPtr NativeFieldInfoPtr_nextPageTween;
  private static readonly IntPtr NativeFieldInfoPtr_previousPageTween;
  private static readonly IntPtr NativeFieldInfoPtr_currentPage;
  private static readonly IntPtr NativeFieldInfoPtr_active;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_NextPage_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_PreviousPage_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Wishlist_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OpenPage_Private_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_ClosePage_Private_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98370, XrefRangeEnd = 98388, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DemoEndSequence.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98388, XrefRangeEnd = 98391, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void NextPage()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DemoEndSequence.NativeMethodInfoPtr_NextPage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98391, XrefRangeEnd = 98394, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PreviousPage()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DemoEndSequence.NativeMethodInfoPtr_PreviousPage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98394, XrefRangeEnd = 98395, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Wishlist()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DemoEndSequence.NativeMethodInfoPtr_Wishlist_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98395, XrefRangeEnd = 98405, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Close()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DemoEndSequence.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 98409, RefRangeEnd = 98411, XrefRangeStart = 98405, XrefRangeEnd = 98409, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OpenPage(int number)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &number
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DemoEndSequence.NativeMethodInfoPtr_OpenPage_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 98415, RefRangeEnd = 98417, XrefRangeStart = 98411, XrefRangeEnd = 98415, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ClosePage(int number)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &number
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DemoEndSequence.NativeMethodInfoPtr_ClosePage_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98417, XrefRangeEnd = 98418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DemoEndSequence()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DemoEndSequence>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DemoEndSequence.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static DemoEndSequence()
  {
    Il2CppClassPointerStore<DemoEndSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (DemoEndSequence));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DemoEndSequence>.NativeClassPtr);
    DemoEndSequence.NativeFieldInfoPtr_pages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoEndSequence>.NativeClassPtr, nameof (pages));
    DemoEndSequence.NativeFieldInfoPtr_pageBlips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoEndSequence>.NativeClassPtr, nameof (pageBlips));
    DemoEndSequence.NativeFieldInfoPtr_blipActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoEndSequence>.NativeClassPtr, nameof (blipActive));
    DemoEndSequence.NativeFieldInfoPtr_blipInactive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoEndSequence>.NativeClassPtr, nameof (blipInactive));
    DemoEndSequence.NativeFieldInfoPtr_openURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoEndSequence>.NativeClassPtr, nameof (openURL));
    DemoEndSequence.NativeFieldInfoPtr_nextPageTween = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoEndSequence>.NativeClassPtr, nameof (nextPageTween));
    DemoEndSequence.NativeFieldInfoPtr_previousPageTween = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoEndSequence>.NativeClassPtr, nameof (previousPageTween));
    DemoEndSequence.NativeFieldInfoPtr_currentPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoEndSequence>.NativeClassPtr, nameof (currentPage));
    DemoEndSequence.NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoEndSequence>.NativeClassPtr, nameof (active));
    DemoEndSequence.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoEndSequence>.NativeClassPtr, 100671965);
    DemoEndSequence.NativeMethodInfoPtr_NextPage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoEndSequence>.NativeClassPtr, 100671966);
    DemoEndSequence.NativeMethodInfoPtr_PreviousPage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoEndSequence>.NativeClassPtr, 100671967);
    DemoEndSequence.NativeMethodInfoPtr_Wishlist_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoEndSequence>.NativeClassPtr, 100671968);
    DemoEndSequence.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoEndSequence>.NativeClassPtr, 100671969);
    DemoEndSequence.NativeMethodInfoPtr_OpenPage_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoEndSequence>.NativeClassPtr, 100671970);
    DemoEndSequence.NativeMethodInfoPtr_ClosePage_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoEndSequence>.NativeClassPtr, 100671971);
    DemoEndSequence.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoEndSequence>.NativeClassPtr, 100671972);
  }

  public DemoEndSequence(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Il2CppReferenceArray<GameObject> pages
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DemoEndSequence.NativeFieldInfoPtr_pages));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<GameObject>) null : new Il2CppReferenceArray<GameObject>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DemoEndSequence.NativeFieldInfoPtr_pages), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<Image> pageBlips
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DemoEndSequence.NativeFieldInfoPtr_pageBlips));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<Image>) null : new Il2CppReferenceArray<Image>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DemoEndSequence.NativeFieldInfoPtr_pageBlips), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite blipActive
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DemoEndSequence.NativeFieldInfoPtr_blipActive));
      return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DemoEndSequence.NativeFieldInfoPtr_blipActive), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite blipInactive
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DemoEndSequence.NativeFieldInfoPtr_blipInactive));
      return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DemoEndSequence.NativeFieldInfoPtr_blipInactive), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe OpenURL openURL
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DemoEndSequence.NativeFieldInfoPtr_openURL));
      return pointer == IntPtr.Zero ? (OpenURL) null : new OpenURL(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DemoEndSequence.NativeFieldInfoPtr_openURL), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TweenUI nextPageTween
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DemoEndSequence.NativeFieldInfoPtr_nextPageTween));
      return pointer == IntPtr.Zero ? (TweenUI) null : new TweenUI(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DemoEndSequence.NativeFieldInfoPtr_nextPageTween), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TweenUI previousPageTween
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DemoEndSequence.NativeFieldInfoPtr_previousPageTween));
      return pointer == IntPtr.Zero ? (TweenUI) null : new TweenUI(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DemoEndSequence.NativeFieldInfoPtr_previousPageTween), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int currentPage
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DemoEndSequence.NativeFieldInfoPtr_currentPage));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DemoEndSequence.NativeFieldInfoPtr_currentPage)) = value;
    }
  }

  public unsafe bool active
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DemoEndSequence.NativeFieldInfoPtr_active));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DemoEndSequence.NativeFieldInfoPtr_active)) = value;
    }
  }
}
