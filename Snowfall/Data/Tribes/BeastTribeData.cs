// Decompiled with JetBrains decompiler
// Type: Snowfall2.Data.Tribes.BeastTribeData
// Assembly: Snowfall, Version=0.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 26AFE777-3FAB-4D6F-AF6C-494837402D4A
// Assembly location: C:\Users\harri\AppData\Local\Temp\Temp1_Snowfall_-_Alpha_2.1.2.zip\Snowfall.dll

using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using Snowfall2.Classes.ScriptableAmounts;
using Snowfall2.Classes.StatusEffects;
using Snowfall2.Classes.TargetModes;
using Snowfall2.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Snowfall2.Data.Tribes
{
  public static class BeastTribeData
  {
    private static readonly List<CardData> TribeItems = new List<CardData>();
    private static readonly List<CardData> TribeUnits = new List<CardData>();
    private static readonly List<CardData> TribeDeckItems = new List<CardData>();

    public static void Load(
      WildfrostMod mod,
      List<CardData> generalUnits,
      List<CardData> generalItems)
    {
      BeastTribeData.LoadStatusEffectsBeast(mod);
      BeastTribeData.LoadCardsBeast(mod);
      BeastTribeData.LoadMoko(mod, generalUnits, generalItems);
    }

    public static void Unload()
    {
      BeastTribeData.TribeItems.Clear();
      BeastTribeData.TribeUnits.Clear();
      BeastTribeData.TribeDeckItems.Clear();
    }

    private static void LoadMoko(
      WildfrostMod mod,
      List<CardData> generalUnits,
      List<CardData> generalItems)
    {
      BeastTribeData.LoadStatusEffectsMoko(mod);
      BeastTribeData.LoadCardsMoko(mod);
      BeastTribeData.LoadTribeMoko(mod, generalUnits, generalItems);
    }

    private static void LoadCardsBeast(WildfrostMod mod)
    {
      CardData cardData1 = mod.Get<CardData>("Sporkypine");
      CardData cardData2 = new CardDataBuilder(mod).CreateUnit("PorkypineAlly", "Porkypine").SetSprites(cardData1.mainSprite, cardData1.backgroundSprite).SetStats(new int?(6), new int?(2), 4).WithBloodProfile(cardData1.bloodProfile).WithIdleAnimationProfile(cardData1.idleAnimationProfile).SetTraits(cardData1.traits.ToArray()).Register<CardData, CardDataBuilder>();
      CardData cardData3 = mod.Get<CardData>("Noodle");
      CardData cardData4 = new CardDataBuilder(mod).Create("GrombleAlly").WithTitle("Gromble").WithCardType().AsUnit().SetSprites(cardData3.mainSprite, cardData3.backgroundSprite).SetStats(new int?(12), new int?(2), 2).WithBloodProfile(cardData3.bloodProfile).WithIdleAnimationProfile(cardData3.idleAnimationProfile).SetTraits(SFUtils.CreateTraitStacks("Upgradeable", 1, mod)).Register<CardData, CardDataBuilder>();
      CardData cardData5 = mod.Get<CardData>("Smakk");
      new CardDataBuilder(mod).CreateUnit("BigfootAlly", "Bigfoot").SetSprites(cardData5.mainSprite, cardData5.backgroundSprite).SetStats(new int?(12), new int?(5), 4).WithBloodProfile(cardData5.bloodProfile).WithIdleAnimationProfile(cardData5.idleAnimationProfile).SetTraits(cardData5.traits.ToArray()).Register<CardData, CardDataBuilder>();
      CardData cardData6 = mod.Get<CardData>("SnormWorm");
      CardData cardData7 = new CardDataBuilder(mod).CreateUnit("WinterWormAlly", "Winter Worm").SetSprites(cardData6.mainSprite, cardData6.backgroundSprite).SetStats(new int?(10), new int?(1), 6).WithBloodProfile(cardData6.bloodProfile).WithIdleAnimationProfile(cardData6.idleAnimationProfile).SetStartWithEffect(SFUtils.CreateSEStacks("When Hit Gain Attack To Self (No Ping)", 1, mod), SFUtils.CreateSEStacks("LoseAttackWhenHealed", 5, mod)).Register<CardData, CardDataBuilder>();
      CardData cardData8 = mod.Get<CardData>("OobaBear");
      CardData cardData9 = new CardDataBuilder(mod).CreateUnit("OobaBearAlly", "Ooba Bear").SetSprites(cardData8.mainSprite, cardData8.backgroundSprite).SetStats(new int?(6), new int?(4), 5).WithBloodProfile(cardData8.bloodProfile).WithIdleAnimationProfile(cardData8.idleAnimationProfile).SetStartWithEffect(SFUtils.CreateSEStacks("When Hit Apply Snow To Attacker", 1, mod)).Register<CardData, CardDataBuilder>();
      CardData cardData10 = mod.Get<CardData>("BulbHead");
      CardData cardData11 = new CardDataBuilder(mod).CreateUnit("BulbheadAlly", "Bulbhead").SetSprites(cardData10.mainSprite, cardData10.backgroundSprite).SetStats(new int?(8), new int?(0), 5).WithBloodProfile(cardData10.bloodProfile).WithIdleAnimationProfile(cardData10.idleAnimationProfile).SetAttackEffect(SFUtils.CreateSEStacks("Shroom", 2, mod)).SetTraits(SFUtils.CreateTraitStacks("Barrage", 1, mod)).Register<CardData, CardDataBuilder>();
      CardData cardData12 = mod.Get<CardData>("JabJoat");
      CardData cardData13 = new CardDataBuilder(mod).CreateUnit("JabJoatAlly", "Jab Joat").SetSprites(cardData12.mainSprite, cardData12.backgroundSprite).SetStats(new int?(7), new int?(1), 3).WithBloodProfile(cardData12.bloodProfile).WithIdleAnimationProfile(cardData12.idleAnimationProfile).SetStartWithEffect(SFUtils.CreateSEStacks("MultiHit", 1, mod)).Register<CardData, CardDataBuilder>();
      CardData cardData14 = mod.Get<CardData>("Wally");
      CardData cardData15 = new CardDataBuilder(mod).CreateUnit("RockhogAlly", "Rockhog").SetSprites(cardData14.mainSprite, cardData14.backgroundSprite).SetStats(new int?(3), new int?(4), 6).WithBloodProfile(cardData14.bloodProfile).WithIdleAnimationProfile(cardData14.idleAnimationProfile).SetStartWithEffect(SFUtils.CreateSEStacks("WhileActiveAddFrenzyToAlliesInRow", 1, mod)).Register<CardData, CardDataBuilder>();
      CardData cardData16 = mod.Get<CardData>("Smackgoon");
      CardData cardData17 = new CardDataBuilder(mod).CreateUnit("GogongAlly", "Gogong").SetSprites(cardData16.mainSprite, cardData16.backgroundSprite).SetStats(new int?(8), new int?(2)).WithBloodProfile(cardData16.bloodProfile).WithIdleAnimationProfile(cardData16.idleAnimationProfile).SetStartWithEffect(SFUtils.CreateSEStacks("ImmuneToSnow", 1, mod), SFUtils.CreateSEStacks("HealWhenEnemySnowed", 2, mod)).SetTraits(SFUtils.CreateTraitStacks("Smackback", 1, mod)).Register<CardData, CardDataBuilder>();
      CardData cardData18 = mod.Get<CardData>("MonkeyKing");
      CardData cardData19 = mod.Get<CardData>("PepperWitch");
      CardData cardData20 = new CardDataBuilder(mod).CreateUnit("Pipper", "Pipper").SetSprites(SFUtils.LoadSprite(mod.ModDirectory, "Images\\Cards\\Allies\\Pipper"), cardData19.backgroundSprite).SetStats(new int?(4), new int?(1), 4).WithBloodProfile(cardData18.bloodProfile).WithIdleAnimationProfile(cardData18.idleAnimationProfile).SetStartWithEffect(SFUtils.CreateSEStacks("SpiceSteal", 1, mod)).Register<CardData, CardDataBuilder>();
      CardData cardData21 = new CardDataBuilder(mod).CreateUnit("Charepi", "Charepi").SetSprites(SFUtils.LoadSprite(mod.ModDirectory, "Images\\Cards\\Allies\\Charepi"), cardData19.backgroundSprite).SetStats(new int?(7), new int?(2), 4).WithBloodProfile(cardData18.bloodProfile).WithIdleAnimationProfile(cardData18.idleAnimationProfile).SetTraits(SFUtils.CreateTraitStacks("Pincer", 1, mod)).Register<CardData, CardDataBuilder>();
      CardData cardData22 = mod.Get<CardData>("Sno");
      CardData cardData23 = new CardDataBuilder(mod).Create("Cubbu").WithTitle("Cubbu").WithCardType().AsUnit().SetSprites(SFUtils.LoadSprite(mod.ModDirectory, "Images\\Cards\\Allies\\Cubbu"), cardData22.backgroundSprite).SetStats(new int?(6), new int?(2), 4).WithBloodProfile(cardData22.bloodProfile).WithIdleAnimationProfile(cardData22.idleAnimationProfile).SetAttackEffect(SFUtils.CreateSEStacks("Snow", 1, mod)).SetTraits(SFUtils.CreateTraitStacks("Upgradeable", 1, mod)).Register<CardData, CardDataBuilder>();
      new CardDataBuilder(mod).CreateUnit("GrizzleAlly", "Grizzle").SetSprites(cardData22.mainSprite, cardData22.backgroundSprite).SetStats(new int?(16), new int?(4), 5).WithBloodProfile(cardData22.bloodProfile).WithIdleAnimationProfile(cardData22.idleAnimationProfile).SetStartWithEffect(SFUtils.CreateSEStacks("ImmuneToSnow", 1, mod), SFUtils.CreateSEStacks("PostAttackBreakSnowShield", 1, mod)).SetAttackEffect(SFUtils.CreateSEStacks("Snow", 4, mod)).SetTraits(cardData22.traits.ToArray()).Register<CardData, CardDataBuilder>();
      CardData cardData24 = mod.Get<CardData>("Snowbo");
      CardData cardData25 = new CardDataBuilder(mod).CreateUnit("Pengickle", "Pengickle").SetSprites(SFUtils.LoadSprite(mod.ModDirectory, "Images\\Cards\\Allies\\Pengickle"), cardData24.backgroundSprite).SetStats(new int?(3), counter: 5).WithBloodProfile(cardData24.bloodProfile).WithIdleAnimationProfile(cardData24.idleAnimationProfile).SetStartWithEffect(SFUtils.CreateSEStacks("SnowEqualToHealth", 1, mod)).SetAttackEffect(SFUtils.CreateSEStacks("HiddenSnow", 0, mod)).Register<CardData, CardDataBuilder>();
      CardData cardData26 = mod.Get<CardData>("SnowKnight");
      CardData cardData27 = new CardDataBuilder(mod).CreateUnit("Sniburr", "Sniburr").SetSprites(SFUtils.LoadSprite(mod.ModDirectory, "Images\\Cards\\Allies\\Sniburr"), cardData26.backgroundSprite).SetStats(new int?(8), new int?(4), 5).WithBloodProfile(cardData26.bloodProfile).WithIdleAnimationProfile(cardData26.idleAnimationProfile).SetStartWithEffect(SFUtils.CreateSEStacks("SnowTargetsInRowOtherThanTarget", 2, mod)).SetTraits(SFUtils.CreateTraitStacks("Longshot", 1, mod)).Register<CardData, CardDataBuilder>();
      CardData cardData28 = mod.Get<CardData>("Minimoko");
      CardData cardData29 = new CardDataBuilder(mod).CreateUnit("MinimokoAlly", "Minimoko").SetSprites(cardData28.mainSprite, cardData28.backgroundSprite).SetStats(new int?(6), new int?(1), 2).WithBloodProfile(cardData28.bloodProfile).WithIdleAnimationProfile(cardData28.idleAnimationProfile).SetTraits(SFUtils.CreateTraitStacks("Upgradeable", 1, mod)).SetStartWithEffect(cardData28.startWithEffects).Register<CardData, CardDataBuilder>();
      CardData cardData30 = mod.Get<CardData>("Makoko");
      new CardDataBuilder(mod).CreateUnit("MakokoAlly", "Makoko").SetSprites(cardData30.mainSprite, cardData30.backgroundSprite).SetStats(new int?(8), new int?(1), 1).WithBloodProfile(cardData30.bloodProfile).WithIdleAnimationProfile(cardData30.idleAnimationProfile).SetStartWithEffect(cardData30.startWithEffects).Register<CardData, CardDataBuilder>();
      CardData cardData31 = new CardDataBuilder(mod).CreateItem("FrostbiteGem", "Frostbite Gem").CanPlayOnHand(false).WithValue(50).SetSprites(SFUtils.LoadSprite(mod.ModDirectory, "Images\\Cards\\Items\\FrostbiteGem"), mod.Get<CardData>("IceShard").backgroundSprite).WithBloodProfile(mod.Get<CardData>("IceShard").bloodProfile).WithIdleAnimationProfile(mod.Get<CardData>("IceShard").idleAnimationProfile).SetAttackEffect(SFUtils.CreateSEStacks("Frostbite", 1, mod)).Register<CardData, CardDataBuilder>();
      CardData cardData32 = new CardDataBuilder(mod).CreateItem("Frostblade", "Frostblade").CanPlayOnHand(false).WithValue(50).SetSprites(SFUtils.LoadSprite(mod.ModDirectory, "Images\\Cards\\Items\\Frostblade"), mod.Get<CardData>("IceShard").backgroundSprite).SetDamage(new int?(1)).WithBloodProfile(mod.Get<CardData>("Dart").bloodProfile).WithIdleAnimationProfile(mod.Get<CardData>("Dart").idleAnimationProfile).SetStartWithEffect(SFUtils.CreateSEStacks("ExcessFrost", 1, mod)).SetAttackEffect(SFUtils.CreateSEStacks("Frost", 2, mod)).Register<CardData, CardDataBuilder>();
      CardData cardData33 = new CardDataBuilder(mod).CreateItem("Snowcone", "Snowcone").CanPlayOnHand(false).WithValue(50).SetSprites(SFUtils.LoadSprite(mod.ModDirectory, "Images\\Cards\\Items\\Snowcone"), mod.Get<CardData>("PinkberryJuice").backgroundSprite).WithBloodProfile(mod.Get<CardData>("SnowStick").bloodProfile).WithIdleAnimationProfile(mod.Get<CardData>("SnowStick").idleAnimationProfile).SetAttackEffect(SFUtils.CreateSEStacks("Snow", 1, mod), SFUtils.CreateSEStacks("Heal", 4, mod)).Register<CardData, CardDataBuilder>();
      BeastTribeData.TribeUnits.AddRange((IEnumerable<CardData>) new CardData[14]
      {
        cardData2,
        cardData7,
        cardData9,
        cardData11,
        cardData13,
        cardData15,
        cardData17,
        cardData20,
        cardData25,
        cardData27,
        cardData29,
        cardData23,
        cardData4,
        cardData21
      });
      BeastTribeData.TribeItems.AddRange((IEnumerable<CardData>) new CardData[3]
      {
        cardData31,
        cardData32,
        cardData33
      });
      BeastTribeData.TribeDeckItems.AddRange((IEnumerable<CardData>) new CardData[4]
      {
        cardData31,
        cardData32,
        cardData32,
        cardData33
      });
    }

    private static void LoadStatusEffectsBeast(WildfrostMod mod)
    {
      new StatusEffectDataBuilder(mod).Create<StatusEffectInstantMultiple>("Frostbite").WithText("Reduce target's <keyword=health> and <keyword=attack> by <{a}>").FreeModify<StatusEffectInstantMultiple>((Action<StatusEffectInstantMultiple>) (se =>
      {
        se.effects = new StatusEffectInstant[2]
        {
          mod.Get<StatusEffectData>("Reduce Max Health") as StatusEffectInstant,
          mod.Get<StatusEffectData>("Reduce Attack") as StatusEffectInstant
        };
        se.targetConstraints = new TargetConstraint[2]
        {
          (TargetConstraint) SFUtils.CreateTargetConstraint<TargetConstraintDoesAttack>(),
          (TargetConstraint) SFUtils.CreateTargetConstraint<TargetConstraintHasHealth>()
        };
        se.canBeBoosted = true;
        se.type = "";
      })).Register<StatusEffectData, StatusEffectDataBuilder>();
      new StatusEffectDataBuilder(mod).Create<StatusEffectBonusDamageEqualToXOnTarget>("ExcessFrost").WithText("Deal additional <keyword=attack> equal to target's <keyword=frost>").FreeModify<StatusEffectBonusDamageEqualToXOnTarget>((Action<StatusEffectBonusDamageEqualToXOnTarget>) (se =>
      {
        se.effectType = "frost";
        se.targetConstraints = Array.Empty<TargetConstraint>();
        se.type = "";
      })).Register<StatusEffectData, StatusEffectDataBuilder>();
      StatusEffectData instantBreakSnowShield = new StatusEffectDataBuilder(mod).Create<StatusEffectInstantLoseX>("InstantBreakSnowShield").FreeModify<StatusEffectInstantLoseX>((Action<StatusEffectInstantLoseX>) (se =>
      {
        se.statusToLose = mod.Get<StatusEffectData>("ImmuneToSnow");
        se.targetConstraints = Array.Empty<TargetConstraint>();
        se.type = "";
      })).Register<StatusEffectData, StatusEffectDataBuilder>();
      new StatusEffectDataBuilder(mod).Create<StatusEffectApplyXPostAttack>("PostAttackBreakSnowShield").WithText("After attacking, break the target's <keyword=snow> shield if they have one").FreeModify<StatusEffectApplyXPostAttack>((Action<StatusEffectApplyXPostAttack>) (se =>
      {
        se.effectToApply = instantBreakSnowShield;
        se.applyToFlags = StatusEffectApplyX.ApplyToFlags.Target;
        se.applyConstraints = new TargetConstraint[1]
        {
          (TargetConstraint) SFUtils.CreateTargetConstraint<TargetConstraintHasStatus>(status: mod.Get<StatusEffectData>("ImmuneToSnow"))
        };
        se.targetConstraints = Array.Empty<TargetConstraint>();
        se.type = "";
      })).Register<StatusEffectData, StatusEffectDataBuilder>();
      new StatusEffectDataBuilder(mod).Create<StatusEffectApplyXWhenAlliesAttack>("SpiceSteal").WithText("When something is hit by an ally, apply <{a}> <keyword=spice> to self").FreeModify<StatusEffectApplyXWhenAlliesAttack>((Action<StatusEffectApplyXWhenAlliesAttack>) (se =>
      {
        se.effectToApply = mod.Get<StatusEffectData>("Spice");
        se.applyToFlags = StatusEffectApplyX.ApplyToFlags.Self;
        se.targetConstraints = new TargetConstraint[1]
        {
          (TargetConstraint) SFUtils.CreateTargetConstraint<TargetConstraintIsUnit>()
        };
        se.applyConstraints = new TargetConstraint[1]
        {
          (TargetConstraint) SFUtils.CreateTargetConstraint<TargetConstraintOnBoard>()
        };
        se.canBeBoosted = true;
      })).Register<StatusEffectData, StatusEffectDataBuilder>().CopyWithSESwapped<StatusEffectData>(mod, "spice", "shell");
      new StatusEffectDataBuilder(mod).Create<StatusEffectApplyXInstant>("HiddenSnow").FreeModify<StatusEffectApplyXInstant>((Action<StatusEffectApplyXInstant>) (se =>
      {
        se.effectToApply = mod.Get<StatusEffectData>("Snow");
        se.applyToFlags = StatusEffectApplyX.ApplyToFlags.Self;
        se.targetConstraints = Array.Empty<TargetConstraint>();
        se.applyConstraints = Array.Empty<TargetConstraint>();
        se.type = "";
      })).Register<StatusEffectData, StatusEffectDataBuilder>();
      new StatusEffectDataBuilder(mod).Create<StatusEffectApplyXPostAttack>("SnowEqualToHealth").WithText("Apply <keyword=snow> equal to current <keyword=health>").FreeModify<StatusEffectApplyXPostAttack>((Action<StatusEffectApplyXPostAttack>) (se =>
      {
        se.effectToApply = mod.Get<StatusEffectData>("Snow");
        se.applyToFlags = StatusEffectApplyX.ApplyToFlags.Target;
        se.targetConstraints = Array.Empty<TargetConstraint>();
        se.applyConstraints = Array.Empty<TargetConstraint>();
        se.scriptableAmount = (ScriptableAmount) SFUtils.CreateScriptableAmount<ScriptableCurrentHealth>();
        se.type = "";
      })).Register<StatusEffectData, StatusEffectDataBuilder>();
      new StatusEffectDataBuilder(mod).Create<StatusEffectInstantApplyXToCustom>("SnowTargetsInRowOtherThanTargetInner").FreeModify<StatusEffectInstantApplyXToCustom>((Action<StatusEffectInstantApplyXToCustom>) (se =>
      {
        se.effectToApply = mod.Get<StatusEffectData>("Snow");
        se.customTargetFlags = StatusEffectInstantApplyXToCustom.CustomTargetFlags.AlliesInFront;
        se.targetConstraints = Array.Empty<TargetConstraint>();
        se.canBeBoosted = true;
        se.type = "";
      })).Register<StatusEffectData, StatusEffectDataBuilder>().ApplyBy<StatusEffectApplyXOnHit>(mod, "SnowTargetsInRowOtherThanTarget", "Apply <{a}> <keyword=snow> to enemies in front of target", StatusEffectApplyX.ApplyToFlags.Target);
      StatusEffectData statusEffectData1 = new StatusEffectDataBuilder(mod).Create<StatusEffectChangeTargetMode>("PincerEffect").FreeModify<StatusEffectChangeTargetMode>((Action<StatusEffectChangeTargetMode>) (se =>
      {
        se.targetMode = (TargetMode) ScriptableObject.CreateInstance<TargetModePincer>();
        se.targetConstraints = Array.Empty<TargetConstraint>();
        se.canBeBoosted = false;
        se.type = "";
      })).Register<StatusEffectData, StatusEffectDataBuilder>();
      new StatusEffectDataBuilder(mod).Create<StatusEffectApplyXWhenHealed>("LoseAttackWhenHealed").WithText("When healed, reduce <keyword=attack> by <{a}>").FreeModify<StatusEffectApplyXWhenHealed>((Action<StatusEffectApplyXWhenHealed>) (se =>
      {
        se.effectToApply = mod.Get<StatusEffectData>("ReduceAttack");
        se.applyToFlags = StatusEffectApplyX.ApplyToFlags.Self;
        se.applyConstraints = Array.Empty<TargetConstraint>();
        se.targetConstraints = Array.Empty<TargetConstraint>();
        se.canBeBoosted = true;
        se.type = "";
      })).Register<StatusEffectData, StatusEffectDataBuilder>();
      StatusEffectData statusEffectData2 = new StatusEffectDataBuilder(mod).Create<StatusEffectWhileActiveX>("WhileActiveAddFrenzyToAlliesInRow").WithText("While active, add <x{a}> <keyword=frenzy> to allies in the row").FreeModify<StatusEffectWhileActiveX>((Action<StatusEffectWhileActiveX>) (se =>
      {
        se.effectToApply = mod.Get<StatusEffectData>("MultiHit");
        se.applyToFlags = StatusEffectApplyX.ApplyToFlags.AlliesInRow;
        se.applyConstraints = new TargetConstraint[1]
        {
          (TargetConstraint) SFUtils.CreateTargetConstraint<TargetConstraintDoesAttack>()
        };
        se.targetConstraints = Array.Empty<TargetConstraint>();
        se.canBeBoosted = true;
        se.type = "";
      })).Register<StatusEffectData, StatusEffectDataBuilder>();
      new StatusEffectDataBuilder(mod).Create<StatusEffectApplyXWhenYAppliedTo>("HealWhenEnemySnowed").WithText("When an enemy is <keyword=snow>'d, heal {a} <keyword=health>").FreeModify<StatusEffectApplyXWhenYAppliedTo>((Action<StatusEffectApplyXWhenYAppliedTo>) (se =>
      {
        se.effectToApply = mod.Get<StatusEffectData>("Heal");
        se.applyToFlags = StatusEffectApplyX.ApplyToFlags.Self;
        se.whenAppliedToFlags = StatusEffectApplyX.ApplyToFlags.Enemies;
        se.whenAppliedType = "snow";
        se.stackable = true;
        se.canBeBoosted = true;
        se.type = "heal";
      })).Register<StatusEffectData, StatusEffectDataBuilder>();
      KeywordData keyword = new Snowfall2.Builders.KeywordDataBuilder(mod).CreateKeyword("Pincer", "Pincer", "Hits the closest & furthest targets in the row").Register<KeywordData, Snowfall2.Builders.KeywordDataBuilder>();
      new Snowfall2.Builders.TraitDataBuilder(mod).CreateTrait("Pincer", keyword).SetEffects(statusEffectData1).Register<TraitData, Snowfall2.Builders.TraitDataBuilder>();
      SnowfallMod.FinalBossGenerator.settings.effectSwappers = SnowfallMod.FinalBossGenerator.settings.effectSwappers.AddToArray<FinalBossEffectSwapper>(ScriptableObject.CreateInstance<FinalBossEffectSwapper>().Set<FinalBossEffectSwapper>("effect", (object) statusEffectData2).Set<FinalBossEffectSwapper>("remove", (object) false).Set<FinalBossEffectSwapper>("replaceWithOptions", (object) new StatusEffectData[1]
      {
        mod.Get<StatusEffectData>("While Active Frenzy To Allies")
      }));
    }

    private static void LoadCardsMoko(WildfrostMod mod)
    {
      CardData cardData1 = mod.Get<CardData>("MonkeyKing");
      new CardDataBuilder(mod).CreateUnit("KingMokoAlly", "King Moko").WithCardType("Leader").WithBloodProfile(cardData1.bloodProfile).WithIdleAnimationProfile(cardData1.idleAnimationProfile).SetStats(new int?(10), new int?(1), 5).SetStartWithEffect(SFUtils.CreateSEStacks("KingMokoSpiceApply", 1, mod), SFUtils.CreateSEStacks("MultiHit", 2, mod)).SetSprites(cardData1.mainSprite, mod.Get<CardData>("MonkeyKing").backgroundSprite).Register<CardData, CardDataBuilder>();
      CardData cardData2 = mod.Get<CardData>("PepperWitch");
      new CardDataBuilder(mod).CreateUnit("PepperWitchAlly", "Pepper Witch").SetSprites(cardData2.mainSprite, cardData2.backgroundSprite).SetStats(new int?(8), new int?(1), 3).WithBloodProfile(cardData2.bloodProfile).WithIdleAnimationProfile(cardData2.idleAnimationProfile).SetStartWithEffect(cardData2.startWithEffects).Register<CardData, CardDataBuilder>();
      new CardDataBuilder(mod).CreateUnit("Coco", "Coco").SetSprites(SFUtils.LoadSprite(mod.ModDirectory, "Images\\Cards\\Allies\\Coco"), cardData2.backgroundSprite).SetStats(new int?(6), new int?(0), 4).WithBloodProfile(cardData1.bloodProfile).WithIdleAnimationProfile(cardData1.idleAnimationProfile).SetStartWithEffect(SFUtils.CreateSEStacks("HealSpice", 1, mod), SFUtils.CreateSEStacks("StealSpiceFront", 1, mod)).Register<CardData, CardDataBuilder>();
      CardData cardData3 = mod.Get<CardData>("MonkeyWorshipTotem");
      new CardDataBuilder(mod).CreateUnit("MonkeyWorshipTotemAlly", "Moko Head").SetStats().WithCardType("Clunker").NeedsTarget(false).SetSprites(cardData3.mainSprite, cardData3.backgroundSprite).WithBloodProfile(cardData3.bloodProfile).WithIdleAnimationProfile(cardData3.idleAnimationProfile).SetStartWithEffect(SFUtils.CreateSEStacks("Scrap", 1, mod), SFUtils.CreateSEStacks("When Destroyed Apply Spice To Allies", 3, mod)).WithTargetMode().Register<CardData, CardDataBuilder>();
      new CardDataBuilder(mod).CreateUnit("PepperBanner", "Pepper Banner").SetStats(counter: 2).WithCardType("Clunker").SetSprites(SFUtils.LoadSprite(mod.ModDirectory, "Images\\Cards\\Allies\\SpiceBanner"), cardData3.backgroundSprite).WithBloodProfile(cardData3.bloodProfile).WithIdleAnimationProfile(cardData3.idleAnimationProfile).SetStartWithEffect(SFUtils.CreateSEStacks("Scrap", 1, mod), SFUtils.CreateSEStacks("While Active Halt Spice To Allies", 1, mod), SFUtils.CreateSEStacks("CountDownEnemiesInRow", 1, mod)).WithTargetMode().Register<CardData, CardDataBuilder>();
      new CardDataBuilder(mod).CreateItem("PepperHarvest", "Spicy Stew").CanPlayOnHand(false).SetSprites(SFUtils.LoadSprite(mod.ModDirectory, "Images\\Cards\\Items\\SpicyStew"), mod.Get<CardData>("DragonflamePepper").backgroundSprite).WithBloodProfile(mod.Get<CardData>("DragonflamePepper").bloodProfile).WithIdleAnimationProfile(mod.Get<CardData>("DragonflamePepper").idleAnimationProfile).SetAttackEffect(SFUtils.CreateSEStacks("SpiceHarvest", 1, mod)).Register<CardData, CardDataBuilder>();
      new CardDataBuilder(mod).CreateItem("ItchingPowder", "Itching Powder").CanPlayOnHand(false).SetSprites(SFUtils.LoadSprite(mod.ModDirectory, "Images\\Cards\\Items\\ItchingPowder"), mod.Get<CardData>("SunberryJuice").backgroundSprite).WithBloodProfile(mod.Get<CardData>("SunberryJuice").bloodProfile).WithIdleAnimationProfile(mod.Get<CardData>("SunberryJuice").idleAnimationProfile).SetAttackEffect(SFUtils.CreateSEStacks("CountdownIfSpiceGT2", 2, mod), SFUtils.CreateSEStacks("LoseSpice", 2, mod)).Register<CardData, CardDataBuilder>();
    }

    private static void LoadStatusEffectsMoko(WildfrostMod mod)
    {
      new StatusEffectDataBuilder(mod).Create<StatusEffectInstantApplyEffect>("SpiceHarvest").WithText("Apply <keyword=spice> equal to cards in hand").FreeModify<StatusEffectInstantApplyEffect>((Action<StatusEffectInstantApplyEffect>) (se =>
      {
        se.effectToApply = mod.Get<StatusEffectData>("Spice");
        se.targetConstraints = new TargetConstraint[0];
        se.scriptableAmount = (ScriptableAmount) SFUtils.CreateScriptableAmount<ScriptableCardsInHand>();
        se.canBeBoosted = false;
        se.stackable = false;
        se.type = "";
      })).Register<StatusEffectData, StatusEffectDataBuilder>().CopyWithSESwapped<StatusEffectData>(mod, "spice", "shell");
      new StatusEffectDataBuilder(mod).Create<StatusEffectApplyXWhenHit>("KingMokoSpiceApply").WithText("When hit, apply <{a}> <keyword=spice> to everyone in the row").FreeModify<StatusEffectApplyXWhenHit>((Action<StatusEffectApplyXWhenHit>) (se =>
      {
        se.effectToApply = mod.Get<StatusEffectData>("Spice");
        se.applyToFlags = StatusEffectApplyX.ApplyToFlags.Self | StatusEffectApplyX.ApplyToFlags.AlliesInRow | StatusEffectApplyX.ApplyToFlags.EnemiesInRow;
        se.targetConstraints = new TargetConstraint[1]
        {
          (TargetConstraint) SFUtils.CreateTargetConstraint<TargetConstraintHasHealth>()
        };
        se.applyConstraints = new TargetConstraint[1]
        {
          (TargetConstraint) SFUtils.CreateTargetConstraint<TargetConstraintDoesAttack>()
        };
        se.stackable = true;
        se.canBeBoosted = true;
      })).Register<StatusEffectData, StatusEffectDataBuilder>().CopyWithSESwapped<StatusEffectData>(mod, "spice", "shell");
      StatusEffectData loseSpice = new StatusEffectDataBuilder(mod).Create<StatusEffectInstantLoseSpiceOrFrost>("LoseSpice").WithText("Remove <{a}> <keyword=spice>").FreeModify<StatusEffectInstantLoseSpiceOrFrost>((Action<StatusEffectInstantLoseSpiceOrFrost>) (se =>
      {
        se.typeToLose = StatusEffectInstantLoseSpiceOrFrost.InstantLoseType.Spice;
        se.targetConstraints = new TargetConstraint[1]
        {
          (TargetConstraint) SFUtils.CreateTargetConstraint<TargetConstraintHasStatus>(status: mod.Get<StatusEffectData>("Spice"))
        };
        se.canBeBoosted = true;
        se.type = "";
      })).Register<StatusEffectData, StatusEffectDataBuilder>();
      loseSpice.CopyWithSESwapped<StatusEffectData>(mod, "spice", "shell");
      StatusEffectData se1 = new StatusEffectDataBuilder(mod).Create<StatusEffectApplyXPreTurn>("StealSpiceFront").FreeModify<StatusEffectApplyXPreTurn>((Action<StatusEffectApplyXPreTurn>) (se =>
      {
        se.effectToApply = loseSpice;
        se.applyToFlags = StatusEffectApplyX.ApplyToFlags.Self;
        se.applyConstraints = new TargetConstraint[1]
        {
          (TargetConstraint) SFUtils.CreateTargetConstraint<TargetConstraintHasStatus>(status: mod.Get<StatusEffectData>("Spice"))
        };
        se.targetConstraints = new TargetConstraint[0];
        se.scriptableAmount = (ScriptableAmount) SFUtils.CreateScriptableAmount<ScriptableCurrentStatus>(statusType: "spice");
        se.type = "";
      })).Register<StatusEffectData, StatusEffectDataBuilder>();
      StatusEffectData statusEffectData1 = se1.CopyWithSESwapped<StatusEffectData>(mod, "spice", "shell");
      StatusEffectData se2 = new StatusEffectDataBuilder(mod).Create<StatusEffectApplyXPreTurn>("HealSpice").WithText("Remove <keyword=spice> from self, then restore equal <keyword=health> to ally in front").FreeModify<StatusEffectApplyXPreTurn>((Action<StatusEffectApplyXPreTurn>) (se =>
      {
        se.effectToApply = mod.Get<StatusEffectData>("Heal");
        se.applyToFlags = StatusEffectApplyX.ApplyToFlags.AllyInFrontOf;
        se.applyConstraints = new TargetConstraint[1]
        {
          (TargetConstraint) SFUtils.CreateTargetConstraint<TargetConstraintHasHealth>()
        };
        se.targetConstraints = new TargetConstraint[0];
        se.scriptableAmount = (ScriptableAmount) SFUtils.CreateScriptableAmount<ScriptableCurrentStatus>(statusType: "spice");
        se.eventPriority = 99;
        se.type = "";
      })).Register<StatusEffectData, StatusEffectDataBuilder>();
      StatusEffectData se3 = new StatusEffectDataBuilder(mod).Create<StatusEffectApplyXPreTurn>("HealSpiceAlt").WithText("Restore <keyword=health> to allies in the row equal to total <keyword=spice> of self & allies in the row.").FreeModify<StatusEffectApplyXPreTurn>((Action<StatusEffectApplyXPreTurn>) (se =>
      {
        se.effectToApply = mod.Get<StatusEffectData>("Heal");
        se.applyToFlags = StatusEffectApplyX.ApplyToFlags.AlliesInRow;
        se.applyConstraints = new TargetConstraint[1]
        {
          (TargetConstraint) SFUtils.CreateTargetConstraint<TargetConstraintHasHealth>()
        };
        se.targetConstraints = new TargetConstraint[0];
        se.scriptableAmount = (ScriptableAmount) SFUtils.CreateScriptableAmount<ScriptableCurrentStatus>(statusType: "spice").AddScriptableDeco(ScriptableDeco.DecoType.AlliesInRow);
        se.applyEqualAmount = false;
        se.eventPriority = 99;
        se.type = "";
      })).Register<StatusEffectData, StatusEffectDataBuilder>();
      StatusEffectData statusEffectData2 = se2.CopyWithSESwapped<StatusEffectData>(mod, "spice", "shell");
      StatusEffectData statusEffectData3 = se3.CopyWithSESwapped<StatusEffectData>(mod, "spice", "shell");
      StatusEffectData halveSpiceOnAttack = new StatusEffectDataBuilder(mod).Create<StatusEffectApplyXPostAttack>("HalveSpiceOnAttack").FreeModify<StatusEffectApplyXPostAttack>((Action<StatusEffectApplyXPostAttack>) (se =>
      {
        se.effectToApply = loseSpice;
        se.applyToFlags = StatusEffectApplyX.ApplyToFlags.Self;
        se.applyConstraints = new TargetConstraint[0];
        se.targetConstraints = new TargetConstraint[0];
        se.scriptableAmount = (ScriptableAmount) SFUtils.CreateScriptableAmount<ScriptableCurrentStatus>(statusType: "spice").AddScriptableDeco(ScriptableDeco.DecoType.HalfUp);
        se.type = "";
      })).Register<StatusEffectData, StatusEffectDataBuilder>();
      halveSpiceOnAttack.CopyWithSESwapped<StatusEffectData>(mod, "spice", "shell");
      new StatusEffectDataBuilder(mod).Create<StatusEffectApplyXOnTurn>("CountDownEnemiesInRow").WithText("Count down all enemies in the row by <{a}>").FreeModify<StatusEffectApplyXOnTurn>((Action<StatusEffectApplyXOnTurn>) (se =>
      {
        se.effectToApply = mod.Get<StatusEffectData>("Reduce Counter");
        se.applyToFlags = StatusEffectApplyX.ApplyToFlags.EnemiesInRow;
        se.canBeBoosted = true;
        se.type = "";
        se.stackable = true;
        se.targetConstraints = new TargetConstraint[1]
        {
          (TargetConstraint) SFUtils.CreateTargetConstraint<TargetConstraintMaxCounterMoreThan>()
        };
      })).Register<StatusEffectData, StatusEffectDataBuilder>();
      new StatusEffectDataBuilder(mod).Create<StatusEffectWhileActiveX>("WhileActiveHalveAlliesSpiceOnAttack").WithText("When an ally attacks, halve their <keyword=spice>").FreeModify<StatusEffectWhileActiveX>((Action<StatusEffectWhileActiveX>) (se =>
      {
        se.effectToApply = halveSpiceOnAttack;
        se.applyToFlags = StatusEffectApplyX.ApplyToFlags.Allies;
        se.applyConstraints = new TargetConstraint[0];
        se.targetConstraints = new TargetConstraint[0];
        se.type = "";
      })).Register<StatusEffectData, StatusEffectDataBuilder>().CopyWithSESwapped<StatusEffectData>(mod, "spice", "shell");
      new StatusEffectDataBuilder(mod).Create<StatusEffectInstantReduceCounter>("CountdownIfSpiceGT2").WithText("Count down <keyword=counter> by <{a}>").FreeModify<StatusEffectInstantReduceCounter>((Action<StatusEffectInstantReduceCounter>) (se =>
      {
        se.targetConstraints = new TargetConstraint[2]
        {
          (TargetConstraint) SFUtils.CreateTargetConstraint<TargetConstraintHasStatus>(status: mod.Get<StatusEffectData>("Spice")),
          (TargetConstraint) SFUtils.CreateTargetConstraint<TargetConstraintMaxCounterMoreThan>()
        };
        se.canBeBoosted = true;
        se.type = "";
      })).Register<StatusEffectData, StatusEffectDataBuilder>().CopyWithSESwapped<StatusEffectData>(mod, "spice", "shell");
      SnowfallMod.FinalBossGenerator.settings.effectSwappers = SnowfallMod.FinalBossGenerator.settings.effectSwappers.AddToArray<FinalBossEffectSwapper>(ScriptableObject.CreateInstance<FinalBossEffectSwapper>().Set<FinalBossEffectSwapper>("effect", (object) se1).Set<FinalBossEffectSwapper>("remove", (object) true)).AddToArray<FinalBossEffectSwapper>(ScriptableObject.CreateInstance<FinalBossEffectSwapper>().Set<FinalBossEffectSwapper>("effect", (object) statusEffectData1).Set<FinalBossEffectSwapper>("remove", (object) true)).AddToArray<FinalBossEffectSwapper>(ScriptableObject.CreateInstance<FinalBossEffectSwapper>().Set<FinalBossEffectSwapper>("effect", (object) se2).Set<FinalBossEffectSwapper>("remove", (object) false).Set<FinalBossEffectSwapper>("replaceWithOptions", (object) new StatusEffectData[1]
      {
        se3
      })).AddToArray<FinalBossEffectSwapper>(ScriptableObject.CreateInstance<FinalBossEffectSwapper>().Set<FinalBossEffectSwapper>("effect", (object) statusEffectData2).Set<FinalBossEffectSwapper>("remove", (object) false).Set<FinalBossEffectSwapper>("replaceWithOptions", (object) new StatusEffectData[1]
      {
        statusEffectData3
      }));
    }

    private static void LoadTribeMoko(
      WildfrostMod mod,
      List<CardData> generalUnits,
      List<CardData> generalItems)
    {
      ClassData classData = SnowfallMod.GameMode.classes[0];
      ClassData instance = ScriptableObject.CreateInstance<ClassData>();
      instance.name = Extensions.PrefixGUID("Moko", mod);
      instance.leaders = new CardData[1]
      {
        mod.Get<CardData>("KingMokoAlly").Clone().Set<CardData>("upgrades", (object) new List<CardUpgradeData>()
        {
          mod.Get<CardUpgradeData>("Crown")
        })
      };
      instance.startingInventory = ScriptableObject.CreateInstance<Inventory>();
      instance.startingInventory.deck = new CardDataList()
      {
        mod.Get<CardData>("ItchingPowder"),
        mod.Get<CardData>("MonkeyWorshipTotemAlly"),
        mod.Get<CardData>("PepperHarvest"),
        mod.Get<CardData>("PepperWitchAlly"),
        mod.Get<CardData>("Peppereaper")
      };
      foreach (CardData cardData in BeastTribeData.TribeDeckItems.ToArray())
        instance.startingInventory.deck.Add(cardData);
      instance.startingInventory.upgrades = new List<CardUpgradeData>();
      PlayerData playerData = new PlayerData(instance, instance.startingInventory);
      instance.characterPrefab = UnityEngine.Object.Instantiate<Character>(classData.characterPrefab);
      instance.characterPrefab.data = playerData;
      instance.characterPrefab.title = classData.characterPrefab.title;
      instance.characterPrefab.team = classData.characterPrefab.team;
      BeastTribeData.TribeItems.AddRange((IEnumerable<CardData>) generalItems);
      BeastTribeData.TribeUnits.AddRange((IEnumerable<CardData>) generalUnits);
      instance.rewardPools = new RewardPool[10]
      {
        SFUtils.CreateRewardPool("GeneralItemPool", "Items", BeastTribeData.TribeItems.Cast<DataFile>().ToList<DataFile>()),
        SFUtils.CreateRewardPool("GeneralUnitPool", "Units", BeastTribeData.TribeUnits.Cast<DataFile>().ToList<DataFile>()),
        SFUtils.CreateRewardPool("GeneralCharmPool", "Charms", ((IEnumerable<RewardPool>) classData.rewardPools).First<RewardPool>((Func<RewardPool, bool>) (p => p.name == "GeneralCharmPool")).list),
        SFUtils.CreateRewardPool("SnowItemPool", "Items", new List<DataFile>()),
        SFUtils.CreateRewardPool("SnowUnitPool", "Units", new List<DataFile>()),
        SFUtils.CreateRewardPool("SnowCharmPool", "Charms", new List<DataFile>()),
        SFUtils.CreateRewardPool(Extensions.PrefixGUID("MokoItemPool", mod), "Items", new List<DataFile>()
        {
          (DataFile) mod.Get<CardData>("ItchingPowder"),
          (DataFile) mod.Get<CardData>("MonkeyWorshipTotemAlly"),
          (DataFile) mod.Get<CardData>("PepperHarvest"),
          (DataFile) mod.Get<CardData>("PepperBanner"),
          (DataFile) mod.Get<CardData>("Peppereaper"),
          (DataFile) mod.Get<CardData>("Peppering"),
          (DataFile) mod.Get<CardData>("Recycler"),
          (DataFile) mod.Get<CardData>("DragonflamePepper"),
          (DataFile) mod.Get<CardData>("MoltenDip"),
          (DataFile) mod.Get<CardData>("SpiceStones"),
          (DataFile) mod.Get<CardData>("SpiceSparklers"),
          (DataFile) mod.Get<CardData>("Demonheart"),
          (DataFile) mod.Get<CardData>("FrostBell"),
          (DataFile) mod.Get<CardData>("FrostBloom"),
          (DataFile) mod.Get<CardData>("IceShard"),
          (DataFile) mod.Get<CardData>("EyeDrops"),
          (DataFile) mod.Get<CardData>("Snowcake"),
          (DataFile) mod.Get<CardData>("SnowGlobe"),
          (DataFile) mod.Get<CardData>("BlazeTea"),
          (DataFile) mod.Get<CardData>("Snowcracker"),
          (DataFile) mod.Get<CardData>("Plinker"),
          (DataFile) mod.Get<CardData>("Heartforge"),
          (DataFile) mod.Get<CardData>("TotemOfTheGoat"),
          (DataFile) mod.Get<CardData>("Mimik"),
          (DataFile) mod.Get<CardData>("MegaMimik")
        }),
        SFUtils.CreateRewardPool(Extensions.PrefixGUID("MokoUnitPool", mod), "Units", new List<DataFile>()
        {
          (DataFile) mod.Get<CardData>("PepperWitchAlly"),
          (DataFile) mod.Get<CardData>("Coco")
        }),
        SFUtils.CreateRewardPool(Extensions.PrefixGUID("MokoCharmPool", mod), "Charms", ((IEnumerable<RewardPool>) classData.rewardPools).First<RewardPool>((Func<RewardPool, bool>) (p => p.name == "BasicCharmPool")).list.AddItem<DataFile>((DataFile) mod.Get<CardUpgradeData>("CardUpgradeSpiky")).AddItem<DataFile>((DataFile) mod.Get<CardUpgradeData>("CardUpgradeTeethWhenHit")).ToList<DataFile>()),
        SFUtils.CreateRewardPool("GeneralModifierPool", "Modifiers", ((IEnumerable<RewardPool>) classData.rewardPools).First<RewardPool>((Func<RewardPool, bool>) (p => p.name == "GeneralModifierPool")).list)
      };
      instance.requiresUnlock = classData.requiresUnlock;
      instance.ModAdded = mod;
      instance.selectSfxEvent = classData.selectSfxEvent;
      instance.flag = SFUtils.LoadSprite(mod.ModDirectory, "Images\\Banners\\BeastBanner");
      instance.Register<ClassData>();
      SnowfallMod.AddedClasses.Add(instance);
    }
  }
}
