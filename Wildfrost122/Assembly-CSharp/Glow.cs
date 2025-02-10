// Decompiled with JetBrains decompiler
// Type: Glow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using Dead;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class Glow : MonoBehaviourRect
{
  [SerializeField]
  private Image image;
  [SerializeField]
  private AnimationCurve fadeCurve;
  [SerializeField]
  private float fadeDuration = 0.5f;
  private float delay;
  private float t;

  public Glow SetSize(Vector2 size)
  {
    this.rectTransform.sizeDelta = size;
    return this;
  }

  public Glow SetPosition(Vector2 position)
  {
    this.rectTransform.anchoredPosition = position;
    return this;
  }

  public Glow SetColor(Color color)
  {
    this.image.color = color;
    return this;
  }

  public Glow RandomColor(float saturation = 1f, float brightness = 1f)
  {
    this.image.color = Color.HSVToRGB(PettyRandom.Range(0.0f, 1f), saturation, brightness);
    return this;
  }

  public Glow Fade(AnimationCurve curve, float duration, float delay = 0.0f)
  {
    this.image.color = this.image.color.WithAlpha(0.0f);
    this.fadeCurve = curve;
    this.fadeDuration = duration;
    this.t = 0.0f;
    this.delay = delay;
    return this;
  }

  private void Update()
  {
    if ((double) this.delay > 0.0)
    {
      this.delay -= Time.deltaTime;
    }
    else
    {
      this.t += Time.deltaTime / this.fadeDuration;
      this.image.color = this.image.color.WithAlpha(this.fadeCurve.Evaluate(this.t));
      if ((double) this.t <= 1.0)
        return;
      Object.Destroy((Object) this.gameObject);
    }
  }
}
