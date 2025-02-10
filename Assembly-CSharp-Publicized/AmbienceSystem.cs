// Decompiled with JetBrains decompiler
// Type: AmbienceSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using FMOD;
using FMOD.Studio;
using FMODUnity;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class AmbienceSystem : GameSystem
{
  [SerializeField]
  public string[] validScenes = new string[2]
  {
    "Battle",
    "Event"
  };
  public static EventInstance current;

  public void OnEnable() => global::Events.OnSceneChanged += new UnityAction<Scene>(this.SceneChanged);

  public void OnDisable()
  {
    global::Events.OnSceneChanged -= new UnityAction<Scene>(this.SceneChanged);
    AmbienceSystem.Stop();
  }

  public void SceneChanged(Scene scene)
  {
    AmbienceSystem.Stop();
    if (!this.validScenes.Contains<string>(scene.name))
      return;
    AmbienceSystem.Play(References.GetCurrentArea().ambienceEvent);
  }

  public static void Play(EventReference eventId) => AmbienceSystem.Play(eventId.Guid);

  public static void Play(GUID eventGUID)
  {
    try
    {
      AmbienceSystem.current = RuntimeManager.CreateInstance(eventGUID);
      int num = (int) AmbienceSystem.current.start();
    }
    catch (EventNotFoundException ex)
    {
      UnityEngine.Debug.LogWarning((object) ex);
    }
  }

  public static void SetParam(string name, float value)
  {
    if (!AmbienceSystem.IsRunning(AmbienceSystem.current))
      return;
    int num = (int) AmbienceSystem.current.setParameterByName(name, value);
  }

  public static void Stop(FMOD.Studio.STOP_MODE stopMode = FMOD.Studio.STOP_MODE.ALLOWFADEOUT)
  {
    if (!AmbienceSystem.IsRunning(AmbienceSystem.current))
      return;
    int num1 = (int) AmbienceSystem.current.stop(stopMode);
    int num2 = (int) AmbienceSystem.current.release();
  }

  public static bool IsRunning(EventInstance instance)
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
}
