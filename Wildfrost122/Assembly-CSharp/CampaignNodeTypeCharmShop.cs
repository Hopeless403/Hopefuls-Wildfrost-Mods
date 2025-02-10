// Decompiled with JetBrains decompiler
// Type: CampaignNodeTypeCharmShop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "CampaignNodeTypeCharmShop", menuName = "Campaign/Node Type/Charm Shop")]
public class CampaignNodeTypeCharmShop : CampaignNodeTypeEvent
{
  [SerializeField]
  private int cardChoices = 1;
  [SerializeField]
  private CampaignNodeTypeCharmShop.UpgradedCard[] forceCards;
  [SerializeField]
  private int choices = 3;
  [SerializeField]
  private CardUpgradeData[] force;
  [SerializeField]
  private Vector2Int priceRange = new Vector2Int(20, 80);
  [SerializeField]
  private int priceOffset = -5;

  public override IEnumerator SetUp(CampaignNode node)
  {
    yield return (object) null;
    CharacterRewards component = References.Player.GetComponent<CharacterRewards>();
    List<EventRoutineCharmShop.UpgradedCard> upgradedCardList = new List<EventRoutineCharmShop.UpgradedCard>();
    CampaignNodeTypeCharmShop.UpgradedCard[] forceCards = this.forceCards;
    if (forceCards != null && forceCards.Length > 0)
    {
      foreach (CampaignNodeTypeCharmShop.UpgradedCard forceCard in this.forceCards)
      {
        upgradedCardList.Add(new EventRoutineCharmShop.UpgradedCard()
        {
          cardDataName = forceCard.cardData.name,
          upgradeNames = ((IEnumerable<CardUpgradeData>) forceCard.upgrades).Select<CardUpgradeData, string>((Func<CardUpgradeData, string>) (a => a.name)).ToArray<string>(),
          price = forceCard.price,
          priceFactor = forceCard.priceFactor
        });
        component.PullOut("Items", (DataFile) forceCard.cardData);
      }
    }
    int num1 = this.cardChoices - upgradedCardList.Count;
    for (int index = 0; index < num1; ++index)
    {
      CardData card = component.Pull<CardData>((object) node, "Items");
      int itemCount = 1;
      if ((double) UnityEngine.Random.Range(0.0f, 1f) < 0.0099999997764825821)
        itemCount = 2;
      CardUpgradeData[] source = component.Pull<CardUpgradeData>((object) node, "Charms", itemCount, false, (Predicate<DataFile>) (a => a is CardUpgradeData cardUpgradeData && cardUpgradeData.CanAssign(card)));
      float f = (float) card.value * UnityEngine.Random.Range(0.8f, 1.2f) + (float) (source.Length * UnityEngine.Random.Range(10, 20)) + (float) this.priceOffset;
      EventRoutineCharmShop.UpgradedCard upgradedCard = new EventRoutineCharmShop.UpgradedCard()
      {
        cardDataName = card.name,
        price = Mathf.RoundToInt(f),
        priceFactor = 1f
      };
      if (source.Length != 0)
        upgradedCard.upgradeNames = ((IEnumerable<CardUpgradeData>) source).Select<CardUpgradeData, string>((Func<CardUpgradeData, string>) (a => a.name)).ToArray<string>();
      upgradedCardList.Add(upgradedCard);
    }
    List<EventRoutineCharmShop.CharmShopItemData> charmShopItemDataList = new List<EventRoutineCharmShop.CharmShopItemData>();
    CardUpgradeData[] force = this.force;
    if (force != null && force.Length > 0)
    {
      foreach (CardUpgradeData upgradeData in this.force)
        charmShopItemDataList.Add(new EventRoutineCharmShop.CharmShopItemData(upgradeData.name, this.GetPrice(upgradeData)));
      component.PullOut("Charms", (IEnumerable<DataFile>) this.force);
    }
    int num2 = this.choices - charmShopItemDataList.Count;
    for (int index = 0; index < num2; ++index)
    {
      CardUpgradeData upgradeData = component.Pull<CardUpgradeData>((object) node, "Charms");
      charmShopItemDataList.Add(new EventRoutineCharmShop.CharmShopItemData(upgradeData.name, this.GetPrice(upgradeData)));
    }
    node.data = new Dictionary<string, object>()
    {
      {
        "data",
        (object) new EventRoutineCharmShop.Data()
        {
          cards = upgradedCardList,
          items = charmShopItemDataList
        }
      }
    };
  }

  public override bool HasMissingData(CampaignNode node)
  {
    EventRoutineCharmShop.Data data = node.data.Get<EventRoutineCharmShop.Data>("data");
    foreach (EventRoutineCharmShop.UpgradedCard card in data.cards)
    {
      if (MissingCardSystem.IsMissing(card.cardDataName))
        return true;
    }
    foreach (EventRoutineCharmShop.CharmShopItemData charmShopItemData in data.items)
    {
      if ((UnityEngine.Object) AddressableLoader.Get<CardUpgradeData>("CardUpgradeData", charmShopItemData.upgradeDataName) == (UnityEngine.Object) null)
        return true;
    }
    return false;
  }

  private int GetPrice(CardUpgradeData upgradeData)
  {
    return this.priceRange.Random() + upgradeData.tier * 10 + this.priceOffset;
  }

  protected override IEnumerator Populate(CampaignNode node)
  {
    EventRoutineCharmShop objectOfType = UnityEngine.Object.FindObjectOfType<EventRoutineCharmShop>();
    objectOfType.node = node;
    yield return (object) objectOfType.Populate();
  }

  [Serializable]
  public class UpgradedCard
  {
    public CardData cardData;
    public CardUpgradeData[] upgrades;
    public int price;
    public float priceFactor;
  }
}
