using Deadpan.Enums.Engine.Components.Modding;
using FMODUnity;
using HarmonyLib;
using HarmonyLib.Public.Patching;
using Mono.Cecil.Cil;
using NaughtyAttributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using WildfrostHopeMod.HarmonySuppressor;
using OpCodes = System.Reflection.Emit.OpCodes;

[HarmonyPatch]
public class Patches
{
    //[HarmonyPostfix]
    [HarmonyPatch(typeof(AssetLoader), nameof(AssetLoader.Awake))]
    static void Awake()
    {
        Events.OnEntityDrag += Focus;
        Events.OnEntityPlace += Unfocus;
        foreach (var invoker in typeof(Events).GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly))
        {
            if (invoker.Name.StartsWith("add_") || invoker.Name.StartsWith("remove_"))
            {
                HarmonySuppressorPlugin.harmony.Patch(
                original: invoker,
                prefix: new HarmonyMethod(typeof(Patches).GetMethod(nameof(AddDebugger)))
                );
                continue;
            }
            //Debug.LogWarning($"Trying to patch [{invoker.Name}]");
            HarmonySuppressorPlugin.harmony.Patch(
                original: invoker,
                prefix: new HarmonyMethod(typeof(Patches).GetMethod(nameof(Debugger)))
                );
            //AccessTools.GetMethodNames(Events.OnAbilityTargetAdd);
            AccessTools.GetFieldNames(typeof(Events));
        }
    }


    

    static void Focus(Entity entity)
    {
        CinemaBarSystem.In();
        CinemaBarSystem.Top.SetPrompt($"Breathe, {entity.name}... breathe", "");
        CinemaBarSystem.SetSortingLayer("UI2");
        /*var anim = GameObject.FindObjectOfType<ChangePhaseAnimationSystem>();
        anim.StartCoroutine(anim.Focus(entity));*/
        BattleMusicSystem musicSystem = UnityEngine.Object.FindObjectOfType<BattleMusicSystem>();
        /*if ((UnityEngine.Object)musicSystem != (UnityEngine.Object)null)
            musicSystem.FadePitchTo(0.3333f);*/
    }
    static void Unfocus(Entity entity, CardContainer[] _, bool idk)
    {
        /*var anim = GameObject.FindObjectOfType<ChangePhaseAnimationSystem>();
        anim.StartCoroutine(anim.UnFocus());*/
        BattleMusicSystem musicSystem = UnityEngine.Object.FindObjectOfType<BattleMusicSystem>();
        if ((UnityEngine.Object)musicSystem != (UnityEngine.Object)null)
            musicSystem.FadePitchTo(1);

        CinemaBarSystem.Clear();
        CinemaBarSystem.Out();
    }




    static event UnityAction owo;

    //[HarmonyPostfix][HarmonyPatch(typeof(Events), nameof(Events.InvokeSlotHover))]
    public static void Debugger(
        MethodBase __originalMethod, 
        object[] __args
        )
    {
        //MethodBase __originalMethod = AccessTools.GetOutsideCaller();
        //nameof(HarmonyManipulator);

        try
        {
            Debug.Log($"[Events] {__originalMethod.Name} ({__args.Where(a => a != null).Join(a => a.ToString())})");
        }
        catch
        {
            Debug.LogError($"[Events] {__originalMethod.Name}");
            foreach (var a in __args)
                Debug.LogWarning(a);
        }

        //Debug.LogWarning(AccessTools.GetOutsideCaller());

        //return stringBuilder.ToString();
    }

    public static void AddDebugger(
        MethodBase __originalMethod,
        object value
        )
    {
        if (AccessTools.Method(value.GetType(), nameof(UnityAction.GetInvocationList)).Invoke(value, null) is Delegate[] delegates)
        {
            foreach (var item in delegates)
                Debug.LogWarning($"[Events] {(
                    __originalMethod.Name.StartsWith("add_") 
                    ? __originalMethod.Name.Substring("add_".Length) + " +="
                    : __originalMethod.Name.Substring("remove_".Length) + " -="
                    )} {(item.Method.DeclaringType != null ? item.Method.DeclaringType + "::" : "")}{item.Method.Name}");
        }
    }

    /*[HarmonyPostfix]
    [HarmonyPatch(typeof(CardData), nameof(CardData.Clone), typeof(bool))]
    [HarmonyPatch(typeof(CardData), nameof(CardData.Clone), typeof(Vector3), typeof(bool))]
    [HarmonyPatch(typeof(CardData), nameof(CardData.Clone), typeof(Vector3), typeof(ulong), typeof(bool))]
    static void Clone()
    {
        var frames = new System.Diagnostics.StackTrace(fNeedFileInfo: true).GetFrames();
        for (int i = 0; i < frames.Length; i++)
        {
            MethodBase method = frames[i].GetMethod();
            if (method.DeclaringType?.Namespace != typeof(Harmony).Namespace)
            {
                Debug.LogError(method.FullDescription());
            }
        }
        throw new Exception();
    }*/

    /*[HarmonyPostfix][HarmonyPatch(typeof(ValueType), nameof(ValueType.ToString))]
    public static string ToString(string __result, ValueType __instance)
    {
        if (__instance is Scene scene)
            return scene.name;
        return __result;
    }*/

    /*[HarmonyPostfix]
    [HarmonyPatch(typeof(HarmonyManipulator), "EmitCallParameter")]
    public static void Debugger(
        MethodBase __originalMethod, 
        MethodBase original, MethodInfo patch, Dictionary<string, VariableDefinition> variables, bool allowFirsParamPassthrough)
    {
        Debug.LogError($"======== PATCHING THE PATCHER ========");
        Debug.LogError($"======== {original.FullDescription()} ========");

        patch.GetArgumentIndex()
        foreach (var item in patch.GetParameters())
            Debug.LogWarning((item.Name, item.va));
    }


    readonly MethodBase original;
    readonly Emitter emitter;
    void RestoreArgumentArray(Dictionary<string, LocalBuilder> variables)
    {
        var parameters = original.GetParameters();
        var i = 0;
        var arrayIdx = 0;
        foreach (var pInfo in parameters)
        {
            var argIndex = i++ + (original.IsStatic ? 0 : 1);
            var pType = pInfo.ParameterType;
            if (pType.IsByRef)
            {
                pType = pType.GetElementType();

                emitter.Emit(OpCodes.Ldarg, argIndex);
                emitter.Emit(OpCodes.Ldloc, variables[ARGS_ARRAY_VAR]);
                emitter.Emit(OpCodes.Ldc_I4, arrayIdx);
                emitter.Emit(OpCodes.Ldelem_Ref);

                if (pType.IsValueType)
                {
                    emitter.Emit(OpCodes.Unbox_Any, pType);
                    if (AccessTools.IsStruct(pType))
                        emitter.Emit(OpCodes.Stobj, pType);
                    else
                        emitter.Emit(StoreIndOpCodeFor(pType));
                }
                else
                {
                    emitter.Emit(OpCodes.Castclass, pType);
                    emitter.Emit(OpCodes.Stind_Ref);
                }
            }
            arrayIdx++;
        }
    }*/




    [HarmonyPatch(typeof(BattleSaveSystem), nameof(BattleSaveSystem.LoadRoutine))]
    [HarmonyPatch(typeof(BattleSaveSystem), nameof(BattleSaveSystem.CreateCards))]
    [HarmonyPatch(typeof(BattleSetUp), nameof(BattleSetUp.Run))]
    [HarmonyPatch(typeof(BoardDisplay), nameof(BoardDisplay.SetUp))]
    [HarmonyPatch(typeof(BattleSetUp), nameof(BattleSetUp.StartAnimation))]
    [HarmonyPatch(typeof(Battle), nameof(Battle.Run))]
    static IEnumerator Postfix(IEnumerator __result, MethodBase __originalMethod)
    {
        Debug.LogWarning($">>> {__originalMethod.FullDescription()} PREFIX");
        yield return __result;
        Debug.LogWarning($">>> {__originalMethod.FullDescription()} POSTFIX");
    }

    [HarmonyPatch(typeof(BattleSaveSystem), nameof(BattleSaveSystem.CreateCards))]
    static IEnumerator Postfix(IEnumerator __result, CardContainer container, IReadOnlyList<BattleEntityData> entitySaveData)
    {
        Debug.LogError($">>> PREFIX");
        Debug.LogError($">>> [{container}] [{entitySaveData.Join()}]");
        yield return __result;
        Debug.LogError($">>> POSTFIX");
    }
}