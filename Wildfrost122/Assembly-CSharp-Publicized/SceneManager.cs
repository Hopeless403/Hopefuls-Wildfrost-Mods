﻿// Decompiled with JetBrains decompiler
// Type: SceneManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

#nullable disable
public static class SceneManager
{
  [CompilerGenerated]
  public static string \u003CActiveSceneKey\u003Ek__BackingField;
  [CompilerGenerated]
  public static string \u003CActiveSceneName\u003Ek__BackingField;
  public static readonly Dictionary<string, Scene> Loaded = new Dictionary<string, Scene>();
  public static readonly List<string> Temporary = new List<string>();
  public static readonly List<string> Loading = new List<string>();
  public static int jobsActive;

  public static string ActiveSceneKey
  {
    get => SceneManager.\u003CActiveSceneKey\u003Ek__BackingField;
    set => SceneManager.\u003CActiveSceneKey\u003Ek__BackingField = value;
  }

  public static string ActiveSceneName
  {
    get => SceneManager.\u003CActiveSceneName\u003Ek__BackingField;
    set => SceneManager.\u003CActiveSceneName\u003Ek__BackingField = value;
  }

  public static Scene GetActive() => SceneManager.Loaded[SceneManager.ActiveSceneKey];

  public static bool HasNoActiveJobs => SceneManager.jobsActive <= 0;

  public static IEnumerator Load(string sceneKey, SceneType type, Action<Scene> onComplete = null)
  {
    SceneManager.JobStart();
    sceneKey = sceneKey.Replace("Scenes/", "").Replace(".unity", "");
    Debug.Log((object) ("SceneManager → Loading Scene \"" + sceneKey + "\""));
    if (SceneManager.Loading.Contains(sceneKey))
      yield return (object) new WaitUntil((Func<bool>) (() => !SceneManager.Loading.Contains(sceneKey)));
    if (!SceneManager.IsLoaded(sceneKey))
    {
      yield return (object) SceneManager.Load(sceneKey, type, true);
      Events.InvokeSceneLoaded(SceneManager.Loaded[sceneKey]);
    }
    else
      Debug.Log((object) ("\"" + sceneKey + "\" already loaded"));
    if (type == SceneType.Active)
      yield return (object) SceneManager.SetActive(sceneKey);
    Action<Scene> action = onComplete;
    if (action != null)
      action(SceneManager.Loaded[sceneKey]);
    SceneManager.JobEnd();
  }

  public static IEnumerator Load(string sceneKey, SceneType type, bool activateOnLoad)
  {
    SceneManager.Loading.Add(sceneKey);
    AsyncOperation handle = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneKey, LoadSceneMode.Additive);
    while (!handle.isDone)
      yield return (object) null;
    SceneManager.Loaded[sceneKey] = UnityEngine.SceneManagement.SceneManager.GetSceneByName(sceneKey);
    SceneManager.Loading.Remove(sceneKey);
    Debug.Log((object) ("\"" + sceneKey + "\" Loaded"));
    if (type == SceneType.Temporary)
      SceneManager.Temporary.Add(sceneKey);
  }

  public static IEnumerator SetActive(string sceneKey)
  {
    Scene scene = SceneManager.Loaded[sceneKey];
    SceneManager.ActiveSceneName = scene.name;
    SceneManager.ActiveSceneKey = sceneKey;
    Events.InvokeSceneChanged(scene);
    yield return (object) SceneManager.UnloadTemporary();
  }

  public static IEnumerator Unload(string sceneKey)
  {
    if (!sceneKey.IsNullOrWhitespace())
    {
      Debug.Log((object) ("SceneManager → Unloading Scene \"" + sceneKey + "\""));
      if (SceneManager.IsLoaded(sceneKey))
      {
        Scene scene = SceneManager.Loaded[sceneKey];
        Events.InvokeSceneUnload(scene);
        AsyncOperation handle = UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(scene);
        while (!handle.isDone)
          yield return (object) null;
        Debug.Log((object) "Scene successfully unloaded");
        SceneManager.Loaded.Remove(sceneKey);
        SceneManager.Temporary.Remove(sceneKey);
        handle = (AsyncOperation) null;
      }
      else
        Debug.Log((object) "Scene is already unloaded...");
    }
  }

  public static IEnumerator UnloadActive()
  {
    Routine.Clump clump = new Routine.Clump();
    if (!SceneManager.ActiveSceneKey.IsNullOrWhitespace())
      clump.Add(SceneManager.Unload(SceneManager.ActiveSceneKey));
    clump.Add(SceneManager.UnloadTemporary());
    yield return (object) clump.WaitForEnd();
  }

  public static IEnumerator UnloadTemporary()
  {
    Routine.Clump clump = new Routine.Clump();
    foreach (string sceneKey in SceneManager.Temporary)
      clump.Add(SceneManager.Unload(sceneKey));
    yield return (object) clump.WaitForEnd();
  }

  public static bool IsLoaded(string sceneKey) => SceneManager.Loaded.ContainsKey(sceneKey);

  public static IEnumerator WaitUntilUnloaded(string sceneKey)
  {
    yield return (object) new WaitUntil((Func<bool>) (() => !SceneManager.Loaded.ContainsKey(sceneKey)));
  }

  public static void JobStart() => ++SceneManager.jobsActive;

  public static void JobEnd() => --SceneManager.jobsActive;
}
