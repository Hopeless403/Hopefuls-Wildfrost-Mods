using HarmonyLib;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using static Console;

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

            /*[HarmonyPrefix]
            [HarmonyPatch(typeof(Console), nameof(Console.CheckScrollPrevious))]*/
            static bool CheckScrollPrevious(Console __instance)
            {
                string[] args = __instance.argsDisplay.current;
                // If no predicted args, disable scrolling
                if (__instance.input.text.IsNullOrWhitespace() || !__instance.argsDisplay.gameObject.activeSelf || args?.Length <= 1 || !instance.scrollConfig)
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

            [HarmonyPrefix]
            [HarmonyPatch(typeof(Console), nameof(Console.Update))]
            static bool Update(Console __instance)
            {
                if (__instance.toggle.Any(Input.GetKeyDown))
                {
                    __instance.Toggle();
                }

                if (Console.active)
                {
                    if (Input.GetKeyDown(KeyCode.Escape))
                    {
                        __instance.Toggle();
                        return false;
                    }

                    if (Input.GetKeyDown(__instance.takePredict) && __instance.argsDisplay.Count > 0)
                    {
                        Command exactCommand = GetExactCommand(__instance.input.text.TrimStart());
                        if (exactCommand != null)
                        {
                            __instance.input.text = exactCommand.id + " " + __instance.argsDisplay.TopArgument;
                        }
                        else
                        {
                            __instance.input.text = __instance.argsDisplay.TopCommand;
                        }

                        __instance.input.MoveToEndOfLine(shift: false, ctrl: false);
                        return false;
                    }

                    CheckScrollPrevious(__instance);

                    if (Input.GetKeyDown(KeyCode.Return))
                    {
                        string text = __instance.input.text.Trim();
                        if (text.Length > 0)
                        {
                            new Routine(HandleCommand(text));
                            __instance.input.text = "";
                            __instance.preIndex = -1;
                        }
                    }

                    for (int i = 0; i < __instance.saveKeys.Length; i++)
                    {
                        KeyCode keyCode = __instance.saveKeys[i];
                        if (!Input.GetKeyDown(keyCode))
                        {
                            continue;
                        }

                        string text2 = __instance.input.text.Trim();
                        if (text2.Length > 0)
                        {
                            __instance.savedCommands[i] = text2;
                            Log($"Command '{text2}' Saved to {keyCode}");
                            __instance.SaveCommands();
                            __instance.input.text = "";
                            __instance.preIndex = -1;
                        }
                        else if (__instance.savedCommands.Length > i)
                        {
                            string text3 = __instance.savedCommands[i];
                            if (text3.Length > 0)
                            {
                                new Routine(HandleCommand(text3));
                                __instance.input.text = "";
                                __instance.preIndex = -1;
                            }
                        }
                    }

                    if (!__instance.input.isFocused)
                    {
                        EventSystem current = EventSystem.current;
                        if ((object)current != null)
                        {
                            current.SetSelectedGameObject(__instance.input.gameObject, null);
                            __instance.input.OnPointerClick(new PointerEventData(current));
                        }
                    }

                    return false;
                }
                return false;
            }

        }
    }
}