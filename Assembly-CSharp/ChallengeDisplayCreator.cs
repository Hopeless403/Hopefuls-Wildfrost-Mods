// Decompiled with JetBrains decompiler
// Type: ChallengeDisplayCreator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ChallengeDisplayCreator : MonoBehaviour
{
  public ChallengeData challenge;
  [SerializeField]
  private ChallengeProgressDisplay displayPrefab;
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
    ChallengeProgressDisplay challengeProgressDisplay = UnityEngine.Object.Instantiate<ChallengeProgressDisplay>(this.displayPrefab, this.transform);
    challengeProgressDisplay.Assign(this.challenge);
    challengeProgressDisplay.SetFill((float) currentValue, this.challenge.goal);
  }
}
