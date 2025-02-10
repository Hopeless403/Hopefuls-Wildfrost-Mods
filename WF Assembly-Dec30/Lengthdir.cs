// Decompiled with JetBrains decompiler
// Type: Lengthdir
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

#nullable disable
public static class Lengthdir : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_X_Public_Static_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Y_Public_Static_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToVector2_Public_Static_Vector2_Single_Single_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127492, XrefRangeEnd = 127493, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float X(float len, float radians)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &len;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &radians;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Lengthdir.NativeMethodInfoPtr_X_Public_Static_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127493, XrefRangeEnd = 127494, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float Y(float len, float radians)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &len;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &radians;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Lengthdir.NativeMethodInfoPtr_Y_Public_Static_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 127496, RefRangeEnd = 127502, XrefRangeStart = 127494, XrefRangeEnd = 127496, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector2 ToVector2(float len, float radians)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &len;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &radians;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Lengthdir.NativeMethodInfoPtr_ToVector2_Public_Static_Vector2_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num);
  }

  static Lengthdir()
  {
    Il2CppClassPointerStore<Lengthdir>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (Lengthdir));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Lengthdir>.NativeClassPtr);
    Lengthdir.NativeMethodInfoPtr_X_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lengthdir>.NativeClassPtr, 100676500);
    Lengthdir.NativeMethodInfoPtr_Y_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lengthdir>.NativeClassPtr, 100676501);
    Lengthdir.NativeMethodInfoPtr_ToVector2_Public_Static_Vector2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lengthdir>.NativeClassPtr, 100676502);
  }

  public Lengthdir(System.IntPtr pointer)
    : base(pointer)
  {
  }
}
