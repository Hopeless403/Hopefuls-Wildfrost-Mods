// Decompiled with JetBrains decompiler
// Type: LTSpline
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
[Serializable]
public class LTSpline : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_DISTANCE_COUNT;
  private static readonly System.IntPtr NativeFieldInfoPtr_SUBLINE_COUNT;
  private static readonly System.IntPtr NativeFieldInfoPtr_distance;
  private static readonly System.IntPtr NativeFieldInfoPtr_constantSpeed;
  private static readonly System.IntPtr NativeFieldInfoPtr_pts;
  private static readonly System.IntPtr NativeFieldInfoPtr_ptsAdj;
  private static readonly System.IntPtr NativeFieldInfoPtr_ptsAdjLength;
  private static readonly System.IntPtr NativeFieldInfoPtr_orientToPath;
  private static readonly System.IntPtr NativeFieldInfoPtr_orientToPath2d;
  private static readonly System.IntPtr NativeFieldInfoPtr_numSections;
  private static readonly System.IntPtr NativeFieldInfoPtr_currPt;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Vector3_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_init_Private_Void_Il2CppStructArray_1_Vector3_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_map_Public_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_interp_Public_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ratioAtPoint_Public_Single_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_point_Public_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_place2d_Public_Void_Transform_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_placeLocal2d_Public_Void_Transform_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_place_Public_Void_Transform_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_place_Public_Void_Transform_Single_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_placeLocal_Public_Void_Transform_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_placeLocal_Public_Void_Transform_Single_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_gizmoDraw_Public_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_drawGizmo_Public_Void_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_drawGizmo_Public_Static_Void_Il2CppReferenceArray_1_Transform_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_drawLine_Public_Static_Void_Il2CppReferenceArray_1_Transform_Single_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_drawLinesGLLines_Public_Void_Material_Color_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_generateVectors_Public_Il2CppStructArray_1_Vector3_0;

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 132234, RefRangeEnd = 132237, XrefRangeStart = 132232, XrefRangeEnd = 132234, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTSpline(Il2CppStructArray<Vector3> pts)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LTSpline>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pts)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTSpline.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132237, XrefRangeEnd = 132239, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTSpline(Il2CppStructArray<Vector3> pts, bool constantSpeed)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LTSpline>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pts);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &constantSpeed;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTSpline.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 132267, RefRangeEnd = 132270, XrefRangeStart = 132239, XrefRangeEnd = 132267, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void init(Il2CppStructArray<Vector3> pts, bool constantSpeed)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pts);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &constantSpeed;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTSpline.NativeMethodInfoPtr_init_Private_Void_Il2CppStructArray_1_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132270, XrefRangeEnd = 132272, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 map(float u)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &u
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTSpline.NativeMethodInfoPtr_map_Public_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 132276, RefRangeEnd = 132280, XrefRangeStart = 132272, XrefRangeEnd = 132276, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 interp(float t)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &t
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTSpline.NativeMethodInfoPtr_interp_Public_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132280, XrefRangeEnd = 132285, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float ratioAtPoint(Vector3 pt)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &pt
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTSpline.NativeMethodInfoPtr_ratioAtPoint_Public_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(14)]
  [CachedScanResults(RefRangeStart = 132288, RefRangeEnd = 132302, XrefRangeStart = 132285, XrefRangeEnd = 132288, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 point(float ratio)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &ratio
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTSpline.NativeMethodInfoPtr_point_Public_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132302, XrefRangeEnd = 132308, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void place2d(Transform transform, float ratio)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &ratio;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTSpline.NativeMethodInfoPtr_place2d_Public_Void_Transform_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132308, XrefRangeEnd = 132319, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void placeLocal2d(Transform transform, float ratio)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &ratio;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTSpline.NativeMethodInfoPtr_placeLocal2d_Public_Void_Transform_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132319, XrefRangeEnd = 132325, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void place(Transform transform, float ratio)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &ratio;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTSpline.NativeMethodInfoPtr_place_Public_Void_Transform_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132325, XrefRangeEnd = 132329, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void place(Transform transform, float ratio, Vector3 worldUp)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &ratio;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &worldUp;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTSpline.NativeMethodInfoPtr_place_Public_Void_Transform_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132329, XrefRangeEnd = 132337, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void placeLocal(Transform transform, float ratio)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &ratio;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTSpline.NativeMethodInfoPtr_placeLocal_Public_Void_Transform_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132337, XrefRangeEnd = 132343, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void placeLocal(Transform transform, float ratio, Vector3 worldUp)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &ratio;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &worldUp;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTSpline.NativeMethodInfoPtr_placeLocal_Public_Void_Transform_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132343, XrefRangeEnd = 132344, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void gizmoDraw(float t = -1f)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &t
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTSpline.NativeMethodInfoPtr_gizmoDraw_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132344, XrefRangeEnd = 132348, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void drawGizmo(Color color)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &color
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTSpline.NativeMethodInfoPtr_drawGizmo_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132348, XrefRangeEnd = 132363, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void drawGizmo(Il2CppReferenceArray<Transform> arr, Color color)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) arr);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTSpline.NativeMethodInfoPtr_drawGizmo_Public_Static_Void_Il2CppReferenceArray_1_Transform_Color_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 132363, RefRangeEnd = 132365, XrefRangeStart = 132363, XrefRangeEnd = 132363, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void drawLine(Il2CppReferenceArray<Transform> arr, float width, Color color)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) arr);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTSpline.NativeMethodInfoPtr_drawLine_Public_Static_Void_Il2CppReferenceArray_1_Transform_Single_Color_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132365, XrefRangeEnd = 132380, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void drawLinesGLLines(Material outlineMaterial, Color color, float width)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outlineMaterial);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &width;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTSpline.NativeMethodInfoPtr_drawLinesGLLines_Public_Void_Material_Color_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132380, XrefRangeEnd = 132395, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Il2CppStructArray<Vector3> generateVectors()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTSpline.NativeMethodInfoPtr_generateVectors_Public_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr nativeObject = num;
    return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<Vector3>) null : new Il2CppStructArray<Vector3>(nativeObject);
  }

  static LTSpline()
  {
    Il2CppClassPointerStore<LTSpline>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (LTSpline));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LTSpline>.NativeClassPtr);
    LTSpline.NativeFieldInfoPtr_DISTANCE_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, nameof (DISTANCE_COUNT));
    LTSpline.NativeFieldInfoPtr_SUBLINE_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, nameof (SUBLINE_COUNT));
    LTSpline.NativeFieldInfoPtr_distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, nameof (distance));
    LTSpline.NativeFieldInfoPtr_constantSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, nameof (constantSpeed));
    LTSpline.NativeFieldInfoPtr_pts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, nameof (pts));
    LTSpline.NativeFieldInfoPtr_ptsAdj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, nameof (ptsAdj));
    LTSpline.NativeFieldInfoPtr_ptsAdjLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, nameof (ptsAdjLength));
    LTSpline.NativeFieldInfoPtr_orientToPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, nameof (orientToPath));
    LTSpline.NativeFieldInfoPtr_orientToPath2d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, nameof (orientToPath2d));
    LTSpline.NativeFieldInfoPtr_numSections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, nameof (numSections));
    LTSpline.NativeFieldInfoPtr_currPt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, nameof (currPt));
    LTSpline.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100676878);
    LTSpline.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100676879);
    LTSpline.NativeMethodInfoPtr_init_Private_Void_Il2CppStructArray_1_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100676880);
    LTSpline.NativeMethodInfoPtr_map_Public_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100676881);
    LTSpline.NativeMethodInfoPtr_interp_Public_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100676882);
    LTSpline.NativeMethodInfoPtr_ratioAtPoint_Public_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100676883);
    LTSpline.NativeMethodInfoPtr_point_Public_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100676884);
    LTSpline.NativeMethodInfoPtr_place2d_Public_Void_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100676885);
    LTSpline.NativeMethodInfoPtr_placeLocal2d_Public_Void_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100676886);
    LTSpline.NativeMethodInfoPtr_place_Public_Void_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100676887);
    LTSpline.NativeMethodInfoPtr_place_Public_Void_Transform_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100676888);
    LTSpline.NativeMethodInfoPtr_placeLocal_Public_Void_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100676889);
    LTSpline.NativeMethodInfoPtr_placeLocal_Public_Void_Transform_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100676890);
    LTSpline.NativeMethodInfoPtr_gizmoDraw_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100676891);
    LTSpline.NativeMethodInfoPtr_drawGizmo_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100676892);
    LTSpline.NativeMethodInfoPtr_drawGizmo_Public_Static_Void_Il2CppReferenceArray_1_Transform_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100676893);
    LTSpline.NativeMethodInfoPtr_drawLine_Public_Static_Void_Il2CppReferenceArray_1_Transform_Single_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100676894);
    LTSpline.NativeMethodInfoPtr_drawLinesGLLines_Public_Void_Material_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100676895);
    LTSpline.NativeMethodInfoPtr_generateVectors_Public_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100676896);
  }

  public LTSpline(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe int DISTANCE_COUNT
  {
    get
    {
      int distanceCount;
      IL2CPP.il2cpp_field_static_get_value(LTSpline.NativeFieldInfoPtr_DISTANCE_COUNT, (void*) &distanceCount);
      return distanceCount;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LTSpline.NativeFieldInfoPtr_DISTANCE_COUNT, (void*) &value);
    }
  }

  public static unsafe int SUBLINE_COUNT
  {
    get
    {
      int sublineCount;
      IL2CPP.il2cpp_field_static_get_value(LTSpline.NativeFieldInfoPtr_SUBLINE_COUNT, (void*) &sublineCount);
      return sublineCount;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LTSpline.NativeFieldInfoPtr_SUBLINE_COUNT, (void*) &value);
    }
  }

  public unsafe float distance
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTSpline.NativeFieldInfoPtr_distance));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTSpline.NativeFieldInfoPtr_distance)) = value;
    }
  }

  public unsafe bool constantSpeed
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTSpline.NativeFieldInfoPtr_constantSpeed));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTSpline.NativeFieldInfoPtr_constantSpeed)) = value;
    }
  }

  public unsafe Il2CppStructArray<Vector3> pts
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTSpline.NativeFieldInfoPtr_pts));
      return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<Vector3>) null : new Il2CppStructArray<Vector3>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LTSpline.NativeFieldInfoPtr_pts), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<Vector3> ptsAdj
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTSpline.NativeFieldInfoPtr_ptsAdj));
      return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<Vector3>) null : new Il2CppStructArray<Vector3>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LTSpline.NativeFieldInfoPtr_ptsAdj), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int ptsAdjLength
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTSpline.NativeFieldInfoPtr_ptsAdjLength));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTSpline.NativeFieldInfoPtr_ptsAdjLength)) = value;
    }
  }

  public unsafe bool orientToPath
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTSpline.NativeFieldInfoPtr_orientToPath));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTSpline.NativeFieldInfoPtr_orientToPath)) = value;
    }
  }

  public unsafe bool orientToPath2d
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTSpline.NativeFieldInfoPtr_orientToPath2d));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTSpline.NativeFieldInfoPtr_orientToPath2d)) = value;
    }
  }

  public unsafe int numSections
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTSpline.NativeFieldInfoPtr_numSections));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTSpline.NativeFieldInfoPtr_numSections)) = value;
    }
  }

  public unsafe int currPt
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTSpline.NativeFieldInfoPtr_currPt));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTSpline.NativeFieldInfoPtr_currPt)) = value;
    }
  }
}
