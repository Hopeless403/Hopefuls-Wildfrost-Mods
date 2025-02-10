// Decompiled with JetBrains decompiler
// Type: Snowfall2.Data.CustomBellData
// Assembly: Snowfall, Version=0.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 26AFE777-3FAB-4D6F-AF6C-494837402D4A
// Assembly location: C:\Users\harri\AppData\Local\Temp\Temp1_Snowfall_-_Alpha_2.1.2.zip\Snowfall.dll

using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using Snowfall2.Classes.Scripts;
using Snowfall2.Classes.StatusEffects;
using Snowfall2.Classes.TargetModes;
using Snowfall2.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Snowfall2.Data
{
  public static class CustomBellData
  {
    public static void Load(WildfrostMod mod)
    {
      CustomBellData.LoadLuminBell(mod);
      CustomBellData.LoadBountyBell(mod);
    }

    public static void Unload(WildfrostMod mod)
    {
      List<HardModeModifierData> list = ((IEnumerable<HardModeModifierData>) MonoBehaviourSingleton<References>.instance.hardModeModifiers).Where<HardModeModifierData>((Func<HardModeModifierData, bool>) (m => m.modifierData.ModAdded == null || m.modifierData.ModAdded.GUID != mod.GUID)).ToList<HardModeModifierData>();
      list.Insert(9, mod.Get<GameModifierData>("Sunbringer").linkedStormBell);
      MonoBehaviourSingleton<References>.instance.hardModeModifiers = list.ToArray();
    }

    private static void LoadLuminBell(WildfrostMod mod)
    {
      mod.Get<CardUpgradeData>("CardUpgradeBoost");
      CardUpgradeData cardUpgradeData = new CardUpgradeDataBuilder(mod).Create("LuminCharm").WithTitle("Luminice Charm").WithText("Start with <1> <keyword=lumin>").WithTier(-3).WithImage(SFUtils.LoadSprite(mod.ModDirectory, "Images\\Charms\\LuminCharm")).WithType(CardUpgradeData.Type.Charm).ChangeEffectBonus(0).SetScripts((CardScript) SFUtils.CreateCardScript<CardScriptAddPassiveEffect>("CardScriptAddPassiveEffect").Set<CardScriptAddPassiveEffect>("effect", (object) mod.Get<StatusEffectData>("Lumin")).Set<CardScriptAddPassiveEffect>("countRange", (object) new Vector2Int(1, 1))).SetConstraints((TargetConstraint) SFUtils.CreateTargetConstraint<TargetConstraintHasAnyEffect>(), (TargetConstraint) SFUtils.CreateTargetConstraint<TargetConstraintEffectsMoreThan>().Set<TargetConstraintEffectsMoreThan>("amount", (object) 0)).Register<CardUpgradeData, CardUpgradeDataBuilder>();
      ScriptUpgradeRandomEnemies instance = ScriptableObject.CreateInstance<ScriptUpgradeRandomEnemies>();
      instance.name = "LuminiceScript";
      instance.illegalCards = new string[4]
      {
        Extensions.PrefixGUID("NewBombom", mod),
        Extensions.PrefixGUID("DesecratedSoul", mod),
        "Gobling",
        "SnormWorm"
      };
      instance.upgradePool = new CardUpgradeData[1]
      {
        cardUpgradeData
      };
      instance.tiers = new ScriptUpgradeEnemies.Tier[9]
      {
        new ScriptUpgradeEnemies.Tier()
        {
          canAffectMiniboss = true,
          upgradesRange = new Vector2Int(1, 1)
        },
        new ScriptUpgradeEnemies.Tier()
        {
          canAffectMiniboss = true,
          upgradesRange = new Vector2Int(1, 1)
        },
        new ScriptUpgradeEnemies.Tier()
        {
          canAffectMiniboss = true,
          upgradesRange = new Vector2Int(1, 1)
        },
        new ScriptUpgradeEnemies.Tier()
        {
          canAffectMiniboss = true,
          upgradesRange = new Vector2Int(1, 1)
        },
        new ScriptUpgradeEnemies.Tier()
        {
          canAffectMiniboss = true,
          upgradesRange = new Vector2Int(1, 1)
        },
        new ScriptUpgradeEnemies.Tier()
        {
          canAffectMiniboss = true,
          upgradesRange = new Vector2Int(1, 1)
        },
        new ScriptUpgradeEnemies.Tier()
        {
          canAffectMiniboss = true,
          upgradesRange = new Vector2Int(1, 1)
        },
        new ScriptUpgradeEnemies.Tier()
        {
          canAffectMiniboss = true,
          upgradesRange = new Vector2Int(1, 1)
        },
        new ScriptUpgradeEnemies.Tier()
        {
          canAffectMiniboss = true,
          upgradesRange = new Vector2Int(1, 1)
        }
      };
      GameModifierData gameModifierData1 = mod.Get<GameModifierData>("BoostAllEffects");
      GameModifierData gameModifierData2 = new Snowfall2.Builders.GameModifierDataBuilder(mod).CreateGameModifier("LuminBell", "Luminice Bell", "A single enemy will be upgraded with a <Luminice Charm> each battle.").WithValue(gameModifierData1.value).SetVisible(gameModifierData1.visible).WithSprites(gameModifierData1.bellSprite, gameModifierData1.dingerSprite).StartScripts((Script) instance).WithPriority(gameModifierData1.scriptPriority).BlockedBy(gameModifierData1.blockedBy).SetRingerSfx(gameModifierData1.ringSfxEvent, gameModifierData1.ringSfxPitch).Register<GameModifierData, Snowfall2.Builders.GameModifierDataBuilder>();
      HardModeModifierData modeModifierData = ScriptableObject.CreateInstance<HardModeModifierData>().Set<HardModeModifierData>("name", (object) "14.Snowfall.LuminStorm").Set<HardModeModifierData>("modifierData", (object) gameModifierData2).Set<HardModeModifierData>("stormPoints", (object) 2).Set<HardModeModifierData>("unlockedByDefault", (object) true).Set<HardModeModifierData>("unlockRequires", (object) new HardModeModifierData[0]).Set<HardModeModifierData>("unlockRequiresPoints", (object) 0);
      gameModifierData2.linkedStormBell = modeModifierData;
      MonoBehaviourSingleton<References>.instance.hardModeModifiers = ((IEnumerable<HardModeModifierData>) MonoBehaviourSingleton<References>.instance.hardModeModifiers).AddItem<HardModeModifierData>(modeModifierData).ToArray<HardModeModifierData>();
    }

    private static void LoadBountyBell(WildfrostMod mod)
    {
      StatusEffectData data1 = new StatusEffectDataBuilder(mod).Create<StatusEffectApplyXOnHit>("ReduceOwnMaxCounter").WithText("Reduce its own <keyword=counter> by <{a}>").FreeModify<StatusEffectApplyXOnHit>((Action<StatusEffectApplyXOnHit>) (se =>
      {
        se.effectToApply = mod.Get<StatusEffectData>("Reduce Max Counter");
        se.applyToFlags = StatusEffectApplyX.ApplyToFlags.Self;
        se.targetConstraints = new TargetConstraint[1]
        {
          (TargetConstraint) SFUtils.CreateTargetConstraint<TargetConstraintMaxCounterMoreThan>()
        };
        se.applyConstraints = new TargetConstraint[1]
        {
          (TargetConstraint) SFUtils.CreateTargetConstraint<TargetConstraintMaxCounterMoreThan>()
        };
        se.canBeBoosted = true;
        se.type = "";
      })).Register<StatusEffectData, StatusEffectDataBuilder>();
      StatusEffectData data2 = new StatusEffectDataBuilder(mod).Create<StatusEffectApplyXWhenRedrawHit>("TriggerWhenRedrawHit").WithText("Trigger when the Redraw Bell is rang").FreeModify<StatusEffectApplyXWhenRedrawHit>((Action<StatusEffectApplyXWhenRedrawHit>) (se =>
      {
        se.effectToApply = mod.Get<StatusEffectData>("Trigger");
        se.applyToFlags = StatusEffectApplyX.ApplyToFlags.Self;
        se.descColorHex = "F99C61";
        se.isReaction = true;
        se.targetConstraints = new TargetConstraint[0];
        se.applyConstraints = new TargetConstraint[0];
        se.type = "";
      })).Register<StatusEffectData, StatusEffectDataBuilder>();
      StatusEffectData stealGold = new StatusEffectDataBuilder(mod).Create<StatusEffectInstantGainGold>("StealGold").FreeModify<StatusEffectInstantGainGold>((Action<StatusEffectInstantGainGold>) (se =>
      {
        se.take = true;
        se.targetConstraints = new TargetConstraint[0];
        se.canBeBoosted = true;
        se.type = "";
      })).Register<StatusEffectData, StatusEffectDataBuilder>();
      StatusEffectData stealGoldOnPlay = new StatusEffectDataBuilder(mod).Create<StatusEffectApplyXOnCardPlayed>("StealGoldOnPlay").FreeModify<StatusEffectApplyXOnCardPlayed>((Action<StatusEffectApplyXOnCardPlayed>) (se =>
      {
        se.effectToApply = stealGold;
        se.applyToFlags = StatusEffectApplyX.ApplyToFlags.Self;
        se.targetConstraints = new TargetConstraint[0];
        se.canBeBoosted = true;
        se.type = "";
      })).Register<StatusEffectData, StatusEffectDataBuilder>();
      StatusEffectData data3 = new StatusEffectDataBuilder(mod).Create<StatusEffectWhileInHandX>("WhileInHandItemsTakeGold").WithText("While in hand, lose <{a}> <keyword=blings> when using an item").FreeModify<StatusEffectWhileInHandX>((Action<StatusEffectWhileInHandX>) (se =>
      {
        se.effectToApply = stealGoldOnPlay;
        se.applyToFlags = StatusEffectApplyX.ApplyToFlags.Hand;
        se.targetConstraints = new TargetConstraint[0];
        se.canBeBoosted = true;
        se.type = "";
      })).Register<StatusEffectData, StatusEffectDataBuilder>();
      StatusEffectData statusEffectData = new StatusEffectDataBuilder(mod).Create<StatusEffectChangeTargetMode>("TargetLeaderEffect").FreeModify<StatusEffectChangeTargetMode>((Action<StatusEffectChangeTargetMode>) (se =>
      {
        se.targetMode = (TargetMode) ScriptableObject.CreateInstance<TargetModeLeader>();
        se.targetConstraints = new TargetConstraint[0];
        se.canBeBoosted = false;
        se.type = "";
      })).Register<StatusEffectData, StatusEffectDataBuilder>();
      KeywordData keyword = new Snowfall2.Builders.KeywordDataBuilder(mod).CreateKeyword("TargetLeader", "Target Leader", "Always target the enemy leader").Register<KeywordData, Snowfall2.Builders.KeywordDataBuilder>();
      TraitData data4 = new Snowfall2.Builders.TraitDataBuilder(mod).CreateTrait("TargetLeader", keyword).SetEffects(statusEffectData).Register<TraitData, Snowfall2.Builders.TraitDataBuilder>();
      mod.Get<TraitData>("Barrage").overrides = ((IEnumerable<TraitData>) mod.Get<TraitData>("Barrage").overrides).AddItem<TraitData>(data4).ToArray<TraitData>();
      mod.Get<TraitData>("Aimless").overrides = ((IEnumerable<TraitData>) mod.Get<TraitData>("Aimless").overrides).AddItem<TraitData>(data4).ToArray<TraitData>();
      CardData gunslinger = new CardDataBuilder(mod).CreateUnit("BountyHunter", "Gunslinger").WithValue(200).WithCardType("Enemy").SetSprites(SFUtils.LoadSprite(mod.ModDirectory, "Images\\Cards\\Enemies\\BountyHunter"), mod.Get<CardData>("CrazyEyes").backgroundSprite).SetStats(new int?(11), new int?(3), 4).WithBloodProfile("BloodProfileHusk").WithIdleAnimationProfile("ShakeAnimationProfile").SetStartWithEffect(new CardData.StatusEffectStacks(data1, 1), SFUtils.CreateSEStacks("ImmuneToSnow", 1, mod)).SetTraits(new CardData.TraitStacks(data4, 1)).Register<CardData, CardDataBuilder>();
      CardData hothead = new CardDataBuilder(mod).CreateUnit("HotHead", "Hot Head").WithValue(200).WithCardType("Enemy").SetSprites(SFUtils.LoadSprite(mod.ModDirectory, "Images\\Cards\\Enemies\\HotHead"), mod.Get<CardData>("CrazyEyes").backgroundSprite).SetStats(new int?(13), new int?(4), 7).WithBloodProfile("BloodProfileHusk").WithIdleAnimationProfile("ShakeAnimationProfile").SetStartWithEffect(new CardData.StatusEffectStacks(data2, 1), SFUtils.CreateSEStacks("ImmuneToSnow", 1, mod)).SetTraits(SFUtils.CreateTraitStacks("Bombard 1", 1, mod)).Register<CardData, CardDataBuilder>();
      CardData fickleHandRock = new CardDataBuilder(mod).CreateItem("FickleHandRock", "Rosha Hand").CanPlayOnHand(false).SetSprites(SFUtils.LoadSprite(mod.ModDirectory, "Images\\Cards\\Items\\FickleHandRock"), mod.Get<CardData>("CrazyEyes").backgroundSprite).SetDamage(new int?(0)).WithBloodProfile("BloodProfileBlack").WithIdleAnimationProfile("FloatAnimationProfile").SetStartWithEffect(new CardData.StatusEffectStacks(data3, 5)).SetAttackEffect(SFUtils.CreateSEStacks("Shell", 1, mod)).SetTraits(SFUtils.CreateTraitStacks("Consume", 1, mod)).Register<CardData, CardDataBuilder>();
      CardData fickleHandScissors = new CardDataBuilder(mod).CreateItem("FickleHandScissors", "Rosha Hand").CanPlayOnHand(false).SetSprites(SFUtils.LoadSprite(mod.ModDirectory, "Images\\Cards\\Items\\FickleHandScissors"), mod.Get<CardData>("CrazyEyes").backgroundSprite).SetDamage(new int?(0)).WithBloodProfile("BloodProfileBlack").WithIdleAnimationProfile("FloatAnimationProfile").SetStartWithEffect(new CardData.StatusEffectStacks(data3, 5)).SetAttackEffect(SFUtils.CreateSEStacks("Spice", 1, mod)).SetTraits(SFUtils.CreateTraitStacks("Consume", 1, mod)).Register<CardData, CardDataBuilder>();
      CardData fickleHandPaper = new CardDataBuilder(mod).CreateItem("FickleHandPaper", "Rosha Hand").CanPlayOnHand(false).SetSprites(SFUtils.LoadSprite(mod.ModDirectory, "Images\\Cards\\Items\\FickleHandPaper"), mod.Get<CardData>("CrazyEyes").backgroundSprite).SetDamage(new int?(0)).WithBloodProfile("BloodProfileBlack").WithIdleAnimationProfile("FloatAnimationProfile").SetStartWithEffect(new CardData.StatusEffectStacks(data3, 5)).SetAttackEffect(SFUtils.CreateSEStacks("Frost", 1, mod)).SetTraits(SFUtils.CreateTraitStacks("Consume", 1, mod)).Register<CardData, CardDataBuilder>();
      CardData fickleHandGun = new CardDataBuilder(mod).CreateItem("FickleHandGun", "Rosha Hand").CanPlayOnHand(false).SetSprites(SFUtils.LoadSprite(mod.ModDirectory, "Images\\Cards\\Items\\FickleHandGun"), mod.Get<CardData>("CrazyEyes").backgroundSprite).SetDamage(new int?(1)).WithBloodProfile("BloodProfileBlack").WithIdleAnimationProfile("FloatAnimationProfile").SetStartWithEffect(new CardData.StatusEffectStacks(data3, 5)).SetTraits(SFUtils.CreateTraitStacks("Barrage", 1, mod), SFUtils.CreateTraitStacks("Consume", 1, mod)).Register<CardData, CardDataBuilder>();
      StatusEffectData summonFickleHand = new StatusEffectDataBuilder(mod).Create<StatusEffectSummon>("SummonFickleHand").FreeModify<StatusEffectSummon>((Action<StatusEffectSummon>) (se =>
      {
        se.effectPrefabRef = (mod.Get<StatusEffectData>("Instant Summon Junk In Hand") as StatusEffectInstantSummon).targetSummon.effectPrefabRef;
        se.targetConstraints = new TargetConstraint[0];
        se.type = "";
      })).NoStacks().Register<StatusEffectData, StatusEffectDataBuilder>();
      StatusEffectData data5 = new StatusEffectDataBuilder(mod).Create<StatusEffectInstantSummonRand>("AddFickleHandToHand").WithText("Add a Rosha Hand to your hand").FreeModify<StatusEffectInstantSummonRand>((Action<StatusEffectInstantSummonRand>) (se =>
      {
        se.summonCardOptions = new CardData[4]
        {
          fickleHandRock,
          fickleHandPaper,
          fickleHandScissors,
          fickleHandGun
        };
        se.summonPosition = StatusEffectInstantSummon.Position.Hand;
        se.targetSummon = summonFickleHand as StatusEffectSummon;
        se.targetConstraints = new TargetConstraint[0];
        se.type = "";
      })).NoStacks().Register<StatusEffectData, StatusEffectDataBuilder>();
      CardData fickle = new CardDataBuilder(mod).Create("Fickle").WithTitle("Fickle").AsUnit().WithValue(200).WithCardType("Enemy").SetSprites(SFUtils.LoadSprite(mod.ModDirectory, "Images\\Cards\\Enemies\\Fickle"), mod.Get<CardData>("CrazyEyes").backgroundSprite).SetStats(new int?(12), new int?(2), 3).WithBloodProfile("BloodProfileHusk").WithIdleAnimationProfile("ShakeAnimationProfile").SetStartWithEffect(SFUtils.CreateSEStacks("MultiHit", 2, mod), SFUtils.CreateSEStacks("ImmuneToSnow", 1, mod)).SetAttackEffect(new CardData.StatusEffectStacks(data5, 1)).SetTraits(SFUtils.CreateTraitStacks("Aimless", 1, mod), SFUtils.CreateTraitStacks("Sneak", 1, mod)).Register<CardData, CardDataBuilder>();
      int[] source = new int[5]{ 3, 4, 5, 6, 7 };
      ScriptAddEnemies instance = ScriptableObject.CreateInstance<ScriptAddEnemies>();
      instance.profiles = ((IEnumerable<int>) source).SelectMany<int, ScriptAddEnemies.Profile>((Func<int, IEnumerable<ScriptAddEnemies.Profile>>) (i => Enumerable.Range(0, BattleTools.Count(i)).Select<int, ScriptAddEnemies.Profile>((Func<int, ScriptAddEnemies.Profile>) (j => new ScriptAddEnemies.Profile()
      {
        battleData = BattleTools.GetBattle(i, j),
        add = 1,
        toWave = 1,
        randomPosition = true,
        pool = new CardData[3]
        {
          gunslinger,
          hothead,
          fickle
        }
      })))).ToArray<ScriptAddEnemies.Profile>();
      GameModifierData gobblerModifier = mod.Get<GameModifierData>("Sunbringer");
      GameModifierData gameModifierData = new Snowfall2.Builders.GameModifierDataBuilder(mod).CreateGameModifier("BountyBell", "Bounty Bell", "Add a <Bounty Hunter> to each fight after leaving the <Tundra>").WithValue(gobblerModifier.value).SetVisible(gobblerModifier.visible).WithSprites(SFUtils.LoadSprite(mod.ModDirectory, "Images\\Bells\\Bounty", new Vector2?(new Vector2(0.5f, 1f))), SFUtils.LoadSprite(mod.ModDirectory, "Images\\Bells\\BountyChime", new Vector2?(new Vector2(0.5f, 1.04f)))).StartScripts((Script) instance).WithPriority(gobblerModifier.scriptPriority).BlockedBy(gobblerModifier.blockedBy).SetRingerSfx(gobblerModifier.ringSfxEvent, gobblerModifier.ringSfxPitch).Register<GameModifierData, Snowfall2.Builders.GameModifierDataBuilder>();
      HardModeModifierData modeModifierData = ScriptableObject.CreateInstance<HardModeModifierData>().Set<HardModeModifierData>("name", (object) (gobblerModifier.linkedStormBell.name.Split('.')[0] + ".Snowfall.BountyStorm")).Set<HardModeModifierData>("modifierData", (object) gameModifierData).Set<HardModeModifierData>("stormPoints", (object) 3).Set<HardModeModifierData>("unlockedByDefault", (object) gobblerModifier.linkedStormBell.unlockedByDefault).Set<HardModeModifierData>("unlockRequires", (object) gobblerModifier.linkedStormBell.unlockRequires).Set<HardModeModifierData>("unlockRequiresPoints", (object) gobblerModifier.linkedStormBell.unlockRequiresPoints);
      gameModifierData.linkedStormBell = modeModifierData;
      MonoBehaviourSingleton<References>.instance.hardModeModifiers = ((IEnumerable<HardModeModifierData>) MonoBehaviourSingleton<References>.instance.hardModeModifiers).AddItem<HardModeModifierData>(modeModifierData).Where<HardModeModifierData>((Func<HardModeModifierData, bool>) (hm => hm.name != gobblerModifier.linkedStormBell.name)).ToArray<HardModeModifierData>();
    }
  }
}
