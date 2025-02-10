// Decompiled with JetBrains decompiler
// Type: DeckDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

public class DeckDisplay : MonoBehaviour
{
  [SerializeField]
  public Character owner;
  public DeckDisplaySequence displaySequence;
  public CompanionLimitSequence companionLimitSequence;
  public CompanionRecoverSequence companionRecoverSequence;
  [SerializeField]
  public CardController[] cardControllers;
  [SerializeField]
  public CardContainer[] cardContainers;
  public UINavigationItem backButtonNavigationItem;

  public void SetOwner(Character owner)
  {
    this.owner = owner;
    this.displaySequence.owner = owner;
    foreach (CardController cardController in this.cardControllers)
      cardController.owner = owner;
    foreach (CardContainer cardContainer in this.cardContainers)
      cardContainer.owner = owner;
    if ((Object) this.companionLimitSequence != (Object) null)
      this.companionLimitSequence.owner = owner;
    if (!((Object) this.companionRecoverSequence != (Object) null))
      return;
    this.companionRecoverSequence.owner = owner;
  }
}
