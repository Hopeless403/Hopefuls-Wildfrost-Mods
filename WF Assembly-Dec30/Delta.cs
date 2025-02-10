// Decompiled with JetBrains decompiler
// Type: Delta
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public static class Delta : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_targetFps;
  private static readonly System.IntPtr NativeMethodInfoPtr_Multiply_Public_Static_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Multiply_Public_Static_Vector2_Vector2_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Multiply_Public_Static_Vector2_Vector2_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Multiply_Public_Static_Vector3_Vector3_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Multiply_Public_Static_Vector3_Vector3_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Lerp_Public_Static_Single_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Lerp_Public_Static_Vector2_Vector2_Vector2_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Lerp_Public_Static_Vector3_Vector3_Vector3_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Lerp_Public_Static_Quaternion_Quaternion_Quaternion_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LerpAngle_Public_Static_Vector3_Vector3_Vector3_Single_Single_0;

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 127401, RefRangeEnd = 127405, XrefRangeStart = 127396, XrefRangeEnd = 127401, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float Multiply(float current, float multiply, float delta)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &current;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &multiply;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &delta;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Delta.NativeMethodInfoPtr_Multiply_Public_Static_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 127410, RefRangeEnd = 127411, XrefRangeStart = 127405, XrefRangeEnd = 127410, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector2 Multiply(Vector2 current, float multiply, float delta)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &current;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &multiply;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &delta;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Delta.NativeMethodInfoPtr_Multiply_Public_Static_Vector2_Vector2_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127411, XrefRangeEnd = 127417, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector2 Multiply(Vector2 current, Vector3 multiply, float delta)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &current;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &multiply;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &delta;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Delta.NativeMethodInfoPtr_Multiply_Public_Static_Vector2_Vector2_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 127422, RefRangeEnd = 127423, XrefRangeStart = 127417, XrefRangeEnd = 127422, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 Multiply(Vector3 current, float multiply, float delta)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &current;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &multiply;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &delta;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Delta.NativeMethodInfoPtr_Multiply_Public_Static_Vector3_Vector3_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 127430, RefRangeEnd = 127433, XrefRangeStart = 127423, XrefRangeEnd = 127430, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 Multiply(Vector3 current, Vector3 multiply, float delta)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &current;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &multiply;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &delta;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Delta.NativeMethodInfoPtr_Multiply_Public_Static_Vector3_Vector3_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 127439, RefRangeEnd = 127445, XrefRangeStart = 127433, XrefRangeEnd = 127439, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float Lerp(float current, float target, float amount, float delta)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &current;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &amount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &delta;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Delta.NativeMethodInfoPtr_Lerp_Public_Static_Single_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 127451, RefRangeEnd = 127454, XrefRangeStart = 127445, XrefRangeEnd = 127451, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector2 Lerp(Vector2 current, Vector2 target, float amount, float delta)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &current;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &amount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &delta;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Delta.NativeMethodInfoPtr_Lerp_Public_Static_Vector2_Vector2_Vector2_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(9)]
  [CachedScanResults(RefRangeStart = 127460, RefRangeEnd = 127469, XrefRangeStart = 127454, XrefRangeEnd = 127460, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 Lerp(Vector3 current, Vector3 target, float amount, float delta)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &current;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &amount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &delta;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Delta.NativeMethodInfoPtr_Lerp_Public_Static_Vector3_Vector3_Vector3_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 127475, RefRangeEnd = 127476, XrefRangeStart = 127469, XrefRangeEnd = 127475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Quaternion Lerp(
    Quaternion current,
    Quaternion target,
    float amount,
    float delta)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &current;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &amount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &delta;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Delta.NativeMethodInfoPtr_Lerp_Public_Static_Quaternion_Quaternion_Quaternion_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Quaternion*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127476, XrefRangeEnd = 127492, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 LerpAngle(
    Vector3 current,
    Vector3 target,
    float amount,
    float delta)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &current;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &amount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &delta;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Delta.NativeMethodInfoPtr_LerpAngle_Public_Static_Vector3_Vector3_Vector3_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  static Delta()
  {
    Il2CppClassPointerStore<Delta>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (Delta));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Delta>.NativeClassPtr);
    Delta.NativeFieldInfoPtr_targetFps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Delta>.NativeClassPtr, nameof (targetFps));
    Delta.NativeMethodInfoPtr_Multiply_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delta>.NativeClassPtr, 100676489);
    Delta.NativeMethodInfoPtr_Multiply_Public_Static_Vector2_Vector2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delta>.NativeClassPtr, 100676490);
    Delta.NativeMethodInfoPtr_Multiply_Public_Static_Vector2_Vector2_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delta>.NativeClassPtr, 100676491);
    Delta.NativeMethodInfoPtr_Multiply_Public_Static_Vector3_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delta>.NativeClassPtr, 100676492);
    Delta.NativeMethodInfoPtr_Multiply_Public_Static_Vector3_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delta>.NativeClassPtr, 100676493);
    Delta.NativeMethodInfoPtr_Lerp_Public_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delta>.NativeClassPtr, 100676494);
    Delta.NativeMethodInfoPtr_Lerp_Public_Static_Vector2_Vector2_Vector2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delta>.NativeClassPtr, 100676495);
    Delta.NativeMethodInfoPtr_Lerp_Public_Static_Vector3_Vector3_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delta>.NativeClassPtr, 100676496);
    Delta.NativeMethodInfoPtr_Lerp_Public_Static_Quaternion_Quaternion_Quaternion_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delta>.NativeClassPtr, 100676497);
    Delta.NativeMethodInfoPtr_LerpAngle_Public_Static_Vector3_Vector3_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delta>.NativeClassPtr, 100676498);
  }

  public Delta(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe float targetFps
  {
    get
    {
      float targetFps;
      IL2CPP.il2cpp_field_static_get_value(Delta.NativeFieldInfoPtr_targetFps, (void*) &targetFps);
      return targetFps;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Delta.NativeFieldInfoPtr_targetFps, (void*) &value);
    }
  }
}
