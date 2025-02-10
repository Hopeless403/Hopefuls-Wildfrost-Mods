// Decompiled with JetBrains decompiler
// Type: ChallengeShrineSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;

public class ChallengeShrineSequence : BuildingSequenceWithUnlocks<ChallengeShrineSequence>
{
  private void Start() => this._OnStart();

  private void OnEnable()
  {
    List<string> unlockedList = MetaprogressionSystem.GetUnlockedList();
    Dictionary<string, string> dictionary = MetaprogressionSystem.Get<Dictionary<string, string>>("charms");
    for (int index = 0; index < this.challengeStones.Length; ++index)
    {
      ChallengeStone challengeStone = this.challengeStones[index];
      if (unlockedList.Contains(challengeStone.challenge.reward.name))
      {
        string str = dictionary[challengeStone.challenge.reward.name];
        CardUpgradeData upgradeData = AddressableLoader.Get<CardUpgradeData>("CardUpgradeData", str);
        challengeStone.Open(upgradeData);
        CardDiscoverSystem.CheckDiscoverCharm(str);
      }
    }
  }
}
