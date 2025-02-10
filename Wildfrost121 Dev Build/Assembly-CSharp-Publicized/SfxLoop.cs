// Decompiled with JetBrains decompiler
// Type: SfxLoop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using FMOD.Studio;
using FMODUnity;
using NaughtyAttributes;
using System;
using UnityEngine;

#nullable disable
public class SfxLoop : MonoBehaviour
{
  [SerializeField]
  public bool onEnable = true;
  [SerializeField]
  public bool useAreaAmbience;
  [SerializeField]
  [HideIf("useAreaAmbience")]
  public EventReference eventRef;
  [SerializeField]
  public SfxLoop.Param[] @params;
  public EventInstance loop;
  public bool playing;

  public EventReference e
  {
    get => !this.useAreaAmbience ? this.eventRef : References.GetCurrentArea().ambienceEvent;
  }

  public void OnEnable()
  {
    if (!this.onEnable)
      return;
    this.Play();
  }

  public void OnDisable() => this.Stop();

  public void Play()
  {
    this.loop = SfxSystem.Loop(this.e);
    foreach (SfxLoop.Param obj in this.@params)
      this.SetParam(obj.name, obj.value);
    this.playing = true;
  }

  public void Stop()
  {
    if (!this.playing)
      return;
    SfxSystem.EndLoop(new EventInstance?(this.loop));
    this.playing = false;
  }

  public void SetParam(string name, float value) => SfxSystem.SetParam(this.loop, name, value);

  public void SetParam(float value)
  {
    if (this.@params.Length == 0)
      return;
    this.SetParam(this.@params[0].name, value);
  }

  [Serializable]
  public struct Param
  {
    public string name;
    public float value;
  }
}
