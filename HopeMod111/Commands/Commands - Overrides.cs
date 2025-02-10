using System.Collections;
using System.Linq;
using UnityEngine;
using System.Reflection;
using System.Collections.Generic;
using System;
using static Rewired.Utils.Classes.Data.TypeWrapper;
using UnityEngine.UI;
using System.IO;
using HarmonyLib;
using System.Runtime.InteropServices;
using Deadpan.Enums.Engine.Components.Modding;

namespace WildfrostHopeMod.CommandsConsole
{
    public partial class ConsoleCustom
    {
        public abstract class Command : Console.Command
        {
            public Command()
            {
                Console.commands.RemoveWhere(c => c.id == this.id);
            }
        }
        private class CommandProgressReset : ConsoleCustom.Command
        {
            public static string Name { get; } = AccessTools.GetOutsideCaller().DeclaringType!.Name;
            public override string id => "progress reset";
            public override string desc => "delete save data";

            public override void Run(string args)
            {
                this.Fail("No");
            }
        }
        public class CommandCustomDestroy : Command
        {
            public override string id => "destroy";

            public override void Run(string args)
            {
                if (Console.hover == null)
                {
                    Fail("Please hover over a card to use this command");
                }
                else if (References.Player == null)
                {
                    Fail("Must be in a campaign to use this command");
                }
                else if (References.Player.entity.display is CharacterDisplay characterDisplay && characterDisplay.deckDisplay.gameObject.activeSelf)
                {
                    if (Battle.instance != null)
                    {
                        FailCannotUse();
                        return;
                    }

                    Character player = References.Player;
                    if ((object)player == null || !player.data.inventory.deck.list.Remove(Console.hover.data))
                    {
                        Fail("Cannot destroy this card");
                        return;
                    }

                    Console.hover.RemoveFromContainers();
                    CardManager.ReturnToPool(Console.hover);
                    CardPopUp.Clear();
                    UnityEngine.Object.FindObjectOfType<DeckDisplaySequence>()?.activeCardsGroup.UpdatePositions();
                }
                else if (!Console.hover.enabled)
                {
                    Fail("Cannot destroy this card");
                }
                else
                {
                    Console.hover.RemoveFromContainers();
                    CardManager.ReturnToPool(Console.hover);
                    CardPopUp.Clear();
                }
            }
        }
        public class CommandCustomSpawn : Command
        {
            public override string id => "spawn";

            public override string format => "spawn <unit>";

            public override bool IsRoutine => true;

            public override IEnumerator Routine(string args)
            {
                CommandCustomSpawn commandSpawn = this;
                if (!References.Battle)
                {
                    commandSpawn.Fail("Must be in battle to use this command");
                    yield break;
                }

                if (args.Length <= 0)
                {
                    commandSpawn.Fail("You must provide a card name");
                    yield break;
                }

                if (!Console.slotHover)
                {
                    commandSpawn.Fail("You must hover over a slot to use this command");
                    yield break;
                }

                if (!Console.slotHover.Empty)
                {
                    commandSpawn.Fail("That slot is not empty!");
                    yield break;
                }

                yield return AddressableLoader.LoadGroup("CardData");
                IEnumerable<CardData> source = from a in AddressableLoader.GetGroup<CardData>("CardData")
                                               where a.cardType.unit && string.Equals(a.name, args, StringComparison.CurrentCultureIgnoreCase)
                                               select a;
                if (source.Any())
                {
                    CardData cardData = source.First();
                    if (cardData != null)
                    {
                        Card card = CardManager.Get(cardData.Clone(), References.Battle.playerCardController, Console.slotHover.owner, inPlay: true, Console.slotHover.owner.team == References.Player.team);
                        card.entity.flipper.FlipDownInstant();
                        card.transform.localPosition = new Vector3(-100f, 0f, 0f);
                        yield return card.UpdateData();
                        Debug.LogWarning("[AConsole] Deploying " + cardData.name);
                        Deploy(card.entity);
                        Console.slotHover.TweenChildPositions();
                        ActionQueue.Add(new ActionReveal(card.entity));
                        ActionQueue.Add(new ActionRunEnableEvent(card.entity));
                        yield return ActionQueue.Wait();
                        yield break;
                    }
                }

                commandSpawn.Fail("Card [" + args + "] does not exist!");
            }

            public void Deploy(Entity entity)
            {
                try
                {
                    int num = -1;
                    int targetColumn = -1;
                    CardSlot slotHover = Console.slotHover;
                    num = References.Battle.GetRowIndex(slotHover.Group);
                    CardContainer row = References.Battle.GetRow(slotHover.owner, num);
                    if (row is CardSlotLane cardSlotLane)
                    {
                        targetColumn = cardSlotLane.slots.IndexOf(slotHover);
                    }

                    Resources.FindObjectsOfTypeAll<WaveDeploySystem>().FirstOrDefault().Deploy(entity, num, targetColumn);
                }
                catch
                {
                    Debug.LogError("[AConsole] FAILED TO DEPLOY [" + entity.name + "] SMARTLY");
                    Console.slotHover.Add(entity);
                }
            }

            public override IEnumerator GetArgOptions(string currentArgs)
            {
                if (!AddressableLoader.IsGroupLoaded("CardData"))
                {
                    yield return AddressableLoader.LoadGroup("CardData");
                }

                IEnumerable<CardData> source = AddressableLoader.GetGroup<CardData>("CardData").Where(delegate (CardData data)
                {
                    string title2 = data.title;
                    return data.name.ToLower().Contains(currentArgs.ToLower()) || (title2?.ToLower().Contains(currentArgs.ToLower()) ?? false);
                });
                predictedArgs = source.Select(delegate (CardData data)
                {
                    string title = data.title;
                    return (!title.IsNullOrEmpty()) ? (data.name + " \t// " + title) : (data.name ?? "");
                }).ToArray();
            }
        }
        private class LoadModCommand : Command
        {
            public override string format => "loadmod <guid>";
            public override string id => "loadmod";
            public override void Run(string args)
            {
                foreach (WildfrostMod mod in Bootstrap.Mods)
                {
                    if (mod.GUID == args)
                    {
                        mod.ModLoad();
                        break;
                    }
                }
            }
            public override IEnumerator GetArgOptions(string currentArgs)
            {
                IEnumerable<WildfrostMod> source = Bootstrap.Mods.Where(mod => !mod.HasLoaded);
                predictedArgs = source.Select(mod => $"{mod.GUID} \t// {mod.Title}").ToArray();
                yield break;
            }
        }
        private class UnLoadModCommand : Command
        {
            public override string format => "unloadmod <guid>";
            public override string id => "unloadmod";
            public override void Run(string args)
            {
                foreach (WildfrostMod mod in Bootstrap.Mods)
                {
                    if (mod.GUID == args)
                    {
                        mod.ModUnload();
                        break;
                    }
                }
            }
            public override IEnumerator GetArgOptions(string currentArgs)
            {
                IEnumerable<WildfrostMod> source = Bootstrap.Mods.Where(mod => mod.HasLoaded);
                predictedArgs = source.Select(mod => $"{mod.GUID} \t// {mod.Title}").ToArray();
                yield break;
            }
        }
        private class CommandSetSaveProfile : Command
        {
            public override string id => "save profile";

            public override string format => "save profile <name>";

            public override string desc => "switch save profile";

            public override void Run(string args)
            {
                if (Campaign.instance == null)
                {
                    SaveSystem.SetProfile(args);
                }
                else
                {
                    Fail("Cannot switch save profile here!");
                }
            }

            public override IEnumerator GetArgOptions(string currentArgs)
            {
                IEnumerable<DirectoryInfo> source = from data in new DirectoryInfo(SaveSystem.profileFolder).GetDirectories()
                                                    where data.Name.ToLower().Contains(currentArgs.ToLower())
                                                    select data;
                predictedArgs = source.Select((DirectoryInfo d) => d.Name).ToArray().With(currentArgs);
                yield break;
            }
        }

        private class CommandPrompt : Command
        {
            public override string id => "prompt";

            public override string format => "prompt <anchor> <x> <y> <maxWidth> <text>";

            public override void Run(string args)
            {
                List<string> list = args.Split([' '], StringSplitOptions.RemoveEmptyEntries).ToList();
                if (list.Count <= 4)
                {
                    this.Fail($"Missing arguments: { new string[] { "anchor", "x", "y", "maxWidth", "text" }.RangeSubset(list.Count, 5-list.Count).Join()}");
                    return;
                }

                if (Enum.TryParse(list[0].ToUpperFirstLetter(), out Prompt.Anchor anchor) && float.TryParse(list[1], out float x) && float.TryParse(list[2], out float y) && float.TryParse(list[3], out float maxWidth))
                {
                    list.RemoveRange(0, 4);
                    string text = string.Join(" ", list);
                    PromptSystem.Create(anchor, x, y, maxWidth);
                    PromptSystem.SetTextAction(() => text);
                }
                else
                    this.Fail("Invalid arguments");
            }
            public override IEnumerator GetArgOptions(string currentArgs)
            {
                predictedArgs = [];

                string[] strArray = Console.Command.Split(currentArgs.TrimStart());
                if (strArray.Length <= 0) yield break;

                string anchor = strArray[0];
                if (anchor.IsEmpty() || (strArray.Length <= 1 && currentArgs.LastOrDefault() != ' '))
                {
                    IEnumerable<string> source = typeof(Prompt.Anchor).GetEnumNames().Where(a => a.ToLower().Contains(anchor.ToLower()));

                    if (source.Any())
                    {
                        predictedArgs = source.Select(s => s + " ").ToArray();
                    }
                }
            }
        }
    }
}