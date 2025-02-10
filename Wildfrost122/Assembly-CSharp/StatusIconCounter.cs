// Decompiled with JetBrains decompiler
// Type: StatusIconCounter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class StatusIconCounter : StatusIcon
{
  [SerializeField]
  private Image image;
  [SerializeField]
  private Sprite customSprite;
  [SerializeField]
  private Material customMaterial;
  [SerializeField]
  private Sprite snowSprite;
  [SerializeField]
  private Material snowMaterial;
  public CardIdleAnimation imminentAnimation;
  private Sprite baseSprite;
  private Material baseMaterial;

  private void Awake()
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
