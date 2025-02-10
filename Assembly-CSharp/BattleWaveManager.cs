// Decompiled with JetBrains decompiler
// Type: BattleWaveManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using UnityEngine;

public class BattleWaveManager : MonoBehaviour
{
  public List<BattleWaveManager.Wave> list;
  private Queue<Entity[]> remainingWaves;

  public void AddWave(BattleWaveManager.Wave wave)
  {
    if (this.list == null)
      this.list = new List<BattleWaveManager.Wave>();
    this.list.Add(wave);
    Debug.Log((object) string.Format("\"{0}\" Added", (object) wave));
  }

  public void AddEntities(Entity[] entities)
  {
    if (this.remainingWaves == null)
      this.remainingWaves = new Queue<Entity[]>();
    this.remainingWaves.Enqueue(entities);
  }

  public Entity[] Pull() => this.remainingWaves.Dequeue();

  public Entity[] Peek() => this.remainingWaves.Peek();

  [Serializable]
  public class Wave
  {
    public int counter;
    public List<CardData> units;
    public bool isBossWave;
    public bool spawned;

    public Wave()
    {
    }

    public Wave(BattleWaveManager.WaveData data)
    {
      this.counter = data.counter;
      this.units = new List<CardData>();
      int count = data.Count;
      for (int index = 0; index < count; ++index)
        this.units.Add(data.GetCardData(index));
      this.isBossWave = data.isBossWave;
    }

    public override string ToString() => string.Format("Wave ({0}) counter: {1}", (object) string.Join<CardData>(", ", (IEnumerable<CardData>) this.units), (object) this.counter);
  }

  [Serializable]
  public abstract class WaveData
  {
    public int counter;
    public bool isBossWave;

    public virtual int Count => 0;

    public abstract void AddCard(CardData card);

    public abstract void InsertCard(int index, CardData card);

    public abstract CardData GetCardData(int index);

    public abstract string GetCardName(int index);

    public abstract CardData PeekCardData(int index);

    public abstract bool AddUpgradeToCard(int index, CardUpgradeData upgradeData);
  }

  [Serializable]
  public class WaveDataBasic : BattleWaveManager.WaveData
  {
    public BattleWaveManager.Card[] cards;

    public override int Count => this.cards.Length;

    public override void AddCard(CardData card)
    {
      List<BattleWaveManager.Card> list = this.cards.ToList<BattleWaveManager.Card>();
      list.Add(new BattleWaveManager.Card(card.name));
      this.cards = list.ToArray();
    }

    public override void InsertCard(int index, CardData card)
    {
      List<BattleWaveManager.Card> list = this.cards.ToList<BattleWaveManager.Card>();
      list.Insert(index, new BattleWaveManager.Card(card.name));
      this.cards = list.ToArray();
    }

    public override CardData GetCardData(int index)
    {
      BattleWaveManager.Card card = this.cards[index];
      CardData cardData = AddressableLoader.Get<CardData>("CardData", card.cardName).Clone();
      if (card.upgradeNames != null)
      {
        foreach (string upgradeName in card.upgradeNames)
          AddressableLoader.Get<CardUpgradeData>("CardUpgradeData", upgradeName).Clone().Assign(cardData);
      }
      return cardData;
    }

    public override CardData PeekCardData(int index) => AddressableLoader.Get<CardData>("CardData", this.cards[index].cardName);

    public override string GetCardName(int index) => this.cards[index].cardName;

    public override bool AddUpgradeToCard(int index, CardUpgradeData upgradeData)
    {
      BattleWaveManager.Card card = this.cards[index];
      CardData cardData = AddressableLoader.Get<CardData>("CardData", card.cardName);
      if (!upgradeData.CanAssign(cardData))
        return false;
      card.AddUpgrade(upgradeData.name);
      return true;
    }

    public BattleWaveManager.Card Get(int index) => this.cards[index];

    public BattleWaveManager.WaveDataFull ConvertToFull()
    {
      BattleWaveManager.WaveDataFull full = new BattleWaveManager.WaveDataFull();
      List<CardSaveData> cardSaveDataList = new List<CardSaveData>();
      for (int index = 0; index < this.cards.Length; ++index)
        cardSaveDataList.Add(new CardSaveData(this.PeekCardData(index)));
      full.cardDatas = cardSaveDataList.ToArray();
      for (int index = 0; index < this.cards.Length; ++index)
      {
        BattleWaveManager.Card card = this.cards[index];
        CardSaveData cardData = full.cardDatas[index];
        List<CardUpgradeSaveData> cardUpgradeSaveDataList = new List<CardUpgradeSaveData>();
        foreach (string upgradeName in card.upgradeNames)
          cardUpgradeSaveDataList.Add(new CardUpgradeSaveData(upgradeName));
        cardData.upgrades = cardUpgradeSaveDataList.ToArray();
      }
      return full;
    }
  }

  [Serializable]
  public class WaveDataFull : BattleWaveManager.WaveData
  {
    public CardSaveData[] cardDatas;

    public override int Count => this.cardDatas.Length;

    public override void AddCard(CardData card)
    {
      List<CardSaveData> list = this.cardDatas.ToList<CardSaveData>();
      list.Add(new CardSaveData(card));
      this.cardDatas = list.ToArray();
    }

    public override void InsertCard(int index, CardData card)
    {
      List<CardSaveData> list = this.cardDatas.ToList<CardSaveData>();
      list.Insert(index, new CardSaveData(card));
      this.cardDatas = list.ToArray();
    }

    public override CardData GetCardData(int index) => this.cardDatas[index].Load(false);

    public override CardData PeekCardData(int index) => AddressableLoader.Get<CardData>("CardData", this.cardDatas[index].name);

    public override string GetCardName(int index) => this.cardDatas[index].name;

    public override bool AddUpgradeToCard(int index, CardUpgradeData upgradeData)
    {
      bool card = false;
      CardData cardData = this.cardDatas[index].Load(false);
      if (upgradeData.CanAssign(cardData))
      {
        upgradeData.Assign(cardData);
        this.cardDatas[index] = new CardSaveData(cardData);
        card = true;
      }
      return card;
    }
  }

  [Serializable]
  public class Card
  {
    public string cardName;
    public List<string> upgradeNames;

    public Card()
    {
    }

    public Card(string cardName) => this.cardName = cardName;

    public void AddUpgrade(string upgradeName)
    {
      if (this.upgradeNames == null)
        this.upgradeNames = new List<string>();
      this.upgradeNames.Add(upgradeName);
    }
  }
}
