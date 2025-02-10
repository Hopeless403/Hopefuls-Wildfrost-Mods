// Decompiled with JetBrains decompiler
// Type: MusicSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using FMOD;
using FMOD.Studio;
using FMODUnity;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class MusicSystem : GameSystem
{
  private static MusicSystem instance;
  public MusicSystem.Music[] music;
  public MusicSystem.Music[] eventMusic;
  private static EventInstance current;
  private static LTDescr fadePitchTween;
  private static float pitch = 1f;

  private void OnEnable()
  {
    MusicSystem.instance = this;
    global::Events.OnSceneChanged += new UnityAction<Scene>(this.SceneChanged);
  }

  private void OnDisable()
  {
    global::Events.OnSceneChanged -= new UnityAction<Scene>(this.SceneChanged);
    MusicSystem.StopMusic();
  }

  private void SceneChanged(Scene from, Scene to) => this.SceneChanged(to);

  private void SceneChanged(Scene scene)
  {
    MusicSystem.StopMusic();
    MusicSystem.Music music = ((IEnumerable<MusicSystem.Music>) this.music).FirstOrDefault<MusicSystem.Music>((Func<MusicSystem.Music, bool>) (a => a.sceneName == scene.name));
    if (music == null)
      return;
    MusicSystem.StartMusic(music.eventId.Guid);
  }

  public static void StartMusic(EventReference eventId) => MusicSystem.StartMusic(eventId.Guid);

  private static void StartMusic(GUID eventGUID)
  {
    try
    {
      MusicSystem.current = RuntimeManager.CreateInstance(eventGUID);
      int num = (int) MusicSystem.current.start();
    }
    catch (EventNotFoundException ex)
    {
      UnityEngine.Debug.LogWarning((object) ex);
    }
  }

  public static void SetParam(string name, float value)
  {
    if (!MusicSystem.IsRunning(MusicSystem.current))
      return;
    int num = (int) MusicSystem.current.setParameterByName(name, value);
  }

  public static void StopMusic(FMOD.Studio.STOP_MODE stopMode = FMOD.Studio.STOP_MODE.ALLOWFADEOUT)
  {
    if (!MusicSystem.IsRunning(MusicSystem.current))
      return;
    int num1 = (int) MusicSystem.current.stop(stopMode);
    int num2 = (int) MusicSystem.current.release();
  }

  public static void FadePitchTo(float value, float time) => MusicSystem.fadePitchTween = LeanTween.value(MusicSystem.instance.gameObject, MusicSystem.pitch, value, time).setOnUpdate((Action<float>) (a =>
  {
    MusicSystem.pitch = a;
    if (!MusicSystem.IsRunning(MusicSystem.current))
      return;
    int num = (int) MusicSystem.current.setPitch(MusicSystem.pitch);
  }));

  private static bool IsRunning(EventInstance instance)
  {
    if (instance.isValid())
    {
      PLAYBACK_STATE state;
      int playbackState = (int) instance.getPlaybackState(out state);
      if (state != PLAYBACK_STATE.STOPPED)
        return true;
    }
    return false;
  }

  [Serializable]
  public class Music
  {
    public string sceneName;
    public EventReference eventId;
  }
}
