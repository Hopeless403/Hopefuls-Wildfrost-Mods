// Decompiled with JetBrains decompiler
// Type: CardScriptCopyEffectsFromOtherCardInDeck
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Copy Effects From Other Card In Deck", menuName = "Card Scripts/Copy Effects From Other Card In Deck")]
public class CardScriptCopyEffectsFromOtherCardInDeck : CardScript
{
  [SerializeField]
  private bool includeReserve = true;
  [SerializeField]
  private string[] eligibleTypes = new string[2]
  {
    "Leader",
    "Friendly"
  };

  public override void Run(CardData target)
  {
    List<CardData> list = new List<CardData>();
    list.AddRange(References.PlayerData.inventory.deck.Where<CardData>((Func<CardData, bool>) (a => this.eligibleTypes.Contains<string>(a.cardType.tag) && (UnityEngine.Object) a != (UnityEngine.Object) target)));
    if (this.includeReserve)
      list.AddRange(References.PlayerData.inventory.reserve.Where<CardData>((Func<CardData, bool>) (a => this.eligibleTypes.Contains<string>(a.cardType.tag) && (UnityEngine.Object) a != (UnityEngine.Object) target)));
    if (list.Count <= 0)
      return;
    CardScriptCopyEffectsFromOtherCardInDeck.GainEffects(target, list.TakeRandom<CardData>());
  }

  private static void GainEffects(CardData target, CardData toCopy)
  {
    target.attackEffects = CardData.StatusEffectStacks.Stack((IEnumerable<CardData.StatusEffectStacks>) target.attackEffects, (IEnumerable<CardData.StatusEffectStacks>) toCopy.attackEffects);
    target.startWithEffects = CardData.StatusEffectStacks.Stack((IEnumerable<CardData.StatusEffectStacks>) target.startWithEffects, ((IEnumerable<CardData.StatusEffectStacks>) toCopy.startWithEffects).Where<CardData.StatusEffectStacks>((Func<CardData.StatusEffectStacks, bool>) (a => !a.data.isStatus && a.data.HasDescOrIsKeyword)));
    CardData.TraitStacks.Stack(ref target.traits, (IEnumerable<CardData.TraitStacks>) toCopy.traits);
  }
}
