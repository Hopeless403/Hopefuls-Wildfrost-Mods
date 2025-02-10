// Decompiled with JetBrains decompiler
// Type: ColourFader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[RequireComponent(typeof (Graphic))]
public class ColourFader : MonoBehaviour
{
  public Graphic _graphic;
  [SerializeField]
  public ColourFader.Colour[] colours;
  [SerializeField]
  public float duration;
  public Color targetColour;
  public float fadeAmount;
  public float fadeDuration;

  public Graphic graphic => this._graphic ?? (this._graphic = this.GetComponent<Graphic>());

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

  public void Update()
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
