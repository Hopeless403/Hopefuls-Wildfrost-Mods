// Decompiled with JetBrains decompiler
// Type: Snowfall2.Data.Encounters.OverburnEncounterData
// Assembly: Snowfall, Version=0.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 26AFE777-3FAB-4D6F-AF6C-494837402D4A
// Assembly location: C:\Users\harri\AppData\Local\Temp\Temp1_Snowfall_-_Alpha_2.1.2.zip\Snowfall.dll

using Deadpan.Enums.Engine.Components.Modding;
using Snowfall2.Classes.ScriptableAmounts;
using Snowfall2.Util;
using System;

namespace Snowfall2.Data.Encounters
{
  public static class OverburnEncounterData
  {
    public static void Load(SnowfallMod mod)
    {
      StatusEffectData data1 = new StatusEffectDataBuilder((WildfrostMod) mod).Create<StatusEffectBonusDamageEqualToX>("ExtraDMGToOverloaded").WithText("Deal <{a}> extra damage if the target has <keyword=overload>").FreeModify<StatusEffectBonusDamageEqualToX>((Action<StatusEffectBonusDamageEqualToX>) (se =>
      {
        se.on = StatusEffectBonusDamageEqualToX.On.ScriptableAmount;
        se.scriptableAmount = (ScriptableAmount) SFUtils.CreateScriptableAmount<ScriptableCurrentStatusBoostable>(statusType: "Snowfall.ExtraDMGToOverloaded").AddScriptableDeco(ScriptableDeco.DecoType.ConditionalOnTarget, (ScriptableAmount) SFUtils.CreateScriptableAmount<ScriptableCurrentStatus>(statusType: "overload"));
        se.targetConstraints = Array.Empty<TargetConstraint>();
        se.canBeBoosted = true;
        se.stackable = true;
        se.type = "Snowfall.ExtraDMGToOverloaded";
      })).Register<StatusEffectData, StatusEffectDataBuilder>();
      StatusEffectData data2 = new StatusEffectDataBuilder((WildfrostMod) mod).Create<StatusEffectApplyXWhenAllyIsKilled>("StackEffectWhenAllyKilled").WithText("When an ally is killed, increase effect by <{a}>").FreeModify<StatusEffectApplyXWhenAllyIsKilled>((Action<StatusEffectApplyXWhenAllyIsKilled>) (se =>
      {
        se.effectToApply = mod.Get<StatusEffectData>("Increase Attack Effect 1");
        se.applyToFlags = StatusEffectApplyX.ApplyToFlags.Self;
        se.targetConstraints = new TargetConstraint[1]
        {
          (TargetConstraint) SFUtils.CreateTargetConstraint<TargetConstraintIsUnit>()
        };
        se.applyConstraints = Array.Empty<TargetConstraint>();
        se.canBeBoosted = true;
        se.type = "";
      })).Register<StatusEffectData, StatusEffectDataBuilder>();
      StatusEffectData data3 = new StatusEffectDataBuilder((WildfrostMod) mod).Create<StatusEffectApplyXPostAttack>("StackEffectPostAttack").WithText("For each target affected, increase effect by <{a}>").FreeModify<StatusEffectApplyXPostAttack>((Action<StatusEffectApplyXPostAttack>) (se =>
      {
        se.effectToApply = mod.Get<StatusEffectData>("Increase Attack Effect 1");
        se.applyToFlags = StatusEffectApplyX.ApplyToFlags.Self;
        se.targetConstraints = new TargetConstraint[1]
        {
          (TargetConstraint) SFUtils.CreateTargetConstraint<TargetConstraintIsUnit>()
        };
        se.applyConstraints = Array.Empty<TargetConstraint>();
        se.canBeBoosted = true;
        se.type = "";
      })).Register<StatusEffectData, StatusEffectDataBuilder>();
      StatusEffectData statusEffectReduceOverburnInstant = new StatusEffectDataBuilder((WildfrostMod) mod).Create<StatusEffectInstantLoseX>("ReduceOverburnInstant").FreeModify<StatusEffectInstantLoseX>((Action<StatusEffectInstantLoseX>) (se =>
      {
        se.statusToLose = mod.Get<StatusEffectData>("Overload");
        se.targetConstraints = Array.Empty<TargetConstraint>();
        se.type = "";
      })).Register<StatusEffectData, StatusEffectDataBuilder>();
      StatusEffectData data4 = new StatusEffectDataBuilder((WildfrostMod) mod).Create<StatusEffectApplyXWhenHit>("RemoveOverburnWhenHit").WithText("When hit, remove <{a}> <keyword=overload> from attacker").FreeModify<StatusEffectApplyXWhenHit>((Action<StatusEffectApplyXWhenHit>) (se =>
      {
        se.effectToApply = statusEffectReduceOverburnInstant;
        se.applyToFlags = StatusEffectApplyX.ApplyToFlags.Attacker;
        se.targetMustBeAlive = false;
        se.eventPriority = 99999;
        se.targetConstraints = Array.Empty<TargetConstraint>();
        se.applyConstraints = Array.Empty<TargetConstraint>();
        se.canBeBoosted = true;
        se.type = "";
      })).Register<StatusEffectData, StatusEffectDataBuilder>();
      CardData cardData1 = mod.Get<CardData>("Burner");
      CardData cardData2 = new CardDataBuilder((WildfrostMod) mod).CreateUnit("OverburnMiniboss", "Wishful Soul").WithValue(650).WithCardType("Miniboss").SetSprites(SFUtils.LoadSprite(mod.ModDirectory, "Images\\Cards\\Enemies\\OverburnMiniboss"), cardData1.backgroundSprite).SetStats(new int?(36), counter: 3).WithBloodProfile("Blood Profile Blue (x2)").WithIdleAnimationProfile("FloatSquishAnimationProfile").SetTraits(SFUtils.CreateTraitStacks("Barrage", 1, (WildfrostMod) mod)).SetStartWithEffect(SFUtils.CreateSEStacks("ImmuneToSnow", 1, (WildfrostMod) mod), new CardData.StatusEffectStacks(data3, 1)).SetAttackEffect(SFUtils.CreateSEStacks("Overload", 2, (WildfrostMod) mod)).Register<CardData, CardDataBuilder>();
      CardData cardData3 = new CardDataBuilder((WildfrostMod) mod).CreateUnit("OverburnPeon", "Burning Soul").WithValue(100).WithCardType("Enemy").SetSprites(SFUtils.LoadSprite(mod.ModDirectory, "Images\\Cards\\Enemies\\OverburnPeon"), cardData1.backgroundSprite).SetStats(new int?(4), new int?(0), 2).WithBloodProfile("Blood Profile Blue (x2)").WithIdleAnimationProfile("FloatSquishAnimationProfile").SetStartWithEffect(SFUtils.CreateSEStacks("When Destroyed Apply Overload To Attacker", 2, (WildfrostMod) mod)).SetAttackEffect(SFUtils.CreateSEStacks("Overload", 1, (WildfrostMod) mod)).Register<CardData, CardDataBuilder>();
      CardData cardData4 = new CardDataBuilder((WildfrostMod) mod).CreateUnit("DesecratedSoul", "Desecrated Soul").WithValue(150).WithCardType("Clunker").SetSprites(SFUtils.LoadSprite(mod.ModDirectory, "Images\\Cards\\Enemies\\DesecratedSoul"), cardData1.backgroundSprite).SetStats().WithBloodProfile("Blood Profile Blue (x2)").WithIdleAnimationProfile("ShakeAnimationProfile").SetTraits(SFUtils.CreateTraitStacks("Frontline", 1, (WildfrostMod) mod)).SetStartWithEffect(SFUtils.CreateSEStacks("Scrap", 3, (WildfrostMod) mod), SFUtils.CreateSEStacks("Teeth", 2, (WildfrostMod) mod), new CardData.StatusEffectStacks(data4, 3)).AsEnemyClunker().Register<CardData, CardDataBuilder>();
      CardData cardData5 = new CardDataBuilder((WildfrostMod) mod).CreateUnit("EmberKnight", "Ember Knight").WithValue(200).WithCardType("Enemy").SetSprites(SFUtils.LoadSprite(mod.ModDirectory, "Images\\Cards\\Enemies\\EmberKnight"), cardData1.backgroundSprite).SetStats(new int?(8), new int?(2), 3).WithBloodProfile("Blood Profile Blue (x2)").WithIdleAnimationProfile("GoopAnimationProfile").SetStartWithEffect(new CardData.StatusEffectStacks(data1, 2)).Register<CardData, CardDataBuilder>();
      CardData cardData6 = new CardDataBuilder((WildfrostMod) mod).CreateUnit("SorrowingSoul", "The Sorrowing Soul").WithValue(250).WithCardType("Enemy").SetSprites(SFUtils.LoadSprite(mod.ModDirectory, "Images\\Cards\\Enemies\\SorrowingSoul"), cardData1.backgroundSprite).SetStats(new int?(12), counter: 6).WithBloodProfile("Blood Profile Blue (x2)").WithIdleAnimationProfile("GoopAnimationProfile").SetAttackEffect(SFUtils.CreateSEStacks("Overload", 2, (WildfrostMod) mod)).SetStartWithEffect(new CardData.StatusEffectStacks(data2, 1), SFUtils.CreateSEStacks("ImmuneToSnow", 1, (WildfrostMod) mod)).Register<CardData, CardDataBuilder>();
      CardData cardData7 = mod.Get<CardData>("Flash");
      CardData cardData8 = new CardDataBuilder((WildfrostMod) mod).CreateUnit("NewVesta", "Vesta").WithValue(250).WithCardType("Enemy").SetSprites(cardData7.mainSprite, cardData1.backgroundSprite).SetStats(new int?(8), counter: 4).WithBloodProfile(cardData7.bloodProfile).WithIdleAnimationProfile(cardData7.idleAnimationProfile).SetTraits(SFUtils.CreateTraitStacks("Barrage", 1, (WildfrostMod) mod)).SetAttackEffect(SFUtils.CreateSEStacks("Double Overload", 1, (WildfrostMod) mod)).Register<CardData, CardDataBuilder>();
      BattleWavePoolData battleWavePoolData1 = SFUtils.CreateBattleWavePoolData((WildfrostMod) mod, "OverburnBattle", "Wave Pool 1", new BattleWavePoolData.Wave[2]
      {
        SFUtils.CreateBattleWaveData(new CardData[3]
        {
          cardData3,
          cardData3,
          cardData5
        }),
        SFUtils.CreateBattleWaveData(new CardData[3]
        {
          cardData3,
          cardData5,
          cardData5
        })
      });
      BattleWavePoolData battleWavePoolData2 = SFUtils.CreateBattleWavePoolData((WildfrostMod) mod, "OverburnBattle", "Wave Pool 2", new BattleWavePoolData.Wave[3]
      {
        SFUtils.CreateBattleWaveData(new CardData[4]
        {
          cardData5,
          cardData4,
          cardData6,
          cardData3
        }),
        SFUtils.CreateBattleWaveData(new CardData[4]
        {
          cardData3,
          cardData4,
          cardData5,
          cardData6
        }),
        SFUtils.CreateBattleWaveData(new CardData[4]
        {
          cardData3,
          cardData3,
          cardData4,
          cardData6
        })
      });
      BattleWavePoolData battleWavePoolData3 = SFUtils.CreateBattleWavePoolData((WildfrostMod) mod, "OverburnBattle", "Wave Pool 3", new BattleWavePoolData.Wave[4]
      {
        SFUtils.CreateBattleWaveData(new CardData[4]
        {
          cardData2,
          cardData3,
          cardData5,
          cardData8
        }, true),
        SFUtils.CreateBattleWaveData(new CardData[4]
        {
          cardData2,
          cardData3,
          cardData5,
          cardData5
        }, true),
        SFUtils.CreateBattleWaveData(new CardData[4]
        {
          cardData2,
          cardData5,
          cardData5,
          cardData8
        }, true),
        SFUtils.CreateBattleWaveData(new CardData[4]
        {
          cardData2,
          cardData5,
          cardData5,
          cardData3
        }, true)
      });
      BattleTools.SetInTier(3, new Snowfall2.Builders.BattleDataBuilder((WildfrostMod) mod).CreateBattle("OverburnBattle", "Wickered Souls", SFUtils.LoadSprite(mod.ModDirectory, "Images\\Encounters\\Wickers"), new BattleWavePoolData[3]
      {
        battleWavePoolData1,
        battleWavePoolData2,
        battleWavePoolData3
      }).Register<BattleData, Snowfall2.Builders.BattleDataBuilder>().name);
    }
  }
}
