// Decompiled with JetBrains decompiler
// Type: Snowfall2.Data.Encounters.InkEncounterData
// Assembly: Snowfall, Version=0.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 26AFE777-3FAB-4D6F-AF6C-494837402D4A
// Assembly location: C:\Users\harri\AppData\Local\Temp\Temp1_Snowfall_-_Alpha_2.1.2.zip\Snowfall.dll

using Deadpan.Enums.Engine.Components.Modding;
using Snowfall2.Classes.StatusEffects;
using Snowfall2.Util;
using System;

namespace Snowfall2.Data.Encounters
{
  public static class InkEncounterData
  {
    public static void Load(SnowfallMod mod)
    {
      StatusEffectData data1 = new StatusEffectDataBuilder((WildfrostMod) mod).Create<StatusEffectApplyXWhenYAppliedTo>("WhenAnythingInkedGainAttack").WithText("When anything receives <keyword=null>, gain <{a}> <keyword=attack>").FreeModify<StatusEffectApplyXWhenYAppliedTo>((Action<StatusEffectApplyXWhenYAppliedTo>) (se =>
      {
        se.effectToApply = mod.Get<StatusEffectData>("Increase Attack");
        se.applyToFlags = StatusEffectApplyX.ApplyToFlags.Self;
        se.whenAppliedType = "ink";
        se.whenAppliedToFlags = StatusEffectApplyX.ApplyToFlags.Allies | StatusEffectApplyX.ApplyToFlags.Enemies;
        se.targetConstraints = new TargetConstraint[0];
        se.applyConstraints = new TargetConstraint[0];
        se.canBeBoosted = true;
        se.type = "";
      })).Register<StatusEffectData, StatusEffectDataBuilder>();
      StatusEffectData data2 = new StatusEffectDataBuilder((WildfrostMod) mod).Create<StatusEffectApplyXWhenDestroyed>("WhenKilledSpreadInk").WithText("When killed, apply <{a}> <keyword=null> to everyone").FreeModify<StatusEffectApplyXWhenDestroyed>((Action<StatusEffectApplyXWhenDestroyed>) (se =>
      {
        se.effectToApply = mod.Get<StatusEffectData>("Null");
        se.applyToFlags = StatusEffectApplyX.ApplyToFlags.Allies | StatusEffectApplyX.ApplyToFlags.Enemies;
        se.targetConstraints = new TargetConstraint[0];
        se.applyConstraints = new TargetConstraint[0];
        se.targetMustBeAlive = false;
        se.canBeBoosted = true;
        se.type = "";
      })).Register<StatusEffectData, StatusEffectDataBuilder>();
      StatusEffectData statusEffectData = new StatusEffectDataBuilder((WildfrostMod) mod).Create<StatusEffectApplyXBeforeYAppliedTo>("WhenInkedHealInstead").FreeModify<StatusEffectApplyXBeforeYAppliedTo>((Action<StatusEffectApplyXBeforeYAppliedTo>) (se =>
      {
        se.instead = true;
        se.whenAppliedType = "ink";
        se.whenAppliedToFlags = StatusEffectApplyX.ApplyToFlags.Self;
        se.effectToApply = mod.Get<StatusEffectData>("Heal");
        se.applyToFlags = StatusEffectApplyX.ApplyToFlags.Self;
        se.targetConstraints = new TargetConstraint[0];
        se.type = "";
        se.canBeBoosted = false;
        se.stackable = false;
      })).Register<StatusEffectData, StatusEffectDataBuilder>();
      StatusEffectData dropNoBlings = new StatusEffectDataBuilder((WildfrostMod) mod).Create<StatusEffectDropNoGold>("DropNoBlings").FreeModify<StatusEffectDropNoGold>((Action<StatusEffectDropNoGold>) (se =>
      {
        se.targetConstraints = new TargetConstraint[0];
        se.type = "";
        se.canBeBoosted = false;
        se.stackable = false;
      })).Register<StatusEffectData, StatusEffectDataBuilder>();
      StatusEffectData data3 = new StatusEffectDataBuilder((WildfrostMod) mod).Create<StatusEffectWhileActiveX>("WhileActiveAlliesDropNoBlings").WithText("While active, allies drop no <keyword=blings>").FreeModify<StatusEffectWhileActiveX>((Action<StatusEffectWhileActiveX>) (se =>
      {
        se.effectToApply = dropNoBlings;
        se.applyToFlags = StatusEffectApplyX.ApplyToFlags.Allies;
        se.targetConstraints = new TargetConstraint[0];
        se.type = "";
        se.canBeBoosted = false;
        se.stackable = false;
      })).Register<StatusEffectData, StatusEffectDataBuilder>();
      StatusEffectData data4 = new StatusEffectDataBuilder((WildfrostMod) mod).Create<StatusEffectApplyXWhenAllyIsHit>("TriggerAgainstAttackerWhenAllyIsHit").WithText("Trigger against attacker when an ally is hit").FreeModify<StatusEffectApplyXWhenAllyIsHit>((Action<StatusEffectApplyXWhenAllyIsHit>) (se =>
      {
        se.effectToApply = mod.Get<StatusEffectData>("Trigger Against");
        se.applyToFlags = StatusEffectApplyX.ApplyToFlags.Attacker;
        se.descColorHex = "F99C61";
        se.isReaction = true;
        se.targetConstraints = new TargetConstraint[0];
        se.applyConstraints = new TargetConstraint[1]
        {
          (TargetConstraint) SFUtils.CreateTargetConstraint<TargetConstraintIsUnit>()
        };
        se.type = "";
      })).Register<StatusEffectData, StatusEffectDataBuilder>();
      KeywordData keyword = new Snowfall2.Builders.KeywordDataBuilder((WildfrostMod) mod).CreateKeyword("Sponge", "Sponge", "When <keyword=null>'d, restore equal <keyword=health> instead").Register<KeywordData, Snowfall2.Builders.KeywordDataBuilder>();
      TraitData data5 = new Snowfall2.Builders.TraitDataBuilder((WildfrostMod) mod).CreateTrait("Sponge", keyword).SetEffects(statusEffectData).Register<TraitData, Snowfall2.Builders.TraitDataBuilder>();
      CardData cardData1 = new CardDataBuilder((WildfrostMod) mod).Create("Plopperfish").WithTitle("Plopperfish").AsUnit().WithValue(100).WithCardType("Enemy").SetSprites(SFUtils.LoadSprite(mod.ModDirectory, "Images\\Cards\\Enemies\\Plopperfish"), mod.Get<CardData>("Voido").backgroundSprite).SetStats(new int?(2), new int?(2), 2).WithBloodProfile("Blood Profile Black").WithIdleAnimationProfile("GoopAnimationProfile").SetStartWithEffect(new CardData.StatusEffectStacks(data2, 1)).Register<CardData, CardDataBuilder>();
      CardData cardData2 = new CardDataBuilder((WildfrostMod) mod).Create("Chester").WithTitle("Chester").AsUnit().WithValue(250).WithCardType("Clunker").SetSprites(SFUtils.LoadSprite(mod.ModDirectory, "Images\\Cards\\Enemies\\Chester"), mod.Get<CardData>("Blingo").backgroundSprite).SetStats().WithBloodProfile("Blood Profile Black").WithIdleAnimationProfile("ShakeAnimationProfile").SetStartWithEffect(new CardData.StatusEffectStacks(data3, 1), SFUtils.CreateSEStacks("Scrap", 3, (WildfrostMod) mod)).AsEnemyClunker().Register<CardData, CardDataBuilder>();
      CardData cardData3 = new CardDataBuilder((WildfrostMod) mod).Create("Sharkgor").WithTitle("Sharkgor").AsUnit().WithValue(350).WithCardType("Enemy").SetSprites(SFUtils.LoadSprite(mod.ModDirectory, "Images\\Cards\\Enemies\\Sharkgor"), mod.Get<CardData>("Bear").backgroundSprite).SetStats(new int?(10), new int?(3)).WithBloodProfile().WithIdleAnimationProfile("GiantAnimationProfile").SetStartWithEffect(new CardData.StatusEffectStacks(data4, 1)).Register<CardData, CardDataBuilder>();
      CardData cardData4 = new CardDataBuilder((WildfrostMod) mod).Create("Sincor").WithTitle("Sincor").AsUnit().WithValue(200).WithCardType("Clunker").SetSprites(SFUtils.LoadSprite(mod.ModDirectory, "Images\\Cards\\Enemies\\Sincor"), mod.Get<CardData>("Voido").backgroundSprite).SetStats(damage: new int?(0), counter: 3).WithBloodProfile("Blood Profile Black").WithIdleAnimationProfile("GoopAnimationProfile").SetStartWithEffect(SFUtils.CreateSEStacks("Scrap", 2, (WildfrostMod) mod)).SetAttackEffect(SFUtils.CreateSEStacks("Null", 2, (WildfrostMod) mod)).SetTraits(SFUtils.CreateTraitStacks("Barrage", 1, (WildfrostMod) mod)).AsEnemyClunker().Register<CardData, CardDataBuilder>();
      CardData cardData5 = new CardDataBuilder((WildfrostMod) mod).Create("InkMiniboss").WithTitle("Scurgeon Hook").AsUnit().WithValue(650).WithCardType("Miniboss").SetSprites(SFUtils.LoadSprite(mod.ModDirectory, "Images\\Cards\\Enemies\\InkMiniboss"), mod.Get<CardData>("Voido").backgroundSprite).SetStats(new int?(15), new int?(2), 4).WithBloodProfile("Blood Profile Black").WithIdleAnimationProfile("GoopAnimationProfile").SetStartWithEffect(new CardData.StatusEffectStacks(data1, 1), SFUtils.CreateSEStacks("ImmuneToSnow", 1, (WildfrostMod) mod)).SetTraits(new CardData.TraitStacks(data5, 1)).Register<CardData, CardDataBuilder>();
      CardData cardData6 = new CardDataBuilder((WildfrostMod) mod).Create("NewBombom").WithTitle("Bombom").AsUnit().WithValue(200).WithCardType("Enemy").SetSprites(mod.Get<CardData>("Bombom").mainSprite, mod.Get<CardData>("Bombom").backgroundSprite).SetStats(new int?(12), new int?(4), 4).WithBloodProfile(mod.Get<CardData>("Bombom").bloodProfile).WithIdleAnimationProfile(mod.Get<CardData>("Bombom").idleAnimationProfile).SetStartWithEffect(SFUtils.CreateSEStacks("On Card Played Damage To Self & AlliesInRow", 3, (WildfrostMod) mod)).SetTraits(mod.Get<CardData>("Bombom").traits.ToArray()).Register<CardData, CardDataBuilder>();
      BattleWavePoolData battleWavePoolData1 = SFUtils.CreateBattleWavePoolData((WildfrostMod) mod, "InkBattle", "Wave Pool 1", new BattleWavePoolData.Wave[2]
      {
        SFUtils.CreateBattleWaveData(new CardData[3]
        {
          cardData1,
          cardData1,
          cardData6
        }),
        SFUtils.CreateBattleWaveData(new CardData[3]
        {
          cardData4,
          cardData1,
          cardData6
        })
      });
      BattleWavePoolData battleWavePoolData2 = SFUtils.CreateBattleWavePoolData((WildfrostMod) mod, "InkBattle", "Wave Pool 2", new BattleWavePoolData.Wave[3]
      {
        SFUtils.CreateBattleWaveData(new CardData[3]
        {
          cardData1,
          cardData1,
          cardData3
        }),
        SFUtils.CreateBattleWaveData(new CardData[3]
        {
          cardData2,
          cardData1,
          cardData3
        }),
        SFUtils.CreateBattleWaveData(new CardData[3]
        {
          cardData4,
          cardData1,
          cardData3
        })
      });
      BattleWavePoolData battleWavePoolData3 = SFUtils.CreateBattleWavePoolData((WildfrostMod) mod, "InkBattle", "Wave Pool 3", new BattleWavePoolData.Wave[2]
      {
        SFUtils.CreateBattleWaveData(new CardData[4]
        {
          cardData5,
          cardData4,
          cardData1,
          cardData1
        }, true),
        SFUtils.CreateBattleWaveData(new CardData[4]
        {
          cardData5,
          cardData1,
          cardData4,
          cardData4
        }, true)
      });
      BattleTools.SetInTier(1, new Snowfall2.Builders.BattleDataBuilder((WildfrostMod) mod).CreateBattle("InkBattle", "Smudged Sailors", SFUtils.LoadSprite(mod.ModDirectory, "Images\\Encounters\\Sailors"), new BattleWavePoolData[3]
      {
        battleWavePoolData1,
        battleWavePoolData2,
        battleWavePoolData3
      }).Register<BattleData, Snowfall2.Builders.BattleDataBuilder>().name);
    }
  }
}
