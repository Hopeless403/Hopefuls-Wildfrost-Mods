// Decompiled with JetBrains decompiler
// Type: StatsPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

#nullable disable
public class StatsPanel : MonoBehaviour
{
  [SerializeField]
  public TMP_Text titleElement;
  [SerializeField]
  public TMP_Text subtitleElement;
  [SerializeField]
  public Transform statsGroup;
  [SerializeField]
  public StatDisplay statPrefab;
  [SerializeField]
  public int maxStats = 6;
  [SerializeField]
  public GameStatData[] stats;

  public void Awake()
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

  public struct Stat
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
