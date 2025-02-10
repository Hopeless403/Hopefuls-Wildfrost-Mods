// Decompiled with JetBrains decompiler
// Type: FlexibleGridLayout
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
public class FlexibleGridLayout : LayoutGroup
{
  private static readonly IntPtr NativeFieldInfoPtr_fitType;
  private static readonly IntPtr NativeFieldInfoPtr_rows;
  private static readonly IntPtr NativeFieldInfoPtr_columns;
  private static readonly IntPtr NativeFieldInfoPtr_cellSize;
  private static readonly IntPtr NativeFieldInfoPtr_spacing;
  private static readonly IntPtr NativeFieldInfoPtr_autoSizeX;
  private static readonly IntPtr NativeFieldInfoPtr_autoSizeY;
  private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89852, XrefRangeEnd = 89896, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void CalculateLayoutInputHorizontal()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FlexibleGridLayout.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(12611)]
  [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void CalculateLayoutInputVertical()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FlexibleGridLayout.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(12611)]
  [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void SetLayoutHorizontal()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FlexibleGridLayout.NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(12611)]
  [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void SetLayoutVertical()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FlexibleGridLayout.NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89896, XrefRangeEnd = 89897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FlexibleGridLayout()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlexibleGridLayout>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FlexibleGridLayout.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static FlexibleGridLayout()
  {
    Il2CppClassPointerStore<FlexibleGridLayout>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (FlexibleGridLayout));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlexibleGridLayout>.NativeClassPtr);
    FlexibleGridLayout.NativeFieldInfoPtr_fitType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlexibleGridLayout>.NativeClassPtr, nameof (fitType));
    FlexibleGridLayout.NativeFieldInfoPtr_rows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlexibleGridLayout>.NativeClassPtr, nameof (rows));
    FlexibleGridLayout.NativeFieldInfoPtr_columns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlexibleGridLayout>.NativeClassPtr, nameof (columns));
    FlexibleGridLayout.NativeFieldInfoPtr_cellSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlexibleGridLayout>.NativeClassPtr, nameof (cellSize));
    FlexibleGridLayout.NativeFieldInfoPtr_spacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlexibleGridLayout>.NativeClassPtr, nameof (spacing));
    FlexibleGridLayout.NativeFieldInfoPtr_autoSizeX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlexibleGridLayout>.NativeClassPtr, nameof (autoSizeX));
    FlexibleGridLayout.NativeFieldInfoPtr_autoSizeY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlexibleGridLayout>.NativeClassPtr, nameof (autoSizeY));
    FlexibleGridLayout.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlexibleGridLayout>.NativeClassPtr, 100670963);
    FlexibleGridLayout.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlexibleGridLayout>.NativeClassPtr, 100670964);
    FlexibleGridLayout.NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlexibleGridLayout>.NativeClassPtr, 100670965);
    FlexibleGridLayout.NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlexibleGridLayout>.NativeClassPtr, 100670966);
    FlexibleGridLayout.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlexibleGridLayout>.NativeClassPtr, 100670967);
  }

  public FlexibleGridLayout(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe FlexibleGridLayout.FitType fitType
  {
    get
    {
      return *(FlexibleGridLayout.FitType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlexibleGridLayout.NativeFieldInfoPtr_fitType));
    }
    [param: In] set
    {
      *(FlexibleGridLayout.FitType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlexibleGridLayout.NativeFieldInfoPtr_fitType)) = value;
    }
  }

  public unsafe int rows
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlexibleGridLayout.NativeFieldInfoPtr_rows));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlexibleGridLayout.NativeFieldInfoPtr_rows)) = value;
    }
  }

  public unsafe int columns
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlexibleGridLayout.NativeFieldInfoPtr_columns));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlexibleGridLayout.NativeFieldInfoPtr_columns)) = value;
    }
  }

  public unsafe Vector2 cellSize
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlexibleGridLayout.NativeFieldInfoPtr_cellSize));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlexibleGridLayout.NativeFieldInfoPtr_cellSize)) = value;
    }
  }

  public unsafe Vector2 spacing
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlexibleGridLayout.NativeFieldInfoPtr_spacing));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlexibleGridLayout.NativeFieldInfoPtr_spacing)) = value;
    }
  }

  public unsafe bool autoSizeX
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlexibleGridLayout.NativeFieldInfoPtr_autoSizeX));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlexibleGridLayout.NativeFieldInfoPtr_autoSizeX)) = value;
    }
  }

  public unsafe bool autoSizeY
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlexibleGridLayout.NativeFieldInfoPtr_autoSizeY));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlexibleGridLayout.NativeFieldInfoPtr_autoSizeY)) = value;
    }
  }

  public enum FitType
  {
    Uniform,
    Width,
    Height,
    FixedRows,
    FixedColumns,
  }
}
