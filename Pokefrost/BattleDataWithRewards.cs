// Decompiled with JetBrains decompiler
// Type: Pokefrost.BattleDataWithRewards
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace Pokefrost
{
  public class BattleDataWithRewards : BattleData
  {
    public List<BossRewardData.Data>[] dataGroups;
    public int canTake = 2;
    public int bonusPulls = 0;
    public List<int> minPulls;
    public List<int> bonusProfile;

    public virtual void AddRewards(CampaignNode node)
    {
      List<BossRewardData.Data> dataList = new List<BossRewardData.Data>();
      List<int> profile = this.DetermineProfile();
      for (int index = 0; index < this.dataGroups.Length; ++index)
        dataList.AddRange(this.dataGroups[index].InRandomOrder<BossRewardData.Data>().Take<BossRewardData.Data>(profile[index]));
      node.data.Add("rewards", (object) new CampaignNodeTypeBoss.RewardData()
      {
        rewards = dataList,
        canTake = this.canTake
      });
    }

    public virtual List<int> DetermineProfile()
    {
      List<int> profile = this.minPulls != null ? this.minPulls.Clone<int>() : this.DefaultMinPulls();
      if (this.bonusPulls > 0 && this.bonusProfile != null)
      {
        int maxInclusive = 0;
        foreach (int num in this.bonusProfile)
          maxInclusive += num;
        int bonusPulls = this.bonusPulls;
        while (bonusPulls > 0)
        {
          int num = Dead.Random.Range(1, maxInclusive);
          for (int index = 0; index < this.bonusProfile.Count; ++index)
          {
            num -= this.bonusProfile[index];
            if (num <= 0)
            {
              profile[index]++;
              --bonusPulls;
              break;
            }
          }
        }
      }
      return profile;
    }

    public List<int> DefaultMinPulls()
    {
      return ((IEnumerable<List<BossRewardData.Data>>) this.dataGroups).Select<List<BossRewardData.Data>, int>((Func<List<BossRewardData.Data>, int>) (g => 1)).ToList<int>();
    }
  }
}
