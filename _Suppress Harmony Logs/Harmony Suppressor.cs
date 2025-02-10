using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using UnityEngine;
using BepInEx;
using System;
using System.IO;
using System.Linq;
using Steamworks.Ugc;
using System.Reflection;
using TMPro;
using UnityEngine.SceneManagement;
using System.Collections;
using HarmonyLib.Tools;
using System.Text;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using ICSharpCode.Decompiler.DebugInfo;

namespace WildfrostHopeMod.HarmonySuppressor;
[HarmonyPatch]
[BepInPlugin("hope.wildfrost.harmony", "Harmony Suppressor", "1.1.0")]
public class HarmonySuppressorPlugin : BaseUnityPlugin
{
    [HarmonyPatch(typeof(ModHolder), nameof(ModHolder.UpdateInfo))]
    public static void Postfix(ModHolder __instance)
    {
        __instance.Title.text += "<size=0.2><voffset=0.03> "
            + Directory.GetLastWriteTime(__instance.Mod.GetType().Assembly.Location);
        __instance.Title.overflowMode = TextOverflowModes.Overflow;
    }

    public static
        float s = 0;

    internal static bool all;
    public static Harmony harmony;
    public void Awake()
    {
        static void LoadMoadAtPath(string path)
        {
            if (!Bootstrap.IsModDirectory(path, out var dlls))
            {
                return;
            }

            Assembly assembly = null;
            string[] array = dlls;
            for (int i = 0; i < array.Length; i++)
            {
                Type[] types = [];
                Assembly assembly2 = Assembly.LoadFrom(array[i]);
                try
                {
                    types = assembly2.GetTypes();
                    for (int j = 0; j < types.Length; j++)
                    {
                        if (types[j].BaseType == typeof(WildfrostMod))
                        {
                            Debug.Log("Found valid mod type");
                            assembly = assembly2;
                            break;
                        }
                    }
                }
                catch (ReflectionTypeLoadException e)
                {
                    Debug.LogError("Checking loaded types");
                    types = e.Types;
                    foreach (var type in types)
                        Debug.LogWarning(type);
                }
                foreach (var type in types)
                    Debug.LogWarning(type);
            }
        }
        /*try
        {
            Bootstrap.LoadModAtPath("C:\\Program Files (x86)\\Steam\\steamapps\\workshop\\content\\1811990\\3415324919");
        }
        catch (Exception e) when (e.GetType() == typeof(ReflectionTypeLoadException))
        {
            Debug.LogException(e);
        }*/
        //Bootstrap.LoadModAtPath("C:\\Program Files (x86)\\Steam\\steamapps\\workshop\\content\\1811990\\3355962208");
        //Bootstrap.LoadModAtPath("C:\\Program Files (x86)\\Steam\\steamapps\\workshop\\content\\1811990\\3415324919");
        //LoadMoadAtPath("C:\\Program Files (x86)\\Steam\\steamapps\\workshop\\content\\1811990\\3415324919");
        //Bootstrap.Mods.Do(mod => Debug.LogWarning(mod.GetType().Assembly.GetTypes().Join(delimiter:"\n")));
        //nameof(Reflect)

        //typeof(Console).Assembly.GetMetadataFileOrNull();
        //ICSharpCode.Decompiler

        _ = typeof(PortablePdbWriter)
        ?? typeof(Mono.Cecil.Cil.PortablePdbWriter);
        _ = typeof(MetaprogressionSystem);
        
        string[] cases = ["catch ", "if ", "else if ", "else", "foreach ", "for ", "while ", "switch "];
        var decompiler = new ICSharpCode.Decompiler.CSharp.CSharpDecompiler(
            fileName: "Wildfrost_Data/Managed/Assembly-CSharp-Publicized.dll",
            settings: new ICSharpCode.Decompiler.DecompilerSettings(ICSharpCode.Decompiler.CSharp.LanguageVersion.CSharp7_3)
            );

        //decompiler.AddPartialTypeDefinition()
        

        foreach (var type in typeof(Console).Assembly.GetTypes().Where(t => t == typeof(MetaprogressionSystem) || t == typeof(AspectRatio)))
        {
            Debug.Log(type.FullName);
            if (type.FullName.Contains('<')) break;
            string contents = decompiler.DecompileTypeAsString(new(type.FullName));
            List<string> lines = contents.Split(["\r\n"], StringSplitOptions.None).ToList();

            for (int i = 0; i < lines.Count; i++)
            {
                //Debug.LogWarning(i+6);
                // Runs code if line i is an if statement
                // Should end on the ending brace
                bool Handler()
                {
                    string line = lines[i].TrimStart('\t');
                    int lineNum = i+6;
                    if (cases.Any(line.StartsWith))
                    {
                        //lines[i] = (i+6) + "_" + lines[i].Substring((int)Math.Floor(((i+6).ToString().Length+1f)/4));
                        i++;
                        int Counter() => lines[i].Count(c => c == '{') - lines[i].Count(c => c == '}');
                        int braceDiff = Counter();
                        bool count = true;
                        if (braceDiff == 0 && line.StartsWith("while"))
                        {
                            i--;
                            count = false;
                        }
                        while (braceDiff != 0)
                        {
                            //Debug.LogWarning($"[{lineNum}] {i + 6}, {braceDiff}, {count}");
                            i++;
                            // Deal with inner if statements
                            if (Handler()) count = false;
                            // index is on the last inner end brace
                            if (count) braceDiff += Counter();
                            else count = true;
                            if (braceDiff != 0 && line.StartsWith("switch"))
                                lines[i] = '\t' + lines[i];
                        }
                        // This is at the ending brace
                        //lines[i] = lineNum + "r" + lines[i]/*;//*/.Substring((int)Math.Floor((lineNum.ToString().Length + 1f) / 4));
                        string tag2 = lines[i+1].TrimStart('\t');
                        //Debug.LogError($"[{lineNum}] {i + 6}");
                        if (tag2 == "}" ||
                            line.StartsWith("catch") && tag2 == "finally" ||
                            line.StartsWith("if") && tag2.StartsWith("else if") ||
                            line.StartsWith("if") && tag2 == "else" ||
                            line.StartsWith("else if") && tag2 == "else" ||
                            //line == "do" && tag2.StartsWith("while") || 
                            !count
                            )
                        {
                            return true;
                        }
                        lines.Insert(1+i, "");
                        return true;
                        //lines.Insert(i, new string('\t', lines[i].Count(c => c == '\t')));
                    }
                    return false;
                }
                Handler();
            }
            contents = lines.Join(delimiter: "\r\n");
            contents = $"""
            #region Assembly {type.Assembly.FullName}
            // {type.Assembly.Location}
            // Decompiled with ICSharpCode.Decompiler 8.1.1.7464
            #endregion

            {contents}
            """;

            string path = Path.Combine(Application.persistentDataPath, "Decompiled", $"{type.FullName.Replace('.', '/')}.cs");
            Directory.CreateDirectory(Path.GetDirectoryName(path).Replace(Path.GetFileName(path), ""));
            File.WriteAllText(
                path: path,
                contents: contents
                );
        }
        

        //var tree = decompiler.DecompileWholeModuleAsString();

        //new   new StreamWriter(Path.Combine(ErrorHandlerSystem.path, "/../Assembly.pdb"), true)

        /*using (System.IO.Stream stream = File.Create(Path.Combine(Application.persistentDataPath, "Assembly.pdb")))
        {
            var debugger = new ICSharpCode.Decompiler.DebugInfo.PortablePdbWriter();
            ICSharpCode.Decompiler.DebugInfo.PortablePdbWriter.WritePdb(
                file: new ICSharpCode.Decompiler.Metadata.PEFile("Wildfrost.exe"),
                decompiler: decompiler,
                settings: new ICSharpCode.Decompiler.DecompilerSettings(ICSharpCode.Decompiler.CSharp.LanguageVersion.Latest),
                targetStream: stream);
            Debug.LogWarning(stream.Length);
        }*/

        _ = typeof(Bootstrap);
        Debug.LogWarning("[Harmony Suppressor] HEWWO!");
        harmony = Harmony.CreateAndPatchAll(typeof(PatchHarmony), "hope.wildfrost.harmony");

        all = !false;
        if (all)
        {
            harmony.PatchAll();
        }
        else
        {
            harmony.PatchAll(typeof(PatchSteam));
            harmony.PatchAll(typeof(HarmonySuppressorPlugin));
        }

        Debug.LogWarning(harmony.GetPatchedMethods().Select(m => m.Name).ToArray().DefaultIfEmpty("None").Join());
        Events.OnModLoaded += mod =>
        {
            if (mod.GUID != "kopie.wildfrost.unityexplorer")
                return;

            mod.Unload();
            mod.UpdateSave();
        };

        

        Events.OnGameStart += () => Application.runInBackground = false;
        //Events.OnGameStart += PatchSteam.Fallback;

        Application.logMessageReceived += PatchErrorLog.CheckError;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backslash))
            Bootstrap.Mods.FirstOrDefault(mod => mod.GUID == "kopie.wildfrost.unityexplorer")?.Load();
    }
    [HarmonyPatch(typeof(WildfrostMod.DebugLoggerTextWriter), nameof(WildfrostMod.DebugLoggerTextWriter.WriteLine))]
    public class PatchHarmony
    {
        static bool Prefix() { Postfix(); return false; }
        static void Postfix() => HarmonyLib.Tools.Logger.ChannelFilter = HarmonyLib.Tools.Logger.LogChannel.Warn | HarmonyLib.Tools.Logger.LogChannel.Error;
    }

    [HarmonyPatch(typeof(ModsSceneManager), nameof(ModsSceneManager.Start))]
    public class PatchModSizes
    {
        public readonly string comment = "this has absolutely nothing to do with the mod kekw";
        public static IEnumerator Postfix(IEnumerator __result, ModsSceneManager __instance)
        {
            Debug.LogWarning(UnityEngine.StackTraceUtility.ExtractStackTrace());
            while (__result.MoveNext())
                yield return __result.Current;
            foreach (var transform in __instance.Content.transform.GetAllChildren())
                transform.localScale = Vector3.one;
        }
    }

}

public class PatchErrorLog
{
    internal static int tries = 0;
    public static IEnumerator CheckErrorRoutine()
    {
        yield return null;
        if (ErrorHandlerSystem.errorCount <= 0)
            yield break;

        if (tries > 0)
            yield break;

        ++tries;
        var handler = GameObject.FindObjectOfType<ErrorHandlerSystem>();
        if (!handler)
            yield break;

        if (handler.errorDisplay.activeSelf)
        {
            Debug.LogWarning("[Harmony Suppressor] FIXING");
            string[] lines = handler.errorText.text.Split('\n');
            for (int i = 0; i < lines.Length; i++)
            {
                int index = lines[i].IndexOf(") (at <");
                if (index >= 0)
                    lines[i] = lines[i].Substring(0, index + 1);
            }
            handler.errorText.text = lines.Join(delimiter: "\n");
        }
        tries = 0;
    }
    public static void CheckError(string log, string stacktrace, LogType type)
    {
        if (type != LogType.Exception)
            return;
        CoroutineManager.Start(CheckErrorRoutine());
    }
}

//[HarmonyPatch(typeof(Bootstrap), nameof(Bootstrap.Update))]
class UpdateActioner { static void Postfix() => Debug.LogWarning(Resources.FindObjectsOfTypeAll<GameUpdateDisplayer>().Any()); }

//[HarmonyPatch(typeof(Bootstrap), nameof(Bootstrap.ModsSetup))]
class PatchBootstrap : MonoBehaviour
{
    static bool Prefix(Bootstrap __instance)
    {
        Debug.LogWarning("STARTING BOOT");
        StopWatch.Start();
        var start = StopWatch.startTime;
        foreach (System.Type allDataType in WildfrostMod.AllDataTypes)
        {
            StopWatch.Start();
            typeof(AddressableLoader).GetMethod("GetGroup", BindingFlags.Static | BindingFlags.Public).MakeGenericMethod(allDataType).Invoke(__instance, new object[1]
            {
         allDataType.ToString()
            });
            Debug.LogWarning($"Group [{allDataType.Name}] took " + StopWatch.Seconds);
        }
        StopWatch.Stop();
        Debug.LogError("Group load took " + (StopWatch.stopTime - start));
        TMP_Text.OnSpriteAssetRequest += (Func<int, string, TMP_SpriteAsset>)((hash, s) =>
        {
            foreach (WildfrostMod mod in Bootstrap.Mods)
            {
                if (s == mod.GUID)
                    return mod.HasLoaded ? mod.SpriteAsset : (TMP_SpriteAsset)null;
            }
            return (TMP_SpriteAsset)null;
        });
        string path = Path.Combine(Application.streamingAssetsPath, "Mods");
        if (!System.IO.Directory.Exists(path))
            System.IO.Directory.CreateDirectory(path);
        foreach (string directory in System.IO.Directory.GetDirectories(path))
            Bootstrap.LoadModAtPath(directory);
        foreach (WildfrostMod lastMod in WildfrostMod.GetLastMods())
            lastMod?.ModLoad();
        return false;
    }
}

[HarmonyPatch(typeof(BuildingDisplay), nameof(BuildingDisplay.Create))]
class PatchBuildingDisplay : MonoBehaviour
{
    static void Prefix(BuildingDisplay __instance, GameObject prefab, Building building)
    {
        Debug.LogWarning("STARTING CREATE");
        Debug.LogWarning((prefab, building));
    }
}
[HarmonyPatch(typeof(Building), nameof(Building.CreateDisplay))]
class PatchBuilding : MonoBehaviour
{
    static void Prefix(Building __instance, GameObject prefab)
    {
        Debug.LogWarning("STARTING CREATEDISPLAY");
        Debug.LogWarning((prefab, __instance.gameObject, prefab == __instance.gameObject));
        Debug.LogWarning((__instance.onSelect.GetPersistentTarget(0), __instance.gameObject, __instance.onSelect.GetPersistentTarget(0) == __instance.gameObject));
        Debug.LogWarning((prefab, __instance.onSelect.GetPersistentTarget(0), prefab == __instance.onSelect.GetPersistentTarget(0)));
    }
}

