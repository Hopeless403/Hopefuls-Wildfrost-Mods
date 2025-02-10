using HarmonyLib;
using UnityEngine;
using BepInEx;
using Steamworks;
using System;
using System.IO;
using System.Linq;
using static Config;
using Steamworks.Ugc;
using System.Collections.Generic;
using System.Reflection;
using TMPro;
using UnityEngine.SceneManagement;
using System.Collections;
using HarmonyLib.Tools;
using System.Text;
using UnityEngine.UI;
using static UnityEngine.UI.Button;
using UnityExplorer.UI;
using UnityExplorer;

namespace WildfrostHopeMod.HarmonySuppressor;

[BepInPlugin("hope.wildfrost.harmony", "Harmony Suppressor", "1.1.0")]
public class HarmonySuppressorPlugin : BaseUnityPlugin
{
    public static
        float s = 0;
    void Awake()
    {
        Debug.LogWarning("[Harmony Suppressor] HEWWO!");
        //Harmony.CreateAndPatchAll(GetType().Assembly, "hope.wildfrost.harmony");
        //Events.OnGameStart += () => Application.runInBackground = false;
        Events.OnPreCampaignPopulate += SpecialEventsSystem.PreCampaignPopulate;
        Debug.LogWarning(Resources.FindObjectsOfTypeAll<CampaignNodeTypeCurseItems>().Any());
        Events.OnGameStart += () => Debug.LogWarning(Resources.FindObjectsOfTypeAll<CampaignNodeTypeCurseItems>().Any());
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backslash))
            ExplorerStandalone.CreateInstance();
    }

    [HarmonyPatch(typeof(SteamManager), nameof(SteamManager.Awake))]
    class PatchSteam
    {
        static bool Prefix(SteamManager __instance)
        {
            try
            {
                SteamClient.Init(SteamManager.appId);
                Debug.LogWarning("INIT successfully");
            }
            catch (System.Exception ex)
            {
                Debug.LogError($"Steam failed to initialize! ({ex})");
                Debug.LogWarning("[Harmony Suppressor] Continuing without Steam");
                return false;
            }
            SteamClient.Shutdown();
            return true;
        }
    }

    public class SpecialEventsSystem : MonoBehaviour
    {
        [Serializable]
        public struct Event
        {
            public CampaignNodeType nodeType;

            public UnlockData requiresUnlock;

            public CampaignNodeType[] replaces;

            public int minTier;

            public Vector2Int perTier;

            public Vector2Int perRun;
        }

        [SerializeField]
        public static Event[] events = [
            ];

        public static void PreCampaignPopulate()
        {
            List<List<CampaignNode>> list = CreateListOfNodes();
            foreach (Event @event in events)
            {
                int num = @event.perRun.Random();
                int num2 = 0;
                int[] array2 = new int[list.Count];
                int num5;
                Vector2Int perTier;
                do
                {
                    foreach (List<CampaignNode> item in list.InRandomOrder())
                    {
                        int num3 = @event.perTier.Random();
                        if (num3 > 0)
                        {
                            foreach (CampaignNode item2 in item)
                            {
                                if (item2.tier < @event.minTier)
                                {
                                    break;
                                }

                                int num4 = array2[item2.tier];
                                perTier = @event.perTier;
                                if (num4 >= perTier.y)
                                {
                                    break;
                                }

                                if (@event.replaces.Contains(item2.type))
                                {
                                    Debug.Log($"SpecialEventSystem → Replacing [{item2} ({item2.type.name}) tier {item2.tier}] with ({@event.nodeType.name})");
                                    item2.SetType(@event.nodeType);
                                    array2[item2.tier]++;
                                    num2++;
                                    if (array2[item2.tier] >= num3 || num2 >= num)
                                    {
                                        break;
                                    }
                                }
                            }
                        }

                        if (num2 >= num)
                        {
                            break;
                        }
                    }

                    num5 = num2;
                    perTier = @event.perRun;
                }
                while (num5 < perTier.x);
            }
        }

        public static List<List<CampaignNode>> CreateListOfNodes()
        {
            List<List<CampaignNode>> list = new List<List<CampaignNode>>();
            int a = 0;
            foreach (CampaignNode node in Campaign.instance.nodes)
            {
                if (node.tier >= 0)
                {
                    a = Mathf.Max(a, node.tier + 1);
                    while (list.Count <= node.tier)
                    {
                        list.Add(new List<CampaignNode>());
                    }

                    int index = UnityEngine.Random.Range(0, list[node.tier].Count - 1);
                    list[node.tier].Insert(index, node);
                }
            }

            return list;
        }
    }
}



