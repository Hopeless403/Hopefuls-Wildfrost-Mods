using Deadpan.Enums.Engine.Components.Modding;
using FMODUnity;
using HarmonyLib;
using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace WildFlipper
{
    public static class Ext {
        public static T FreeModify<T>(this T target, Func<T, T> action) => action(target);
        public static T FreeModify<T>(this T target, Action<T> action) { action(target); return target; }
    }
    public partial class WildFlipperMod
    {
        public class BlueBlobble : CardDataBuilder
        {
            public string hiddenTitle => "Blob of Water";

            /*public CardDataBuilder builder =>
                new CardDataBuilder(instance)
                .CreateUnit("BlueBlobble", "Blue Blobble")
                .SetStats(3, 1, 3)
                .WithFlavour("Because these little guys go poof as soon as you defeat them, no one knows what they truly are. Blue Blobbles are likely under the domination of the Water Spirit. They are moist, jiggly, and honestly, quite pleasant to touch.")
                .WithTargetMode(nameof(TargetModeAll))
                ;*/
            public CardDataBuilder builder =>
                new CardDataBuilder(instance)
                .CreateUnit("SeijiTakamori", "Seiji Takamori")
                .SetStats(300, 10, 3)
                .SetSprites("Ashi.png", "Ashi BG.png")
                .WithFlavour("It took the world ending for him to realize the extent of the excuses he gave himself")
                //.SetStartWithEffect(builders.Select(b => new CardData.StatusEffectStacks(b.Build(), 1)).ToArray())
                .SubscribeToAfterAllBuildEvent(c => c.startWithEffects = [
                    instance.CreateEffectStack("Blobby", 1)])
                .WithTargetMode(nameof(TargetModeAll))
                ;

            public StatusEffectDataBuilder[] builders =>
                [
                /*new StatusEffectDataBuilder(instance)
                .Create<StatusEffectApplyXWhenXAppliedTo>(hiddenTitle, s =>
                {
                    s.instead = true;
                    s.adjustAmount = true;
                    s.whenAnyApplied = true;
                    s.whenAppliedToFlags = StatusEffectApplyX.ApplyToFlags.Allies;
                    s.applyToFlags = StatusEffectApplyX.ApplyToFlags.Attacker;
                    //s.effectToApply = 
                }),*/

                new StatusEffectDataBuilder(instance)
                .Create<StatusEffectApplyXOnHit>(hiddenTitle, s =>
                {
                    s.applyToFlags = StatusEffectApplyX.ApplyToFlags.Self;
                    s.effectToApply = ScriptableObject.CreateInstance<StatusEffectInstantHeal>();
                    s.targetMustBeAlive = false;
                    s.targetConstraints = [];
                }).WithText("On kill, apply to enemies: instant heal <{a}>"),
                ];
                
            public class StatusEffectApplyXWhenXAppliedTo : StatusEffectApplyXWhenYAppliedTo
            {
                public override bool RunApplyStatusEvent(StatusEffectApply apply)
                {
                    this.effectToApply = apply.effectData;
                    return base.RunApplyStatusEvent(apply);
                }
            }
        }


        // It's not needed to extend NextPhase,
        // but AllJournalEntries mod checks that :3
        public class StatusEffectInstantPhase : StatusEffectInstant
        {
            public override void Init()
            {
                base.Init();
                Events.OnRedrawBellHit += s => ActionQueue.Stack(new ActionSelect(null, e => e?.Awake()), true);
            }
            public CardData nextPhase;
            // can be null to not use any animation
            // otherwise, copy bamboozle's NextPhase.animation
            public CardAnimation animation;

            public override IEnumerator Process()
            {
                if (nextPhase == null)
                    throw new NullReferenceException($"Next phase of [{name}] cannot be null.");

                ActionChangePhaseCustom action = new ActionChangePhaseCustom(this.target, this.nextPhase.Clone(), this.animation);
                action.priority = 10;
                ActionQueue.Stack((PlayAction)action, true);
                yield return base.Process();
            }
        }

        public class ActionChangePhaseCustom : ActionChangePhase
        {
            // Skips the zoom-in
            public bool skipFocus = true;
            // Skips the beating-up animation
            public bool skipAnimation = true;

            public ActionChangePhaseCustom(Entity entity, CardData newPhase, CardAnimation animation) : base(entity, newPhase, animation) { }
            public ActionChangePhaseCustom(Entity entity, CardData[] newPhases, CardAnimation animation) : base(entity, newPhases, animation) { }

            public override IEnumerator Run()
            {
                if (this.entity.IsAliveAndExists())
                {
                    Events.InvokeEntityChangePhase(this.entity);
                    CardData[] newPhases = this.newPhases;
                    bool multipleNewPhases = newPhases != null && newPhases.Length > 0;
                    if (multipleNewPhases)
                    {
                        Routine routine = new Routine(this.CreateNewCards());
                    }
                    if (Deckpack.IsOpen && References.Player.entity.display is CharacterDisplay display)
                        display.CloseInventory();
                    ChangePhaseAnimationSystem animationSystem = GameObject.FindObjectOfType<ChangePhaseAnimationSystem>();
                    if (animationSystem && !skipFocus)
                    {
                        PauseMenu.Block();
                        DeckpackBlocker.Block();
                        yield return animationSystem.Focus(this.entity);
                    }
                    if (this.animation && !skipAnimation)
                        yield return this.animation.Routine(this.entity);


                    foreach (PlayAction action in ActionQueue.GetActions())
                    {
                        switch (action)
                        {
                            case ActionTrigger actionTrigger:
                                if (actionTrigger.entity == this.entity)
                                {
                                    ActionQueue.Remove(action);
                                    break;
                                }
                                break;
                            case ActionEffectApply actionEffectApply:
                                actionEffectApply.TryRemoveEntity(this.entity);
                                break;
                        }
                    }
                    if (multipleNewPhases)
                    {
                        ActionSequence action = new ActionSequence(this.Split(this.entity, this.newPhases));
                        action.note = "Split boss";
                        action.priority = 10;
                        ActionQueue.Stack((PlayAction)action, true);
                    }
                    else
                    {
                        ActionSequence action = new ActionSequence(Change(this.entity, this.newPhase));
                        action.note = "Change boss phase";
                        action.priority = 10;
                        ActionQueue.Stack((PlayAction)action, true);
                    }
                    if (animationSystem && !skipFocus)
                    {
                        ActionSequence action = new ActionSequence(animationSystem.UnFocus());
                        action.note = "Unfocus boss";
                        action.priority = 10;
                        ActionQueue.Stack((PlayAction)action, true);
                    }
                }
            }
            public new static IEnumerator Change(Entity entity, CardData newData)
            {
                yield return StatusEffectSystem.EntityDisableEvent(entity);

                entity.alive = false;
                entity.flipper.FlipDown(true);
                yield return entity.ClearStatuses();
                yield return null;
                yield return new WaitUntil(() => entity.flipper.isCompleteFired);
                entity.data = newData;
                entity.alive = true;
                yield return entity.display.UpdateData(doPing: true);

                entity.flipper.FlipUp(true);
                _=typeof(StatusEffectOngoingAttack);

                Events.InvokeEntityEnabled(entity);
                yield return StatusEffectSystem.EntityEnableEvent(entity);


            }


            [HarmonyPatch(typeof(StatusEffectOngoing), nameof(StatusEffectOngoing.StackRoutine))]
            public class PatchOngoing
            {
                static IEnumerator Postfix(IEnumerator __result, StatusEffectOngoing __instance)
                {
                    Debug.LogWarning(__instance.target.statusEffects.Select(s => (s.name, s.count)).Join(delimiter:"\n"));
                    yield return __result;
                    yield return null;
                    Debug.LogError(__instance.target.statusEffects.Select(s => (s.name, s.count)).Join(delimiter: "\n"));
                }
            }
        }
    }

}