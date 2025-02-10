// Decompiled with JetBrains decompiler
// Type: LeanSmooth
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

#nullable disable
public class LeanSmooth : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_damp_Public_Static_Single_Single_Single_byref_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_damp_Public_Static_Vector3_Vector3_Vector3_byref_Vector3_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_damp_Public_Static_Color_Color_Color_byref_Color_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_spring_Public_Static_Single_Single_Single_byref_Single_Single_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_spring_Public_Static_Vector3_Vector3_Vector3_byref_Vector3_Single_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_spring_Public_Static_Color_Color_Color_byref_Color_Single_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_linear_Public_Static_Single_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_linear_Public_Static_Vector3_Vector3_Vector3_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_linear_Public_Static_Color_Color_Color_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_bounceOut_Public_Static_Single_Single_Single_byref_Single_Single_Single_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_bounceOut_Public_Static_Vector3_Vector3_Vector3_byref_Vector3_Single_Single_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_bounceOut_Public_Static_Color_Color_Color_byref_Color_Single_Single_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(13)]
  [CachedScanResults(RefRangeStart = 128669, RefRangeEnd = 128682, XrefRangeStart = 128666, XrefRangeEnd = 128669, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float damp(
    float current,
    float target,
    ref float currentVelocity,
    float smoothTime,
    float maxSpeed = -1f,
    float deltaTime = -1f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &current;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref currentVelocity;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &smoothTime;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &maxSpeed;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanSmooth.NativeMethodInfoPtr_damp_Public_Static_Single_Single_Single_byref_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 128685, RefRangeEnd = 128688, XrefRangeStart = 128682, XrefRangeEnd = 128685, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 damp(
    Vector3 current,
    Vector3 target,
    ref Vector3 currentVelocity,
    float smoothTime,
    float maxSpeed = -1f,
    float deltaTime = -1f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &current;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref currentVelocity;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &smoothTime;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &maxSpeed;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanSmooth.NativeMethodInfoPtr_damp_Public_Static_Vector3_Vector3_Vector3_byref_Vector3_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 128692, RefRangeEnd = 128693, XrefRangeStart = 128688, XrefRangeEnd = 128692, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Color damp(
    Color current,
    Color target,
    ref Color currentVelocity,
    float smoothTime,
    float maxSpeed = -1f,
    float deltaTime = -1f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &current;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref currentVelocity;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &smoothTime;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &maxSpeed;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanSmooth.NativeMethodInfoPtr_damp_Public_Static_Color_Color_Color_byref_Color_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Color*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(13)]
  [CachedScanResults(RefRangeStart = 128694, RefRangeEnd = 128707, XrefRangeStart = 128693, XrefRangeEnd = 128694, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float spring(
    float current,
    float target,
    ref float currentVelocity,
    float smoothTime,
    float maxSpeed = -1f,
    float deltaTime = -1f,
    float friction = 2f,
    float accelRate = 0.5f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[8];
    numPtr[0] = (System.IntPtr) &current;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref currentVelocity;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &smoothTime;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &maxSpeed;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &friction;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &accelRate;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanSmooth.NativeMethodInfoPtr_spring_Public_Static_Single_Single_Single_byref_Single_Single_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 128710, RefRangeEnd = 128713, XrefRangeStart = 128707, XrefRangeEnd = 128710, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 spring(
    Vector3 current,
    Vector3 target,
    ref Vector3 currentVelocity,
    float smoothTime,
    float maxSpeed = -1f,
    float deltaTime = -1f,
    float friction = 2f,
    float accelRate = 0.5f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[8];
    numPtr[0] = (System.IntPtr) &current;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref currentVelocity;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &smoothTime;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &maxSpeed;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &friction;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &accelRate;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanSmooth.NativeMethodInfoPtr_spring_Public_Static_Vector3_Vector3_Vector3_byref_Vector3_Single_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 128717, RefRangeEnd = 128718, XrefRangeStart = 128713, XrefRangeEnd = 128717, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Color spring(
    Color current,
    Color target,
    ref Color currentVelocity,
    float smoothTime,
    float maxSpeed = -1f,
    float deltaTime = -1f,
    float friction = 2f,
    float accelRate = 0.5f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[8];
    numPtr[0] = (System.IntPtr) &current;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref currentVelocity;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &smoothTime;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &maxSpeed;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &friction;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &accelRate;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanSmooth.NativeMethodInfoPtr_spring_Public_Static_Color_Color_Color_byref_Color_Single_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Color*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(13)]
  [CachedScanResults(RefRangeStart = 128721, RefRangeEnd = 128734, XrefRangeStart = 128718, XrefRangeEnd = 128721, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float linear(float current, float target, float moveSpeed, float deltaTime = -1f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &current;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &moveSpeed;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanSmooth.NativeMethodInfoPtr_linear_Public_Static_Single_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 128737, RefRangeEnd = 128740, XrefRangeStart = 128734, XrefRangeEnd = 128737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 linear(
    Vector3 current,
    Vector3 target,
    float moveSpeed,
    float deltaTime = -1f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &current;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &moveSpeed;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanSmooth.NativeMethodInfoPtr_linear_Public_Static_Vector3_Vector3_Vector3_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 128744, RefRangeEnd = 128745, XrefRangeStart = 128740, XrefRangeEnd = 128744, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Color linear(Color current, Color target, float moveSpeed)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &current;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &moveSpeed;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanSmooth.NativeMethodInfoPtr_linear_Public_Static_Color_Color_Color_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Color*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(13)]
  [CachedScanResults(RefRangeStart = 128746, RefRangeEnd = 128759, XrefRangeStart = 128745, XrefRangeEnd = 128746, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float bounceOut(
    float current,
    float target,
    ref float currentVelocity,
    float smoothTime,
    float maxSpeed = -1f,
    float deltaTime = -1f,
    float friction = 2f,
    float accelRate = 0.5f,
    float hitDamping = 0.9f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[9];
    numPtr[0] = (System.IntPtr) &current;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref currentVelocity;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &smoothTime;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &maxSpeed;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &friction;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &accelRate;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &hitDamping;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanSmooth.NativeMethodInfoPtr_bounceOut_Public_Static_Single_Single_Single_byref_Single_Single_Single_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 128762, RefRangeEnd = 128765, XrefRangeStart = 128759, XrefRangeEnd = 128762, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 bounceOut(
    Vector3 current,
    Vector3 target,
    ref Vector3 currentVelocity,
    float smoothTime,
    float maxSpeed = -1f,
    float deltaTime = -1f,
    float friction = 2f,
    float accelRate = 0.5f,
    float hitDamping = 0.9f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[9];
    numPtr[0] = (System.IntPtr) &current;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref currentVelocity;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &smoothTime;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &maxSpeed;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &friction;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &accelRate;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &hitDamping;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanSmooth.NativeMethodInfoPtr_bounceOut_Public_Static_Vector3_Vector3_Vector3_byref_Vector3_Single_Single_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 128769, RefRangeEnd = 128770, XrefRangeStart = 128765, XrefRangeEnd = 128769, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Color bounceOut(
    Color current,
    Color target,
    ref Color currentVelocity,
    float smoothTime,
    float maxSpeed = -1f,
    float deltaTime = -1f,
    float friction = 2f,
    float accelRate = 0.5f,
    float hitDamping = 0.9f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[9];
    numPtr[0] = (System.IntPtr) &current;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref currentVelocity;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &smoothTime;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &maxSpeed;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &friction;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &accelRate;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &hitDamping;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanSmooth.NativeMethodInfoPtr_bounceOut_Public_Static_Color_Color_Color_byref_Color_Single_Single_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Color*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1959)]
  [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LeanSmooth()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeanSmooth>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanSmooth.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static LeanSmooth()
  {
    Il2CppClassPointerStore<LeanSmooth>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (LeanSmooth));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeanSmooth>.NativeClassPtr);
    LeanSmooth.NativeMethodInfoPtr_damp_Public_Static_Single_Single_Single_byref_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanSmooth>.NativeClassPtr, 100676606);
    LeanSmooth.NativeMethodInfoPtr_damp_Public_Static_Vector3_Vector3_Vector3_byref_Vector3_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanSmooth>.NativeClassPtr, 100676607);
    LeanSmooth.NativeMethodInfoPtr_damp_Public_Static_Color_Color_Color_byref_Color_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanSmooth>.NativeClassPtr, 100676608);
    LeanSmooth.NativeMethodInfoPtr_spring_Public_Static_Single_Single_Single_byref_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanSmooth>.NativeClassPtr, 100676609);
    LeanSmooth.NativeMethodInfoPtr_spring_Public_Static_Vector3_Vector3_Vector3_byref_Vector3_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanSmooth>.NativeClassPtr, 100676610);
    LeanSmooth.NativeMethodInfoPtr_spring_Public_Static_Color_Color_Color_byref_Color_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanSmooth>.NativeClassPtr, 100676611);
    LeanSmooth.NativeMethodInfoPtr_linear_Public_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanSmooth>.NativeClassPtr, 100676612);
    LeanSmooth.NativeMethodInfoPtr_linear_Public_Static_Vector3_Vector3_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanSmooth>.NativeClassPtr, 100676613);
    LeanSmooth.NativeMethodInfoPtr_linear_Public_Static_Color_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanSmooth>.NativeClassPtr, 100676614);
    LeanSmooth.NativeMethodInfoPtr_bounceOut_Public_Static_Single_Single_Single_byref_Single_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanSmooth>.NativeClassPtr, 100676615);
    LeanSmooth.NativeMethodInfoPtr_bounceOut_Public_Static_Vector3_Vector3_Vector3_byref_Vector3_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanSmooth>.NativeClassPtr, 100676616);
    LeanSmooth.NativeMethodInfoPtr_bounceOut_Public_Static_Color_Color_Color_byref_Color_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanSmooth>.NativeClassPtr, 100676617);
    LeanSmooth.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanSmooth>.NativeClassPtr, 100676618);
  }

  public LeanSmooth(System.IntPtr pointer)
    : base(pointer)
  {
  }
}
