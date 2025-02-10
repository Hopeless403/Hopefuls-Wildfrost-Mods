// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectEvolveCrown
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectEvolveCrown : StatusEffectEvolve
  {
    public override void Autofill(string n, string descrip, WildfrostMod mod)
    {
      base.Autofill(n, descrip, mod);
      this.type = "evolve2";
    }

    public override bool ReadyToEvolve(CardData cardData) => cardData.HasCrown;
  }
}
