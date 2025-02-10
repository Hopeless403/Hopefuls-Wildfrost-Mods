// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectRevive
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectRevive : StatusEffectData
  {
    public float healthFactor = 0.5f;
    public float damageFactor = 0.5f;

    public override void Init()
    {
      global::Events.OnEntityDisplayUpdated += new UnityAction<Entity>(this.EntityDisplayUpdated);
    }

    public void OnDestroy()
    {
      global::Events.OnEntityDisplayUpdated -= new UnityAction<Entity>(this.EntityDisplayUpdated);
    }

    public void EntityDisplayUpdated(Entity entity)
    {
      if ((UnityEngine.Object) entity == (UnityEngine.Object) this.target && this.target.hp.current <= 0 && !this.target.silenced)
      {
        this.target.PromptUpdate();
        ActionQueue.Stack((PlayAction) new ActionSequence(this.Animate()));
        this.target.damage.current = Mathf.CeilToInt((float) this.target.damage.max * this.damageFactor);
        this.target.hp.current = Mathf.CeilToInt((float) this.target.hp.max * this.healthFactor);
        this.CountDown();
        this.target.statusEffects.Remove((StatusEffectData) this);
        global::Events.OnEntityDisplayUpdated -= new UnityAction<Entity>(this.EntityDisplayUpdated);
        if (this.target.display is Card display)
          display.promptUpdateDescription = true;
        this.target.PromptUpdate();
      }
      else
      {
        if (!((UnityEngine.Object) entity == (UnityEngine.Object) this.target) || this.target.hp.current > 0)
          return;
        this.target.statusEffects.Remove((StatusEffectData) this);
        global::Events.OnEntityDisplayUpdated -= new UnityAction<Entity>(this.EntityDisplayUpdated);
        if (this.target.display is Card display)
          display.promptUpdateDescription = true;
        this.target.PromptUpdate();
      }
    }

    public void CountDown()
    {
      foreach (CardData cardData in References.PlayerData.inventory.deck)
      {
        if ((long) this.target.data.id == (long) cardData.id)
        {
          for (int index = 0; index < cardData.startWithEffects.Length; ++index)
          {
            CardData.StatusEffectStacks stack = cardData.startWithEffects[index];
            if (stack.data.name == this.name)
            {
              --stack.count;
              if (stack.count == 0)
                cardData.startWithEffects = ((IEnumerable<CardData.StatusEffectStacks>) cardData.startWithEffects).Where<CardData.StatusEffectStacks>((Func<CardData.StatusEffectStacks, bool>) (item => item != stack)).ToArray<CardData.StatusEffectStacks>();
            }
          }
        }
      }
    }

    public IEnumerator Animate()
    {
      ChangePhaseAnimationSystem animationSystem = UnityEngine.Object.FindObjectOfType<ChangePhaseAnimationSystem>();
      GameObject obj = new GameObject("focus");
      obj.transform.SetParent(animationSystem.container);
      obj.transform.position = this.target.transform.position;
      animationSystem.container = obj.transform;
      animationSystem?.Flash();
      yield return (object) animationSystem.Focus(this.target);
      yield return (object) Sequences.Wait(0.3f);
      ActionSequence action = new ActionSequence(animationSystem.UnFocus());
      action.note = "Unfocus boss";
      action.priority = 10;
      ActionQueue.Stack((PlayAction) action, true);
    }

    private IEnumerator blah()
    {
      this.target.containers[0].SetChildPosition(this.target);
      yield break;
    }

    public override bool RunBeginEvent()
    {
      this.target.display.promptUpdateDescription = true;
      this.target.PromptUpdate();
      return base.RunBeginEvent();
    }
  }
}
