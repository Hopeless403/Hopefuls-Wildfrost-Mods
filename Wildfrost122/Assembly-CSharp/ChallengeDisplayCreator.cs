﻿// Decompiled with JetBrains decompiler
// Type: ChallengeDisplayCreator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
public class ChallengeDisplayCreator : MonoBehaviour
{
  public ChallengeData challenge;
  [SerializeField]
  private ChallengeProgressDisplay displayPrefab;
  [SerializeField]
  private Transform displayParent;
  [SerializeField]
  private bool checkOnEnable = true;

  private void OnEnable()
  {
    if (!this.checkOnEnable)
      return;
    this.Check();
  }

  public void Check()
  {
    if (!(bool) (UnityEngine.Object) this.challenge || !this.challenge.reward.IsActive || !(bool) (UnityEngine.Object) this.displayPrefab)
      return;
    List<string> stringList = SaveSystem.LoadProgressData<List<string>>("completedChallenges", (List<string>) null) ?? new List<string>();
    if (stringList.Contains(this.challenge.name))
      return;
    foreach (ChallengeData require in this.challenge.requires)
    {
      if (!stringList.Contains(require.name))
        return;
    }
    List<ChallengeProgress> source = SaveSystem.LoadProgressData<List<ChallengeProgress>>("challengeProgress", (List<ChallengeProgress>) null);
    ChallengeProgress challengeProgress = source != null ? source.FirstOrDefault<ChallengeProgress>((Func<ChallengeProgress, bool>) (a => a.challengeName == this.challenge.name)) : (ChallengeProgress) null;
    int currentValue = challengeProgress != null ? challengeProgress.currentValue : 0;
    ChallengeProgressDisplay challengeProgressDisplay = UnityEngine.Object.Instantiate<ChallengeProgressDisplay>(this.displayPrefab, (bool) (UnityEngine.Object) this.displayParent ? this.displayParent : this.transform);
    challengeProgressDisplay.Assign(this.challenge);
    challengeProgressDisplay.SetFill((float) currentValue, this.challenge.goal);
  }
}
