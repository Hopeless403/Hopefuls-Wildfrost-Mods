// Decompiled with JetBrains decompiler
// Type: CardUpgradeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Localization;

#nullable disable
[CreateAssetMenu(fileName = "CardUpgradeData", menuName = "Card Upgrade Data")]
public class CardUpgradeData : DataFile, ISaveable<CardUpgradeSaveData>
{
  public int tier;
  [SerializeField]
  internal LocalizedString titleKey;
  [SerializeField]
  internal LocalizedString textKey;
  [ShowAssetPreview(64, 64)]
  public Sprite image;
  public CardUpgradeData.Type type;
  public CardData.StatusEffectStacks[] attackEffects;
  public CardData.StatusEffectStacks[] effects;
  public CardData.TraitStacks[] giveTraits;
  public CardScript[] scripts;
  public bool becomesTargetedCard;
  public bool canBeRemoved;
  public bool takeSlot = true;
  [Header("Constraints for applying this to a card")]
  [SerializeField]
  internal TargetConstraint[] targetConstraints;
  [Header("Stat Changes")]
  public int damage;
  public int hp;
  public int counter;
  public int uses;
  public int effectBonus;
  [Header("Set Exact Stats")]
  public bool setDamage;
  public bool setHp;
  public bool setCounter;
  public bool setUses;
  private List<CardData.StatusEffectStacks> effectsAffected;
  private List<CardData.TraitStacks> traitsAffected;
  private List<CardData.StatusEffectStacks> attackEffectsApplied;
  private List<CardData.StatusEffectStacks> startWithEffectsApplied;
  private int damageChange;
  private int hpChange;
  private int counterChange;
  private int usesChange;

  public string title => this.titleKey.GetLocalizedString();

  public string text => this.textKey.GetLocalizedString();

  public void Assign(CardData cardData)
  {
    int damage = cardData.damage;
    int hp = cardData.hp;
    int counter = cardData.counter;
    int uses = cardData.uses;
    this.AdjustStats(cardData);
    this.RunScripts(cardData);
    this.damageChange = cardData.damage - damage;
    this.hpChange = cardData.hp - hp;
    this.counterChange = cardData.counter - counter;
    this.usesChange = cardData.uses - uses;
    this.AdjustEffectBonus(cardData);
    this.GainEffects(cardData);
    cardData.upgrades.Add(this);
  }

  public void AdjustStats(CardData cardData)
  {
    if (this.becomesTargetedCard)
    {
      cardData.hasAttack = true;
      if (cardData.playType == Card.PlayType.None)
        cardData.playType = Card.PlayType.Play;
      cardData.needsTarget = true;
    }
    bool flag = cardData.counter > 0;
    cardData.damage = this.setDamage ? this.damage : cardData.damage + this.damage;
    cardData.hp = this.setHp ? this.hp : cardData.hp + this.hp;
    cardData.counter = this.setCounter ? this.counter : Mathf.Max(flag ? 1 : 0, cardData.counter + this.counter);
    cardData.uses = this.setUses ? this.uses : cardData.uses + this.uses;
    cardData.damage = Mathf.Max(0, cardData.damage);
    cardData.hp = Mathf.Max(0, cardData.hp);
    cardData.counter = Mathf.Max(0, cardData.counter);
    cardData.uses = Mathf.Max(0, cardData.uses);
  }

  public void RunScripts(CardData cardData)
  {
    foreach (CardScript script in this.scripts)
      script.Run(cardData);
  }

  public void AdjustEffectBonus(CardData cardData)
  {
    if (this.effectBonus == 0)
      return;
    this.effectsAffected = new List<CardData.StatusEffectStacks>();
    foreach (CardData.StatusEffectStacks attackEffect in cardData.attackEffects)
    {
      if (attackEffect.data.isStatus || attackEffect.data.stackable)
      {
        attackEffect.count = Mathf.Max(0, attackEffect.count + this.effectBonus);
        this.effectsAffected.Add(attackEffect);
      }
    }
    foreach (CardData.StatusEffectStacks startWithEffect in cardData.startWithEffects)
    {
      if (startWithEffect.data.canBeBoosted)
      {
        startWithEffect.count = Mathf.Max(0, startWithEffect.count + this.effectBonus);
        this.effectsAffected.Add(startWithEffect);
      }
    }
    this.traitsAffected = new List<CardData.TraitStacks>();
    foreach (CardData.TraitStacks trait in cardData.traits)
    {
      if (trait.data.keyword.canStack)
      {
        trait.count = Mathf.Max(0, trait.count + this.effectBonus);
        this.traitsAffected.Add(trait);
      }
    }
  }

  public void GainEffects(CardData cardData)
  {
    if (this.attackEffects.Length != 0)
    {
      this.attackEffectsApplied = new List<CardData.StatusEffectStacks>();
      List<CardData.StatusEffectStacks> list = cardData.attackEffects.ToList<CardData.StatusEffectStacks>();
      for (int index = this.attackEffects.Length - 1; index >= 0; --index)
      {
        CardData.StatusEffectStacks e = this.attackEffects[index];
        CardData.StatusEffectStacks statusEffectStacks = list.Find((Predicate<CardData.StatusEffectStacks>) (a => (UnityEngine.Object) a.data == (UnityEngine.Object) e.data));
        if (statusEffectStacks != null)
          statusEffectStacks.count += e.count;
        else
          list.Add(new CardData.StatusEffectStacks(e.data, e.count));
        this.attackEffectsApplied.Add(e);
      }
      cardData.attackEffects = list.ToArray();
    }
    if (this.effects.Length != 0)
    {
      this.startWithEffectsApplied = new List<CardData.StatusEffectStacks>();
      List<CardData.StatusEffectStacks> list = cardData.startWithEffects.ToList<CardData.StatusEffectStacks>();
      for (int index = this.effects.Length - 1; index >= 0; --index)
      {
        CardData.StatusEffectStacks e = this.effects[index];
        CardData.StatusEffectStacks statusEffectStacks = list.Find((Predicate<CardData.StatusEffectStacks>) (a => (UnityEngine.Object) a.data == (UnityEngine.Object) e.data));
        if (statusEffectStacks != null)
          statusEffectStacks.count += e.count;
        else
          list.Add(new CardData.StatusEffectStacks(e.data, e.count));
        this.startWithEffectsApplied.Add(e);
      }
      cardData.startWithEffects = list.ToArray();
    }
    CardData.TraitStacks.Stack(ref cardData.traits, (IEnumerable<CardData.TraitStacks>) this.giveTraits);
  }

  public IEnumerator Assign(Entity entity)
  {
    CardUpgradeData upgradeData = this;
    Events.InvokeUpgradeAssign(entity, upgradeData);
    upgradeData.Assign(entity.data);
    yield return (object) entity.ClearStatuses();
    if (entity.display is Card display)
      yield return (object) display.UpdateData(false);
  }

  public void UnAssign(CardData assignedTo)
  {
    assignedTo.damage -= this.damageChange;
    assignedTo.hp -= this.hpChange;
    assignedTo.counter -= this.counterChange;
    assignedTo.uses -= this.usesChange;
    if (this.effectBonus != 0)
    {
      foreach (CardData.StatusEffectStacks statusEffectStacks in this.effectsAffected)
        statusEffectStacks.count -= this.effectBonus;
      this.effectsAffected = (List<CardData.StatusEffectStacks>) null;
      foreach (CardData.TraitStacks traitStacks in this.traitsAffected)
        traitStacks.count -= this.effectBonus;
      this.traitsAffected = (List<CardData.TraitStacks>) null;
    }
    if (this.attackEffectsApplied != null && this.attackEffectsApplied.Count > 0)
    {
      List<CardData.StatusEffectStacks> list = assignedTo.attackEffects.ToList<CardData.StatusEffectStacks>();
      for (int index = this.attackEffectsApplied.Count - 1; index >= 0; --index)
      {
        CardData.StatusEffectStacks e = this.attackEffectsApplied[index];
        CardData.StatusEffectStacks statusEffectStacks = list.Find((Predicate<CardData.StatusEffectStacks>) (a => (UnityEngine.Object) a.data == (UnityEngine.Object) e.data));
        statusEffectStacks.count -= e.count;
        if (statusEffectStacks.count <= 0)
          list.Remove(e);
      }
    }
    if (this.startWithEffectsApplied != null && this.startWithEffectsApplied.Count > 0)
    {
      List<CardData.StatusEffectStacks> list = assignedTo.startWithEffects.ToList<CardData.StatusEffectStacks>();
      for (int index = this.startWithEffectsApplied.Count - 1; index >= 0; --index)
      {
        CardData.StatusEffectStacks e = this.startWithEffectsApplied[index];
        CardData.StatusEffectStacks statusEffectStacks = list.Find((Predicate<CardData.StatusEffectStacks>) (a => (UnityEngine.Object) a.data == (UnityEngine.Object) e.data));
        statusEffectStacks.count -= e.count;
        if (statusEffectStacks.count <= 0)
          list.Remove(e);
      }
      assignedTo.startWithEffects = list.ToArray();
      this.startWithEffectsApplied = (List<CardData.StatusEffectStacks>) null;
    }
    assignedTo.upgrades.Remove(this);
  }

  public bool CanAssign(Entity card)
  {
    CardData data = card.data;
    if (this.damage != 0 && !data.hasAttack || this.hp != 0 && !data.hasHealth || this.counter != 0 && data.counter <= 0)
      return false;
    foreach (CardData.TraitStacks traitStacks in ((IEnumerable<CardData.TraitStacks>) this.giveTraits).Where<CardData.TraitStacks>((Func<CardData.TraitStacks, bool>) (t => !t.data.keyword.canStack)))
    {
      CardData.TraitStacks t = traitStacks;
      if (data.traits.Any<CardData.TraitStacks>((Func<CardData.TraitStacks, bool>) (a => a.data.name == t.data.name)))
        return false;
    }
    foreach (TargetConstraint targetConstraint in this.targetConstraints)
    {
      if (!targetConstraint.Check(card))
        return false;
    }
    return this.CheckSlots(data);
  }

  public bool CanAssign(CardData cardData)
  {
    if (this.damage != 0 && !cardData.hasAttack || this.hp != 0 && !cardData.hasHealth || this.counter != 0 && cardData.counter <= 0)
      return false;
    foreach (CardData.TraitStacks traitStacks in ((IEnumerable<CardData.TraitStacks>) this.giveTraits).Where<CardData.TraitStacks>((Func<CardData.TraitStacks, bool>) (t => !t.data.keyword.canStack)))
    {
      CardData.TraitStacks t = traitStacks;
      if (cardData.traits.Any<CardData.TraitStacks>((Func<CardData.TraitStacks, bool>) (a => ((object) a.data).Equals((object) t.data))))
        return false;
    }
    foreach (TargetConstraint targetConstraint in this.targetConstraints)
    {
      if (!targetConstraint.Check(cardData))
        return false;
    }
    return this.CheckSlots(cardData);
  }

  public void Display(Entity entity)
  {
    if (this.type == CardUpgradeData.Type.None || !(entity.display is Card display))
      return;
    switch (this.type)
    {
      case CardUpgradeData.Type.Charm:
        if (!(bool) (UnityEngine.Object) display.charmHolder)
          break;
        display.charmHolder.Create(this);
        display.charmHolder.SetPositions();
        break;
      case CardUpgradeData.Type.Token:
        if (!(bool) (UnityEngine.Object) display.tokenHolder)
          break;
        display.tokenHolder.Create(this);
        display.tokenHolder.SetPositions();
        break;
      case CardUpgradeData.Type.Crown:
        if (!(bool) (UnityEngine.Object) display.crownHolder)
          break;
        display.crownHolder.Create(this);
        display.crownHolder.SetPositions();
        break;
    }
  }

  public CardUpgradeData Clone() => this.InstantiateKeepName<CardUpgradeData>();

  public CardUpgradeSaveData Save() => new CardUpgradeSaveData(this.name);

  private bool CheckSlots(CardData cardData)
  {
    if (!this.takeSlot)
      return true;
    switch (this.type)
    {
      case CardUpgradeData.Type.Charm:
        int count = cardData.upgrades.FindAll((Predicate<CardUpgradeData>) (a => a.type == this.type && a.takeSlot)).Count;
        int charmSlots = cardData.charmSlots;
        if (cardData.customData != null)
          charmSlots += cardData.customData.Get<int>("extraCharmSlots", 0);
        int num = charmSlots;
        if (count >= num)
          return false;
        break;
      case CardUpgradeData.Type.Token:
        if (cardData.upgrades.FindAll((Predicate<CardUpgradeData>) (a => a.type == this.type && a.takeSlot)).Count >= cardData.tokenSlots)
          return false;
        break;
      case CardUpgradeData.Type.Crown:
        if (cardData.upgrades.FindAll((Predicate<CardUpgradeData>) (a => a.type == this.type && a.takeSlot)).Count >= cardData.crownSlots)
          return false;
        break;
    }
    return true;
  }

  public enum Type
  {
    None,
    Charm,
    Token,
    Crown,
  }
}
