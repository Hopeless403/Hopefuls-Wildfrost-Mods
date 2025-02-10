// Decompiled with JetBrains decompiler
// Type: Pokefrost.FixTribeFlags
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using HarmonyLib;

#nullable disable
namespace Pokefrost
{
  [HarmonyPatch(typeof (InspectSystem), "GetClass", new System.Type[] {typeof (CardData)})]
  internal static class FixTribeFlags
  {
    internal static bool Prefix(ref ClassData __result, CardData cardData)
    {
      string name = cardData.name;
      if (!name.Contains("websiteofsites.wildfrost.pokefrost"))
        return true;
      foreach (string str in Pokefrost.Pokefrost.basicPool)
      {
        if (name.Contains(str))
        {
          __result = References.Classes[0];
          return false;
        }
      }
      foreach (string str in Pokefrost.Pokefrost.magicPool)
      {
        if (name.Contains(str))
        {
          __result = References.Classes[2];
          return false;
        }
      }
      foreach (string str in Pokefrost.Pokefrost.clunkPool)
      {
        if (name.Contains(str))
        {
          __result = References.Classes[1];
          return false;
        }
      }
      return false;
    }
  }
}
