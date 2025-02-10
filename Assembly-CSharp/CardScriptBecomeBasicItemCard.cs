// Decompiled with JetBrains decompiler
// Type: CardScriptBecomeBasicItemCard
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

[CreateAssetMenu(fileName = "Become Basic Item Card", menuName = "Card Scripts/Become Basic Item Card")]
public class CardScriptBecomeBasicItemCard : CardScript
{
  public override void Run(CardData target)
  {
    target.playType = Card.PlayType.Play;
    target.needsTarget = true;
    target.canPlayOnBoard = true;
    target.canPlayOnHand = false;
    target.canPlayOnFriendly = true;
    target.canPlayOnEnemy = true;
    target.playOnSlot = false;
    target.defaultPlayPosition = CardData.PlayPosition.None;
  }
}
