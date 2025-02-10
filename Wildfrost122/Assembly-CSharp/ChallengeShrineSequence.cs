// Decompiled with JetBrains decompiler
// Type: ChallengeShrineSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;

#nullable disable
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
