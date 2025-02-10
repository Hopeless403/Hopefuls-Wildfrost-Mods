using HarmonyLib;
using System.Collections;
using System.Linq;
using UnityEngine;
using UnityExplorer.UI;
using static WildfrostHopeMod.CommandsConsole.ConsoleCustom;

namespace WildfrostHopeMod.CommandsConsole
{
    public partial class ConsoleMod
    {
        [HarmonyPatch(typeof(Console), nameof(Console.PopulateHelp))]
        internal class PatchAddCustomCommandsHelp
        {
            static bool Prefix() => false;
        }
        [HarmonyPatch(typeof(Console), nameof(Console.Commands))]
        internal class PatchAddCustomCommands
        {
            static void Postfix(Console __instance)
            {
                RegisterCommands();
                foreach (var command in ConsoleCustom.commands)
                {
                    MonoBehaviour.print(command.id);
                    Console.commands = Console.commands.Append(command).ToList();
                }
            }
        }
        [HarmonyPatch(typeof(Console.Command), nameof(Console.Command.Fail))]
        internal class PatchDebugFail
        {
            static void Postfix(Console.Command __instance, string message)
                => Debug.LogError($"[AConsole mod] {message}");
        }


    }
}