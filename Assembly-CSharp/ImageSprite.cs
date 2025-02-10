// Decompiled with JetBrains decompiler
// Type: ImageSprite
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.UI;

public class ImageSprite : Image
{
  [SerializeField]
  private bool copySpriteSize = true;
  [SerializeField]
  private bool copySpritePivot = true;

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
