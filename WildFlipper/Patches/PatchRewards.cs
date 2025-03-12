using Deadpan.Enums.Engine.Components.Modding;
using FMODUnity;
using HarmonyLib;
using HarmonyLib.Public.Patching;
using ICSharpCode.Decompiler.CSharp.Syntax;
using Mono.Cecil.Cil;
using NaughtyAttributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;
using UnityEngine.Localization;
using UnityEngine.SceneManagement;
using OpCodes = System.Reflection.Emit.OpCodes;

//[HarmonyPatch]
public class Patches
{
    //[HarmonyPostfix][HarmonyPatch(typeof(AssetLoader), nameof(AssetLoader.Awake))]
    internal static void Awake()
    {
        //Events.OnEntityDrag += Focus;
        //Events.OnEntityPlace += Unfocus;
        foreach (var invoker in typeof(Events).GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly))
        {
            if (invoker.Name.StartsWith("add_") || invoker.Name.StartsWith("remove_"))
            {
                WildFlipper.WildFlipperMod.instance.HarmonyInstance.Patch(
                    original: invoker
                    , prefix: new HarmonyMethod(typeof(Patches).GetMethod(nameof(AddDebugger)))
                    );
                continue;
            }
            //Debug.LogWarning($"Trying to patch [{invoker.Name}]");
            WildFlipper.WildFlipperMod.instance.HarmonyInstance.Patch(
                original: invoker
                , prefix: new HarmonyMethod(typeof(Patches).GetMethod(nameof(Debugger)))
                );
        }

        foreach (var invoker in typeof(StatusEffectData).GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly))
        {
            //Debug.LogWarning($"Trying to patch [{invoker.Name}]");
            if (invoker.Name.StartsWith("add_") || invoker.Name.StartsWith("remove_"))
            {
                WildFlipper.WildFlipperMod.instance.HarmonyInstance.Patch(
                    original: invoker
                    //, prefix: new HarmonyMethod(typeof(Patches).GetMethod(nameof(EffectAddDebugger)))
                    );
                continue;
            }
            if (invoker.Name.StartsWith("get_"))
                continue;

            if (!(invoker.Name.EndsWith("Event") || invoker.Name.EndsWith("Routine") || invoker.Name == "Init" || invoker.Name == "Apply"))
                continue;

            Debug.LogWarning($"~~~~~~~Trying to patch [{invoker.Name}]");
            WildFlipper.WildFlipperMod.instance.HarmonyInstance.Patch(
                original: invoker
                , prefix: new HarmonyMethod(typeof(Patches).GetMethod(nameof(EffectDebugger)))
                );
        }
    }

    internal static string Print(object a)
    {
        if (a == null)
            return $"NULL [{a?.GetType()}]";
        if (a is Scene scene)
            return scene.name;
        if (a is Entity entity)
            return $"{entity.name} (id: {entity.data?.id})";
        if (a is CardData cardData)
            return $"{cardData.name} (id: {cardData.id})";
        if (a is StatusEffectApply statusEffectApply)
            return (statusEffectApply.applier?.ToString() ?? "NULL APPLIER", statusEffectApply.target?.ToString() ?? "NULL TARGET", statusEffectApply.effectData?.ToString() ?? "NULL EFFECT", statusEffectApply.count).ToString();
        return a.ToString();
    }


    //[HarmonyPostfix][HarmonyPatch(typeof(Events), nameof(Events.InvokeSlotHover))]
    public static void Debugger(
        MethodBase __originalMethod,
        object[] __args
        )
    {
        try
        {
            Debug.LogWarning($"[Events] {__originalMethod.Name} ({__args.Where(a => a != null).Join(Print)})");
        }
        catch
        {
            Debug.LogError($"[Events] {__originalMethod.Name}");
            foreach (var a in __args)
            {
                Debug.LogWarning(Print(a));
            }

        }
    }
    public static void AddDebugger(
        MethodBase __originalMethod,
        object value
        )
    {
        if (AccessTools.Method(value.GetType(), nameof(UnityAction.GetInvocationList)).Invoke(value, null) is Delegate[] delegates)
        {
            foreach (var item in delegates)
                Debug.Log($"[Events] {(
                    __originalMethod.Name.StartsWith("add_")
                    ? __originalMethod.Name.Substring("add_".Length) + " +="
                    : __originalMethod.Name.Substring("remove_".Length) + " -="
                    )} {(item.Method.DeclaringType != null ? item.Method.DeclaringType + "::" : "")}{item.Method.Name}");
        }
    }







    public static void EffectDebugger(
        StatusEffectData __instance,
        MethodBase __originalMethod,
        object[] __args
        )
    {
        try
        {
            Debug.LogWarning($"[StatusEffect: {__instance?.name} (id: {__instance?.id})] {__originalMethod.Name} ({__args.Where(a => a != null).Join(Print)})");
        }
        catch
        {
            Debug.LogError($"[StatusEffect: {__instance?.name} (id: {__instance?.id})] {__originalMethod.Name}");
            foreach (var a in __args)
            {
                Debug.LogWarning(Print(a));
            }

        }
    }


    public static void EffectAddDebugger(
        StatusEffectData __instance,
        MethodBase __originalMethod,
        object value
        )
    {
        if (AccessTools.Method(value.GetType(), nameof(UnityAction.GetInvocationList)).Invoke(value, null) is Delegate[] delegates)
        {
            foreach (var item in delegates)
                Debug.LogWarning($"[StatusEffect: {__instance?.name} (id: {__instance?.id})] {(
                    __originalMethod.Name.StartsWith("add_")
                    ? __originalMethod.Name.Substring("add_".Length) + " +="
                    : __originalMethod.Name.Substring("remove_".Length) + " -="
                    )} {(item.Method.DeclaringType != null ? item.Method.DeclaringType + "::" : "")}{item.Method.Name}");
        }
    }

}