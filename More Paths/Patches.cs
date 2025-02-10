using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static CampaignGenerator;

namespace WildfrostHopeMod.Paths;
static class Ext
{
    public static string Repeat(this string str, int count, string delimiter = "") =>
        count <= 0 ? "" :
        new StringBuilder((str.Length + delimiter.Length) * count)
            .Insert(0, str)
            .Insert(str.Length, delimiter + str, Mathf.Max(0, count - 1))
        .ToString();
}

[HarmonyPatch(typeof(CampaignGenerator), nameof(TryGenerate))]
public class PatchReplaceTryGenerate
{
    #region For others to patch
    public static CampaignGenerator generator;
    public static IReadOnlyDictionary<string, CampaignNodeType> nodeDict;
    public static string[] FixPresetLines(string[] _presetLines, int paths = 2)
    {
        int _lines = _presetLines.Length;
        if (_lines - 2 < paths)
        {
            var pathLines = _presetLines.RangeSubset(0, _lines - 2);
            _presetLines = pathLines.AddItem(pathLines.Last().Repeat(paths-(_lines-2), "\n")).ToArray()
                .AddRangeToArray(_presetLines.Subset(_lines-2, _lines-1));
        }
        else if (_lines - 2 > paths)
        {
            var pathLines = _presetLines.RangeSubset(0, paths);
            _presetLines = pathLines.AddRangeToArray(_presetLines.Subset(_lines - 2, _lines - 1));
        }
        int targetLength = _presetLines[0].Length;
        for (int i=1; i<_presetLines.Length; i++)
        {
            _presetLines[i] += ' '* Mathf.Max(targetLength - _presetLines[i].Length, 0);
            if (_presetLines[i].Length > targetLength)
                _presetLines[i] = _presetLines[i].Substring(0, targetLength);
        }
        return _presetLines;
    }
    public static List<Node> AddNametagNodes(List<Node> nodes, IReadOnlyDictionary<string, CampaignNodeType> nodeDict, CampaignGenerator generator, float xOffset, List<int> battleTierIndices, int positionIndex, int areaIndex)
    {
        if (areaIndex != 0)
        {
            CampaignNodeType type = nodeDict["area" + areaIndex.ToString()];
            float y = generator.nodeSpacing.y * 0.25f.WithRandomSign();
            Node node = generator.CreateNode(xOffset - generator.nodeSpacing.x * 0.5f, y, type, battleTierIndices[positionIndex], positionIndex, areaIndex);
            nodes.Add(node);
            node.interactable = false;
        };
        return nodes;
    }
    public static List<Node> AddAreaDetails(List<Node> nodes, IReadOnlyDictionary<string, CampaignNodeType> nodeDict, CampaignGenerator generator, float xOffset, int areaIndex,
        int numberPerNode = 2)
    {
        CampaignNodeType type1 = nodeDict[areaIndex.ToString()];
        for (int index3 = 0; index3 < numberPerNode; ++index3)
        {
            Node node = generator.CreateNode(xOffset, generator.nodeSpacing.y * UnityEngine.Random.Range(-0.5f, 0.5f), type1, -1, 0, areaIndex);
            nodes.Add(node);
            node.interactable = false;
        }
        return nodes;
    }
    public static void ConnectNodes(List<Node> nodesAtPreviousPosition, List<Node> nodesAtThisPosition)
    {

        if (nodesAtPreviousPosition.Count > 0)
        {
            /// if This < Previous, then it'll connect the Previouses to Thises
            /// 0 => 0
            /// 1 => 1
            /// 2 => 0

            /// Note: This only works normally if the min is EXACTLY 1
            int num2 = Mathf.Max(nodesAtThisPosition.Count, nodesAtPreviousPosition.Count);
            for (int index4 = 0; index4 < num2; ++index4)
            {
                Node other = nodesAtThisPosition[index4 % nodesAtThisPosition.Count];
                nodesAtPreviousPosition[index4 % nodesAtPreviousPosition.Count].Connect(other);
            }
        }
    }
    public static void ShuffleNodes(List<Node> nodes, int paths=2)
    {
        bool flag = true;
        int num = 10000;
        while (flag && num > 0)
        {
            flag = false;
            foreach (Node node in nodes)
            {
                foreach (Node node2 in nodes)
                {
                    if (node != node2)
                    {
                        Vector2 vector = new Vector2(node.x - node2.x, node.y - node2.y);
                        if (vector.magnitude < node.r + node2.r)
                        {
                            Vector2 vector2 = vector.normalized * 0.01f;
                            node.x += vector2.x;
                            node.y += vector2.y;
                            node2.x -= vector2.x;
                            node2.y -= vector2.y;
                            flag = true;
                        }
                    }
                }

                foreach (Node.Connection connection in node.connections)
                {
                    Vector2 vector3 = new Vector2(node.x - connection.node.x, node.y - connection.node.y);
                    float num2 = vector3.magnitude - (node.r + connection.node.r);
                    if (num2 > 0f)
                    {
                        Vector2 vector4 = vector3.normalized * 0.001f * num2 / Mathf.Max(1, paths - 1);
                        node.x -= vector4.x;
                        node.y -= vector4.y;
                        connection.node.x += vector4.x;
                        connection.node.y += vector4.y;
                    }
                }
            }

            num--;
        }
    }

    public static bool CheckError(List<Node> nodes, int paths = 2)
    {
        bool error = false;
        /// Instead of looping over all nodes twice, once each to check if node1/node2 is interactable,
        /// Filter only the interactable nodes and loop over this instead
        var interactableNodes = nodes.Where(node => node.interactable);
        foreach (Node node1 in interactableNodes)
        {
            foreach (Node.Connection connection in node1.connections)
            {
                Line line = new Line(node1.x, node1.y, connection.node.x, connection.node.y);
                foreach (Node node2 in interactableNodes)
                {
                    if (node2 != node1
                        && node2 != connection.node
                        && (node2.x > node1.x && node2.x < connection.node.x || node2.x > connection.node.x && node2.x < node1.x)
                        && (node2.y > node1.y && node2.y < connection.node.y || node2.y > connection.node.y && node2.y < node1.y)
                        && LineIntersectsCircle(line, node2.x, node2.y, node2.r))
                    {
                        Debug.Log($"Error: [{connection}] INTERSECTS [{node2}]");
                        connection.color = Color.yellow;
                        node2.color = Color.red;
                        error = true;
                        break;
                    }
                }
                if (error)
                    break;
            }
            if (error)
                break;
        }
        return error;
    }
    #endregion

    static async Task<bool> TryGenerate(CampaignGenerator __instance,
        Campaign campaign,
        int attempt,
        List<Node> nodes,
        IReadOnlyDictionary<string, CampaignNodeType> nodeDict,
        int paths = 2)
    {
        Debug.Log($"Attempt #{attempt + 1}");
        if (paths < 1) paths = 2;
        StopWatch.Start();

        generator = __instance;
        PatchReplaceTryGenerate.nodeDict = nodeDict;

        /*//////////////////////////////////////////////
        TextAsset _preset = __instance.ChoosePreset();
        string[] _presetLines = GetPresetLines(_preset);
        _presetLines = FixPresetLines(_presetLines, paths);

        //////////////////////////////////////////////
        _preset = new TextAsset(string.Join("\n", _presetLines));*/

        campaign.preset = __instance.ChoosePreset();
        string[] presetLines = GetPresetLines(campaign.preset);
        Events.InvokeCampaignLoadPreset(ref presetLines); // doesn't change the number of lines
        // add the proper number of lines
        presetLines = FixPresetLines(presetLines, paths);
        campaign.preset = new TextAsset(string.Join("\n", presetLines));

        //////////////////////////////////////////////
        int _lastIndex = presetLines.Length - 1;
        Debug.LogWarning($"There are {_lastIndex - 1} paths:\n" + campaign.preset);
        //////////////////////////////////////////////
        ///
        int campaignLength = GetCampaignLength(presetLines);
        campaign.battleTiers = presetLines[_lastIndex-1];
        List<int> battleTierIndices = new List<int>();
        foreach (char battleTier in campaign.battleTiers)
        {
            int battleTierIndex = int.Parse(battleTier.ToString());
            battleTierIndices.Add(battleTierIndex);
        }
        string areaNum = presetLines[_lastIndex];

        float xOffset = 0f;
        List<Node> nodesAtPreviousPosition = new List<Node>();
        for (int positionIndex = 0; positionIndex < campaignLength; ++positionIndex)
        {
            string areaIndexStr = areaNum[positionIndex].ToString();
            int.TryParse(areaIndexStr, out int areaIndex);
            List<string> nodeLetters = new List<string>();
            ////////////////////////////////////////////// assuming all but the last 2 lines are dedicated to nodes
            for (int lineIndex = 0; lineIndex <= _lastIndex-2; ++lineIndex)
            {
                string nodeLetter = presetLines[lineIndex][positionIndex].ToString();
                if (!nodeLetter.IsNullOrWhitespace())
                    nodeLetters.Add(nodeLetter);
            }
            // Create "Now entering" nametag
            nodes = AddNametagNodes(nodes, nodeDict, __instance, xOffset, battleTierIndices, positionIndex, areaIndex);

            float yOffset = (float)(-(nodeLetters.Count - 1) * __instance.nodeSpacing.y * 0.5f);// (1/paths));
            List<Node> nodesAtThisPosition = new List<Node>();
            foreach (string nodeLetter in nodeLetters)
            {
                CampaignNodeType type = nodeDict[nodeLetter];
                Node node = __instance.CreateNode(xOffset, yOffset, type, battleTierIndices[positionIndex], positionIndex, areaIndex, 0.5f);// 0.75f);
                nodes.Add(node);
                nodesAtThisPosition.Add(node);
                yOffset += __instance.nodeSpacing.y;
            }
            // Create details. These don't actually get created, but are transformed into details elsewhere
            nodes = AddAreaDetails(nodes, nodeDict, __instance, xOffset, areaIndex, 0);

            xOffset += __instance.nodeSpacing.x;
            ConnectNodes(nodesAtPreviousPosition, nodesAtThisPosition);
            nodesAtPreviousPosition = nodesAtThisPosition;
        }
        Events.InvokeCampaignNodesCreated(ref nodes, __instance.nodeSpacing);
        /////////////////////////////////////////////////////////////////////
        await Task.Run(() => ShuffleNodes(nodes, paths));
        bool error = false;
        Debug.LogWarning(PathsMod.Mod.ignoreErrors);
        error = PathsMod.Mod.ignoreErrors ? false : CheckError(nodes, paths);
        
        Debug.Log($"Generation took {StopWatch.Stop()}ms");
        return error;
    }

    static bool Prefix(CampaignGenerator __instance, ref Task<bool> __result,
        Campaign campaign,
        int attempt,
        List<Node> nodes,
        IReadOnlyDictionary<string, CampaignNodeType> nodeDict)
    {
        int paths = PathsMod.Mod.pathNumber;
        //__instance.nodeSpacing = new Vector2(3.2f, 1);
        //__instance.restartOnError = true; // default: true

        Debug.LogWarning($"[More Paths] Patching for {paths} paths...");

        __result = TryGenerate(__instance, campaign, attempt, nodes, nodeDict, paths);
        return false;
    }
}