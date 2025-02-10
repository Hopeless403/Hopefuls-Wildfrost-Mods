// Decompiled with JetBrains decompiler
// Type: TweenUI
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

#nullable disable
public class TweenUI : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_target;
  private static readonly System.IntPtr NativeFieldInfoPtr_fireOnEnable;
  private static readonly System.IntPtr NativeFieldInfoPtr_fireOnStart;
  private static readonly System.IntPtr NativeFieldInfoPtr_enableOnFire;
  private static readonly System.IntPtr NativeFieldInfoPtr_disableAfter;
  private static readonly System.IntPtr NativeFieldInfoPtr_multi;
  private static readonly System.IntPtr NativeFieldInfoPtr_property;
  private static readonly System.IntPtr NativeFieldInfoPtr_ease;
  private static readonly System.IntPtr NativeFieldInfoPtr_animationCurve;
  private static readonly System.IntPtr NativeFieldInfoPtr_randomSigns;
  private static readonly System.IntPtr NativeFieldInfoPtr_randomDuration;
  private static readonly System.IntPtr NativeFieldInfoPtr_duration;
  private static readonly System.IntPtr NativeFieldInfoPtr_durationRange;
  private static readonly System.IntPtr NativeFieldInfoPtr_randomDelay;
  private static readonly System.IntPtr NativeFieldInfoPtr_delay;
  private static readonly System.IntPtr NativeFieldInfoPtr_delayRange;
  private static readonly System.IntPtr NativeFieldInfoPtr_to;
  private static readonly System.IntPtr NativeFieldInfoPtr_hasFrom;
  private static readonly System.IntPtr NativeFieldInfoPtr_from;
  private static readonly System.IntPtr NativeFieldInfoPtr_tweens;
  private static readonly System.IntPtr NativeFieldInfoPtr_cancelOtherTweens;
  private static readonly System.IntPtr NativeFieldInfoPtr_ignoreTimeScale;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_multiOrRandomDuration_Private_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_multiOrRandomDelay_Private_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsAnimationCurve_Private_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_FireOnStart_Private_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Fire_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDuration_Public_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetFrom_Private_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__Fire_b__33_0_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__Fire_b__33_1_Private_Void_0;

  public unsafe bool multiOrRandomDuration
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TweenUI.NativeMethodInfoPtr_get_multiOrRandomDuration_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public unsafe bool multiOrRandomDelay
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TweenUI.NativeMethodInfoPtr_get_multiOrRandomDelay_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public unsafe bool IsAnimationCurve
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TweenUI.NativeMethodInfoPtr_get_IsAnimationCurve_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public unsafe bool FireOnStart
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TweenUI.NativeMethodInfoPtr_get_FireOnStart_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86061, XrefRangeEnd = 86062, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TweenUI.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86062, XrefRangeEnd = 86063, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TweenUI.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(34)]
  [CachedScanResults(RefRangeStart = 86104, RefRangeEnd = 86138, XrefRangeStart = 86063, XrefRangeEnd = 86104, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Fire()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TweenUI.NativeMethodInfoPtr_Fire_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(9)]
  [CachedScanResults(RefRangeStart = 86138, RefRangeEnd = 86147, XrefRangeStart = 86138, XrefRangeEnd = 86138, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float GetDuration()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TweenUI.NativeMethodInfoPtr_GetDuration_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 86158, RefRangeEnd = 86161, XrefRangeStart = 86147, XrefRangeEnd = 86158, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 GetFrom()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TweenUI.NativeMethodInfoPtr_GetFrom_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86161, XrefRangeEnd = 86162, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TweenUI()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TweenUI>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TweenUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86162, XrefRangeEnd = 86165, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _Fire_b__33_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TweenUI.NativeMethodInfoPtr__Fire_b__33_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _Fire_b__33_1()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TweenUI.NativeMethodInfoPtr__Fire_b__33_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static TweenUI()
  {
    Il2CppClassPointerStore<TweenUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (TweenUI));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TweenUI>.NativeClassPtr);
    TweenUI.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenUI>.NativeClassPtr, nameof (target));
    TweenUI.NativeFieldInfoPtr_fireOnEnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenUI>.NativeClassPtr, nameof (fireOnEnable));
    TweenUI.NativeFieldInfoPtr_fireOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenUI>.NativeClassPtr, nameof (fireOnStart));
    TweenUI.NativeFieldInfoPtr_enableOnFire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenUI>.NativeClassPtr, nameof (enableOnFire));
    TweenUI.NativeFieldInfoPtr_disableAfter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenUI>.NativeClassPtr, nameof (disableAfter));
    TweenUI.NativeFieldInfoPtr_multi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenUI>.NativeClassPtr, nameof (multi));
    TweenUI.NativeFieldInfoPtr_property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenUI>.NativeClassPtr, nameof (property));
    TweenUI.NativeFieldInfoPtr_ease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenUI>.NativeClassPtr, nameof (ease));
    TweenUI.NativeFieldInfoPtr_animationCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenUI>.NativeClassPtr, nameof (animationCurve));
    TweenUI.NativeFieldInfoPtr_randomSigns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenUI>.NativeClassPtr, nameof (randomSigns));
    TweenUI.NativeFieldInfoPtr_randomDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenUI>.NativeClassPtr, nameof (randomDuration));
    TweenUI.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenUI>.NativeClassPtr, nameof (duration));
    TweenUI.NativeFieldInfoPtr_durationRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenUI>.NativeClassPtr, nameof (durationRange));
    TweenUI.NativeFieldInfoPtr_randomDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenUI>.NativeClassPtr, nameof (randomDelay));
    TweenUI.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenUI>.NativeClassPtr, nameof (delay));
    TweenUI.NativeFieldInfoPtr_delayRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenUI>.NativeClassPtr, nameof (delayRange));
    TweenUI.NativeFieldInfoPtr_to = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenUI>.NativeClassPtr, nameof (to));
    TweenUI.NativeFieldInfoPtr_hasFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenUI>.NativeClassPtr, nameof (hasFrom));
    TweenUI.NativeFieldInfoPtr_from = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenUI>.NativeClassPtr, nameof (from));
    TweenUI.NativeFieldInfoPtr_tweens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenUI>.NativeClassPtr, nameof (tweens));
    TweenUI.NativeFieldInfoPtr_cancelOtherTweens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenUI>.NativeClassPtr, nameof (cancelOtherTweens));
    TweenUI.NativeFieldInfoPtr_ignoreTimeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenUI>.NativeClassPtr, nameof (ignoreTimeScale));
    TweenUI.NativeMethodInfoPtr_get_multiOrRandomDuration_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenUI>.NativeClassPtr, 100670546);
    TweenUI.NativeMethodInfoPtr_get_multiOrRandomDelay_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenUI>.NativeClassPtr, 100670547);
    TweenUI.NativeMethodInfoPtr_get_IsAnimationCurve_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenUI>.NativeClassPtr, 100670548);
    TweenUI.NativeMethodInfoPtr_get_FireOnStart_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenUI>.NativeClassPtr, 100670549);
    TweenUI.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenUI>.NativeClassPtr, 100670550);
    TweenUI.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenUI>.NativeClassPtr, 100670551);
    TweenUI.NativeMethodInfoPtr_Fire_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenUI>.NativeClassPtr, 100670552);
    TweenUI.NativeMethodInfoPtr_GetDuration_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenUI>.NativeClassPtr, 100670553);
    TweenUI.NativeMethodInfoPtr_GetFrom_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenUI>.NativeClassPtr, 100670554);
    TweenUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenUI>.NativeClassPtr, 100670555);
    TweenUI.NativeMethodInfoPtr__Fire_b__33_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenUI>.NativeClassPtr, 100670556);
    TweenUI.NativeMethodInfoPtr__Fire_b__33_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenUI>.NativeClassPtr, 100670557);
  }

  public TweenUI(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe GameObject target
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.NativeFieldInfoPtr_target));
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool fireOnEnable
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.NativeFieldInfoPtr_fireOnEnable));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.NativeFieldInfoPtr_fireOnEnable)) = value;
    }
  }

  public unsafe bool fireOnStart
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.NativeFieldInfoPtr_fireOnStart));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.NativeFieldInfoPtr_fireOnStart)) = value;
    }
  }

  public unsafe bool enableOnFire
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.NativeFieldInfoPtr_enableOnFire));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.NativeFieldInfoPtr_enableOnFire)) = value;
    }
  }

  public unsafe bool disableAfter
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.NativeFieldInfoPtr_disableAfter));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.NativeFieldInfoPtr_disableAfter)) = value;
    }
  }

  public unsafe bool multi
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.NativeFieldInfoPtr_multi));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.NativeFieldInfoPtr_multi)) = value;
    }
  }

  public unsafe TweenUI.Property property
  {
    get
    {
      return *(TweenUI.Property*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.NativeFieldInfoPtr_property));
    }
    [param: In] set
    {
      *(TweenUI.Property*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.NativeFieldInfoPtr_property)) = value;
    }
  }

  public unsafe LeanTweenType ease
  {
    get
    {
      return *(LeanTweenType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.NativeFieldInfoPtr_ease));
    }
    [param: In] set
    {
      *(LeanTweenType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.NativeFieldInfoPtr_ease)) = value;
    }
  }

  public unsafe AnimationCurve animationCurve
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.NativeFieldInfoPtr_animationCurve));
      return pointer == System.IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.NativeFieldInfoPtr_animationCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool randomSigns
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.NativeFieldInfoPtr_randomSigns));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.NativeFieldInfoPtr_randomSigns)) = value;
    }
  }

  public unsafe bool randomDuration
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.NativeFieldInfoPtr_randomDuration));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.NativeFieldInfoPtr_randomDuration)) = value;
    }
  }

  public unsafe float duration
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.NativeFieldInfoPtr_duration));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.NativeFieldInfoPtr_duration)) = value;
    }
  }

  public unsafe Vector2 durationRange
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.NativeFieldInfoPtr_durationRange));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.NativeFieldInfoPtr_durationRange)) = value;
    }
  }

  public unsafe bool randomDelay
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.NativeFieldInfoPtr_randomDelay));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.NativeFieldInfoPtr_randomDelay)) = value;
    }
  }

  public unsafe float delay
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.NativeFieldInfoPtr_delay));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.NativeFieldInfoPtr_delay)) = value;
    }
  }

  public unsafe Vector2 delayRange
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.NativeFieldInfoPtr_delayRange));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.NativeFieldInfoPtr_delayRange)) = value;
    }
  }

  public unsafe Vector3 to
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.NativeFieldInfoPtr_to));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.NativeFieldInfoPtr_to)) = value;
    }
  }

  public unsafe bool hasFrom
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.NativeFieldInfoPtr_hasFrom));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.NativeFieldInfoPtr_hasFrom)) = value;
    }
  }

  public unsafe Vector3 from
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.NativeFieldInfoPtr_from));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.NativeFieldInfoPtr_from)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<TweenUI.Tween> tweens
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.NativeFieldInfoPtr_tweens));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<TweenUI.Tween>) null : new Il2CppReferenceArray<TweenUI.Tween>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.NativeFieldInfoPtr_tweens), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool cancelOtherTweens
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.NativeFieldInfoPtr_cancelOtherTweens));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.NativeFieldInfoPtr_cancelOtherTweens)) = value;
    }
  }

  public unsafe bool ignoreTimeScale
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.NativeFieldInfoPtr_ignoreTimeScale));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.NativeFieldInfoPtr_ignoreTimeScale)) = value;
    }
  }

  public enum Property
  {
    Move,
    Rotate,
    Scale,
  }

  [Serializable]
  public sealed class Tween : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_property;
    private static readonly System.IntPtr NativeFieldInfoPtr_ease;
    private static readonly System.IntPtr NativeFieldInfoPtr_curve;
    private static readonly System.IntPtr NativeFieldInfoPtr_randomSigns;
    private static readonly System.IntPtr NativeFieldInfoPtr_duration;
    private static readonly System.IntPtr NativeFieldInfoPtr_delay;
    private static readonly System.IntPtr NativeFieldInfoPtr_to;
    private static readonly System.IntPtr NativeFieldInfoPtr_hasFrom;
    private static readonly System.IntPtr NativeFieldInfoPtr_from;
    private static readonly System.IntPtr NativeMethodInfoPtr_Fire_Public_Void_GameObject_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetFrom_Private_Vector3_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86020, XrefRangeEnd = 86047, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Fire(GameObject target, bool ignoreTimeScale)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreTimeScale;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TweenUI.Tween.NativeMethodInfoPtr_Fire_Public_Void_GameObject_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 86058, RefRangeEnd = 86061, XrefRangeStart = 86047, XrefRangeEnd = 86058, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Vector3 GetFrom()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TweenUI.Tween.NativeMethodInfoPtr_GetFrom_Private_Vector3_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
    }

    static Tween()
    {
      Il2CppClassPointerStore<TweenUI.Tween>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TweenUI>.NativeClassPtr, nameof (Tween));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TweenUI.Tween>.NativeClassPtr);
      TweenUI.Tween.NativeFieldInfoPtr_property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenUI.Tween>.NativeClassPtr, nameof (property));
      TweenUI.Tween.NativeFieldInfoPtr_ease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenUI.Tween>.NativeClassPtr, nameof (ease));
      TweenUI.Tween.NativeFieldInfoPtr_curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenUI.Tween>.NativeClassPtr, nameof (curve));
      TweenUI.Tween.NativeFieldInfoPtr_randomSigns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenUI.Tween>.NativeClassPtr, nameof (randomSigns));
      TweenUI.Tween.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenUI.Tween>.NativeClassPtr, nameof (duration));
      TweenUI.Tween.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenUI.Tween>.NativeClassPtr, nameof (delay));
      TweenUI.Tween.NativeFieldInfoPtr_to = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenUI.Tween>.NativeClassPtr, nameof (to));
      TweenUI.Tween.NativeFieldInfoPtr_hasFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenUI.Tween>.NativeClassPtr, nameof (hasFrom));
      TweenUI.Tween.NativeFieldInfoPtr_from = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenUI.Tween>.NativeClassPtr, nameof (from));
      TweenUI.Tween.NativeMethodInfoPtr_Fire_Public_Void_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenUI.Tween>.NativeClassPtr, 100670558);
      TweenUI.Tween.NativeMethodInfoPtr_GetFrom_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenUI.Tween>.NativeClassPtr, 100670559);
    }

    public Tween(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Tween()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TweenUI.Tween>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TweenUI.Tween>.NativeClassPtr, data));
    }

    public unsafe TweenUI.Property property
    {
      get
      {
        return *(TweenUI.Property*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.Tween.NativeFieldInfoPtr_property));
      }
      [param: In] set
      {
        *(TweenUI.Property*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.Tween.NativeFieldInfoPtr_property)) = value;
      }
    }

    public unsafe LeanTweenType ease
    {
      get
      {
        return *(LeanTweenType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.Tween.NativeFieldInfoPtr_ease));
      }
      [param: In] set
      {
        *(LeanTweenType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.Tween.NativeFieldInfoPtr_ease)) = value;
      }
    }

    public unsafe AnimationCurve curve
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.Tween.NativeFieldInfoPtr_curve));
        return pointer == System.IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.Tween.NativeFieldInfoPtr_curve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool randomSigns
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.Tween.NativeFieldInfoPtr_randomSigns));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.Tween.NativeFieldInfoPtr_randomSigns)) = value;
      }
    }

    public unsafe float duration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.Tween.NativeFieldInfoPtr_duration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.Tween.NativeFieldInfoPtr_duration)) = value;
      }
    }

    public unsafe float delay
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.Tween.NativeFieldInfoPtr_delay));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.Tween.NativeFieldInfoPtr_delay)) = value;
      }
    }

    public unsafe Vector3 to
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.Tween.NativeFieldInfoPtr_to));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.Tween.NativeFieldInfoPtr_to)) = value;
      }
    }

    public unsafe bool hasFrom
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.Tween.NativeFieldInfoPtr_hasFrom));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.Tween.NativeFieldInfoPtr_hasFrom)) = value;
      }
    }

    public unsafe Vector3 from
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.Tween.NativeFieldInfoPtr_from));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TweenUI.Tween.NativeFieldInfoPtr_from)) = value;
      }
    }
  }
}
