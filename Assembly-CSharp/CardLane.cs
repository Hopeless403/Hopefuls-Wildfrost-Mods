// Decompiled with JetBrains decompiler
// Type: CardLane
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public class CardLane : CardContainer
{
  [Range(-1f, 1f)]
  public int dir = -1;

  public override void SetSize(int size, float cardScale)
  {
    base.SetSize(size, cardScale);
    this.holder.sizeDelta = new Vector2((float) ((double) (3f * cardScale) * (double) size + (double) this.gap.x * (double) (size - 1)), 4.5f * cardScale);
  }

  public override Vector3 GetChildPosition(Entity child)
  {
    int num1 = this.IndexOf(child);
    float num2 = 3f * this.CardScale;
    double cardScale = (double) this.CardScale;
    float num3 = this.holder.sizeDelta.x * 0.5f;
    float num4 = (float) ((double) this.max * (double) num2 * 0.5 + (double) (this.max - 1) * (double) this.gap.x * 0.5);
    float num5 = (float) ((double) -this.max * (double) this.gap.y * 0.5);
    float num6 = (float) ((double) -this.max * (double) this.gap.z * 0.5);
    int num7 = (double) num4 > (double) num3 ? 1 : 0;
    if (num7 != 0)
      num4 = num3;
    float num8 = num4 * 2f;
    float num9 = num4 * (float) this.dir + num2 * 0.5f * (float) -this.dir;
    float num10 = this.gap.x;
    if (num7 != 0)
      num10 = (num8 - num2 * (float) this.Count) / (float) Mathf.Max(1, this.Count - 1);
    float num11 = (num2 + num10) * (float) -this.dir;
    double x = (double) num9 + (double) num11 * (double) num1;
    float num12 = num5 + this.gap.y * (float) num1;
    float num13 = num6 + this.gap.z * (float) num1;
    double y = (double) num12;
    double z = (double) num13;
    return new Vector3((float) x, (float) y, (float) z);
  }

  public void SetDirection(int dir) => this.dir = dir;
}
