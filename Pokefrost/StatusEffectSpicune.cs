// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectSpicune
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Events;

#nullable disable
namespace Pokefrost
{
  public class StatusEffectSpicune : StatusEffectData
  {
    public bool cardPlayed;
    public int current;
    public int amountToClear;

    public static event UnityAction<Entity, int> OnJuiceCleared;

    public override void Init()
    {
      this.OnCardPlayed += new StatusEffectData.EffectCardPlayEventHandler(this.CardPlayed);
    }

    public override bool RunStackEvent(int stacks)
    {
      this.current += stacks;
      this.target.effectBonus += stacks;
      return false;
    }

    public override bool RunCardPlayedEvent(Entity entity, Entity[] targets)
    {
      if (!((UnityEngine.Object) entity == (UnityEngine.Object) this.target) || this.count <= 0)
        return false;
      this.amountToClear = this.current;
      return !((IEnumerable<PlayAction>) ActionQueue.GetActions()).Any<PlayAction>((Func<PlayAction, bool>) (a => a is ActionTrigger actionTrigger && (UnityEngine.Object) actionTrigger.entity == (UnityEngine.Object) this.target));
    }

    public override bool RunActionPerformedEvent(PlayAction action)
    {
      return this.cardPlayed && ActionQueue.Empty;
    }

    public IEnumerator Clear(int amount)
    {
      int amount2 = amount;
      global::Events.InvokeStatusEffectCountDown((StatusEffectData) this, ref amount2);
      if (amount2 != 0)
      {
        this.current -= amount2;
        this.target.effectBonus -= amount2;
        yield return (object) this.CountDown(this.target, amount2);
        if (this.count == 0)
        {
          UnityAction<Entity, int> onJuiceCleared = StatusEffectSpicune.OnJuiceCleared;
          if (onJuiceCleared != null)
            onJuiceCleared(this.target, amount2);
        }
      }
    }

    public IEnumerator CardPlayed(Entity entity, Entity[] targets)
    {
      yield return (object) this.Clear(this.amountToClear);
    }

    public override bool RunEndEvent()
    {
      this.target.effectBonus -= this.current;
      return false;
    }
  }
}
