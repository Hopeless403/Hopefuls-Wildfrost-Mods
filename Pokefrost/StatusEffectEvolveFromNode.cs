// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectEvolveFromNode
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using System;

#nullable disable
namespace Pokefrost
{
  public class StatusEffectEvolveFromNode : StatusEffectEvolve
  {
    public string targetNodeName = "Salty Spicelands";
    public bool readyToEvolve = false;

    public override void Autofill(string n, string descrip, WildfrostMod mod)
    {
      base.Autofill(n, descrip, mod);
      this.type = "evolve3";
    }

    public virtual bool NodeVisit(string nodeName, CardData cardData)
    {
      return nodeName == this.targetNodeName;
    }

    public override bool ReadyToEvolve(CardData cardData) => false;

    [HarmonyPatch(typeof (CampaignNode), "SetCleared")]
    internal static class AfterNodeCleared
    {
      internal static void Prefix(CampaignNode __instance)
      {
        StatusEffectEvolve.CheckEvolve<StatusEffectEvolveFromNode>(References.Player.data.inventory.deck, "evolve3", (Func<StatusEffectEvolveFromNode, CardData, bool>) ((s, c) => s.NodeVisit(__instance.name, c)));
        StatusEffectEvolve.CheckEvolve<StatusEffectEvolveFromNode>(References.Player.data.inventory.reserve, "evolve3", (Func<StatusEffectEvolveFromNode, CardData, bool>) ((s, c) => s.NodeVisit(__instance.name, c)));
        if (EvolutionPopUp.evolvedPokemonLastBattle.Count <= 0)
          return;
        MonoBehaviourSingleton<References>.instance.StartCoroutine(EvolutionPopUp.DelayedRun());
      }
    }
  }
}
