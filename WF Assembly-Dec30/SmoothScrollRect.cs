// Decompiled with JetBrains decompiler
// Type: SmoothScrollRect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
public class SmoothScrollRect : ScrollRect
{
  private static readonly System.IntPtr NativeFieldInfoPtr_speed;
  private static readonly System.IntPtr NativeFieldInfoPtr_smoothScrollTime;
  private static readonly System.IntPtr NativeFieldInfoPtr_smoothScrollEase;
  private static readonly System.IntPtr NativeFieldInfoPtr_tween;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnScroll_Public_Virtual_Void_PointerEventData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ScrollTo_Public_Void_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetContent_Public_Void_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetContent_Public_Void_RectTransform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ScrollToTop_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ScrollToTopAfterFrame_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ScrollToTopAfterFrameRoutine_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__OnScroll_b__4_0_Private_Void_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ScrollTo_b__5_0_Private_Void_Vector2_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95004, XrefRangeEnd = 95033, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnScroll(PointerEventData data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SmoothScrollRect.NativeMethodInfoPtr_OnScroll_Public_Virtual_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 95062, RefRangeEnd = 95065, XrefRangeStart = 95033, XrefRangeEnd = 95062, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ScrollTo(Vector2 targetPosition)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &targetPosition
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SmoothScrollRect.NativeMethodInfoPtr_ScrollTo_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95065, XrefRangeEnd = 95069, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetContent(GameObject comp)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) comp)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SmoothScrollRect.NativeMethodInfoPtr_SetContent_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetContent(RectTransform rectTransform)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rectTransform)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SmoothScrollRect.NativeMethodInfoPtr_SetContent_Public_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95069, XrefRangeEnd = 95070, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ScrollToTop()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SmoothScrollRect.NativeMethodInfoPtr_ScrollToTop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95070, XrefRangeEnd = 95077, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ScrollToTopAfterFrame()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SmoothScrollRect.NativeMethodInfoPtr_ScrollToTopAfterFrame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95077, XrefRangeEnd = 95082, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator ScrollToTopAfterFrameRoutine()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SmoothScrollRect.NativeMethodInfoPtr_ScrollToTopAfterFrameRoutine_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95082, XrefRangeEnd = 95083, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SmoothScrollRect()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmoothScrollRect>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SmoothScrollRect.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95083, XrefRangeEnd = 95084, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _OnScroll_b__4_0(Vector2 a)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &a
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SmoothScrollRect.NativeMethodInfoPtr__OnScroll_b__4_0_Private_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _ScrollTo_b__5_0(Vector2 a)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &a
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SmoothScrollRect.NativeMethodInfoPtr__ScrollTo_b__5_0_Private_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static SmoothScrollRect()
  {
    Il2CppClassPointerStore<SmoothScrollRect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (SmoothScrollRect));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmoothScrollRect>.NativeClassPtr);
    SmoothScrollRect.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothScrollRect>.NativeClassPtr, nameof (speed));
    SmoothScrollRect.NativeFieldInfoPtr_smoothScrollTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothScrollRect>.NativeClassPtr, nameof (smoothScrollTime));
    SmoothScrollRect.NativeFieldInfoPtr_smoothScrollEase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothScrollRect>.NativeClassPtr, nameof (smoothScrollEase));
    SmoothScrollRect.NativeFieldInfoPtr_tween = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothScrollRect>.NativeClassPtr, nameof (tween));
    SmoothScrollRect.NativeMethodInfoPtr_OnScroll_Public_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothScrollRect>.NativeClassPtr, 100671547);
    SmoothScrollRect.NativeMethodInfoPtr_ScrollTo_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothScrollRect>.NativeClassPtr, 100671548);
    SmoothScrollRect.NativeMethodInfoPtr_SetContent_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothScrollRect>.NativeClassPtr, 100671549);
    SmoothScrollRect.NativeMethodInfoPtr_SetContent_Public_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothScrollRect>.NativeClassPtr, 100671550);
    SmoothScrollRect.NativeMethodInfoPtr_ScrollToTop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothScrollRect>.NativeClassPtr, 100671551);
    SmoothScrollRect.NativeMethodInfoPtr_ScrollToTopAfterFrame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothScrollRect>.NativeClassPtr, 100671552);
    SmoothScrollRect.NativeMethodInfoPtr_ScrollToTopAfterFrameRoutine_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothScrollRect>.NativeClassPtr, 100671553);
    SmoothScrollRect.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothScrollRect>.NativeClassPtr, 100671554);
    SmoothScrollRect.NativeMethodInfoPtr__OnScroll_b__4_0_Private_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothScrollRect>.NativeClassPtr, 100671555);
    SmoothScrollRect.NativeMethodInfoPtr__ScrollTo_b__5_0_Private_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothScrollRect>.NativeClassPtr, 100671556);
  }

  public SmoothScrollRect(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe float speed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SmoothScrollRect.NativeFieldInfoPtr_speed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SmoothScrollRect.NativeFieldInfoPtr_speed)) = value;
    }
  }

  public static unsafe float smoothScrollTime
  {
    get
    {
      float smoothScrollTime;
      IL2CPP.il2cpp_field_static_get_value(SmoothScrollRect.NativeFieldInfoPtr_smoothScrollTime, (void*) &smoothScrollTime);
      return smoothScrollTime;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SmoothScrollRect.NativeFieldInfoPtr_smoothScrollTime, (void*) &value);
    }
  }

  public static unsafe LeanTweenType smoothScrollEase
  {
    get
    {
      LeanTweenType smoothScrollEase;
      IL2CPP.il2cpp_field_static_get_value(SmoothScrollRect.NativeFieldInfoPtr_smoothScrollEase, (void*) &smoothScrollEase);
      return smoothScrollEase;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SmoothScrollRect.NativeFieldInfoPtr_smoothScrollEase, (void*) &value);
    }
  }

  public unsafe LTDescr tween
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SmoothScrollRect.NativeFieldInfoPtr_tween));
      return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SmoothScrollRect.NativeFieldInfoPtr_tween), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("SmoothScrollRect/<ScrollToTopAfterFrameRoutine>d__10")]
  public sealed class _ScrollToTopAfterFrameRoutine_d__10 : Il2CppSystem.Object
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
    public unsafe _ScrollToTopAfterFrameRoutine_d__10(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmoothScrollRect._ScrollToTopAfterFrameRoutine_d__10>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SmoothScrollRect._ScrollToTopAfterFrameRoutine_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SmoothScrollRect._ScrollToTopAfterFrameRoutine_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94993, XrefRangeEnd = 94998, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SmoothScrollRect._ScrollToTopAfterFrameRoutine_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SmoothScrollRect._ScrollToTopAfterFrameRoutine_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94998, XrefRangeEnd = 95004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SmoothScrollRect._ScrollToTopAfterFrameRoutine_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SmoothScrollRect._ScrollToTopAfterFrameRoutine_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _ScrollToTopAfterFrameRoutine_d__10()
    {
      Il2CppClassPointerStore<SmoothScrollRect._ScrollToTopAfterFrameRoutine_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SmoothScrollRect>.NativeClassPtr, "<ScrollToTopAfterFrameRoutine>d__10");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmoothScrollRect._ScrollToTopAfterFrameRoutine_d__10>.NativeClassPtr);
      SmoothScrollRect._ScrollToTopAfterFrameRoutine_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothScrollRect._ScrollToTopAfterFrameRoutine_d__10>.NativeClassPtr, "<>1__state");
      SmoothScrollRect._ScrollToTopAfterFrameRoutine_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothScrollRect._ScrollToTopAfterFrameRoutine_d__10>.NativeClassPtr, "<>2__current");
      SmoothScrollRect._ScrollToTopAfterFrameRoutine_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothScrollRect._ScrollToTopAfterFrameRoutine_d__10>.NativeClassPtr, "<>4__this");
      SmoothScrollRect._ScrollToTopAfterFrameRoutine_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothScrollRect._ScrollToTopAfterFrameRoutine_d__10>.NativeClassPtr, 100671557);
      SmoothScrollRect._ScrollToTopAfterFrameRoutine_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothScrollRect._ScrollToTopAfterFrameRoutine_d__10>.NativeClassPtr, 100671558);
      SmoothScrollRect._ScrollToTopAfterFrameRoutine_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothScrollRect._ScrollToTopAfterFrameRoutine_d__10>.NativeClassPtr, 100671559);
      SmoothScrollRect._ScrollToTopAfterFrameRoutine_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothScrollRect._ScrollToTopAfterFrameRoutine_d__10>.NativeClassPtr, 100671560);
      SmoothScrollRect._ScrollToTopAfterFrameRoutine_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothScrollRect._ScrollToTopAfterFrameRoutine_d__10>.NativeClassPtr, 100671561);
      SmoothScrollRect._ScrollToTopAfterFrameRoutine_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothScrollRect._ScrollToTopAfterFrameRoutine_d__10>.NativeClassPtr, 100671562);
    }

    public _ScrollToTopAfterFrameRoutine_d__10(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SmoothScrollRect._ScrollToTopAfterFrameRoutine_d__10.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SmoothScrollRect._ScrollToTopAfterFrameRoutine_d__10.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SmoothScrollRect._ScrollToTopAfterFrameRoutine_d__10.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SmoothScrollRect._ScrollToTopAfterFrameRoutine_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SmoothScrollRect __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SmoothScrollRect._ScrollToTopAfterFrameRoutine_d__10.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (SmoothScrollRect) null : new SmoothScrollRect(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SmoothScrollRect._ScrollToTopAfterFrameRoutine_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
