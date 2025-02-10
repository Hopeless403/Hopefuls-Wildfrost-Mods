// Decompiled with JetBrains decompiler
// Type: BoardDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class BoardDisplay : MonoBehaviour
{
  public Character player;
  public Character enemy;
  public int playerRowLength = 3;
  public int enemyRowLength = 3;
  [Range(0.0f, 1f)]
  public float cardScale = 0.333333343f;
  [SerializeField]
  private LayoutGroup layout;
  [Header("Card Container References")]
  public CardContainer playerReserve;
  public CardContainer[] playerRows;
  public CardContainer enemyReserve;
  public CardContainer[] enemyRows;

  public IEnumerator SetUp(CampaignNode node, CardController cardController)
  {
    this.layout.enabled = false;
    if ((Object) this.playerReserve != (Object) null)
    {
      this.playerReserve.owner = this.player;
      this.player.reserveContainer = this.playerReserve;
      this.playerReserve.SetSize(999, this.cardScale);
      this.playerReserve.AssignController(cardController);
    }
    if ((Object) this.enemyReserve != (Object) null)
    {
      this.enemyReserve.owner = this.enemy;
      this.enemy.reserveContainer = this.enemyReserve;
      this.enemyReserve.SetSize(999, this.cardScale);
      this.enemyReserve.AssignController(cardController);
    }
    for (int index = 0; index < this.playerRows.Length; ++index)
    {
      CardContainer playerRow = this.playerRows[index];
      playerRow.owner = this.player;
      playerRow.SetSize(this.playerRowLength, this.cardScale);
      playerRow.AssignController(cardController);
      if (playerRow is CardSlotLane cardSlotLane)
        cardSlotLane.SetDirection(1);
      References.Battle.rows[this.player].Add(playerRow);
      References.Battle.rowIndices[playerRow] = index;
    }
    for (int index = 0; index < this.enemyRows.Length; ++index)
    {
      CardContainer enemyRow = this.enemyRows[index];
      enemyRow.owner = this.enemy;
      enemyRow.SetSize(this.enemyRowLength, this.cardScale);
      enemyRow.AssignController(cardController);
      if (enemyRow is CardSlotLane cardSlotLane)
        cardSlotLane.SetDirection(-1);
      References.Battle.rows[this.enemy].Add(enemyRow);
      References.Battle.rowIndices[enemyRow] = index;
    }
    yield return (object) null;
    this.layout.enabled = true;
  }
}
