// Decompiled with JetBrains decompiler
// Type: BossRewardSelectCrown
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

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
