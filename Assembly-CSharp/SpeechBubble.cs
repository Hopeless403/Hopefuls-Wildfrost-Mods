// Decompiled with JetBrains decompiler
// Type: SpeechBubble
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using TMPro;
using UnityEngine;

public class SpeechBubble : MonoBehaviour
{
  [SerializeField]
  private TMP_Text textElement;

  public void SetSize(float size) => this.textElement.fontSize = size;

  public void SetTextColour(Color color) => this.textElement.color = color;

  public void SetTextSpriteAsset(TMP_SpriteAsset spriteAsset) => this.textElement.spriteAsset = spriteAsset;

  public void SetText(string text) => this.textElement.text = text;
}
