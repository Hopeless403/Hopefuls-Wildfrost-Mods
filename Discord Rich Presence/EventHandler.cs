using Deadpan.Enums.Engine.Components.Modding;
using DiscordRPC;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Text;
using UnityEngine.Localization.Components;

namespace WildfrostHopeMod.Discord_Rich_Presence
{
    public static class EventHandler
    {
        public enum State
        {
            UNKNOWN,
            // Active scenes (Notifies SceneChanged)
            MainMenu,
            Town,
            CharacterSelect,
            MapNew,
            Battle,
            Event,

            // Temporary scenes (Notifies SceneLoaded)
            BossReward,
            BattleWin,
            CampaignEnd,
        }

        public static State currentState;
        public static void SceneChanged(Scene scene)
        {
            State pre = currentState;
            currentState = scene.name switch
            {
                nameof(State.MainMenu) => State.MainMenu,
                nameof(State.Town) => State.Town,
                nameof(State.CharacterSelect) => State.CharacterSelect,
                nameof(State.MapNew) => State.MapNew,
                nameof(State.Battle) => State.Battle,
                nameof(State.Event) => State.Event,
                _ => State.UNKNOWN,
            };
            if (pre != currentState)
                Debug.LogError($"============= Scene: {scene.name} =============");

            RefreshStatus();
        }
        public static void SceneLoaded(Scene scene)
        {
            State pre = currentState;
            currentState = scene.name switch
            {
                //nameof(State.BossReward) => State.BossReward,
                //nameof(State.BattleWin) => State.BattleWin,
                nameof(State.CampaignEnd) => State.CampaignEnd,
                _ => currentState
            };
            if (pre != currentState)
                Debug.LogError($"============= Scene: {scene.name} =============");
            else return;

            RefreshStatus();
        }

        public static void BattlePreTurnStart(int turnCount)
        {
            Debug.LogError($"============= Battle Turn: {turnCount} =============");
            RefreshStatus();
        }

        internal static void RefreshStatus()
        {


            if (Campaign.instance)
            {
                DateTime startTime = default;
                if (StatsSystem.instance)
                    startTime = DateTime.Now.Subtract(new TimeSpan(0, 0, seconds: ((int)StatsSystem.Get().time)));

                string tribeName = default;
                string tribeTitle = default;
                if (Campaign.instance && References.PlayerData?.classData)
                {
                    WildfrostMod tribeMod = References.PlayerData.classData.ModAdded;

                    tribeName = References.PlayerData.classData.name;
                    var titles = new Dictionary<string, string>
                    {
                        ["Tutorial"] = "tribe1_name",
                        ["Basic"] = "tribe1_name",
                        ["Magic"] = "tribe2_name",
                        ["Clunk"] = "tribe3_name",
                        ["artemys.wildfrost.frostknights.Rhodes"] = "RhodesTribeTitle"
                    };

                    if (titles.TryGetValue(tribeName, out string key))
                    {
                        tribeTitle = Extensions.GetLocalizedString("UI Text", key).GetLocalizedString();
                    }
                    else
                    {
                        foreach (var k in new List<string> { tribeName, tribeName.Replace($"{tribeMod.GUID}.", ""), $"{tribeMod.GUID}.TribeTitle", $"{tribeMod.GUID}..TribeTitle" })
                        {
                            //Debug.LogWarning(Extensions.GetLocalizedString("UI Text", k));
                            tribeTitle = Extensions.GetLocalizedString("UI Text", k).GetLocalizedString();
                            if (!tribeTitle.IsNullOrEmpty() || tribeMod == null)
                                break;
                        }
                    }
                    if (tribeTitle.IsNullOrEmpty())
                        tribeTitle = tribeMod?.Title;
                    else if (tribeMod != null)
                        tribeTitle += " - " + tribeMod.Title;

                    //Debug.LogError("GOT TITLE: " + tribeTitle);
                    //Debug.LogError((tribeMod, tribeMod?.Title));
                }


                string leaderName = default;
                string leaderTitle = default;
                if (Campaign.instance && (bool)References.PlayerData?.inventory && References.LeaderData)
                {
                    leaderName = References.LeaderData.name;
                    leaderTitle = References.LeaderData.title;
                }


                RichPresence presence = Utility.StatusBuilder(
                    state: GetTextFromState(currentState),
                    details: GetDetails(leaderName, leaderTitle, tribeTitle),
                    timestamp: startTime != default ? new Timestamps { Start = startTime } : null
                    );

                if (presence == null) return;

                if (tribeName != default)
                {
                    presence.Assets.LargeImageKey = $"tribe_{tribeName.GetAssetName()}";
                    presence.Assets.LargeImageText = tribeTitle;
                }
                else
                {
                    presence.Assets.LargeImageKey = $"tribe_unknown{Dead.Random.Choose(1,2)}";
                }

                string battleName = "";
                CampaignNode node = null;
                if (Battle.instance && (battleName = StatsSystem.GetBattleName()) != null)
                {
                    BattleData battleData = AddressableLoader.Get<BattleData>(nameof(BattleData), battleName);
                    string battleTitle = "";
                    if (battleData?.nameRef != null && !battleData.nameRef.IsEmpty)
                        battleTitle = battleData?.nameRef?.GetLocalizedString();

                    presence.Assets.SmallImageKey = $"battle_{battleName.GetAssetName()}";
                    presence.Assets.SmallImageText = battleTitle;
                }
                else if (EventManager.instance && (node = Campaign.FindCharacterNode(References.Player))?.type != null)
                {
                    string nodeName = node.type.name;
                    string nodeTitle = "";
                    if (node.type.mapNodePrefab?.label?.textFitter && node.type.mapNodePrefab.label.textFitter.TryGetComponent<LocalizeStringEvent>(out var stringEvent))
                    {
                        if (stringEvent.StringReference != null && !stringEvent.StringReference.IsEmpty)
                            nodeTitle = stringEvent.StringReference.GetLocalizedString();
                    }

                    Debug.LogError("GOT KEY: " + $"map_{nodeName.GetAssetName()}");
                    presence.Assets.SmallImageKey = $"map_{nodeName.GetAssetName()}";
                    presence.Assets.SmallImageText = nodeTitle;
                }

                WildfrostRichPresence.client?.SetPresence( presence );
            }

            else // Not in campaign
            {
                Utility.SetStatus(
                    state: GetTextFromState(currentState),
                    details: null
                    );
            }
        }

        public static string GetDetails(string leaderName = null, string leaderTitle = null, string tribeTitle = null)
        {
            if (Campaign.instance && Campaign.Data?.GameMode.name == "GameModeDaily")
            {
                return "Playing the Daily Voyage";
            }

            StringBuilder builder = new StringBuilder();
            if (!leaderTitle.IsNullOrEmpty())
            {
                builder.Append("Playing {0}".Format(leaderTitle));
                if (!tribeTitle.IsNullOrEmpty())
                    builder.Append(" ({0})".Format(tribeTitle));
            }
            else if(!tribeTitle.IsNullOrEmpty())
            {
                builder.Append("Playing {0}".Format(tribeTitle));
            }
            return builder.ToString();
        }

        internal static string GetTextFromState(State state)
        {
            string text = $"In {state}";
            switch (state)
            {
                /*case State.Town:
                    return text = "Talking to the townsfolk";*/

                case State.Battle:
                    if (Battle.instance/* && Battle.instance.minibosses.Count > 0*/)
                    {
                        /*string bossText = Battle.instance.minibosses.Where(boss => boss.IsAliveAndExists() && boss.owner == Battle.instance.enemy)
                                                                    .Select(boss => boss.data.title)
                                                                    .Distinct()
                                                                    .Join();*/
                        
                        string battleName = Battle.instance ? StatsSystem.GetBattleName() : default;
                        BattleData battleData = battleName != default ? AddressableLoader.Get<BattleData>(nameof(BattleData), battleName) : null;
                        string battleTitle = "";
                        if (battleData?.nameRef != null && !battleData.nameRef.IsEmpty)
                            battleTitle = battleData?.nameRef?.GetLocalizedString();

                        /*if (!bossText.IsNullOrEmpty())
                        {
                            text = $"Fighting {bossText}";

                            if (bossText != battleTitle && !battleTitle.IsNullOrEmpty())
                                text += $" ({battleTitle})";
                        }
                        else if (!battleTitle.IsNullOrEmpty())
                        {
                            text = $"Fighting {battleTitle}";
                        }*/
                        if (!battleTitle.IsNullOrEmpty())
                        {
                            text = $"Fighting {battleTitle}";

                            if (battleData.ModAdded != null)
                                text += $" ({battleData.ModAdded.Title})";
                        }
                    }

                    return text;
                case State.MapNew:
                    if (Campaign.instance)
                    {
                        CampaignNode node = Campaign.FindCharacterNode(References.Player);
                        if (node == null) return text;
                        else text = $"Map - Tier {node.tier} Floor {node.positionIndex}"; // F{node.positionIndex}
                    }

                    return text;

                case State.Event:
                    if (Campaign.instance)
                    {
                        CampaignNode node = Campaign.FindCharacterNode(References.Player);
                        if (node == null) return text;
                        else text = $"Event"; // F{node.positionIndex} 

                        if (node.type.mapNodePrefab?.label?.textFitter && node.type.mapNodePrefab.label.textFitter.TryGetComponent<LocalizeStringEvent>(out var stringEvent))
                        {
                            if (stringEvent.StringReference != null && !stringEvent.StringReference.IsEmpty)
                                text += " - " + stringEvent.StringReference.GetLocalizedString();
                        }
                        switch (node.type.name)
                        {
                            case "CampaignNodeCharmShop":
                            case "CampaignNodeClunkShop":
                            case "CampaignNodeShop":
                                text += " - " + $"{References.PlayerData.inventory.gold}G" ;
                                break;
                        }
                    }

                    return text;
                /*case State.CHOOSING_CARD:
                    return "Choosing a card...";
                case State.CHOOSING_RARE_CARD:
                    return "Choosing a rare card...";
                case State.TRADE_TOOTH:
                    return "Trading for pelts...";
                case State.TRADE_PELT:
                    return "Trading pelts for card...";
                case State.TRADE:
                    return "Trading...";
                case State.MERGE_CARD:
                    return "Merging card...";
                case State.TOTEM_SELECT:
                    return "Selecting a totem piece...";
                case State.TOTEM_BUILD:
                    return "Building a totem...";
                case State.UNKNOW:*/
                case State.UNKNOWN:
                    return "";
                default:
                    return $"In {state}";
            }
        }

        /*public static void onViewControlModeSwitch(ControlMode mode)
        {
            State previousState = currentState;
            currentState = getStateFromControlMode(mode);
            if (previousState == currentState) return;
            if (currentState == State.UNKNOW) Debug.LogError($"Unknown Control Mode: {mode} (Please report to Dev)");
            Utility.SetStatus(getTextFromState(currentState), Timestamps.Now);
        }*/
    }
}