// Decompiled with JetBrains decompiler
// Type: JournalCardManagerPopulator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using Deadpan.Enums.Engine.Components.Modding;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class JournalCardManagerPopulator : MonoBehaviour
{
  [SerializeField]
  public JournalCardManagerPopulator.Category[] categories;
  [CompilerGenerated]
  public bool \u003Cpopulated\u003Ek__BackingField;
  public bool subbed;

  public bool populated
  {
    get => this.\u003Cpopulated\u003Ek__BackingField;
    set => this.\u003Cpopulated\u003Ek__BackingField = value;
  }

  public void OnEnable()
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

  public void ModToggled(WildfrostMod mod)
  {
    if (!this.populated)
      return;
    this.Clear();
  }

  public void Clear()
  {
    foreach (JournalCardManagerPopulator.Category category in this.categories)
      category.cardNames.Clear();
    this.populated = false;
  }

  public void Populate()
  {
    // ISSUE: variable of a compiler-generated type
    JournalCardManagerPopulator.\u003C\u003Ec__DisplayClass9_0 cDisplayClass90;
    // ISSUE: reference to a compiler-generated field
    cDisplayClass90.\u003C\u003E4__this = this;
    this.populated = true;
    StopWatch.Start();
    // ISSUE: reference to a compiler-generated field
    cDisplayClass90.usedCards = new List<string>();
    // ISSUE: reference to a compiler-generated field
    cDisplayClass90.playerCards = new List<string>();
    List<string> stringList = new List<string>();
    foreach (ClassData classData in References.Classes)
    {
      foreach (CardData cardData in classData.startingInventory.deck)
        this.\u003CPopulate\u003Eg__StoreAsPlayerCard\u007C9_1(cardData, ref cDisplayClass90);
      foreach (CardData cardData in classData.startingInventory.reserve)
        this.\u003CPopulate\u003Eg__StoreAsPlayerCard\u007C9_1(cardData, ref cDisplayClass90);
      foreach (RewardPool rewardPool in classData.rewardPools)
      {
        if (!stringList.Contains(rewardPool.name))
        {
          stringList.Add(rewardPool.name);
          foreach (DataFile dataFile in rewardPool.list)
          {
            if (dataFile is CardData cardData)
              this.\u003CPopulate\u003Eg__StoreAsPlayerCard\u007C9_1(cardData, ref cDisplayClass90);
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
          // ISSUE: reference to a compiler-generated field
          bool flag = name2 == "Friendly" || name2 == "Item" || cDisplayClass90.playerCards.Contains(cardData.name);
          this.\u003CPopulate\u003Eg__ProcessCard\u007C9_0(cardData, !flag, ref cDisplayClass90);
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
                this.\u003CPopulate\u003Eg__ProcessCard\u007C9_0(unit, true, ref cDisplayClass90);
            }
          }
        }
      }
    }
    Debug.Log((object) string.Format("Journal Card Manager Population Done! ({0}ms)", (object) StopWatch.Stop()));
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

  [CompilerGenerated]
  public void \u003CPopulate\u003Eg__ProcessCard\u007C9_0(
    CardData cardData,
    bool enemy,
    [In] ref JournalCardManagerPopulator.\u003C\u003Ec__DisplayClass9_0 obj2)
  {
    // ISSUE: reference to a compiler-generated field
    if (obj2.usedCards.Contains(cardData.name))
      return;
    // ISSUE: reference to a compiler-generated field
    obj2.usedCards.Add(cardData.name);
    JournalCardManagerPopulator.Category[] categories = this.categories;
    int index = 0;
    while (index < categories.Length && !categories[index].CheckAdd(cardData, enemy))
      ++index;
  }

  [CompilerGenerated]
  public void \u003CPopulate\u003Eg__StoreAsPlayerCard\u007C9_1(
    CardData cardData,
    [In] ref JournalCardManagerPopulator.\u003C\u003Ec__DisplayClass9_0 obj1)
  {
    // ISSUE: reference to a compiler-generated field
    if (!(bool) (UnityEngine.Object) cardData || obj1.playerCards.Contains(cardData.name))
      return;
    // ISSUE: reference to a compiler-generated field
    obj1.playerCards.Add(cardData.name);
    foreach (string createdByThi in CreatedByLookup.GetCreatedByThis(cardData.name))
    {
      // ISSUE: reference to a compiler-generated field
      obj1.playerCards.Add(createdByThi);
    }
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
