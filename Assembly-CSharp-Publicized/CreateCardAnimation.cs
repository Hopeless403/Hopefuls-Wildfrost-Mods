// Decompiled with JetBrains decompiler
// Type: CreateCardAnimation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

  public IEnumerator DestroyOnEnd(ParticleSystem ps)
  {
    CreateCardAnimation createCardAnimation = this;
    yield return (object) new WaitUntil((Func<bool>) (() => !(bool) (UnityEngine.Object) this || !(bool) (UnityEngine.Object) ps || !ps.isPlaying));
    if ((bool) (UnityEngine.Object) createCardAnimation && (bool) (UnityEngine.Object) createCardAnimation.gameObject)
      createCardAnimation.gameObject.Destroy();
  }

  public static IEnumerator GainEffects(
    Entity entity,
    IEnumerable<CardData.StatusEffectStacks> withEffects)
  {
    Routine.Clump clump = new Routine.Clump();
    foreach (CardData.StatusEffectStacks withEffect in withEffects)
      clump.Add(StatusEffectSystem.Apply(entity, (Entity) null, withEffect.data, withEffect.count));
    yield return (object) clump.WaitForEnd();
  }
}
