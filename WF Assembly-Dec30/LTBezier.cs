// Decompiled with JetBrains decompiler
// Type: LTBezier
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
public class LTBezier : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_length;
  private static readonly System.IntPtr NativeFieldInfoPtr_a;
  private static readonly System.IntPtr NativeFieldInfoPtr_aa;
  private static readonly System.IntPtr NativeFieldInfoPtr_bb;
  private static readonly System.IntPtr NativeFieldInfoPtr_cc;
  private static readonly System.IntPtr NativeFieldInfoPtr_len;
  private static readonly System.IntPtr NativeFieldInfoPtr_arcLengths;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Vector3_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_map_Private_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_bezierPoint_Private_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_point_Public_Vector3_Single_0;

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 132112, RefRangeEnd = 132113, XrefRangeStart = 132102, XrefRangeEnd = 132112, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTBezier(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float precision)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LTBezier>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &c;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &d;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &precision;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTBezier.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132113, XrefRangeEnd = 132114, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float map(float u)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &u
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTBezier.NativeMethodInfoPtr_map_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public unsafe Vector3 bezierPoint(float t)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &t
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTBezier.NativeMethodInfoPtr_bezierPoint_Private_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 132115, RefRangeEnd = 132122, XrefRangeStart = 132114, XrefRangeEnd = 132115, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 point(float t)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &t
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTBezier.NativeMethodInfoPtr_point_Public_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  static LTBezier()
  {
    Il2CppClassPointerStore<LTBezier>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (LTBezier));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LTBezier>.NativeClassPtr);
    LTBezier.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTBezier>.NativeClassPtr, nameof (length));
    LTBezier.NativeFieldInfoPtr_a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTBezier>.NativeClassPtr, nameof (a));
    LTBezier.NativeFieldInfoPtr_aa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTBezier>.NativeClassPtr, nameof (aa));
    LTBezier.NativeFieldInfoPtr_bb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTBezier>.NativeClassPtr, nameof (bb));
    LTBezier.NativeFieldInfoPtr_cc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTBezier>.NativeClassPtr, nameof (cc));
    LTBezier.NativeFieldInfoPtr_len = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTBezier>.NativeClassPtr, nameof (len));
    LTBezier.NativeFieldInfoPtr_arcLengths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTBezier>.NativeClassPtr, nameof (arcLengths));
    LTBezier.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTBezier>.NativeClassPtr, 100676861);
    LTBezier.NativeMethodInfoPtr_map_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTBezier>.NativeClassPtr, 100676862);
    LTBezier.NativeMethodInfoPtr_bezierPoint_Private_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTBezier>.NativeClassPtr, 100676863);
    LTBezier.NativeMethodInfoPtr_point_Public_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTBezier>.NativeClassPtr, 100676864);
  }

  public LTBezier(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe float length
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTBezier.NativeFieldInfoPtr_length));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTBezier.NativeFieldInfoPtr_length)) = value;
    }
  }

  public unsafe Vector3 a
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTBezier.NativeFieldInfoPtr_a));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTBezier.NativeFieldInfoPtr_a)) = value;
    }
  }

  public unsafe Vector3 aa
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTBezier.NativeFieldInfoPtr_aa));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTBezier.NativeFieldInfoPtr_aa)) = value;
    }
  }

  public unsafe Vector3 bb
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTBezier.NativeFieldInfoPtr_bb));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTBezier.NativeFieldInfoPtr_bb)) = value;
    }
  }

  public unsafe Vector3 cc
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTBezier.NativeFieldInfoPtr_cc));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTBezier.NativeFieldInfoPtr_cc)) = value;
    }
  }

  public unsafe float len
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTBezier.NativeFieldInfoPtr_len));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTBezier.NativeFieldInfoPtr_len)) = value;
    }
  }

  public unsafe Il2CppStructArray<float> arcLengths
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTBezier.NativeFieldInfoPtr_arcLengths));
      return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<float>) null : new Il2CppStructArray<float>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LTBezier.NativeFieldInfoPtr_arcLengths), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
