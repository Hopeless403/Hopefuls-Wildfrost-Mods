// Decompiled with JetBrains decompiler
// Type: Pokefrost.PatchInkedTargetModeRemove
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using HarmonyLib;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  [HarmonyPatch(typeof (StatusEffectChangeTargetMode), "RunEndEvent")]
  internal static class PatchInkedTargetModeRemove
  {
    private static void Postfix(StatusEffectChangeTargetMode __instance)
    {
      if (!__instance.target.silenced)
        return;
      __instance.target.targetMode = (TargetMode) ScriptableObject.CreateInstance<TargetModeBasic>();
    }
  }
}
