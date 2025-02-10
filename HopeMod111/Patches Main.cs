using Deadpan.Enums.Engine.Components.Modding;
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
        [HarmonyPatch(typeof(Console), nameof(Console.Commands))]
        internal class PatchAddCustomCommands
        {
            static void Postfix(Console __instance)
            {
                RegisterCommands();
                foreach (var command in ConsoleCustom.commands)
                {
                    MonoBehaviour.print(command.id);
                    Console.commands.Add(command);
                }
            }
        }
        [HarmonyPatch(typeof(Console.Command), nameof(Console.Command.Fail))]
        internal class PatchDebugFail
        {
            static void Postfix(Console.Command __instance, string message)
                => Debug.LogError($"[AConsole mod] {message}");
        }


        [HarmonyPatch(typeof(Console), nameof(Console.Toggle))]
        internal class PatchToggleCloseUE
        {
            static void Prefix(out bool __state)
            {
                __state = false;
                if (Console.active)
                    return;
                if (Bootstrap.Mods.Any(mod => mod.GUID == "kopie.wildfrost.unityexplorer" && mod.HasLoaded))
                {
                    __state = UIManager.ShowMenu;
                    UIManager.ShowMenu = false;
                }
            }
            static void Postfix(bool __state) => CoroutineManager.Start(RetoggleAfterInputFocus(__state));
            static IEnumerator RetoggleAfterInputFocus(bool __state)
            {
                if (!__state) yield break;
                yield return new WaitUntil(() => Console.instance.input.isFocused);
                UIManager.ShowMenu = __state;
            }
            internal static void RetoggleConsoleAfterUELoaded(WildfrostMod mod)
            {
                if (mod.GUID != "kopie.wildfrost.unityexplorer") return;
                CoroutineManager.Start(RetoggleConsoleAfterUELoadedIE());
            }
            static IEnumerator RetoggleConsoleAfterUELoadedIE()
            {
                yield return new WaitUntil(() => UIManager.UICanvas);
                yield return new WaitForSeconds(0.35f);
                Console.instance?.Toggle();
                yield return null;
                Console.instance?.Toggle();
            }
        }


        /*[HarmonyPatch(typeof(Console), nameof(Console.KeepFocus))]
        public class PatchKeepFocus
        {
            public static bool Prefix(Console __instance)
            {
                Debug.LogWarning(EventSystem.current);
                EventSystem current = EventSystem.current;
                if (current == null)
                    return true;
                current.SetSelectedGameObject(__instance.input.gameObject, null);
                __instance.input.OnPointerClick(new PointerEventData(current));
                
                return false;
            }
        }*/
    }
}