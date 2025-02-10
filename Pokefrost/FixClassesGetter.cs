// Decompiled with JetBrains decompiler
// Type: Pokefrost.FixClassesGetter
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using HarmonyLib;

#nullable disable
namespace Pokefrost
{
  [HarmonyPatch(typeof (References), "Classes", MethodType.Getter)]
  internal static class FixClassesGetter
  {
    private static void Postfix(ref ClassData[] __result)
    {
      __result = AddressableLoader.GetGroup<ClassData>("ClassData").ToArray();
    }
  }
}
