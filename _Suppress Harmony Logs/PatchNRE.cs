using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using MonoMod.Utils;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace WildfrostHopeMod.HarmonySuppressor;

//[HarmonyPatch]
internal class PatchNRE
{
    [HarmonyPatch(typeof(RuntimeHelpers), nameof(RuntimeHelpers.ExecuteCodeWithGuaranteedCleanup))]
    static void Postfix(TryCode code, CleanupCode backoutCode, object userData)
    {
        Debug.LogError("AYO WE POSTFIXED THE ERROR SOMEHOW? LMAO");
        Debug.LogError((code, backoutCode, userData));
        
        LogFrames();
        _ = typeof(CardDataBuilder);
    }

    [HarmonyPatch(typeof(UnityEngine.StackTraceUtility), "ExtractFormattedStackTrace")]
    static void Postfix(System.Diagnostics.StackTrace stackTrace, string __result)
    {
        Debug.LogError("AYO WE POSTFIXED THE ExtractFormattedStackTrace SOMEHOW? LMAO");
        Debug.LogWarning($"--------\n{__result}\n--------");
    }

    [HarmonyPatch(typeof(Debug), nameof(Debug.LogException), typeof(Exception), typeof(UnityEngine.Object))]
    [HarmonyPostfix][HarmonyPatch(typeof(Debug), nameof(Debug.LogException), typeof(Exception))]
    static void SetErrorCode(Exception exception)
    {
        _ = nameof(UnityEngine.EventSystems.ExecuteEvents.Execute);
        Debug.LogError("AYO WE POSTFIXED THE LogException SOMEHOW? LMAO");
        Debug.LogWarning($"----------------");
        exception.LogDetailed();
        Debug.LogWarning($"----------------");
    }



    [HarmonyPatch(typeof(NullReferenceException), MethodType.Constructor)]
    static void Postfix(NullReferenceException __instance)
    {
        
        Debug.LogError("AYO WE POSTFIXED THE NullReferenceException Constructor SOMEHOW? LMAO");
        Debug.LogWarning(AccessTools.GetMethodNames(typeof(Application.LogCallback)).Join());
        //LogFrames();
        __instance.LogDetailed();
    }
    [HarmonyPatch(typeof(Application.LogCallback), nameof(Application.LogCallback.Invoke))]
    [HarmonyPatch(typeof(Application.LogCallback), nameof(Application.LogCallback.BeginInvoke))]
    [HarmonyPatch(typeof(Application.LogCallback), nameof(Application.LogCallback.EndInvoke))]
    static void Postfix(Application.LogCallback __instance)
    {
        Debug.LogError("AYO WE POSTFIXED THE LogCallback Constructor SOMEHOW? LMAO");
    }
    public static event Application.LogCallback logMessageReceived;
    static void LogFrames()
    {
        //logMessageReceived?.Invoke()
        Debug.LogWarning(
            new System.Diagnostics.StackTrace(fNeedFileInfo: true).GetFrames()
            .Join(
                f => $"{f.GetMethod().DeclaringType?.Name}::{f.GetMethod().Name}",
                delimiter: "\n"
                )
            );
    }

    static void Method()
    {
        StatusEffectSystem.Apply(null, null, null, 0);

        AccessTools.GetOutsideCaller();
        throw new NullReferenceException();
    }
}
public static class owo
{
    public static T PrintAllFields<T>(this T t, Type type = null)
    {
        foreach (var field in t.GetAllFields(type))
        {
            try { Debug.Log($"{field.Name}: {field.GetValue(t) ?? "null"}"); }
            catch { Debug.Log($"{field.Name} failed"); }
        }
        return t;
    }
    public static FieldInfo[] GetAllFields<T>(this T t, Type type = null)
    {
        return (type ?? t.GetType()).GetFields((BindingFlags)0x1FFFFFD);//.Concat(typeof(T).GetFields((BindingFlags)0x1FFFFFF)).ToArray();
    }
}