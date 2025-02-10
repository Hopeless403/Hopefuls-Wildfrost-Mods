// Decompiled with JetBrains decompiler
// Type: CardContainerGrid
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class CardContainerGrid : CardContainer
{
  [SerializeField]
  public bool fixedWidth;
  [SerializeField]
  public float minHeight;
  [SerializeField]
  public Vector2 cellSize = new Vector2(2.25f, 3.375f);
  [SerializeField]
  public Vector2 spacing = new Vector2(0.5f, 0.5f);
  [SerializeField]
  public int columnCount = 5;
  [SerializeField]
  public TextAlignment align = TextAlignment.Center;
  [Header("Sort Cards by Type")]
  [SerializeField]
  public bool sort;
  [Header("A lil randomness to card position/rotation")]
  [SerializeField]
  public Vector3 randomOffset;
  [SerializeField]
  public Vector3 randomRotation;

  public new void DestroyAll()
  {
    foreach (Entity entity in this.entities)
      CardManager.ReturnToPool(entity);
    this.entities.Clear();
    this.Count = 0;
  }

  public override void CardAdded(Entity entity)
  {
    base.CardAdded(entity);
    this.SetSize();
    this.Sort();
  }

  public override void CardRemoved(Entity entity)
  {
    base.CardRemoved(entity);
    this.SetSize();
    this.Sort();
  }

  public override float CardScale => this.cellSize.x / 3f;

  public override Vector3 GetChildPosition(Entity child)
  {
    int num1 = this.IndexOf(child);
    int num2 = num1 % this.columnCount;
    int rowIndex = Mathf.FloorToInt((float) (num1 / this.columnCount));
    int num3 = this.RowCount(rowIndex);
    float num4 = (float) ((double) num3 * (double) this.cellSize.x + (double) (num3 - 1) * (double) this.spacing.x);
    Vector2 sizeDelta = this.rectTransform.sizeDelta;
    Vector2 vector2_1 = new Vector2(-sizeDelta.x, sizeDelta.y) * 0.5f;
    switch (this.align)
    {
      case TextAlignment.Center:
        vector2_1.x = (float) (-(double) num4 * 0.5);
        break;
      case TextAlignment.Right:
        vector2_1.x = sizeDelta.x * 0.5f - num4;
        break;
    }
    vector2_1.x += this.cellSize.x * 0.5f + this.spacing.x;
    vector2_1.y -= this.cellSize.y * 0.5f + this.spacing.y;
    Vector2 vector2_2 = vector2_1;
    vector2_2.x += (float) ((double) num2 * (double) this.cellSize.x + (double) (num2 - 1) * (double) this.spacing.x);
    vector2_2.y -= (float) ((double) rowIndex * (double) this.cellSize.y + (double) (rowIndex - 1) * (double) this.spacing.y);
    return (Vector3) vector2_2 + Vector3.Scale(child.random3, this.randomOffset);
  }

  public int RowCount(int rowIndex)
  {
    return Mathf.Clamp(this.Count - rowIndex * this.columnCount, 0, this.columnCount);
  }

  public override Vector3 GetChildRotation(Entity child)
  {
    return Vector3.Scale(child.random3, this.randomRotation);
  }

  public void SetSize()
  {
    int columnCount = this.GetColumnCount();
    int rowCount = this.GetRowCount();
    float x = this.fixedWidth ? this.rectTransform.sizeDelta.x : (float) ((double) columnCount * (double) this.cellSize.x + (double) (columnCount - 1) * (double) this.spacing.x);
    float y = Mathf.Max(this.minHeight, (float) ((double) rowCount * (double) this.cellSize.y + (double) (rowCount - 1) * (double) this.spacing.y));
    LayoutElement component = this.GetComponent<LayoutElement>();
    if (component != null)
    {
      component.preferredWidth = x;
      component.preferredHeight = y;
    }
    else
      this.rectTransform.sizeDelta = new Vector2(x, y);
  }

  public void Sort()
  {
    if (!this.sort)
      return;
    this.entities.Sort((Comparison<Entity>) ((a, b) => a.data.cardType.sortPriority.CompareTo(b.data.cardType.sortPriority)));
  }

  public int GetColumnCount() => Mathf.Min(this.columnCount, this.Count);

  public int GetRowCount() => Mathf.CeilToInt((float) this.Count / (float) this.columnCount);
}
