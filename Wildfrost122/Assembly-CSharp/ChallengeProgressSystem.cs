﻿// Decompiled with JetBrains decompiler
// Type: ChallengeProgressSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Events;

#nullable disable
public class ChallengeProgressSystem : GameSystem
{
  private static ChallengeProgressSystem instance;
  public List<ChallengeProgress> progress;
  private bool saveRequired;

  private void Awake() => ChallengeProgressSystem.instance = this;

  private void OnEnable()
  {
    global::Events.OnCampaignSaved += new UnityAction(this.CheckSave);
    global::Events.OnCampaignLoaded += new UnityAction(this.Load);
    ChallengeProgressSystem.instance.progress = ChallengeProgressSystem.LoadProgress();
  }

  private void OnDisable()
  {
    global::Events.OnCampaignSaved -= new UnityAction(this.CheckSave);
    global::Events.OnCampaignLoaded -= new UnityAction(this.Load);
  }

  public static int GetProgress(string challengeName)
  {
    List<ChallengeProgress> progress = ChallengeProgressSystem.instance.progress;
    ChallengeProgress challengeProgress = progress != null ? progress.FirstOrDefault<ChallengeProgress>((Func<ChallengeProgress, bool>) (a => a.challengeName == challengeName)) : (ChallengeProgress) null;
    return challengeProgress == null ? 0 : challengeProgress.currentValue;
  }

  public static void AddProgress(string challengeName, int add)
  {
    ChallengeProgress challengeProgress1 = ChallengeProgressSystem.instance.progress.FirstOrDefault<ChallengeProgress>((Func<ChallengeProgress, bool>) (a => a.challengeName == challengeName));
    if (challengeProgress1 == null)
    {
      List<ChallengeProgress> source = SaveSystem.LoadProgressData<List<ChallengeProgress>>("challengeProgress", (List<ChallengeProgress>) null);
      ChallengeProgress challengeProgress2 = source != null ? source.FirstOrDefault<ChallengeProgress>((Func<ChallengeProgress, bool>) (a => a.challengeName == challengeName)) : (ChallengeProgress) null;
      challengeProgress1 = challengeProgress2 == null ? new ChallengeProgress(challengeName, 0) : new ChallengeProgress(challengeName, challengeProgress2.currentValue);
      ChallengeProgressSystem.instance.progress.Add(challengeProgress1);
    }
    ChallengeProgressSystem.instance.saveRequired = true;
    challengeProgress1.currentValue += add;
  }

  private static List<ChallengeProgress> LoadProgress()
  {
    List<ChallengeProgress> challengeProgressList = SaveSystem.LoadProgressData<List<ChallengeProgress>>("challengeProgress", new List<ChallengeProgress>());
    foreach (ChallengeProgress challengeProgress in challengeProgressList)
      challengeProgress.originalValue = challengeProgress.currentValue;
    return challengeProgressList;
  }

  private void CheckSave()
  {
    if (!this.saveRequired)
      return;
    if (Campaign.Data.GameMode.doSave)
      SaveSystem.SaveCampaignData<List<ChallengeProgress>>(Campaign.Data.GameMode, "challengeProgress", this.progress);
    SaveSystem.SaveProgressData<List<ChallengeProgress>>("challengeProgress", this.progress);
    this.saveRequired = false;
  }

  private void Load()
  {
    this.progress = ChallengeProgressSystem.LoadProgress();
    List<ChallengeProgress> challengeProgressList = SaveSystem.LoadCampaignData<List<ChallengeProgress>>(Campaign.Data.GameMode, "challengeProgress", (List<ChallengeProgress>) null);
    if (challengeProgressList == null)
      return;
    foreach (ChallengeProgress challengeProgress1 in challengeProgressList)
    {
      ChallengeProgress inCampaignData = challengeProgress1;
      ChallengeProgress challengeProgress2 = this.progress.FirstOrDefault<ChallengeProgress>((Func<ChallengeProgress, bool>) (a => a.challengeName == inCampaignData.challengeName));
      if (challengeProgress2 != null && inCampaignData.currentValue >= challengeProgress2.currentValue)
        challengeProgress2.originalValue = inCampaignData.originalValue;
    }
  }
}
