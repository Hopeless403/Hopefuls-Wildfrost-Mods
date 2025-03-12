using Deadpan.Enums.Engine.Components.Modding;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace WildfrostHopeMod.CommandsConsole
{
    public partial class ConsoleCustom
    {
        // WIP


        public class CommandMapReplace : Console.Command
        {
            public override string id => "map replace";
            public override string format => "map replace <name>";
            public override string desc => "the selected map node";
            public override bool hidden => true;
            public override void Run(string args)
            {
                MapNode[] objectsOfType = UnityEngine.Object.FindObjectsOfType<MapNode>();
                if (objectsOfType.Length == 0) FailCannotUse();
                else
                {
                    MapNode node = objectsOfType.FirstOrDefault(n => n.IsHovered);
                    if (node == null) Fail("You must be hovering over a map node");
                    else
                    {
                        CampaignNodeType type = null;
                        IEnumerable<CampaignNodeType> source = AddressableLoader.GetGroup<CampaignNodeType>("CampaignNodeType").Where(a => a.canLink && string.Equals(a.name, args, StringComparison.CurrentCultureIgnoreCase));
                        if (source.Any())
                        {
                            type = source.First();

                            node.campaignNode.SetType(type);
                            var clump = new Routine.Clump();
                            clump.Add(type.SetUp(node.campaignNode));
                            clump.WaitForEnd();
                            node.Refresh();
                            node.Assign(node.campaignNode);
                            node.campaignNode.revealed = true;

                            node.spriteOptions = [type.mapNodeSprite];
                            //node.spriteSetter =
                            node.Refresh();
                        }
                        else Fail($"CampaignNodeType [{args}] could not be found!");

                    }
                }
            }
            public override IEnumerator GetArgOptions(string currentArgs)
            {
                if (!AddressableLoader.IsGroupLoaded("CampaignNodeType")) yield return AddressableLoader.LoadGroup("CampaignNodeType");
                IEnumerable<CampaignNodeType> source = AddressableLoader.GetGroup<CampaignNodeType>("CampaignNodeType").Where(a => a.canLink && a.name.ToLowerInvariant().Contains(currentArgs.ToLowerInvariant()));
                predictedArgs = source.Select(CampaignNodeType => CampaignNodeType.name.Replace(" ", "")).ToArray();
            }

        }

        public class CommandCustomSummon : Console.Command
        {
            public override string id => "custom effect summon";
            public override string format => "custom effect summon <name>";
            public override string desc => "";
            public override bool IsRoutine => true;

            public override IEnumerator Routine(string args)
            {
                if (args.Length > 0)
                {
                    if (Console.hover != null)
                    {
                        if (Console.hover.enabled)
                        {
                            Entity applier = CardManager.Get(AddressableLoader.groups["CardData"].lookup["Junk"] as CardData, null, References.Player, false, false).entity;
                            Entity target = Console.hover;
                            string[] strArray = Split(args);
                            int count = 1;
                            string cardName = string.Join(" ", strArray);
                            if (strArray.Length > 1 && int.TryParse(strArray.Last(), out count))
                                cardName = string.Join(" ", strArray.RangeSubset(0, strArray.Length - 1));
                            if (!AddressableLoader.IsGroupLoaded("CardData")) yield return AddressableLoader.LoadGroup("CardData");
                            IEnumerable<CardData> source = AddressableLoader.GetGroup<CardData>("CardData").Where(a => string.Equals(a.name, cardName, StringComparison.CurrentCultureIgnoreCase));
                            if (source.Any())
                            {
                                CardData cardData = source.First();
                                if (cardData != null)
                                {
                                    yield return StatusEffectSystem.Apply(Console.hover, applier, CreateSummonEffect(cardName), count);
                                    Card card = target.gameObject.GetComponent<Card>();
                                    card.promptUpdateDescription = true;
                                    yield return card.UpdateDisplay(false);
                                }
                            }
                            else Fail("CardData [" + cardName + "] does not exist!");
                        }
                        else Fail("Cannot use on that card");
                    }
                    else Fail("Please hover over a card to use this command");
                }
                else Fail("You must provide a CardData name");
            }

            public override IEnumerator GetArgOptions(string currentArgs)
            {
                if (!AddressableLoader.IsGroupLoaded("CardData")) yield return AddressableLoader.LoadGroup("CardData");
                IEnumerable<CardData> source = AddressableLoader.GetGroup<CardData>("CardData").Where(a => a.name.ToLower().Contains(currentArgs.ToLower()) || a.title.ToLower().Contains(currentArgs.ToLower()));
                predictedArgs = source.Select(cardData => $"{cardData.name} \t// {cardData.title}").ToArray();
            }

            public StatusEffectSummon CreateSummonEffect(string cardName)
            {
                // Activator.CreateInstance(type)
                var effect = new StatusEffectDataBuilder(ConsoleMod.Mod)
                    .Create<StatusEffectSummon>($"Summon {cardName}")
                    .WithText($"Summon <card={cardName}>")
                    .FreeModify(d =>
                    {
                        var data = d as StatusEffectSummon;
                        data.summonCard = ConsoleMod.Mod.Get<CardData>(cardName);
                    })
                    .SetSummonPrefabRef()
                    .Build();
                return effect as StatusEffectSummon;
            }
            public StatusEffectSummon CreateSummonEffect(CardData cardData)
            {
                var effect = new StatusEffectDataBuilder(ConsoleMod.Mod)
                    .Create<StatusEffectSummon>($"Summon {cardData.name}")
                    .WithText($"Summon <card={cardData.name}>")
                    .FreeModify(d =>
                    {
                        var data = d as StatusEffectSummon;
                        data.summonCard = cardData;
                    })
                    .SetSummonPrefabRef()
                    .Build();
                return effect as StatusEffectSummon;
            }
        }
    }
}