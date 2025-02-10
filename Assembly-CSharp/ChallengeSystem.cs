// Decompiled with JetBrains decompiler
// Type: ChallengeSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Events;

public class ChallengeSystem : GameSystem
{
  public List<ChallengeData> activeChallenges;
  public List<ChallengeData> saveRequired;

  private void OnEnable()
  {
    List<string> stringList = SaveSystem.LoadProgressData<List<string>>("completedChallenges", (List<string>) null) ?? new List<string>();
    this.activeChallenges = new List<ChallengeData>();
    foreach (ChallengeData allChallenge in ChallengeSystem.GetAllChallenges())
    {
      if (!stringList.Contains(allChallenge.name))
      {
        bool flag = true;
        foreach (ChallengeData require in allChallenge.requires)
        {
          if (!stringList.Contains(require.name))
          {
            flag = false;
            break;
          }
        }
        if (flag)
          this.activeChallenges.Add(allChallenge);
      }
    }
    global::Events.OnStatChanged += new UnityAction<string, string, int, int>(this.StatChanged);
    global::Events.OnOverallStatsSaved += new UnityAction<CampaignStats>(this.OverallStatsChanged);
    global::Events.OnCampaignSaved += new UnityAction(this.CheckSave);
  }

  private void OnDisable()
  {
    global::Events.OnStatChanged -= new UnityAction<string, string, int, int>(this.StatChanged);
    global::Events.OnOverallStatsSaved -= new UnityAction<CampaignStats>(this.OverallStatsChanged);
    global::Events.OnCampaignSaved -= new UnityAction(this.CheckSave);
  }

  private void StatChanged(string stat, string key, int oldValue, int newValue)
  {
    for (int index = this.activeChallenges.Count - 1; index >= 0; --index)
    {
      ChallengeData activeChallenge = this.activeChallenges[index];
      ChallengeListener listener = activeChallenge.listener;
      if (listener.checkType == ChallengeListener.CheckType.MidRun && listener.Check(stat, key))
      {
        listener.Set(activeChallenge.name, oldValue, newValue);
        if (ChallengeProgressSystem.GetProgress(activeChallenge.name) >= activeChallenge.goal)
        {
          this.activeChallenges.RemoveAt(index);
          this.saveRequired.Add(activeChallenge);
        }
      }
    }
  }

  private void OverallStatsChanged(CampaignStats stats)
  {
    bool flag = false;
    for (int index = this.activeChallenges.Count - 1; index >= 0; --index)
    {
      ChallengeData activeChallenge = this.activeChallenges[index];
      ChallengeListener listener = activeChallenge.listener;
      if (listener.checkType == ChallengeListener.CheckType.EndOfRun && listener.CheckComplete(stats))
      {
        ChallengeProgressSystem.AddProgress(activeChallenge.name, 1);
        if (ChallengeProgressSystem.GetProgress(activeChallenge.name) >= activeChallenge.goal)
        {
          this.activeChallenges.RemoveAt(index);
          this.saveRequired.Add(activeChallenge);
          flag = true;
        }
      }
    }
    if (!flag)
      return;
    this.CheckSave();
  }

  private void CheckSave()
  {
    if (this.saveRequired.Count <= 0)
      return;
    List<string> stringList1 = SaveSystem.LoadProgressData<List<string>>("completedChallenges", (List<string>) null) ?? new List<string>();
    List<string> stringList2 = SaveSystem.LoadProgressData<List<string>>("townNew", (List<string>) null) ?? new List<string>();
    List<string> stringList3 = SaveSystem.LoadProgressData<List<string>>("unlocked", (List<string>) null) ?? new List<string>();
    foreach (ChallengeData challengeData in this.saveRequired)
    {
      stringList1.Add(challengeData.name);
      stringList2.Add(challengeData.reward.name);
      stringList3.Add(challengeData.reward.name);
      global::Events.InvokeChallengeCompletedSaved(challengeData);
    }
    SaveSystem.SaveProgressData<List<string>>("completedChallenges", stringList1);
    SaveSystem.SaveProgressData<List<string>>("townNew", stringList2);
    SaveSystem.SaveProgressData<List<string>>("unlocked", stringList3);
    this.saveRequired.Clear();
  }

  public static IEnumerable<ChallengeData> GetAllChallenges() => AddressableLoader.GetGroup<ChallengeData>("ChallengeData").Where<ChallengeData>((Func<ChallengeData, bool>) (a => a.reward.IsActive));
}
