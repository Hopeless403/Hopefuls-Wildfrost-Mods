// Decompiled with JetBrains decompiler
// Type: DeckDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
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
