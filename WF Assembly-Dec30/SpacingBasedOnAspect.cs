// Decompiled with JetBrains decompiler
// Type: SpacingBasedOnAspect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class SpacingBasedOnAspect : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_curve;
  private static readonly IntPtr NativeFieldInfoPtr_maxSpacing;
  private static readonly IntPtr NativeFieldInfoPtr_minSpacing;
  private static readonly IntPtr NativeFieldInfoPtr__layout;
  private static readonly IntPtr NativeMethodInfoPtr_get_layout_Private_get_HorizontalOrVerticalLayoutGroup_0;
  private static readonly IntPtr NativeMethodInfoPtr_UpdatePosition_Public_Void_RectTransform_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe HorizontalOrVerticalLayoutGroup layout
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95084, XrefRangeEnd = 95088, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpacingBasedOnAspect.NativeMethodInfoPtr_get_layout_Private_get_HorizontalOrVerticalLayoutGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (HorizontalOrVerticalLayoutGroup) null : new HorizontalOrVerticalLayoutGroup(pointer);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95088, XrefRangeEnd = 95096, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdatePosition(RectTransform canvas)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) canvas)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SpacingBasedOnAspect.NativeMethodInfoPtr_UpdatePosition_Public_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SpacingBasedOnAspect()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpacingBasedOnAspect>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SpacingBasedOnAspect.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static SpacingBasedOnAspect()
  {
    Il2CppClassPointerStore<SpacingBasedOnAspect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (SpacingBasedOnAspect));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpacingBasedOnAspect>.NativeClassPtr);
    SpacingBasedOnAspect.NativeFieldInfoPtr_curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpacingBasedOnAspect>.NativeClassPtr, nameof (curve));
    SpacingBasedOnAspect.NativeFieldInfoPtr_maxSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpacingBasedOnAspect>.NativeClassPtr, nameof (maxSpacing));
    SpacingBasedOnAspect.NativeFieldInfoPtr_minSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpacingBasedOnAspect>.NativeClassPtr, nameof (minSpacing));
    SpacingBasedOnAspect.NativeFieldInfoPtr__layout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpacingBasedOnAspect>.NativeClassPtr, nameof (_layout));
    SpacingBasedOnAspect.NativeMethodInfoPtr_get_layout_Private_get_HorizontalOrVerticalLayoutGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpacingBasedOnAspect>.NativeClassPtr, 100671563);
    SpacingBasedOnAspect.NativeMethodInfoPtr_UpdatePosition_Public_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpacingBasedOnAspect>.NativeClassPtr, 100671564);
    SpacingBasedOnAspect.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpacingBasedOnAspect>.NativeClassPtr, 100671565);
  }

  public SpacingBasedOnAspect(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe AnimationCurve curve
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpacingBasedOnAspect.NativeFieldInfoPtr_curve));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpacingBasedOnAspect.NativeFieldInfoPtr_curve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float maxSpacing
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpacingBasedOnAspect.NativeFieldInfoPtr_maxSpacing));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpacingBasedOnAspect.NativeFieldInfoPtr_maxSpacing)) = value;
    }
  }

  public unsafe float minSpacing
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpacingBasedOnAspect.NativeFieldInfoPtr_minSpacing));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpacingBasedOnAspect.NativeFieldInfoPtr_minSpacing)) = value;
    }
  }

  public unsafe HorizontalOrVerticalLayoutGroup _layout
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpacingBasedOnAspect.NativeFieldInfoPtr__layout));
      return pointer == IntPtr.Zero ? (HorizontalOrVerticalLayoutGroup) null : new HorizontalOrVerticalLayoutGroup(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpacingBasedOnAspect.NativeFieldInfoPtr__layout), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
