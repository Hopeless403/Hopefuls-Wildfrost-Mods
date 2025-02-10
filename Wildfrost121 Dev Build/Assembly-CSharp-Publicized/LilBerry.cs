// Decompiled with JetBrains decompiler
// Type: LilBerry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
public class LilBerry : ScriptableCardImage
{
  [SerializeField]
  public Transform image;
  [SerializeField]
  public AnimationCurve scaleCurve;
  [Header("Scale Tween")]
  [SerializeField]
  public AnimationCurve tweenCurve;
  [SerializeField]
  public float tweenDur;
  public float scaleFrom = 1f;
  public float scaleTo = 1f;
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
    this.SetScale();
  }

  public void SetScale()
  {
    this.scaleFrom = Mathf.Lerp(1f, this.image.localScale.x, 0.5f);
    this.scaleTo = this.scaleCurve.Evaluate((float) this.current);
    this.StartScaleTween();
  }

  public void StartScaleTween()
  {
    this.tween = true;
    this.tweenT = 0.0f;
  }

  public void Update()
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
