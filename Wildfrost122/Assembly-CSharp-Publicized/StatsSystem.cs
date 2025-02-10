// Decompiled with JetBrains decompiler
// Type: StatsSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using Dead;
using System;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class StatsSystem : GameSystem
{
  public static StatsSystem instance;
  [SerializeField]
  public CampaignStats stats;
  public int goldThisBattle;
  public int sacrificedThisBattle;
  public bool kingMokoExists;
  public bool campaignEnded;

  public static CampaignStats Get() => StatsSystem.instance.Stats;

  public static void Set(CampaignStats stats)
  {
    if (stats == null)
      stats = new CampaignStats();
    StatsSystem.instance.stats = stats;
  }

  public CampaignStats Stats => this.stats;

  public void OnEnable()
  {
    StatsSystem.instance = this;
    global::Events.OnCampaignEnd += new UnityAction<Campaign.Result, CampaignStats, PlayerData>(this.CampaignEnd);
    global::Events.OnCampaignSaved += new UnityAction(this.CampaignSaved);
    global::Events.OnEntityHit += new UnityAction<Hit>(this.EntityHit);
    global::Events.OnEntityPostHit += new UnityAction<Hit>(this.PostEntityHit);
    global::Events.OnStatusEffectApplied += new UnityAction<StatusEffectApply>(this.StatusApplied);
    global::Events.OnEntityKilled += new UnityAction<Entity, DeathType>(this.EntityKilled);
    global::Events.OnEntityOffered += new UnityAction<Entity>(this.EntityOffered);
    global::Events.OnEntityChosen += new UnityAction<Entity>(this.EntityChosen);
    global::Events.OnEntityFlee += new UnityAction<Entity>(this.EntityFlee);
    global::Events.OnDiscard += new UnityAction<Entity>(this.EntityDiscarded);
    global::Events.OnEntitySummoned += new UnityAction<Entity, Entity>(this.EntitySummoned);
    global::Events.OnEntityTriggered += new global::Events.UnityActionRef<Trigger>(this.EntityTriggered);
    global::Events.OnCardInjured += new UnityAction<CardData>(this.CardInjured);
    global::Events.OnBattleStart += new UnityAction(this.BattleStart);
    global::Events.OnBattleEnd += new UnityAction(this.BattleEnd);
    global::Events.OnDropGold += new UnityAction<int, string, Character, Vector3>(this.DropGold);
    global::Events.OnSpendGold += new UnityAction<int>(this.SpendGold);
    global::Events.OnShopItemPurchase += new UnityAction<ShopItem>(this.ShopItemPurchase);
    global::Events.OnShopItemHaggled += new UnityAction<ShopItem>(this.ShopItemHaggled);
    global::Events.OnKillCombo += new UnityAction<int>(this.KillCombo);
    global::Events.OnRedrawBellHit += new UnityAction<RedrawBellSystem>(this.RedrawBellHit);
    global::Events.OnWaveDeployerEarlyDeploy += new UnityAction(this.WaveDeployerEarlyDeploy);
    global::Events.OnBattleTurnStart += new UnityAction<int>(this.BattleTurnStart);
    global::Events.OnRename += new UnityAction<Entity, string>(this.Rename);
    global::Events.OnMuncherFeed += new UnityAction<Entity>(this.MuncherFeed);
    global::Events.OnUpgradeGained += new UnityAction<CardUpgradeData>(this.UpgradeGained);
    global::Events.OnUpgradeAssign += new UnityAction<Entity, CardUpgradeData>(this.UpgradeAssigned);
  }

  public void OnDisable()
  {
    global::Events.OnCampaignEnd -= new UnityAction<Campaign.Result, CampaignStats, PlayerData>(this.CampaignEnd);
    global::Events.OnCampaignSaved -= new UnityAction(this.CampaignSaved);
    global::Events.OnEntityHit -= new UnityAction<Hit>(this.EntityHit);
    global::Events.OnEntityPostHit -= new UnityAction<Hit>(this.PostEntityHit);
    global::Events.OnStatusEffectApplied -= new UnityAction<StatusEffectApply>(this.StatusApplied);
    global::Events.OnEntityKilled -= new UnityAction<Entity, DeathType>(this.EntityKilled);
    global::Events.OnEntityOffered -= new UnityAction<Entity>(this.EntityOffered);
    global::Events.OnEntityChosen -= new UnityAction<Entity>(this.EntityChosen);
    global::Events.OnEntityFlee -= new UnityAction<Entity>(this.EntityFlee);
    global::Events.OnDiscard -= new UnityAction<Entity>(this.EntityDiscarded);
    global::Events.OnEntitySummoned -= new UnityAction<Entity, Entity>(this.EntitySummoned);
    global::Events.OnEntityTriggered -= new global::Events.UnityActionRef<Trigger>(this.EntityTriggered);
    global::Events.OnCardInjured -= new UnityAction<CardData>(this.CardInjured);
    global::Events.OnBattleStart -= new UnityAction(this.BattleStart);
    global::Events.OnBattleEnd -= new UnityAction(this.BattleEnd);
    global::Events.OnDropGold -= new UnityAction<int, string, Character, Vector3>(this.DropGold);
    global::Events.OnSpendGold -= new UnityAction<int>(this.SpendGold);
    global::Events.OnShopItemPurchase -= new UnityAction<ShopItem>(this.ShopItemPurchase);
    global::Events.OnShopItemHaggled -= new UnityAction<ShopItem>(this.ShopItemHaggled);
    global::Events.OnKillCombo -= new UnityAction<int>(this.KillCombo);
    global::Events.OnRedrawBellHit -= new UnityAction<RedrawBellSystem>(this.RedrawBellHit);
    global::Events.OnWaveDeployerEarlyDeploy -= new UnityAction(this.WaveDeployerEarlyDeploy);
    global::Events.OnBattleTurnStart -= new UnityAction<int>(this.BattleTurnStart);
    global::Events.OnRename -= new UnityAction<Entity, string>(this.Rename);
    global::Events.OnMuncherFeed -= new UnityAction<Entity>(this.MuncherFeed);
    global::Events.OnUpgradeGained -= new UnityAction<CardUpgradeData>(this.UpgradeGained);
    global::Events.OnUpgradeAssign -= new UnityAction<Entity, CardUpgradeData>(this.UpgradeAssigned);
  }

  public void Update()
  {
    if (this.campaignEnded)
      return;
    this.stats.time += Time.deltaTime;
    if ((double) this.stats.time < 3600.0)
      return;
    ++this.stats.hours;
    this.stats.time -= 3600f;
  }

  public void CampaignEnd(Campaign.Result result, CampaignStats stats, PlayerData playerData)
  {
    this.campaignEnded = true;
  }

  public void CampaignSaved()
  {
    if (!Campaign.Data.GameMode.doSave)
      return;
    SaveSystem.SaveCampaignData<CampaignStats>(Campaign.Data.GameMode, "stats", this.stats);
  }

  public void EntityHit(Hit hit)
  {
    bool flag = (UnityEngine.Object) hit.target.owner == (UnityEngine.Object) References.Player;
    if (!hit.Offensive)
      return;
    if ((UnityEngine.Object) hit.owner == (UnityEngine.Object) References.Player)
    {
      if (hit.damage > 0)
      {
        this.Stats.Add("damageDealt", hit.damageType, hit.damage);
        this.Stats.Max("highestDamageDealt", hit.damageType, hit.damage);
        if (flag)
          this.Stats.Add("friendlyDamageDealt", hit.target.data.name, hit.damage);
      }
      this.Stats.Add("cardsHit", hit.target.data.name, 1);
    }
    if (!flag)
      return;
    this.Stats.Add("hitsTakenByCardType", hit.target.data.cardType.name, 1);
    if (hit.damage > 0)
      this.Stats.Add("damageTaken", hit.damageType, hit.damage);
    if (hit.damageBlocked <= 0)
      return;
    this.Stats.Add("damageBlocked", hit.damageType, hit.damageBlocked);
  }

  public void PostEntityHit(Hit hit)
  {
    if (hit.dodged || hit.damageDealt >= 0 || !((UnityEngine.Object) hit.target.owner == (UnityEngine.Object) References.Player) || !((UnityEngine.Object) hit.owner == (UnityEngine.Object) References.Player))
      return;
    this.Stats.Add("amountHealedTo", hit.target.data.name, -hit.damageDealt);
    if ((bool) (UnityEngine.Object) hit.attacker && (bool) (UnityEngine.Object) hit.attacker.data)
      this.Stats.Add("amountHealedFrom", hit.attacker.data.name, -hit.damageDealt);
    this.Stats.Max("highestHealth", hit.target.hp.current);
  }

  public void StatusApplied(StatusEffectApply apply)
  {
    if (!(bool) (UnityEngine.Object) apply.applier)
      return;
    string type1 = (bool) (UnityEngine.Object) apply.effectData ? apply.effectData.type : (string) null;
    if (type1.IsNullOrWhitespace() || !((UnityEngine.Object) apply.applier.owner == (UnityEngine.Object) References.Player))
      return;
    this.Stats.Add("statusesApplied", type1, apply.count);
    StatusEffectData status = apply.target.FindStatus(apply.effectData);
    if ((bool) (UnityEngine.Object) status)
      this.Stats.Max("highestStatusEffect", type1, status.count);
    string type2 = apply.effectData.type;
    if (!(type2 == "max health up") && !(type2 == "max health up only"))
      return;
    this.Stats.Max("highestHealth", apply.target.hp.current);
  }

  public void EntityKilled(Entity entity, DeathType deathType)
  {
    if ((UnityEngine.Object) entity.owner == (UnityEngine.Object) References.Player)
    {
      this.Stats.Add("friendliesDied", entity.data.name, 1);
      if (!DeathSystem.KilledByOwnTeam(entity))
        return;
      this.Stats.Add("friendliesSacrificed", entity.data.name, 1);
      ++this.sacrificedThisBattle;
      this.Stats.Max("highestSacrificesInBattle", this.sacrificedThisBattle);
    }
    else
    {
      this.Stats.Add("enemiesKilled", entity.data.name, 1);
      Hit lastHit = entity.lastHit;
      if (lastHit == null)
        return;
      Entity attacker = lastHit.attacker;
      if (attacker == null)
        return;
      Character owner = attacker.owner;
      if (owner == null)
        return;
      CardData data = attacker.data;
      if (data == null)
        return;
      if (entity.data.name == "FinalBoss")
        this.Stats.Add("finalBossKills", data.name, 1);
      if (!((UnityEngine.Object) owner == (UnityEngine.Object) References.Player))
        return;
      this.Stats.Add("kills", data.name, 1);
      this.Stats.Add("enemiesKilledByCardType", data.cardType.name, 1);
      this.Stats.Add("enemiesKilledDamageType", entity.lastHit.damageType, 1);
      if (entity.lastHit.trigger != null)
        this.Stats.Add("enemiesKilledTriggerType", entity.lastHit.trigger.type, 1);
      if (entity.data.cardType.name == "Boss")
        this.Stats.Add("bossesKilled", entity.data.name, 1);
      if (entity.data.cardType.miniboss)
        this.Stats.Add("minibossesKilledByCardType", data.cardType.name, 1);
      if (!(bool) (UnityEngine.Object) entity.statusEffects.Find((Predicate<StatusEffectData>) (a => a.type == "demonize")))
        return;
      this.Stats.Add("demonizedEnemiesKilled", data.name, 1);
    }
  }

  public void EntityOffered(Entity entity) => this.Stats.Add("cardsOffered", entity.data.name, 1);

  public void EntityChosen(Entity entity)
  {
    this.Stats.Add("cardsChosen", entity.data.name, 1);
    this.Stats.Add("cardTypesChosen", entity.data.cardType.name, 1);
  }

  public void EntityFlee(Entity entity)
  {
    if (!((UnityEngine.Object) entity.owner != (UnityEngine.Object) References.Player))
      return;
    this.Stats.Add("enemiesEscaped", entity.data.name, 1);
  }

  public void EntityDiscarded(Entity entity)
  {
    if (!((UnityEngine.Object) entity.owner == (UnityEngine.Object) References.Player))
      return;
    this.Stats.Add("friendliesRecalled", entity.data.name, 1);
  }

  public void EntitySummoned(Entity entity, Entity summonedBy)
  {
    if (!entity.data.cardType.unit)
      return;
    this.Stats.Add("cardsSummoned", entity.data.name, 1);
  }

  public void EntityTriggered(ref Trigger trigger)
  {
    if ((UnityEngine.Object) trigger.entity.owner == (UnityEngine.Object) References.Player && !trigger.type.IsNullOrWhitespace())
      this.Stats.Add("totalTriggers", trigger.type, 1);
    this.Stats.Add("cardsTriggered", trigger.entity.data.name, 1);
  }

  public void CardInjured(CardData cardData)
  {
    this.Stats.Add("friendliesInjured", cardData.name, 1);
  }

  public void BattleStart()
  {
    this.goldThisBattle = 0;
    this.sacrificedThisBattle = 0;
    this.kingMokoExists = (bool) (UnityEngine.Object) Battle.GetCards(References.Battle.enemy).FirstOrDefault<Entity>((Func<Entity, bool>) (a => a.data.cardType.miniboss && a.data.name == "MonkeyKing"));
  }

  public void BattleEnd()
  {
    string battleName = StatsSystem.GetBattleName();
    if ((UnityEngine.Object) References.Battle.winner == (UnityEngine.Object) References.Player)
    {
      this.Stats.Add("battlesWon", battleName, 1);
      if (Battle.GetCardsOnBoard(References.Battle.player).Count == 1)
        this.Stats.Add("winBattleWithOnlyLeaderRemaining", 1);
      if (this.kingMokoExists && this.Stats.Get("cardsTriggered", "MonkeyKing", 0) > 0)
        this.Stats.Add("winBattleSurviveKingMokoAttack", 1);
      if (References.Player.handContainer.Count == 0 && References.Player.discardContainer.Count == 0 && References.Player.drawContainer.Count == 0)
        this.Stats.Add("winBattleWithNoCardsInDeck", 1);
    }
    else
      this.Stats.Add("battlesLost", battleName, 1);
    this.Stats.Max("highestGoldFromBattle", battleName, this.goldThisBattle);
  }

  public void DropGold(int amount, string source, Character owner, Vector3 position)
  {
    this.Stats.Add("goldGained", source, amount);
    this.goldThisBattle += amount;
  }

  public void SpendGold(int amount) => this.Stats.Add("goldSpent", amount);

  public void ShopItemPurchase(ShopItem item)
  {
    if ((double) item.priceFactor < 1.0)
      this.Stats.Add("discountsBought", 1);
    string key = (string) null;
    if (item.GetComponent<CharmMachine>() != null || item.GetComponent<CardCharm>() != null)
      key = "charm";
    else if (item.GetComponent<CrownHolderShop>() != null)
      key = "crown";
    else if (item.GetComponent<Card>() != null)
      key = "card";
    int id = Campaign.FindCharacterNode(References.Player).id;
    if (this.Stats.Get("preShopId", -1) != id)
    {
      this.Stats.Set("preShopId", id);
      this.Stats.Delete("boughtInSingleShop");
      this.Stats.Set("boughtInSingleShop", key, 1);
    }
    else
      this.Stats.Add("boughtInSingleShop", key, 1);
    this.Stats.Add("shopItemsBought", key, 1);
  }

  public void ShopItemHaggled(ShopItem item) => this.Stats.Add("shopItemsHaggled", 1);

  public void KillCombo(int combo) => this.Stats.Max("highestKillCombo", combo);

  public void RedrawBellHit(RedrawBellSystem redrawBellSystem)
  {
    this.Stats.Add("redrawBellHits", 1);
  }

  public void WaveDeployerEarlyDeploy() => this.Stats.Add("enemyWaveBellHits", 1);

  public void BattleTurnStart(int turnCount) => this.Stats.Add("turnsTaken", 1);

  public void Rename(Entity entity, string newName)
  {
    this.Stats.Add("renames", newName, 1);
    this.Stats.Add("bestRename", newName, PettyRandom.Range(1, 1000));
  }

  public void MuncherFeed(Entity entity)
  {
    this.Stats.Add("cardsMunched", entity.data.name, 1);
    if (entity.data.traits == null)
      return;
    foreach (CardData.TraitStacks trait in entity.data.traits)
    {
      if (trait.data.name == "Consume")
        this.Stats.Add("consumeCardsMunched", 1);
    }
  }

  public void UpgradeGained(CardUpgradeData upgradeData)
  {
    switch (upgradeData.type)
    {
      case CardUpgradeData.Type.Charm:
        this.Stats.Add("charmsGained", upgradeData.name, 1);
        break;
      case CardUpgradeData.Type.Crown:
        this.Stats.Add("crownsGained", upgradeData.name, 1);
        break;
    }
  }

  public void UpgradeAssigned(Entity entity, CardUpgradeData upgradeData)
  {
    if (upgradeData.type != CardUpgradeData.Type.Charm)
      return;
    this.Stats.Add("charmsAssigned", upgradeData.name, 1);
    this.Stats.Add("charmsAssignedTo", entity.data.name, 1);
  }

  public static string GetBattleName()
  {
    object obj;
    return Campaign.FindCharacterNode(References.Player).data.TryGetValue("battle", out obj) && obj is string str ? str : (string) null;
  }
}
