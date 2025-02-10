// Decompiled with JetBrains decompiler
// Type: CardStack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
public class CardStack : CardContainer
{
  [SerializeField]
  public Vector3 randomAngleAmount = new Vector3(0.0f, 0.0f, 2f);
  public bool insertAtBottom;
  public bool flipOnAdd = true;

  public override void SetSize(int size, float cardScale)
  {
    base.SetSize(size, cardScale);
    this.holder.sizeDelta = GameManager.CARD_SIZE * cardScale;
  }

  public override Vector3 GetChildPosition(Entity child)
  {
    int num1 = this.IndexOf(child);
    float num2 = 0.0f;
    float num3 = 0.0f;
    double x = 0.0 + (double) this.gap.x * (double) num1;
    float num4 = num2 + this.gap.y * (float) num1;
    float num5 = num3 + this.gap.z * (float) num1;
    double y = (double) num4;
    double z = (double) num5;
    return new Vector3((float) x, (float) y, (float) z);
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

  public override Vector3 GetChildRotation(Entity child)
  {
    return Vector3.Scale(child.random3, this.randomAngleAmount);
  }

  public override void CardAdded(Entity entity)
  {
    base.CardAdded(entity);
    entity.enabled = false;
    if (!this.flipOnAdd || !(bool) (Object) entity.flipper)
      return;
    entity.flipper.FlipDown();
  }
}
