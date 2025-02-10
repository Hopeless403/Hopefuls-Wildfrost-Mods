// Decompiled with JetBrains decompiler
// Type: DoubleGoblingGoldModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class DoubleGoblingGoldModifierSystem : GameSystem
{
  public const float multiplier = 2f;

  public void OnEnable()
  {
    global::Events.OnCardDataCreated += new UnityAction<CardData>(DoubleGoblingGoldModifierSystem.CardDataCreated);
  }

  public void OnDisable()
  {
    global::Events.OnCardDataCreated -= new UnityAction<CardData>(DoubleGoblingGoldModifierSystem.CardDataCreated);
  }

  public static void CardDataCreated(CardData cardData)
  {
    if (!(cardData.name == "Gobling"))
      return;
    CardData.StatusEffectStacks startWithEffect = cardData.startWithEffects[1];
    startWithEffect.count = Mathf.RoundToInt((float) startWithEffect.count * 2f);
  }
}
