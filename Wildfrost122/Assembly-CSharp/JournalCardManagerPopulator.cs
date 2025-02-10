// Decompiled with JetBrains decompiler
// Type: JournalCardManagerPopulator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using Deadpan.Enums.Engine.Components.Modding;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class JournalCardManagerPopulator : MonoBehaviour
{
  [SerializeField]
  private JournalCardManagerPopulator.Category[] categories;
  private bool subbed;

  public bool populated { get; private set; }

  private void OnEnable()
  {
    if (!this.subbed)
    {
      global::Events.OnModLoaded += new UnityAction<WildfrostMod>(this.ModToggled);
      global::Events.OnModUnloaded += new UnityAction<WildfrostMod>(this.ModToggled);
      this.subbed = true;
    }
    if (this.populated)
      return;
    this.Populate();
  }

  private void ModToggled(WildfrostMod mod)
  {
    if (!this.populated)
      return;
    this.Clear();
  }

  private void Clear()
  {
    foreach (JournalCardManagerPopulator.Category category in this.categories)
      category.cardNames.Clear();
    this.populated = false;
  }

  public void Populate()
  {
    this.populated = true;
    StopWatch.Start();
    List<string> usedCards = new List<string>();
    List<string> playerCards = new List<string>();
    List<string> stringList = new List<string>();
    foreach (ClassData classData in References.Classes)
    {
      foreach (CardData cardData in classData.startingInventory.deck)
        StoreAsPlayerCard(cardData);
      foreach (CardData cardData in classData.startingInventory.reserve)
        StoreAsPlayerCard(cardData);
      foreach (RewardPool rewardPool in classData.rewardPools)
      {
        if (!stringList.Contains(rewardPool.name))
        {
          stringList.Add(rewardPool.name);
          foreach (DataFile dataFile in rewardPool.list)
          {
            if (dataFile is CardData cardData)
              StoreAsPlayerCard(cardData);
          }
        }
      }
    }
    foreach (CardData cardData in AddressableLoader.GetGroup<CardData>("CardData"))
    {
      if (!((UnityEngine.Object) cardData.mainSprite == (UnityEngine.Object) null) && !(cardData.mainSprite.name == "Nothing"))
      {
        string name1 = cardData.cardType.name;
        if (!(name1 == "Boss") && !(name1 == "BossSmall") || !(cardData.name != "FinalBoss2"))
        {
          string name2 = cardData.cardType.name;
          bool flag = name2 == "Friendly" || name2 == "Item" || playerCards.Contains(cardData.name);
          ProcessCard(cardData, !flag);
        }
      }
    }
    foreach (BattleData battleData in AddressableLoader.GetGroup<BattleData>("BattleData"))
    {
      foreach (BattleWavePoolData pool in battleData.pools)
      {
        foreach (BattleWavePoolData.Wave wave in pool.waves)
        {
          foreach (CardData unit in wave.units)
          {
            if ((bool) (UnityEngine.Object) unit && unit.cardType.miniboss)
            {
              string name = unit.cardType.name;
              if (name == "Boss" || name == "BossSmall")
                ProcessCard(unit, true);
            }
          }
        }
      }
    }
    Debug.Log((object) string.Format("Journal Card Manager Population Done! ({0}ms)", (object) StopWatch.Stop()));

    void ProcessCard(CardData cardData, bool enemy)
    {
      if (usedCards.Contains(cardData.name))
        return;
      usedCards.Add(cardData.name);
      JournalCardManagerPopulator.Category[] categories = this.categories;
      int index = 0;
      while (index < categories.Length && !categories[index].CheckAdd(cardData, enemy))
        ++index;
    }

    void StoreAsPlayerCard(CardData cardData)
    {
      if (!(bool) (UnityEngine.Object) cardData || playerCards.Contains(cardData.name))
        return;
      playerCards.Add(cardData.name);
      foreach (string createdByThi in CreatedByLookup.GetCreatedByThis(cardData.name))
        playerCards.Add(createdByThi);
    }
  }

  public JournalCardManagerPopulator.Category GetCategory(string name)
  {
    foreach (JournalCardManagerPopulator.Category category in this.categories)
    {
      if (category.name == name)
        return category;
    }
    return (JournalCardManagerPopulator.Category) null;
  }

  [Serializable]
  public class Category
  {
    public string name;
    public bool enemy;
    public string[] cardTypes;
    public List<string> cardNames;

    public bool CheckAdd(CardData cardData, bool enemy)
    {
      if (this.enemy != enemy || !this.cardTypes.Contains<string>(cardData.cardType.name))
        return false;
      this.cardNames.Add(cardData.name);
      return true;
    }
  }
}
