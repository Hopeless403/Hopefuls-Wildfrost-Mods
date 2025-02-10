// Decompiled with JetBrains decompiler
// Type: SfxLoop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using FMOD.Studio;
using FMODUnity;
using NaughtyAttributes;
using System;
using UnityEngine;

#nullable disable
public class SfxLoop : MonoBehaviour
{
  [SerializeField]
  private bool onEnable = true;
  [SerializeField]
  private bool useAreaAmbience;
  [SerializeField]
  [HideIf("useAreaAmbience")]
  private EventReference eventRef;
  [SerializeField]
  private SfxLoop.Param[] @params;
  private EventInstance loop;
  private bool playing;

  private EventReference e
  {
    get => !this.useAreaAmbience ? this.eventRef : References.GetCurrentArea().ambienceEvent;
  }

  private void OnEnable()
  {
    if (!this.onEnable)
      return;
    this.Play();
  }

  private void OnDisable() => this.Stop();

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
  private struct Param
  {
    public string name;
    public float value;
  }
}
