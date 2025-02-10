// Decompiled with JetBrains decompiler
// Type: CardUpgradeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Localization;

[CreateAssetMenu(fileName = "CardUpgradeData", menuName = "Card Upgrade Data")]
public class CardUpgradeData : DataFile, ISaveable<CardUpgradeSaveData>
{
  public int tier;
  [SerializeField]
  public LocalizedString titleKey;
  [SerializeField]
  public LocalizedString textKey;
  [ShowAssetPreview(64, 64)]
  public Sprite image;
  public CardUpgradeData.Type type;
  public CardData.StatusEffectStacks[] attackEffects;
  public CardData.StatusEffectStacks[] effects;
  public CardData.TraitStacks[] giveTraits;
  public CardScript[] scripts;
  public bool becomesTargetedCard;
  public bool canBeRemoved;
  [Header("Constraints for applying this to a card")]
  [SerializeField]
  public TargetConstraint[] targetConstraints;
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
  public List<CardData.StatusEffectStacks> effectsAffected;
  public List<CardData.TraitStacks> traitsAffected;
  public List<CardData.StatusEffectStacks> attackEffectsApplied;
  public List<CardData.StatusEffectStacks> startWithEffectsApplied;
  public int damageChange;
  public int hpChange;
  public int counterChange;
  public int usesChange;

  public string title => this.titleKey.GetLocalizedString();

  public string text => this.textKey.GetLocalizedString();

  public void Assign(CardData cardData)
  {
    int damage = cardData.damage;
    int hp = cardData.hp;
    int counter = cardData.counter;
    int uses = cardData.uses;
    if (this.becomesTargetedCard)
    {
      cardData.hasAttack = true;
      if (cardData.playType == Card.PlayType.None)
        cardData.playType = Card.PlayType.Play;
      cardData.needsTarget = true;
    }
    cardData.damage = this.setDamage ? this.damage : cardData.damage + this.damage;
    cardData.hp = this.setHp ? this.hp : cardData.hp + this.hp;
    cardData.counter = this.setCounter ? this.counter : cardData.counter + this.counter;
    cardData.uses = this.setUses ? this.uses : cardData.uses + this.uses;
    cardData.damage = Mathf.Max(0, cardData.damage);
    cardData.hp = Mathf.Max(0, cardData.hp);
    cardData.counter = Mathf.Max(0, cardData.counter);
    cardData.uses = Mathf.Max(0, cardData.uses);
    this.damageChange = cardData.damage - damage;
    this.hpChange = cardData.hp - hp;
    this.counterChange = cardData.counter - counter;
    this.usesChange = cardData.uses - uses;
    foreach (CardScript script in this.scripts)
      script.Run(cardData);
    if (this.effectBonus != 0)
    {
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
    if (this.attackEffects.Length != 0)
    {
      this.attackEffectsApplied = new List<CardData.StatusEffectStacks>();
      List<CardData.StatusEffectStacks> list = cardData.attackEffects.ToList<CardData.StatusEffectStacks>();
      for (int index = this.attackEffects.Length - 1; index >= 0; --index)
      {
        CardData.StatusEffectStacks e = this.attackEffects[index];
        if (list.Exists((Predicate<CardData.StatusEffectStacks>) (a => (UnityEngine.Object) a.data == (UnityEngine.Object) e.data)))
          list.Find((Predicate<CardData.StatusEffectStacks>) (a => (UnityEngine.Object) a.data == (UnityEngine.Object) e.data)).count += e.count;
        else
          list.Add(e);
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
        if (list.Exists((Predicate<CardData.StatusEffectStacks>) (a => (UnityEngine.Object) a.data == (UnityEngine.Object) e.data)))
          list.Find((Predicate<CardData.StatusEffectStacks>) (a => (UnityEngine.Object) a.data == (UnityEngine.Object) e.data)).count += e.count;
        else
          list.Add(e);
        this.startWithEffectsApplied.Add(e);
      }
      cardData.startWithEffects = list.ToArray();
    }
    foreach (CardData.TraitStacks giveTrait in this.giveTraits)
    {
      bool flag = false;
      foreach (CardData.TraitStacks trait in cardData.traits)
      {
        if (trait.data.Equals((object) giveTrait.data))
        {
          trait.count += giveTrait.count;
          flag = true;
          break;
        }
      }
      if (!flag)
        cardData.traits.Add(new CardData.TraitStacks()
        {
          data = giveTrait.data,
          count = giveTrait.count
        });
    }
    cardData.upgrades.Add(this);
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
    switch (this.type)
    {
      case CardUpgradeData.Type.Charm:
        int count = data.upgrades.FindAll((Predicate<CardUpgradeData>) (a => a.type == this.type)).Count;
        int charmSlots = data.charmSlots;
        if (data.customData != null)
          charmSlots += data.customData.Get<int>("extraCharmSlots", 0);
        int num = charmSlots;
        if (count >= num)
          return false;
        break;
      case CardUpgradeData.Type.Token:
        if (data.upgrades.FindAll((Predicate<CardUpgradeData>) (a => a.type == this.type)).Count >= data.tokenSlots)
          return false;
        break;
      case CardUpgradeData.Type.Crown:
        if (data.upgrades.FindAll((Predicate<CardUpgradeData>) (a => a.type == this.type)).Count >= data.crownSlots)
          return false;
        break;
    }
    return true;
  }

  public bool CanAssign(CardData cardData)
  {
    if (this.damage != 0 && !cardData.hasAttack || this.hp != 0 && !cardData.hasHealth || this.counter != 0 && cardData.counter <= 0)
      return false;
    foreach (CardData.TraitStacks traitStacks in ((IEnumerable<CardData.TraitStacks>) this.giveTraits).Where<CardData.TraitStacks>((Func<CardData.TraitStacks, bool>) (t => !t.data.keyword.canStack)))
    {
      CardData.TraitStacks t = traitStacks;
      if (cardData.traits.Any<CardData.TraitStacks>((Func<CardData.TraitStacks, bool>) (a => a.data.Equals((object) t.data))))
        return false;
    }
    foreach (TargetConstraint targetConstraint in this.targetConstraints)
    {
      if (!targetConstraint.Check(cardData))
        return false;
    }
    switch (this.type)
    {
      case CardUpgradeData.Type.Charm:
        if (cardData.upgrades.FindAll((Predicate<CardUpgradeData>) (a => a.type == this.type)).Count >= cardData.charmSlots)
          return false;
        break;
      case CardUpgradeData.Type.Token:
        if (cardData.upgrades.FindAll((Predicate<CardUpgradeData>) (a => a.type == this.type)).Count >= cardData.tokenSlots)
          return false;
        break;
      case CardUpgradeData.Type.Crown:
        if (cardData.upgrades.FindAll((Predicate<CardUpgradeData>) (a => a.type == this.type)).Count >= cardData.crownSlots)
          return false;
        break;
    }
    return true;
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

  [CompilerGenerated]
  public bool \u003CCanAssign\u003Eb__37_2(CardUpgradeData a) => a.type == this.type;

  [CompilerGenerated]
  public bool \u003CCanAssign\u003Eb__37_3(CardUpgradeData a) => a.type == this.type;

  [CompilerGenerated]
  public bool \u003CCanAssign\u003Eb__37_4(CardUpgradeData a) => a.type == this.type;

  [CompilerGenerated]
  public bool \u003CCanAssign\u003Eb__38_2(CardUpgradeData a) => a.type == this.type;

  [CompilerGenerated]
  public bool \u003CCanAssign\u003Eb__38_3(CardUpgradeData a) => a.type == this.type;

  [CompilerGenerated]
  public bool \u003CCanAssign\u003Eb__38_4(CardUpgradeData a) => a.type == this.type;

  public enum Type
  {
    None,
    Charm,
    Token,
    Crown,
  }
}
