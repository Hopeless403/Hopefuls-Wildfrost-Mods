// Decompiled with JetBrains decompiler
// Type: LargeUIScaler
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
public class LargeUIScaler : WorldSpaceCanvasUpdater
{
  private static readonly IntPtr NativeFieldInfoPtr_setScale;
  private static readonly IntPtr NativeFieldInfoPtr_scaleMin;
  private static readonly IntPtr NativeFieldInfoPtr_scaleMax;
  private static readonly IntPtr NativeFieldInfoPtr_setPosition;
  private static readonly IntPtr NativeFieldInfoPtr_positionMin;
  private static readonly IntPtr NativeFieldInfoPtr_positionMax;
  private static readonly IntPtr NativeFieldInfoPtr_aspectRatioInfluence;
  private static readonly IntPtr NativeMethodInfoPtr_UpdateSize_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91953, XrefRangeEnd = 91966, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void UpdateSize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LargeUIScaler.NativeMethodInfoPtr_UpdateSize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91966, XrefRangeEnd = 91971, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LargeUIScaler()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LargeUIScaler>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LargeUIScaler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static LargeUIScaler()
  {
    Il2CppClassPointerStore<LargeUIScaler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (LargeUIScaler));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LargeUIScaler>.NativeClassPtr);
    LargeUIScaler.NativeFieldInfoPtr_setScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LargeUIScaler>.NativeClassPtr, nameof (setScale));
    LargeUIScaler.NativeFieldInfoPtr_scaleMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LargeUIScaler>.NativeClassPtr, nameof (scaleMin));
    LargeUIScaler.NativeFieldInfoPtr_scaleMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LargeUIScaler>.NativeClassPtr, nameof (scaleMax));
    LargeUIScaler.NativeFieldInfoPtr_setPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LargeUIScaler>.NativeClassPtr, nameof (setPosition));
    LargeUIScaler.NativeFieldInfoPtr_positionMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LargeUIScaler>.NativeClassPtr, nameof (positionMin));
    LargeUIScaler.NativeFieldInfoPtr_positionMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LargeUIScaler>.NativeClassPtr, nameof (positionMax));
    LargeUIScaler.NativeFieldInfoPtr_aspectRatioInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LargeUIScaler>.NativeClassPtr, nameof (aspectRatioInfluence));
    LargeUIScaler.NativeMethodInfoPtr_UpdateSize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LargeUIScaler>.NativeClassPtr, 100671198);
    LargeUIScaler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LargeUIScaler>.NativeClassPtr, 100671199);
  }

  public LargeUIScaler(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe bool setScale
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LargeUIScaler.NativeFieldInfoPtr_setScale));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LargeUIScaler.NativeFieldInfoPtr_setScale)) = value;
    }
  }

  public unsafe Vector3 scaleMin
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LargeUIScaler.NativeFieldInfoPtr_scaleMin));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LargeUIScaler.NativeFieldInfoPtr_scaleMin)) = value;
    }
  }

  public unsafe Vector3 scaleMax
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LargeUIScaler.NativeFieldInfoPtr_scaleMax));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LargeUIScaler.NativeFieldInfoPtr_scaleMax)) = value;
    }
  }

  public unsafe bool setPosition
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LargeUIScaler.NativeFieldInfoPtr_setPosition));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LargeUIScaler.NativeFieldInfoPtr_setPosition)) = value;
    }
  }

  public unsafe Vector3 positionMin
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LargeUIScaler.NativeFieldInfoPtr_positionMin));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LargeUIScaler.NativeFieldInfoPtr_positionMin)) = value;
    }
  }

  public unsafe Vector3 positionMax
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LargeUIScaler.NativeFieldInfoPtr_positionMax));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LargeUIScaler.NativeFieldInfoPtr_positionMax)) = value;
    }
  }

  public unsafe AnimationCurve aspectRatioInfluence
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LargeUIScaler.NativeFieldInfoPtr_aspectRatioInfluence));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LargeUIScaler.NativeFieldInfoPtr_aspectRatioInfluence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
