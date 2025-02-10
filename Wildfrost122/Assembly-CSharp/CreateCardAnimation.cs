// Decompiled with JetBrains decompiler
// Type: CreateCardAnimation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
public class CreateCardAnimation : MonoBehaviour
{
  public virtual IEnumerator Run(Entity entity, params CardData.StatusEffectStacks[] withEffects)
  {
    // ISSUE: reference to a compiler-generated field
    int num = this.\u003C\u003E1__state;
    CreateCardAnimation createCardAnimation = this;
    if (num != 0)
    {
      if (num != 1)
        return false;
      // ISSUE: reference to a compiler-generated field
      this.\u003C\u003E1__state = -1;
      createCardAnimation.gameObject.Destroy();
      return false;
    }
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = -1;
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E2__current = (object) CreateCardAnimation.GainEffects(entity, (IEnumerable<CardData.StatusEffectStacks>) withEffects);
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = 1;
    return true;
  }

  protected IEnumerator DestroyOnEnd(ParticleSystem ps)
  {
    CreateCardAnimation createCardAnimation = this;
    yield return (object) new WaitUntil((Func<bool>) (() => !(bool) (UnityEngine.Object) this || !(bool) (UnityEngine.Object) ps || !ps.isPlaying));
    if ((bool) (UnityEngine.Object) createCardAnimation && (bool) (UnityEngine.Object) createCardAnimation.gameObject)
      createCardAnimation.gameObject.Destroy();
  }

  protected static IEnumerator GainEffects(
    Entity entity,
    IEnumerable<CardData.StatusEffectStacks> withEffects)
  {
    Routine.Clump clump = new Routine.Clump();
    foreach (CardData.StatusEffectStacks withEffect in withEffects)
      clump.Add(StatusEffectSystem.Apply(entity, (Entity) null, withEffect.data, withEffect.count));
    yield return (object) clump.WaitForEnd();
  }
}
