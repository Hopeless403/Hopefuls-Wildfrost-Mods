// Decompiled with JetBrains decompiler
// Type: ScriptCurseCrowns
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Curse Crowns", menuName = "Scripts/Curse Crowns")]
public class ScriptCurseCrowns : Script
{
  [SerializeField]
  public int curseBossCrowns = 1;
  [SerializeField]
  public int curseShopCrowns = 1;
  [SerializeField]
  public int[] legalBossTiers = new int[1]{ 2 };
  [SerializeField]
  public int[] legalShopTiers = new int[4]{ 2, 3, 4, 5 };
  [SerializeField]
  public CardUpgradeData[] cursedCrowns;

  public override IEnumerator Run()
  {
    List<CardUpgradeData> pool = this.PopulatePool();
    int curseBossCrowns = this.curseBossCrowns;
    int curseShopCrowns = this.curseShopCrowns;
    foreach (CampaignNode node in (IEnumerable<CampaignNode>) References.Campaign.nodes.Where<CampaignNode>((Func<CampaignNode, bool>) (a => a.type.interactable && a.dataLinkedTo == -1 && a.tier >= 0 && a.data != null)).InRandomOrder<CampaignNode>())
    {
      if (node.type is CampaignNodeTypeBoss && this.TryCurseBossCrown(node, pool))
      {
        if (--curseBossCrowns <= 0 && curseShopCrowns <= 0)
          break;
      }
      else if (node.type is CampaignNodeTypeShop && this.TryCurseShopCrown(node, pool) && --curseShopCrowns <= 0 && curseBossCrowns <= 0)
        yield break;
    }
  }

  public bool TryCurseBossCrown(CampaignNode node, List<CardUpgradeData> pool)
  {
    if (!this.legalBossTiers.Contains<int>(node.tier))
      return false;
    CampaignNodeTypeBoss.RewardData rewardData = node.data.Get<CampaignNodeTypeBoss.RewardData>("rewards");
    if (rewardData != null)
    {
      foreach (BossRewardData.Data reward in rewardData.rewards)
      {
        CardUpgradeData upgradeData;
        if (reward.type == BossRewardData.Type.Crown && reward is BossRewardDataCrown.Data data && ScriptCurseCrowns.TryPullFromPool(pool, out upgradeData))
        {
          data.upgradeDataName = upgradeData.name;
          return true;
        }
      }
    }
    return false;
  }

  public bool TryCurseShopCrown(CampaignNode node, List<CardUpgradeData> pool)
  {
    if (!this.legalShopTiers.Contains<int>(node.tier))
      return false;
    ShopRoutine.Data data = node.data.Get<ShopRoutine.Data>("shopData");
    CardUpgradeData upgradeData;
    if (data == null || !ScriptCurseCrowns.TryPullFromPool(pool, out upgradeData))
      return false;
    data.crownType = upgradeData.name;
    return true;
  }

  public static bool TryPullFromPool(List<CardUpgradeData> pool, out CardUpgradeData upgradeData)
  {
    if (pool.Count > 0)
    {
      upgradeData = pool.TakeRandom<CardUpgradeData>();
      return true;
    }
    upgradeData = (CardUpgradeData) null;
    return false;
  }

  public List<CardUpgradeData> PopulatePool()
  {
    List<CardUpgradeData> cardUpgradeDataList = new List<CardUpgradeData>();
    cardUpgradeDataList.AddRange((IEnumerable<CardUpgradeData>) this.cursedCrowns);
    return cardUpgradeDataList;
  }
}
