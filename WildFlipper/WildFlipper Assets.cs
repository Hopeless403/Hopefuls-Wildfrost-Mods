using Deadpan.Enums.Engine.Components.Modding;
using UnityEngine;
using WildFlipper;
using static ExtraPopups.PopGroup;
using static WildFlipper.WildFlipperMod;

internal static class WildFlipperModHelpers
{
    public static void InitAssets() => assets = [
        .. EmoomlinBuilders(),

        new CardDataBuilder(instance)
        .CreateUnit(name:"IceForge", englishTitle:"Ice Forge", idleAnim:"FloatAnimationProfile")
        .IsPet((ChallengeData)null)
        .WithCardType("Clunker")
        .WithTitle("冰熔炉", SystemLanguage.ChineseSimplified)
        .WithTitle("冰熔爐", SystemLanguage.ChineseTraditional)
        .WithTitle("얼음 용광로", SystemLanguage.Korean)
        .WithTitle("アイスフォージ", SystemLanguage.Japanese)
        .WithText("While active, add <+{s0}><keyword=attack> to all allies and <-{s1}><keyword=attack> to all enemies", SystemLanguage.English)
        .WithText("在场时，所有友军<+{s0}><keyword=attack>，所有敌人<-{s1}><keyword=attack>", SystemLanguage.ChineseSimplified)
        .WithText("在場時，所有隊友<+{s0}><keyword=attack>，所有敵人<-{s1}><keyword=attack>", SystemLanguage.ChineseTraditional)
        .WithText("전장에 있는 동안, 모든 아군의 <keyword=attack><+{s0}>, 모든 적의 <keyword=attack><-{s1}>", SystemLanguage.Korean)
        .WithText("場にある間、すべての味方に<+{s0}><keyword=attack>を、すべての敵に<-{s1}><keyword=attack>を追加する", SystemLanguage.Japanese)
        .SetStats(null, null, 0)
        .SetSprites("IceForge_mainSprite.png", "IceForge_BG.png")
        .WithValue(190)         // Base gold as an enemy: 4-6
        .SubscribeToAfterAllBuildEvent(data =>
        {
                data.startWithEffects = new CardData.StatusEffectStacks[]
                {
                        new CardData.StatusEffectStacks(instance.Get<StatusEffectData>("While Active Increase Attack To Allies (No Desc)"), 2),
                        new CardData.StatusEffectStacks(instance.Get<StatusEffectData>("While Active Reduce Attack To Enemies (No Ping, No Desc)"), 2),
                        new CardData.StatusEffectStacks(instance.Get<StatusEffectData>("Scrap"), 2),
                };
                data.titleFallback = "Ice Forge";
        }),

            new StatusEffectDataBuilder(instance)
            .Create<StatusEffectOngoingMaxCounter>("Ongoing Reduce Max Counter")
            .SubscribeToAfterAllBuildEvent(s => (s as StatusEffectOngoingMaxCounter).reverse = true),

            new StatusEffectDataBuilder(instance)
            .Create<StatusEffectWhileActiveX>("While Active Reduce Max Counter To Allies")
            .WithText("While active, reduce the counter of allies")
            .SubscribeToAfterAllBuildEvent(d =>
            {
                var data = (StatusEffectWhileActiveX)d;
                data.effectToApply = instance.TryGet<StatusEffectOngoingMaxCounter>("Ongoing Reduce Max Counter");
                data.applyToFlags = StatusEffectApplyX.ApplyToFlags.Allies;
                //nameof(Card.AddPassiveEffectText)
            })
            ,
            new StatusEffectDataBuilder(instance)
            .Create<StatusEffectApplyXWhenCardMoves>("When Enemy Moves Apply Spice To Them")
            .WithText("When an enemy moves, apply <{a}><keyword=spice> to them")
            .SubscribeToAfterAllBuildEvent(d =>
            {
                var data = (StatusEffectApplyXWhenCardMoves)d;
                data.effectToApply = instance.TryGet<StatusEffectData>("Spice");
                data.applyToFlags = StatusEffectApplyX.ApplyToFlags.Target;
            })
            ,
            new StatusEffectDataBuilder(instance)
            .Create<StatusEffectApplyXOnHit>("On Hit Snow'd Target, Ink Ally Behind")
            .WithText("On Hit Snow'd Target, Ink Ally Behind")
            .SubscribeToAfterAllBuildEvent<StatusEffectApplyXOnHit>(data =>
            {
                data.effectToApply = instance.Get<StatusEffectData>("Null");
                data.applyConstraints = [new Scriptable<TargetConstraintHasStatus>(t => t.status = instance.Get<StatusEffectData>("Snow"))];
                data.applyToFlags = StatusEffectApplyX.ApplyToFlags.AllyBehind;
            })
            ,

            new StatusEffectDataBuilder(instance)
            .Create<StatusEffectUnshovable>("Unshovable")
            .WithText("<Unshovable>")
            .SubscribeToAfterAllBuildEvent(d =>
            {
            })
            ,

            new CardUpgradeDataBuilder(instance)
            .Create("Give Counter Charm")
            .WithType(CardUpgradeData.Type.Charm)
            .WithTitle("Counter Charm")
            .WithText("yada yada")
            .ChangeCounter(10)
            .WithSetCounter(true)
            /*.SubscribeToAfterAllBuildEvent(d =>
            {
                d
            })*/
            ,
            new StatusEffectDataBuilder(instance)
            .Create<StatusEffectRetain>("StatusEffectRetain")
            .WithText("When discarded, redraw instead")
            .SubscribeToAfterAllBuildEvent(d =>
            {
            })
            ,

            new StatusEffectDataBuilder(instance)
            .Create<StatusEffectApplyXWhenCardMoves>("Riptide")
            .WithText("When an enemy moves, deal <{a}> damage to them")
            .SubscribeToAfterAllBuildEvent(delegate (StatusEffectApplyXWhenCardMoves d)
            {
                var data = (StatusEffectApplyXWhenCardMoves)d;
                data.dealDamage = true;
                data.doesDamage = true;
                data.applyToFlags = StatusEffectApplyX.ApplyToFlags.Target;
            })
            ,


            new StatusEffectDataBuilder(instance)
            .Create<StatusEffectWhileActiveX>("While Active Increase Effects To Allies")
            .WithText("While active, boost allies' effects by {a}")
            .SubscribeToAfterAllBuildEvent(d =>
            {

                var data = (StatusEffectWhileActiveX)d;
                data.effectToApply = instance.TryGet<StatusEffectOngoingEffects>("Ongoing Increase Effects");
                data.applyToFlags = StatusEffectApplyX.ApplyToFlags.AlliesInRow;
                data.canBeBoosted = false;
                //nameof(Card.AddPassiveEffectText)
            })
            ,
            new StatusEffectDataBuilder(instance)
            .Create<StatusEffectApplyXWhenAllyAheadIsHit>("When Ally Ahead Is Hit Damage Attacker")
            .WithText("When Ally Ahead Is Hit Damage Attacker by {a}")
            .SubscribeToAfterAllBuildEvent(d =>
            {
                var data = (StatusEffectApplyXWhenAllyAheadIsHit)d;
                data.dealDamage = true;
                data.applyToFlags = StatusEffectApplyX.ApplyToFlags.Attacker;
            })
            ,

            new StatusEffectDataBuilder(instance)
            .Create<StatusEffectApplyXWhenHit>("Trigger Against Backlines When Hit")
            .WithText("When hit, trigger against backline units")
            .WithIsReaction(true)
            .SubscribeToAfterAllBuildEvent(d =>
            {
                var data = (StatusEffectApplyXWhenHit)d;
                data.descColorHex = "F99C61";   // trigger color
                data.effectToApply = instance.TryGet<StatusEffectData>("Trigger Against");
                data.applyToFlags = StatusEffectApplyX.ApplyToFlags.Enemies;
                data.applyConstraints = [new Scriptable<TargetConstraintInColumn>()];
            })
            ,

            //instance.StatusCopyBoxed<StatusEffectWhileInHandX>("While Active Add Equal Attack To Junk In Hand", "While In Hand Add Equal Attack To Junk In Hand"),

            new BlueBlobble().builder.Patch_ExtraPopups(
                ("Aimless", Left),
                ("Snow", Right)
                )
            .SubscribeToAfterAllBuildEvent(data => {})
            ,
            

            new StatusEffectDataBuilder(instance)
            .Create<StatusEffectInstantPhase>("Instant Next Phase Lump", data =>
            {
                data.nextPhase = instance.Get<CardData>("Lump");
            }),
            new StatusEffectDataBuilder(instance)
            .Create<StatusEffectInstantPhase>("Instant Next Phase SplitBoss2", data =>
            {
                data.nextPhase = instance.Get<CardData>("SplitBoss2");
            })
            ,
            new StatusEffectDataBuilder(instance)
            .Create<StatusEffectRecycleX>("Recycle Naked Gnome", data =>
            {
                data.cardToRecycle = "NakedGnome";
            })
            .WithText("Recycle NakedGnome")
            .Patch_IgnoreSilenced()
            ,
            new StatusEffectDataBuilder(instance)
            .Create<StatusEffectMultiHit>("Frenzy?", data =>
            {

            }).WithText("Has {a} frenzy"),

            new StatusEffectDataBuilder(instance)
                .Create<StatusEffectInstantEat>("healer", s =>
                {
                })
            .WithText("On kill, apply to enemies: instant heal <{a}>"),
            new StatusEffectDataBuilder(instance)
                .Create<StatusEffectInstantEat>("golder", s =>
                {
                })
            .WithText("On kill, apply to enemies: instant heal <{a}>"),
            new StatusEffectDataBuilder(instance)
                .Create<StatusEffectWhenCharmedRunScript>("charmy", s =>
                {
                    s.self = false;
                    s.ally = true;
                    s.applyToSelf = true;
                    s.scripts = [new Scriptable<CardScriptGiveRandomUpgrade>(t => {
                        t.fromPool = false;
                    })];
                    //AddressableLoader.GetGroup<TraitData>(nameof(TraitData)).ForEach(t => t.effects.Do(PatchIgnoreSilence.Patch_IgnoreSilenced));
                })
            .WithText("When another card is charmed, randomly gain an upgrade"),
            new StatusEffectDataBuilder(instance)
                .Create<StatusEffectBlockPlayAction>("action", s =>
                {
                    s.actionsNamesToBlock = [nameof(ActionRedraw)];
                })
            .WithText("When a crowned card is charmed, destroy it"),

            new StatusEffectDataBuilder(instance)
                .Create<StatusEffectApplyXOnKill>("Blobby", s =>
                {
                    s.applyToFlags = StatusEffectApplyX.ApplyToFlags.Target;
                    s.effectToApply = instance.Get<StatusEffectData>("golder");
                    s.targetConstraints = [];
                    s.targetMustBeAlive = false;
                })
            .WithText("On kill, apply to enemies: instant heal <{a}>"),
            new StatusEffectDataBuilder(instance)
            .Create<StatusEffectApplyXWhenAllyIsKilled>("When Ally Is Killed Activate Sacrifice Effects")
            .WithText("When an ally is killed, activate <Sacrifice> effects")
            .SubscribeToAfterAllBuildEvent(d =>
            {
                var data = (StatusEffectApplyXWhenAllyIsKilled)d;
                data.effectToApply = instance.TryGet<StatusEffectData>("Activate Sacrifice Effects For Other Team");
                // imagine the lower line doesn't exist and we're actually using the "good bonescraper" effect
                (data.effectToApply as StatusEffectInstantActivateSacrificeEffects).forOtherTeam = false;
                data.applyToFlags = StatusEffectApplyX.ApplyToFlags.Target;
                data.targetMustBeAlive = false;
            }),
            /*new GameModifierDataBuilder(instance)
            .Create("mody") // test code. you get it
            .WithTitle("")
            .WithDescription("")
            .WithBellSprite(instance.IconSprite)
            .WithDingerSprite(instance.IconSprite)
            .SubscribeToAfterAllBuildEvent(d =>
            {
                foreach (ClassData classData in AddressableLoader.GetGroup<ClassData>("ClassData"))
                {
                    foreach (RewardPool rewardPool in classData.rewardPools)
                    {
                        if (rewardPool == null || rewardPool.list == null)
                            continue;

                        if (rewardPool.name == "GeneralModifierPool" && !rewardPool.list.Contains(d))
                            rewardPool.list.Add(d);
                    }
                }
            })
            ,*/
            new KeywordDataBuilder(instance)
                .Create("DisplayJunk")
                .WithTitle("")
                .WithShow(true)
                .WithShowName(true)
                .WithDescription("<card=TailsTwo>"),

            new StatusEffectDataBuilder(instance)
                .Create<StatusEffectApplyXWhenYAppliedTo>("Sustained by Ink", s =>
                {
                    s.applyToFlags = StatusEffectApplyX.ApplyToFlags.Self;
                    s.effectToApply = instance.Get<StatusEffectData>("golder");
                    s.whenAppliedToFlags = StatusEffectApplyX.ApplyToFlags.Self;
                    s.whenAppliedTypes = ["ink", "shroom"];
                    s.instead = true;
                })
            .WithText($"When inked or shroomed, instead gain {{a}} gold and <keyword={Extensions.PrefixGUID("Display Junk", instance).ToLower()}?"),

            new StatusEffectDataBuilder(instance)
                .Create<StatusEffectApplyXWhenYAppliedTo>("Summon by ink", s =>
                {
                    s.applyToFlags = StatusEffectApplyX.ApplyToFlags.Self;
                    s.effectToApply = instance.Get<StatusEffectData>("Instant Summon TailsFour");
                    s.whenAppliedToFlags = StatusEffectApplyX.ApplyToFlags.Self;
                    s.whenAppliedTypes = ["ink", "shroom"];
                    s.instead = true;

                    s.applyEqualAmount = false;
                })
            .WithText("When inked or shroomed, instead gain {a} gold"),

            new StatusEffectDataBuilder(instance)
              .Create<StatusEffectApplyXOnKill>("On Kill Enemy (Snowed) Apply Their Snow To RandomEnemy")
              .WithStackable(true)
              .WithCanBeBoosted(false)
              .SubscribeToAfterAllBuildEvent(d =>
              {
                    var data = (StatusEffectApplyXOnKill)d;
                    data.effectToApply = instance.TryGet<StatusEffectData>("Snow");
                    data.applyConstraints = new TargetConstraint[]
                    {
                      new Scriptable<TargetConstraintOnBoard>(),
                      new Scriptable<TargetConstraintIsAlive>(),
                    };
                    data.applyEqualAmount = true;
                    data.contextEqualAmount = new Scriptable<ScriptableCurrentStatus>(t =>
                    {
                      t.statusType = "snow";
                    });
                    data.applyToFlags = StatusEffectApplyX.ApplyToFlags.RandomEnemy;
                    data.queue = true;
                    data.noTargetType = NoTargetType.NoTargetForStatus;
                    data.noTargetTypeArgs = new string[]
                    {
                      "<sprite name=snow>",
                    };
              })];
}