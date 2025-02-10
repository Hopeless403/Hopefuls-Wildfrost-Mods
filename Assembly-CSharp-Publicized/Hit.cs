// Decompiled with JetBrains decompiler
// Type: Hit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Hit
{
  public Entity attacker;
  public readonly Character owner;
  public readonly Entity target;
  public string damageType = "basic";
  public Trigger trigger;
  public int damage;
  public int damageBlocked;
  [CompilerGenerated]
  public int \u003CdamageDealt\u003Ek__BackingField;
  public int counterReduction;
  public float screenShake = 1f;
  public bool countsAsHit = true;
  public bool canBeNullified = true;
  public bool nullified;
  public List<CardData.StatusEffectStacks> statusEffects;
  public bool doAnimation = true;
  public bool canRetaliate = true;
  public bool dodged;
  [CompilerGenerated]
  public bool \u003COffensive\u003Ek__BackingField;
  public int extraOffensiveness;

  public int damageDealt
  {
    get => this.\u003CdamageDealt\u003Ek__BackingField;
    set => this.\u003CdamageDealt\u003Ek__BackingField = value;
  }

  public bool Offensive
  {
    get => this.\u003COffensive\u003Ek__BackingField;
    set => this.\u003COffensive\u003Ek__BackingField = value;
  }

  public int GetOffensiveness()
  {
    int offensiveness = Mathf.Max(0, this.damage) + this.damageBlocked + this.extraOffensiveness;
    if (this.statusEffects != null)
    {
      foreach (CardData.StatusEffectStacks statusEffect in this.statusEffects)
      {
        if (statusEffect.data.offensive)
          offensiveness += statusEffect.count;
      }
    }
    return offensiveness;
  }

  public bool Supportive
  {
    get
    {
      if (this.damage < 0)
        return true;
      if (this.statusEffects != null)
      {
        foreach (CardData.StatusEffectStacks statusEffect in this.statusEffects)
        {
          if (!statusEffect.data.offensive)
            return true;
        }
      }
      return false;
    }
  }

  public int GetSupportiveness()
  {
    int supportiveness = Mathf.Max(0, -this.damage);
    if (this.statusEffects != null)
    {
      foreach (CardData.StatusEffectStacks statusEffect in this.statusEffects)
      {
        if (!statusEffect.data.offensive)
          supportiveness += statusEffect.count;
      }
    }
    return supportiveness;
  }

  public bool BasicHit => this.damageType == "basic";

  public Hit(Entity attacker, Entity target)
  {
    this.attacker = attacker;
    if ((bool) (Object) attacker)
    {
      this.owner = attacker.owner;
      this.damage = Mathf.Max(0, attacker.damage.current + attacker.tempDamage.Value);
      this.countsAsHit = attacker.data.hasAttack;
      if (this.countsAsHit)
        this.Offensive = attacker.IsOffensive();
    }
    this.target = target;
  }

  public Hit(Entity attacker, Entity target, int damage)
  {
    this.attacker = attacker;
    if ((bool) (Object) attacker)
      this.owner = attacker.owner;
    this.target = target;
    this.damage = damage;
    this.Offensive = damage > 0;
  }

  public void AddAttackerStatuses()
  {
    if (!(bool) (Object) this.attacker.data || this.attacker.attackEffects == null || this.attacker.silenced)
      return;
    foreach (CardData.StatusEffectStacks attackEffect in this.attacker.attackEffects)
    {
      int attackEffectAmount = this.CalculateAttackEffectAmount(attackEffect.count);
      if (attackEffectAmount > 0)
        this.AddStatusEffect(attackEffect.data, attackEffectAmount);
    }
  }

  public int CalculateAttackEffectAmount(int statusEffectStacks) => !this.attacker.silenced ? Mathf.Max(0, Mathf.RoundToInt((float) (statusEffectStacks + this.attacker.effectBonus) * this.attacker.effectFactor)) : 0;

  public void AddStatusEffect(CardData.StatusEffectStacks statusEffect)
  {
    if (this.statusEffects == null)
      this.statusEffects = new List<CardData.StatusEffectStacks>();
    this.statusEffects.Add(statusEffect);
    if (this.Offensive || !this.countsAsHit || !statusEffect.data.offensive)
      return;
    this.Offensive = true;
  }

  public void AddStatusEffect(StatusEffectData statusEffectData, int count) => this.AddStatusEffect(new CardData.StatusEffectStacks()
  {
    data = statusEffectData,
    count = count
  });

  public IEnumerator Process()
  {
    Hit hit = this;
    if ((bool) (Object) hit.target)
    {
      if (hit.countsAsHit)
        hit.target.lastHit = hit;
      if (hit.countsAsHit)
        yield return (object) StatusEffectSystem.HitEvent(hit);
      if (!hit.dodged)
      {
        Events.InvokeEntityHit(hit);
        if (!hit.nullified)
        {
          if (hit.damage != 0)
          {
            hit.damageDealt = hit.damage;
            int num = hit.target.hp.current - hit.damage;
            if (num > hit.target.hp.max)
            {
              hit.damageDealt += num - hit.target.hp.max;
              num = hit.target.hp.max;
            }
            hit.target.hp.current = num;
          }
          hit.target.counter.current = Mathf.Max(hit.target.counter.current - hit.counterReduction, 0);
        }
        Routine.Clump clump = new Routine.Clump();
        if (!hit.nullified)
        {
          List<CardData.StatusEffectStacks> statusEffects = hit.statusEffects;
          if (statusEffects != null && statusEffects.Count > 0)
          {
            foreach (CardData.StatusEffectStacks statusEffect in hit.statusEffects)
              clump.Add(StatusEffectSystem.Apply(hit.target, hit.attacker, statusEffect.data, statusEffect.count));
          }
        }
        hit.target.PromptUpdate();
        if (clump.Count > 0)
          yield return (object) clump.WaitForEnd();
      }
      else
        Events.InvokeEntityDodge(hit);
      Events.InvokeEntityPostHit(hit);
      if (hit.countsAsHit)
        yield return (object) StatusEffectSystem.PostHitEvent(hit);
      yield return (object) Sequences.Null();
    }
  }

  public void FlagAsOffensive() => this.Offensive = true;
}
