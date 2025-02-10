using HarmonyLib;
using System;
using System.Collections;
using System.Linq;
using System.Reflection;
using UnityEngine;
using static Console;

namespace WildfrostHopeMod.CommandsConsole
{
    public partial class ConsoleMod
    {
        public static class PatchTitleAsPrediction
        {
            public static void Run()
            {
                Type commandType = typeof(Console.Command);
                Assembly assembly = commandType.Assembly;
                Type[] types = assembly.GetTypes();
                foreach (Type type in types)
                {
                    if (!type.IsSubclassOf(commandType) || type.IsAbstract) continue;
                    if (type.Name.ToLowerInvariant().Contains("card") || type.Name.ToLowerInvariant().Contains("spawn") || type.Name.ToLowerInvariant().Contains("upgrade"))
                    {
                        Mod.HarmonyInstance.Patch(
                            type.GetMethod(nameof(Console.Command.GetArgOptions)),
                            postfix: new HarmonyMethod(typeof(PatchTitleAsPrediction), "Postfix"));
                    }
                }
            }
            static IEnumerator Postfix(IEnumerator __result, object __instance)
            {
                if (!Mod.autocompleteConfig)
                    yield break;

                Command command = __instance as Command;
                var args = Console.instance.input.text.Split(';').Last().Replace(command.id + " ", "").TrimStart();
                if (command.id.Contains("spawn"))
                {
                    var group = AddressableLoader.groups["CardData"];/*
                    var a = group.list.Last() as CardData;
                    Debug.LogWarning(a.cardType.unit);
                    Debug.LogWarning(a.name);
                    Debug.LogWarning(a.title);
                    Debug.LogWarning(args.ToLower());*/
                    var source = group.list.Cast<CardData>().Where(a => a.cardType.unit && (a.name.ToLower().Contains(args.ToLower()) || a.title.ToLower().Contains(args.ToLower())));
                    command.predictedArgs = source.Select(data => $"{data.name} // {data.title}").ToArray();
                }
                else if (command.id.Contains("card"))
                {
                    var group = AddressableLoader.groups["CardData"];
                    var source = group.list.Cast<CardData>().Where(a => a.name.ToLower().Contains(args.ToLower()) || a.title.ToLower().Contains(args.ToLower()));
                    command.predictedArgs = source.Select(data => $"{data.name} // {data.title}").ToArray();
                }
                else if (command.id.Contains("upgrade"))
                {
                    var group = AddressableLoader.groups["CardUpgradeData"];
                    var source = group.list.Cast<CardUpgradeData>().Where(a => a.name.ToLower().Contains(args.ToLower()) || a.title.ToLower().Contains(args.ToLower()));
                    command.predictedArgs = source.Select(data => $"{data.name} // {data.title}").ToArray();
                }
                yield return null;
            }
        }
    }
}