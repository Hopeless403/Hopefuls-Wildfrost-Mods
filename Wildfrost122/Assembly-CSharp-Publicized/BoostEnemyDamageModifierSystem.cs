// Decompiled with JetBrains decompiler
// Type: BoostEnemyDamageModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine.Events;

#nullable disable
public class BoostEnemyDamageModifierSystem : GameSystem
{
  public const int attackAdd = 1;
  public const int healthAdd = 1;

  public void OnEnable()
  {
    global::Events.OnCardDataCreated += new UnityAction<CardData>(BoostEnemyDamageModifierSystem.CardDataCreated);
  }

  public void OnDisable()
  {
    global::Events.OnCardDataCreated -= new UnityAction<CardData>(BoostEnemyDamageModifierSystem.CardDataCreated);
  }

  public static void CardDataCreated(CardData cardData)
  {
    string name = cardData.cardType.name;
    if (!(name == "Enemy") && !(name == "Miniboss") && !(name == "Boss") && !(name == "BossSmall"))
      return;
    if (cardData.hasAttack)
      ++cardData.damage;
    if (!cardData.hasHealth)
      return;
    ++cardData.hp;
  }
}
