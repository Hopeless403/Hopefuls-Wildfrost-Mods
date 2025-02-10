// Decompiled with JetBrains decompiler
// Type: PositionBasedOnAspect
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
public class PositionBasedOnAspect : MonoBehaviourRect
{
  private static readonly IntPtr NativeFieldInfoPtr_curve;
  private static readonly IntPtr NativeFieldInfoPtr_maxPosition;
  private static readonly IntPtr NativeFieldInfoPtr_minPosition;
  private static readonly IntPtr NativeMethodInfoPtr_UpdatePosition_Public_Void_RectTransform_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94337, XrefRangeEnd = 94341, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdatePosition(RectTransform canvas)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) canvas)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PositionBasedOnAspect.NativeMethodInfoPtr_UpdatePosition_Public_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 21168, RefRangeEnd = 21171, XrefRangeStart = 21168, XrefRangeEnd = 21171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PositionBasedOnAspect()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PositionBasedOnAspect>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PositionBasedOnAspect.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static PositionBasedOnAspect()
  {
    Il2CppClassPointerStore<PositionBasedOnAspect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (PositionBasedOnAspect));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PositionBasedOnAspect>.NativeClassPtr);
    PositionBasedOnAspect.NativeFieldInfoPtr_curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PositionBasedOnAspect>.NativeClassPtr, nameof (curve));
    PositionBasedOnAspect.NativeFieldInfoPtr_maxPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PositionBasedOnAspect>.NativeClassPtr, nameof (maxPosition));
    PositionBasedOnAspect.NativeFieldInfoPtr_minPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PositionBasedOnAspect>.NativeClassPtr, nameof (minPosition));
    PositionBasedOnAspect.NativeMethodInfoPtr_UpdatePosition_Public_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionBasedOnAspect>.NativeClassPtr, 100671425);
    PositionBasedOnAspect.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionBasedOnAspect>.NativeClassPtr, 100671426);
  }

  public PositionBasedOnAspect(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe AnimationCurve curve
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PositionBasedOnAspect.NativeFieldInfoPtr_curve));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PositionBasedOnAspect.NativeFieldInfoPtr_curve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 maxPosition
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PositionBasedOnAspect.NativeFieldInfoPtr_maxPosition));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PositionBasedOnAspect.NativeFieldInfoPtr_maxPosition)) = value;
    }
  }

  public unsafe Vector3 minPosition
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PositionBasedOnAspect.NativeFieldInfoPtr_minPosition));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PositionBasedOnAspect.NativeFieldInfoPtr_minPosition)) = value;
    }
  }
}
