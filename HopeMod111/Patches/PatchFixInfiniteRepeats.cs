using HarmonyLib;
using System;
using static Console;

namespace WildfrostHopeMod.CommandsConsole
{
    public partial class ConsoleMod
    {

        [HarmonyPatch(typeof(CommandRepeat), nameof(CommandRepeat.Run))]
        internal class PatchFixInfiniteRepeats
        {
            static bool Prefix(CommandRepeat __instance, string args)
            {
                if (Console.previous.Count <= 0)
                {
                    __instance.Fail("No previous commands!");
                    return false;
                }
                int result = 1;
                if (args.Length > 0)
                    int.TryParse(args, out result);
                foreach (var command in Console.previous)
                {
                    if (command.TrimStart().StartsWith("repeat", StringComparison.InvariantCultureIgnoreCase))
                    {
                        continue;
                    }
                    new Routine(Console.CommandRepeat.Repeat(command, result));
                    return false;
                }
                __instance.Fail("No valid previous commands!");
                return false;
            }
        }
    }
}