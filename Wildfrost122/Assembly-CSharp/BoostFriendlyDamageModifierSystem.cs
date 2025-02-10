// Decompiled with JetBrains decompiler
// Type: BoostFriendlyDamageModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine.Events;

#nullable disable
public class BoostFriendlyDamageModifierSystem : GameSystem
{
  private const int attackAdd = 1;

  private void OnEnable()
  {
    global::Events.OnCardDataCreated += new UnityAction<CardData>(BoostFriendlyDamageModifierSystem.CardDataCreated);
  }

  private void OnDisable()
  {
    global::Events.OnCardDataCreated -= new UnityAction<CardData>(BoostFriendlyDamageModifierSystem.CardDataCreated);
  }

  private static void CardDataCreated(CardData cardData)
  {
    if (!(cardData.cardType.name == "Friendly") || !cardData.hasAttack)
      return;
    ++cardData.damage;
  }
}
