// Decompiled with JetBrains decompiler
// Type: OpenCharmBlockSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

public class OpenCharmBlockSequence : UISequence
{
  [Header("Custom Values")]
  [SerializeField]
  private CardUpgradeData charmData;
  [SerializeField]
  private Transform charmBlockHolder;
  [SerializeField]
  private GainCharmSequence gainCharmSequence;
  [SerializeField]
  private Character character;
  [SerializeField]
  private UnityEngine.Animator animator;
  [SerializeField]
  private float animationDuration = 2f;
  [SerializeField]
  private ParticleSystem buildupParticleSystem;
  [SerializeField]
  private ParticleSystem explodeParticleSystem;

  public void SetCharm(CardUpgradeData charmData, Transform charmBlock)
  {
    this.charmData = charmData;
    this.charmBlockHolder.SetPositionAndRotation(charmBlock.position, charmBlock.rotation);
  }

  public void SetCharacter(Character character) => this.character = character;

  public override IEnumerator Run()
  {
    OpenCharmBlockSequence charmBlockSequence = this;
    yield return (object) Sequences.Wait(charmBlockSequence.startDelay);
    charmBlockSequence.gameObject.SetActive(true);
    charmBlockSequence.gainCharmSequence.SetCharm(charmBlockSequence.charmData);
    charmBlockSequence.gainCharmSequence.SetCharacter(charmBlockSequence.character);
    charmBlockSequence.animator.SetBool("BackgroundFade", true);
    Events.InvokeScreenRumble(0.1f, 0.0f, 0.0f, 0.1f, 0.0f, 0.0f);
    LeanTween.moveLocal(charmBlockSequence.charmBlockHolder.gameObject, Vector3.zero, 1f).setEase(LeanTweenType.easeOutBack);
    LeanTween.rotateLocal(charmBlockSequence.charmBlockHolder.gameObject, Vector3.zero, 1.5f).setEase(LeanTweenType.easeOutElastic);
    yield return (object) Sequences.Wait(0.4f);
    charmBlockSequence.animator.SetTrigger("Open");
    SfxSystem.OneShot("event:/sfx/inventory/charm_claim");
    Events.InvokeScreenRumble(0.0f, 2f, 0.25f, 0.75f, 0.5f, 0.25f);
    yield return (object) Sequences.Wait(charmBlockSequence.animationDuration);
    Events.InvokeScreenShake(5f);
    Routine.Clump clump = new Routine.Clump();
    clump.Add(charmBlockSequence.gainCharmSequence.Run());
    clump.Add(charmBlockSequence.FadeOutBackground(0.25f));
    yield return (object) clump.WaitForEnd();
    charmBlockSequence.gameObject.SetActive(false);
  }

  private IEnumerator FadeOutBackground(float delay = 0.0f)
  {
    yield return (object) Sequences.Wait(delay);
    this.animator.SetBool("BackgroundFade", false);
    yield return (object) Sequences.Wait(0.5f);
  }

  public void PlayBuildUpParticleSystem() => this.buildupParticleSystem.Play();

  public void PlayExplodeParticleSystem() => this.explodeParticleSystem.Play();
}
