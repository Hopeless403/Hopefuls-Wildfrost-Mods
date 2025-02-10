// Decompiled with JetBrains decompiler
// Type: BattleWavePoolData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Battle Wave Pool Data", menuName = "Battle Wave Pool")]
public class BattleWavePoolData : ScriptableObject
{
  [Range(1f, 5f)]
  public int weight = 1;
  public int forcePulls;
  public int maxPulls = 999;
  public BattleWavePoolData.Wave[] waves;
  public int pullCount;
  public List<BattleWavePoolData.Wave> workingList;

  public bool CanPull() => this.pullCount < this.maxPulls;

  public bool MustPull() => this.pullCount < this.forcePulls;

  public BattleWavePoolData.Wave Pull()
  {
    if (this.workingList == null)
      this.workingList = new List<BattleWavePoolData.Wave>();
    if (this.workingList.Count <= 0)
      this.workingList.AddRange((IEnumerable<BattleWavePoolData.Wave>) this.waves);
    int index = this.workingList.Count > 0 ? this.workingList.RandomIndex<BattleWavePoolData.Wave>() : throw new Exception("BattleWavePoolData \"waves\" list is empty!");
    BattleWavePoolData.Wave working = this.workingList[index];
    this.workingList.RemoveAt(index);
    ++this.pullCount;
    return working;
  }

  public void Reset()
  {
    this.pullCount = 0;
    this.workingList = (List<BattleWavePoolData.Wave>) null;
  }

  [Serializable]
  public struct Wave
  {
    public List<CardData> units;
    public int value;
    public int positionPriority;
    public bool fixedOrder;
    public int maxSize;

    public bool CanAddTo() => this.maxSize <= 0 || this.units.Count < this.maxSize;
  }
}
