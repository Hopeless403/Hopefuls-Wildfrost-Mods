// Decompiled with JetBrains decompiler
// Type: NexFrequencyChecker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections.Generic;
using UnityEngine;

public static class NexFrequencyChecker
{
  public static readonly Dictionary<NexFrequencyChecker.Function, NexFrequencyChecker.Profile> lookup = new Dictionary<NexFrequencyChecker.Function, NexFrequencyChecker.Profile>()
  {
    {
      NexFrequencyChecker.Function.PutScore,
      new NexFrequencyChecker.Profile(10, 60f)
    },
    {
      NexFrequencyChecker.Function.GetCommonData,
      new NexFrequencyChecker.Profile(10, 60f)
    },
    {
      NexFrequencyChecker.Function.PutCommonData,
      new NexFrequencyChecker.Profile(10, 60f)
    },
    {
      NexFrequencyChecker.Function.DeleteCommonData,
      new NexFrequencyChecker.Profile(10, 60f)
    },
    {
      NexFrequencyChecker.Function.GetRanking,
      new NexFrequencyChecker.Profile(20, 60f)
    },
    {
      NexFrequencyChecker.Function.GetCategorySetting,
      new NexFrequencyChecker.Profile(20, 60f)
    },
    {
      NexFrequencyChecker.Function.GetRankingChart,
      new NexFrequencyChecker.Profile(20, 60f)
    },
    {
      NexFrequencyChecker.Function.GetEstimatedScoreRank,
      new NexFrequencyChecker.Profile(20, 60f)
    }
  };

  public static bool Check(NexFrequencyChecker.Function functionName)
  {
    NexFrequencyChecker.Profile profile;
    if (!NexFrequencyChecker.lookup.TryGetValue(functionName, out profile) || !profile.Check())
      return false;
    profile.LogRequest();
    return true;
  }

  public enum Function
  {
    PutScore,
    GetCommonData,
    PutCommonData,
    DeleteCommonData,
    GetRanking,
    GetCategorySetting,
    GetRankingChart,
    GetEstimatedScoreRank,
  }

  public readonly struct Profile
  {
    public readonly int allowedRequests;
    public readonly float cooldownSeconds;
    public readonly List<float> requests;

    public Profile(int allowedRequests, float cooldownSeconds)
    {
      this.allowedRequests = allowedRequests;
      this.cooldownSeconds = cooldownSeconds;
      this.requests = new List<float>();
    }

    public bool Check()
    {
      this.RemoveInactive(Time.realtimeSinceStartup);
      return this.requests.Count < this.allowedRequests;
    }

    public void RemoveInactive(float time)
    {
      float num = time - this.cooldownSeconds;
      for (int index = this.requests.Count - 1; index >= 0; --index)
      {
        if ((double) this.requests[index] < (double) num)
          this.requests.RemoveAt(index);
      }
    }

    public void LogRequest() => this.requests.Add(Time.realtimeSinceStartup);
  }
}
