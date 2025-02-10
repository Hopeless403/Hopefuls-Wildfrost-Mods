// Decompiled with JetBrains decompiler
// Type: WinMusic
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using FMOD;
using FMOD.Studio;
using FMODUnity;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class WinMusic : MonoBehaviour
{
  [SerializeField]
  private bool playOnStart = true;
  [SerializeField]
  private EventReference musicEvent;
  private EventInstance current;

  private void OnEnable()
  {
    global::Events.OnBackToMainMenu += new UnityAction(this.BackToMainMenu);
    global::Events.OnSceneChanged += new UnityAction<Scene>(this.SceneChanged);
  }

  private void OnDisable()
  {
    global::Events.OnBackToMainMenu -= new UnityAction(this.BackToMainMenu);
    global::Events.OnSceneChanged -= new UnityAction<Scene>(this.SceneChanged);
  }

  private void Start()
  {
    if (!this.playOnStart || (Object) References.Battle.winner != (Object) References.Battle.player)
      return;
    this.StartMusic(this.musicEvent.Guid);
  }

  private void BackToMainMenu() => this.SetEndParam();

  private void SceneChanged(Scene scene) => this.SetEndParam();

  public void Play() => this.StartMusic(this.musicEvent.Guid);

  private void StartMusic(GUID eventGUID)
  {
    try
    {
      this.current = RuntimeManager.CreateInstance(eventGUID);
      int num = (int) this.current.start();
    }
    catch (EventNotFoundException ex)
    {
      UnityEngine.Debug.LogWarning((object) ex);
    }
  }

  public void SetEndParam() => this.SetParam("final_win", 1f);

  private void SetParam(string name, float value)
  {
    if (!this.IsRunning())
      return;
    int num = (int) this.current.setParameterByName(name, value);
  }

  private bool IsRunning()
  {
    if (this.current.isValid())
    {
      PLAYBACK_STATE state;
      int playbackState = (int) this.current.getPlaybackState(out state);
      if (state != PLAYBACK_STATE.STOPPED)
        return true;
    }
    return false;
  }
}
