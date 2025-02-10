using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.IO;
using Deadpan.Enums.Engine.Components.Modding;
using Rewired;
using static UnityEngine.Rendering.DebugUI;
using HarmonyLib;

namespace WildfrostHopeMod.CommandsConsole
{
    public partial class ConsoleCustom
    {
        
        public class CommandAvatarRandomise : Console.Command
        {
            public static readonly List<string> parts = new()
            {
                "Body",
                "Head",
                "Weapon1",
                "Weapon2",
                "Eyes",
                "Eyebrows",
                "Mouth",
                "Nose",
                "Ears",
                "HairTop",
                "HairBack",
                "Beard",
                "HairColour",
                "EyeColour",
                "SkinColour",
                "ClothingColour",
                "MarkingColour"
            };
            public override string id => "avatar randomise";
            public override string format => "avatar randomise <part?>";
            public override string desc => "randomise a Leader's avatar";
            //public override bool IsRoutine => true;
            //public override IEnumerator Routine(string args)
            public override void Run(string args)
            {
                var entity = Console.hover;
                Leader image;
                string part = "";
                IEnumerable<string> source = parts.Where(a => string.Equals(a, args, StringComparison.CurrentCultureIgnoreCase));
                if (source.Any())
                    part = source.First();
                if (!entity)
                    Fail("You must hover over a card to use this command");
                else if (entity.data.cardType.name != "Leader")
                    Fail("Card must have CardType Leader to use this command");
                else if (!(image = (entity.display as Card).scriptableImage as Leader))
                    Fail("Card must have ScriptableImage of type Leader");
                else
                {
                    var script = entity.data.createScripts.First(c => c is CardScriptLeader) as CardScriptLeader;
                    if (entity.data.TryGetCustomData("CharacterData", out CharacterData data, null))
                    {
                        var profile = script.leaderProfileOptions.RandomItem();
                        var charType = script.characterTypeOptions.RandomItem();
                        profile.Apply(charType);
                        if (!part.IsNullOrWhitespace())
                        {
                            var fieldName = (char.ToLower(part[0]) + part.Substring(1) + "Index")
                                .Replace("marking", "markings")
                                .Replace("ears", "ear")
                                .Replace("eyebrows", "eyebrow")
                                .Replace("Colour", "Color");
                            Debug.LogError(fieldName);
                            var field = data.GetType().GetField(fieldName);
                            int i = (int)field.GetValue(data);
                            Debug.LogWarning(i);
                            if (parts.IndexOf(part) < 5)
                                data.SetRandomPrefab(false, charType, part, ref i);
                            else if (parts.IndexOf(part) >= parts.Count - 5)
                                data.SetRandomColorSet(false, charType, part, ref i);
                            else
                                data.SetRandomSprite(false, charType, part, ref i);
                            
                            field.SetValue(data, i);
                            Debug.LogWarning((int)field.GetValue(data));
                        }
                        else
                            //script.Run(entity.data);
                            data.Randomize(script.characterTypeOptions.FirstOrDefault());
                        profile.UnApply(charType);
                        entity.data.SetCustomData("CharacterData", data); 
                        image.avatar.UpdateDisplay(data);
                        if (Campaign.instance)
                            SaveSystem.SaveCampaignData(Campaign.Data.GameMode, "data", Campaign.instance.Save());
                    }
                    else
                        Fail($"Entity [{entity.name}] has no CharacterData");
                }
            }
            public override IEnumerator GetArgOptions(string currentArgs)
            {
                IEnumerable<string> source = parts.Where(a => a.ToLower().Contains(currentArgs.ToLower()));
                predictedArgs = source.ToArray();
                yield break;
            }
        }
        public class CommandAvatarShift : Console.Command
        {
            public override string id => "avatar shift";
            public override string format => "avatar shift <part>";
            public override string desc => "(WIP) shift part of a Leader's avatar";
            public override void Run(string args)
            {
                var entity = Console.hover;
                Leader image;
                if (!entity)
                    Fail("You must hover over a card to use this command");
                else if (entity.data.cardType.name != "Leader")
                    Fail("Card must have CardType Leader to use this command");
                else if (!(image = (entity.display as Card).scriptableImage as Leader))
                    Fail("Card must have ScriptableImage of type Leader");
                else
                {
                    var script = entity.data.createScripts.First(c => c is CardScriptLeader);
                    script.Run(entity.data);
                    if (entity.data.TryGetCustomData("CharacterData", out CharacterData data, null))
                    {
                        image.avatar.UpdateDisplay(data);
                        if (Campaign.instance)
                            SaveSystem.SaveCampaignData(Campaign.Data.GameMode, "data", Campaign.instance.Save());
                    }
                    else
                        Fail($"Entity [{entity.name}] has no CharacterData");
                }
            }
        }
        /*public class CommandAvatarRun : Console.Command
        {
            public override string id => "avatar";
            public override string format => "avatar <parts?>";
            public override string desc => "customise a Leader's avatar";
            public override void Run(string args)
            {
                var entity = Console.hover;
                if (entity.data.cardType.name != "Leader")
                    FailCannotUse();
                if (!entity.TryGetComponent(out Leader image))
                    FailCannotUse();
                image.avatar.UpdateDisplay(null);
            }

        }*/
        /*public class CommandAvatarRoutine : Console.Command
        {
            public override string id => "avatar";
            public override string format => "avatar <parts?>";
            public override string desc => "customise a Leader's avatar";
            public override bool IsRoutine => true;
            public override IEnumerator Routine(string args)
            {
                CommandExportCards command = this;
                CardData cardData = null;
                Card temp = null;
                if (args.Length == 0)
                {
                    if (Console.hover == null) Fail("Please hover over a card or provide a card name to use this command");
                    else
                    {
                        cardData = Console.hover.data;
                        temp = GameObject.Instantiate(Console.hover.display as Card);
                    }
                }
                else
                {
                    if (!AddressableLoader.IsGroupLoaded("CardData")) yield return AddressableLoader.LoadGroup("CardData");
                    IEnumerable<CardData> source = AddressableLoader.GetGroup<CardData>("CardData").Where(a => string.Equals(a.name, args, StringComparison.CurrentCultureIgnoreCase));
                    if (source.Any()) 
                        cardData = source.First();
                    else command.Fail("Card [" + args + "] does not exist!");
                }
                if (cardData != null && !(cardData.mainSprite?.name == "Nothing"))
                {
                    Card card = temp ?? CardManager.Get(cardData, null, null, false, false);
                    card.gameObject.SetLayerRecursively(7);
                    yield return card.UpdateData(false);
                    card.transform.position = Vector3.zero;
                    yield return null;
                    GameObject newCameraObject = new GameObject("NewCamera");
                    ExportCards exportCards = new();
                    exportCards._camera = newCameraObject.AddComponent<Camera>();
                    exportCards._camera.CopyFrom(Camera.main);
                    exportCards._camera.cullingMask = 1 << card.gameObject.layer;
                    exportCards.Screenshot(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + exportCards.folder + "/" + cardData.cardType.name, card.titleText.text + " (" + card.name + ").png");
                    yield return null;
                    CardManager.ReturnToPool(card);
                    card = null;
                    cardData = null;
                    // exportCards.camera.targetTexture = null; // the MainCamera's target texture has to be null
                    // exportCards.camera.cullingMask = -1; // this renders every layer
                    newCameraObject.Destroy();
                }
                else Fail("Card is not valid");
                temp.Destroy();
            }


            public override IEnumerator GetArgOptions(string currentArgs)
            {
                if (!AddressableLoader.IsGroupLoaded("CardData")) yield return AddressableLoader.LoadGroup("CardData");
                IEnumerable<CardData> source = AddressableLoader.GetGroup<CardData>("CardData").Where(a => a.name.ToLower().Contains(currentArgs.ToLower()));
                predictedArgs = source.Select(cardData => cardData.name).ToArray();
            }
        }*/
    }
}