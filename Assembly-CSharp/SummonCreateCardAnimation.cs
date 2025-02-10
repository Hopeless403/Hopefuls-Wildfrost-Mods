// Decompiled with JetBrains decompiler
// Type: SummonCreateCardAnimation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonCreateCardAnimation : CreateCardAnimation
{
  [SerializeField]
  private ParticleSystem inParticleSystem;
  [SerializeField]
  private ParticleSystem outParticleSystem;
  [SerializeField]
  private float chargeDelay = 0.54f;

  public override IEnumerator Run(Entity entity, params CardData.StatusEffectStacks[] withEffects)
  {
    SummonCreateCardAnimation createCardAnimation = this;
    Routine.Clump clump = new Routine.Clump();
    SfxSystem.OneShot("event:/sfx/card/summon");
    clump.Add(createCardAnimation.In());
    clump.Add(CreateCardAnimation.GainEffects(entity, (IEnumerable<CardData.StatusEffectStacks>) withEffects));
    yield return (object) clump.WaitForEnd();
    createCardAnimation.Out();
    yield return (object) new WaitForSeconds(createCardAnimation.chargeDelay);
    if (entity.display is Card display)
      LeanTween.alphaCanvas(display.canvasGroup, 1f, 0.1f);
    double num = (double) entity.curveAnimator.Ping();
    entity.wobbler.WobbleRandom();
    clump.Add(createCardAnimation.DestroyOnEnd(createCardAnimation.outParticleSystem));
  }

  private IEnumerator In()
  {
    this.inParticleSystem.Play();
    yield return (object) new WaitForSeconds(this.inParticleSystem.main.duration);
  }

  private void Out()
  {
    this.inParticleSystem.gameObject.Destroy();
    this.outParticleSystem.Play();
  }
}
