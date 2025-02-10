// Decompiled with JetBrains decompiler
// Type: SpeechBubble
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using TMPro;
using UnityEngine;

public class SpeechBubble : MonoBehaviour
{
  [SerializeField]
  public TMP_Text textElement;

  public void SetSize(float size) => this.textElement.fontSize = size;

  public void SetTextColour(Color color) => this.textElement.color = color;

  public void SetTextSpriteAsset(TMP_SpriteAsset spriteAsset) => this.textElement.spriteAsset = spriteAsset;

  public void SetText(string text) => this.textElement.text = text;
}
