// Decompiled with JetBrains decompiler
// Type: BoostAllEffectsModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Events;

public class BoostAllEffectsModifierSystem : GameSystem
{
  private const int add = 1;

  private void OnEnable() => global::Events.OnCardDataCreated += new UnityAction<CardData>(BoostAllEffectsModifierSystem.CardDataCreated);

  private void OnDisable() => global::Events.OnCardDataCreated -= new UnityAction<CardData>(BoostAllEffectsModifierSystem.CardDataCreated);

  private static void CardDataCreated(CardData cardData)
  {
    foreach (CardData.StatusEffectStacks statusEffectStacks in ((IEnumerable<CardData.StatusEffectStacks>) cardData.attackEffects).Where<CardData.StatusEffectStacks>((Func<CardData.StatusEffectStacks, bool>) (e => e.data.stackable)))
      ++statusEffectStacks.count;
    foreach (CardData.StatusEffectStacks statusEffectStacks in ((IEnumerable<CardData.StatusEffectStacks>) cardData.startWithEffects).Where<CardData.StatusEffectStacks>((Func<CardData.StatusEffectStacks, bool>) (e => !e.data.isStatus && e.data.canBeBoosted)))
      ++statusEffectStacks.count;
    foreach (CardData.TraitStacks traitStacks in cardData.traits.Where<CardData.TraitStacks>((Func<CardData.TraitStacks, bool>) (t => t.data.keyword.canStack)))
      ++traitStacks.count;
  }
}
