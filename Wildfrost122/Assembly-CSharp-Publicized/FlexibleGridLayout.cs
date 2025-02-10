// Decompiled with JetBrains decompiler
// Type: FlexibleGridLayout
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class FlexibleGridLayout : LayoutGroup
{
  public FlexibleGridLayout.FitType fitType;
  public int rows;
  public int columns;
  public Vector2 cellSize;
  public Vector2 spacing;
  public bool autoSizeX;
  public bool autoSizeY;

  public override void CalculateLayoutInputHorizontal()
  {
    base.CalculateLayoutInputHorizontal();
    this.autoSizeX = false;
    this.autoSizeY = false;
    if (this.fitType == FlexibleGridLayout.FitType.Width || this.fitType == FlexibleGridLayout.FitType.Height || this.fitType == FlexibleGridLayout.FitType.Uniform)
    {
      this.autoSizeX = true;
      this.autoSizeY = true;
      float f = Mathf.Sqrt((float) this.transform.childCount);
      this.rows = Mathf.CeilToInt(f);
      this.columns = Mathf.CeilToInt(f);
    }
    switch (this.fitType)
    {
      case FlexibleGridLayout.FitType.Width:
      case FlexibleGridLayout.FitType.FixedColumns:
        this.rows = Mathf.CeilToInt((float) (this.transform.childCount / this.columns));
        break;
      case FlexibleGridLayout.FitType.Height:
      case FlexibleGridLayout.FitType.FixedRows:
        this.columns = Mathf.CeilToInt((float) (this.transform.childCount / this.rows));
        break;
    }
    Rect rect = this.rectTransform.rect;
    float width = rect.width;
    rect = this.rectTransform.rect;
    float height = rect.height;
    if (this.autoSizeX)
      this.cellSize.x = (float) ((double) width / (double) this.columns - (double) this.spacing.x / (double) this.columns * (double) (this.columns - 1)) - (float) (this.padding.left / this.columns) - (float) (this.padding.right / this.columns);
    if (this.autoSizeY)
      this.cellSize.y = (float) ((double) height / (double) this.rows - (double) this.spacing.y / (double) this.rows * (double) (this.columns - 1)) - (float) (this.padding.top / this.rows) - (float) (this.padding.bottom / this.rows);
    for (int index = 0; index < this.rectChildren.Count; ++index)
    {
      int num1 = index / this.columns;
      int num2 = index % this.columns;
      RectTransform rectChild = this.rectChildren[index];
      float pos1 = (float) ((double) this.cellSize.x * (double) num2 + (double) this.spacing.x * (double) num2) + (float) this.padding.left;
      float pos2 = (float) ((double) this.cellSize.y * (double) num1 + (double) this.spacing.y * (double) num1) + (float) this.padding.top;
      this.SetChildAlongAxis(rectChild, 0, pos1, this.cellSize.x);
      this.SetChildAlongAxis(rectChild, 1, pos2, this.cellSize.y);
    }
  }

  public override void CalculateLayoutInputVertical()
  {
  }

  public override void SetLayoutHorizontal()
  {
  }

  public override void SetLayoutVertical()
  {
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
