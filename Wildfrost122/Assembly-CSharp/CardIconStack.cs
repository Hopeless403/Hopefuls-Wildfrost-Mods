// Decompiled with JetBrains decompiler
// Type: CardIconStack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using UnityEngine;

#nullable disable
public class CardIconStack : CardContainer
{
  private Dictionary<Entity, RectTransform> activeIcons = new Dictionary<Entity, RectTransform>();
  private Queue<RectTransform> iconPool = new Queue<RectTransform>();
  private int iconCount;
  [SerializeField]
  private Vector3 randomAngleAmount = new Vector3(0.0f, 0.0f, 2f);
  public bool insertAtBottom;
  [SerializeField]
  private RectTransform iconPrefab;

  public override void SetSize(int size, float cardScale)
  {
    base.SetSize(size, cardScale);
    this.holder.sizeDelta = GameManager.CARD_SIZE * cardScale;
  }

  public override Vector3 GetChildPosition(Entity child)
  {
    this.IndexOf(child);
    return new Vector3(0.0f, 0.0f, 0.0f);
  }

  public override void Add(Entity entity)
  {
    if (this.insertAtBottom)
    {
      entity.transform.SetParent((Transform) this.holder);
      entity.AddTo((CardContainer) this);
      this.entities.Insert(0, entity);
      entity.transform.SetSiblingIndex(0);
      ++this.Count;
      this.CardAdded(entity);
      for (int index = 1; index < this.Count; ++index)
        this.TweenChildPosition(this.entities[index]);
    }
    else
      base.Add(entity);
  }

  public override Vector3 GetChildRotation(Entity child) => Vector3.zero;

  protected override void CardAdded(Entity entity)
  {
    base.CardAdded(entity);
    entity.enabled = false;
    if ((Object) entity.flipper != (Object) null && !entity.flipper.flipped)
      entity.flipper.FlipDown();
    this.AddIcon(entity);
  }

  protected override void CardRemoved(Entity entity) => this.RemoveIcon(entity);

  private void AddIcon(Entity entity)
  {
    this.activeIcons[entity] = this.GetIcon();
    this.UpdateIconPositions();
  }

  private void RemoveIcon(Entity entity)
  {
    RectTransform activeIcon = this.activeIcons[entity];
    if (!((Object) activeIcon != (Object) null))
      return;
    this.PoolIcon(activeIcon);
    this.activeIcons.Remove(entity);
  }

  private void UpdateIconPositions()
  {
    int count = this.Count;
    for (int index = 0; index < count; ++index)
    {
      Entity key = this[index];
      RectTransform activeIcon = this.activeIcons[key];
      activeIcon.SetSiblingIndex(index);
      activeIcon.localPosition = this.gap * (float) index;
      activeIcon.localEulerAngles = Vector3.Scale(key.random3, this.randomAngleAmount);
    }
  }

  private void PoolIcon(RectTransform icon)
  {
    icon.gameObject.SetActive(false);
    this.iconPool.Enqueue(icon);
  }

  private RectTransform GetIcon()
  {
    RectTransform icon;
    if (this.iconPool.Count > 0)
    {
      icon = this.iconPool.Dequeue();
    }
    else
    {
      icon = Object.Instantiate<RectTransform>(this.iconPrefab, this.transform);
      icon.name = string.Format("Icon {0}", (object) this.iconCount++);
    }
    icon.gameObject.SetActive(true);
    return icon;
  }
}
