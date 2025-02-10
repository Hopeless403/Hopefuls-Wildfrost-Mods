// Decompiled with JetBrains decompiler
// Type: Pokefrost.AppendFinalBossGeneration
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  [HarmonyPatch(typeof (FinalBossGenerationSettings), "Process")]
  internal class AppendFinalBossGeneration
  {
    private static string[] traitsToRemove = new string[4]
    {
      "Pickup",
      "Synchronize",
      "Synchronize2",
      "Salvage"
    };

    internal static void Prefix(FinalBossGenerationSettings __instance)
    {
      foreach (FinalBossEffectSwapper effectSwapper in __instance.effectSwappers)
      {
        if (effectSwapper.effect.name.Contains("Buff Card In Deck On Kill"))
          return;
      }
      AppendFinalBossGeneration.AddTraits(__instance);
      AppendFinalBossGeneration.AddEffectSwappers(__instance);
      AppendFinalBossGeneration.AddScripts(__instance);
    }

    internal static void AddTraits(FinalBossGenerationSettings __instance)
    {
      __instance.ignoreTraits = __instance.ignoreTraits.AddRangeToArray<TraitData>(((IEnumerable<string>) AppendFinalBossGeneration.traitsToRemove).Select<string, TraitData>((Func<string, TraitData>) (s => Pokefrost.Pokefrost.instance.TryGet<TraitData>(s))).ToArray<TraitData>());
    }

    internal static void AddEffectSwappers(FinalBossGenerationSettings __instance)
    {
      List<FinalBossEffectSwapper> bossEffectSwapperList = new List<FinalBossEffectSwapper>()
      {
        AppendFinalBossGeneration.CreateSwapper("While Active Frenzy To Crown Allies", "While Active Frenzy To Allies"),
        AppendFinalBossGeneration.CreateSwapper("Give Thick Club", "On Card Played Buff Marowak", maxBoost: 1),
        AppendFinalBossGeneration.CreateSwapper("While Active Increase Effects To Hand", "Ongoing Increase Effects"),
        AppendFinalBossGeneration.CreateSwapper("Give Slowking Crown"),
        AppendFinalBossGeneration.CreateSwapper("Give Combo to Card in Hand", "On Turn Apply Attack To Self", maxBoost: 1),
        AppendFinalBossGeneration.CreateSwapper("Discard Rightmost Button"),
        AppendFinalBossGeneration.CreateSwapper("When Deployed Sketch", attackOption: "Null"),
        AppendFinalBossGeneration.CreateSwapper("Trigger All Button", "When Destroyed Trigger To Allies"),
        AppendFinalBossGeneration.CreateSwapper("Trigger All Listener_1"),
        AppendFinalBossGeneration.CreateSwapper("When Ally Summoned Add Skull To Hand"),
        AppendFinalBossGeneration.CreateSwapper("Trigger When Summon", "Trigger When Card Destroyed"),
        AppendFinalBossGeneration.CreateSwapper("On Hit Snowed Target Double Attack Otherwise Half", attackOption: "Snow", minBoost: 1, maxBoost: 2),
        AppendFinalBossGeneration.CreateSwapper("Buff Card In Deck On Kill", "On Turn Apply Attack To Self", minBoost: 1, maxBoost: 3),
        AppendFinalBossGeneration.CreateSwapper("Trigger Clunker Ahead", "On Turn Apply Scrap To RandomAlly"),
        AppendFinalBossGeneration.CreateSwapper("On Card Played Increase Attack Of Cards In Hand", "While Active Increase Attack To Allies"),
        AppendFinalBossGeneration.CreateSwapper("When Hit Add Scrap Pile To Hand", "On Turn Apply Scrap To RandomAlly"),
        AppendFinalBossGeneration.CreateSwapper("End of Turn Draw a Card", "When Hit Add Junk To Hand"),
        AppendFinalBossGeneration.CreateSwapper("While Active It Is Overshroom", attackOption: "Overload", minBoost: 4, maxBoost: 4),
        AppendFinalBossGeneration.CreateSwapper("Gain Frenzy When Companion Is Killed", "MultiHit", minBoost: 2, maxBoost: 3),
        AppendFinalBossGeneration.CreateSwapper("Revive", "Heal Self", minBoost: 3, maxBoost: 5),
        AppendFinalBossGeneration.CreateSwapper("Rest Button", "Heal Self", minBoost: 3, maxBoost: 5),
        AppendFinalBossGeneration.CreateSwapper("Rest Listener_1"),
        AppendFinalBossGeneration.CreateSwapper("Redraw Cards", "Trigger When Redraw Hit"),
        AppendFinalBossGeneration.CreateSwapper("Add Tar Blade Button"),
        AppendFinalBossGeneration.CreateSwapper("Tar Shot Listener_1"),
        AppendFinalBossGeneration.CreateSwapper("Bonus Damage Equal To Darts In Hand", "Deal Bonus Damage Equal To Cards In Hand"),
        AppendFinalBossGeneration.CreateSwapper("Convert Spice To Burning To Front Enemy"),
        AppendFinalBossGeneration.CreateSwapper("Autotomize Button"),
        AppendFinalBossGeneration.CreateSwapper("While Active Unlimited Lumin", "Apply Lumin To Random Ally"),
        AppendFinalBossGeneration.CreateSwapper("On Turn Trigger Allies In Hand"),
        AppendFinalBossGeneration.CreateSwapper("Gain Hero On Recall", "Temporary Hero"),
        AppendFinalBossGeneration.CreateSwapper("Maybe Make Front Enemy Retreat", "On Card Played Return Front Enemy To Hand"),
        AppendFinalBossGeneration.CreateSwapper("On Turn Return Prophesized Card To Hand", "Deal Damage To All Enemies", minBoost: 39, maxBoost: 59),
        AppendFinalBossGeneration.CreateSwapper("When Prophesized Card Played Give Allies Attack")
      };
      __instance.effectSwappers = ((IEnumerable<FinalBossEffectSwapper>) __instance.effectSwappers.AddRangeToArray<FinalBossEffectSwapper>(bossEffectSwapperList.ToArray())).ToArray<FinalBossEffectSwapper>();
    }

    internal static FinalBossEffectSwapper CreateSwapper(
      string effect,
      string replaceOption = null,
      string attackOption = null,
      int minBoost = 0,
      int maxBoost = 0)
    {
      FinalBossEffectSwapper instance = ScriptableObject.CreateInstance<FinalBossEffectSwapper>();
      instance.effect = Pokefrost.Pokefrost.instance.TryGet<StatusEffectData>(effect);
      instance.name = instance.effect.name;
      instance.replaceWithOptions = new StatusEffectData[0];
      if (!replaceOption.IsNullOrEmpty())
        instance.replaceWithOptions = ((IEnumerable<StatusEffectData>) instance.replaceWithOptions).Append<StatusEffectData>(Pokefrost.Pokefrost.instance.Get<StatusEffectData>(replaceOption)).ToArray<StatusEffectData>();
      if (!attackOption.IsNullOrEmpty())
        instance.replaceWithAttackEffect = Pokefrost.Pokefrost.instance.TryGet<StatusEffectData>(attackOption);
      instance.boostRange = new Vector2Int(minBoost, maxBoost);
      return instance;
    }

    private static void AddScripts(FinalBossGenerationSettings __instance)
    {
      FinalBossCardModifier[] items = new FinalBossCardModifier[6]
      {
        AppendFinalBossGeneration.CreateCardModifier("ambipom", (CardScript) AppendFinalBossGeneration.TraitScript("Trash", 1, 1)),
        AppendFinalBossGeneration.CreateCardModifier("gardevoir", (CardScript) AppendFinalBossGeneration.PassiveScript("Copy Effects Applied To Front Enemy", 1, 1)),
        AppendFinalBossGeneration.CreateCardModifier("gallade", (CardScript) AppendFinalBossGeneration.PassiveScript("Copy Effects Applied To Front Enemy", 1, 1)),
        AppendFinalBossGeneration.CreateCardModifier("cresselia", (CardScript) AppendFinalBossGeneration.PassiveScript("Trigger When Dream Card Played", 1, 1)),
        AppendFinalBossGeneration.CreateCardModifier("xatu", (CardScript) AppendFinalBossGeneration.CounterScript(10, 10)),
        AppendFinalBossGeneration.CreateCardModifier("ludicolo", (CardScript) AppendFinalBossGeneration.CounterScript(5, 5))
      };
      __instance.cardModifiers = __instance.cardModifiers.AddRangeToArray<FinalBossCardModifier>(items);
    }

    private static FinalBossCardModifier CreateCardModifier(
      string name,
      params CardScript[] scripts)
    {
      FinalBossCardModifier instance = ScriptableObject.CreateInstance<FinalBossCardModifier>();
      instance.name = name;
      instance.card = Pokefrost.Pokefrost.instance.TryGet<CardData>(name);
      instance.runAll = scripts;
      return instance;
    }

    private static CardScriptAddPassiveEffect PassiveScript(string name, int min, int max)
    {
      CardScriptAddPassiveEffect instance = ScriptableObject.CreateInstance<CardScriptAddPassiveEffect>();
      instance.name = "Add Passive: " + name;
      instance.effect = Pokefrost.Pokefrost.instance.TryGet<StatusEffectData>(name);
      instance.countRange = new Vector2Int(min, max);
      return instance;
    }

    private static CardScriptAddAttackEffect AttackScript(string name, int min, int max)
    {
      CardScriptAddAttackEffect instance = ScriptableObject.CreateInstance<CardScriptAddAttackEffect>();
      instance.name = "Add Attack Effect: " + name;
      instance.effect = Pokefrost.Pokefrost.instance.TryGet<StatusEffectData>(name);
      instance.countRange = new Vector2Int(min, max);
      return instance;
    }

    private static CardScriptAddTrait TraitScript(string name, int min, int max)
    {
      CardScriptAddTrait instance = ScriptableObject.CreateInstance<CardScriptAddTrait>();
      instance.name = "Add Trait: " + name;
      instance.trait = Pokefrost.Pokefrost.instance.TryGet<TraitData>(name);
      instance.countRange = new Vector2Int(min, max);
      return instance;
    }

    private static CardScriptSetCounter CounterScript(int min, int max)
    {
      CardScriptSetCounter instance = ScriptableObject.CreateInstance<CardScriptSetCounter>();
      instance.name = "Counter to " + min.ToString() + "-" + max.ToString();
      instance.counterRange = new Vector2Int(min, max);
      return instance;
    }
  }
}
