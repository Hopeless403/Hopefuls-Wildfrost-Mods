// Decompiled with JetBrains decompiler
// Type: DefeatSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using FMODUnity;
using System;
using System.Collections;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DefeatSequence : MonoBehaviour
{
  [SerializeField]
  public EventReference music;
  [SerializeField]
  public float startDelay;
  [SerializeField]
  public GameObject restartButton;
  [SerializeField]
  public GameObject scoresButton;
  [SerializeField]
  public GameObject defeatLayout;
  [SerializeField]
  public GameObject winLayout;
  [SerializeField]
  public GameObject vanquishedLayout;
  [SerializeField]
  public GameObject statsLayout;
  [SerializeField]
  public GameObject leaderDisplayLayout;
  [SerializeField]
  public GameObject challengeLayout;
  [SerializeField]
  public GameObject progressLayout;
  [SerializeField]
  public GameObject scoresLayout;
  [SerializeField]
  public GameObject buttonsLayout;
  [SerializeField]
  public LayoutLink[] titlePanels;
  [SerializeField]
  public ChallengeProgressSequence challengeSequence;
  [SerializeField]
  public MetaprogressSequence progressSequence;
  [SerializeField]
  public ScoreSequence scoreSequence;
  [SerializeField]
  public string endCreditsScene = "CreditsEnd";
  [SerializeField]
  public WinMusic winMusic;
  [Header("Temporary win help panel")]
  [SerializeField]
  public HelpPanelShower gameWinHelp;
  [SerializeField]
  public ParticleSystem gameWinPS;
  public bool active;

  public IEnumerator Start()
  {
    bool flag = (UnityEngine.Object) References.Battle.winner == (UnityEngine.Object) References.Battle.player;
    if (!flag)
      MusicSystem.StartMusic(this.music);
    this.active = true;
    this.restartButton.SetActive(!flag && Campaign.Data.GameMode.canRestart);
    this.scoresButton.SetActive(Campaign.Data.GameMode.submitScore);
    yield return (object) this.Routine();
  }

  public IEnumerator Routine()
  {
    DefeatSequence defeatSequence = this;
    yield return (object) new WaitForSeconds(defeatSequence.startDelay);
    foreach (LayoutLink titlePanel in defeatSequence.titlePanels)
      titlePanel.offset = new Vector3(0.0f, 0.0f, -4f);
    if ((UnityEngine.Object) References.Battle.winner == (UnityEngine.Object) References.Battle.player)
    {
      if (SaveSystem.LoadCampaignData<bool>(Campaign.Data.GameMode, "trueWin", false))
      {
        yield return (object) SceneManager.Load(defeatSequence.endCreditsScene, SceneType.Temporary);
        yield return (object) SceneManager.WaitUntilUnloaded(defeatSequence.endCreditsScene);
      }
      defeatSequence.winMusic.Play();
      defeatSequence.gameWinPS.Play();
      if (SaveSystem.LoadCampaignData<bool>(Campaign.Data.GameMode, "trueWin", false))
        defeatSequence.vanquishedLayout.SetActive(true);
      else
        defeatSequence.winLayout.SetActive(true);
    }
    else
      defeatSequence.defeatLayout.SetActive(true);
    yield return (object) new WaitForSeconds(1f);
    foreach (LayoutLink titlePanel in defeatSequence.titlePanels)
      titlePanel.offset = Vector3.zero;
    if (Campaign.Data.GameMode.showStats)
    {
      defeatSequence.statsLayout.SetActive(true);
      defeatSequence.leaderDisplayLayout.SetActive(true);
    }
    ChallengeProgressSystem objectOfType = UnityEngine.Object.FindObjectOfType<ChallengeProgressSystem>();
    if (objectOfType != null && objectOfType.progress != null && objectOfType.progress.Count<ChallengeProgress>((Func<ChallengeProgress, bool>) (a => a.currentValue > a.originalValue)) > 0)
    {
      defeatSequence.challengeLayout.SetActive(true);
      yield return (object) new WaitForSeconds(1f);
      yield return (object) new WaitUntil(new Func<bool>(defeatSequence.\u003CRoutine\u003Eb__23_1));
    }
    global::Routine.Clump clump = new global::Routine.Clump();
    if (Campaign.Data.GameMode.submitScore)
    {
      defeatSequence.scoresLayout.SetActive(true);
      yield return (object) new WaitForSeconds(1f);
      clump.Add((IEnumerator) new WaitUntil(new Func<bool>(defeatSequence.\u003CRoutine\u003Eb__23_2)));
    }
    yield return (object) clump.WaitForEnd();
    defeatSequence.buttonsLayout.SetActive(true);
  }

  public void GoTo(string sceneName)
  {
    if (!this.active)
      return;
    this.active = false;
    global::Routine routine = new global::Routine(Sequences.EndCampaign(sceneName));
  }

  public void QuickRestart()
  {
    if (!this.active)
      return;
    Campaign.Data = new CampaignData(Campaign.Data.GameMode);
    global::Routine routine = new global::Routine(Sequences.EndCampaign("CharacterSelect"));
    this.active = false;
  }

  public void Exit()
  {
    if (!this.active)
      return;
    this.active = false;
    if ((UnityEngine.Object) References.Campaign != (UnityEngine.Object) null)
      References.Campaign.Final();
    GameManager.Quit();
  }

  [CompilerGenerated]
  public bool \u003CRoutine\u003Eb__23_1() => !this.challengeSequence.running;

  [CompilerGenerated]
  public bool \u003CRoutine\u003Eb__23_2() => !this.scoreSequence.running;
}
