using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace WildfrostHopeMod.Database.StatusEffects
{
    public class StatusEffectChooseCard : StatusEffectData
    {
        public EffectEntityEventHandler eventHandler;
        public From from;

        protected Entity selected;
        protected CardPocketSequence sequence;
        public override void Init()
        {
            base.PostHit += Tutor;
        }

        public override bool RunPostHitEvent(Hit hit)
        {
            if (hit.attacker == target && hit.damageType == "basic")
            {
                return true;
            }
            return false;
        }
        private CardContainer GetPotentialCards()
        {
            return from switch
            {
                From.Hand => References.Player.handContainer,
                From.Draw => References.Player.drawContainer,
                From.Discard => References.Player.discardContainer,
                _ => null
            };
        }

        private IEnumerator Tutor(Hit hit) //Activates on posthit
        {
            sequence = GameObject.FindObjectOfType<CardPocketSequence>(true);
            CardContainer container = GetPotentialCards();
            if (!container)
                yield break;
            sequence.AddCards(container);

            CardControllerSelectCard cc = (CardControllerSelectCard)sequence.cardController;
            cc.pressEvent.AddListener(ChooseCard);
            cc.canPress = true;

            CinemaBarSystem.In();
            CinemaBarSystem.Top.SetPrompt("Select a card to continue", "Select");
            CinemaBarSystem.Bottom.SetPrompt("Right-click to exit", "Back");
            CinemaBarSystem.SetSortingLayer("UI2");
            yield return sequence.Run();

            if (selected != null) //Card Selected
            {
                yield return eventHandler?.Invoke(selected);
            }

            selected = null;
            cc.canPress = false;
            cc.pressEvent.RemoveListener(ChooseCard);
            CinemaBarSystem.Out();
        }

        private void ChooseCard(Entity entity)
        {
            selected = entity;
            sequence.promptEnd = true;
        }

        public enum From
        {
            None,
            Hand,
            Draw,
            Discard,
            Board,
            Allies,
            Enemies
        }
    }
}
