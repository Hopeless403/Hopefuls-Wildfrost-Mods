// Decompiled with JetBrains decompiler
// Type: StatusIconCharge
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.UI;

public class StatusIconCharge : StatusIcon
{
  public Sprite chargedSprite;
  public Material chargedMaterial;
  public Sprite snowSprite;
  public Material snowMaterial;
  public Image _image;
  public Sprite baseSprite;
  public Material baseMaterial;

  public Image image
  {
    get
    {
      if ((Object) this._image == (Object) null)
      {
        this._image = this.GetComponent<Image>();
        this.baseSprite = this._image.sprite;
      }
      return this._image;
    }
  }

  public void Awake() => this.baseMaterial = this.textElement.fontSharedMaterial;

  public void CheckSetSprite()
  {
    Stat stat = this.GetValue();
    Sprite sprite = this.baseSprite;
    Material material = this.baseMaterial;
    if ((Object) this.target != (Object) null && this.target.IsSnowed)
    {
      sprite = this.snowSprite ?? this.baseSprite;
      material = this.snowMaterial ?? this.baseMaterial;
      this.textElement.gameObject.SetActive(true);
    }
    else if (stat.current <= 0)
    {
      sprite = this.chargedSprite ?? this.baseSprite;
      material = this.chargedMaterial ?? this.baseMaterial;
      this.textElement.gameObject.SetActive(false);
    }
    else
      this.textElement.gameObject.SetActive(true);
    if ((Object) sprite != (Object) null)
      this.image.sprite = sprite;
    if (!((Object) material != (Object) null))
      return;
    this.textElement.fontSharedMaterial = material;
  }
}
