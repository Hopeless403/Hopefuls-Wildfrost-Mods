// Decompiled with JetBrains decompiler
// Type: UtilityScript
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Linq.Expressions;
using Il2CppSystem.Reflection;
using Il2CppSystem.Text.RegularExpressions;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.AI;

#nullable disable
public static class UtilityScript : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_GetLogMessage_Public_Static_String_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetMethodInfo_Public_Static_MethodInfo_Expression_1_Action_1_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GenerateSineWave_Public_Static_Vector3_Vector3_Vector3_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PlanarDistance_Public_Static_Single_Vector3_Vector3_Axis_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetAverage_Internal_Static_Vector2_List_1_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RandomInRange_Public_Static_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PlanarDistanceVec3_Public_Static_Vector3_Vector3_Vector3_Axis_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPlanar_Public_Static_Vector3_Vector3_Axis_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RoundAwayFromZero_Public_Static_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddToAverage_Public_Static_Single_Single_Int32_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SubtractFromAverage_Public_Static_Single_Single_Int32_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ReplaceInAverage_Public_Static_Single_Single_Int32_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddAveragesTogether_Public_Static_Single_Single_Int32_Single_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetNormalDistance_Public_Static_Single_Vector3_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPathBasedOnOS_Public_Static_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetIdentifier_Public_Static_String_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Lerp_Public_Static_Vector3_Vector3_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsEmpty_Public_Static_Boolean_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToEpoch_Public_Static_Double_DateTime_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FromEpoch_Public_Static_DateTime_Double_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToEpochMs_Public_Static_Double_DateTime_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FromEpochMs_Public_Static_DateTime_Double_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SecondsToMs_Public_Static_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddWatermark_Public_Static_Texture2D_Texture2D_Texture2D_Int32_Int32_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AngleDir_Public_Static_Single_Vector3_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToCsv_Public_Static_IEnumerable_1_String_IEnumerable_1_T_String_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SubtractValueFromMean_Public_Static_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddValueToMean_Public_Static_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RandomColour_Public_Static_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RandomIndex_Public_Static_Int32_IEnumerable_1_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Next_Public_Static_T_IEnumerable_1_T_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CompareArrays_Public_Static_Boolean_Il2CppObjectBase_Il2CppObjectBase_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemapProportion_Public_Static_Single_Single_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Distance_Public_Static_Single_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Difference_Public_Static_Vector3_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InRange_Public_Static_Boolean_Vector2_Single_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RandomEnumValue_Public_Static_T_Likelihood_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPercentageBetweenValues_Public_Static_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPercentageBetweenValues_Public_Static_Single_Vector2_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetValueAtPercentage_Public_Static_Single_Vector2_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Clamp_Public_Static_Single_Vector2_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToVec3_Public_Static_Vector3_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsWithinThreshold_Internal_Static_Boolean_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FlipTexture_Public_Static_Texture2D_Texture2D_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToTexture2D_Public_Static_Texture2D_Texture_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RandomPointInRectTransform_Internal_Static_Vector3_RectTransform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RandomEnumValue_Public_Static_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RandomValueFromList_Internal_Static_T_List_1_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetEnumValue_Public_Static_T_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetCharPosition_Public_Static_Vector2_TextMeshPro_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HasReachedDestination_Internal_Static_Boolean_NavMeshAgent_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomPointOnNavMesh_Internal_Static_Vector3_NavMeshAgent_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SpiltAndCamelCase_Public_Static_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSignedVec3_Internal_Static_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsInCameraView_Internal_Static_Boolean_Camera_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSignedAngle_Internal_Static_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RandomValueFromList_Internal_Static_T_Il2CppArrayBase_1_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RandomValueFromList_Internal_Static_T_List_1_T_List_1_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RoundToNearestMultiple_Public_Static_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Truncate_Public_Static_Single_Single_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PingPong_Internal_Static_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ScaleObject_Internal_Static_IEnumerator_GameObject_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FindObject_Public_Static_GameObject_GameObject_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Static_Void_IEnumerable_1_TSource_Action_1_TSource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Quaternion_Quaternion_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Next_Public_Static_T_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Multiply_Public_Static_Vector3_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToVector3_Public_Static_Vector3_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToColour_Public_Static_Color_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ColourFromVector3_Public_Static_Color_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyFrom_Public_Static_Void_Transform_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyFrom_Public_Static_Void_RectTransform_RectTransform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RotateAround_Public_Static_Vector3_Vector3_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ScaleToOne_Public_Static_Color_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToString_Public_Static_String_Il2CppStructArray_1_Char_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetLayerRecursively_Public_Static_Void_GameObject_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SignedAngleBetween_Public_Static_Single_Vector3_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnsignedAngleBetween_Public_Static_Single_Vector3_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDirTowardsPoint_Public_Static_Vector3_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDirAwayFromPoint_Public_Static_Vector3_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Static_Void_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Static_Void_RectTransform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RangeSubset_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Subset_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_Il2CppStructArray_1_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsValidEmail_Public_Static_Boolean_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_String_Match_PDM_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19483, XrefRangeEnd = 19488, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetLogMessage(string source, string message)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(source);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(message);
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_GetLogMessage_Public_Static_String_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19488, XrefRangeEnd = 19490, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe MethodInfo GetMethodInfo<T>(Expression<Il2CppSystem.Action<T>> expression)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) expression)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.MethodInfoStoreGeneric_GetMethodInfo_Public_Static_MethodInfo_Expression_1_Action_1_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (MethodInfo) null : new MethodInfo(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19490, XrefRangeEnd = 19491, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 GenerateSineWave(
    Vector3 axis,
    Vector3 currentPosition,
    float frequency,
    float magnitude,
    float timeStep)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &axis;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &currentPosition;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &frequency;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &magnitude;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &timeStep;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_GenerateSineWave_Public_Static_Vector3_Vector3_Vector3_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19491, XrefRangeEnd = 19492, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float PlanarDistance(this Vector3 a, Vector3 b, Axis negatedAxis)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &negatedAxis;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_PlanarDistance_Public_Static_Single_Vector3_Vector3_Axis_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19492, XrefRangeEnd = 19499, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector2 GetAverage(List<Vector2> positions)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) positions)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_GetAverage_Internal_Static_Vector2_List_1_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19499, XrefRangeEnd = 19502, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 RandomInRange(this Vector3 inVector)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &inVector
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_RandomInRange_Public_Static_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19502, XrefRangeEnd = 19507, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 PlanarDistanceVec3(this Vector3 a, Vector3 b, Axis negatedAxis)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &negatedAxis;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_PlanarDistanceVec3_Public_Static_Vector3_Vector3_Vector3_Axis_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe Vector3 GetPlanar(this Vector3 a, Axis negatedAxis)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &negatedAxis;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_GetPlanar_Public_Static_Vector3_Vector3_Axis_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19507, XrefRangeEnd = 19508, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float RoundAwayFromZero(this float f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &f
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_RoundAwayFromZero_Public_Static_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe float AddToAverage(float average, int size, float value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &average;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_AddToAverage_Public_Static_Single_Single_Int32_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe float SubtractFromAverage(float average, int size, float value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &average;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_SubtractFromAverage_Public_Static_Single_Single_Int32_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe float ReplaceInAverage(
    float average,
    int size,
    float oldValue,
    float newValue)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &average;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &oldValue;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &newValue;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_ReplaceInAverage_Public_Static_Single_Single_Int32_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe float AddAveragesTogether(
    float averageA,
    int sizeA,
    float averageB,
    int sizeB)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &averageA;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &sizeA;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &averageB;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &sizeB;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_AddAveragesTogether_Public_Static_Single_Single_Int32_Single_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe float GetNormalDistance(
    this Vector3 position,
    Vector3 startPosition,
    Vector3 destination)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &position;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &startPosition;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &destination;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_GetNormalDistance_Public_Static_Single_Vector3_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19508, XrefRangeEnd = 19528, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetPathBasedOnOS()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_GetPathBasedOnOS_Public_Static_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19528, XrefRangeEnd = 19531, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetIdentifier(string userIdentifier, string uniqueObjectIdentifier)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(userIdentifier);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(uniqueObjectIdentifier);
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_GetIdentifier_Public_Static_String_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19531, XrefRangeEnd = 19532, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 Lerp(this Vector3 a, Vector3 b, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_Lerp_Public_Static_Vector3_Vector3_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19532, XrefRangeEnd = 19533, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsEmpty(this string input)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(input)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_IsEmpty_Public_Static_Boolean_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19533, XrefRangeEnd = 19536, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe double ToEpoch(this Il2CppSystem.DateTime dt)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &dt
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_ToEpoch_Public_Static_Double_DateTime_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(double*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19536, XrefRangeEnd = 19538, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppSystem.DateTime FromEpoch(this double epoch)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &epoch
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_FromEpoch_Public_Static_DateTime_Double_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Il2CppSystem.DateTime*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19538, XrefRangeEnd = 19541, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe double ToEpochMs(this Il2CppSystem.DateTime dt)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &dt
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_ToEpochMs_Public_Static_Double_DateTime_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(double*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19541, XrefRangeEnd = 19543, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppSystem.DateTime FromEpochMs(this double epoch)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &epoch
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_FromEpochMs_Public_Static_DateTime_Double_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Il2CppSystem.DateTime*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe float SecondsToMs(this float seconds)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &seconds
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_SecondsToMs_Public_Static_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19543, XrefRangeEnd = 19551, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Texture2D AddWatermark(
    Texture2D textureToSave,
    Texture2D watermark,
    int startPositionX,
    int startPositionY,
    bool hideFadedPixels = false)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) textureToSave);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) watermark);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &startPositionX;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &startPositionY;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &hideFadedPixels;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_AddWatermark_Public_Static_Texture2D_Texture2D_Texture2D_Int32_Int32_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (Texture2D) null : new Texture2D(pointer);
  }

  [CallerCount(0)]
  public static unsafe float AngleDir(Vector3 fwd, Vector3 targetDir, Vector3 up)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &fwd;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &targetDir;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &up;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_AngleDir_Public_Static_Single_Vector3_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19551, XrefRangeEnd = 19555, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe IEnumerable<string> ToCsv<T>(
    IEnumerable<T> objectlist,
    string separator = ",",
    bool header = true)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) objectlist);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(separator);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &header;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.MethodInfoStoreGeneric_ToCsv_Public_Static_IEnumerable_1_String_IEnumerable_1_T_String_Boolean_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerable<string>) null : new IEnumerable<string>(pointer);
  }

  [CallerCount(0)]
  public static unsafe float SubtractValueFromMean(
    float inVal,
    float currentMean,
    float numOfValues)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &inVal;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &currentMean;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &numOfValues;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_SubtractValueFromMean_Public_Static_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe float AddValueToMean(float inVal, float currentMean, float numOfValues)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &inVal;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &currentMean;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &numOfValues;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_AddValueToMean_Public_Static_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19555, XrefRangeEnd = 19558, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Color RandomColour()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_RandomColour_Public_Static_Color_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Color*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 19559, RefRangeEnd = 19560, XrefRangeStart = 19558, XrefRangeEnd = 19559, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int RandomIndex<T>(this IEnumerable<T> list)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) list)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.MethodInfoStoreGeneric_RandomIndex_Public_Static_Int32_IEnumerable_1_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19560, XrefRangeEnd = 19561, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe T Next<T>(this IEnumerable<T> list, T anchor)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) list);
    System.IntPtr num = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local2 = (object) anchor;
      if (!(local2 is string))
      {
        System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = ptr == System.IntPtr.Zero ? (T&) ptr : (!IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ptr)) ? (T&) ptr : (T&) IL2CPP.il2cpp_object_unbox(ptr));
      }
      else
      {
        // ISSUE: cast to a reference type
        local1 = (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string);
      }
    }
    else
      local1 = ref anchor;
    *(System.IntPtr*) num = (System.IntPtr) ref local1;
    System.IntPtr exc;
    System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(UtilityScript.MethodInfoStoreGeneric_Next_Public_Static_T_IEnumerable_1_T_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19561, XrefRangeEnd = 19590, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool CompareArrays(Il2CppObjectBase arrayA, Il2CppObjectBase arrayB)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr(arrayA);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr(arrayB);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_CompareArrays_Public_Static_Boolean_Il2CppObjectBase_Il2CppObjectBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe float RemapProportion(
    this float value,
    float currentMin,
    float currentMax,
    float newMin,
    float newMax)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &value;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &currentMin;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &currentMax;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &newMin;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &newMax;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_RemapProportion_Public_Static_Single_Single_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 19595, RefRangeEnd = 19598, XrefRangeStart = 19590, XrefRangeEnd = 19595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float Distance(this Vector3 thisVec, Vector3 compareVec)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &thisVec;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &compareVec;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_Distance_Public_Static_Single_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe Vector3 Difference(this Vector3 a, Vector3 b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_Difference_Public_Static_Vector3_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe bool InRange(this Vector2 inRange, float inNum, bool isInclusive = true)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &inRange;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &inNum;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &isInclusive;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_InRange_Public_Static_Boolean_Vector2_Single_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19598, XrefRangeEnd = 19635, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe T RandomEnumValue<T>(Likelihood likelihood)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &likelihood
    };
    System.IntPtr exc;
    System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(UtilityScript.MethodInfoStoreGeneric_RandomEnumValue_Public_Static_T_Likelihood_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
  }

  [CallerCount(0)]
  public static unsafe float GetPercentageBetweenValues(float inVal, float minVal, float maxVal)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &inVal;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &minVal;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &maxVal;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_GetPercentageBetweenValues_Public_Static_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe float GetPercentageBetweenValues(this Vector2 inVec, float inVal)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &inVec;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &inVal;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_GetPercentageBetweenValues_Public_Static_Single_Vector2_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe float GetValueAtPercentage(this Vector2 inVec, float percentage)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &inVec;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &percentage;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_GetValueAtPercentage_Public_Static_Single_Vector2_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe float Clamp(this Vector2 inVec, float inVal)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &inVec;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &inVal;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_Clamp_Public_Static_Single_Vector2_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe Vector3 ToVec3(this Vector2 inVec)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &inVec
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_ToVec3_Public_Static_Vector3_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe bool IsWithinThreshold(float value, float compareTo, float threshold)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &value;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &compareTo;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &threshold;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_IsWithinThreshold_Internal_Static_Boolean_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19635, XrefRangeEnd = 19642, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Texture2D FlipTexture(this Texture2D original)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) original)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_FlipTexture_Public_Static_Texture2D_Texture2D_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (Texture2D) null : new Texture2D(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 19658, RefRangeEnd = 19659, XrefRangeStart = 19642, XrefRangeEnd = 19658, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Texture2D ToTexture2D(this Texture texture)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) texture)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_ToTexture2D_Public_Static_Texture2D_Texture_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (Texture2D) null : new Texture2D(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19659, XrefRangeEnd = 19673, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 RandomPointInRectTransform(RectTransform rectTransform)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rectTransform)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_RandomPointInRectTransform_Internal_Static_Vector3_RectTransform_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19673, XrefRangeEnd = 19685, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe T RandomEnumValue<T>()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(UtilityScript.MethodInfoStoreGeneric_RandomEnumValue_Public_Static_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19685, XrefRangeEnd = 19687, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe T RandomValueFromList<T>(this List<T> list)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) list)
    };
    System.IntPtr exc;
    System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(UtilityScript.MethodInfoStoreGeneric_RandomValueFromList_Internal_Static_T_List_1_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19687, XrefRangeEnd = 19696, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe T GetEnumValue<T>(string valueName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(valueName)
    };
    System.IntPtr exc;
    System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(UtilityScript.MethodInfoStoreGeneric_GetEnumValue_Public_Static_T_String_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19696, XrefRangeEnd = 19700, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector2 GetCharPosition(this TextMeshPro text, int index)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) text);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_GetCharPosition_Public_Static_Vector2_TextMeshPro_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19700, XrefRangeEnd = 19705, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool HasReachedDestination(this NavMeshAgent agent)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) agent)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_HasReachedDestination_Internal_Static_Boolean_NavMeshAgent_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19705, XrefRangeEnd = 19710, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 GetRandomPointOnNavMesh(this NavMeshAgent agent, float maxWalkDist)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) agent);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &maxWalkDist;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_GetRandomPointOnNavMesh_Internal_Static_Vector3_NavMeshAgent_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19710, XrefRangeEnd = 19727, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string SpiltAndCamelCase(this string inString)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(inString)
    };
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_SpiltAndCamelCase_Public_Static_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19727, XrefRangeEnd = 19729, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 GetSignedVec3(this Vector3 inVector)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &inVector
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_GetSignedVec3_Internal_Static_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 19730, RefRangeEnd = 19731, XrefRangeStart = 19729, XrefRangeEnd = 19730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsInCameraView(this Camera cam, Vector3 position, float border = 0.0f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cam);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &border;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_IsInCameraView_Internal_Static_Boolean_Camera_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe float GetSignedAngle(float inAngle)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &inAngle
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_GetSignedAngle_Internal_Static_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19731, XrefRangeEnd = 19732, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe T RandomValueFromList<T>(this Il2CppArrayBase<T> list)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) list)
    };
    System.IntPtr exc;
    System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(UtilityScript.MethodInfoStoreGeneric_RandomValueFromList_Internal_Static_T_Il2CppArrayBase_1_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19732, XrefRangeEnd = 19734, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe T RandomValueFromList<T>(List<T> listA, List<T> ignoreFromListA)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) listA);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) ignoreFromListA);
    System.IntPtr exc;
    System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(UtilityScript.MethodInfoStoreGeneric_RandomValueFromList_Internal_Static_T_List_1_T_List_1_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19734, XrefRangeEnd = 19741, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float RoundToNearestMultiple(this float value, float factor)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &value;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &factor;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_RoundToNearestMultiple_Public_Static_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19741, XrefRangeEnd = 19746, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float Truncate(this float value, int digits)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &value;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &digits;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_Truncate_Public_Static_Single_Single_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19746, XrefRangeEnd = 19748, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float PingPong(float timeValue, float minValue, float maxValue)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &timeValue;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &minValue;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &maxValue;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_PingPong_Internal_Static_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19748, XrefRangeEnd = 19753, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe IEnumerator ScaleObject(GameObject gameObj, float aValue, float aTime)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObj);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aValue;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &aTime;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_ScaleObject_Internal_Static_IEnumerator_GameObject_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19753, XrefRangeEnd = 19771, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe GameObject FindObject(this GameObject parent, string name)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parent);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(name);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_FindObject_Public_Static_GameObject_GameObject_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19771, XrefRangeEnd = 19786, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Update<TSource>(
    this IEnumerable<TSource> outer,
    Il2CppSystem.Action<TSource> updator)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outer);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) updator);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UtilityScript.MethodInfoStoreGeneric_Update_Public_Static_Void_IEnumerable_1_TSource_Action_1_TSource_0<TSource>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public static unsafe bool Approximately(
    this Quaternion quatA,
    Quaternion value,
    float acceptableRange)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &quatA;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &acceptableRange;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Quaternion_Quaternion_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe T Next<T>(this T src) where T : new()
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local2 = (object) src;
      if (!(local2 is string))
      {
        System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = ptr == System.IntPtr.Zero ? (T&) ptr : (!IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ptr)) ? (T&) ptr : (T&) IL2CPP.il2cpp_object_unbox(ptr));
      }
      else
      {
        // ISSUE: cast to a reference type
        local1 = (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string);
      }
    }
    else
      local1 = ref src;
    *numPtr2 = (System.IntPtr) ref local1;
    System.IntPtr exc;
    System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(UtilityScript.MethodInfoStoreGeneric_Next_Public_Static_T_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
  }

  [CallerCount(0)]
  public static unsafe Vector3 Multiply(this Vector3 src, Vector3 vector)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &src;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &vector;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_Multiply_Public_Static_Vector3_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(24)]
  [CachedScanResults(RefRangeStart = 19786, RefRangeEnd = 19810, XrefRangeStart = 19786, XrefRangeEnd = 19786, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 ToVector3(this Color src)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &src
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_ToVector3_Public_Static_Vector3_Color_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe Color ToColour(this Vector3 src, float alpha = 1f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &src;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &alpha;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_ToColour_Public_Static_Color_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Color*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe Color ColourFromVector3(Vector3 src)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &src
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_ColourFromVector3_Public_Static_Color_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Color*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19810, XrefRangeEnd = 19822, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CopyFrom(this Transform toEdit, Transform copyFrom)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) toEdit);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) copyFrom);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_CopyFrom_Public_Static_Void_Transform_Transform_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19822, XrefRangeEnd = 19835, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CopyFrom(
    this RectTransform objRectTransform,
    RectTransform rectTransform)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) objRectTransform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rectTransform);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_CopyFrom_Public_Static_Void_RectTransform_RectTransform_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19835, XrefRangeEnd = 19837, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 RotateAround(this Vector3 point, Vector3 pivot, Vector3 angle)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &point;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pivot;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &angle;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_RotateAround_Public_Static_Vector3_Vector3_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe Color ScaleToOne(this Color src)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &src
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_ScaleToOne_Public_Static_Color_Color_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Color*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19837, XrefRangeEnd = 19842, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string ConvertToString(this Il2CppStructArray<char> charArray)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) charArray)
    };
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_ConvertToString_Public_Static_String_Il2CppStructArray_1_Char_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 19867, RefRangeEnd = 19868, XrefRangeStart = 19842, XrefRangeEnd = 19867, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetLayerRecursively(this GameObject src, int newLayer)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) src);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &newLayer;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_SetLayerRecursively_Public_Static_Void_GameObject_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19868, XrefRangeEnd = 19870, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float SignedAngleBetween(Vector3 vector1, Vector3 vector2, Vector3 normal)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &vector1;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &vector2;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &normal;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_SignedAngleBetween_Public_Static_Single_Vector3_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19870, XrefRangeEnd = 19873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float UnsignedAngleBetween(Vector3 vector1, Vector3 vector2, Vector3 normal)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &vector1;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &vector2;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &normal;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_UnsignedAngleBetween_Public_Static_Single_Vector3_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19873, XrefRangeEnd = 19874, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 GetDirTowardsPoint(this Vector3 ownPos, Vector3 pointTowards)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &ownPos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pointTowards;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_GetDirTowardsPoint_Public_Static_Vector3_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19874, XrefRangeEnd = 19875, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 GetDirAwayFromPoint(this Vector3 ownPos, Vector3 pointAway)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &ownPos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pointAway;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_GetDirAwayFromPoint_Public_Static_Vector3_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19875, XrefRangeEnd = 19884, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Reset(this Transform inTransform)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inTransform)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_Reset_Public_Static_Void_Transform_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19884, XrefRangeEnd = 19898, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Reset(this RectTransform rectTransform)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rectTransform)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_Reset_Public_Static_Void_RectTransform_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19898, XrefRangeEnd = 19901, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppArrayBase<T> RangeSubset<T>(
    this Il2CppArrayBase<T> array,
    int startIndex,
    int length)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) array);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &startIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &length;
    System.IntPtr exc;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UtilityScript.MethodInfoStoreGeneric_RangeSubset_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_Int32_Int32_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19901, XrefRangeEnd = 19905, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppArrayBase<M0> Subset(
    this Il2CppArrayBase<M0> array,
    [Optional] Il2CppStructArray<int> indices)
  {
    if (indices == null)
      indices = new Il2CppStructArray<int>(0L);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) array);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) indices);
    System.IntPtr exc;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UtilityScript.MethodInfoStoreGeneric_Subset_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_Il2CppStructArray_1_Int32_0<M0>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return Il2CppArrayBase<M0>.WrapNativeGenericArrayPointer(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19905, XrefRangeEnd = 19931, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsValidEmail(string email)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(email)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_IsValidEmail_Public_Static_Boolean_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19931, XrefRangeEnd = 19942, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string Method_Internal_Static_String_Match_PDM_0(Match match)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) match)
    };
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(UtilityScript.NativeMethodInfoPtr_Method_Internal_Static_String_Match_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  public static Il2CppArrayBase<T> Subset<T, T>(Il2CppArrayBase<T> array, params int[] indices)
  {
    return array.Subset(new Il2CppStructArray<int>(indices));
  }

  static UtilityScript()
  {
    Il2CppClassPointerStore<UtilityScript>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (UtilityScript));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr);
    UtilityScript.NativeMethodInfoPtr_GetLogMessage_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663631);
    UtilityScript.NativeMethodInfoPtr_GetMethodInfo_Public_Static_MethodInfo_Expression_1_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663632);
    UtilityScript.NativeMethodInfoPtr_GenerateSineWave_Public_Static_Vector3_Vector3_Vector3_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663633);
    UtilityScript.NativeMethodInfoPtr_PlanarDistance_Public_Static_Single_Vector3_Vector3_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663634);
    UtilityScript.NativeMethodInfoPtr_GetAverage_Internal_Static_Vector2_List_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663635);
    UtilityScript.NativeMethodInfoPtr_RandomInRange_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663636);
    UtilityScript.NativeMethodInfoPtr_PlanarDistanceVec3_Public_Static_Vector3_Vector3_Vector3_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663637);
    UtilityScript.NativeMethodInfoPtr_GetPlanar_Public_Static_Vector3_Vector3_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663638);
    UtilityScript.NativeMethodInfoPtr_RoundAwayFromZero_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663639);
    UtilityScript.NativeMethodInfoPtr_AddToAverage_Public_Static_Single_Single_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663640);
    UtilityScript.NativeMethodInfoPtr_SubtractFromAverage_Public_Static_Single_Single_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663641);
    UtilityScript.NativeMethodInfoPtr_ReplaceInAverage_Public_Static_Single_Single_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663642);
    UtilityScript.NativeMethodInfoPtr_AddAveragesTogether_Public_Static_Single_Single_Int32_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663643);
    UtilityScript.NativeMethodInfoPtr_GetNormalDistance_Public_Static_Single_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663644);
    UtilityScript.NativeMethodInfoPtr_GetPathBasedOnOS_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663645);
    UtilityScript.NativeMethodInfoPtr_GetIdentifier_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663646);
    UtilityScript.NativeMethodInfoPtr_Lerp_Public_Static_Vector3_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663647);
    UtilityScript.NativeMethodInfoPtr_IsEmpty_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663648);
    UtilityScript.NativeMethodInfoPtr_ToEpoch_Public_Static_Double_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663649);
    UtilityScript.NativeMethodInfoPtr_FromEpoch_Public_Static_DateTime_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663650);
    UtilityScript.NativeMethodInfoPtr_ToEpochMs_Public_Static_Double_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663651);
    UtilityScript.NativeMethodInfoPtr_FromEpochMs_Public_Static_DateTime_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663652);
    UtilityScript.NativeMethodInfoPtr_SecondsToMs_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663653);
    UtilityScript.NativeMethodInfoPtr_AddWatermark_Public_Static_Texture2D_Texture2D_Texture2D_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663654);
    UtilityScript.NativeMethodInfoPtr_AngleDir_Public_Static_Single_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663655);
    UtilityScript.NativeMethodInfoPtr_ToCsv_Public_Static_IEnumerable_1_String_IEnumerable_1_T_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663656);
    UtilityScript.NativeMethodInfoPtr_SubtractValueFromMean_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663657);
    UtilityScript.NativeMethodInfoPtr_AddValueToMean_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663658);
    UtilityScript.NativeMethodInfoPtr_RandomColour_Public_Static_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663659);
    UtilityScript.NativeMethodInfoPtr_RandomIndex_Public_Static_Int32_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663660);
    UtilityScript.NativeMethodInfoPtr_Next_Public_Static_T_IEnumerable_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663661);
    UtilityScript.NativeMethodInfoPtr_CompareArrays_Public_Static_Boolean_Il2CppObjectBase_Il2CppObjectBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663662);
    UtilityScript.NativeMethodInfoPtr_RemapProportion_Public_Static_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663663);
    UtilityScript.NativeMethodInfoPtr_Distance_Public_Static_Single_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663664);
    UtilityScript.NativeMethodInfoPtr_Difference_Public_Static_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663665);
    UtilityScript.NativeMethodInfoPtr_InRange_Public_Static_Boolean_Vector2_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663666);
    UtilityScript.NativeMethodInfoPtr_RandomEnumValue_Public_Static_T_Likelihood_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663667);
    UtilityScript.NativeMethodInfoPtr_GetPercentageBetweenValues_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663668);
    UtilityScript.NativeMethodInfoPtr_GetPercentageBetweenValues_Public_Static_Single_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663669);
    UtilityScript.NativeMethodInfoPtr_GetValueAtPercentage_Public_Static_Single_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663670);
    UtilityScript.NativeMethodInfoPtr_Clamp_Public_Static_Single_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663671);
    UtilityScript.NativeMethodInfoPtr_ToVec3_Public_Static_Vector3_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663672);
    UtilityScript.NativeMethodInfoPtr_IsWithinThreshold_Internal_Static_Boolean_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663673);
    UtilityScript.NativeMethodInfoPtr_FlipTexture_Public_Static_Texture2D_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663674);
    UtilityScript.NativeMethodInfoPtr_ToTexture2D_Public_Static_Texture2D_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663675);
    UtilityScript.NativeMethodInfoPtr_RandomPointInRectTransform_Internal_Static_Vector3_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663676);
    UtilityScript.NativeMethodInfoPtr_RandomEnumValue_Public_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663677);
    UtilityScript.NativeMethodInfoPtr_RandomValueFromList_Internal_Static_T_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663678);
    UtilityScript.NativeMethodInfoPtr_GetEnumValue_Public_Static_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663679);
    UtilityScript.NativeMethodInfoPtr_GetCharPosition_Public_Static_Vector2_TextMeshPro_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663680);
    UtilityScript.NativeMethodInfoPtr_HasReachedDestination_Internal_Static_Boolean_NavMeshAgent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663681);
    UtilityScript.NativeMethodInfoPtr_GetRandomPointOnNavMesh_Internal_Static_Vector3_NavMeshAgent_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663682);
    UtilityScript.NativeMethodInfoPtr_SpiltAndCamelCase_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663683);
    UtilityScript.NativeMethodInfoPtr_GetSignedVec3_Internal_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663684);
    UtilityScript.NativeMethodInfoPtr_IsInCameraView_Internal_Static_Boolean_Camera_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663685);
    UtilityScript.NativeMethodInfoPtr_GetSignedAngle_Internal_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663686);
    UtilityScript.NativeMethodInfoPtr_RandomValueFromList_Internal_Static_T_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663687);
    UtilityScript.NativeMethodInfoPtr_RandomValueFromList_Internal_Static_T_List_1_T_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663688);
    UtilityScript.NativeMethodInfoPtr_RoundToNearestMultiple_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663689);
    UtilityScript.NativeMethodInfoPtr_Truncate_Public_Static_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663690);
    UtilityScript.NativeMethodInfoPtr_PingPong_Internal_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663691);
    UtilityScript.NativeMethodInfoPtr_ScaleObject_Internal_Static_IEnumerator_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663692);
    UtilityScript.NativeMethodInfoPtr_FindObject_Public_Static_GameObject_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663693);
    UtilityScript.NativeMethodInfoPtr_Update_Public_Static_Void_IEnumerable_1_TSource_Action_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663694);
    UtilityScript.NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Quaternion_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663695);
    UtilityScript.NativeMethodInfoPtr_Next_Public_Static_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663696);
    UtilityScript.NativeMethodInfoPtr_Multiply_Public_Static_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663697);
    UtilityScript.NativeMethodInfoPtr_ToVector3_Public_Static_Vector3_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663698);
    UtilityScript.NativeMethodInfoPtr_ToColour_Public_Static_Color_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663699);
    UtilityScript.NativeMethodInfoPtr_ColourFromVector3_Public_Static_Color_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663700);
    UtilityScript.NativeMethodInfoPtr_CopyFrom_Public_Static_Void_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663701);
    UtilityScript.NativeMethodInfoPtr_CopyFrom_Public_Static_Void_RectTransform_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663702);
    UtilityScript.NativeMethodInfoPtr_RotateAround_Public_Static_Vector3_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663703);
    UtilityScript.NativeMethodInfoPtr_ScaleToOne_Public_Static_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663704);
    UtilityScript.NativeMethodInfoPtr_ConvertToString_Public_Static_String_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663705);
    UtilityScript.NativeMethodInfoPtr_SetLayerRecursively_Public_Static_Void_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663706);
    UtilityScript.NativeMethodInfoPtr_SignedAngleBetween_Public_Static_Single_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663707);
    UtilityScript.NativeMethodInfoPtr_UnsignedAngleBetween_Public_Static_Single_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663708);
    UtilityScript.NativeMethodInfoPtr_GetDirTowardsPoint_Public_Static_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663709);
    UtilityScript.NativeMethodInfoPtr_GetDirAwayFromPoint_Public_Static_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663710);
    UtilityScript.NativeMethodInfoPtr_Reset_Public_Static_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663711);
    UtilityScript.NativeMethodInfoPtr_Reset_Public_Static_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663712);
    UtilityScript.NativeMethodInfoPtr_RangeSubset_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663713);
    UtilityScript.NativeMethodInfoPtr_Subset_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663714);
    UtilityScript.NativeMethodInfoPtr_IsValidEmail_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663715);
    UtilityScript.NativeMethodInfoPtr_Method_Internal_Static_String_Match_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, 100663716);
  }

  public UtilityScript(System.IntPtr pointer)
    : base(pointer)
  {
  }

  [ObfuscatedName("UtilityScript/<>c__DisplayClass25_0`1")]
  public sealed class __c__DisplayClass25_0<T> : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_o;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ToCsv_b__2_Internal_String_FieldInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ToCsv_b__3_Internal_String_PropertyInfo_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass25_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UtilityScript.__c__DisplayClass25_0<T>>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UtilityScript.__c__DisplayClass25_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19350, XrefRangeEnd = 19353, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string _ToCsv_b__2(FieldInfo f)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) f)
      };
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(UtilityScript.__c__DisplayClass25_0<T>.NativeMethodInfoPtr__ToCsv_b__2_Internal_String_FieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19353, XrefRangeEnd = 19363, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string _ToCsv_b__3(PropertyInfo p)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p)
      };
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(UtilityScript.__c__DisplayClass25_0<T>.NativeMethodInfoPtr__ToCsv_b__3_Internal_String_PropertyInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static __c__DisplayClass25_0()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<UtilityScript.__c__DisplayClass25_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, "<>c__DisplayClass25_0`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UtilityScript.__c__DisplayClass25_0<T>>.NativeClassPtr);
      UtilityScript.__c__DisplayClass25_0<T>.NativeFieldInfoPtr_o = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityScript.__c__DisplayClass25_0<T>>.NativeClassPtr, nameof (o));
      UtilityScript.__c__DisplayClass25_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript.__c__DisplayClass25_0<T>>.NativeClassPtr, 100663717);
      UtilityScript.__c__DisplayClass25_0<T>.NativeMethodInfoPtr__ToCsv_b__2_Internal_String_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript.__c__DisplayClass25_0<T>>.NativeClassPtr, 100663718);
      UtilityScript.__c__DisplayClass25_0<T>.NativeMethodInfoPtr__ToCsv_b__3_Internal_String_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript.__c__DisplayClass25_0<T>>.NativeClassPtr, 100663719);
    }

    public __c__DisplayClass25_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe T o
    {
      get
      {
        return IL2CPP.PointerToValueGeneric<T>(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UtilityScript.__c__DisplayClass25_0<T>.NativeFieldInfoPtr_o), true, false);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr targetAddress = ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UtilityScript.__c__DisplayClass25_0<T>.NativeFieldInfoPtr_o);
        System.Type type = typeof (T);
        if (!type.IsValueType)
        {
          if (!string.Equals(type.FullName, "System.String"))
          {
            System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((object) value as Il2CppObjectBase);
            if (ptr != System.IntPtr.Zero && IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ptr)))
            {
              System.IntPtr num1 = ptr;
              System.IntPtr num2 = IL2CPP.il2cpp_object_unbox(ptr);
              int num3 = IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(num1), (uint&) System.IntPtr.Zero);
              __memcpy(targetAddress, num2, num3);
            }
            else
              IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, targetAddress, ptr);
          }
          else
          {
            System.IntPtr il2Cpp = IL2CPP.ManagedStringToIl2Cpp((object) value as string);
            IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, targetAddress, il2Cpp);
          }
        }
        else
        {
          T obj = value;
          *(T*) targetAddress = obj;
        }
      }
    }
  }

  [ObfuscatedName("UtilityScript/<>c__25`1")]
  [Serializable]
  public sealed class __c__25<T> : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__25_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__25_1;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ToCsv_b__25_0_Internal_String_FieldInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ToCsv_b__25_1_Internal_String_PropertyInfo_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__25()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UtilityScript.__c__25<T>>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UtilityScript.__c__25<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19363, XrefRangeEnd = 19364, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string _ToCsv_b__25_0(FieldInfo f)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) f)
      };
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(UtilityScript.__c__25<T>.NativeMethodInfoPtr__ToCsv_b__25_0_Internal_String_FieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string _ToCsv_b__25_1(PropertyInfo p)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p)
      };
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(UtilityScript.__c__25<T>.NativeMethodInfoPtr__ToCsv_b__25_1_Internal_String_PropertyInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static __c__25()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<UtilityScript.__c__25<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, "<>c__25`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UtilityScript.__c__25<T>>.NativeClassPtr);
      UtilityScript.__c__25<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityScript.__c__25<T>>.NativeClassPtr, "<>9");
      UtilityScript.__c__25<T>.NativeFieldInfoPtr___9__25_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityScript.__c__25<T>>.NativeClassPtr, "<>9__25_0");
      UtilityScript.__c__25<T>.NativeFieldInfoPtr___9__25_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityScript.__c__25<T>>.NativeClassPtr, "<>9__25_1");
      UtilityScript.__c__25<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript.__c__25<T>>.NativeClassPtr, 100663721);
      UtilityScript.__c__25<T>.NativeMethodInfoPtr__ToCsv_b__25_0_Internal_String_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript.__c__25<T>>.NativeClassPtr, 100663722);
      UtilityScript.__c__25<T>.NativeMethodInfoPtr__ToCsv_b__25_1_Internal_String_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript.__c__25<T>>.NativeClassPtr, 100663723);
    }

    public __c__25(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe UtilityScript.__c__25<T> __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(UtilityScript.__c__25<T>.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (UtilityScript.__c__25<T>) null : new UtilityScript.__c__25<T>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UtilityScript.__c__25<T>.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<FieldInfo, string> __9__25_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(UtilityScript.__c__25<T>.NativeFieldInfoPtr___9__25_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<FieldInfo, string>) null : new Il2CppSystem.Func<FieldInfo, string>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UtilityScript.__c__25<T>.NativeFieldInfoPtr___9__25_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<PropertyInfo, string> __9__25_1
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(UtilityScript.__c__25<T>.NativeFieldInfoPtr___9__25_1, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<PropertyInfo, string>) null : new Il2CppSystem.Func<PropertyInfo, string>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UtilityScript.__c__25<T>.NativeFieldInfoPtr___9__25_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("UtilityScript/<ToCsv>d__25`1")]
  public sealed class _ToCsv_d__25<T> : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___l__initialThreadId;
    private static readonly System.IntPtr NativeFieldInfoPtr_header;
    private static readonly System.IntPtr NativeFieldInfoPtr___3__header;
    private static readonly System.IntPtr NativeFieldInfoPtr_separator;
    private static readonly System.IntPtr NativeFieldInfoPtr___3__separator;
    private static readonly System.IntPtr NativeFieldInfoPtr_objectlist;
    private static readonly System.IntPtr NativeFieldInfoPtr___3__objectlist;
    private static readonly System.IntPtr NativeFieldInfoPtr__fields_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr__properties_5__3;
    private static readonly System.IntPtr NativeFieldInfoPtr___7__wrap3;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 19366, RefRangeEnd = 19367, XrefRangeStart = 19364, XrefRangeEnd = 19366, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _ToCsv_d__25(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UtilityScript._ToCsv_d__25<T>>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UtilityScript._ToCsv_d__25<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19367, XrefRangeEnd = 19368, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UtilityScript._ToCsv_d__25<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19368, XrefRangeEnd = 19451, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript._ToCsv_d__25<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19451, XrefRangeEnd = 19454, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void __m__Finally1()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UtilityScript._ToCsv_d__25<T>.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe string System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EString\u003E\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(UtilityScript._ToCsv_d__25<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19454, XrefRangeEnd = 19460, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UtilityScript._ToCsv_d__25<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript._ToCsv_d__25<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19460, XrefRangeEnd = 19466, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe IEnumerator<string> System_Collections_Generic_IEnumerable_System_String__GetEnumerator()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript._ToCsv_d__25<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerator<string>) null : new IEnumerator<string>(pointer);
    }

    [CallerCount(0)]
    public virtual unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript._ToCsv_d__25<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
    }

    static _ToCsv_d__25()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<UtilityScript._ToCsv_d__25<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, "<ToCsv>d__25`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UtilityScript._ToCsv_d__25<T>>.NativeClassPtr);
      UtilityScript._ToCsv_d__25<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityScript._ToCsv_d__25<T>>.NativeClassPtr, "<>1__state");
      UtilityScript._ToCsv_d__25<T>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityScript._ToCsv_d__25<T>>.NativeClassPtr, "<>2__current");
      UtilityScript._ToCsv_d__25<T>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityScript._ToCsv_d__25<T>>.NativeClassPtr, "<>l__initialThreadId");
      UtilityScript._ToCsv_d__25<T>.NativeFieldInfoPtr_header = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityScript._ToCsv_d__25<T>>.NativeClassPtr, nameof (header));
      UtilityScript._ToCsv_d__25<T>.NativeFieldInfoPtr___3__header = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityScript._ToCsv_d__25<T>>.NativeClassPtr, "<>3__header");
      UtilityScript._ToCsv_d__25<T>.NativeFieldInfoPtr_separator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityScript._ToCsv_d__25<T>>.NativeClassPtr, nameof (separator));
      UtilityScript._ToCsv_d__25<T>.NativeFieldInfoPtr___3__separator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityScript._ToCsv_d__25<T>>.NativeClassPtr, "<>3__separator");
      UtilityScript._ToCsv_d__25<T>.NativeFieldInfoPtr_objectlist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityScript._ToCsv_d__25<T>>.NativeClassPtr, nameof (objectlist));
      UtilityScript._ToCsv_d__25<T>.NativeFieldInfoPtr___3__objectlist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityScript._ToCsv_d__25<T>>.NativeClassPtr, "<>3__objectlist");
      UtilityScript._ToCsv_d__25<T>.NativeFieldInfoPtr__fields_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityScript._ToCsv_d__25<T>>.NativeClassPtr, "<fields>5__2");
      UtilityScript._ToCsv_d__25<T>.NativeFieldInfoPtr__properties_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityScript._ToCsv_d__25<T>>.NativeClassPtr, "<properties>5__3");
      UtilityScript._ToCsv_d__25<T>.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityScript._ToCsv_d__25<T>>.NativeClassPtr, "<>7__wrap3");
      UtilityScript._ToCsv_d__25<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript._ToCsv_d__25<T>>.NativeClassPtr, 100663724);
      UtilityScript._ToCsv_d__25<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript._ToCsv_d__25<T>>.NativeClassPtr, 100663725);
      UtilityScript._ToCsv_d__25<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript._ToCsv_d__25<T>>.NativeClassPtr, 100663726);
      UtilityScript._ToCsv_d__25<T>.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript._ToCsv_d__25<T>>.NativeClassPtr, 100663727);
      UtilityScript._ToCsv_d__25<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript._ToCsv_d__25<T>>.NativeClassPtr, 100663728);
      UtilityScript._ToCsv_d__25<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript._ToCsv_d__25<T>>.NativeClassPtr, 100663729);
      UtilityScript._ToCsv_d__25<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript._ToCsv_d__25<T>>.NativeClassPtr, 100663730);
      UtilityScript._ToCsv_d__25<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript._ToCsv_d__25<T>>.NativeClassPtr, 100663731);
      UtilityScript._ToCsv_d__25<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript._ToCsv_d__25<T>>.NativeClassPtr, 100663732);
    }

    public _ToCsv_d__25(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UtilityScript._ToCsv_d__25<T>.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UtilityScript._ToCsv_d__25<T>.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe string __2__current
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UtilityScript._ToCsv_d__25<T>.NativeFieldInfoPtr___2__current)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UtilityScript._ToCsv_d__25<T>.NativeFieldInfoPtr___2__current), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe int __l__initialThreadId
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UtilityScript._ToCsv_d__25<T>.NativeFieldInfoPtr___l__initialThreadId));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UtilityScript._ToCsv_d__25<T>.NativeFieldInfoPtr___l__initialThreadId)) = value;
      }
    }

    public unsafe bool header
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UtilityScript._ToCsv_d__25<T>.NativeFieldInfoPtr_header));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UtilityScript._ToCsv_d__25<T>.NativeFieldInfoPtr_header)) = value;
      }
    }

    public unsafe bool __3__header
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UtilityScript._ToCsv_d__25<T>.NativeFieldInfoPtr___3__header));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UtilityScript._ToCsv_d__25<T>.NativeFieldInfoPtr___3__header)) = value;
      }
    }

    public unsafe string separator
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UtilityScript._ToCsv_d__25<T>.NativeFieldInfoPtr_separator)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UtilityScript._ToCsv_d__25<T>.NativeFieldInfoPtr_separator), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string __3__separator
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UtilityScript._ToCsv_d__25<T>.NativeFieldInfoPtr___3__separator)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UtilityScript._ToCsv_d__25<T>.NativeFieldInfoPtr___3__separator), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe IEnumerable<T> objectlist
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UtilityScript._ToCsv_d__25<T>.NativeFieldInfoPtr_objectlist));
        return pointer == System.IntPtr.Zero ? (IEnumerable<T>) null : new IEnumerable<T>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UtilityScript._ToCsv_d__25<T>.NativeFieldInfoPtr_objectlist), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe IEnumerable<T> __3__objectlist
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UtilityScript._ToCsv_d__25<T>.NativeFieldInfoPtr___3__objectlist));
        return pointer == System.IntPtr.Zero ? (IEnumerable<T>) null : new IEnumerable<T>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UtilityScript._ToCsv_d__25<T>.NativeFieldInfoPtr___3__objectlist), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<FieldInfo> _fields_5__2
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UtilityScript._ToCsv_d__25<T>.NativeFieldInfoPtr__fields_5__2));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<FieldInfo>) null : new Il2CppReferenceArray<FieldInfo>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UtilityScript._ToCsv_d__25<T>.NativeFieldInfoPtr__fields_5__2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<PropertyInfo> _properties_5__3
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UtilityScript._ToCsv_d__25<T>.NativeFieldInfoPtr__properties_5__3));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<PropertyInfo>) null : new Il2CppReferenceArray<PropertyInfo>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UtilityScript._ToCsv_d__25<T>.NativeFieldInfoPtr__properties_5__3), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe IEnumerator<T> __7__wrap3
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UtilityScript._ToCsv_d__25<T>.NativeFieldInfoPtr___7__wrap3));
        return pointer == System.IntPtr.Zero ? (IEnumerator<T>) null : new IEnumerator<T>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UtilityScript._ToCsv_d__25<T>.NativeFieldInfoPtr___7__wrap3), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("UtilityScript/<>c__DisplayClass31_0")]
  public sealed class __c__DisplayClass31_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_arrayA;
    private static readonly System.IntPtr NativeFieldInfoPtr_arrayB;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__CompareArrays_b__0_Internal_Boolean_Int32_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass31_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UtilityScript.__c__DisplayClass31_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UtilityScript.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19466, XrefRangeEnd = 19468, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _CompareArrays_b__0(int dimension)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &dimension
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript.__c__DisplayClass31_0.NativeMethodInfoPtr__CompareArrays_b__0_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass31_0()
    {
      Il2CppClassPointerStore<UtilityScript.__c__DisplayClass31_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, "<>c__DisplayClass31_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UtilityScript.__c__DisplayClass31_0>.NativeClassPtr);
      UtilityScript.__c__DisplayClass31_0.NativeFieldInfoPtr_arrayA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityScript.__c__DisplayClass31_0>.NativeClassPtr, nameof (arrayA));
      UtilityScript.__c__DisplayClass31_0.NativeFieldInfoPtr_arrayB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityScript.__c__DisplayClass31_0>.NativeClassPtr, nameof (arrayB));
      UtilityScript.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript.__c__DisplayClass31_0>.NativeClassPtr, 100663733);
      UtilityScript.__c__DisplayClass31_0.NativeMethodInfoPtr__CompareArrays_b__0_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript.__c__DisplayClass31_0>.NativeClassPtr, 100663734);
    }

    public __c__DisplayClass31_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppObjectBase arrayA
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UtilityScript.__c__DisplayClass31_0.NativeFieldInfoPtr_arrayA));
        return pointer == System.IntPtr.Zero ? (Il2CppObjectBase) null : new Il2CppObjectBase(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UtilityScript.__c__DisplayClass31_0.NativeFieldInfoPtr_arrayA), IL2CPP.Il2CppObjectBaseToPtr(value));
      }
    }

    public unsafe Il2CppObjectBase arrayB
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UtilityScript.__c__DisplayClass31_0.NativeFieldInfoPtr_arrayB));
        return pointer == System.IntPtr.Zero ? (Il2CppObjectBase) null : new Il2CppObjectBase(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UtilityScript.__c__DisplayClass31_0.NativeFieldInfoPtr_arrayB), IL2CPP.Il2CppObjectBaseToPtr(value));
      }
    }
  }

  [ObfuscatedName("UtilityScript/<ScaleObject>d__61")]
  public sealed class _ScaleObject_d__61 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr_gameObj;
    private static readonly System.IntPtr NativeFieldInfoPtr_aValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_aTime;
    private static readonly System.IntPtr NativeFieldInfoPtr__currentScale_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr__t_5__3;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _ScaleObject_d__61(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UtilityScript._ScaleObject_d__61>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UtilityScript._ScaleObject_d__61.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UtilityScript._ScaleObject_d__61.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19468, XrefRangeEnd = 19477, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript._ScaleObject_d__61.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript._ScaleObject_d__61.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19477, XrefRangeEnd = 19483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UtilityScript._ScaleObject_d__61.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UtilityScript._ScaleObject_d__61.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _ScaleObject_d__61()
    {
      Il2CppClassPointerStore<UtilityScript._ScaleObject_d__61>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UtilityScript>.NativeClassPtr, "<ScaleObject>d__61");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UtilityScript._ScaleObject_d__61>.NativeClassPtr);
      UtilityScript._ScaleObject_d__61.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityScript._ScaleObject_d__61>.NativeClassPtr, "<>1__state");
      UtilityScript._ScaleObject_d__61.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityScript._ScaleObject_d__61>.NativeClassPtr, "<>2__current");
      UtilityScript._ScaleObject_d__61.NativeFieldInfoPtr_gameObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityScript._ScaleObject_d__61>.NativeClassPtr, nameof (gameObj));
      UtilityScript._ScaleObject_d__61.NativeFieldInfoPtr_aValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityScript._ScaleObject_d__61>.NativeClassPtr, nameof (aValue));
      UtilityScript._ScaleObject_d__61.NativeFieldInfoPtr_aTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityScript._ScaleObject_d__61>.NativeClassPtr, nameof (aTime));
      UtilityScript._ScaleObject_d__61.NativeFieldInfoPtr__currentScale_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityScript._ScaleObject_d__61>.NativeClassPtr, "<currentScale>5__2");
      UtilityScript._ScaleObject_d__61.NativeFieldInfoPtr__t_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityScript._ScaleObject_d__61>.NativeClassPtr, "<t>5__3");
      UtilityScript._ScaleObject_d__61.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript._ScaleObject_d__61>.NativeClassPtr, 100663735);
      UtilityScript._ScaleObject_d__61.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript._ScaleObject_d__61>.NativeClassPtr, 100663736);
      UtilityScript._ScaleObject_d__61.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript._ScaleObject_d__61>.NativeClassPtr, 100663737);
      UtilityScript._ScaleObject_d__61.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript._ScaleObject_d__61>.NativeClassPtr, 100663738);
      UtilityScript._ScaleObject_d__61.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript._ScaleObject_d__61>.NativeClassPtr, 100663739);
      UtilityScript._ScaleObject_d__61.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityScript._ScaleObject_d__61>.NativeClassPtr, 100663740);
    }

    public _ScaleObject_d__61(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UtilityScript._ScaleObject_d__61.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UtilityScript._ScaleObject_d__61.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UtilityScript._ScaleObject_d__61.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UtilityScript._ScaleObject_d__61.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject gameObj
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UtilityScript._ScaleObject_d__61.NativeFieldInfoPtr_gameObj));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UtilityScript._ScaleObject_d__61.NativeFieldInfoPtr_gameObj), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float aValue
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UtilityScript._ScaleObject_d__61.NativeFieldInfoPtr_aValue));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UtilityScript._ScaleObject_d__61.NativeFieldInfoPtr_aValue)) = value;
      }
    }

    public unsafe float aTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UtilityScript._ScaleObject_d__61.NativeFieldInfoPtr_aTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UtilityScript._ScaleObject_d__61.NativeFieldInfoPtr_aTime)) = value;
      }
    }

    public unsafe Vector3 _currentScale_5__2
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UtilityScript._ScaleObject_d__61.NativeFieldInfoPtr__currentScale_5__2));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UtilityScript._ScaleObject_d__61.NativeFieldInfoPtr__currentScale_5__2)) = value;
      }
    }

    public unsafe float _t_5__3
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UtilityScript._ScaleObject_d__61.NativeFieldInfoPtr__t_5__3));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UtilityScript._ScaleObject_d__61.NativeFieldInfoPtr__t_5__3)) = value;
      }
    }
  }

  private sealed class MethodInfoStoreGeneric_GetMethodInfo_Public_Static_MethodInfo_Expression_1_Action_1_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(UtilityScript.NativeMethodInfoPtr_GetMethodInfo_Public_Static_MethodInfo_Expression_1_Action_1_T_0, Il2CppClassPointerStore<UtilityScript>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_ToCsv_Public_Static_IEnumerable_1_String_IEnumerable_1_T_String_Boolean_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(UtilityScript.NativeMethodInfoPtr_ToCsv_Public_Static_IEnumerable_1_String_IEnumerable_1_T_String_Boolean_0, Il2CppClassPointerStore<UtilityScript>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_RandomIndex_Public_Static_Int32_IEnumerable_1_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(UtilityScript.NativeMethodInfoPtr_RandomIndex_Public_Static_Int32_IEnumerable_1_T_0, Il2CppClassPointerStore<UtilityScript>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_Next_Public_Static_T_IEnumerable_1_T_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(UtilityScript.NativeMethodInfoPtr_Next_Public_Static_T_IEnumerable_1_T_T_0, Il2CppClassPointerStore<UtilityScript>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_RandomEnumValue_Public_Static_T_Likelihood_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(UtilityScript.NativeMethodInfoPtr_RandomEnumValue_Public_Static_T_Likelihood_0, Il2CppClassPointerStore<UtilityScript>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_RandomEnumValue_Public_Static_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(UtilityScript.NativeMethodInfoPtr_RandomEnumValue_Public_Static_T_0, Il2CppClassPointerStore<UtilityScript>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_RandomValueFromList_Internal_Static_T_List_1_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(UtilityScript.NativeMethodInfoPtr_RandomValueFromList_Internal_Static_T_List_1_T_0, Il2CppClassPointerStore<UtilityScript>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_GetEnumValue_Public_Static_T_String_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(UtilityScript.NativeMethodInfoPtr_GetEnumValue_Public_Static_T_String_0, Il2CppClassPointerStore<UtilityScript>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_RandomValueFromList_Internal_Static_T_Il2CppArrayBase_1_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(UtilityScript.NativeMethodInfoPtr_RandomValueFromList_Internal_Static_T_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<UtilityScript>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_RandomValueFromList_Internal_Static_T_List_1_T_List_1_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(UtilityScript.NativeMethodInfoPtr_RandomValueFromList_Internal_Static_T_List_1_T_List_1_T_0, Il2CppClassPointerStore<UtilityScript>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_Update_Public_Static_Void_IEnumerable_1_TSource_Action_1_TSource_0<TSource>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(UtilityScript.NativeMethodInfoPtr_Update_Public_Static_Void_IEnumerable_1_TSource_Action_1_TSource_0, Il2CppClassPointerStore<UtilityScript>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_Next_Public_Static_T_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(UtilityScript.NativeMethodInfoPtr_Next_Public_Static_T_T_0, Il2CppClassPointerStore<UtilityScript>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_RangeSubset_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_Int32_Int32_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(UtilityScript.NativeMethodInfoPtr_RangeSubset_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_Int32_Int32_0, Il2CppClassPointerStore<UtilityScript>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_Subset_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_Il2CppStructArray_1_Int32_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(UtilityScript.NativeMethodInfoPtr_Subset_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_Il2CppStructArray_1_Int32_0, Il2CppClassPointerStore<UtilityScript>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
