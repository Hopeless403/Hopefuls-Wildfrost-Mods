﻿// Decompiled with JetBrains decompiler
// Type: Rewired.InputManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using Rewired.Platforms;
using Rewired.Utils;
using Rewired.Utils.Interfaces;
using System.ComponentModel;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

#nullable disable
namespace Rewired
{
  [AddComponentMenu("Rewired/Input Manager")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  public sealed class InputManager : InputManager_Base
  {
    private bool ignoreRecompile;

    protected override void OnInitialized() => this.SubscribeEvents();

    protected override void OnDeinitialized() => this.UnsubscribeEvents();

    protected override void DetectPlatform()
    {
      this.scriptingBackend = ScriptingBackend.Mono;
      this.scriptingAPILevel = ScriptingAPILevel.Net20;
      this.editorPlatform = EditorPlatform.None;
      this.platform = Platform.Unknown;
      this.webplayerPlatform = WebplayerPlatform.None;
      this.isEditor = false;
      if (UnityEngine.SystemInfo.deviceName == null)
      {
        string empty1 = string.Empty;
      }
      if (UnityEngine.SystemInfo.deviceModel == null)
      {
        string empty2 = string.Empty;
      }
      this.platform = Platform.Windows;
      this.scriptingBackend = ScriptingBackend.Mono;
      this.scriptingAPILevel = ScriptingAPILevel.Net46;
    }

    protected override void CheckRecompile()
    {
    }

    protected override IExternalTools GetExternalTools() => (IExternalTools) new ExternalTools();

    private bool CheckDeviceName(string searchPattern, string deviceName, string deviceModel)
    {
      return Regex.IsMatch(deviceName, searchPattern, RegexOptions.IgnoreCase) || Regex.IsMatch(deviceModel, searchPattern, RegexOptions.IgnoreCase);
    }

    private void SubscribeEvents()
    {
      this.UnsubscribeEvents();
      SceneManager.sceneLoaded += new UnityAction<Scene, LoadSceneMode>(this.OnSceneLoaded);
    }

    private void UnsubscribeEvents()
    {
      SceneManager.sceneLoaded -= new UnityAction<Scene, LoadSceneMode>(this.OnSceneLoaded);
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode) => this.OnSceneLoaded();
  }
}
