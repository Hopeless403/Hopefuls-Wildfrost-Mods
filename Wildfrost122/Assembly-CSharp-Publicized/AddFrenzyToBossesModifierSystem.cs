// Decompiled with JetBrains decompiler
// Type: AddFrenzyToBossesModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections.Generic;
using UnityEngine.Events;

#nullable disable
public class AddFrenzyToBossesModifierSystem : GameSystem
{
  public StatusEffectData _effect;

  public StatusEffectData effect
  {
    get
    {
      return this._effect ?? (this._effect = AddressableLoader.Get<StatusEffectData>("StatusEffectData", "MultiHit"));
    }
  }

  public void OnEnable()
  {
    global::Events.OnCardDataCreated += new UnityAction<CardData>(this.CardDataCreated);
  }

  public void OnDisable()
  {
    global::Events.OnCardDataCreated -= new UnityAction<CardData>(this.CardDataCreated);
  }

  public void CardDataCreated(CardData cardData)
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
