// Decompiled with JetBrains decompiler
// Type: TurnOrderNumber
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TurnOrderNumber : MonoBehaviour
{
  [SerializeField]
  private Image glow;
  [SerializeField]
  private Color imminentGlowColour = Color.red;
  [SerializeField]
  private Image image;
  [SerializeField]
  private Sprite imminentSprite;
  [SerializeField]
  private TMP_Text textElement;

  public void Set(Entity entity, int number)
  {
    this.textElement.text = number.ToString();
    if (entity.counter.current > 1 || entity.IsSnowed)
      return;
    this.glow.color = this.imminentGlowColour;
    this.image.sprite = this.imminentSprite;
  }
}
