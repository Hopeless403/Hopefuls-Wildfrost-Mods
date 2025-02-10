// Decompiled with JetBrains decompiler
// Type: Pokefrost.BattleGenerationScriptHooh
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  internal class BattleGenerationScriptHooh : BattleGenerationScript
  {
    public override SaveCollection<BattleWaveManager.WaveData> Run(
      BattleData battleData,
      int points)
    {
      Debug.Log((object) string.Format("Creating Waves for [{0}]", (object) battleData));
      List<BattleWavePoolData> battleWavePoolDataList = new List<BattleWavePoolData>();
      int targetValue = Mathf.RoundToInt((float) points * battleData.pointFactor);
      Debug.Log((object) string.Format("Points: {0}", (object) targetValue));
      BattleGenerationScript.WaveList waves = new BattleGenerationScript.WaveList(targetValue);
      BattleWavePoolData[] array1 = ((IEnumerable<BattleWavePoolData>) battleData.pools).Select<BattleWavePoolData, BattleWavePoolData>((Func<BattleWavePoolData, BattleWavePoolData>) (p => p.InstantiateKeepName<BattleWavePoolData>())).ToArray<BattleWavePoolData>();
      BattleWavePoolData.Wave wave1 = array1[0].Pull();
      Dead.Random.Range(0, array1[1].waves.Length);
      BattleWavePoolData[] array2 = ((IEnumerable<BattleWavePoolData>) array1).Skip<BattleWavePoolData>(1).ToArray<BattleWavePoolData>();
      for (int index = 0; index < 3; ++index)
        waves.Add(this.Concat(((IEnumerable<BattleWavePoolData>) array2).Select<BattleWavePoolData, BattleWavePoolData.Wave>((Func<BattleWavePoolData, BattleWavePoolData.Wave>) (p => p.Pull())).ToArray<BattleWavePoolData.Wave>()));
      waves.AddUnit(0, wave1.units[0]);
      this.AddBonusUnits(waves, battleData);
      List<BattleWaveManager.WaveData> collection = new List<BattleWaveManager.WaveData>();
      int count = waves.Count;
      for (int waveIndex = 0; waveIndex < count; ++waveIndex)
      {
        BattleWaveManager.WaveDataBasic waveDataBasic1 = new BattleWaveManager.WaveDataBasic();
        waveDataBasic1.counter = battleData.waveCounter;
        BattleWaveManager.WaveDataBasic waveDataBasic2 = waveDataBasic1;
        BattleWavePoolData.Wave wave2 = waves.GetWave(waveIndex);
        List<string> source = new List<string>();
        foreach (CardData unit in wave2.units)
        {
          source.Add(unit.name);
          if (!waveDataBasic2.isBossWave && unit.cardType.miniboss)
            waveDataBasic2.isBossWave = true;
        }
        waveDataBasic2.cards = source.Select<string, BattleWaveManager.Card>((Func<string, BattleWaveManager.Card>) (a => new BattleWaveManager.Card(a))).ToArray<BattleWaveManager.Card>();
        collection.Add((BattleWaveManager.WaveData) waveDataBasic2);
      }
      return new SaveCollection<BattleWaveManager.WaveData>(collection);
    }

    public BattleWavePoolData.Wave Concat(params BattleWavePoolData.Wave[] waves)
    {
      BattleWavePoolData.Wave wave = new BattleWavePoolData.Wave();
      wave.units = new List<CardData>(6);
      for (int index = 0; index < waves.Length; ++index)
      {
        wave.units.AddRange((IEnumerable<CardData>) waves[index].units);
        wave.value += waves[index].value;
        wave.positionPriority = Math.Max(wave.positionPriority, waves[index].positionPriority);
        wave.fixedOrder = true;
        wave.maxSize += waves[index].maxSize;
      }
      return wave;
    }
  }
}
