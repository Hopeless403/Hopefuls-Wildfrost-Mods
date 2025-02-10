using HarmonyLib;
using System;
using System.Collections;
using System.Linq;
using UnityEngine;

namespace WildfrostHopeMod.CommandsConsole
{
    public partial class ConsoleMod
    {
        [HarmonyPatch]
        public class PatchRunMultipleCommands
        {
            [HarmonyPrefix]
            [HarmonyPatch(typeof(Console), nameof(Console.PredictArgsRoutine))]
            static void PredictArgsRoutine(ref string text)
            {
                if (!text.Contains(';')) return;
                text = text.Split(';').Last().TrimStart();
            }

            internal static Console.Command exactCommand = null;

            [HarmonyPrefix]
            [HarmonyPatch(typeof(Console), nameof(Console.CheckTakePredict))]
            static bool CheckTakePredict(Console __instance)
            {
                string text = __instance.input.text;
                if (!text.Contains(';') || !Input.GetKeyDown(__instance.takePredict) || __instance.argsDisplay.Count <= 0)
                {
                    exactCommand = Console.GetExactCommand(text.TrimStart());
                    return true; // meaning continue checking as normal
                }

                var commands = text.Split(';');
                exactCommand = Console.GetExactCommand(commands.Last().TrimStart());
                commands[commands.Length - 1] = exactCommand == null ?
                    __instance.argsDisplay.TopCommand
                    : exactCommand.id + " " + __instance.argsDisplay.TopArgument.Split(new string[] { " //" }, StringSplitOptions.None).First();
                // Note the added Split(), which we'll use to add comments in predicted args
                commands = commands.Select(c => c.Trim()).ToArray();
                __instance.input.text = string.Join("; ", commands);
                __instance.input.MoveToEndOfLine(false, false);
                return false;
            }

            [HarmonyPostfix]
            [HarmonyPatch(typeof(Console), nameof(Console.CheckTakePredict))]
            /// This is to undo the PatchTitleAsPrediction patch
            static void PostCheckTakePredict(Console __instance)
            {
                var array = __instance.input.text.Split(new string[] { " //" }, StringSplitOptions.RemoveEmptyEntries);
                if (array.Length > 0) __instance.input.text = array.First();
                if (exactCommand != null) __instance.input.text = __instance.input.text.Replace(" " + exactCommand.format, " ");
            }

            [HarmonyPrefix]
            [HarmonyPatch(typeof(Console), nameof(Console.HandleCommand))]
            static bool HandleCommand(Console __instance, string text)
            {
                //string text = __instance.input.text;
                if (!text.Contains(';'))
                    return true;
                string[] commands = text.Split(';').Select(t => t.Trim()).ToArray();
                new Routine(HandleCommands(commands));
                return false;
            }
            [HarmonyPostfix]
            [HarmonyPatch(typeof(Console), nameof(Console.HandleCommand))]
            static IEnumerator PostHandleCommand(IEnumerator __result)
            {
                yield return __result;
                Console.previous.RemoveDuplicates();
            }

            public static IEnumerator HandleCommands(string[] commands)
            {
                int success = 0;
                foreach (var command in commands)
                {
                    if (command.Length <= 0)
                        continue;
                    yield return Console.HandleCommand(command);
                    success++;
                }
                Console.previous.RemoveRange(0, success);
                Console.previous.Insert(0, string.Join("; ", commands));
            }
        }
    }
}