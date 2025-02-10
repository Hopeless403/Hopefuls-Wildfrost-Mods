// Decompiled with JetBrains decompiler
// Type: AspectRatio
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

#nullable disable
public static class AspectRatio : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_GetAspectRatio_Public_Static_Vector2_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetAspectRatio_Public_Static_Vector2_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetAspectRatio_Public_Static_Vector2_Int32_Int32_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetAspectRatio_Public_Static_Vector2_Vector2_Boolean_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20106, XrefRangeEnd = 20128, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector2 GetAspectRatio(int x, int y)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &x;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AspectRatio.NativeMethodInfoPtr_GetAspectRatio_Public_Static_Vector2_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20128, XrefRangeEnd = 20150, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector2 GetAspectRatio(Vector2 xy)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &xy
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AspectRatio.NativeMethodInfoPtr_GetAspectRatio_Public_Static_Vector2_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20150, XrefRangeEnd = 20218, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector2 GetAspectRatio(int x, int y, bool debug)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &x;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &debug;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AspectRatio.NativeMethodInfoPtr_GetAspectRatio_Public_Static_Vector2_Int32_Int32_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20218, XrefRangeEnd = 20286, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector2 GetAspectRatio(Vector2 xy, bool debug)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &xy;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &debug;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AspectRatio.NativeMethodInfoPtr_GetAspectRatio_Public_Static_Vector2_Vector2_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num);
  }

  static AspectRatio()
  {
    Il2CppClassPointerStore<AspectRatio>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (AspectRatio));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AspectRatio>.NativeClassPtr);
    AspectRatio.NativeMethodInfoPtr_GetAspectRatio_Public_Static_Vector2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatio>.NativeClassPtr, 100663760);
    AspectRatio.NativeMethodInfoPtr_GetAspectRatio_Public_Static_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatio>.NativeClassPtr, 100663761);
    AspectRatio.NativeMethodInfoPtr_GetAspectRatio_Public_Static_Vector2_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatio>.NativeClassPtr, 100663762);
    AspectRatio.NativeMethodInfoPtr_GetAspectRatio_Public_Static_Vector2_Vector2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatio>.NativeClassPtr, 100663763);
  }

  public AspectRatio(System.IntPtr pointer)
    : base(pointer)
  {
  }
}
