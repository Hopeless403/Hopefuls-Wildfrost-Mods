﻿// Decompiled with JetBrains decompiler
// Type: OverallStatsDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class OverallStatsDisplay : MonoBehaviour
{
  [SerializeField]
  public GameStatData[] stats;
  [SerializeField]
  public int statsPerGroup = 20;
  [SerializeField]
  public TMP_Text[] nameGroups;
  [SerializeField]
  public TMP_Text[] valueGroups;
  [SerializeField]
  public float lineHeight = 0.34f;
  public static readonly Dictionary<string, bool> localesCentred = new Dictionary<string, bool>()
  {
    {
      "en",
      false
    },
    {
      "zh-Hans",
      true
    },
    {
      "zh-Hant",
      true
    },
    {
      "ko",
      true
    },
    {
      "ja",
      true
    }
  };
  public static bool centred;

  public void OnEnable()
  {
    OverallStatsDisplay.localesCentred.TryGetValue(LocalizationSettings.SelectedLocale.Identifier.Code, out OverallStatsDisplay.centred);
    this.Clear();
    this.Populate();
  }

  public void Populate()
  {
    StopWatch.Start();
    CampaignStats stats = OverallStatsSystem.Get().Clone();
    List<string> stringList = new List<string>()
    {
      "GameModeNormal",
      "GameModeDaily",
      "GameModeTutorial"
    };
    GameMode gameMode1 = (GameMode) null;
    if (Campaign.Data != null && (bool) (Object) References.Campaign && References.Campaign.result == Campaign.Result.None)
    {
      stringList.Remove(Campaign.Data.GameMode.name);
      OverallStatsSystem.Combine(stats, StatsSystem.Get());
      gameMode1 = Campaign.Data.GameMode;
    }
    foreach (string assetName in stringList)
    {
      if (!((Object) gameMode1 != (Object) null) || !(assetName == gameMode1.name))
      {
        GameMode gameMode2 = AddressableLoader.Get<GameMode>("GameMode", assetName);
        if (SaveSystem.CampaignExists(gameMode2) && Campaign.CheckContinue(gameMode2))
        {
          CampaignStats other = SaveSystem.LoadCampaignData<CampaignStats>(gameMode2, "stats");
          if (other != null)
            OverallStatsSystem.Combine(stats, other);
        }
      }
    }
    int num = 0;
    int index = 0;
    TMP_Text nameGroup = this.nameGroups[index];
    TMP_Text valueGroup = this.valueGroups[index];
    foreach (GameStatData stat in this.stats)
    {
      if (!(bool) (Object) stat)
      {
        nameGroup.text += "<br>";
        if (!OverallStatsDisplay.centred)
          valueGroup.text += "<br>";
      }
      else
      {
        string str = stat.stringKey.GetLocalizedString().Format(OverallStatsDisplay.centred ? (object) ("<#fff>" + stat.GetStringValue(stats, stat.GetValue(stats)) + "</color><br>") : (object) "<br>");
        nameGroup.text += str;
        if (!OverallStatsDisplay.centred)
        {
          TMP_Text tmpText = valueGroup;
          tmpText.text = tmpText.text + stat.GetStringValue(stats, stat.GetValue(stats)) + "<br>";
        }
      }
      if (++num > this.statsPerGroup)
      {
        num = 0;
        if (++index < this.nameGroups.Length)
        {
          nameGroup = this.nameGroups[index];
          valueGroup = this.valueGroups[index];
        }
        else
          break;
      }
    }
    Debug.Log((object) string.Format("OverallStatsDisplay → Populated ({0}ms)", (object) StopWatch.Stop()));
  }

  public void Clear()
  {
    foreach (TMP_Text nameGroup in this.nameGroups)
    {
      nameGroup.text = string.Format("<line-height={0}>", (object) this.lineHeight);
      if (OverallStatsDisplay.centred)
        nameGroup.text += "<align=center>";
    }
    foreach (TMP_Text valueGroup in this.valueGroups)
      valueGroup.text = string.Format("<line-height={0}>", (object) this.lineHeight);
  }
}
