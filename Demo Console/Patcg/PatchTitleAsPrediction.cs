using BepInEx.Unity.IL2CPP.Utils;
using HarmonyLib;
using Il2CppSystem.Collections;
using System;
//using System.Collections;
using System.Collections.Generic;
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
                        HarmonyInstance.Patch(
                            type.GetMethod(nameof(Console.Command.GetArgOptions)),
                            postfix: new HarmonyMethod(typeof(PatchTitleAsPrediction), "Postfix"));
                    }
                }
            }
            static void Postfix(object __instance, IEnumerator __result)
            {
                if (!instance.autocompleteConfig)
                    return;
                
                Command command = __instance as Command;
                string[] array = [];
                command.predictedArgs = array;
                var args = Console.instance.input.text.Split(';').Last().Replace(command.id + " ", "").TrimStart();

                System.Collections.IEnumerator SetArgs(string[] args)
                {
                    yield return new WaitUntil((Func<bool>)(() => !__result.MoveNext()));
                    command.predictedArgs = args;
                }

                if (command.id.Contains("spawn"))
                {
                    var group = AddressableLoader.groups["CardData"];
                    var source = group.list.ToArray().ToList().Cast<CardData>().Where(a => a.cardType.unit && (a.name.ToLower().Contains(args.ToLower()) || (a.titleKey != null && !a.titleKey.IsEmpty && a.title.ToLower().Contains(args.ToLower()))));
                    SfxSystem.instance.StartCoroutine(SetArgs(source.Select(data => data.titleKey == null || data.titleKey.IsEmpty ? data.name : $"{data.name} // {data.title}").ToArray()));
                    //command.predictedArgs = source.Select(data => $"{data.name} // {data.title}").ToArray();
                }
                else if (command.id.Contains("card"))
                {
                    var group = AddressableLoader.groups["CardData"];
                    var source = group.list.ToArray().ToList().Cast<CardData>().Where(a => a.name.ToLower().Contains(args.ToLower()) || (a.titleKey != null && !a.titleKey.IsEmpty && a.title.ToLower().Contains(args.ToLower())));
                    SfxSystem.instance.StartCoroutine(SetArgs(source.Select(data => data.titleKey == null || data.titleKey.IsEmpty ? data.name : $"{data.name} // {data.title}").ToArray()));
                    //command.predictedArgs = source.Select(data => $"{data.name} // {data.title}").ToArray();
                }
                else if (command.id.Contains("upgrade"))
                {
                    var group = AddressableLoader.groups["CardUpgradeData"];
                    var source = group.list.ToArray().ToList().Select(a => a.Cast<CardUpgradeData>()).Where(a => a.name.ToLower().Contains(args.ToLower()) || (a.titleKey != null && !a.titleKey.IsEmpty && a.title.ToLower().Contains(args.ToLower())));
                    SfxSystem.instance.StartCoroutine(SetArgs(source.Select(data => data.titleKey == null || data.titleKey.IsEmpty ? data.name : $"{data.name} // {data.title}").ToArray()));
                    //command.predictedArgs = source.Select(data => $"{data.name} // {data.title}").ToArray();
                }
                //yield return null;
            }
        }
    }
}