// Decompiled with JetBrains decompiler
// Type: ScrollToNavigation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class ScrollToNavigation : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_scroller;
  private static readonly IntPtr NativeFieldInfoPtr_scrollRect;
  private static readonly IntPtr NativeMethodInfoPtr_get_HasScroller_Private_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_HasScrollRect_Private_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Navigation_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_TryScrollScroller_Private_Void_Transform_0;
  private static readonly IntPtr NativeMethodInfoPtr_ScrollScrollerVertical_Private_Void_Transform_0;
  private static readonly IntPtr NativeMethodInfoPtr_ScrollScrollerHorizontal_Private_Void_Transform_0;
  private static readonly IntPtr NativeMethodInfoPtr_TryScrollScrollRect_Private_Void_Transform_0;
  private static readonly IntPtr NativeMethodInfoPtr_ScrollScrollRectVertical_Private_Void_Transform_0;
  private static readonly IntPtr NativeMethodInfoPtr_ScrollScrollRectHorizontal_Private_Void_Transform_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe bool HasScroller
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94750, XrefRangeEnd = 94754, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScrollToNavigation.NativeMethodInfoPtr_get_HasScroller_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public unsafe bool HasScrollRect
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94754, XrefRangeEnd = 94758, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScrollToNavigation.NativeMethodInfoPtr_get_HasScrollRect_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94758, XrefRangeEnd = 94766, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScrollToNavigation.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94766, XrefRangeEnd = 94774, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScrollToNavigation.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94774, XrefRangeEnd = 94792, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Navigation()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScrollToNavigation.NativeMethodInfoPtr_Navigation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94792, XrefRangeEnd = 94800, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void TryScrollScroller(Transform target)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScrollToNavigation.NativeMethodInfoPtr_TryScrollScroller_Private_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94800, XrefRangeEnd = 94806, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ScrollScrollerVertical(Transform target)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScrollToNavigation.NativeMethodInfoPtr_ScrollScrollerVertical_Private_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94806, XrefRangeEnd = 94812, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ScrollScrollerHorizontal(Transform target)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScrollToNavigation.NativeMethodInfoPtr_ScrollScrollerHorizontal_Private_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 94821, RefRangeEnd = 94822, XrefRangeStart = 94812, XrefRangeEnd = 94821, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void TryScrollScrollRect(Transform target)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScrollToNavigation.NativeMethodInfoPtr_TryScrollScrollRect_Private_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94822, XrefRangeEnd = 94829, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ScrollScrollRectVertical(Transform target)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScrollToNavigation.NativeMethodInfoPtr_ScrollScrollRectVertical_Private_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94829, XrefRangeEnd = 94836, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ScrollScrollRectHorizontal(Transform target)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScrollToNavigation.NativeMethodInfoPtr_ScrollScrollRectHorizontal_Private_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ScrollToNavigation()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScrollToNavigation>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScrollToNavigation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ScrollToNavigation()
  {
    Il2CppClassPointerStore<ScrollToNavigation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ScrollToNavigation));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrollToNavigation>.NativeClassPtr);
    ScrollToNavigation.NativeFieldInfoPtr_scroller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollToNavigation>.NativeClassPtr, nameof (scroller));
    ScrollToNavigation.NativeFieldInfoPtr_scrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollToNavigation>.NativeClassPtr, nameof (scrollRect));
    ScrollToNavigation.NativeMethodInfoPtr_get_HasScroller_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollToNavigation>.NativeClassPtr, 100671499);
    ScrollToNavigation.NativeMethodInfoPtr_get_HasScrollRect_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollToNavigation>.NativeClassPtr, 100671500);
    ScrollToNavigation.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollToNavigation>.NativeClassPtr, 100671501);
    ScrollToNavigation.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollToNavigation>.NativeClassPtr, 100671502);
    ScrollToNavigation.NativeMethodInfoPtr_Navigation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollToNavigation>.NativeClassPtr, 100671503);
    ScrollToNavigation.NativeMethodInfoPtr_TryScrollScroller_Private_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollToNavigation>.NativeClassPtr, 100671504);
    ScrollToNavigation.NativeMethodInfoPtr_ScrollScrollerVertical_Private_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollToNavigation>.NativeClassPtr, 100671505);
    ScrollToNavigation.NativeMethodInfoPtr_ScrollScrollerHorizontal_Private_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollToNavigation>.NativeClassPtr, 100671506);
    ScrollToNavigation.NativeMethodInfoPtr_TryScrollScrollRect_Private_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollToNavigation>.NativeClassPtr, 100671507);
    ScrollToNavigation.NativeMethodInfoPtr_ScrollScrollRectVertical_Private_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollToNavigation>.NativeClassPtr, 100671508);
    ScrollToNavigation.NativeMethodInfoPtr_ScrollScrollRectHorizontal_Private_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollToNavigation>.NativeClassPtr, 100671509);
    ScrollToNavigation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollToNavigation>.NativeClassPtr, 100671510);
  }

  public ScrollToNavigation(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Scroller scroller
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrollToNavigation.NativeFieldInfoPtr_scroller));
      return pointer == IntPtr.Zero ? (Scroller) null : new Scroller(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScrollToNavigation.NativeFieldInfoPtr_scroller), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SmoothScrollRect scrollRect
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrollToNavigation.NativeFieldInfoPtr_scrollRect));
      return pointer == IntPtr.Zero ? (SmoothScrollRect) null : new SmoothScrollRect(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScrollToNavigation.NativeFieldInfoPtr_scrollRect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
