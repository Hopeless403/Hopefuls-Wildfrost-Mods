// Decompiled with JetBrains decompiler
// Type: ColourFader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[RequireComponent(typeof (Graphic))]
public class ColourFader : MonoBehaviour
{
  private Graphic _graphic;
  [SerializeField]
  private ColourFader.Colour[] colours;
  [SerializeField]
  private float duration;
  private Color targetColour;
  private float fadeAmount;
  private float fadeDuration;

  private Graphic graphic => this._graphic ?? (this._graphic = this.GetComponent<Graphic>());

  public void FadeToColour(string name)
  {
    foreach (ColourFader.Colour colour in this.colours)
    {
      if (colour.name == name)
      {
        this.FadeToColour(colour.colour);
        break;
      }
    }
  }

  public void FadeToColour(Color colour)
  {
    this.fadeAmount = 0.0f;
    this.fadeDuration = this.duration;
    this.targetColour = colour;
  }

  private void Update()
  {
    if ((double) this.fadeAmount >= (double) this.fadeDuration)
      return;
    this.fadeAmount += Time.deltaTime * this.fadeDuration;
    this.graphic.color = Color.Lerp(this.graphic.color, this.targetColour, this.fadeAmount);
  }

  [Serializable]
  public struct Colour
  {
    public string name;
    public Color colour;
  }
}
