// Decompiled with JetBrains decompiler
// Type: PauseMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
public class PauseMenu : Menu
{
  [SerializeField]
  public ButtonAnimator backToMenuButton;
  [SerializeField]
  public ButtonAnimator quickRestartButton;
  [SerializeField]
  public bool freezeTimeScale = true;
  [SerializeField]
  public JournalTab battleLogTab;
  [SerializeField]
  public JournalTab settingsTab;
  [SerializeField]
  public JournalTab lorePageTab;
  public static int blocked;
  [SerializeField]
  public bool doButtonLogic = true;

  public void OnEnable()
  {
    if (this.doButtonLogic)
    {
      switch (SceneManager.GetActive().name)
      {
        case "MainMenu":
          this.backToMenuButton.interactable = false;
          this.quickRestartButton.interactable = false;
          break;
        case "CharacterSelect":
        case "ContinueRun":
        case "Town":
        case "Cards":
          this.backToMenuButton.interactable = true;
          this.quickRestartButton.interactable = false;
          break;
        default:
          this.backToMenuButton.interactable = true;
          this.quickRestartButton.interactable = Campaign.Data != null && Campaign.Data.GameMode.canRestart;
          break;
      }
    }
    GameManager.paused = true;
    if (!this.freezeTimeScale)
      return;
    Time.timeScale = 0.0f;
  }

  public void OnDisable()
  {
    GameManager.paused = false;
    if (!this.freezeTimeScale)
      return;
    Time.timeScale = 1f;
  }

  public void GoToMainMenu()
  {
    if (!this.active)
      return;
    MonoBehaviourSingleton<Transition>.instance.StartCoroutine(SceneManager.Unload("Mods"));
    MonoBehaviourSingleton<Transition>.instance.StartCoroutine(SceneManager.Load("MainMenu", SceneType.Active));
  }

  public void BackToMainMenu()
  {
    if (!this.active)
      return;
    if ((bool) (Object) References.Campaign && !Campaign.Data.GameMode.doSave)
    {
      References.Campaign.End(Campaign.Result.None);
      JournalNameHistory.MostRecentNameKilled();
    }
    Routine routine = new Routine(Sequences.EndCampaign("MainMenu"));
    this.active = false;
    Events.InvokeBackToMainMenu();
  }

  public void QuickRestart()
  {
    if (!this.active)
      return;
    if ((bool) (Object) References.Campaign)
    {
      References.Campaign.End(Campaign.Result.Restart);
      JournalNameHistory.MostRecentNameKilled();
    }
    Campaign.Data = new CampaignData(Campaign.Data.GameMode);
    Routine routine = new Routine(Sequences.EndCampaign("CharacterSelect"));
    this.active = false;
  }

  public void BattleLog()
  {
    if (this.gameObject.activeSelf)
      return;
    this.Open();
    this.battleLogTab.Select();
  }

  public void Settings()
  {
    if (this.gameObject.activeSelf)
      return;
    this.Open();
    this.settingsTab.Select();
  }

  public void OpenLorePages()
  {
    if (this.gameObject.activeSelf)
      return;
    this.Open();
    this.lorePageTab.Select();
  }

  public override void Open()
  {
    if (PauseMenu.blocked > 0)
      return;
    base.Open();
  }

  public static void Block()
  {
    ++PauseMenu.blocked;
    foreach (Menu menu in Object.FindObjectsOfType<PauseMenu>())
      menu.Close();
  }

  public static void Unblock() => --PauseMenu.blocked;
}
