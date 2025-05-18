using HarmonyLib;
using ICSharpCode.Decompiler.Util;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace WildfrostHopeMod.CommandsConsole
{
    public partial class ConsoleMod
    {
        [HarmonyPatch]
        internal class PatchHelpText
        {
            [HarmonyPatch(typeof(Console), nameof(Console.PopulateHelp))]
            static void Postfix(Console __instance)
            {
                List<string> text = [.. __instance.helpText.text.Split(["\n"], System.StringSplitOptions.None)];
                text.Sort();
                __instance.helpText.SetText(text.Join(delimiter:"\n"));
            }
        }


    }
}