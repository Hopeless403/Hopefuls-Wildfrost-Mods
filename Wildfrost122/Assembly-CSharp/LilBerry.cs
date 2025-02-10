// Decompiled with JetBrains decompiler
// Type: LilBerry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
public class LilBerry : ScriptableCardImage
{
  [SerializeField]
  private Transform image;
  [SerializeField]
  private AnimationCurve scaleCurve;
  [Header("Scale Tween")]
  [SerializeField]
  private AnimationCurve tweenCurve;
  [SerializeField]
  private float tweenDur;
  private float scaleFrom = 1f;
  private float scaleTo = 1f;
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
    this.SetScale();
  }

  private void SetScale()
  {
    this.scaleFrom = Mathf.Lerp(1f, this.image.localScale.x, 0.5f);
    this.scaleTo = this.scaleCurve.Evaluate((float) this.current);
    this.StartScaleTween();
  }

  private void StartScaleTween()
  {
    this.tween = true;
    this.tweenT = 0.0f;
  }

  private void Update()
  {
    if (!this.tween)
      return;
    this.tweenT += Time.deltaTime / this.tweenDur;
    float num = this.scaleFrom + this.tweenCurve.Evaluate(this.tweenT) * (this.scaleTo - this.scaleFrom);
    this.image.transform.localScale = new Vector3(num, num, 1f);
    if ((double) this.tweenT <= 1.0)
      return;
    this.tween = false;
  }
}
