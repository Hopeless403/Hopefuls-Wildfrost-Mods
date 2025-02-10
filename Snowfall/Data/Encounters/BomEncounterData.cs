// Decompiled with JetBrains decompiler
// Type: Snowfall2.Data.Encounters.BomEncounterData
// Assembly: Snowfall, Version=0.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 26AFE777-3FAB-4D6F-AF6C-494837402D4A
// Assembly location: C:\Users\harri\AppData\Local\Temp\Temp1_Snowfall_-_Alpha_2.1.2.zip\Snowfall.dll

using Deadpan.Enums.Engine.Components.Modding;
using Snowfall2.Classes.StatusEffects;
using Snowfall2.Util;
using System;

namespace Snowfall2.Data.Encounters
{
  public static class BomEncounterData
  {
    public static void Load(SnowfallMod mod)
    {
      KeywordData keywordData = new Snowfall2.Builders.KeywordDataBuilder((WildfrostMod) mod).CreateKeyword("Wash", "Wash", "Remove all applied statuses").Register<KeywordData, Snowfall2.Builders.KeywordDataBuilder>();
      StatusEffectData wash = new StatusEffectDataBuilder((WildfrostMod) mod).Create<StatusEffectWash>("Wash").Register<StatusEffectData, StatusEffectDataBuilder>();
      new StatusEffectDataBuilder((WildfrostMod) mod).Create<StatusEffectApplyXWhenHit>("WashAttackerWhenHit").WithText("<keyword=" + keywordData.name.ToLower() + "> the attacker when hit").WithType("").WithCanBeBoosted(false).WithStackable(false).FreeModify<StatusEffectApplyXWhenHit>((Action<StatusEffectApplyXWhenHit>) (se =>
      {
        se.effectToApply = wash;
        se.targetConstraints = new TargetConstraint[0];
        se.applyToFlags = StatusEffectApplyX.ApplyToFlags.Attacker;
      })).Register<StatusEffectData, StatusEffectDataBuilder>();
      new StatusEffectDataBuilder((WildfrostMod) mod).Create<StatusEffectInstantApplyXToCustom>("ExplodeBomCol").WithType("").WithCanBeBoosted(true).WithStackable(true).FreeModify<StatusEffectInstantApplyXToCustom>((Action<StatusEffectInstantApplyXToCustom>) (se =>
      {
        se.effectToApply = mod.Get<StatusEffectData>("Weakness");
        se.customTargetFlags = StatusEffectInstantApplyXToCustom.CustomTargetFlags.FrontColumnEnemies;
        se.targetConstraints = new TargetConstraint[0];
      })).Register<StatusEffectData, StatusEffectDataBuilder>().ApplyBy<StatusEffectApplyXWhenDestroyed>((WildfrostMod) mod, "ExplodeBom", "When destroyed, apply <{a}> <keyword=weakness> to enemies in the frontmost column", targetMustBeAlive: false);
      new StatusEffectDataBuilder((WildfrostMod) mod).Create<StatusEffectApplyXWhenYAppliedTo>("WhenBomAppliedGainFrenzy").WithText("When <keyword=weakness> is applied to anyone, gain <x{a}> <keyword=frenzy>").WithType("").WithCanBeBoosted(true).WithStackable(true).FreeModify<StatusEffectApplyXWhenYAppliedTo>((Action<StatusEffectApplyXWhenYAppliedTo>) (se =>
      {
        se.whenAppliedToFlags = StatusEffectApplyX.ApplyToFlags.Allies | StatusEffectApplyX.ApplyToFlags.Enemies;
        se.whenAppliedType = "vim";
        se.effectToApply = mod.Get<StatusEffectData>("MultiHit");
        se.targetConstraints = new TargetConstraint[0];
        se.applyToFlags = StatusEffectApplyX.ApplyToFlags.Self;
      })).Register<StatusEffectData, StatusEffectDataBuilder>();
      StatusEffectSummon summonBomBunny = new StatusEffectDataBuilder((WildfrostMod) mod).Create<StatusEffectSummon>("SummonBomBunny").FreeModify<StatusEffectSummon>((Action<StatusEffectSummon>) (se =>
      {
        se.effectPrefabRef = (mod.Get<StatusEffectData>("Instant Summon Junk In Hand") as StatusEffectInstantSummon).targetSummon.effectPrefabRef;
        se.targetConstraints = new TargetConstraint[0];
        se.type = "";
      })).Register<StatusEffectData, StatusEffectDataBuilder>() as StatusEffectSummon;
      StatusEffectData instantSummon = new StatusEffectDataBuilder((WildfrostMod) mod).Create<StatusEffectInstantSummon>("InstantSummonBomBunny").FreeModify<StatusEffectInstantSummon>((Action<StatusEffectInstantSummon>) (se =>
      {
        se.summonPosition = StatusEffectInstantSummon.Position.InFrontOf;
        se.targetSummon = summonBomBunny;
      })).Register<StatusEffectData, StatusEffectDataBuilder>();
      StatusEffectData data = new StatusEffectDataBuilder((WildfrostMod) mod).Create<StatusEffectApplyXWhenHit>("SummonBomBunnyWhenHit").WithText("When hit, deploy <card=" + Extensions.PrefixGUID("BomBunny", (WildfrostMod) mod) + ">").FreeModify<StatusEffectApplyXWhenHit>((Action<StatusEffectApplyXWhenHit>) (se =>
      {
        se.effectToApply = instantSummon;
        se.applyToFlags = StatusEffectApplyX.ApplyToFlags.Self;
        se.targetConstraints = new TargetConstraint[0];
        se.applyConstraints = new TargetConstraint[0];
        se.targetMustBeAlive = false;
        se.type = "";
      })).Register<StatusEffectData, StatusEffectDataBuilder>();
      CardData cardData1 = mod.Get<CardData>("EnergyDart");
      CardData cardData2 = new CardDataBuilder((WildfrostMod) mod).CreateUnit("BomBunny", "Bom Bunny").WithValue(50).SetStats(damage: new int?(0), counter: 2).SetSprites(cardData1.mainSprite, cardData1.backgroundSprite).WithBloodProfile(cardData1.bloodProfile).WithIdleAnimationProfile("PingAnimationProfile").SetStartWithEffect(mod.CreateEffectStack("ExplodeBom", 1), mod.CreateEffectStack("Scrap", 1)).SetTraits(mod.CreateTraitStack("Frontline", 1)).WithCardType("Clunker").AsEnemyClunker().Register<CardData, CardDataBuilder>();
      summonBomBunny.summonCard = cardData2;
      CardData cardData3 = new CardDataBuilder((WildfrostMod) mod).CreateUnit("Thumper", "Thumper").WithValue(200).SetStats(new int?(6), counter: 3).SetSprites(SFUtils.LoadSprite(mod.ModDirectory, "Images\\Cards\\Enemies\\Thumper"), mod.Get<CardData>("Gobling").backgroundSprite).WithBloodProfile().WithIdleAnimationProfile("ShakeAnimationProfile").SetStartWithEffect(mod.CreateEffectStack("WashAttackerWhenHit", 1), mod.CreateEffectStack("On Turn Escape To Self", 1)).WithCardType("Enemy").Register<CardData, CardDataBuilder>();
      CardData cardData4 = new CardDataBuilder((WildfrostMod) mod).CreateUnit("Bunner", "Bunner").WithValue(150).SetStats(new int?(5), new int?(1), 2).SetSprites(SFUtils.LoadSprite(mod.ModDirectory, "Images\\Cards\\Enemies\\Bunner"), mod.Get<CardData>("Vox").backgroundSprite).WithBloodProfile().WithIdleAnimationProfile("SquishAnimationProfile").WithCardType("Enemy").Register<CardData, CardDataBuilder>();
      CardData cardData5 = mod.Get<CardData>("Gnomlings");
      CardData cardData6 = new CardDataBuilder((WildfrostMod) mod).CreateUnit("Sizzle", "Sizzle").WithValue(250).SetStats(new int?(7), new int?(1), 3).SetSprites(SFUtils.LoadSprite(mod.ModDirectory, "Images\\Cards\\Enemies\\Sizzle"), cardData5.backgroundSprite).WithBloodProfile(cardData5.bloodProfile).WithIdleAnimationProfile(cardData5.idleAnimationProfile).SetStartWithEffect(mod.CreateEffectStack("WhenBomAppliedGainFrenzy", 1)).WithCardType("Enemy").Register<CardData, CardDataBuilder>();
      CardData cardData7 = mod.Get<CardData>("Witch");
      CardData cardData8 = new CardDataBuilder((WildfrostMod) mod).CreateUnit("Biji", "Biji").WithValue(650).SetStats(new int?(10), new int?(0), 4).SetSprites(SFUtils.LoadSprite(mod.ModDirectory, "Images\\Cards\\Enemies\\Biji"), cardData7.backgroundSprite).WithBloodProfile(cardData7.bloodProfile).WithIdleAnimationProfile(cardData7.idleAnimationProfile).SetStartWithEffect(new CardData.StatusEffectStacks(data, 1)).SetAttackEffect(mod.CreateEffectStack("Weakness", 3)).WithCardType("Miniboss").Register<CardData, CardDataBuilder>();
      BattleWavePoolData battleWavePoolData1 = SFUtils.CreateBattleWavePoolData((WildfrostMod) mod, "BomBattle", "Wave Pool 1", new BattleWavePoolData.Wave[1]
      {
        SFUtils.CreateBattleWaveData(new CardData[3]
        {
          cardData2,
          cardData2,
          cardData4
        })
      });
      BattleWavePoolData battleWavePoolData2 = SFUtils.CreateBattleWavePoolData((WildfrostMod) mod, "BomBattle", "Wave Pool 2", new BattleWavePoolData.Wave[1]
      {
        SFUtils.CreateBattleWaveData(new CardData[3]
        {
          cardData2,
          cardData3,
          cardData6
        })
      });
      BattleWavePoolData battleWavePoolData3 = SFUtils.CreateBattleWavePoolData((WildfrostMod) mod, "BomBattle", "Wave Pool 3", new BattleWavePoolData.Wave[1]
      {
        SFUtils.CreateBattleWaveData(new CardData[4]
        {
          cardData2,
          cardData2,
          cardData4,
          cardData8
        })
      });
      BattleTools.SetInTier(0, new Snowfall2.Builders.BattleDataBuilder((WildfrostMod) mod).CreateBattle("BomBattle", "Bun Squad", SFUtils.LoadSprite(mod.ModDirectory, "Images\\Encounters\\BomSquad"), new BattleWavePoolData[3]
      {
        battleWavePoolData1,
        battleWavePoolData2,
        battleWavePoolData3
      }).Register<BattleData, Snowfall2.Builders.BattleDataBuilder>().name);
    }
  }
}
