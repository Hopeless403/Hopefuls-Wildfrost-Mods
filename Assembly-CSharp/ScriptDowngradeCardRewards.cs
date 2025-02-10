// Decompiled with JetBrains decompiler
// Type: ScriptDowngradeCardRewards
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "Downgrade Card Rewards", menuName = "Scripts/Downgrade Card Rewards")]
public class ScriptDowngradeCardRewards : Script
{
  [SerializeField]
  private CardUpgradeData[] charms;
  [SerializeField]
  private int downgradesPerTier = 2;
  [SerializeField]
  private ScriptDowngradeCardRewards.FixedCharmSet[] charmSets;

  public override IEnumerator Run()
  {
    List<CardUpgradeData> pool = this.PopulatePool();
    Dictionary<int, int> dictionary = new Dictionary<int, int>();
    for (int key = 0; key <= 8; ++key)
      dictionary[key] = this.downgradesPerTier;
    using (IEnumerator<CampaignNode> enumerator = References.Campaign.nodes.Where<CampaignNode>((Func<CampaignNode, bool>) (a => a.type.interactable && a.dataLinkedTo == -1 && a.tier >= 0 && a.data != null)).InRandomOrder<CampaignNode>().GetEnumerator())
    {
      while (enumerator.MoveNext())
      {
        CampaignNode current = enumerator.Current;
        if (dictionary[current.tier] > 0 && this.TryAddDowngrade(current, pool))
          --dictionary[current.tier];
      }
      yield break;
    }
  }

  private bool TryAddDowngrade(CampaignNode node, List<CardUpgradeData> pool)
  {
    bool flag = false;
    switch (node.type)
    {
      case CampaignNodeTypeItem _:
      case CampaignNodeTypeCompanion _:
      case CampaignNodeTypeCurseItems _:
        int appliedToIndex1;
        CardUpgradeData downgradeApplied1;
        if (this.TryAddDowngrade(node.data.GetSaveCollection<string>("cards"), pool, out appliedToIndex1, out downgradeApplied1))
        {
          flag = true;
          ScriptDowngradeCardRewards.AddUpgradeToCardInNodeData(node, appliedToIndex1, downgradeApplied1.name);
          break;
        }
        break;
      default:
        if (node.type is CampaignNodeTypeShop)
        {
          ShopRoutine.Data data = node.data.Get<ShopRoutine.Data>("shopData");
          int appliedToIndex2;
          CardUpgradeData downgradeApplied2;
          if (this.TryAddDowngrade(data.items.Select<ShopRoutine.Item, string>((Func<ShopRoutine.Item, string>) (a => a.cardDataName)).ToArray<string>(), pool, out appliedToIndex2, out downgradeApplied2))
          {
            flag = true;
            for (int index = 0; index <= appliedToIndex2; ++index)
            {
              if (data.upgrades.Count <= index)
              {
                string[] strArray1;
                if (index != appliedToIndex2)
                  strArray1 = (string[]) null;
                else
                  strArray1 = new string[1]
                  {
                    downgradeApplied2.name
                  };
                string[] strArray2 = strArray1;
                data.upgrades.Add(strArray2);
              }
              else if (index == appliedToIndex2)
              {
                string[] upgrade = data.upgrades[index];
                string[] strArray;
                if (upgrade == null)
                {
                  strArray = new string[1]
                  {
                    downgradeApplied2.name
                  };
                }
                else
                {
                  List<string> list = upgrade.ToList<string>();
                  list.Add(downgradeApplied2.name);
                  strArray = list.ToArray();
                }
                data.upgrades[index] = strArray;
              }
            }
            break;
          }
          break;
        }
        if (node.type is CampaignNodeTypeCharmShop)
        {
          EventRoutineCharmShop.Data data = node.data.Get<EventRoutineCharmShop.Data>("data");
          int appliedToIndex3;
          CardUpgradeData downgradeApplied3;
          if (this.TryAddDowngrade(data.cards.Select<EventRoutineCharmShop.UpgradedCard, string>((Func<EventRoutineCharmShop.UpgradedCard, string>) (a => a.cardDataName)).ToArray<string>(), pool, out appliedToIndex3, out downgradeApplied3))
          {
            flag = true;
            EventRoutineCharmShop.UpgradedCard card = data.cards[appliedToIndex3];
            List<string> stringList = card.upgradeNames == null ? new List<string>() : card.upgradeNames.ToList<string>();
            stringList.Add(downgradeApplied3.name);
            card.upgradeNames = stringList.ToArray();
            break;
          }
          break;
        }
        break;
    }
    return flag;
  }

  private static void AddUpgradeToCardInNodeData(
    CampaignNode node,
    int cardIndex,
    string upgradeName)
  {
    string key = string.Format("upgrades{0}", (object) cardIndex);
    if (node.data.ContainsKey(key))
      node.data.Get<SaveCollection<string>>(key).Add(upgradeName);
    else
      node.data[key] = (object) new SaveCollection<string>(upgradeName);
    if (node.linkedToThis == null)
      return;
    foreach (int linkedToThi in node.linkedToThis)
      ScriptDowngradeCardRewards.AddUpgradeToCardInNodeData(Campaign.GetNode(linkedToThi), cardIndex, upgradeName);
  }

  private bool TryAddDowngrade(
    string[] cardNames,
    List<CardUpgradeData> pool,
    out int appliedToIndex,
    out CardUpgradeData downgradeApplied)
  {
    appliedToIndex = -1;
    downgradeApplied = (CardUpgradeData) null;
    bool flag = false;
    foreach (int index in (IEnumerable<int>) ((IList<string>) cardNames).GetIndices<string>().InRandomOrder<int>())
    {
      CardData cardData = AddressableLoader.Get<CardData>("CardData", cardNames[index]);
      downgradeApplied = this.FindDowngrade(cardData, pool);
      if ((bool) (UnityEngine.Object) downgradeApplied)
      {
        pool.Remove(downgradeApplied);
        flag = true;
        appliedToIndex = index;
        break;
      }
    }
    return flag;
  }

  private CardUpgradeData FindDowngrade(CardData cardData, List<CardUpgradeData> pool)
  {
    foreach (ScriptDowngradeCardRewards.FixedCharmSet charmSet in this.charmSets)
    {
      if (charmSet.cards.Contains<string>(cardData.name))
        return charmSet.charmOptions.RandomItem<CardUpgradeData>();
    }
    for (int index = 0; index < pool.Count; ++index)
    {
      if (pool[index].CanAssign(cardData))
        return pool[index];
    }
    return (CardUpgradeData) null;
  }

  private List<CardUpgradeData> PopulatePool()
  {
    List<CardUpgradeData> cardUpgradeDataList = new List<CardUpgradeData>();
    cardUpgradeDataList.AddRange((IEnumerable<CardUpgradeData>) ((IEnumerable<CardUpgradeData>) this.charms).InRandomOrder<CardUpgradeData>());
    cardUpgradeDataList.AddRange((IEnumerable<CardUpgradeData>) ((IEnumerable<CardUpgradeData>) this.charms).InRandomOrder<CardUpgradeData>());
    return cardUpgradeDataList;
  }

  [Serializable]
  private struct FixedCharmSet
  {
    public string[] cards;
    public CardUpgradeData[] charmOptions;
  }
}
