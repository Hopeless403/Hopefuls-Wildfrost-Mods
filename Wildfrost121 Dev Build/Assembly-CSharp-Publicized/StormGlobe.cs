// Decompiled with JetBrains decompiler
// Type: StormGlobe
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.UI;

#nullable disable
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
