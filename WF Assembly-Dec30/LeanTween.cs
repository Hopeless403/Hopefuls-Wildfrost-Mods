// Decompiled with JetBrains decompiler
// Type: LeanTween
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;

#nullable disable
public class LeanTween : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_throwErrors;
  private static readonly System.IntPtr NativeFieldInfoPtr_tau;
  private static readonly System.IntPtr NativeFieldInfoPtr_PI_DIV2;
  private static readonly System.IntPtr NativeFieldInfoPtr_sequences;
  private static readonly System.IntPtr NativeFieldInfoPtr_tweens;
  private static readonly System.IntPtr NativeFieldInfoPtr_tweensFinished;
  private static readonly System.IntPtr NativeFieldInfoPtr_tweensFinishedIds;
  private static readonly System.IntPtr NativeFieldInfoPtr_tween;
  private static readonly System.IntPtr NativeFieldInfoPtr_tweenMaxSearch;
  private static readonly System.IntPtr NativeFieldInfoPtr_maxTweens;
  private static readonly System.IntPtr NativeFieldInfoPtr_maxSequences;
  private static readonly System.IntPtr NativeFieldInfoPtr_frameRendered;
  private static readonly System.IntPtr NativeFieldInfoPtr__tweenEmpty;
  private static readonly System.IntPtr NativeFieldInfoPtr_dtEstimated;
  private static readonly System.IntPtr NativeFieldInfoPtr_dtManual;
  private static readonly System.IntPtr NativeFieldInfoPtr_dtActual;
  private static readonly System.IntPtr NativeFieldInfoPtr_global_counter;
  private static readonly System.IntPtr NativeFieldInfoPtr_i;
  private static readonly System.IntPtr NativeFieldInfoPtr_j;
  private static readonly System.IntPtr NativeFieldInfoPtr_finishedCnt;
  private static readonly System.IntPtr NativeFieldInfoPtr_punch;
  private static readonly System.IntPtr NativeFieldInfoPtr_shake;
  private static readonly System.IntPtr NativeFieldInfoPtr_maxTweenReached;
  private static readonly System.IntPtr NativeFieldInfoPtr_startSearch;
  private static readonly System.IntPtr NativeFieldInfoPtr_d;
  private static readonly System.IntPtr NativeFieldInfoPtr_eventListeners;
  private static readonly System.IntPtr NativeFieldInfoPtr_goListeners;
  private static readonly System.IntPtr NativeFieldInfoPtr_eventsMaxSearch;
  private static readonly System.IntPtr NativeFieldInfoPtr_EVENTS_MAX;
  private static readonly System.IntPtr NativeFieldInfoPtr_LISTENERS_MAX;
  private static readonly System.IntPtr NativeFieldInfoPtr_INIT_LISTENERS_MAX;
  private static readonly System.IntPtr NativeMethodInfoPtr_init_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_maxSearch_Public_Static_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_maxSimulataneousTweens_Public_Static_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_tweensRunning_Public_Static_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_init_Public_Static_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_init_Public_Static_Void_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_reset_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_onLevelWasLoaded54_Private_Static_Void_Scene_LoadSceneMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_internalOnLevelWasLoaded_Private_Static_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_update_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_removeTween_Public_Static_Void_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_removeTween_Public_Static_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_add_Public_Static_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_closestRot_Public_Static_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_cancelAll_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_cancelAll_Public_Static_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_cancel_Public_Static_Void_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_cancel_Public_Static_Void_GameObject_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_cancel_Public_Static_Void_RectTransform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_cancel_Public_Static_Void_GameObject_Int32_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_cancel_Public_Static_Void_LTRect_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_cancel_Public_Static_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_cancel_Public_Static_Void_Int32_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_descr_Public_Static_LTDescr_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_description_Public_Static_LTDescr_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_descriptions_Public_Static_Il2CppReferenceArray_1_LTDescr_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_pause_Public_Static_Void_GameObject_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_pause_Public_Static_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_pause_Public_Static_Void_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_pauseAll_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_resumeAll_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_resume_Public_Static_Void_GameObject_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_resume_Public_Static_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_resume_Public_Static_Void_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_isPaused_Public_Static_Boolean_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_isPaused_Public_Static_Boolean_RectTransform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_isPaused_Public_Static_Boolean_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_isTweening_Public_Static_Boolean_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_isTweening_Public_Static_Boolean_RectTransform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_isTweening_Public_Static_Boolean_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_isTweening_Public_Static_Boolean_LTRect_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_drawBezierPath_Public_Static_Void_Vector3_Vector3_Vector3_Vector3_Single_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_logError_Public_Static_Object_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_options_Public_Static_LTDescr_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_options_Public_Static_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_tweenEmpty_Public_Static_get_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_pushNewTween_Private_Static_LTDescr_GameObject_Vector3_Single_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_play_Public_Static_LTDescr_RectTransform_Il2CppReferenceArray_1_Sprite_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_sequence_Public_Static_LTSeq_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_alpha_Public_Static_LTDescr_GameObject_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_alpha_Public_Static_LTDescr_LTRect_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_textAlpha_Public_Static_LTDescr_RectTransform_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_alphaText_Public_Static_LTDescr_RectTransform_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_alphaCanvas_Public_Static_LTDescr_CanvasGroup_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_alphaVertex_Public_Static_LTDescr_GameObject_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_color_Public_Static_LTDescr_GameObject_Color_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_textColor_Public_Static_LTDescr_RectTransform_Color_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_colorText_Public_Static_LTDescr_RectTransform_Color_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_delayedCall_Public_Static_LTDescr_Single_Action_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_delayedCall_Public_Static_LTDescr_Single_Action_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_delayedCall_Public_Static_LTDescr_GameObject_Single_Action_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_delayedCall_Public_Static_LTDescr_GameObject_Single_Action_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_destroyAfter_Public_Static_LTDescr_LTRect_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_move_Public_Static_LTDescr_GameObject_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_move_Public_Static_LTDescr_GameObject_Vector2_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_move_Public_Static_LTDescr_GameObject_Il2CppStructArray_1_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_move_Public_Static_LTDescr_GameObject_LTBezierPath_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_move_Public_Static_LTDescr_GameObject_LTSpline_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_moveSpline_Public_Static_LTDescr_GameObject_Il2CppStructArray_1_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_moveSpline_Public_Static_LTDescr_GameObject_LTSpline_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_moveSplineLocal_Public_Static_LTDescr_GameObject_Il2CppStructArray_1_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_move_Public_Static_LTDescr_LTRect_Vector2_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_moveMargin_Public_Static_LTDescr_LTRect_Vector2_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_moveX_Public_Static_LTDescr_GameObject_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_moveY_Public_Static_LTDescr_GameObject_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_moveZ_Public_Static_LTDescr_GameObject_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_moveLocal_Public_Static_LTDescr_GameObject_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_moveLocal_Public_Static_LTDescr_GameObject_Il2CppStructArray_1_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_moveLocalX_Public_Static_LTDescr_GameObject_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_moveLocalY_Public_Static_LTDescr_GameObject_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_moveLocalZ_Public_Static_LTDescr_GameObject_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_moveLocal_Public_Static_LTDescr_GameObject_LTBezierPath_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_moveLocal_Public_Static_LTDescr_GameObject_LTSpline_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_move_Public_Static_LTDescr_GameObject_Transform_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_rotate_Public_Static_LTDescr_GameObject_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_rotate_Public_Static_LTDescr_LTRect_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_rotateLocal_Public_Static_LTDescr_GameObject_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_rotateX_Public_Static_LTDescr_GameObject_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_rotateY_Public_Static_LTDescr_GameObject_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_rotateZ_Public_Static_LTDescr_GameObject_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_rotateAround_Public_Static_LTDescr_GameObject_Vector3_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_rotateAroundLocal_Public_Static_LTDescr_GameObject_Vector3_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_scale_Public_Static_LTDescr_GameObject_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_scale_Public_Static_LTDescr_LTRect_Vector2_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_scaleX_Public_Static_LTDescr_GameObject_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_scaleY_Public_Static_LTDescr_GameObject_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_scaleZ_Public_Static_LTDescr_GameObject_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_value_Public_Static_LTDescr_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Vector2_Vector2_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Vector3_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Color_Color_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_1_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_2_Single_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_1_Color_Color_Color_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_2_Color_Object_Color_Color_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_1_Vector2_Vector2_Vector2_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_1_Vector3_Vector3_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_2_Single_Object_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_delayedSound_Public_Static_LTDescr_AudioClip_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_delayedSound_Public_Static_LTDescr_GameObject_AudioClip_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_move_Public_Static_LTDescr_RectTransform_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_moveX_Public_Static_LTDescr_RectTransform_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_moveY_Public_Static_LTDescr_RectTransform_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_moveZ_Public_Static_LTDescr_RectTransform_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_rotate_Public_Static_LTDescr_RectTransform_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_rotate_Public_Static_LTDescr_RectTransform_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_rotateAround_Public_Static_LTDescr_RectTransform_Vector3_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_rotateAroundLocal_Public_Static_LTDescr_RectTransform_Vector3_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_scale_Public_Static_LTDescr_RectTransform_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_size_Public_Static_LTDescr_RectTransform_Vector2_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_alpha_Public_Static_LTDescr_RectTransform_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_color_Public_Static_LTDescr_RectTransform_Color_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_tweenOnCurve_Public_Static_Single_LTDescr_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_tweenOnCurveVector_Public_Static_Vector3_LTDescr_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeOutQuadOpt_Public_Static_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeInQuadOpt_Public_Static_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeInOutQuadOpt_Public_Static_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeInOutQuadOpt_Public_Static_Vector3_Vector3_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_linear_Public_Static_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_clerp_Public_Static_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_spring_Public_Static_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeInQuad_Public_Static_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeOutQuad_Public_Static_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeInOutQuad_Public_Static_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeInOutQuadOpt2_Public_Static_Single_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeInCubic_Public_Static_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeOutCubic_Public_Static_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeInOutCubic_Public_Static_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeInQuart_Public_Static_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeOutQuart_Public_Static_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeInOutQuart_Public_Static_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeInQuint_Public_Static_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeOutQuint_Public_Static_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeInOutQuint_Public_Static_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeInSine_Public_Static_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeOutSine_Public_Static_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeInOutSine_Public_Static_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeInExpo_Public_Static_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeOutExpo_Public_Static_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeInOutExpo_Public_Static_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeInCirc_Public_Static_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeOutCirc_Public_Static_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeInOutCirc_Public_Static_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeInBounce_Public_Static_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeOutBounce_Public_Static_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeInOutBounce_Public_Static_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeInBack_Public_Static_Single_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeOutBack_Public_Static_Single_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeInOutBack_Public_Static_Single_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeInElastic_Public_Static_Single_Single_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeOutElastic_Public_Static_Single_Single_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeInOutElastic_Public_Static_Single_Single_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_followDamp_Public_Static_LTDescr_Transform_Transform_LeanProp_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_followSpring_Public_Static_LTDescr_Transform_Transform_LeanProp_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_followBounceOut_Public_Static_LTDescr_Transform_Transform_LeanProp_Single_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_followLinear_Public_Static_LTDescr_Transform_Transform_LeanProp_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_addListener_Public_Static_Void_Int32_Action_1_LTEvent_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_addListener_Public_Static_Void_GameObject_Int32_Action_1_LTEvent_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_removeListener_Public_Static_Boolean_Int32_Action_1_LTEvent_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_removeListener_Public_Static_Boolean_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_removeListener_Public_Static_Boolean_GameObject_Int32_Action_1_LTEvent_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_dispatchEvent_Public_Static_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_dispatchEvent_Public_Static_Void_Int32_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(10)]
  [CachedScanResults(RefRangeStart = 129347, RefRangeEnd = 129357, XrefRangeStart = 129338, XrefRangeEnd = 129347, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void init()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_init_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  public static unsafe int maxSearch
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129357, XrefRangeEnd = 129361, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_get_maxSearch_Public_Static_get_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public static unsafe int maxSimulataneousTweens
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129361, XrefRangeEnd = 129365, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_get_maxSimulataneousTweens_Public_Static_get_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public static unsafe int tweensRunning
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129365, XrefRangeEnd = 129372, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_get_tweensRunning_Public_Static_get_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129372, XrefRangeEnd = 129377, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void init(int maxSimultaneousTweens)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &maxSimultaneousTweens
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_init_Public_Static_Void_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(14)]
  [CachedScanResults(RefRangeStart = 129470, RefRangeEnd = 129484, XrefRangeStart = 129377, XrefRangeEnd = 129470, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void init(int maxSimultaneousTweens, int maxSimultaneousSequences)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &maxSimultaneousTweens;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &maxSimultaneousSequences;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_init_Public_Static_Void_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129484, XrefRangeEnd = 129507, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void reset()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_reset_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129507, XrefRangeEnd = 129557, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129557, XrefRangeEnd = 129565, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void onLevelWasLoaded54(Scene scene, LoadSceneMode mode)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &scene;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &mode;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_onLevelWasLoaded54_Private_Static_Void_Scene_LoadSceneMode_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129565, XrefRangeEnd = 129569, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void internalOnLevelWasLoaded(int lvl)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &lvl
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_internalOnLevelWasLoaded_Private_Static_Void_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 129642, RefRangeEnd = 129643, XrefRangeStart = 129569, XrefRangeEnd = 129642, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void update()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_update_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 129651, RefRangeEnd = 129652, XrefRangeStart = 129643, XrefRangeEnd = 129651, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void removeTween(int i, int uniqueId)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &i;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &uniqueId;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_removeTween_Public_Static_Void_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 129697, RefRangeEnd = 129703, XrefRangeStart = 129652, XrefRangeEnd = 129697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void removeTween(int i)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &i
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_removeTween_Public_Static_Void_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129703, XrefRangeEnd = 129717, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppStructArray<Vector3> add(Il2CppStructArray<Vector3> a, Vector3 b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_add_Public_Static_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr nativeObject = num;
    return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<Vector3>) null : new Il2CppStructArray<Vector3>(nativeObject);
  }

  [CallerCount(9)]
  [CachedScanResults(RefRangeStart = 129717, RefRangeEnd = 129726, XrefRangeStart = 129717, XrefRangeEnd = 129717, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float closestRot(float from, float to)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &from;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_closestRot_Public_Static_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129726, XrefRangeEnd = 129730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void cancelAll()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_cancelAll_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 129752, RefRangeEnd = 129753, XrefRangeStart = 129730, XrefRangeEnd = 129752, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void cancelAll(bool callComplete)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &callComplete
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_cancelAll_Public_Static_Void_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(115)]
  [CachedScanResults(RefRangeStart = 129757, RefRangeEnd = 129872, XrefRangeStart = 129753, XrefRangeEnd = 129757, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void cancel(GameObject gameObject)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_cancel_Public_Static_Void_GameObject_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 129890, RefRangeEnd = 129893, XrefRangeStart = 129872, XrefRangeEnd = 129890, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void cancel(GameObject gameObject, bool callOnComplete)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &callOnComplete;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_cancel_Public_Static_Void_GameObject_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 129899, RefRangeEnd = 129906, XrefRangeStart = 129893, XrefRangeEnd = 129899, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void cancel(RectTransform rect)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rect)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_cancel_Public_Static_Void_RectTransform_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 129925, RefRangeEnd = 129926, XrefRangeStart = 129906, XrefRangeEnd = 129925, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void cancel(GameObject gameObject, int uniqueId, bool callOnComplete = false)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &uniqueId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &callOnComplete;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_cancel_Public_Static_Void_GameObject_Int32_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129926, XrefRangeEnd = 129935, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void cancel(LTRect ltRect, int uniqueId)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) ltRect);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &uniqueId;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_cancel_Public_Static_Void_LTRect_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 129939, RefRangeEnd = 129941, XrefRangeStart = 129935, XrefRangeEnd = 129939, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void cancel(int uniqueId)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &uniqueId
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_cancel_Public_Static_Void_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 129955, RefRangeEnd = 129956, XrefRangeStart = 129941, XrefRangeEnd = 129955, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void cancel(int uniqueId, bool callOnComplete)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &uniqueId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &callOnComplete;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_cancel_Public_Static_Void_Int32_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 129969, RefRangeEnd = 129970, XrefRangeStart = 129956, XrefRangeEnd = 129969, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr descr(int uniqueId)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &uniqueId
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_descr_Public_Static_LTDescr_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129970, XrefRangeEnd = 129974, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr description(int uniqueId)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &uniqueId
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_description_Public_Static_LTDescr_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129974, XrefRangeEnd = 130007, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppReferenceArray<LTDescr> descriptions(GameObject gameObject = null)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_descriptions_Public_Static_Il2CppReferenceArray_1_LTDescr_GameObject_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr nativeObject = num;
    return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<LTDescr>) null : new Il2CppReferenceArray<LTDescr>(nativeObject);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130007, XrefRangeEnd = 130018, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void pause(GameObject gameObject, int uniqueId)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &uniqueId;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_pause_Public_Static_Void_GameObject_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130018, XrefRangeEnd = 130025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void pause(int uniqueId)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &uniqueId
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_pause_Public_Static_Void_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 130041, RefRangeEnd = 130042, XrefRangeStart = 130025, XrefRangeEnd = 130041, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void pause(GameObject gameObject)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_pause_Public_Static_Void_GameObject_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130042, XrefRangeEnd = 130053, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void pauseAll()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_pauseAll_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130053, XrefRangeEnd = 130064, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void resumeAll()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_resumeAll_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130064, XrefRangeEnd = 130075, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void resume(GameObject gameObject, int uniqueId)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &uniqueId;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_resume_Public_Static_Void_GameObject_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130075, XrefRangeEnd = 130082, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void resume(int uniqueId)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &uniqueId
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_resume_Public_Static_Void_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 130098, RefRangeEnd = 130099, XrefRangeStart = 130082, XrefRangeEnd = 130098, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void resume(GameObject gameObject)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_resume_Public_Static_Void_GameObject_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 130135, RefRangeEnd = 130136, XrefRangeStart = 130099, XrefRangeEnd = 130135, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool isPaused(GameObject gameObject = null)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_isPaused_Public_Static_Boolean_GameObject_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 130142, RefRangeEnd = 130143, XrefRangeStart = 130136, XrefRangeEnd = 130142, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool isPaused(RectTransform rect)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rect)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_isPaused_Public_Static_Boolean_RectTransform_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130143, XrefRangeEnd = 130157, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool isPaused(int uniqueId)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &uniqueId
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_isPaused_Public_Static_Boolean_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 130181, RefRangeEnd = 130184, XrefRangeStart = 130157, XrefRangeEnd = 130181, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool isTweening(GameObject gameObject = null)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_isTweening_Public_Static_Boolean_GameObject_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130184, XrefRangeEnd = 130190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool isTweening(RectTransform rect)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rect)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_isTweening_Public_Static_Boolean_RectTransform_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130190, XrefRangeEnd = 130198, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool isTweening(int uniqueId)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &uniqueId
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_isTweening_Public_Static_Boolean_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130198, XrefRangeEnd = 130207, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool isTweening(LTRect ltRect)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) ltRect)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_isTweening_Public_Static_Boolean_LTRect_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130207, XrefRangeEnd = 130208, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void drawBezierPath(
    Vector3 a,
    Vector3 b,
    Vector3 c,
    Vector3 d,
    float arrowSize = 0.0f,
    Transform arrowTransform = null)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &c;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &d;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &arrowSize;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) arrowTransform);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_drawBezierPath_Public_Static_Void_Vector3_Vector3_Vector3_Vector3_Single_Transform_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 130216, RefRangeEnd = 130219, XrefRangeStart = 130208, XrefRangeEnd = 130216, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppSystem.Object logError(string error)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(error)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_logError_Public_Static_Object_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130219, XrefRangeEnd = 130225, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr options(LTDescr seed)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) seed)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_options_Public_Static_LTDescr_LTDescr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(79)]
  [CachedScanResults(RefRangeStart = 130269, RefRangeEnd = 130348, XrefRangeStart = 130225, XrefRangeEnd = 130269, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr options()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_options_Public_Static_LTDescr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  public static unsafe GameObject tweenEmpty
  {
    [CallerCount(12), CachedScanResults(RefRangeStart = 130358, RefRangeEnd = 130370, XrefRangeStart = 130348, XrefRangeEnd = 130358, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_get_tweenEmpty_Public_Static_get_GameObject_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
  }

  [CallerCount(70)]
  [CachedScanResults(RefRangeStart = 130387, RefRangeEnd = 130457, XrefRangeStart = 130370, XrefRangeEnd = 130387, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr pushNewTween(
    GameObject gameObject,
    Vector3 to,
    float time,
    LTDescr tween)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) tween);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_pushNewTween_Private_Static_LTDescr_GameObject_Vector3_Single_LTDescr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 130466, RefRangeEnd = 130467, XrefRangeStart = 130457, XrefRangeEnd = 130466, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr play(
    RectTransform rectTransform,
    Il2CppReferenceArray<Sprite> sprites)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rectTransform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sprites);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_play_Public_Static_LTDescr_RectTransform_Il2CppReferenceArray_1_Sprite_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 130489, RefRangeEnd = 130490, XrefRangeStart = 130467, XrefRangeEnd = 130489, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTSeq sequence(bool initSequence = true)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &initSequence
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_sequence_Public_Static_LTSeq_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTSeq) null : new LTSeq(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 130500, RefRangeEnd = 130501, XrefRangeStart = 130490, XrefRangeEnd = 130500, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr alpha(GameObject gameObject, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_alpha_Public_Static_LTDescr_GameObject_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130501, XrefRangeEnd = 130509, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr alpha(LTRect ltRect, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) ltRect);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_alpha_Public_Static_LTDescr_LTRect_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130509, XrefRangeEnd = 130516, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr textAlpha(RectTransform rectTransform, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rectTransform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_textAlpha_Public_Static_LTDescr_RectTransform_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 130523, RefRangeEnd = 130524, XrefRangeStart = 130516, XrefRangeEnd = 130523, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr alphaText(RectTransform rectTransform, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rectTransform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_alphaText_Public_Static_LTDescr_RectTransform_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 130531, RefRangeEnd = 130538, XrefRangeStart = 130524, XrefRangeEnd = 130531, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr alphaCanvas(CanvasGroup canvasGroup, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) canvasGroup);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_alphaCanvas_Public_Static_LTDescr_CanvasGroup_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 130544, RefRangeEnd = 130545, XrefRangeStart = 130538, XrefRangeEnd = 130544, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr alphaVertex(GameObject gameObject, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_alphaVertex_Public_Static_LTDescr_GameObject_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(9)]
  [CachedScanResults(RefRangeStart = 130556, RefRangeEnd = 130565, XrefRangeStart = 130545, XrefRangeEnd = 130556, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr color(GameObject gameObject, Color to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_color_Public_Static_LTDescr_GameObject_Color_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130565, XrefRangeEnd = 130573, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr textColor(RectTransform rectTransform, Color to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rectTransform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_textColor_Public_Static_LTDescr_RectTransform_Color_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 130581, RefRangeEnd = 130582, XrefRangeStart = 130573, XrefRangeEnd = 130581, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr colorText(RectTransform rectTransform, Color to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rectTransform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_colorText_Public_Static_LTDescr_RectTransform_Color_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 130592, RefRangeEnd = 130593, XrefRangeStart = 130582, XrefRangeEnd = 130592, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr delayedCall(float delayTime, Il2CppSystem.Action callback)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &delayTime;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_delayedCall_Public_Static_LTDescr_Single_Action_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 130603, RefRangeEnd = 130604, XrefRangeStart = 130593, XrefRangeEnd = 130603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr delayedCall(float delayTime, Il2CppSystem.Action<Il2CppSystem.Object> callback)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &delayTime;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_delayedCall_Public_Static_LTDescr_Single_Action_1_Object_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 130613, RefRangeEnd = 130615, XrefRangeStart = 130604, XrefRangeEnd = 130613, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr delayedCall(GameObject gameObject, float delayTime, Il2CppSystem.Action callback)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &delayTime;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_delayedCall_Public_Static_LTDescr_GameObject_Single_Action_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 130624, RefRangeEnd = 130626, XrefRangeStart = 130615, XrefRangeEnd = 130624, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr delayedCall(
    GameObject gameObject,
    float delayTime,
    Il2CppSystem.Action<Il2CppSystem.Object> callback)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &delayTime;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_delayedCall_Public_Static_LTDescr_GameObject_Single_Action_1_Object_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130626, XrefRangeEnd = 130637, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr destroyAfter(LTRect rect, float delayTime)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rect);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &delayTime;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_destroyAfter_Public_Static_LTDescr_LTRect_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(17)]
  [CachedScanResults(RefRangeStart = 130643, RefRangeEnd = 130660, XrefRangeStart = 130637, XrefRangeEnd = 130643, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr move(GameObject gameObject, Vector3 to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_move_Public_Static_LTDescr_GameObject_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 130668, RefRangeEnd = 130670, XrefRangeStart = 130660, XrefRangeEnd = 130668, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr move(GameObject gameObject, Vector2 to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_move_Public_Static_LTDescr_GameObject_Vector2_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 130710, RefRangeEnd = 130712, XrefRangeStart = 130670, XrefRangeEnd = 130710, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr move(
    GameObject gameObject,
    Il2CppStructArray<Vector3> to,
    float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) to);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_move_Public_Static_LTDescr_GameObject_Il2CppStructArray_1_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 130740, RefRangeEnd = 130742, XrefRangeStart = 130712, XrefRangeEnd = 130740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr move(GameObject gameObject, LTBezierPath to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) to);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_move_Public_Static_LTDescr_GameObject_LTBezierPath_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 130770, RefRangeEnd = 130772, XrefRangeStart = 130742, XrefRangeEnd = 130770, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr move(GameObject gameObject, LTSpline to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) to);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_move_Public_Static_LTDescr_GameObject_LTSpline_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 130804, RefRangeEnd = 130806, XrefRangeStart = 130772, XrefRangeEnd = 130804, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr moveSpline(
    GameObject gameObject,
    Il2CppStructArray<Vector3> to,
    float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) to);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_moveSpline_Public_Static_LTDescr_GameObject_Il2CppStructArray_1_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 130834, RefRangeEnd = 130836, XrefRangeStart = 130806, XrefRangeEnd = 130834, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr moveSpline(GameObject gameObject, LTSpline to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) to);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_moveSpline_Public_Static_LTDescr_GameObject_LTSpline_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 130868, RefRangeEnd = 130870, XrefRangeStart = 130836, XrefRangeEnd = 130868, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr moveSplineLocal(
    GameObject gameObject,
    Il2CppStructArray<Vector3> to,
    float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) to);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_moveSplineLocal_Public_Static_LTDescr_GameObject_Il2CppStructArray_1_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130870, XrefRangeEnd = 130878, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr move(LTRect ltRect, Vector2 to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) ltRect);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_move_Public_Static_LTDescr_LTRect_Vector2_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130878, XrefRangeEnd = 130886, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr moveMargin(LTRect ltRect, Vector2 to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) ltRect);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_moveMargin_Public_Static_LTDescr_LTRect_Vector2_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 130892, RefRangeEnd = 130894, XrefRangeStart = 130886, XrefRangeEnd = 130892, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr moveX(GameObject gameObject, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_moveX_Public_Static_LTDescr_GameObject_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 130900, RefRangeEnd = 130902, XrefRangeStart = 130894, XrefRangeEnd = 130900, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr moveY(GameObject gameObject, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_moveY_Public_Static_LTDescr_GameObject_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 130908, RefRangeEnd = 130910, XrefRangeStart = 130902, XrefRangeEnd = 130908, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr moveZ(GameObject gameObject, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_moveZ_Public_Static_LTDescr_GameObject_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(48)]
  [CachedScanResults(RefRangeStart = 130916, RefRangeEnd = 130964, XrefRangeStart = 130910, XrefRangeEnd = 130916, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr moveLocal(GameObject gameObject, Vector3 to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_moveLocal_Public_Static_LTDescr_GameObject_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130964, XrefRangeEnd = 131004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr moveLocal(
    GameObject gameObject,
    Il2CppStructArray<Vector3> to,
    float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) to);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_moveLocal_Public_Static_LTDescr_GameObject_Il2CppStructArray_1_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 131010, RefRangeEnd = 131014, XrefRangeStart = 131004, XrefRangeEnd = 131010, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr moveLocalX(GameObject gameObject, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_moveLocalX_Public_Static_LTDescr_GameObject_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 131020, RefRangeEnd = 131023, XrefRangeStart = 131014, XrefRangeEnd = 131020, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr moveLocalY(GameObject gameObject, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_moveLocalY_Public_Static_LTDescr_GameObject_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 131029, RefRangeEnd = 131031, XrefRangeStart = 131023, XrefRangeEnd = 131029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr moveLocalZ(GameObject gameObject, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_moveLocalZ_Public_Static_LTDescr_GameObject_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 131059, RefRangeEnd = 131061, XrefRangeStart = 131031, XrefRangeEnd = 131059, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr moveLocal(GameObject gameObject, LTBezierPath to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) to);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_moveLocal_Public_Static_LTDescr_GameObject_LTBezierPath_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 131089, RefRangeEnd = 131091, XrefRangeStart = 131061, XrefRangeEnd = 131089, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr moveLocal(GameObject gameObject, LTSpline to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) to);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_moveLocal_Public_Static_LTDescr_GameObject_LTSpline_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131091, XrefRangeEnd = 131100, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr move(GameObject gameObject, Transform to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) to);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_move_Public_Static_LTDescr_GameObject_Transform_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 131106, RefRangeEnd = 131109, XrefRangeStart = 131100, XrefRangeEnd = 131106, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr rotate(GameObject gameObject, Vector3 to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_rotate_Public_Static_LTDescr_GameObject_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131109, XrefRangeEnd = 131117, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr rotate(LTRect ltRect, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) ltRect);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_rotate_Public_Static_LTDescr_LTRect_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(25)]
  [CachedScanResults(RefRangeStart = 131123, RefRangeEnd = 131148, XrefRangeStart = 131117, XrefRangeEnd = 131123, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr rotateLocal(GameObject gameObject, Vector3 to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_rotateLocal_Public_Static_LTDescr_GameObject_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 131154, RefRangeEnd = 131156, XrefRangeStart = 131148, XrefRangeEnd = 131154, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr rotateX(GameObject gameObject, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_rotateX_Public_Static_LTDescr_GameObject_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 131162, RefRangeEnd = 131165, XrefRangeStart = 131156, XrefRangeEnd = 131162, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr rotateY(GameObject gameObject, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_rotateY_Public_Static_LTDescr_GameObject_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 131171, RefRangeEnd = 131175, XrefRangeStart = 131165, XrefRangeEnd = 131171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr rotateZ(GameObject gameObject, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_rotateZ_Public_Static_LTDescr_GameObject_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 131182, RefRangeEnd = 131184, XrefRangeStart = 131175, XrefRangeEnd = 131182, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr rotateAround(
    GameObject gameObject,
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
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_rotateAround_Public_Static_LTDescr_GameObject_Vector3_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 131191, RefRangeEnd = 131193, XrefRangeStart = 131184, XrefRangeEnd = 131191, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr rotateAroundLocal(
    GameObject gameObject,
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
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_rotateAroundLocal_Public_Static_LTDescr_GameObject_Vector3_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(76)]
  [CachedScanResults(RefRangeStart = 131199, RefRangeEnd = 131275, XrefRangeStart = 131193, XrefRangeEnd = 131199, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr scale(GameObject gameObject, Vector3 to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_scale_Public_Static_LTDescr_GameObject_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131275, XrefRangeEnd = 131283, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr scale(LTRect ltRect, Vector2 to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) ltRect);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_scale_Public_Static_LTDescr_LTRect_Vector2_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 131289, RefRangeEnd = 131291, XrefRangeStart = 131283, XrefRangeEnd = 131289, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr scaleX(GameObject gameObject, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_scaleX_Public_Static_LTDescr_GameObject_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 131297, RefRangeEnd = 131301, XrefRangeStart = 131291, XrefRangeEnd = 131297, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr scaleY(GameObject gameObject, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_scaleY_Public_Static_LTDescr_GameObject_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 131307, RefRangeEnd = 131309, XrefRangeStart = 131301, XrefRangeEnd = 131307, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr scaleZ(GameObject gameObject, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_scaleZ_Public_Static_LTDescr_GameObject_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(30)]
  [CachedScanResults(RefRangeStart = 131316, RefRangeEnd = 131346, XrefRangeStart = 131309, XrefRangeEnd = 131316, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr value(GameObject gameObject, float from, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &from;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 131354, RefRangeEnd = 131359, XrefRangeStart = 131346, XrefRangeEnd = 131354, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr value(float from, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &from;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_value_Public_Static_LTDescr_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 131367, RefRangeEnd = 131370, XrefRangeStart = 131359, XrefRangeEnd = 131367, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr value(GameObject gameObject, Vector2 from, Vector2 to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &from;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Vector2_Vector2_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 131377, RefRangeEnd = 131378, XrefRangeStart = 131370, XrefRangeEnd = 131377, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr value(GameObject gameObject, Vector3 from, Vector3 to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &from;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Vector3_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 131391, RefRangeEnd = 131392, XrefRangeStart = 131378, XrefRangeEnd = 131391, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr value(GameObject gameObject, Color from, Color to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &from;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Color_Color_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 131401, RefRangeEnd = 131402, XrefRangeStart = 131392, XrefRangeEnd = 131401, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr value(
    GameObject gameObject,
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
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_1_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 131411, RefRangeEnd = 131412, XrefRangeStart = 131402, XrefRangeEnd = 131411, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr value(
    GameObject gameObject,
    Il2CppSystem.Action<float, float> callOnUpdateRatio,
    float from,
    float to,
    float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callOnUpdateRatio);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &from;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_2_Single_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 131423, RefRangeEnd = 131424, XrefRangeStart = 131412, XrefRangeEnd = 131423, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr value(
    GameObject gameObject,
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
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_1_Color_Color_Color_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131424, XrefRangeEnd = 131435, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr value(
    GameObject gameObject,
    Il2CppSystem.Action<Color, Il2CppSystem.Object> callOnUpdate,
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
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_2_Color_Object_Color_Color_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 131444, RefRangeEnd = 131445, XrefRangeStart = 131435, XrefRangeEnd = 131444, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr value(
    GameObject gameObject,
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
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_1_Vector2_Vector2_Vector2_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 131454, RefRangeEnd = 131455, XrefRangeStart = 131445, XrefRangeEnd = 131454, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr value(
    GameObject gameObject,
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
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_1_Vector3_Vector3_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 131464, RefRangeEnd = 131465, XrefRangeStart = 131455, XrefRangeEnd = 131464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr value(
    GameObject gameObject,
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
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_2_Single_Object_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131465, XrefRangeEnd = 131475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr delayedSound(AudioClip audio, Vector3 pos, float volume)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) audio);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &volume;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_delayedSound_Public_Static_LTDescr_AudioClip_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131475, XrefRangeEnd = 131484, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr delayedSound(
    GameObject gameObject,
    AudioClip audio,
    Vector3 pos,
    float volume)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) audio);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &pos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &volume;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_delayedSound_Public_Static_LTDescr_GameObject_AudioClip_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 131492, RefRangeEnd = 131499, XrefRangeStart = 131484, XrefRangeEnd = 131492, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr move(RectTransform rectTrans, Vector3 to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rectTrans);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_move_Public_Static_LTDescr_RectTransform_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 131507, RefRangeEnd = 131508, XrefRangeStart = 131499, XrefRangeEnd = 131507, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr moveX(RectTransform rectTrans, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rectTrans);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_moveX_Public_Static_LTDescr_RectTransform_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 131516, RefRangeEnd = 131517, XrefRangeStart = 131508, XrefRangeEnd = 131516, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr moveY(RectTransform rectTrans, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rectTrans);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_moveY_Public_Static_LTDescr_RectTransform_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 131525, RefRangeEnd = 131526, XrefRangeStart = 131517, XrefRangeEnd = 131525, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr moveZ(RectTransform rectTrans, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rectTrans);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_moveZ_Public_Static_LTDescr_RectTransform_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131526, XrefRangeEnd = 131537, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr rotate(RectTransform rectTrans, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rectTrans);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_rotate_Public_Static_LTDescr_RectTransform_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 131548, RefRangeEnd = 131549, XrefRangeStart = 131537, XrefRangeEnd = 131548, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr rotate(RectTransform rectTrans, Vector3 to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rectTrans);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_rotate_Public_Static_LTDescr_RectTransform_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 131558, RefRangeEnd = 131559, XrefRangeStart = 131549, XrefRangeEnd = 131558, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr rotateAround(
    RectTransform rectTrans,
    Vector3 axis,
    float to,
    float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rectTrans);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &axis;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_rotateAround_Public_Static_LTDescr_RectTransform_Vector3_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 131568, RefRangeEnd = 131569, XrefRangeStart = 131559, XrefRangeEnd = 131568, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr rotateAroundLocal(
    RectTransform rectTrans,
    Vector3 axis,
    float to,
    float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rectTrans);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &axis;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_rotateAroundLocal_Public_Static_LTDescr_RectTransform_Vector3_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 131577, RefRangeEnd = 131578, XrefRangeStart = 131569, XrefRangeEnd = 131577, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr scale(RectTransform rectTrans, Vector3 to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rectTrans);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_scale_Public_Static_LTDescr_RectTransform_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 131586, RefRangeEnd = 131587, XrefRangeStart = 131578, XrefRangeEnd = 131586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr size(RectTransform rectTrans, Vector2 to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rectTrans);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_size_Public_Static_LTDescr_RectTransform_Vector2_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 131595, RefRangeEnd = 131596, XrefRangeStart = 131587, XrefRangeEnd = 131595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr alpha(RectTransform rectTrans, float to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rectTrans);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_alpha_Public_Static_LTDescr_RectTransform_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131596, XrefRangeEnd = 131605, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr color(RectTransform rectTrans, Color to, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rectTrans);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_color_Public_Static_LTDescr_RectTransform_Color_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131605, XrefRangeEnd = 131606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float tweenOnCurve(LTDescr tweenDescr, float ratioPassed)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) tweenDescr);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &ratioPassed;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_tweenOnCurve_Public_Static_Single_LTDescr_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131606, XrefRangeEnd = 131609, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 tweenOnCurveVector(LTDescr tweenDescr, float ratioPassed)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) tweenDescr);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &ratioPassed;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_tweenOnCurveVector_Public_Static_Vector3_LTDescr_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe float easeOutQuadOpt(float start, float diff, float ratioPassed)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &diff;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &ratioPassed;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeOutQuadOpt_Public_Static_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe float easeInQuadOpt(float start, float diff, float ratioPassed)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &diff;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &ratioPassed;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeInQuadOpt_Public_Static_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe float easeInOutQuadOpt(float start, float diff, float ratioPassed)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &diff;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &ratioPassed;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeInOutQuadOpt_Public_Static_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131609, XrefRangeEnd = 131610, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 easeInOutQuadOpt(Vector3 start, Vector3 diff, float ratioPassed)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &diff;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &ratioPassed;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeInOutQuadOpt_Public_Static_Vector3_Vector3_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 131610, RefRangeEnd = 131611, XrefRangeStart = 131610, XrefRangeEnd = 131610, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float linear(float start, float end, float val)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &val;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_linear_Public_Static_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe float clerp(float start, float end, float val)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &val;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_clerp_Public_Static_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131611, XrefRangeEnd = 131614, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float spring(float start, float end, float val)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &val;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_spring_Public_Static_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe float easeInQuad(float start, float end, float val)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &val;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeInQuad_Public_Static_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe float easeOutQuad(float start, float end, float val)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &val;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeOutQuad_Public_Static_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe float easeInOutQuad(float start, float end, float val)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &val;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeInOutQuad_Public_Static_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe float easeInOutQuadOpt2(float start, float diffBy2, float val, float val2)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &diffBy2;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &val;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &val2;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeInOutQuadOpt2_Public_Static_Single_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe float easeInCubic(float start, float end, float val)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &val;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeInCubic_Public_Static_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe float easeOutCubic(float start, float end, float val)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &val;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeOutCubic_Public_Static_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe float easeInOutCubic(float start, float end, float val)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &val;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeInOutCubic_Public_Static_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe float easeInQuart(float start, float end, float val)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &val;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeInQuart_Public_Static_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe float easeOutQuart(float start, float end, float val)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &val;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeOutQuart_Public_Static_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe float easeInOutQuart(float start, float end, float val)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &val;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeInOutQuart_Public_Static_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe float easeInQuint(float start, float end, float val)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &val;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeInQuint_Public_Static_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe float easeOutQuint(float start, float end, float val)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &val;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeOutQuint_Public_Static_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe float easeInOutQuint(float start, float end, float val)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &val;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeInOutQuint_Public_Static_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131614, XrefRangeEnd = 131615, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float easeInSine(float start, float end, float val)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &val;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeInSine_Public_Static_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131615, XrefRangeEnd = 131616, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float easeOutSine(float start, float end, float val)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &val;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeOutSine_Public_Static_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131616, XrefRangeEnd = 131617, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float easeInOutSine(float start, float end, float val)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &val;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeInOutSine_Public_Static_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131617, XrefRangeEnd = 131618, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float easeInExpo(float start, float end, float val)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &val;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeInExpo_Public_Static_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131618, XrefRangeEnd = 131619, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float easeOutExpo(float start, float end, float val)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &val;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeOutExpo_Public_Static_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131619, XrefRangeEnd = 131622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float easeInOutExpo(float start, float end, float val)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &val;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeInOutExpo_Public_Static_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131622, XrefRangeEnd = 131624, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float easeInCirc(float start, float end, float val)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &val;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeInCirc_Public_Static_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131624, XrefRangeEnd = 131626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float easeOutCirc(float start, float end, float val)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &val;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeOutCirc_Public_Static_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131626, XrefRangeEnd = 131631, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float easeInOutCirc(float start, float end, float val)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &val;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeInOutCirc_Public_Static_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 131635, RefRangeEnd = 131638, XrefRangeStart = 131631, XrefRangeEnd = 131635, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float easeInBounce(float start, float end, float val)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &val;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeInBounce_Public_Static_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(9)]
  [CachedScanResults(RefRangeStart = 131638, RefRangeEnd = 131647, XrefRangeStart = 131638, XrefRangeEnd = 131638, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float easeOutBounce(float start, float end, float val)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &val;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeOutBounce_Public_Static_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131647, XrefRangeEnd = 131657, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float easeInOutBounce(float start, float end, float val)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &val;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeInOutBounce_Public_Static_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe float easeInBack(float start, float end, float val, float overshoot = 1f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &val;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &overshoot;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeInBack_Public_Static_Single_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe float easeOutBack(float start, float end, float val, float overshoot = 1f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &val;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &overshoot;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeOutBack_Public_Static_Single_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe float easeInOutBack(float start, float end, float val, float overshoot = 1f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &val;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &overshoot;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeInOutBack_Public_Static_Single_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 131660, RefRangeEnd = 131663, XrefRangeStart = 131657, XrefRangeEnd = 131660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float easeInElastic(
    float start,
    float end,
    float val,
    float overshoot = 1f,
    float period = 0.3f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &val;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &overshoot;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &period;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeInElastic_Public_Static_Single_Single_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 131666, RefRangeEnd = 131669, XrefRangeStart = 131663, XrefRangeEnd = 131666, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float easeOutElastic(
    float start,
    float end,
    float val,
    float overshoot = 1f,
    float period = 0.3f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &val;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &overshoot;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &period;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeOutElastic_Public_Static_Single_Single_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 131676, RefRangeEnd = 131679, XrefRangeStart = 131669, XrefRangeEnd = 131676, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float easeInOutElastic(
    float start,
    float end,
    float val,
    float overshoot = 1f,
    float period = 0.3f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &val;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &overshoot;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &period;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeInOutElastic_Public_Static_Single_Single_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131679, XrefRangeEnd = 131748, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr followDamp(
    Transform trans,
    Transform target,
    LeanProp prop,
    float smoothTime,
    float maxSpeed = -1f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) trans);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &prop;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &smoothTime;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &maxSpeed;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_followDamp_Public_Static_LTDescr_Transform_Transform_LeanProp_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131748, XrefRangeEnd = 131817, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr followSpring(
    Transform trans,
    Transform target,
    LeanProp prop,
    float smoothTime,
    float maxSpeed = -1f,
    float friction = 2f,
    float accelRate = 0.5f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[7];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) trans);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &prop;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &smoothTime;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &maxSpeed;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &friction;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &accelRate;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_followSpring_Public_Static_LTDescr_Transform_Transform_LeanProp_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131817, XrefRangeEnd = 131885, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr followBounceOut(
    Transform trans,
    Transform target,
    LeanProp prop,
    float smoothTime,
    float maxSpeed = -1f,
    float friction = 2f,
    float accelRate = 0.5f,
    float hitDamping = 0.9f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[8];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) trans);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &prop;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &smoothTime;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &maxSpeed;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &friction;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &accelRate;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &hitDamping;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_followBounceOut_Public_Static_LTDescr_Transform_Transform_LeanProp_Single_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131885, XrefRangeEnd = 131953, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LTDescr followLinear(
    Transform trans,
    Transform target,
    LeanProp prop,
    float moveSpeed)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) trans);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &prop;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &moveSpeed;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_followLinear_Public_Static_LTDescr_Transform_Transform_LeanProp_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131953, XrefRangeEnd = 131958, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void addListener(int eventId, Il2CppSystem.Action<LTEvent> callback)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &eventId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_addListener_Public_Static_Void_Int32_Action_1_LTEvent_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 132027, RefRangeEnd = 132028, XrefRangeStart = 131958, XrefRangeEnd = 132027, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void addListener(GameObject caller, int eventId, Il2CppSystem.Action<LTEvent> callback)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) caller);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &eventId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_addListener_Public_Static_Void_GameObject_Int32_Action_1_LTEvent_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132028, XrefRangeEnd = 132033, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool removeListener(int eventId, Il2CppSystem.Action<LTEvent> callback)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &eventId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_removeListener_Public_Static_Boolean_Int32_Action_1_LTEvent_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132033, XrefRangeEnd = 132040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool removeListener(int eventId)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &eventId
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_removeListener_Public_Static_Boolean_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 132068, RefRangeEnd = 132069, XrefRangeStart = 132040, XrefRangeEnd = 132068, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool removeListener(
    GameObject caller,
    int eventId,
    Il2CppSystem.Action<LTEvent> callback)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) caller);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &eventId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_removeListener_Public_Static_Boolean_GameObject_Int32_Action_1_LTEvent_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132069, XrefRangeEnd = 132073, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void dispatchEvent(int eventId)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &eventId
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_dispatchEvent_Public_Static_Void_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 132099, RefRangeEnd = 132100, XrefRangeStart = 132073, XrefRangeEnd = 132099, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void dispatchEvent(int eventId, Il2CppSystem.Object data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &eventId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_dispatchEvent_Public_Static_Void_Int32_Object_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LeanTween()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeanTween>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static LeanTween()
  {
    Il2CppClassPointerStore<LeanTween>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (LeanTween));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeanTween>.NativeClassPtr);
    LeanTween.NativeFieldInfoPtr_throwErrors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, nameof (throwErrors));
    LeanTween.NativeFieldInfoPtr_tau = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, nameof (tau));
    LeanTween.NativeFieldInfoPtr_PI_DIV2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, nameof (PI_DIV2));
    LeanTween.NativeFieldInfoPtr_sequences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, nameof (sequences));
    LeanTween.NativeFieldInfoPtr_tweens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, nameof (tweens));
    LeanTween.NativeFieldInfoPtr_tweensFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, nameof (tweensFinished));
    LeanTween.NativeFieldInfoPtr_tweensFinishedIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, nameof (tweensFinishedIds));
    LeanTween.NativeFieldInfoPtr_tween = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, nameof (tween));
    LeanTween.NativeFieldInfoPtr_tweenMaxSearch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, nameof (tweenMaxSearch));
    LeanTween.NativeFieldInfoPtr_maxTweens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, nameof (maxTweens));
    LeanTween.NativeFieldInfoPtr_maxSequences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, nameof (maxSequences));
    LeanTween.NativeFieldInfoPtr_frameRendered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, nameof (frameRendered));
    LeanTween.NativeFieldInfoPtr__tweenEmpty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, nameof (_tweenEmpty));
    LeanTween.NativeFieldInfoPtr_dtEstimated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, nameof (dtEstimated));
    LeanTween.NativeFieldInfoPtr_dtManual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, nameof (dtManual));
    LeanTween.NativeFieldInfoPtr_dtActual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, nameof (dtActual));
    LeanTween.NativeFieldInfoPtr_global_counter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, nameof (global_counter));
    LeanTween.NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, nameof (i));
    LeanTween.NativeFieldInfoPtr_j = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, nameof (j));
    LeanTween.NativeFieldInfoPtr_finishedCnt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, nameof (finishedCnt));
    LeanTween.NativeFieldInfoPtr_punch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, nameof (punch));
    LeanTween.NativeFieldInfoPtr_shake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, nameof (shake));
    LeanTween.NativeFieldInfoPtr_maxTweenReached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, nameof (maxTweenReached));
    LeanTween.NativeFieldInfoPtr_startSearch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, nameof (startSearch));
    LeanTween.NativeFieldInfoPtr_d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, nameof (d));
    LeanTween.NativeFieldInfoPtr_eventListeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, nameof (eventListeners));
    LeanTween.NativeFieldInfoPtr_goListeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, nameof (goListeners));
    LeanTween.NativeFieldInfoPtr_eventsMaxSearch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, nameof (eventsMaxSearch));
    LeanTween.NativeFieldInfoPtr_EVENTS_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, nameof (EVENTS_MAX));
    LeanTween.NativeFieldInfoPtr_LISTENERS_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, nameof (LISTENERS_MAX));
    LeanTween.NativeFieldInfoPtr_INIT_LISTENERS_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, nameof (INIT_LISTENERS_MAX));
    LeanTween.NativeMethodInfoPtr_init_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676638);
    LeanTween.NativeMethodInfoPtr_get_maxSearch_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676639);
    LeanTween.NativeMethodInfoPtr_get_maxSimulataneousTweens_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676640);
    LeanTween.NativeMethodInfoPtr_get_tweensRunning_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676641);
    LeanTween.NativeMethodInfoPtr_init_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676642);
    LeanTween.NativeMethodInfoPtr_init_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676643);
    LeanTween.NativeMethodInfoPtr_reset_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676644);
    LeanTween.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676645);
    LeanTween.NativeMethodInfoPtr_onLevelWasLoaded54_Private_Static_Void_Scene_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676646);
    LeanTween.NativeMethodInfoPtr_internalOnLevelWasLoaded_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676647);
    LeanTween.NativeMethodInfoPtr_update_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676648);
    LeanTween.NativeMethodInfoPtr_removeTween_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676649);
    LeanTween.NativeMethodInfoPtr_removeTween_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676650);
    LeanTween.NativeMethodInfoPtr_add_Public_Static_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676651);
    LeanTween.NativeMethodInfoPtr_closestRot_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676652);
    LeanTween.NativeMethodInfoPtr_cancelAll_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676653);
    LeanTween.NativeMethodInfoPtr_cancelAll_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676654);
    LeanTween.NativeMethodInfoPtr_cancel_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676655);
    LeanTween.NativeMethodInfoPtr_cancel_Public_Static_Void_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676656);
    LeanTween.NativeMethodInfoPtr_cancel_Public_Static_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676657);
    LeanTween.NativeMethodInfoPtr_cancel_Public_Static_Void_GameObject_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676658);
    LeanTween.NativeMethodInfoPtr_cancel_Public_Static_Void_LTRect_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676659);
    LeanTween.NativeMethodInfoPtr_cancel_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676660);
    LeanTween.NativeMethodInfoPtr_cancel_Public_Static_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676661);
    LeanTween.NativeMethodInfoPtr_descr_Public_Static_LTDescr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676662);
    LeanTween.NativeMethodInfoPtr_description_Public_Static_LTDescr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676663);
    LeanTween.NativeMethodInfoPtr_descriptions_Public_Static_Il2CppReferenceArray_1_LTDescr_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676664);
    LeanTween.NativeMethodInfoPtr_pause_Public_Static_Void_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676665);
    LeanTween.NativeMethodInfoPtr_pause_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676666);
    LeanTween.NativeMethodInfoPtr_pause_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676667);
    LeanTween.NativeMethodInfoPtr_pauseAll_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676668);
    LeanTween.NativeMethodInfoPtr_resumeAll_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676669);
    LeanTween.NativeMethodInfoPtr_resume_Public_Static_Void_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676670);
    LeanTween.NativeMethodInfoPtr_resume_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676671);
    LeanTween.NativeMethodInfoPtr_resume_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676672);
    LeanTween.NativeMethodInfoPtr_isPaused_Public_Static_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676673);
    LeanTween.NativeMethodInfoPtr_isPaused_Public_Static_Boolean_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676674);
    LeanTween.NativeMethodInfoPtr_isPaused_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676675);
    LeanTween.NativeMethodInfoPtr_isTweening_Public_Static_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676676);
    LeanTween.NativeMethodInfoPtr_isTweening_Public_Static_Boolean_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676677);
    LeanTween.NativeMethodInfoPtr_isTweening_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676678);
    LeanTween.NativeMethodInfoPtr_isTweening_Public_Static_Boolean_LTRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676679);
    LeanTween.NativeMethodInfoPtr_drawBezierPath_Public_Static_Void_Vector3_Vector3_Vector3_Vector3_Single_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676680);
    LeanTween.NativeMethodInfoPtr_logError_Public_Static_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676681);
    LeanTween.NativeMethodInfoPtr_options_Public_Static_LTDescr_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676682);
    LeanTween.NativeMethodInfoPtr_options_Public_Static_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676683);
    LeanTween.NativeMethodInfoPtr_get_tweenEmpty_Public_Static_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676684);
    LeanTween.NativeMethodInfoPtr_pushNewTween_Private_Static_LTDescr_GameObject_Vector3_Single_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676685);
    LeanTween.NativeMethodInfoPtr_play_Public_Static_LTDescr_RectTransform_Il2CppReferenceArray_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676686);
    LeanTween.NativeMethodInfoPtr_sequence_Public_Static_LTSeq_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676687);
    LeanTween.NativeMethodInfoPtr_alpha_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676688);
    LeanTween.NativeMethodInfoPtr_alpha_Public_Static_LTDescr_LTRect_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676689);
    LeanTween.NativeMethodInfoPtr_textAlpha_Public_Static_LTDescr_RectTransform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676690);
    LeanTween.NativeMethodInfoPtr_alphaText_Public_Static_LTDescr_RectTransform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676691);
    LeanTween.NativeMethodInfoPtr_alphaCanvas_Public_Static_LTDescr_CanvasGroup_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676692);
    LeanTween.NativeMethodInfoPtr_alphaVertex_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676693);
    LeanTween.NativeMethodInfoPtr_color_Public_Static_LTDescr_GameObject_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676694);
    LeanTween.NativeMethodInfoPtr_textColor_Public_Static_LTDescr_RectTransform_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676695);
    LeanTween.NativeMethodInfoPtr_colorText_Public_Static_LTDescr_RectTransform_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676696);
    LeanTween.NativeMethodInfoPtr_delayedCall_Public_Static_LTDescr_Single_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676697);
    LeanTween.NativeMethodInfoPtr_delayedCall_Public_Static_LTDescr_Single_Action_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676698);
    LeanTween.NativeMethodInfoPtr_delayedCall_Public_Static_LTDescr_GameObject_Single_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676699);
    LeanTween.NativeMethodInfoPtr_delayedCall_Public_Static_LTDescr_GameObject_Single_Action_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676700);
    LeanTween.NativeMethodInfoPtr_destroyAfter_Public_Static_LTDescr_LTRect_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676701);
    LeanTween.NativeMethodInfoPtr_move_Public_Static_LTDescr_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676702);
    LeanTween.NativeMethodInfoPtr_move_Public_Static_LTDescr_GameObject_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676703);
    LeanTween.NativeMethodInfoPtr_move_Public_Static_LTDescr_GameObject_Il2CppStructArray_1_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676704);
    LeanTween.NativeMethodInfoPtr_move_Public_Static_LTDescr_GameObject_LTBezierPath_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676705);
    LeanTween.NativeMethodInfoPtr_move_Public_Static_LTDescr_GameObject_LTSpline_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676706);
    LeanTween.NativeMethodInfoPtr_moveSpline_Public_Static_LTDescr_GameObject_Il2CppStructArray_1_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676707);
    LeanTween.NativeMethodInfoPtr_moveSpline_Public_Static_LTDescr_GameObject_LTSpline_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676708);
    LeanTween.NativeMethodInfoPtr_moveSplineLocal_Public_Static_LTDescr_GameObject_Il2CppStructArray_1_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676709);
    LeanTween.NativeMethodInfoPtr_move_Public_Static_LTDescr_LTRect_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676710);
    LeanTween.NativeMethodInfoPtr_moveMargin_Public_Static_LTDescr_LTRect_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676711);
    LeanTween.NativeMethodInfoPtr_moveX_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676712);
    LeanTween.NativeMethodInfoPtr_moveY_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676713);
    LeanTween.NativeMethodInfoPtr_moveZ_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676714);
    LeanTween.NativeMethodInfoPtr_moveLocal_Public_Static_LTDescr_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676715);
    LeanTween.NativeMethodInfoPtr_moveLocal_Public_Static_LTDescr_GameObject_Il2CppStructArray_1_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676716);
    LeanTween.NativeMethodInfoPtr_moveLocalX_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676717);
    LeanTween.NativeMethodInfoPtr_moveLocalY_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676718);
    LeanTween.NativeMethodInfoPtr_moveLocalZ_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676719);
    LeanTween.NativeMethodInfoPtr_moveLocal_Public_Static_LTDescr_GameObject_LTBezierPath_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676720);
    LeanTween.NativeMethodInfoPtr_moveLocal_Public_Static_LTDescr_GameObject_LTSpline_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676721);
    LeanTween.NativeMethodInfoPtr_move_Public_Static_LTDescr_GameObject_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676722);
    LeanTween.NativeMethodInfoPtr_rotate_Public_Static_LTDescr_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676723);
    LeanTween.NativeMethodInfoPtr_rotate_Public_Static_LTDescr_LTRect_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676724);
    LeanTween.NativeMethodInfoPtr_rotateLocal_Public_Static_LTDescr_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676725);
    LeanTween.NativeMethodInfoPtr_rotateX_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676726);
    LeanTween.NativeMethodInfoPtr_rotateY_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676727);
    LeanTween.NativeMethodInfoPtr_rotateZ_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676728);
    LeanTween.NativeMethodInfoPtr_rotateAround_Public_Static_LTDescr_GameObject_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676729);
    LeanTween.NativeMethodInfoPtr_rotateAroundLocal_Public_Static_LTDescr_GameObject_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676730);
    LeanTween.NativeMethodInfoPtr_scale_Public_Static_LTDescr_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676731);
    LeanTween.NativeMethodInfoPtr_scale_Public_Static_LTDescr_LTRect_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676732);
    LeanTween.NativeMethodInfoPtr_scaleX_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676733);
    LeanTween.NativeMethodInfoPtr_scaleY_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676734);
    LeanTween.NativeMethodInfoPtr_scaleZ_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676735);
    LeanTween.NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676736);
    LeanTween.NativeMethodInfoPtr_value_Public_Static_LTDescr_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676737);
    LeanTween.NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676738);
    LeanTween.NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676739);
    LeanTween.NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676740);
    LeanTween.NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_1_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676741);
    LeanTween.NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_2_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676742);
    LeanTween.NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_1_Color_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676743);
    LeanTween.NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_2_Color_Object_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676744);
    LeanTween.NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_1_Vector2_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676745);
    LeanTween.NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_1_Vector3_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676746);
    LeanTween.NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_2_Single_Object_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676747);
    LeanTween.NativeMethodInfoPtr_delayedSound_Public_Static_LTDescr_AudioClip_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676748);
    LeanTween.NativeMethodInfoPtr_delayedSound_Public_Static_LTDescr_GameObject_AudioClip_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676749);
    LeanTween.NativeMethodInfoPtr_move_Public_Static_LTDescr_RectTransform_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676750);
    LeanTween.NativeMethodInfoPtr_moveX_Public_Static_LTDescr_RectTransform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676751);
    LeanTween.NativeMethodInfoPtr_moveY_Public_Static_LTDescr_RectTransform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676752);
    LeanTween.NativeMethodInfoPtr_moveZ_Public_Static_LTDescr_RectTransform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676753);
    LeanTween.NativeMethodInfoPtr_rotate_Public_Static_LTDescr_RectTransform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676754);
    LeanTween.NativeMethodInfoPtr_rotate_Public_Static_LTDescr_RectTransform_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676755);
    LeanTween.NativeMethodInfoPtr_rotateAround_Public_Static_LTDescr_RectTransform_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676756);
    LeanTween.NativeMethodInfoPtr_rotateAroundLocal_Public_Static_LTDescr_RectTransform_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676757);
    LeanTween.NativeMethodInfoPtr_scale_Public_Static_LTDescr_RectTransform_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676758);
    LeanTween.NativeMethodInfoPtr_size_Public_Static_LTDescr_RectTransform_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676759);
    LeanTween.NativeMethodInfoPtr_alpha_Public_Static_LTDescr_RectTransform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676760);
    LeanTween.NativeMethodInfoPtr_color_Public_Static_LTDescr_RectTransform_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676761);
    LeanTween.NativeMethodInfoPtr_tweenOnCurve_Public_Static_Single_LTDescr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676762);
    LeanTween.NativeMethodInfoPtr_tweenOnCurveVector_Public_Static_Vector3_LTDescr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676763);
    LeanTween.NativeMethodInfoPtr_easeOutQuadOpt_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676764);
    LeanTween.NativeMethodInfoPtr_easeInQuadOpt_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676765);
    LeanTween.NativeMethodInfoPtr_easeInOutQuadOpt_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676766);
    LeanTween.NativeMethodInfoPtr_easeInOutQuadOpt_Public_Static_Vector3_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676767);
    LeanTween.NativeMethodInfoPtr_linear_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676768);
    LeanTween.NativeMethodInfoPtr_clerp_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676769);
    LeanTween.NativeMethodInfoPtr_spring_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676770);
    LeanTween.NativeMethodInfoPtr_easeInQuad_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676771);
    LeanTween.NativeMethodInfoPtr_easeOutQuad_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676772);
    LeanTween.NativeMethodInfoPtr_easeInOutQuad_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676773);
    LeanTween.NativeMethodInfoPtr_easeInOutQuadOpt2_Public_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676774);
    LeanTween.NativeMethodInfoPtr_easeInCubic_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676775);
    LeanTween.NativeMethodInfoPtr_easeOutCubic_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676776);
    LeanTween.NativeMethodInfoPtr_easeInOutCubic_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676777);
    LeanTween.NativeMethodInfoPtr_easeInQuart_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676778);
    LeanTween.NativeMethodInfoPtr_easeOutQuart_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676779);
    LeanTween.NativeMethodInfoPtr_easeInOutQuart_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676780);
    LeanTween.NativeMethodInfoPtr_easeInQuint_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676781);
    LeanTween.NativeMethodInfoPtr_easeOutQuint_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676782);
    LeanTween.NativeMethodInfoPtr_easeInOutQuint_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676783);
    LeanTween.NativeMethodInfoPtr_easeInSine_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676784);
    LeanTween.NativeMethodInfoPtr_easeOutSine_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676785);
    LeanTween.NativeMethodInfoPtr_easeInOutSine_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676786);
    LeanTween.NativeMethodInfoPtr_easeInExpo_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676787);
    LeanTween.NativeMethodInfoPtr_easeOutExpo_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676788);
    LeanTween.NativeMethodInfoPtr_easeInOutExpo_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676789);
    LeanTween.NativeMethodInfoPtr_easeInCirc_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676790);
    LeanTween.NativeMethodInfoPtr_easeOutCirc_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676791);
    LeanTween.NativeMethodInfoPtr_easeInOutCirc_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676792);
    LeanTween.NativeMethodInfoPtr_easeInBounce_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676793);
    LeanTween.NativeMethodInfoPtr_easeOutBounce_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676794);
    LeanTween.NativeMethodInfoPtr_easeInOutBounce_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676795);
    LeanTween.NativeMethodInfoPtr_easeInBack_Public_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676796);
    LeanTween.NativeMethodInfoPtr_easeOutBack_Public_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676797);
    LeanTween.NativeMethodInfoPtr_easeInOutBack_Public_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676798);
    LeanTween.NativeMethodInfoPtr_easeInElastic_Public_Static_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676799);
    LeanTween.NativeMethodInfoPtr_easeOutElastic_Public_Static_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676800);
    LeanTween.NativeMethodInfoPtr_easeInOutElastic_Public_Static_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676801);
    LeanTween.NativeMethodInfoPtr_followDamp_Public_Static_LTDescr_Transform_Transform_LeanProp_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676802);
    LeanTween.NativeMethodInfoPtr_followSpring_Public_Static_LTDescr_Transform_Transform_LeanProp_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676803);
    LeanTween.NativeMethodInfoPtr_followBounceOut_Public_Static_LTDescr_Transform_Transform_LeanProp_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676804);
    LeanTween.NativeMethodInfoPtr_followLinear_Public_Static_LTDescr_Transform_Transform_LeanProp_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676805);
    LeanTween.NativeMethodInfoPtr_addListener_Public_Static_Void_Int32_Action_1_LTEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676806);
    LeanTween.NativeMethodInfoPtr_addListener_Public_Static_Void_GameObject_Int32_Action_1_LTEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676807);
    LeanTween.NativeMethodInfoPtr_removeListener_Public_Static_Boolean_Int32_Action_1_LTEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676808);
    LeanTween.NativeMethodInfoPtr_removeListener_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676809);
    LeanTween.NativeMethodInfoPtr_removeListener_Public_Static_Boolean_GameObject_Int32_Action_1_LTEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676810);
    LeanTween.NativeMethodInfoPtr_dispatchEvent_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676811);
    LeanTween.NativeMethodInfoPtr_dispatchEvent_Public_Static_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676812);
    LeanTween.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100676813);
  }

  public LeanTween(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe bool throwErrors
  {
    get
    {
      bool throwErrors;
      IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_throwErrors, (void*) &throwErrors);
      return throwErrors;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_throwErrors, (void*) &value);
    }
  }

  public static unsafe float tau
  {
    get
    {
      float tau;
      IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_tau, (void*) &tau);
      return tau;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_tau, (void*) &value);
    }
  }

  public static unsafe float PI_DIV2
  {
    get
    {
      float piDiV2;
      IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_PI_DIV2, (void*) &piDiV2);
      return piDiV2;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_PI_DIV2, (void*) &value);
    }
  }

  public static unsafe Il2CppReferenceArray<LTSeq> sequences
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_sequences, (void*) &num);
      System.IntPtr nativeObject = num;
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<LTSeq>) null : new Il2CppReferenceArray<LTSeq>(nativeObject);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_sequences, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Il2CppReferenceArray<LTDescr> tweens
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_tweens, (void*) &num);
      System.IntPtr nativeObject = num;
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<LTDescr>) null : new Il2CppReferenceArray<LTDescr>(nativeObject);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_tweens, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Il2CppStructArray<int> tweensFinished
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_tweensFinished, (void*) &num);
      System.IntPtr nativeObject = num;
      return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<int>) null : new Il2CppStructArray<int>(nativeObject);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_tweensFinished, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Il2CppStructArray<int> tweensFinishedIds
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_tweensFinishedIds, (void*) &num);
      System.IntPtr nativeObject = num;
      return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<int>) null : new Il2CppStructArray<int>(nativeObject);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_tweensFinishedIds, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe LTDescr tween
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_tween, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_tween, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe int tweenMaxSearch
  {
    get
    {
      int tweenMaxSearch;
      IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_tweenMaxSearch, (void*) &tweenMaxSearch);
      return tweenMaxSearch;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_tweenMaxSearch, (void*) &value);
    }
  }

  public static unsafe int maxTweens
  {
    get
    {
      int maxTweens;
      IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_maxTweens, (void*) &maxTweens);
      return maxTweens;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_maxTweens, (void*) &value);
    }
  }

  public static unsafe int maxSequences
  {
    get
    {
      int maxSequences;
      IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_maxSequences, (void*) &maxSequences);
      return maxSequences;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_maxSequences, (void*) &value);
    }
  }

  public static unsafe int frameRendered
  {
    get
    {
      int frameRendered;
      IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_frameRendered, (void*) &frameRendered);
      return frameRendered;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_frameRendered, (void*) &value);
    }
  }

  public static unsafe GameObject _tweenEmpty
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr__tweenEmpty, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr__tweenEmpty, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe float dtEstimated
  {
    get
    {
      float dtEstimated;
      IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_dtEstimated, (void*) &dtEstimated);
      return dtEstimated;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_dtEstimated, (void*) &value);
    }
  }

  public static unsafe float dtManual
  {
    get
    {
      float dtManual;
      IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_dtManual, (void*) &dtManual);
      return dtManual;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_dtManual, (void*) &value);
    }
  }

  public static unsafe float dtActual
  {
    get
    {
      float dtActual;
      IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_dtActual, (void*) &dtActual);
      return dtActual;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_dtActual, (void*) &value);
    }
  }

  public static unsafe uint global_counter
  {
    get
    {
      uint globalCounter;
      IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_global_counter, (void*) &globalCounter);
      return globalCounter;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_global_counter, (void*) &value);
    }
  }

  public static unsafe int i
  {
    get
    {
      int i;
      IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_i, (void*) &i);
      return i;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_i, (void*) &value);
    }
  }

  public static unsafe int j
  {
    get
    {
      int j;
      IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_j, (void*) &j);
      return j;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_j, (void*) &value);
    }
  }

  public static unsafe int finishedCnt
  {
    get
    {
      int finishedCnt;
      IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_finishedCnt, (void*) &finishedCnt);
      return finishedCnt;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_finishedCnt, (void*) &value);
    }
  }

  public static unsafe AnimationCurve punch
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_punch, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_punch, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe AnimationCurve shake
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_shake, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_shake, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe int maxTweenReached
  {
    get
    {
      int maxTweenReached;
      IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_maxTweenReached, (void*) &maxTweenReached);
      return maxTweenReached;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_maxTweenReached, (void*) &value);
    }
  }

  public static unsafe int startSearch
  {
    get
    {
      int startSearch;
      IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_startSearch, (void*) &startSearch);
      return startSearch;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_startSearch, (void*) &value);
    }
  }

  public static unsafe LTDescr d
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_d, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_d, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Il2CppReferenceArray<Il2CppSystem.Action<LTEvent>> eventListeners
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_eventListeners, (void*) &num);
      System.IntPtr nativeObject = num;
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Il2CppSystem.Action<LTEvent>>) null : new Il2CppReferenceArray<Il2CppSystem.Action<LTEvent>>(nativeObject);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_eventListeners, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Il2CppReferenceArray<GameObject> goListeners
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_goListeners, (void*) &num);
      System.IntPtr nativeObject = num;
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<GameObject>) null : new Il2CppReferenceArray<GameObject>(nativeObject);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_goListeners, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe int eventsMaxSearch
  {
    get
    {
      int eventsMaxSearch;
      IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_eventsMaxSearch, (void*) &eventsMaxSearch);
      return eventsMaxSearch;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_eventsMaxSearch, (void*) &value);
    }
  }

  public static unsafe int EVENTS_MAX
  {
    get
    {
      int eventsMax;
      IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_EVENTS_MAX, (void*) &eventsMax);
      return eventsMax;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_EVENTS_MAX, (void*) &value);
    }
  }

  public static unsafe int LISTENERS_MAX
  {
    get
    {
      int listenersMax;
      IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_LISTENERS_MAX, (void*) &listenersMax);
      return listenersMax;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_LISTENERS_MAX, (void*) &value);
    }
  }

  public static unsafe int INIT_LISTENERS_MAX
  {
    get
    {
      int initListenersMax;
      IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_INIT_LISTENERS_MAX, (void*) &initListenersMax);
      return initListenersMax;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_INIT_LISTENERS_MAX, (void*) &value);
    }
  }

  [ObfuscatedName("LeanTween/<>c__DisplayClass193_0")]
  public sealed class __c__DisplayClass193_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_d;
    private static readonly System.IntPtr NativeFieldInfoPtr_smoothTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_maxSpeed;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__followDamp_b__0_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__followDamp_b__1_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__followDamp_b__2_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__followDamp_b__3_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__followDamp_b__4_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__followDamp_b__5_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__followDamp_b__6_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__followDamp_b__7_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__followDamp_b__8_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__followDamp_b__9_Internal_Void_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass193_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeanTween.__c__DisplayClass193_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass193_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129059, XrefRangeEnd = 129063, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _followDamp_b__0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass193_0.NativeMethodInfoPtr__followDamp_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129063, XrefRangeEnd = 129067, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _followDamp_b__1()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass193_0.NativeMethodInfoPtr__followDamp_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129067, XrefRangeEnd = 129074, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _followDamp_b__2()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass193_0.NativeMethodInfoPtr__followDamp_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129074, XrefRangeEnd = 129081, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _followDamp_b__3()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass193_0.NativeMethodInfoPtr__followDamp_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129081, XrefRangeEnd = 129088, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _followDamp_b__4()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass193_0.NativeMethodInfoPtr__followDamp_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129088, XrefRangeEnd = 129095, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _followDamp_b__5()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass193_0.NativeMethodInfoPtr__followDamp_b__5_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129095, XrefRangeEnd = 129102, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _followDamp_b__6()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass193_0.NativeMethodInfoPtr__followDamp_b__6_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129102, XrefRangeEnd = 129109, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _followDamp_b__7()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass193_0.NativeMethodInfoPtr__followDamp_b__7_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129109, XrefRangeEnd = 129114, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _followDamp_b__8()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass193_0.NativeMethodInfoPtr__followDamp_b__8_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129114, XrefRangeEnd = 129131, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _followDamp_b__9()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass193_0.NativeMethodInfoPtr__followDamp_b__9_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static __c__DisplayClass193_0()
    {
      Il2CppClassPointerStore<LeanTween.__c__DisplayClass193_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "<>c__DisplayClass193_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeanTween.__c__DisplayClass193_0>.NativeClassPtr);
      LeanTween.__c__DisplayClass193_0.NativeFieldInfoPtr_d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween.__c__DisplayClass193_0>.NativeClassPtr, nameof (d));
      LeanTween.__c__DisplayClass193_0.NativeFieldInfoPtr_smoothTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween.__c__DisplayClass193_0>.NativeClassPtr, nameof (smoothTime));
      LeanTween.__c__DisplayClass193_0.NativeFieldInfoPtr_maxSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween.__c__DisplayClass193_0>.NativeClassPtr, nameof (maxSpeed));
      LeanTween.__c__DisplayClass193_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass193_0>.NativeClassPtr, 100676815);
      LeanTween.__c__DisplayClass193_0.NativeMethodInfoPtr__followDamp_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass193_0>.NativeClassPtr, 100676816);
      LeanTween.__c__DisplayClass193_0.NativeMethodInfoPtr__followDamp_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass193_0>.NativeClassPtr, 100676817);
      LeanTween.__c__DisplayClass193_0.NativeMethodInfoPtr__followDamp_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass193_0>.NativeClassPtr, 100676818);
      LeanTween.__c__DisplayClass193_0.NativeMethodInfoPtr__followDamp_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass193_0>.NativeClassPtr, 100676819);
      LeanTween.__c__DisplayClass193_0.NativeMethodInfoPtr__followDamp_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass193_0>.NativeClassPtr, 100676820);
      LeanTween.__c__DisplayClass193_0.NativeMethodInfoPtr__followDamp_b__5_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass193_0>.NativeClassPtr, 100676821);
      LeanTween.__c__DisplayClass193_0.NativeMethodInfoPtr__followDamp_b__6_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass193_0>.NativeClassPtr, 100676822);
      LeanTween.__c__DisplayClass193_0.NativeMethodInfoPtr__followDamp_b__7_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass193_0>.NativeClassPtr, 100676823);
      LeanTween.__c__DisplayClass193_0.NativeMethodInfoPtr__followDamp_b__8_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass193_0>.NativeClassPtr, 100676824);
      LeanTween.__c__DisplayClass193_0.NativeMethodInfoPtr__followDamp_b__9_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass193_0>.NativeClassPtr, 100676825);
    }

    public __c__DisplayClass193_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LTDescr d
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass193_0.NativeFieldInfoPtr_d));
        return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass193_0.NativeFieldInfoPtr_d), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float smoothTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass193_0.NativeFieldInfoPtr_smoothTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass193_0.NativeFieldInfoPtr_smoothTime)) = value;
      }
    }

    public unsafe float maxSpeed
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass193_0.NativeFieldInfoPtr_maxSpeed));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass193_0.NativeFieldInfoPtr_maxSpeed)) = value;
      }
    }
  }

  [ObfuscatedName("LeanTween/<>c__DisplayClass194_0")]
  public sealed class __c__DisplayClass194_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_d;
    private static readonly System.IntPtr NativeFieldInfoPtr_smoothTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_maxSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_friction;
    private static readonly System.IntPtr NativeFieldInfoPtr_accelRate;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__followSpring_b__0_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__followSpring_b__1_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__followSpring_b__2_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__followSpring_b__3_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__followSpring_b__4_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__followSpring_b__5_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__followSpring_b__6_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__followSpring_b__7_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__followSpring_b__8_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__followSpring_b__9_Internal_Void_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass194_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeanTween.__c__DisplayClass194_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass194_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129131, XrefRangeEnd = 129135, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _followSpring_b__0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass194_0.NativeMethodInfoPtr__followSpring_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129135, XrefRangeEnd = 129139, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _followSpring_b__1()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass194_0.NativeMethodInfoPtr__followSpring_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129139, XrefRangeEnd = 129146, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _followSpring_b__2()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass194_0.NativeMethodInfoPtr__followSpring_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129146, XrefRangeEnd = 129153, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _followSpring_b__3()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass194_0.NativeMethodInfoPtr__followSpring_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129153, XrefRangeEnd = 129160, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _followSpring_b__4()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass194_0.NativeMethodInfoPtr__followSpring_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129160, XrefRangeEnd = 129167, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _followSpring_b__5()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass194_0.NativeMethodInfoPtr__followSpring_b__5_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129167, XrefRangeEnd = 129174, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _followSpring_b__6()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass194_0.NativeMethodInfoPtr__followSpring_b__6_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129174, XrefRangeEnd = 129181, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _followSpring_b__7()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass194_0.NativeMethodInfoPtr__followSpring_b__7_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129181, XrefRangeEnd = 129186, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _followSpring_b__8()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass194_0.NativeMethodInfoPtr__followSpring_b__8_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129186, XrefRangeEnd = 129203, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _followSpring_b__9()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass194_0.NativeMethodInfoPtr__followSpring_b__9_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static __c__DisplayClass194_0()
    {
      Il2CppClassPointerStore<LeanTween.__c__DisplayClass194_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "<>c__DisplayClass194_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeanTween.__c__DisplayClass194_0>.NativeClassPtr);
      LeanTween.__c__DisplayClass194_0.NativeFieldInfoPtr_d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween.__c__DisplayClass194_0>.NativeClassPtr, nameof (d));
      LeanTween.__c__DisplayClass194_0.NativeFieldInfoPtr_smoothTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween.__c__DisplayClass194_0>.NativeClassPtr, nameof (smoothTime));
      LeanTween.__c__DisplayClass194_0.NativeFieldInfoPtr_maxSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween.__c__DisplayClass194_0>.NativeClassPtr, nameof (maxSpeed));
      LeanTween.__c__DisplayClass194_0.NativeFieldInfoPtr_friction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween.__c__DisplayClass194_0>.NativeClassPtr, nameof (friction));
      LeanTween.__c__DisplayClass194_0.NativeFieldInfoPtr_accelRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween.__c__DisplayClass194_0>.NativeClassPtr, nameof (accelRate));
      LeanTween.__c__DisplayClass194_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass194_0>.NativeClassPtr, 100676826);
      LeanTween.__c__DisplayClass194_0.NativeMethodInfoPtr__followSpring_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass194_0>.NativeClassPtr, 100676827);
      LeanTween.__c__DisplayClass194_0.NativeMethodInfoPtr__followSpring_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass194_0>.NativeClassPtr, 100676828);
      LeanTween.__c__DisplayClass194_0.NativeMethodInfoPtr__followSpring_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass194_0>.NativeClassPtr, 100676829);
      LeanTween.__c__DisplayClass194_0.NativeMethodInfoPtr__followSpring_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass194_0>.NativeClassPtr, 100676830);
      LeanTween.__c__DisplayClass194_0.NativeMethodInfoPtr__followSpring_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass194_0>.NativeClassPtr, 100676831);
      LeanTween.__c__DisplayClass194_0.NativeMethodInfoPtr__followSpring_b__5_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass194_0>.NativeClassPtr, 100676832);
      LeanTween.__c__DisplayClass194_0.NativeMethodInfoPtr__followSpring_b__6_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass194_0>.NativeClassPtr, 100676833);
      LeanTween.__c__DisplayClass194_0.NativeMethodInfoPtr__followSpring_b__7_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass194_0>.NativeClassPtr, 100676834);
      LeanTween.__c__DisplayClass194_0.NativeMethodInfoPtr__followSpring_b__8_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass194_0>.NativeClassPtr, 100676835);
      LeanTween.__c__DisplayClass194_0.NativeMethodInfoPtr__followSpring_b__9_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass194_0>.NativeClassPtr, 100676836);
    }

    public __c__DisplayClass194_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LTDescr d
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass194_0.NativeFieldInfoPtr_d));
        return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass194_0.NativeFieldInfoPtr_d), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float smoothTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass194_0.NativeFieldInfoPtr_smoothTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass194_0.NativeFieldInfoPtr_smoothTime)) = value;
      }
    }

    public unsafe float maxSpeed
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass194_0.NativeFieldInfoPtr_maxSpeed));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass194_0.NativeFieldInfoPtr_maxSpeed)) = value;
      }
    }

    public unsafe float friction
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass194_0.NativeFieldInfoPtr_friction));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass194_0.NativeFieldInfoPtr_friction)) = value;
      }
    }

    public unsafe float accelRate
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass194_0.NativeFieldInfoPtr_accelRate));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass194_0.NativeFieldInfoPtr_accelRate)) = value;
      }
    }
  }

  [ObfuscatedName("LeanTween/<>c__DisplayClass195_0")]
  public sealed class __c__DisplayClass195_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_d;
    private static readonly System.IntPtr NativeFieldInfoPtr_smoothTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_maxSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_friction;
    private static readonly System.IntPtr NativeFieldInfoPtr_accelRate;
    private static readonly System.IntPtr NativeFieldInfoPtr_hitDamping;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__followBounceOut_b__0_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__followBounceOut_b__1_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__followBounceOut_b__2_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__followBounceOut_b__3_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__followBounceOut_b__4_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__followBounceOut_b__5_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__followBounceOut_b__6_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__followBounceOut_b__7_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__followBounceOut_b__8_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__followBounceOut_b__9_Internal_Void_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass195_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeanTween.__c__DisplayClass195_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass195_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129203, XrefRangeEnd = 129207, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _followBounceOut_b__0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass195_0.NativeMethodInfoPtr__followBounceOut_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129207, XrefRangeEnd = 129211, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _followBounceOut_b__1()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass195_0.NativeMethodInfoPtr__followBounceOut_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129211, XrefRangeEnd = 129218, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _followBounceOut_b__2()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass195_0.NativeMethodInfoPtr__followBounceOut_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129218, XrefRangeEnd = 129225, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _followBounceOut_b__3()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass195_0.NativeMethodInfoPtr__followBounceOut_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129225, XrefRangeEnd = 129232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _followBounceOut_b__4()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass195_0.NativeMethodInfoPtr__followBounceOut_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129232, XrefRangeEnd = 129239, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _followBounceOut_b__5()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass195_0.NativeMethodInfoPtr__followBounceOut_b__5_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129239, XrefRangeEnd = 129246, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _followBounceOut_b__6()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass195_0.NativeMethodInfoPtr__followBounceOut_b__6_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129246, XrefRangeEnd = 129253, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _followBounceOut_b__7()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass195_0.NativeMethodInfoPtr__followBounceOut_b__7_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129253, XrefRangeEnd = 129258, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _followBounceOut_b__8()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass195_0.NativeMethodInfoPtr__followBounceOut_b__8_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129258, XrefRangeEnd = 129275, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _followBounceOut_b__9()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass195_0.NativeMethodInfoPtr__followBounceOut_b__9_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static __c__DisplayClass195_0()
    {
      Il2CppClassPointerStore<LeanTween.__c__DisplayClass195_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "<>c__DisplayClass195_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeanTween.__c__DisplayClass195_0>.NativeClassPtr);
      LeanTween.__c__DisplayClass195_0.NativeFieldInfoPtr_d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween.__c__DisplayClass195_0>.NativeClassPtr, nameof (d));
      LeanTween.__c__DisplayClass195_0.NativeFieldInfoPtr_smoothTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween.__c__DisplayClass195_0>.NativeClassPtr, nameof (smoothTime));
      LeanTween.__c__DisplayClass195_0.NativeFieldInfoPtr_maxSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween.__c__DisplayClass195_0>.NativeClassPtr, nameof (maxSpeed));
      LeanTween.__c__DisplayClass195_0.NativeFieldInfoPtr_friction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween.__c__DisplayClass195_0>.NativeClassPtr, nameof (friction));
      LeanTween.__c__DisplayClass195_0.NativeFieldInfoPtr_accelRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween.__c__DisplayClass195_0>.NativeClassPtr, nameof (accelRate));
      LeanTween.__c__DisplayClass195_0.NativeFieldInfoPtr_hitDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween.__c__DisplayClass195_0>.NativeClassPtr, nameof (hitDamping));
      LeanTween.__c__DisplayClass195_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass195_0>.NativeClassPtr, 100676837);
      LeanTween.__c__DisplayClass195_0.NativeMethodInfoPtr__followBounceOut_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass195_0>.NativeClassPtr, 100676838);
      LeanTween.__c__DisplayClass195_0.NativeMethodInfoPtr__followBounceOut_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass195_0>.NativeClassPtr, 100676839);
      LeanTween.__c__DisplayClass195_0.NativeMethodInfoPtr__followBounceOut_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass195_0>.NativeClassPtr, 100676840);
      LeanTween.__c__DisplayClass195_0.NativeMethodInfoPtr__followBounceOut_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass195_0>.NativeClassPtr, 100676841);
      LeanTween.__c__DisplayClass195_0.NativeMethodInfoPtr__followBounceOut_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass195_0>.NativeClassPtr, 100676842);
      LeanTween.__c__DisplayClass195_0.NativeMethodInfoPtr__followBounceOut_b__5_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass195_0>.NativeClassPtr, 100676843);
      LeanTween.__c__DisplayClass195_0.NativeMethodInfoPtr__followBounceOut_b__6_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass195_0>.NativeClassPtr, 100676844);
      LeanTween.__c__DisplayClass195_0.NativeMethodInfoPtr__followBounceOut_b__7_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass195_0>.NativeClassPtr, 100676845);
      LeanTween.__c__DisplayClass195_0.NativeMethodInfoPtr__followBounceOut_b__8_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass195_0>.NativeClassPtr, 100676846);
      LeanTween.__c__DisplayClass195_0.NativeMethodInfoPtr__followBounceOut_b__9_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass195_0>.NativeClassPtr, 100676847);
    }

    public __c__DisplayClass195_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LTDescr d
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass195_0.NativeFieldInfoPtr_d));
        return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass195_0.NativeFieldInfoPtr_d), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float smoothTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass195_0.NativeFieldInfoPtr_smoothTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass195_0.NativeFieldInfoPtr_smoothTime)) = value;
      }
    }

    public unsafe float maxSpeed
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass195_0.NativeFieldInfoPtr_maxSpeed));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass195_0.NativeFieldInfoPtr_maxSpeed)) = value;
      }
    }

    public unsafe float friction
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass195_0.NativeFieldInfoPtr_friction));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass195_0.NativeFieldInfoPtr_friction)) = value;
      }
    }

    public unsafe float accelRate
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass195_0.NativeFieldInfoPtr_accelRate));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass195_0.NativeFieldInfoPtr_accelRate)) = value;
      }
    }

    public unsafe float hitDamping
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass195_0.NativeFieldInfoPtr_hitDamping));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass195_0.NativeFieldInfoPtr_hitDamping)) = value;
      }
    }
  }

  [ObfuscatedName("LeanTween/<>c__DisplayClass196_0")]
  public sealed class __c__DisplayClass196_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_d;
    private static readonly System.IntPtr NativeFieldInfoPtr_moveSpeed;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__followLinear_b__0_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__followLinear_b__1_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__followLinear_b__2_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__followLinear_b__3_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__followLinear_b__4_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__followLinear_b__5_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__followLinear_b__6_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__followLinear_b__7_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__followLinear_b__8_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__followLinear_b__9_Internal_Void_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass196_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeanTween.__c__DisplayClass196_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass196_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129275, XrefRangeEnd = 129278, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _followLinear_b__0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass196_0.NativeMethodInfoPtr__followLinear_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129278, XrefRangeEnd = 129282, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _followLinear_b__1()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass196_0.NativeMethodInfoPtr__followLinear_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129282, XrefRangeEnd = 129288, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _followLinear_b__2()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass196_0.NativeMethodInfoPtr__followLinear_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129288, XrefRangeEnd = 129294, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _followLinear_b__3()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass196_0.NativeMethodInfoPtr__followLinear_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129294, XrefRangeEnd = 129300, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _followLinear_b__4()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass196_0.NativeMethodInfoPtr__followLinear_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129300, XrefRangeEnd = 129306, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _followLinear_b__5()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass196_0.NativeMethodInfoPtr__followLinear_b__5_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129306, XrefRangeEnd = 129312, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _followLinear_b__6()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass196_0.NativeMethodInfoPtr__followLinear_b__6_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129312, XrefRangeEnd = 129318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _followLinear_b__7()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass196_0.NativeMethodInfoPtr__followLinear_b__7_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129318, XrefRangeEnd = 129322, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _followLinear_b__8()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass196_0.NativeMethodInfoPtr__followLinear_b__8_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129322, XrefRangeEnd = 129338, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _followLinear_b__9()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass196_0.NativeMethodInfoPtr__followLinear_b__9_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static __c__DisplayClass196_0()
    {
      Il2CppClassPointerStore<LeanTween.__c__DisplayClass196_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "<>c__DisplayClass196_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeanTween.__c__DisplayClass196_0>.NativeClassPtr);
      LeanTween.__c__DisplayClass196_0.NativeFieldInfoPtr_d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween.__c__DisplayClass196_0>.NativeClassPtr, nameof (d));
      LeanTween.__c__DisplayClass196_0.NativeFieldInfoPtr_moveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween.__c__DisplayClass196_0>.NativeClassPtr, nameof (moveSpeed));
      LeanTween.__c__DisplayClass196_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass196_0>.NativeClassPtr, 100676848);
      LeanTween.__c__DisplayClass196_0.NativeMethodInfoPtr__followLinear_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass196_0>.NativeClassPtr, 100676849);
      LeanTween.__c__DisplayClass196_0.NativeMethodInfoPtr__followLinear_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass196_0>.NativeClassPtr, 100676850);
      LeanTween.__c__DisplayClass196_0.NativeMethodInfoPtr__followLinear_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass196_0>.NativeClassPtr, 100676851);
      LeanTween.__c__DisplayClass196_0.NativeMethodInfoPtr__followLinear_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass196_0>.NativeClassPtr, 100676852);
      LeanTween.__c__DisplayClass196_0.NativeMethodInfoPtr__followLinear_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass196_0>.NativeClassPtr, 100676853);
      LeanTween.__c__DisplayClass196_0.NativeMethodInfoPtr__followLinear_b__5_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass196_0>.NativeClassPtr, 100676854);
      LeanTween.__c__DisplayClass196_0.NativeMethodInfoPtr__followLinear_b__6_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass196_0>.NativeClassPtr, 100676855);
      LeanTween.__c__DisplayClass196_0.NativeMethodInfoPtr__followLinear_b__7_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass196_0>.NativeClassPtr, 100676856);
      LeanTween.__c__DisplayClass196_0.NativeMethodInfoPtr__followLinear_b__8_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass196_0>.NativeClassPtr, 100676857);
      LeanTween.__c__DisplayClass196_0.NativeMethodInfoPtr__followLinear_b__9_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass196_0>.NativeClassPtr, 100676858);
    }

    public __c__DisplayClass196_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LTDescr d
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass196_0.NativeFieldInfoPtr_d));
        return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass196_0.NativeFieldInfoPtr_d), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float moveSpeed
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass196_0.NativeFieldInfoPtr_moveSpeed));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass196_0.NativeFieldInfoPtr_moveSpeed)) = value;
      }
    }
  }
}
