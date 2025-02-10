// Decompiled with JetBrains decompiler
// Type: ChallengeDisplayCreator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ChallengeDisplayCreator : MonoBehaviour
{
  public ChallengeData challenge;
  [SerializeField]
  public ChallengeProgressDisplay displayPrefab;
  [SerializeField]
  public bool checkOnEnable = true;

  public void OnEnable()
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

  [CompilerGenerated]
  public bool \u003CCheck\u003Eb__4_0(ChallengeProgress a) => a.challengeName == this.challenge.name;
}
