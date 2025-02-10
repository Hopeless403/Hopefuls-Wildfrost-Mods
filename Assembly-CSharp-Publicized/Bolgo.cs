// Decompiled with JetBrains decompiler
// Type: Bolgo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.UI;

public class Bolgo : ScriptableCardImage
{
  [SerializeField]
  public Image image;
  [Header("Scale Based On Damage")]
  [SerializeField]
  public AnimationCurve scaleCurve;
  [SerializeField]
  public AnimationCurve tweenCurve;
  [SerializeField]
  public float tweenDur;
  [Header("Set Sprite Based On Shell")]
  [SerializeField]
  public Sprite[] sprites;
  [SerializeField]
  public AnimationCurve spriteIndexCurve;
  public int currentShell;
  public bool currentDamageSet;
  public int currentDamage;
  public float scaleFrom = 1f;
  public float scaleTo = 1f;
  public float tweenT;
  public bool tween;

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

  public void SetScale()
  {
    this.scaleFrom = Mathf.Lerp(1f, this.image.transform.localScale.x, 0.5f);
    this.scaleTo = this.scaleCurve.Evaluate((float) this.currentDamage);
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
