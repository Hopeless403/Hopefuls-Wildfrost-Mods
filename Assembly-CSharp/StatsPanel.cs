// Decompiled with JetBrains decompiler
// Type: StatsPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class StatsPanel : MonoBehaviour
{
  [SerializeField]
  private TMP_Text titleElement;
  [SerializeField]
  private TMP_Text subtitleElement;
  [SerializeField]
  private Transform statsGroup;
  [SerializeField]
  private StatDisplay statPrefab;
  [SerializeField]
  private int maxStats = 6;
  [SerializeField]
  private GameStatData[] stats;

  private void Awake()
  {
    this.titleElement.text = References.LeaderData.title;
    this.subtitleElement.gameObject.SetActive(false);
    CampaignStats runStats = StatsSystem.Get();
    ((IList<GameStatData>) this.stats).Shuffle<GameStatData>();
    foreach (StatsPanel.Stat stat in (IEnumerable<StatsPanel.Stat>) ((IEnumerable<GameStatData>) this.stats).Select<GameStatData, StatsPanel.Stat>((Func<GameStatData, StatsPanel.Stat>) (s => new StatsPanel.Stat(s, runStats))).Where<StatsPanel.Stat>((Func<StatsPanel.Stat, bool>) (s => (double) s.value > 0.0)).OrderByDescending<StatsPanel.Stat, float>((Func<StatsPanel.Stat, float>) (s => UnityEngine.Random.Range(0.0f, s.priority))).Take<StatsPanel.Stat>(this.maxStats).OrderByDescending<StatsPanel.Stat, float>((Func<StatsPanel.Stat, float>) (s => s.statData.displayOrder)))
    {
      StatDisplay statDisplay = UnityEngine.Object.Instantiate<StatDisplay>(this.statPrefab, this.statsGroup);
      statDisplay.gameObject.SetActive(true);
      statDisplay.Assign(stat.statData, stat.stringValue);
    }
  }

  private struct Stat
  {
    public readonly GameStatData statData;
    public readonly float value;
    public readonly string stringValue;
    public readonly float priority;

    public Stat(GameStatData statData, CampaignStats runStats)
    {
      this.statData = statData;
      this.value = statData.GetValue(runStats);
      this.stringValue = statData.GetStringValue(runStats, this.value);
      this.priority = statData.GetPriority(this.value);
    }
  }
}
