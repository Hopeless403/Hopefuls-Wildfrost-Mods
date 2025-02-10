// Decompiled with JetBrains decompiler
// Type: ChallengeListDisplayBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class ChallengeListDisplayBuilder : MonoBehaviour
{
  [SerializeField]
  private Transform tempGroup;
  [SerializeField]
  private Transform finalGroup;
  [SerializeField]
  private AssetReferenceGameObject inProgressPrefab;
  [SerializeField]
  private AssetReferenceGameObject completedPrefab;
  [SerializeField]
  private AssetReferenceGameObject lockedPrefab;
  private readonly CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
  private CancellationToken cancellationToken;
  private Transform[] progress;

  public bool running { get; private set; }

  private void Awake() => this.cancellationToken = this.cancellationTokenSource.Token;

  private async void OnEnable()
  {
    if (this.running)
    {
      this.cancellationTokenSource.Cancel();
      while (this.running)
        await Task.Yield();
    }
    await this.Build();
  }

  private async Task Build()
  {
    this.running = true;
    List<ChallengeData> completedChallenges;
    List<ChallengeData> lockedChallenges;
    List<ChallengeProgress> challengeProgress;
    List<ChallengeData> inProgressChallenges;
    this.GetChallengeLists(out inProgressChallenges, out completedChallenges, out lockedChallenges, out challengeProgress);
    this.finalGroup.DestroyAllChildren();
    this.progress = new Transform[inProgressChallenges.Count + completedChallenges.Count + lockedChallenges.Count];
    int challengeIndex = 0;
    foreach (ChallengeData challengeData in inProgressChallenges)
    {
      ChallengeData challenge = challengeData;
      if (!this.cancellationToken.IsCancellationRequested)
      {
        List<ChallengeProgress> source = challengeProgress;
        ChallengeProgress progressAmount = source != null ? source.FirstOrDefault<ChallengeProgress>((Func<ChallengeProgress, bool>) (a => a.challengeName == challenge.name)) : (ChallengeProgress) null;
        await this.CreateInProgressEntry(challengeIndex++, challenge, progressAmount);
      }
      else
        break;
    }
    foreach (ChallengeData challengeData in completedChallenges)
    {
      if (!this.cancellationToken.IsCancellationRequested)
        await this.CreateCompletedEntry(challengeIndex++, challengeData);
      else
        break;
    }
    foreach (ChallengeData challengeData in lockedChallenges)
    {
      if (!this.cancellationToken.IsCancellationRequested)
        await this.CreateLockedEntry(challengeIndex++);
      else
        break;
    }
    foreach (Transform transform in this.progress)
    {
      if (!this.cancellationToken.IsCancellationRequested)
        transform.SetParent(this.finalGroup);
      else
        break;
    }
    this.progress = (Transform[]) null;
    this.tempGroup.DestroyAllChildren();
    this.running = false;
    completedChallenges = (List<ChallengeData>) null;
    lockedChallenges = (List<ChallengeData>) null;
    challengeProgress = (List<ChallengeProgress>) null;
  }

  private void GetChallengeLists(
    out List<ChallengeData> inProgressChallenges,
    out List<ChallengeData> completedChallenges,
    out List<ChallengeData> lockedChallenges,
    out List<ChallengeProgress> challengeProgress)
  {
    IEnumerable<ChallengeData> allChallenges = ChallengeSystem.GetAllChallenges();
    ChallengeSystem objectOfType1 = UnityEngine.Object.FindObjectOfType<ChallengeSystem>();
    bool flag1 = (UnityEngine.Object) objectOfType1 != (UnityEngine.Object) null;
    List<string> stringList = SaveSystem.LoadProgressData<List<string>>(nameof (completedChallenges)) ?? new List<string>();
    if (flag1)
      stringList.AddRange(objectOfType1.saveRequired.Select<ChallengeData, string>((Func<ChallengeData, string>) (a => a.name)));
    ref List<ChallengeProgress> local = ref challengeProgress;
    ChallengeProgressSystem objectOfType2 = UnityEngine.Object.FindObjectOfType<ChallengeProgressSystem>();
    List<ChallengeProgress> challengeProgressList = objectOfType2 != null ? objectOfType2.progress : SaveSystem.LoadProgressData<List<ChallengeProgress>>(nameof (challengeProgress));
    local = challengeProgressList;
    completedChallenges = new List<ChallengeData>();
    lockedChallenges = new List<ChallengeData>();
    inProgressChallenges = flag1 ? objectOfType1.activeChallenges : new List<ChallengeData>();
    foreach (ChallengeData challengeData in allChallenges)
    {
      ChallengeData challenge = challengeData;
      if (stringList.Contains(challenge.name))
        completedChallenges.Add(challenge);
      else if (flag1)
      {
        if (challenge.hidden || !(bool) (UnityEngine.Object) inProgressChallenges.FirstOrDefault<ChallengeData>((Func<ChallengeData, bool>) (a => a.name == challenge.name)))
          lockedChallenges.Add(challenge);
      }
      else
      {
        bool flag2 = !challenge.hidden;
        if (flag2)
        {
          foreach (ChallengeData require in challenge.requires)
          {
            if (!stringList.Contains(require.name))
            {
              flag2 = false;
              break;
            }
          }
        }
        if (!flag2)
          lockedChallenges.Add(challenge);
        else
          inProgressChallenges.Add(challenge);
      }
    }
  }

  private async Task CreateInProgressEntry(
    int challengeIndex,
    ChallengeData challengeData,
    ChallengeProgress progressAmount)
  {
    GameObject task = await this.inProgressPrefab.InstantiateAsync(this.tempGroup).Task;
    this.progress[challengeIndex] = task.transform;
    if (this.cancellationToken.IsCancellationRequested)
      return;
    ChallengeEntry component = task.GetComponent<ChallengeEntry>();
    if (component == null)
      return;
    component.Assign(challengeData, false);
    ChallengeEntry challengeEntry = component;
    ChallengeProgress challengeProgress = progressAmount;
    int currentValue = challengeProgress != null ? challengeProgress.currentValue : 0;
    challengeEntry.SetProgress(currentValue);
  }

  private async Task CreateCompletedEntry(int challengeIndex, ChallengeData challengeData)
  {
    GameObject task = await this.completedPrefab.InstantiateAsync(this.tempGroup).Task;
    this.progress[challengeIndex] = task.transform;
    if (this.cancellationToken.IsCancellationRequested)
      return;
    task.GetComponent<ChallengeEntry>()?.Assign(challengeData, true);
  }

  private async Task CreateLockedEntry(int challengeIndex)
  {
    GameObject task = await this.lockedPrefab.InstantiateAsync(this.tempGroup).Task;
    this.progress[challengeIndex] = task.transform;
  }
}
