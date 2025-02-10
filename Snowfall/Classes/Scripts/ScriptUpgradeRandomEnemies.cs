// Decompiled with JetBrains decompiler
// Type: Snowfall2.Classes.Scripts.ScriptUpgradeRandomEnemies
// Assembly: Snowfall, Version=0.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 26AFE777-3FAB-4D6F-AF6C-494837402D4A
// Assembly location: C:\Users\harri\AppData\Local\Temp\Temp1_Snowfall_-_Alpha_2.1.2.zip\Snowfall.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Snowfall2.Classes.Scripts
{
  public class ScriptUpgradeRandomEnemies : ScriptUpgradeEnemies
  {
    public override IEnumerator Run()
    {
      List<CardUpgradeData> currentPool = new List<CardUpgradeData>();
      foreach (CampaignNode node in References.Campaign.nodes)
      {
        if (node.type.isBattle)
        {
          BattleWaveManager.WaveData[] saveCollection = node.data.GetSaveCollection<BattleWaveManager.WaveData>("waves");
          int num = this.tiers.Length > node.tier ? this.tiers[node.tier].upgradesRange.Random() : 0;
          if (num > 0)
            this.AddUpgradesRand(currentPool, saveCollection, num, this.tiers[node.tier].canAffectMiniboss);
          saveCollection = (BattleWaveManager.WaveData[]) null;
        }
      }
      yield break;
    }

    public void AddUpgradesRand(
      List<CardUpgradeData> currentPool,
      BattleWaveManager.WaveData[] waves,
      int upgradeCount,
      bool canUpgradeMiniboss)
    {
      List<int> list = ((IEnumerable<BattleWaveManager.WaveData>) waves).Select<BattleWaveManager.WaveData, int>((Func<BattleWaveManager.WaveData, int, int>) ((_, i) => i)).ToList<int>();
      for (int index1 = 0; index1 < waves.Length; ++index1)
      {
        int index2 = Dead.Random.Choose<int>(list.ToArray());
        list.Remove(index2);
        if (this.TryAddUpgrade(currentPool, waves[index2], canUpgradeMiniboss) && --upgradeCount <= 0)
          break;
      }
    }
  }
}
