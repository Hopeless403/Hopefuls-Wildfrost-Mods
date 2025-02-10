// Decompiled with JetBrains decompiler
// Type: StatusEffectCrush
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Traits/Crush", fileName = "Crush")]
public class StatusEffectCrush : StatusEffectData
{
  public override void Init() => this.OnCardPlayed += new StatusEffectData.EffectCardPlayEventHandler(this.Check);

  public static CardContainer[] GetWasInRows(Entity entity, IEnumerable<Entity> targets)
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

  public override bool RunCardPlayedEvent(Entity entity, Entity[] targets) => this.target.enabled && (UnityEngine.Object) entity == (UnityEngine.Object) this.target;

  public IEnumerator Check(Entity entity, Entity[] targets)
  {
    StatusEffectCrush statusEffectCrush = this;
    int c = statusEffectCrush.GetAmount();
    for (int i = 0; i < c; ++i)
      yield return (object) statusEffectCrush.DestroyCard();
  }

  public IEnumerator DestroyCard()
  {
    StatusEffectCrush statusEffectCrush = this;
    Entity entity = References.Player.handContainer.InRandomOrder<Entity>().FirstOrDefault<Entity>(new Func<Entity, bool>(statusEffectCrush.\u003CDestroyCard\u003Eb__4_0));
    if (!(bool) (UnityEngine.Object) entity)
      entity = References.Player.handContainer.InRandomOrder<Entity>().FirstOrDefault<Entity>(new Func<Entity, bool>(statusEffectCrush.\u003CDestroyCard\u003Eb__4_1));
    if ((bool) (UnityEngine.Object) entity)
    {
      double num = (double) statusEffectCrush.target.curveAnimator.Ping();
      Routine.Clump clump = new Routine.Clump();
      clump.Add(entity.Kill());
      clump.Add(Sequences.Wait(0.5f));
      yield return (object) clump.WaitForEnd();
    }
  }

  [CompilerGenerated]
  public bool \u003CDestroyCard\u003Eb__4_0(Entity a) => a.name == "Junk" && (UnityEngine.Object) a != (UnityEngine.Object) this.target;

  [CompilerGenerated]
  public bool \u003CDestroyCard\u003Eb__4_1(Entity a) => a.data.cardType.item && (UnityEngine.Object) a != (UnityEngine.Object) this.target;
}
