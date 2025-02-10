// Decompiled with JetBrains decompiler
// Type: CampaignStats
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
[Serializable]
public class CampaignStats
{
  public float time;
  public int hours;
  public Dictionary<string, Dictionary<string, int>> add;
  public Dictionary<string, Dictionary<string, int>> max;

  public void Add(string stat, int value)
  {
    this.Change(stat, value, ref this.add, new Func<int, int, int>(this.Add));
  }

  public void Add(string stat, string key, int value)
  {
    this.Change(stat, key, value, ref this.add, new Func<int, int, int>(this.Add));
  }

  public void Max(string stat, int value)
  {
    this.Change(stat, value, ref this.max, new Func<int, int, int>(this.Max));
  }

  public void Max(string stat, string key, int value)
  {
    this.Change(stat, key, value, ref this.max, new Func<int, int, int>(this.Max));
  }

  public void Min(string stat, int value)
  {
    this.Change(stat, value, ref this.max, new Func<int, int, int>(this.Min));
  }

  public void Min(string stat, string key, int value)
  {
    this.Change(stat, key, value, ref this.max, new Func<int, int, int>(this.Min));
  }

  public void Change(
    string stat,
    int value,
    ref Dictionary<string, Dictionary<string, int>> values,
    Func<int, int, int> action)
  {
    this.Change(stat, "", value, ref values, action);
  }

  public void Change(
    string stat,
    string key,
    int value,
    ref Dictionary<string, Dictionary<string, int>> values,
    Func<int, int, int> action)
  {
    int oldValue = 0;
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
    int newValue;
    if (dictionary1.ContainsKey(key))
    {
      oldValue = dictionary1[key];
      newValue = action(oldValue, value);
    }
    else
      newValue = value;
    dictionary1[key] = newValue;
    if (oldValue == newValue)
      return;
    Events.InvokeStatChanged(stat, key, oldValue, newValue);
  }

  public int Add(int value, int add) => value + add;

  public int Max(int value, int max) => Mathf.Max(value, max);

  public int Min(int value, int min) => Mathf.Min(value, min);

  public Dictionary<string, int> Get(
    string stat,
    Dictionary<string, Dictionary<string, int>> source)
  {
    if (source != null && source.ContainsKey(stat))
    {
      Dictionary<string, int> dictionary = source[stat];
      if (dictionary != null)
        return dictionary;
    }
    return (Dictionary<string, int>) null;
  }

  public Dictionary<string, int> Get(string stat) => this.Get(stat, this.add);

  public int Get(string stat, int defaultValue)
  {
    Dictionary<string, int> dictionary = this.Get(stat, this.add);
    return dictionary == null || !dictionary.ContainsKey("") ? defaultValue : dictionary[""];
  }

  public int Get(string stat, string key, int defaultValue)
  {
    Dictionary<string, int> dictionary = this.Get(stat, this.add);
    return dictionary == null || !dictionary.ContainsKey(key) ? defaultValue : dictionary[key];
  }

  public int Best(string stat, int defaultValue)
  {
    Dictionary<string, int> dictionary = this.Get(stat, this.max);
    return dictionary == null ? defaultValue : dictionary.Values.Prepend<int>(0).Max();
  }

  public int Best(string stat, string key, int defaultValue)
  {
    Dictionary<string, int> dictionary = this.Get(stat, this.max);
    return dictionary == null || !dictionary.ContainsKey(key) ? defaultValue : dictionary[key];
  }

  public int Count(string stat)
  {
    Dictionary<string, int> dictionary = this.Get(stat, this.add);
    return dictionary == null ? 0 : dictionary.Values.Sum();
  }

  public void Set(string stat, int value) => this.Set(this.add, stat, "", value);

  public void Set(string stat, string key, int value) => this.Set(this.add, stat, key, value);

  public void SetBest(string stat, int value) => this.Set(this.max, stat, "", value);

  public void SetBest(string stat, string key, int value) => this.Set(this.max, stat, key, value);

  public void Set(
    Dictionary<string, Dictionary<string, int>> dict,
    string stat,
    string key,
    int value)
  {
    if (!dict.ContainsKey(stat))
      dict[stat] = new Dictionary<string, int>()
      {
        {
          key,
          value
        }
      };
    else
      dict[stat][key] = value;
  }

  public void Delete(string stat) => this.add.Remove(stat);

  public void DeleteBest(string stat) => this.max.Remove(stat);

  public CampaignStats Clone()
  {
    CampaignStats campaignStats = new CampaignStats()
    {
      time = this.time,
      hours = this.hours
    };
    if (this.add != null)
      campaignStats.add = this.add.ToDictionary<KeyValuePair<string, Dictionary<string, int>>, string, Dictionary<string, int>>((Func<KeyValuePair<string, Dictionary<string, int>>, string>) (a => a.Key), (Func<KeyValuePair<string, Dictionary<string, int>>, Dictionary<string, int>>) (a => a.Value.ToDictionary<KeyValuePair<string, int>, string, int>((Func<KeyValuePair<string, int>, string>) (b => b.Key), (Func<KeyValuePair<string, int>, int>) (b => b.Value))));
    if (this.max != null)
      campaignStats.max = this.max.ToDictionary<KeyValuePair<string, Dictionary<string, int>>, string, Dictionary<string, int>>((Func<KeyValuePair<string, Dictionary<string, int>>, string>) (a => a.Key), (Func<KeyValuePair<string, Dictionary<string, int>>, Dictionary<string, int>>) (a => a.Value.ToDictionary<KeyValuePair<string, int>, string, int>((Func<KeyValuePair<string, int>, string>) (b => b.Key), (Func<KeyValuePair<string, int>, int>) (b => b.Value))));
    return campaignStats;
  }
}
