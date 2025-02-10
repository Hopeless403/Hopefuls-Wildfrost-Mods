// Decompiled with JetBrains decompiler
// Type: CampaignNodeTypeBoss
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "CampaignNodeTypeBoss", menuName = "Campaign/Node Type/Boss")]
public class CampaignNodeTypeBoss : CampaignNodeTypeBattle
{
  public static void GetRewards(CampaignNode node)
  {
    BossRewardPool pool = ((IEnumerable<BossRewardPool>) MonoBehaviourSingleton<References>.instance.bossRewardPools).FirstOrDefault<BossRewardPool>((Func<BossRewardPool, bool>) (a => a.areaIndex == node.areaIndex));
    if (!(bool) (UnityEngine.Object) pool)
      return;
    List<BossRewardData.Data> rewards = CampaignNodeTypeBoss.GetRewards(pool);
    CampaignNode campaignNode = node;
    if (campaignNode.data == null)
      campaignNode.data = new Dictionary<string, object>();
    node.data.Add("rewards", (object) new CampaignNodeTypeBoss.RewardData()
    {
      rewards = rewards,
      canTake = pool.canTake
    });
  }

  private static List<BossRewardData.Data> GetRewards(BossRewardPool pool)
  {
    List<BossRewardData.Data> rewards = new List<BossRewardData.Data>();
    UnityEngine.Random.InitState(Campaign.FindCharacterNode(References.Player).seed);
    foreach (BossRewardData bossRewardData in (IEnumerable<BossRewardData>) ((IEnumerable<BossRewardData>) pool.bossRewards).InRandomOrder<BossRewardData>())
    {
      BossRewardData.Data data = bossRewardData.Pull();
      rewards.Add(data);
    }
    return rewards;
  }

  [Serializable]
  public class RewardData
  {
    public List<BossRewardData.Data> rewards;
    public int canTake;
  }
}
