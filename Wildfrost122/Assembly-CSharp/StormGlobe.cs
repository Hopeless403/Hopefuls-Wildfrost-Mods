// Decompiled with JetBrains decompiler
// Type: StormGlobe
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class StormGlobe : ScriptableCardImage
{
  [SerializeField]
  private Image image;
  [SerializeField]
  private Sprite[] sprites;
  [SerializeField]
  private AnimationCurve spriteIndexCurve;
  private int effectBonus;

  public override void UpdateEvent()
  {
    if (this.entity.effectBonus == this.effectBonus)
      return;
    this.effectBonus = this.entity.effectBonus;
    this.image.sprite = this.sprites[Mathf.Clamp(Mathf.RoundToInt(this.spriteIndexCurve.Evaluate((float) this.effectBonus)), 0, this.sprites.Length - 1)];
  }
}
