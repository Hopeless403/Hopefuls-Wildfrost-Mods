using HarmonyLib;

namespace WildfrostHopeMod.CommandsConsole
{
    public partial class ConsoleMod
    {
        [HarmonyPatch]
        internal class PatchConsoleHovers
        {
            [HarmonyPostfix]
            [HarmonyPatch(typeof(JournalCardDisplay), nameof(JournalCardDisplay.OnDisable))]
            static void UnHoverCard() => Console.hover = null;
            [HarmonyPostfix]
            [HarmonyPatch(typeof(JournalCharm), nameof(JournalCharm.Hover))]
            static void HoverCharm(JournalCharm __instance) => ConsoleMod.hover = __instance.upgradeData;
            [HarmonyPostfix]
            [HarmonyPatch(typeof(CardCharmInteraction), nameof(CardCharmInteraction.UnHover))]
            [HarmonyPatch(typeof(JournalCharm), nameof(JournalCharm.UnHover))]
            static void UnHoverCharm() => ConsoleMod.hover = null;
        }


    }
}