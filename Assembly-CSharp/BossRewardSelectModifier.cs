// Decompiled with JetBrains decompiler
// Type: BossRewardSelectModifier
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public class BossRewardSelectModifier : BossRewardSelect
{
  [SerializeField]
  private ImageSprite bellImage;
  [SerializeField]
  private ImageSprite dingerImage;

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
