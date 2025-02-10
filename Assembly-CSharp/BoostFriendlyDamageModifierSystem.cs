// Decompiled with JetBrains decompiler
// Type: BoostFriendlyDamageModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine.Events;

public class BoostFriendlyDamageModifierSystem : GameSystem
{
  private const int attackAdd = 1;

  private void OnEnable() => global::Events.OnCardDataCreated += new UnityAction<CardData>(BoostFriendlyDamageModifierSystem.CardDataCreated);

  private void OnDisable() => global::Events.OnCardDataCreated -= new UnityAction<CardData>(BoostFriendlyDamageModifierSystem.CardDataCreated);

  private static void CardDataCreated(CardData cardData)
  {
    if (!(cardData.cardType.name == "Friendly") || !cardData.hasAttack)
      return;
    ++cardData.damage;
  }
}
