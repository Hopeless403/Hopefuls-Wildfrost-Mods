// Decompiled with JetBrains decompiler
// Type: BossRewardSelectModifier
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
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
