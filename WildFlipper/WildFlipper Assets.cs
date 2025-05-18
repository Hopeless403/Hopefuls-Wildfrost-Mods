using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Localization;
using WildFlipper;
using WildfrostHopeMod.Utils;
using WildfrostHopeMod.VFX;
using static ExtraPopups.PopGroup;
using static WildFlipper.WildFlipperMod;
using Extensions = Deadpan.Enums.Engine.Components.Modding.Extensions;

public class StatusEffectSanity : StatusEffectData
{
    int maximum = 9;
    int minimum = -9;
    public override IEnumerator RemoveStacks(int amount, bool removeTemporary)
    {
        var entity = new Entity();



        Events.OnEntityPing -= SfxSystem.EntityPing;
        entity.curveAnimator.Ping();
        Events.OnEntityPing += SfxSystem.EntityPing;



        count -= amount;
        if (removeTemporary)
        {
            temporary -= amount;
        }

        count = Mathf.Max(minimum, count);

        target.PromptUpdate();
        yield break;
    }
    public virtual void GainAttack()
    {
        target.damage.current += GetAmount();
        target.PromptUpdate();
    }
}


public class StatusEffectInstantReplace : StatusEffectInstant
{
    public string typeToReplace = "snow";
    public StatusEffectData effectToApply;
    public override IEnumerator Process()
    {
        
        StatusEffectData statusToChange = target.FindStatus(typeToReplace);
        if (statusToChange)
        {
            Debug.LogError($"Changing coutn from {count} to {statusToChange.count}");
            count = statusToChange.count;
            yield return StatusEffectSystem.Apply(target, applier, effectToApply, GetAmount());
            yield return statusToChange.RemoveStacks(GetAmount(), false);
        }
        base.Process();
    }
}
public class StatusEffectInstantShuffle : StatusEffectInstant
{
    public Targets.Flag targetFlags;

    public float delayAfter = 0.13f;
    public TargetConstraint[] applyConstraints = [];
    public SelectScript<Entity> selectScript;

    public override IEnumerator Process()
    {
        Debug.Log($"{this} Running...");
        List<Entity> list = Targets.Get(target, targetFlags, this, applyConstraints)
            .Where(entity => entity.actualContainers?.Any() ?? false).ToList();

        Debug.LogWarning($"GOT for {targetFlags}, {Targets.Get(target, targetFlags, this, applyConstraints).Join()}");
        if (selectScript)
            list = selectScript.Run(list);
        Debug.LogWarning($"GOT {list.Join()}");
        if (list.Count <= 0)
            yield break;

        List<CardContainer> containers = list.Select(entity => entity.actualContainers.FirstOrDefault()).ToList();
        list.Shuffle();
        
        foreach (CardContainer cardContainer in containers)
        {
            Entity entityToMove = list[0];
            list.RemoveAt(0);
            yield return Sequences.CardMove(entityToMove, [cardContainer]);
        }
        double num = target.curveAnimator.Ping();
        yield return Sequences.Wait(delayAfter);
        yield return Remove();
    }
}

[HarmonyPatch]
public class PatchUnplaceableCards
{
    [HarmonyPatch(typeof(UnplayableCrownCardSystem), nameof(UnplayableCrownCardSystem.CardIsBlocked))]
    public static bool Postfix(bool wasBlocked, Entity card)
    {
        if (wasBlocked || card.data.playType != Card.PlayType.Place) return wasBlocked;

        for (int row = 0; row < References.Battle.GetRows(card.owner).Count; row++)
        {
            if (References.Battle.CanDeploy(card, row, out _))
                return false;
        }
        return true;
    }
}


// On the board, "container" refers to a row.
// Not that it checks the shuffle is valid (see bosses)
public class StatusEffectInstantShuffleInContainer : StatusEffectInstant
{
    public override IEnumerator Process()
    {
        if (target.containers != null && target.containers.Any())
        {
            CardContainer container = target.containers.RandomItem();
            foreach (Entity entity in container.ToArray().InRandomOrder())
            {
                yield return Sequences.CardMove(entity, [container], tweenAll: false);/*
                container.Remove(entity);
                container.Insert(0, entity);*/
            }
            container.TweenChildPositions();
        }

        yield return Remove();
    }
}


public class StatusEffectInstantGainCrown : StatusEffectInstant
{
    public string customCrown;
    public override IEnumerator Process()
    {
        if (!target.data.HasCrown)
        {
            CardUpgradeData crownData = AddressableLoader.Get<CardUpgradeData>("CardUpgradeData", customCrown.IsNullOrWhitespace() ? "Crown" : customCrown);
            if (crownData && crownData.CanAssign(target))
                crownData.Clone().Assign(target);
        }
        return base.Process();
    }
}
public class StatusEffectGiveCrownIfSummoned : StatusEffectData
{
    public override void Init()
    {
        Events.OnEntitySummoned += EntitySummoned;
    }
    public void OnDestroy()
    {
        Events.OnEntitySummoned -= EntitySummoned;
    }

    public void EntitySummoned(Entity entity, Entity summonedBy)
    {
        if (entity != target) return;
        ActionQueue.Stack(new ActionSequence(SummnoedRoutine()) { note = $"Give crown to {target}" });
    }
    
    public IEnumerator SummnoedRoutine()
    {
        var crown = AddressableLoader.Get<CardUpgradeData>(nameof(CardUpgradeData), "Crown").Clone();
        Debug.LogWarning(crown);
        yield return crown.Assign(target);
        yield return Remove();
    }
}

public class StatusEffectOngoingFreeAction : StatusEffectOngoing
{
    public override void Init()
    {
        Events.OnActionPerform += FreeAction;
    }
    public void OnDestroy()
    {
        Events.OnActionPerform -= FreeAction;
    }
    public void FreeAction(PlayAction action) => References.Player.freeAction = true;
}

internal static class WildFlipperModHelpers
{
    public static void InitAssets() => assets = [
        .. EmoomlinBuilders(),

        new StatusEffectDataBuilder(instance)
        .Create<StatusEffectGiveCrownIfSummoned>("Gain Crown")
        .SubscribeToAfterAllBuildEvent<StatusEffectGiveCrownIfSummoned>(data =>{
            }),

        new StatusEffectDataBuilder(instance)
        .Create<StatusEffectInstantShuffleInContainer>("Shuffle Current Container"),

        new StatusEffectDataBuilder(instance)
        .Create<StatusEffectInstantShuffle>("Shuffle Hand, Ally, And Self")
        .SubscribeToAfterAllBuildEvent<StatusEffectInstantShuffle>(data => {
            data.targetFlags = Targets.Flag.Hand | Targets.Flag.Allies | Targets.Flag.Self;
        }),


        new StatusEffectDataBuilder(instance)
        .Create<StatusEffectInstantReplace>("Replace Snow With Spice")
        .WithType("hope.replace")
        .WithIsStatus(true)
        .SubscribeToAfterAllBuildEvent<StatusEffectInstantReplace>(data => {
            data.typeToReplace = "snow";
            data.effectToApply = instance.TryGet<StatusEffectData>("Spice");
        }),
        new StatusEffectDataBuilder(instance)
        .Create<StatusEffectApplyXWhenYAppliedTo>("When Snow Replaced, Trigger?")
        .SubscribeToAfterAllBuildEvent<StatusEffectApplyXWhenYAppliedTo>(data => {
            data.applyEqualAmount = true;
            data.whenAppliedTypes = ["hope.replace"];
            data.whenAppliedToFlags = ~(StatusEffectApplyX.ApplyToFlags)0;
            data.effectToApply = instance.TryGet<StatusEffectData>("Block");
            data.applyToFlags = StatusEffectApplyX.ApplyToFlags.Self;
        }),

    new StatusEffectDataBuilder(instance)
    .Create<StatusEffectApplyXWhenXAppliedTo>("When Any Status Applied, Reapply To Allies")
    .Patch_IgnoreSilenced()
    .WithText("When any status is applied, apply an <equal amount> to allies", SystemLanguage.English)
    .WithStackable(false)
    .WithCanBeBoosted(false)
    .SubscribeToAfterAllBuildEvent<StatusEffectApplyXWhenXAppliedTo>(data =>
    {
        // Temporary effectToApply is required to prevent errors
        data.effectToApply = instance.TryGet<StatusEffectData>("Snow");
        data.applyToFlags = StatusEffectApplyX.ApplyToFlags.Allies;
        data.waitForAnimationEnd = true;
        data.doPing = false; // up to you

        // Avoid queueing this effect if possible...
        data.queue = false;

        data.whenAnyApplied = true;
        data.whenAppliedToFlags = StatusEffectApplyX.ApplyToFlags.Self;
        data.applyEqualAmount = true;
    }),

    new StatusEffectDataBuilder(instance)
        .Create<StatusEffectTemporaryFlipped>("Hoverable Flipped State")
        .WithText("Flipped ya", SystemLanguage.English)
        .WithStackable(true)
        .WithCanBeBoosted(false),

    new StatusEffectDataBuilder(instance)
        .Create<StatusEffectWhileActiveX>("While Active Flip Cards In Hand")
        .WithText("While active, flip cards in hand")
        .SubscribeToAfterAllBuildEvent<StatusEffectWhileActiveX>(data =>
        {
            data.effectToApply = instance.TryGet<StatusEffectTemporaryFlipped>("Hoverable Flipped State");
            data.applyToFlags = StatusEffectApplyX.ApplyToFlags.Hand;
        }),

    new StatusEffectDataBuilder(instance)
        .Create<StatusEffectOngoingFreeAction>("Ongoing Free Action")
        .WithText("Free actions for all", SystemLanguage.English),

    new StatusEffectDataBuilder(instance)
        .Create<StatusEffectWhileActiveX>("While Active Ongoing Free Action")
        .WithText("While active, turns are free")
        .SubscribeToAfterAllBuildEvent<StatusEffectWhileActiveX>(data =>
        {
            data.effectToApply = instance.TryGet<StatusEffectOngoingFreeAction>("Ongoing Free Action");
            data.applyToFlags = StatusEffectApplyX.ApplyToFlags.Self;
            //~StatusEffectApplyX.ApplyToFlags.None;
        }),

        new StatusEffectDataBuilder(instance)
  .Create<StatusEffectInstantMultiple>("Sacrifice Ally & Summon BlackGoat")
  .WithStackable(false)
  .WithCanBeBoosted(false)
  .WithOffensive(true)     // As an attack effect, this is treated as a debuff
  .WithMakesOffensive(false)   // As a starting effect, its entity should target allies
  .WithDoesDamage(true)     // Its entity can activate "On kill" effects with this effect, eg for Bling Charm
  .SubscribeToAfterAllBuildEvent<StatusEffectInstantMultiple>(data =>
  {
    data.effects = new StatusEffectInstant[]
    {
      instance.TryGet<StatusEffectInstantSacrifice>("Sacrifice Ally"),
      instance.TryGet<StatusEffectInstantSummon>("Instant Summon BlackGoat"),
    };
  }),


        (
new KeywordDataBuilder(instance)
.Create("bleed")
.WithTitle("Bleed")
.WithTitleColour(new Color(0.85f, 0.44f, 0.44f))
.WithDescription("Take damage after triggering| Dissapears when trigger")
.WithNoteColour(new Color(0.85f, 0.44f, 0.85f))
.WithBodyColour(new Color(0.2f, 0.5f, 0.5f))
),
        (
new StatusEffectDataBuilder(instance)
.Create<StatusEffectSnow>("Bleed Effect")
.WithIsStatus(true)
.WithVisible(true)
.Subscribe_WithStatusIcon("bleed icon") // TODO: Put whatever you want to name the icon builder
),
        (
new StatusIconBuilder(instance)
.Create(name: "bleed icon",     // Used in StatusEffectDataBuilder.Subscribe_WithStatusIcon()
    statusType: "abogadouuu.wildfrost.limbusmod.bleed",
    instance.IconPath)

.WithIconGroupName(StatusIconBuilder.IconGroups.health)

// Icons without text can skip these two altogether
.WithTextColour(new Color(0.1f, 0f, 0f))   // Reddish-black      
.WithTextShadow(new Color(1f, 1f, 0f))     // Opaque yellow shadow

.WithTextboxSprite()                                    // This version reuses the main sprite for the textbox

.WithKeywords(iconKeywordOrNull: "bleed") // the "icon keyword" will be adjusted to show the icon's textbox sprite
),


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
        //.SetSprites("Love.png", "IceForge_BG.png")
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
        new CardDataBuilder(instance)
        .CreateUnit(name:"IceForge2", englishTitle:"Ice Forge2", idleAnim:"FloatAnimationProfile")
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
        //.SetSprites("Love2.png", "IceForge_BG.png")
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
            .Create<StatusEffectSanity>("When Enemy Moves Do something???")
            .SubscribeToAfterAllBuildEvent<StatusEffectSanity>(data =>
            {
                data.textKey = new LocalizedString();
                Debug.LogWarning("IsEmpty???");
                Debug.LogWarning(data.textKey.IsEmpty);
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