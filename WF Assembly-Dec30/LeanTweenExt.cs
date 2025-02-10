// Decompiled with JetBrains decompiler
// Type: LeanTweenExt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using UnityEngine;

#nullable disable
public static class LeanTweenExt : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanAlpha_Public_Static_LTDescr_GameObject_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanAlphaVertex_Public_Static_LTDescr_GameObject_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanAlpha_Public_Static_LTDescr_RectTransform_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanAlpha_Public_Static_LTDescr_CanvasGroup_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanAlphaText_Public_Static_LTDescr_RectTransform_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanCancel_Public_Static_Void_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanCancel_Public_Static_Void_GameObject_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanCancel_Public_Static_Void_GameObject_Int32_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanCancel_Public_Static_Void_RectTransform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanColor_Public_Static_LTDescr_GameObject_Color_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanColorText_Public_Static_LTDescr_RectTransform_Color_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanDelayedCall_Public_Static_LTDescr_GameObject_Single_Action_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanDelayedCall_Public_Static_LTDescr_GameObject_Single_Action_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanIsPaused_Public_Static_Boolean_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanIsPaused_Public_Static_Boolean_RectTransform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanIsTweening_Public_Static_Boolean_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_GameObject_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_Transform_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_RectTransform_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_GameObject_Vector2_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_Transform_Vector2_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_GameObject_Il2CppStructArray_1_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_GameObject_LTBezierPath_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_GameObject_LTSpline_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_Transform_Il2CppStructArray_1_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_Transform_LTBezierPath_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_Transform_LTSpline_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanMoveLocal_Public_Static_LTDescr_GameObject_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanMoveLocal_Public_Static_LTDescr_GameObject_LTBezierPath_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanMoveLocal_Public_Static_LTDescr_GameObject_LTSpline_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanMoveLocal_Public_Static_LTDescr_Transform_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanMoveLocal_Public_Static_LTDescr_Transform_LTBezierPath_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanMoveLocal_Public_Static_LTDescr_Transform_LTSpline_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanMoveLocalX_Public_Static_LTDescr_GameObject_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanMoveLocalY_Public_Static_LTDescr_GameObject_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanMoveLocalZ_Public_Static_LTDescr_GameObject_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanMoveLocalX_Public_Static_LTDescr_Transform_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanMoveLocalY_Public_Static_LTDescr_Transform_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanMoveLocalZ_Public_Static_LTDescr_Transform_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanMoveSpline_Public_Static_LTDescr_GameObject_Il2CppStructArray_1_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanMoveSpline_Public_Static_LTDescr_GameObject_LTSpline_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanMoveSpline_Public_Static_LTDescr_Transform_Il2CppStructArray_1_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanMoveSpline_Public_Static_LTDescr_Transform_LTSpline_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanMoveSplineLocal_Public_Static_LTDescr_GameObject_Il2CppStructArray_1_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanMoveSplineLocal_Public_Static_LTDescr_Transform_Il2CppStructArray_1_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanMoveX_Public_Static_LTDescr_GameObject_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanMoveX_Public_Static_LTDescr_Transform_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanMoveX_Public_Static_LTDescr_RectTransform_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanMoveY_Public_Static_LTDescr_GameObject_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanMoveY_Public_Static_LTDescr_Transform_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanMoveY_Public_Static_LTDescr_RectTransform_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanMoveZ_Public_Static_LTDescr_GameObject_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanMoveZ_Public_Static_LTDescr_Transform_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanMoveZ_Public_Static_LTDescr_RectTransform_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanPause_Public_Static_Void_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanPlay_Public_Static_LTDescr_RectTransform_Il2CppReferenceArray_1_Sprite_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanResume_Public_Static_Void_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanRotate_Public_Static_LTDescr_GameObject_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanRotate_Public_Static_LTDescr_Transform_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanRotate_Public_Static_LTDescr_RectTransform_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanRotateAround_Public_Static_LTDescr_GameObject_Vector3_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanRotateAround_Public_Static_LTDescr_Transform_Vector3_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanRotateAround_Public_Static_LTDescr_RectTransform_Vector3_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanRotateAroundLocal_Public_Static_LTDescr_GameObject_Vector3_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanRotateAroundLocal_Public_Static_LTDescr_Transform_Vector3_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanRotateAroundLocal_Public_Static_LTDescr_RectTransform_Vector3_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanRotateX_Public_Static_LTDescr_GameObject_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanRotateX_Public_Static_LTDescr_Transform_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanRotateY_Public_Static_LTDescr_GameObject_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanRotateY_Public_Static_LTDescr_Transform_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanRotateZ_Public_Static_LTDescr_GameObject_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanRotateZ_Public_Static_LTDescr_Transform_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanScale_Public_Static_LTDescr_GameObject_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanScale_Public_Static_LTDescr_Transform_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanScale_Public_Static_LTDescr_RectTransform_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanScaleX_Public_Static_LTDescr_GameObject_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanScaleX_Public_Static_LTDescr_Transform_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanScaleY_Public_Static_LTDescr_GameObject_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanScaleY_Public_Static_LTDescr_Transform_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanScaleZ_Public_Static_LTDescr_GameObject_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanScaleZ_Public_Static_LTDescr_Transform_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanSize_Public_Static_LTDescr_RectTransform_Vector2_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Color_Color_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Vector2_Vector2_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Vector3_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Action_1_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Action_2_Single_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Action_2_Single_Object_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Action_1_Color_Color_Color_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Action_1_Vector2_Vector2_Vector2_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Action_1_Vector3_Vector3_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanSetPosX_Public_Static_Void_Transform_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanSetPosY_Public_Static_Void_Transform_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanSetPosZ_Public_Static_Void_Transform_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanSetLocalPosX_Public_Static_Void_Transform_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanSetLocalPosY_Public_Static_Void_Transform_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanSetLocalPosZ_Public_Static_Void_Transform_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeanColor_Public_Static_Color_Transform_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132999, XrefRangeEnd = 133003, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanAlpha(this GameObject gameObject, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanAlpha_Public_Static_LTDescr_GameObject_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133003, XrefRangeEnd = 133007, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanAlphaVertex(this GameObject gameObject, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanAlphaVertex_Public_Static_LTDescr_GameObject_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133007, XrefRangeEnd = 133011, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanAlpha(this RectTransform rectTransform, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rectTransform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanAlpha_Public_Static_LTDescr_RectTransform_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 133015, RefRangeEnd = 133023, XrefRangeStart = 133011, XrefRangeEnd = 133015, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanAlpha(this CanvasGroup canvas, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) canvas);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanAlpha_Public_Static_LTDescr_CanvasGroup_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133023, XrefRangeEnd = 133027, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanAlphaText(
    this RectTransform rectTransform,
    float to,
    float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rectTransform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanAlphaText_Public_Static_LTDescr_RectTransform_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133027, XrefRangeEnd = 133031, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void LeanCancel(this GameObject gameObject)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanCancel_Public_Static_Void_GameObject_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133031, XrefRangeEnd = 133035, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void LeanCancel(this GameObject gameObject, bool callOnComplete)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &callOnComplete;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanCancel_Public_Static_Void_GameObject_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133035, XrefRangeEnd = 133039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void LeanCancel(
    this GameObject gameObject,
    int uniqueId,
    bool callOnComplete = false)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &uniqueId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &callOnComplete;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanCancel_Public_Static_Void_GameObject_Int32_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 133043, RefRangeEnd = 133044, XrefRangeStart = 133039, XrefRangeEnd = 133043, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void LeanCancel(this RectTransform rectTransform)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rectTransform)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanCancel_Public_Static_Void_RectTransform_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133044, XrefRangeEnd = 133048, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanColor(this GameObject gameObject, Color to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanColor_Public_Static_LTDescr_GameObject_Color_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133048, XrefRangeEnd = 133052, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanColorText(
    this RectTransform rectTransform,
    Color to,
    float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rectTransform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanColorText_Public_Static_LTDescr_RectTransform_Color_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133052, XrefRangeEnd = 133056, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanDelayedCall(
    this GameObject gameObject,
    float delayTime,
    Il2CppSystem.Action callback)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &delayTime;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanDelayedCall_Public_Static_LTDescr_GameObject_Single_Action_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133056, XrefRangeEnd = 133060, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanDelayedCall(
    this GameObject gameObject,
    float delayTime,
    Il2CppSystem.Action<Il2CppSystem.Object> callback)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &delayTime;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanDelayedCall_Public_Static_LTDescr_GameObject_Single_Action_1_Object_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133060, XrefRangeEnd = 133064, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool LeanIsPaused(this GameObject gameObject)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanIsPaused_Public_Static_Boolean_GameObject_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133064, XrefRangeEnd = 133068, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool LeanIsPaused(this RectTransform rectTransform)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rectTransform)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanIsPaused_Public_Static_Boolean_RectTransform_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133068, XrefRangeEnd = 133072, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool LeanIsTweening(this GameObject gameObject)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanIsTweening_Public_Static_Boolean_GameObject_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133072, XrefRangeEnd = 133076, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanMove(this GameObject gameObject, Vector3 to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_GameObject_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133076, XrefRangeEnd = 133081, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanMove(this Transform transform, Vector3 to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_Transform_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133081, XrefRangeEnd = 133085, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanMove(this RectTransform rectTransform, Vector3 to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rectTransform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_RectTransform_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133085, XrefRangeEnd = 133089, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanMove(this GameObject gameObject, Vector2 to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_GameObject_Vector2_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133089, XrefRangeEnd = 133095, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanMove(this Transform transform, Vector2 to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_Transform_Vector2_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133095, XrefRangeEnd = 133099, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanMove(
    this GameObject gameObject,
    Il2CppStructArray<Vector3> to,
    float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) to);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_GameObject_Il2CppStructArray_1_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133099, XrefRangeEnd = 133103, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanMove(this GameObject gameObject, LTBezierPath to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) to);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_GameObject_LTBezierPath_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133103, XrefRangeEnd = 133107, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanMove(this GameObject gameObject, LTSpline to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) to);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_GameObject_LTSpline_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133107, XrefRangeEnd = 133113, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanMove(
    this Transform transform,
    Il2CppStructArray<Vector3> to,
    float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) to);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_Transform_Il2CppStructArray_1_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133113, XrefRangeEnd = 133119, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanMove(this Transform transform, LTBezierPath to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) to);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_Transform_LTBezierPath_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133119, XrefRangeEnd = 133125, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanMove(this Transform transform, LTSpline to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) to);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_Transform_LTSpline_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133125, XrefRangeEnd = 133129, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanMoveLocal(this GameObject gameObject, Vector3 to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMoveLocal_Public_Static_LTDescr_GameObject_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133129, XrefRangeEnd = 133133, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanMoveLocal(
    this GameObject gameObject,
    LTBezierPath to,
    float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) to);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMoveLocal_Public_Static_LTDescr_GameObject_LTBezierPath_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133133, XrefRangeEnd = 133137, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanMoveLocal(this GameObject gameObject, LTSpline to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) to);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMoveLocal_Public_Static_LTDescr_GameObject_LTSpline_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133137, XrefRangeEnd = 133142, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanMoveLocal(this Transform transform, Vector3 to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMoveLocal_Public_Static_LTDescr_Transform_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133142, XrefRangeEnd = 133148, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanMoveLocal(this Transform transform, LTBezierPath to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) to);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMoveLocal_Public_Static_LTDescr_Transform_LTBezierPath_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133148, XrefRangeEnd = 133154, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanMoveLocal(this Transform transform, LTSpline to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) to);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMoveLocal_Public_Static_LTDescr_Transform_LTSpline_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133154, XrefRangeEnd = 133158, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanMoveLocalX(this GameObject gameObject, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMoveLocalX_Public_Static_LTDescr_GameObject_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133158, XrefRangeEnd = 133162, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanMoveLocalY(this GameObject gameObject, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMoveLocalY_Public_Static_LTDescr_GameObject_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133162, XrefRangeEnd = 133166, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanMoveLocalZ(this GameObject gameObject, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMoveLocalZ_Public_Static_LTDescr_GameObject_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133166, XrefRangeEnd = 133172, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanMoveLocalX(this Transform transform, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMoveLocalX_Public_Static_LTDescr_Transform_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133172, XrefRangeEnd = 133178, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanMoveLocalY(this Transform transform, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMoveLocalY_Public_Static_LTDescr_Transform_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133178, XrefRangeEnd = 133184, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanMoveLocalZ(this Transform transform, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMoveLocalZ_Public_Static_LTDescr_Transform_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133184, XrefRangeEnd = 133188, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanMoveSpline(
    this GameObject gameObject,
    Il2CppStructArray<Vector3> to,
    float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) to);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMoveSpline_Public_Static_LTDescr_GameObject_Il2CppStructArray_1_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133188, XrefRangeEnd = 133192, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanMoveSpline(this GameObject gameObject, LTSpline to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) to);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMoveSpline_Public_Static_LTDescr_GameObject_LTSpline_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133192, XrefRangeEnd = 133198, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanMoveSpline(
    this Transform transform,
    Il2CppStructArray<Vector3> to,
    float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) to);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMoveSpline_Public_Static_LTDescr_Transform_Il2CppStructArray_1_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133198, XrefRangeEnd = 133204, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanMoveSpline(this Transform transform, LTSpline to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) to);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMoveSpline_Public_Static_LTDescr_Transform_LTSpline_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133204, XrefRangeEnd = 133208, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanMoveSplineLocal(
    this GameObject gameObject,
    Il2CppStructArray<Vector3> to,
    float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) to);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMoveSplineLocal_Public_Static_LTDescr_GameObject_Il2CppStructArray_1_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133208, XrefRangeEnd = 133214, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanMoveSplineLocal(
    this Transform transform,
    Il2CppStructArray<Vector3> to,
    float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) to);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMoveSplineLocal_Public_Static_LTDescr_Transform_Il2CppStructArray_1_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133214, XrefRangeEnd = 133218, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanMoveX(this GameObject gameObject, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMoveX_Public_Static_LTDescr_GameObject_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133218, XrefRangeEnd = 133224, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanMoveX(this Transform transform, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMoveX_Public_Static_LTDescr_Transform_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133224, XrefRangeEnd = 133228, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanMoveX(this RectTransform rectTransform, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rectTransform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMoveX_Public_Static_LTDescr_RectTransform_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133228, XrefRangeEnd = 133232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanMoveY(this GameObject gameObject, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMoveY_Public_Static_LTDescr_GameObject_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133232, XrefRangeEnd = 133238, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanMoveY(this Transform transform, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMoveY_Public_Static_LTDescr_Transform_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133238, XrefRangeEnd = 133242, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanMoveY(this RectTransform rectTransform, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rectTransform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMoveY_Public_Static_LTDescr_RectTransform_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133242, XrefRangeEnd = 133246, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanMoveZ(this GameObject gameObject, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMoveZ_Public_Static_LTDescr_GameObject_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133246, XrefRangeEnd = 133252, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanMoveZ(this Transform transform, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMoveZ_Public_Static_LTDescr_Transform_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133252, XrefRangeEnd = 133256, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanMoveZ(this RectTransform rectTransform, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rectTransform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMoveZ_Public_Static_LTDescr_RectTransform_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133256, XrefRangeEnd = 133260, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void LeanPause(this GameObject gameObject)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanPause_Public_Static_Void_GameObject_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133260, XrefRangeEnd = 133264, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanPlay(
    this RectTransform rectTransform,
    Il2CppReferenceArray<Sprite> sprites)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rectTransform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sprites);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanPlay_Public_Static_LTDescr_RectTransform_Il2CppReferenceArray_1_Sprite_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133264, XrefRangeEnd = 133268, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void LeanResume(this GameObject gameObject)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanResume_Public_Static_Void_GameObject_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133268, XrefRangeEnd = 133272, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanRotate(this GameObject gameObject, Vector3 to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanRotate_Public_Static_LTDescr_GameObject_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133272, XrefRangeEnd = 133277, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanRotate(this Transform transform, Vector3 to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanRotate_Public_Static_LTDescr_Transform_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133277, XrefRangeEnd = 133281, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanRotate(this RectTransform rectTransform, Vector3 to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rectTransform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanRotate_Public_Static_LTDescr_RectTransform_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133281, XrefRangeEnd = 133285, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanRotateAround(
    this GameObject gameObject,
    Vector3 axis,
    float add,
    float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &axis;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &add;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanRotateAround_Public_Static_LTDescr_GameObject_Vector3_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133285, XrefRangeEnd = 133290, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanRotateAround(
    this Transform transform,
    Vector3 axis,
    float add,
    float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &axis;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &add;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanRotateAround_Public_Static_LTDescr_Transform_Vector3_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133290, XrefRangeEnd = 133294, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanRotateAround(
    this RectTransform rectTransform,
    Vector3 axis,
    float add,
    float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rectTransform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &axis;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &add;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanRotateAround_Public_Static_LTDescr_RectTransform_Vector3_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133294, XrefRangeEnd = 133298, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanRotateAroundLocal(
    this GameObject gameObject,
    Vector3 axis,
    float add,
    float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &axis;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &add;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanRotateAroundLocal_Public_Static_LTDescr_GameObject_Vector3_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133298, XrefRangeEnd = 133303, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanRotateAroundLocal(
    this Transform transform,
    Vector3 axis,
    float add,
    float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &axis;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &add;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanRotateAroundLocal_Public_Static_LTDescr_Transform_Vector3_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133303, XrefRangeEnd = 133307, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanRotateAroundLocal(
    this RectTransform rectTransform,
    Vector3 axis,
    float add,
    float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rectTransform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &axis;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &add;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanRotateAroundLocal_Public_Static_LTDescr_RectTransform_Vector3_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133307, XrefRangeEnd = 133311, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanRotateX(this GameObject gameObject, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanRotateX_Public_Static_LTDescr_GameObject_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133311, XrefRangeEnd = 133317, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanRotateX(this Transform transform, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanRotateX_Public_Static_LTDescr_Transform_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133317, XrefRangeEnd = 133321, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanRotateY(this GameObject gameObject, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanRotateY_Public_Static_LTDescr_GameObject_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133321, XrefRangeEnd = 133327, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanRotateY(this Transform transform, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanRotateY_Public_Static_LTDescr_Transform_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133327, XrefRangeEnd = 133331, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanRotateZ(this GameObject gameObject, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanRotateZ_Public_Static_LTDescr_GameObject_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133331, XrefRangeEnd = 133337, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanRotateZ(this Transform transform, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanRotateZ_Public_Static_LTDescr_Transform_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133337, XrefRangeEnd = 133341, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanScale(this GameObject gameObject, Vector3 to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanScale_Public_Static_LTDescr_GameObject_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133341, XrefRangeEnd = 133346, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanScale(this Transform transform, Vector3 to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanScale_Public_Static_LTDescr_Transform_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 133350, RefRangeEnd = 133356, XrefRangeStart = 133346, XrefRangeEnd = 133350, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanScale(this RectTransform rectTransform, Vector3 to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rectTransform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanScale_Public_Static_LTDescr_RectTransform_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133356, XrefRangeEnd = 133360, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanScaleX(this GameObject gameObject, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanScaleX_Public_Static_LTDescr_GameObject_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133360, XrefRangeEnd = 133366, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanScaleX(this Transform transform, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanScaleX_Public_Static_LTDescr_Transform_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133366, XrefRangeEnd = 133370, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanScaleY(this GameObject gameObject, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanScaleY_Public_Static_LTDescr_GameObject_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133370, XrefRangeEnd = 133376, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanScaleY(this Transform transform, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanScaleY_Public_Static_LTDescr_Transform_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133376, XrefRangeEnd = 133380, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanScaleZ(this GameObject gameObject, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanScaleZ_Public_Static_LTDescr_GameObject_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133380, XrefRangeEnd = 133386, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanScaleZ(this Transform transform, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanScaleZ_Public_Static_LTDescr_Transform_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133386, XrefRangeEnd = 133390, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanSize(this RectTransform rectTransform, Vector2 to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rectTransform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanSize_Public_Static_LTDescr_RectTransform_Vector2_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133390, XrefRangeEnd = 133394, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanValue(
    this GameObject gameObject,
    Color from,
    Color to,
    float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &from;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Color_Color_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133394, XrefRangeEnd = 133398, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanValue(
    this GameObject gameObject,
    float from,
    float to,
    float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &from;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133398, XrefRangeEnd = 133402, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanValue(
    this GameObject gameObject,
    Vector2 from,
    Vector2 to,
    float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &from;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Vector2_Vector2_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133402, XrefRangeEnd = 133406, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanValue(
    this GameObject gameObject,
    Vector3 from,
    Vector3 to,
    float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &from;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Vector3_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133406, XrefRangeEnd = 133410, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanValue(
    this GameObject gameObject,
    Il2CppSystem.Action<float> callOnUpdate,
    float from,
    float to,
    float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callOnUpdate);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &from;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Action_1_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133410, XrefRangeEnd = 133414, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanValue(
    this GameObject gameObject,
    Il2CppSystem.Action<float, float> callOnUpdate,
    float from,
    float to,
    float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callOnUpdate);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &from;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Action_2_Single_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133414, XrefRangeEnd = 133418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanValue(
    this GameObject gameObject,
    Il2CppSystem.Action<float, Il2CppSystem.Object> callOnUpdate,
    float from,
    float to,
    float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callOnUpdate);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &from;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Action_2_Single_Object_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133418, XrefRangeEnd = 133422, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanValue(
    this GameObject gameObject,
    Il2CppSystem.Action<Color> callOnUpdate,
    Color from,
    Color to,
    float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callOnUpdate);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &from;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Action_1_Color_Color_Color_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133422, XrefRangeEnd = 133426, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanValue(
    this GameObject gameObject,
    Il2CppSystem.Action<Vector2> callOnUpdate,
    Vector2 from,
    Vector2 to,
    float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callOnUpdate);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &from;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Action_1_Vector2_Vector2_Vector2_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133426, XrefRangeEnd = 133430, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr LeanValue(
    this GameObject gameObject,
    Il2CppSystem.Action<Vector3> callOnUpdate,
    Vector3 from,
    Vector3 to,
    float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callOnUpdate);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &from;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Action_1_Vector3_Vector3_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133430, XrefRangeEnd = 133433, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void LeanSetPosX(this Transform transform, float val)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &val;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanSetPosX_Public_Static_Void_Transform_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133433, XrefRangeEnd = 133436, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void LeanSetPosY(this Transform transform, float val)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &val;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanSetPosY_Public_Static_Void_Transform_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133436, XrefRangeEnd = 133439, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void LeanSetPosZ(this Transform transform, float val)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &val;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanSetPosZ_Public_Static_Void_Transform_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133439, XrefRangeEnd = 133442, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void LeanSetLocalPosX(this Transform transform, float val)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &val;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanSetLocalPosX_Public_Static_Void_Transform_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133442, XrefRangeEnd = 133445, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void LeanSetLocalPosY(this Transform transform, float val)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &val;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanSetLocalPosY_Public_Static_Void_Transform_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133445, XrefRangeEnd = 133448, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void LeanSetLocalPosZ(this Transform transform, float val)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &val;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanSetLocalPosZ_Public_Static_Void_Transform_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133448, XrefRangeEnd = 133453, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Color LeanColor(this Transform transform)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanColor_Public_Static_Color_Transform_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Color*) IL2CPP.il2cpp_object_unbox(num);
  }

  static LeanTweenExt()
  {
    Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (LeanTweenExt));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr);
    LeanTweenExt.NativeMethodInfoPtr_LeanAlpha_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100676946);
    LeanTweenExt.NativeMethodInfoPtr_LeanAlphaVertex_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100676947);
    LeanTweenExt.NativeMethodInfoPtr_LeanAlpha_Public_Static_LTDescr_RectTransform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100676948);
    LeanTweenExt.NativeMethodInfoPtr_LeanAlpha_Public_Static_LTDescr_CanvasGroup_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100676949);
    LeanTweenExt.NativeMethodInfoPtr_LeanAlphaText_Public_Static_LTDescr_RectTransform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100676950);
    LeanTweenExt.NativeMethodInfoPtr_LeanCancel_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100676951);
    LeanTweenExt.NativeMethodInfoPtr_LeanCancel_Public_Static_Void_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100676952);
    LeanTweenExt.NativeMethodInfoPtr_LeanCancel_Public_Static_Void_GameObject_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100676953);
    LeanTweenExt.NativeMethodInfoPtr_LeanCancel_Public_Static_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100676954);
    LeanTweenExt.NativeMethodInfoPtr_LeanColor_Public_Static_LTDescr_GameObject_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100676955);
    LeanTweenExt.NativeMethodInfoPtr_LeanColorText_Public_Static_LTDescr_RectTransform_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100676956);
    LeanTweenExt.NativeMethodInfoPtr_LeanDelayedCall_Public_Static_LTDescr_GameObject_Single_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100676957);
    LeanTweenExt.NativeMethodInfoPtr_LeanDelayedCall_Public_Static_LTDescr_GameObject_Single_Action_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100676958);
    LeanTweenExt.NativeMethodInfoPtr_LeanIsPaused_Public_Static_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100676959);
    LeanTweenExt.NativeMethodInfoPtr_LeanIsPaused_Public_Static_Boolean_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100676960);
    LeanTweenExt.NativeMethodInfoPtr_LeanIsTweening_Public_Static_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100676961);
    LeanTweenExt.NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100676962);
    LeanTweenExt.NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_Transform_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100676963);
    LeanTweenExt.NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_RectTransform_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100676964);
    LeanTweenExt.NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_GameObject_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100676965);
    LeanTweenExt.NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_Transform_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100676966);
    LeanTweenExt.NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_GameObject_Il2CppStructArray_1_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100676967);
    LeanTweenExt.NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_GameObject_LTBezierPath_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100676968);
    LeanTweenExt.NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_GameObject_LTSpline_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100676969);
    LeanTweenExt.NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_Transform_Il2CppStructArray_1_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100676970);
    LeanTweenExt.NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_Transform_LTBezierPath_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100676971);
    LeanTweenExt.NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_Transform_LTSpline_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100676972);
    LeanTweenExt.NativeMethodInfoPtr_LeanMoveLocal_Public_Static_LTDescr_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100676973);
    LeanTweenExt.NativeMethodInfoPtr_LeanMoveLocal_Public_Static_LTDescr_GameObject_LTBezierPath_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100676974);
    LeanTweenExt.NativeMethodInfoPtr_LeanMoveLocal_Public_Static_LTDescr_GameObject_LTSpline_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100676975);
    LeanTweenExt.NativeMethodInfoPtr_LeanMoveLocal_Public_Static_LTDescr_Transform_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100676976);
    LeanTweenExt.NativeMethodInfoPtr_LeanMoveLocal_Public_Static_LTDescr_Transform_LTBezierPath_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100676977);
    LeanTweenExt.NativeMethodInfoPtr_LeanMoveLocal_Public_Static_LTDescr_Transform_LTSpline_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100676978);
    LeanTweenExt.NativeMethodInfoPtr_LeanMoveLocalX_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100676979);
    LeanTweenExt.NativeMethodInfoPtr_LeanMoveLocalY_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100676980);
    LeanTweenExt.NativeMethodInfoPtr_LeanMoveLocalZ_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100676981);
    LeanTweenExt.NativeMethodInfoPtr_LeanMoveLocalX_Public_Static_LTDescr_Transform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100676982);
    LeanTweenExt.NativeMethodInfoPtr_LeanMoveLocalY_Public_Static_LTDescr_Transform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100676983);
    LeanTweenExt.NativeMethodInfoPtr_LeanMoveLocalZ_Public_Static_LTDescr_Transform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100676984);
    LeanTweenExt.NativeMethodInfoPtr_LeanMoveSpline_Public_Static_LTDescr_GameObject_Il2CppStructArray_1_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100676985);
    LeanTweenExt.NativeMethodInfoPtr_LeanMoveSpline_Public_Static_LTDescr_GameObject_LTSpline_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100676986);
    LeanTweenExt.NativeMethodInfoPtr_LeanMoveSpline_Public_Static_LTDescr_Transform_Il2CppStructArray_1_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100676987);
    LeanTweenExt.NativeMethodInfoPtr_LeanMoveSpline_Public_Static_LTDescr_Transform_LTSpline_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100676988);
    LeanTweenExt.NativeMethodInfoPtr_LeanMoveSplineLocal_Public_Static_LTDescr_GameObject_Il2CppStructArray_1_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100676989);
    LeanTweenExt.NativeMethodInfoPtr_LeanMoveSplineLocal_Public_Static_LTDescr_Transform_Il2CppStructArray_1_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100676990);
    LeanTweenExt.NativeMethodInfoPtr_LeanMoveX_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100676991);
    LeanTweenExt.NativeMethodInfoPtr_LeanMoveX_Public_Static_LTDescr_Transform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100676992);
    LeanTweenExt.NativeMethodInfoPtr_LeanMoveX_Public_Static_LTDescr_RectTransform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100676993);
    LeanTweenExt.NativeMethodInfoPtr_LeanMoveY_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100676994);
    LeanTweenExt.NativeMethodInfoPtr_LeanMoveY_Public_Static_LTDescr_Transform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100676995);
    LeanTweenExt.NativeMethodInfoPtr_LeanMoveY_Public_Static_LTDescr_RectTransform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100676996);
    LeanTweenExt.NativeMethodInfoPtr_LeanMoveZ_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100676997);
    LeanTweenExt.NativeMethodInfoPtr_LeanMoveZ_Public_Static_LTDescr_Transform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100676998);
    LeanTweenExt.NativeMethodInfoPtr_LeanMoveZ_Public_Static_LTDescr_RectTransform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100676999);
    LeanTweenExt.NativeMethodInfoPtr_LeanPause_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100677000);
    LeanTweenExt.NativeMethodInfoPtr_LeanPlay_Public_Static_LTDescr_RectTransform_Il2CppReferenceArray_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100677001);
    LeanTweenExt.NativeMethodInfoPtr_LeanResume_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100677002);
    LeanTweenExt.NativeMethodInfoPtr_LeanRotate_Public_Static_LTDescr_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100677003);
    LeanTweenExt.NativeMethodInfoPtr_LeanRotate_Public_Static_LTDescr_Transform_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100677004);
    LeanTweenExt.NativeMethodInfoPtr_LeanRotate_Public_Static_LTDescr_RectTransform_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100677005);
    LeanTweenExt.NativeMethodInfoPtr_LeanRotateAround_Public_Static_LTDescr_GameObject_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100677006);
    LeanTweenExt.NativeMethodInfoPtr_LeanRotateAround_Public_Static_LTDescr_Transform_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100677007);
    LeanTweenExt.NativeMethodInfoPtr_LeanRotateAround_Public_Static_LTDescr_RectTransform_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100677008);
    LeanTweenExt.NativeMethodInfoPtr_LeanRotateAroundLocal_Public_Static_LTDescr_GameObject_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100677009);
    LeanTweenExt.NativeMethodInfoPtr_LeanRotateAroundLocal_Public_Static_LTDescr_Transform_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100677010);
    LeanTweenExt.NativeMethodInfoPtr_LeanRotateAroundLocal_Public_Static_LTDescr_RectTransform_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100677011);
    LeanTweenExt.NativeMethodInfoPtr_LeanRotateX_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100677012);
    LeanTweenExt.NativeMethodInfoPtr_LeanRotateX_Public_Static_LTDescr_Transform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100677013);
    LeanTweenExt.NativeMethodInfoPtr_LeanRotateY_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100677014);
    LeanTweenExt.NativeMethodInfoPtr_LeanRotateY_Public_Static_LTDescr_Transform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100677015);
    LeanTweenExt.NativeMethodInfoPtr_LeanRotateZ_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100677016);
    LeanTweenExt.NativeMethodInfoPtr_LeanRotateZ_Public_Static_LTDescr_Transform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100677017);
    LeanTweenExt.NativeMethodInfoPtr_LeanScale_Public_Static_LTDescr_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100677018);
    LeanTweenExt.NativeMethodInfoPtr_LeanScale_Public_Static_LTDescr_Transform_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100677019);
    LeanTweenExt.NativeMethodInfoPtr_LeanScale_Public_Static_LTDescr_RectTransform_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100677020);
    LeanTweenExt.NativeMethodInfoPtr_LeanScaleX_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100677021);
    LeanTweenExt.NativeMethodInfoPtr_LeanScaleX_Public_Static_LTDescr_Transform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100677022);
    LeanTweenExt.NativeMethodInfoPtr_LeanScaleY_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100677023);
    LeanTweenExt.NativeMethodInfoPtr_LeanScaleY_Public_Static_LTDescr_Transform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100677024);
    LeanTweenExt.NativeMethodInfoPtr_LeanScaleZ_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100677025);
    LeanTweenExt.NativeMethodInfoPtr_LeanScaleZ_Public_Static_LTDescr_Transform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100677026);
    LeanTweenExt.NativeMethodInfoPtr_LeanSize_Public_Static_LTDescr_RectTransform_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100677027);
    LeanTweenExt.NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100677028);
    LeanTweenExt.NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100677029);
    LeanTweenExt.NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100677030);
    LeanTweenExt.NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100677031);
    LeanTweenExt.NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Action_1_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100677032);
    LeanTweenExt.NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Action_2_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100677033);
    LeanTweenExt.NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Action_2_Single_Object_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100677034);
    LeanTweenExt.NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Action_1_Color_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100677035);
    LeanTweenExt.NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Action_1_Vector2_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100677036);
    LeanTweenExt.NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Action_1_Vector3_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100677037);
    LeanTweenExt.NativeMethodInfoPtr_LeanSetPosX_Public_Static_Void_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100677038);
    LeanTweenExt.NativeMethodInfoPtr_LeanSetPosY_Public_Static_Void_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100677039);
    LeanTweenExt.NativeMethodInfoPtr_LeanSetPosZ_Public_Static_Void_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100677040);
    LeanTweenExt.NativeMethodInfoPtr_LeanSetLocalPosX_Public_Static_Void_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100677041);
    LeanTweenExt.NativeMethodInfoPtr_LeanSetLocalPosY_Public_Static_Void_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100677042);
    LeanTweenExt.NativeMethodInfoPtr_LeanSetLocalPosZ_Public_Static_Void_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100677043);
    LeanTweenExt.NativeMethodInfoPtr_LeanColor_Public_Static_Color_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100677044);
  }

  public LeanTweenExt(System.IntPtr pointer)
    : base(pointer)
  {
  }
}
