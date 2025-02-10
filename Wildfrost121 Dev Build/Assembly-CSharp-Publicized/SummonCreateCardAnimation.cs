// Decompiled with JetBrains decompiler
// Type: SummonCreateCardAnimation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
public class SummonCreateCardAnimation : CreateCardAnimation
{
  [SerializeField]
  public ParticleSystem inParticleSystem;
  [SerializeField]
  public ParticleSystem outParticleSystem;
  [SerializeField]
  public float chargeDelay = 0.54f;

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

  public IEnumerator In()
  {
    this.inParticleSystem.Play();
    yield return (object) new WaitForSeconds(this.inParticleSystem.main.duration);
  }

  public void Out()
  {
    this.inParticleSystem.gameObject.Destroy();
    this.outParticleSystem.Play();
  }
}
