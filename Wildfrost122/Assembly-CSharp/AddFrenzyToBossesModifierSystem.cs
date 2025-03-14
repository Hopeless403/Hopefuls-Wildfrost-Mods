﻿// Decompiled with JetBrains decompiler
// Type: AddFrenzyToBossesModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using UnityEngine.Events;

#nullable disable
public class AddFrenzyToBossesModifierSystem : GameSystem
{
  private StatusEffectData _effect;

  private StatusEffectData effect
  {
    get
    {
      return this._effect ?? (this._effect = AddressableLoader.Get<StatusEffectData>("StatusEffectData", "MultiHit"));
    }
  }

  private void OnEnable()
  {
    global::Events.OnCardDataCreated += new UnityAction<CardData>(this.CardDataCreated);
  }

  private void OnDisable()
  {
    global::Events.OnCardDataCreated -= new UnityAction<CardData>(this.CardDataCreated);
  }

  private void CardDataCreated(CardData cardData)
  {
    string name = cardData.cardType.name;
    if (!(name == "Miniboss") && !(name == "Boss") && !(name == "BossSmall"))
      return;
    cardData.startWithEffects = CardData.StatusEffectStacks.Stack((IEnumerable<CardData.StatusEffectStacks>) cardData.startWithEffects, (IEnumerable<CardData.StatusEffectStacks>) new CardData.StatusEffectStacks[1]
    {
      new CardData.StatusEffectStacks(this.effect, 1)
    });
  }
}
