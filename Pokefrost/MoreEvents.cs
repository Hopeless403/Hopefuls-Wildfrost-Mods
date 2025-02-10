// Decompiled with JetBrains decompiler
// Type: Pokefrost.MoreEvents
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using HarmonyLib;
using UnityEngine.Events;

#nullable disable
namespace Pokefrost
{
  [HarmonyPatch(typeof (global::Events))]
  internal class MoreEvents
  {
    public static event UnityAction OnCampaignGenerated;

    [HarmonyPatch("InvokeCampaignGenerated")]
    private static void Postfix()
    {
      if (MoreEvents.OnCampaignGenerated == null)
        return;
      MoreEvents.OnCampaignGenerated();
    }
  }
}
