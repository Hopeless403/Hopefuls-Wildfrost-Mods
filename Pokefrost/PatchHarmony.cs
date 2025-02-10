// Decompiled with JetBrains decompiler
// Type: Pokefrost.PatchHarmony
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using HarmonyLib.Tools;

#nullable disable
namespace Pokefrost
{
  [HarmonyPatch(typeof (WildfrostMod.DebugLoggerTextWriter), "WriteLine")]
  internal class PatchHarmony
  {
    private static bool Prefix()
    {
      PatchHarmony.Postfix();
      return false;
    }

    private static void Postfix()
    {
      Logger.ChannelFilter = Logger.LogChannel.Warn | Logger.LogChannel.Error;
    }
  }
}
