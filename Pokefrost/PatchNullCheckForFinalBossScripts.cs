// Decompiled with JetBrains decompiler
// Type: Pokefrost.PatchNullCheckForFinalBossScripts
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
  [HarmonyPatch(typeof (FinalBossGenerationSettings), "RunScripts")]
  internal class PatchNullCheckForFinalBossScripts
  {
    private static void Prefix(FinalBossGenerationSettings __instance)
    {
      int length = __instance.cardModifiers.Length;
      __instance.cardModifiers = ((IEnumerable<FinalBossCardModifier>) __instance.cardModifiers).Where<FinalBossCardModifier>((Func<FinalBossCardModifier, bool>) (x => (UnityEngine.Object) x.card != (UnityEngine.Object) null)).ToArray<FinalBossCardModifier>();
      if (length == __instance.cardModifiers.Length)
        return;
      Debug.LogError((object) "[Pokefrost] Null Scripts!");
      if (!PatchNullCheckForRewards.queuedWarning)
      {
        Debug.LogError((object) "[Pokefrost] Null Rewards!");
        MonoBehaviourSingleton<References>.instance.StartCoroutine(PatchNullCheckForRewards.PromptWarning());
        PatchNullCheckForRewards.queuedWarning = true;
      }
    }
  }
}
