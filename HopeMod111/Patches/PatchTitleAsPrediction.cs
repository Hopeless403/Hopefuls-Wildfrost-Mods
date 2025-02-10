using HarmonyLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;
using static Console;

namespace WildfrostHopeMod.CommandsConsole
{
    public partial class ConsoleMod
    {
        //[HarmonyPatch(typeof(Console.Command), nameof(Console.Command.GetArgOptions))]
        public static class PatchTitleAsPrediction
        {
            static readonly string[] typesToCheck = ["spawn", "card", "upgrade", "modifier", "battle"];
            public static void Run()
            {
                Type commandType = typeof(Console.Command);
                Assembly assembly = commandType.Assembly;
                Type[] types = assembly.GetTypes();
                foreach (Type type in types)
                {
                    if (!type.IsSubclassOf(commandType) || type.IsAbstract) continue;
                    if (typesToCheck.Any(t => type.Name.ToLowerInvariant().Contains(t)))
                    {
                        var method = type.GetMethod(nameof(Console.Command.GetArgOptions));
                        Debug.LogWarning(method.FullDescription());
                        if (method != null)
                        Mod.HarmonyInstance.Patch(method,
                            postfix: new HarmonyMethod(typeof(PatchTitleAsPrediction), nameof(Postfix)));
                    }
                }
            }
            static IEnumerator Postfix(IEnumerator __result, object __instance)
            {
                if (!Mod.autocompleteConfig)
                    yield break;

                if (__instance is not Command command)
                    yield break;

                var args = Console.instance.input.text.Split(';').Last().Replace(command.id + "\t", "").Replace(command.id + " ", "").TrimStart();
                if (command.id.Contains("spawn"))
                {
                    var group = AddressableLoader.groups[nameof(CardData)];
                    var source = group.list.Cast<CardData>().Where(a => a.cardType.unit && (a.name.ToLower().Contains(args.ToLower()) || a.title.ToLower().Contains(args.ToLower())));
                    command.predictedArgs = source.Select(data => $"{data.name} \t// {data.title}").ToArray();
                }
                else if (command.id.Contains("card"))
                {
                    var group = AddressableLoader.groups[nameof(CardData)];
                    var source = group.list.Cast<CardData>().Where(a => a.name.ToLower().Contains(args.ToLower()) || a.title.ToLower().Contains(args.ToLower()));
                    command.predictedArgs = source.Select(data => $"{data.name} \t// {data.title}").ToArray();
                }
                else if (command.id.Contains("upgrade"))
                {
                    var group = AddressableLoader.groups[nameof(CardUpgradeData)];
                    var source = group.list.Cast<CardUpgradeData>().Where(a => a.name.ToLower().Contains(args.ToLower()) || a.title.ToLower().Contains(args.ToLower()));
                    command.predictedArgs = source.Select(data => $"{data.name} \t// {data.title}").ToArray();
                }
                else if (command.id.Contains("modifier"))
                {
                    var group = AddressableLoader.groups[nameof(GameModifierData)];
                    var source = group.list.Cast<GameModifierData>().Where(a => a.name.ToLower().Contains(args.ToLower()) 
                    || (
                        a.titleKey != null && !a.titleKey.IsEmpty && a.titleKey.GetLocalizedString().ToLower().Contains(args.ToLower())
                        ));
                    command.predictedArgs = source.Select(data => (data.titleKey != null && !data.titleKey.IsEmpty) ? $"{data.name} \t// {data.titleKey.GetLocalizedString()}" : data.name).ToArray();
                }
                else if (command.id == "next battle")
                {
                    var group = AddressableLoader.groups[nameof(BattleData)];
                    var source = group.list.Cast<BattleData>().Where(a => a.name.ToLower().Contains(args.ToLower())
                    || (
                        a.nameRef != null && !a.nameRef.IsEmpty && a.nameRef.GetLocalizedString().ToLower().Contains(args.ToLower())
                        ));
                    command.predictedArgs = source.Select(data => (data.nameRef != null && !data.nameRef.IsEmpty) ? $"{data.name} \t// {data.nameRef.GetLocalizedString()}" : data.name).ToArray();
                }
                //Debug.Log($"'{command.id}'");
                yield return null;
            }
        }
    }
}