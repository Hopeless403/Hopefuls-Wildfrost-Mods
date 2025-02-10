// Decompiled with JetBrains decompiler
// Type: Pokefrost.PatchDynamicKeyword2
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using HarmonyLib;
using System;
using System.Linq;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  [HarmonyPatch(typeof (InspectSystem), "Popup", new System.Type[] {typeof (KeywordData), typeof (Transform)})]
  internal static class PatchDynamicKeyword2
  {
    private static void Postfix(InspectSystem __instance, KeywordData keyword)
    {
      if (!PatchDynamicKeyword.dynamicKeywords.Contains(keyword.name))
        return;
      CardPopUpPanel cardPopUpPanel = __instance.popups.FirstOrDefault<Tooltip>((Func<Tooltip, bool>) (p => p.name == keyword.name)) as CardPopUpPanel;
      int index = PatchDynamicKeyword.dynamicKeywords.IndexOf(keyword.name);
      string newValue = "???";
      foreach (StatusEffectData statusEffect in __instance.inspect.statusEffects)
      {
        if (statusEffect.GetType().Name == PatchDynamicKeyword.dynamicTypes[index])
          newValue = statusEffect.GetAmount().ToString();
      }
      cardPopUpPanel.Set(keyword, keyword.body.Replace("{0}", newValue));
    }
  }
}
