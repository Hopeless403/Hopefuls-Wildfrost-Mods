// Decompiled with JetBrains decompiler
// Type: ChallengeShrineSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections.Generic;

#nullable disable
public class ChallengeShrineSequence : BuildingSequenceWithUnlocks<ChallengeShrineSequence>
{
  public void Start() => this._OnStart();

  public void OnEnable()
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
