// Decompiled with JetBrains decompiler
// Type: Splatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using Dead;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class Splatter : MonoBehaviour
{
  [SerializeField]
  public Sprite[] spriteOptions;
  [SerializeField]
  public Vector2 sizeRange = new Vector2(1.5f, 2f);
  [SerializeField]
  public Vector2 angleRange = new Vector2(0.0f, 360f);
  [SerializeField]
  public Image image;
  [CompilerGenerated]
  public bool \u003Cfading\u003Ek__BackingField;

  public bool fading
  {
    get => this.\u003Cfading\u003Ek__BackingField;
    set => this.\u003Cfading\u003Ek__BackingField = value;
  }

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

  public void Awake()
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

  [CompilerGenerated]
  public void \u003CFadeOut\u003Eb__15_0(float a)
  {
    this.image.color = this.image.color.With(alpha: a);
  }

  [CompilerGenerated]
  public void \u003CFadeOut\u003Eb__15_1() => this.gameObject.Destroy();
}
