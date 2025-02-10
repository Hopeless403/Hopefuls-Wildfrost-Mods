// Decompiled with JetBrains decompiler
// Type: AddFrenzyToBossesModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using UnityEngine.Events;

public class AddFrenzyToBossesModifierSystem : GameSystem
{
  private StatusEffectData _effect;

  private StatusEffectData effect => this._effect ?? (this._effect = AddressableLoader.Get<StatusEffectData>("StatusEffectData", "MultiHit"));

  private void OnEnable() => global::Events.OnCardDataCreated += new UnityAction<CardData>(this.CardDataCreated);

  private void OnDisable() => global::Events.OnCardDataCreated -= new UnityAction<CardData>(this.CardDataCreated);

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
