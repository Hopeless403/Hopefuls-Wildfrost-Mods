// Decompiled with JetBrains decompiler
// Type: CardHand
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System;
using UnityEngine;

#nullable disable
public class CardHand : CardContainer
{
  [SerializeField]
  public float fanCircleRadius = 20f;
  [SerializeField]
  public Vector3 fanCircleStartPos = new Vector3(0.0f, -20f, 0.0f);
  public bool staticAngleAdd;
  [ShowIf("staticAngleAdd")]
  public float fanCircleAngleAdd = 5f;
  [SerializeField]
  [DisableIf("staticAngleAdd")]
  public AnimationCurve fanCircleAngleAddCurve;
  [SerializeField]
  public bool dynamicGap;
  [SerializeField]
  [EnableIf("dynamicGap")]
  public AnimationCurve dynamicGapCurve;

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

  public override Vector3 GetChildRotation(Entity child)
  {
    return new Vector3(0.0f, 0.0f, this.GetAngle(this.IndexOf(child)));
  }

  public Vector3 GetGap(int cardCount)
  {
    if (!this.dynamicGap || this.dynamicGapCurve.length <= 0)
      return this.gap;
    Keyframe keyframe = this.dynamicGapCurve[this.dynamicGapCurve.length - 1];
    float time = keyframe.time;
    return this.gap.WithX((double) cardCount > (double) time ? keyframe.value : this.dynamicGapCurve.Evaluate((float) cardCount));
  }

  public float GetAngleAdd()
  {
    if (this.fanCircleAngleAddCurve.length <= 0 || this.staticAngleAdd)
      return this.fanCircleAngleAdd;
    Keyframe keyframe = this.fanCircleAngleAddCurve[this.fanCircleAngleAddCurve.length - 1];
    return (double) this.Count <= (double) keyframe.time ? this.fanCircleAngleAddCurve.Evaluate((float) this.Count) : keyframe.value;
  }

  public float GetAngle(int childIndex)
  {
    float angleAdd = this.GetAngleAdd();
    return (float) (-(double) angleAdd * (double) (this.Count - 1) * 0.5 + (double) childIndex * (double) angleAdd);
  }
}
