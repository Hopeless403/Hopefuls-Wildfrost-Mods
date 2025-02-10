// Decompiled with JetBrains decompiler
// Type: ToggleSprite
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class ToggleSprite : MonoBehaviour
{
  [SerializeField]
  private Image image;
  [SerializeField]
  private Sprite onSprite;
  [SerializeField]
  private Sprite offSprite;

  public void Set(bool value) => this.image.sprite = value ? this.onSprite : this.offSprite;
}
