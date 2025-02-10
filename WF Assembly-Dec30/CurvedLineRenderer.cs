// Decompiled with JetBrains decompiler
// Type: CurvedLineRenderer
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
public class CurvedLineRenderer : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_lineSegmentSize;
  private static readonly IntPtr NativeFieldInfoPtr_lineWidth;
  private static readonly IntPtr NativeFieldInfoPtr_autoUpdate;
  private static readonly IntPtr NativeFieldInfoPtr_promptUpdate;
  private static readonly IntPtr NativeFieldInfoPtr_showGizmos;
  private static readonly IntPtr NativeFieldInfoPtr_gizmoSize;
  private static readonly IntPtr NativeFieldInfoPtr_gizmoColor;
  private static readonly IntPtr NativeFieldInfoPtr_linePoints;
  private static readonly IntPtr NativeFieldInfoPtr_linePositions;
  private static readonly IntPtr NativeFieldInfoPtr_linePositionsOld;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_UpdatePoints_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetPoints_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetPointsToLine_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89427, XrefRangeEnd = 89429, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CurvedLineRenderer.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 89431, RefRangeEnd = 89432, XrefRangeStart = 89429, XrefRangeEnd = 89431, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdatePoints()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CurvedLineRenderer.NativeMethodInfoPtr_UpdatePoints_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 89443, RefRangeEnd = 89448, XrefRangeStart = 89432, XrefRangeEnd = 89443, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void GetPoints()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CurvedLineRenderer.NativeMethodInfoPtr_GetPoints_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 89461, RefRangeEnd = 89465, XrefRangeStart = 89448, XrefRangeEnd = 89461, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetPointsToLine()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CurvedLineRenderer.NativeMethodInfoPtr_SetPointsToLine_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDrawGizmosSelected()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CurvedLineRenderer.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89465, XrefRangeEnd = 89467, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDrawGizmos()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CurvedLineRenderer.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89467, XrefRangeEnd = 89479, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CurvedLineRenderer()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CurvedLineRenderer>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CurvedLineRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CurvedLineRenderer()
  {
    Il2CppClassPointerStore<CurvedLineRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CurvedLineRenderer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CurvedLineRenderer>.NativeClassPtr);
    CurvedLineRenderer.NativeFieldInfoPtr_lineSegmentSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurvedLineRenderer>.NativeClassPtr, nameof (lineSegmentSize));
    CurvedLineRenderer.NativeFieldInfoPtr_lineWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurvedLineRenderer>.NativeClassPtr, nameof (lineWidth));
    CurvedLineRenderer.NativeFieldInfoPtr_autoUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurvedLineRenderer>.NativeClassPtr, nameof (autoUpdate));
    CurvedLineRenderer.NativeFieldInfoPtr_promptUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurvedLineRenderer>.NativeClassPtr, nameof (promptUpdate));
    CurvedLineRenderer.NativeFieldInfoPtr_showGizmos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurvedLineRenderer>.NativeClassPtr, nameof (showGizmos));
    CurvedLineRenderer.NativeFieldInfoPtr_gizmoSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurvedLineRenderer>.NativeClassPtr, nameof (gizmoSize));
    CurvedLineRenderer.NativeFieldInfoPtr_gizmoColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurvedLineRenderer>.NativeClassPtr, nameof (gizmoColor));
    CurvedLineRenderer.NativeFieldInfoPtr_linePoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurvedLineRenderer>.NativeClassPtr, nameof (linePoints));
    CurvedLineRenderer.NativeFieldInfoPtr_linePositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurvedLineRenderer>.NativeClassPtr, nameof (linePositions));
    CurvedLineRenderer.NativeFieldInfoPtr_linePositionsOld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurvedLineRenderer>.NativeClassPtr, nameof (linePositionsOld));
    CurvedLineRenderer.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurvedLineRenderer>.NativeClassPtr, 100670896);
    CurvedLineRenderer.NativeMethodInfoPtr_UpdatePoints_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurvedLineRenderer>.NativeClassPtr, 100670897);
    CurvedLineRenderer.NativeMethodInfoPtr_GetPoints_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurvedLineRenderer>.NativeClassPtr, 100670898);
    CurvedLineRenderer.NativeMethodInfoPtr_SetPointsToLine_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurvedLineRenderer>.NativeClassPtr, 100670899);
    CurvedLineRenderer.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurvedLineRenderer>.NativeClassPtr, 100670900);
    CurvedLineRenderer.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurvedLineRenderer>.NativeClassPtr, 100670901);
    CurvedLineRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurvedLineRenderer>.NativeClassPtr, 100670902);
  }

  public CurvedLineRenderer(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe float lineSegmentSize
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedLineRenderer.NativeFieldInfoPtr_lineSegmentSize));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedLineRenderer.NativeFieldInfoPtr_lineSegmentSize)) = value;
    }
  }

  public unsafe float lineWidth
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedLineRenderer.NativeFieldInfoPtr_lineWidth));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedLineRenderer.NativeFieldInfoPtr_lineWidth)) = value;
    }
  }

  public unsafe bool autoUpdate
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedLineRenderer.NativeFieldInfoPtr_autoUpdate));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedLineRenderer.NativeFieldInfoPtr_autoUpdate)) = value;
    }
  }

  public unsafe bool promptUpdate
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedLineRenderer.NativeFieldInfoPtr_promptUpdate));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedLineRenderer.NativeFieldInfoPtr_promptUpdate)) = value;
    }
  }

  public unsafe bool showGizmos
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedLineRenderer.NativeFieldInfoPtr_showGizmos));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedLineRenderer.NativeFieldInfoPtr_showGizmos)) = value;
    }
  }

  public unsafe float gizmoSize
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedLineRenderer.NativeFieldInfoPtr_gizmoSize));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedLineRenderer.NativeFieldInfoPtr_gizmoSize)) = value;
    }
  }

  public unsafe Color gizmoColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedLineRenderer.NativeFieldInfoPtr_gizmoColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedLineRenderer.NativeFieldInfoPtr_gizmoColor)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<CurvedLinePoint> linePoints
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedLineRenderer.NativeFieldInfoPtr_linePoints));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<CurvedLinePoint>) null : new Il2CppReferenceArray<CurvedLinePoint>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CurvedLineRenderer.NativeFieldInfoPtr_linePoints), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<Vector3> linePositions
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedLineRenderer.NativeFieldInfoPtr_linePositions));
      return nativeObject == IntPtr.Zero ? (Il2CppStructArray<Vector3>) null : new Il2CppStructArray<Vector3>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CurvedLineRenderer.NativeFieldInfoPtr_linePositions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<Vector3> linePositionsOld
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedLineRenderer.NativeFieldInfoPtr_linePositionsOld));
      return nativeObject == IntPtr.Zero ? (Il2CppStructArray<Vector3>) null : new Il2CppStructArray<Vector3>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CurvedLineRenderer.NativeFieldInfoPtr_linePositionsOld), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
