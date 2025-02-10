// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectBurning
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectBurning : StatusEffectData
  {
    public CardAnimation buildupAnimation;
    public bool burning;

    public override void Init() => global::Events.OnEntityHit += new UnityAction<Hit>(this.EntityHit);

    public void OnDestroy() => global::Events.OnEntityHit -= new UnityAction<Hit>(this.EntityHit);

    public void EntityHit(Hit hit)
    {
      if (!((Object) hit.target == (Object) this.target) || !hit.Offensive || !hit.canRetaliate || !hit.countsAsHit)
        return;
      this.Check();
    }

    public void Check()
    {
      if (this.count <= 0 || this.burning)
        return;
      ActionSequence action1 = new ActionSequence(this.DealDamage());
      action1.fixedPosition = true;
      action1.priority = this.eventPriority;
      action1.note = "Burned";
      ActionQueue.Stack((PlayAction) action1);
      ActionSequence action2 = new ActionSequence(this.Clear());
      action2.fixedPosition = true;
      action2.priority = this.eventPriority;
      action2.note = "Clear Burns";
      ActionQueue.Stack((PlayAction) action2);
      this.burning = true;
    }

    public IEnumerator DealDamage()
    {
      if ((bool) (Object) this && (bool) (Object) this.target && this.target.alive)
      {
        HashSet<Entity> targets = new HashSet<Entity>();
        CardContainer[] cardContainerArray = this.target.containers;
        for (int index = 0; index < cardContainerArray.Length; ++index)
        {
          CardContainer collection = cardContainerArray[index];
          targets.AddRange<Entity>((IEnumerable<Entity>) collection);
          collection = (CardContainer) null;
        }
        cardContainerArray = (CardContainer[]) null;
        if ((bool) (Object) this.buildupAnimation)
          yield return (object) this.buildupAnimation.Routine((object) this.target);
        Entity damager = this.GetDamager();
        Routine.Clump clump = new Routine.Clump();
        foreach (Entity item in targets)
        {
          Hit hit = new Hit(damager, item, this.count)
          {
            damageType = "burning",
            canRetaliate = false
          };
          clump.Add(hit.Process());
          Pokefrost.Pokefrost.fx.TryPlayEffect("burntei", item.transform.position, item.transform.lossyScale);
          hit = (Hit) null;
        }
        SfxSystem.OneShot("event:/sfx/status/overburn_damage");
        clump.Add(Sequences.Wait(0.5f));
        yield return (object) clump.WaitForEnd();
      }
    }

    public IEnumerator Clear()
    {
      if ((bool) (Object) this && (bool) (Object) this.target && this.target.alive)
      {
        yield return (object) this.Remove();
        this.burning = false;
      }
    }
  }
}
