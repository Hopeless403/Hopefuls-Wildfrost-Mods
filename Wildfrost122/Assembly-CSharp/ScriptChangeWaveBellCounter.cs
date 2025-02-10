// Decompiled with JetBrains decompiler
// Type: ScriptChangeWaveBellCounter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Change Wave Bell Counter", menuName = "Scripts/Change Wave Bell Counter")]
public class ScriptChangeWaveBellCounter : Script
{
  [SerializeField]
  private bool set;
  [SerializeField]
  [HideIf("set")]
  private bool add = true;
  [SerializeField]
  private int value = 1;

  public override IEnumerator Run()
  {
    if (this.set)
      this.Set();
    else if (this.add)
    {
      this.Add();
      yield break;
    }
  }

  private void Add()
  {
    foreach (CampaignNode node in Campaign.instance.nodes)
    {
      object obj;
      if (!node.cleared && node.type.isBattle && node.data.TryGetValue("waves", out obj) && obj is SaveCollection<BattleWaveManager.WaveData> waves)
        this.Add(waves);
    }
  }

  private void Set()
  {
    foreach (CampaignNode node in Campaign.instance.nodes)
    {
      object obj;
      if (!node.cleared && node.type.isBattle && node.data.TryGetValue("waves", out obj) && obj is SaveCollection<BattleWaveManager.WaveData> waves)
        this.Set(waves);
    }
  }

  private void Add(SaveCollection<BattleWaveManager.WaveData> waves)
  {
    for (int index = 0; index < waves.Count; ++index)
      waves[index].counter += this.value;
  }

  private void Set(SaveCollection<BattleWaveManager.WaveData> waves)
  {
    for (int index = 0; index < waves.Count; ++index)
      waves[index].counter = this.value;
  }
}
