﻿// Decompiled with JetBrains decompiler
// Type: BoostAllEffectsModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Events;

#nullable disable
public class BoostAllEffectsModifierSystem : GameSystem
{
  public const int add = 1;

  public void OnEnable()
  {
    global::Events.OnCardDataCreated += new UnityAction<CardData>(BoostAllEffectsModifierSystem.CardDataCreated);
  }

  public void OnDisable()
  {
    global::Events.OnCardDataCreated -= new UnityAction<CardData>(BoostAllEffectsModifierSystem.CardDataCreated);
  }

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
