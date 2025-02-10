// Decompiled with JetBrains decompiler
// Type: LargeUIScaleUpdater
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
public class LargeUIScaleUpdater : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_scaleMin;
  private static readonly IntPtr NativeFieldInfoPtr_scaleMax;
  private static readonly IntPtr NativeFieldInfoPtr_positionMin;
  private static readonly IntPtr NativeFieldInfoPtr_positionMax;
  private static readonly IntPtr NativeFieldInfoPtr__transform;
  private static readonly IntPtr NativeMethodInfoPtr_get_t_Private_get_Transform_0;
  private static readonly IntPtr NativeMethodInfoPtr_PromptUpdate_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe Transform t
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91971, XrefRangeEnd = 91973, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(LargeUIScaleUpdater.NativeMethodInfoPtr_get_t_Private_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 91979, RefRangeEnd = 91980, XrefRangeStart = 91973, XrefRangeEnd = 91979, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PromptUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LargeUIScaleUpdater.NativeMethodInfoPtr_PromptUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91980, XrefRangeEnd = 91985, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LargeUIScaleUpdater()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LargeUIScaleUpdater>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LargeUIScaleUpdater.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static LargeUIScaleUpdater()
  {
    Il2CppClassPointerStore<LargeUIScaleUpdater>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (LargeUIScaleUpdater));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LargeUIScaleUpdater>.NativeClassPtr);
    LargeUIScaleUpdater.NativeFieldInfoPtr_scaleMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LargeUIScaleUpdater>.NativeClassPtr, nameof (scaleMin));
    LargeUIScaleUpdater.NativeFieldInfoPtr_scaleMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LargeUIScaleUpdater>.NativeClassPtr, nameof (scaleMax));
    LargeUIScaleUpdater.NativeFieldInfoPtr_positionMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LargeUIScaleUpdater>.NativeClassPtr, nameof (positionMin));
    LargeUIScaleUpdater.NativeFieldInfoPtr_positionMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LargeUIScaleUpdater>.NativeClassPtr, nameof (positionMax));
    LargeUIScaleUpdater.NativeFieldInfoPtr__transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LargeUIScaleUpdater>.NativeClassPtr, nameof (_transform));
    LargeUIScaleUpdater.NativeMethodInfoPtr_get_t_Private_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LargeUIScaleUpdater>.NativeClassPtr, 100671200);
    LargeUIScaleUpdater.NativeMethodInfoPtr_PromptUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LargeUIScaleUpdater>.NativeClassPtr, 100671201);
    LargeUIScaleUpdater.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LargeUIScaleUpdater>.NativeClassPtr, 100671202);
  }

  public LargeUIScaleUpdater(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Vector3 scaleMin
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LargeUIScaleUpdater.NativeFieldInfoPtr_scaleMin));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LargeUIScaleUpdater.NativeFieldInfoPtr_scaleMin)) = value;
    }
  }

  public unsafe Vector3 scaleMax
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LargeUIScaleUpdater.NativeFieldInfoPtr_scaleMax));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LargeUIScaleUpdater.NativeFieldInfoPtr_scaleMax)) = value;
    }
  }

  public unsafe Vector3 positionMin
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LargeUIScaleUpdater.NativeFieldInfoPtr_positionMin));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LargeUIScaleUpdater.NativeFieldInfoPtr_positionMin)) = value;
    }
  }

  public unsafe Vector3 positionMax
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LargeUIScaleUpdater.NativeFieldInfoPtr_positionMax));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LargeUIScaleUpdater.NativeFieldInfoPtr_positionMax)) = value;
    }
  }

  public unsafe Transform _transform
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LargeUIScaleUpdater.NativeFieldInfoPtr__transform));
      return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LargeUIScaleUpdater.NativeFieldInfoPtr__transform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
