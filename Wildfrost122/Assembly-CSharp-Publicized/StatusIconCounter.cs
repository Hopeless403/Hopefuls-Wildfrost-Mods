// Decompiled with JetBrains decompiler
// Type: StatusIconCounter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class StatusIconCounter : StatusIcon
{
  [SerializeField]
  public Image image;
  [SerializeField]
  public Sprite customSprite;
  [SerializeField]
  public Material customMaterial;
  [SerializeField]
  public Sprite snowSprite;
  [SerializeField]
  public Material snowMaterial;
  public CardIdleAnimation imminentAnimation;
  public Sprite baseSprite;
  public Material baseMaterial;

  public void Awake()
  {
    this.baseSprite = this.image.sprite;
    this.baseMaterial = this.textElement.fontSharedMaterial;
  }

  public void CheckSetSprite()
  {
    Stat stat = this.GetValue();
    Sprite sprite = this.baseSprite;
    Material material = this.baseMaterial;
    if ((Object) this.target != (Object) null && this.target.IsSnowed)
    {
      sprite = this.snowSprite ?? this.baseSprite;
      material = this.snowMaterial ?? this.baseMaterial;
    }
    else if (stat.current <= 1)
    {
      sprite = this.customSprite ?? this.baseSprite;
      material = this.customMaterial ?? this.baseMaterial;
    }
    if ((Object) sprite != (Object) null)
      this.image.sprite = sprite;
    if (!((Object) material != (Object) null))
      return;
    this.textElement.fontSharedMaterial = material;
  }
}
