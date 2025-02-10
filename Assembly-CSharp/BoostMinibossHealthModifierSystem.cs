// Decompiled with JetBrains decompiler
// Type: BoostMinibossHealthModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;

public class BoostMinibossHealthModifierSystem : GameSystem
{
  private const float healthFactor = 1.1f;

  private void OnEnable() => global::Events.OnCardDataCreated += new UnityAction<CardData>(this.CardDataCreated);

  private void OnDisable() => global::Events.OnCardDataCreated -= new UnityAction<CardData>(this.CardDataCreated);

  private void CardDataCreated(CardData cardData)
  {
    string name = cardData.cardType.name;
    if (!(name == "Miniboss") && !(name == "Boss"))
      return;
    if (cardData.hasHealth)
      this.BoostHealth(cardData, 1.1f);
    else
      this.BoostStatusEffect(cardData, "scrap", 1.1f);
  }

  private void BoostHealth(CardData cardData, float factor)
  {
    float f = (float) cardData.hp * factor;
    cardData.hp = Mathf.RoundToInt(f);
  }

  private void BoostStatusEffect(CardData cardData, string statusType, float factor)
  {
    foreach (CardData.StatusEffectStacks startWithEffect in cardData.startWithEffects)
    {
      if (!(startWithEffect.data.type != statusType))
      {
        float f = (float) startWithEffect.count * factor;
        startWithEffect.count = Mathf.RoundToInt(f);
      }
    }
  }
}
