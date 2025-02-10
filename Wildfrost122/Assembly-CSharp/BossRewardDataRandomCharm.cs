// Decompiled with JetBrains decompiler
// Type: BossRewardDataRandomCharm
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Boss Rewards/Random Charm", fileName = "Random Charm")]
public class BossRewardDataRandomCharm : BossRewardData
{
  [SerializeField]
  private int minTier = 1;

  public override BossRewardData.Data Pull()
  {
    string name = References.Player.GetComponent<CharacterRewards>().Pull<CardUpgradeData>((object) this, "Charms", 1, false, new Predicate<DataFile>(this.CheckTier))[0].name;
    BossRewardDataRandomCharm.Data data = new BossRewardDataRandomCharm.Data();
    data.type = BossRewardData.Type.Charm;
    data.upgradeName = name;
    return (BossRewardData.Data) data;
  }

  private bool CheckTier(DataFile dataFile)
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
