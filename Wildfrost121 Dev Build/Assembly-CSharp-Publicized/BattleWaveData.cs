// Decompiled with JetBrains decompiler
// Type: BattleWaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
[Serializable]
public class BattleWaveData
{
  public List<ulong> deployed;
  public int counter;
  public int counterMax;
  public int currentWave;
  public int overflowWaveIndex;
  public BattleWaveData.Wave[] waves;

  [Serializable]
  public class Wave
  {
    public int counter;
    public ulong[] unitIds;
    public bool isBossWave;
    public bool spawned;

    public Wave()
    {
    }

    public Wave(BattleWaveManager.Wave wave)
    {
      this.counter = wave.counter;
      this.unitIds = wave.units.Where<CardData>((Func<CardData, bool>) (a => (bool) (UnityEngine.Object) a)).Select<CardData, ulong>((Func<CardData, ulong>) (a => a.id)).ToArray<ulong>();
      this.isBossWave = wave.isBossWave;
      this.spawned = wave.spawned;
    }
  }
}
