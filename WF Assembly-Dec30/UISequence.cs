// Decompiled with JetBrains decompiler
// Type: UISequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class UISequence : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_promptEnd;
  private static readonly IntPtr NativeFieldInfoPtr_startDelay;
  private static readonly IntPtr NativeFieldInfoPtr_delayBetween;
  private static readonly IntPtr NativeFieldInfoPtr_tweenInDur;
  private static readonly IntPtr NativeFieldInfoPtr_tweenInEase;
  private static readonly IntPtr NativeFieldInfoPtr_tweenOutDur;
  private static readonly IntPtr NativeFieldInfoPtr_tweenOutEase;
  private static readonly IntPtr NativeFieldInfoPtr_routine;
  private static readonly IntPtr NativeMethodInfoPtr_get_IsRunning_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_Begin_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_End_Public_Virtual_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_EndIfRunning_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_New_IEnumerator_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe bool IsRunning
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 100161, RefRangeEnd = 100163, XrefRangeStart = 100161, XrefRangeEnd = 100161, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(UISequence.NativeMethodInfoPtr_get_IsRunning_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(10)]
  [CachedScanResults(RefRangeStart = 100171, RefRangeEnd = 100181, XrefRangeStart = 100163, XrefRangeEnd = 100171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Begin()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UISequence.NativeMethodInfoPtr_Begin_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(14)]
  [CachedScanResults(RefRangeStart = 66591, RefRangeEnd = 66605, XrefRangeStart = 66591, XrefRangeEnd = 66605, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void End()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UISequence.NativeMethodInfoPtr_End_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100181, XrefRangeEnd = 100182, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EndIfRunning()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UISequence.NativeMethodInfoPtr_EndIfRunning_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(44)]
  [CachedScanResults(RefRangeStart = 26224, RefRangeEnd = 26268, XrefRangeStart = 26224, XrefRangeEnd = 26268, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe IEnumerator Run()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UISequence.NativeMethodInfoPtr_Run_Public_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    IntPtr pointer = num;
    return pointer == IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(15)]
  [CachedScanResults(RefRangeStart = 100183, RefRangeEnd = 100198, XrefRangeStart = 100182, XrefRangeEnd = 100183, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UISequence()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UISequence>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UISequence.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static UISequence()
  {
    Il2CppClassPointerStore<UISequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (UISequence));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UISequence>.NativeClassPtr);
    UISequence.NativeFieldInfoPtr_promptEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISequence>.NativeClassPtr, nameof (promptEnd));
    UISequence.NativeFieldInfoPtr_startDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISequence>.NativeClassPtr, nameof (startDelay));
    UISequence.NativeFieldInfoPtr_delayBetween = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISequence>.NativeClassPtr, nameof (delayBetween));
    UISequence.NativeFieldInfoPtr_tweenInDur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISequence>.NativeClassPtr, nameof (tweenInDur));
    UISequence.NativeFieldInfoPtr_tweenInEase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISequence>.NativeClassPtr, nameof (tweenInEase));
    UISequence.NativeFieldInfoPtr_tweenOutDur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISequence>.NativeClassPtr, nameof (tweenOutDur));
    UISequence.NativeFieldInfoPtr_tweenOutEase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISequence>.NativeClassPtr, nameof (tweenOutEase));
    UISequence.NativeFieldInfoPtr_routine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISequence>.NativeClassPtr, nameof (routine));
    UISequence.NativeMethodInfoPtr_get_IsRunning_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISequence>.NativeClassPtr, 100672278);
    UISequence.NativeMethodInfoPtr_Begin_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISequence>.NativeClassPtr, 100672279);
    UISequence.NativeMethodInfoPtr_End_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISequence>.NativeClassPtr, 100672280);
    UISequence.NativeMethodInfoPtr_EndIfRunning_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISequence>.NativeClassPtr, 100672281);
    UISequence.NativeMethodInfoPtr_Run_Public_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISequence>.NativeClassPtr, 100672282);
    UISequence.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISequence>.NativeClassPtr, 100672283);
  }

  public UISequence(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe bool promptEnd
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISequence.NativeFieldInfoPtr_promptEnd));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISequence.NativeFieldInfoPtr_promptEnd)) = value;
    }
  }

  public unsafe float startDelay
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISequence.NativeFieldInfoPtr_startDelay));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISequence.NativeFieldInfoPtr_startDelay)) = value;
    }
  }

  public unsafe float delayBetween
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISequence.NativeFieldInfoPtr_delayBetween));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISequence.NativeFieldInfoPtr_delayBetween)) = value;
    }
  }

  public unsafe float tweenInDur
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISequence.NativeFieldInfoPtr_tweenInDur));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISequence.NativeFieldInfoPtr_tweenInDur)) = value;
    }
  }

  public unsafe LeanTweenType tweenInEase
  {
    get
    {
      return *(LeanTweenType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISequence.NativeFieldInfoPtr_tweenInEase));
    }
    [param: In] set
    {
      *(LeanTweenType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISequence.NativeFieldInfoPtr_tweenInEase)) = value;
    }
  }

  public unsafe float tweenOutDur
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISequence.NativeFieldInfoPtr_tweenOutDur));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISequence.NativeFieldInfoPtr_tweenOutDur)) = value;
    }
  }

  public unsafe LeanTweenType tweenOutEase
  {
    get
    {
      return *(LeanTweenType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISequence.NativeFieldInfoPtr_tweenOutEase));
    }
    [param: In] set
    {
      *(LeanTweenType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISequence.NativeFieldInfoPtr_tweenOutEase)) = value;
    }
  }

  public unsafe Routine routine
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISequence.NativeFieldInfoPtr_routine));
      return pointer == IntPtr.Zero ? (Routine) null : new Routine(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISequence.NativeFieldInfoPtr_routine), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
