// Decompiled with JetBrains decompiler
// Type: TweenUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

#nullable disable
public class TweenUI : MonoBehaviour
{
  [SerializeField]
  public GameObject target;
  [SerializeField]
  [HideIf("fireOnStart")]
  public bool fireOnEnable;
  [SerializeField]
  [HideIf("fireOnEnable")]
  public bool fireOnStart;
  [SerializeField]
  [HideIf("FireOnStart")]
  public bool enableOnFire;
  [SerializeField]
  public bool disableAfter;
  [SerializeField]
  public bool multi;
  [SerializeField]
  [HideIf("multi")]
  public TweenUI.Property property;
  [SerializeField]
  [HideIf("multi")]
  public LeanTweenType ease;
  [SerializeField]
  [HideIf("multi")]
  [ShowIf("IsAnimationCurve")]
  public AnimationCurve animationCurve;
  [SerializeField]
  [HideIf("multi")]
  public bool randomSigns;
  [Header("Duration")]
  [SerializeField]
  [HideIf("multi")]
  public bool randomDuration;
  [SerializeField]
  [HideIf("multiOrRandomDuration")]
  public float duration;
  [SerializeField]
  [HideIf("multi")]
  [ShowIf("randomDuration")]
  public Vector2 durationRange;
  [Header("Delay")]
  [SerializeField]
  [HideIf("multi")]
  public bool randomDelay;
  [SerializeField]
  [HideIf("multiOrRandomDelay")]
  public float delay;
  [SerializeField]
  [HideIf("multi")]
  [ShowIf("randomDelay")]
  public Vector2 delayRange;
  [Header("Values")]
  [SerializeField]
  [HideIf("multi")]
  public Vector3 to;
  [SerializeField]
  [HideIf("multi")]
  public bool hasFrom;
  [SerializeField]
  [HideIf("multi")]
  [ShowIf("hasFrom")]
  public Vector3 from;
  [SerializeField]
  [ShowIf("multi")]
  public TweenUI.Tween[] tweens;
  [SerializeField]
  public bool cancelOtherTweens = true;
  [SerializeField]
  public bool ignoreTimeScale;

  public bool multiOrRandomDuration => this.multi || this.randomDuration;

  public bool multiOrRandomDelay => this.multi || this.randomDelay;

  public bool IsAnimationCurve => this.ease == LeanTweenType.animationCurve;

  public bool FireOnStart => this.fireOnEnable || this.fireOnStart;

  public void OnEnable()
  {
    if (!this.fireOnEnable)
      return;
    this.Fire();
  }

  public void Start()
  {
    if (!this.fireOnStart)
      return;
    this.Fire();
  }

  public void Fire()
  {
    if (this.enableOnFire && !this.FireOnStart)
      this.target.gameObject.SetActive(true);
    if (this.cancelOtherTweens)
      LeanTween.cancel(this.target);
    if (this.multi)
    {
      this.delay = 0.0f;
      this.duration = 0.0f;
      foreach (TweenUI.Tween tween in this.tweens)
      {
        tween.Fire(this.target, this.ignoreTimeScale);
        this.delay = Mathf.Max(this.delay, tween.delay);
        this.duration = Mathf.Max(this.duration, tween.duration);
      }
      if (!this.disableAfter)
        return;
      LeanTween.value(this.target, 0.0f, 0.0f, this.delay + this.duration).setIgnoreTimeScale(this.ignoreTimeScale).setOnComplete((System.Action) (() => this.target.gameObject.SetActive(false)));
    }
    else
    {
      if (this.randomDuration)
        this.duration = this.durationRange.PettyRandom();
      if (this.randomDelay)
        this.delay = this.delayRange.PettyRandom();
      LTDescr ltDescr = (LTDescr) null;
      switch (this.property)
      {
        case TweenUI.Property.Move:
          if (this.hasFrom)
            this.target.transform.localPosition = this.GetFrom();
          ltDescr = LeanTween.moveLocal(this.target, this.to, this.duration);
          break;
        case TweenUI.Property.Rotate:
          if (this.hasFrom)
            this.target.transform.localEulerAngles = this.GetFrom();
          ltDescr = LeanTween.rotateLocal(this.target, this.to, this.duration);
          break;
        case TweenUI.Property.Scale:
          if (this.hasFrom)
            this.target.transform.localScale = this.GetFrom();
          ltDescr = LeanTween.scale(this.target, this.to, this.duration);
          break;
      }
      if (ltDescr == null)
        return;
      if (this.ignoreTimeScale)
        ltDescr.setIgnoreTimeScale(true);
      if ((double) this.delay > 0.0)
        ltDescr.setDelay(this.delay);
      if (this.IsAnimationCurve)
        ltDescr.setEase(this.animationCurve);
      else
        ltDescr.setEase(this.ease);
      if (!this.disableAfter)
        return;
      ltDescr.setOnComplete((System.Action) (() => this.target.gameObject.SetActive(false)));
    }
  }

  public float GetDuration() => this.delay + this.duration;

  public Vector3 GetFrom()
  {
    return !this.randomSigns ? this.from : this.from.With(new float?(this.from.x.WithRandomSign()), new float?(this.from.y.WithRandomSign()), new float?(this.from.z.WithRandomSign()));
  }

  [CompilerGenerated]
  public void \u003CFire\u003Eb__33_0() => this.target.gameObject.SetActive(false);

  [CompilerGenerated]
  public void \u003CFire\u003Eb__33_1() => this.target.gameObject.SetActive(false);

  public enum Property
  {
    Move,
    Rotate,
    Scale,
  }

  [Serializable]
  public struct Tween
  {
    public TweenUI.Property property;
    public LeanTweenType ease;
    public AnimationCurve curve;
    public bool randomSigns;
    [Header("Duration")]
    public float duration;
    [Header("Delay")]
    public float delay;
    [Header("Values")]
    public Vector3 to;
    public bool hasFrom;
    public Vector3 from;

    public void Fire(GameObject target, bool ignoreTimeScale)
    {
      LTDescr ltDescr = (LTDescr) null;
      switch (this.property)
      {
        case TweenUI.Property.Move:
          if (this.hasFrom)
            target.transform.localPosition = this.GetFrom();
          ltDescr = LeanTween.moveLocal(target, this.to, this.duration);
          break;
        case TweenUI.Property.Rotate:
          if (this.hasFrom)
            target.transform.localEulerAngles = this.GetFrom();
          ltDescr = LeanTween.rotateLocal(target, this.to, this.duration);
          break;
        case TweenUI.Property.Scale:
          if (this.hasFrom)
            target.transform.localScale = this.GetFrom();
          ltDescr = LeanTween.scale(target, this.to, this.duration);
          break;
      }
      if (ignoreTimeScale)
        ltDescr.setIgnoreTimeScale(true);
      if ((double) this.delay > 0.0 && ltDescr != null)
        ltDescr.setDelay(this.delay);
      if (this.ease == LeanTweenType.animationCurve)
        ltDescr?.setEase(this.curve);
      else
        ltDescr?.setEase(this.ease);
    }

    public Vector3 GetFrom()
    {
      return !this.randomSigns ? this.from : this.from.With(new float?(this.from.x.WithRandomSign()), new float?(this.from.y.WithRandomSign()), new float?(this.from.z.WithRandomSign()));
    }
  }
}
