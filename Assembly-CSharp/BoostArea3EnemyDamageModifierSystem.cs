// Decompiled with JetBrains decompiler
// Type: BoostArea3EnemyDamageModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine.Events;

public class BoostArea3EnemyDamageModifierSystem : GameSystem
{
  private const int area = 2;
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
    this.correctArea = node.areaIndex == 2;
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
