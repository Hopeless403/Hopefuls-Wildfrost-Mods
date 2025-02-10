// Decompiled with JetBrains decompiler
// Type: Menu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Events;

public class Menu : MonoBehaviour
{
  [SerializeField]
  public HelpPanelShower retryTutorialHelp;
  public bool active = true;

  public void GoTo(string sceneName)
  {
    if (!this.active)
      return;
    Routine routine = new Routine(Transition.To(sceneName));
    this.active = false;
  }

  public void StartGameOrContinue() => this.StartGameOrContinue("GameModeNormal");

  public void StartGameOrContinue(string gameModeName, bool skipTutorial = false)
  {
    GameMode gameMode1 = AddressableLoader.Get<GameMode>("GameMode", "GameModeTutorial");
    if (Campaign.CheckContinue(gameMode1))
    {
      Campaign.Data = CampaignData.Load(gameMode1);
      Routine routine = new Routine(SceneManager.Load("ContinueRun", SceneType.Temporary));
    }
    else if (!skipTutorial && SaveSystem.LoadProgressData<int>("tutorialProgress", 0) <= 1 && (bool) (Object) this.retryTutorialHelp)
    {
      this.retryTutorialHelp.Show();
      this.retryTutorialHelp.AddButton(0, HelpPanelSystem.ButtonType.Positive, (UnityAction) (() => this.StartGame("GameModeTutorial")));
      this.retryTutorialHelp.AddButton(1, HelpPanelSystem.ButtonType.Negative, (UnityAction) (() =>
      {
        SaveSystem.SaveProgressData<int>("tutorialProgress", 2);
        global::Events.InvokeTutorialSkip();
        this.StartGameOrContinue(gameModeName, true);
      }));
    }
    else
    {
      GameMode gameMode2 = AddressableLoader.Get<GameMode>("GameMode", gameModeName);
      if (Campaign.CheckContinue(gameMode2))
      {
        Campaign.Data = CampaignData.Load(gameMode2);
        Routine routine = new Routine(SceneManager.Load("ContinueRun", SceneType.Temporary));
      }
      else
        this.StartGame(gameMode2);
    }
  }

  public void StartGame() => this.StartGame("GameModeNormal");

  public void StartGame(string gameModeName) => this.StartGame(AddressableLoader.Get<GameMode>("GameMode", gameModeName));

  public void StartGame(GameMode gameMode)
  {
    SaveSystem.DeleteCampaign(gameMode);
    global::Events.InvokeCampaignDeleted();
    Campaign.Data = new CampaignData(gameMode);
    this.GoTo(gameMode.startScene);
  }

  public void GoToTown() => this.GoTo("Town");

  public void ExitGame()
  {
    if (!this.active)
      return;
    GameManager.Quit();
  }

  public virtual void Open()
  {
    this.gameObject.SetActive(true);
    this.active = true;
  }

  public void Close()
  {
    this.gameObject.SetActive(false);
    this.active = false;
  }

  public void Toggle()
  {
    if (this.gameObject.activeSelf)
      this.Close();
    else
      this.Open();
  }
}
