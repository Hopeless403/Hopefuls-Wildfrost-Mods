// Decompiled with JetBrains decompiler
// Type: StormGlobe
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.UI;

public class StormGlobe : ScriptableCardImage
{
  [SerializeField]
  public Image image;
  [SerializeField]
  public Sprite[] sprites;
  [SerializeField]
  public AnimationCurve spriteIndexCurve;
  public int effectBonus;

  public override void UpdateEvent()
  {
    if (this.entity.effectBonus == this.effectBonus)
      return;
    this.effectBonus = this.entity.effectBonus;
    this.image.sprite = this.sprites[Mathf.Clamp(Mathf.RoundToInt(this.spriteIndexCurve.Evaluate((float) this.effectBonus)), 0, this.sprites.Length - 1)];
  }
}
