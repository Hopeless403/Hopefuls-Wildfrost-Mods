// Decompiled with JetBrains decompiler
// Type: ErrorHandlerSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

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
  public bool displayErrors = true;
  [SerializeField]
  [ShowIf("displayErrors")]
  public GameObject errorDisplay;
  [SerializeField]
  [ShowIf("displayErrors")]
  public TMP_InputField errorText;
  [SerializeField]
  [ShowIf("displayErrors")]
  public bool freezeTimeScale = true;
  [SerializeField]
  [ShowIf("displayErrors")]
  public EventReference sfxEvent;
  [SerializeField]
  public bool showPersistentMessage = true;
  [SerializeField]
  [ShowIf("showPersistentMessage")]
  public GameObject persistentMessage;
  public const string format = "\n\n[{0}] {1}\n{2}";
  public float timeScalePre = 1f;
  public static int errorCount;

  public static string path => Application.persistentDataPath + "/Errors.log";

  public void OnEnable()
  {
    Application.logMessageReceived += new Application.LogCallback(this.HandleLog);
  }

  public void OnDisable()
  {
    Application.logMessageReceived -= new Application.LogCallback(this.HandleLog);
  }

  public void HandleLog(string log, string stacktrace, LogType type)
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

  public void ShowError(string text)
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

  public void ShowPersistentMessage() => this.persistentMessage.SetActive(true);

  public void HidePersistentMessage() => this.persistentMessage.SetActive(false);
}
