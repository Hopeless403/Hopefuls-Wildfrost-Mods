// Decompiled with JetBrains decompiler
// Type: ScriptEarlyMinibosses
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Early Minibosses", menuName = "Scripts/Early Minibosses")]
public class ScriptEarlyMinibosses : Script
{
  public override IEnumerator Run()
  {
    using (List<CampaignNode>.Enumerator enumerator = References.Campaign.nodes.GetEnumerator())
    {
      while (enumerator.MoveNext())
      {
        CampaignNode current = enumerator.Current;
        if (current.type.isBattle && !current.type.isBoss)
        {
          List<BattleWaveManager.WaveData> list = current.data.GetSaveCollection<BattleWaveManager.WaveData>("waves").ToList<BattleWaveManager.WaveData>();
          BattleWaveManager.WaveData waveData = list.FirstOrDefault<BattleWaveManager.WaveData>((Func<BattleWaveManager.WaveData, bool>) (a => a.isBossWave));
          if (waveData != null)
          {
            int index = list.IndexOf(waveData);
            list.RemoveAt(index);
            list.Insert(index - 1, waveData);
            current.data["waves"] = (object) new SaveCollection<BattleWaveManager.WaveData>(list);
          }
        }
      }
      yield break;
    }
  }
}
