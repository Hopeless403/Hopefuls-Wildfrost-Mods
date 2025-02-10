// Decompiled with JetBrains decompiler
// Type: WildfrostModMiya.CardAdder
// Assembly: WildfrostModMiya, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 51F56119-3F77-414A-8824-BFF112DF055A
// Assembly location: C:\Users\harri\Downloads\Wildfrost v1.0.4\BepInEx\plugins\WildfrostModMiya.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Localization;

namespace WildfrostModMiya
{
  public static class CardAdder
  {
    internal static readonly Dictionary<CardAdder.VanillaStatusEffects, string> VanillaStatusEffectsNamesLookUp = new Dictionary<CardAdder.VanillaStatusEffects, string>()
    {
      [CardAdder.VanillaStatusEffects.AddAttackAndHealthToSummon] = "Add Attack & Health To Summon",
      [CardAdder.VanillaStatusEffects.Block] = "Block",
      [CardAdder.VanillaStatusEffects.Bombard1] = "Bombard 1",
      [CardAdder.VanillaStatusEffects.Bombard2] = "Bombard 2",
      [CardAdder.VanillaStatusEffects.BonusDamageEqualToDartsInHand] = "Bonus Damage Equal To Darts In Hand",
      [CardAdder.VanillaStatusEffects.BonusDamageEqualToGoldFactor002] = "Bonus Damage Equal To Gold Factor 0.02",
      [CardAdder.VanillaStatusEffects.BonusDamageEqualToJuice] = "Bonus Damage Equal To Juice",
      [CardAdder.VanillaStatusEffects.BonusDamageEqualToScrapOnBoard] = "Bonus Damage Equal To Scrap On Board",
      [CardAdder.VanillaStatusEffects.BonusDamageEqualToScrap] = "Bonus Damage Equal To Scrap",
      [CardAdder.VanillaStatusEffects.BonusDamageEqualToShell] = "Bonus Damage Equal To Shell",
      [CardAdder.VanillaStatusEffects.BoostEffects] = "Boost Effects",
      [CardAdder.VanillaStatusEffects.Budge] = "Budge",
      [CardAdder.VanillaStatusEffects.CannotRecall] = "Cannot Recall",
      [CardAdder.VanillaStatusEffects.CheckHasJuice] = "Check Has Juice",
      [CardAdder.VanillaStatusEffects.Cleanse] = "Cleanse",
      [CardAdder.VanillaStatusEffects.CombineWhen2Deployed] = "Combine When 2 Deployed",
      [CardAdder.VanillaStatusEffects.CopyEffects] = "Copy Effects",
      [CardAdder.VanillaStatusEffects.Crush] = "Crush",
      [CardAdder.VanillaStatusEffects.DamageEqualToHealth] = "Damage Equal To Health",
      [CardAdder.VanillaStatusEffects.DamageToFrontAllies] = "Damage To Front Allies",
      [CardAdder.VanillaStatusEffects.Demonize] = "Demonize",
      [CardAdder.VanillaStatusEffects.DestroyAfterUse] = "Destroy After Use",
      [CardAdder.VanillaStatusEffects.DestroySelfAfterTurn] = "Destroy Self After Turn",
      [CardAdder.VanillaStatusEffects.DoubleAllSpiceWhenDestroyed] = "Double All Spice When Destroyed",
      [CardAdder.VanillaStatusEffects.DoubleBlock] = "Double Block",
      [CardAdder.VanillaStatusEffects.DoubleInk] = "Double Ink",
      [CardAdder.VanillaStatusEffects.DoubleJuice] = "Double Juice",
      [CardAdder.VanillaStatusEffects.DoubleNegativeEffects] = "Double Negative Effects",
      [CardAdder.VanillaStatusEffects.DoubleOverload] = "Double Overload",
      [CardAdder.VanillaStatusEffects.DoubleShell] = "Double Shell",
      [CardAdder.VanillaStatusEffects.DoubleShroom] = "Double Shroom",
      [CardAdder.VanillaStatusEffects.DoubleSpice] = "Double Spice",
      [CardAdder.VanillaStatusEffects.DoubleVim] = "Double Vim",
      [CardAdder.VanillaStatusEffects.DrawCards] = "Draw Cards",
      [CardAdder.VanillaStatusEffects.EatHealthAndAttack] = "Eat (Health & Attack)",
      [CardAdder.VanillaStatusEffects.EatHealthAndAttackAndEffects] = "Eat (Health, Attack & Effects)",
      [CardAdder.VanillaStatusEffects.EatAlliesInRowHealthAndAttack] = "Eat Allies In Row (Health & Attack)",
      [CardAdder.VanillaStatusEffects.EatRandomAllyHealthAndAttackAndEffects] = "Eat Random Ally (Health, Attack & Effects)",
      [CardAdder.VanillaStatusEffects.Escape] = "Escape",
      [CardAdder.VanillaStatusEffects.FillBoardFinalBoss] = "Fill Board (Final Boss)",
      [CardAdder.VanillaStatusEffects.FinalBossPhase2] = "FinalBossPhase2",
      [CardAdder.VanillaStatusEffects.Flee] = "Flee",
      [CardAdder.VanillaStatusEffects.FreeAction] = "Free Action",
      [CardAdder.VanillaStatusEffects.FrenzyBossPhase2] = "FrenzyBossPhase2",
      [CardAdder.VanillaStatusEffects.Frost] = "Frost",
      [CardAdder.VanillaStatusEffects.GainFrenzyWhenWildUnitKilled] = "Gain Frenzy When Wild Unit Killed",
      [CardAdder.VanillaStatusEffects.GainGoldRange36] = "Gain Gold Range (3-6)",
      [CardAdder.VanillaStatusEffects.GainGold] = "Gain Gold",
      [CardAdder.VanillaStatusEffects.GoatWampusPhase2] = "GoatWampusPhase2",
      [CardAdder.VanillaStatusEffects.HaltSpice] = "Halt Spice",
      [CardAdder.VanillaStatusEffects.Haze] = "Haze",
      [CardAdder.VanillaStatusEffects.HealNoPing] = "Heal (No Ping)",
      [CardAdder.VanillaStatusEffects.HealFrontAllyBasedOnDamageDealt] = "Heal Front Ally Based On Damage Dealt",
      [CardAdder.VanillaStatusEffects.HealFullAndGainEqualSpice] = "Heal Full, Gain Equal Spice",
      [CardAdder.VanillaStatusEffects.HealToFrontAllies] = "Heal To Front Allies",
      [CardAdder.VanillaStatusEffects.Heal] = "Heal",
      [CardAdder.VanillaStatusEffects.HighPriorityPosition] = "High Priority Position",
      [CardAdder.VanillaStatusEffects.HitAllCrownEnemies] = "Hit All Crown Enemies",
      [CardAdder.VanillaStatusEffects.HitAllEnemiesInRow] = "Hit All Enemies In Row",
      [CardAdder.VanillaStatusEffects.HitAllEnemies] = "Hit All Enemies",
      [CardAdder.VanillaStatusEffects.HitAllUndamagedEnemies] = "Hit All Undamaged Enemies",
      [CardAdder.VanillaStatusEffects.HitFurthestTarget] = "Hit Furthest Target",
      [CardAdder.VanillaStatusEffects.HitRandomTarget] = "Hit Random Target",
      [CardAdder.VanillaStatusEffects.ImmuneToFrost] = "ImmuneToFrost",
      [CardAdder.VanillaStatusEffects.ImmuneToSnow] = "ImmuneToSnow",
      [CardAdder.VanillaStatusEffects.ImmuneToSpice] = "ImmuneToSpice",
      [CardAdder.VanillaStatusEffects.ImmuneToVim] = "ImmuneToVim",
      [CardAdder.VanillaStatusEffects.IncreaseAllSpiceAppliedNoDesc] = "Increase All Spice Applied (No Desc)",
      [CardAdder.VanillaStatusEffects.IncreaseAttackAndHealth] = "Increase Attack & Health",
      [CardAdder.VanillaStatusEffects.IncreaseAttackAndLoseHalfHealth] = "Increase Attack & Lose Half Health",
      [CardAdder.VanillaStatusEffects.IncreaseAttackEffect1] = "Increase Attack Effect 1",
      [CardAdder.VanillaStatusEffects.IncreaseAttackWhileAlone] = "Increase Attack While Alone",
      [CardAdder.VanillaStatusEffects.IncreaseAttackWhileDamaged] = "Increase Attack While Damaged",
      [CardAdder.VanillaStatusEffects.IncreaseAttack] = "Increase Attack",
      [CardAdder.VanillaStatusEffects.IncreaseEffects] = "Increase Effects",
      [CardAdder.VanillaStatusEffects.IncreaseMaxCounter] = "Increase Max Counter",
      [CardAdder.VanillaStatusEffects.IncreaseMaxHealth] = "Increase Max Health",
      [CardAdder.VanillaStatusEffects.Injury] = "Injury",
      [CardAdder.VanillaStatusEffects.InstantAddScrap] = "Instant Add Scrap",
      [CardAdder.VanillaStatusEffects.InstantApplyAttackToApplier] = "Instant Apply Attack To Applier",
      [CardAdder.VanillaStatusEffects.InstantApplyCurrentAttackToAllies] = "Instant Apply Current Attack To Allies",
      [CardAdder.VanillaStatusEffects.InstantApplyCurrentAttackToRandomAlly] = "Instant Apply Current Attack To Random Ally",
      [CardAdder.VanillaStatusEffects.InstantApplyFrenzyToItemInHand] = "Instant Apply Frenzy (To Item In Hand)",
      [CardAdder.VanillaStatusEffects.InstantDraw] = "Instant Draw",
      [CardAdder.VanillaStatusEffects.InstantGainAimless] = "Instant Gain Aimless",
      [CardAdder.VanillaStatusEffects.InstantGainFury] = "Instant Gain Fury",
      [CardAdder.VanillaStatusEffects.InstantGainNoomlinToCardInHand] = "Instant Gain Noomlin (To Card In Hand)",
      [CardAdder.VanillaStatusEffects.InstantGainSoulboundToEnemy] = "Instant Gain Soulbound (To Enemy)",
      [CardAdder.VanillaStatusEffects.InstantSummonBloo] = "Instant Summon Bloo",
      [CardAdder.VanillaStatusEffects.InstantSummonCopyOfItem] = "Instant Summon Copy Of Item",
      [CardAdder.VanillaStatusEffects.InstantSummonCopyOnOtherSideWithXHealth] = "Instant Summon Copy On Other Side With X Health",
      [CardAdder.VanillaStatusEffects.InstantSummonCopy] = "Instant Summon Copy",
      [CardAdder.VanillaStatusEffects.InstantSummonDregg] = "Instant Summon Dregg",
      [CardAdder.VanillaStatusEffects.InstantSummonFallow] = "Instant Summon Fallow",
      [CardAdder.VanillaStatusEffects.InstantSummonGearhammerInHand] = "Instant Summon Gearhammer In Hand",
      [CardAdder.VanillaStatusEffects.InstantSummonJunkInHand] = "Instant Summon Junk In Hand",
      [CardAdder.VanillaStatusEffects.InstantSummonSunShardInHand] = "Instant Summon SunShard In Hand",
      [CardAdder.VanillaStatusEffects.InstantSummonTailsFour] = "Instant Summon TailsFour",
      [CardAdder.VanillaStatusEffects.InstantSummonTailsOne] = "Instant Summon TailsOne",
      [CardAdder.VanillaStatusEffects.InstantSummonTailsThree] = "Instant Summon TailsThree",
      [CardAdder.VanillaStatusEffects.InstantSummonTailsTwo] = "Instant Summon TailsTwo",
      [CardAdder.VanillaStatusEffects.Kill] = "Kill",
      [CardAdder.VanillaStatusEffects.LastStand] = "Last Stand",
      [CardAdder.VanillaStatusEffects.LoseHalfHealth] = "Lose Half Health",
      [CardAdder.VanillaStatusEffects.LoseJuice] = "Lose Juice",
      [CardAdder.VanillaStatusEffects.LoseScrap] = "Lose Scrap",
      [CardAdder.VanillaStatusEffects.LowPriorityPosition] = "Low Priority Position",
      [CardAdder.VanillaStatusEffects.Lumin] = "Lumin",
      [CardAdder.VanillaStatusEffects.MultiHitTemporaryAndNotVisible] = "MultiHit (Temporary, Not Visible)",
      [CardAdder.VanillaStatusEffects.MultiHit] = "MultiHit",
      [CardAdder.VanillaStatusEffects.MustHaveJuiceToTrigger] = "Must Have Juice To Trigger",
      [CardAdder.VanillaStatusEffects.Null] = "Null",
      [CardAdder.VanillaStatusEffects.OnCardPlayedAddFuryToTarget] = "On Card Played Add Fury To Target",
      [CardAdder.VanillaStatusEffects.OnCardPlayedAddGearhammerToHand] = "On Card Played Add Gearhammer To Hand",
      [CardAdder.VanillaStatusEffects.OnCardPlayedAddJunkToHand] = "On Card Played Add Junk To Hand",
      [CardAdder.VanillaStatusEffects.OnCardPlayedAddScrapToRandomAlly] = "On Card Played Add Scrap To RandomAlly",
      [CardAdder.VanillaStatusEffects.OnCardPlayedAddSoulboundToRandomAlly] = "On Card Played Add Soulbound To RandomAlly",
      [CardAdder.VanillaStatusEffects.OnCardPlayedAddSunShardToHand] = "On Card Played Add SunShard To Hand",
      [CardAdder.VanillaStatusEffects.OnCardPlayedApplyAttackToSelf] = "On Card Played Apply Attack To Self",
      [CardAdder.VanillaStatusEffects.OnCardPlayedApplyBlockToRandomUnit] = "On Card Played Apply Block To RandomUnit",
      [CardAdder.VanillaStatusEffects.OnCardPlayedApplyFrostToRandomEnemy] = "On Card Played Apply Frost To RandomEnemy",
      [CardAdder.VanillaStatusEffects.OnCardPlayedApplyHazeToRandomEnemy] = "On Card Played Apply Haze To RandomEnemy",
      [CardAdder.VanillaStatusEffects.OnCardPlayedApplyInkToRandomEnemy] = "On Card Played Apply Ink To RandomEnemy",
      [CardAdder.VanillaStatusEffects.OnCardPlayedApplyOverloadToFrontEnemy] = "On Card Played Apply Overload To FrontEnemy",
      [CardAdder.VanillaStatusEffects.OnCardPlayedApplyShellToRandomAlly] = "On Card Played Apply Shell To RandomAlly",
      [CardAdder.VanillaStatusEffects.OnCardPlayedApplyShroomToEnemies] = "On Card Played Apply Shroom To Enemies",
      [CardAdder.VanillaStatusEffects.OnCardPlayedApplySnowToEnemiesInRow] = "On Card Played Apply Snow To EnemiesInRow",
      [CardAdder.VanillaStatusEffects.OnCardPlayedApplySpiceToRandomAlly] = "On Card Played Apply Spice To RandomAlly",
      [CardAdder.VanillaStatusEffects.OnCardPlayedApplyTeethToRandomAlly] = "On Card Played Apply Teeth To RandomAlly",
      [CardAdder.VanillaStatusEffects.OnCardPlayedBoostToRandomAlly] = "On Card Played Boost To RandomAlly",
      [CardAdder.VanillaStatusEffects.OnCardPlayedBoostToRandomEnemy] = "On Card Played Boost To RandomEnemy",
      [CardAdder.VanillaStatusEffects.OnCardPlayedDamageFrostedEnemies] = "On Card Played Damage Frosted Enemies",
      [CardAdder.VanillaStatusEffects.OnCardPlayedDamageInkedEnemies] = "On Card Played Damage Inked Enemies",
      [CardAdder.VanillaStatusEffects.OnCardPlayedDamageToSelfAndAlliesInRow] = "On Card Played Damage To Self & AlliesInRow",
      [CardAdder.VanillaStatusEffects.OnCardPlayedDamageUndamagedEnemies] = "On Card Played Damage Undamaged Enemies",
      [CardAdder.VanillaStatusEffects.OnCardPlayedDestroyRandomCardInHand] = "On Card Played Destroy Random Card In Hand",
      [CardAdder.VanillaStatusEffects.OnCardPlayedDestroyRandomJunkInHand] = "On Card Played Destroy Random Junk In Hand",
      [CardAdder.VanillaStatusEffects.OnCardPlayedDestroyRightmostCardInHand] = "On Card Played Destroy Rightmost Card In Hand",
      [CardAdder.VanillaStatusEffects.OnCardPlayedDoubleVimToSelf] = "On Card Played Double Vim To Self",
      [CardAdder.VanillaStatusEffects.OnCardPlayedLose1JuiceToSelfNoDesc] = "On Card Played Lose 1 Juice To Self (No Desc)",
      [CardAdder.VanillaStatusEffects.OnCardPlayedLoseScrapToSelf] = "On Card Played Lose Scrap To Self",
      [CardAdder.VanillaStatusEffects.OnCardPlayedReduceAttackEffect1ToSelf] = "On Card Played Reduce Attack Effect 1 To Self",
      [CardAdder.VanillaStatusEffects.OnCardPlayedReduceCounterToAllies] = "On Card Played Reduce Counter To Allies",
      [CardAdder.VanillaStatusEffects.OnCardPlayedSacrificeRandomAlly] = "On Card Played Sacrifice RandomAlly",
      [CardAdder.VanillaStatusEffects.OnCardPlayedTakeHealthFromAllies] = "On Card Played Take Health From Allies",
      [CardAdder.VanillaStatusEffects.OnCardPlayedTriggerAgainstAllyBehind] = "On Card Played Trigger Against AllyBehind",
      [CardAdder.VanillaStatusEffects.OnCardPlayedTriggerRandomAlly] = "On Card Played Trigger RandomAlly",
      [CardAdder.VanillaStatusEffects.OnCardPlayedUseRandomItemInHandAgainstRandomEnemy] = "On Card Played Use Random Item In Hand Against Random Enemy",
      [CardAdder.VanillaStatusEffects.OnCardPlayedVimToAllies] = "On Card Played Vim To Allies",
      [CardAdder.VanillaStatusEffects.OnCardPlayedVimToSelf] = "On Card Played Vim To Self",
      [CardAdder.VanillaStatusEffects.OnCardPlayedVoidToEnemies] = "On Card Played Void To Enemies",
      [CardAdder.VanillaStatusEffects.OnHitDamageDamagedTarget] = "On Hit Damage Damaged Target",
      [CardAdder.VanillaStatusEffects.OnHitDamageFrostedTarget] = "On Hit Damage Frosted Target",
      [CardAdder.VanillaStatusEffects.OnHitDamageShelledTarget] = "On Hit Damage Shelled Target",
      [CardAdder.VanillaStatusEffects.OnHitDamageSnowedTarget] = "On Hit Damage Snowed Target",
      [CardAdder.VanillaStatusEffects.OnHitEqualDamageToInkedTarget] = "On Hit Equal Damage To Inked Target",
      [CardAdder.VanillaStatusEffects.OnHitEqualHealToFrontAlly] = "On Hit Equal Heal To FrontAlly",
      [CardAdder.VanillaStatusEffects.OnHitEqualOverloadToTarget] = "On Hit Equal Overload To Target",
      [CardAdder.VanillaStatusEffects.OnHitEqualSnowToTarget] = "On Hit Equal Snow To Target",
      [CardAdder.VanillaStatusEffects.OnHitPullTarget] = "On Hit Pull Target",
      [CardAdder.VanillaStatusEffects.OnHitPushTarget] = "On Hit Push Target",
      [CardAdder.VanillaStatusEffects.OnKillApplyAttackToSelf] = "On Kill Apply Attack To Self",
      [CardAdder.VanillaStatusEffects.OnKillApplyBlockToSelf] = "On Kill Apply Block To Self",
      [CardAdder.VanillaStatusEffects.OnKillApplyGoldToSelf] = "On Kill Apply Gold To Self",
      [CardAdder.VanillaStatusEffects.OnKillApplyScrapToAllies] = "On Kill Apply Scrap To Allies",
      [CardAdder.VanillaStatusEffects.OnKillApplyScrapToAllyBehind] = "On Kill Apply Scrap To AllyBehind",
      [CardAdder.VanillaStatusEffects.OnKillApplyScrapToRandomAlly] = "On Kill Apply Scrap To RandomAlly",
      [CardAdder.VanillaStatusEffects.OnKillApplyShellToSelf] = "On Kill Apply Shell To Self",
      [CardAdder.VanillaStatusEffects.OnKillApplyStealthToSelf] = "On Kill Apply Stealth To Self",
      [CardAdder.VanillaStatusEffects.OnKillApplyTeethToSelf] = "On Kill Apply Teeth To Self",
      [CardAdder.VanillaStatusEffects.OnKillApplyVimToAllyBehind] = "On Kill Apply Vim To AllyBehind",
      [CardAdder.VanillaStatusEffects.OnKillApplyVimToRandomAlly] = "On Kill Apply Vim To RandomAlly",
      [CardAdder.VanillaStatusEffects.OnKillApplyVimToRandomEnemy] = "On Kill Apply Vim To RandomEnemy",
      [CardAdder.VanillaStatusEffects.OnKillDraw] = "On Kill Draw",
      [CardAdder.VanillaStatusEffects.OnKillHealToSelfAndAlliesInRow] = "On Kill Heal To Self & AlliesInRow",
      [CardAdder.VanillaStatusEffects.OnKillHealToSelf] = "On Kill Heal To Self",
      [CardAdder.VanillaStatusEffects.OnKillIncreaseHealthToSelfAndAllies] = "On Kill Increase Health To Self & Allies",
      [CardAdder.VanillaStatusEffects.OnTurnApplyAttackToSelf] = "On Turn Apply Attack To Self",
      [CardAdder.VanillaStatusEffects.OnTurnApplyDemonizeToRandomEnemy] = "On Turn Apply Demonize To RandomEnemy",
      [CardAdder.VanillaStatusEffects.OnTurnApplyInkToEnemies] = "On Turn Apply Ink To Enemies",
      [CardAdder.VanillaStatusEffects.OnTurnApplyInkToRandomEnemy] = "On Turn Apply Ink To RandomEnemy",
      [CardAdder.VanillaStatusEffects.OnTurnApplyJuiceToAllyBehind] = "On Turn Apply Juice To AllyBehind",
      [CardAdder.VanillaStatusEffects.OnTurnApplyOverloadToRandomEnemy] = "On Turn Apply Overload To RandomEnemy",
      [CardAdder.VanillaStatusEffects.OnTurnApplyScrapToAllyAhead] = "On Turn Apply Scrap To AllyAhead",
      [CardAdder.VanillaStatusEffects.OnTurnApplyScrapToAllyBehind] = "On Turn Apply Scrap To AllyBehind",
      [CardAdder.VanillaStatusEffects.OnTurnApplyScrapToRandomAlly] = "On Turn Apply Scrap To RandomAlly",
      [CardAdder.VanillaStatusEffects.OnTurnApplyScrapToSelf] = "On Turn Apply Scrap To Self",
      [CardAdder.VanillaStatusEffects.OnTurnApplyShellToAllies] = "On Turn Apply Shell To Allies",
      [CardAdder.VanillaStatusEffects.OnTurnApplyShellToAllyInFrontOf] = "On Turn Apply Shell To AllyInFrontOf",
      [CardAdder.VanillaStatusEffects.OnTurnApplyShellToSelf] = "On Turn Apply Shell To Self",
      [CardAdder.VanillaStatusEffects.OnTurnApplySnowToEnemies] = "On Turn Apply Snow To Enemies",
      [CardAdder.VanillaStatusEffects.OnTurnApplySpiceToAllies] = "On Turn Apply Spice To Allies",
      [CardAdder.VanillaStatusEffects.OnTurnApplySpiceToAllyBehind] = "On Turn Apply Spice To AllyBehind",
      [CardAdder.VanillaStatusEffects.OnTurnApplySpiceToAllyInFrontOf] = "On Turn Apply Spice To AllyInFrontOf",
      [CardAdder.VanillaStatusEffects.OnTurnApplyTeethToSelf] = "On Turn Apply Teeth To Self",
      [CardAdder.VanillaStatusEffects.OnTurnApplyVimToAllyBehind] = "On Turn Apply Vim To AllyBehind",
      [CardAdder.VanillaStatusEffects.OnTurnApplyVimToRandomAlly] = "On Turn Apply Vim To RandomAlly",
      [CardAdder.VanillaStatusEffects.OnTurnApplyVoidToEveryone] = "On Turn Apply Void To Everyone",
      [CardAdder.VanillaStatusEffects.OnTurnApplyVoidToRandomEnemy] = "On Turn Apply Void To RandomEnemy",
      [CardAdder.VanillaStatusEffects.OnTurnEatRandomAllyHealthAndAttackAndEffects] = "On Turn Eat Random Ally (Health, Attack & Effects)",
      [CardAdder.VanillaStatusEffects.OnTurnEscapeToSelf] = "On Turn Escape To Self",
      [CardAdder.VanillaStatusEffects.OnTurnHealAllies] = "On Turn Heal Allies",
      [CardAdder.VanillaStatusEffects.OngoingIncreaseAttack] = "Ongoing Increase Attack",
      [CardAdder.VanillaStatusEffects.OngoingIncreaseEffectFactor] = "Ongoing Increase Effect Factor",
      [CardAdder.VanillaStatusEffects.OngoingIncreaseEffects] = "Ongoing Increase Effects",
      [CardAdder.VanillaStatusEffects.OngoingReduceAttack] = "Ongoing Reduce Attack",
      [CardAdder.VanillaStatusEffects.Overload] = "Overload",
      [CardAdder.VanillaStatusEffects.PreTriggerGainTempMultiHitEqualToJuice1] = "Pre Trigger Gain Temp MultiHit Equal To Juice - 1",
      [CardAdder.VanillaStatusEffects.PreTriggerGainTempMultiHitEqualToScrap1] = "Pre Trigger Gain Temp MultiHit Equal To Scrap - 1",
      [CardAdder.VanillaStatusEffects.PreTurnDestroyAllItemsInHand] = "Pre Turn Destroy All Items In Hand",
      [CardAdder.VanillaStatusEffects.PreTurnDestroyRandomCardInHand] = "Pre Turn Destroy Random Card In Hand",
      [CardAdder.VanillaStatusEffects.PreTurnEatAlliesInRowHealthAndAttack] = "Pre Turn Eat Allies In Row (Health & Attack)",
      [CardAdder.VanillaStatusEffects.PreTurnEatRandomAllyHealthAndAttackAndEffects] = "Pre Turn Eat Random Ally (Health, Attack & Effects)",
      [CardAdder.VanillaStatusEffects.PreTurnGainAttackForEachItemInHandForEachCardDestroyed] = "Pre Turn Gain Attack For Each Item In Hand (For Each Card Destroyed)",
      [CardAdder.VanillaStatusEffects.PreTurnGainTempMultiHitEqualToJuice] = "Pre Turn Gain Temp MultiHit Equal To Juice",
      [CardAdder.VanillaStatusEffects.PreTurnTakeJuiceFromRandomAlly] = "Pre Turn Take Juice From RandomAlly",
      [CardAdder.VanillaStatusEffects.PreTurnTakeScrapFromRandomAlly] = "Pre Turn Take Scrap From RandomAlly",
      [CardAdder.VanillaStatusEffects.Pull] = "Pull",
      [CardAdder.VanillaStatusEffects.Push] = "Push",
      [CardAdder.VanillaStatusEffects.RecycleJunk] = "Recycle Junk",
      [CardAdder.VanillaStatusEffects.RedrawCards] = "Redraw Cards",
      [CardAdder.VanillaStatusEffects.ReduceAttackEffect1] = "Reduce Attack Effect 1",
      [CardAdder.VanillaStatusEffects.ReduceAttack] = "Reduce Attack",
      [CardAdder.VanillaStatusEffects.ReduceCounter] = "Reduce Counter",
      [CardAdder.VanillaStatusEffects.ReduceEffects] = "Reduce Effects",
      [CardAdder.VanillaStatusEffects.ReduceMaxCounter] = "Reduce Max Counter",
      [CardAdder.VanillaStatusEffects.ReduceMaxHealthMustbeally] = "Reduce Max Health (Must be ally)",
      [CardAdder.VanillaStatusEffects.ReduceMaxHealth] = "Reduce Max Health",
      [CardAdder.VanillaStatusEffects.ResistShroom] = "ResistShroom",
      [CardAdder.VanillaStatusEffects.ResistSnow] = "ResistSnow",
      [CardAdder.VanillaStatusEffects.ResistSpice] = "ResistSpice",
      [CardAdder.VanillaStatusEffects.SacrificeAlly] = "Sacrifice Ally",
      [CardAdder.VanillaStatusEffects.SacrificeCardInHand] = "Sacrifice Card In Hand",
      [CardAdder.VanillaStatusEffects.SacrificeEnemy] = "Sacrifice Enemy",
      [CardAdder.VanillaStatusEffects.Scrap] = "Scrap",
      [CardAdder.VanillaStatusEffects.SetHealth] = "Set Health",
      [CardAdder.VanillaStatusEffects.SetMaxHealth] = "Set Max Health",
      [CardAdder.VanillaStatusEffects.Shell] = "Shell",
      [CardAdder.VanillaStatusEffects.Shroom] = "Shroom",
      [CardAdder.VanillaStatusEffects.Snow] = "Snow",
      [CardAdder.VanillaStatusEffects.SoulboundBossPhase2] = "SoulboundBossPhase2",
      [CardAdder.VanillaStatusEffects.Spice] = "Spice",
      [CardAdder.VanillaStatusEffects.Split] = "Split",
      [CardAdder.VanillaStatusEffects.SplitBossPhase2] = "SplitBossPhase2",
      [CardAdder.VanillaStatusEffects.Stealth] = "Stealth",
      [CardAdder.VanillaStatusEffects.SummonBeepop] = "Summon Beepop",
      [CardAdder.VanillaStatusEffects.SummonBloo] = "Summon Bloo",
      [CardAdder.VanillaStatusEffects.SummonBoBo] = "Summon BoBo",
      [CardAdder.VanillaStatusEffects.SummonBonzo] = "Summon Bonzo",
      [CardAdder.VanillaStatusEffects.SummonDregg] = "Summon Dregg",
      [CardAdder.VanillaStatusEffects.SummonEnemyLeech] = "Summon Enemy Leech",
      [CardAdder.VanillaStatusEffects.SummonEnemyPigeon] = "Summon Enemy Pigeon",
      [CardAdder.VanillaStatusEffects.SummonEnemyPopper] = "Summon Enemy Popper",
      [CardAdder.VanillaStatusEffects.SummonFallow] = "Summon Fallow",
      [CardAdder.VanillaStatusEffects.SummonGearhammer] = "Summon Gearhammer",
      [CardAdder.VanillaStatusEffects.SummonItem] = "Summon Item",
      [CardAdder.VanillaStatusEffects.SummonJunk] = "Summon Junk",
      [CardAdder.VanillaStatusEffects.SummonPlep] = "Summon Plep",
      [CardAdder.VanillaStatusEffects.SummonSunShard] = "Summon SunShard",
      [CardAdder.VanillaStatusEffects.SummonTailsFive] = "Summon TailsFive",
      [CardAdder.VanillaStatusEffects.SummonTailsFour] = "Summon TailsFour",
      [CardAdder.VanillaStatusEffects.SummonTailsOne] = "Summon TailsOne",
      [CardAdder.VanillaStatusEffects.SummonTailsThree] = "Summon TailsThree",
      [CardAdder.VanillaStatusEffects.SummonTailsTwo] = "Summon TailsTwo",
      [CardAdder.VanillaStatusEffects.SummonTigris] = "Summon Tigris",
      [CardAdder.VanillaStatusEffects.SummonUzu] = "Summon Uzu",
      [CardAdder.VanillaStatusEffects.Summoned] = "Summoned",
      [CardAdder.VanillaStatusEffects.Take100DamageWhenSoulboundUnitKilled] = "Take 100 Damage When Soulbound Unit Killed",
      [CardAdder.VanillaStatusEffects.TakeHealth] = "Take Health",
      [CardAdder.VanillaStatusEffects.Teeth] = "Teeth",
      [CardAdder.VanillaStatusEffects.TemporaryAimless] = "Temporary Aimless",
      [CardAdder.VanillaStatusEffects.TemporaryBarrage] = "Temporary Barrage",
      [CardAdder.VanillaStatusEffects.TemporaryFury] = "Temporary Fury",
      [CardAdder.VanillaStatusEffects.TemporaryNoomlin] = "Temporary Noomlin",
      [CardAdder.VanillaStatusEffects.TemporaryPigheaded] = "Temporary Pigheaded",
      [CardAdder.VanillaStatusEffects.TemporarySoulbound] = "Temporary Soulbound",
      [CardAdder.VanillaStatusEffects.TemporarySummoned] = "Temporary Summoned",
      [CardAdder.VanillaStatusEffects.TemporaryUnbreakable] = "Temporary Unbreakable",
      [CardAdder.VanillaStatusEffects.TemporaryUnmovable] = "Temporary Unmovable",
      [CardAdder.VanillaStatusEffects.TriggerAgainstAndReduceUses] = "Trigger Against & Reduce Uses",
      [CardAdder.VanillaStatusEffects.TriggerAgainstDontCountAsTrigger] = "Trigger Against (Don't Count As Trigger)",
      [CardAdder.VanillaStatusEffects.TriggerAgainstAllyWhenAllyIsHit] = "Trigger Against Ally When Ally Is Hit",
      [CardAdder.VanillaStatusEffects.TriggerAgainstAttackerWhenHit] = "Trigger Against Attacker When Hit",
      [CardAdder.VanillaStatusEffects.TriggerAgainstCrownAlliesWhenDiscarded] = "Trigger Against Crown Allies When Discarded",
      [CardAdder.VanillaStatusEffects.TriggerAgainstCrownAlliesWhenDrawn] = "Trigger Against Crown Allies When Drawn",
      [CardAdder.VanillaStatusEffects.TriggerAgainstRandomAllyWhenDiscarded] = "Trigger Against Random Ally When Discarded",
      [CardAdder.VanillaStatusEffects.TriggerAgainstRandomAllyWhenDrawn] = "Trigger Against Random Ally When Drawn",
      [CardAdder.VanillaStatusEffects.TriggerAgainstRandomEnemy] = "Trigger Against Random Enemy",
      [CardAdder.VanillaStatusEffects.TriggerAgainstRandomUnitWhenDiscarded] = "Trigger Against Random Unit When Discarded",
      [CardAdder.VanillaStatusEffects.TriggerAgainstRandomUnitWhenDrawn] = "Trigger Against Random Unit When Drawn",
      [CardAdder.VanillaStatusEffects.TriggerAgainstWhenAllyAttacks] = "Trigger Against When Ally Attacks",
      [CardAdder.VanillaStatusEffects.TriggerAgainstWhenFrostApplied] = "Trigger Against When Frost Applied",
      [CardAdder.VanillaStatusEffects.TriggerAgainstWhenSnowApplied] = "Trigger Against When Snow Applied",
      [CardAdder.VanillaStatusEffects.TriggerAgainstWhenWeaknessApplied] = "Trigger Against When Weakness Applied",
      [CardAdder.VanillaStatusEffects.TriggerAgainst] = "Trigger Against",
      [CardAdder.VanillaStatusEffects.TriggerWhenAllyAttacks] = "Trigger When Ally Attacks",
      [CardAdder.VanillaStatusEffects.TriggerWhenAllyInRowAttacks] = "Trigger When Ally In Row Attacks",
      [CardAdder.VanillaStatusEffects.TriggerWhenAllyIsHit] = "Trigger When Ally Is Hit",
      [CardAdder.VanillaStatusEffects.TriggerWhenDeployed] = "Trigger When Deployed",
      [CardAdder.VanillaStatusEffects.TriggerWhenEnemyIsKilled] = "Trigger When Enemy Is Killed",
      [CardAdder.VanillaStatusEffects.TriggerWhenJunkDestroyed] = "Trigger When Junk Destroyed",
      [CardAdder.VanillaStatusEffects.TriggerWhenRedrawHit] = "Trigger When Redraw Hit",
      [CardAdder.VanillaStatusEffects.Trigger] = "Trigger",
      [CardAdder.VanillaStatusEffects.Unmovable] = "Unmovable",
      [CardAdder.VanillaStatusEffects.Weakness] = "Weakness",
      [CardAdder.VanillaStatusEffects.WhenAllyIsHealedApplyEqualSpice] = "When Ally Is Healed Apply Equal Spice",
      [CardAdder.VanillaStatusEffects.WhenAllyIsHealedTriggerToSelf] = "When Ally Is Healed Trigger To Self",
      [CardAdder.VanillaStatusEffects.WhenAllyisHitApplyFrostToAttacker] = "When Ally is Hit Apply Frost To Attacker",
      [CardAdder.VanillaStatusEffects.WhenAllyisHitApplyShroomToAttacker] = "When Ally is Hit Apply Shroom To Attacker",
      [CardAdder.VanillaStatusEffects.WhenAllyisHitApplyTeethToSelf] = "When Ally is Hit Apply Teeth To Self",
      [CardAdder.VanillaStatusEffects.WhenAllyisHitApplyVimToTarget] = "When Ally is Hit Apply Vim To Target",
      [CardAdder.VanillaStatusEffects.WhenAllyisHitHealToTarget] = "When Ally is Hit Heal To Target",
      [CardAdder.VanillaStatusEffects.WhenAllyisHitIncreaseHealthToSelf] = "When Ally is Hit Increase Health To Self",
      [CardAdder.VanillaStatusEffects.WhenAllyIsKilledApplyAttackToSelf] = "When Ally Is Killed Apply Attack To Self",
      [CardAdder.VanillaStatusEffects.WhenAllyIsKilledGainTheirAttack] = "When Ally Is Killed Gain Their Attack",
      [CardAdder.VanillaStatusEffects.WhenAllyIsKilledLoseHalfHealthAndGainAttack] = "When Ally Is Killed Lose Half Health & Gain Attack",
      [CardAdder.VanillaStatusEffects.WhenAllyIsKilledTriggerToSelf] = "When Ally Is Killed Trigger To Self",
      [CardAdder.VanillaStatusEffects.WhenAllyIsSacrificedGainTheirAttack] = "When Ally Is Sacrificed Gain Their Attack",
      [CardAdder.VanillaStatusEffects.WhenAllyIsSacrificedTriggerToSelf] = "When Ally Is Sacrificed Trigger To Self",
      [CardAdder.VanillaStatusEffects.WhenAnyoneTakesShroomDamageApplyAttackToSelf] = "When Anyone Takes Shroom Damage Apply Attack To Self",
      [CardAdder.VanillaStatusEffects.WhenBuiltAddJunkToHand] = "When Built Add Junk To Hand",
      [CardAdder.VanillaStatusEffects.WhenBuiltApplyVimToSelf] = "When Built Apply Vim To Self",
      [CardAdder.VanillaStatusEffects.WhenCardDestroyedAndGainAttack] = "When Card Destroyed, Gain Attack",
      [CardAdder.VanillaStatusEffects.WhenCardDestroyedAndGainJuice] = "When Card Destroyed, Gain Juice",
      [CardAdder.VanillaStatusEffects.WhenCardDestroyedAndReduceCounterToSelf] = "When Card Destroyed, Reduce Counter To Self",
      [CardAdder.VanillaStatusEffects.WhenConsumedAddHealthToAllies] = "When Consumed Add Health To Allies",
      [CardAdder.VanillaStatusEffects.WhenConsumedApplyOverloadToEnemies] = "When Consumed Apply Overload To Enemies",
      [CardAdder.VanillaStatusEffects.WhenDeployedAddJunkToHand] = "When Deployed Add Junk To Hand",
      [CardAdder.VanillaStatusEffects.WhenDeployedApplyBlockToSelf] = "When Deployed Apply Block To Self",
      [CardAdder.VanillaStatusEffects.WhenDeployedApplyFrenzyToSelf] = "When Deployed Apply Frenzy To Self",
      [CardAdder.VanillaStatusEffects.WhenDeployedApplyInkToAllies] = "When Deployed Apply Ink To Allies",
      [CardAdder.VanillaStatusEffects.WhenDeployedApplyInkToEnemiesInRow] = "When Deployed Apply Ink To EnemiesInRow",
      [CardAdder.VanillaStatusEffects.WhenDeployedCopyEffectsOfRandomEnemy] = "When Deployed Copy Effects Of RandomEnemy",
      [CardAdder.VanillaStatusEffects.WhenDeployedFillBoardFinalBoss] = "When Deployed Fill Board (Final Boss)",
      [CardAdder.VanillaStatusEffects.WhenDeployedSummonWowee] = "When Deployed Summon Wowee",
      [CardAdder.VanillaStatusEffects.WhenDestroyedApplyDamageToAlliesInRow] = "When Destroyed Apply Damage To AlliesInRow",
      [CardAdder.VanillaStatusEffects.WhenDestroyedApplyDamageToAttacker] = "When Destroyed Apply Damage To Attacker",
      [CardAdder.VanillaStatusEffects.WhenDestroyedApplyDamageToEnemiesEqualToJuice] = "When Destroyed Apply Damage To Enemies Equal To Juice",
      [CardAdder.VanillaStatusEffects.WhenDestroyedApplyDamageToEnemiesInRow] = "When Destroyed Apply Damage To EnemiesInRow",
      [CardAdder.VanillaStatusEffects.WhenDestroyedApplyFrenzyToRandomAlly] = "When Destroyed Apply Frenzy To RandomAlly",
      [CardAdder.VanillaStatusEffects.WhenDestroyedApplyHazeToAttacker] = "When Destroyed Apply Haze To Attacker",
      [CardAdder.VanillaStatusEffects.WhenDestroyedApplyOverloadToAttacker] = "When Destroyed Apply Overload To Attacker",
      [CardAdder.VanillaStatusEffects.WhenDestroyedApplySpiceToAllies] = "When Destroyed Apply Spice To Allies",
      [CardAdder.VanillaStatusEffects.WhenDestroyedApplyStealthToAlliesInRow] = "When Destroyed Apply Stealth To AlliesInRow",
      [CardAdder.VanillaStatusEffects.WhenDestroyedSummonDregg] = "When Destroyed Summon Dregg",
      [CardAdder.VanillaStatusEffects.WhenDestroyedTriggerToAllies] = "When Destroyed Trigger To Allies",
      [CardAdder.VanillaStatusEffects.WhenDrawnApplySnowToAllies] = "When Drawn Apply Snow To Allies",
      [CardAdder.VanillaStatusEffects.WhenEnemiesAttackApplyDemonizeToAttacker] = "When Enemies Attack Apply Demonize To Attacker",
      [CardAdder.VanillaStatusEffects.WhenEnemyShroomedIsKilledApplyTheirShroomToRandomEnemy] = "When Enemy (Shroomed) Is Killed Apply Their Shroom To RandomEnemy",
      [CardAdder.VanillaStatusEffects.WhenEnemyDeployedCopyEffectsOfTarget] = "When Enemy Deployed Copy Effects Of Target",
      [CardAdder.VanillaStatusEffects.WhenEnemyIsKilledApplyGoldToSelf] = "When Enemy Is Killed Apply Gold To Self",
      [CardAdder.VanillaStatusEffects.WhenEnemyIsKilledApplyShellToAttacker] = "When Enemy Is Killed Apply Shell To Attacker",
      [CardAdder.VanillaStatusEffects.WhenHealedApplyAttackToSelf] = "When Healed Apply Attack To Self",
      [CardAdder.VanillaStatusEffects.WhenHealedTriggerToSelf] = "When Healed Trigger To Self",
      [CardAdder.VanillaStatusEffects.WhenHealthLostApplyEqualAttackToSelfAndAllies] = "When Health Lost Apply Equal Attack To Self And Allies",
      [CardAdder.VanillaStatusEffects.WhenHealthLostApplyEqualFrostToSelf] = "When Health Lost Apply Equal Frost To Self",
      [CardAdder.VanillaStatusEffects.WhenHealthLostApplyEqualSpiceToSelf] = "When Health Lost Apply Equal Spice To Self",
      [CardAdder.VanillaStatusEffects.WhenHitAddFrenzyToSelf] = "When Hit Add Frenzy To Self",
      [CardAdder.VanillaStatusEffects.WhenHitAddGearhammerToHand] = "When Hit Add Gearhammer To Hand",
      [CardAdder.VanillaStatusEffects.WhenHitAddHealthLostToAttacker] = "When Hit Add Health Lost To Attacker",
      [CardAdder.VanillaStatusEffects.WhenHitAddHealthLostToRandomAlly] = "When Hit Add Health Lost To RandomAlly",
      [CardAdder.VanillaStatusEffects.WhenHitAddJunkToHand] = "When Hit Add Junk To Hand",
      [CardAdder.VanillaStatusEffects.WhenHitApplyBlockToRandomAlly] = "When Hit Apply Block To RandomAlly",
      [CardAdder.VanillaStatusEffects.WhenHitApplyDemonizeToAttacker] = "When Hit Apply Demonize To Attacker",
      [CardAdder.VanillaStatusEffects.WhenHitApplyFrostToEnemies] = "When Hit Apply Frost To Enemies",
      [CardAdder.VanillaStatusEffects.WhenHitApplyFrostToRandomEnemy] = "When Hit Apply Frost To RandomEnemy",
      [CardAdder.VanillaStatusEffects.WhenHitApplyGoldToAttackerNoPing] = "When Hit Apply Gold To Attacker (No Ping)",
      [CardAdder.VanillaStatusEffects.WhenHitApplyInkToAttacker] = "When Hit Apply Ink To Attacker",
      [CardAdder.VanillaStatusEffects.WhenHitApplyInkToRandomEnemy] = "When Hit Apply Ink To RandomEnemy",
      [CardAdder.VanillaStatusEffects.WhenHitApplyInkToSelf] = "When Hit Apply Ink To Self",
      [CardAdder.VanillaStatusEffects.WhenHitApplyOverloadToAttacker] = "When Hit Apply Overload To Attacker",
      [CardAdder.VanillaStatusEffects.WhenHitApplyShellToAllies] = "When Hit Apply Shell To Allies",
      [CardAdder.VanillaStatusEffects.WhenHitApplyShellToAllyBehind] = "When Hit Apply Shell To AllyBehind",
      [CardAdder.VanillaStatusEffects.WhenHitApplyShellToSelf] = "When Hit Apply Shell To Self",
      [CardAdder.VanillaStatusEffects.WhenHitApplyShroomToAttacker] = "When Hit Apply Shroom To Attacker",
      [CardAdder.VanillaStatusEffects.WhenHitApplyShroomToRandomEnemy] = "When Hit Apply Shroom To RandomEnemy",
      [CardAdder.VanillaStatusEffects.WhenHitApplySnowToAttacker] = "When Hit Apply Snow To Attacker",
      [CardAdder.VanillaStatusEffects.WhenHitApplySnowToEnemies] = "When Hit Apply Snow To Enemies",
      [CardAdder.VanillaStatusEffects.WhenHitApplySnowToRandomEnemy] = "When Hit Apply Snow To RandomEnemy",
      [CardAdder.VanillaStatusEffects.WhenHitApplySpiceToAlliesAndEnemiesAndSelf] = "When Hit Apply Spice To Allies & Enemies & Self",
      [CardAdder.VanillaStatusEffects.WhenHitApplySpiceToAllies] = "When Hit Apply Spice To Allies",
      [CardAdder.VanillaStatusEffects.WhenHitApplySpiceToAlliesInRow] = "When Hit Apply Spice To AlliesInRow",
      [CardAdder.VanillaStatusEffects.WhenHitApplySpiceToSelf] = "When Hit Apply Spice To Self",
      [CardAdder.VanillaStatusEffects.WhenHitApplyStealthToSelf] = "When Hit Apply Stealth To Self",
      [CardAdder.VanillaStatusEffects.WhenHitApplyVimToSelf] = "When Hit Apply Vim To Self",
      [CardAdder.VanillaStatusEffects.WhenHitApplyVoidToAttacker] = "When Hit Apply Void To Attacker",
      [CardAdder.VanillaStatusEffects.WhenHitApplyWeaknessToAttacker] = "When Hit Apply Weakness To Attacker",
      [CardAdder.VanillaStatusEffects.WhenHitDamageToEnemies] = "When Hit Damage To Enemies",
      [CardAdder.VanillaStatusEffects.WhenHitDamageToEnemiesInRow] = "When Hit Damage To EnemiesInRow",
      [CardAdder.VanillaStatusEffects.WhenHitDraw] = "When Hit Draw",
      [CardAdder.VanillaStatusEffects.WhenHitEqualDamageToAttacker] = "When Hit Equal Damage To Attacker",
      [CardAdder.VanillaStatusEffects.WhenHitGainAttackToSelfNoPing] = "When Hit Gain Attack To Self (No Ping)",
      [CardAdder.VanillaStatusEffects.WhenHitGainTeethToSelf] = "When Hit Gain Teeth To Self",
      [CardAdder.VanillaStatusEffects.WhenHitIncreaseAttackEffect1ToSelf] = "When Hit Increase Attack Effect 1 To Self",
      [CardAdder.VanillaStatusEffects.WhenHitIncreaseAttackToRandomAlly] = "When Hit Increase Attack To RandomAlly",
      [CardAdder.VanillaStatusEffects.WhenHitIncreaseHealthToRandomAlly] = "When Hit Increase Health To RandomAlly",
      [CardAdder.VanillaStatusEffects.WhenHitReduceAttackToAttacker] = "When Hit Reduce Attack To Attacker",
      [CardAdder.VanillaStatusEffects.WhenHitReduceAttackToSelf] = "When Hit Reduce Attack To Self",
      [CardAdder.VanillaStatusEffects.WhenHitReduceCounterToSelf] = "When Hit Reduce Counter To Self",
      [CardAdder.VanillaStatusEffects.WhenHitTriggerToSelf] = "When Hit Trigger To Self",
      [CardAdder.VanillaStatusEffects.WhenHitWithJunkAddFrenzyToSelf] = "When Hit With Junk Add Frenzy To Self",
      [CardAdder.VanillaStatusEffects.WhenJuiceAppliedToSelfGainFrenzy] = "When Juice Applied To Self Gain Frenzy",
      [CardAdder.VanillaStatusEffects.WhenSacrificedSummonTailsFour] = "When Sacrificed Summon TailsFour",
      [CardAdder.VanillaStatusEffects.WhenSacrificedSummonTailsOne] = "When Sacrificed Summon TailsOne",
      [CardAdder.VanillaStatusEffects.WhenSacrificedSummonTailsThree] = "When Sacrificed Summon TailsThree",
      [CardAdder.VanillaStatusEffects.WhenSacrificedSummonTailsTwo] = "When Sacrificed Summon TailsTwo",
      [CardAdder.VanillaStatusEffects.WhenShellAppliedToSelfGainSpiceInstead] = "When Shell Applied To Self Gain Spice Instead",
      [CardAdder.VanillaStatusEffects.WhenShroomAppliedToAnythingDoubleAmountAndLoseScrap] = "When Shroom Applied To Anything Double Amount And Lose Scrap",
      [CardAdder.VanillaStatusEffects.WhenShroomDamageTakenTriggerToSelf] = "When Shroom Damage Taken Trigger To Self",
      [CardAdder.VanillaStatusEffects.WhenSnowAppliedToAnythingGainAttackToSelf] = "When Snow Applied To Anything Gain Attack To Self",
      [CardAdder.VanillaStatusEffects.WhenSnowAppliedToAnythingGainEqualAttackToSelf] = "When Snow Applied To Anything Gain Equal Attack To Self",
      [CardAdder.VanillaStatusEffects.WhenSnowAppliedToSelfApplyDemonizeToEnemies] = "When Snow Applied To Self Apply Demonize To Enemies",
      [CardAdder.VanillaStatusEffects.WhenSnowAppliedToSelfGainEqualAttack] = "When Snow Applied To Self Gain Equal Attack",
      [CardAdder.VanillaStatusEffects.WhenSpiceXAppliedToSelfTriggerToSelf] = "When Spice X Applied To Self Trigger To Self",
      [CardAdder.VanillaStatusEffects.WhenVimAppliedToAnythingDoubleAmount] = "When Vim Applied To Anything Double Amount",
      [CardAdder.VanillaStatusEffects.WhenXHealthLostSplit] = "When X Health Lost Split",
      [CardAdder.VanillaStatusEffects.WhileActiveAddEqualAttackToJunkInHand] = "While Active Add Equal Attack To Junk In Hand",
      [CardAdder.VanillaStatusEffects.WhileActiveAimlessToEnemies] = "While Active Aimless To Enemies",
      [CardAdder.VanillaStatusEffects.WhileActiveBarrageToAllies] = "While Active Barrage To Allies",
      [CardAdder.VanillaStatusEffects.WhileActiveBarrageToAlliesInRow] = "While Active Barrage To AlliesInRow",
      [CardAdder.VanillaStatusEffects.WhileActiveBarrageToEnemies] = "While Active Barrage To Enemies",
      [CardAdder.VanillaStatusEffects.WhileActiveFrenzyToAllies] = "While Active Frenzy To Allies",
      [CardAdder.VanillaStatusEffects.WhileActiveFrenzyToCrownAllies] = "While Active Frenzy To Crown Allies",
      [CardAdder.VanillaStatusEffects.WhileActiveHaltSpiceToAllies] = "While Active Halt Spice To Allies",
      [CardAdder.VanillaStatusEffects.WhileActiveIncreaseAllSpiceApplied] = "While Active Increase All Spice Applied",
      [CardAdder.VanillaStatusEffects.WhileActiveIncreaseAttackbyCurrentToAllies] = "While Active Increase Attack by Current To Allies",
      [CardAdder.VanillaStatusEffects.WhileActiveIncreaseAttackbyCurrentToSummonedAllies] = "While Active Increase Attack by Current To Summoned Allies",
      [CardAdder.VanillaStatusEffects.WhileActiveIncreaseAttackToAlliesAndEnemies] = "While Active Increase Attack To Allies & Enemies",
      [CardAdder.VanillaStatusEffects.WhileActiveIncreaseAttackToAlliesNoDesc] = "While Active Increase Attack To Allies (No Desc)",
      [CardAdder.VanillaStatusEffects.WhileActiveIncreaseAttackToAllies] = "While Active Increase Attack To Allies",
      [CardAdder.VanillaStatusEffects.WhileActiveIncreaseAttackToAlliesInRow] = "While Active Increase Attack To AlliesInRow",
      [CardAdder.VanillaStatusEffects.WhileActiveIncreaseAttackToItemsInHand] = "While Active Increase Attack To Items In Hand",
      [CardAdder.VanillaStatusEffects.WhileActiveIncreaseAttackToJunkInHand] = "While Active Increase Attack To Junk In Hand",
      [CardAdder.VanillaStatusEffects.WhileActiveIncreaseEffectsToAlliesAndEnemies] = "While Active Increase Effects To Allies & Enemies",
      [CardAdder.VanillaStatusEffects.WhileActiveIncreaseEffectsToFrontAlly] = "While Active Increase Effects To FrontAlly",
      [CardAdder.VanillaStatusEffects.WhileActiveIncreaseEffectsToHand] = "While Active Increase Effects To Hand",
      [CardAdder.VanillaStatusEffects.WhileActivePigheadedToEnemies] = "While Active Pigheaded To Enemies",
      [CardAdder.VanillaStatusEffects.WhileActiveReduceAttackToEnemiesNoPingAndNoDesc] = "While Active Reduce Attack To Enemies (No Ping, No Desc)",
      [CardAdder.VanillaStatusEffects.WhileActiveSnowImmuneToAllies] = "While Active Snow Immune To Allies",
      [CardAdder.VanillaStatusEffects.WhileActiveTeethToAllies] = "While Active Teeth To Allies",
      [CardAdder.VanillaStatusEffects.WhileActiveUnmovableToEnemies] = "While Active Unmovable To Enemies",
      [CardAdder.VanillaStatusEffects.WhileInHandReduceAttackToAllies] = "While In Hand Reduce Attack To Allies",
      [CardAdder.VanillaStatusEffects.WhileLastInHandDoubleEffectsToSelf] = "While Last In Hand Double Effects To Self"
    };
    internal static readonly Dictionary<CardAdder.VanillaTraits, string> VanillaTraitsNamesLookUp = new Dictionary<CardAdder.VanillaTraits, string>()
    {
      [CardAdder.VanillaTraits.Aimless] = "Aimless",
      [CardAdder.VanillaTraits.Backline] = "Backline",
      [CardAdder.VanillaTraits.Barrage] = "Barrage",
      [CardAdder.VanillaTraits.Bombard1] = "Bombard 1",
      [CardAdder.VanillaTraits.Bombard2] = "Bombard 2",
      [CardAdder.VanillaTraits.Combo] = "Combo",
      [CardAdder.VanillaTraits.Consume] = "Consume",
      [CardAdder.VanillaTraits.Crush] = "Crush",
      [CardAdder.VanillaTraits.Draw] = "Draw",
      [CardAdder.VanillaTraits.Effigy] = "Effigy",
      [CardAdder.VanillaTraits.Explode] = "Explode",
      [CardAdder.VanillaTraits.Frontline] = "Frontline",
      [CardAdder.VanillaTraits.Fury] = "Fury",
      [CardAdder.VanillaTraits.Greed] = "Greed",
      [CardAdder.VanillaTraits.Hellbent] = "Hellbent",
      [CardAdder.VanillaTraits.Knockback] = "Knockback",
      [CardAdder.VanillaTraits.Longshot] = "Longshot",
      [CardAdder.VanillaTraits.Noomlin] = "Noomlin",
      [CardAdder.VanillaTraits.Pigheaded] = "Pigheaded",
      [CardAdder.VanillaTraits.Pull] = "Pull",
      [CardAdder.VanillaTraits.Recycle] = "Recycle",
      [CardAdder.VanillaTraits.Smackback] = "Smackback",
      [CardAdder.VanillaTraits.Soulbound] = "Soulbound",
      [CardAdder.VanillaTraits.Spark] = "Spark",
      [CardAdder.VanillaTraits.Summoned] = "Summoned",
      [CardAdder.VanillaTraits.Trash] = "Trash",
      [CardAdder.VanillaTraits.Unmovable] = "Unmovable",
      [CardAdder.VanillaTraits.Wild] = "Wild"
    };
    internal static readonly Dictionary<CardAdder.VanillaBloodProfiles, string> VanillaBloodProfilesNamesLookUp = new Dictionary<CardAdder.VanillaBloodProfiles, string>()
    {
      [CardAdder.VanillaBloodProfiles.BloodProfileBerry] = "Blood Profile Berry",
      [CardAdder.VanillaBloodProfiles.BloodProfileBlack] = "Blood Profile Black",
      [CardAdder.VanillaBloodProfiles.BloodProfileBlueDouble] = "Blood Profile Blue (x2)",
      [CardAdder.VanillaBloodProfiles.BloodProfileFungus] = "Blood Profile Fungus",
      [CardAdder.VanillaBloodProfiles.BloodProfileNormal] = "Blood Profile Normal",
      [CardAdder.VanillaBloodProfiles.BloodProfileSnow] = "Blood Profile Snow",
      [CardAdder.VanillaBloodProfiles.BloodProfilePinkWisp] = "Blood Profile Pink Wisp",
      [CardAdder.VanillaBloodProfiles.BloodProfileHusk] = "Blood Profile Husk"
    };

    public static event Action<int> OnAskForAddingCards;

    internal static void LaunchEvent()
    {
      Action<int> askForAddingCards = CardAdder.OnAskForAddingCards;
      if (askForAddingCards == null)
        return;
      askForAddingCards(0);
    }

    public static Sprite ToSprite(this Texture2D t, Vector2? v = null)
    {
      Vector2 vector2 = v ?? new Vector2(0.5f, 0.5f);
      return Sprite.Create(t, new Rect(0.0f, 0.0f, (float) ((Texture) t).width, (float) ((Texture) t).height), vector2);
    }

    public static Sprite LoadSpriteFromCardPortraits(string name, Vector2? v = null)
    {
      Texture2D t = new Texture2D(2, 2);
      ImageConversion.LoadImage(t, Il2CppStructArray<byte>.op_Implicit(File.ReadAllBytes(WildFrostAPIMod.ModsFolder + (name.EndsWith(".png") ? name : name + ".png"))));
      return t.ToSprite(v);
    }

    public static CardData RegisterCardInApi(this CardData t)
    {
      t.SetCustomData("AddedByApi", Object.op_Implicit(true));
      t.original = t;
      WildFrostAPIMod.CardDataAdditions.Add(t);
      return t;
    }

    public static CardData ModifyFields(this CardData t, Func<CardData, CardData> modifyFields)
    {
      t = modifyFields(t);
      return t;
    }

    public static CardData SetSprites(this CardData t, Sprite mainSprite, Sprite backgroundSprite)
    {
      t.mainSprite = mainSprite;
      t.backgroundSprite = backgroundSprite;
      return t;
    }

    public static global::StatusEffectData StatusEffectData(
      this CardAdder.VanillaStatusEffects effect)
    {
      return CardAdder.VanillaStatusEffectsNamesLookUp[effect].StatusEffectData();
    }

    public static CardData.StatusEffectStacks StatusEffectStack(
      this CardAdder.VanillaStatusEffects effect,
      int amount)
    {
      return CardAdder.VanillaStatusEffectsNamesLookUp[effect].StatusEffectStack(amount);
    }

    public static global::StatusEffectData StatusEffectData(this string name) => ((Il2CppObjectBase) AddressableLoader.groups[nameof (StatusEffectData)].lookup[name]).Cast<global::StatusEffectData>();

    public static CardData.StatusEffectStacks StatusEffectStack(this string name, int amount) => new CardData.StatusEffectStacks()
    {
      data = ((Il2CppObjectBase) AddressableLoader.groups["StatusEffectData"].lookup[name]).Cast<global::StatusEffectData>(),
      count = amount
    };

    public static CardData.TraitStacks TraitStack(this CardAdder.VanillaTraits trait, int amount) => CardAdder.VanillaTraitsNamesLookUp[trait].TraitStack(amount);

    public static CardData.TraitStacks TraitStack(this string name, int amount) => new CardData.TraitStacks()
    {
      data = ((Il2CppObjectBase) AddressableLoader.groups["TraitData"].lookup[name]).Cast<TraitData>(),
      count = amount
    };

    public static CardData AddToPool(
      this CardData t,
      params CardAdder.VanillaRewardPools[] rewardPools)
    {
      List<string> stringList = new List<string>();
      foreach (CardAdder.VanillaRewardPools rewardPool in rewardPools)
        stringList.Add(rewardPool.ToString().Replace("VanillaRewardPools.", ""));
      t = t.AddToPool(stringList.ToArray());
      return t;
    }

    public static CardData AddToPool(this CardData t, params string[] rewardPools)
    {
      Il2CppReferenceArray<Object> typeIncludingAssets = Object.FindObjectsOfTypeIncludingAssets(Il2CppType.Of<RewardPool>());
      foreach (string rewardPool in rewardPools)
      {
        string poolName = rewardPool;
        ((Il2CppObjectBase) IArrayExt.ToList<Object>((Il2CppArrayBase<Object>) typeIncludingAssets).Find<Object>((Predicate<Object>) (a => a.name == poolName))).Cast<RewardPool>()?.list?.Add((DataFile) t);
      }
      return t;
    }

    public static CardData SetIdleAnimationProfile(
      this CardData t,
      CardAdder.VanillaCardAnimationProfiles profile)
    {
      return t.SetIdleAnimationProfile(profile.ToString().Replace("VanillaCardAnimationProfiles.", ""));
    }

    public static CardData SetIdleAnimationProfile(this CardData t, CardAnimationProfile profile)
    {
      t.idleAnimationProfile = profile;
      return t;
    }

    public static CardData SetIdleAnimationProfile(this CardData t, string animationProfileName)
    {
      t.idleAnimationProfile = WildFrostAPIMod.VanillaAnimationProfiles?.Find((Predicate<CardAnimationProfile>) (a => Object.op_Inequality((Object) a, (Object) null) && ((Object) a).name.Equals(animationProfileName, StringComparison.OrdinalIgnoreCase)));
      return !Object.op_Equality((Object) t.idleAnimationProfile, (Object) null) ? t : throw new Exception("Animation profile with name " + animationProfileName + " not found!");
    }

    public static CardData SetBloodProfile(
      this CardData t,
      CardAdder.VanillaBloodProfiles bloodProfile)
    {
      return t.SetBloodProfile(CardAdder.VanillaBloodProfilesNamesLookUp[bloodProfile]);
    }

    public static CardData SetBloodProfile(this CardData t, BloodProfile bloodProfile)
    {
      t.bloodProfile = bloodProfile;
      return t;
    }

    public static CardData SetBloodProfile(this CardData t, string bloodProfileName)
    {
      t.bloodProfile = WildFrostAPIMod.VanillaBloodProfiles?.Find((Predicate<BloodProfile>) (a => Object.op_Inequality((Object) a, (Object) null) && ((Object) a).name.Equals(bloodProfileName, StringComparison.OrdinalIgnoreCase)));
      return !Object.op_Equality((Object) t.bloodProfile, (Object) null) ? t : throw new Exception("Blood profile with name " + bloodProfileName + " not found!");
    }

    public static CardData SetTargetMode(
      this CardData t,
      CardAdder.VanillaTargetModes vanillaTargetMode)
    {
      return t.SetTargetMode(vanillaTargetMode.ToString().Replace("VanillaTargetModes.", ""));
    }

    public static CardData SetTargetMode(this CardData t, TargetMode targetMode)
    {
      t.targetMode = targetMode;
      return t;
    }

    public static CardData SetTargetMode(this CardData t, string targetModeName)
    {
      t.targetMode = WildFrostAPIMod.VanillaTargetModes?.Find((Predicate<TargetMode>) (a => Object.op_Inequality((Object) a, (Object) null) && ((Object) a).name == targetModeName));
      return t;
    }

    public static List<T> Dictinct<T>(this List<T> list)
    {
      List<T> list1 = new List<T>();
      foreach (T obj in list)
      {
        if (!list1.Contains(obj))
          list1.Add(obj);
      }
      return list1;
    }

    public static CardData AddToPets(this CardData t)
    {
      List<string> list1 = SaveSystem.LoadProgressData<List<string>>("petHutUnlocks", new List<string>());
      list1.Add(((Object) t).name);
      SaveSystem.SaveProgressData<List<string>>("petHutUnlocks", list1.Dictinct<string>());
      List<string> list2 = IArrayExt.ToList<string>((Il2CppArrayBase<string>) ((Il2CppObjectBase) MetaprogressionSystem.data["pets"]).Cast<Il2CppStringArray>());
      list2.Add(((Object) t).name);
      MetaprogressionSystem.data["pets"] = ((Il2CppObjectBase) list2.Dictinct<string>().ToArray()).Cast<Object>();
      SelectStartingPet objectOfType = Object.FindObjectOfType<SelectStartingPet>();
      if (Object.op_Inequality((Object) objectOfType, (Object) null))
      {
        objectOfType.group.Clear();
        CoroutineManager.Start(objectOfType.SetUp());
      }
      return t;
    }

    public static CardData SetStartWithEffects(
      this CardData t,
      params CardData.StatusEffectStacks[] effect)
    {
      t.startWithEffects = Il2CppReferenceArray<CardData.StatusEffectStacks>.op_Implicit(effect);
      return t;
    }

    public static CardData SetUpgrades(this CardData t, List<string> upgrade)
    {
      List<CardUpgradeData> list = new List<CardUpgradeData>();
      foreach (string str in upgrade)
        list.Add(((Il2CppObjectBase) AddressableLoader.groups["CardUpgradeData"].lookup[str]).Cast<CardUpgradeData>());
      return t;
    }

    public static CardData SetUpgrades(this CardData t, List<CardAdder.VanillaCardUpgrades> upgrade)
    {
      List<CardUpgradeData> list = new List<CardUpgradeData>();
      foreach (CardAdder.VanillaCardUpgrades vanillaCardUpgrades in upgrade)
        list.Add(((Il2CppObjectBase) AddressableLoader.groups["CardUpgradeData"].lookup[vanillaCardUpgrades.ToString().Replace("VanillaCardUpgrades.", "")]).Cast<CardUpgradeData>());
      return t;
    }

    public static CardData SetUpgrades(this CardData t, List<CardUpgradeData> upgrade)
    {
      t.upgrades = upgrade;
      return t;
    }

    public static CardData SetAttackEffects(
      this CardData t,
      params CardData.StatusEffectStacks[] effect)
    {
      t.attackEffects = Il2CppReferenceArray<CardData.StatusEffectStacks>.op_Implicit(effect);
      return t;
    }

    public static CardData SetTraits(this CardData t, params CardData.TraitStacks[] traits)
    {
      List<CardData.TraitStacks> list = new List<CardData.TraitStacks>();
      foreach (CardData.TraitStacks trait in traits)
        list.Add(trait);
      t.traits = list;
      return t;
    }

    public static CardData SetStats(this CardData t, int? health = null, int? damage = null, int counter = 0) => t.SetHealth(health).SetDamage(damage).SetCounter(counter);

    public static CardData SetCounter(this CardData t, int counter)
    {
      t.counter = counter;
      return t;
    }

    public static CardData SetDamage(this CardData t, int? damage)
    {
      if (damage.HasValue)
      {
        t.hasAttack = true;
        t.damage = damage.Value;
      }
      return t;
    }

    public static CardData SetHealth(this CardData t, int? health)
    {
      if (health.HasValue)
      {
        t.hasHealth = true;
        t.hp = health.Value;
      }
      return t;
    }

    public static CardData SetSprites(this CardData t, string mainSprite, string backgroundSprite)
    {
      t.mainSprite = CardAdder.LoadSpriteFromCardPortraits(mainSprite);
      t.backgroundSprite = CardAdder.LoadSpriteFromCardPortraits(backgroundSprite);
      return t;
    }

    public static CardData SetIsUnit(this CardData t)
    {
      t.canBeHit = true;
      t.playType = (Card.PlayType) 2;
      t.canPlayOnBoard = true;
      return t;
    }

    public static CardData SetCardType(this CardData t, CardAdder.VanillaCardTypes cardType)
    {
      t.cardType = AddressableLoader.GetGroup<CardType>("CardType").Find<CardType>((Predicate<CardType>) (type => ((Object) type).name == cardType.ToString().Replace("VanillaCardTypes.", "")));
      return t;
    }

    public static CardData SetCardType(this CardData t, string cardTypeName)
    {
      t.cardType = AddressableLoader.GetGroup<CardType>("CardType").Find<CardType>((Predicate<CardType>) (type => ((Object) type).name == cardTypeName));
      return t;
    }

    public static CardData SetCanPlay(this CardData t, CardAdder.CanPlay canPlayFlags)
    {
      t.canPlayOnBoard = canPlayFlags.HasFlag((Enum) CardAdder.CanPlay.CanPlayOnBoard);
      t.canPlayOnEnemy = canPlayFlags.HasFlag((Enum) CardAdder.CanPlay.CanPlayOnEnemy);
      t.canPlayOnFriendly = canPlayFlags.HasFlag((Enum) CardAdder.CanPlay.CanPlayOnFriendly);
      t.canPlayOnHand = canPlayFlags.HasFlag((Enum) CardAdder.CanPlay.CanPlayOnHand);
      return t;
    }

    public static CardData SetItemUses(this CardData t, int amount)
    {
      t.uses = amount;
      return t;
    }

    public static CardData SetIsItem(this CardData t)
    {
      t.uses = 1;
      t.canBeHit = false;
      t.playType = (Card.PlayType) 1;
      t = t.SetCardType(CardAdder.VanillaCardTypes.Item);
      return t;
    }

    public static CardData SetTitle(this CardData t, string name)
    {
      t.titleKey = LocalizationHelper.FromId(LocalizationHelper.CreateLocalizedString(((Object) t).name + ".Title", name));
      return t;
    }

    public static CardData SetText(this CardData t, string text)
    {
      t.textKey = LocalizationHelper.FromId(LocalizationHelper.CreateLocalizedString(((Object) t).name + ".Text", text));
      return t;
    }

    public static CardData SetFlavour(this CardData t, string flavour)
    {
      t.flavourKey = LocalizationHelper.FromId(LocalizationHelper.CreateLocalizedString(((Object) t).name + ".Flavour", flavour));
      return t;
    }

    public static CardData CreateCardData(string modName, string cardName)
    {
      CardData instance = ScriptableObject.CreateInstance<CardData>();
      instance.titleKey = new LocalizedString();
      instance.flavourKey = new LocalizedString();
      instance.textKey = new LocalizedString();
      instance.injuries = new List<CardData.StatusEffectStacks>();
      instance.upgrades = new List<CardUpgradeData>();
      instance.attackEffects = new Il2CppReferenceArray<CardData.StatusEffectStacks>(0L);
      instance.startWithEffects = new Il2CppReferenceArray<CardData.StatusEffectStacks>(0L);
      instance.traits = new List<CardData.TraitStacks>();
      instance.createScripts = new Il2CppReferenceArray<CardScript>(0L);
      CardData cardData = instance.SetTargetMode(CardAdder.VanillaTargetModes.TargetModeBasic);
      ((Object) cardData).name = cardName.StartsWith(modName) ? cardName : modName + "." + cardName;
      if (modName == "")
        ((Object) cardData).name = cardName;
      cardData.cardType = AddressableLoader.GetGroup<CardType>("CardType").Find<CardType>((Predicate<CardType>) (type => ((Object) type).name == "Friendly"));
      cardData.backgroundSprite = CardAdder.LoadSpriteFromCardPortraits("CardPortraits\\FALLBACKBACKGROUNDSPRITE.png");
      cardData.mainSprite = CardAdder.LoadSpriteFromCardPortraits("CardPortraits\\FALLBACKMAINSPRITE.png");
      return cardData;
    }

    public enum VanillaStatusEffects
    {
      None,
      AddAttackAndHealthToSummon,
      Block,
      Bombard1,
      Bombard2,
      BonusDamageEqualToDartsInHand,
      BonusDamageEqualToGoldFactor002,
      BonusDamageEqualToJuice,
      BonusDamageEqualToScrapOnBoard,
      BonusDamageEqualToScrap,
      BonusDamageEqualToShell,
      BoostEffects,
      Budge,
      CannotRecall,
      CheckHasJuice,
      Cleanse,
      CombineWhen2Deployed,
      CopyEffects,
      Crush,
      DamageEqualToHealth,
      DamageToFrontAllies,
      Demonize,
      DestroyAfterUse,
      DestroySelfAfterTurn,
      DoubleAllSpiceWhenDestroyed,
      DoubleBlock,
      DoubleInk,
      DoubleJuice,
      DoubleNegativeEffects,
      DoubleOverload,
      DoubleShell,
      DoubleShroom,
      DoubleSpice,
      DoubleVim,
      DrawCards,
      EatHealthAndAttack,
      EatHealthAndAttackAndEffects,
      EatAlliesInRowHealthAndAttack,
      EatRandomAllyHealthAndAttackAndEffects,
      Escape,
      FillBoardFinalBoss,
      FinalBossPhase2,
      Flee,
      FreeAction,
      FrenzyBossPhase2,
      Frost,
      GainFrenzyWhenWildUnitKilled,
      GainGoldRange36,
      GainGold,
      GoatWampusPhase2,
      HaltSpice,
      Haze,
      HealNoPing,
      HealFrontAllyBasedOnDamageDealt,
      HealFullAndGainEqualSpice,
      HealToFrontAllies,
      Heal,
      HighPriorityPosition,
      HitAllCrownEnemies,
      HitAllEnemiesInRow,
      HitAllEnemies,
      HitAllUndamagedEnemies,
      HitFurthestTarget,
      HitRandomTarget,
      ImmuneToFrost,
      ImmuneToSnow,
      ImmuneToSpice,
      ImmuneToVim,
      IncreaseAllSpiceAppliedNoDesc,
      IncreaseAttackAndHealth,
      IncreaseAttackAndLoseHalfHealth,
      IncreaseAttackEffect1,
      IncreaseAttackWhileAlone,
      IncreaseAttackWhileDamaged,
      IncreaseAttack,
      IncreaseEffects,
      IncreaseMaxCounter,
      IncreaseMaxHealth,
      Injury,
      InstantAddScrap,
      InstantApplyAttackToApplier,
      InstantApplyCurrentAttackToAllies,
      InstantApplyCurrentAttackToRandomAlly,
      InstantApplyFrenzyToItemInHand,
      InstantDraw,
      InstantGainAimless,
      InstantGainFury,
      InstantGainNoomlinToCardInHand,
      InstantGainSoulboundToEnemy,
      InstantSummonBloo,
      InstantSummonCopyOfItem,
      InstantSummonCopyOnOtherSideWithXHealth,
      InstantSummonCopy,
      InstantSummonDregg,
      InstantSummonFallow,
      InstantSummonGearhammerInHand,
      InstantSummonJunkInHand,
      InstantSummonSunShardInHand,
      InstantSummonTailsFour,
      InstantSummonTailsOne,
      InstantSummonTailsThree,
      InstantSummonTailsTwo,
      Kill,
      LastStand,
      LoseHalfHealth,
      LoseJuice,
      LoseScrap,
      LowPriorityPosition,
      Lumin,
      MultiHitTemporaryAndNotVisible,
      MultiHit,
      MustHaveJuiceToTrigger,
      Null,
      OnCardPlayedAddFuryToTarget,
      OnCardPlayedAddGearhammerToHand,
      OnCardPlayedAddJunkToHand,
      OnCardPlayedAddScrapToRandomAlly,
      OnCardPlayedAddSoulboundToRandomAlly,
      OnCardPlayedAddSunShardToHand,
      OnCardPlayedApplyAttackToSelf,
      OnCardPlayedApplyBlockToRandomUnit,
      OnCardPlayedApplyFrostToRandomEnemy,
      OnCardPlayedApplyHazeToRandomEnemy,
      OnCardPlayedApplyInkToRandomEnemy,
      OnCardPlayedApplyOverloadToFrontEnemy,
      OnCardPlayedApplyShellToRandomAlly,
      OnCardPlayedApplyShroomToEnemies,
      OnCardPlayedApplySnowToEnemiesInRow,
      OnCardPlayedApplySpiceToRandomAlly,
      OnCardPlayedApplyTeethToRandomAlly,
      OnCardPlayedBoostToRandomAlly,
      OnCardPlayedBoostToRandomEnemy,
      OnCardPlayedDamageFrostedEnemies,
      OnCardPlayedDamageInkedEnemies,
      OnCardPlayedDamageToSelfAndAlliesInRow,
      OnCardPlayedDamageUndamagedEnemies,
      OnCardPlayedDestroyRandomCardInHand,
      OnCardPlayedDestroyRandomJunkInHand,
      OnCardPlayedDestroyRightmostCardInHand,
      OnCardPlayedDoubleVimToSelf,
      OnCardPlayedLose1JuiceToSelfNoDesc,
      OnCardPlayedLoseScrapToSelf,
      OnCardPlayedReduceAttackEffect1ToSelf,
      OnCardPlayedReduceCounterToAllies,
      OnCardPlayedSacrificeRandomAlly,
      OnCardPlayedTakeHealthFromAllies,
      OnCardPlayedTriggerAgainstAllyBehind,
      OnCardPlayedTriggerRandomAlly,
      OnCardPlayedUseRandomItemInHandAgainstRandomEnemy,
      OnCardPlayedVimToAllies,
      OnCardPlayedVimToSelf,
      OnCardPlayedVoidToEnemies,
      OnHitDamageDamagedTarget,
      OnHitDamageFrostedTarget,
      OnHitDamageShelledTarget,
      OnHitDamageSnowedTarget,
      OnHitEqualDamageToInkedTarget,
      OnHitEqualHealToFrontAlly,
      OnHitEqualOverloadToTarget,
      OnHitEqualSnowToTarget,
      OnHitPullTarget,
      OnHitPushTarget,
      OnKillApplyAttackToSelf,
      OnKillApplyBlockToSelf,
      OnKillApplyGoldToSelf,
      OnKillApplyScrapToAllies,
      OnKillApplyScrapToAllyBehind,
      OnKillApplyScrapToRandomAlly,
      OnKillApplyShellToSelf,
      OnKillApplyStealthToSelf,
      OnKillApplyTeethToSelf,
      OnKillApplyVimToAllyBehind,
      OnKillApplyVimToRandomAlly,
      OnKillApplyVimToRandomEnemy,
      OnKillDraw,
      OnKillHealToSelfAndAlliesInRow,
      OnKillHealToSelf,
      OnKillIncreaseHealthToSelfAndAllies,
      OnTurnApplyAttackToSelf,
      OnTurnApplyDemonizeToRandomEnemy,
      OnTurnApplyInkToEnemies,
      OnTurnApplyInkToRandomEnemy,
      OnTurnApplyJuiceToAllyBehind,
      OnTurnApplyOverloadToRandomEnemy,
      OnTurnApplyScrapToAllyAhead,
      OnTurnApplyScrapToAllyBehind,
      OnTurnApplyScrapToRandomAlly,
      OnTurnApplyScrapToSelf,
      OnTurnApplyShellToAllies,
      OnTurnApplyShellToAllyInFrontOf,
      OnTurnApplyShellToSelf,
      OnTurnApplySnowToEnemies,
      OnTurnApplySpiceToAllies,
      OnTurnApplySpiceToAllyBehind,
      OnTurnApplySpiceToAllyInFrontOf,
      OnTurnApplyTeethToSelf,
      OnTurnApplyVimToAllyBehind,
      OnTurnApplyVimToRandomAlly,
      OnTurnApplyVoidToEveryone,
      OnTurnApplyVoidToRandomEnemy,
      OnTurnEatRandomAllyHealthAndAttackAndEffects,
      OnTurnEscapeToSelf,
      OnTurnHealAllies,
      OngoingIncreaseAttack,
      OngoingIncreaseEffectFactor,
      OngoingIncreaseEffects,
      OngoingReduceAttack,
      Overload,
      PreTriggerGainTempMultiHitEqualToJuice1,
      PreTriggerGainTempMultiHitEqualToScrap1,
      PreTurnDestroyAllItemsInHand,
      PreTurnDestroyRandomCardInHand,
      PreTurnEatAlliesInRowHealthAndAttack,
      PreTurnEatRandomAllyHealthAndAttackAndEffects,
      PreTurnGainAttackForEachItemInHandForEachCardDestroyed,
      PreTurnGainTempMultiHitEqualToJuice,
      PreTurnTakeJuiceFromRandomAlly,
      PreTurnTakeScrapFromRandomAlly,
      Pull,
      Push,
      RecycleJunk,
      RedrawCards,
      ReduceAttackEffect1,
      ReduceAttack,
      ReduceCounter,
      ReduceEffects,
      ReduceMaxCounter,
      ReduceMaxHealthMustbeally,
      ReduceMaxHealth,
      ResistShroom,
      ResistSnow,
      ResistSpice,
      SacrificeAlly,
      SacrificeCardInHand,
      SacrificeEnemy,
      Scrap,
      SetHealth,
      SetMaxHealth,
      Shell,
      Shroom,
      Snow,
      SoulboundBossPhase2,
      Spice,
      Split,
      SplitBossPhase2,
      Stealth,
      SummonBeepop,
      SummonBloo,
      SummonBoBo,
      SummonBonzo,
      SummonDregg,
      SummonEnemyLeech,
      SummonEnemyPigeon,
      SummonEnemyPopper,
      SummonFallow,
      SummonGearhammer,
      SummonItem,
      SummonJunk,
      SummonPlep,
      SummonSunShard,
      SummonTailsFive,
      SummonTailsFour,
      SummonTailsOne,
      SummonTailsThree,
      SummonTailsTwo,
      SummonTigris,
      SummonUzu,
      Summoned,
      Take100DamageWhenSoulboundUnitKilled,
      TakeHealth,
      Teeth,
      TemporaryAimless,
      TemporaryBarrage,
      TemporaryFury,
      TemporaryNoomlin,
      TemporaryPigheaded,
      TemporarySoulbound,
      TemporarySummoned,
      TemporaryUnbreakable,
      TemporaryUnmovable,
      TriggerAgainstAndReduceUses,
      TriggerAgainstDontCountAsTrigger,
      TriggerAgainstAllyWhenAllyIsHit,
      TriggerAgainstAttackerWhenHit,
      TriggerAgainstCrownAlliesWhenDiscarded,
      TriggerAgainstCrownAlliesWhenDrawn,
      TriggerAgainstRandomAllyWhenDiscarded,
      TriggerAgainstRandomAllyWhenDrawn,
      TriggerAgainstRandomEnemy,
      TriggerAgainstRandomUnitWhenDiscarded,
      TriggerAgainstRandomUnitWhenDrawn,
      TriggerAgainstWhenAllyAttacks,
      TriggerAgainstWhenFrostApplied,
      TriggerAgainstWhenSnowApplied,
      TriggerAgainstWhenWeaknessApplied,
      TriggerAgainst,
      TriggerWhenAllyAttacks,
      TriggerWhenAllyInRowAttacks,
      TriggerWhenAllyIsHit,
      TriggerWhenDeployed,
      TriggerWhenEnemyIsKilled,
      TriggerWhenJunkDestroyed,
      TriggerWhenRedrawHit,
      Trigger,
      Unmovable,
      Weakness,
      WhenAllyIsHealedApplyEqualSpice,
      WhenAllyIsHealedTriggerToSelf,
      WhenAllyisHitApplyFrostToAttacker,
      WhenAllyisHitApplyShroomToAttacker,
      WhenAllyisHitApplyTeethToSelf,
      WhenAllyisHitApplyVimToTarget,
      WhenAllyisHitHealToTarget,
      WhenAllyisHitIncreaseHealthToSelf,
      WhenAllyIsKilledApplyAttackToSelf,
      WhenAllyIsKilledGainTheirAttack,
      WhenAllyIsKilledLoseHalfHealthAndGainAttack,
      WhenAllyIsKilledTriggerToSelf,
      WhenAllyIsSacrificedGainTheirAttack,
      WhenAllyIsSacrificedTriggerToSelf,
      WhenAnyoneTakesShroomDamageApplyAttackToSelf,
      WhenBuiltAddJunkToHand,
      WhenBuiltApplyVimToSelf,
      WhenCardDestroyedAndGainAttack,
      WhenCardDestroyedAndGainJuice,
      WhenCardDestroyedAndReduceCounterToSelf,
      WhenConsumedAddHealthToAllies,
      WhenConsumedApplyOverloadToEnemies,
      WhenDeployedAddJunkToHand,
      WhenDeployedApplyBlockToSelf,
      WhenDeployedApplyFrenzyToSelf,
      WhenDeployedApplyInkToAllies,
      WhenDeployedApplyInkToEnemiesInRow,
      WhenDeployedCopyEffectsOfRandomEnemy,
      WhenDeployedFillBoardFinalBoss,
      WhenDeployedSummonWowee,
      WhenDestroyedApplyDamageToAlliesInRow,
      WhenDestroyedApplyDamageToAttacker,
      WhenDestroyedApplyDamageToEnemiesEqualToJuice,
      WhenDestroyedApplyDamageToEnemiesInRow,
      WhenDestroyedApplyFrenzyToRandomAlly,
      WhenDestroyedApplyHazeToAttacker,
      WhenDestroyedApplyOverloadToAttacker,
      WhenDestroyedApplySpiceToAllies,
      WhenDestroyedApplyStealthToAlliesInRow,
      WhenDestroyedSummonDregg,
      WhenDestroyedTriggerToAllies,
      WhenDrawnApplySnowToAllies,
      WhenEnemiesAttackApplyDemonizeToAttacker,
      WhenEnemyShroomedIsKilledApplyTheirShroomToRandomEnemy,
      WhenEnemyDeployedCopyEffectsOfTarget,
      WhenEnemyIsKilledApplyGoldToSelf,
      WhenEnemyIsKilledApplyShellToAttacker,
      WhenHealedApplyAttackToSelf,
      WhenHealedTriggerToSelf,
      WhenHealthLostApplyEqualAttackToSelfAndAllies,
      WhenHealthLostApplyEqualFrostToSelf,
      WhenHealthLostApplyEqualSpiceToSelf,
      WhenHitAddFrenzyToSelf,
      WhenHitAddGearhammerToHand,
      WhenHitAddHealthLostToAttacker,
      WhenHitAddHealthLostToRandomAlly,
      WhenHitAddJunkToHand,
      WhenHitApplyBlockToRandomAlly,
      WhenHitApplyDemonizeToAttacker,
      WhenHitApplyFrostToEnemies,
      WhenHitApplyFrostToRandomEnemy,
      WhenHitApplyGoldToAttackerNoPing,
      WhenHitApplyInkToAttacker,
      WhenHitApplyInkToRandomEnemy,
      WhenHitApplyInkToSelf,
      WhenHitApplyOverloadToAttacker,
      WhenHitApplyShellToAllies,
      WhenHitApplyShellToAllyBehind,
      WhenHitApplyShellToSelf,
      WhenHitApplyShroomToAttacker,
      WhenHitApplyShroomToRandomEnemy,
      WhenHitApplySnowToAttacker,
      WhenHitApplySnowToEnemies,
      WhenHitApplySnowToRandomEnemy,
      WhenHitApplySpiceToAlliesAndEnemiesAndSelf,
      WhenHitApplySpiceToAllies,
      WhenHitApplySpiceToAlliesInRow,
      WhenHitApplySpiceToSelf,
      WhenHitApplyStealthToSelf,
      WhenHitApplyVimToSelf,
      WhenHitApplyVoidToAttacker,
      WhenHitApplyWeaknessToAttacker,
      WhenHitDamageToEnemies,
      WhenHitDamageToEnemiesInRow,
      WhenHitDraw,
      WhenHitEqualDamageToAttacker,
      WhenHitGainAttackToSelfNoPing,
      WhenHitGainTeethToSelf,
      WhenHitIncreaseAttackEffect1ToSelf,
      WhenHitIncreaseAttackToRandomAlly,
      WhenHitIncreaseHealthToRandomAlly,
      WhenHitReduceAttackToAttacker,
      WhenHitReduceAttackToSelf,
      WhenHitReduceCounterToSelf,
      WhenHitTriggerToSelf,
      WhenHitWithJunkAddFrenzyToSelf,
      WhenJuiceAppliedToSelfGainFrenzy,
      WhenSacrificedSummonTailsFour,
      WhenSacrificedSummonTailsOne,
      WhenSacrificedSummonTailsThree,
      WhenSacrificedSummonTailsTwo,
      WhenShellAppliedToSelfGainSpiceInstead,
      WhenShroomAppliedToAnythingDoubleAmountAndLoseScrap,
      WhenShroomDamageTakenTriggerToSelf,
      WhenSnowAppliedToAnythingGainAttackToSelf,
      WhenSnowAppliedToAnythingGainEqualAttackToSelf,
      WhenSnowAppliedToSelfApplyDemonizeToEnemies,
      WhenSnowAppliedToSelfGainEqualAttack,
      WhenSpiceXAppliedToSelfTriggerToSelf,
      WhenVimAppliedToAnythingDoubleAmount,
      WhenXHealthLostSplit,
      WhileActiveAddEqualAttackToJunkInHand,
      WhileActiveAimlessToEnemies,
      WhileActiveBarrageToAllies,
      WhileActiveBarrageToAlliesInRow,
      WhileActiveBarrageToEnemies,
      WhileActiveFrenzyToAllies,
      WhileActiveFrenzyToCrownAllies,
      WhileActiveHaltSpiceToAllies,
      WhileActiveIncreaseAllSpiceApplied,
      WhileActiveIncreaseAttackbyCurrentToAllies,
      WhileActiveIncreaseAttackbyCurrentToSummonedAllies,
      WhileActiveIncreaseAttackToAlliesAndEnemies,
      WhileActiveIncreaseAttackToAlliesNoDesc,
      WhileActiveIncreaseAttackToAllies,
      WhileActiveIncreaseAttackToAlliesInRow,
      WhileActiveIncreaseAttackToItemsInHand,
      WhileActiveIncreaseAttackToJunkInHand,
      WhileActiveIncreaseEffectsToAlliesAndEnemies,
      WhileActiveIncreaseEffectsToFrontAlly,
      WhileActiveIncreaseEffectsToHand,
      WhileActivePigheadedToEnemies,
      WhileActiveReduceAttackToEnemiesNoPingAndNoDesc,
      WhileActiveSnowImmuneToAllies,
      WhileActiveTeethToAllies,
      WhileActiveUnmovableToEnemies,
      WhileInHandReduceAttackToAllies,
      WhileLastInHandDoubleEffectsToSelf,
    }

    public enum VanillaTraits
    {
      None,
      Aimless,
      Backline,
      Barrage,
      Bombard1,
      Bombard2,
      Combo,
      Consume,
      Crush,
      Draw,
      Effigy,
      Explode,
      Frontline,
      Fury,
      Greed,
      Hellbent,
      Knockback,
      Longshot,
      Noomlin,
      Pigheaded,
      Pull,
      Recycle,
      Smackback,
      Soulbound,
      Spark,
      Summoned,
      Trash,
      Unmovable,
      Wild,
    }

    public enum VanillaRewardPools
    {
      None,
      BasicItemPool,
      BasicUnitPool,
      BasicCharmPool,
      GeneralItemPool,
      GeneralUnitPool,
      GeneralCharmPool,
      MagicItemPool,
      MagicUnitPool,
      MagicCharmPool,
      ClunkItemPool,
      ClunkUnitPool,
      ClunkCharmPool,
    }

    public enum VanillaCardAnimationProfiles
    {
      None,
      HeartbeatAnimationProfile,
      FloatAnimationProfile,
      FloatSquishAnimationProfile,
      FlyAnimationProfile,
      GiantAnimationProfile,
      HangAnimationProfile,
      Heartbeat2AnimationProfile,
      PingAnimationProfile,
      PulseAnimationProfile,
      ShakeAnimationProfile,
      SquishAnimationProfile,
      SwayAnimationProfile,
      GoopAnimationProfile,
    }

    public enum VanillaBloodProfiles
    {
      None,
      BloodProfileBerry,
      BloodProfileBlack,
      BloodProfileBlueDouble,
      BloodProfileFungus,
      BloodProfileNormal,
      BloodProfileSnow,
      BloodProfilePinkWisp,
      BloodProfileHusk,
    }

    public enum VanillaTargetModes
    {
      None,
      TargetModeAll,
      TargetModeAllUndamaged,
      TargetModeBack,
      TargetModeBasic,
      TargetModeRandom,
      TargetModeRow,
      TargetModeCrowns,
    }

    public enum VanillaCardUpgrades
    {
      None,
      CardUpgradeAcorn,
      CardUpgradeAttackAndHealth,
      CardUpgradeAttackConsume,
      CardUpgradeAttackIncreaseCounter,
      CardUpgradeAttackRemoveEffects,
      CardUpgradeBalanced,
      CardUpgradeBarrage,
      CardUpgradeBattle,
      CardUpgradeBling,
      CardUpgradeBlock,
      CardUpgradeBom,
      CardUpgradeBombskull,
      CardUpgradeBoost,
      CardUpgradeCake,
      CardUpgradeCloudberry,
      CardUpgradeConsume,
      CardUpgradeConsumeAddHealth,
      CardUpgradeConsumeOverload,
      CardUpgradeCritical,
      CardUpgradeCrush,
      CardUpgradeDemonize,
      CardUpgradeDraw,
      CardUpgradeEffigy,
      CardUpgradeFrenzyConsume,
      CardUpgradeFrenzyReduceAttack,
      CardUpgradeFrosthand,
      CardUpgradeFury,
      CardUpgradeGreed,
      CardUpgradeHeart,
      CardUpgradeHook,
      CardUpgradeInk,
      CardUpgradeNoomlin,
      CardUpgradeOverload,
      CardUpgradePig,
      CardUpgradePunchfist,
      CardUpgradeRemoveCharmLimit,
      CardUpgradeScrap,
      CardUpgradeShellBecomesSpice,
      CardUpgradeShellOnKill,
      CardUpgradeShroom,
      CardUpgradeShroomReduceHealth,
      CardUpgradeSnowball,
      CardUpgradeSnowImmune,
      CardUpgradeSpark,
      CardUpgradeSpice,
      CardUpgradeSpiky,
      CardUpgradeSun,
      CardUpgradeTeethWhenHit,
      CardUpgradeTrash,
      CardUpgradeWeakness,
      CardUpgradeWildcard,
      Crown,
    }

    public enum VanillaCardTypes
    {
      None,
      Boss,
      BossSmall,
      Clunker,
      Enemy,
      Friendly,
      Item,
      Leader,
      Miniboss,
      Summoned,
    }

    [Flags]
    public enum CanPlay
    {
      None = 0,
      CanPlayOnBoard = 1,
      CanPlayOnEnemy = 2,
      CanPlayOnFriendly = 4,
      CanPlayOnHand = 8,
    }
  }
}
