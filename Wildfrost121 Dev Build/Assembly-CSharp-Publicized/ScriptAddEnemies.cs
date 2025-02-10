// Decompiled with JetBrains decompiler
// Type: ScriptAddEnemies
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Add Enemies", menuName = "Scripts/Add Enemies")]
public class ScriptAddEnemies : Script
{
  [SerializeField]
  public ScriptAddEnemies.Profile[] profiles;

  public override IEnumerator Run()
  {
    using (List<CampaignNode>.Enumerator enumerator = References.Campaign.nodes.GetEnumerator())
    {
      while (enumerator.MoveNext())
      {
        CampaignNode current = enumerator.Current;
        if (current.type.isBattle)
        {
          string targetBattleName = (string) current.data["battle"];
          ScriptAddEnemies.Profile profile = ((IEnumerable<ScriptAddEnemies.Profile>) this.profiles).FirstOrDefault<ScriptAddEnemies.Profile>((Func<ScriptAddEnemies.Profile, bool>) (a => a.battleData.name == targetBattleName));
          if (profile != null)
          {
            BattleWaveManager.WaveData save = current.data.GetSaveCollection<BattleWaveManager.WaveData>("waves")[profile.toWave];
            int count = save.Count;
            ScriptAddEnemies.InsertTo(save, profile.randomPosition ? Dead.Random.Range(0, count) : count, profile.add, profile.pool);
          }
        }
      }
      yield break;
    }
  }

  public static void InsertTo(
    BattleWaveManager.WaveData waveData,
    int insertPos,
    int count,
    CardData[] fromPool)
  {
    List<CardData> list = new List<CardData>();
    for (int index = 0; index < count; ++index)
    {
      if (list.Count <= 0)
        list.AddRange((IEnumerable<CardData>) fromPool);
      CardData random = list.TakeRandom<CardData>();
      if (waveData is BattleWaveManager.WaveDataFull)
        waveData.InsertCard(insertPos, random.Clone());
      else
        waveData.InsertCard(insertPos, random);
    }
  }

  [Serializable]
  public class Profile
  {
    public BattleData battleData;
    public int add = 2;
    public int toWave = 1;
    public bool randomPosition;
    public CardData[] pool;
  }
}
