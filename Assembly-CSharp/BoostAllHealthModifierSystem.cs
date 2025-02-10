// Decompiled with JetBrains decompiler
// Type: BoostAllHealthModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine.Events;

public class BoostAllHealthModifierSystem : GameSystem
{
  private const int healthAdd = 2;

  private void OnEnable() => global::Events.OnCardDataCreated += new UnityAction<CardData>(BoostAllHealthModifierSystem.CardDataCreated);

  private void OnDisable() => global::Events.OnCardDataCreated -= new UnityAction<CardData>(BoostAllHealthModifierSystem.CardDataCreated);

  private static void CardDataCreated(CardData cardData)
  {
    if (!(cardData.cardType.name == "Friendly") || !cardData.hasHealth)
      return;
    cardData.hp += 2;
  }
}
