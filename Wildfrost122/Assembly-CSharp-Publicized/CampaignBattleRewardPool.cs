// Decompiled with JetBrains decompiler
// Type: CampaignBattleRewardPool
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
public class CampaignBattleRewardPool : MonoBehaviour
{
  public CampaignBattleRewardPool.Pool[] pools;

  [Serializable]
  public struct Pool
  {
    public string name;
    public List<CampaignNodeType> nodeTypes;
    public RewardData[] rewards;
    public List<RewardData> pool;

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
