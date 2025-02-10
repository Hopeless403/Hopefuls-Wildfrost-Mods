// Decompiled with JetBrains decompiler
// Type: SnowBear
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
public class SnowBear : ScriptableCardImage
{
  [SerializeField]
  private Transform main;
  [SerializeField]
  private Transform ball;
  [SerializeField]
  private AnimationCurve curve;
  [SerializeField]
  private AnimationCurve ballScaleCurve;
  [SerializeField]
  private AnimationCurve ballYCurve;
  [SerializeField]
  private AnimationCurve yCurve;
  [Header("Tween")]
  [SerializeField]
  private AnimationCurve tweenCurve;
  [SerializeField]
  private float tweenDur;
  private float tweenFrom;
  private float tweenTo;
  private float tweenT;
  private bool tween;
  private bool currentSet;
  private int current;

  public override void UpdateEvent()
  {
    if (this.currentSet && this.current == this.entity.damage.current)
      return;
    this.currentSet = true;
    this.current = this.entity.damage.current;
    this.Set();
  }

  private void Set()
  {
    this.tweenFrom = this.tweenTo;
    this.tweenTo = this.curve.Evaluate((float) this.current);
    this.StartTween();
  }

  private void StartTween()
  {
    this.tween = true;
    this.tweenT = 0.0f;
  }

  private void Update()
  {
    if (!this.tween)
      return;
    this.tweenT += Time.deltaTime / this.tweenDur;
    this.UpdateValues(this.tweenFrom + this.tweenCurve.Evaluate(this.tweenT) * (this.tweenTo - this.tweenFrom));
    if ((double) this.tweenT <= 1.0)
      return;
    this.tween = false;
  }

  private void UpdateValues(float progress)
  {
    float num1 = this.ballScaleCurve.Evaluate(progress);
    float num2 = this.ballYCurve.Evaluate(progress);
    float num3 = this.yCurve.Evaluate(progress);
    this.ball.localScale = new Vector3(num1, num1, 1f);
    this.ball.localPosition = this.ball.localPosition.WithY(num2);
    this.main.localPosition = this.main.localPosition.WithY(num3);
  }
}
