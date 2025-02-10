// Decompiled with JetBrains decompiler
// Type: TouchScroller
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
public class TouchScroller : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_scroller;
  private static readonly IntPtr NativeFieldInfoPtr_horizontal;
  private static readonly IntPtr NativeFieldInfoPtr_vertical;
  private static readonly IntPtr NativeFieldInfoPtr_sensitivity;
  private static readonly IntPtr NativeFieldInfoPtr_inertia;
  private static readonly IntPtr NativeFieldInfoPtr_vx;
  private static readonly IntPtr NativeFieldInfoPtr_vy;
  private static readonly IntPtr NativeFieldInfoPtr_threshold;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95997, XrefRangeEnd = 96042, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TouchScroller.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96042, XrefRangeEnd = 96043, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TouchScroller()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchScroller>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TouchScroller.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static TouchScroller()
  {
    Il2CppClassPointerStore<TouchScroller>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (TouchScroller));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchScroller>.NativeClassPtr);
    TouchScroller.NativeFieldInfoPtr_scroller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchScroller>.NativeClassPtr, nameof (scroller));
    TouchScroller.NativeFieldInfoPtr_horizontal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchScroller>.NativeClassPtr, nameof (horizontal));
    TouchScroller.NativeFieldInfoPtr_vertical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchScroller>.NativeClassPtr, nameof (vertical));
    TouchScroller.NativeFieldInfoPtr_sensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchScroller>.NativeClassPtr, nameof (sensitivity));
    TouchScroller.NativeFieldInfoPtr_inertia = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchScroller>.NativeClassPtr, nameof (inertia));
    TouchScroller.NativeFieldInfoPtr_vx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchScroller>.NativeClassPtr, nameof (vx));
    TouchScroller.NativeFieldInfoPtr_vy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchScroller>.NativeClassPtr, nameof (vy));
    TouchScroller.NativeFieldInfoPtr_threshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchScroller>.NativeClassPtr, nameof (threshold));
    TouchScroller.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScroller>.NativeClassPtr, 100671667);
    TouchScroller.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScroller>.NativeClassPtr, 100671668);
  }

  public TouchScroller(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Scroller scroller
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TouchScroller.NativeFieldInfoPtr_scroller));
      return pointer == IntPtr.Zero ? (Scroller) null : new Scroller(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TouchScroller.NativeFieldInfoPtr_scroller), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool horizontal
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TouchScroller.NativeFieldInfoPtr_horizontal));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TouchScroller.NativeFieldInfoPtr_horizontal)) = value;
    }
  }

  public unsafe bool vertical
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TouchScroller.NativeFieldInfoPtr_vertical));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TouchScroller.NativeFieldInfoPtr_vertical)) = value;
    }
  }

  public unsafe float sensitivity
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TouchScroller.NativeFieldInfoPtr_sensitivity));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TouchScroller.NativeFieldInfoPtr_sensitivity)) = value;
    }
  }

  public unsafe float inertia
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TouchScroller.NativeFieldInfoPtr_inertia));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TouchScroller.NativeFieldInfoPtr_inertia)) = value;
    }
  }

  public unsafe float vx
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TouchScroller.NativeFieldInfoPtr_vx));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TouchScroller.NativeFieldInfoPtr_vx)) = value;
    }
  }

  public unsafe float vy
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TouchScroller.NativeFieldInfoPtr_vy));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TouchScroller.NativeFieldInfoPtr_vy)) = value;
    }
  }

  public static unsafe float threshold
  {
    get
    {
      float threshold;
      IL2CPP.il2cpp_field_static_get_value(TouchScroller.NativeFieldInfoPtr_threshold, (void*) &threshold);
      return threshold;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(TouchScroller.NativeFieldInfoPtr_threshold, (void*) &value);
    }
  }
}
