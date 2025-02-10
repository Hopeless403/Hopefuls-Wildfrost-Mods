// Decompiled with JetBrains decompiler
// Type: LeaderReroll.Patch
// Assembly: LeaderReroll, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B49BAD01-7FF8-40B0-BDD0-8A9F0E6D0D3B
// Assembly location: C:\Users\harri\Downloads\LeaderReroll.dll

using HarmonyLib;
using UnityEngine;

namespace LeaderReroll
{
  [HarmonyPatch(typeof (CharacterSelectScreen), "Start")]
  internal class Patch
  {
    private static void Postfix(CharacterSelectScreen __instance) => ((Component) __instance).gameObject.AddComponent<RerollComponent>();
  }
}
