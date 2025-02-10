// Decompiled with JetBrains decompiler
// Type: TurnOrderNumber
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TurnOrderNumber : MonoBehaviour
{
  [SerializeField]
  public Image glow;
  [SerializeField]
  public Color imminentGlowColour = Color.red;
  [SerializeField]
  public Image image;
  [SerializeField]
  public Sprite imminentSprite;
  [SerializeField]
  public TMP_Text textElement;

  public void Set(Entity entity, int number)
  {
    this.textElement.text = number.ToString();
    if (entity.counter.current > 1 || entity.IsSnowed)
      return;
    this.glow.color = this.imminentGlowColour;
    this.image.sprite = this.imminentSprite;
  }
}
