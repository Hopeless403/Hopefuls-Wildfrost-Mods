// Decompiled with JetBrains decompiler
// Type: DeckDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
public class DeckDisplay : MonoBehaviour
{
  [SerializeField]
  private Character owner;
  public DeckDisplaySequence displaySequence;
  public CompanionLimitSequence companionLimitSequence;
  public CompanionRecoverSequence companionRecoverSequence;
  [SerializeField]
  private CardController[] cardControllers;
  [SerializeField]
  private CardContainer[] cardContainers;
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
