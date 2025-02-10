// Decompiled with JetBrains decompiler
// Type: Splatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using Dead;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class Splatter : MonoBehaviour
{
  [SerializeField]
  private Sprite[] spriteOptions;
  [SerializeField]
  private Vector2 sizeRange = new Vector2(1.5f, 2f);
  [SerializeField]
  private Vector2 angleRange = new Vector2(0.0f, 360f);
  [SerializeField]
  private Image image;

  public bool fading { get; private set; }

  public Sprite sprite
  {
    get => this.image.sprite;
    set => this.image.sprite = value;
  }

  public Color color
  {
    get => this.image.color;
    set => this.image.color = value;
  }

  private void Awake()
  {
    this.image.sprite = this.spriteOptions[PettyRandom.Range(0, this.spriteOptions.Length - 1)];
    this.transform.localEulerAngles = new Vector3(0.0f, 0.0f, this.angleRange.PettyRandom());
    this.transform.localScale = Vector3.one * this.sizeRange.PettyRandom();
  }

  public void FadeOut(float reduceTime = 0.0f)
  {
    if (this.fading)
      return;
    float time = Mathf.Max(0.1f, PettyRandom.Range(10f, 15f) - reduceTime);
    if (SplatterSystem.CheckStartTween(time))
    {
      LeanTween.cancel(this.gameObject);
      LeanTween.value(this.gameObject, this.image.color.a, 0.0f, time).setOnUpdate((Action<float>) (a => this.image.color = this.image.color.With(alpha: a))).setEase(LeanTweenType.easeInOutQuint).setOnComplete((System.Action) (() => this.gameObject.Destroy()));
      this.fading = true;
    }
    else
      this.gameObject.Destroy();
  }
}
