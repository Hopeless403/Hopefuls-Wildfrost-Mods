// Decompiled with JetBrains decompiler
// Type: TargetConstraintIsInDeck
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Is In Deck", menuName = "Target Constraints/Is In Deck")]
public class TargetConstraintIsInDeck : TargetConstraint
{
  [SerializeField]
  private bool includeReserve = true;

  public override bool Check(CardData targetData)
  {
    if (References.PlayerData == null)
      return false;
    if (TargetConstraintIsInDeck.IsInDeck(targetData))
      return true;
    return this.includeReserve && TargetConstraintIsInDeck.IsInReserve(targetData);
  }

  public override bool Check(Entity target) => this.Check(target.data);

  private static bool IsInDeck(CardData cardData)
  {
    return References.PlayerData.inventory.deck.Contains(cardData);
  }

  private static bool IsInReserve(CardData cardData)
  {
    return References.PlayerData.inventory.reserve.Contains(cardData);
  }
}
