// Decompiled with JetBrains decompiler
// Type: DefeatSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using FMODUnity;
using System;
using System.Collections;
using System.Linq;
using UnityEngine;

public class DefeatSequence : MonoBehaviour
{
  [SerializeField]
  private EventReference music;
  [SerializeField]
  private float startDelay;
  [SerializeField]
  private GameObject restartButton;
  [SerializeField]
  private GameObject scoresButton;
  [SerializeField]
  private GameObject defeatLayout;
  [SerializeField]
  private GameObject winLayout;
  [SerializeField]
  private GameObject vanquishedLayout;
  [SerializeField]
  private GameObject statsLayout;
  [SerializeField]
  private GameObject leaderDisplayLayout;
  [SerializeField]
  private GameObject challengeLayout;
  [SerializeField]
  private GameObject progressLayout;
  [SerializeField]
  private GameObject scoresLayout;
  [SerializeField]
  private GameObject buttonsLayout;
  [SerializeField]
  private LayoutLink[] titlePanels;
  [SerializeField]
  private ChallengeProgressSequence challengeSequence;
  [SerializeField]
  private MetaprogressSequence progressSequence;
  [SerializeField]
  private ScoreSequence scoreSequence;
  [SerializeField]
  private string endCreditsScene = "CreditsEnd";
  [SerializeField]
  private WinMusic winMusic;
  [Header("Temporary win help panel")]
  [SerializeField]
  private HelpPanelShower gameWinHelp;
  [SerializeField]
  private ParticleSystem gameWinPS;
  private bool active;

  private IEnumerator Start()
  {
    bool flag = (UnityEngine.Object) References.Battle.winner == (UnityEngine.Object) References.Battle.player;
    if (!flag)
      MusicSystem.StartMusic(this.music);
    this.active = true;
    this.restartButton.SetActive(!flag && Campaign.Data.GameMode.canRestart);
    this.scoresButton.SetActive(Campaign.Data.GameMode.submitScore);
    yield return (object) this.Routine();
  }

  private IEnumerator Routine()
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
      // ISSUE: reference to a compiler-generated method
      yield return (object) new WaitUntil(new Func<bool>(defeatSequence.\u003CRoutine\u003Eb__23_1));
    }
    global::Routine.Clump clump = new global::Routine.Clump();
    if (Campaign.Data.GameMode.submitScore)
    {
      defeatSequence.scoresLayout.SetActive(true);
      yield return (object) new WaitForSeconds(1f);
      // ISSUE: reference to a compiler-generated method
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
}
