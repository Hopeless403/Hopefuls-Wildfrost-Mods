// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectEvolveNincada
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectEvolveNincada : StatusEffectEvolve
  {
    public string shedinjaMask = "websiteofsites.wildfrost.pokefrost.shedinjamask";

    public override bool ReadyToEvolve(CardData cardData)
    {
      CardData.StatusEffectStacks statusEffectStacks = ((IEnumerable<CardData.StatusEffectStacks>) cardData.startWithEffects).FirstOrDefault<CardData.StatusEffectStacks>((Func<CardData.StatusEffectStacks, bool>) (s => (UnityEngine.Object) s?.data == (UnityEngine.Object) this));
      if (statusEffectStacks != null)
        statusEffectStacks.count = Math.Max(0, statusEffectStacks.count - 1);
      return base.ReadyToEvolve(cardData);
    }

    public override void Evolve(WildfrostMod mod, CardData preEvo)
    {
      CardData data = mod.Get<CardData>(this.shedinjaMask).Clone();
      References.PlayerData.inventory.deck.Add(data);
      Events.InvokeEntityShowUnlocked(CardManager.Get(data, (CardController) null, References.Player, false, true).entity);
      base.Evolve(mod, preEvo);
      EvolutionPopUp.pokemonEvolvedIntoLastBattle.Add(data);
    }
  }
}
