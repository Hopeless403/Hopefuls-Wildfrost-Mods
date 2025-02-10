// Decompiled with JetBrains decompiler
// Type: Pokefrost.PatchAddComponent
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using HarmonyLib;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  [HarmonyPatch(typeof (GameObjectExt), "AddComponentByName")]
  internal class PatchAddComponent
  {
    private static string assem => typeof (PatchAddComponent).Assembly.GetName().Name;

    private static string namesp => typeof (PatchAddComponent).Namespace;

    private static Component Postfix(
      Component __result,
      GameObject gameObject,
      string componentName)
    {
      if ((UnityEngine.Object) __result == (UnityEngine.Object) null)
      {
        System.Type type = System.Type.GetType(PatchAddComponent.namesp + "." + componentName + "," + PatchAddComponent.assem);
        if (type != (System.Type) null)
          return gameObject.AddComponent(type);
      }
      return __result;
    }
  }
}
