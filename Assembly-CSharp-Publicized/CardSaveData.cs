// Decompiled with JetBrains decompiler
// Type: CardSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[Serializable]
public class CardSaveData : ILoadable<CardData>
{
  public ulong id;
  public string name;
  public string title;
  public int hp;
  public int damage;
  public int counter;
  public Vector3 random3;
  public CardUpgradeSaveData[] upgrades;
  public StatusEffectSaveData[] attackEffects;
  public StatusEffectSaveData[] startWithEffects;
  public TraitSaveData[] traits;
  public StatusEffectSaveData[] injuries;
  public Dictionary<string, object> customData;

  public CardSaveData()
  {
  }

  public CardSaveData(CardData cardData)
  {
    this.id = cardData.id;
    this.name = cardData.name;
    this.title = cardData.forceTitle;
    this.hp = cardData.hp;
    this.damage = cardData.damage;
    this.counter = cardData.counter;
    this.random3 = cardData.random3;
    this.upgrades = cardData.upgrades.SaveArray<CardUpgradeData, CardUpgradeSaveData>();
    this.attackEffects = cardData.attackEffects.SaveArray<CardData.StatusEffectStacks, StatusEffectSaveData>();
    this.startWithEffects = cardData.startWithEffects.SaveArray<CardData.StatusEffectStacks, StatusEffectSaveData>();
    this.traits = cardData.traits.SaveArray<CardData.TraitStacks, TraitSaveData>();
    this.injuries = cardData.injuries.SaveArray<CardData.StatusEffectStacks, StatusEffectSaveData>();
    this.customData = cardData.customData;
    if (!(bool) (UnityEngine.Object) cardData.original || !((UnityEngine.Object) cardData.cardType != (UnityEngine.Object) cardData.original.cardType))
      return;
    if (this.customData == null)
      this.customData = new Dictionary<string, object>();
    this.customData["OverrideCardType"] = (object) cardData.cardType.name;
  }

  public CardData Peek() => AddressableLoader.Get<CardData>("CardData", this.name);

  public CardData Load() => this.Load(true);

  public CardData Load(bool keepId)
  {
    CardData cardData1 = AddressableLoader.Get<CardData>("CardData", this.name);
    int num = !(bool) (UnityEngine.Object) cardData1 ? 1 : 0;
    CardData cardData2 = num != 0 ? (keepId ? MissingCardSystem.GetCloneWithId(this.name, this.random3, this.id) : MissingCardSystem.GetClone(this.name)) : (keepId ? cardData1.Clone(this.random3, this.id, false) : cardData1.Clone(this.random3, false));
    cardData2.customData = this.customData;
    cardData2.attackEffects = this.attackEffects.LoadArray<CardData.StatusEffectStacks, StatusEffectSaveData>();
    cardData2.startWithEffects = this.startWithEffects.LoadArray<CardData.StatusEffectStacks, StatusEffectSaveData>();
    cardData2.traits = this.traits.LoadList<CardData.TraitStacks, TraitSaveData>();
    cardData2.injuries = this.injuries.LoadList<CardData.StatusEffectStacks, StatusEffectSaveData>();
    if (num == 0)
      cardData2.forceTitle = this.title;
    cardData2.hp = this.hp;
    cardData2.damage = this.damage;
    cardData2.counter = this.counter;
    if (cardData2.customData != null && cardData2.customData.ContainsKey("OverrideCardType"))
      cardData2.cardType = AddressableLoader.Get<CardType>("CardType", cardData2.customData.Get<string>("OverrideCardType"));
    CardUpgradeSaveData[] upgrades = this.upgrades;
    if (upgrades != null && upgrades.Length > 0)
    {
      cardData2.upgrades = this.upgrades.LoadList<CardUpgradeData, CardUpgradeSaveData>();
      if (cardData2.upgrades.Any<CardUpgradeData>((Func<CardUpgradeData, bool>) (a => a.becomesTargetedCard)))
      {
        cardData2.hasAttack = true;
        if (cardData2.playType == Card.PlayType.None)
          cardData2.playType = Card.PlayType.Play;
        cardData2.needsTarget = true;
      }
    }
    return cardData2;
  }
}
