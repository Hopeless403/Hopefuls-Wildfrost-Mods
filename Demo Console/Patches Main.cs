using HarmonyLib;
using System.Collections;
using System.Linq;
using UnityEngine;
//using static WildfrostHopeMod.CommandsConsole.ConsoleCustom;

namespace WildfrostHopeMod.CommandsConsole
{
    public partial class ConsoleMod
    {
        /*[HarmonyPatch(typeof(Console), nameof(Console.Commands))]
        internal class PatchAddCustomCommands
        {
            static void Postfix(Console __instance)
            {
                Debug.LogWarning(Console.commands.ToArray().ToList().Select(a => a.id).Join());
                foreach (var command in ConsoleCustom.commands)
                {
                    Debug.LogError(command.id);
                    Console.commands.Add(command);
                }
            }
            *//*ConsoleCustom.RegisterCommands();

            }*//*
        }*/
        [HarmonyPatch(typeof(Console.Command), nameof(Console.Command.Fail))]
        internal class PatchDebugFail
        {
            static void Postfix(Console.Command __instance, string message)
                => Debug.LogError($"[AConsole mod] {message}");
        }
    }
}