using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


namespace WildFlipper
{
    public partial class WildFlipperMod
    {
        // Does nothing except show an -oomlin
        // ... which is used on card played, and recreated when redrawn
        // Does not give free action
        public class StatusEffectShowPet : StatusEffectFreeAction
        {
            public override IEnumerator CardPlayedRoutine(Entity entity, Entity[] targets)
            {
                yield return base.CardPlayedRoutine(entity, targets);
                target.owner.freeAction = false;
            }
        }
        public class TargetConstraintHasPet : TargetConstraint
        {
            public override bool Check(CardData targetData)
            {
                return targetData.startWithEffects.Any(effectStack => Traverse.Create(effectStack.data).Field("petPrefab").GetValue() is GameObject go && go != null);
            }
            public override bool Check(Entity target)
            {
                return target.display is Card card && card.itemHolderPet?.currentPet != null;
            }
        }
        internal static List<object> EmoomlinBuilders()
        {
            // Plan:
            // Add a trait called Emoomlin
            // While a card has Emoomlin,
            // ... show the emoomlin
            // ... gain +4 attack and +1 to effects, where possible
            // When the card is played, lose Emoomlin trait

            assets.Add(new KeywordDataBuilder(instance)
                .Create("emoomlin")
                .WithTitle("Emoomlin")
                .WithTitle("エムームリン", SystemLanguage.Japanese)
                .WithDescription("""
                    Does not end your turn when played. Boost effects by <1> and <+4><keyword=attack>
                    |Card loses Emoomlin when played
                    """
                    )
                .WithDescription("", SystemLanguage.Japanese)
                .WithShowName(true)
            );


            assets.Add(new TraitDataBuilder(instance)
                .Create("Emoomlin")
                .WithOverrides(instance.TryGet<TraitData>("Noomlin"), instance.TryGet<TraitData>("Zoomlin"))
                .SubscribeToAfterAllBuildEvent(data =>
                {
                    data.keyword = instance.TryGet<KeywordData>("emoomlin");
                    data.effects = new[]
                    {
                        instance.TryGet<StatusEffectData>("Show Emoomlin"),
                        instance.TryGet<StatusEffectData>("Ongoing Increase Attack (No type)"),
                        instance.TryGet<StatusEffectData>("While Active Increase Effects"),
                        instance.TryGet<StatusEffectApplyXOnCardPlayed>("On Card Played Lose Emoomlin"),
                    };
                }
                )
            );

            assets.Add(new StatusEffectDataBuilder(instance)
                  .Create<StatusEffectOngoingAttack>("Ongoing Increase Attack (No type)")
                  .WithStackable(true)
                  .WithCanBeBoosted(false)
                  .SubscribeToAfterAllBuildEvent<StatusEffectOngoingAttack>(data =>
                  {
                      data.type = "";
                      data.targetConstraints = new TargetConstraint[]
                      {
                        new Scriptable<TargetConstraintDoesDamage>(),
                      };
                  })
            );

            assets.Add(new StatusEffectDataBuilder(instance)
                .Create<StatusEffectWhileActiveX>("While Active Increase Effects")
                .WithStackable(true)
                .WithCanBeBoosted(false)
                .SubscribeToAfterAllBuildEvent<StatusEffectWhileActiveX>(data =>
                {
                    data.hiddenKeywords = new KeywordData[] { instance.TryGet<KeywordData>("Active"), };
                    data.eventPriority = 10;
                    data.effectToApply = instance.TryGet<StatusEffectData>("Ongoing Increase Effects");
                    data.applyToFlags = StatusEffectApplyX.ApplyToFlags.Self;

                    data.applyConstraints = new TargetConstraint[]
                    {

                    };
                })
            );


            assets.Add(new StatusEffectDataBuilder(instance)
                .Create<StatusEffectApplyXOnCardPlayed>("On Card Played Lose Emoomlin")
                .SubscribeToAfterAllBuildEvent<StatusEffectApplyXOnCardPlayed>(data =>
                {
                    data.effectToApply = instance.TryGet<StatusEffectData>("Lose Emoomlin");
                    data.applyToFlags = StatusEffectApplyX.ApplyToFlags.Self;
                    data.queue = true; // let higher-priority effects happen first
                    data.targetMustBeAlive = false;

                    AddressableLoader.GetGroup<CardData>(nameof(CardData)).Where(card => card.startWithEffects.Any(effectStack => Traverse.Create(effectStack.data).Field("petPrefab").GetValue() is GameObject go && go != null)).Do(Debug.LogError);
                }
                )
            );

            assets.Add(new StatusEffectDataBuilder(instance)
              .Create<StatusEffectInstantLoseTrait>("Lose Emoomlin")
              .WithStackable(true)
              .SubscribeToAfterAllBuildEvent<StatusEffectInstantLoseTrait>(data =>
              {
                  data.traitToLose = instance.TryGet<TraitData>("Emoomlin");
              })
            );


            // Any effect that shows the pet
            // If it shouldn't give a free action, DO NOT use OnCardPlayedWithPet without any effect to apply (this will cause crashes)
            // ...instead use this custom StatusEffectShowPet
            assets.Add(new StatusEffectDataBuilder(instance)
                .Create<StatusEffectShowPet>("Show Emoomlin")
                .SubscribeToAfterAllBuildEvent<StatusEffectShowPet>(data =>
                    // lazy to make my own prefab
                    data.petPrefab = instance.TryGet<StatusEffectFreeAction>("Free Action").petPrefab

                )
            );

            // Unnecessary, but useful for testing ;3
            assets.Add(new StatusEffectDataBuilder(instance)
                .Create<StatusEffectTemporaryTrait>("Apply Emoomlin Trait")
                .WithIsKeyword(true)     // tells the game that this effect adds a keyword description
                .WithKeyword("emoomlin") // <- does nothing
                .SubscribeToAfterAllBuildEvent<StatusEffectTemporaryTrait>(data =>
                {
                    data.trait = instance.TryGet<TraitData>("Emoomlin");
                }
                )
            );



            return assets;
        }
    }
}


