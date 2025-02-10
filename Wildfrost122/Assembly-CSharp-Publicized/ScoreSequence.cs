// Decompiled with JetBrains decompiler
// Type: ScoreSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using FMODUnity;
using Steamworks.Data;
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Localization;

#nullable disable
public class ScoreSequence : MonoBehaviour
{
  [SerializeField]
  public TMP_Text timeText;
  [SerializeField]
  public TMP_Text timeScoreText;
  [SerializeField]
  public TMP_Text battlesText;
  [SerializeField]
  public TMP_Text battlesScoreText;
  [SerializeField]
  public TMP_Text goldText;
  [SerializeField]
  public TMP_Text goldScoreText;
  [SerializeField]
  public TMP_Text totalScoreText;
  [SerializeField]
  public TMP_Text globalRankText;
  [SerializeField]
  public LocalizedString totalStringRef;
  [SerializeField]
  public LocalizedString submittingStringRef;
  [SerializeField]
  public LocalizedString failedToSubmitStringRef;
  [SerializeField]
  public LocalizedString globalRankStringRef;
  [Header("SFX")]
  [SerializeField]
  public EventReference countSfx;
  [SerializeField]
  public EventReference countFinishSfx;
  [SerializeField]
  public EventReference countFinishFirstSfx;
  [CompilerGenerated]
  public bool \u003Crunning\u003Ek__BackingField;

  public bool running
  {
    get => this.\u003Crunning\u003Ek__BackingField;
    set => this.\u003Crunning\u003Ek__BackingField = value;
  }

  public IEnumerator Start()
  {
    yield return (object) this.Sequence();
  }

  public void OnDisable() => this.StopAllCoroutines();

  public IEnumerator Sequence()
  {
    this.running = true;
    this.totalScoreText.gameObject.SetActive(false);
    this.globalRankText.gameObject.SetActive(false);
    int submittedTime = ScoreSubmitSystem.SubmittedTime;
    int gold = ScoreSubmitSystem.SubmittedGold;
    int battlesWon = ScoreSubmitSystem.SubmittedBattlesWon;
    this.timeText.text = TimeSpan.FromSeconds((double) submittedTime).ToString();
    this.battlesText.text = battlesWon.ToString();
    this.goldText.text = gold.ToString();
    this.timeScoreText.text = "";
    this.battlesScoreText.text = "";
    this.goldScoreText.text = "";
    int scoreFromTime = ScoreSubmitSystem.GetScoreFromTime(References.Campaign.result == Campaign.Result.Win, submittedTime);
    Debug.Log((object) string.Format("Time Taken: {0} = {1} points", (object) this.timeText.text, (object) scoreFromTime));
    yield return (object) this.CountScoreUp(this.timeScoreText, "+{0}", "<#f40>{0}", scoreFromTime);
    int scoreFromBattlesWon = ScoreSubmitSystem.GetScoreFromBattlesWon(battlesWon);
    Debug.Log((object) string.Format("Battles Won: {0} = {1} points", (object) this.battlesText.text, (object) scoreFromBattlesWon));
    yield return (object) this.CountScoreUp(this.battlesScoreText, "+{0}", "<#f40>{0}", scoreFromBattlesWon);
    int scoreFromGold = ScoreSubmitSystem.GetScoreFromGold(gold);
    Debug.Log((object) string.Format("Blings: {0} = {1} points", (object) this.goldText.text, (object) scoreFromGold));
    yield return (object) this.CountScoreUp(this.goldScoreText, "+{0}", "<#f40>{0}", scoreFromGold);
    this.totalScoreText.gameObject.SetActive(true);
    int submittedScore = ScoreSubmitSystem.SubmittedScore;
    Debug.Log((object) string.Format("Final Score: {0}", (object) submittedScore));
    string localizedString = this.totalStringRef.GetLocalizedString();
    yield return (object) this.CountScoreUp(this.totalScoreText, string.Format(localizedString, (object) "<#ff0>{0}"), string.Format(localizedString, (object) "<#f40>{0}"), submittedScore);
    if (!this.countFinishSfx.IsNull)
      SfxSystem.OneShot(this.countFinishSfx);
    LeaderboardUpdate? result = ScoreSubmitSystem.result;
    if (result.HasValue && result.GetValueOrDefault().Changed)
    {
      result = ScoreSubmitSystem.result;
      int newGlobalRank = result.Value.NewGlobalRank;
      if (newGlobalRank > 0)
      {
        Debug.Log((object) string.Format("Global Rank: {0}", (object) newGlobalRank));
        this.globalRankText.gameObject.SetActive(true);
        this.globalRankText.text = string.Format(this.globalRankStringRef.GetLocalizedString(), (object) newGlobalRank);
        if (newGlobalRank == 1 && !this.countFinishFirstSfx.IsNull)
          SfxSystem.OneShot(this.countFinishFirstSfx);
      }
    }
    this.running = false;
  }

  public IEnumerator SetSubmitScoreText()
  {
    this.globalRankText.gameObject.SetActive(true);
    if (ScoreSubmitSystem.status == ScoreSubmitSystem.Status.Submitting)
    {
      string text = this.submittingStringRef.GetLocalizedString();
      this.globalRankText.text = text;
      float t = 1f;
      string dots = "";
      yield return (object) null;
      while (ScoreSubmitSystem.status == ScoreSubmitSystem.Status.Submitting)
      {
        t -= Time.deltaTime;
        if ((double) t <= 0.0)
        {
          ++t;
          dots = dots.Length < 3 ? dots + "." : "";
          this.globalRankText.text = text + dots;
        }
        yield return (object) null;
      }
      text = (string) null;
      dots = (string) null;
    }
    switch (ScoreSubmitSystem.status)
    {
      case ScoreSubmitSystem.Status.Failed:
        this.globalRankText.text = this.failedToSubmitStringRef.GetLocalizedString();
        break;
      case ScoreSubmitSystem.Status.Success:
        int? playerRank = ScoreSubmitSystem.playerRank;
        if (playerRank.HasValue)
        {
          playerRank = ScoreSubmitSystem.playerRank;
          int num = playerRank.Value;
          Debug.Log((object) string.Format("Global Rank: {0}", (object) num));
          this.globalRankText.text = string.Format(this.globalRankStringRef.GetLocalizedString(), (object) num);
          if (num != 1 || this.countFinishFirstSfx.IsNull)
            break;
          SfxSystem.OneShot(this.countFinishFirstSfx);
          break;
        }
        this.globalRankText.gameObject.SetActive(false);
        break;
    }
  }

  public IEnumerator CountScoreUp(
    TMP_Text element,
    string positiveFormat,
    string negativeFormat,
    int toScore,
    int fromScore = 0)
  {
    int v = fromScore;
    element.text = ScoreSequence.Format(positiveFormat, negativeFormat, fromScore);
    float time = Mathf.Clamp((float) toScore / 100f, 1f, 3f);
    float t = 0.0f;
    yield return (object) null;
    while ((double) t < (double) time)
    {
      t += Time.deltaTime;
      int num = fromScore + Mathf.RoundToInt(Mathf.Min(1f, t / time) * (float) (toScore - fromScore));
      element.text = ScoreSequence.Format(positiveFormat, negativeFormat, num);
      if (v != num && !this.countSfx.IsNull)
        SfxSystem.OneShot(this.countSfx);
      v = num;
      yield return (object) null;
    }
  }

  public static string Format(string positive, string negative, int value)
  {
    return value < 0 ? string.Format(negative, (object) value) : string.Format(positive, (object) value);
  }
}
