// Decompiled with JetBrains decompiler
// Type: WispAnimator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using UnityEngine;

#nullable disable
public class WispAnimator : MonoBehaviourCacheTransform
{
  public float knockback = 8f;
  public float gravitate = 5f;
  public float maxSpeed = 2f;
  public ParticleSystem smokeFx;
  public SpriteRenderer sprite;
  public SpriteRenderer faceSprite;
  public ParticleSystem pingPS;
  private Vector3 velocity = Vector3.zero;
  private Transform target;

  public void KnockBackFrom(Vector3 from)
  {
    this.velocity = (this.transform.position - from).WithZ(0.0f).normalized * this.knockback;
  }

  public void SetTarget(Transform target) => this.target = target;

  public bool TargetExists() => (bool) (UnityEngine.Object) this.target;

  public void JumpToTarget()
  {
    this.pingPS.Play();
    LeanTween.move(this.gameObject, this.target.position, 1f).setEaseInBack();
  }

  public void FadeToColour(Color color, float delay, float duration)
  {
    Color color1 = this.sprite.color;
    Gradient gradient = new Gradient()
    {
      alphaKeys = new GradientAlphaKey[1]
      {
        new GradientAlphaKey(1f, 0.0f)
      },
      colorKeys = new GradientColorKey[2]
      {
        new GradientColorKey(color1, 0.0f),
        new GradientColorKey(color, 1f)
      }
    };
    LeanTween.value(this.gameObject, 0.0f, 1f, duration).setDelay(delay).setOnUpdate((Action<float>) (a =>
    {
      Color color2 = gradient.Evaluate(a);
      this.sprite.color = color2;
      this.smokeFx.main.startColor = (ParticleSystem.MinMaxGradient) color2;
    }));
  }

  public void SetSortingLayer(string layerName, int orderInLayer)
  {
    this.smokeFx.GetComponent<Renderer>().sortingLayerName = layerName;
    this.smokeFx.GetComponent<Renderer>().sortingOrder = orderInLayer;
    this.sprite.sortingLayerName = layerName;
    this.sprite.sortingOrder = orderInLayer + 1;
    this.faceSprite.sortingLayerName = layerName;
    this.faceSprite.sortingOrder = orderInLayer + 2;
  }

  private void Update()
  {
    this.transform.position += this.velocity * Time.deltaTime;
    this.velocity = Vector3.MoveTowards(this.velocity, (double) this.maxSpeed != 0.0 ? ((bool) (UnityEngine.Object) this.target ? (this.target.position - this.transform.position).normalized * this.maxSpeed : Vector3.zero) : Vector3.zero, this.gravitate * Time.deltaTime);
  }
}
