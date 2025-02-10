// Decompiled with JetBrains decompiler
// Type: BossRewardDataCrown
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Boss Rewards/Crown", fileName = "Crown")]
public class BossRewardDataCrown : BossRewardData
{
  public override BossRewardData.Data Pull()
  {
    BossRewardDataCrown.Data data = new BossRewardDataCrown.Data();
    data.type = BossRewardData.Type.Crown;
    return (BossRewardData.Data) data;
  }

  [Serializable]
  public new class Data : BossRewardData.Data
  {
    public string upgradeDataName;

    public CardUpgradeData GetUpgrade()
    {
      return AddressableLoader.Get<CardUpgradeData>("CardUpgradeData", this.upgradeDataName.IsNullOrWhitespace() ? "Crown" : this.upgradeDataName);
    }

    public override void Select()
    {
      CardUpgradeData upgradeData = this.GetUpgrade().Clone();
      References.PlayerData.inventory.upgrades.Add(upgradeData);
      Events.InvokeUpgradeGained(upgradeData);
    }
  }
}
