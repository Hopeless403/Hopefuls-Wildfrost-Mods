// Decompiled with JetBrains decompiler
// Type: ToggleSprite
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.UI;

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
