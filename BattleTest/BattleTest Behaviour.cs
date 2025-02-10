using Deadpan.Enums.Engine.Components.Modding;
using FMODUnity;
using HarmonyLib;
using Rewired;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace WildfrostHopeMod.BattleTest
{
    public class BattleTestModBehaviour : MonoBehaviour
    {
        [HarmonyPatch]
        public class ExtraPopups
        {
            static readonly Dictionary<string, (string keyword, PopGroup group)[]> flavours = new()
            {
                { "Pengoon", [
                    ("scrap", PopGroup.Right),
                    ("snow", PopGroup.LeftOverflow),
                ] },
                { "Chungoon", [
                    ("scrap", PopGroup.Right),
                    ("snow", PopGroup.LeftOverflow),
                ] },
            };

            public enum PopGroup
            {
                Left,
                LeftOverflow,
                Right,
                RightOverflow,
                Bottom
            }
            static Transform GetGroup(CardInspector inspector, PopGroup popGroup) =>
                popGroup switch
                {
                    PopGroup.Left => inspector.leftPopGroup,
                    PopGroup.LeftOverflow => inspector.leftOverflowPopGroup,
                    PopGroup.Right => inspector.rightPopGroup,
                    PopGroup.RightOverflow => inspector.rightOverflowPopGroup,
                    PopGroup.Bottom => inspector.bottomPopGroup
                };

            [HarmonyPatch(typeof(CardInspector), nameof(CardInspector.CreatePopups))]
            static void Postfix(CardInspector __instance, Entity inspect)
            {
                if (inspect.display is not Card card) return;
                if (!flavours.TryGetValue(inspect.name, out var flavour)) return;

                foreach ((string keyword, PopGroup group) in flavour)
                {
                    KeywordData data = Text.ToKeyword(keyword) ?? throw new NullReferenceException($"No KeywordData found with name [{keyword}]");
                    CardPopUpPanel panel = __instance.Popup(data, GetGroup(__instance, group));
                    foreach (CardData card in Text.GetMentionedCards(keyword.body))
                    {
                        CardPopUpPanel cardPopUpPanel = __instance.Popup(keyword1, group);
                        panel.children.AddIfNotNull(cardPopUpPanel);
                    }
                }
            }
            static Transform GetGroup(InspectSystem inspector, PopGroup popGroup) =>
                popGroup switch
                {
                    PopGroup.Left => inspector.leftPopGroup,
                    PopGroup.LeftOverflow => inspector.leftOverflowPopGroup,
                    PopGroup.Right => inspector.rightPopGroup,
                    PopGroup.RightOverflow => inspector.rightOverflowPopGroup,
                    PopGroup.Bottom => inspector.bottomPopGroup
                };

            [HarmonyPatch(typeof(InspectSystem), nameof(InspectSystem.CreatePopups))]
            static void Postfix(InspectSystem __instance)
            {
                Entity entity = __instance.inspect;
                if (inspect.display is not Card card) return;
                if (!flavours.TryGetValue(inspect.name, out var flavour)) return;

                foreach ((string keyword, PopGroup group) in flavour)
                {
                    KeywordData data = Text.ToKeyword(keyword) ?? throw new NullReferenceException($"No KeywordData found with name [{keyword}]");
                    CardPopUpPanel panel = __instance.Popup(data, GetGroup(__instance, group));
                    foreach (CardData card in Text.GetMentionedCards(keyword.body))
                    {
                        CardPopUpPanel cardPopUpPanel = __instance.Popup(keyword1, group);
                        panel.children.AddIfNotNull(cardPopUpPanel);
                    }
                }
            }
        }

        void Update()
        {
            //ModifyCardSequence
            if (MusicSystem.current.isValid()
                && FMOD.RESULT.OK == (MusicSystem.current.getDescription(out var desc) & MusicSystem.current.getTimelinePosition(out int pos)))
            {
                desc.getLength(out int length);
                desc.getPath(out string path);
                Debug.Log($"{Path.GetFileName(path)}:   {pos}/{length}");
            }
            else
                Debug.Log("not valid");
            if (Input.GetKey(KeyCode.LeftAlt))
            {
                FMODUnity.RuntimeManager.StudioSystem.getBankList(out var banks);
                List<string> lines = new List<string>();
                foreach (var bank in banks)
                {
                    bank.getPath(out string bankpath);
                    //Debug.Log(bankpath);
                    bank.getEventList(out var events);
                    foreach (var e in events)
                    {
                        e.isOneshot(out bool eOne);
                        //Events.InvokeAudioPitchChange("Master", 5);
                        e.getPath(out string path);
                        //Debug.Log(path + ": " + eOne);
                        e.getID(out FMOD.GUID id);

                        List<FMOD.Studio.PARAMETER_DESCRIPTION> descs = [];
                        e.getParameterDescriptionCount(out var parameterDescriptionCount);
                        for (int i = 0; i < parameterDescriptionCount; i++)
                        {
                            e.getParameterDescriptionByIndex(parameterDescriptionCount, out var paramDesc);
                            descs.Add(paramDesc);
                            Debug.LogWarning($"{path} :    {i}");
                            paramDesc.PrintAllFields();
                            Debug.LogError("OWO");
                            paramDesc.id.PrintAllFields();
                        }
                        lines.Add($"{path}\t{id}\t{descs.Select(d => (string)d.name).Join()}");
                    }
                }
            }

            if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.T))
            {
            }
        }
    }
}