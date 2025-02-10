// Decompiled with JetBrains decompiler
// Type: ImageSprite
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class ImageSprite : Image
{
  [SerializeField]
  public bool copySpriteSize = true;
  [SerializeField]
  public bool copySpritePivot = true;

  public void SetSprite(Sprite sprite)
  {
    this.sprite = sprite;
    if (!(bool) (Object) sprite)
      return;
    Vector2 size = sprite.rect.size;
    if (this.copySpritePivot)
    {
      Vector3 anchoredPosition3D = this.rectTransform.anchoredPosition3D;
      this.rectTransform.pivot = sprite.pivot / size;
      this.rectTransform.anchoredPosition3D = anchoredPosition3D;
    }
    if (!this.copySpriteSize)
      return;
    this.rectTransform.sizeDelta = size / sprite.pixelsPerUnit;
  }
}
