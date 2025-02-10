// Decompiled with JetBrains decompiler
// Type: SwayerColour
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using Dead;
using NaughtyAttributes;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class SwayerColour : MonoBehaviour
{
  [SerializeField]
  public bool randomStart;
  [HideIf("sprite")]
  public Graphic graphic;
  [HideIf("ui")]
  public SpriteRenderer renderer;
  public Gradient gradient;
  public float speed = 1f;
  public AnimationCurve curve;
  public float t;

  public bool ui => (Object) this.graphic != (Object) null;

  public bool sprite => (Object) this.renderer != (Object) null;

  public void Awake()
  {
    if (!this.randomStart)
      return;
    this.t = PettyRandom.Range(0.0f, 10f);
  }

  public void Update()
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
