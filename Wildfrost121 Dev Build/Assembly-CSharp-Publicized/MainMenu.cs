// Decompiled with JetBrains decompiler
// Type: MainMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

#nullable disable
public class MainMenu : Menu
{
  public GameObject playButton;
  public GameObject continueButton;
  public GameObject modsButton;
  public bool skipTutorial = true;

  public bool tutorial
  {
    get => !this.skipTutorial && SaveSystem.LoadProgressData<int>("tutorialProgress", 0) == 0;
  }

  public void Start() => this.modsButton.SetActive(true);

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

  public IEnumerator CreditsRoutine()
  {
    MainMenu mainMenu = this;
    mainMenu.active = false;
    yield return (object) SceneManager.Load("Credits", SceneType.Temporary);
    yield return (object) SceneManager.WaitUntilUnloaded("Credits");
    mainMenu.active = true;
  }

  public void Settings() => Object.FindObjectOfType<PauseMenu>(true)?.Settings();
}
