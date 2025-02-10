// Decompiled with JetBrains decompiler
// Type: StatusEffectCrush
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Traits/Crush", fileName = "Crush")]
public class StatusEffectCrush : StatusEffectData
{
  protected override void Init()
  {
    this.OnCardPlayed += new StatusEffectData.EffectCardPlayEventHandler(this.Check);
  }

  private static CardContainer[] GetWasInRows(Entity entity, IEnumerable<Entity> targets)
  {
    if (entity.data.playType != Card.PlayType.Play || !entity.NeedsTarget)
      return entity.containers;
    HashSet<CardContainer> list = new HashSet<CardContainer>();
    foreach (Entity target in targets)
    {
      if (target.containers != null && target.containers.Length != 0)
        list.AddRange<CardContainer>((IEnumerable<CardContainer>) target.containers);
      else
        list.AddRange<CardContainer>((IEnumerable<CardContainer>) target.preContainers);
    }
    return list.ToArray<CardContainer>();
  }

  public override bool RunCardPlayedEvent(Entity entity, Entity[] targets)
  {
    return this.target.enabled && (UnityEngine.Object) entity == (UnityEngine.Object) this.target;
  }

  private IEnumerator Check(Entity entity, Entity[] targets)
  {
    StatusEffectCrush statusEffectCrush = this;
    int c = statusEffectCrush.GetAmount();
    for (int i = 0; i < c; ++i)
      yield return (object) statusEffectCrush.DestroyCard();
  }

  private IEnumerator DestroyCard()
  {
    StatusEffectCrush statusEffectCrush = this;
    // ISSUE: reference to a compiler-generated method
    Entity entity = References.Player.handContainer.InRandomOrder<Entity>().FirstOrDefault<Entity>(new Func<Entity, bool>(statusEffectCrush.\u003CDestroyCard\u003Eb__4_0));
    if (!(bool) (UnityEngine.Object) entity)
    {
      // ISSUE: reference to a compiler-generated method
      entity = References.Player.handContainer.InRandomOrder<Entity>().FirstOrDefault<Entity>(new Func<Entity, bool>(statusEffectCrush.\u003CDestroyCard\u003Eb__4_1));
    }
    if ((bool) (UnityEngine.Object) entity)
    {
      double num = (double) statusEffectCrush.target.curveAnimator.Ping();
      Routine.Clump clump = new Routine.Clump();
      clump.Add(entity.Kill());
      clump.Add(Sequences.Wait(0.5f));
      yield return (object) clump.WaitForEnd();
    }
  }
}
