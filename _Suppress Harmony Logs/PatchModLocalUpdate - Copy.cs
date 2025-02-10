using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using UnityEngine;
using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using System.Collections;
using UnityEngine.UI;
using static UnityEngine.UI.Button;
using Dead;

namespace WildfrostHopeMod.HarmonySuppressor;

[HarmonyPatch]
public class PatchModLocalUpdate
{
    /*[HarmonyPatch(
        typeof(MetaprogressionSystem),
        nameof(MetaprogressionSystem.GetUnlockedPets))]
    public static void Postfix(ref string[] __result) => 
        __result = __result.AddRangeToArray(
            AddressableLoader.GetGroup<CardData>("CardData")
            .RandomItems(PettyRandom.Range(30, 40)).Select(c => c.name).ToArray()
            );*/


    public static Dictionary<string, DateTime> lastLoaded = new Dictionary<string, DateTime>();
    public static Dictionary<string, (Assembly assembly, string location)> assemblyInfo = [];
    public static Dictionary<string, string> assemblyPair 
        => assemblyInfo.ToLookup(x => x.Value.assembly.FullName, 
                                 x => x.Value.location)
                       .ToDictionary(x => x.Key,
                                     x => x.First());



    [HarmonyPatch(
        assemblyQualifiedDeclaringType: "System.Reflection.RuntimeAssembly, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
        nameof(Assembly.Location), MethodType.Getter)]
    public static bool Prefix(Assembly __instance, ref string __result) => !assemblyPair.TryGetValue(__instance.FullName, out __result);

    [HarmonyPatch(
        assemblyQualifiedDeclaringType: "System.Reflection.RuntimeAssembly, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
        nameof(Assembly.Location), MethodType.Getter)]
    public static void Postfix(Assembly __instance, string __result) => Debug.LogError("POSTFIX: GOT THE RESULT \n" + __result);


    [HarmonyPrefix][HarmonyPatch(typeof(Bootstrap), nameof(Bootstrap.LoadModAtPath))]
    public static bool LoadModAtPath(string path)
    {
        string shortPath = path.Split('/').Last().Replace("StreamingAssets", "");
        Debug.LogError("Trying to load mod at " + shortPath);
        try
        {
            Assembly assembly1 = (Assembly)null;
            string assemblyLocation = "";
            var dlls = from file in new DirectoryInfo(path).GetFiles("*.dll", SearchOption.TopDirectoryOnly)
                       orderby file.Name == "UniverseLib.Mono.dll" ? DateTime.MinValue : file.LastWriteTime
                       select file.FullName;
            if (!dlls.Any())
                return false;
            foreach (string assemblyFile in dlls)
            {
                Assembly modAssembly = null;
                try
                {
                    modAssembly = Assembly.Load(File.ReadAllBytes(assemblyFile));
                }
                catch
                {
                    modAssembly = Assembly.LoadFrom(assemblyFile);
                }

                try
                {
                    foreach (System.Type type in modAssembly.GetTypes())
                    {
                        if (type.BaseType == typeof(WildfrostMod))
                        {
                            assembly1 = modAssembly;
                            assemblyLocation = assemblyFile;
                            break;
                        }
                    }
                }
                catch (TypeLoadException ex)
                {
                }
            }
            if (assembly1 == null)
            {
                Debug.LogWarning($"Empty mod at {shortPath}");
            }
            else
            {
                WildfrostMod instance = null;
                foreach (System.Type type in assembly1.GetTypes())
                {
                    if (type.BaseType == typeof(WildfrostMod) && type != typeof(InternalMod))
                    {
                        instance = Activator.CreateInstance(type, path) as WildfrostMod;
                        assemblyInfo[instance.GUID] = (assembly1, assemblyLocation);
                        Bootstrap.Mods.Add(instance);
                        lastLoaded[path] = File.GetLastWriteTime(path);
                        break;
                    }
                }
                Debug.LogWarning($"Added instance [{instance.Title}] from dir [{shortPath}]");
            }
        }
        catch (Exception ex)
        {
            Debug.LogWarning($"FAILED to instantiate mod from dir [{shortPath}]\n{ex}");
        };
        return false;
    }

    public static System.Diagnostics.Stopwatch globalTime;
    [HarmonyPatch(typeof(WildfrostMod), nameof(WildfrostMod.ModLoad))]
    public static bool Prefix(ref WildfrostMod __instance, out System.Diagnostics.Stopwatch __state)
    {
        globalTime = System.Diagnostics.Stopwatch.StartNew();
        Debug.LogWarning(">>>> Global time reset");
        __state = System.Diagnostics.Stopwatch.StartNew();
        Debug.LogWarning($"TRYING Mod load [{__instance.Title}] from [{Path.GetFileName(__instance.GetType().Assembly.Location)}]");
        var path = __instance.ModDirectory;
        if (lastLoaded.TryGetValue(path, out DateTime time) && time < File.GetLastWriteTime(assemblyInfo[__instance.GUID].location))
        {
            Debug.LogError($"ASSEMBLY OF [{__instance.Title}] WAS CHANGED");
            Bootstrap.Mods.Remove(__instance);
            Bootstrap.LoadModAtPath(path);
            var newMod = Bootstrap.Mods.FirstOrDefault(mod => mod.ModDirectory == path);
            if (newMod != null)
            {
                newMod.ModLoad();
                var holder = Resources.FindObjectsOfTypeAll<ModHolder>().FirstOrDefault(holder => holder.Mod.ModDirectory == path);
                if (holder)
                {
                    holder.Mod = newMod;
                    holder.UpdateInfo();
                }
            }
            __instance = null;
            return false;
        }
        return true;
    }
    [HarmonyPatch(typeof(WildfrostMod), nameof(WildfrostMod.ModLoad))]
    public static void Postfix(WildfrostMod __instance, System.Diagnostics.Stopwatch __state)
    {
        globalTime.Stop();
        __state.Stop();
        if (__instance != null)
            Debug.LogError($"Mod load [{__instance.Title}] took {__state.ElapsedMilliseconds} ms");
    }

    [HarmonyPatch(typeof(WildfrostMod), nameof(WildfrostMod.Load))]
    public static void Prefix(WildfrostMod __instance, out (System.Diagnostics.Stopwatch, string) __state)
        => __state = (System.Diagnostics.Stopwatch.StartNew(), __instance.Title);
    [HarmonyPatch(typeof(WildfrostMod), nameof(WildfrostMod.Load))]
    public static void Postfix(WildfrostMod __instance, (System.Diagnostics.Stopwatch, string) __state)
    {
        __state.Item1.Stop();
        if (__state.Item1.ElapsedMilliseconds == 0) return;
        Debug.LogError($">> Load [{__state.Item2}] took {__state.Item1.ElapsedMilliseconds} ms");
    }

    /*[HarmonyPatch(typeof(Extensions), nameof(Extensions.PrefixGUID))]
    private static class FixClassesGetter
    {
        private static void Prefix(WildfrostMod mod, string name, out int __state)
        {
            Debug.LogWarning($">> [{mod.Title}] Getting {name}");
            __state = ((int)globalTime.ElapsedMilliseconds);
        }
        private static void Postfix(WildfrostMod mod, string name, int __state)
        {
            //Debug.LogWarning($">> [{mod.Title}] Getting {name}");
            x.Add($"\"{name}\"");
            y.Add(((int)globalTime.ElapsedMilliseconds) - __state);
            Debug.LogWarning($">>>> GLOBAL TIME ELAPSED: {globalTime.ElapsedMilliseconds}ms");
            if (((int)globalTime.ElapsedMilliseconds) - __state > 5)
                Debug.LogError($"[{mod}] {name} TOOK TOO LONG: {((int)globalTime.ElapsedMilliseconds) - __state}");
        }
    }*/





    [HarmonyPatch(typeof(ModsSceneManager), nameof(ModsSceneManager.Start))]
    public static IEnumerator Postfix(IEnumerator __result, ModsSceneManager __instance)
    {
        yield return __result;
        //CoroutineManager.Start(DontRelease(__instance));
    }
    static IEnumerator DontRelease(ModsSceneManager __instance)
    {
        yield return new WaitForFixedUpdate();
        foreach (var modTransform in __instance.Content.transform.GetAllChildren())
        {
            var modHolder = modTransform.GetComponent<ModHolder>();
            Button button = modHolder.PublishButton.GetComponentInChildren<Button>();

            button.onClick = new ButtonClickedEvent();
            button.onClick.AddListener(() => throw new NotSupportedException(
                "This code includes patches to the Bootstrap and ModLoad operations which are not allowed to be released."
                ));
        }
    }
}
