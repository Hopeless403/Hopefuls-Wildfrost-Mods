// Decompiled with JetBrains decompiler
// Type: ScrollRectAuto
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
public class ScrollRectAuto : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr__scrollRect;
  private static readonly IntPtr NativeFieldInfoPtr_activateTime;
  private static readonly IntPtr NativeFieldInfoPtr_scrollSpeed;
  private static readonly IntPtr NativeFieldInfoPtr_acceleration;
  private static readonly IntPtr NativeFieldInfoPtr_disableAtBottom;
  private static readonly IntPtr NativeFieldInfoPtr_disableOnDrag;
  private static readonly IntPtr NativeFieldInfoPtr_disableOnMouseScroll;
  private static readonly IntPtr NativeFieldInfoPtr_reactivate;
  private static readonly IntPtr NativeFieldInfoPtr_reactivateTime;
  private static readonly IntPtr NativeFieldInfoPtr_onReachBottom;
  private static readonly IntPtr NativeFieldInfoPtr_scrollSpeedCurrent;
  private static readonly IntPtr NativeFieldInfoPtr_scroll;
  private static readonly IntPtr NativeFieldInfoPtr_active;
  private static readonly IntPtr NativeFieldInfoPtr_reactivateTimer;
  private static readonly IntPtr NativeMethodInfoPtr_get_scrollRect_Private_get_ScrollRect_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDrag_Public_Virtual_Final_New_Void_PointerEventData_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnScroll_Public_Virtual_Final_New_Void_PointerEventData_0;
  private static readonly IntPtr NativeMethodInfoPtr_Stop_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe ScrollRect scrollRect
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 94723, RefRangeEnd = 94725, XrefRangeStart = 94719, XrefRangeEnd = 94723, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScrollRectAuto.NativeMethodInfoPtr_get_scrollRect_Private_get_ScrollRect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (ScrollRect) null : new ScrollRect(pointer);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94725, XrefRangeEnd = 94749, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScrollRectAuto.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public virtual unsafe void OnDrag(PointerEventData eventData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScrollRectAuto.NativeMethodInfoPtr_OnDrag_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public virtual unsafe void OnScroll(PointerEventData eventData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScrollRectAuto.NativeMethodInfoPtr_OnScroll_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public unsafe void Stop()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScrollRectAuto.NativeMethodInfoPtr_Stop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94749, XrefRangeEnd = 94750, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ScrollRectAuto()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScrollRectAuto>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScrollRectAuto.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ScrollRectAuto()
  {
    Il2CppClassPointerStore<ScrollRectAuto>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ScrollRectAuto));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrollRectAuto>.NativeClassPtr);
    ScrollRectAuto.NativeFieldInfoPtr__scrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRectAuto>.NativeClassPtr, nameof (_scrollRect));
    ScrollRectAuto.NativeFieldInfoPtr_activateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRectAuto>.NativeClassPtr, nameof (activateTime));
    ScrollRectAuto.NativeFieldInfoPtr_scrollSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRectAuto>.NativeClassPtr, nameof (scrollSpeed));
    ScrollRectAuto.NativeFieldInfoPtr_acceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRectAuto>.NativeClassPtr, nameof (acceleration));
    ScrollRectAuto.NativeFieldInfoPtr_disableAtBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRectAuto>.NativeClassPtr, nameof (disableAtBottom));
    ScrollRectAuto.NativeFieldInfoPtr_disableOnDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRectAuto>.NativeClassPtr, nameof (disableOnDrag));
    ScrollRectAuto.NativeFieldInfoPtr_disableOnMouseScroll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRectAuto>.NativeClassPtr, nameof (disableOnMouseScroll));
    ScrollRectAuto.NativeFieldInfoPtr_reactivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRectAuto>.NativeClassPtr, nameof (reactivate));
    ScrollRectAuto.NativeFieldInfoPtr_reactivateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRectAuto>.NativeClassPtr, nameof (reactivateTime));
    ScrollRectAuto.NativeFieldInfoPtr_onReachBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRectAuto>.NativeClassPtr, nameof (onReachBottom));
    ScrollRectAuto.NativeFieldInfoPtr_scrollSpeedCurrent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRectAuto>.NativeClassPtr, nameof (scrollSpeedCurrent));
    ScrollRectAuto.NativeFieldInfoPtr_scroll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRectAuto>.NativeClassPtr, nameof (scroll));
    ScrollRectAuto.NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRectAuto>.NativeClassPtr, nameof (active));
    ScrollRectAuto.NativeFieldInfoPtr_reactivateTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRectAuto>.NativeClassPtr, nameof (reactivateTimer));
    ScrollRectAuto.NativeMethodInfoPtr_get_scrollRect_Private_get_ScrollRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectAuto>.NativeClassPtr, 100671492);
    ScrollRectAuto.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectAuto>.NativeClassPtr, 100671493);
    ScrollRectAuto.NativeMethodInfoPtr_OnDrag_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectAuto>.NativeClassPtr, 100671494);
    ScrollRectAuto.NativeMethodInfoPtr_OnScroll_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectAuto>.NativeClassPtr, 100671495);
    ScrollRectAuto.NativeMethodInfoPtr_Stop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectAuto>.NativeClassPtr, 100671496);
    ScrollRectAuto.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectAuto>.NativeClassPtr, 100671497);
  }

  public ScrollRectAuto(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe ScrollRect _scrollRect
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrollRectAuto.NativeFieldInfoPtr__scrollRect));
      return pointer == IntPtr.Zero ? (ScrollRect) null : new ScrollRect(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScrollRectAuto.NativeFieldInfoPtr__scrollRect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float activateTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrollRectAuto.NativeFieldInfoPtr_activateTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrollRectAuto.NativeFieldInfoPtr_activateTime)) = value;
    }
  }

  public unsafe float scrollSpeed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrollRectAuto.NativeFieldInfoPtr_scrollSpeed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrollRectAuto.NativeFieldInfoPtr_scrollSpeed)) = value;
    }
  }

  public unsafe float acceleration
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrollRectAuto.NativeFieldInfoPtr_acceleration));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrollRectAuto.NativeFieldInfoPtr_acceleration)) = value;
    }
  }

  public unsafe bool disableAtBottom
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrollRectAuto.NativeFieldInfoPtr_disableAtBottom));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrollRectAuto.NativeFieldInfoPtr_disableAtBottom)) = value;
    }
  }

  public unsafe bool disableOnDrag
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrollRectAuto.NativeFieldInfoPtr_disableOnDrag));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrollRectAuto.NativeFieldInfoPtr_disableOnDrag)) = value;
    }
  }

  public unsafe bool disableOnMouseScroll
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrollRectAuto.NativeFieldInfoPtr_disableOnMouseScroll));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrollRectAuto.NativeFieldInfoPtr_disableOnMouseScroll)) = value;
    }
  }

  public unsafe bool reactivate
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrollRectAuto.NativeFieldInfoPtr_reactivate));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrollRectAuto.NativeFieldInfoPtr_reactivate)) = value;
    }
  }

  public unsafe float reactivateTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrollRectAuto.NativeFieldInfoPtr_reactivateTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrollRectAuto.NativeFieldInfoPtr_reactivateTime)) = value;
    }
  }

  public unsafe UnityEvent onReachBottom
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrollRectAuto.NativeFieldInfoPtr_onReachBottom));
      return pointer == IntPtr.Zero ? (UnityEvent) null : new UnityEvent(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScrollRectAuto.NativeFieldInfoPtr_onReachBottom), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float scrollSpeedCurrent
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrollRectAuto.NativeFieldInfoPtr_scrollSpeedCurrent));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrollRectAuto.NativeFieldInfoPtr_scrollSpeedCurrent)) = value;
    }
  }

  public static unsafe Vector2 scroll
  {
    get
    {
      Vector2 scroll;
      IL2CPP.il2cpp_field_static_get_value(ScrollRectAuto.NativeFieldInfoPtr_scroll, (void*) &scroll);
      return scroll;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ScrollRectAuto.NativeFieldInfoPtr_scroll, (void*) &value);
    }
  }

  public unsafe bool active
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrollRectAuto.NativeFieldInfoPtr_active));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrollRectAuto.NativeFieldInfoPtr_active)) = value;
    }
  }

  public unsafe float reactivateTimer
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrollRectAuto.NativeFieldInfoPtr_reactivateTimer));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrollRectAuto.NativeFieldInfoPtr_reactivateTimer)) = value;
    }
  }
}
