// Decompiled with JetBrains decompiler
// Type: Bolgo
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
public class Bolgo : ScriptableCardImage
{
  private static readonly IntPtr NativeFieldInfoPtr_image;
  private static readonly IntPtr NativeFieldInfoPtr_scaleCurve;
  private static readonly IntPtr NativeFieldInfoPtr_tweenCurve;
  private static readonly IntPtr NativeFieldInfoPtr_tweenDur;
  private static readonly IntPtr NativeFieldInfoPtr_sprites;
  private static readonly IntPtr NativeFieldInfoPtr_spriteIndexCurve;
  private static readonly IntPtr NativeFieldInfoPtr_currentShell;
  private static readonly IntPtr NativeFieldInfoPtr_currentDamageSet;
  private static readonly IntPtr NativeFieldInfoPtr_currentDamage;
  private static readonly IntPtr NativeFieldInfoPtr_scaleFrom;
  private static readonly IntPtr NativeFieldInfoPtr_scaleTo;
  private static readonly IntPtr NativeFieldInfoPtr_tweenT;
  private static readonly IntPtr NativeFieldInfoPtr_tween;
  private static readonly IntPtr NativeMethodInfoPtr_UpdateEvent_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetScale_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_StartScaleTween_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21140, XrefRangeEnd = 21152, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void UpdateEvent()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Bolgo.NativeMethodInfoPtr_UpdateEvent_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21152, XrefRangeEnd = 21155, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetScale()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Bolgo.NativeMethodInfoPtr_SetScale_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public unsafe void StartScaleTween()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Bolgo.NativeMethodInfoPtr_StartScaleTween_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21155, XrefRangeEnd = 21159, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Bolgo.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21159, XrefRangeEnd = 21160, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Bolgo()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Bolgo>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Bolgo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static Bolgo()
  {
    Il2CppClassPointerStore<Bolgo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (Bolgo));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Bolgo>.NativeClassPtr);
    Bolgo.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bolgo>.NativeClassPtr, nameof (image));
    Bolgo.NativeFieldInfoPtr_scaleCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bolgo>.NativeClassPtr, nameof (scaleCurve));
    Bolgo.NativeFieldInfoPtr_tweenCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bolgo>.NativeClassPtr, nameof (tweenCurve));
    Bolgo.NativeFieldInfoPtr_tweenDur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bolgo>.NativeClassPtr, nameof (tweenDur));
    Bolgo.NativeFieldInfoPtr_sprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bolgo>.NativeClassPtr, nameof (sprites));
    Bolgo.NativeFieldInfoPtr_spriteIndexCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bolgo>.NativeClassPtr, nameof (spriteIndexCurve));
    Bolgo.NativeFieldInfoPtr_currentShell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bolgo>.NativeClassPtr, nameof (currentShell));
    Bolgo.NativeFieldInfoPtr_currentDamageSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bolgo>.NativeClassPtr, nameof (currentDamageSet));
    Bolgo.NativeFieldInfoPtr_currentDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bolgo>.NativeClassPtr, nameof (currentDamage));
    Bolgo.NativeFieldInfoPtr_scaleFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bolgo>.NativeClassPtr, nameof (scaleFrom));
    Bolgo.NativeFieldInfoPtr_scaleTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bolgo>.NativeClassPtr, nameof (scaleTo));
    Bolgo.NativeFieldInfoPtr_tweenT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bolgo>.NativeClassPtr, nameof (tweenT));
    Bolgo.NativeFieldInfoPtr_tween = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bolgo>.NativeClassPtr, nameof (tween));
    Bolgo.NativeMethodInfoPtr_UpdateEvent_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bolgo>.NativeClassPtr, 100663869);
    Bolgo.NativeMethodInfoPtr_SetScale_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bolgo>.NativeClassPtr, 100663870);
    Bolgo.NativeMethodInfoPtr_StartScaleTween_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bolgo>.NativeClassPtr, 100663871);
    Bolgo.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bolgo>.NativeClassPtr, 100663872);
    Bolgo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bolgo>.NativeClassPtr, 100663873);
  }

  public Bolgo(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Image image
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Bolgo.NativeFieldInfoPtr_image));
      return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Bolgo.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve scaleCurve
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Bolgo.NativeFieldInfoPtr_scaleCurve));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Bolgo.NativeFieldInfoPtr_scaleCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve tweenCurve
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Bolgo.NativeFieldInfoPtr_tweenCurve));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Bolgo.NativeFieldInfoPtr_tweenCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float tweenDur
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Bolgo.NativeFieldInfoPtr_tweenDur));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Bolgo.NativeFieldInfoPtr_tweenDur)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<Sprite> sprites
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Bolgo.NativeFieldInfoPtr_sprites));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<Sprite>) null : new Il2CppReferenceArray<Sprite>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Bolgo.NativeFieldInfoPtr_sprites), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve spriteIndexCurve
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Bolgo.NativeFieldInfoPtr_spriteIndexCurve));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Bolgo.NativeFieldInfoPtr_spriteIndexCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int currentShell
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Bolgo.NativeFieldInfoPtr_currentShell));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Bolgo.NativeFieldInfoPtr_currentShell)) = value;
    }
  }

  public unsafe bool currentDamageSet
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Bolgo.NativeFieldInfoPtr_currentDamageSet));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Bolgo.NativeFieldInfoPtr_currentDamageSet)) = value;
    }
  }

  public unsafe int currentDamage
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Bolgo.NativeFieldInfoPtr_currentDamage));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Bolgo.NativeFieldInfoPtr_currentDamage)) = value;
    }
  }

  public unsafe float scaleFrom
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Bolgo.NativeFieldInfoPtr_scaleFrom));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Bolgo.NativeFieldInfoPtr_scaleFrom)) = value;
    }
  }

  public unsafe float scaleTo
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Bolgo.NativeFieldInfoPtr_scaleTo));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Bolgo.NativeFieldInfoPtr_scaleTo)) = value;
    }
  }

  public unsafe float tweenT
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Bolgo.NativeFieldInfoPtr_tweenT));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Bolgo.NativeFieldInfoPtr_tweenT)) = value;
    }
  }

  public unsafe bool tween
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Bolgo.NativeFieldInfoPtr_tween));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Bolgo.NativeFieldInfoPtr_tween)) = value;
    }
  }
}
