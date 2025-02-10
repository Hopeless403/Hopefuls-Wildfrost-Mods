// Decompiled with JetBrains decompiler
// Type: BoostArea2EnemyDamageModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine.Events;

#nullable disable
public class BoostArea2EnemyDamageModifierSystem : GameSystem
{
  public const int area = 1;
  public const int damageAdd = 1;
  public bool correctArea;

  public void OnEnable()
  {
    global::Events.PreBattleSetUp += new UnityAction<CampaignNode>(this.PreBattleSetUp);
    global::Events.PostBattleSetUp += new UnityAction<CampaignNode>(this.PostBattleSetUp);
  }

  public void OnDisable()
  {
    global::Events.PreBattleSetUp -= new UnityAction<CampaignNode>(this.PreBattleSetUp);
    global::Events.PostBattleSetUp -= new UnityAction<CampaignNode>(this.PostBattleSetUp);
  }

  public void PreBattleSetUp(CampaignNode node)
  {
    this.correctArea = node.areaIndex == 1;
    if (!this.correctArea)
      return;
    global::Events.OnCardDataCreated += new UnityAction<CardData>(this.CardDataCreated);
  }

  public void PostBattleSetUp(CampaignNode node)
  {
    if (this.correctArea)
      global::Events.OnCardDataCreated -= new UnityAction<CardData>(this.CardDataCreated);
    this.correctArea = false;
  }

  public void CardDataCreated(CardData cardData)
  {
    if (!this.correctArea)
      return;
    string name = cardData.cardType.name;
    if (!(name == "Enemy") && !(name == "Miniboss") && !(name == "Boss") || !cardData.hasAttack)
      return;
    ++cardData.damage;
  }
}
