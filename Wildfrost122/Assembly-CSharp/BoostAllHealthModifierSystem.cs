// Decompiled with JetBrains decompiler
// Type: BoostAllHealthModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine.Events;

#nullable disable
public class BoostAllHealthModifierSystem : GameSystem
{
  private const int healthAdd = 2;

  private void OnEnable()
  {
    global::Events.OnCardDataCreated += new UnityAction<CardData>(BoostAllHealthModifierSystem.CardDataCreated);
  }

  private void OnDisable()
  {
    global::Events.OnCardDataCreated -= new UnityAction<CardData>(BoostAllHealthModifierSystem.CardDataCreated);
  }

  private static void CardDataCreated(CardData cardData)
  {
    if (!(cardData.cardType.name == "Friendly") || !cardData.hasHealth)
      return;
    cardData.hp += 2;
  }
}
