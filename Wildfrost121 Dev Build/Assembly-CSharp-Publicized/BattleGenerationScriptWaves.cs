// Decompiled with JetBrains decompiler
// Type: BattleGenerationScriptWaves
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "WaveBattleGenerator", menuName = "Battle Generation Scripts/Waves")]
public class BattleGenerationScriptWaves : BattleGenerationScript
{
  public override SaveCollection<BattleWaveManager.WaveData> Run(BattleData battleData, int points)
  {
    Debug.Log((object) string.Format("Creating Waves for [{0}]", (object) battleData));
    List<BattleWavePoolData> list = new List<BattleWavePoolData>();
    int targetValue = Mathf.RoundToInt((float) points * battleData.pointFactor);
    Debug.Log((object) string.Format("Points: {0}", (object) targetValue));
    BattleGenerationScript.WaveList waves = new BattleGenerationScript.WaveList(targetValue);
    foreach (BattleWavePoolData pool in battleData.pools)
    {
      BattleWavePoolData battleWavePoolData = UnityEngine.Object.Instantiate<BattleWavePoolData>(pool);
      while (battleWavePoolData.MustPull() && battleWavePoolData.CanPull())
        waves.Add(battleWavePoolData.Pull());
      for (int index = 0; index < battleWavePoolData.weight; ++index)
        list.Add(battleWavePoolData);
    }
    while (!waves.Satisfied() && list.Count > 0)
    {
      BattleWavePoolData battleWavePoolData = list.RandomItem<BattleWavePoolData>();
      if ((UnityEngine.Object) battleWavePoolData != (UnityEngine.Object) null && battleWavePoolData.CanPull())
      {
        waves.Add(battleWavePoolData.Pull());
      }
      else
      {
        list.Remove(battleWavePoolData);
        UnityEngine.Object.Destroy((UnityEngine.Object) battleWavePoolData);
      }
    }
    for (int index = list.Count - 1; index >= 0; --index)
    {
      UnityEngine.Object.Destroy((UnityEngine.Object) list[index]);
      list.RemoveAt(index);
    }
    this.AddGoldGivers(waves, battleData);
    this.AddBonusUnits(waves, battleData);
    List<BattleWaveManager.WaveData> collection = new List<BattleWaveManager.WaveData>();
    int count = waves.Count;
    for (int waveIndex = 0; waveIndex < count; ++waveIndex)
    {
      BattleWaveManager.WaveDataBasic waveDataBasic1 = new BattleWaveManager.WaveDataBasic();
      waveDataBasic1.counter = battleData.waveCounter;
      BattleWaveManager.WaveDataBasic waveDataBasic2 = waveDataBasic1;
      BattleWavePoolData.Wave wave = waves.GetWave(waveIndex);
      List<string> source = new List<string>();
      foreach (CardData unit in wave.units)
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
}
