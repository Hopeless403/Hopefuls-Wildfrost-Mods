// Decompiled with JetBrains decompiler
// Type: InjurySystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class InjurySystem : GameSystem
{
  [SerializeField]
  private CardType[] typesThatCanBeInjured;
  [SerializeField]
  private StatusEffectData injuryEffect;
  [SerializeField]
  private List<CardData> injuredThisBattle;

  private void OnEnable()
  {
    global::Events.OnBattleStart += new UnityAction(this.BattleStart);
    global::Events.OnEntityKilled += new UnityAction<Entity, DeathType>(this.EntityKilled);
    global::Events.OnBattleSaved += new UnityAction(this.BattleSaved);
    global::Events.OnBattleLoaded += new UnityAction(this.BattleLoaded);
  }

  private void OnDisable()
  {
    global::Events.OnBattleStart -= new UnityAction(this.BattleStart);
    global::Events.OnEntityKilled -= new UnityAction<Entity, DeathType>(this.EntityKilled);
    global::Events.OnBattleSaved -= new UnityAction(this.BattleSaved);
    global::Events.OnBattleLoaded -= new UnityAction(this.BattleLoaded);
  }

  private void EntityKilled(Entity entity, DeathType deathType)
  {
    if (InjurySystem.IsPlayerCard(entity.data))
    {
      if (InjurySystem.AnyAliveClonesOfThisCard(entity.data))
        return;
      this.Injure(entity.data);
    }
    else
    {
      CardData originalCardData;
      if (!InjurySystem.IsCloneOfPlayerCard(entity.data, out originalCardData) || InjurySystem.IsCardAlive(originalCardData) || InjurySystem.AnyAliveClonesOfThisCard(originalCardData))
        return;
      this.Injure(originalCardData);
    }
  }

  private void BattleStart()
  {
    if (this.injuredThisBattle == null)
      this.injuredThisBattle = new List<CardData>();
    this.injuredThisBattle.Clear();
  }

  private void BattleSaved()
  {
    if (!Campaign.Data.GameMode.doSave)
      return;
    CardData[] injuriesThisBattle = InjurySystem.GetInjuriesThisBattle();
    if (injuriesThisBattle == null || injuriesThisBattle.Length <= 0)
      return;
    InjurySystem.SaveState saveState = new InjurySystem.SaveState(Campaign.FindCharacterNode(References.Player).id, (IEnumerable<CardData>) injuriesThisBattle);
    SaveSystem.SaveCampaignData<InjurySystem.SaveState>(Campaign.Data.GameMode, "battleInjuredThisBattle", saveState);
  }

  private void BattleLoaded()
  {
    InjurySystem.SaveState saveState = SaveSystem.LoadCampaignData<InjurySystem.SaveState>(Campaign.Data.GameMode, "battleInjuredThisBattle");
    if (saveState == null || Campaign.FindCharacterNode(References.Player).id != saveState.campaignNodeId || saveState.injuredThisBattleIds == null)
      return;
    this.injuredThisBattle = saveState.Load();
    foreach (CardData cardData1 in this.injuredThisBattle)
    {
      CardData cardData2 = cardData1;
      if (cardData2.injuries == null)
        cardData2.injuries = new List<CardData.StatusEffectStacks>();
      if (cardData1.injuries.Count <= 0)
        cardData1.injuries.Add(new CardData.StatusEffectStacks(this.injuryEffect, 1));
    }
  }

  private static bool IsPlayerCard(CardData cardData) => References.PlayerData.inventory.deck.Any<CardData>((Func<CardData, bool>) (a => (long) a.id == (long) cardData.id));

  private static bool IsCloneOfPlayerCard(CardData cardData, out CardData originalCardData)
  {
    ulong num;
    if (cardData.TryGetCustomData<ulong>("splitOriginalId", out num, 0UL))
    {
      foreach (CardData cardData1 in References.PlayerData.inventory.deck)
      {
        if ((long) cardData1.id == (long) num)
        {
          originalCardData = cardData1;
          return true;
        }
      }
    }
    originalCardData = (CardData) null;
    return false;
  }

  public void Injure(CardData cardData)
  {
    if (!this.CanInjure(cardData))
      return;
    CardData cardData1 = cardData;
    if (cardData1.injuries == null)
      cardData1.injuries = new List<CardData.StatusEffectStacks>();
    if (cardData.injuries.Count <= 0)
      cardData.injuries.Add(new CardData.StatusEffectStacks(this.injuryEffect, 1));
    if (this.injuredThisBattle == null)
      this.injuredThisBattle = new List<CardData>();
    this.injuredThisBattle.Add(cardData);
    global::Events.InvokeCardInjured(cardData);
  }

  public bool CanInjure(CardData cardData) => (bool) (UnityEngine.Object) cardData && this.CanInjure(cardData.cardType);

  public bool CanInjure(CardType cardType) => this.typesThatCanBeInjured.Contains<CardType>(cardType);

  public static CardData[] GetInjuriesThisBattle()
  {
    InjurySystem objectOfType = UnityEngine.Object.FindObjectOfType<InjurySystem>();
    return (bool) (UnityEngine.Object) objectOfType && objectOfType.injuredThisBattle != null ? objectOfType.injuredThisBattle.Where<CardData>(new Func<CardData, bool>(InjurySystem.IsPlayerCard)).ToArray<CardData>() : new CardData[0];
  }

  private static bool IsCardAlive(CardData cardData)
  {
    foreach (Entity card in References.Battle.cards)
    {
      if ((long) card.data.id == (long) cardData.id && card.IsAliveAndExists())
        return true;
    }
    return false;
  }

  private static bool AnyAliveClonesOfThisCard(CardData originalCardData)
  {
    bool flag = false;
    foreach (Entity card in References.Battle.cards)
    {
      object obj;
      if (card.data.customData != null && card.data.customData.TryGetValue("splitOriginalId", out obj) && obj is ulong num && (long) num == (long) originalCardData.id && card.IsAliveAndExists())
      {
        flag = true;
        break;
      }
    }
    return flag;
  }

  [Serializable]
  public class SaveState
  {
    public int campaignNodeId;
    public List<ulong> injuredThisBattleIds;

    public SaveState()
    {
    }

    public SaveState(int campaignNodeId, IEnumerable<CardData> injuredThisBattle)
    {
      this.campaignNodeId = campaignNodeId;
      this.injuredThisBattleIds = injuredThisBattle.Select<CardData, ulong>((Func<CardData, ulong>) (a => a.id)).ToList<ulong>();
    }

    public List<CardData> Load()
    {
      List<CardData> cardDataList = new List<CardData>();
      foreach (CardData cardData in References.PlayerData.inventory.deck)
      {
        int index = this.injuredThisBattleIds.IndexOf(cardData.id);
        if (index >= 0)
        {
          this.injuredThisBattleIds.RemoveAt(index);
          cardDataList.Add(cardData);
        }
      }
      return cardDataList;
    }
  }
}
