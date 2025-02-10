using System.Collections;
using System.Linq;
using UnityEngine;
using System.Reflection;
using System.Collections.Generic;
using System;
using static Rewired.Utils.Classes.Data.TypeWrapper;
using UnityEngine.UI;

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

        public class CommandCustomDestroy : ConsoleCustom.Command
        {
            public override string id => "destroy";

            public override void Run(string args)
            {
                if (Console.hover == null)
                {
                    this.Fail("Please hover over a card to use this command");
                }
                else if (References.Player == null)
                    Fail("Must be in a campaign to use this command");
                else if (References.Player.entity.display is CharacterDisplay display && display.deckDisplay.gameObject.activeSelf)
                {
                    if (Battle.instance != null)
                    {
                        this.FailCannotUse();
                        return;
                    }
                    else if (!(References.Player?.data.inventory.deck.list.Remove(Console.hover.data) ?? false))
                    {
                        this.Fail("Cannot destroy this card");
                        return;
                    }
                    Console.hover.RemoveFromContainers();
                    CardManager.ReturnToPool(Console.hover);
                    CardPopUp.Clear();
                    GameObject.FindObjectOfType<DeckDisplaySequence>()?.activeCardsGroup.UpdatePositions();
                }
                else if (!Console.hover.enabled)
                {
                    this.Fail("Cannot destroy this card");
                }
                else
                {
                    Console.hover.RemoveFromContainers();
                    CardManager.ReturnToPool(Console.hover);
                    CardPopUp.Clear();
                }
            }
        }
        public class CommandCustomSpawn : ConsoleCustom.Command
        {
            public override string id => "spawn";

            public override string format => "spawn <unit>";

            public override bool IsRoutine => true;

            public override IEnumerator Routine(string args)
            {
                CommandCustomSpawn commandSpawn = this;
                if (!References.Battle)
                    commandSpawn.Fail("Must be in battle to use this command");
                else if (args.Length <= 0)
                    commandSpawn.Fail("You must provide a card name");
                else if (!Console.slotHover)
                    commandSpawn.Fail("You must hover over a slot to use this command");
                else if (!Console.slotHover.Empty)
                {
                    commandSpawn.Fail("That slot is not empty!");
                }
                else
                {
                    yield return (object)AddressableLoader.LoadGroup("CardData");
                    IEnumerable<CardData> source = AddressableLoader.GetGroup<CardData>("CardData").Where<CardData>((Func<CardData, bool>)(a => a.cardType.unit && string.Equals(a.name, args, StringComparison.CurrentCultureIgnoreCase)));
                    if (source.Any())
                    {
                        CardData cardData = source.First();
                        if (cardData != null)
                        {
                            Card card = CardManager.Get(cardData.Clone(), References.Battle.playerCardController, Console.slotHover.owner, true, Console.slotHover.owner.team == References.Player.team);
                            card.entity.flipper.FlipDownInstant();
                            card.transform.localPosition = new Vector3(-100f, 0.0f, 0.0f);
                            yield return card.UpdateData(false);

                            Debug.LogWarning($"[AConsole] Deploying {cardData.name}");
                            Deploy(card.entity);

                            //Console.slotHover.Add(card.entity);
                            Console.slotHover.TweenChildPositions();
                            ActionQueue.Add(new ActionReveal(card.entity));
                            ActionQueue.Add(new ActionRunEnableEvent(card.entity));
                            yield return ActionQueue.Wait();
                            card = null;
                            yield break;
                        }
                    }
                    commandSpawn.Fail("Card [" + args + "] does not exist!");
                }
            }
            public void Deploy(Entity entity)
            {
                try
                {
                    int targetRow = -1;
                    int targetColumn = -1;
                    CardSlot slot = Console.slotHover;

                    targetRow = References.Battle.GetRowIndex(slot.Group);
                    var row = References.Battle.GetRow(slot.owner, targetRow);
                    if (row is CardSlotLane lane)
                        targetColumn = lane.slots.IndexOf(slot);
                    Resources.FindObjectsOfTypeAll<WaveDeploySystem>().FirstOrDefault().Deploy(entity, targetRow, targetColumn);
                }
                catch
                {
                    Debug.LogError($"[AConsole] FAILED TO DEPLOY [{entity.name}] SMARTLY");
                    Console.slotHover.Add(entity);
                }
            }

            public override IEnumerator GetArgOptions(string currentArgs)
            {
                CommandCustomSpawn commandSpawn = this;
                if (!AddressableLoader.IsGroupLoaded("CardData")) yield return AddressableLoader.LoadGroup("CardData");
                IEnumerable<CardData> source = AddressableLoader.GetGroup<CardData>("CardData").Where(data =>
                {
                    string title = data.title;
                    return data.name.ToLower().Contains(currentArgs.ToLower()) || (title?.ToLower().Contains(currentArgs.ToLower()) ?? false);
                });

                predictedArgs = source.Select(data =>
                {
                    string title = data.title;
                    if (!title.IsNullOrEmpty()) return $"{data.name} // {title}";
                    else return $"{data.name}";
                }).ToArray();
            }
        }
    }
}