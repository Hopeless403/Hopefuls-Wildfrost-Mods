// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectEvolveSlowpoke
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;

#nullable disable
namespace Pokefrost
{
  public class StatusEffectEvolveSlowpoke : StatusEffectEvolveFromNode
  {
    public string evolveUncrowned = "slowbro";
    public string evolveCrowned = "slowking";

    public override void Autofill(string n, string descrip, WildfrostMod mod)
    {
      base.Autofill(n, descrip, mod);
      this.evolutionCardName = "slowking";
    }

    public override void Evolve(WildfrostMod mod, CardData preEvo)
    {
      if (preEvo.HasCrown)
      {
        this.evolutionCardName = this.evolveCrowned;
        References.Player.data.inventory.upgrades.Add(mod.Get<CardUpgradeData>("CrownSlowking"));
      }
      else
        this.evolutionCardName = this.evolveUncrowned;
      base.Evolve(mod, preEvo);
    }
  }
}
