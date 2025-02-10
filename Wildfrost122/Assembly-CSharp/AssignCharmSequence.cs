// Decompiled with JetBrains decompiler
// Type: AssignCharmSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class AssignCharmSequence : UISequence
{
  [SerializeField]
  private Image background;
  [SerializeField]
  private float backgroundAlpha = 0.67f;
  [SerializeField]
  private Transform cardHolder;
  [SerializeField]
  private float cardScale = 1f;
  [SerializeField]
  private ParticleSystem glows;
  [SerializeField]
  private ParticleSystem ding;
  [SerializeField]
  private UnityEngine.Animator animator;
  private Entity target;
  private CardUpgradeData upgradeData;
  private float fade;
  private static float fadeInDur = 0.5f;
  private static float fadeOutDur = 0.25f;
  private Transform previousParent;
  private int previousChildIndex;
  private Vector3 previousPosition;

  public void Assign(Entity target, CardUpgradeData upgradeData)
  {
    this.target = target;
    this.upgradeData = upgradeData;
  }

  private void Focus()
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

  private void Unfocus()
  {
    if (!(bool) (UnityEngine.Object) this.target || !this.target.StillExists())
      return;
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

  private void BackgroundFade(float alpha, float dur)
  {
    LeanTween.cancel(this.background.gameObject);
    LeanTween.value(this.background.gameObject, this.fade, alpha, dur).setEase(LeanTweenType.easeOutQuad).setOnUpdate((Action<float>) (a =>
    {
      this.fade = a;
      this.background.color = this.background.color.WithAlpha(a);
    }));
  }

  private void Rumble() => Events.InvokeScreenRumble(0.0f, 1f, 0.0f, 1f, 0.5f, 0.25f);

  private void AssignCharm()
  {
    Routine routine = new Routine(this.upgradeData.Assign(this.target));
  }

  private void StartGlow() => this.glows.Play();

  private void Ding() => this.ding.Play();
}
