// Decompiled with JetBrains decompiler
// Type: ScriptUpgradeMinibosses
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
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
          if ((bool) (UnityEngine.Object) cardData && cardData.cardType.miniboss)
          {
            CardUpgradeData upgrade = this.GetUpgrade(cardData);
            if (upgrade != null)
              wave.AddUpgradeToCard(index, upgrade.Clone());
          }
        }
      }
    }
  }

  private CardUpgradeData GetUpgrade(CardData cardData)
  {
    foreach (ScriptUpgradeMinibosses.Profile profile in this.profiles)
    {
      if (profile.cardDataNames.Contains<string>(cardData.name))
        return profile.possibleUpgrades.RandomItem<CardUpgradeData>();
    }
    return this.GetDefaultUpgrade(cardData);
  }

  private CardUpgradeData GetDefaultUpgrade(CardData cardData)
  {
    foreach (CardUpgradeData defaultUpgrade in (IEnumerable<CardUpgradeData>) ((IEnumerable<CardUpgradeData>) this.defaultUpgrades).InRandomOrder<CardUpgradeData>())
    {
      if (defaultUpgrade.CanAssign(cardData))
        return defaultUpgrade;
    }
    return (CardUpgradeData) null;
  }

  [Serializable]
  public struct Profile
  {
    public string[] cardDataNames;
    public CardUpgradeData[] possibleUpgrades;
  }
}
