// Decompiled with JetBrains decompiler
// Type: LeaderboardsPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using Steamworks;
using Steamworks.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaderboardsPanel : MonoBehaviour
{
  [SerializeField]
  private GameObject loading;
  [SerializeField]
  private GameObject noEntries;
  [SerializeField]
  private GameObject noConnection;
  [SerializeField]
  private GameObject tooManyRequests;
  [SerializeField]
  private Transform entriesGroup;
  [SerializeField]
  private DateTextSetter dateTextSetter;
  [SerializeField]
  private LeaderboardsFetcher fetcher;
  [SerializeField]
  private LeaderboardsEntry entryPrefab;
  [SerializeField]
  private bool fetchEveryTime = true;
  [SerializeField]
  private int entriesPerPage = 10;
  [SerializeField]
  private LeaderboardsFetcher.Type type;
  [Header("Buttons")]
  [SerializeField]
  private ButtonAnimator globalButton;
  [SerializeField]
  private ButtonAnimator friendsButton;
  [SerializeField]
  private ButtonAnimator playerRankButton;
  [SerializeField]
  private ButtonAnimator nextPageButton;
  [SerializeField]
  private ButtonAnimator prePageButton;
  [SerializeField]
  private ButtonAnimator nextDayButton;
  [SerializeField]
  private ButtonAnimator preDayButton;
  private int page;
  private int dayOffset;
  private int playerRankPage;
  private const int maxDayOffset = 100;
  private int maxPage = 9999;
  private bool fetched;

  private bool fetch => !this.fetched || this.fetchEveryTime;

  private void OnEnable()
  {
    this.page = 0;
    this.dayOffset = 0;
    this.nextDayButton.interactable = false;
    if (!this.fetch)
      return;
    this.Clear();
    this.StartCoroutine(this.Fetch(true));
  }

  private void OnDisable() => this.StopAllCoroutines();

  private void Clear()
  {
    this.noEntries.SetActive(false);
    this.noConnection.SetActive(false);
    this.tooManyRequests.SetActive(false);
    this.entriesGroup.DestroyAllChildren();
    this.prePageButton.interactable = false;
    this.nextPageButton.interactable = false;
  }

  private IEnumerator Fetch(bool aroundPlayer)
  {
    yield break;
  }

  private void Populate(IReadOnlyCollection<LeaderboardEntry> entries)
  {
    bool flag = entries != null && entries.Count > 0;
    this.noEntries.SetActive(!flag);
    if (!flag)
      return;
    foreach (LeaderboardEntry entry in (IEnumerable<LeaderboardEntry>) entries)
    {
      LeaderboardsEntry leaderboardsEntry = UnityEngine.Object.Instantiate<LeaderboardsEntry>(this.entryPrefab, this.entriesGroup);
      Friend user = entry.User;
      int num = user.IsMe ? 1 : 0;
      user = entry.User;
      string name = user.Name;
      int globalRank = entry.GlobalRank;
      // ISSUE: variable of a boxed type
      __Boxed<int> score = (ValueType) entry.Score;
      string timeString = LeaderboardsPanel.SecondsToTimeString(entry.Details[0]);
      leaderboardsEntry.Set(num != 0, name, globalRank, (object) score, timeString);
    }
  }

  public void PreviousDay()
  {
    if (this.dayOffset >= 100)
      return;
    this.SetDayOffset(this.dayOffset + 1);
    this.Refetch(true);
  }

  public void NextDay()
  {
    if (this.dayOffset <= 0)
      return;
    this.SetDayOffset(this.dayOffset - 1);
    this.Refetch(true);
  }

  private void SetDayOffset(int value)
  {
    this.dayOffset = value;
    this.dateTextSetter.SetText(-this.dayOffset);
    this.fetcher.ResetPlayerRank();
    this.maxPage = 0;
    this.type = LeaderboardsFetcher.Type.Global;
    this.SetPage(0);
    this.playerRankButton.interactable = false;
    this.preDayButton.interactable = this.dayOffset < 100;
    this.nextDayButton.interactable = this.dayOffset > 0;
  }

  public void NextPage()
  {
    if (this.page >= this.maxPage)
      return;
    this.SetPage(this.page + 1);
    this.Refetch(false);
  }

  public void PreviousPage()
  {
    if (this.page <= 0)
      return;
    this.SetPage(this.page - 1);
    this.Refetch(false);
  }

  private void SetPage(int value)
  {
    this.page = value;
    this.nextPageButton.interactable = this.page < this.maxPage;
    this.prePageButton.interactable = this.page > 0;
  }

  public void Global()
  {
    if (this.type == LeaderboardsFetcher.Type.Global && this.page <= 0)
      return;
    this.type = LeaderboardsFetcher.Type.Global;
    this.SetPage(0);
    this.Refetch(false);
  }

  public void Friends()
  {
    if (this.type == LeaderboardsFetcher.Type.Friends)
      return;
    this.type = LeaderboardsFetcher.Type.Friends;
    this.SetPage(0);
    this.Refetch(false);
  }

  public void JumpToPlayer()
  {
    if (!this.fetcher.playerHasRank || this.page == this.playerRankPage)
      return;
    this.type = LeaderboardsFetcher.Type.Global;
    this.SetPage(this.playerRankPage);
    this.Refetch(false);
  }

  private void Refetch(bool aroundPlayer)
  {
    this.Clear();
    this.StopAllCoroutines();
    this.StartCoroutine(this.Fetch(aroundPlayer));
  }

  private static string SecondsToTimeString(int seconds)
  {
    double f = (double) seconds / 60.0 / 60.0;
    int num1 = Mathf.FloorToInt((float) f);
    int num2 = Mathf.FloorToInt((float) ((f - (double) num1) * 60.0));
    return num1 <= 0 ? string.Format("{0}m", (object) num2) : string.Format("{0}h {1}m", (object) num1, (object) num2);
  }
}
