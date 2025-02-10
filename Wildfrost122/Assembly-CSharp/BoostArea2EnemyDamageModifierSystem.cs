// Decompiled with JetBrains decompiler
// Type: BoostArea2EnemyDamageModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine.Events;

#nullable disable
public class BoostArea2EnemyDamageModifierSystem : GameSystem
{
  private const int area = 1;
  private const int damageAdd = 1;
  private bool correctArea;

  private void OnEnable()
  {
    global::Events.PreBattleSetUp += new UnityAction<CampaignNode>(this.PreBattleSetUp);
    global::Events.PostBattleSetUp += new UnityAction<CampaignNode>(this.PostBattleSetUp);
  }

  private void OnDisable()
  {
    global::Events.PreBattleSetUp -= new UnityAction<CampaignNode>(this.PreBattleSetUp);
    global::Events.PostBattleSetUp -= new UnityAction<CampaignNode>(this.PostBattleSetUp);
  }

  private void PreBattleSetUp(CampaignNode node)
  {
    this.correctArea = node.areaIndex == 1;
    if (!this.correctArea)
      return;
    global::Events.OnCardDataCreated += new UnityAction<CardData>(this.CardDataCreated);
  }

  private void PostBattleSetUp(CampaignNode node)
  {
    if (this.correctArea)
      global::Events.OnCardDataCreated -= new UnityAction<CardData>(this.CardDataCreated);
    this.correctArea = false;
  }

  private void CardDataCreated(CardData cardData)
  {
    if (!this.correctArea)
      return;
    string name = cardData.cardType.name;
    if (!(name == "Enemy") && !(name == "Miniboss") && !(name == "Boss") || !cardData.hasAttack)
      return;
    ++cardData.damage;
  }
}
