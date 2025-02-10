// Decompiled with JetBrains decompiler
// Type: SnowBear
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
public class SnowBear : ScriptableCardImage
{
  [SerializeField]
  public Transform main;
  [SerializeField]
  public Transform ball;
  [SerializeField]
  public AnimationCurve curve;
  [SerializeField]
  public AnimationCurve ballScaleCurve;
  [SerializeField]
  public AnimationCurve ballYCurve;
  [SerializeField]
  public AnimationCurve yCurve;
  [Header("Tween")]
  [SerializeField]
  public AnimationCurve tweenCurve;
  [SerializeField]
  public float tweenDur;
  public float tweenFrom;
  public float tweenTo;
  public float tweenT;
  public bool tween;
  public bool currentSet;
  public int current;

  public override void UpdateEvent()
  {
    if (this.currentSet && this.current == this.entity.damage.current)
      return;
    this.currentSet = true;
    this.current = this.entity.damage.current;
    this.Set();
  }

  public void Set()
  {
    this.tweenFrom = this.tweenTo;
    this.tweenTo = this.curve.Evaluate((float) this.current);
    this.StartTween();
  }

  public void StartTween()
  {
    this.tween = true;
    this.tweenT = 0.0f;
  }

  public void Update()
  {
    if (!this.tween)
      return;
    this.tweenT += Time.deltaTime / this.tweenDur;
    this.UpdateValues(this.tweenFrom + this.tweenCurve.Evaluate(this.tweenT) * (this.tweenTo - this.tweenFrom));
    if ((double) this.tweenT <= 1.0)
      return;
    this.tween = false;
  }

  public void UpdateValues(float progress)
  {
    float num1 = this.ballScaleCurve.Evaluate(progress);
    float num2 = this.ballYCurve.Evaluate(progress);
    float num3 = this.yCurve.Evaluate(progress);
    this.ball.localScale = new Vector3(num1, num1, 1f);
    this.ball.localPosition = this.ball.localPosition.WithY(num2);
    this.main.localPosition = this.main.localPosition.WithY(num3);
  }
}
