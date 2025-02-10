// Decompiled with JetBrains decompiler
// Type: Snowfall2.Data.Encounters.CrowerEncounterData
// Assembly: Snowfall, Version=0.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 26AFE777-3FAB-4D6F-AF6C-494837402D4A
// Assembly location: C:\Users\harri\AppData\Local\Temp\Temp1_Snowfall_-_Alpha_2.1.2.zip\Snowfall.dll

using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using Snowfall2.Classes.StatusEffects;
using Snowfall2.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Snowfall2.Data.Encounters
{
  public static class CrowerEncounterData
  {
    public static void Load(SnowfallMod mod)
    {
      StatusEffectData data1 = new StatusEffectDataBuilder((WildfrostMod) mod).Create<StatusEffectApplyXWhenUnitIsKilled>("StealDMGOfKilledUnits").WithText("When a unit is killed, gain their <keyword=attack>").FreeModify<StatusEffectApplyXWhenUnitIsKilled>((Action<StatusEffectApplyXWhenUnitIsKilled>) (se =>
      {
        se.effectToApply = mod.Get<StatusEffectData>("Increase Attack");
        se.applyToFlags = StatusEffectApplyX.ApplyToFlags.Self;
        se.ally = true;
        se.enemy = true;
        se.unitConstraints = new TargetConstraint[1]
        {
          (TargetConstraint) SFUtils.CreateTargetConstraint<TargetConstraintAttackMoreThan>()
        };
        se.targetConstraints = new TargetConstraint[0];
        se.applyConstraints = new TargetConstraint[0];
        se.applyEqualAmount = true;
        se.contextEqualAmount = (ScriptableAmount) SFUtils.CreateScriptableAmount<ScriptableCurrentAttack>();
        se.canBeBoosted = false;
        se.type = "";
      })).Register<StatusEffectData, StatusEffectDataBuilder>();
      StatusEffectData data2 = new StatusEffectDataBuilder((WildfrostMod) mod).Create<StatusEffectApplyXPostAttack>("EatRandomAllyAbsorbAttackAndEffects").WithText("After attacking, eat a random ally, absorbing their <keyword=attack> and <keyword=health>").FreeModify<StatusEffectApplyXPostAttack>((Action<StatusEffectApplyXPostAttack>) (se =>
      {
        se.effectToApply = mod.Get<StatusEffectData>("Eat (Health & Attack)");
        se.applyToFlags = StatusEffectApplyX.ApplyToFlags.RandomAlly;
        se.targetConstraints = new TargetConstraint[0];
        se.applyConstraints = new TargetConstraint[2]
        {
          (TargetConstraint) SFUtils.CreateTargetConstraint<TargetConstraintAttackMoreThan>(moreThan: -1),
          (TargetConstraint) SFUtils.CreateTargetConstraint<TargetConstraintIsCardType>(allowedTypes: new CardType[4]
          {
            mod.Get<CardType>("Enemy"),
            mod.Get<CardType>("Clunker"),
            mod.Get<CardType>("Friendly"),
            mod.Get<CardType>("Summoned")
          })
        };
        se.type = "";
      })).Register<StatusEffectData, StatusEffectDataBuilder>();
      StatusEffectData data3 = new StatusEffectDataBuilder((WildfrostMod) mod).Create<StatusEffectApplyXWhenDestroyed>("ReduceAllyCounterWhenDestroyed").WithText("When killed, reduce <keyword=counter> of a random ally by <{a}>").FreeModify<StatusEffectApplyXWhenDestroyed>((Action<StatusEffectApplyXWhenDestroyed>) (se =>
      {
        se.effectToApply = mod.Get<StatusEffectData>("Reduce Max Counter");
        se.applyToFlags = StatusEffectApplyX.ApplyToFlags.RandomAlly;
        se.targetConstraints = new TargetConstraint[0];
        se.applyConstraints = new TargetConstraint[0];
        se.targetMustBeAlive = false;
        se.canBeBoosted = true;
        se.type = "";
      })).Register<StatusEffectData, StatusEffectDataBuilder>();
      StatusEffectDataBuilder instantHurt2Strengthen = new StatusEffectDataBuilder((WildfrostMod) mod).Create<StatusEffectInstantMultipleWeighted>("InstantHurt2Strengthen").FreeModify<StatusEffectInstantMultipleWeighted>((Action<StatusEffectInstantMultipleWeighted>) (se =>
      {
        se.effects = new StatusEffectInstant[2]
        {
          mod.GetStatusEffect<StatusEffectInstant>("Reduce Max Health"),
          mod.GetStatusEffect<StatusEffectInstant>("Increase Attack")
        };
        se.weights = new int[2]{ 0, 2 };
        se.multiply = false;
        se.targetConstraints = new TargetConstraint[0];
        se.type = "";
        se.canBeBoosted = true;
      }));
      StatusEffectData data4 = new StatusEffectDataBuilder((WildfrostMod) mod).Create<StatusEffectApplyXOnTurn>("Hurt2AndStrengthenRandomAlly").WithText("Increase a random ally's <keyword=attack> by <{ap2}>, but reduce their <keyword=health> by <{a}>").FreeModify<StatusEffectApplyXOnTurn>((Action<StatusEffectApplyXOnTurn>) (se =>
      {
        se.effectToApply = (StatusEffectData) (DataFileBuilder<StatusEffectData, StatusEffectDataBuilder>) instantHurt2Strengthen;
        se.applyToFlags = StatusEffectApplyX.ApplyToFlags.RandomAlly;
        se.targetConstraints = new TargetConstraint[0];
        se.applyConstraints = new TargetConstraint[1]
        {
          (TargetConstraint) SFUtils.CreateTargetConstraint<TargetConstraintDoesAttack>()
        };
        se.canBeBoosted = true;
        se.type = "";
      })).Register<StatusEffectData, StatusEffectDataBuilder>();
      StatusEffectData temporaryWild = new StatusEffectDataBuilder((WildfrostMod) mod).Create<StatusEffectTemporaryTrait>("TemporaryWild").FreeModify<StatusEffectTemporaryTrait>((Action<StatusEffectTemporaryTrait>) (se =>
      {
        se.trait = mod.Get<TraitData>("Wild");
        se.targetConstraints = new TargetConstraint[0];
        se.type = "";
      })).Build();
      StatusEffectData data5 = new StatusEffectDataBuilder((WildfrostMod) mod).Create<StatusEffectWhileActiveX>("WhileActiveApplyWildToAllAllies").WithText("While active, apply <keyword=wild> to all allies").FreeModify<StatusEffectWhileActiveX>((Action<StatusEffectWhileActiveX>) (se =>
      {
        se.effectToApply = temporaryWild;
        se.applyToFlags = StatusEffectApplyX.ApplyToFlags.Allies;
        se.targetConstraints = new TargetConstraint[0];
        se.applyConstraints = new TargetConstraint[0];
        se.type = "";
      })).Register<StatusEffectData, StatusEffectDataBuilder>();
      StatusEffectData pushWhenDeployed = new StatusEffectDataBuilder((WildfrostMod) mod).Create<StatusEffectApplyXWhenDeployed>("PushWhenDeployed").FreeModify<StatusEffectApplyXWhenDeployed>((Action<StatusEffectApplyXWhenDeployed>) (se =>
      {
        se.effectToApply = mod.Get<StatusEffectData>("Push");
        se.applyToFlags = StatusEffectApplyX.ApplyToFlags.Self;
        se.targetConstraints = new TargetConstraint[0];
        se.applyConstraints = new TargetConstraint[0];
        se.type = "";
      })).Register<StatusEffectData, StatusEffectDataBuilder>();
      string[] strArray = new string[6]
      {
        "Chikaiju",
        "Chikagoru",
        "Chikashi",
        "Chikasan",
        "Chikani",
        "Chikichi"
      };
      Sprite[] spriteArray = new Sprite[6]
      {
        SFUtils.LoadSprite(mod.ModDirectory, "Images\\Cards\\Enemies\\Chikaiju"),
        mod.Get<CardData>("TailsOne").mainSprite,
        mod.Get<CardData>("TailsTwo").mainSprite,
        mod.Get<CardData>("TailsThree").mainSprite,
        mod.Get<CardData>("TailsFour").mainSprite,
        mod.Get<CardData>("TailsFive").mainSprite
      };
      int[] numArray = new int[6]{ 5, 3, 2, 2, 1, 1 };
      List<(string, CardData, StatusEffectData)> valueTupleList = new List<(string, CardData, StatusEffectData)>();
      for (int index = 0; index < strArray.Length; ++index)
      {
        string englishTitle = strArray[index];
        int num = strArray.Length - index;
        CardDataBuilder builder = new CardDataBuilder((WildfrostMod) mod).CreateUnit("Evil" + englishTitle, englishTitle).WithValue(index > 0 ? 50 : 400).WithCardType(mod.Get<CardType>("Enemy")).SetSprites(spriteArray[index], mod.Get<CardData>("TailsOne").backgroundSprite).SetStats(new int?(2 * (strArray.Length - index) + (index == 0 ? 3 : 0)), new int?(2 * (strArray.Length - index)), 3 + Math.Max(num - 2, 0)).WithBloodProfile().WithIdleAnimationProfile("FlyAnimationProfile");
        if (index > 0)
          builder = builder.SetStartWithEffect(new CardData.StatusEffectStacks(valueTupleList[index - 1].Item3, 1));
        if (numArray[index] > 1)
          builder = builder.SetStartWithEffect(((IEnumerable<CardData.StatusEffectStacks>) builder._data.startWithEffects).AddItem<CardData.StatusEffectStacks>(SFUtils.CreateSEStacks("MultiHit", numArray[index] - 1, (WildfrostMod) mod)).ToArray<CardData.StatusEffectStacks>());
        CardData chikaCard = builder.Register<CardData, CardDataBuilder>();
        StatusEffectSummon summon = new StatusEffectDataBuilder((WildfrostMod) mod).Create<StatusEffectSummon>("Summon" + englishTitle).FreeModify<StatusEffectSummon>((Action<StatusEffectSummon>) (se =>
        {
          se.summonCard = chikaCard;
          se.effectPrefabRef = mod.GetStatusEffect<StatusEffectSummon>("Summon Enemy Leech").effectPrefabRef;
          se.setCardType = mod.Get<CardType>("Summoned");
          se.gainTrait = mod.Get<StatusEffectData>("Temporary Summoned");
          se.eventPriority = 99999;
        })).Register<StatusEffectData, StatusEffectDataBuilder>() as StatusEffectSummon;
        StatusEffectData instantSummon = new StatusEffectDataBuilder((WildfrostMod) mod).Create<StatusEffectInstantSummon>("InstantSummon" + englishTitle).FreeModify<StatusEffectInstantSummon>((Action<StatusEffectInstantSummon>) (se =>
        {
          se.summonPosition = StatusEffectInstantSummon.Position.InFrontOf;
          se.targetSummon = summon;
          se.withEffects = new StatusEffectData[1]
          {
            pushWhenDeployed
          };
        })).Register<StatusEffectData, StatusEffectDataBuilder>();
        StatusEffectData statusEffectData = new StatusEffectDataBuilder((WildfrostMod) mod).Create<StatusEffectApplyXWhenDestroyed>("SummonWhenDestroyed" + englishTitle).WithText("When killed, summon <card=" + Extensions.PrefixGUID("Evil" + englishTitle, (WildfrostMod) mod) + "> to the back of the row").FreeModify<StatusEffectApplyXWhenDestroyed>((Action<StatusEffectApplyXWhenDestroyed>) (se =>
        {
          se.effectToApply = instantSummon;
          se.applyToFlags = StatusEffectApplyX.ApplyToFlags.Self;
          se.targetConstraints = new TargetConstraint[0];
          se.applyConstraints = new TargetConstraint[0];
          se.targetMustBeAlive = false;
          se.type = "";
        })).Register<StatusEffectData, StatusEffectDataBuilder>();
        valueTupleList.Add((englishTitle, chikaCard, statusEffectData));
      }
      CardData cardData1 = mod.Get<CardData>("Reaper");
      CardData cardData2 = new CardDataBuilder((WildfrostMod) mod).Create("ShadyBrewer").WithTitle("Shady Brewer").AsUnit().WithValue(200).WithCardType(mod.Get<CardType>("Enemy")).SetSprites(SFUtils.LoadSprite(mod.ModDirectory, "Images\\Cards\\Enemies\\ShadyBrewer"), cardData1.backgroundSprite).SetStats(new int?(9), counter: 5).WithBloodProfile().WithIdleAnimationProfile("HangAnimationProfile").SetStartWithEffect(new CardData.StatusEffectStacks(data5, 1), SFUtils.CreateSEStacks("On Turn Escape To Self", 1, (WildfrostMod) mod)).Register<CardData, CardDataBuilder>();
      CardData cardData3 = new CardDataBuilder((WildfrostMod) mod).Create("Executioner").WithTitle("Hack-n-Slash").AsUnit().WithValue(250).WithCardType(mod.Get<CardType>("Enemy")).SetSprites(SFUtils.LoadSprite(mod.ModDirectory, "Images\\Cards\\Enemies\\Executioner"), cardData1.backgroundSprite).SetStats(new int?(17), new int?(4), 5).WithBloodProfile().WithIdleAnimationProfile("ShakeAnimationProfile").SetStartWithEffect(new CardData.StatusEffectStacks(data4, 2)).Register<CardData, CardDataBuilder>();
      CardData cardData4 = new CardDataBuilder((WildfrostMod) mod).Create("Crower").WithTitle("Crower").AsUnit().WithValue(100).WithCardType(mod.Get<CardType>("Enemy")).SetSprites(SFUtils.LoadSprite(mod.ModDirectory, "Images\\Cards\\Enemies\\SunCrower"), mod.Get<CardData>("Egg").backgroundSprite).SetStats(new int?(4), new int?(1), 2).WithBloodProfile().WithIdleAnimationProfile("FloatAnimationProfile").SetStartWithEffect(new CardData.StatusEffectStacks(data3, 1)).Register<CardData, CardDataBuilder>();
      CardData cardData5 = new CardDataBuilder((WildfrostMod) mod).Create("EvilMonch").WithTitle("Monch").AsUnit().WithValue(400).WithCardType(mod.Get<CardType>("Enemy")).SetSprites(SFUtils.LoadSprite(mod.ModDirectory, "Images\\Cards\\Enemies\\Monch"), mod.Get<CardData>("Monch").backgroundSprite).SetStats(new int?(22), new int?(2), 4).WithBloodProfile("Blood Profile Black").WithIdleAnimationProfile("FloatAnimationProfile").SetStartWithEffect(new CardData.StatusEffectStacks(data2, 1), SFUtils.CreateSEStacks("ImmuneToSnow", 1, (WildfrostMod) mod)).SetTraits(SFUtils.CreateTraitStacks("Frontline", 1, (WildfrostMod) mod)).Register<CardData, CardDataBuilder>();
      CardData cardData6 = new CardDataBuilder((WildfrostMod) mod).Create("DevicroMiniboss").WithTitle("Devicro").AsUnit().WithValue(650).WithCardType(mod.Get<CardType>("Miniboss")).SetSprites(SFUtils.LoadSprite(mod.ModDirectory, "Images\\Cards\\Enemies\\Devicro"), cardData1.backgroundSprite).SetStats(new int?(45), new int?(0), 6).WithBloodProfile().WithIdleAnimationProfile("ShakeAnimationProfile").SetStartWithEffect(new CardData.StatusEffectStacks(data1, 1), SFUtils.CreateSEStacks("ImmuneToSnow", 1, (WildfrostMod) mod)).Register<CardData, CardDataBuilder>();
      BattleWavePoolData battleWavePoolData1 = SFUtils.CreateBattleWavePoolData((WildfrostMod) mod, "CrowerBattle", "Wave Pool 1", new BattleWavePoolData.Wave[1]
      {
        SFUtils.CreateBattleWaveData(new CardData[4]
        {
          valueTupleList[valueTupleList.Count - 1].Item2,
          cardData4,
          cardData4,
          cardData3
        })
      });
      BattleWavePoolData battleWavePoolData2 = SFUtils.CreateBattleWavePoolData((WildfrostMod) mod, "CrowerBattle", "Wave Pool 2", new BattleWavePoolData.Wave[2]
      {
        SFUtils.CreateBattleWaveData(new CardData[4]
        {
          cardData2,
          cardData4,
          cardData4,
          cardData5
        }),
        SFUtils.CreateBattleWaveData(new CardData[4]
        {
          cardData2,
          cardData4,
          cardData3,
          cardData5
        })
      });
      BattleWavePoolData battleWavePoolData3 = SFUtils.CreateBattleWavePoolData((WildfrostMod) mod, "CrowerBattle", "Wave Pool 3", new BattleWavePoolData.Wave[2]
      {
        SFUtils.CreateBattleWaveData(new CardData[3]
        {
          cardData6,
          cardData3,
          cardData2
        }, true),
        SFUtils.CreateBattleWaveData(new CardData[3]
        {
          cardData6,
          cardData4,
          cardData2
        }, true)
      });
      BattleTools.SetInTier(4, new Snowfall2.Builders.BattleDataBuilder((WildfrostMod) mod).CreateBattle("CrowerBattle", "Cleaving Crowers", SFUtils.LoadSprite(mod.ModDirectory, "Images\\Encounters\\Crowers"), new BattleWavePoolData[3]
      {
        battleWavePoolData1,
        battleWavePoolData2,
        battleWavePoolData3
      }).Register<BattleData, Snowfall2.Builders.BattleDataBuilder>().name);
    }
  }
}
