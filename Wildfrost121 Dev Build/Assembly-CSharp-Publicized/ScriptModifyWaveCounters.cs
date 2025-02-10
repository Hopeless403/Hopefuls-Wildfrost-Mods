// Decompiled with JetBrains decompiler
// Type: ScriptModifyWaveCounters
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Modify Wave Counters", menuName = "Scripts/Modify Wave Counters")]
public class ScriptModifyWaveCounters : Script
{
  [SerializeField]
  public int change = -1;
  [SerializeField]
  public bool normalBattles = true;
  [SerializeField]
  public bool bossBattles = true;
  [SerializeField]
  public bool finalBossBattles = true;

  public override IEnumerator Run()
  {
    using (List<CampaignNode>.Enumerator enumerator = References.Campaign.nodes.GetEnumerator())
    {
      while (enumerator.MoveNext())
      {
        CampaignNode current = enumerator.Current;
        if (current.type.isBattle && (this.normalBattles || !(current.type.name == "CampaignNodeBattle")) && (this.bossBattles || !(current.type.name == "CampaignNodeBoss")))
        {
          if (!this.finalBossBattles)
          {
            string name = current.type.name;
            if (name == "CampaignNodeFinalBoss" || name == "CampaignNodeFinalFinalBoss")
              continue;
          }
          BattleWaveManager.WaveData[] saveCollection = current.data.GetSaveCollection<BattleWaveManager.WaveData>("waves");
          foreach (BattleWaveManager.WaveData waveData in saveCollection)
            waveData.counter += this.change;
          current.data["waves"] = (object) new SaveCollection<BattleWaveManager.WaveData>(saveCollection);
        }
      }
      yield break;
    }
  }
}
