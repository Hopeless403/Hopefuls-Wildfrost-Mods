// Decompiled with JetBrains decompiler
// Type: SpeechBubble
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using TMPro;
using UnityEngine;

#nullable disable
public class SpeechBubble : MonoBehaviour
{
  [SerializeField]
  private TMP_Text textElement;

  public void SetSize(float size) => this.textElement.fontSize = size;

  public void SetTextColour(Color color) => this.textElement.color = color;

  public void SetTextSpriteAsset(TMP_SpriteAsset spriteAsset)
  {
    this.textElement.spriteAsset = spriteAsset;
  }

  public void SetText(string text) => this.textElement.text = text;
}
