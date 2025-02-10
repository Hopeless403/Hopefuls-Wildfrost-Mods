// Decompiled with JetBrains decompiler
// Type: BossRewardSelectCrown
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

public class BossRewardSelectCrown : BossRewardSelect
{
  [SerializeField]
  public ImageSprite crownImage;

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
