// Decompiled with JetBrains decompiler
// Type: LeaderboardsPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using Steamworks;
using Steamworks.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaderboardsPanel : MonoBehaviour
{
  [SerializeField]
  public GameObject loading;
  [SerializeField]
  public GameObject noEntries;
  [SerializeField]
  public GameObject noConnection;
  [SerializeField]
  public GameObject tooManyRequests;
  [SerializeField]
  public Transform entriesGroup;
  [SerializeField]
  public DateTextSetter dateTextSetter;
  [SerializeField]
  public LeaderboardsFetcher fetcher;
  [SerializeField]
  public LeaderboardsEntry entryPrefab;
  [SerializeField]
  public bool fetchEveryTime = true;
  [SerializeField]
  public int entriesPerPage = 10;
  [SerializeField]
  public LeaderboardsFetcher.Type type;
  [Header("Buttons")]
  [SerializeField]
  public ButtonAnimator globalButton;
  [SerializeField]
  public ButtonAnimator friendsButton;
  [SerializeField]
  public ButtonAnimator playerRankButton;
  [SerializeField]
  public ButtonAnimator nextPageButton;
  [SerializeField]
  public ButtonAnimator prePageButton;
  [SerializeField]
  public ButtonAnimator nextDayButton;
  [SerializeField]
  public ButtonAnimator preDayButton;
  public int page;
  public int dayOffset;
  public int playerRankPage;
  public const int maxDayOffset = 100;
  public int maxPage = 9999;
  public bool fetched;

  public bool fetch => !this.fetched || this.fetchEveryTime;

  public void OnEnable()
  {
    this.page = 0;
    this.dayOffset = 0;
    this.nextDayButton.interactable = false;
    if (!this.fetch)
      return;
    this.Clear();
    this.StartCoroutine(this.Fetch(true));
  }

  public void OnDisable() => this.StopAllCoroutines();

  public void Clear()
  {
    this.noEntries.SetActive(false);
    this.noConnection.SetActive(false);
    this.tooManyRequests.SetActive(false);
    this.entriesGroup.DestroyAllChildren();
    this.prePageButton.interactable = false;
    this.nextPageButton.interactable = false;
  }

  public IEnumerator Fetch(bool aroundPlayer)
  {
    yield break;
  }

  public void Populate(IReadOnlyCollection<LeaderboardEntry> entries)
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

  public void SetDayOffset(int value)
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

  public void SetPage(int value)
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

  public void Refetch(bool aroundPlayer)
  {
    this.Clear();
    this.StopAllCoroutines();
    this.StartCoroutine(this.Fetch(aroundPlayer));
  }

  public static string SecondsToTimeString(int seconds)
  {
    double f = (double) seconds / 60.0 / 60.0;
    int num1 = Mathf.FloorToInt((float) f);
    int num2 = Mathf.FloorToInt((float) ((f - (double) num1) * 60.0));
    return num1 <= 0 ? string.Format("{0}m", (object) num2) : string.Format("{0}h {1}m", (object) num1, (object) num2);
  }
}
