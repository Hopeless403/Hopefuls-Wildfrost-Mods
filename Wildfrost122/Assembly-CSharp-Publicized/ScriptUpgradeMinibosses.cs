// Decompiled with JetBrains decompiler
// Type: ScriptUpgradeMinibosses
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Upgrade Minibosses", menuName = "Scripts/Upgrade Minibosses")]
public class ScriptUpgradeMinibosses : Script
{
  [SerializeField]
  public ScriptUpgradeMinibosses.Profile[] profiles;
  [SerializeField]
  public CardUpgradeData[] defaultUpgrades;

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

  public void AddUpgrade(BattleWaveManager.WaveData[] waves)
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

  public CardUpgradeData GetUpgrade(CardData cardData)
  {
    foreach (ScriptUpgradeMinibosses.Profile profile in this.profiles)
    {
      if (profile.cardDataNames.Contains<string>(cardData.name))
        return profile.possibleUpgrades.RandomItem<CardUpgradeData>();
    }
    return this.GetDefaultUpgrade(cardData);
  }

  public CardUpgradeData GetDefaultUpgrade(CardData cardData)
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
