// Decompiled with JetBrains decompiler
// Type: CardContainerGrid
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using UnityEngine;
using UnityEngine.UI;

public class CardContainerGrid : CardContainer
{
  [SerializeField]
  private bool fixedWidth;
  [SerializeField]
  private float minHeight;
  [SerializeField]
  private Vector2 cellSize = new Vector2(2.25f, 3.375f);
  [SerializeField]
  private Vector2 spacing = new Vector2(0.5f, 0.5f);
  [SerializeField]
  private int columnCount = 5;
  [SerializeField]
  private TextAlignment align = TextAlignment.Center;
  [Header("Sort Cards by Type")]
  [SerializeField]
  private bool sort;
  [Header("A lil randomness to card position/rotation")]
  [SerializeField]
  private Vector3 randomOffset;
  [SerializeField]
  private Vector3 randomRotation;

  public new void DestroyAll()
  {
    foreach (Entity entity in this.entities)
      CardManager.ReturnToPool(entity);
    this.entities.Clear();
    this.Count = 0;
  }

  protected override void CardAdded(Entity entity)
  {
    base.CardAdded(entity);
    this.SetSize();
    this.Sort();
  }

  protected override void CardRemoved(Entity entity)
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

  private int RowCount(int rowIndex) => Mathf.Clamp(this.Count - rowIndex * this.columnCount, 0, this.columnCount);

  public override Vector3 GetChildRotation(Entity child) => Vector3.Scale(child.random3, this.randomRotation);

  private void SetSize()
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

  private void Sort()
  {
    if (!this.sort)
      return;
    this.entities.Sort((Comparison<Entity>) ((a, b) => a.data.cardType.sortPriority.CompareTo(b.data.cardType.sortPriority)));
  }

  private int GetColumnCount() => Mathf.Min(this.columnCount, this.Count);

  private int GetRowCount() => Mathf.CeilToInt((float) this.Count / (float) this.columnCount);
}
