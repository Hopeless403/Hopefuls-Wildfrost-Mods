// Decompiled with JetBrains decompiler
// Type: DeckDisplayGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using TMPro;
using UnityEngine;

#nullable disable
public class DeckDisplayGroup : MonoBehaviour
{
  public TextMeshProUGUI titleElement;
  public CardContainerGrid[] grids;
  [SerializeField]
  public CardController cardController;

  public IEnumerator CreateCard(CardData data)
  {
    Card card = CardManager.Get(data, this.cardController, (Character) null, false, true);
    this.AddCard(card);
    yield return (object) card.UpdateData(false);
  }

  public CardContainerGrid GetGrid(Card card) => this.GetGrid(card.entity.data);

  public CardContainerGrid GetGrid(CardData cardData)
  {
    return this.grids.Length <= 1 || !(cardData.cardType.tag == "Friendly") ? this.grids[0] : this.grids[1];
  }

  public void AddCard(Card card)
  {
    CardContainerGrid grid = this.GetGrid(card);
    grid.Add(card.entity);
    card.entity.owner = grid.owner;
  }

  public void InsertCard(int index, Card card)
  {
    CardContainerGrid grid = this.GetGrid(card);
    grid.Insert(index, card.entity);
    card.entity.owner = grid.owner;
  }

  public void RemoveCard(Card card) => this.GetGrid(card).Remove(card.entity);

  public void UpdatePositions()
  {
    foreach (CardContainer grid in this.grids)
      grid.SetChildPositions();
  }

  public void Clear()
  {
    foreach (CardContainerGrid grid in this.grids)
      grid.DestroyAll();
  }
}
