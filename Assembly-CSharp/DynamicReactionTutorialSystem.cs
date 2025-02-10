// Decompiled with JetBrains decompiler
// Type: DynamicReactionTutorialSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class DynamicReactionTutorialSystem : GameSystem
{
  private void OnEnable()
  {
    Events.OnCampaignGenerated += new Events.AsyncAction(DynamicReactionTutorialSystem.CampaignGenerated);
    if (!SaveSystem.LoadProgressData<bool>("dynamicReactionTutorial", false) && !(Campaign.Data.GameMode.name != "GameModeNormal"))
      return;
    this.enabled = false;
  }

  private void OnDisable() => Events.OnCampaignGenerated -= new Events.AsyncAction(DynamicReactionTutorialSystem.CampaignGenerated);

  private static Task CampaignGenerated()
  {
    CampaignNode campaignNode = References.Campaign.nodes.FirstOrDefault<CampaignNode>((Func<CampaignNode, bool>) (a => a.type.isBattle));
    object obj;
    if (campaignNode != null && campaignNode.data.TryGetValue("waves", out obj) && obj is SaveCollection<BattleWaveManager.WaveData> saveCollection && saveCollection.Count > 0)
    {
      BattleWaveManager.WaveData waveData = saveCollection[0];
      if (waveData != null)
      {
        string[] strArray = new string[1]{ "Smackgoon" };
        string[] array = new string[5]
        {
          "Chungoon",
          "Grouchy",
          "Snoolf",
          "Snowbo",
          "NakedGnome"
        };
        bool flag = false;
        for (int index = 0; index < waveData.Count; ++index)
        {
          string cardName = waveData.GetCardName(index);
          if (strArray.Contains<string>(cardName))
          {
            flag = true;
            break;
          }
        }
        if (!flag)
        {
          for (int index = 0; index < waveData.Count; ++index)
          {
            string cardName = waveData.GetCardName(index);
            if (array.Contains<string>(cardName) && waveData is BattleWaveManager.WaveDataBasic waveDataBasic)
            {
              BattleWaveManager.Card card = waveDataBasic.Get(index);
              card.cardName = strArray.RandomItem<string>();
              card.upgradeNames = (List<string>) null;
              break;
            }
          }
        }
      }
    }
    return Task.CompletedTask;
  }
}
