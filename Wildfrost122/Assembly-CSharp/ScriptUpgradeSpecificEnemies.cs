﻿// Decompiled with JetBrains decompiler
// Type: ScriptUpgradeSpecificEnemies
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Upgrade Specific Enemies", menuName = "Scripts/Upgrade Specific Enemies")]
public class ScriptUpgradeSpecificEnemies : Script
{
  [SerializeField]
  private ScriptUpgradeSpecificEnemies.Profile[] profiles;

  public override IEnumerator Run()
  {
    using (List<CampaignNode>.Enumerator enumerator = References.Campaign.nodes.GetEnumerator())
    {
      while (enumerator.MoveNext())
      {
        CampaignNode current = enumerator.Current;
        if (current.type.isBattle)
        {
          foreach (BattleWaveManager.WaveData save in current.data.GetSaveCollection<BattleWaveManager.WaveData>("waves"))
          {
            for (int index = 0; index < save.Count; ++index)
            {
              string cardName = save.GetCardName(index);
              ScriptUpgradeSpecificEnemies.Profile profile = ((IEnumerable<ScriptUpgradeSpecificEnemies.Profile>) this.profiles).FirstOrDefault<ScriptUpgradeSpecificEnemies.Profile>((Func<ScriptUpgradeSpecificEnemies.Profile, bool>) (a => a.cardData.name == cardName));
              if (profile != null)
              {
                foreach (CardUpgradeData upgrade in profile.upgrades)
                  save.AddUpgradeToCard(index, upgrade);
              }
            }
          }
        }
      }
      yield break;
    }
  }

  [Serializable]
  public class Profile
  {
    public CardData cardData;
    public CardUpgradeData[] upgrades;
  }
}
