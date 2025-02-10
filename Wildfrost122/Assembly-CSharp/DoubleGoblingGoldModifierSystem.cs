// Decompiled with JetBrains decompiler
// Type: DoubleGoblingGoldModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class DoubleGoblingGoldModifierSystem : GameSystem
{
  private const float multiplier = 2f;

  private void OnEnable()
  {
    global::Events.OnCardDataCreated += new UnityAction<CardData>(DoubleGoblingGoldModifierSystem.CardDataCreated);
  }

  private void OnDisable()
  {
    global::Events.OnCardDataCreated -= new UnityAction<CardData>(DoubleGoblingGoldModifierSystem.CardDataCreated);
  }

  private static void CardDataCreated(CardData cardData)
  {
    if (!(cardData.name == "Gobling"))
      return;
    CardData.StatusEffectStacks startWithEffect = cardData.startWithEffects[1];
    startWithEffect.count = Mathf.RoundToInt((float) startWithEffect.count * 2f);
  }
}
