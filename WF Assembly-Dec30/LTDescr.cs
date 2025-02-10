// Decompiled with JetBrains decompiler
// Type: LTDescr
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class LTDescr : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_toggle;
  private static readonly System.IntPtr NativeFieldInfoPtr_useEstimatedTime;
  private static readonly System.IntPtr NativeFieldInfoPtr_useFrames;
  private static readonly System.IntPtr NativeFieldInfoPtr_useManualTime;
  private static readonly System.IntPtr NativeFieldInfoPtr_usesNormalDt;
  private static readonly System.IntPtr NativeFieldInfoPtr_hasInitiliazed;
  private static readonly System.IntPtr NativeFieldInfoPtr_hasExtraOnCompletes;
  private static readonly System.IntPtr NativeFieldInfoPtr_hasPhysics;
  private static readonly System.IntPtr NativeFieldInfoPtr_onCompleteOnRepeat;
  private static readonly System.IntPtr NativeFieldInfoPtr_onCompleteOnStart;
  private static readonly System.IntPtr NativeFieldInfoPtr_useRecursion;
  private static readonly System.IntPtr NativeFieldInfoPtr_ratioPassed;
  private static readonly System.IntPtr NativeFieldInfoPtr_passed;
  private static readonly System.IntPtr NativeFieldInfoPtr_delay;
  private static readonly System.IntPtr NativeFieldInfoPtr_time;
  private static readonly System.IntPtr NativeFieldInfoPtr_speed;
  private static readonly System.IntPtr NativeFieldInfoPtr_lastVal;
  private static readonly System.IntPtr NativeFieldInfoPtr__id;
  private static readonly System.IntPtr NativeFieldInfoPtr_loopCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_counter;
  private static readonly System.IntPtr NativeFieldInfoPtr_direction;
  private static readonly System.IntPtr NativeFieldInfoPtr_directionLast;
  private static readonly System.IntPtr NativeFieldInfoPtr_overshoot;
  private static readonly System.IntPtr NativeFieldInfoPtr_period;
  private static readonly System.IntPtr NativeFieldInfoPtr_scale;
  private static readonly System.IntPtr NativeFieldInfoPtr_destroyOnComplete;
  private static readonly System.IntPtr NativeFieldInfoPtr_trans;
  private static readonly System.IntPtr NativeFieldInfoPtr_fromInternal;
  private static readonly System.IntPtr NativeFieldInfoPtr_toInternal;
  private static readonly System.IntPtr NativeFieldInfoPtr_diff;
  private static readonly System.IntPtr NativeFieldInfoPtr_diffDiv2;
  private static readonly System.IntPtr NativeFieldInfoPtr_type;
  private static readonly System.IntPtr NativeFieldInfoPtr_easeType;
  private static readonly System.IntPtr NativeFieldInfoPtr_loopType;
  private static readonly System.IntPtr NativeFieldInfoPtr_hasUpdateCallback;
  private static readonly System.IntPtr NativeFieldInfoPtr_easeMethod;
  private static readonly System.IntPtr NativeFieldInfoPtr__easeInternal_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__initInternal_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr_spriteRen;
  private static readonly System.IntPtr NativeFieldInfoPtr_rectTransform;
  private static readonly System.IntPtr NativeFieldInfoPtr_uiText;
  private static readonly System.IntPtr NativeFieldInfoPtr_uiImage;
  private static readonly System.IntPtr NativeFieldInfoPtr_rawImage;
  private static readonly System.IntPtr NativeFieldInfoPtr_sprites;
  private static readonly System.IntPtr NativeFieldInfoPtr__optional;
  private static readonly System.IntPtr NativeFieldInfoPtr_val;
  private static readonly System.IntPtr NativeFieldInfoPtr_dt;
  private static readonly System.IntPtr NativeFieldInfoPtr_newVect;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_from_Public_get_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_from_Public_set_Void_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_to_Public_get_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_to_Public_set_Void_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_easeInternal_Public_get_ActionMethodDelegate_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_easeInternal_Public_set_Void_ActionMethodDelegate_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_initInternal_Public_get_ActionMethodDelegate_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_initInternal_Public_set_Void_ActionMethodDelegate_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_toTrans_Public_get_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_cancel_Public_LTDescr_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_uniqueId_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_id_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_optional_Public_get_LTDescrOptional_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_optional_Public_set_Void_LTDescrOptional_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_reset_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setFollow_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setMoveX_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setMoveY_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setMoveZ_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setMoveLocalX_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setMoveLocalY_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setMoveLocalZ_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_initFromInternal_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setOffset_Public_LTDescr_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setMoveCurved_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setMoveCurvedLocal_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setMoveSpline_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setMoveSplineLocal_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setScaleX_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setScaleY_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setScaleZ_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setRotateX_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setRotateY_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setRotateZ_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setRotateAround_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setRotateAroundLocal_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setAlpha_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setTextAlpha_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setAlphaVertex_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setColor_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setCallbackColor_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setTextColor_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setCanvasAlpha_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setCanvasGroupAlpha_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setCanvasColor_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setCanvasMoveX_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setCanvasMoveY_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setCanvasMoveZ_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_initCanvasRotateAround_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setCanvasRotateAround_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setCanvasRotateAroundLocal_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setCanvasPlaySprite_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setCanvasMove_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setCanvasScale_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setCanvasSizeDelta_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_callback_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setCallback_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setValue3_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setMove_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setMoveLocal_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setMoveToTransform_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setRotate_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setRotateLocal_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setScale_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setGUIMove_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setGUIMoveMargin_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setGUIScale_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setGUIAlpha_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setGUIRotate_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setDelayedSound_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setTarget_Public_LTDescr_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_init_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_initSpeed_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_updateNow_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_updateInternal_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_callOnCompletes_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setFromColor_Public_LTDescr_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_alphaRecursive_Private_Static_Void_Transform_Single_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_colorRecursive_Private_Static_Void_Transform_Color_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_alphaRecursive_Private_Static_Void_RectTransform_Single_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_alphaRecursiveSprite_Private_Static_Void_Transform_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_colorRecursiveSprite_Private_Static_Void_Transform_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_colorRecursive_Private_Static_Void_RectTransform_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_textAlphaChildrenRecursive_Private_Static_Void_Transform_Single_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_textAlphaRecursive_Private_Static_Void_Transform_Single_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_textColorRecursive_Private_Static_Void_Transform_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_tweenColor_Private_Static_Color_LTDescr_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_pause_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_resume_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setAxis_Public_LTDescr_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setDelay_Public_LTDescr_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setEase_Public_LTDescr_LeanTweenType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setEaseLinear_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setEaseSpring_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setEaseInQuad_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setEaseOutQuad_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setEaseInOutQuad_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setEaseInCubic_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setEaseOutCubic_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setEaseInOutCubic_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setEaseInQuart_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setEaseOutQuart_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setEaseInOutQuart_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setEaseInQuint_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setEaseOutQuint_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setEaseInOutQuint_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setEaseInSine_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setEaseOutSine_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setEaseInOutSine_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setEaseInExpo_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setEaseOutExpo_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setEaseInOutExpo_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setEaseInCirc_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setEaseOutCirc_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setEaseInOutCirc_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setEaseInBounce_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setEaseOutBounce_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setEaseInOutBounce_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setEaseInBack_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setEaseOutBack_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setEaseInOutBack_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setEaseInElastic_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setEaseOutElastic_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setEaseInOutElastic_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setEasePunch_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setEaseShake_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_tweenOnCurve_Private_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeInOutQuad_Private_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeInQuad_Private_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeOutQuad_Private_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeLinear_Private_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeSpring_Private_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeInCubic_Private_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeOutCubic_Private_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeInOutCubic_Private_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeInQuart_Private_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeOutQuart_Private_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeInOutQuart_Private_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeInQuint_Private_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeOutQuint_Private_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeInOutQuint_Private_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeInSine_Private_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeOutSine_Private_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeInOutSine_Private_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeInExpo_Private_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeOutExpo_Private_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeInOutExpo_Private_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeInCirc_Private_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeOutCirc_Private_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeInOutCirc_Private_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeInBounce_Private_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeOutBounce_Private_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeInOutBounce_Private_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeInBack_Private_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeOutBack_Private_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeInOutBack_Private_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeInElastic_Private_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeOutElastic_Private_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_easeInOutElastic_Private_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setOvershoot_Public_LTDescr_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setPeriod_Public_LTDescr_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setScale_Public_LTDescr_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setEase_Public_LTDescr_AnimationCurve_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setTo_Public_LTDescr_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setTo_Public_LTDescr_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setFrom_Public_LTDescr_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setFrom_Public_LTDescr_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setDiff_Public_LTDescr_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setHasInitialized_Public_LTDescr_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setId_Public_LTDescr_UInt32_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setPassed_Public_LTDescr_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setTime_Public_LTDescr_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setSpeed_Public_LTDescr_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setRepeat_Public_LTDescr_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setLoopType_Public_LTDescr_LeanTweenType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setUseEstimatedTime_Public_LTDescr_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setIgnoreTimeScale_Public_LTDescr_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setUseFrames_Public_LTDescr_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setUseManualTime_Public_LTDescr_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setLoopCount_Public_LTDescr_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setLoopOnce_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setLoopClamp_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setLoopClamp_Public_LTDescr_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setLoopPingPong_Public_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setLoopPingPong_Public_LTDescr_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setOnComplete_Public_LTDescr_Action_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setOnComplete_Public_LTDescr_Action_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setOnComplete_Public_LTDescr_Action_1_Object_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setOnCompleteParam_Public_LTDescr_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_1_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setOnUpdateRatio_Public_LTDescr_Action_2_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setOnUpdateObject_Public_LTDescr_Action_2_Single_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setOnUpdateVector2_Public_LTDescr_Action_1_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setOnUpdateVector3_Public_LTDescr_Action_1_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setOnUpdateColor_Public_LTDescr_Action_1_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setOnUpdateColor_Public_LTDescr_Action_2_Color_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_1_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_2_Color_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_2_Single_Object_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_2_Vector3_Object_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_1_Vector2_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_1_Vector3_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setOnUpdateParam_Public_LTDescr_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setOrientToPath_Public_LTDescr_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setOrientToPath2d_Public_LTDescr_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setRect_Public_LTDescr_LTRect_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setRect_Public_LTDescr_Rect_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setPath_Public_LTDescr_LTBezierPath_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setPoint_Public_LTDescr_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setDestroyOnComplete_Public_LTDescr_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setAudio_Public_LTDescr_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setOnCompleteOnRepeat_Public_LTDescr_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setOnCompleteOnStart_Public_LTDescr_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setRect_Public_LTDescr_RectTransform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setSprites_Public_LTDescr_Il2CppReferenceArray_1_Sprite_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setFrameRate_Public_LTDescr_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setOnStart_Public_LTDescr_Action_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setDirection_Public_LTDescr_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setRecursive_Public_LTDescr_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setMoveX_b__73_0_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setMoveX_b__73_1_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setMoveY_b__74_0_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setMoveY_b__74_1_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setMoveZ_b__75_0_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setMoveZ_b__75_1_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setMoveLocalX_b__76_0_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setMoveLocalX_b__76_1_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setMoveLocalY_b__77_0_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setMoveLocalY_b__77_1_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setMoveLocalZ_b__78_0_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setMoveLocalZ_b__78_1_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setMoveCurved_b__81_0_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setMoveCurvedLocal_b__82_0_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setMoveSpline_b__83_0_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setMoveSplineLocal_b__84_0_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setScaleX_b__85_0_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setScaleX_b__85_1_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setScaleY_b__86_0_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setScaleY_b__86_1_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setScaleZ_b__87_0_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setScaleZ_b__87_1_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setRotateX_b__88_0_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setRotateX_b__88_1_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setRotateY_b__89_0_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setRotateY_b__89_1_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setRotateZ_b__90_0_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setRotateZ_b__90_1_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setRotateAround_b__91_0_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setRotateAround_b__91_1_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setRotateAroundLocal_b__92_0_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setRotateAroundLocal_b__92_1_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setAlpha_b__93_0_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setAlpha_b__93_2_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setAlpha_b__93_1_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setTextAlpha_b__94_0_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setTextAlpha_b__94_1_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setAlphaVertex_b__95_0_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setAlphaVertex_b__95_1_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setColor_b__96_0_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setColor_b__96_1_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setCallbackColor_b__97_0_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setCallbackColor_b__97_1_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setTextColor_b__98_0_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setTextColor_b__98_1_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setCanvasAlpha_b__99_0_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setCanvasAlpha_b__99_1_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setCanvasGroupAlpha_b__100_0_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setCanvasGroupAlpha_b__100_1_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setCanvasColor_b__101_0_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setCanvasColor_b__101_1_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setCanvasMoveX_b__102_0_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setCanvasMoveX_b__102_1_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setCanvasMoveY_b__103_0_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setCanvasMoveY_b__103_1_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setCanvasMoveZ_b__104_0_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setCanvasMoveZ_b__104_1_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setCanvasRotateAround_b__106_0_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setCanvasRotateAroundLocal_b__107_0_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setCanvasPlaySprite_b__108_0_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setCanvasPlaySprite_b__108_1_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setCanvasMove_b__109_0_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setCanvasMove_b__109_1_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setCanvasScale_b__110_0_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setCanvasScale_b__110_1_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setCanvasSizeDelta_b__111_0_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setCanvasSizeDelta_b__111_1_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setMove_b__115_0_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setMove_b__115_1_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setMoveLocal_b__116_0_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setMoveLocal_b__116_1_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setMoveToTransform_b__117_0_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setMoveToTransform_b__117_1_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setRotate_b__118_0_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setRotate_b__118_1_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setRotateLocal_b__119_0_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setRotateLocal_b__119_1_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setScale_b__120_0_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setScale_b__120_1_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setGUIMove_b__121_0_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setGUIMove_b__121_1_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setGUIMoveMargin_b__122_0_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setGUIMoveMargin_b__122_1_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setGUIScale_b__123_0_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setGUIScale_b__123_1_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setGUIAlpha_b__124_0_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setGUIAlpha_b__124_1_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setGUIRotate_b__125_0_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setGUIRotate_b__125_1_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__setDelayedSound_b__126_0_Private_Void_0;

  public unsafe Vector3 from
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_get_from_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_set_from_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public unsafe Vector3 to
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_get_to_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_set_to_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public unsafe LTDescr.ActionMethodDelegate easeInternal
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_get_easeInternal_Public_get_ActionMethodDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (LTDescr.ActionMethodDelegate) null : new LTDescr.ActionMethodDelegate(pointer);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133980, XrefRangeEnd = 133981, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_set_easeInternal_Public_set_Void_ActionMethodDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public unsafe LTDescr.ActionMethodDelegate initInternal
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_get_initInternal_Public_get_ActionMethodDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (LTDescr.ActionMethodDelegate) null : new LTDescr.ActionMethodDelegate(pointer);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133981, XrefRangeEnd = 133982, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_set_initInternal_Public_set_Void_ActionMethodDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public unsafe Transform toTrans
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_get_toTrans_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133982, XrefRangeEnd = 134108, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string ToString()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LTDescr.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 134115, RefRangeEnd = 134116, XrefRangeStart = 134108, XrefRangeEnd = 134115, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LTDescr>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134116, XrefRangeEnd = 134125, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr cancel(GameObject gameObject)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_cancel_Public_LTDescr_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  public unsafe int uniqueId
  {
    [CallerCount(6), CachedScanResults(RefRangeStart = 134125, RefRangeEnd = 134131, XrefRangeStart = 134125, XrefRangeEnd = 134125, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_get_uniqueId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public unsafe int id
  {
    [CallerCount(6), CachedScanResults(RefRangeStart = 134125, RefRangeEnd = 134131, XrefRangeStart = 134125, XrefRangeEnd = 134131, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_get_id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public unsafe LTDescrOptional optional
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_get_optional_Public_get_LTDescrOptional_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (LTDescrOptional) null : new LTDescrOptional(pointer);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134131, XrefRangeEnd = 134132, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_set_optional_Public_set_Void_LTDescrOptional_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134132, XrefRangeEnd = 134145, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void reset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 134145, RefRangeEnd = 134149, XrefRangeStart = 134145, XrefRangeEnd = 134145, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setFollow()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setFollow_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 134162, RefRangeEnd = 134163, XrefRangeStart = 134149, XrefRangeEnd = 134162, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setMoveX()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setMoveX_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 134176, RefRangeEnd = 134177, XrefRangeStart = 134163, XrefRangeEnd = 134176, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setMoveY()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setMoveY_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 134190, RefRangeEnd = 134191, XrefRangeStart = 134177, XrefRangeEnd = 134190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setMoveZ()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setMoveZ_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 134204, RefRangeEnd = 134205, XrefRangeStart = 134191, XrefRangeEnd = 134204, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setMoveLocalX()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setMoveLocalX_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 134218, RefRangeEnd = 134219, XrefRangeStart = 134205, XrefRangeEnd = 134218, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setMoveLocalY()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setMoveLocalY_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 134232, RefRangeEnd = 134233, XrefRangeStart = 134219, XrefRangeEnd = 134232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setMoveLocalZ()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setMoveLocalZ_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  public unsafe void initFromInternal()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_initFromInternal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public unsafe LTDescr setOffset(Vector3 offset)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &offset
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setOffset_Public_LTDescr_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 134246, RefRangeEnd = 134248, XrefRangeStart = 134233, XrefRangeEnd = 134246, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setMoveCurved()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setMoveCurved_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 134261, RefRangeEnd = 134263, XrefRangeStart = 134248, XrefRangeEnd = 134261, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setMoveCurvedLocal()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setMoveCurvedLocal_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 134276, RefRangeEnd = 134279, XrefRangeStart = 134263, XrefRangeEnd = 134276, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setMoveSpline()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setMoveSpline_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 134292, RefRangeEnd = 134294, XrefRangeStart = 134279, XrefRangeEnd = 134292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setMoveSplineLocal()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setMoveSplineLocal_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 134307, RefRangeEnd = 134308, XrefRangeStart = 134294, XrefRangeEnd = 134307, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setScaleX()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setScaleX_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 134321, RefRangeEnd = 134322, XrefRangeStart = 134308, XrefRangeEnd = 134321, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setScaleY()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setScaleY_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 134335, RefRangeEnd = 134336, XrefRangeStart = 134322, XrefRangeEnd = 134335, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setScaleZ()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setScaleZ_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 134349, RefRangeEnd = 134350, XrefRangeStart = 134336, XrefRangeEnd = 134349, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setRotateX()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setRotateX_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 134363, RefRangeEnd = 134364, XrefRangeStart = 134350, XrefRangeEnd = 134363, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setRotateY()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setRotateY_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 134377, RefRangeEnd = 134378, XrefRangeStart = 134364, XrefRangeEnd = 134377, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setRotateZ()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setRotateZ_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 134391, RefRangeEnd = 134392, XrefRangeStart = 134378, XrefRangeEnd = 134391, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setRotateAround()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setRotateAround_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 134405, RefRangeEnd = 134406, XrefRangeStart = 134392, XrefRangeEnd = 134405, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setRotateAroundLocal()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setRotateAroundLocal_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 134419, RefRangeEnd = 134420, XrefRangeStart = 134406, XrefRangeEnd = 134419, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setAlpha()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setAlpha_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 134433, RefRangeEnd = 134435, XrefRangeStart = 134420, XrefRangeEnd = 134433, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setTextAlpha()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setTextAlpha_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 134448, RefRangeEnd = 134449, XrefRangeStart = 134435, XrefRangeEnd = 134448, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setAlphaVertex()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setAlphaVertex_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 134462, RefRangeEnd = 134463, XrefRangeStart = 134449, XrefRangeEnd = 134462, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setColor()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setColor_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 134476, RefRangeEnd = 134479, XrefRangeStart = 134463, XrefRangeEnd = 134476, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setCallbackColor()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setCallbackColor_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 134492, RefRangeEnd = 134494, XrefRangeStart = 134479, XrefRangeEnd = 134492, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setTextColor()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setTextColor_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 134507, RefRangeEnd = 134508, XrefRangeStart = 134494, XrefRangeEnd = 134507, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setCanvasAlpha()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setCanvasAlpha_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 134521, RefRangeEnd = 134522, XrefRangeStart = 134508, XrefRangeEnd = 134521, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setCanvasGroupAlpha()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setCanvasGroupAlpha_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 134535, RefRangeEnd = 134536, XrefRangeStart = 134522, XrefRangeEnd = 134535, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setCanvasColor()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setCanvasColor_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 134549, RefRangeEnd = 134550, XrefRangeStart = 134536, XrefRangeEnd = 134549, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setCanvasMoveX()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setCanvasMoveX_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 134563, RefRangeEnd = 134564, XrefRangeStart = 134550, XrefRangeEnd = 134563, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setCanvasMoveY()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setCanvasMoveY_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 134577, RefRangeEnd = 134578, XrefRangeStart = 134564, XrefRangeEnd = 134577, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setCanvasMoveZ()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setCanvasMoveZ_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134578, XrefRangeEnd = 134579, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void initCanvasRotateAround()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_initCanvasRotateAround_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 134592, RefRangeEnd = 134595, XrefRangeStart = 134579, XrefRangeEnd = 134592, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setCanvasRotateAround()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setCanvasRotateAround_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 134608, RefRangeEnd = 134609, XrefRangeStart = 134595, XrefRangeEnd = 134608, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setCanvasRotateAroundLocal()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setCanvasRotateAroundLocal_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 134622, RefRangeEnd = 134623, XrefRangeStart = 134609, XrefRangeEnd = 134622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setCanvasPlaySprite()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setCanvasPlaySprite_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 134636, RefRangeEnd = 134637, XrefRangeStart = 134623, XrefRangeEnd = 134636, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setCanvasMove()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setCanvasMove_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 134650, RefRangeEnd = 134651, XrefRangeStart = 134637, XrefRangeEnd = 134650, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setCanvasScale()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setCanvasScale_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 134664, RefRangeEnd = 134665, XrefRangeStart = 134651, XrefRangeEnd = 134664, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setCanvasSizeDelta()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setCanvasSizeDelta_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134665, XrefRangeEnd = 134668, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void callback()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_callback_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(10)]
  [CachedScanResults(RefRangeStart = 134690, RefRangeEnd = 134700, XrefRangeStart = 134668, XrefRangeEnd = 134690, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setCallback()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setCallback_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 134722, RefRangeEnd = 134726, XrefRangeStart = 134700, XrefRangeEnd = 134722, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setValue3()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setValue3_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 134739, RefRangeEnd = 134741, XrefRangeStart = 134726, XrefRangeEnd = 134739, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setMove()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setMove_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 134754, RefRangeEnd = 134755, XrefRangeStart = 134741, XrefRangeEnd = 134754, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setMoveLocal()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setMoveLocal_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 134768, RefRangeEnd = 134769, XrefRangeStart = 134755, XrefRangeEnd = 134768, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setMoveToTransform()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setMoveToTransform_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 134782, RefRangeEnd = 134783, XrefRangeStart = 134769, XrefRangeEnd = 134782, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setRotate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setRotate_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 134796, RefRangeEnd = 134797, XrefRangeStart = 134783, XrefRangeEnd = 134796, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setRotateLocal()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setRotateLocal_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 134810, RefRangeEnd = 134811, XrefRangeStart = 134797, XrefRangeEnd = 134810, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setScale()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setScale_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 134824, RefRangeEnd = 134825, XrefRangeStart = 134811, XrefRangeEnd = 134824, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setGUIMove()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setGUIMove_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 134838, RefRangeEnd = 134839, XrefRangeStart = 134825, XrefRangeEnd = 134838, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setGUIMoveMargin()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setGUIMoveMargin_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 134852, RefRangeEnd = 134853, XrefRangeStart = 134839, XrefRangeEnd = 134852, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setGUIScale()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setGUIScale_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 134866, RefRangeEnd = 134867, XrefRangeStart = 134853, XrefRangeEnd = 134866, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setGUIAlpha()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setGUIAlpha_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 134880, RefRangeEnd = 134881, XrefRangeStart = 134867, XrefRangeEnd = 134880, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setGUIRotate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setGUIRotate_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 134894, RefRangeEnd = 134896, XrefRangeStart = 134881, XrefRangeEnd = 134894, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setDelayedSound()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setDelayedSound_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 134897, RefRangeEnd = 134902, XrefRangeStart = 134896, XrefRangeEnd = 134897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setTarget(Transform trans)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) trans)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setTarget_Public_LTDescr_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 134908, RefRangeEnd = 134911, XrefRangeStart = 134902, XrefRangeEnd = 134908, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void init()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 134912, RefRangeEnd = 134914, XrefRangeStart = 134911, XrefRangeEnd = 134912, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void initSpeed()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_initSpeed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134914, XrefRangeEnd = 134915, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr updateNow()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_updateNow_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(12)]
  [CachedScanResults(RefRangeStart = 134953, RefRangeEnd = 134965, XrefRangeStart = 134915, XrefRangeEnd = 134953, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool updateInternal()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_updateInternal_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 134968, RefRangeEnd = 134971, XrefRangeStart = 134965, XrefRangeEnd = 134968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void callOnCompletes()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_callOnCompletes_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 134971, RefRangeEnd = 134973, XrefRangeStart = 134971, XrefRangeEnd = 134971, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setFromColor(Color col)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &col
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setFromColor_Public_LTDescr_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 135021, RefRangeEnd = 135024, XrefRangeStart = 134973, XrefRangeEnd = 135021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void alphaRecursive(Transform transform, float val, bool useRecursion = true)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &val;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &useRecursion;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_alphaRecursive_Private_Static_Void_Transform_Single_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 135058, RefRangeEnd = 135061, XrefRangeStart = 135024, XrefRangeEnd = 135058, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void colorRecursive(Transform transform, Color toColor, bool useRecursion = true)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &toColor;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &useRecursion;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_colorRecursive_Private_Static_Void_Transform_Color_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 135098, RefRangeEnd = 135100, XrefRangeStart = 135061, XrefRangeEnd = 135098, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void alphaRecursive(
    RectTransform rectTransform,
    float val,
    int recursiveLevel = 0)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rectTransform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &val;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &recursiveLevel;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_alphaRecursive_Private_Static_Void_RectTransform_Single_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 135134, RefRangeEnd = 135135, XrefRangeStart = 135100, XrefRangeEnd = 135134, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void alphaRecursiveSprite(Transform transform, float val)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &val;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_alphaRecursiveSprite_Private_Static_Void_Transform_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 135169, RefRangeEnd = 135172, XrefRangeStart = 135135, XrefRangeEnd = 135169, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void colorRecursiveSprite(Transform transform, Color toColor)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &toColor;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_colorRecursiveSprite_Private_Static_Void_Transform_Color_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 135209, RefRangeEnd = 135211, XrefRangeStart = 135172, XrefRangeEnd = 135209, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void colorRecursive(RectTransform rectTransform, Color toColor)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rectTransform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &toColor;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_colorRecursive_Private_Static_Void_RectTransform_Color_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 135241, RefRangeEnd = 135243, XrefRangeStart = 135211, XrefRangeEnd = 135241, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void textAlphaChildrenRecursive(
    Transform trans,
    float val,
    bool useRecursion = true)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) trans);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &val;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &useRecursion;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_textAlphaChildrenRecursive_Private_Static_Void_Transform_Single_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 135273, RefRangeEnd = 135275, XrefRangeStart = 135243, XrefRangeEnd = 135273, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void textAlphaRecursive(Transform trans, float val, bool useRecursion = true)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) trans);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &val;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &useRecursion;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_textAlphaRecursive_Private_Static_Void_Transform_Single_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 135305, RefRangeEnd = 135307, XrefRangeStart = 135275, XrefRangeEnd = 135305, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void textColorRecursive(Transform trans, Color toColor)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) trans);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &toColor;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_textColorRecursive_Private_Static_Void_Transform_Color_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 135307, RefRangeEnd = 135311, XrefRangeStart = 135307, XrefRangeEnd = 135307, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Color tweenColor(LTDescr tween, float val)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) tween);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &val;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_tweenColor_Private_Static_Color_LTDescr_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Color*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 135311, RefRangeEnd = 135315, XrefRangeStart = 135311, XrefRangeEnd = 135311, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr pause()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_pause_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 135315, RefRangeEnd = 135319, XrefRangeStart = 135315, XrefRangeEnd = 135315, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr resume()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_resume_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 135319, RefRangeEnd = 135327, XrefRangeStart = 135319, XrefRangeEnd = 135319, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setAxis(Vector3 axis)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &axis
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setAxis_Public_LTDescr_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(24)]
  [CachedScanResults(RefRangeStart = 135327, RefRangeEnd = 135351, XrefRangeStart = 135327, XrefRangeEnd = 135327, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setDelay(float delay)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &delay
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setDelay_Public_LTDescr_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(139)]
  [CachedScanResults(RefRangeStart = 135358, RefRangeEnd = 135497, XrefRangeStart = 135351, XrefRangeEnd = 135358, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setEase(LeanTweenType easeType)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &easeType
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEase_Public_LTDescr_LeanTweenType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 135504, RefRangeEnd = 135506, XrefRangeStart = 135497, XrefRangeEnd = 135504, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setEaseLinear()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseLinear_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135506, XrefRangeEnd = 135513, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setEaseSpring()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseSpring_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 135520, RefRangeEnd = 135521, XrefRangeStart = 135513, XrefRangeEnd = 135520, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setEaseInQuad()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseInQuad_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 135528, RefRangeEnd = 135531, XrefRangeStart = 135521, XrefRangeEnd = 135528, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setEaseOutQuad()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseOutQuad_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 135538, RefRangeEnd = 135540, XrefRangeStart = 135531, XrefRangeEnd = 135538, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setEaseInOutQuad()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseInOutQuad_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135540, XrefRangeEnd = 135547, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setEaseInCubic()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseInCubic_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135547, XrefRangeEnd = 135554, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setEaseOutCubic()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseOutCubic_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135554, XrefRangeEnd = 135561, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setEaseInOutCubic()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseInOutCubic_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135561, XrefRangeEnd = 135568, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setEaseInQuart()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseInQuart_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 135575, RefRangeEnd = 135581, XrefRangeStart = 135568, XrefRangeEnd = 135575, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setEaseOutQuart()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseOutQuart_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 135588, RefRangeEnd = 135589, XrefRangeStart = 135581, XrefRangeEnd = 135588, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setEaseInOutQuart()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseInOutQuart_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135589, XrefRangeEnd = 135596, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setEaseInQuint()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseInQuint_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 135603, RefRangeEnd = 135609, XrefRangeStart = 135596, XrefRangeEnd = 135603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setEaseOutQuint()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseOutQuint_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135609, XrefRangeEnd = 135616, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setEaseInOutQuint()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseInOutQuint_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135616, XrefRangeEnd = 135623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setEaseInSine()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseInSine_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135623, XrefRangeEnd = 135630, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setEaseOutSine()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseOutSine_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135630, XrefRangeEnd = 135637, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setEaseInOutSine()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseInOutSine_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135637, XrefRangeEnd = 135644, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setEaseInExpo()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseInExpo_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135644, XrefRangeEnd = 135651, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setEaseOutExpo()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseOutExpo_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135651, XrefRangeEnd = 135658, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setEaseInOutExpo()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseInOutExpo_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135658, XrefRangeEnd = 135665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setEaseInCirc()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseInCirc_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135665, XrefRangeEnd = 135672, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setEaseOutCirc()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseOutCirc_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135672, XrefRangeEnd = 135679, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setEaseInOutCirc()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseInOutCirc_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135679, XrefRangeEnd = 135686, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setEaseInBounce()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseInBounce_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135686, XrefRangeEnd = 135693, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setEaseOutBounce()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseOutBounce_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135693, XrefRangeEnd = 135700, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setEaseInOutBounce()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseInOutBounce_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 135707, RefRangeEnd = 135710, XrefRangeStart = 135700, XrefRangeEnd = 135707, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setEaseInBack()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseInBack_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 135717, RefRangeEnd = 135723, XrefRangeStart = 135710, XrefRangeEnd = 135717, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setEaseOutBack()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseOutBack_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135723, XrefRangeEnd = 135730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setEaseInOutBack()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseInOutBack_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135730, XrefRangeEnd = 135737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setEaseInElastic()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseInElastic_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(15)]
  [CachedScanResults(RefRangeStart = 135744, RefRangeEnd = 135759, XrefRangeStart = 135737, XrefRangeEnd = 135744, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setEaseOutElastic()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseOutElastic_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135759, XrefRangeEnd = 135766, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setEaseInOutElastic()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseInOutElastic_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135766, XrefRangeEnd = 135778, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setEasePunch()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEasePunch_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135778, XrefRangeEnd = 135790, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setEaseShake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseShake_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135790, XrefRangeEnd = 135793, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 tweenOnCurve()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_tweenOnCurve_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135793, XrefRangeEnd = 135798, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 easeInOutQuad()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeInOutQuad_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135798, XrefRangeEnd = 135801, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 easeInQuad()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeInQuad_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135801, XrefRangeEnd = 135805, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 easeOutQuad()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeOutQuad_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135805, XrefRangeEnd = 135808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 easeLinear()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeLinear_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135808, XrefRangeEnd = 135815, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 easeSpring()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeSpring_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135815, XrefRangeEnd = 135818, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 easeInCubic()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeInCubic_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135818, XrefRangeEnd = 135822, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 easeOutCubic()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeOutCubic_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135822, XrefRangeEnd = 135829, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 easeInOutCubic()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeInOutCubic_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135829, XrefRangeEnd = 135832, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 easeInQuart()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeInQuart_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135832, XrefRangeEnd = 135836, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 easeOutQuart()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeOutQuart_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135836, XrefRangeEnd = 135840, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 easeInOutQuart()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeInOutQuart_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135840, XrefRangeEnd = 135844, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 easeInQuint()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeInQuint_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135844, XrefRangeEnd = 135848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 easeOutQuint()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeOutQuint_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135848, XrefRangeEnd = 135855, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 easeInOutQuint()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeInOutQuint_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135855, XrefRangeEnd = 135863, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 easeInSine()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeInSine_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135863, XrefRangeEnd = 135871, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 easeOutSine()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeOutSine_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135871, XrefRangeEnd = 135875, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 easeInOutSine()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeInOutSine_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135875, XrefRangeEnd = 135879, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 easeInExpo()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeInExpo_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135879, XrefRangeEnd = 135883, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 easeOutExpo()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeOutExpo_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135883, XrefRangeEnd = 135890, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 easeInOutExpo()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeInOutExpo_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135890, XrefRangeEnd = 135895, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 easeInCirc()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeInCirc_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135895, XrefRangeEnd = 135901, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 easeOutCirc()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeOutCirc_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135901, XrefRangeEnd = 135911, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 easeInOutCirc()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeInOutCirc_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135911, XrefRangeEnd = 135923, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 easeInBounce()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeInBounce_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135923, XrefRangeEnd = 135933, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 easeOutBounce()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeOutBounce_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135933, XrefRangeEnd = 135953, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 easeInOutBounce()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeInOutBounce_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135953, XrefRangeEnd = 135956, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 easeInBack()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeInBack_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135956, XrefRangeEnd = 135960, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 easeOutBack()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeOutBack_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135960, XrefRangeEnd = 135966, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 easeInOutBack()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeInOutBack_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135966, XrefRangeEnd = 135972, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 easeInElastic()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeInElastic_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135972, XrefRangeEnd = 135978, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 easeOutElastic()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeOutElastic_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135978, XrefRangeEnd = 135984, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 easeInOutElastic()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeInOutElastic_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public unsafe LTDescr setOvershoot(float overshoot)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &overshoot
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setOvershoot_Public_LTDescr_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  public unsafe LTDescr setPeriod(float period)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &period
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setPeriod_Public_LTDescr_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  public unsafe LTDescr setScale(float scale)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &scale
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setScale_Public_LTDescr_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(32)]
  [CachedScanResults(RefRangeStart = 135992, RefRangeEnd = 136024, XrefRangeStart = 135984, XrefRangeEnd = 135992, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setEase(AnimationCurve easeCurve)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) easeCurve)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEase_Public_LTDescr_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 136024, RefRangeEnd = 136032, XrefRangeStart = 136024, XrefRangeEnd = 136024, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setTo(Vector3 to)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &to
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setTo_Public_LTDescr_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 134897, RefRangeEnd = 134902, XrefRangeStart = 134897, XrefRangeEnd = 134902, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setTo(Transform to)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) to)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setTo_Public_LTDescr_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(21)]
  [CachedScanResults(RefRangeStart = 136037, RefRangeEnd = 136058, XrefRangeStart = 136032, XrefRangeEnd = 136037, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setFrom(Vector3 from)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &from
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setFrom_Public_LTDescr_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 136063, RefRangeEnd = 136064, XrefRangeStart = 136058, XrefRangeEnd = 136063, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setFrom(float from)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &from
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setFrom_Public_LTDescr_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  public unsafe LTDescr setDiff(Vector3 diff)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &diff
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setDiff_Public_LTDescr_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 136064, RefRangeEnd = 136067, XrefRangeStart = 136064, XrefRangeEnd = 136064, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setHasInitialized(bool has)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &has
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setHasInitialized_Public_LTDescr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  public unsafe LTDescr setId(uint id, uint global_counter)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &id;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &global_counter;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setId_Public_LTDescr_UInt32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  public unsafe LTDescr setPassed(float passed)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &passed
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setPassed_Public_LTDescr_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 136067, RefRangeEnd = 136069, XrefRangeStart = 136067, XrefRangeEnd = 136067, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setTime(float time)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &time
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setTime_Public_LTDescr_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136069, XrefRangeEnd = 136070, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setSpeed(float speed)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &speed
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setSpeed_Public_LTDescr_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 136070, RefRangeEnd = 136071, XrefRangeStart = 136070, XrefRangeEnd = 136070, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setRepeat(int repeat)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &repeat
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setRepeat_Public_LTDescr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  public unsafe LTDescr setLoopType(LeanTweenType loopType)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &loopType
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setLoopType_Public_LTDescr_LeanTweenType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(24)]
  [CachedScanResults(RefRangeStart = 136071, RefRangeEnd = 136095, XrefRangeStart = 136071, XrefRangeEnd = 136071, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setUseEstimatedTime(bool useEstimatedTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &useEstimatedTime
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setUseEstimatedTime_Public_LTDescr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(24)]
  [CachedScanResults(RefRangeStart = 136071, RefRangeEnd = 136095, XrefRangeStart = 136071, XrefRangeEnd = 136095, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setIgnoreTimeScale(bool useUnScaledTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &useUnScaledTime
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setIgnoreTimeScale_Public_LTDescr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  public unsafe LTDescr setUseFrames(bool useFrames)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &useFrames
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setUseFrames_Public_LTDescr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  public unsafe LTDescr setUseManualTime(bool useManualTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &useManualTime
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setUseManualTime_Public_LTDescr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 136095, RefRangeEnd = 136096, XrefRangeStart = 136095, XrefRangeEnd = 136095, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setLoopCount(int loopCount)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &loopCount
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setLoopCount_Public_LTDescr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  public unsafe LTDescr setLoopOnce()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setLoopOnce_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 136096, RefRangeEnd = 136097, XrefRangeStart = 136096, XrefRangeEnd = 136096, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setLoopClamp()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setLoopClamp_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  public unsafe LTDescr setLoopClamp(int loops)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &loops
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setLoopClamp_Public_LTDescr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 136097, RefRangeEnd = 136098, XrefRangeStart = 136097, XrefRangeEnd = 136097, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setLoopPingPong()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setLoopPingPong_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 136098, RefRangeEnd = 136099, XrefRangeStart = 136098, XrefRangeEnd = 136098, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setLoopPingPong(int loops)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &loops
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setLoopPingPong_Public_LTDescr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(19)]
  [CachedScanResults(RefRangeStart = 136100, RefRangeEnd = 136119, XrefRangeStart = 136099, XrefRangeEnd = 136100, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setOnComplete(Il2CppSystem.Action onComplete)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onComplete)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setOnComplete_Public_LTDescr_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 136120, RefRangeEnd = 136122, XrefRangeStart = 136119, XrefRangeEnd = 136120, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setOnComplete(Il2CppSystem.Action<Il2CppSystem.Object> onComplete)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onComplete)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setOnComplete_Public_LTDescr_Action_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136122, XrefRangeEnd = 136124, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setOnComplete(Il2CppSystem.Action<Il2CppSystem.Object> onComplete, Il2CppSystem.Object onCompleteParam)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onComplete);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onCompleteParam);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setOnComplete_Public_LTDescr_Action_1_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 136125, RefRangeEnd = 136127, XrefRangeStart = 136124, XrefRangeEnd = 136125, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setOnCompleteParam(Il2CppSystem.Object onCompleteParam)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onCompleteParam)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setOnCompleteParam_Public_LTDescr_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(35)]
  [CachedScanResults(RefRangeStart = 136128, RefRangeEnd = 136163, XrefRangeStart = 136127, XrefRangeEnd = 136128, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setOnUpdate(Il2CppSystem.Action<float> onUpdate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onUpdate)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 136164, RefRangeEnd = 136165, XrefRangeStart = 136163, XrefRangeEnd = 136164, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setOnUpdateRatio(Il2CppSystem.Action<float, float> onUpdate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onUpdate)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setOnUpdateRatio_Public_LTDescr_Action_2_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136165, XrefRangeEnd = 136166, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setOnUpdateObject(Il2CppSystem.Action<float, Il2CppSystem.Object> onUpdate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onUpdate)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setOnUpdateObject_Public_LTDescr_Action_2_Single_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 136167, RefRangeEnd = 136170, XrefRangeStart = 136166, XrefRangeEnd = 136167, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setOnUpdateVector2(Il2CppSystem.Action<Vector2> onUpdate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onUpdate)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setOnUpdateVector2_Public_LTDescr_Action_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 136171, RefRangeEnd = 136173, XrefRangeStart = 136170, XrefRangeEnd = 136171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setOnUpdateVector3(Il2CppSystem.Action<Vector3> onUpdate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onUpdate)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setOnUpdateVector3_Public_LTDescr_Action_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 136174, RefRangeEnd = 136175, XrefRangeStart = 136173, XrefRangeEnd = 136174, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setOnUpdateColor(Il2CppSystem.Action<Color> onUpdate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onUpdate)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setOnUpdateColor_Public_LTDescr_Action_1_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 136176, RefRangeEnd = 136177, XrefRangeStart = 136175, XrefRangeEnd = 136176, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setOnUpdateColor(Il2CppSystem.Action<Color, Il2CppSystem.Object> onUpdate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onUpdate)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setOnUpdateColor_Public_LTDescr_Action_2_Color_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 136174, RefRangeEnd = 136175, XrefRangeStart = 136174, XrefRangeEnd = 136175, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setOnUpdate(Il2CppSystem.Action<Color> onUpdate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onUpdate)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_1_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 136176, RefRangeEnd = 136177, XrefRangeStart = 136176, XrefRangeEnd = 136177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setOnUpdate(Il2CppSystem.Action<Color, Il2CppSystem.Object> onUpdate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onUpdate)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_2_Color_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 136179, RefRangeEnd = 136180, XrefRangeStart = 136177, XrefRangeEnd = 136179, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setOnUpdate(Il2CppSystem.Action<float, Il2CppSystem.Object> onUpdate, Il2CppSystem.Object onUpdateParam = null)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onUpdate);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onUpdateParam);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_2_Single_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136180, XrefRangeEnd = 136182, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setOnUpdate(Il2CppSystem.Action<Vector3, Il2CppSystem.Object> onUpdate, Il2CppSystem.Object onUpdateParam = null)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onUpdate);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onUpdateParam);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_2_Vector3_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136182, XrefRangeEnd = 136184, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setOnUpdate(Il2CppSystem.Action<Vector2> onUpdate, Il2CppSystem.Object onUpdateParam = null)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onUpdate);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onUpdateParam);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_1_Vector2_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136184, XrefRangeEnd = 136186, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setOnUpdate(Il2CppSystem.Action<Vector3> onUpdate, Il2CppSystem.Object onUpdateParam = null)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onUpdate);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onUpdateParam);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_1_Vector3_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136186, XrefRangeEnd = 136187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setOnUpdateParam(Il2CppSystem.Object onUpdateParam)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onUpdateParam)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setOnUpdateParam_Public_LTDescr_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136187, XrefRangeEnd = 136193, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setOrientToPath(bool doesOrient)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &doesOrient
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setOrientToPath_Public_LTDescr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136193, XrefRangeEnd = 136200, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setOrientToPath2d(bool doesOrient2d)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &doesOrient2d
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setOrientToPath2d_Public_LTDescr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 136201, RefRangeEnd = 136207, XrefRangeStart = 136200, XrefRangeEnd = 136201, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setRect(LTRect rect)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rect)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setRect_Public_LTDescr_LTRect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136207, XrefRangeEnd = 136212, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setRect(Rect rect)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &rect
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setRect_Public_LTDescr_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136212, XrefRangeEnd = 136213, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setPath(LTBezierPath path)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) path)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setPath_Public_LTDescr_LTBezierPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 136213, RefRangeEnd = 136220, XrefRangeStart = 136213, XrefRangeEnd = 136213, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setPoint(Vector3 point)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &point
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setPoint_Public_LTDescr_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 136220, RefRangeEnd = 136221, XrefRangeStart = 136220, XrefRangeEnd = 136220, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setDestroyOnComplete(bool doesDestroy)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &doesDestroy
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setDestroyOnComplete_Public_LTDescr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 136222, RefRangeEnd = 136224, XrefRangeStart = 136221, XrefRangeEnd = 136222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setAudio(Il2CppSystem.Object audio)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) audio)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setAudio_Public_LTDescr_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  public unsafe LTDescr setOnCompleteOnRepeat(bool isOn)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &isOn
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setOnCompleteOnRepeat_Public_LTDescr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  public unsafe LTDescr setOnCompleteOnStart(bool isOn)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &isOn
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setOnCompleteOnStart_Public_LTDescr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(12)]
  [CachedScanResults(RefRangeStart = 136225, RefRangeEnd = 136237, XrefRangeStart = 136224, XrefRangeEnd = 136225, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setRect(RectTransform rect)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rect)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setRect_Public_LTDescr_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 136238, RefRangeEnd = 136239, XrefRangeStart = 136237, XrefRangeEnd = 136238, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setSprites(Il2CppReferenceArray<Sprite> sprites)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sprites)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setSprites_Public_LTDescr_Il2CppReferenceArray_1_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  public unsafe LTDescr setFrameRate(float frameRate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &frameRate
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setFrameRate_Public_LTDescr_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136239, XrefRangeEnd = 136240, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setOnStart(Il2CppSystem.Action onStart)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onStart)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setOnStart_Public_LTDescr_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136240, XrefRangeEnd = 136258, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTDescr setDirection(float direction)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &direction
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setDirection_Public_LTDescr_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  public unsafe LTDescr setRecursive(bool useRecursion)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &useRecursion
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setRecursive_Public_LTDescr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136258, XrefRangeEnd = 136259, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setMoveX_b__73_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setMoveX_b__73_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136259, XrefRangeEnd = 136262, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setMoveX_b__73_1()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setMoveX_b__73_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136262, XrefRangeEnd = 136263, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setMoveY_b__74_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setMoveY_b__74_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136263, XrefRangeEnd = 136266, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setMoveY_b__74_1()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setMoveY_b__74_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136266, XrefRangeEnd = 136267, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setMoveZ_b__75_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setMoveZ_b__75_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136267, XrefRangeEnd = 136270, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setMoveZ_b__75_1()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setMoveZ_b__75_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136270, XrefRangeEnd = 136271, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setMoveLocalX_b__76_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setMoveLocalX_b__76_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136271, XrefRangeEnd = 136274, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setMoveLocalX_b__76_1()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setMoveLocalX_b__76_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136274, XrefRangeEnd = 136275, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setMoveLocalY_b__77_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setMoveLocalY_b__77_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136275, XrefRangeEnd = 136278, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setMoveLocalY_b__77_1()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setMoveLocalY_b__77_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136278, XrefRangeEnd = 136279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setMoveLocalZ_b__78_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setMoveLocalZ_b__78_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136279, XrefRangeEnd = 136282, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setMoveLocalZ_b__78_1()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setMoveLocalZ_b__78_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136282, XrefRangeEnd = 136288, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setMoveCurved_b__81_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setMoveCurved_b__81_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136288, XrefRangeEnd = 136294, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setMoveCurvedLocal_b__82_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setMoveCurvedLocal_b__82_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136294, XrefRangeEnd = 136300, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setMoveSpline_b__83_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setMoveSpline_b__83_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136300, XrefRangeEnd = 136306, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setMoveSplineLocal_b__84_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setMoveSplineLocal_b__84_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136306, XrefRangeEnd = 136307, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setScaleX_b__85_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setScaleX_b__85_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136307, XrefRangeEnd = 136310, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setScaleX_b__85_1()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setScaleX_b__85_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136310, XrefRangeEnd = 136311, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setScaleY_b__86_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setScaleY_b__86_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136311, XrefRangeEnd = 136314, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setScaleY_b__86_1()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setScaleY_b__86_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136314, XrefRangeEnd = 136315, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setScaleZ_b__87_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setScaleZ_b__87_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136315, XrefRangeEnd = 136318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setScaleZ_b__87_1()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setScaleZ_b__87_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136318, XrefRangeEnd = 136323, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setRotateX_b__88_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setRotateX_b__88_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136323, XrefRangeEnd = 136326, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setRotateX_b__88_1()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setRotateX_b__88_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136326, XrefRangeEnd = 136331, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setRotateY_b__89_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setRotateY_b__89_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136331, XrefRangeEnd = 136334, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setRotateY_b__89_1()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setRotateY_b__89_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136334, XrefRangeEnd = 136339, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setRotateZ_b__90_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setRotateZ_b__90_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136339, XrefRangeEnd = 136342, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setRotateZ_b__90_1()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setRotateZ_b__90_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136342, XrefRangeEnd = 136343, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setRotateAround_b__91_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setRotateAround_b__91_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136343, XrefRangeEnd = 136356, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setRotateAround_b__91_1()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setRotateAround_b__91_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136356, XrefRangeEnd = 136357, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setRotateAroundLocal_b__92_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setRotateAroundLocal_b__92_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136357, XrefRangeEnd = 136372, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setRotateAroundLocal_b__92_1()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setRotateAroundLocal_b__92_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136372, XrefRangeEnd = 136458, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setAlpha_b__93_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setAlpha_b__93_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136458, XrefRangeEnd = 136466, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setAlpha_b__93_2()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setAlpha_b__93_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136466, XrefRangeEnd = 136475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setAlpha_b__93_1()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setAlpha_b__93_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136475, XrefRangeEnd = 136483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setTextAlpha_b__94_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setTextAlpha_b__94_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136483, XrefRangeEnd = 136485, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setTextAlpha_b__94_1()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setTextAlpha_b__94_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136485, XrefRangeEnd = 136490, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setAlphaVertex_b__95_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setAlphaVertex_b__95_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136490, XrefRangeEnd = 136513, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setAlphaVertex_b__95_1()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setAlphaVertex_b__95_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136513, XrefRangeEnd = 136542, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setColor_b__96_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setColor_b__96_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136542, XrefRangeEnd = 136556, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setColor_b__96_1()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setColor_b__96_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public unsafe void _setCallbackColor_b__97_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setCallbackColor_b__97_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136556, XrefRangeEnd = 136570, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setCallbackColor_b__97_1()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setCallbackColor_b__97_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136570, XrefRangeEnd = 136579, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setTextColor_b__98_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setTextColor_b__98_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136579, XrefRangeEnd = 136587, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setTextColor_b__98_1()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setTextColor_b__98_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136587, XrefRangeEnd = 136602, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setCanvasAlpha_b__99_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setCanvasAlpha_b__99_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136602, XrefRangeEnd = 136619, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setCanvasAlpha_b__99_1()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setCanvasAlpha_b__99_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136619, XrefRangeEnd = 136623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setCanvasGroupAlpha_b__100_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setCanvasGroupAlpha_b__100_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136623, XrefRangeEnd = 136628, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setCanvasGroupAlpha_b__100_1()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setCanvasGroupAlpha_b__100_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136628, XrefRangeEnd = 136645, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setCanvasColor_b__101_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setCanvasColor_b__101_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136645, XrefRangeEnd = 136660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setCanvasColor_b__101_1()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setCanvasColor_b__101_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136660, XrefRangeEnd = 136661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setCanvasMoveX_b__102_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setCanvasMoveX_b__102_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136661, XrefRangeEnd = 136663, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setCanvasMoveX_b__102_1()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setCanvasMoveX_b__102_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136663, XrefRangeEnd = 136664, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setCanvasMoveY_b__103_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setCanvasMoveY_b__103_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136664, XrefRangeEnd = 136666, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setCanvasMoveY_b__103_1()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setCanvasMoveY_b__103_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136666, XrefRangeEnd = 136667, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setCanvasMoveZ_b__104_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setCanvasMoveZ_b__104_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136667, XrefRangeEnd = 136669, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setCanvasMoveZ_b__104_1()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setCanvasMoveZ_b__104_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136669, XrefRangeEnd = 136682, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setCanvasRotateAround_b__106_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setCanvasRotateAround_b__106_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136682, XrefRangeEnd = 136697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setCanvasRotateAroundLocal_b__107_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setCanvasRotateAroundLocal_b__107_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136697, XrefRangeEnd = 136701, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setCanvasPlaySprite_b__108_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setCanvasPlaySprite_b__108_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136701, XrefRangeEnd = 136709, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setCanvasPlaySprite_b__108_1()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setCanvasPlaySprite_b__108_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136709, XrefRangeEnd = 136710, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setCanvasMove_b__109_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setCanvasMove_b__109_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136710, XrefRangeEnd = 136711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setCanvasMove_b__109_1()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setCanvasMove_b__109_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136711, XrefRangeEnd = 136712, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setCanvasScale_b__110_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setCanvasScale_b__110_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136712, XrefRangeEnd = 136713, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setCanvasScale_b__110_1()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setCanvasScale_b__110_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136713, XrefRangeEnd = 136714, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setCanvasSizeDelta_b__111_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setCanvasSizeDelta_b__111_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136714, XrefRangeEnd = 136716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setCanvasSizeDelta_b__111_1()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setCanvasSizeDelta_b__111_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136716, XrefRangeEnd = 136717, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setMove_b__115_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setMove_b__115_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136717, XrefRangeEnd = 136721, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setMove_b__115_1()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setMove_b__115_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136721, XrefRangeEnd = 136722, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setMoveLocal_b__116_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setMoveLocal_b__116_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136722, XrefRangeEnd = 136726, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setMoveLocal_b__116_1()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setMoveLocal_b__116_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setMoveToTransform_b__117_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setMoveToTransform_b__117_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136726, XrefRangeEnd = 136731, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setMoveToTransform_b__117_1()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setMoveToTransform_b__117_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136731, XrefRangeEnd = 136738, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setRotate_b__118_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setRotate_b__118_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136738, XrefRangeEnd = 136742, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setRotate_b__118_1()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setRotate_b__118_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136742, XrefRangeEnd = 136749, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setRotateLocal_b__119_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setRotateLocal_b__119_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136749, XrefRangeEnd = 136753, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setRotateLocal_b__119_1()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setRotateLocal_b__119_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136753, XrefRangeEnd = 136754, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setScale_b__120_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setScale_b__120_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136754, XrefRangeEnd = 136758, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setScale_b__120_1()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setScale_b__120_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136758, XrefRangeEnd = 136762, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setGUIMove_b__121_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setGUIMove_b__121_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136762, XrefRangeEnd = 136767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setGUIMove_b__121_1()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setGUIMove_b__121_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public unsafe void _setGUIMoveMargin_b__122_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setGUIMoveMargin_b__122_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public unsafe void _setGUIMoveMargin_b__122_1()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setGUIMoveMargin_b__122_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136767, XrefRangeEnd = 136771, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setGUIScale_b__123_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setGUIScale_b__123_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136771, XrefRangeEnd = 136776, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setGUIScale_b__123_1()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setGUIScale_b__123_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public unsafe void _setGUIAlpha_b__124_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setGUIAlpha_b__124_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public unsafe void _setGUIAlpha_b__124_1()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setGUIAlpha_b__124_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136776, XrefRangeEnd = 136777, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _setGUIRotate_b__125_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setGUIRotate_b__125_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public unsafe void _setGUIRotate_b__125_1()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setGUIRotate_b__125_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public unsafe void _setDelayedSound_b__126_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setDelayedSound_b__126_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static LTDescr()
  {
    Il2CppClassPointerStore<LTDescr>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (LTDescr));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LTDescr>.NativeClassPtr);
    LTDescr.NativeFieldInfoPtr_toggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, nameof (toggle));
    LTDescr.NativeFieldInfoPtr_useEstimatedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, nameof (useEstimatedTime));
    LTDescr.NativeFieldInfoPtr_useFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, nameof (useFrames));
    LTDescr.NativeFieldInfoPtr_useManualTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, nameof (useManualTime));
    LTDescr.NativeFieldInfoPtr_usesNormalDt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, nameof (usesNormalDt));
    LTDescr.NativeFieldInfoPtr_hasInitiliazed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, nameof (hasInitiliazed));
    LTDescr.NativeFieldInfoPtr_hasExtraOnCompletes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, nameof (hasExtraOnCompletes));
    LTDescr.NativeFieldInfoPtr_hasPhysics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, nameof (hasPhysics));
    LTDescr.NativeFieldInfoPtr_onCompleteOnRepeat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, nameof (onCompleteOnRepeat));
    LTDescr.NativeFieldInfoPtr_onCompleteOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, nameof (onCompleteOnStart));
    LTDescr.NativeFieldInfoPtr_useRecursion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, nameof (useRecursion));
    LTDescr.NativeFieldInfoPtr_ratioPassed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, nameof (ratioPassed));
    LTDescr.NativeFieldInfoPtr_passed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, nameof (passed));
    LTDescr.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, nameof (delay));
    LTDescr.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, nameof (time));
    LTDescr.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, nameof (speed));
    LTDescr.NativeFieldInfoPtr_lastVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, nameof (lastVal));
    LTDescr.NativeFieldInfoPtr__id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, nameof (_id));
    LTDescr.NativeFieldInfoPtr_loopCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, nameof (loopCount));
    LTDescr.NativeFieldInfoPtr_counter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, nameof (counter));
    LTDescr.NativeFieldInfoPtr_direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, nameof (direction));
    LTDescr.NativeFieldInfoPtr_directionLast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, nameof (directionLast));
    LTDescr.NativeFieldInfoPtr_overshoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, nameof (overshoot));
    LTDescr.NativeFieldInfoPtr_period = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, nameof (period));
    LTDescr.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, nameof (scale));
    LTDescr.NativeFieldInfoPtr_destroyOnComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, nameof (destroyOnComplete));
    LTDescr.NativeFieldInfoPtr_trans = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, nameof (trans));
    LTDescr.NativeFieldInfoPtr_fromInternal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, nameof (fromInternal));
    LTDescr.NativeFieldInfoPtr_toInternal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, nameof (toInternal));
    LTDescr.NativeFieldInfoPtr_diff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, nameof (diff));
    LTDescr.NativeFieldInfoPtr_diffDiv2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, nameof (diffDiv2));
    LTDescr.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, nameof (type));
    LTDescr.NativeFieldInfoPtr_easeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, nameof (easeType));
    LTDescr.NativeFieldInfoPtr_loopType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, nameof (loopType));
    LTDescr.NativeFieldInfoPtr_hasUpdateCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, nameof (hasUpdateCallback));
    LTDescr.NativeFieldInfoPtr_easeMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, nameof (easeMethod));
    LTDescr.NativeFieldInfoPtr__easeInternal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "<easeInternal>k__BackingField");
    LTDescr.NativeFieldInfoPtr__initInternal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "<initInternal>k__BackingField");
    LTDescr.NativeFieldInfoPtr_spriteRen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, nameof (spriteRen));
    LTDescr.NativeFieldInfoPtr_rectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, nameof (rectTransform));
    LTDescr.NativeFieldInfoPtr_uiText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, nameof (uiText));
    LTDescr.NativeFieldInfoPtr_uiImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, nameof (uiImage));
    LTDescr.NativeFieldInfoPtr_rawImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, nameof (rawImage));
    LTDescr.NativeFieldInfoPtr_sprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, nameof (sprites));
    LTDescr.NativeFieldInfoPtr__optional = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, nameof (_optional));
    LTDescr.NativeFieldInfoPtr_val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, nameof (val));
    LTDescr.NativeFieldInfoPtr_dt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, nameof (dt));
    LTDescr.NativeFieldInfoPtr_newVect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, nameof (newVect));
    LTDescr.NativeMethodInfoPtr_get_from_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677045);
    LTDescr.NativeMethodInfoPtr_set_from_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677046);
    LTDescr.NativeMethodInfoPtr_get_to_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677047);
    LTDescr.NativeMethodInfoPtr_set_to_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677048);
    LTDescr.NativeMethodInfoPtr_get_easeInternal_Public_get_ActionMethodDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677049);
    LTDescr.NativeMethodInfoPtr_set_easeInternal_Public_set_Void_ActionMethodDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677050);
    LTDescr.NativeMethodInfoPtr_get_initInternal_Public_get_ActionMethodDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677051);
    LTDescr.NativeMethodInfoPtr_set_initInternal_Public_set_Void_ActionMethodDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677052);
    LTDescr.NativeMethodInfoPtr_get_toTrans_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677053);
    LTDescr.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677054);
    LTDescr.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677055);
    LTDescr.NativeMethodInfoPtr_cancel_Public_LTDescr_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677056);
    LTDescr.NativeMethodInfoPtr_get_uniqueId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677057);
    LTDescr.NativeMethodInfoPtr_get_id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677058);
    LTDescr.NativeMethodInfoPtr_get_optional_Public_get_LTDescrOptional_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677059);
    LTDescr.NativeMethodInfoPtr_set_optional_Public_set_Void_LTDescrOptional_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677060);
    LTDescr.NativeMethodInfoPtr_reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677061);
    LTDescr.NativeMethodInfoPtr_setFollow_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677062);
    LTDescr.NativeMethodInfoPtr_setMoveX_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677063);
    LTDescr.NativeMethodInfoPtr_setMoveY_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677064);
    LTDescr.NativeMethodInfoPtr_setMoveZ_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677065);
    LTDescr.NativeMethodInfoPtr_setMoveLocalX_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677066);
    LTDescr.NativeMethodInfoPtr_setMoveLocalY_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677067);
    LTDescr.NativeMethodInfoPtr_setMoveLocalZ_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677068);
    LTDescr.NativeMethodInfoPtr_initFromInternal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677069);
    LTDescr.NativeMethodInfoPtr_setOffset_Public_LTDescr_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677070);
    LTDescr.NativeMethodInfoPtr_setMoveCurved_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677071);
    LTDescr.NativeMethodInfoPtr_setMoveCurvedLocal_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677072);
    LTDescr.NativeMethodInfoPtr_setMoveSpline_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677073);
    LTDescr.NativeMethodInfoPtr_setMoveSplineLocal_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677074);
    LTDescr.NativeMethodInfoPtr_setScaleX_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677075);
    LTDescr.NativeMethodInfoPtr_setScaleY_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677076);
    LTDescr.NativeMethodInfoPtr_setScaleZ_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677077);
    LTDescr.NativeMethodInfoPtr_setRotateX_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677078);
    LTDescr.NativeMethodInfoPtr_setRotateY_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677079);
    LTDescr.NativeMethodInfoPtr_setRotateZ_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677080);
    LTDescr.NativeMethodInfoPtr_setRotateAround_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677081);
    LTDescr.NativeMethodInfoPtr_setRotateAroundLocal_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677082);
    LTDescr.NativeMethodInfoPtr_setAlpha_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677083);
    LTDescr.NativeMethodInfoPtr_setTextAlpha_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677084);
    LTDescr.NativeMethodInfoPtr_setAlphaVertex_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677085);
    LTDescr.NativeMethodInfoPtr_setColor_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677086);
    LTDescr.NativeMethodInfoPtr_setCallbackColor_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677087);
    LTDescr.NativeMethodInfoPtr_setTextColor_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677088);
    LTDescr.NativeMethodInfoPtr_setCanvasAlpha_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677089);
    LTDescr.NativeMethodInfoPtr_setCanvasGroupAlpha_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677090);
    LTDescr.NativeMethodInfoPtr_setCanvasColor_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677091);
    LTDescr.NativeMethodInfoPtr_setCanvasMoveX_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677092);
    LTDescr.NativeMethodInfoPtr_setCanvasMoveY_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677093);
    LTDescr.NativeMethodInfoPtr_setCanvasMoveZ_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677094);
    LTDescr.NativeMethodInfoPtr_initCanvasRotateAround_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677095);
    LTDescr.NativeMethodInfoPtr_setCanvasRotateAround_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677096);
    LTDescr.NativeMethodInfoPtr_setCanvasRotateAroundLocal_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677097);
    LTDescr.NativeMethodInfoPtr_setCanvasPlaySprite_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677098);
    LTDescr.NativeMethodInfoPtr_setCanvasMove_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677099);
    LTDescr.NativeMethodInfoPtr_setCanvasScale_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677100);
    LTDescr.NativeMethodInfoPtr_setCanvasSizeDelta_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677101);
    LTDescr.NativeMethodInfoPtr_callback_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677102);
    LTDescr.NativeMethodInfoPtr_setCallback_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677103);
    LTDescr.NativeMethodInfoPtr_setValue3_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677104);
    LTDescr.NativeMethodInfoPtr_setMove_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677105);
    LTDescr.NativeMethodInfoPtr_setMoveLocal_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677106);
    LTDescr.NativeMethodInfoPtr_setMoveToTransform_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677107);
    LTDescr.NativeMethodInfoPtr_setRotate_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677108);
    LTDescr.NativeMethodInfoPtr_setRotateLocal_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677109);
    LTDescr.NativeMethodInfoPtr_setScale_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677110);
    LTDescr.NativeMethodInfoPtr_setGUIMove_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677111);
    LTDescr.NativeMethodInfoPtr_setGUIMoveMargin_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677112);
    LTDescr.NativeMethodInfoPtr_setGUIScale_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677113);
    LTDescr.NativeMethodInfoPtr_setGUIAlpha_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677114);
    LTDescr.NativeMethodInfoPtr_setGUIRotate_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677115);
    LTDescr.NativeMethodInfoPtr_setDelayedSound_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677116);
    LTDescr.NativeMethodInfoPtr_setTarget_Public_LTDescr_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677117);
    LTDescr.NativeMethodInfoPtr_init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677118);
    LTDescr.NativeMethodInfoPtr_initSpeed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677119);
    LTDescr.NativeMethodInfoPtr_updateNow_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677120);
    LTDescr.NativeMethodInfoPtr_updateInternal_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677121);
    LTDescr.NativeMethodInfoPtr_callOnCompletes_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677122);
    LTDescr.NativeMethodInfoPtr_setFromColor_Public_LTDescr_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677123);
    LTDescr.NativeMethodInfoPtr_alphaRecursive_Private_Static_Void_Transform_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677124);
    LTDescr.NativeMethodInfoPtr_colorRecursive_Private_Static_Void_Transform_Color_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677125);
    LTDescr.NativeMethodInfoPtr_alphaRecursive_Private_Static_Void_RectTransform_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677126);
    LTDescr.NativeMethodInfoPtr_alphaRecursiveSprite_Private_Static_Void_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677127);
    LTDescr.NativeMethodInfoPtr_colorRecursiveSprite_Private_Static_Void_Transform_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677128);
    LTDescr.NativeMethodInfoPtr_colorRecursive_Private_Static_Void_RectTransform_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677129);
    LTDescr.NativeMethodInfoPtr_textAlphaChildrenRecursive_Private_Static_Void_Transform_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677130);
    LTDescr.NativeMethodInfoPtr_textAlphaRecursive_Private_Static_Void_Transform_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677131);
    LTDescr.NativeMethodInfoPtr_textColorRecursive_Private_Static_Void_Transform_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677132);
    LTDescr.NativeMethodInfoPtr_tweenColor_Private_Static_Color_LTDescr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677133);
    LTDescr.NativeMethodInfoPtr_pause_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677134);
    LTDescr.NativeMethodInfoPtr_resume_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677135);
    LTDescr.NativeMethodInfoPtr_setAxis_Public_LTDescr_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677136);
    LTDescr.NativeMethodInfoPtr_setDelay_Public_LTDescr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677137);
    LTDescr.NativeMethodInfoPtr_setEase_Public_LTDescr_LeanTweenType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677138);
    LTDescr.NativeMethodInfoPtr_setEaseLinear_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677139);
    LTDescr.NativeMethodInfoPtr_setEaseSpring_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677140);
    LTDescr.NativeMethodInfoPtr_setEaseInQuad_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677141);
    LTDescr.NativeMethodInfoPtr_setEaseOutQuad_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677142);
    LTDescr.NativeMethodInfoPtr_setEaseInOutQuad_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677143);
    LTDescr.NativeMethodInfoPtr_setEaseInCubic_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677144);
    LTDescr.NativeMethodInfoPtr_setEaseOutCubic_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677145);
    LTDescr.NativeMethodInfoPtr_setEaseInOutCubic_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677146);
    LTDescr.NativeMethodInfoPtr_setEaseInQuart_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677147);
    LTDescr.NativeMethodInfoPtr_setEaseOutQuart_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677148);
    LTDescr.NativeMethodInfoPtr_setEaseInOutQuart_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677149);
    LTDescr.NativeMethodInfoPtr_setEaseInQuint_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677150);
    LTDescr.NativeMethodInfoPtr_setEaseOutQuint_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677151);
    LTDescr.NativeMethodInfoPtr_setEaseInOutQuint_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677152);
    LTDescr.NativeMethodInfoPtr_setEaseInSine_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677153);
    LTDescr.NativeMethodInfoPtr_setEaseOutSine_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677154);
    LTDescr.NativeMethodInfoPtr_setEaseInOutSine_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677155);
    LTDescr.NativeMethodInfoPtr_setEaseInExpo_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677156);
    LTDescr.NativeMethodInfoPtr_setEaseOutExpo_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677157);
    LTDescr.NativeMethodInfoPtr_setEaseInOutExpo_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677158);
    LTDescr.NativeMethodInfoPtr_setEaseInCirc_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677159);
    LTDescr.NativeMethodInfoPtr_setEaseOutCirc_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677160);
    LTDescr.NativeMethodInfoPtr_setEaseInOutCirc_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677161);
    LTDescr.NativeMethodInfoPtr_setEaseInBounce_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677162);
    LTDescr.NativeMethodInfoPtr_setEaseOutBounce_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677163);
    LTDescr.NativeMethodInfoPtr_setEaseInOutBounce_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677164);
    LTDescr.NativeMethodInfoPtr_setEaseInBack_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677165);
    LTDescr.NativeMethodInfoPtr_setEaseOutBack_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677166);
    LTDescr.NativeMethodInfoPtr_setEaseInOutBack_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677167);
    LTDescr.NativeMethodInfoPtr_setEaseInElastic_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677168);
    LTDescr.NativeMethodInfoPtr_setEaseOutElastic_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677169);
    LTDescr.NativeMethodInfoPtr_setEaseInOutElastic_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677170);
    LTDescr.NativeMethodInfoPtr_setEasePunch_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677171);
    LTDescr.NativeMethodInfoPtr_setEaseShake_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677172);
    LTDescr.NativeMethodInfoPtr_tweenOnCurve_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677173);
    LTDescr.NativeMethodInfoPtr_easeInOutQuad_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677174);
    LTDescr.NativeMethodInfoPtr_easeInQuad_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677175);
    LTDescr.NativeMethodInfoPtr_easeOutQuad_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677176);
    LTDescr.NativeMethodInfoPtr_easeLinear_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677177);
    LTDescr.NativeMethodInfoPtr_easeSpring_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677178);
    LTDescr.NativeMethodInfoPtr_easeInCubic_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677179);
    LTDescr.NativeMethodInfoPtr_easeOutCubic_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677180);
    LTDescr.NativeMethodInfoPtr_easeInOutCubic_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677181);
    LTDescr.NativeMethodInfoPtr_easeInQuart_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677182);
    LTDescr.NativeMethodInfoPtr_easeOutQuart_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677183);
    LTDescr.NativeMethodInfoPtr_easeInOutQuart_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677184);
    LTDescr.NativeMethodInfoPtr_easeInQuint_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677185);
    LTDescr.NativeMethodInfoPtr_easeOutQuint_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677186);
    LTDescr.NativeMethodInfoPtr_easeInOutQuint_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677187);
    LTDescr.NativeMethodInfoPtr_easeInSine_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677188);
    LTDescr.NativeMethodInfoPtr_easeOutSine_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677189);
    LTDescr.NativeMethodInfoPtr_easeInOutSine_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677190);
    LTDescr.NativeMethodInfoPtr_easeInExpo_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677191);
    LTDescr.NativeMethodInfoPtr_easeOutExpo_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677192);
    LTDescr.NativeMethodInfoPtr_easeInOutExpo_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677193);
    LTDescr.NativeMethodInfoPtr_easeInCirc_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677194);
    LTDescr.NativeMethodInfoPtr_easeOutCirc_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677195);
    LTDescr.NativeMethodInfoPtr_easeInOutCirc_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677196);
    LTDescr.NativeMethodInfoPtr_easeInBounce_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677197);
    LTDescr.NativeMethodInfoPtr_easeOutBounce_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677198);
    LTDescr.NativeMethodInfoPtr_easeInOutBounce_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677199);
    LTDescr.NativeMethodInfoPtr_easeInBack_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677200);
    LTDescr.NativeMethodInfoPtr_easeOutBack_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677201);
    LTDescr.NativeMethodInfoPtr_easeInOutBack_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677202);
    LTDescr.NativeMethodInfoPtr_easeInElastic_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677203);
    LTDescr.NativeMethodInfoPtr_easeOutElastic_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677204);
    LTDescr.NativeMethodInfoPtr_easeInOutElastic_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677205);
    LTDescr.NativeMethodInfoPtr_setOvershoot_Public_LTDescr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677206);
    LTDescr.NativeMethodInfoPtr_setPeriod_Public_LTDescr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677207);
    LTDescr.NativeMethodInfoPtr_setScale_Public_LTDescr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677208);
    LTDescr.NativeMethodInfoPtr_setEase_Public_LTDescr_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677209);
    LTDescr.NativeMethodInfoPtr_setTo_Public_LTDescr_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677210);
    LTDescr.NativeMethodInfoPtr_setTo_Public_LTDescr_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677211);
    LTDescr.NativeMethodInfoPtr_setFrom_Public_LTDescr_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677212);
    LTDescr.NativeMethodInfoPtr_setFrom_Public_LTDescr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677213);
    LTDescr.NativeMethodInfoPtr_setDiff_Public_LTDescr_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677214);
    LTDescr.NativeMethodInfoPtr_setHasInitialized_Public_LTDescr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677215);
    LTDescr.NativeMethodInfoPtr_setId_Public_LTDescr_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677216);
    LTDescr.NativeMethodInfoPtr_setPassed_Public_LTDescr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677217);
    LTDescr.NativeMethodInfoPtr_setTime_Public_LTDescr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677218);
    LTDescr.NativeMethodInfoPtr_setSpeed_Public_LTDescr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677219);
    LTDescr.NativeMethodInfoPtr_setRepeat_Public_LTDescr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677220);
    LTDescr.NativeMethodInfoPtr_setLoopType_Public_LTDescr_LeanTweenType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677221);
    LTDescr.NativeMethodInfoPtr_setUseEstimatedTime_Public_LTDescr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677222);
    LTDescr.NativeMethodInfoPtr_setIgnoreTimeScale_Public_LTDescr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677223);
    LTDescr.NativeMethodInfoPtr_setUseFrames_Public_LTDescr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677224);
    LTDescr.NativeMethodInfoPtr_setUseManualTime_Public_LTDescr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677225);
    LTDescr.NativeMethodInfoPtr_setLoopCount_Public_LTDescr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677226);
    LTDescr.NativeMethodInfoPtr_setLoopOnce_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677227);
    LTDescr.NativeMethodInfoPtr_setLoopClamp_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677228);
    LTDescr.NativeMethodInfoPtr_setLoopClamp_Public_LTDescr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677229);
    LTDescr.NativeMethodInfoPtr_setLoopPingPong_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677230);
    LTDescr.NativeMethodInfoPtr_setLoopPingPong_Public_LTDescr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677231);
    LTDescr.NativeMethodInfoPtr_setOnComplete_Public_LTDescr_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677232);
    LTDescr.NativeMethodInfoPtr_setOnComplete_Public_LTDescr_Action_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677233);
    LTDescr.NativeMethodInfoPtr_setOnComplete_Public_LTDescr_Action_1_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677234);
    LTDescr.NativeMethodInfoPtr_setOnCompleteParam_Public_LTDescr_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677235);
    LTDescr.NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677236);
    LTDescr.NativeMethodInfoPtr_setOnUpdateRatio_Public_LTDescr_Action_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677237);
    LTDescr.NativeMethodInfoPtr_setOnUpdateObject_Public_LTDescr_Action_2_Single_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677238);
    LTDescr.NativeMethodInfoPtr_setOnUpdateVector2_Public_LTDescr_Action_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677239);
    LTDescr.NativeMethodInfoPtr_setOnUpdateVector3_Public_LTDescr_Action_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677240);
    LTDescr.NativeMethodInfoPtr_setOnUpdateColor_Public_LTDescr_Action_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677241);
    LTDescr.NativeMethodInfoPtr_setOnUpdateColor_Public_LTDescr_Action_2_Color_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677242);
    LTDescr.NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677243);
    LTDescr.NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_2_Color_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677244);
    LTDescr.NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_2_Single_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677245);
    LTDescr.NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_2_Vector3_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677246);
    LTDescr.NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_1_Vector2_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677247);
    LTDescr.NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_1_Vector3_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677248);
    LTDescr.NativeMethodInfoPtr_setOnUpdateParam_Public_LTDescr_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677249);
    LTDescr.NativeMethodInfoPtr_setOrientToPath_Public_LTDescr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677250);
    LTDescr.NativeMethodInfoPtr_setOrientToPath2d_Public_LTDescr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677251);
    LTDescr.NativeMethodInfoPtr_setRect_Public_LTDescr_LTRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677252);
    LTDescr.NativeMethodInfoPtr_setRect_Public_LTDescr_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677253);
    LTDescr.NativeMethodInfoPtr_setPath_Public_LTDescr_LTBezierPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677254);
    LTDescr.NativeMethodInfoPtr_setPoint_Public_LTDescr_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677255);
    LTDescr.NativeMethodInfoPtr_setDestroyOnComplete_Public_LTDescr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677256);
    LTDescr.NativeMethodInfoPtr_setAudio_Public_LTDescr_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677257);
    LTDescr.NativeMethodInfoPtr_setOnCompleteOnRepeat_Public_LTDescr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677258);
    LTDescr.NativeMethodInfoPtr_setOnCompleteOnStart_Public_LTDescr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677259);
    LTDescr.NativeMethodInfoPtr_setRect_Public_LTDescr_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677260);
    LTDescr.NativeMethodInfoPtr_setSprites_Public_LTDescr_Il2CppReferenceArray_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677261);
    LTDescr.NativeMethodInfoPtr_setFrameRate_Public_LTDescr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677262);
    LTDescr.NativeMethodInfoPtr_setOnStart_Public_LTDescr_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677263);
    LTDescr.NativeMethodInfoPtr_setDirection_Public_LTDescr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677264);
    LTDescr.NativeMethodInfoPtr_setRecursive_Public_LTDescr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677265);
    LTDescr.NativeMethodInfoPtr__setMoveX_b__73_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677266);
    LTDescr.NativeMethodInfoPtr__setMoveX_b__73_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677267);
    LTDescr.NativeMethodInfoPtr__setMoveY_b__74_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677268);
    LTDescr.NativeMethodInfoPtr__setMoveY_b__74_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677269);
    LTDescr.NativeMethodInfoPtr__setMoveZ_b__75_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677270);
    LTDescr.NativeMethodInfoPtr__setMoveZ_b__75_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677271);
    LTDescr.NativeMethodInfoPtr__setMoveLocalX_b__76_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677272);
    LTDescr.NativeMethodInfoPtr__setMoveLocalX_b__76_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677273);
    LTDescr.NativeMethodInfoPtr__setMoveLocalY_b__77_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677274);
    LTDescr.NativeMethodInfoPtr__setMoveLocalY_b__77_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677275);
    LTDescr.NativeMethodInfoPtr__setMoveLocalZ_b__78_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677276);
    LTDescr.NativeMethodInfoPtr__setMoveLocalZ_b__78_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677277);
    LTDescr.NativeMethodInfoPtr__setMoveCurved_b__81_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677278);
    LTDescr.NativeMethodInfoPtr__setMoveCurvedLocal_b__82_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677279);
    LTDescr.NativeMethodInfoPtr__setMoveSpline_b__83_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677280);
    LTDescr.NativeMethodInfoPtr__setMoveSplineLocal_b__84_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677281);
    LTDescr.NativeMethodInfoPtr__setScaleX_b__85_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677282);
    LTDescr.NativeMethodInfoPtr__setScaleX_b__85_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677283);
    LTDescr.NativeMethodInfoPtr__setScaleY_b__86_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677284);
    LTDescr.NativeMethodInfoPtr__setScaleY_b__86_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677285);
    LTDescr.NativeMethodInfoPtr__setScaleZ_b__87_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677286);
    LTDescr.NativeMethodInfoPtr__setScaleZ_b__87_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677287);
    LTDescr.NativeMethodInfoPtr__setRotateX_b__88_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677288);
    LTDescr.NativeMethodInfoPtr__setRotateX_b__88_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677289);
    LTDescr.NativeMethodInfoPtr__setRotateY_b__89_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677290);
    LTDescr.NativeMethodInfoPtr__setRotateY_b__89_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677291);
    LTDescr.NativeMethodInfoPtr__setRotateZ_b__90_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677292);
    LTDescr.NativeMethodInfoPtr__setRotateZ_b__90_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677293);
    LTDescr.NativeMethodInfoPtr__setRotateAround_b__91_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677294);
    LTDescr.NativeMethodInfoPtr__setRotateAround_b__91_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677295);
    LTDescr.NativeMethodInfoPtr__setRotateAroundLocal_b__92_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677296);
    LTDescr.NativeMethodInfoPtr__setRotateAroundLocal_b__92_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677297);
    LTDescr.NativeMethodInfoPtr__setAlpha_b__93_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677298);
    LTDescr.NativeMethodInfoPtr__setAlpha_b__93_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677299);
    LTDescr.NativeMethodInfoPtr__setAlpha_b__93_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677300);
    LTDescr.NativeMethodInfoPtr__setTextAlpha_b__94_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677301);
    LTDescr.NativeMethodInfoPtr__setTextAlpha_b__94_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677302);
    LTDescr.NativeMethodInfoPtr__setAlphaVertex_b__95_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677303);
    LTDescr.NativeMethodInfoPtr__setAlphaVertex_b__95_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677304);
    LTDescr.NativeMethodInfoPtr__setColor_b__96_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677305);
    LTDescr.NativeMethodInfoPtr__setColor_b__96_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677306);
    LTDescr.NativeMethodInfoPtr__setCallbackColor_b__97_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677307);
    LTDescr.NativeMethodInfoPtr__setCallbackColor_b__97_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677308);
    LTDescr.NativeMethodInfoPtr__setTextColor_b__98_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677309);
    LTDescr.NativeMethodInfoPtr__setTextColor_b__98_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677310);
    LTDescr.NativeMethodInfoPtr__setCanvasAlpha_b__99_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677311);
    LTDescr.NativeMethodInfoPtr__setCanvasAlpha_b__99_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677312);
    LTDescr.NativeMethodInfoPtr__setCanvasGroupAlpha_b__100_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677313);
    LTDescr.NativeMethodInfoPtr__setCanvasGroupAlpha_b__100_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677314);
    LTDescr.NativeMethodInfoPtr__setCanvasColor_b__101_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677315);
    LTDescr.NativeMethodInfoPtr__setCanvasColor_b__101_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677316);
    LTDescr.NativeMethodInfoPtr__setCanvasMoveX_b__102_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677317);
    LTDescr.NativeMethodInfoPtr__setCanvasMoveX_b__102_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677318);
    LTDescr.NativeMethodInfoPtr__setCanvasMoveY_b__103_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677319);
    LTDescr.NativeMethodInfoPtr__setCanvasMoveY_b__103_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677320);
    LTDescr.NativeMethodInfoPtr__setCanvasMoveZ_b__104_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677321);
    LTDescr.NativeMethodInfoPtr__setCanvasMoveZ_b__104_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677322);
    LTDescr.NativeMethodInfoPtr__setCanvasRotateAround_b__106_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677323);
    LTDescr.NativeMethodInfoPtr__setCanvasRotateAroundLocal_b__107_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677324);
    LTDescr.NativeMethodInfoPtr__setCanvasPlaySprite_b__108_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677325);
    LTDescr.NativeMethodInfoPtr__setCanvasPlaySprite_b__108_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677326);
    LTDescr.NativeMethodInfoPtr__setCanvasMove_b__109_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677327);
    LTDescr.NativeMethodInfoPtr__setCanvasMove_b__109_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677328);
    LTDescr.NativeMethodInfoPtr__setCanvasScale_b__110_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677329);
    LTDescr.NativeMethodInfoPtr__setCanvasScale_b__110_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677330);
    LTDescr.NativeMethodInfoPtr__setCanvasSizeDelta_b__111_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677331);
    LTDescr.NativeMethodInfoPtr__setCanvasSizeDelta_b__111_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677332);
    LTDescr.NativeMethodInfoPtr__setMove_b__115_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677333);
    LTDescr.NativeMethodInfoPtr__setMove_b__115_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677334);
    LTDescr.NativeMethodInfoPtr__setMoveLocal_b__116_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677335);
    LTDescr.NativeMethodInfoPtr__setMoveLocal_b__116_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677336);
    LTDescr.NativeMethodInfoPtr__setMoveToTransform_b__117_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677337);
    LTDescr.NativeMethodInfoPtr__setMoveToTransform_b__117_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677338);
    LTDescr.NativeMethodInfoPtr__setRotate_b__118_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677339);
    LTDescr.NativeMethodInfoPtr__setRotate_b__118_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677340);
    LTDescr.NativeMethodInfoPtr__setRotateLocal_b__119_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677341);
    LTDescr.NativeMethodInfoPtr__setRotateLocal_b__119_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677342);
    LTDescr.NativeMethodInfoPtr__setScale_b__120_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677343);
    LTDescr.NativeMethodInfoPtr__setScale_b__120_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677344);
    LTDescr.NativeMethodInfoPtr__setGUIMove_b__121_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677345);
    LTDescr.NativeMethodInfoPtr__setGUIMove_b__121_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677346);
    LTDescr.NativeMethodInfoPtr__setGUIMoveMargin_b__122_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677347);
    LTDescr.NativeMethodInfoPtr__setGUIMoveMargin_b__122_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677348);
    LTDescr.NativeMethodInfoPtr__setGUIScale_b__123_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677349);
    LTDescr.NativeMethodInfoPtr__setGUIScale_b__123_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677350);
    LTDescr.NativeMethodInfoPtr__setGUIAlpha_b__124_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677351);
    LTDescr.NativeMethodInfoPtr__setGUIAlpha_b__124_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677352);
    LTDescr.NativeMethodInfoPtr__setGUIRotate_b__125_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677353);
    LTDescr.NativeMethodInfoPtr__setGUIRotate_b__125_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677354);
    LTDescr.NativeMethodInfoPtr__setDelayedSound_b__126_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100677355);
  }

  public LTDescr(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe bool toggle
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_toggle));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_toggle)) = value;
    }
  }

  public unsafe bool useEstimatedTime
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_useEstimatedTime));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_useEstimatedTime)) = value;
    }
  }

  public unsafe bool useFrames
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_useFrames));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_useFrames)) = value;
    }
  }

  public unsafe bool useManualTime
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_useManualTime));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_useManualTime)) = value;
    }
  }

  public unsafe bool usesNormalDt
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_usesNormalDt));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_usesNormalDt)) = value;
    }
  }

  public unsafe bool hasInitiliazed
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_hasInitiliazed));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_hasInitiliazed)) = value;
    }
  }

  public unsafe bool hasExtraOnCompletes
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_hasExtraOnCompletes));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_hasExtraOnCompletes)) = value;
    }
  }

  public unsafe bool hasPhysics
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_hasPhysics));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_hasPhysics)) = value;
    }
  }

  public unsafe bool onCompleteOnRepeat
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_onCompleteOnRepeat));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_onCompleteOnRepeat)) = value;
    }
  }

  public unsafe bool onCompleteOnStart
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_onCompleteOnStart));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_onCompleteOnStart)) = value;
    }
  }

  public unsafe bool useRecursion
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_useRecursion));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_useRecursion)) = value;
    }
  }

  public unsafe float ratioPassed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_ratioPassed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_ratioPassed)) = value;
    }
  }

  public unsafe float passed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_passed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_passed)) = value;
    }
  }

  public unsafe float delay
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_delay));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_delay)) = value;
    }
  }

  public unsafe float time
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_time));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_time)) = value;
    }
  }

  public unsafe float speed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_speed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_speed)) = value;
    }
  }

  public unsafe float lastVal
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_lastVal));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_lastVal)) = value;
    }
  }

  public unsafe uint _id
  {
    get
    {
      return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr__id));
    }
    [param: In] set
    {
      *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr__id)) = value;
    }
  }

  public unsafe int loopCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_loopCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_loopCount)) = value;
    }
  }

  public unsafe uint counter
  {
    get
    {
      return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_counter));
    }
    [param: In] set
    {
      *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_counter)) = value;
    }
  }

  public unsafe float direction
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_direction));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_direction)) = value;
    }
  }

  public unsafe float directionLast
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_directionLast));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_directionLast)) = value;
    }
  }

  public unsafe float overshoot
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_overshoot));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_overshoot)) = value;
    }
  }

  public unsafe float period
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_period));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_period)) = value;
    }
  }

  public unsafe float scale
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_scale));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_scale)) = value;
    }
  }

  public unsafe bool destroyOnComplete
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_destroyOnComplete));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_destroyOnComplete)) = value;
    }
  }

  public unsafe Transform trans
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_trans));
      return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_trans), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 fromInternal
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_fromInternal));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_fromInternal)) = value;
    }
  }

  public unsafe Vector3 toInternal
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_toInternal));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_toInternal)) = value;
    }
  }

  public unsafe Vector3 diff
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_diff));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_diff)) = value;
    }
  }

  public unsafe Vector3 diffDiv2
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_diffDiv2));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_diffDiv2)) = value;
    }
  }

  public unsafe TweenAction type
  {
    get
    {
      return *(TweenAction*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_type));
    }
    [param: In] set
    {
      *(TweenAction*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_type)) = value;
    }
  }

  public unsafe LeanTweenType easeType
  {
    get
    {
      return *(LeanTweenType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_easeType));
    }
    [param: In] set
    {
      *(LeanTweenType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_easeType)) = value;
    }
  }

  public unsafe LeanTweenType loopType
  {
    get
    {
      return *(LeanTweenType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_loopType));
    }
    [param: In] set
    {
      *(LeanTweenType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_loopType)) = value;
    }
  }

  public unsafe bool hasUpdateCallback
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_hasUpdateCallback));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_hasUpdateCallback)) = value;
    }
  }

  public unsafe LTDescr.EaseTypeDelegate easeMethod
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_easeMethod));
      return pointer == System.IntPtr.Zero ? (LTDescr.EaseTypeDelegate) null : new LTDescr.EaseTypeDelegate(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_easeMethod), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LTDescr.ActionMethodDelegate _easeInternal_k__BackingField
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr__easeInternal_k__BackingField));
      return pointer == System.IntPtr.Zero ? (LTDescr.ActionMethodDelegate) null : new LTDescr.ActionMethodDelegate(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr__easeInternal_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LTDescr.ActionMethodDelegate _initInternal_k__BackingField
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr__initInternal_k__BackingField));
      return pointer == System.IntPtr.Zero ? (LTDescr.ActionMethodDelegate) null : new LTDescr.ActionMethodDelegate(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr__initInternal_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SpriteRenderer spriteRen
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_spriteRen));
      return pointer == System.IntPtr.Zero ? (SpriteRenderer) null : new SpriteRenderer(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_spriteRen), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform rectTransform
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_rectTransform));
      return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_rectTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEngine.UI.Text uiText
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_uiText));
      return pointer == System.IntPtr.Zero ? (UnityEngine.UI.Text) null : new UnityEngine.UI.Text(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_uiText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image uiImage
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_uiImage));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_uiImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RawImage rawImage
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_rawImage));
      return pointer == System.IntPtr.Zero ? (RawImage) null : new RawImage(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_rawImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<Sprite> sprites
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_sprites));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Sprite>) null : new Il2CppReferenceArray<Sprite>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_sprites), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LTDescrOptional _optional
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr__optional));
      return pointer == System.IntPtr.Zero ? (LTDescrOptional) null : new LTDescrOptional(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr__optional), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe float val
  {
    get
    {
      float val;
      IL2CPP.il2cpp_field_static_get_value(LTDescr.NativeFieldInfoPtr_val, (void*) &val);
      return val;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LTDescr.NativeFieldInfoPtr_val, (void*) &value);
    }
  }

  public static unsafe float dt
  {
    get
    {
      float dt;
      IL2CPP.il2cpp_field_static_get_value(LTDescr.NativeFieldInfoPtr_dt, (void*) &dt);
      return dt;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LTDescr.NativeFieldInfoPtr_dt, (void*) &value);
    }
  }

  public static unsafe Vector3 newVect
  {
    get
    {
      Vector3 newVect;
      IL2CPP.il2cpp_field_static_get_value(LTDescr.NativeFieldInfoPtr_newVect, (void*) &newVect);
      return newVect;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LTDescr.NativeFieldInfoPtr_newVect, (void*) &value);
    }
  }

  public sealed class EaseTypeDelegate : Il2CppSystem.MulticastDelegate
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Vector3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Vector3_IAsyncResult_0;

    [CallerCount(37)]
    [CachedScanResults(RefRangeStart = 133459, RefRangeEnd = 133496, XrefRangeStart = 133453, XrefRangeEnd = 133459, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EaseTypeDelegate(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LTDescr.EaseTypeDelegate>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LTDescr.EaseTypeDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe Vector3 Invoke()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.EaseTypeDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 67134, RefRangeEnd = 67135, XrefRangeStart = 67134, XrefRangeEnd = 67135, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
      Il2CppSystem.AsyncCallback callback,
      Il2CppSystem.Object @object)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.EaseTypeDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133496, XrefRangeEnd = 133498, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Vector3 EndInvoke(Il2CppSystem.IAsyncResult result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.EaseTypeDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Vector3_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
    }

    static EaseTypeDelegate()
    {
      Il2CppClassPointerStore<LTDescr.EaseTypeDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, nameof (EaseTypeDelegate));
      LTDescr.EaseTypeDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr.EaseTypeDelegate>.NativeClassPtr, 100677356);
      LTDescr.EaseTypeDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr.EaseTypeDelegate>.NativeClassPtr, 100677357);
      LTDescr.EaseTypeDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr.EaseTypeDelegate>.NativeClassPtr, 100677358);
      LTDescr.EaseTypeDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Vector3_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr.EaseTypeDelegate>.NativeClassPtr, 100677359);
    }

    public EaseTypeDelegate(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static implicit operator LTDescr.EaseTypeDelegate([In] System.Func<Vector3> obj0)
    {
      return DelegateSupport.ConvertDelegate<LTDescr.EaseTypeDelegate>((System.Delegate) obj0);
    }

    public static LTDescr.EaseTypeDelegate operator +(
      [In] LTDescr.EaseTypeDelegate obj0,
      [In] LTDescr.EaseTypeDelegate obj1)
    {
      return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<LTDescr.EaseTypeDelegate>();
    }

    public static LTDescr.EaseTypeDelegate operator -(
      [In] LTDescr.EaseTypeDelegate obj0,
      [In] LTDescr.EaseTypeDelegate obj1)
    {
      Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
      return (object) @delegate == null ? (LTDescr.EaseTypeDelegate) @delegate : @delegate.Cast<LTDescr.EaseTypeDelegate>();
    }
  }

  public sealed class ActionMethodDelegate : Il2CppSystem.MulticastDelegate
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

    [CallerCount(476)]
    [CachedScanResults(RefRangeStart = 133504, RefRangeEnd = 133980, XrefRangeStart = 133498, XrefRangeEnd = 133504, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ActionMethodDelegate(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LTDescr.ActionMethodDelegate>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LTDescr.ActionMethodDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe void Invoke()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LTDescr.ActionMethodDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 67134, RefRangeEnd = 67135, XrefRangeStart = 67134, XrefRangeEnd = 67135, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
      Il2CppSystem.AsyncCallback callback,
      Il2CppSystem.Object @object)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTDescr.ActionMethodDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 67136, RefRangeEnd = 67137, XrefRangeStart = 67136, XrefRangeEnd = 67137, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LTDescr.ActionMethodDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ActionMethodDelegate()
    {
      Il2CppClassPointerStore<LTDescr.ActionMethodDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, nameof (ActionMethodDelegate));
      LTDescr.ActionMethodDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr.ActionMethodDelegate>.NativeClassPtr, 100677360);
      LTDescr.ActionMethodDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr.ActionMethodDelegate>.NativeClassPtr, 100677361);
      LTDescr.ActionMethodDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr.ActionMethodDelegate>.NativeClassPtr, 100677362);
      LTDescr.ActionMethodDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr.ActionMethodDelegate>.NativeClassPtr, 100677363);
    }

    public ActionMethodDelegate(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static implicit operator LTDescr.ActionMethodDelegate([In] System.Action obj0)
    {
      return DelegateSupport.ConvertDelegate<LTDescr.ActionMethodDelegate>((System.Delegate) obj0);
    }

    public static LTDescr.ActionMethodDelegate operator +(
      [In] LTDescr.ActionMethodDelegate obj0,
      [In] LTDescr.ActionMethodDelegate obj1)
    {
      return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<LTDescr.ActionMethodDelegate>();
    }

    public static LTDescr.ActionMethodDelegate operator -(
      [In] LTDescr.ActionMethodDelegate obj0,
      [In] LTDescr.ActionMethodDelegate obj1)
    {
      Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
      return (object) @delegate == null ? (LTDescr.ActionMethodDelegate) @delegate : @delegate.Cast<LTDescr.ActionMethodDelegate>();
    }
  }

  [ObfuscatedName("LTDescr/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__113_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__114_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__setCallback_b__113_0_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__setValue3_b__114_0_Internal_Void_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LTDescr.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LTDescr.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _setCallback_b__113_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LTDescr.__c.NativeMethodInfoPtr__setCallback_b__113_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _setValue3_b__114_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LTDescr.__c.NativeMethodInfoPtr__setValue3_b__114_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static __c()
    {
      Il2CppClassPointerStore<LTDescr.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LTDescr.__c>.NativeClassPtr);
      LTDescr.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr.__c>.NativeClassPtr, "<>9");
      LTDescr.__c.NativeFieldInfoPtr___9__113_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr.__c>.NativeClassPtr, "<>9__113_0");
      LTDescr.__c.NativeFieldInfoPtr___9__114_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr.__c>.NativeClassPtr, "<>9__114_0");
      LTDescr.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr.__c>.NativeClassPtr, 100677365);
      LTDescr.__c.NativeMethodInfoPtr__setCallback_b__113_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr.__c>.NativeClassPtr, 100677366);
      LTDescr.__c.NativeMethodInfoPtr__setValue3_b__114_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr.__c>.NativeClassPtr, 100677367);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe LTDescr.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(LTDescr.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (LTDescr.__c) null : new LTDescr.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LTDescr.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe LTDescr.ActionMethodDelegate __9__113_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(LTDescr.__c.NativeFieldInfoPtr___9__113_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (LTDescr.ActionMethodDelegate) null : new LTDescr.ActionMethodDelegate(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LTDescr.__c.NativeFieldInfoPtr___9__113_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe LTDescr.ActionMethodDelegate __9__114_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(LTDescr.__c.NativeFieldInfoPtr___9__114_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (LTDescr.ActionMethodDelegate) null : new LTDescr.ActionMethodDelegate(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LTDescr.__c.NativeFieldInfoPtr___9__114_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
