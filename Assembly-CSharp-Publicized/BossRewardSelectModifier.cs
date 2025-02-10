// Decompiled with JetBrains decompiler
// Type: BossRewardSelectModifier
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

public class BossRewardSelectModifier : BossRewardSelect
{
  [SerializeField]
  public ImageSprite bellImage;
  [SerializeField]
  public ImageSprite dingerImage;

  public override void SetUp(
    BossRewardData.Data rewardData,
    GainBlessingSequence2 gainBlessingSequence)
  {
    base.SetUp(rewardData, gainBlessingSequence);
    if (!(rewardData is BossRewardDataModifier.Data data))
      return;
    GameModifierData modifier = data.GetModifier();
    this.bellImage.SetSprite(modifier.bellSprite);
    this.dingerImage.SetSprite(modifier.dingerSprite);
    this.popUpName = modifier.name;
    this.title = modifier.titleKey.GetLocalizedString();
    this.body = modifier.descriptionKey.GetLocalizedString();
  }
}
