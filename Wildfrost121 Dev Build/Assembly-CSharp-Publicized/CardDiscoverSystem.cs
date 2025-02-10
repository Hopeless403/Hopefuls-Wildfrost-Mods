// Decompiled with JetBrains decompiler
// Type: CardDiscoverSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class CardDiscoverSystem : GameSystem
{
  public static CardDiscoverSystem instance;
  [SerializeField]
  public CardDiscoverSystem.PhaseChange[] phaseChanges;
  public List<string> discoveredCards;
  public List<string> discoveredCharms;

  public void OnEnable()
  {
    CardDiscoverSystem.instance = this;
    this.discoveredCards = SaveSystem.LoadProgressData<List<string>>("cardsDiscovered");
    if (this.discoveredCards == null)
      this.discoveredCards = new List<string>();
    this.discoveredCharms = SaveSystem.LoadProgressData<List<string>>("charmsDiscovered");
    if (this.discoveredCharms == null)
      this.discoveredCharms = new List<string>();
    global::Events.OnPreCampaignPopulate += new UnityAction(this.CampaignStart);
    global::Events.OnEntityKilled += new UnityAction<Entity, DeathType>(this.EntityKilled);
    global::Events.OnEntitySummoned += new UnityAction<Entity, Entity>(this.EntitySummoned);
    global::Events.OnEntityShowUnlocked += new UnityAction<Entity>(this.EntityShowUnlocked);
    global::Events.OnUpgradeGained += new UnityAction<CardUpgradeData>(this.UpgradeGained);
    global::Events.OnEntityEnterBackpack += new UnityAction<Entity>(this.EntityEnterBackpack);
  }

  public void OnDisable()
  {
    global::Events.OnPreCampaignPopulate -= new UnityAction(this.CampaignStart);
    global::Events.OnEntityKilled -= new UnityAction<Entity, DeathType>(this.EntityKilled);
    global::Events.OnEntitySummoned -= new UnityAction<Entity, Entity>(this.EntitySummoned);
    global::Events.OnEntityShowUnlocked -= new UnityAction<Entity>(this.EntityShowUnlocked);
    global::Events.OnUpgradeGained -= new UnityAction<CardUpgradeData>(this.UpgradeGained);
    global::Events.OnEntityEnterBackpack -= new UnityAction<Entity>(this.EntityEnterBackpack);
  }

  public void CampaignStart()
  {
    foreach (CardData cardData in References.PlayerData.inventory.deck)
    {
      this.DiscoverCard(cardData);
      foreach (UnityEngine.Object upgrade in cardData.upgrades)
        this.DiscoverCharm(upgrade.name);
    }
  }

  public void EntityKilled(Entity entity, DeathType deathType)
  {
    if (!(bool) (UnityEngine.Object) References.Battle || entity.owner.team != References.Battle.enemy.team)
      return;
    this.DiscoverCard(entity.data);
    this.DiscoverCard(((IEnumerable<CardDiscoverSystem.PhaseChange>) this.phaseChanges).FirstOrDefault<CardDiscoverSystem.PhaseChange>((Func<CardDiscoverSystem.PhaseChange, bool>) (a => a.phasedCardName == entity.data.name)).originalCardName);
  }

  public void EntitySummoned(Entity entity, Entity summonedBy) => this.DiscoverCard(entity.data);

  public void EntityShowUnlocked(Entity entity) => this.DiscoverCard(entity.data);

  public void UpgradeGained(CardUpgradeData upgradeData)
  {
    if (upgradeData.type != CardUpgradeData.Type.Charm)
      return;
    this.DiscoverCharm(upgradeData.name);
  }

  public void EntityEnterBackpack(Entity entity)
  {
    this.DiscoverCard(entity.data);
    foreach (CardUpgradeData upgrade in entity.data.upgrades)
    {
      if (upgrade.type == CardUpgradeData.Type.Charm)
        this.DiscoverCharm(upgrade.name);
    }
  }

  public void DiscoverCard(CardData cardData)
  {
    if (!cardData.cardType.discoverInJournal)
      return;
    this.DiscoverCard(cardData.name);
  }

  public void DiscoverCard(string cardDataName)
  {
    if (this.discoveredCards.Contains(cardDataName))
      return;
    this.discoveredCards.Add(cardDataName);
    SaveSystem.SaveProgressData<List<string>>("cardsDiscovered", this.discoveredCards);
  }

  public void DiscoverCharm(string charmName)
  {
    if (this.discoveredCharms.Contains(charmName))
      return;
    this.discoveredCharms.Add(charmName);
    SaveSystem.SaveProgressData<List<string>>("charmsDiscovered", this.discoveredCharms);
  }

  public static void CheckDiscoverCharm(string charmName)
  {
    CardDiscoverSystem.instance.DiscoverCharm(charmName);
  }

  [Serializable]
  public struct PhaseChange
  {
    public string phasedCardName;
    public string originalCardName;
  }
}
