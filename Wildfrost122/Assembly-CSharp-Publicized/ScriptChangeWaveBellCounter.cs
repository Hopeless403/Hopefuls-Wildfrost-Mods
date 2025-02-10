// Decompiled with JetBrains decompiler
// Type: ScriptChangeWaveBellCounter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Change Wave Bell Counter", menuName = "Scripts/Change Wave Bell Counter")]
public class ScriptChangeWaveBellCounter : Script
{
  [SerializeField]
  public bool set;
  [SerializeField]
  [HideIf("set")]
  public bool add = true;
  [SerializeField]
  public int value = 1;

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

  public void Add()
  {
    foreach (CampaignNode node in Campaign.instance.nodes)
    {
      object obj;
      if (!node.cleared && node.type.isBattle && node.data.TryGetValue("waves", out obj) && obj is SaveCollection<BattleWaveManager.WaveData> waves)
        this.Add(waves);
    }
  }

  public void Set()
  {
    foreach (CampaignNode node in Campaign.instance.nodes)
    {
      object obj;
      if (!node.cleared && node.type.isBattle && node.data.TryGetValue("waves", out obj) && obj is SaveCollection<BattleWaveManager.WaveData> waves)
        this.Set(waves);
    }
  }

  public void Add(SaveCollection<BattleWaveManager.WaveData> waves)
  {
    for (int index = 0; index < waves.Count; ++index)
      waves[index].counter += this.value;
  }

  public void Set(SaveCollection<BattleWaveManager.WaveData> waves)
  {
    for (int index = 0; index < waves.Count; ++index)
      waves[index].counter = this.value;
  }
}
