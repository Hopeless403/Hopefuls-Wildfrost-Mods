// Decompiled with JetBrains decompiler
// Type: BattleGenerationScript
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections.Generic;
using UnityEngine;

#nullable disable
public abstract class BattleGenerationScript : ScriptableObject
{
  public virtual SaveCollection<BattleWaveManager.WaveData> Run(BattleData battleData, int points)
  {
    return new SaveCollection<BattleWaveManager.WaveData>();
  }

  public void AddGoldGivers(BattleGenerationScript.WaveList waves, BattleData battleData)
  {
    if (battleData.goldGivers <= 0 || battleData.goldGiverPool.Length == 0)
      return;
    List<int> list = new List<int>();
    for (int index = 1; index < waves.Count - 1; ++index)
      list.Add(index);
    for (int index = 0; index < battleData.goldGivers && list.Count > 0; ++index)
    {
      int waveIndex = list.RandomItem<int>();
      list.Remove(waveIndex);
      waves.AddUnit(waveIndex, battleData.goldGiverPool.RandomItem<CardData>());
    }
  }

  public void AddBonusUnits(BattleGenerationScript.WaveList waves, BattleData battleData)
  {
    int num = battleData.bonusUnitRange.Random();
    if (num <= 0 || battleData.bonusUnitPool.Length == 0)
      return;
    List<int> list = new List<int>();
    for (int waveIndex = 0; waveIndex < waves.Count; ++waveIndex)
    {
      if (waves.GetWave(waveIndex).CanAddTo())
        list.Add(waveIndex);
    }
    for (int index = 0; index < num && list.Count > 0; ++index)
    {
      int waveIndex = list.RandomItem<int>();
      list.Remove(waveIndex);
      waves.AddUnit(waveIndex, battleData.bonusUnitPool.RandomItem<CardData>());
    }
  }

  public class WaveList
  {
    public List<BattleWavePoolData.Wave> list;
    public int value;
    public int targetValue;

    public WaveList(int targetValue) => this.targetValue = targetValue;

    public void Add(BattleWavePoolData.Wave wave)
    {
      if (this.list == null)
        this.list = new List<BattleWavePoolData.Wave>();
      if (!wave.fixedOrder)
        wave.units.Shuffle<CardData>();
      int num = this.list.Count;
      int positionPriority1 = wave.positionPriority;
      for (int index1 = 0; index1 < this.list.Count; ++index1)
      {
        int positionPriority2 = this.list[index1].positionPriority;
        if (positionPriority2 >= positionPriority1)
        {
          num = index1;
          if (positionPriority2 == positionPriority1)
          {
            for (int index2 = index1 + 1; index2 < this.list.Count; ++index2)
            {
              if (this.list[index2].positionPriority > positionPriority1)
              {
                num = RandomInclusive.Range(num, index2);
                break;
              }
            }
            break;
          }
          break;
        }
      }
      this.list.Insert(num, wave);
      this.value += wave.value;
    }

    public void RemoveAt(int index) => this.list.RemoveAt(index);

    public BattleWavePoolData.Wave GetWave(int waveIndex) => this.list[waveIndex];

    public void AddUnit(int waveIndex, CardData unit) => this.GetWave(waveIndex).units.Add(unit);

    public int Count => this.list.Count;

    public bool Satisfied() => this.value >= this.targetValue;
  }
}
