// Decompiled with JetBrains decompiler
// Type: AmbienceSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using FMOD;
using FMOD.Studio;
using FMODUnity;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

#nullable disable
public class AmbienceSystem : GameSystem
{
  [SerializeField]
  private string[] validScenes = new string[2]
  {
    "Battle",
    "Event"
  };
  private static EventInstance current;

  private void OnEnable() => global::Events.OnSceneChanged += new UnityAction<Scene>(this.SceneChanged);

  private void OnDisable()
  {
    global::Events.OnSceneChanged -= new UnityAction<Scene>(this.SceneChanged);
    AmbienceSystem.Stop();
  }

  private void SceneChanged(Scene scene)
  {
    AmbienceSystem.Stop();
    if (!this.validScenes.Contains<string>(scene.name))
      return;
    AmbienceSystem.Play(References.GetCurrentArea().ambienceEvent);
  }

  public static void Play(EventReference eventId) => AmbienceSystem.Play(eventId.Guid);

  private static void Play(GUID eventGUID)
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

  private static void Stop(FMOD.Studio.STOP_MODE stopMode = FMOD.Studio.STOP_MODE.ALLOWFADEOUT)
  {
    if (!AmbienceSystem.IsRunning(AmbienceSystem.current))
      return;
    int num1 = (int) AmbienceSystem.current.stop(stopMode);
    int num2 = (int) AmbienceSystem.current.release();
  }

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
}
