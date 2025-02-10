// Decompiled with JetBrains decompiler
// Type: SwayerColour
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using Dead;
using NaughtyAttributes;
using UnityEngine;
using UnityEngine.UI;

public class SwayerColour : MonoBehaviour
{
  [SerializeField]
  private bool randomStart;
  [HideIf("sprite")]
  public Graphic graphic;
  [HideIf("ui")]
  public SpriteRenderer renderer;
  public Gradient gradient;
  public float speed = 1f;
  public AnimationCurve curve;
  private float t;

  private bool ui => (Object) this.graphic != (Object) null;

  private bool sprite => (Object) this.renderer != (Object) null;

  private void Awake()
  {
    if (!this.randomStart)
      return;
    this.t = PettyRandom.Range(0.0f, 10f);
  }

  private void Update()
  {
    this.t = (float) (((double) this.t + (double) Time.deltaTime * (double) this.speed) % 1.0);
    Color color = this.gradient.Evaluate(this.curve.Evaluate(this.t));
    if (this.ui)
      this.graphic.color = color;
    if (!this.sprite)
      return;
    this.renderer.color = color;
  }
}
