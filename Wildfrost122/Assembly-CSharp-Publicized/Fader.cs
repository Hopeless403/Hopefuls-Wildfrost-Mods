// Decompiled with JetBrains decompiler
// Type: Fader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[RequireComponent(typeof (Graphic))]
public class Fader : MonoBehaviour
{
  public Graphic _graphic;
  [SerializeField]
  public Gradient gradient;
  [SerializeField]
  public bool startFadedIn;
  [SerializeField]
  public LeanTweenType ease = LeanTweenType.easeInOutQuad;
  [SerializeField]
  public float delay;
  [SerializeField]
  public float dur = 0.5f;
  [SerializeField]
  public bool onAwake;
  [SerializeField]
  public bool onEnable;
  [SerializeField]
  public bool loop;
  [SerializeField]
  public bool ignoreTimeScale;
  public float current;

  public Graphic graphic => this._graphic ?? (this._graphic = this.GetComponent<Graphic>());

  public void Awake()
  {
    this.Set(this.startFadedIn ? 1f : 0.0f);
    if (!this.onAwake)
      return;
    this.In();
  }

  public void OnEnable()
  {
    if (!this.onEnable)
      return;
    this.Set(0.0f);
    this.In();
  }

  public void Set(float value)
  {
    this.current = value;
    this.graphic.color = this.gradient.Evaluate(value);
  }

  public void In() => this.Tween(1f, this.dur, this.ease);

  public void In(float dur) => this.Tween(1f, dur, this.ease);

  public void In(float dur, LeanTweenType ease) => this.Tween(1f, dur, ease);

  public void Out() => this.Tween(0.0f, this.dur, this.ease);

  public void Out(float dur) => this.Tween(0.0f, dur, this.ease);

  public void Out(float dur, LeanTweenType ease) => this.Tween(0.0f, dur, ease);

  public void Tween(float to, float dur, LeanTweenType ease)
  {
    LeanTween.cancel(this.gameObject);
    LTDescr ltDescr = LeanTween.value(this.gameObject, this.current, to, dur).setDelay(this.delay).setEase(ease).setOnUpdate(new Action<float>(this.Set)).setIgnoreTimeScale(this.ignoreTimeScale);
    if (!this.loop)
      return;
    ltDescr.setLoopCount(-1);
  }
}
