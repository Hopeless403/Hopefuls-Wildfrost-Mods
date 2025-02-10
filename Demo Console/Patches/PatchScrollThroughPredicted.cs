using HarmonyLib;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace WildfrostHopeMod.CommandsConsole
{
    public partial class ConsoleMod
    {
        [HarmonyPatch]
        public class PatchScrollThroughPredicted
        {
            public static float holdTime = 0.7f;
            public static float currentHoldTime = 0;
            static int tick = 0;
            static Transform fixer = null;

            [HarmonyPrefix]
            [HarmonyPatch(typeof(Console), nameof(Console.CheckScrollPrevious))]
            static bool CheckScrollPrevious(Console __instance)
            {
                string[] args = __instance.argsDisplay.current;
                // If no predicted args, disable scrolling
                if (__instance.input.text.IsNullOrWhitespace() || PatchRunMultipleCommands.exactCommand == null || !__instance.argsDisplay.gameObject.activeSelf || args?.Length <= 1 || !Mod.scrollConfig)
                {
                    return true;
                }
                // String is non-empty.
                // Now check if holding the key, and speedscroll if so
                string[] scrolledArgs = new string[args.Length];
                if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
                    currentHoldTime += Time.unscaledDeltaTime;
                else currentHoldTime = 0;

                if (currentHoldTime >= holdTime) tick++;
                if (Input.GetKeyDown(KeyCode.UpArrow) || (tick == 3 && Input.GetKey(KeyCode.UpArrow)))
                    for (int i = 0; i < args.Length; i++)
                    {
                        tick = 0;
                        scrolledArgs[(i + 1) % args.Length] = args[i];
                    }
                else if (Input.GetKeyDown(KeyCode.DownArrow) || (tick == 3 && Input.GetKey(KeyCode.DownArrow)))
                    for (int i = 0; i < args.Length; i++)
                    {
                        tick = 0;
                        scrolledArgs[(args.Length + i - 1) % args.Length] = args[i];
                    }
                if (scrolledArgs.ToHashSet().SetEquals(args))
                {
                    __instance.argsDisplay.DisplayArgs(scrolledArgs);
                    __instance.input.MoveToEndOfLine(false, false);
                }
                return false;
            }

            [HarmonyPostfix]
            [HarmonyPatch(typeof(ConsoleArgsDisplay), nameof(ConsoleArgsDisplay.DisplayArgs))]
            static void FixAlignment(ConsoleArgsDisplay __instance)
            {
                Canvas.ForceUpdateCanvases();
                __instance.gameObject.GetComponent<VerticalLayoutGroup>().enabled = false;
                __instance.gameObject.GetComponent<VerticalLayoutGroup>().enabled = true;
            }
        }
    }
}