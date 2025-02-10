using CampaignReader;
using Deadpan.Enums.Engine.Components.Modding;
using FMODUnity;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace WildfrostHopeMod.CAFix
{
    public class CampaignReaderFix : WildfrostMod
    {
        public static CampaignReaderFix Mod;
        public CampaignReaderFix(string modDirectory) : base(modDirectory)
        {
            Mod = this;
        }
        public override string GUID => "hope.wildfrost.cafix";
        public override string[] Depends => new string[] {  };
        public override string Title => "CAnalyser Fix";
        public override string Description => "";
        public override TMP_SpriteAsset SpriteAsset => base.SpriteAsset;
        public static GameObject behaviour;

        public override void Load()
        {
            base.Load();

            behaviour = new GameObject("FashionModBehaviour");
            GameObject.DontDestroyOnLoad(behaviour);
            behaviour.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset |
                                  HideFlags.HideInInspector | HideFlags.NotEditable;

            var e = behaviour.AddComponent<HopeTemplateModBehaviour>();
        }

        public override void Unload()
        {
            base.Unload();
            GameObject.Destroy(behaviour);
            behaviour = null;
        }

        /*[HarmonyPatch(typeof(CampaignReaderMod.Mapreading), "OnGUI")]
        public class Patch
        {
            static bool Prefix() => false;
            *//*public static void Postfix(CampaignReaderMod.Mapreading __instance)
            {
                if (Campaign.instance == null || __instance.isOn != 1)
                    return;
                //Debug.Log("GUITIME: " + Campaign.instance.preset);
                GUILayout.BeginHorizontal();
                if (GUILayout.Button("Scroll up", GUILayout.Width(150), GUILayout.Height(20)))
                {
                    Debug.LogWarning("scroll up");
                }
                if (GUILayout.Button("Scroll down", GUILayout.Width(150), GUILayout.Height(20)))
                {
                    Debug.LogWarning("scroll down");
                }
                GUILayout.EndHorizontal();
            }*//*
        }*/
    }

    public class HopeTemplateModBehaviour : MonoBehaviour
    {
        public string input;
        public int isOn = 0;
        public CampaignNode to_display = (CampaignNode)null;
        public List<MapNode> MapState = new List<MapNode>();
        public int section = 1;

        public int vOffset = 0;

        private void Update()
        {
            if (!Input.GetKeyDown(KeyCode.Minus) || (UnityEngine.Object)References.Campaign == (UnityEngine.Object)null)
                return;
            if (this.isOn != 0)
                this.isOn = 0;
            else
                this.isOn = 1;
        }
        private void OnGUI()
        {
            if (this.isOn == 0)
                GUILayout.Label("Analyze with -");
            else if ((UnityEngine.Object)References.Campaign == (UnityEngine.Object)null)
            {
                this.isOn = 0;
            }
            else
            {
                int seed = Campaign.Data.Seed;
                if (GUILayout.Button("Close Analysis"))
                {
                    this.isOn = 0;
                    this.to_display = (CampaignNode)null;
                }
                GUILayout.TextArea("Campaign seed: " + seed.ToString());
                List<CampaignNode> campaignNodeList1 = new List<CampaignNode>();
                List<CampaignNode> campaignNodeList2 = new List<CampaignNode>();
                List<CampaignNode> campaignNodeList3 = new List<CampaignNode>();
                List<CampaignNode> campaignNodeList4 = new List<CampaignNode>();
                List<CampaignNode> campaignNodeList5 = new List<CampaignNode>();
                List<CampaignNode> campaignNodeList6 = new List<CampaignNode>();
                List<CampaignNode> campaignNodeList7 = new List<CampaignNode>();
                List<CampaignNode> campaignNodeList8 = new List<CampaignNode>();
                List<CampaignNode> campaignNodeList9 = new List<CampaignNode>();
                int currentIndex = 0;
                int finalIndex = 0;
                bool flag = false;
                string str = "top";
                int num3 = -100;

                // clamp so vOffset stays in valid range when changing # of paths
                // upper limit of vOffset is number of paths - 1 (index starting from 0) - 1 (we see two paths at once)
                int maxPaths = References.Campaign.nodes.Max(node => node.connections.Count);
                vOffset = Mathf.Clamp(vOffset, 0, maxPaths - 2);


                // main idea is to adjust the list so that we only look at 2 paths at a time
                List<CampaignNode> ignoreNodes = new List<CampaignNode>();
                foreach (CampaignNode node in References.Campaign.nodes)
                {
                    // remove "extra" paths
                    if (node.connections.Count > vOffset + 1)
                    {
                        // the node on the actual map
                        MapNode mapNode = References.Map.FindNode(node);
                        List<MapPath> mapPaths = References.Map.FindPaths(mapNode);
                        for (int i = 0; i < node.connections.Count; i++)
                        {
                            if (i != vOffset && i != vOffset + 1)
                            {
                                var path = mapPaths[i].nodes.Select(node => node.mapNode.campaignNode).ToList();
                                ignoreNodes.AddRange(path.GetRange(1, path.Count - 2));
                                // don't ignore the first and last;
                                // those are the start and end of the branching path
                            }
                        }
                    }
                }
                List<CampaignNode> adjustedNodes = References.Campaign.nodes.Except(ignoreNodes).ToList();

                // make sure to change these to use the adjusted list (References.Campaign.nodes => adjustedNodes)
                // fyi this is the same as `finalIndex = adjustedNodes.FindIndex(node => node.type.ToString().Contains("FinalFinal"));`
                for (int index = 0; index < adjustedNodes.Count; ++index)
                {
                    if (adjustedNodes[index].type.ToString().Contains("FinalFinal"))
                        finalIndex = index;
                }
                foreach (CampaignNode node in adjustedNodes)
                {
                    if (node.name != "Snowdwell" && (node.type.ToString() != "CampaignNodeDetail1 (CampaignNodeType)" || node.type.ToString() != "CampaignNodeDetail2 (CampaignNodeType)" || node.type.ToString() != "CampaignNodeDetail3 (CampaignNodeType)") && currentIndex < finalIndex)
                    {
                        if (flag)
                        {
                            switch (str)
                            {
                                case "top":
                                    str = "bottom";
                                    if (node.areaIndex == 0)
                                    {
                                        campaignNodeList1.Add(node);
                                        campaignNodeList2.Add(new CampaignNode());
                                    }
                                    else if (node.areaIndex == 1)
                                    {
                                        campaignNodeList4.Add(node);
                                        campaignNodeList5.Add(new CampaignNode());
                                    }
                                    else if (node.areaIndex == 2)
                                    {
                                        campaignNodeList7.Add(node);
                                        campaignNodeList8.Add(new CampaignNode());
                                    }
                                    if (node.connections.Count > 0 && num3 == node.connections[0].otherId)
                                    {
                                        flag = false;
                                        break;
                                    }
                                    break;
                                case "bottom":
                                    str = "top";
                                    if (node.connections.Count > 0)
                                        num3 = node.connections[0].otherId;
                                    if (node.areaIndex == 0)
                                        campaignNodeList3.Add(node);
                                    else if (node.areaIndex == 1)
                                        campaignNodeList6.Add(node);
                                    else if (node.areaIndex == 2)
                                        campaignNodeList9.Add(node);
                                    break;
                            }
                        }
                        else
                        {
                            if (node.connections.Count > 1)
                            {
                                flag = true;
                                str = "bottom";
                            }
                            else
                                flag = false;
                            if (node.areaIndex == 0)
                            {
                                campaignNodeList1.Add(new CampaignNode());
                                campaignNodeList2.Add(node);
                                campaignNodeList3.Add(new CampaignNode());
                            }
                            else if (node.areaIndex == 1)
                            {
                                campaignNodeList4.Add(new CampaignNode());
                                campaignNodeList5.Add(node);
                                campaignNodeList6.Add(new CampaignNode());
                            }
                            else if (node.areaIndex == 2)
                            {
                                campaignNodeList7.Add(new CampaignNode());
                                campaignNodeList8.Add(node);
                                campaignNodeList9.Add(new CampaignNode());
                            }
                        }
                        ++currentIndex;
                    }
                    else if (currentIndex == finalIndex)
                    {
                        ++currentIndex;
                        if (node.areaIndex == 2)
                        {
                            campaignNodeList7.Add(new CampaignNode());
                            campaignNodeList8.Add(node);
                            campaignNodeList9.Add(new CampaignNode());
                        }
                    }
                }
                int width = 90;
                int height = 40;
                if (this.isOn == 1)
                {
                    if (this.section == 1)
                    {
                        GUILayout.BeginHorizontal();
                        foreach (CampaignNode campaignNode in campaignNodeList1)
                        {
                            switch (campaignNode.name)
                            {
                                case "Frozen Travellers":
                                    if (GUILayout.Button("Frozen\nCompanion", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        break;
                                    }
                                    break;
                                case "Blingsnail Cave":
                                    if (GUILayout.Button("Blingsnail", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        break;
                                    }
                                    break;
                                case "Item":
                                    if (GUILayout.Button("Chest", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        break;
                                    }
                                    break;
                                case "Charm":
                                    if (GUILayout.Button("Charm\nMachine", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        break;
                                    }
                                    break;
                                case "The Woolly Snail":
                                    if (GUILayout.Button("Woolly Snail\nShop", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        break;
                                    }
                                    break;
                                case "Muncher":
                                    if (GUILayout.Button("Muncher", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        break;
                                    }
                                    break;
                                case "CurseItem":
                                    if (GUILayout.Button("Gnome\nMerchant", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        break;
                                    }
                                    break;
                                case "Gnome Duper":
                                    if (GUILayout.Button("Shade\nSculptor", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        break;
                                    }
                                    break;
                                case "Charm Shop":
                                    if (GUILayout.Button("Charm\nMerchant", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        break;
                                    }
                                    break;
                                case "trade":
                                    if (GUILayout.Button("Pokefrost\nTrade", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        break;
                                    }
                                    break;
                                case "Injured Companion":
                                    if (GUILayout.Button("Injured\nCompanion", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        break;
                                    }
                                    break;
                                default:
                                    GUILayout.Button("___________", GUILayout.Width((float)width), GUILayout.Height((float)height));
                                    break;
                            }
                        }
                        GUILayout.EndHorizontal();
                        GUILayout.BeginHorizontal();
                        foreach (CampaignNode campaignNode in campaignNodeList2)
                        {
                            string name = campaignNode.name;
                            int num4;
                            switch (name)
                            {
                                case "Frozen Travellers":
                                    if (GUILayout.Button("Frozen\nCompanion", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        goto label_160;
                                    }
                                    else
                                        goto label_160;
                                case "Blingsnail Cave":
                                    if (GUILayout.Button("Blingsnail", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        goto label_160;
                                    }
                                    else
                                        goto label_160;
                                case "Item":
                                    if (GUILayout.Button("Chest", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        goto label_160;
                                    }
                                    else
                                        goto label_160;
                                case "Charm":
                                    if (GUILayout.Button("Charm\nMachine", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        goto label_160;
                                    }
                                    else
                                        goto label_160;
                                case "The Woolly Snail":
                                    if (GUILayout.Button("Woolly Snail\nShop", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        goto label_160;
                                    }
                                    else
                                        goto label_160;
                                case "Muncher":
                                    if (GUILayout.Button("Muncher", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        goto label_160;
                                    }
                                    else
                                        goto label_160;
                                case "CurseItem":
                                    if (GUILayout.Button("Gnome\nMerchant", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        goto label_160;
                                    }
                                    else
                                        goto label_160;
                                case "Gnome Duper":
                                    if (GUILayout.Button("Shade\nSculptor", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        goto label_160;
                                    }
                                    else
                                        goto label_160;
                                case "Charm Shop":
                                    if (GUILayout.Button("Charm\nMerchant", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        goto label_160;
                                    }
                                    else
                                        goto label_160;
                                case "trade":
                                    if (GUILayout.Button("Pokefrost\nTrade", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        goto label_160;
                                    }
                                    else
                                        goto label_160;
                                case "Injured Companion":
                                    if (GUILayout.Button("Injured\nCompanion", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        goto label_160;
                                    }
                                    else
                                        goto label_160;
                                case "Journal Page":
                                    if (GUILayout.Button("Journal\nPage", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        goto label_160;
                                    }
                                    else
                                        goto label_160;
                                case "Ascension Chamber":
                                    if (GUILayout.Button("Ascension\nChamber", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        goto label_160;
                                    }
                                    else
                                        goto label_160;
                                case "Battle":
                                    num4 = 1;
                                    break;
                                default:
                                    num4 = name == "Boss!" ? 1 : 0;
                                    break;
                            }
                            if (num4 != 0)
                            {
                                foreach (KeyValuePair<string, object> keyValuePair in campaignNode.data)
                                {
                                    if (keyValuePair.Key == "battle")
                                    {
                                        if (keyValuePair.Value.ToString() == "Snowbos")
                                        {
                                            if (GUILayout.Button("Snowbo Squad", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                                this.to_display = campaignNode;
                                        }
                                        else if (keyValuePair.Value.ToString() == "Pengoons")
                                        {
                                            if (GUILayout.Button("The\nPengoons", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                                this.to_display = campaignNode;
                                        }
                                        else if (keyValuePair.Value.ToString() == "Yeti")
                                        {
                                            if (GUILayout.Button("The Snowland\nBears", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                                this.to_display = campaignNode;
                                        }
                                        else if (keyValuePair.Value.ToString() == "Frosters")
                                        {
                                            if (GUILayout.Button("The Frost\nShades", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                                this.to_display = campaignNode;
                                        }
                                        else if (keyValuePair.Value.ToString() == "Shroomers")
                                        {
                                            if (GUILayout.Button("The Noxious\nShrooms", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                                this.to_display = campaignNode;
                                        }
                                        else if (keyValuePair.Value.ToString() == "Berries")
                                        {
                                            if (GUILayout.Button("The\nGloberries", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                                this.to_display = campaignNode;
                                        }
                                        else if (keyValuePair.Value.ToString() == "Frenzy Boss")
                                        {
                                            if (GUILayout.Button("Infernoko", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                                this.to_display = campaignNode;
                                        }
                                        else if (keyValuePair.Value.ToString() == "Split Boss")
                                        {
                                            if (GUILayout.Button("Bamboozle", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                                this.to_display = campaignNode;
                                        }
                                        else if (keyValuePair.Value.ToString() == "BabyBerries")
                                        {
                                            if (GUILayout.Button("The Bog\nBerries", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                                this.to_display = campaignNode;
                                        }
                                        else if (keyValuePair.Value.ToString() == "Bombers")
                                        {
                                            if (GUILayout.Button("The Snow\nLumps", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                                this.to_display = campaignNode;
                                        }
                                        else if (GUILayout.Button("Modded\nFight", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                            this.to_display = campaignNode;
                                    }
                                }
                            }
                            else
                            {
                                switch (name)
                                {
                                    case "Final Boss!":
                                        if (GUILayout.Button("Eye of the storm", GUILayout.Width((float)(2 * width)), GUILayout.Height((float)height)))
                                        {
                                            this.to_display = campaignNode;
                                            break;
                                        }
                                        break;
                                    case "Final Final Boss!":
                                        if (GUILayout.Button("Quite a Spoiler", GUILayout.Width((float)(2 * width)), GUILayout.Height((float)height)))
                                        {
                                            this.to_display = campaignNode;
                                            break;
                                        }
                                        break;
                                    default:
                                        GUILayout.Button("___________", GUILayout.Width((float)width), GUILayout.Height((float)height));
                                        break;
                                }
                            }
                        label_160:;
                        }
                        GUILayout.EndHorizontal();
                        GUILayout.BeginHorizontal();
                        foreach (CampaignNode campaignNode in campaignNodeList3)
                        {
                            switch (campaignNode.name)
                            {
                                case "Frozen Travellers":
                                    if (GUILayout.Button("Frozen\nCompanion", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        break;
                                    }
                                    break;
                                case "Blingsnail Cave":
                                    if (GUILayout.Button("Blingsnail", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        break;
                                    }
                                    break;
                                case "Item":
                                    if (GUILayout.Button("Chest", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        break;
                                    }
                                    break;
                                case "Charm":
                                    if (GUILayout.Button("Charm\nMachine", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        break;
                                    }
                                    break;
                                case "The Woolly Snail":
                                    if (GUILayout.Button("Woolly Snail\nShop", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        break;
                                    }
                                    break;
                                case "Muncher":
                                    if (GUILayout.Button("Muncher", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        break;
                                    }
                                    break;
                                case "CurseItem":
                                    if (GUILayout.Button("Gnome\nMerchant", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        break;
                                    }
                                    break;
                                case "Gnome Duper":
                                    if (GUILayout.Button("Shade\nSculptor", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        break;
                                    }
                                    break;
                                case "Charm Shop":
                                    if (GUILayout.Button("Charm\nMerchant", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        break;
                                    }
                                    break;
                                case "trade":
                                    if (GUILayout.Button("Pokefrost\nTrade", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        break;
                                    }
                                    break;
                                case "Injured Companion":
                                    if (GUILayout.Button("Injured\nCompanion", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        break;
                                    }
                                    break;
                                default:
                                    GUILayout.Button("___________", GUILayout.Width((float)width), GUILayout.Height((float)height));
                                    break;
                            }
                        }
                        GUILayout.EndHorizontal();
                    }
                    else if (this.section == 2)
                    {
                        GUILayout.BeginHorizontal();
                        foreach (CampaignNode campaignNode in campaignNodeList4)
                        {
                            switch (campaignNode.name)
                            {
                                case "Frozen Travellers":
                                    if (GUILayout.Button("Frozen\nCompanion", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        break;
                                    }
                                    break;
                                case "Blingsnail Cave":
                                    if (GUILayout.Button("Blingsnail", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        break;
                                    }
                                    break;
                                case "Item":
                                    if (GUILayout.Button("Chest", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        break;
                                    }
                                    break;
                                case "Charm":
                                    if (GUILayout.Button("Charm\nMachine", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        break;
                                    }
                                    break;
                                case "The Woolly Snail":
                                    if (GUILayout.Button("Woolly Snail\nShop", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        break;
                                    }
                                    break;
                                case "Muncher":
                                    if (GUILayout.Button("Muncher", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        break;
                                    }
                                    break;
                                case "CurseItem":
                                    if (GUILayout.Button("Gnome\nMerchant", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        break;
                                    }
                                    break;
                                case "Gnome Duper":
                                    if (GUILayout.Button("Shade\nSculptor", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        break;
                                    }
                                    break;
                                case "Charm Shop":
                                    if (GUILayout.Button("Charm\nMerchant", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        break;
                                    }
                                    break;
                                case "trade":
                                    if (GUILayout.Button("Pokefrost\nTrade", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        break;
                                    }
                                    break;
                                case "Injured Companion":
                                    if (GUILayout.Button("Injured\nCompanion", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        break;
                                    }
                                    break;
                                default:
                                    GUILayout.Button("___________", GUILayout.Width((float)width), GUILayout.Height((float)height));
                                    break;
                            }
                        }
                        GUILayout.EndHorizontal();
                        GUILayout.BeginHorizontal();
                        foreach (CampaignNode campaignNode in campaignNodeList5)
                        {
                            string name = campaignNode.name;
                            int num5;
                            switch (name)
                            {
                                case "Frozen Travellers":
                                    if (GUILayout.Button("Frozen\nCompanion", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        goto label_295;
                                    }
                                    else
                                        goto label_295;
                                case "Blingsnail Cave":
                                    if (GUILayout.Button("Blingsnail", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        goto label_295;
                                    }
                                    else
                                        goto label_295;
                                case "Item":
                                    if (GUILayout.Button("Chest", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        goto label_295;
                                    }
                                    else
                                        goto label_295;
                                case "Charm":
                                    if (GUILayout.Button("Charm\nMachine", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        goto label_295;
                                    }
                                    else
                                        goto label_295;
                                case "The Woolly Snail":
                                    if (GUILayout.Button("Woolly Snail\nShop", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        goto label_295;
                                    }
                                    else
                                        goto label_295;
                                case "Muncher":
                                    if (GUILayout.Button("Muncher", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        goto label_295;
                                    }
                                    else
                                        goto label_295;
                                case "CurseItem":
                                    if (GUILayout.Button("Gnome\nMerchant", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        goto label_295;
                                    }
                                    else
                                        goto label_295;
                                case "Gnome Duper":
                                    if (GUILayout.Button("Shade\nSculptor", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        goto label_295;
                                    }
                                    else
                                        goto label_295;
                                case "Charm Shop":
                                    if (GUILayout.Button("Charm\nMerchant", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        goto label_295;
                                    }
                                    else
                                        goto label_295;
                                case "trade":
                                    if (GUILayout.Button("Pokefrost\nTrade", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        goto label_295;
                                    }
                                    else
                                        goto label_295;
                                case "Injured Companion":
                                    if (GUILayout.Button("Injured\nCompanion", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        goto label_295;
                                    }
                                    else
                                        goto label_295;
                                case "Journal Page":
                                    if (GUILayout.Button("Journal\nPage", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        goto label_295;
                                    }
                                    else
                                        goto label_295;
                                case "Ascension Chamber":
                                    if (GUILayout.Button("Ascension\nChamber", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        goto label_295;
                                    }
                                    else
                                        goto label_295;
                                case "Battle":
                                    num5 = 1;
                                    break;
                                default:
                                    num5 = name == "Boss!" ? 1 : 0;
                                    break;
                            }
                            if (num5 != 0)
                            {
                                foreach (KeyValuePair<string, object> keyValuePair in campaignNode.data)
                                {
                                    if (keyValuePair.Key == "battle")
                                    {
                                        if (keyValuePair.Value.ToString() == "Husks")
                                        {
                                            if (GUILayout.Button("The Shelled\nHusks", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                                this.to_display = campaignNode;
                                        }
                                        else if (keyValuePair.Value.ToString() == "Goats")
                                        {
                                            if (GUILayout.Button("The Demonhorn\nGoats", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                                this.to_display = campaignNode;
                                        }
                                        else if (keyValuePair.Value.ToString() == "Spice Monkeys")
                                        {
                                            if (GUILayout.Button("The Spice\nMokos", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                                this.to_display = campaignNode;
                                        }
                                        else if (keyValuePair.Value.ToString() == "Spikers")
                                        {
                                            if (GUILayout.Button("The Toothy\nShades", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                                this.to_display = campaignNode;
                                        }
                                        else if (keyValuePair.Value.ToString() == "Drek")
                                        {
                                            if (GUILayout.Button("The Wooly\nDrek", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                                this.to_display = campaignNode;
                                        }
                                        else if (keyValuePair.Value.ToString() == "Inkers")
                                        {
                                            if (GUILayout.Button("The Ink\nSacs", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                                this.to_display = campaignNode;
                                        }
                                        else if (keyValuePair.Value.ToString() == "Toadstool Boss")
                                        {
                                            if (GUILayout.Button("Truffle", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                                this.to_display = campaignNode;
                                        }
                                        else if (keyValuePair.Value.ToString() == "Clunker Boss")
                                        {
                                            if (GUILayout.Button("Krunker", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                                this.to_display = campaignNode;
                                        }
                                        else if (GUILayout.Button("Modded\nFight", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                            this.to_display = campaignNode;
                                    }
                                }
                            }
                            else
                            {
                                switch (name)
                                {
                                    case "Final Boss!":
                                        if (GUILayout.Button("Eye of the storm", GUILayout.Width((float)(2 * width)), GUILayout.Height((float)height)))
                                        {
                                            this.to_display = campaignNode;
                                            break;
                                        }
                                        break;
                                    case "Final Final Boss!":
                                        if (GUILayout.Button("Quite a Spoiler", GUILayout.Width((float)(2 * width)), GUILayout.Height((float)height)))
                                        {
                                            this.to_display = campaignNode;
                                            break;
                                        }
                                        break;
                                    default:
                                        GUILayout.Button("___________", GUILayout.Width((float)width), GUILayout.Height((float)height));
                                        break;
                                }
                            }
                        label_295:;
                        }
                        GUILayout.EndHorizontal();
                        GUILayout.BeginHorizontal();
                        foreach (CampaignNode campaignNode in campaignNodeList6)
                        {
                            switch (campaignNode.name)
                            {
                                case "Frozen Travellers":
                                    if (GUILayout.Button("Frozen\nCompanion", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        break;
                                    }
                                    break;
                                case "Blingsnail Cave":
                                    if (GUILayout.Button("Blingsnail", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        break;
                                    }
                                    break;
                                case "Item":
                                    if (GUILayout.Button("Chest", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        break;
                                    }
                                    break;
                                case "Charm":
                                    if (GUILayout.Button("Charm\nMachine", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        break;
                                    }
                                    break;
                                case "The Woolly Snail":
                                    if (GUILayout.Button("Woolly Snail\nShop", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        break;
                                    }
                                    break;
                                case "Muncher":
                                    if (GUILayout.Button("Muncher", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        break;
                                    }
                                    break;
                                case "CurseItem":
                                    if (GUILayout.Button("Gnome\nMerchant", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        break;
                                    }
                                    break;
                                case "Gnome Duper":
                                    if (GUILayout.Button("Shade\nSculptor", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        break;
                                    }
                                    break;
                                case "Charm Shop":
                                    if (GUILayout.Button("Charm\nMerchant", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        break;
                                    }
                                    break;
                                case "trade":
                                    if (GUILayout.Button("Pokefrost\nTrade", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        break;
                                    }
                                    break;
                                case "Injured Companion":
                                    if (GUILayout.Button("Injured\nCompanion", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    {
                                        this.to_display = campaignNode;
                                        break;
                                    }
                                    break;
                                default:
                                    GUILayout.Button("___________", GUILayout.Width((float)width), GUILayout.Height((float)height));
                                    break;
                            }
                        }
                        GUILayout.EndHorizontal();
                    }
                    else if (this.section == 3)
                    {
                        CreateRowRewards(campaignNodeList7, width, height);
                        CreateRowMain(campaignNodeList8, width, height);
                        CreateRowRewards(campaignNodeList9, width, height);
                    }

                    GUILayout.BeginHorizontal();
                    if (GUILayout.Button("Previous Area", GUILayout.Width(150f), GUILayout.Height(20f)) && this.section > 1)
                        --this.section;
                    if (GUILayout.Button("Next Area", GUILayout.Width(150f), GUILayout.Height(20f)) && this.section < 3)
                        ++this.section;
                    GUILayout.EndHorizontal();

                    GUILayout.BeginHorizontal();
                    if (GUILayout.Button("Scroll down", GUILayout.Width(150f), GUILayout.Height(20f)) && vOffset < maxPaths-2)
                        vOffset++;
                    if (GUILayout.Button("Scroll up", GUILayout.Width(150f), GUILayout.Height(20f)) && vOffset > 0)
                        vOffset--;
                    GUILayout.EndHorizontal();
                }
            }
        }
        public void CreateRowMain(List<CampaignNode> campaignNodeList,  float width, float height)
        {
            GUILayout.BeginHorizontal();
            foreach (CampaignNode campaignNode in campaignNodeList)
            {
                string name = campaignNode.name;
                int num6;
                switch (name)
                {
                    case "Frozen Travellers":
                        if (GUILayout.Button("Frozen\nCompanion", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                        {
                            this.to_display = campaignNode;
                            goto label_415;
                        }
                        else
                            goto label_415;
                    case "Blingsnail Cave":
                        if (GUILayout.Button("Blingsnail", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                        {
                            this.to_display = campaignNode;
                            goto label_415;
                        }
                        else
                            goto label_415;
                    case "Item":
                        if (GUILayout.Button("Chest", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                        {
                            this.to_display = campaignNode;
                            goto label_415;
                        }
                        else
                            goto label_415;
                    case "Charm":
                        if (GUILayout.Button("Charm\nMachine", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                        {
                            this.to_display = campaignNode;
                            goto label_415;
                        }
                        else
                            goto label_415;
                    case "The Woolly Snail":
                        if (GUILayout.Button("Woolly Snail\nShop", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                        {
                            this.to_display = campaignNode;
                            goto label_415;
                        }
                        else
                            goto label_415;
                    case "Muncher":
                        if (GUILayout.Button("Muncher", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                        {
                            this.to_display = campaignNode;
                            goto label_415;
                        }
                        else
                            goto label_415;
                    case "CurseItem":
                        if (GUILayout.Button("Gnome\nMerchant", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                        {
                            this.to_display = campaignNode;
                            goto label_415;
                        }
                        else
                            goto label_415;
                    case "Gnome Duper":
                        if (GUILayout.Button("Shade\nSculptor", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                        {
                            this.to_display = campaignNode;
                            goto label_415;
                        }
                        else
                            goto label_415;
                    case "Charm Shop":
                        if (GUILayout.Button("Charm\nMerchant", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                        {
                            this.to_display = campaignNode;
                            goto label_415;
                        }
                        else
                            goto label_415;
                    case "trade":
                        if (GUILayout.Button("Pokefrost\nTrade", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                        {
                            this.to_display = campaignNode;
                            goto label_415;
                        }
                        else
                            goto label_415;
                    case "Injured Companion":
                        if (GUILayout.Button("Injured\nCompanion", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                        {
                            this.to_display = campaignNode;
                            goto label_415;
                        }
                        else
                            goto label_415;
                    case "Journal Page":
                        if (GUILayout.Button("Journal\nPage", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                        {
                            this.to_display = campaignNode;
                            goto label_415;
                        }
                        else
                            goto label_415;
                    case "Ascension Chamber":
                        if (GUILayout.Button("Ascension\nChamber", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                        {
                            this.to_display = campaignNode;
                            goto label_415;
                        }
                        else
                            goto label_415;
                    case "Battle":
                        num6 = 1;
                        break;
                    default:
                        num6 = name == "Boss!" ? 1 : 0;
                        break;
                }
                if (num6 != 0)
                {
                    foreach (KeyValuePair<string, object> keyValuePair in campaignNode.data)
                    {
                        if (keyValuePair.Key == "battle")
                        {
                            if (keyValuePair.Value.ToString() == "Wildlings")
                            {
                                if (GUILayout.Button("The Wild\nHogs", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    this.to_display = campaignNode;
                            }
                            else if (keyValuePair.Value.ToString() == "Blockers")
                            {
                                if (GUILayout.Button("The Ice\nKrabs", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    this.to_display = campaignNode;
                            }
                            else if (keyValuePair.Value.ToString() == "Mimiks")
                            {
                                if (GUILayout.Button("The Gunk\nBugs", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                    this.to_display = campaignNode;
                            }
                            else if (GUILayout.Button("Modded\nFight", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                                this.to_display = campaignNode;
                        }
                    }
                }
                else
                {
                    switch (name)
                    {
                        case "Final Boss!":
                            if (GUILayout.Button("Eye of the storm", GUILayout.Width((float)(2 * width)), GUILayout.Height((float)height)))
                            {
                                this.to_display = campaignNode;
                                break;
                            }
                            break;
                        case "Final Final Boss!":
                            if (GUILayout.Button("Quite a Spoiler", GUILayout.Width((float)(2 * width)), GUILayout.Height((float)height)))
                            {
                                this.to_display = campaignNode;
                                break;
                            }
                            break;
                        default:
                            GUILayout.Button("___________", GUILayout.Width((float)width), GUILayout.Height((float)height));
                            break;
                    }
                }
            label_415:;
            }
            GUILayout.EndHorizontal();
        }

        public void CreateRowRewards(List<CampaignNode> campaignNodeList, float width = 90, float height = 40)
        {
            GUILayout.BeginHorizontal();
            foreach (CampaignNode campaignNode in campaignNodeList)
            {
                switch (campaignNode.name)
                {
                    case "Frozen Travellers":
                        if (GUILayout.Button("Frozen\nCompanion", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                        {
                            this.to_display = campaignNode;
                            break;
                        }
                        break;
                    case "Blingsnail Cave":
                        if (GUILayout.Button("Blingsnail", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                        {
                            this.to_display = campaignNode;
                            break;
                        }
                        break;
                    case "Item":
                        if (GUILayout.Button("Chest", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                        {
                            this.to_display = campaignNode;
                            break;
                        }
                        break;
                    case "Charm":
                        if (GUILayout.Button("Charm\nMachine", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                        {
                            this.to_display = campaignNode;
                            break;
                        }
                        break;
                    case "The Woolly Snail":
                        if (GUILayout.Button("Woolly Snail\nShop", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                        {
                            this.to_display = campaignNode;
                            break;
                        }
                        break;
                    case "Muncher":
                        if (GUILayout.Button("Muncher", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                        {
                            this.to_display = campaignNode;
                            break;
                        }
                        break;
                    case "CurseItem":
                        if (GUILayout.Button("Gnome\nMerchant", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                        {
                            this.to_display = campaignNode;
                            break;
                        }
                        break;
                    case "Gnome Duper":
                        if (GUILayout.Button("Shade\nSculptor", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                        {
                            this.to_display = campaignNode;
                            break;
                        }
                        break;
                    case "Charm Shop":
                        if (GUILayout.Button("Charm\nMerchant", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                        {
                            this.to_display = campaignNode;
                            break;
                        }
                        break;
                    case "trade":
                        if (GUILayout.Button("Pokefrost\nTrade", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                        {
                            this.to_display = campaignNode;
                            break;
                        }
                        break;
                    case "Injured Companion":
                        if (GUILayout.Button("Injured\nCompanion", GUILayout.Width((float)width), GUILayout.Height((float)height)))
                        {
                            this.to_display = campaignNode;
                            break;
                        }
                        break;
                    default:
                        GUILayout.Button("___________", GUILayout.Width((float)width), GUILayout.Height((float)height));
                        break;
                }
            }
            GUILayout.EndHorizontal();
        }
        internal void Start()
        {
        }

        
    }
}