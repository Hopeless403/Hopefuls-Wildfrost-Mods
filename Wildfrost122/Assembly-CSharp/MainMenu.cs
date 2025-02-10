// Decompiled with JetBrains decompiler
// Type: MainMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

#nullable disable
public class MainMenu : Menu
{
  public GameObject playButton;
  public GameObject continueButton;
  public GameObject modsButton;
  public bool skipTutorial = true;

  private bool tutorial
  {
    get => !this.skipTutorial && SaveSystem.LoadProgressData<int>("tutorialProgress", 0) == 0;
  }

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
