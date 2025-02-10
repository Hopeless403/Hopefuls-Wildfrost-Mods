// Decompiled with JetBrains decompiler
// Type: SplatterSurface
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using Dead;
using NaughtyAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SplatterSurface : MonoBehaviour, IPoolable
{
  public RectTransform splatterContainer;
  [SerializeField]
  public Vector2 splatterScaleRange = new Vector2(1f, 1f);
  [SerializeField]
  public Vector2 splatterAlphaRange = new Vector2(1f, 1f);
  [SerializeField]
  public bool limitSplatters;
  [SerializeField]
  [ShowIf("limitSplatters")]
  public int maxSplatters = 10;
  [SerializeField]
  public bool colorBlend;
  [SerializeField]
  [ShowIf("colorBlend")]
  public Vector2 colorBlendRange = new Vector2(0.2f, 0.4f);
  [SerializeField]
  [ShowIf("colorBlend")]
  public Color blend = Color.white;
  [SerializeField]
  public bool fadeSplatters;
  [SerializeField]
  [ShowIf("fadeSplatters")]
  public Color fadeToColour;
  [SerializeField]
  [ShowIf("fadeSplatters")]
  public float fadeToDelay;
  public readonly List<Splatter> splatters = new List<Splatter>();

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
    if (this.fadeSplatters)
    {
      Color from = splatter.color;
      Color to = this.fadeToColour;
      LeanTween.value(splatter.gameObject, 0.0f, 1f, PettyRandom.Range(10f, 15f)).setEase(LeanTweenType.easeInOutQuint).setDelay(this.fadeToDelay).setOnUpdate((Action<float>) (a => splatter.color = Color.Lerp(from, to, a)));
    }
    Vector3 to1 = transform.localScale * this.splatterScaleRange.PettyRandom();
    transform.localScale = to1 * 0.5f;
    LeanTween.scale(splatter.gameObject, to1, PettyRandom.Range(0.12f, 0.18f)).setEase(LeanTweenType.easeOutBack);
    transform.position = particle.transform.position;
    transform.localPosition = transform.localPosition.WithZ(0.0f);
    if (!this.limitSplatters)
      return;
    int num = this.splatters.Count - this.maxSplatters;
    for (int index = 0; index < num; ++index)
    {
      this.splatters[0].FadeOut();
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

  public Splatter[] GetActiveSplatters() => this.splatters.Where<Splatter>((Func<Splatter, bool>) (a => !a.fading)).ToArray<Splatter>();

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
