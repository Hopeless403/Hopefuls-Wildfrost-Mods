// Decompiled with JetBrains decompiler
// Type: UnityEngine.UI.Extensions.FlowLayoutGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.UI.Extensions
{
  public class FlowLayoutGroup : LayoutGroup
  {
    private static readonly IntPtr NativeFieldInfoPtr_SpacingX;
    private static readonly IntPtr NativeFieldInfoPtr_SpacingY;
    private static readonly IntPtr NativeFieldInfoPtr_ExpandHorizontalSpacing;
    private static readonly IntPtr NativeFieldInfoPtr_ChildForceExpandWidth;
    private static readonly IntPtr NativeFieldInfoPtr_ChildForceExpandHeight;
    private static readonly IntPtr NativeFieldInfoPtr_invertOrder;
    private static readonly IntPtr NativeFieldInfoPtr__layoutHeight;
    private static readonly IntPtr NativeFieldInfoPtr__layoutWidth;
    private static readonly IntPtr NativeFieldInfoPtr_maxWidth;
    private static readonly IntPtr NativeFieldInfoPtr_maxHeight;
    private static readonly IntPtr NativeFieldInfoPtr_m_StartAxis;
    private static readonly IntPtr NativeFieldInfoPtr__itemList;
    private static readonly IntPtr NativeMethodInfoPtr_get_startAxis_Public_get_Axis_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_startAxis_Public_set_Void_Axis_0;
    private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_IsCenterAlign_Protected_get_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_IsRightAlign_Protected_get_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_IsMiddleAlign_Protected_get_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_IsLowerAlign_Protected_get_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetLayout_Public_Single_Int32_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_CalculateRowVerticalOffset_Private_Single_Single_Single_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_CalculateColHorizontalOffset_Private_Single_Single_Single_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_LayoutRow_Protected_Void_IList_1_RectTransform_Single_Single_Single_Single_Single_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_LayoutCol_Protected_Void_IList_1_RectTransform_Single_Single_Single_Single_Single_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetGreatestMinimumChildWidth_Public_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetGreatestMinimumChildHeigth_Public_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe FlowLayoutGroup.Axis startAxis
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 141894, RefRangeEnd = 141895, XrefRangeStart = 141894, XrefRangeEnd = 141894, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlowLayoutGroup.NativeMethodInfoPtr_get_startAxis_Public_get_Axis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(FlowLayoutGroup.Axis*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141895, XrefRangeEnd = 141898, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1]
        {
          (IntPtr) &value
        };
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(FlowLayoutGroup.NativeMethodInfoPtr_set_startAxis_Public_set_Void_Axis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141898, XrefRangeEnd = 141899, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void CalculateLayoutInputHorizontal()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FlowLayoutGroup.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141899, XrefRangeEnd = 141900, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void SetLayoutHorizontal()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FlowLayoutGroup.NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141900, XrefRangeEnd = 141901, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void SetLayoutVertical()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FlowLayoutGroup.NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141901, XrefRangeEnd = 141911, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void CalculateLayoutInputVertical()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FlowLayoutGroup.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public unsafe bool IsCenterAlign
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 141911, RefRangeEnd = 141912, XrefRangeStart = 141911, XrefRangeEnd = 141911, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlowLayoutGroup.NativeMethodInfoPtr_get_IsCenterAlign_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool IsRightAlign
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 141912, RefRangeEnd = 141915, XrefRangeStart = 141912, XrefRangeEnd = 141912, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlowLayoutGroup.NativeMethodInfoPtr_get_IsRightAlign_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool IsMiddleAlign
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 141915, RefRangeEnd = 141916, XrefRangeStart = 141915, XrefRangeEnd = 141915, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlowLayoutGroup.NativeMethodInfoPtr_get_IsMiddleAlign_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool IsLowerAlign
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 141916, RefRangeEnd = 141919, XrefRangeStart = 141916, XrefRangeEnd = 141916, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlowLayoutGroup.NativeMethodInfoPtr_get_IsLowerAlign_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 141992, RefRangeEnd = 141995, XrefRangeStart = 141919, XrefRangeEnd = 141992, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float SetLayout(int axis, bool layoutInput)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &axis;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &layoutInput;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlowLayoutGroup.NativeMethodInfoPtr_SetLayout_Public_Single_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe float CalculateRowVerticalOffset(
      float groupHeight,
      float yOffset,
      float currentRowHeight)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &groupHeight;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &yOffset;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &currentRowHeight;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlowLayoutGroup.NativeMethodInfoPtr_CalculateRowVerticalOffset_Private_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 141995, RefRangeEnd = 141996, XrefRangeStart = 141995, XrefRangeEnd = 141995, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float CalculateColHorizontalOffset(
      float groupWidth,
      float xOffset,
      float currentColWidth)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &groupWidth;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &xOffset;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &currentColWidth;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlowLayoutGroup.NativeMethodInfoPtr_CalculateColHorizontalOffset_Private_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 142030, RefRangeEnd = 142032, XrefRangeStart = 141996, XrefRangeEnd = 142030, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void LayoutRow(
      IList<RectTransform> contents,
      float rowWidth,
      float rowHeight,
      float maxWidth,
      float xOffset,
      float yOffset,
      int axis)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[7];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) contents);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &rowWidth;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &rowHeight;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &maxWidth;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &xOffset;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(5) * sizeof (IntPtr))) = (IntPtr) &yOffset;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(6) * sizeof (IntPtr))) = (IntPtr) &axis;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FlowLayoutGroup.NativeMethodInfoPtr_LayoutRow_Protected_Void_IList_1_RectTransform_Single_Single_Single_Single_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 142066, RefRangeEnd = 142068, XrefRangeStart = 142032, XrefRangeEnd = 142066, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void LayoutCol(
      IList<RectTransform> contents,
      float colWidth,
      float colHeight,
      float maxHeight,
      float xOffset,
      float yOffset,
      int axis)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[7];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) contents);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &colWidth;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &colHeight;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &maxHeight;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &xOffset;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(5) * sizeof (IntPtr))) = (IntPtr) &yOffset;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(6) * sizeof (IntPtr))) = (IntPtr) &axis;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FlowLayoutGroup.NativeMethodInfoPtr_LayoutCol_Protected_Void_IList_1_RectTransform_Single_Single_Single_Single_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142068, XrefRangeEnd = 142074, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float GetGreatestMinimumChildWidth()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlowLayoutGroup.NativeMethodInfoPtr_GetGreatestMinimumChildWidth_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142074, XrefRangeEnd = 142080, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float GetGreatestMinimumChildHeigth()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlowLayoutGroup.NativeMethodInfoPtr_GetGreatestMinimumChildHeigth_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142080, XrefRangeEnd = 142089, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe FlowLayoutGroup()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FlowLayoutGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static FlowLayoutGroup()
    {
      Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.UI.Extensions", nameof (FlowLayoutGroup));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr);
      FlowLayoutGroup.NativeFieldInfoPtr_SpacingX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr, nameof (SpacingX));
      FlowLayoutGroup.NativeFieldInfoPtr_SpacingY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr, nameof (SpacingY));
      FlowLayoutGroup.NativeFieldInfoPtr_ExpandHorizontalSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr, nameof (ExpandHorizontalSpacing));
      FlowLayoutGroup.NativeFieldInfoPtr_ChildForceExpandWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr, nameof (ChildForceExpandWidth));
      FlowLayoutGroup.NativeFieldInfoPtr_ChildForceExpandHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr, nameof (ChildForceExpandHeight));
      FlowLayoutGroup.NativeFieldInfoPtr_invertOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr, nameof (invertOrder));
      FlowLayoutGroup.NativeFieldInfoPtr__layoutHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr, nameof (_layoutHeight));
      FlowLayoutGroup.NativeFieldInfoPtr__layoutWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr, nameof (_layoutWidth));
      FlowLayoutGroup.NativeFieldInfoPtr_maxWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr, nameof (maxWidth));
      FlowLayoutGroup.NativeFieldInfoPtr_maxHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr, nameof (maxHeight));
      FlowLayoutGroup.NativeFieldInfoPtr_m_StartAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr, nameof (m_StartAxis));
      FlowLayoutGroup.NativeFieldInfoPtr__itemList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr, nameof (_itemList));
      FlowLayoutGroup.NativeMethodInfoPtr_get_startAxis_Public_get_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr, 100678372);
      FlowLayoutGroup.NativeMethodInfoPtr_set_startAxis_Public_set_Void_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr, 100678373);
      FlowLayoutGroup.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr, 100678374);
      FlowLayoutGroup.NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr, 100678375);
      FlowLayoutGroup.NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr, 100678376);
      FlowLayoutGroup.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr, 100678377);
      FlowLayoutGroup.NativeMethodInfoPtr_get_IsCenterAlign_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr, 100678378);
      FlowLayoutGroup.NativeMethodInfoPtr_get_IsRightAlign_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr, 100678379);
      FlowLayoutGroup.NativeMethodInfoPtr_get_IsMiddleAlign_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr, 100678380);
      FlowLayoutGroup.NativeMethodInfoPtr_get_IsLowerAlign_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr, 100678381);
      FlowLayoutGroup.NativeMethodInfoPtr_SetLayout_Public_Single_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr, 100678382);
      FlowLayoutGroup.NativeMethodInfoPtr_CalculateRowVerticalOffset_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr, 100678383);
      FlowLayoutGroup.NativeMethodInfoPtr_CalculateColHorizontalOffset_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr, 100678384);
      FlowLayoutGroup.NativeMethodInfoPtr_LayoutRow_Protected_Void_IList_1_RectTransform_Single_Single_Single_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr, 100678385);
      FlowLayoutGroup.NativeMethodInfoPtr_LayoutCol_Protected_Void_IList_1_RectTransform_Single_Single_Single_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr, 100678386);
      FlowLayoutGroup.NativeMethodInfoPtr_GetGreatestMinimumChildWidth_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr, 100678387);
      FlowLayoutGroup.NativeMethodInfoPtr_GetGreatestMinimumChildHeigth_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr, 100678388);
      FlowLayoutGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr, 100678389);
    }

    public FlowLayoutGroup(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float SpacingX
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowLayoutGroup.NativeFieldInfoPtr_SpacingX));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowLayoutGroup.NativeFieldInfoPtr_SpacingX)) = value;
      }
    }

    public unsafe float SpacingY
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowLayoutGroup.NativeFieldInfoPtr_SpacingY));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowLayoutGroup.NativeFieldInfoPtr_SpacingY)) = value;
      }
    }

    public unsafe bool ExpandHorizontalSpacing
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowLayoutGroup.NativeFieldInfoPtr_ExpandHorizontalSpacing));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowLayoutGroup.NativeFieldInfoPtr_ExpandHorizontalSpacing)) = value;
      }
    }

    public unsafe bool ChildForceExpandWidth
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowLayoutGroup.NativeFieldInfoPtr_ChildForceExpandWidth));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowLayoutGroup.NativeFieldInfoPtr_ChildForceExpandWidth)) = value;
      }
    }

    public unsafe bool ChildForceExpandHeight
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowLayoutGroup.NativeFieldInfoPtr_ChildForceExpandHeight));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowLayoutGroup.NativeFieldInfoPtr_ChildForceExpandHeight)) = value;
      }
    }

    public unsafe bool invertOrder
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowLayoutGroup.NativeFieldInfoPtr_invertOrder));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowLayoutGroup.NativeFieldInfoPtr_invertOrder)) = value;
      }
    }

    public unsafe float _layoutHeight
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowLayoutGroup.NativeFieldInfoPtr__layoutHeight));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowLayoutGroup.NativeFieldInfoPtr__layoutHeight)) = value;
      }
    }

    public unsafe float _layoutWidth
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowLayoutGroup.NativeFieldInfoPtr__layoutWidth));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowLayoutGroup.NativeFieldInfoPtr__layoutWidth)) = value;
      }
    }

    public unsafe float maxWidth
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowLayoutGroup.NativeFieldInfoPtr_maxWidth));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowLayoutGroup.NativeFieldInfoPtr_maxWidth)) = value;
      }
    }

    public unsafe float maxHeight
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowLayoutGroup.NativeFieldInfoPtr_maxHeight));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowLayoutGroup.NativeFieldInfoPtr_maxHeight)) = value;
      }
    }

    public unsafe FlowLayoutGroup.Axis m_StartAxis
    {
      get
      {
        return *(FlowLayoutGroup.Axis*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowLayoutGroup.NativeFieldInfoPtr_m_StartAxis));
      }
      [param: In] set
      {
        *(FlowLayoutGroup.Axis*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowLayoutGroup.NativeFieldInfoPtr_m_StartAxis)) = value;
      }
    }

    public unsafe IList<RectTransform> _itemList
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowLayoutGroup.NativeFieldInfoPtr__itemList));
        return pointer == IntPtr.Zero ? (IList<RectTransform>) null : new IList<RectTransform>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowLayoutGroup.NativeFieldInfoPtr__itemList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public enum Axis
    {
      Horizontal,
      Vertical,
    }
  }
}
