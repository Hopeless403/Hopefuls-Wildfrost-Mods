// Decompiled with JetBrains decompiler
// Type: SplatterSurface
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using Dead;
using NaughtyAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
public class SplatterSurface : MonoBehaviour, IPoolable
{
  public RectTransform splatterContainer;
  [SerializeField]
  private Vector2 splatterScaleRange = new Vector2(1f, 1f);
  [SerializeField]
  private Vector2 splatterAlphaRange = new Vector2(1f, 1f);
  [SerializeField]
  private bool limitSplatters;
  [SerializeField]
  [ShowIf("limitSplatters")]
  private int maxSplatters = 10;
  [SerializeField]
  private bool colorBlend;
  [SerializeField]
  [ShowIf("colorBlend")]
  private Vector2 colorBlendRange = new Vector2(0.2f, 0.4f);
  [SerializeField]
  [ShowIf("colorBlend")]
  private Color blend = Color.white;
  [SerializeField]
  private bool fadeSplatters;
  [SerializeField]
  [ShowIf("fadeSplatters")]
  private Color fadeToColour;
  [SerializeField]
  [ShowIf("fadeSplatters")]
  private float fadeToDelay;
  private readonly List<Splatter> splatters = new List<Splatter>();

  public void Splat(SplatterParticle particle)
  {
    Splatter splatter = UnityEngine.Object.Instantiate<Splatter>(particle.splatterPrefab, (Transform) this.splatterContainer);
    Transform transform = splatter.transform;
    this.splatters.Add(splatter);
    Color color = particle.color;
    if (this.colorBlend)
    {
      float t = this.colorBlendRange.PettyRandom();
      color = Color.Lerp(color, this.blend, t);
    }
    splatter.color = color.With(alpha: particle.color.a * this.splatterAlphaRange.PettyRandom());
    int reduceTime = this.limitSplatters ? this.splatters.Count - this.maxSplatters : 0;
    if (this.fadeSplatters)
    {
      float time = Mathf.Max(1f, PettyRandom.Range(10f, 15f) - (float) reduceTime);
      if (SplatterSystem.CheckStartTween(time))
      {
        Color from = splatter.color;
        Color to = this.fadeToColour;
        LeanTween.value(splatter.gameObject, 0.0f, 1f, time).setEase(LeanTweenType.easeInOutQuint).setDelay(this.fadeToDelay).setOnUpdate((Action<float>) (a => splatter.color = Color.Lerp(from, to, a)));
      }
      else
        splatter.color = this.fadeToColour;
    }
    Vector3 to1 = transform.localScale * this.splatterScaleRange.PettyRandom();
    float time1 = PettyRandom.Range(0.12f, 0.18f);
    if (SplatterSystem.CheckStartTween(time1))
    {
      transform.localScale = to1 * 0.5f;
      LeanTween.scale(splatter.gameObject, to1, time1).setEase(LeanTweenType.easeOutBack);
    }
    else
      transform.localScale = to1;
    transform.position = particle.transform.position;
    transform.localPosition = transform.localPosition.WithZ(0.0f);
    if (!this.limitSplatters)
      return;
    for (int index = 0; index < reduceTime; ++index)
    {
      this.splatters[0].FadeOut((float) reduceTime);
      this.splatters.RemoveAt(0);
    }
  }

  public void Load(SplatterPersistenceSystem.SplatterData data, Splatter prefab)
  {
    Splatter splatter = UnityEngine.Object.Instantiate<Splatter>(prefab, (Transform) this.splatterContainer);
    this.splatters.Add(splatter);
    splatter.sprite = data.sprite;
    splatter.color = data.color;
    Transform transform = splatter.transform;
    transform.localPosition = data.offset;
    transform.localScale = data.scale;
    transform.localEulerAngles = new Vector3(0.0f, 0.0f, data.angle);
  }

  public Splatter[] GetActiveSplatters()
  {
    return this.splatters.Where<Splatter>((Func<Splatter, bool>) (a => !a.fading)).ToArray<Splatter>();
  }

  public void OnGetFromPool()
  {
  }

  public void OnReturnToPool()
  {
    foreach (Component splatter in this.splatters)
      UnityEngine.Object.Destroy((UnityEngine.Object) splatter.gameObject);
    this.splatters.Clear();
  }
}
