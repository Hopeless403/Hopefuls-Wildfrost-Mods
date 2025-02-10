// Decompiled with JetBrains decompiler
// Type: Page
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
public class Page : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_canDrag;
  private static readonly IntPtr NativeFieldInfoPtr_canZoom;
  private static readonly IntPtr NativeFieldInfoPtr_zoomRange;
  private static readonly IntPtr NativeFieldInfoPtr_zoomSpeed;
  private static readonly IntPtr NativeFieldInfoPtr_dragging;
  private static readonly IntPtr NativeFieldInfoPtr_dragGrabPos;
  private static readonly IntPtr NativeFieldInfoPtr_zoom;
  private static readonly IntPtr NativeFieldInfoPtr_zoomTarget;
  private static readonly IntPtr NativeFieldInfoPtr_inspecting;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_InspectStart_Private_Void_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_InspectEnd_Private_Void_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_StartDrag_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Drag_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_StopDrag_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53131, XrefRangeEnd = 53145, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Page.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53145, XrefRangeEnd = 53159, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Page.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53159, XrefRangeEnd = 53191, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Page.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public unsafe void InspectStart(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Page.NativeMethodInfoPtr_InspectStart_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public unsafe void InspectEnd(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Page.NativeMethodInfoPtr_InspectEnd_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53191, XrefRangeEnd = 53200, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StartDrag()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Page.NativeMethodInfoPtr_StartDrag_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53200, XrefRangeEnd = 53209, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Drag()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Page.NativeMethodInfoPtr_Drag_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 53209, RefRangeEnd = 53213, XrefRangeStart = 53209, XrefRangeEnd = 53209, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StopDrag()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Page.NativeMethodInfoPtr_StopDrag_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53213, XrefRangeEnd = 53214, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Page()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Page>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Page.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static Page()
  {
    Il2CppClassPointerStore<Page>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (Page));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Page>.NativeClassPtr);
    Page.NativeFieldInfoPtr_canDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Page>.NativeClassPtr, nameof (canDrag));
    Page.NativeFieldInfoPtr_canZoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Page>.NativeClassPtr, nameof (canZoom));
    Page.NativeFieldInfoPtr_zoomRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Page>.NativeClassPtr, nameof (zoomRange));
    Page.NativeFieldInfoPtr_zoomSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Page>.NativeClassPtr, nameof (zoomSpeed));
    Page.NativeFieldInfoPtr_dragging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Page>.NativeClassPtr, nameof (dragging));
    Page.NativeFieldInfoPtr_dragGrabPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Page>.NativeClassPtr, nameof (dragGrabPos));
    Page.NativeFieldInfoPtr_zoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Page>.NativeClassPtr, nameof (zoom));
    Page.NativeFieldInfoPtr_zoomTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Page>.NativeClassPtr, nameof (zoomTarget));
    Page.NativeFieldInfoPtr_inspecting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Page>.NativeClassPtr, nameof (inspecting));
    Page.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Page>.NativeClassPtr, 100667580);
    Page.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Page>.NativeClassPtr, 100667581);
    Page.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Page>.NativeClassPtr, 100667582);
    Page.NativeMethodInfoPtr_InspectStart_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Page>.NativeClassPtr, 100667583);
    Page.NativeMethodInfoPtr_InspectEnd_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Page>.NativeClassPtr, 100667584);
    Page.NativeMethodInfoPtr_StartDrag_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Page>.NativeClassPtr, 100667585);
    Page.NativeMethodInfoPtr_Drag_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Page>.NativeClassPtr, 100667586);
    Page.NativeMethodInfoPtr_StopDrag_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Page>.NativeClassPtr, 100667587);
    Page.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Page>.NativeClassPtr, 100667588);
  }

  public Page(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe bool canDrag
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Page.NativeFieldInfoPtr_canDrag));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Page.NativeFieldInfoPtr_canDrag)) = value;
    }
  }

  public unsafe bool canZoom
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Page.NativeFieldInfoPtr_canZoom));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Page.NativeFieldInfoPtr_canZoom)) = value;
    }
  }

  public unsafe Vector2 zoomRange
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Page.NativeFieldInfoPtr_zoomRange));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Page.NativeFieldInfoPtr_zoomRange)) = value;
    }
  }

  public unsafe float zoomSpeed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Page.NativeFieldInfoPtr_zoomSpeed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Page.NativeFieldInfoPtr_zoomSpeed)) = value;
    }
  }

  public unsafe bool dragging
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Page.NativeFieldInfoPtr_dragging));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Page.NativeFieldInfoPtr_dragging)) = value;
    }
  }

  public unsafe Vector3 dragGrabPos
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Page.NativeFieldInfoPtr_dragGrabPos));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Page.NativeFieldInfoPtr_dragGrabPos)) = value;
    }
  }

  public unsafe float zoom
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Page.NativeFieldInfoPtr_zoom));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Page.NativeFieldInfoPtr_zoom)) = value;
    }
  }

  public unsafe float zoomTarget
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Page.NativeFieldInfoPtr_zoomTarget));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Page.NativeFieldInfoPtr_zoomTarget)) = value;
    }
  }

  public unsafe bool inspecting
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Page.NativeFieldInfoPtr_inspecting));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Page.NativeFieldInfoPtr_inspecting)) = value;
    }
  }
}
