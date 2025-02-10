using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using UnityEngine;
using BepInEx;
using Steamworks;
using System;
using System.IO;
using static Config;
using Steamworks.Ugc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics.Tracing;
using System.Reflection;

namespace WildfrostHopeMod.AlwaysUpdated;


[BepInPlugin("hope.wildfrost.updater", "Always Updated", "1.1.0")]
public class AlwaysUpdatedPlugin : BaseUnityPlugin
{
    void Awake()
    {
        Debug.LogWarning("[Always Updated] HEWWO!");
        //Harmony.CreateAndPatchAll(GetType().Assembly, "hope.wildfrost.updater");
    }

    //[HarmonyPatch]
    class PatchItems
    {
        static System.Reflection.MethodBase TargetMethod()
        {
            return typeof(Enumerable).GetMethods()
                .First(m => m.Name == "Any" && m.GetParameters().Count() == 1)
                .MakeGenericMethod(typeof(Item));
        }
        static async void Postfix(IEnumerable<Item> source, bool __result)
        {
            Debug.LogWarning("Any!!! " + source.Count() + __result);
            if (!__result) return;
            foreach (Item pageEntry in source)
            {
                string directory = pageEntry.Directory;
                if (directory == null 
                    || pageEntry.IsDownloadPending 
                    || Directory.GetLastWriteTime(pageEntry.Directory).CompareTo(pageEntry.Updated) == -1)
                {
                    await pageEntry.DownloadAsync();
                }
            }
        }
    }

    [HarmonyPatch(typeof(Bootstrap), nameof(Bootstrap.OnEnable))]
    class PatchSteam
    {
        static void Prefix()
        {
            //if (!SteamManager.init) return true;
            Debug.LogError("I'm takin' over!");
            Check();
            //return false;
        }
        static async void Check()
        {
            List<string> outdated = new List<string>();
            int i = 1;
            while (true)
            {
                Query query = Query.All;
                query = query.WhereUserSubscribed();
                ResultPage? pageAsync = await query.GetPageAsync(i);
                Debug.LogWarning(Assembly.GetExecutingAssembly().Location);
                if (pageAsync.HasValue && pageAsync.Value.Entries.Any())
                {
                    foreach (Item entry in pageAsync?.Entries)
                    {
                        Item pageEntry = entry;
                        string directory = pageEntry.Directory;
                        Debug.LogWarning(directory);
                        if (Directory.GetLastWriteTime(pageEntry.Directory).CompareTo(pageEntry.Updated) == -1
                            && directory != Assembly.GetExecutingAssembly().Location
                            )
                        {
                            await pageEntry.DownloadAsync();
                            directory = pageEntry.Directory;
                            outdated.Add(directory);
                        }
                    }
                    ++i;
                }
                else
                    break;
            }
            foreach (string path in outdated)
            {
                Bootstrap.Mods.RemoveWhere(mod => mod.ModDirectory == path);
                Bootstrap.LoadModAtPath(path);
            }
        }
    }
}