// Decompiled with JetBrains decompiler
// Type: BoostAllEffectsModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Events;

public class BoostAllEffectsModifierSystem : GameSystem
{
  public const int add = 1;

  public void OnEnable() => global::Events.OnCardDataCreated += new UnityAction<CardData>(BoostAllEffectsModifierSystem.CardDataCreated);

  public void OnDisable() => global::Events.OnCardDataCreated -= new UnityAction<CardData>(BoostAllEffectsModifierSystem.CardDataCreated);

  public static void CardDataCreated(CardData cardData)
  {
    foreach (CardData.StatusEffectStacks statusEffectStacks in ((IEnumerable<CardData.StatusEffectStacks>) cardData.attackEffects).Where<CardData.StatusEffectStacks>((Func<CardData.StatusEffectStacks, bool>) (e => e.data.stackable)))
      ++statusEffectStacks.count;
    foreach (CardData.StatusEffectStacks statusEffectStacks in ((IEnumerable<CardData.StatusEffectStacks>) cardData.startWithEffects).Where<CardData.StatusEffectStacks>((Func<CardData.StatusEffectStacks, bool>) (e => !e.data.isStatus && e.data.canBeBoosted)))
      ++statusEffectStacks.count;
    foreach (CardData.TraitStacks traitStacks in cardData.traits.Where<CardData.TraitStacks>((Func<CardData.TraitStacks, bool>) (t => t.data.keyword.canStack)))
      ++traitStacks.count;
  }
}
