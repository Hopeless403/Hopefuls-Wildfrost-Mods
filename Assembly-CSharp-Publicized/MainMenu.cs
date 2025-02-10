// Decompiled with JetBrains decompiler
// Type: MainMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

public class MainMenu : Menu
{
  public GameObject playButton;
  public GameObject continueButton;
  public GameObject modsButton;
  public bool skipTutorial = true;

  public bool tutorial => !this.skipTutorial && SaveSystem.LoadProgressData<int>("tutorialProgress", 0) == 0;

  public void Start()
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
