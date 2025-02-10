// Decompiled with JetBrains decompiler
// Type: MainMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

public class MainMenu : Menu
{
  public GameObject playButton;
  public GameObject continueButton;
  public GameObject modsButton;
  public bool skipTutorial = true;

  private bool tutorial => !this.skipTutorial && SaveSystem.LoadProgressData<int>("tutorialProgress", 0) == 0;

  private void Start()
  {
    this.modsButton.SetActive(true);
    this.skipTutorial = false;
  }

  public void Play()
  {
    if (this.tutorial)
      this.StartGame("GameModeTutorial");
    else
      this.GoToTown();
  }

  public void Credits()
  {
    if (!this.active)
      return;
    this.StartCoroutine(this.CreditsRoutine());
  }

  private IEnumerator CreditsRoutine()
  {
    MainMenu mainMenu = this;
    mainMenu.active = false;
    yield return (object) SceneManager.Load("Credits", SceneType.Temporary);
    yield return (object) SceneManager.WaitUntilUnloaded("Credits");
    mainMenu.active = true;
  }

  public void Settings() => Object.FindObjectOfType<PauseMenu>(true)?.Settings();
}
