// Decompiled with JetBrains decompiler
// Type: CardAnimationProfile
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
public class CardAnimationProfile : ScriptableObject
{
  private static readonly IntPtr NativeFieldInfoPtr_speedFactor;
  private static readonly IntPtr NativeFieldInfoPtr_doMoveX;
  private static readonly IntPtr NativeFieldInfoPtr_moveX;
  private static readonly IntPtr NativeFieldInfoPtr_doMoveY;
  private static readonly IntPtr NativeFieldInfoPtr_moveY;
  private static readonly IntPtr NativeFieldInfoPtr_doMoveZ;
  private static readonly IntPtr NativeFieldInfoPtr_moveZ;
  private static readonly IntPtr NativeFieldInfoPtr_moveAmount;
  private static readonly IntPtr NativeFieldInfoPtr_doRotateX;
  private static readonly IntPtr NativeFieldInfoPtr_rotateX;
  private static readonly IntPtr NativeFieldInfoPtr_doRotateY;
  private static readonly IntPtr NativeFieldInfoPtr_rotateY;
  private static readonly IntPtr NativeFieldInfoPtr_doRotateZ;
  private static readonly IntPtr NativeFieldInfoPtr_rotateZ;
  private static readonly IntPtr NativeFieldInfoPtr_rotateAmount;
  private static readonly IntPtr NativeFieldInfoPtr_doScaleX;
  private static readonly IntPtr NativeFieldInfoPtr_ScaleX;
  private static readonly IntPtr NativeFieldInfoPtr_doScaleY;
  private static readonly IntPtr NativeFieldInfoPtr_ScaleY;
  private static readonly IntPtr NativeFieldInfoPtr_doScaleZ;
  private static readonly IntPtr NativeFieldInfoPtr_ScaleZ;
  private static readonly IntPtr NativeFieldInfoPtr_scaleAmount;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(110)]
  [CachedScanResults(RefRangeStart = 104608, RefRangeEnd = 104718, XrefRangeStart = 104608, XrefRangeEnd = 104718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardAnimationProfile()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardAnimationProfile>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardAnimationProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CardAnimationProfile()
  {
    Il2CppClassPointerStore<CardAnimationProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CardAnimationProfile));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardAnimationProfile>.NativeClassPtr);
    CardAnimationProfile.NativeFieldInfoPtr_speedFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationProfile>.NativeClassPtr, nameof (speedFactor));
    CardAnimationProfile.NativeFieldInfoPtr_doMoveX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationProfile>.NativeClassPtr, nameof (doMoveX));
    CardAnimationProfile.NativeFieldInfoPtr_moveX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationProfile>.NativeClassPtr, nameof (moveX));
    CardAnimationProfile.NativeFieldInfoPtr_doMoveY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationProfile>.NativeClassPtr, nameof (doMoveY));
    CardAnimationProfile.NativeFieldInfoPtr_moveY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationProfile>.NativeClassPtr, nameof (moveY));
    CardAnimationProfile.NativeFieldInfoPtr_doMoveZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationProfile>.NativeClassPtr, nameof (doMoveZ));
    CardAnimationProfile.NativeFieldInfoPtr_moveZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationProfile>.NativeClassPtr, nameof (moveZ));
    CardAnimationProfile.NativeFieldInfoPtr_moveAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationProfile>.NativeClassPtr, nameof (moveAmount));
    CardAnimationProfile.NativeFieldInfoPtr_doRotateX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationProfile>.NativeClassPtr, nameof (doRotateX));
    CardAnimationProfile.NativeFieldInfoPtr_rotateX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationProfile>.NativeClassPtr, nameof (rotateX));
    CardAnimationProfile.NativeFieldInfoPtr_doRotateY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationProfile>.NativeClassPtr, nameof (doRotateY));
    CardAnimationProfile.NativeFieldInfoPtr_rotateY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationProfile>.NativeClassPtr, nameof (rotateY));
    CardAnimationProfile.NativeFieldInfoPtr_doRotateZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationProfile>.NativeClassPtr, nameof (doRotateZ));
    CardAnimationProfile.NativeFieldInfoPtr_rotateZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationProfile>.NativeClassPtr, nameof (rotateZ));
    CardAnimationProfile.NativeFieldInfoPtr_rotateAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationProfile>.NativeClassPtr, nameof (rotateAmount));
    CardAnimationProfile.NativeFieldInfoPtr_doScaleX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationProfile>.NativeClassPtr, nameof (doScaleX));
    CardAnimationProfile.NativeFieldInfoPtr_ScaleX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationProfile>.NativeClassPtr, nameof (ScaleX));
    CardAnimationProfile.NativeFieldInfoPtr_doScaleY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationProfile>.NativeClassPtr, nameof (doScaleY));
    CardAnimationProfile.NativeFieldInfoPtr_ScaleY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationProfile>.NativeClassPtr, nameof (ScaleY));
    CardAnimationProfile.NativeFieldInfoPtr_doScaleZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationProfile>.NativeClassPtr, nameof (doScaleZ));
    CardAnimationProfile.NativeFieldInfoPtr_ScaleZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationProfile>.NativeClassPtr, nameof (ScaleZ));
    CardAnimationProfile.NativeFieldInfoPtr_scaleAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationProfile>.NativeClassPtr, nameof (scaleAmount));
    CardAnimationProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardAnimationProfile>.NativeClassPtr, 100673244);
  }

  public CardAnimationProfile(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe float speedFactor
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationProfile.NativeFieldInfoPtr_speedFactor));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationProfile.NativeFieldInfoPtr_speedFactor)) = value;
    }
  }

  public unsafe bool doMoveX
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationProfile.NativeFieldInfoPtr_doMoveX));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationProfile.NativeFieldInfoPtr_doMoveX)) = value;
    }
  }

  public unsafe AnimationCurve moveX
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationProfile.NativeFieldInfoPtr_moveX));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationProfile.NativeFieldInfoPtr_moveX), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool doMoveY
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationProfile.NativeFieldInfoPtr_doMoveY));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationProfile.NativeFieldInfoPtr_doMoveY)) = value;
    }
  }

  public unsafe AnimationCurve moveY
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationProfile.NativeFieldInfoPtr_moveY));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationProfile.NativeFieldInfoPtr_moveY), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool doMoveZ
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationProfile.NativeFieldInfoPtr_doMoveZ));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationProfile.NativeFieldInfoPtr_doMoveZ)) = value;
    }
  }

  public unsafe AnimationCurve moveZ
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationProfile.NativeFieldInfoPtr_moveZ));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationProfile.NativeFieldInfoPtr_moveZ), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 moveAmount
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationProfile.NativeFieldInfoPtr_moveAmount));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationProfile.NativeFieldInfoPtr_moveAmount)) = value;
    }
  }

  public unsafe bool doRotateX
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationProfile.NativeFieldInfoPtr_doRotateX));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationProfile.NativeFieldInfoPtr_doRotateX)) = value;
    }
  }

  public unsafe AnimationCurve rotateX
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationProfile.NativeFieldInfoPtr_rotateX));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationProfile.NativeFieldInfoPtr_rotateX), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool doRotateY
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationProfile.NativeFieldInfoPtr_doRotateY));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationProfile.NativeFieldInfoPtr_doRotateY)) = value;
    }
  }

  public unsafe AnimationCurve rotateY
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationProfile.NativeFieldInfoPtr_rotateY));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationProfile.NativeFieldInfoPtr_rotateY), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool doRotateZ
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationProfile.NativeFieldInfoPtr_doRotateZ));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationProfile.NativeFieldInfoPtr_doRotateZ)) = value;
    }
  }

  public unsafe AnimationCurve rotateZ
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationProfile.NativeFieldInfoPtr_rotateZ));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationProfile.NativeFieldInfoPtr_rotateZ), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 rotateAmount
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationProfile.NativeFieldInfoPtr_rotateAmount));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationProfile.NativeFieldInfoPtr_rotateAmount)) = value;
    }
  }

  public unsafe bool doScaleX
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationProfile.NativeFieldInfoPtr_doScaleX));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationProfile.NativeFieldInfoPtr_doScaleX)) = value;
    }
  }

  public unsafe AnimationCurve ScaleX
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationProfile.NativeFieldInfoPtr_ScaleX));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationProfile.NativeFieldInfoPtr_ScaleX), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool doScaleY
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationProfile.NativeFieldInfoPtr_doScaleY));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationProfile.NativeFieldInfoPtr_doScaleY)) = value;
    }
  }

  public unsafe AnimationCurve ScaleY
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationProfile.NativeFieldInfoPtr_ScaleY));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationProfile.NativeFieldInfoPtr_ScaleY), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool doScaleZ
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationProfile.NativeFieldInfoPtr_doScaleZ));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationProfile.NativeFieldInfoPtr_doScaleZ)) = value;
    }
  }

  public unsafe AnimationCurve ScaleZ
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationProfile.NativeFieldInfoPtr_ScaleZ));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationProfile.NativeFieldInfoPtr_ScaleZ), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 scaleAmount
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationProfile.NativeFieldInfoPtr_scaleAmount));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationProfile.NativeFieldInfoPtr_scaleAmount)) = value;
    }
  }
}
