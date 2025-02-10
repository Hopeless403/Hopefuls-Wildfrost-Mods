// Decompiled with JetBrains decompiler
// Type: ScaleBasedOnAspect
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
public class ScaleBasedOnAspect : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_curve;
  private static readonly IntPtr NativeFieldInfoPtr_maxScale;
  private static readonly IntPtr NativeFieldInfoPtr_minScale;
  private static readonly IntPtr NativeFieldInfoPtr_autoLinkToParent;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_UpdateScale_Public_Void_RectTransform_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94341, XrefRangeEnd = 94363, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScaleBasedOnAspect.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94363, XrefRangeEnd = 94367, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateScale(RectTransform canvas)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) canvas)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScaleBasedOnAspect.NativeMethodInfoPtr_UpdateScale_Public_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ScaleBasedOnAspect()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScaleBasedOnAspect>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScaleBasedOnAspect.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ScaleBasedOnAspect()
  {
    Il2CppClassPointerStore<ScaleBasedOnAspect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ScaleBasedOnAspect));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScaleBasedOnAspect>.NativeClassPtr);
    ScaleBasedOnAspect.NativeFieldInfoPtr_curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleBasedOnAspect>.NativeClassPtr, nameof (curve));
    ScaleBasedOnAspect.NativeFieldInfoPtr_maxScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleBasedOnAspect>.NativeClassPtr, nameof (maxScale));
    ScaleBasedOnAspect.NativeFieldInfoPtr_minScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleBasedOnAspect>.NativeClassPtr, nameof (minScale));
    ScaleBasedOnAspect.NativeFieldInfoPtr_autoLinkToParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleBasedOnAspect>.NativeClassPtr, nameof (autoLinkToParent));
    ScaleBasedOnAspect.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleBasedOnAspect>.NativeClassPtr, 100671427);
    ScaleBasedOnAspect.NativeMethodInfoPtr_UpdateScale_Public_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleBasedOnAspect>.NativeClassPtr, 100671428);
    ScaleBasedOnAspect.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleBasedOnAspect>.NativeClassPtr, 100671429);
  }

  public ScaleBasedOnAspect(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe AnimationCurve curve
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScaleBasedOnAspect.NativeFieldInfoPtr_curve));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScaleBasedOnAspect.NativeFieldInfoPtr_curve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 maxScale
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScaleBasedOnAspect.NativeFieldInfoPtr_maxScale));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScaleBasedOnAspect.NativeFieldInfoPtr_maxScale)) = value;
    }
  }

  public unsafe Vector3 minScale
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScaleBasedOnAspect.NativeFieldInfoPtr_minScale));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScaleBasedOnAspect.NativeFieldInfoPtr_minScale)) = value;
    }
  }

  public unsafe bool autoLinkToParent
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScaleBasedOnAspect.NativeFieldInfoPtr_autoLinkToParent));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScaleBasedOnAspect.NativeFieldInfoPtr_autoLinkToParent)) = value;
    }
  }
}
