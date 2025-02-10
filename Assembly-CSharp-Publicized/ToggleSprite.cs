// Decompiled with JetBrains decompiler
// Type: ToggleSprite
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.UI;

public class ToggleSprite : MonoBehaviour
{
  [SerializeField]
  public Image image;
  [SerializeField]
  public Sprite onSprite;
  [SerializeField]
  public Sprite offSprite;

  public void Set(bool value) => this.image.sprite = value ? this.onSprite : this.offSprite;
}
