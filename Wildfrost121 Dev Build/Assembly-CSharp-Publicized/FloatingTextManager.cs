// Decompiled with JetBrains decompiler
// Type: FloatingTextManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
public class FloatingTextManager : MonoBehaviourSingleton<FloatingTextManager>
{
  [SerializeField]
  public FloatingText prefab;
  [SerializeField]
  public FloatingTextManager.Animation[] animations;
  [SerializeField]
  public FloatingTextManager.FadeCurve[] fadeCurves;
  public Dictionary<string, FloatingTextManager.Animation> animationDictionary;
  public Dictionary<string, FloatingTextManager.FadeCurve> fadeCurveDictionary;
  public static Queue<FloatingText> pool = new Queue<FloatingText>();

  public void Start()
  {
    this.animationDictionary = new Dictionary<string, FloatingTextManager.Animation>();
    foreach (FloatingTextManager.Animation animation in this.animations)
      this.animationDictionary[animation.name] = animation;
    this.fadeCurveDictionary = new Dictionary<string, FloatingTextManager.FadeCurve>();
    foreach (FloatingTextManager.FadeCurve fadeCurve in this.fadeCurves)
      this.fadeCurveDictionary[fadeCurve.name] = fadeCurve;
  }

  public static FloatingTextManager.Animation GetAnimation(string name)
  {
    return MonoBehaviourSingleton<FloatingTextManager>.instance.animationDictionary[name];
  }

  public static FloatingTextManager.FadeCurve GetFadeCurve(string name)
  {
    return MonoBehaviourSingleton<FloatingTextManager>.instance.fadeCurveDictionary[name];
  }

  public static FloatingText GetFromPool()
  {
    if (FloatingTextManager.pool.Count <= 0)
      return MonoBehaviourSingleton<FloatingTextManager>.instance.CreatePrefab();
    FloatingText fromPool = FloatingTextManager.pool.Dequeue();
    fromPool.gameObject.SetActive(true);
    return fromPool;
  }

  public static void ReturnToPool(FloatingText item)
  {
    item.Reset();
    item.StopAllCoroutines();
    item.gameObject.SetActive(false);
    item.transform.SetParent(MonoBehaviourSingleton<FloatingTextManager>.instance.transform);
    FloatingTextManager.pool.Enqueue(item);
  }

  public FloatingText CreatePrefab()
  {
    FloatingText prefab = UnityEngine.Object.Instantiate<FloatingText>(this.prefab, this.transform);
    prefab.gameObject.SetActive(true);
    return prefab;
  }

  [Serializable]
  public struct Animation
  {
    public string name;
    public FloatingTextManager.Animation.Tween[] tweens;

    public void Fire(GameObject target, float strength)
    {
      foreach (FloatingTextManager.Animation.Tween tween in this.tweens)
        tween.Fire(target, strength);
    }

    public float GetDuration()
    {
      float duration = 0.0f;
      foreach (FloatingTextManager.Animation.Tween tween in this.tweens)
        duration += tween.GetDuration();
      return duration;
    }

    [Serializable]
    public struct Tween
    {
      public LeanTweenType ease;
      [ShowIf("IsAnimationCurve")]
      public AnimationCurve curve;
      public float duration;
      public float delay;
      public FloatingTextManager.Animation.Tween.Property property;
      public bool relative;
      public Vector3 to;
      public bool hasFrom;
      [ShowIf("hasFrom")]
      public Vector3 from;

      public bool IsAnimationCurve => this.ease == LeanTweenType.animationCurve;

      public void Fire(GameObject target, float strength)
      {
        LTDescr ltDescr = (LTDescr) null;
        switch (this.property)
        {
          case FloatingTextManager.Animation.Tween.Property.Move:
            Vector3 localPosition = target.transform.localPosition;
            if (this.hasFrom)
              target.transform.localPosition = this.relative ? localPosition + this.from * strength : this.from;
            ltDescr = LeanTween.moveLocal(target, this.relative ? localPosition + this.to * strength : this.to, this.duration);
            break;
          case FloatingTextManager.Animation.Tween.Property.Scale:
            Vector3 localScale = target.transform.localScale;
            if (this.hasFrom)
              target.transform.localScale = this.relative ? localScale + this.from * strength : this.from;
            ltDescr = LeanTween.scale(target, this.relative ? localScale + this.to * strength : this.to, this.duration);
            break;
          case FloatingTextManager.Animation.Tween.Property.Rotate:
            Vector3 localEulerAngles = target.transform.localEulerAngles;
            if (this.hasFrom)
              target.transform.localEulerAngles = this.relative ? localEulerAngles + this.from * strength : this.from;
            ltDescr = LeanTween.rotateLocal(target, this.relative ? localEulerAngles + this.to * strength : this.to, this.duration);
            break;
        }
        if (this.IsAnimationCurve)
          ltDescr?.setEase(this.curve);
        else
          ltDescr?.setEase(this.ease);
        if ((double) this.delay <= 0.0 || ltDescr == null)
          return;
        ltDescr.setDelay(this.delay);
      }

      public float GetDuration() => this.duration + this.delay;

      public enum Property
      {
        Move,
        Scale,
        Rotate,
      }
    }
  }

  [Serializable]
  public struct FadeCurve
  {
    public string name;
    public AnimationCurve curve;
  }
}
