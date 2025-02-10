// Decompiled with JetBrains decompiler
// Type: ErrorHandlerSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using FMODUnity;
using NaughtyAttributes;
using System;
using System.IO;
using TMPro;
using UnityEngine;

#nullable disable
public class ErrorHandlerSystem : GameSystem
{
  [SerializeField]
  private bool displayErrors = true;
  [SerializeField]
  [ShowIf("displayErrors")]
  private GameObject errorDisplay;
  [SerializeField]
  [ShowIf("displayErrors")]
  private TMP_InputField errorText;
  [SerializeField]
  [ShowIf("displayErrors")]
  private bool freezeTimeScale = true;
  [SerializeField]
  [ShowIf("displayErrors")]
  private EventReference sfxEvent;
  [SerializeField]
  private bool showPersistentMessage = true;
  [SerializeField]
  [ShowIf("showPersistentMessage")]
  private GameObject persistentMessage;
  private const string format = "\n\n[{0}] {1}\n{2}";
  private float timeScalePre = 1f;
  private static int errorCount;

  private static string path => Application.persistentDataPath + "/Errors.log";

  private void OnEnable()
  {
    Application.logMessageReceived += new Application.LogCallback(this.HandleLog);
  }

  private void OnDisable()
  {
    Application.logMessageReceived -= new Application.LogCallback(this.HandleLog);
  }

  private void HandleLog(string log, string stacktrace, LogType type)
  {
    if (type != LogType.Exception)
      return;
    ++ErrorHandlerSystem.errorCount;
    using (StreamWriter streamWriter = new StreamWriter(ErrorHandlerSystem.path, true))
      streamWriter.WriteLine("\n\n[{0}] {1}\n{2}", (object) DateTime.Now, (object) log, (object) stacktrace);
    if (this.displayErrors)
    {
      this.ShowError(log + "\n" + stacktrace);
    }
    else
    {
      if (!this.showPersistentMessage)
        return;
      this.ShowPersistentMessage();
    }
  }

  private void ShowError(string text)
  {
    this.errorDisplay.SetActive(true);
    this.errorText.text = text;
    if (this.freezeTimeScale)
    {
      this.timeScalePre = Time.timeScale;
      Time.timeScale = 0.0f;
    }
    SfxSystem.OneShot(this.sfxEvent.Guid);
  }

  public void HideError()
  {
    this.errorDisplay.SetActive(false);
    Time.timeScale = this.timeScalePre;
    if (!this.showPersistentMessage || ErrorHandlerSystem.errorCount <= 0)
      return;
    this.ShowPersistentMessage();
  }

  public void ExitGame() => GameManager.Quit();

  private void ShowPersistentMessage() => this.persistentMessage.SetActive(true);

  public void HidePersistentMessage() => this.persistentMessage.SetActive(false);
}
