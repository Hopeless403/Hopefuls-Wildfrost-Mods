// Decompiled with JetBrains decompiler
// Type: Pokefrost.PatchDynamicKeyword
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using HarmonyLib;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  [HarmonyPatch(typeof (CardPopUpTarget), "Pop")]
  internal static class PatchDynamicKeyword
  {
    public static List<string> dynamicKeywords = new List<string>()
    {
      "pickup",
      "resist"
    };
    public static List<string> dynamicTypes = new List<string>()
    {
      typeof (StatusEffectPickup).Name,
      typeof (StatusEffectResist).Name
    };

    private static void Postfix(CardPopUpTarget __instance)
    {
      foreach (string str in __instance.current)
      {
        Tooltip tooltip;
        if (PatchDynamicKeyword.dynamicKeywords.Contains(str) && MonoBehaviourRectSingleton<CardPopUp>.instance.activePanels.TryGetValue(str, out tooltip))
        {
          int index = PatchDynamicKeyword.dynamicKeywords.IndexOf(str);
          string newValue = "???";
          if (__instance.IsCard)
          {
            foreach (StatusEffectData statusEffect in __instance.card.entity.statusEffects)
            {
              if (statusEffect.GetType().Name == PatchDynamicKeyword.dynamicTypes[index] | (statusEffect is StatusEffectApplyX statusEffectApplyX && (Object) statusEffectApplyX.effectToApply != (Object) null && statusEffectApplyX.effectToApply.GetType().Name == PatchDynamicKeyword.dynamicTypes[index]))
              {
                newValue = statusEffect.GetAmount().ToString();
                break;
              }
            }
          }
          KeywordData keyword = AddressableLoader.Get<KeywordData>("KeywordData", str);
          ((CardPopUpPanel) tooltip).Set(keyword, keyword.body.Replace("???", newValue));
        }
      }
    }
  }
}
