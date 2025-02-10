// Decompiled with JetBrains decompiler
// Type: ScriptModifyWaveCounters
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Modify Wave Counters", menuName = "Scripts/Modify Wave Counters")]
public class ScriptModifyWaveCounters : Script
{
  [SerializeField]
  private int change = -1;
  [SerializeField]
  private bool normalBattles = true;
  [SerializeField]
  private bool bossBattles = true;
  [SerializeField]
  private bool finalBossBattles = true;

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
