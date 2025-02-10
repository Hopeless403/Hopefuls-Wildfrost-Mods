// Decompiled with JetBrains decompiler
// Type: CampaignNodeTypeClunkShop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "CampaignNodeTypeClunkShop", menuName = "Campaign/Node Type/Clunk Shop")]
public class CampaignNodeTypeClunkShop : CampaignNodeTypeEvent
{
  [Header("Stock")]
  [SerializeField]
  public int itemCount = 3;
  [SerializeField]
  public int charmCount = 3;
  [SerializeField]
  public CardUpgradeData[] charmPool;
  [Header("Prices")]
  [SerializeField]
  [MinMaxSlider(0.0f, 2f)]
  public Vector2 priceFactorRange = new Vector2(0.8f, 1.2f);
  [SerializeField]
  public int discounts = 1;
  [SerializeField]
  public float discountFactor = 0.5f;
  [SerializeField]
  public Vector2Int charmPriceRange = new Vector2Int(60, 80);

  public override IEnumerator SetUp(CampaignNode node)
  {
    yield return (object) null;
    CharacterRewards component = References.Player.GetComponent<CharacterRewards>();
    EventRoutineClunkShop.Data data = new EventRoutineClunkShop.Data();
    Predicate<DataFile> predicate = (Predicate<DataFile>) (a => a is CardData cardData1 && cardData1.cardType.name == "Clunker");
    CampaignNode pulledBy = node;
    int itemCount = this.itemCount;
    Predicate<DataFile> match = predicate;
    CardData[] cardDataArray = component.Pull<CardData>((object) pulledBy, "Items", itemCount, false, match);
    data.cards = new List<EventRoutineClunkShop.CardItem>();
    foreach (CardData cardData2 in cardDataArray)
      data.cards.Add(new EventRoutineClunkShop.CardItem(cardData2));
    List<CardUpgradeData> list1 = new List<CardUpgradeData>((IEnumerable<CardUpgradeData>) this.charmPool);
    list1.Shuffle<CardUpgradeData>();
    data.charms = new List<EventRoutineClunkShop.CharmItem>();
    for (int index = 0; index < this.charmCount; ++index)
    {
      CardUpgradeData cardUpgradeData = list1.Count > 0 ? list1[0] : (CardUpgradeData) null;
      if (!((UnityEngine.Object) cardUpgradeData == (UnityEngine.Object) null))
      {
        list1.RemoveAt(0);
        data.charms.Add(new EventRoutineClunkShop.CharmItem(cardUpgradeData.name, this.charmPriceRange.Random()));
      }
      else
        break;
    }
    if (this.discounts > 0)
    {
      List<EventRoutineClunkShop.Item> list2 = new List<EventRoutineClunkShop.Item>();
      list2.AddRange((IEnumerable<EventRoutineClunkShop.Item>) data.cards);
      list2.AddRange((IEnumerable<EventRoutineClunkShop.Item>) data.charms);
      list2.Shuffle<EventRoutineClunkShop.Item>();
      for (int index = 0; index < this.discounts; ++index)
      {
        EventRoutineClunkShop.Item obj = list2.Count > 0 ? list2[0] : (EventRoutineClunkShop.Item) null;
        if (obj != null)
        {
          list2.RemoveAt(0);
          obj.priceFactor = this.discountFactor;
        }
        else
          break;
      }
    }
    node.data = new Dictionary<string, object>()
    {
      {
        "shopData",
        (object) data
      }
    };
  }

  public override bool HasMissingData(CampaignNode node)
  {
    foreach (EventRoutineClunkShop.CardItem card in node.data.Get<EventRoutineClunkShop.Data>("shopData").cards)
    {
      if (MissingCardSystem.IsMissing(card.dataName))
        return true;
    }
    return false;
  }

  public override IEnumerator Populate(CampaignNode node)
  {
    EventRoutineClunkShop objectOfType = UnityEngine.Object.FindObjectOfType<EventRoutineClunkShop>();
    objectOfType.node = node;
    yield return (object) objectOfType.Populate();
  }
}
