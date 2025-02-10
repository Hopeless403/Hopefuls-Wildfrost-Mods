// Decompiled with JetBrains decompiler
// Type: CardSlot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
public class CardSlot : CardContainer
{
  [SerializeField]
  private SpriteRenderer icon;
  private Color originalIconColor;

  private void Awake() => this.originalIconColor = this.icon.color;

  public override void SetSize(int size, float cardScale)
  {
    base.SetSize(size, cardScale);
    this.holder.sizeDelta = GameManager.CARD_SIZE * cardScale;
  }

  protected override void CardAdded(Entity entity) => this.FadeOutIcon();

  protected override void CardRemoved(Entity entity)
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

  private void FadeOutIcon()
  {
    LeanTween.cancel(this.icon.gameObject);
    LeanTween.color(this.icon.gameObject, this.originalIconColor.With(alpha: 0.0f), 0.33f);
  }

  private void FadeInIcon()
  {
    LeanTween.cancel(this.icon.gameObject);
    LeanTween.color(this.icon.gameObject, this.originalIconColor, 0.33f);
  }
}
