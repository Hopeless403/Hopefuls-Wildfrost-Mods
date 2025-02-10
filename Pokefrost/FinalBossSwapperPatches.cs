// Decompiled with JetBrains decompiler
// Type: Pokefrost.AppendCardReplacement
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  [HarmonyPatch(typeof (FinalBossGenerationSettings), "ReplaceCards", new System.Type[] {typeof (IList<CardData>)})]
  internal class AppendCardReplacement
  {
    internal static void Prefix(FinalBossGenerationSettings __instance)
    {
      foreach (FinalBossGenerationSettings.ReplaceCard replaceCard in __instance.replaceCards)
      {
        if (replaceCard.card.name == "websiteofsites.wildfrost.pokefrost.eevee")
          return;
      }
      List<FinalBossGenerationSettings.ReplaceCard> replaceCardList = new List<FinalBossGenerationSettings.ReplaceCard>();
      foreach (CardDataBuilder cardDataBuilder in Pokefrost.Pokefrost.instance.list)
      {
        CardData cardData = Pokefrost.Pokefrost.instance.Get<CardData>(cardDataBuilder._data.name);
        foreach (CardData.StatusEffectStacks startWithEffect in cardData.startWithEffects)
        {
          if (startWithEffect.data is StatusEffectEvolve data)
          {
            Debug.Log((object) ("[Pokefrost] Replacing " + cardData.name));
            CardData[] cardDataArray = data.EvolveForFinalBoss((WildfrostMod) Pokefrost.Pokefrost.instance);
            if (cardDataArray != null)
            {
              FinalBossGenerationSettings.ReplaceCard replaceCard = new FinalBossGenerationSettings.ReplaceCard()
              {
                card = cardData,
                options = cardDataArray
              };
              replaceCardList.Add(replaceCard);
            }
          }
        }
      }
      __instance.replaceCards = ((IEnumerable<FinalBossGenerationSettings.ReplaceCard>) __instance.replaceCards.AddRangeToArray<FinalBossGenerationSettings.ReplaceCard>(replaceCardList.ToArray())).ToArray<FinalBossGenerationSettings.ReplaceCard>();
    }
  }
}
