// Decompiled with JetBrains decompiler
// Type: BossRewardSelectCrown
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
public class BossRewardSelectCrown : BossRewardSelect
{
  [SerializeField]
  private ImageSprite crownImage;

  public override void SetUp(
    BossRewardData.Data rewardData,
    GainBlessingSequence2 gainBlessingSequence)
  {
    base.SetUp(rewardData, gainBlessingSequence);
    if (!(rewardData is BossRewardDataCrown.Data data))
      return;
    CardUpgradeData upgrade = data.GetUpgrade();
    this.crownImage.SetSprite(upgrade.image);
    this.popUpName = upgrade.name;
    this.title = upgrade.title;
    this.body = upgrade.text;
  }
}
