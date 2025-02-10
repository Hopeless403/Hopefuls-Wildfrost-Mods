// Decompiled with JetBrains decompiler
// Type: CardSlot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
public class CardSlot : CardContainer
{
  [SerializeField]
  public SpriteRenderer icon;
  public Color originalIconColor;

  public void Awake() => this.originalIconColor = this.icon.color;

  public override void SetSize(int size, float cardScale)
  {
    base.SetSize(size, cardScale);
    this.holder.sizeDelta = GameManager.CARD_SIZE * cardScale;
  }

  public override void CardAdded(Entity entity) => this.FadeOutIcon();

  public override void CardRemoved(Entity entity)
  {
    if (!this.Empty)
      return;
    this.FadeInIcon();
  }

  public void ForceHover() => this.cc?.HoverSlot(this);

  public void ForceUnHover()
  {
    if (!((Object) this.cc != (Object) null) || !((Object) this.cc.hoverSlot == (Object) this))
      return;
    this.cc.UnHoverSlot();
  }

  public override void Hover()
  {
    if (!this.canHover || !((Object) this.cc != (Object) null))
      return;
    this.cc.HoverSlot(this);
  }

  public override void UnHover()
  {
    if (!this.canHover || !((Object) this.cc != (Object) null) || !((Object) this.cc.hoverSlot == (Object) this))
      return;
    this.cc.UnHoverSlot();
  }

  public void FadeOutIcon()
  {
    LeanTween.cancel(this.icon.gameObject);
    LeanTween.color(this.icon.gameObject, this.originalIconColor.With(alpha: 0.0f), 0.33f);
  }

  public void FadeInIcon()
  {
    LeanTween.cancel(this.icon.gameObject);
    LeanTween.color(this.icon.gameObject, this.originalIconColor, 0.33f);
  }
}
