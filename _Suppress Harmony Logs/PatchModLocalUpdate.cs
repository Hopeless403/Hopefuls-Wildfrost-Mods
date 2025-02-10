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
using ICSharpCode.Decompiler.CSharp.Syntax;

namespace WildfrostHopeMod.HarmonySuppressor;

[HarmonyPatch]
public class PatchModLocalUpdate
{
    // Keys: Mod.GUID
    public static Dictionary<string, DateTime> modLastLoaded = [];
    public static Dictionary<string, (Assembly assembly, string location)> modAssemblyInfo = [];

    /// <summary>
    /// Key: Assembly.FullName, 
    /// Value: Assembly.Location
    /// </summary>
    public static Dictionary<string, string> AssemblyLocations 
        => modAssemblyInfo.ToLookup(x => x.Value.assembly.FullName,
                                    x => x.Value.location)
                          .ToDictionary(x => x.Key,
                                        x => x.First());
    // Explanation:
    // Mods can rarely have the same Assembly but different GUID
    // i.e. the GUID is dynamic, e.g. GUID => DateTime.Now
    // ToLookup combines them into 1 group before doing ToDictionary with their first representative
    // Very possible to not rely on modAssemblyInfo, but we keep synced just in case

    /// <summary>
    /// Fix wrong assembly.location if loaded through bytes
    /// </summary>
    /// <returns>True if assembly was loaded by this code</returns>
    /*[HarmonyPrefix]
    [HarmonyPatch(
        assemblyQualifiedDeclaringType: "System.Reflection.RuntimeAssembly, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
        nameof(Assembly.Location), MethodType.Getter)]*/
    public static bool Location(Assembly __instance, ref string __result)
        => !AssemblyLocations.TryGetValue(__instance.FullName, out __result);

    [HarmonyPostfix]
    [HarmonyPatch(typeof(AssetLoader), nameof(AssetLoader.Awake))]
    static void Awake() => HarmonySuppressorPlugin.harmony.Patch(
        AccessTools.TypeByName("RuntimeAssembly").GetMethod("get_Location"),
        prefix: new(typeof(PatchModLocalUpdate).GetMethod(nameof(Location)))
        );



    /// <summary>
    /// Load assemblies from bytes. 
    /// Wrap everything in a try-catch.
    /// </summary>
    /// <returns>Skips vanilla method</returns>
    [HarmonyPrefix][HarmonyPatch(typeof(Bootstrap), nameof(Bootstrap.LoadModAtPath))]
    public static bool LoadModAtPath(string path)
    {
        string shortPath = path.Split('/').Last().Replace("StreamingAssets", "");
        Debug.LogError("Trying to load mod at " + shortPath);

        try
        {
            Assembly modDependency = null;
            Assembly modAssembly = null;
            string assemblyLocation = "";

            // Get possible dlls in this directory
            IEnumerable<string> dllPaths = from file in new DirectoryInfo(path).GetFiles("*.dll", SearchOption.TopDirectoryOnly)
                                           // Overcomplicated way to load UniverseLib first before Unity Explorer mod
                                           orderby file.Name == "UniverseLib.Mono.dll" ? DateTime.MinValue : file.LastWriteTime
                                           select file.FullName;

            if (!dllPaths.Any())
                return false;

            foreach (string dllPath in dllPaths)
            {
                try
                {
                    //throw new Exception();
                    modDependency = Assembly.Load(File.ReadAllBytes(dllPath));
                }
                catch
                {
                    modDependency = Assembly.LoadFrom(dllPath);
                }

                try
                {
                    foreach (System.Type type in modDependency.GetTypes())
                    {
                        if (type.BaseType == typeof(WildfrostMod))
                        {
                            
                            modAssembly = modDependency;
                            assemblyLocation = dllPath;
                            break;
                        }
                    }
                }
                catch (TypeLoadException ex) { }
            }

            if (modAssembly == null)
            {
                Debug.LogWarning($"Empty mod at {shortPath}");
            }
            else
            {
                WildfrostMod mod = null;
                foreach (System.Type type in modAssembly.GetTypes())
                {
                    if (type.BaseType == typeof(WildfrostMod) && type != typeof(InternalMod))
                    {
                        mod = (WildfrostMod)Activator.CreateInstance(type, path);
                        /*if (HarmonySuppressorPlugin.all && type.Name == "Stabilizer")
                        {
                            mod.HarmonyInstance.UnpatchSelf();
                            HarmonySuppressorPlugin.harmony.UnpatchSelf();
                            HarmonySuppressorPlugin.harmony.PatchAll();
                        }*/

                        modLastLoaded[path] = File.GetLastWriteTime(assemblyLocation);
                        modAssemblyInfo[mod.GUID] = (modAssembly, assemblyLocation);
                        Bootstrap.Mods.Add(mod);

                        Debug.LogError((modAssemblyInfo[mod.GUID].location, modAssemblyInfo[mod.GUID].assembly.Location));
                        break;
                    }
                }
                Debug.LogWarning($"Added instance [{mod?.Title}] from dir [{shortPath}]");
            }
        }
        catch (Exception ex)
        {
            Debug.LogWarning($"FAILED to instantiate mod from dir [{shortPath}]\n{ex}");
        };
        return false;
    }




    /// <summary>
    /// If the mod DLL updated, skip loading this mod. Load the updated one instead.
    /// Otherwise load normally.
    /// </summary>
    /// <param name="__state">Stopwatch</param>
    [HarmonyPatch(typeof(WildfrostMod), nameof(WildfrostMod.ModLoad))]
    public static bool Prefix(WildfrostMod __instance, out System.Diagnostics.Stopwatch __state)
    {
        __state = System.Diagnostics.Stopwatch.StartNew();

        Debug.LogWarning($"TRYING Mod load [{__instance.Title}] from [{modAssemblyInfo[__instance.GUID].location}]");
        //Debug.LogError($"WEEWOOWEEWOOO\n{(modAssemblyInfo[__instance.GUID].location, modAssemblyInfo[__instance.GUID].assembly.Location)}\nWEEWOO");
        var path = __instance.ModDirectory;


        if (modLastLoaded.TryGetValue(path, out DateTime time) && time < File.GetLastWriteTime(modAssemblyInfo[__instance.GUID].location))
        {
            Debug.LogError($"ASSEMBLY OF [{__instance.Title}] WAS CHANGED\nat{modAssemblyInfo[__instance.GUID].location}\nfrom [{time}] to [{File.GetLastWriteTime(modAssemblyInfo[__instance.GUID].location)}]");
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
            return false;
        }
        return true;
    }

    #region Timers
    [HarmonyPatch(typeof(WildfrostMod), nameof(WildfrostMod.ModLoad))]
    public static void Postfix(WildfrostMod __instance, System.Diagnostics.Stopwatch __state)
    {
        if (HarmonySuppressorPlugin.all && __instance.GetType().Name == "Stabilizer")
        {
            __instance.HarmonyInstance.GetPatchedMethods().DoIf(
                m => m.Name == nameof(Assembly.Location),
                m => __instance.HarmonyInstance.Unpatch(m, HarmonyPatchType.All)
            );
            HarmonySuppressorPlugin.harmony.UnpatchSelf();
            HarmonySuppressorPlugin.harmony.PatchAll();
        }
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
        if (__state.Item1.ElapsedMilliseconds == 0) return; // For mods that force unloading when loaded
        Debug.LogError($">> Load [{__state.Item2}] took {__state.Item1.ElapsedMilliseconds} ms");
    }
    #endregion




    [HarmonyPatch(typeof(WildfrostMod), nameof(WildfrostMod.CompareTo))]
    public static void Postfix(ref int __result, WildfrostMod __instance, WildfrostMod other)
    {
        if (__instance == other)
            __result = 0;
        else
        __result = other == null || __instance.ModDirectory.Contains(Application.streamingAssetsPath)
            ? 
            //(modAssemblyInfo.ContainsKey(__instance.GUID) ?
                File.GetLastWriteTime(modAssemblyInfo[other.GUID].location)
                .CompareTo(File.GetLastWriteTime(modAssemblyInfo[__instance.GUID].location))
            //: string.Compare(__instance.GUID, other.GUID, StringComparison.Ordinal)) 
            : 1;
    }



    #region Stop myself from uploading a mod that can possibly break mod loading :p
    [HarmonyPatch(typeof(ModsSceneManager), nameof(ModsSceneManager.Start))]
    public static IEnumerator Postfix(IEnumerator __result, ModsSceneManager __instance)
    {
        yield return __result;
        //CoroutineManager.Start(DontRelease(__instance));
    }
    static IEnumerator DontRelease(ModsSceneManager __instance)
    {
        yield return new WaitForFixedUpdate(); // Wait for Mod Uploader to make changes first
        // After Mod Uploader changed buttons, change it back
        foreach (var modTransform in __instance.Content.transform.GetAllChildren())
        {
            var modHolder = modTransform.GetComponent<ModHolder>();
            Button button = modHolder.PublishButton.GetComponentInChildren<Button>();

            button.onClick = new ButtonClickedEvent();
            button.onClick.AddListener(() => throw new NotSupportedException(
                "This code includes patches to the Bootstrap and ModLoad operations which are not allowed to be released."
                // unless used by someone that knows what they're doing
                ));
        }
    }
    #endregion
}