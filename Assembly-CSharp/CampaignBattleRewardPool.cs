// Decompiled with JetBrains decompiler
// Type: CampaignBattleRewardPool
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using UnityEngine;

public class CampaignBattleRewardPool : MonoBehaviour
{
  public CampaignBattleRewardPool.Pool[] pools;

  [Serializable]
  public struct Pool
  {
    public string name;
    public List<CampaignNodeType> nodeTypes;
    public RewardData[] rewards;
    private List<RewardData> pool;

    public RewardData Pull()
    {
      if (this.pool == null)
        this.pool = new List<RewardData>();
      if (this.pool.Count <= 0)
      {
        this.pool.AddRange((IEnumerable<RewardData>) this.rewards);
        this.pool.Shuffle<RewardData>();
      }
      if (this.pool.Count <= 0)
        throw new Exception("CampaignBattleRewardPool IS EMPTY! God Dammit!");
      RewardData rewardData = this.pool[0];
      this.pool.RemoveAt(0);
      return rewardData;
    }
  }
}
