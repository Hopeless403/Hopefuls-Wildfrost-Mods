// Decompiled with JetBrains decompiler
// Type: GridLayoutBasedOnAspect
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
public class GridLayoutBasedOnAspect : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr__layoutGroup;
  private static readonly IntPtr NativeFieldInfoPtr_curve;
  private static readonly IntPtr NativeFieldInfoPtr_setSpacing;
  private static readonly IntPtr NativeFieldInfoPtr_minSpacing;
  private static readonly IntPtr NativeFieldInfoPtr_maxSpacing;
  private static readonly IntPtr NativeFieldInfoPtr_autoLinkToParent;
  private static readonly IntPtr NativeMethodInfoPtr_get_layoutGroup_Private_get_GridLayoutGroup_0;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_UpdateLayout_Public_Void_RectTransform_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe GridLayoutGroup layoutGroup
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90011, XrefRangeEnd = 90015, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(GridLayoutBasedOnAspect.NativeMethodInfoPtr_get_layoutGroup_Private_get_GridLayoutGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90015, XrefRangeEnd = 90040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(GridLayoutBasedOnAspect.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90040, XrefRangeEnd = 90047, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateLayout(RectTransform canvas)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) canvas)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(GridLayoutBasedOnAspect.NativeMethodInfoPtr_UpdateLayout_Public_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GridLayoutBasedOnAspect()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GridLayoutBasedOnAspect>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(GridLayoutBasedOnAspect.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static GridLayoutBasedOnAspect()
  {
    Il2CppClassPointerStore<GridLayoutBasedOnAspect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (GridLayoutBasedOnAspect));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GridLayoutBasedOnAspect>.NativeClassPtr);
    GridLayoutBasedOnAspect.NativeFieldInfoPtr__layoutGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridLayoutBasedOnAspect>.NativeClassPtr, nameof (_layoutGroup));
    GridLayoutBasedOnAspect.NativeFieldInfoPtr_curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridLayoutBasedOnAspect>.NativeClassPtr, nameof (curve));
    GridLayoutBasedOnAspect.NativeFieldInfoPtr_setSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridLayoutBasedOnAspect>.NativeClassPtr, nameof (setSpacing));
    GridLayoutBasedOnAspect.NativeFieldInfoPtr_minSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridLayoutBasedOnAspect>.NativeClassPtr, nameof (minSpacing));
    GridLayoutBasedOnAspect.NativeFieldInfoPtr_maxSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridLayoutBasedOnAspect>.NativeClassPtr, nameof (maxSpacing));
    GridLayoutBasedOnAspect.NativeFieldInfoPtr_autoLinkToParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridLayoutBasedOnAspect>.NativeClassPtr, nameof (autoLinkToParent));
    GridLayoutBasedOnAspect.NativeMethodInfoPtr_get_layoutGroup_Private_get_GridLayoutGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutBasedOnAspect>.NativeClassPtr, 100670986);
    GridLayoutBasedOnAspect.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutBasedOnAspect>.NativeClassPtr, 100670987);
    GridLayoutBasedOnAspect.NativeMethodInfoPtr_UpdateLayout_Public_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutBasedOnAspect>.NativeClassPtr, 100670988);
    GridLayoutBasedOnAspect.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutBasedOnAspect>.NativeClassPtr, 100670989);
  }

  public GridLayoutBasedOnAspect(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe GridLayoutGroup _layoutGroup
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GridLayoutBasedOnAspect.NativeFieldInfoPtr__layoutGroup));
      return pointer == IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GridLayoutBasedOnAspect.NativeFieldInfoPtr__layoutGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve curve
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GridLayoutBasedOnAspect.NativeFieldInfoPtr_curve));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GridLayoutBasedOnAspect.NativeFieldInfoPtr_curve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool setSpacing
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GridLayoutBasedOnAspect.NativeFieldInfoPtr_setSpacing));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GridLayoutBasedOnAspect.NativeFieldInfoPtr_setSpacing)) = value;
    }
  }

  public unsafe Vector2 minSpacing
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GridLayoutBasedOnAspect.NativeFieldInfoPtr_minSpacing));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GridLayoutBasedOnAspect.NativeFieldInfoPtr_minSpacing)) = value;
    }
  }

  public unsafe Vector2 maxSpacing
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GridLayoutBasedOnAspect.NativeFieldInfoPtr_maxSpacing));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GridLayoutBasedOnAspect.NativeFieldInfoPtr_maxSpacing)) = value;
    }
  }

  public unsafe bool autoLinkToParent
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GridLayoutBasedOnAspect.NativeFieldInfoPtr_autoLinkToParent));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GridLayoutBasedOnAspect.NativeFieldInfoPtr_autoLinkToParent)) = value;
    }
  }
}
