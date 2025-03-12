using HarmonyLib;
using System.Collections.Generic;
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
                if (args == null) return true;

                List<string> scrolledArgs = args.Clone<string>();
                // If no predicted args, disable scrolling
                if (Input.GetKey(KeyCode.LeftAlt) || __instance.input.text.IsNullOrWhitespace() || !__instance.argsDisplay.gameObject.activeSelf || args?.Length <= 1 || !Mod.scrollConfig)
                {
                    return true;
                }

                bool updateDisplay = false;

                // String is non-empty.
                if (PatchRunMultipleCommands.exactCommand == null)
                {
                    if (Input.GetAxis("Mouse ScrollWheel") > 0f)
                        for (int i = 0; i < args.Length; i++)
                        {
                            scrolledArgs[(i + 1) % args.Length] = args[i];
                            updateDisplay = true;
                        }
                    else if (Input.GetAxis("Mouse ScrollWheel") < 0f)
                        for (int i = 0; i < args.Length; i++)
                        {
                            scrolledArgs[(args.Length + i - 1) % args.Length] = args[i];
                            updateDisplay = true;
                        }

                    Console.instance.argsDisplay.commands = scrolledArgs
                        .Select(a => Console.commands.FirstOrDefault(c => a.Contains(c.id))).ToArray();
                }
                else
                {
                    // Now check if holding the key, and speedscroll if so
                    if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
                        currentHoldTime += Time.unscaledDeltaTime;
                    else currentHoldTime = 0;

                    if (currentHoldTime >= holdTime) tick++;
                    if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetAxis("Mouse ScrollWheel") > 0f || (tick == 3 && Input.GetKey(KeyCode.UpArrow)))
                        for (int i = 0; i < args.Length; i++)
                        {
                            tick = 0;
                            scrolledArgs[(i + 1) % args.Length] = args[i];
                            updateDisplay = true;
                        }
                    else if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetAxis("Mouse ScrollWheel") < 0f || (tick == 3 && Input.GetKey(KeyCode.DownArrow)))
                        for (int i = 0; i < args.Length; i++)
                        {
                            tick = 0;
                            scrolledArgs[(args.Length + i - 1) % args.Length] = args[i];
                            updateDisplay = true;
                        }
                }
                
                if (updateDisplay)
                {
                    __instance.argsDisplay.DisplayArgs(scrolledArgs.ToArray());
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