// Decompiled with JetBrains decompiler
// Type: Bolgo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.UI;

public class Bolgo : ScriptableCardImage
{
  [SerializeField]
  private Image image;
  [Header("Scale Based On Damage")]
  [SerializeField]
  private AnimationCurve scaleCurve;
  [SerializeField]
  private AnimationCurve tweenCurve;
  [SerializeField]
  private float tweenDur;
  [Header("Set Sprite Based On Shell")]
  [SerializeField]
  private Sprite[] sprites;
  [SerializeField]
  private AnimationCurve spriteIndexCurve;
  private int currentShell;
  private bool currentDamageSet;
  private int currentDamage;
  private float scaleFrom = 1f;
  private float scaleTo = 1f;
  private float tweenT;
  private bool tween;

  public override void UpdateEvent()
  {
    if (!this.currentDamageSet || this.currentDamage != this.entity.damage.current)
    {
      this.currentDamageSet = true;
      this.currentDamage = this.entity.damage.current;
      this.SetScale();
    }
    StatusEffectData status = this.entity.FindStatus("shell");
    int count = status != null ? status.count : 0;
    if (count == this.currentShell)
      return;
    this.currentShell = count;
    this.image.sprite = this.sprites[Mathf.RoundToInt(Mathf.Clamp(this.spriteIndexCurve.Evaluate((float) this.currentShell), 0.0f, 1f) * ((float) this.sprites.Length - 1f))];
  }

  private void SetScale()
  {
    this.scaleFrom = Mathf.Lerp(1f, this.image.transform.localScale.x, 0.5f);
    this.scaleTo = this.scaleCurve.Evaluate((float) this.currentDamage);
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
