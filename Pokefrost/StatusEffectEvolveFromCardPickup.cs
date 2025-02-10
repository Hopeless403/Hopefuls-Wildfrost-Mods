// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectEvolveFromCardPickup
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using System;

#nullable disable
namespace Pokefrost
{
  public class StatusEffectEvolveFromCardPickup : StatusEffectEvolve
  {
    public virtual string CardName => "";

    public override void Autofill(string n, string descrip, WildfrostMod mod)
    {
      base.Autofill(n, descrip, mod);
      this.type = "evolve4";
    }

    public virtual bool CardSelected(CardData self, Entity selectedCard)
    {
      return selectedCard.data.name == this.CardName;
    }

    public static void CheckEvolveFromSelect(ShopItem item)
    {
      Entity componentInChildren = item.GetComponentInChildren<Entity>();
      if (!((UnityEngine.Object) componentInChildren != (UnityEngine.Object) null))
        return;
      StatusEffectEvolveFromCardPickup.CheckEvolveFromSelect(componentInChildren);
    }

    public static void CheckEvolveFromSelect(Entity entity)
    {
      if ((UnityEngine.Object) References.Player?.data?.inventory == (UnityEngine.Object) null)
        return;
      int num;
      if (entity.data.TryGetCustomData<int>("Future Sight ID", out num, -1))
        CardScriptForsee.ids.Add(num);
      StatusEffectEvolve.CheckEvolve<StatusEffectEvolveFromCardPickup>(References.PlayerData.inventory.deck, "evolve4", (Func<StatusEffectEvolveFromCardPickup, CardData, bool>) ((s, c) => s.CardSelected(c, entity)));
      StatusEffectEvolve.CheckEvolve<StatusEffectEvolveFromCardPickup>(References.PlayerData.inventory.reserve, "evolve4", (Func<StatusEffectEvolveFromCardPickup, CardData, bool>) ((s, c) => s.CardSelected(c, entity)));
      if (EvolutionPopUp.evolvedPokemonLastBattle.Count <= 0)
        return;
      MonoBehaviourSingleton<References>.instance.StartCoroutine(EvolutionPopUp.DelayedRun());
    }
  }
}
