// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectEvolveNatu
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using System.Linq;

#nullable disable
namespace Pokefrost
{
  public class StatusEffectEvolveNatu : StatusEffectEvolveFromCardPickup
  {
    public override bool CardSelected(CardData self, Entity selectedCard)
    {
      string str;
      self.TryGetCustomData<string>("Future Sight", out str, this.CardName);
      return str == selectedCard.data.name;
    }

    public override void Evolve(WildfrostMod mod, CardData preEvo)
    {
      base.Evolve(mod, preEvo);
      CardData cardData1 = EvolutionPopUp.pokemonEvolvedIntoLastBattle.Last<CardData>();
      CardData cardData2 = EvolutionPopUp.evolvedPokemonLastBattle.Last<CardData>();
      if (!cardData1.name.Contains("xatu") || !cardData2.name.Contains("natu"))
        return;
      string str;
      cardData2.TryGetCustomData<string>("Future Sight", out str, this.CardName);
      cardData1.SetCustomData("Future Sight", (object) str);
    }
  }
}
