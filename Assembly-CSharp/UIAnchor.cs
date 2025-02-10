// Decompiled with JetBrains decompiler
// Type: UIAnchor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public class UIAnchor : MonoBehaviour
{
  public float revealDur = 0.75f;
  public float hideDur = 0.25f;
  [Header("Rotation")]
  public Vector3 angleStart = new Vector3(45f, 90f, 0.0f);
  public bool angleRandomSign = true;
  public LeanTweenType angleTweenEase = LeanTweenType.easeOutBack;
  [Header("Rotation Hide")]
  public Vector3 angleHide = new Vector3(45f, 90f, 0.0f);
  public bool angleHideRandomSign = true;
  public LeanTweenType angleHideTweenEase = LeanTweenType.easeInBack;
  [Header("Scale")]
  public Vector3 scaleStart = Vector3.one;
  public LeanTweenType scaleTweenEase = LeanTweenType.easeInQuart;
  [Header("Scale Hide")]
  public Vector3 scaleHide = Vector3.zero;
  public LeanTweenType scaleHideTweenEase = LeanTweenType.easeInBack;
  [Header("Wobble?")]
  public float wobbleAmount = 2f;
  [Header("Fade In?")]
  public bool doFadeIn = true;
  public float fadeInDur = 0.25f;
  public bool doFadeOut = true;
  public float fadeOutDur = 0.25f;

  public void SetUp()
  {
    if (this.angleRandomSign)
      this.transform.localEulerAngles = new Vector3(this.angleStart.x.WithRandomSign(), this.angleStart.y.WithRandomSign(), this.angleStart.z.WithRandomSign());
    else
      this.transform.localEulerAngles = this.angleStart;
    this.transform.localScale = this.scaleStart;
    if (!this.doFadeIn)
      return;
    CanvasGroup component = this.GetComponent<CanvasGroup>();
    if (!((Object) component != (Object) null))
      return;
    component.alpha = 0.0f;
  }

  public void Reveal()
  {
    LeanTween.cancel(this.gameObject);
    Vector3 zero = Vector3.zero;
    if (this.transform.localEulerAngles != zero)
      LeanTween.rotateLocal(this.gameObject, zero, this.revealDur).setEase(this.angleTweenEase);
    Vector3 one = Vector3.one;
    if (this.transform.localScale != one)
      LeanTween.scale(this.gameObject, one, this.revealDur).setEase(this.scaleTweenEase);
    if (this.doFadeIn && (double) this.fadeInDur > 0.0)
    {
      CanvasGroup component = this.GetComponent<CanvasGroup>();
      if ((Object) component != (Object) null)
        component.LeanAlpha(1f, this.fadeInDur).setEase(LeanTweenType.linear);
    }
    if ((double) this.wobbleAmount <= 0.0)
      return;
    Vector3 vector3 = -(this.transform.localEulerAngles / 90f) * this.wobbleAmount;
    this.transform.GetComponentInChildren<Wobbler>()?.Wobble(new Vector3(vector3.y, vector3.x, 0.0f));
  }

  public void UnReveal(float delay = 0.0f)
  {
    LeanTween.cancel(this.gameObject);
    Vector3 angleHide = this.angleHide;
    if (this.transform.localEulerAngles != angleHide)
      LeanTween.rotateLocal(this.gameObject, angleHide, this.hideDur).setDelay(delay).setEase(this.angleHideTweenEase);
    Vector3 scaleHide = this.scaleHide;
    if (this.transform.localScale != scaleHide)
      LeanTween.scale(this.gameObject, scaleHide, this.hideDur).setDelay(delay).setEase(this.scaleHideTweenEase);
    if (!this.doFadeOut || (double) this.fadeOutDur <= 0.0)
      return;
    CanvasGroup component = this.GetComponent<CanvasGroup>();
    if (!((Object) component != (Object) null))
      return;
    component.LeanAlpha(0.0f, this.fadeOutDur).setDelay(delay).setEase(LeanTweenType.linear);
  }
}
