﻿// Decompiled with JetBrains decompiler
// Type: ScreenFlashSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
public class ScreenFlashSystem : GameSystem
{
  private static ScreenFlashSystem instance;
  [SerializeField]
  private SpriteRenderer renderer;
  [SerializeField]
  private AnimationCurve curve;
  [SerializeField]
  private Material basicMaterial;
  [SerializeField]
  private Material additiveMaterial;
  private Color color;
  private float current;
  private float duration;
  private float amount = 1f;

  private void Awake() => ScreenFlashSystem.instance = this;

  private void Update()
  {
    if (!this.renderer.enabled)
      return;
    this.current += Time.deltaTime;
    this.renderer.color = this.color.WithAlpha(this.curve.Evaluate(Mathf.Min(1f, this.current / this.duration)) * this.amount);
    if ((double) this.current < (double) this.duration)
      return;
    this.renderer.enabled = false;
    this.renderer.material = this.basicMaterial;
  }

  public static void SetDrawOrder(string sortingLayer, int orderInLayer)
  {
    ScreenFlashSystem.instance._SetDrawOrder(sortingLayer, orderInLayer);
  }

  public static void SetColour(Color color) => ScreenFlashSystem.instance.color = color;

  public static void SetMaterialAdditive()
  {
    ScreenFlashSystem.instance.renderer.material = ScreenFlashSystem.instance.additiveMaterial;
  }

  public static void Run(float duration) => ScreenFlashSystem.instance._Run(duration);

  private void _SetDrawOrder(string sortingLayer, int orderInLayer)
  {
    this.renderer.sortingLayerName = sortingLayer;
    this.renderer.sortingOrder = orderInLayer;
  }

  private void _Run(float duration)
  {
    this.current = 0.0f;
    this.renderer.enabled = true;
    this.duration = duration;
    this.amount = Mathf.Max(0.2f, Settings.Load<float>("ScreenFlash", 1f));
  }
}
