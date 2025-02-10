// Decompiled with JetBrains decompiler
// Type: FlipCreateCardAnimation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipCreateCardAnimation : CreateCardAnimation
{
  private static readonly Vector3 startPos = new Vector3(0.0f, -10f, 0.0f);

  public override IEnumerator Run(Entity entity, params CardData.StatusEffectStacks[] withEffects)
  {
    FlipCreateCardAnimation createCardAnimation = this;
    entity.transform.localScale = Vector3.zero;
    entity.transform.position = FlipCreateCardAnimation.startPos;
    if (entity.display is Card display)
      display.canvasGroup.alpha = 1f;
    entity.flipper.FlipDownInstant();
    double num = (double) entity.curveAnimator.Ping();
    yield return (object) CreateCardAnimation.GainEffects(entity, (IEnumerable<CardData.StatusEffectStacks>) withEffects);
    entity.flipper.FlipUp();
    entity.wobbler.WobbleRandom();
    createCardAnimation.gameObject.Destroy();
  }
}
