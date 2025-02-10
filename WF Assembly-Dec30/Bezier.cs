// Decompiled with JetBrains decompiler
// Type: Bezier
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
public class Bezier : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_lineRenderer;
  private static readonly IntPtr NativeFieldInfoPtr_quality;
  private static readonly IntPtr NativeMethodInfoPtr_get_pointCount_Public_get_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetPoint_Public_Vector3_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_UpdateCurve_Public_Void_Vector3_Vector3_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_UpdateCurve_Public_Void_Vector3_Vector3_Vector3_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_Calculate_Private_Vector3_Single_Vector3_Vector3_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_Calculate_Private_Vector3_Single_Vector3_Vector3_Vector3_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe int pointCount
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 86728, RefRangeEnd = 86731, XrefRangeStart = 86726, XrefRangeEnd = 86728, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(Bezier.NativeMethodInfoPtr_get_pointCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 86732, RefRangeEnd = 86734, XrefRangeStart = 86731, XrefRangeEnd = 86732, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 GetPoint(int index)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &index
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(Bezier.NativeMethodInfoPtr_GetPoint_Public_Vector3_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86734, XrefRangeEnd = 86738, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Bezier.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 86741, RefRangeEnd = 86742, XrefRangeStart = 86738, XrefRangeEnd = 86741, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateCurve(Vector3 p0, Vector3 p1, Vector3 p2)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = (IntPtr) &p0;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &p1;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &p2;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Bezier.NativeMethodInfoPtr_UpdateCurve_Public_Void_Vector3_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86742, XrefRangeEnd = 86745, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateCurve(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[4];
    numPtr[0] = (IntPtr) &p0;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &p1;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &p2;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &p3;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Bezier.NativeMethodInfoPtr_UpdateCurve_Public_Void_Vector3_Vector3_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public unsafe Vector3 Calculate(float t, Vector3 p0, Vector3 p1, Vector3 p2)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[4];
    numPtr[0] = (IntPtr) &t;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &p0;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &p1;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &p2;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(Bezier.NativeMethodInfoPtr_Calculate_Private_Vector3_Single_Vector3_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public unsafe Vector3 Calculate(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[5];
    numPtr[0] = (IntPtr) &t;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &p0;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &p1;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &p2;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &p3;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(Bezier.NativeMethodInfoPtr_Calculate_Private_Vector3_Single_Vector3_Vector3_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86745, XrefRangeEnd = 86746, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Bezier()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Bezier>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Bezier.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static Bezier()
  {
    Il2CppClassPointerStore<Bezier>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (Bezier));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Bezier>.NativeClassPtr);
    Bezier.NativeFieldInfoPtr_lineRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bezier>.NativeClassPtr, nameof (lineRenderer));
    Bezier.NativeFieldInfoPtr_quality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bezier>.NativeClassPtr, nameof (quality));
    Bezier.NativeMethodInfoPtr_get_pointCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bezier>.NativeClassPtr, 100670605);
    Bezier.NativeMethodInfoPtr_GetPoint_Public_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bezier>.NativeClassPtr, 100670606);
    Bezier.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bezier>.NativeClassPtr, 100670607);
    Bezier.NativeMethodInfoPtr_UpdateCurve_Public_Void_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bezier>.NativeClassPtr, 100670608);
    Bezier.NativeMethodInfoPtr_UpdateCurve_Public_Void_Vector3_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bezier>.NativeClassPtr, 100670609);
    Bezier.NativeMethodInfoPtr_Calculate_Private_Vector3_Single_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bezier>.NativeClassPtr, 100670610);
    Bezier.NativeMethodInfoPtr_Calculate_Private_Vector3_Single_Vector3_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bezier>.NativeClassPtr, 100670611);
    Bezier.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bezier>.NativeClassPtr, 100670612);
  }

  public Bezier(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe LineRenderer lineRenderer
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Bezier.NativeFieldInfoPtr_lineRenderer));
      return pointer == IntPtr.Zero ? (LineRenderer) null : new LineRenderer(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Bezier.NativeFieldInfoPtr_lineRenderer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int quality
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Bezier.NativeFieldInfoPtr_quality));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Bezier.NativeFieldInfoPtr_quality)) = value;
    }
  }
}
