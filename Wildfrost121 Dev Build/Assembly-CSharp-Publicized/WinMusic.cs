// Decompiled with JetBrains decompiler
// Type: WinMusic
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using FMOD;
using FMOD.Studio;
using FMODUnity;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

#nullable disable
public class WinMusic : MonoBehaviour
{
  [SerializeField]
  public bool playOnStart = true;
  [SerializeField]
  public EventReference musicEvent;
  public EventInstance current;

  public void OnEnable()
  {
    global::Events.OnBackToMainMenu += new UnityAction(this.BackToMainMenu);
    global::Events.OnSceneChanged += new UnityAction<Scene>(this.SceneChanged);
  }

  public void OnDisable()
  {
    global::Events.OnBackToMainMenu -= new UnityAction(this.BackToMainMenu);
    global::Events.OnSceneChanged -= new UnityAction<Scene>(this.SceneChanged);
  }

  public void Start()
  {
    if (!this.playOnStart || (Object) References.Battle.winner != (Object) References.Battle.player)
      return;
    this.StartMusic(this.musicEvent.Guid);
  }

  public void BackToMainMenu() => this.SetEndParam();

  public void SceneChanged(Scene scene) => this.SetEndParam();

  public void Play() => this.StartMusic(this.musicEvent.Guid);

  public void StartMusic(GUID eventGUID)
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

  public void SetParam(string name, float value)
  {
    if (!this.IsRunning())
      return;
    int num = (int) this.current.setParameterByName(name, value);
  }

  public bool IsRunning()
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
