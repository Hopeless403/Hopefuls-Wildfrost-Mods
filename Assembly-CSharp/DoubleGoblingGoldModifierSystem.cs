// Decompiled with JetBrains decompiler
// Type: DoubleGoblingGoldModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;

public class DoubleGoblingGoldModifierSystem : GameSystem
{
  private const float multiplier = 2f;

  private void OnEnable() => global::Events.OnCardDataCreated += new UnityAction<CardData>(DoubleGoblingGoldModifierSystem.CardDataCreated);

  private void OnDisable() => global::Events.OnCardDataCreated -= new UnityAction<CardData>(DoubleGoblingGoldModifierSystem.CardDataCreated);

  private static void CardDataCreated(CardData cardData)
  {
    if (!(cardData.name == "Gobling"))
      return;
    CardData.StatusEffectStacks startWithEffect = cardData.startWithEffects[1];
    startWithEffect.count = Mathf.RoundToInt((float) startWithEffect.count * 2f);
  }
}
