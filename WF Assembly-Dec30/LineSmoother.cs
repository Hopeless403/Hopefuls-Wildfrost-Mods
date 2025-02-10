// Decompiled with JetBrains decompiler
// Type: LineSmoother
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using UnityEngine;

#nullable disable
public class LineSmoother : MonoBehaviour
{
  private static readonly IntPtr NativeMethodInfoPtr_SmoothLine_Public_Static_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector3_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 89530, RefRangeEnd = 89531, XrefRangeStart = 89479, XrefRangeEnd = 89530, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppStructArray<Vector3> SmoothLine(
    Il2CppStructArray<Vector3> inputPoints,
    float segmentSize)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inputPoints);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &segmentSize;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(LineSmoother.NativeMethodInfoPtr_SmoothLine_Public_Static_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector3_Single_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    IntPtr nativeObject = num;
    return nativeObject == IntPtr.Zero ? (Il2CppStructArray<Vector3>) null : new Il2CppStructArray<Vector3>(nativeObject);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LineSmoother()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LineSmoother>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LineSmoother.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static LineSmoother()
  {
    Il2CppClassPointerStore<LineSmoother>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (LineSmoother));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LineSmoother>.NativeClassPtr);
    LineSmoother.NativeMethodInfoPtr_SmoothLine_Public_Static_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineSmoother>.NativeClassPtr, 100670903);
    LineSmoother.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineSmoother>.NativeClassPtr, 100670904);
  }

  public LineSmoother(IntPtr pointer)
    : base(pointer)
  {
  }
}
