// Decompiled with JetBrains decompiler
// Type: Fader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[RequireComponent(typeof (Graphic))]
public class Fader : MonoBehaviour
{
  private Graphic _graphic;
  [SerializeField]
  private Gradient gradient;
  [SerializeField]
  private bool startFadedIn;
  [SerializeField]
  private LeanTweenType ease = LeanTweenType.easeInOutQuad;
  [SerializeField]
  private float delay;
  [SerializeField]
  private float dur = 0.5f;
  [SerializeField]
  private bool onAwake;
  [SerializeField]
  private bool onEnable;
  [SerializeField]
  private bool loop;
  [SerializeField]
  private bool ignoreTimeScale;
  private float current;

  private Graphic graphic => this._graphic ?? (this._graphic = this.GetComponent<Graphic>());

  private void Awake()
  {
    this.Set(this.startFadedIn ? 1f : 0.0f);
    if (!this.onAwake)
      return;
    this.In();
  }

  private void OnEnable()
  {
    if (!this.onEnable)
      return;
    this.Set(0.0f);
    this.In();
  }

  private void Set(float value)
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

  private void Tween(float to, float dur, LeanTweenType ease)
  {
    LeanTween.cancel(this.gameObject);
    LTDescr ltDescr = LeanTween.value(this.gameObject, this.current, to, dur).setDelay(this.delay).setEase(ease).setOnUpdate(new Action<float>(this.Set)).setIgnoreTimeScale(this.ignoreTimeScale);
    if (!this.loop)
      return;
    ltDescr.setLoopCount(-1);
  }
}
