// Decompiled with JetBrains decompiler
// Type: UnityEngine.UI.Extensions.FlowLayoutGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;

#nullable disable
namespace UnityEngine.UI.Extensions
{
  [AddComponentMenu("Layout/Extensions/Flow Layout Group")]
  public class FlowLayoutGroup : LayoutGroup
  {
    public float SpacingX;
    public float SpacingY;
    public bool ExpandHorizontalSpacing;
    public bool ChildForceExpandWidth;
    public bool ChildForceExpandHeight;
    public bool invertOrder;
    private float _layoutHeight;
    private float _layoutWidth;
    public float maxWidth = 20f;
    public float maxHeight = 10f;
    [SerializeField]
    protected FlowLayoutGroup.Axis m_StartAxis;
    private readonly IList<RectTransform> _itemList = (IList<RectTransform>) new List<RectTransform>();

    public FlowLayoutGroup.Axis startAxis
    {
      get => this.m_StartAxis;
      set => this.SetProperty<FlowLayoutGroup.Axis>(ref this.m_StartAxis, value);
    }

    public override void CalculateLayoutInputHorizontal()
    {
      if (this.startAxis == FlowLayoutGroup.Axis.Horizontal)
      {
        base.CalculateLayoutInputHorizontal();
        this.SetLayoutInputForAxis(this.GetGreatestMinimumChildWidth() + (float) this.padding.left + (float) this.padding.right, -1f, -1f, 0);
      }
      else
        this._layoutWidth = this.SetLayout(0, true);
    }

    public override void SetLayoutHorizontal()
    {
      double num = (double) this.SetLayout(0, false);
    }

    public override void SetLayoutVertical()
    {
      double num = (double) this.SetLayout(1, false);
    }

    public override void CalculateLayoutInputVertical()
    {
      if (this.startAxis == FlowLayoutGroup.Axis.Horizontal)
      {
        this._layoutHeight = this.SetLayout(1, true);
      }
      else
      {
        base.CalculateLayoutInputHorizontal();
        this.SetLayoutInputForAxis(this.GetGreatestMinimumChildHeigth() + (float) this.padding.bottom + (float) this.padding.top, -1f, -1f, 1);
      }
    }

    protected bool IsCenterAlign
    {
      get
      {
        return this.childAlignment == TextAnchor.LowerCenter || this.childAlignment == TextAnchor.MiddleCenter || this.childAlignment == TextAnchor.UpperCenter;
      }
    }

    protected bool IsRightAlign
    {
      get
      {
        return this.childAlignment == TextAnchor.LowerRight || this.childAlignment == TextAnchor.MiddleRight || this.childAlignment == TextAnchor.UpperRight;
      }
    }

    protected bool IsMiddleAlign
    {
      get
      {
        return this.childAlignment == TextAnchor.MiddleLeft || this.childAlignment == TextAnchor.MiddleRight || this.childAlignment == TextAnchor.MiddleCenter;
      }
    }

    protected bool IsLowerAlign
    {
      get
      {
        return this.childAlignment == TextAnchor.LowerLeft || this.childAlignment == TextAnchor.LowerRight || this.childAlignment == TextAnchor.LowerCenter;
      }
    }

    public float SetLayout(int axis, bool layoutInput)
    {
      Rect rect;
      double num1;
      if (this.startAxis != FlowLayoutGroup.Axis.Vertical)
      {
        rect = this.rectTransform.rect;
        num1 = (double) rect.height;
      }
      else
        num1 = (double) this.maxHeight;
      float groupHeight = (float) num1;
      double num2;
      if (this.startAxis != FlowLayoutGroup.Axis.Horizontal)
      {
        rect = this.rectTransform.rect;
        num2 = (double) rect.width;
      }
      else
        num2 = (double) this.maxWidth;
      float groupWidth = (float) num2;
      float a = 0.0f;
      float num3 = 0.0f;
      float num4 = 0.0f;
      float num5 = 0.0f;
      float num6 = 0.0f;
      float num7 = 0.0f;
      float num8 = 0.0f;
      if (this.startAxis == FlowLayoutGroup.Axis.Horizontal)
      {
        num7 = groupHeight;
        num8 = groupWidth - (float) this.padding.left - (float) this.padding.right;
        if (this.IsLowerAlign)
        {
          num5 = (float) this.padding.bottom;
          num6 = (float) this.padding.top;
        }
        else
        {
          num5 = (float) this.padding.top;
          num6 = (float) this.padding.bottom;
        }
        num3 = this.SpacingY;
        num4 = this.SpacingX;
      }
      else if (this.startAxis == FlowLayoutGroup.Axis.Vertical)
      {
        num7 = groupWidth;
        num8 = groupHeight - (float) this.padding.top - (float) this.padding.bottom;
        if (this.IsRightAlign)
        {
          num5 = (float) this.padding.right;
          num6 = (float) this.padding.left;
        }
        else
        {
          num5 = (float) this.padding.left;
          num6 = (float) this.padding.right;
        }
        num3 = this.SpacingX;
        num4 = this.SpacingY;
      }
      float num9 = 0.0f;
      float num10 = 0.0f;
      for (int index1 = 0; index1 < this.rectChildren.Count; ++index1)
      {
        int index2 = index1;
        RectTransform rectChild = this.rectChildren[index2];
        float num11 = 0.0f;
        float num12 = 0.0f;
        if (this.startAxis == FlowLayoutGroup.Axis.Horizontal)
        {
          if (this.invertOrder)
            index2 = this.IsLowerAlign ? this.rectChildren.Count - 1 - index1 : index1;
          rectChild = this.rectChildren[index2];
          num11 = Mathf.Min(LayoutUtility.GetPreferredSize(rectChild, 0), num8);
          num12 = Mathf.Min(LayoutUtility.GetPreferredSize(rectChild, 1), num8);
        }
        else if (this.startAxis == FlowLayoutGroup.Axis.Vertical)
        {
          if (this.invertOrder)
            index2 = this.IsRightAlign ? this.rectChildren.Count - 1 - index1 : index1;
          rectChild = this.rectChildren[index2];
          num11 = Mathf.Min(LayoutUtility.GetPreferredSize(rectChild, 1), num8);
          num12 = Mathf.Min(LayoutUtility.GetPreferredSize(rectChild, 0), num8);
        }
        if ((double) num9 + (double) num11 > (double) num8)
        {
          float num13 = num9 - num4;
          if (!layoutInput)
          {
            if (this.startAxis == FlowLayoutGroup.Axis.Horizontal)
            {
              float rowVerticalOffset = this.CalculateRowVerticalOffset(num7, num5, num10);
              this.LayoutRow(this._itemList, num13, num10, num8, (float) this.padding.left, rowVerticalOffset, axis);
            }
            else if (this.startAxis == FlowLayoutGroup.Axis.Vertical)
            {
              float horizontalOffset = this.CalculateColHorizontalOffset(num7, num5, num10);
              this.LayoutCol(this._itemList, num10, num13, num8, horizontalOffset, (float) this.padding.top, axis);
            }
          }
          this._itemList.Clear();
          a = Mathf.Max(a, num13);
          num5 = num5 + num10 + num3;
          num10 = 0.0f;
          num9 = 0.0f;
        }
        num9 += num11;
        this._itemList.Add(rectChild);
        if ((double) num12 > (double) num10)
          num10 = num12;
        if (index1 < this.rectChildren.Count - 1)
          num9 += num4;
      }
      if (!layoutInput)
      {
        if (this.startAxis == FlowLayoutGroup.Axis.Horizontal)
        {
          float rowVerticalOffset = this.CalculateRowVerticalOffset(groupHeight, num5, num10);
          num9 -= num4;
          this.LayoutRow(this._itemList, num9, num10, num8 - (this.ChildForceExpandWidth ? 0.0f : num4), (float) this.padding.left, rowVerticalOffset, axis);
        }
        else if (this.startAxis == FlowLayoutGroup.Axis.Vertical)
        {
          float horizontalOffset = this.CalculateColHorizontalOffset(groupWidth, num5, num10);
          num9 -= num4;
          this.LayoutCol(this._itemList, num10, num9, num8 - (this.ChildForceExpandHeight ? 0.0f : num4), horizontalOffset, (float) this.padding.top, axis);
        }
      }
      this._itemList.Clear();
      float num14 = Mathf.Max(a, num9);
      float num15 = num5 + num10 + num6;
      if (layoutInput)
        this.SetLayoutInputForAxis(num15, num15, -1f, axis);
      if (this.startAxis == FlowLayoutGroup.Axis.Vertical)
        this.rectTransform.sizeDelta = this.rectTransform.sizeDelta.WithY(num14);
      else
        this.rectTransform.sizeDelta = this.rectTransform.sizeDelta.WithX(num14);
      return num15;
    }

    private float CalculateRowVerticalOffset(
      float groupHeight,
      float yOffset,
      float currentRowHeight)
    {
      if (this.IsLowerAlign)
        return groupHeight - yOffset - currentRowHeight;
      return this.IsMiddleAlign ? (float) ((double) groupHeight * 0.5 - (double) this._layoutHeight * 0.5) + yOffset : yOffset;
    }

    private float CalculateColHorizontalOffset(
      float groupWidth,
      float xOffset,
      float currentColWidth)
    {
      if (this.IsRightAlign)
        return groupWidth - xOffset - currentColWidth;
      return this.IsCenterAlign ? (float) ((double) groupWidth * 0.5 - (double) this._layoutWidth * 0.5) + xOffset : xOffset;
    }

    protected void LayoutRow(
      IList<RectTransform> contents,
      float rowWidth,
      float rowHeight,
      float maxWidth,
      float xOffset,
      float yOffset,
      int axis)
    {
      float pos1 = xOffset;
      if (!this.ChildForceExpandWidth && this.IsCenterAlign)
        pos1 += (float) (((double) maxWidth - (double) rowWidth) * 0.5);
      else if (!this.ChildForceExpandWidth && this.IsRightAlign)
        pos1 += maxWidth - rowWidth;
      float num1 = 0.0f;
      float num2 = 0.0f;
      if (this.ChildForceExpandWidth)
        num1 = (maxWidth - rowWidth) / (float) this._itemList.Count;
      else if (this.ExpandHorizontalSpacing)
      {
        num2 = (maxWidth - rowWidth) / (float) (this._itemList.Count - 1);
        if (this._itemList.Count > 1)
        {
          if (this.IsCenterAlign)
            pos1 -= num2 * 0.5f * (float) (this._itemList.Count - 1);
          else if (this.IsRightAlign)
            pos1 -= num2 * (float) (this._itemList.Count - 1);
        }
      }
      for (int index = 0; index < this._itemList.Count; ++index)
      {
        RectTransform rect = this._itemList[this.IsLowerAlign ? this._itemList.Count - 1 - index : index];
        float a = LayoutUtility.GetPreferredSize(rect, 0) + num1;
        float size1 = LayoutUtility.GetPreferredSize(rect, 1);
        if (this.ChildForceExpandHeight)
          size1 = rowHeight;
        float size2 = Mathf.Min(a, maxWidth);
        float pos2 = yOffset;
        if (this.IsMiddleAlign)
          pos2 += (float) (((double) rowHeight - (double) size1) * 0.5);
        else if (this.IsLowerAlign)
          pos2 += rowHeight - size1;
        if (this.ExpandHorizontalSpacing && index > 0)
          pos1 += num2;
        if (axis == 0)
          this.SetChildAlongAxis(rect, 0, pos1, size2);
        else
          this.SetChildAlongAxis(rect, 1, pos2, size1);
        if (index < this._itemList.Count - 1)
          pos1 += size2 + this.SpacingX;
      }
    }

    protected void LayoutCol(
      IList<RectTransform> contents,
      float colWidth,
      float colHeight,
      float maxHeight,
      float xOffset,
      float yOffset,
      int axis)
    {
      float pos1 = yOffset;
      if (!this.ChildForceExpandHeight && this.IsMiddleAlign)
        pos1 += (float) (((double) maxHeight - (double) colHeight) * 0.5);
      else if (!this.ChildForceExpandHeight && this.IsLowerAlign)
        pos1 += maxHeight - colHeight;
      float num1 = 0.0f;
      float num2 = 0.0f;
      if (this.ChildForceExpandHeight)
        num1 = (maxHeight - colHeight) / (float) this._itemList.Count;
      else if (this.ExpandHorizontalSpacing)
      {
        num2 = (maxHeight - colHeight) / (float) (this._itemList.Count - 1);
        if (this._itemList.Count > 1)
        {
          if (this.IsMiddleAlign)
            pos1 -= num2 * 0.5f * (float) (this._itemList.Count - 1);
          else if (this.IsLowerAlign)
            pos1 -= num2 * (float) (this._itemList.Count - 1);
        }
      }
      for (int index = 0; index < this._itemList.Count; ++index)
      {
        RectTransform rect = this._itemList[this.IsRightAlign ? this._itemList.Count - 1 - index : index];
        float size1 = LayoutUtility.GetPreferredSize(rect, 0);
        float a = LayoutUtility.GetPreferredSize(rect, 1) + num1;
        if (this.ChildForceExpandWidth)
          size1 = colWidth;
        float size2 = Mathf.Min(a, maxHeight);
        float pos2 = xOffset;
        if (this.IsCenterAlign)
          pos2 += (float) (((double) colWidth - (double) size1) * 0.5);
        else if (this.IsRightAlign)
          pos2 += colWidth - size1;
        if (this.ExpandHorizontalSpacing && index > 0)
          pos1 += num2;
        if (axis == 0)
          this.SetChildAlongAxis(rect, 0, pos2, size1);
        else
          this.SetChildAlongAxis(rect, 1, pos1, size2);
        if (index < this._itemList.Count - 1)
          pos1 += size2 + this.SpacingY;
      }
    }

    public float GetGreatestMinimumChildWidth()
    {
      float b = 0.0f;
      for (int index = 0; index < this.rectChildren.Count; ++index)
        b = Mathf.Max(LayoutUtility.GetMinWidth(this.rectChildren[index]), b);
      return b;
    }

    public float GetGreatestMinimumChildHeigth()
    {
      float b = 0.0f;
      for (int index = 0; index < this.rectChildren.Count; ++index)
        b = Mathf.Max(LayoutUtility.GetMinHeight(this.rectChildren[index]), b);
      return b;
    }

    public enum Axis
    {
      Horizontal,
      Vertical,
    }
  }
}
