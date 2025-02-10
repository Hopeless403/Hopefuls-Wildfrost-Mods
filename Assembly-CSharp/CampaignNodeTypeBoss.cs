// Decompiled with JetBrains decompiler
// Type: CampaignNodeTypeBoss
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "CampaignNodeTypeBoss", menuName = "Campaign/Node Type/Boss")]
public class CampaignNodeTypeBoss : CampaignNodeTypeBattle
{
  [SerializeField]
  private CampaignNodeTypeBoss.AreaProfile[] areaProfiles;

  public override IEnumerator SetUp(CampaignNode node)
  {
    this.GetRewards(node);
    yield break;
  }

  public void GetRewards(CampaignNode node)
  {
    CampaignNodeTypeBoss.AreaProfile profile = ((IEnumerable<CampaignNodeTypeBoss.AreaProfile>) this.areaProfiles).FirstOrDefault<CampaignNodeTypeBoss.AreaProfile>((Func<CampaignNodeTypeBoss.AreaProfile, bool>) (a => a.areaIndex == node.areaIndex));
    if (profile == null)
      return;
    List<BossRewardData.Data> rewards = CampaignNodeTypeBoss.GetRewards(profile);
    CampaignNode campaignNode = node;
    if (campaignNode.data == null)
      campaignNode.data = new Dictionary<string, object>();
    node.data.Add("rewards", (object) new CampaignNodeTypeBoss.RewardData()
    {
      rewards = rewards,
      canTake = profile.canTake
    });
  }

  private static List<BossRewardData.Data> GetRewards(CampaignNodeTypeBoss.AreaProfile profile)
  {
    List<BossRewardData.Data> rewards = new List<BossRewardData.Data>();
    UnityEngine.Random.InitState(Campaign.FindCharacterNode(References.Player).seed);
    foreach (BossRewardData bossRewardData in (IEnumerable<BossRewardData>) ((IEnumerable<BossRewardData>) profile.pool.bossRewards).InRandomOrder<BossRewardData>())
    {
      BossRewardData.Data data = bossRewardData.Pull();
      rewards.Add(data);
    }
    return rewards;
  }

  [Serializable]
  public class AreaProfile
  {
    public int areaIndex;
    public int canTake = 2;
    public BossRewardPool pool;
  }

  [Serializable]
  public class RewardData
  {
    public List<BossRewardData.Data> rewards;
    public int canTake;
  }
}
