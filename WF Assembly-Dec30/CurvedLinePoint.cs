// Decompiled with JetBrains decompiler
// Type: CurvedLinePoint
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
public class CurvedLinePoint : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_showGizmo;
  private static readonly IntPtr NativeFieldInfoPtr_gizmoSize;
  private static readonly IntPtr NativeFieldInfoPtr_gizmoColor;
  private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89411, XrefRangeEnd = 89415, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDrawGizmos()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CurvedLinePoint.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89415, XrefRangeEnd = 89426, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDrawGizmosSelected()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CurvedLinePoint.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89426, XrefRangeEnd = 89427, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CurvedLinePoint()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CurvedLinePoint>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CurvedLinePoint.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CurvedLinePoint()
  {
    Il2CppClassPointerStore<CurvedLinePoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CurvedLinePoint));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CurvedLinePoint>.NativeClassPtr);
    CurvedLinePoint.NativeFieldInfoPtr_showGizmo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurvedLinePoint>.NativeClassPtr, nameof (showGizmo));
    CurvedLinePoint.NativeFieldInfoPtr_gizmoSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurvedLinePoint>.NativeClassPtr, nameof (gizmoSize));
    CurvedLinePoint.NativeFieldInfoPtr_gizmoColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurvedLinePoint>.NativeClassPtr, nameof (gizmoColor));
    CurvedLinePoint.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurvedLinePoint>.NativeClassPtr, 100670893);
    CurvedLinePoint.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurvedLinePoint>.NativeClassPtr, 100670894);
    CurvedLinePoint.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurvedLinePoint>.NativeClassPtr, 100670895);
  }

  public CurvedLinePoint(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe bool showGizmo
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedLinePoint.NativeFieldInfoPtr_showGizmo));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedLinePoint.NativeFieldInfoPtr_showGizmo)) = value;
    }
  }

  public unsafe float gizmoSize
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedLinePoint.NativeFieldInfoPtr_gizmoSize));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedLinePoint.NativeFieldInfoPtr_gizmoSize)) = value;
    }
  }

  public unsafe Color gizmoColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedLinePoint.NativeFieldInfoPtr_gizmoColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedLinePoint.NativeFieldInfoPtr_gizmoColor)) = value;
    }
  }
}
