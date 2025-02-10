// Decompiled with JetBrains decompiler
// Type: DoubleGoblingGoldModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Events;

public class DoubleGoblingGoldModifierSystem : GameSystem
{
  public const float multiplier = 2f;

  public void OnEnable() => global::Events.OnCardDataCreated += new UnityAction<CardData>(DoubleGoblingGoldModifierSystem.CardDataCreated);

  public void OnDisable() => global::Events.OnCardDataCreated -= new UnityAction<CardData>(DoubleGoblingGoldModifierSystem.CardDataCreated);

  public static void CardDataCreated(CardData cardData)
  {
    if (!(cardData.name == "Gobling"))
      return;
    CardData.StatusEffectStacks startWithEffect = cardData.startWithEffects[1];
    startWithEffect.count = Mathf.RoundToInt((float) startWithEffect.count * 2f);
  }
}
