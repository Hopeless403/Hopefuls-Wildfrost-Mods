// Decompiled with JetBrains decompiler
// Type: Splatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using Dead;
using System;
using UnityEngine;
using UnityEngine.UI;

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

  public void FadeOut()
  {
    if (this.fading)
      return;
    LeanTween.cancel(this.gameObject);
    LeanTween.value(this.gameObject, this.image.color.a, 0.0f, PettyRandom.Range(10f, 15f)).setOnUpdate((Action<float>) (a => this.image.color = this.image.color.With(alpha: a))).setEase(LeanTweenType.easeInOutQuint).setOnComplete((System.Action) (() => this.gameObject.Destroy()));
    this.fading = true;
  }
}
