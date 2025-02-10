// Decompiled with JetBrains decompiler
// Type: Pokefrost.CommandFillEvolves
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

#nullable disable
namespace Pokefrost
{
  public class CommandFillEvolves : Console.Command
  {
    public override string id => "evofill";

    public override string format => "evofill";

    public override void Run(string args)
    {
      for (int index = 0; index < 3; ++index)
      {
        EvolutionPopUp.evolvedPokemonLastBattle.Add(Pokefrost.Pokefrost.instance.Get<CardData>("eevee").Clone());
        EvolutionPopUp.pokemonEvolvedIntoLastBattle.Add(Pokefrost.Pokefrost.instance.Get<CardData>(StatusEffectEvolveEevee.eeveelutions.RandomItem<string>()).Clone());
      }
      EvolutionPopUp.evolvedPokemonLastBattle.Add(Pokefrost.Pokefrost.instance.Get<CardData>("BerryPet").Clone());
      EvolutionPopUp.pokemonEvolvedIntoLastBattle.Add(Pokefrost.Pokefrost.instance.Get<CardData>(StatusEffectEvolveEevee.eeveelutions.RandomItem<string>()).Clone());
    }
  }
}
