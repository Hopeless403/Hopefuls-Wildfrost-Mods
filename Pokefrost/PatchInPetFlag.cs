// Decompiled with JetBrains decompiler
// Type: Pokefrost.PatchInPetFlag
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using HarmonyLib;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  [HarmonyPatch(typeof (PetHutFlagSetter), "SetupFlag")]
  internal static class PatchInPetFlag
  {
    private static void Prefix(PetHutFlagSetter __instance)
    {
      __instance.flagSprites = ((IEnumerable<Sprite>) __instance.flagSprites).Append<Sprite>(AddressableExtMethods.ASprite("eeveeflag")).ToArray<Sprite>();
      __instance.flagSprites = ((IEnumerable<Sprite>) __instance.flagSprites).Append<Sprite>(AddressableExtMethods.ASprite("rotomflag")).ToArray<Sprite>();
    }
  }
}
