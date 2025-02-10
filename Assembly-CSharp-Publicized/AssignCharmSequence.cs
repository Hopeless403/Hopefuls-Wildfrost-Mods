// Decompiled with JetBrains decompiler
// Type: AssignCharmSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class AssignCharmSequence : UISequence
{
  [SerializeField]
  public Image background;
  [SerializeField]
  public float backgroundAlpha = 0.67f;
  [SerializeField]
  public Transform cardHolder;
  [SerializeField]
  public float cardScale = 1f;
  [SerializeField]
  public ParticleSystem glows;
  [SerializeField]
  public ParticleSystem ding;
  [SerializeField]
  public UnityEngine.Animator animator;
  public Entity target;
  public CardUpgradeData upgradeData;
  public float fade;
  public static float fadeInDur = 0.5f;
  public static float fadeOutDur = 0.25f;
  public Transform previousParent;
  public int previousChildIndex;
  public Vector3 previousPosition;

  public void Assign(Entity target, CardUpgradeData upgradeData)
  {
    this.target = target;
    this.upgradeData = upgradeData;
  }

  public void Focus()
  {
    this.target.ForceUnHover();
    this.previousParent = this.target.transform.parent;
    this.previousChildIndex = this.target.transform.GetSiblingIndex();
    this.previousPosition = this.target.transform.localPosition;
    this.target.transform.SetParent(this.cardHolder, true);
    LeanTween.moveLocal(this.target.gameObject, Vector3.zero, 0.5f).setEase(LeanTweenType.easeOutQuart);
    this.target.wobbler?.WobbleRandom();
    LeanTween.scale(this.target.gameObject, Vector3.one * this.cardScale, 0.67f).setEase(LeanTweenType.easeOutBack);
    LeanTween.rotateLocal(this.target.gameObject, Vector3.zero, 1f).setEase(LeanTweenType.easeOutBack);
  }

  public void Unfocus()
  {
    this.target.transform.parent = this.previousParent;
    this.target.transform.SetSiblingIndex(this.previousChildIndex);
    this.target.TweenToContainer();
    this.target.wobbler?.WobbleRandom();
  }

  public override IEnumerator Run()
  {
    AssignCharmSequence assignCharmSequence = this;
    assignCharmSequence.gameObject.SetActive(true);
    yield return (object) Sequences.Wait(assignCharmSequence.startDelay);
    assignCharmSequence.BackgroundFade(assignCharmSequence.backgroundAlpha, AssignCharmSequence.fadeInDur);
    assignCharmSequence.Focus();
    assignCharmSequence.animator.SetTrigger("Assign");
    SfxSystem.OneShot("event:/sfx/inventory/charm_assign");
    yield return (object) new WaitForSeconds(3f);
    assignCharmSequence.BackgroundFade(0.0f, AssignCharmSequence.fadeOutDur);
    yield return (object) new WaitForSeconds(AssignCharmSequence.fadeOutDur * 0.5f);
    assignCharmSequence.Unfocus();
    yield return (object) new WaitForSeconds(AssignCharmSequence.fadeOutDur * 0.5f);
    assignCharmSequence.gameObject.SetActive(false);
  }

  public void BackgroundFade(float alpha, float dur)
  {
    LeanTween.cancel(this.background.gameObject);
    LeanTween.value(this.background.gameObject, this.fade, alpha, dur).setEase(LeanTweenType.easeOutQuad).setOnUpdate((Action<float>) (a =>
    {
      this.fade = a;
      this.background.color = this.background.color.WithAlpha(a);
    }));
  }

  public void Rumble() => Events.InvokeScreenRumble(0.0f, 1f, 0.0f, 1f, 0.5f, 0.25f);

  public void AssignCharm()
  {
    Routine routine = new Routine(this.upgradeData.Assign(this.target));
  }

  public void StartGlow() => this.glows.Play();

  public void Ding() => this.ding.Play();

  [CompilerGenerated]
  public void \u003CBackgroundFade\u003Eb__19_0(float a)
  {
    this.fade = a;
    this.background.color = this.background.color.WithAlpha(a);
  }
}
