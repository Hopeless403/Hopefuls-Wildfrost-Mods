// Decompiled with JetBrains decompiler
// Type: ScriptUpgradeMinibosses
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Upgrade Minibosses", menuName = "Scripts/Upgrade Minibosses")]
public class ScriptUpgradeMinibosses : Script
{
  [SerializeField]
  private ScriptUpgradeMinibosses.Profile[] profiles;
  [SerializeField]
  private CardUpgradeData[] defaultUpgrades;

  public override IEnumerator Run()
  {
    using (List<CampaignNode>.Enumerator enumerator = References.Campaign.nodes.GetEnumerator())
    {
      while (enumerator.MoveNext())
      {
        CampaignNode current = enumerator.Current;
        if (current.type.isBattle && !(current.type.name == "CampaignNodeFinalBoss"))
          this.AddUpgrade(current.data.GetSaveCollection<BattleWaveManager.WaveData>("waves"));
      }
      yield break;
    }
  }

  private void AddUpgrade(BattleWaveManager.WaveData[] waves)
  {
    foreach (BattleWaveManager.WaveData wave in waves)
    {
      if (wave.isBossWave)
      {
        for (int index = 0; index < wave.Count; ++index)
        {
          CardData cardData = wave.PeekCardData(index);
          if (cardData.cardType.miniboss)
          {
            CardUpgradeData upgrade = this.GetUpgrade(cardData.name);
            if (upgrade != null)
              wave.AddUpgradeToCard(index, upgrade);
          }
        }
      }
    }
  }

  private CardUpgradeData GetUpgrade(string cardDataName)
  {
    foreach (ScriptUpgradeMinibosses.Profile profile in this.profiles)
    {
      if (profile.cardDataNames.Contains<string>(cardDataName))
        return profile.possibleUpgrades.RandomItem<CardUpgradeData>();
    }
    return this.defaultUpgrades.RandomItem<CardUpgradeData>();
  }

  [Serializable]
  public struct Profile
  {
    public string[] cardDataNames;
    public CardUpgradeData[] possibleUpgrades;
  }
}
