// Decompiled with JetBrains decompiler
// Type: BoostMinibossHealthModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class BoostMinibossHealthModifierSystem : GameSystem
{
  public const float healthFactor = 1.1f;

  public void OnEnable()
  {
    global::Events.OnCardDataCreated += new UnityAction<CardData>(this.CardDataCreated);
  }

  public void OnDisable()
  {
    global::Events.OnCardDataCreated -= new UnityAction<CardData>(this.CardDataCreated);
  }

  public void CardDataCreated(CardData cardData)
  {
    string name = cardData.cardType.name;
    if (!(name == "Miniboss") && !(name == "Boss"))
      return;
    if (cardData.hasHealth)
      this.BoostHealth(cardData, 1.1f);
    else
      this.BoostStatusEffect(cardData, "scrap", 1.1f);
  }

  public void BoostHealth(CardData cardData, float factor)
  {
    float f = (float) cardData.hp * factor;
    cardData.hp = Mathf.RoundToInt(f);
  }

  public void BoostStatusEffect(CardData cardData, string statusType, float factor)
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
