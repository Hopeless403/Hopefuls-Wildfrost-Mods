// Decompiled with JetBrains decompiler
// Type: OverallStatsSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class OverallStatsSystem : GameSystem
{
  public static OverallStatsSystem instance;
  [SerializeField]
  public CampaignStats stats;

  public void Awake() => OverallStatsSystem.instance = this;

  public void OnEnable()
  {
    global::Events.OnCampaignEnd += new UnityAction<Campaign.Result, CampaignStats, PlayerData>(this.CampaignEnd);
    global::Events.OnGameStart += new UnityAction(this.GameStart);
  }

  public void OnDisable()
  {
    global::Events.OnCampaignEnd -= new UnityAction<Campaign.Result, CampaignStats, PlayerData>(this.CampaignEnd);
    global::Events.OnGameStart -= new UnityAction(this.GameStart);
  }

  public static CampaignStats Get() => OverallStatsSystem.instance.stats;

  public void GameStart()
  {
    if (SaveSystem.Enabled && SaveSystem.StatsExists() && SaveSystem.StatsDataExists("stats"))
      this.stats = SaveSystem.LoadStatsData<CampaignStats>("stats");
    else
      this.stats = new CampaignStats();
  }

  public void CampaignEnd(Campaign.Result result, CampaignStats stats, PlayerData playerData)
  {
    OverallStatsSystem.Combine(this.stats, stats);
    bool mainGameMode = Campaign.Data.GameMode.mainGameMode;
    bool dailyRun = Campaign.Data.GameMode.dailyRun;
    switch (result)
    {
      case Campaign.Result.Win:
        if (SaveSystem.LoadCampaignData<bool>(Campaign.Data.GameMode, "trueWin", false))
        {
          this.stats.Add("results", "trueWin", 1);
          if (mainGameMode)
          {
            this.stats.Add("currentTrueWinStreak", 1);
            this.stats.Max("bestTrueWinStreak", this.stats.Get("currentTrueWinStreak", 1));
          }
        }
        else
          this.stats.Add("results", "win", 1);
        if (mainGameMode)
        {
          this.stats.Add("currentWinStreak", 1);
          this.stats.Max("bestWinStreak", this.stats.Get("currentWinStreak", 1));
          this.stats.Min("bestWinTime", stats.hours * 3600 + Mathf.FloorToInt(stats.time));
        }
        if (dailyRun)
          this.stats.Add("dailyRunResults", "win", 1);
        this.stats.Add("winsWithTribe", playerData.classData.id, 1);
        using (HashSet<string>.Enumerator enumerator = playerData.inventory.deck.Select<CardData, string>((Func<CardData, string>) (a => a.name)).ToHashSet<string>().GetEnumerator())
        {
          while (enumerator.MoveNext())
            this.stats.Add("winsWithCardInDeck", enumerator.Current, 1);
          break;
        }
      case Campaign.Result.Lose:
        this.stats.Add("results", "lose", 1);
        if (mainGameMode)
          this.ResetWinStreak();
        if (dailyRun)
          this.stats.Add("dailyRunResults", "lose", 1);
        this.stats.Add("loseWithTribe", playerData.classData.id, 1);
        break;
      case Campaign.Result.Restart:
        this.stats.Add("results", "restart", 1);
        if (mainGameMode)
          this.ResetWinStreak();
        if (dailyRun)
          this.stats.Add("dailyRunResults", "restart", 1);
        this.stats.Add("loseWithTribe", playerData.classData.id, 1);
        break;
    }
    this.Save();
  }

  public void ResetWinStreak()
  {
    this.stats.Set("currentWinStreak", 0);
    this.stats.Set("currentTrueWinStreak", 0);
  }

  public void Save()
  {
    SaveSystem.SaveStatsData<CampaignStats>("stats", this.stats);
    global::Events.InvokeOverallStatsSaved(this.stats);
  }

  public static void Combine(CampaignStats stats, CampaignStats other)
  {
    stats.time += other.time;
    stats.hours += other.hours;
    if (other.add != null)
    {
      foreach (KeyValuePair<string, Dictionary<string, int>> keyValuePair1 in other.add)
      {
        foreach (KeyValuePair<string, int> keyValuePair2 in keyValuePair1.Value)
          OverallStatsSystem.Change(keyValuePair1.Key, keyValuePair2.Key, keyValuePair2.Value, ref stats.add, new Func<int, int, int>(OverallStatsSystem.Add));
      }
    }
    if (other.max == null)
      return;
    foreach (KeyValuePair<string, Dictionary<string, int>> keyValuePair3 in other.max)
    {
      foreach (KeyValuePair<string, int> keyValuePair4 in keyValuePair3.Value)
        OverallStatsSystem.Change(keyValuePair3.Key, keyValuePair4.Key, keyValuePair4.Value, ref stats.max, new Func<int, int, int>(OverallStatsSystem.Max));
    }
  }

  public static void Change(
    string stat,
    string key,
    int value,
    ref Dictionary<string, Dictionary<string, int>> values,
    Func<int, int, int> action)
  {
    if (values == null)
      values = new Dictionary<string, Dictionary<string, int>>();
    Dictionary<string, int> dictionary1;
    if (!values.ContainsKey(stat))
    {
      dictionary1 = new Dictionary<string, int>();
      values[stat] = dictionary1;
    }
    else
    {
      Dictionary<string, int> dictionary2 = values[stat];
      if (dictionary2 != null)
      {
        dictionary1 = dictionary2;
      }
      else
      {
        dictionary1 = new Dictionary<string, int>();
        values[stat] = dictionary1;
      }
    }
    int num1;
    if (dictionary1.ContainsKey(key))
    {
      int num2 = dictionary1[key];
      num1 = action(num2, value);
    }
    else
      num1 = value;
    dictionary1[key] = num1;
  }

  public static int Add(int value, int add) => value + add;

  public static int Max(int value, int max) => Mathf.Max(value, max);
}
