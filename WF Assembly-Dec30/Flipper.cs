// Decompiled with JetBrains decompiler
// Type: Flipper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class Flipper : MonoBehaviourCacheTransform
{
  private static readonly IntPtr NativeFieldInfoPtr_state;
  private static readonly IntPtr NativeFieldInfoPtr_entity;
  private static readonly IntPtr NativeFieldInfoPtr_hover;
  private static readonly IntPtr NativeFieldInfoPtr_flipUpDurationRand;
  private static readonly IntPtr NativeFieldInfoPtr_flipDownDurationRand;
  private static readonly IntPtr NativeFieldInfoPtr_flipUpCurve;
  private static readonly IntPtr NativeFieldInfoPtr_flipDownCurve;
  private static readonly IntPtr NativeFieldInfoPtr_flipPositionOffset;
  private static readonly IntPtr NativeFieldInfoPtr_flipPositionCurve;
  private static readonly IntPtr NativeFieldInfoPtr_onFlipUp;
  private static readonly IntPtr NativeFieldInfoPtr_onFlipDown;
  private static readonly IntPtr NativeFieldInfoPtr_preAngle;
  private static readonly IntPtr NativeFieldInfoPtr_angle;
  private static readonly IntPtr NativeFieldInfoPtr_flipped;
  private static readonly IntPtr NativeFieldInfoPtr_t;
  private static readonly IntPtr NativeFieldInfoPtr_duration;
  private static readonly IntPtr NativeFieldInfoPtr_isCompleteFired;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_UpdateAngle_Private_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_FlipUp_Public_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_FlipUpInstant_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_FlipDown_Public_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_FlipDownInstant_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnGetFromPool_Public_Virtual_Final_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnReturnToPool_Public_Virtual_Final_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50147, XrefRangeEnd = 50156, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Flipper.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 50169, RefRangeEnd = 50170, XrefRangeStart = 50156, XrefRangeEnd = 50169, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateAngle(float angle)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &angle
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Flipper.NativeMethodInfoPtr_UpdateAngle_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 50173, RefRangeEnd = 50180, XrefRangeStart = 50170, XrefRangeEnd = 50173, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FlipUp(bool force = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &force
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Flipper.NativeMethodInfoPtr_FlipUp_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(10)]
  [CachedScanResults(RefRangeStart = 50194, RefRangeEnd = 50204, XrefRangeStart = 50180, XrefRangeEnd = 50194, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FlipUpInstant()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Flipper.NativeMethodInfoPtr_FlipUpInstant_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 50207, RefRangeEnd = 50211, XrefRangeStart = 50204, XrefRangeEnd = 50207, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FlipDown(bool force = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &force
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Flipper.NativeMethodInfoPtr_FlipDown_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(16)]
  [CachedScanResults(RefRangeStart = 50225, RefRangeEnd = 50241, XrefRangeStart = 50211, XrefRangeEnd = 50225, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FlipDownInstant()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Flipper.NativeMethodInfoPtr_FlipDownInstant_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(12611)]
  [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnGetFromPool()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Flipper.NativeMethodInfoPtr_OnGetFromPool_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 50255, RefRangeEnd = 50256, XrefRangeStart = 50241, XrefRangeEnd = 50255, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnReturnToPool()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Flipper.NativeMethodInfoPtr_OnReturnToPool_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50256, XrefRangeEnd = 50257, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Flipper()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Flipper>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Flipper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static Flipper()
  {
    Il2CppClassPointerStore<Flipper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (Flipper));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Flipper>.NativeClassPtr);
    Flipper.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Flipper>.NativeClassPtr, nameof (state));
    Flipper.NativeFieldInfoPtr_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Flipper>.NativeClassPtr, nameof (entity));
    Flipper.NativeFieldInfoPtr_hover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Flipper>.NativeClassPtr, nameof (hover));
    Flipper.NativeFieldInfoPtr_flipUpDurationRand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Flipper>.NativeClassPtr, nameof (flipUpDurationRand));
    Flipper.NativeFieldInfoPtr_flipDownDurationRand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Flipper>.NativeClassPtr, nameof (flipDownDurationRand));
    Flipper.NativeFieldInfoPtr_flipUpCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Flipper>.NativeClassPtr, nameof (flipUpCurve));
    Flipper.NativeFieldInfoPtr_flipDownCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Flipper>.NativeClassPtr, nameof (flipDownCurve));
    Flipper.NativeFieldInfoPtr_flipPositionOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Flipper>.NativeClassPtr, nameof (flipPositionOffset));
    Flipper.NativeFieldInfoPtr_flipPositionCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Flipper>.NativeClassPtr, nameof (flipPositionCurve));
    Flipper.NativeFieldInfoPtr_onFlipUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Flipper>.NativeClassPtr, nameof (onFlipUp));
    Flipper.NativeFieldInfoPtr_onFlipDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Flipper>.NativeClassPtr, nameof (onFlipDown));
    Flipper.NativeFieldInfoPtr_preAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Flipper>.NativeClassPtr, nameof (preAngle));
    Flipper.NativeFieldInfoPtr_angle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Flipper>.NativeClassPtr, nameof (angle));
    Flipper.NativeFieldInfoPtr_flipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Flipper>.NativeClassPtr, nameof (flipped));
    Flipper.NativeFieldInfoPtr_t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Flipper>.NativeClassPtr, nameof (t));
    Flipper.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Flipper>.NativeClassPtr, nameof (duration));
    Flipper.NativeFieldInfoPtr_isCompleteFired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Flipper>.NativeClassPtr, nameof (isCompleteFired));
    Flipper.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Flipper>.NativeClassPtr, 100667250);
    Flipper.NativeMethodInfoPtr_UpdateAngle_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Flipper>.NativeClassPtr, 100667251);
    Flipper.NativeMethodInfoPtr_FlipUp_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Flipper>.NativeClassPtr, 100667252);
    Flipper.NativeMethodInfoPtr_FlipUpInstant_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Flipper>.NativeClassPtr, 100667253);
    Flipper.NativeMethodInfoPtr_FlipDown_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Flipper>.NativeClassPtr, 100667254);
    Flipper.NativeMethodInfoPtr_FlipDownInstant_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Flipper>.NativeClassPtr, 100667255);
    Flipper.NativeMethodInfoPtr_OnGetFromPool_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Flipper>.NativeClassPtr, 100667256);
    Flipper.NativeMethodInfoPtr_OnReturnToPool_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Flipper>.NativeClassPtr, 100667257);
    Flipper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Flipper>.NativeClassPtr, 100667258);
  }

  public Flipper(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Flipper.State state
  {
    get
    {
      return *(Flipper.State*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Flipper.NativeFieldInfoPtr_state));
    }
    [param: In] set
    {
      *(Flipper.State*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Flipper.NativeFieldInfoPtr_state)) = value;
    }
  }

  public unsafe Entity entity
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Flipper.NativeFieldInfoPtr_entity));
      return pointer == IntPtr.Zero ? (Entity) null : new Entity(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Flipper.NativeFieldInfoPtr_entity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CardHover hover
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Flipper.NativeFieldInfoPtr_hover));
      return pointer == IntPtr.Zero ? (CardHover) null : new CardHover(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Flipper.NativeFieldInfoPtr_hover), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector2 flipUpDurationRand
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Flipper.NativeFieldInfoPtr_flipUpDurationRand));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Flipper.NativeFieldInfoPtr_flipUpDurationRand)) = value;
    }
  }

  public unsafe Vector2 flipDownDurationRand
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Flipper.NativeFieldInfoPtr_flipDownDurationRand));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Flipper.NativeFieldInfoPtr_flipDownDurationRand)) = value;
    }
  }

  public unsafe AnimationCurve flipUpCurve
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Flipper.NativeFieldInfoPtr_flipUpCurve));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Flipper.NativeFieldInfoPtr_flipUpCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve flipDownCurve
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Flipper.NativeFieldInfoPtr_flipDownCurve));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Flipper.NativeFieldInfoPtr_flipDownCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 flipPositionOffset
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Flipper.NativeFieldInfoPtr_flipPositionOffset));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Flipper.NativeFieldInfoPtr_flipPositionOffset)) = value;
    }
  }

  public unsafe AnimationCurve flipPositionCurve
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Flipper.NativeFieldInfoPtr_flipPositionCurve));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Flipper.NativeFieldInfoPtr_flipPositionCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEvent onFlipUp
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Flipper.NativeFieldInfoPtr_onFlipUp));
      return pointer == IntPtr.Zero ? (UnityEvent) null : new UnityEvent(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Flipper.NativeFieldInfoPtr_onFlipUp), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEvent onFlipDown
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Flipper.NativeFieldInfoPtr_onFlipDown));
      return pointer == IntPtr.Zero ? (UnityEvent) null : new UnityEvent(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Flipper.NativeFieldInfoPtr_onFlipDown), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float preAngle
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Flipper.NativeFieldInfoPtr_preAngle));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Flipper.NativeFieldInfoPtr_preAngle)) = value;
    }
  }

  public unsafe float angle
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Flipper.NativeFieldInfoPtr_angle));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Flipper.NativeFieldInfoPtr_angle)) = value;
    }
  }

  public unsafe bool flipped
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Flipper.NativeFieldInfoPtr_flipped));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Flipper.NativeFieldInfoPtr_flipped)) = value;
    }
  }

  public unsafe float t
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Flipper.NativeFieldInfoPtr_t));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Flipper.NativeFieldInfoPtr_t)) = value;
    }
  }

  public unsafe float duration
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Flipper.NativeFieldInfoPtr_duration));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Flipper.NativeFieldInfoPtr_duration)) = value;
    }
  }

  public unsafe bool isCompleteFired
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Flipper.NativeFieldInfoPtr_isCompleteFired));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Flipper.NativeFieldInfoPtr_isCompleteFired)) = value;
    }
  }

  public enum State
  {
    None,
    FlipUp,
    FlipDown,
  }
}
