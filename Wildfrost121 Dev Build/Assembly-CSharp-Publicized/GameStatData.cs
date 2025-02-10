// Decompiled with JetBrains decompiler
// Type: GameStatData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Localization;

#nullable disable
[CreateAssetMenu(menuName = "Game Stat", fileName = "Stat")]
public class GameStatData : ScriptableObject
{
  public LocalizedString stringKey;
  [SerializeField]
  public GameStatData.Type type;
  [SerializeField]
  [ShowIf("NeedsStatName")]
  public string statName;
  [SerializeField]
  [ShowIf("NeedsKey")]
  public string statKey;
  [SerializeField]
  [ShowIf("NeedsRate")]
  public string statKeyOver;
  [SerializeField]
  [ShowIf("NeedsDefault")]
  public int defaultValue;
  public float displayOrder;
  public float priority;
  public float par = 1f;
  public float priorityAddOverPar;
  public float prioritySubUnderPar;
  public GameStatData[] overwrites;

  public bool NeedsStatName => this.type != GameStatData.Type.Time;

  public bool NeedsKey
  {
    get
    {
      GameStatData.Type type = this.type;
      int num;
      switch (type)
      {
        case GameStatData.Type.Normal:
        case GameStatData.Type.Best:
          num = 0;
          break;
        default:
          num = type != GameStatData.Type.Rate ? 1 : 0;
          break;
      }
      return num == 0;
    }
  }

  public bool NeedsDefault
  {
    get
    {
      return this.type != GameStatData.Type.Count && this.type != GameStatData.Type.Time && this.type != GameStatData.Type.RandomKey;
    }
  }

  public bool NeedsRate => this.type == GameStatData.Type.Rate;

  public float GetPriority(float value)
  {
    float num = value - this.par;
    float priority = this.priority;
    return (double) num <= 0.0 ? priority + this.prioritySubUnderPar * num : priority + this.priorityAddOverPar * num;
  }

  public float GetValue(CampaignStats stats)
  {
    float num;
    switch (this.type)
    {
      case GameStatData.Type.Best:
        num = (float) this.GetBestValue(stats, this.statKey);
        break;
      case GameStatData.Type.BestAny:
        num = (float) stats.Best(this.statName, this.defaultValue);
        break;
      case GameStatData.Type.Count:
        num = (float) stats.Count(this.statName);
        break;
      case GameStatData.Type.Time:
        num = (float) Mathf.RoundToInt(stats.time + (float) (stats.hours * 3600));
        break;
      case GameStatData.Type.RandomKey:
        num = 1f;
        break;
      case GameStatData.Type.Rate:
        num = this.GetRateValue(stats);
        break;
      case GameStatData.Type.BestTime:
        num = (float) this.GetBestValue(stats, this.statKey);
        break;
      default:
        num = (float) this.GetNormalValue(stats, this.statKey);
        break;
    }
    return num;
  }

  public int GetBestValue(CampaignStats stats, string statKey)
  {
    if (!GameStatData.HasMultipleStatKeys(statKey))
      return stats.Best(this.statName, statKey, this.defaultValue);
    IEnumerable<string> statKeys = GameStatData.GetStatKeys(statKey);
    List<int> source = new List<int>();
    foreach (string key in statKeys)
      source.Add(stats.Best(this.statName, key, this.defaultValue));
    return source.Max();
  }

  public int GetNormalValue(CampaignStats stats, string statKey)
  {
    if (!GameStatData.HasMultipleStatKeys(statKey))
      return stats.Get(this.statName, statKey, this.defaultValue);
    IEnumerable<string> statKeys = GameStatData.GetStatKeys(statKey);
    int normalValue = 0;
    foreach (string key in statKeys)
      normalValue += stats.Get(this.statName, key, this.defaultValue);
    return normalValue;
  }

  public float GetRateValue(CampaignStats stats)
  {
    float normalValue = (float) this.GetNormalValue(stats, this.statKey);
    float num = (float) this.GetNormalValue(stats, this.statKeyOver) + normalValue;
    return (double) num <= 0.0 ? ((double) normalValue > 0.0 ? 1f : 0.0f) : normalValue / num;
  }

  public static bool HasMultipleStatKeys(string @in) => @in.Contains('|');

  public static IEnumerable<string> GetStatKeys(string @in)
  {
    return (IEnumerable<string>) @in.Split('|', StringSplitOptions.None);
  }

  public string GetStringValue(CampaignStats stats, float value)
  {
    if ((double) value <= 0.0)
      return "-";
    string stringValue;
    switch (this.type)
    {
      case GameStatData.Type.Time:
        stringValue = GameStatData.FromSeconds(value);
        break;
      case GameStatData.Type.RandomKey:
        stringValue = this.GetRandomStringValue(stats);
        break;
      case GameStatData.Type.Rate:
        stringValue = (value * 100f).ToString("0") + "%";
        break;
      case GameStatData.Type.BestTime:
        stringValue = GameStatData.FromSeconds(value);
        break;
      default:
        stringValue = Mathf.RoundToInt(value).ToString("N0");
        break;
    }
    return stringValue;
  }

  public string GetRandomStringValue(CampaignStats stats)
  {
    Dictionary<string, int> dictionary = stats.Get(this.statName);
    if (dictionary == null)
      return "-";
    string randomStringValue = "-";
    int num = 0;
    foreach (KeyValuePair<string, int> keyValuePair in dictionary)
    {
      if (keyValuePair.Value >= num)
      {
        num = keyValuePair.Value;
        randomStringValue = keyValuePair.Key;
      }
    }
    return randomStringValue;
  }

  public static string FromSeconds(float seconds)
  {
    TimeSpan timeSpan = TimeSpan.FromSeconds((double) seconds);
    return string.Format("{0:00}:{1:00}:{2:00}", (object) (int) timeSpan.TotalHours, (object) timeSpan.Minutes, (object) timeSpan.Seconds);
  }

  public enum Type
  {
    Normal,
    Best,
    BestAny,
    Count,
    Time,
    RandomKey,
    Rate,
    BestTime,
  }
}
