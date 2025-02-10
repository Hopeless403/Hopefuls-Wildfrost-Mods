// Decompiled with JetBrains decompiler
// Type: CardHand
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using System;
using UnityEngine;

public class CardHand : CardContainer
{
  [SerializeField]
  private float fanCircleRadius = 20f;
  [SerializeField]
  private Vector3 fanCircleStartPos = new Vector3(0.0f, -20f, 0.0f);
  public bool staticAngleAdd;
  [ShowIf("staticAngleAdd")]
  public float fanCircleAngleAdd = 5f;
  [SerializeField]
  [DisableIf("staticAngleAdd")]
  private AnimationCurve fanCircleAngleAddCurve;
  [SerializeField]
  private bool dynamicGap;
  [SerializeField]
  [EnableIf("dynamicGap")]
  private AnimationCurve dynamicGapCurve;

  public override void TweenChildPosition(Entity child)
  {
    child.DrawOrder = this.GetChildDrawOrder(child);
    base.TweenChildPosition(child);
  }

  public override void SetSize(int size, float cardScale)
  {
    base.SetSize(size, cardScale);
    this.holder.sizeDelta = new Vector2((float) ((double) (3f * cardScale) * (double) size + (double) this.GetGap(size).x * (double) (size - 1)), 4.5f * cardScale);
  }

  public override Vector3 GetChildPosition(Entity child)
  {
    int childIndex = this.IndexOf(child);
    float radians = (float) (((double) this.GetAngle(childIndex) + 90.0) * (Math.PI / 180.0));
    Vector3 gap = this.GetGap(this.Count);
    return this.fanCircleStartPos + gap * ((float) (this.Count - 1) * 0.5f) - gap * (float) childIndex + (Vector3) Lengthdir.ToVector2(this.fanCircleRadius, radians);
  }

  public override Vector3 GetChildRotation(Entity child) => new Vector3(0.0f, 0.0f, this.GetAngle(this.IndexOf(child)));

  private Vector3 GetGap(int cardCount)
  {
    if (!this.dynamicGap || this.dynamicGapCurve.length <= 0)
      return this.gap;
    Keyframe keyframe = this.dynamicGapCurve[this.dynamicGapCurve.length - 1];
    float time = keyframe.time;
    return this.gap.WithX((double) cardCount > (double) time ? keyframe.value : this.dynamicGapCurve.Evaluate((float) cardCount));
  }

  private float GetAngleAdd()
  {
    if (this.fanCircleAngleAddCurve.length <= 0 || this.staticAngleAdd)
      return this.fanCircleAngleAdd;
    Keyframe keyframe = this.fanCircleAngleAddCurve[this.fanCircleAngleAddCurve.length - 1];
    return (double) this.Count <= (double) keyframe.time ? this.fanCircleAngleAddCurve.Evaluate((float) this.Count) : keyframe.value;
  }

  private float GetAngle(int childIndex)
  {
    float angleAdd = this.GetAngleAdd();
    return (float) (-(double) angleAdd * (double) (this.Count - 1) * 0.5 + (double) childIndex * (double) angleAdd);
  }
}
