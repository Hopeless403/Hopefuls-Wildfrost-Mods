using Deadpan.Enums.Engine.Components.Modding;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;
using UnityEngine.Events;
using static Rewired.Utils.Classes.Data.TypeWrapper;

namespace WildfrostHopeMod.CommandsConsole
{
    public partial class ConsoleCustom
    {
        private class CommandCustomGainCard : Console.CommandGainCard, ICommandOverride
        {
            public override IEnumerator Routine(string args)
            {
                if (args.Length == 0)
                {
                    Fail("You must provide a card name");
                    yield break;
                }

                if (!TryGetPlayer(out var player))
                {
                    yield break;
                }

                yield return AddressableLoader.LoadGroup("CardData");
                IEnumerable<CardData> source = from a in AddressableLoader.GetGroup<CardData>("CardData")
                                               where string.Equals(a.name, args, StringComparison.CurrentCultureIgnoreCase)
                                               select a;
                if (!source.Any())
                {
                    Fail($"Card [{args}] does not exist!");
                    yield break;
                }

                CardData cardData = source.First();
                if (cardData == null)
                {
                    yield break;
                }

                CardData cardData2 = cardData.Clone();
                player.data.inventory.deck.Add(cardData2);
                if (Battle.instance && player.handContainer)
                {
                    Card card = CardManager.Get(cardData2, Battle.instance.playerCardController, player, inPlay: true, isPlayerCard: true);
                    card.entity.flipper.FlipDownInstant();
                    card.transform.localPosition = new Vector3(-100f, 0f, 0f);
                    yield return card.UpdateData();
                    player.handContainer.Add(card.entity);
                    player.handContainer.TweenChildPositions();
                    ActionQueue.Add(new ActionReveal(card.entity));
                    ActionQueue.Add(new ActionRunEnableEvent(card.entity));
                    yield return ActionQueue.Wait();
                }
                else
                {
                    var deckDisplaySequence = GameObject.FindObjectOfType<DeckDisplaySequence>(true);
                    if (deckDisplaySequence && deckDisplaySequence.gameObject.activeSelf)
                    {
                        yield return deckDisplaySequence.activeCardsGroup.CreateCard(cardData2);
                        deckDisplaySequence.activeCardsGroup.UpdatePositions();
                        yield return deckDisplaySequence.FixLayoutsRoutinePreserveScroll();
                    }
                }
            }
        }
        private class CommandCustomGainUpgrade : Console.CommandGainUpgrade, ICommandOverride
        {
            public override IEnumerator Routine(string args)
            {
                yield return base.Routine(args);
                var deckDisplaySequence = GameObject.FindObjectOfType<DeckDisplaySequence>(true);
                if (deckDisplaySequence && deckDisplaySequence.gameObject.activeSelf)
                {
                    deckDisplaySequence.charmHolder.Clear();
                    deckDisplaySequence.crownHolder.Clear();
                    foreach (CardUpgradeData upgrade in deckDisplaySequence.owner.data.inventory.upgrades)
                    {
                        switch (upgrade.type)
                        {
                            case CardUpgradeData.Type.Charm:
                                deckDisplaySequence.charmHolder.Create(upgrade);
                                continue;
                            case CardUpgradeData.Type.Crown:
                                deckDisplaySequence.crownHolder.Create(upgrade);
                                continue;
                            default:
                                continue;
                        }
                    }
                    deckDisplaySequence.charmHolder.SetPositions();
                    deckDisplaySequence.crownHolder.SetPositions();
                }
            }
        }
    }
}