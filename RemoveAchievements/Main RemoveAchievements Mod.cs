using Deadpan.Enums.Engine.Components.Modding;
using FMODUnity;
using HarmonyLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Steamworks;
using Steamworks.Data;
using UnityEngine.AddressableAssets;
using System.Reflection;
using UnityEngine.SceneManagement;
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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;
using UnityEngine.Localization;
using UnityEngine.SceneManagement;
using OpCodes = System.Reflection.Emit.OpCodes;
using System.CodeDom;
using System.Diagnostics;
using Debug = UnityEngine.Debug;

namespace WildfrostHopeMod.RemoveAchievements
{
    [HarmonyPatch]
    public class RemoveAchievementsMod : WildfrostMod
    {
        public static RemoveAchievementsMod instance;
        public RemoveAchievementsMod(string modDirectory) : base(modDirectory)
        {
            instance = this;
        }
        public override string GUID => "hope.wildfrost.test";
        public override string[] Depends => new string[] { };
        public override string Title => "Extreme Debugging (NOT FOR REGULAR PLAY)";
        public override string Description => """
            !!! If you're not encountering an error / crash, this mod won't do anything for you.
            Debugs A LOT more of the Events and StatusEffect routines so you'll know where and when things break

            Because of all the logs, this can slightly slow down the game during fights.



            NOTE: This mod also relies on patching the way Harmony patches methods, particularly by allowing you to use `object[] __args` as a variable for HarmonyPrefixes to get the initial value of the patched method's arguments
            I don't guarantee this won't cause other unrelated load/unload issues
            """;

        public override TMP_SpriteAsset SpriteAsset => base.SpriteAsset;
        public static GameObject behaviour;
        static ErrorHandlerSystem system;
        public class EscapeErrors : MonoBehaviour
        {
            void Update()
            {
                system ??= GameObject.FindObjectOfType<ErrorHandlerSystem>();
                if (system.errorDisplay.activeSelf && Input.GetKey(KeyCode.Escape))
                    system.HideError();
            }
        }
        public override void Load()
        {
            behaviour = new(Title, typeof(EscapeErrors));
            //Debug.LogWarning("MOD LOADing");
            base.Load();
            //Debug.LogWarning("MOD LOADED");
            //this.HarmonyInstance.GetPatchedMethods().Do(Debug.LogWarning);

            Awake();
            /*foreach (Achievement achievement in SteamUserStats.Achievements)
            {
                Debug.Log($"→ {achievement.Name} ({achievement.State})");
            }*/
            //var a = Addressables.LoadAssetAsync<UnityEngine.Object>("Assets/Locales/English (en).asset").WaitForCompletion();
        }
        public override void Unload()
        {
            base.Unload();
            GameObject.Destroy(behaviour);
            behaviour = null;
        }

        internal static void Awake()
        {
            _ = typeof(HarmonyManipulator);
            //Events.OnEntityDrag += Focus;
            //Events.OnEntityPlace += Unfocus;


            /// NOTES: First 3 work fine. They also have arguments

            int attempt = 0;
            int limit = -20;
            foreach (var invoker in typeof(Events).GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly))
            {
                if (invoker.Name.StartsWith("add_") || invoker.Name.StartsWith("remove_"))
                {
                    instance.HarmonyInstance.Patch(
                        original: invoker
                        //, prefix: new HarmonyMethod(typeof(RemoveAchievementsMod).GetMethod(nameof(AddDebugger)))
                        );
                    continue;
                }

                // Too annoying
                if (invoker.Name.Contains("Slot") || invoker.Name.Contains("Container"))
                    continue;


                Debug.LogWarning($"Trying to patch [{invoker.Name}] [{invoker.GetParameters().Join(p => p.Name)}]");
                instance.HarmonyInstance.Patch(
                    original: invoker
                    , prefix: new HarmonyMethod(typeof(RemoveAchievementsMod).GetMethod(nameof(Debugger)))
                    );

                if (attempt++ == limit)
                    break;/////
            }
            //return;///////



            foreach (var invoker in typeof(StatusEffectData).GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly))
            {
                //Debug.LogWarning($"Trying to patch [{invoker.Name}]");
                if (invoker.Name.StartsWith("add_") || invoker.Name.StartsWith("remove_"))
                {
                    instance.HarmonyInstance.Patch(
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
                instance.HarmonyInstance.Patch(
                    original: invoker
                    , prefix: new HarmonyMethod(typeof(RemoveAchievementsMod).GetMethod(nameof(EffectDebugger)))
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
            MethodBase __originalMethod
            ,object[] __args
            )
        {
            try
            {
                Debug.LogWarning($"[Events] {__originalMethod.Name} ({__args.Where(a => a != null).Join(Print)})");
                //Debug.LogWarning($"[Events] {__originalMethod.Name})");
                //Debug.LogWarning(__args?.Count().ToString() ?? "NULL");
            }
            catch
            {
                Debug.LogError($"[Events] {__originalMethod.Name}");
                /*foreach (var a in __args)
                {
                    Debug.LogWarning(Print(a));
                }*/
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
            object[] __args,
            MethodBase __originalMethod
            )
        {
            try
            {
                string s = $"[StatusEffect: {__instance?.name} (id: {__instance?.id})] {__originalMethod?.Name} ({__args.Where(a => a != null).Join(Print)})";
                //if (AccessTools.GetReturnedType(__originalMethod) 
                if (__originalMethod.Name.EndsWith("Event"))
                    //Debug.Log(s)
                        ;
                else 
                    Debug.LogWarning(s);
            }
            catch
            {
                Debug.LogError($"WE FAILED AT [{__originalMethod}]: {(__instance)}");
                //Debug.Log($"[StatusEffect: {__instance?.name} (id: {__instance?.id})] {__originalMethod?.Name}");
                foreach (var a in __args)
                {
                    Debug.LogWarning(Print(a));
                }

            }
        }

        
        public static void IEnumeratorEffectDebugger(
            ref IEnumerator __result,
            StatusEffectData __instance,
            MethodBase __originalMethod,
            object[] __args
            )
        {
            Debug.LogError("IENUMERATOR MENTIONED " + __instance);
            try
            {
                //Debug.LogWarning($"[StatusEffect: {__instance?.name} (id: {__instance?.id})] {__originalMethod?.Name} ({__args.Where(a => a != null).Join(Print)})");
            }
            finally { }
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
}
