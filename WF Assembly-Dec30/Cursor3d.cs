// Decompiled with JetBrains decompiler
// Type: Cursor3d
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

#nullable disable
public class Cursor3d : MonoBehaviourSingleton<Cursor3d>
{
  private static readonly IntPtr NativeFieldInfoPtr__cam;
  private static readonly IntPtr NativeFieldInfoPtr_layerMask;
  private static readonly IntPtr NativeFieldInfoPtr_usingMouse;
  private static readonly IntPtr NativeFieldInfoPtr_usingTouch;
  private static readonly IntPtr NativeFieldInfoPtr_mouseObj;
  private static readonly IntPtr NativeFieldInfoPtr_showVirtualPointerState;
  private static readonly IntPtr NativeFieldInfoPtr__Position_k__BackingField;
  private static readonly IntPtr NativeFieldInfoPtr__PositionWithZ_k__BackingField;
  private static readonly IntPtr NativeFieldInfoPtr_offset;
  private static readonly IntPtr NativeFieldInfoPtr_hits;
  private static readonly IntPtr NativeMethodInfoPtr_get_cam_Private_get_Camera_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_Static_get_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_Position_Private_Static_set_Void_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_PositionWithZ_Public_Static_get_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_PositionWithZ_Private_Static_set_Void_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetScreenPoint_Public_Vector2_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetPosition_Internal_Void_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe Camera cam
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38300, XrefRangeEnd = 38302, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(Cursor3d.NativeMethodInfoPtr_get_cam_Private_get_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (Camera) null : new Camera(pointer);
    }
  }

  public static unsafe Vector3 Position
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38302, XrefRangeEnd = 38306, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(Cursor3d.NativeMethodInfoPtr_get_Position_Public_Static_get_Vector3_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38306, XrefRangeEnd = 38310, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Cursor3d.NativeMethodInfoPtr_set_Position_Private_Static_set_Void_Vector3_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public static unsafe Vector3 PositionWithZ
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38310, XrefRangeEnd = 38314, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(Cursor3d.NativeMethodInfoPtr_get_PositionWithZ_Public_Static_get_Vector3_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38314, XrefRangeEnd = 38318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Cursor3d.NativeMethodInfoPtr_set_PositionWithZ_Private_Static_set_Void_Vector3_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38318, XrefRangeEnd = 38322, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Cursor3d.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38322, XrefRangeEnd = 38357, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Cursor3d.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 38362, RefRangeEnd = 38363, XrefRangeStart = 38357, XrefRangeEnd = 38362, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector2 GetScreenPoint()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(Cursor3d.NativeMethodInfoPtr_GetScreenPoint_Public_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 38381, RefRangeEnd = 38382, XrefRangeStart = 38363, XrefRangeEnd = 38381, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetPosition(Vector3 position)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &position
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Cursor3d.NativeMethodInfoPtr_SetPosition_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38382, XrefRangeEnd = 38389, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Cursor3d()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cursor3d>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Cursor3d.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static Cursor3d()
  {
    Il2CppClassPointerStore<Cursor3d>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (Cursor3d));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cursor3d>.NativeClassPtr);
    Cursor3d.NativeFieldInfoPtr__cam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cursor3d>.NativeClassPtr, nameof (_cam));
    Cursor3d.NativeFieldInfoPtr_layerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cursor3d>.NativeClassPtr, nameof (layerMask));
    Cursor3d.NativeFieldInfoPtr_usingMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cursor3d>.NativeClassPtr, nameof (usingMouse));
    Cursor3d.NativeFieldInfoPtr_usingTouch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cursor3d>.NativeClassPtr, nameof (usingTouch));
    Cursor3d.NativeFieldInfoPtr_mouseObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cursor3d>.NativeClassPtr, nameof (mouseObj));
    Cursor3d.NativeFieldInfoPtr_showVirtualPointerState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cursor3d>.NativeClassPtr, nameof (showVirtualPointerState));
    Cursor3d.NativeFieldInfoPtr__Position_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cursor3d>.NativeClassPtr, "<Position>k__BackingField");
    Cursor3d.NativeFieldInfoPtr__PositionWithZ_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cursor3d>.NativeClassPtr, "<PositionWithZ>k__BackingField");
    Cursor3d.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cursor3d>.NativeClassPtr, nameof (offset));
    Cursor3d.NativeFieldInfoPtr_hits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cursor3d>.NativeClassPtr, nameof (hits));
    Cursor3d.NativeMethodInfoPtr_get_cam_Private_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor3d>.NativeClassPtr, 100665895);
    Cursor3d.NativeMethodInfoPtr_get_Position_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor3d>.NativeClassPtr, 100665896);
    Cursor3d.NativeMethodInfoPtr_set_Position_Private_Static_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor3d>.NativeClassPtr, 100665897);
    Cursor3d.NativeMethodInfoPtr_get_PositionWithZ_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor3d>.NativeClassPtr, 100665898);
    Cursor3d.NativeMethodInfoPtr_set_PositionWithZ_Private_Static_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor3d>.NativeClassPtr, 100665899);
    Cursor3d.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor3d>.NativeClassPtr, 100665900);
    Cursor3d.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor3d>.NativeClassPtr, 100665901);
    Cursor3d.NativeMethodInfoPtr_GetScreenPoint_Public_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor3d>.NativeClassPtr, 100665902);
    Cursor3d.NativeMethodInfoPtr_SetPosition_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor3d>.NativeClassPtr, 100665903);
    Cursor3d.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor3d>.NativeClassPtr, 100665904);
  }

  public Cursor3d(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Camera _cam
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Cursor3d.NativeFieldInfoPtr__cam));
      return pointer == IntPtr.Zero ? (Camera) null : new Camera(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Cursor3d.NativeFieldInfoPtr__cam), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LayerMask layerMask
  {
    get
    {
      return *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Cursor3d.NativeFieldInfoPtr_layerMask));
    }
    [param: In] set
    {
      *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Cursor3d.NativeFieldInfoPtr_layerMask)) = value;
    }
  }

  public unsafe bool usingMouse
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Cursor3d.NativeFieldInfoPtr_usingMouse));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Cursor3d.NativeFieldInfoPtr_usingMouse)) = value;
    }
  }

  public unsafe bool usingTouch
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Cursor3d.NativeFieldInfoPtr_usingTouch));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Cursor3d.NativeFieldInfoPtr_usingTouch)) = value;
    }
  }

  public unsafe GameObject mouseObj
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Cursor3d.NativeFieldInfoPtr_mouseObj));
      return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Cursor3d.NativeFieldInfoPtr_mouseObj), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool showVirtualPointerState
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Cursor3d.NativeFieldInfoPtr_showVirtualPointerState));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Cursor3d.NativeFieldInfoPtr_showVirtualPointerState)) = value;
    }
  }

  public static unsafe Vector3 _Position_k__BackingField
  {
    get
    {
      Vector3 positionKBackingField;
      IL2CPP.il2cpp_field_static_get_value(Cursor3d.NativeFieldInfoPtr__Position_k__BackingField, (void*) &positionKBackingField);
      return positionKBackingField;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Cursor3d.NativeFieldInfoPtr__Position_k__BackingField, (void*) &value);
    }
  }

  public static unsafe Vector3 _PositionWithZ_k__BackingField
  {
    get
    {
      Vector3 withZKBackingField;
      IL2CPP.il2cpp_field_static_get_value(Cursor3d.NativeFieldInfoPtr__PositionWithZ_k__BackingField, (void*) &withZKBackingField);
      return withZKBackingField;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Cursor3d.NativeFieldInfoPtr__PositionWithZ_k__BackingField, (void*) &value);
    }
  }

  public static unsafe Vector3 offset
  {
    get
    {
      Vector3 offset;
      IL2CPP.il2cpp_field_static_get_value(Cursor3d.NativeFieldInfoPtr_offset, (void*) &offset);
      return offset;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Cursor3d.NativeFieldInfoPtr_offset, (void*) &value);
    }
  }

  public unsafe Il2CppStructArray<RaycastHit> hits
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Cursor3d.NativeFieldInfoPtr_hits));
      return nativeObject == IntPtr.Zero ? (Il2CppStructArray<RaycastHit>) null : new Il2CppStructArray<RaycastHit>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Cursor3d.NativeFieldInfoPtr_hits), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
