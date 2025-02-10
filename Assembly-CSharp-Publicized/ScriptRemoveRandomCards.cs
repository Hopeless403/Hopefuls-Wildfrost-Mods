// Decompiled with JetBrains decompiler
// Type: ScriptRemoveRandomCards
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "Remove Random Cards", menuName = "Scripts/Remove Random Cards")]
public class ScriptRemoveRandomCards : Script
{
  [SerializeField]
  public Vector2Int countRange;
  [SerializeField]
  public CardType[] cardTypes;

  public override IEnumerator Run()
  {
    // ISSUE: reference to a compiler-generated field
    int num1 = this.\u003C\u003E1__state;
    ScriptRemoveRandomCards removeRandomCards = this;
    if (num1 != 0)
      return false;
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = -1;
    CardData[] array = References.PlayerData.inventory.deck.Where<CardData>(new Func<CardData, bool>(removeRandomCards.Eligible)).InRandomOrder<CardData>().ToArray<CardData>();
    int num2 = removeRandomCards.countRange.Random();
    for (int index = 0; index < num2; ++index)
    {
      CardData cardData = array[index];
      References.PlayerData.inventory.deck.Remove(cardData);
      Debug.Log((object) (removeRandomCards.name + " → Removing " + cardData.name + " from player's deck"));
    }
    return false;
  }

  public bool Eligible(CardData cardData) => this.cardTypes.Length == 0 || this.cardTypes.Contains<CardType>(cardData.cardType);
}
