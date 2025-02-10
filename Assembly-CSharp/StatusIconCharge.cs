// Decompiled with JetBrains decompiler
// Type: StatusIconCharge
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.UI;

public class StatusIconCharge : StatusIcon
{
  public Sprite chargedSprite;
  public Material chargedMaterial;
  public Sprite snowSprite;
  public Material snowMaterial;
  private Image _image;
  private Sprite baseSprite;
  private Material baseMaterial;

  private Image image
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

  private void Awake() => this.baseMaterial = this.textElement.fontSharedMaterial;

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
