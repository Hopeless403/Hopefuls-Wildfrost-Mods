// Decompiled with JetBrains decompiler
// Type: BoostAllHealthModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine.Events;

#nullable disable
public class BoostAllHealthModifierSystem : GameSystem
{
  public const int healthAdd = 2;

  public void OnEnable()
  {
    global::Events.OnCardDataCreated += new UnityAction<CardData>(BoostAllHealthModifierSystem.CardDataCreated);
  }

  public void OnDisable()
  {
    global::Events.OnCardDataCreated -= new UnityAction<CardData>(BoostAllHealthModifierSystem.CardDataCreated);
  }

  public static void CardDataCreated(CardData cardData)
  {
    if (!(cardData.cardType.name == "Friendly") || !cardData.hasHealth)
      return;
    cardData.hp += 2;
  }
}
