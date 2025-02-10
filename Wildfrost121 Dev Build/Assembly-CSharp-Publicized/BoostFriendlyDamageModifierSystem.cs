// Decompiled with JetBrains decompiler
// Type: BoostFriendlyDamageModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine.Events;

#nullable disable
public class BoostFriendlyDamageModifierSystem : GameSystem
{
  public const int attackAdd = 1;

  public void OnEnable()
  {
    global::Events.OnCardDataCreated += new UnityAction<CardData>(BoostFriendlyDamageModifierSystem.CardDataCreated);
  }

  public void OnDisable()
  {
    global::Events.OnCardDataCreated -= new UnityAction<CardData>(BoostFriendlyDamageModifierSystem.CardDataCreated);
  }

  public static void CardDataCreated(CardData cardData)
  {
    if (!(cardData.cardType.name == "Friendly") || !cardData.hasAttack)
      return;
    ++cardData.damage;
  }
}
