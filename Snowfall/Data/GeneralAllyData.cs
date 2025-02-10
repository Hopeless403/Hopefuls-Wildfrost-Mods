// Decompiled with JetBrains decompiler
// Type: Snowfall2.Data.GeneralAllyData
// Assembly: Snowfall, Version=0.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 26AFE777-3FAB-4D6F-AF6C-494837402D4A
// Assembly location: C:\Users\harri\AppData\Local\Temp\Temp1_Snowfall_-_Alpha_2.1.2.zip\Snowfall.dll

using Deadpan.Enums.Engine.Components.Modding;
using Snowfall2.Classes.BossRewardDatas;
using Snowfall2.Classes.CardScripts;
using Snowfall2.Classes.ScriptableAmounts;
using Snowfall2.Classes.StatusEffects;
using Snowfall2.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Snowfall2.Data
{
  public static class GeneralAllyData
  {
    private static readonly Dictionary<string, string> Upgrades = new Dictionary<string, string>()
    {
      {
        "MinimokoAlly",
        "MakokoAlly"
      },
      {
        "Cubbu",
        "GrizzleAlly"
      },
      {
        "GrombleAlly",
        "BigfootAlly"
      },
      {
        "NewBerryWitch",
        "Sweetcaster"
      }
    };

    private static void LoadSpecialCharms(WildfrostMod mod)
    {
      KeywordData keyword = new Snowfall2.Builders.KeywordDataBuilder(mod).CreateKeyword("Upgradeable", "Upgradeable", "Can be upgraded somehow...").Register<KeywordData, Snowfall2.Builders.KeywordDataBuilder>();
      TraitData upgradeableTrait = new Snowfall2.Builders.TraitDataBuilder(mod).CreateTrait("Upgradeable", keyword).Register<TraitData, Snowfall2.Builders.TraitDataBuilder>();
      CardScriptTransform cardScriptTransform = SFUtils.CreateCardScript<CardScriptTransform>("UpgradeCard").Set<CardScriptTransform>("transformFunc", (object) (Func<string, string>) (name =>
      {
        if (GeneralAllyData.Upgrades.ContainsKey(name))
          return GeneralAllyData.Upgrades[name];
        foreach (KeyValuePair<string, string> upgrade in GeneralAllyData.Upgrades)
        {
          string str = Extensions.PrefixGUID(upgrade.Key, mod);
          if (name == str)
            return upgrade.Value;
        }
        return (string) null;
      }));
      CardUpgradeData cardUpgradeData = new CardUpgradeDataBuilder(mod).Create("UpgradeCard").WithType(CardUpgradeData.Type.Charm).WithTitle("Upgrade Charm").WithText("Upgrades an ally, but makes them unable to have charms").WithTier(-3).WithImage(SFUtils.LoadSprite(mod.ModDirectory, "Images\\Charms\\UpgradeCharm")).SetScripts((CardScript) cardScriptTransform).FreeModify((Action<CardUpgradeData>) (charm => charm.targetConstraints = new TargetConstraint[1]
      {
        (TargetConstraint) SFUtils.CreateTargetConstraint<TargetConstraintHasTrait>(trait: upgradeableTrait)
      })).Register<CardUpgradeData, CardUpgradeDataBuilder>();
      BossRewardData[] bossRewards = ((IEnumerable<CampaignNodeTypeBoss.AreaProfile>) ((CampaignNodeTypeBoss) mod.Get<CampaignNodeType>("CampaignNodeBoss")).areaProfiles).First<CampaignNodeTypeBoss.AreaProfile>((Func<CampaignNodeTypeBoss.AreaProfile, bool>) (profile => profile.areaIndex == 1)).pool.bossRewards;
      bossRewards[Math.Min(bossRewards.Length / 2, bossRewards.Length - 1)] = (BossRewardData) ScriptableObject.CreateInstance<BossRewardDataSpecificCharm>().Set<BossRewardDataSpecificCharm>("upgradeName", (object) cardUpgradeData.name);
    }

    public static void Load(List<CardData> units, List<CardData> items, WildfrostMod mod)
    {
      GeneralAllyData.LoadSpecialCharms(mod);
      KeywordData keyword = new Snowfall2.Builders.KeywordDataBuilder(mod).CreateKeyword("Sneak", "Sneak", "Attacks ignore Smackback & \"when hit\" effects").Register<KeywordData, Snowfall2.Builders.KeywordDataBuilder>();
      StatusEffectData statusEffectData = new StatusEffectDataBuilder(mod).Create<StatusEffectSneak>("Sneak").Register<StatusEffectData, StatusEffectDataBuilder>();
      TraitData data1 = new Snowfall2.Builders.TraitDataBuilder(mod).CreateTrait("Sneak", keyword).SetEffects(statusEffectData).Register<TraitData, Snowfall2.Builders.TraitDataBuilder>();
      StatusEffectData data2 = new StatusEffectDataBuilder(mod).Create<StatusEffectApplyXOnHit>("OnHitReduceAttackToSelf").WithText("Reduce own <keyword=attack> by <{a}>").FreeModify<StatusEffectApplyXOnHit>((Action<StatusEffectApplyXOnHit>) (se =>
      {
        se.effectToApply = mod.Get<StatusEffectData>("Reduce Attack");
        se.applyToFlags = StatusEffectApplyX.ApplyToFlags.Self;
        se.targetConstraints = new TargetConstraint[0];
        se.applyConstraints = new TargetConstraint[0];
        se.canBeBoosted = true;
        se.type = "";
      })).Register<StatusEffectData, StatusEffectDataBuilder>();
      StatusEffectData data3 = new StatusEffectDataBuilder(mod).Create<StatusEffectApplyXInstant>("SnowEqualToFrost").WithText("Replace <keyword=frost> with equal <keyword=snow>").FreeModify<StatusEffectApplyXInstant>((Action<StatusEffectApplyXInstant>) (se =>
      {
        se.effectToApply = mod.Get<StatusEffectData>("Snow");
        se.applyToFlags = StatusEffectApplyX.ApplyToFlags.Self;
        se.targetConstraints = new TargetConstraint[0];
        se.applyConstraints = new TargetConstraint[0];
        se.scriptableAmount = (ScriptableAmount) SFUtils.CreateScriptableAmount<ScriptableCurrentStatus>(statusType: "frost");
        se.canBeBoosted = false;
        se.stackable = false;
        se.type = "";
      })).Register<StatusEffectData, StatusEffectDataBuilder>();
      StatusEffectData removeFrostInstant = new StatusEffectDataBuilder(mod).Create<StatusEffectInstantLoseSpiceOrFrost>("RemoveFrostInstant").FreeModify<StatusEffectInstantLoseSpiceOrFrost>((Action<StatusEffectInstantLoseSpiceOrFrost>) (se =>
      {
        se.typeToLose = StatusEffectInstantLoseSpiceOrFrost.InstantLoseType.Frost;
        se.targetConstraints = new TargetConstraint[0];
        se.canBeBoosted = true;
        se.type = "";
      })).Register<StatusEffectData, StatusEffectDataBuilder>();
      StatusEffectData data4 = new StatusEffectDataBuilder(mod).Create<StatusEffectApplyXInstant>("RemoveFrost").FreeModify<StatusEffectApplyXInstant>((Action<StatusEffectApplyXInstant>) (se =>
      {
        se.effectToApply = removeFrostInstant;
        se.applyToFlags = StatusEffectApplyX.ApplyToFlags.Self;
        se.targetConstraints = new TargetConstraint[0];
        se.applyConstraints = new TargetConstraint[0];
        se.scriptableAmount = (ScriptableAmount) SFUtils.CreateScriptableAmount<ScriptableCurrentStatus>(statusType: "frost");
        se.canBeBoosted = false;
        se.stackable = false;
        se.type = "";
      })).Register<StatusEffectData, StatusEffectDataBuilder>();
      StatusEffectData data5 = new StatusEffectDataBuilder(mod).Create<StatusEffectApplyXOnTurn>("ReduceCounterRow").WithText("Count down <keyword=counter> of allies in the row by <{a}>").FreeModify<StatusEffectApplyXOnTurn>((Action<StatusEffectApplyXOnTurn>) (se =>
      {
        se.targetConstraints = new TargetConstraint[0];
        se.applyConstraints = new TargetConstraint[1]
        {
          (TargetConstraint) SFUtils.CreateTargetConstraint<TargetConstraintMaxCounterMoreThan>()
        };
        se.applyToFlags = StatusEffectApplyX.ApplyToFlags.AlliesInRow;
        se.effectToApply = mod.Get<StatusEffectData>("Reduce Counter");
        se.canBeBoosted = true;
        se.type = "";
      })).Register<StatusEffectData, StatusEffectDataBuilder>();
      StatusEffectData data6 = new StatusEffectDataBuilder(mod).Create<StatusEffectBonusDamageEqualToX>("ExtraDMGCounter").WithText("Deal additional <keyword=attack> equal to <keyword=counter>").FreeModify<StatusEffectBonusDamageEqualToX>((Action<StatusEffectBonusDamageEqualToX>) (se =>
      {
        se.targetConstraints = new TargetConstraint[0];
        se.scriptableAmount = (ScriptableAmount) SFUtils.CreateScriptableAmount<ScriptableCurrentCounter>();
        se.add = true;
        se.on = StatusEffectBonusDamageEqualToX.On.ScriptableAmount;
        se.type = "";
      })).Register<StatusEffectData, StatusEffectDataBuilder>();
      StatusEffectData data7 = new StatusEffectDataBuilder(mod).Create<StatusEffectApplyXOnTurn>("IncreaseAllAlliesHealth").WithText("Increase <keyword=health> of all allies by <{a}>").FreeModify<StatusEffectApplyXOnTurn>((Action<StatusEffectApplyXOnTurn>) (se =>
      {
        se.effectToApply = mod.Get<StatusEffectData>("Increase Max Health");
        se.applyToFlags = StatusEffectApplyX.ApplyToFlags.Allies;
        se.targetConstraints = new TargetConstraint[0];
        se.applyConstraints = new TargetConstraint[1]
        {
          (TargetConstraint) SFUtils.CreateTargetConstraint<TargetConstraintHasHealth>()
        };
        se.canBeBoosted = true;
        se.type = "";
      })).Register<StatusEffectData, StatusEffectDataBuilder>();
      StatusEffectApplyXOnTurn data8 = new StatusEffectDataBuilder(mod).Create<StatusEffectApplyXInstant>("CleanseAllAllies").FreeModify<StatusEffectApplyXInstant>((Action<StatusEffectApplyXInstant>) (se =>
      {
        se.effectToApply = mod.Get<StatusEffectData>("Cleanse");
        se.applyToFlags = StatusEffectApplyX.ApplyToFlags.Allies;
        se.targetConstraints = new TargetConstraint[1]
        {
          (TargetConstraint) SFUtils.CreateTargetConstraint<TargetConstraintDamaged>(not: true)
        };
        se.applyConstraints = new TargetConstraint[0];
        se.canBeBoosted = false;
        se.stackable = false;
        se.type = "";
      })).Register<StatusEffectData, StatusEffectDataBuilder>().ApplyBy<StatusEffectApplyXOnTurn>(mod, "CleanseAllAlliesIfUndamaged", "If undamaged, <keyword=cleanse> all allies");
      StatusEffectData data9 = new StatusEffectDataBuilder(mod).Create<StatusEffectApplyXWhenHit>("WhenHitEscape").WithText("When hit, escape from the battle").FreeModify<StatusEffectApplyXWhenHit>((Action<StatusEffectApplyXWhenHit>) (se =>
      {
        se.effectToApply = mod.Get<StatusEffectData>("Escape");
        se.applyToFlags = StatusEffectApplyX.ApplyToFlags.Self;
        se.targetConstraints = new TargetConstraint[0];
        se.applyConstraints = new TargetConstraint[0];
        se.canBeBoosted = false;
        se.stackable = false;
        se.type = "";
      })).Register<StatusEffectData, StatusEffectDataBuilder>();
      StatusEffectData data10 = new StatusEffectDataBuilder(mod).Create<StatusEffectApplyXWhenAllyIsHit>("PunishFrost").WithText("When ally is hit, apply <{a}> <keyword=frost> to the attacker").FreeModify<StatusEffectApplyXWhenAllyIsHit>((Action<StatusEffectApplyXWhenAllyIsHit>) (se =>
      {
        se.effectToApply = mod.Get<StatusEffectData>("Frost");
        se.applyToFlags = StatusEffectApplyX.ApplyToFlags.Attacker;
        se.targetConstraints = new TargetConstraint[0];
        se.applyConstraints = new TargetConstraint[1]
        {
          (TargetConstraint) SFUtils.CreateTargetConstraint<TargetConstraintOnBoard>()
        };
        se.canBeBoosted = true;
        se.stackable = true;
        se.type = "";
      })).Register<StatusEffectData, StatusEffectDataBuilder>();
      new StatusEffectDataBuilder(mod).Create<StatusEffectApplyXOnKill>("OnKillGainScrap").WithText("On Kill: Gain <{a}> <keyword=scrap>").FreeModify<StatusEffectApplyXOnKill>((Action<StatusEffectApplyXOnKill>) (se =>
      {
        se.effectToApply = mod.Get<StatusEffectData>("Scrap");
        se.applyToFlags = StatusEffectApplyX.ApplyToFlags.Self;
        se.canBeBoosted = true;
        se.stackable = true;
        se.type = "";
      })).Register<StatusEffectData, StatusEffectDataBuilder>();
      StatusEffectData data11 = new StatusEffectDataBuilder(mod).Create<StatusEffectOnTurnApplyXIfCondition>("OnTurnAddFrostOrGainDmg").WithText("If target has <keyword=frost>, gain <{a}> <keyword=attack>, otherwise apply <{a}> <keyword=frost>").FreeModify<StatusEffectOnTurnApplyXIfCondition>((Action<StatusEffectOnTurnApplyXIfCondition>) (se =>
      {
        se.condition = (TargetConstraint) SFUtils.CreateTargetConstraint<TargetConstraintHasStatusType>(statusType: "frost");
        se.onTarget = true;
        se.onSuccess = mod.Get<StatusEffectData>("Increase Attack");
        se.onFailure = mod.Get<StatusEffectData>("Frost");
        se.applyToTargetOnFailure = true;
        se.canBeBoosted = true;
        se.stackable = true;
        se.type = "";
      })).Register<StatusEffectData, StatusEffectDataBuilder>();
      CardData cardData1 = new CardDataBuilder(mod).CreateUnit("Wismer", "Wismer").SetSprites(SFUtils.LoadSprite(mod.ModDirectory, "Images\\Cards\\Allies\\Wismer"), mod.Get<CardData>("Gobling").backgroundSprite).SetStats(new int?(5), new int?(3), 3).WithBloodProfile(mod.Get<CardData>("Gobling").bloodProfile).WithIdleAnimationProfile(mod.Get<CardData>("Gobling").idleAnimationProfile).SetTraits(new CardData.TraitStacks(data1, 1)).Register<CardData, CardDataBuilder>();
      CardData cardData2 = new CardDataBuilder(mod).CreateUnit("BiwaLoat", "Biwa Loat").SetSprites(SFUtils.LoadSprite(mod.ModDirectory, "Images\\Cards\\Allies\\BiwaLoat"), mod.Get<CardData>("Gok").backgroundSprite).SetStats(new int?(6), counter: 4).WithBloodProfile(mod.Get<CardData>("Gok").bloodProfile).WithIdleAnimationProfile(mod.Get<CardData>("Gok").idleAnimationProfile).SetStartWithEffect(new CardData.StatusEffectStacks(data5, 1)).Register<CardData, CardDataBuilder>();
      CardData cardData3 = new CardDataBuilder(mod).CreateUnit("Boar", "Boar").SetSprites(SFUtils.LoadSprite(mod.ModDirectory, "Images\\Cards\\Allies\\Boar"), mod.Get<CardData>("Smakk").backgroundSprite).SetStats(new int?(8), new int?(2), 6).WithBloodProfile(mod.Get<CardData>("Smakk").bloodProfile).WithIdleAnimationProfile(mod.Get<CardData>("Smakk").idleAnimationProfile).SetStartWithEffect(new CardData.StatusEffectStacks(data6, 1)).SetTraits(SFUtils.CreateTraitStacks("Smackback", 1, mod)).Register<CardData, CardDataBuilder>();
      CardData cardData4 = mod.Get<CardData>("Gok");
      CardData cardData5 = new CardDataBuilder(mod).Create("Cinder").WithTitle("Cinder").AsUnit().SetSprites(SFUtils.LoadSprite(mod.ModDirectory, "Images\\Cards\\Allies\\Cinder"), cardData4.backgroundSprite).SetStats(new int?(6), new int?(2), 4).WithBloodProfile(cardData4.bloodProfile).WithIdleAnimationProfile(cardData4.idleAnimationProfile).SetStartWithEffect(SFUtils.CreateSEStacks("On Turn Apply Shell To Self", 3, mod)).SetAttackEffect(SFUtils.CreateSEStacks("Demonize", 1, mod)).Register<CardData, CardDataBuilder>();
      CardData cardData6 = mod.Get<CardData>("BerryMonster");
      CardData cardData7 = new CardDataBuilder(mod).Create("NewEarthBerry").WithTitle("Earth Berry").AsUnit().SetSprites(cardData6.mainSprite, cardData6.backgroundSprite).SetStats(new int?(6), new int?(0), 5).WithBloodProfile(cardData6.bloodProfile).WithIdleAnimationProfile(cardData6.idleAnimationProfile).SetStartWithEffect(cardData6.startWithEffects).Register<CardData, CardDataBuilder>();
      CardData cardData8 = mod.Get<CardData>("BerryWitch");
      CardData cardData9 = new CardDataBuilder(mod).Create("NewBerryWitch").WithTitle("Berry Witch").AsUnit().SetSprites(cardData8.mainSprite, cardData8.backgroundSprite).SetStats(new int?(6), new int?(2), 5).WithBloodProfile(cardData8.bloodProfile).WithIdleAnimationProfile(cardData8.idleAnimationProfile).SetStartWithEffect(cardData8.startWithEffects).SetTraits(SFUtils.CreateTraitStacks("Upgradeable", 1, mod)).Register<CardData, CardDataBuilder>();
      new CardDataBuilder(mod).Create("Sweetcaster").WithTitle("Sweetcaster").AsUnit().SetSprites(SFUtils.LoadSprite(mod.ModDirectory, "Images\\Cards\\Allies\\Sweetcaster"), cardData8.backgroundSprite).SetStats(new int?(9), new int?(3), 3).WithBloodProfile(cardData8.bloodProfile).WithIdleAnimationProfile(cardData8.idleAnimationProfile).SetStartWithEffect(new CardData.StatusEffectStacks(data7, 2), new CardData.StatusEffectStacks((StatusEffectData) data8, 1)).Register<CardData, CardDataBuilder>();
      CardData cardData10 = mod.Get<CardData>("Frostinger");
      CardData cardData11 = new CardDataBuilder(mod).Create("ScaredyCat").WithTitle("Scaredy Cat").AsUnit().SetSprites(SFUtils.LoadSprite(mod.ModDirectory, "Images\\Cards\\Allies\\ScaredyCat"), cardData10.backgroundSprite).SetStats(new int?(3)).WithBloodProfile(cardData10.bloodProfile).WithIdleAnimationProfile("ShakeAnimationProfile").SetStartWithEffect(new CardData.StatusEffectStacks(data9, 1), new CardData.StatusEffectStacks(data10, 2)).Register<CardData, CardDataBuilder>();
      CardData cardData12 = new CardDataBuilder(mod).CreateUnit("Shilly", "Shilly").SetSprites(SFUtils.LoadSprite(mod.ModDirectory, "Images\\Cards\\Allies\\Shilly"), cardData10.backgroundSprite).SetStats(new int?(5), new int?(1), 2).WithBloodProfile(cardData10.bloodProfile).WithIdleAnimationProfile(cardData10.idleAnimationProfile).SetStartWithEffect(new CardData.StatusEffectStacks(data11, 1)).Register<CardData, CardDataBuilder>();
      CardData cardData13 = new CardDataBuilder(mod).CreateItem("GlaceSaber", "Glacial Saber").CanPlayOnHand(false).WithValue(50).SetSprites(SFUtils.LoadSprite(mod.ModDirectory, "Images\\Cards\\Items\\GlaceSaber"), mod.Get<CardData>("IceDice").backgroundSprite).SetDamage(new int?(4)).WithBloodProfile(mod.Get<CardData>("IceDice").bloodProfile).WithIdleAnimationProfile(mod.Get<CardData>("IceDice").idleAnimationProfile).SetStartWithEffect(new CardData.StatusEffectStacks(data2, 1)).SetAttackEffect(SFUtils.CreateSEStacks("Block", 1, mod)).Register<CardData, CardDataBuilder>();
      CardData cardData14 = new CardDataBuilder(mod).CreateItem("SnowFlute", "Flute of Lethargy").CanPlayOnHand(false).WithValue(50).SetSprites(SFUtils.LoadSprite(mod.ModDirectory, "Images\\Cards\\Items\\SnowFlute"), mod.Get<CardData>("SnowGlobe").backgroundSprite).WithBloodProfile(mod.Get<CardData>("SnowGlobe").bloodProfile).WithIdleAnimationProfile(mod.Get<CardData>("SnowGlobe").idleAnimationProfile).SetAttackEffect(new CardData.StatusEffectStacks(data3, 1), new CardData.StatusEffectStacks(data4, 1)).Register<CardData, CardDataBuilder>().Set<CardData>("targetConstraints", (object) new TargetConstraint[1]
      {
        (TargetConstraint) SFUtils.CreateTargetConstraint<TargetConstraintHasStatus>(status: mod.Get<StatusEffectData>("Frost"))
      });
      CardData cardData15 = mod.Get<CardData>("SpikeWall");
      CardData cardData16 = new CardDataBuilder(mod).CreateUnit("SpikeWallAlly", "Spike Wall").WithValue(50).WithCardType(mod.Get<CardType>("Clunker")).SetSprites(cardData15.mainSprite, cardData15.backgroundSprite).SetStats(damage: new int?(2)).WithBloodProfile(cardData15.bloodProfile).WithIdleAnimationProfile(cardData15.idleAnimationProfile).SetStartWithEffect(SFUtils.CreateSEStacks("Scrap", 2, mod), SFUtils.CreateSEStacks("OnKillGainScrap", 1, mod)).SetTraits(cardData15.traits.ToArray()).Register<CardData, CardDataBuilder>();
      units.Add(cardData1);
      units.Add(cardData2);
      units.Add(cardData3);
      units.Add(cardData5);
      units.Add(cardData7);
      units.Add(cardData9);
      units.Add(cardData11);
      units.Add(cardData12);
      items.Add(cardData16);
      items.Add(cardData13);
      items.Add(cardData14);
    }
  }
}
