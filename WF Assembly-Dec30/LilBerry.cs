// Decompiled with JetBrains decompiler
// Type: LilBerry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class LilBerry : ScriptableCardImage
{
  private static readonly IntPtr NativeFieldInfoPtr_image;
  private static readonly IntPtr NativeFieldInfoPtr_scaleCurve;
  private static readonly IntPtr NativeFieldInfoPtr_tweenCurve;
  private static readonly IntPtr NativeFieldInfoPtr_tweenDur;
  private static readonly IntPtr NativeFieldInfoPtr_scaleFrom;
  private static readonly IntPtr NativeFieldInfoPtr_scaleTo;
  private static readonly IntPtr NativeFieldInfoPtr_tweenT;
  private static readonly IntPtr NativeFieldInfoPtr_tween;
  private static readonly IntPtr NativeFieldInfoPtr_currentSet;
  private static readonly IntPtr NativeFieldInfoPtr_current;
  private static readonly IntPtr NativeMethodInfoPtr_UpdateEvent_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetScale_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_StartScaleTween_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21171, XrefRangeEnd = 21175, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void UpdateEvent()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LilBerry.NativeMethodInfoPtr_UpdateEvent_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21175, XrefRangeEnd = 21177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetScale()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LilBerry.NativeMethodInfoPtr_SetScale_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public unsafe void StartScaleTween()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LilBerry.NativeMethodInfoPtr_StartScaleTween_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21177, XrefRangeEnd = 21181, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LilBerry.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21181, XrefRangeEnd = 21182, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LilBerry()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LilBerry>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LilBerry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static LilBerry()
  {
    Il2CppClassPointerStore<LilBerry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (LilBerry));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LilBerry>.NativeClassPtr);
    LilBerry.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LilBerry>.NativeClassPtr, nameof (image));
    LilBerry.NativeFieldInfoPtr_scaleCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LilBerry>.NativeClassPtr, nameof (scaleCurve));
    LilBerry.NativeFieldInfoPtr_tweenCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LilBerry>.NativeClassPtr, nameof (tweenCurve));
    LilBerry.NativeFieldInfoPtr_tweenDur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LilBerry>.NativeClassPtr, nameof (tweenDur));
    LilBerry.NativeFieldInfoPtr_scaleFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LilBerry>.NativeClassPtr, nameof (scaleFrom));
    LilBerry.NativeFieldInfoPtr_scaleTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LilBerry>.NativeClassPtr, nameof (scaleTo));
    LilBerry.NativeFieldInfoPtr_tweenT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LilBerry>.NativeClassPtr, nameof (tweenT));
    LilBerry.NativeFieldInfoPtr_tween = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LilBerry>.NativeClassPtr, nameof (tween));
    LilBerry.NativeFieldInfoPtr_currentSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LilBerry>.NativeClassPtr, nameof (currentSet));
    LilBerry.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LilBerry>.NativeClassPtr, nameof (current));
    LilBerry.NativeMethodInfoPtr_UpdateEvent_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LilBerry>.NativeClassPtr, 100663876);
    LilBerry.NativeMethodInfoPtr_SetScale_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LilBerry>.NativeClassPtr, 100663877);
    LilBerry.NativeMethodInfoPtr_StartScaleTween_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LilBerry>.NativeClassPtr, 100663878);
    LilBerry.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LilBerry>.NativeClassPtr, 100663879);
    LilBerry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LilBerry>.NativeClassPtr, 100663880);
  }

  public LilBerry(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Transform image
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LilBerry.NativeFieldInfoPtr_image));
      return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LilBerry.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve scaleCurve
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LilBerry.NativeFieldInfoPtr_scaleCurve));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LilBerry.NativeFieldInfoPtr_scaleCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve tweenCurve
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LilBerry.NativeFieldInfoPtr_tweenCurve));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LilBerry.NativeFieldInfoPtr_tweenCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float tweenDur
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LilBerry.NativeFieldInfoPtr_tweenDur));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LilBerry.NativeFieldInfoPtr_tweenDur)) = value;
    }
  }

  public unsafe float scaleFrom
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LilBerry.NativeFieldInfoPtr_scaleFrom));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LilBerry.NativeFieldInfoPtr_scaleFrom)) = value;
    }
  }

  public unsafe float scaleTo
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LilBerry.NativeFieldInfoPtr_scaleTo));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LilBerry.NativeFieldInfoPtr_scaleTo)) = value;
    }
  }

  public unsafe float tweenT
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LilBerry.NativeFieldInfoPtr_tweenT));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LilBerry.NativeFieldInfoPtr_tweenT)) = value;
    }
  }

  public unsafe bool tween
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LilBerry.NativeFieldInfoPtr_tween));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LilBerry.NativeFieldInfoPtr_tween)) = value;
    }
  }

  public unsafe bool currentSet
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LilBerry.NativeFieldInfoPtr_currentSet));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LilBerry.NativeFieldInfoPtr_currentSet)) = value;
    }
  }

  public unsafe int current
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LilBerry.NativeFieldInfoPtr_current));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LilBerry.NativeFieldInfoPtr_current)) = value;
    }
  }
}
