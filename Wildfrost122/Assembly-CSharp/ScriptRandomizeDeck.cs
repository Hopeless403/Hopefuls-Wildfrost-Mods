// Decompiled with JetBrains decompiler
// Type: ScriptRandomizeDeck
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Randomize Deck", menuName = "Scripts/Randomize Deck")]
public class ScriptRandomizeDeck : Script
{
  [SerializeField]
  private Vector2Int cardsToRemove = new Vector2Int(0, 2);
  [SerializeField]
  private Vector2Int cardsToAdd = new Vector2Int(1, 4);
  [SerializeField]
  private Vector2Int charmsToAdd = new Vector2Int(1, 3);
  [SerializeField]
  [Range(0.0f, 1f)]
  private float addCharmChance = 0.25f;
  [SerializeField]
  [Range(0.0f, 1f)]
  private float replaceChance = 0.5f;

  public override IEnumerator Run()
  {
    List<CardData> cards;
    List<CardUpgradeData> charms;
    ScriptRandomizeDeck.GetPools(out cards, out charms);
    this.RemoveCards();
    this.AddCards(cards);
    if ((double) UnityEngine.Random.Range(0.0f, 1f) < (double) this.addCharmChance)
      this.AddCharms(charms);
    References.PlayerData.inventory.deck.Sort((Comparison<CardData>) ((a, b) => a.cardType.sortPriority.CompareTo(b.cardType.sortPriority)));
    yield break;
  }

  private static void GetPools(out List<CardData> cards, out List<CardUpgradeData> charms)
  {
    cards = new List<CardData>();
    charms = new List<CardUpgradeData>();
    foreach (RewardPool rewardPool in References.PlayerData.classData.rewardPools)
    {
      foreach (DataFile dataFile in rewardPool.list)
      {
        if (!(dataFile is CardData cardData))
        {
          if (dataFile is CardUpgradeData cardUpgradeData)
            charms.Add(cardUpgradeData);
        }
        else
          cards.Add(cardData);
      }
    }
  }

  private void RemoveCards()
  {
    int num = this.cardsToRemove.Random();
    for (int index1 = 0; index1 < num; ++index1)
    {
      int index2 = UnityEngine.Random.Range(1, References.PlayerData.inventory.deck.Count);
      References.PlayerData.inventory.deck.RemoveAt(index2);
    }
  }

  private void AddCards(List<CardData> cards)
  {
    int num = this.cardsToAdd.Random();
    List<CardData> added = new List<CardData>();
    for (int index = 0; index < num; ++index)
      this.AddCard(References.PlayerData.inventory.deck, cards.TakeRandom<CardData>().Clone(), added);
  }

  private void AddCard(CardDataList deck, CardData cardDataClone, List<CardData> added)
  {
    int num = (double) UnityEngine.Random.Range(0.0f, 1f) < (double) this.replaceChance ? 1 : 0;
    int index = UnityEngine.Random.Range(1, deck.Count);
    if (num != 0 && !added.Contains(deck[index]))
      deck.RemoveAt(index);
    deck.Insert(index, cardDataClone);
  }

  private void AddCharms(List<CardUpgradeData> charms)
  {
    int num = this.charmsToAdd.Random();
    for (int index = 0; index < num; ++index)
    {
      bool flag = false;
      while (!flag && charms.Count > 0)
        flag = ScriptRandomizeDeck.TryAddCharm(References.PlayerData.inventory.deck, charms.TakeRandom<CardUpgradeData>());
      if (charms.Count <= 0)
        break;
    }
  }

  private static bool TryAddCharm(CardDataList deck, CardUpgradeData upgradeData)
  {
    bool flag = false;
    foreach (CardData cardData in (IEnumerable<CardData>) deck.InRandomOrder<CardData>())
    {
      if (upgradeData.CanAssign(cardData))
      {
        upgradeData.Clone().Assign(cardData);
        flag = true;
        break;
      }
    }
    return flag;
  }
}
