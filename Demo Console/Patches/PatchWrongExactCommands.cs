using HarmonyLib;
using System;
using System.Linq;
using UnityEngine;
using static Console;

namespace WildfrostHopeMod.CommandsConsole
{
    public partial class ConsoleMod
    {
        [HarmonyPatch(typeof(Console), nameof(Console.GetExactCommand))]
        internal class PatchWrongExactCommands
        {
            static void Postfix(ref Console.Command __result, string text)
            {
                Console.Command[] predictedCommands = Console.commands.Where(a => a.id.StartsWith(text)).ToArray();
                if (predictedCommands.Length > 0 && __result != null)
                    __result = null;
            }
        }
    }
}