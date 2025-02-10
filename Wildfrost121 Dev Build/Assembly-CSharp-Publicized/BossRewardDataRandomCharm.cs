// Decompiled with JetBrains decompiler
// Type: BossRewardDataRandomCharm
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Boss Rewards/Random Charm", fileName = "Random Charm")]
public class BossRewardDataRandomCharm : BossRewardData
{
  [SerializeField]
  public int minTier = 1;

  public override BossRewardData.Data Pull()
  {
    string name = References.Player.GetComponent<CharacterRewards>().Pull<CardUpgradeData>((object) this, "Charms", 1, false, new Predicate<DataFile>(this.CheckTier))[0].name;
    BossRewardDataRandomCharm.Data data = new BossRewardDataRandomCharm.Data();
    data.type = BossRewardData.Type.Charm;
    data.upgradeName = name;
    return (BossRewardData.Data) data;
  }

  public bool CheckTier(DataFile dataFile)
  {
    return dataFile is CardUpgradeData cardUpgradeData && cardUpgradeData.tier >= this.minTier;
  }

  [Serializable]
  public new class Data : BossRewardData.Data
  {
    public string upgradeName;

    public CardUpgradeData GetUpgrade()
    {
      return AddressableLoader.Get<CardUpgradeData>("CardUpgradeData", this.upgradeName);
    }

    public override void Select()
    {
      CardUpgradeData upgradeData = this.GetUpgrade().Clone();
      References.PlayerData.inventory.upgrades.Add(upgradeData);
      Events.InvokeUpgradeGained(upgradeData);
    }
  }
}
