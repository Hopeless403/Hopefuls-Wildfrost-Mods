// Decompiled with JetBrains decompiler
// Type: ScreenFlashSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
public class ScreenFlashSystem : GameSystem
{
  public static ScreenFlashSystem instance;
  [SerializeField]
  public SpriteRenderer renderer;
  [SerializeField]
  public AnimationCurve curve;
  [SerializeField]
  public Material basicMaterial;
  [SerializeField]
  public Material additiveMaterial;
  public Color color;
  public float current;
  public float duration;
  public float amount = 1f;

  public void Awake() => ScreenFlashSystem.instance = this;

  public void Update()
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

  public void _SetDrawOrder(string sortingLayer, int orderInLayer)
  {
    this.renderer.sortingLayerName = sortingLayer;
    this.renderer.sortingOrder = orderInLayer;
  }

  public void _Run(float duration)
  {
    this.current = 0.0f;
    this.renderer.enabled = true;
    this.duration = duration;
    this.amount = Mathf.Max(0.2f, Settings.Load<float>("ScreenFlash", 1f));
  }
}
