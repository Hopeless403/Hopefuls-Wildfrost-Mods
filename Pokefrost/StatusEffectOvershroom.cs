// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectOvershroom
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Pokefrost
{
  public class StatusEffectOvershroom : StatusEffectData
  {
    [SerializeField]
    public CardAnimation buildupAnimation;
    public bool overloading;
    public bool subbed;
    public bool primed;
    public StatusEffectData dummy1;
    public StatusEffectData dummy2;
    public StatusEffectData dummy3;
    private string[] types = new string[2]
    {
      "Shroom",
      "Overload"
    };

    public override void Init()
    {
      this.OnStack += new StatusEffectData.EffectStackEventHandler(this.Stack);
      global::Events.OnEntityDisplayUpdated += new UnityAction<Entity>(this.EntityDisplayUpdated);
      this.OnTurnEnd += new StatusEffectData.EffectEntityEventHandler(this.DealDamage);
      global::Events.OnPostProcessUnits += new UnityAction<Character>(this.Prime);
      this.subbed = true;
    }

    public void OnDestroy()
    {
      global::Events.OnEntityDisplayUpdated -= new UnityAction<Entity>(this.EntityDisplayUpdated);
      this.Unsub();
    }

    public void EntityDisplayUpdated(Entity entity)
    {
      if (!((UnityEngine.Object) entity == (UnityEngine.Object) this.target) || !this.target.enabled)
        return;
      this.Check();
    }

    public IEnumerator Stack(int stacks)
    {
      bool flag = true;
      List<StatusEffectData> effectstoremove = new List<StatusEffectData>();
      foreach (StatusEffectData effect in this.target.statusEffects)
      {
        if (this.types.Contains<string>(effect.name) && effect.offensive)
        {
          this.count += effect.count;
          stacks += effect.count;
          effectstoremove.Add(effect);
        }
      }
      foreach (StatusEffectData effect in effectstoremove)
        yield return (object) effect.RemoveStacks(effect.count, false);
      Routine.Clump clump = new Routine.Clump();
      clump.Add(StatusEffectSystem.Apply(this.target, this.applier, this.dummy1, stacks, applyEvenIfZero: true));
      clump.Add(StatusEffectSystem.Apply(this.target, this.applier, this.dummy2, stacks, applyEvenIfZero: true));
      yield return (object) clump.WaitForEnd();
      int shroomDiff = 0;
      int overDiff = 0;
      StatusEffectData shroom = (StatusEffectData) null;
      StatusEffectData overload = (StatusEffectData) null;
      foreach (StatusEffectData effect in this.target.statusEffects)
      {
        if (!effect.offensive && effect.count != this.count)
        {
          if (effect.name == "Shroom")
            shroomDiff = effect.count - this.count;
          if (effect.name == "Overload")
            overDiff = effect.count - this.count;
        }
      }
      this.count = Math.Max(0, this.count + shroomDiff + overDiff);
      if ((bool) (UnityEngine.Object) shroom)
        shroom.count = this.count;
      if ((bool) (UnityEngine.Object) overload)
        overload.count = this.count;
      this.Check();
      yield return (object) null;
    }

    public void Check()
    {
      if (this.count < this.target.hp.current || this.overloading)
        return;
      ActionSequence action1 = new ActionSequence(this.DealDamage(this.count));
      action1.fixedPosition = true;
      action1.priority = this.eventPriority;
      action1.note = "Overload";
      ActionQueue.Stack((PlayAction) action1);
      ActionSequence action2 = new ActionSequence(this.Clear());
      action2.fixedPosition = true;
      action2.priority = this.eventPriority;
      action2.note = "Clear Overload";
      ActionQueue.Stack((PlayAction) action2);
      this.overloading = true;
    }

    public override bool RunApplyStatusEvent(StatusEffectApply apply)
    {
      int num;
      if (apply != null && (UnityEngine.Object) this.target == (UnityEngine.Object) apply?.target)
      {
        StatusEffectData effectData = apply.effectData;
        if ((effectData != null ? (effectData.offensive ? 1 : 0) : 0) != 0)
        {
          num = this.types.Contains<string>(apply?.effectData.name) ? 1 : 0;
          goto label_4;
        }
      }
      num = 0;
label_4:
      if (num != 0)
      {
        Debug.Log((object) "[Pokefrost] Changing to overshroom");
        apply.effectData = Pokefrost.Pokefrost.instance.Get<StatusEffectData>("Overshroom");
      }
      return false;
    }

    public IEnumerator DealDamage(int damage)
    {
      if ((bool) (UnityEngine.Object) this && (bool) (UnityEngine.Object) this.target && this.target.alive)
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
        if ((bool) (UnityEngine.Object) this.buildupAnimation)
          yield return (object) this.buildupAnimation.Routine((object) this.target);
        Entity damager = this.GetDamager();
        Routine.Clump clump = new Routine.Clump();
        foreach (Entity item in targets)
        {
          Hit hit = new Hit(damager, item, damage)
          {
            damageType = "overload"
          };
          clump.Add(hit.Process());
          hit = (Hit) null;
        }
        clump.Add(Sequences.Wait(0.5f));
        yield return (object) clump.WaitForEnd();
      }
    }

    public IEnumerator Clear()
    {
      if ((bool) (UnityEngine.Object) this && (bool) (UnityEngine.Object) this.target && this.target.alive)
      {
        Routine.Clump clump = new Routine.Clump();
        for (int i = this.target.statusEffects.Count - 1; i >= 0; --i)
        {
          if ((UnityEngine.Object) this.target.statusEffects[i] != (UnityEngine.Object) null && this.types.Contains<string>(this.target.statusEffects[i].name))
            clump.Add(this.target.statusEffects[i].Remove());
        }
        clump.Add(this.Remove());
        yield return (object) clump.WaitForEnd();
        this.overloading = false;
        clump = (Routine.Clump) null;
      }
    }

    public void Unsub()
    {
      if (!this.subbed)
        return;
      global::Events.OnPostProcessUnits -= new UnityAction<Character>(this.Prime);
      this.subbed = false;
    }

    public void Prime(Character character)
    {
      this.primed = true;
      this.Unsub();
    }

    public override bool RunTurnEndEvent(Entity entity)
    {
      return this.primed && this.target.enabled && (UnityEngine.Object) entity == (UnityEngine.Object) this.target;
    }

    public IEnumerator DealDamage(Entity entity)
    {
      int amount = 1;
      global::Events.InvokeStatusEffectCountDown((StatusEffectData) this, ref amount);
      if (amount != 0)
        yield return (object) this.CountDown(entity, amount);
      Hit hit = new Hit(this.GetDamager(), this.target, this.count + 1)
      {
        screenShake = 0.25f,
        damageType = "shroom"
      };
      yield return (object) hit.Process();
      yield return (object) Sequences.Wait(0.2f);
    }
  }
}
