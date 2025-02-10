// Decompiled with JetBrains decompiler
// Type: BossRewardDataCrown
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using UnityEngine;

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

    public CardUpgradeData GetUpgrade() => AddressableLoader.Get<CardUpgradeData>("CardUpgradeData", this.upgradeDataName.IsNullOrWhitespace() ? "Crown" : this.upgradeDataName);

    public override void Select()
    {
      CardUpgradeData upgradeData = this.GetUpgrade().Clone();
      References.PlayerData.inventory.upgrades.Add(upgradeData);
      Events.InvokeUpgradeGained(upgradeData);
    }
  }
}
