// Decompiled with JetBrains decompiler
// Type: Animator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using UnityEngine;

public class Animator : MonoBehaviour
{
  [SerializeField]
  private Animator.Animation[] animations;
  private Dictionary<string, Animator.Animation> lookup;

  private void Awake()
  {
    this.lookup = new Dictionary<string, Animator.Animation>();
    foreach (Animator.Animation animation in this.animations)
      this.lookup[animation.name] = animation;
  }

  public void Play(string animationName)
  {
    if (!this.lookup.ContainsKey(animationName))
      return;
    this.lookup[animationName].Play(this.gameObject);
  }

  public void Stop() => LeanTween.cancel(this.gameObject);

  [Serializable]
  public struct Animation
  {
    public string name;
    public Animator.Animation.Property property;
    public AnimationCurve curve;
    public Vector2 duration;
    public Vector2 delay;
    public Vector3 to;
    public Vector3 from;
    public bool hasFrom;
    public bool loop;

    public void Play(GameObject target)
    {
      LeanTween.cancel(target);
      LTDescr ltDescr = (LTDescr) null;
      switch (this.property)
      {
        case Animator.Animation.Property.Move:
          if (this.hasFrom)
            target.transform.localPosition = this.from;
          ltDescr = LeanTween.moveLocal(target, this.to, this.duration.PettyRandom());
          break;
        case Animator.Animation.Property.Rotate:
          if (this.hasFrom)
            target.transform.localEulerAngles = this.from;
          ltDescr = LeanTween.rotateLocal(target, this.to, this.duration.PettyRandom());
          break;
        case Animator.Animation.Property.Scale:
          if (this.hasFrom)
            target.transform.localScale = this.from;
          ltDescr = LeanTween.scale(target, this.to, this.duration.PettyRandom());
          break;
      }
      float delay = this.delay.PettyRandom();
      if ((double) delay > 0.0 && ltDescr != null)
        ltDescr.setDelay(delay);
      ltDescr?.setEase(this.curve);
      if (!this.loop || ltDescr == null)
        return;
      ltDescr.setLoopClamp();
    }

    public enum Property
    {
      Move,
      Rotate,
      Scale,
    }
  }
}
