// Decompiled with JetBrains decompiler
// Type: FlipCreateCardAnimation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
public class FlipCreateCardAnimation : CreateCardAnimation
{
  public static readonly Vector3 startPos = new Vector3(0.0f, -10f, 0.0f);

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
