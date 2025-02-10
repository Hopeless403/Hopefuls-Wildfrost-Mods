// Decompiled with JetBrains decompiler
// Type: CampaignNodeTypeShop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "CampaignNodeTypeShop", menuName = "Campaign/Node Type/Shop")]
public class CampaignNodeTypeShop : CampaignNodeTypeEvent
{
  [SerializeField]
  public CampaignNodeTypeShop.Stock stock;
  [Header("Prices")]
  [SerializeField]
  [MinMaxSlider(0.0f, 2f)]
  public Vector2 priceFactorRange = new Vector2(0.8f, 1.2f);
  [SerializeField]
  public int discounts = 1;
  [SerializeField]
  public float discountFactor = 0.5f;
  [SerializeField]
  public int charmPrice = 50;
  [SerializeField]
  public int charmPriceAdd = 20;
  [SerializeField]
  public int crownPrice = 80;
  [SerializeField]
  public int crownPriceAdd = 30;
  [SerializeField]
  public int priceOffset = -5;

  public override IEnumerator SetUp(CampaignNode node)
  {
    yield return (object) null;
    CharacterRewards component = References.Player.GetComponent<CharacterRewards>();
    Dictionary<string, DataFile[]> dictionary = new Dictionary<string, DataFile[]>();
    dictionary["Companions"] = component.Pull<DataFile>((object) node, "Units", this.stock.companionCount);
    Predicate<DataFile> match1 = (Predicate<DataFile>) (a => a is CardData cardData1 && cardData1.cardType.name == "Item" && !cardData1.traits.Exists((Predicate<CardData.TraitStacks>) (b => b.data.name == "Consume")));
    dictionary["Items"] = component.Pull<DataFile>((object) node, "Items", this.stock.itemCount, false, match1);
    Predicate<DataFile> match2 = (Predicate<DataFile>) (a => a is CardData cardData2 && cardData2.cardType.name == "Item" && cardData2.traits.Exists((Predicate<CardData.TraitStacks>) (b => b.data.name == "Consume")));
    dictionary["Consumables"] = component.Pull<DataFile>((object) node, "Items", this.stock.consumableCount, false, match2);
    ShopRoutine.Data data = new ShopRoutine.Data()
    {
      charmPrice = this.charmPrice,
      charmPriceAdd = this.charmPriceAdd,
      crownPrice = this.crownPrice,
      crownPriceAdd = this.crownPriceAdd
    };
    foreach (KeyValuePair<string, DataFile[]> keyValuePair in dictionary)
    {
      string str;
      DataFile[] dataFileArray1;
      keyValuePair.Deconstruct(ref str, ref dataFileArray1);
      string category = str;
      DataFile[] dataFileArray2 = dataFileArray1;
      if (dataFileArray2 != null)
      {
        dataFileArray1 = dataFileArray2;
        for (int index = 0; index < dataFileArray1.Length; ++index)
        {
          if (dataFileArray1[index] is CardData cardData3)
          {
            ShopRoutine.Item obj = new ShopRoutine.Item(category, cardData3, this.priceOffset, this.priceFactorRange.Random());
            data.items.Add(obj);
          }
        }
      }
    }
    foreach (CardUpgradeData cardUpgradeData in component.Pull<CardUpgradeData>((object) node, "Charms", this.stock.charmCount))
      data.charms.Add(cardUpgradeData.name);
    List<ShopRoutine.Item> list = new List<ShopRoutine.Item>();
    foreach (ShopRoutine.Item obj in data.items)
    {
      if (obj.category == "Companions" && this.stock.companionsCanDiscount)
        list.Add(obj);
      else if (obj.category == "Items" && this.stock.itemsCanDiscount)
        list.Add(obj);
      else if (obj.category == "Consumables" && this.stock.consumablesCanDiscount)
        list.Add(obj);
    }
    for (int index1 = 0; index1 < this.discounts; ++index1)
    {
      if (list.Count > 0)
      {
        int index2 = list.RandomIndex<ShopRoutine.Item>();
        list[index2].priceFactor = this.discountFactor;
        list.RemoveAt(index2);
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

  public override IEnumerator Populate(CampaignNode node)
  {
    ShopRoutine objectOfType = UnityEngine.Object.FindObjectOfType<ShopRoutine>();
    objectOfType.node = node;
    yield return (object) objectOfType.Populate();
  }

  public override bool HasMissingData(CampaignNode node)
  {
    foreach (ShopRoutine.Item obj in node.data.Get<ShopRoutine.Data>("shopData").items)
    {
      if (MissingCardSystem.IsMissing(obj.cardDataName))
        return true;
    }
    return false;
  }

  [Serializable]
  public struct Stock
  {
    public AnimationCurve companions;
    public bool companionsCanDiscount;
    public AnimationCurve items;
    public bool itemsCanDiscount;
    public AnimationCurve consumables;
    public bool consumablesCanDiscount;
    public AnimationCurve charms;

    public int companionCount => Mathf.RoundToInt(this.companions.Evaluate(UnityEngine.Random.value));

    public int itemCount => Mathf.RoundToInt(this.items.Evaluate(UnityEngine.Random.value));

    public int consumableCount => Mathf.RoundToInt(this.consumables.Evaluate(UnityEngine.Random.value));

    public int charmCount => Mathf.RoundToInt(this.charms.Evaluate(UnityEngine.Random.value));
  }
}
