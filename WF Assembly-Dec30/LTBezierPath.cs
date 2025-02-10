// Decompiled with JetBrains decompiler
// Type: LTBezierPath
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class LTBezierPath : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_pts;
  private static readonly System.IntPtr NativeFieldInfoPtr_length;
  private static readonly System.IntPtr NativeFieldInfoPtr_orientToPath;
  private static readonly System.IntPtr NativeFieldInfoPtr_orientToPath2d;
  private static readonly System.IntPtr NativeFieldInfoPtr_beziers;
  private static readonly System.IntPtr NativeFieldInfoPtr_lengthRatio;
  private static readonly System.IntPtr NativeFieldInfoPtr_currentBezier;
  private static readonly System.IntPtr NativeFieldInfoPtr_previousBezier;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setPoints_Public_Void_Il2CppStructArray_1_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_distance_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_point_Public_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_place2d_Public_Void_Transform_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_placeLocal2d_Public_Void_Transform_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_place_Public_Void_Transform_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_place_Public_Void_Transform_Single_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_placeLocal_Public_Void_Transform_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_placeLocal_Public_Void_Transform_Single_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_gizmoDraw_Public_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ratioAtPoint_Public_Single_Vector3_Single_0;

  [CallerCount(1959)]
  [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTBezierPath()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTBezierPath.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 132124, RefRangeEnd = 132126, XrefRangeStart = 132122, XrefRangeEnd = 132124, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTBezierPath(Il2CppStructArray<Vector3> pts_)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pts_)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTBezierPath.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 132154, RefRangeEnd = 132158, XrefRangeStart = 132126, XrefRangeEnd = 132154, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void setPoints(Il2CppStructArray<Vector3> pts_)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pts_)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTBezierPath.NativeMethodInfoPtr_setPoints_Public_Void_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  public unsafe float distance
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTBezierPath.NativeMethodInfoPtr_get_distance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(9)]
  [CachedScanResults(RefRangeStart = 132160, RefRangeEnd = 132169, XrefRangeStart = 132158, XrefRangeEnd = 132160, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 point(float ratio)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &ratio
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTBezierPath.NativeMethodInfoPtr_point_Public_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132169, XrefRangeEnd = 132177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void place2d(Transform transform, float ratio)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &ratio;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTBezierPath.NativeMethodInfoPtr_place2d_Public_Void_Transform_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132177, XrefRangeEnd = 132185, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void placeLocal2d(Transform transform, float ratio)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &ratio;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTBezierPath.NativeMethodInfoPtr_placeLocal2d_Public_Void_Transform_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132185, XrefRangeEnd = 132193, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void place(Transform transform, float ratio)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &ratio;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTBezierPath.NativeMethodInfoPtr_place_Public_Void_Transform_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132193, XrefRangeEnd = 132199, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void place(Transform transform, float ratio, Vector3 worldUp)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &ratio;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &worldUp;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTBezierPath.NativeMethodInfoPtr_place_Public_Void_Transform_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132199, XrefRangeEnd = 132204, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void placeLocal(Transform transform, float ratio)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &ratio;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTBezierPath.NativeMethodInfoPtr_placeLocal_Public_Void_Transform_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132204, XrefRangeEnd = 132207, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void placeLocal(Transform transform, float ratio, Vector3 worldUp)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &ratio;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &worldUp;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTBezierPath.NativeMethodInfoPtr_placeLocal_Public_Void_Transform_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132207, XrefRangeEnd = 132214, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void gizmoDraw(float t = -1f)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &t
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTBezierPath.NativeMethodInfoPtr_gizmoDraw_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132214, XrefRangeEnd = 132232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float ratioAtPoint(Vector3 pt, float precision = 0.01f)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &pt;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &precision;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTBezierPath.NativeMethodInfoPtr_ratioAtPoint_Public_Single_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  static LTBezierPath()
  {
    Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (LTBezierPath));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr);
    LTBezierPath.NativeFieldInfoPtr_pts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, nameof (pts));
    LTBezierPath.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, nameof (length));
    LTBezierPath.NativeFieldInfoPtr_orientToPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, nameof (orientToPath));
    LTBezierPath.NativeFieldInfoPtr_orientToPath2d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, nameof (orientToPath2d));
    LTBezierPath.NativeFieldInfoPtr_beziers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, nameof (beziers));
    LTBezierPath.NativeFieldInfoPtr_lengthRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, nameof (lengthRatio));
    LTBezierPath.NativeFieldInfoPtr_currentBezier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, nameof (currentBezier));
    LTBezierPath.NativeFieldInfoPtr_previousBezier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, nameof (previousBezier));
    LTBezierPath.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, 100676865);
    LTBezierPath.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, 100676866);
    LTBezierPath.NativeMethodInfoPtr_setPoints_Public_Void_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, 100676867);
    LTBezierPath.NativeMethodInfoPtr_get_distance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, 100676868);
    LTBezierPath.NativeMethodInfoPtr_point_Public_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, 100676869);
    LTBezierPath.NativeMethodInfoPtr_place2d_Public_Void_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, 100676870);
    LTBezierPath.NativeMethodInfoPtr_placeLocal2d_Public_Void_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, 100676871);
    LTBezierPath.NativeMethodInfoPtr_place_Public_Void_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, 100676872);
    LTBezierPath.NativeMethodInfoPtr_place_Public_Void_Transform_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, 100676873);
    LTBezierPath.NativeMethodInfoPtr_placeLocal_Public_Void_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, 100676874);
    LTBezierPath.NativeMethodInfoPtr_placeLocal_Public_Void_Transform_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, 100676875);
    LTBezierPath.NativeMethodInfoPtr_gizmoDraw_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, 100676876);
    LTBezierPath.NativeMethodInfoPtr_ratioAtPoint_Public_Single_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, 100676877);
  }

  public LTBezierPath(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Il2CppStructArray<Vector3> pts
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTBezierPath.NativeFieldInfoPtr_pts));
      return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<Vector3>) null : new Il2CppStructArray<Vector3>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LTBezierPath.NativeFieldInfoPtr_pts), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float length
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTBezierPath.NativeFieldInfoPtr_length));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTBezierPath.NativeFieldInfoPtr_length)) = value;
    }
  }

  public unsafe bool orientToPath
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTBezierPath.NativeFieldInfoPtr_orientToPath));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTBezierPath.NativeFieldInfoPtr_orientToPath)) = value;
    }
  }

  public unsafe bool orientToPath2d
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTBezierPath.NativeFieldInfoPtr_orientToPath2d));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTBezierPath.NativeFieldInfoPtr_orientToPath2d)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<LTBezier> beziers
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTBezierPath.NativeFieldInfoPtr_beziers));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<LTBezier>) null : new Il2CppReferenceArray<LTBezier>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LTBezierPath.NativeFieldInfoPtr_beziers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<float> lengthRatio
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTBezierPath.NativeFieldInfoPtr_lengthRatio));
      return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<float>) null : new Il2CppStructArray<float>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LTBezierPath.NativeFieldInfoPtr_lengthRatio), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int currentBezier
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTBezierPath.NativeFieldInfoPtr_currentBezier));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTBezierPath.NativeFieldInfoPtr_currentBezier)) = value;
    }
  }

  public unsafe int previousBezier
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTBezierPath.NativeFieldInfoPtr_previousBezier));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTBezierPath.NativeFieldInfoPtr_previousBezier)) = value;
    }
  }
}
