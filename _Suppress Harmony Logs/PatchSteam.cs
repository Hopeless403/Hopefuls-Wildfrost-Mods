using HarmonyLib;
using UnityEngine;
using Steamworks;
using System.IO;
using System.Linq;
using static Config;
using FMODUnity;
using System.Collections;
using Deadpan.Enums.Engine.Components.Modding;
using System.Reflection;
using TMPro;

namespace WildfrostHopeMod.HarmonySuppressor;

[HarmonyPatch(typeof(SteamManager), nameof(SteamManager.Awake))]
public class PatchSteam
{
    
    static bool Prefix(SteamManager __instance)
    {
        try
        {
            Resources.FindObjectsOfTypeAll<Bootstrap>().First().ModsSetup();
            SteamClient.Init(SteamManager.appId);
            Debug.LogWarning("INIT successfully");
        }
        catch (System.Exception ex)
        {
            Debug.LogError($"Steam failed to initialize! ({ex})");
            Debug.LogWarning("[Harmony Suppressor] Continuing without Steam");
            Fallback();
            return false;
        }
        SteamClient.Shutdown();
        return true;
    }
    public static void Fallback()
    {
        string workshop = Application.dataPath;
        int i;
        if ((i = workshop.IndexOf("Steam/steamapps/")) == -1) return;
        workshop = workshop.Substring(0, i) + $"Steam/steamapps/workshop/content/{SteamManager.appId}";
        Directory.GetDirectories(workshop).Update(path => {
        try {
            var info = new DirectoryInfo(path).FullName;
            if (Bootstrap.Mods.All(m => new DirectoryInfo(m.ModDirectory).FullName != info))
                Bootstrap.LoadModAtPath(path);
            } catch { }
        });
        var a = data.versionFormat.Split('\n');
        a[0] += " (Offline)";
        data.versionFormat = string.Join("\n", a);
    }
}
[HarmonyPatch(typeof(Bootstrap), nameof(Bootstrap.ModsSetup))]
public class PatchBootstrap2
{

    static IEnumerator Postfix(IEnumerator original, Bootstrap __instance)
    {
        foreach (System.Type allDataType in WildfrostMod.AllDataTypes)
            typeof(AddressableLoader).GetMethod("GetGroup", BindingFlags.Static | BindingFlags.Public).MakeGenericMethod(allDataType).Invoke(__instance,
            [
        (object) allDataType.ToString()
            ]);
        TMP_Text.OnSpriteAssetRequest += (hash, s) =>
        {
            foreach (WildfrostMod mod in Bootstrap.Mods)
            {
                if (s == mod.GUID)
                    return mod.HasLoaded ? mod.SpriteAsset : (TMP_SpriteAsset)null;
            }
            return (TMP_SpriteAsset)null;
        };
        string path = Path.Combine(Application.streamingAssetsPath, "Mods");
        if (!System.IO.Directory.Exists(path))
            System.IO.Directory.CreateDirectory(path);
        foreach (string directory in System.IO.Directory.GetDirectories(path))
            Bootstrap.LoadModAtPath(directory);
        foreach (WildfrostMod lastMod in WildfrostMod.GetLastMods())
            lastMod?.ModLoad();
        yield break;
    }
}
