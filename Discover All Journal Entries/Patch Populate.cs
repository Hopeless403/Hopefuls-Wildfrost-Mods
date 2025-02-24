using HarmonyLib;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Localization.SmartFormat.Utilities;
using static JournalCardManagerPopulator;
using static Mono.Security.X509.Extensions.NetscapeCertTypeExtension;

namespace WildfrostHopeMod
{
    public partial class DiscoverAllMod
    {
        static readonly UnityEngine.Localization.Locale nothingLocale = ScriptableObject.CreateInstance<UnityEngine.Localization.Locale>();
        /// <summary>
        /// Regenerate all journal cards
        /// </summary>
        [HarmonyPatch(typeof(JournalCardManager), nameof(JournalCardManager.OnEnable))]
        static void Prefix(JournalCardManager __instance)
        {
            __instance.locale = nothingLocale;
            bool repopulate = false;

            if (__instance.populator.GetCategory("Enemy") is not Category cat)
                return;

            repopulate |= cat.cardNames.Contains("Dap") != instance.hiddenCards;
            if (__instance.subbed && repopulate)
            {
                __instance.requiresRebuild = true;
                __instance.populator.Clear();
            }
        }




        static readonly HashSet<string> usedCards = [];
        static readonly HashSet<string> playerCards = [];
        static readonly HashSet<string> usedPools = [];
        static JournalCardManagerPopulator populator;
        /// <summary>
        /// Recover clunkers & tribe flags
        /// </summary>
        [HarmonyPatch(typeof(JournalCardManagerPopulator), nameof(JournalCardManagerPopulator.Populate))]
        static bool Prefix(JournalCardManagerPopulator __instance)
        {
            populator = __instance;

            if (__instance.GetCategory("Friendly") is Category friendlies && !friendlies.cardTypes.Contains("Leader"))
                friendlies.cardTypes = [..friendlies.cardTypes.Union(["Leader"])];

            if (__instance.GetCategory("Enemy") is Category enemies && !enemies.cardTypes.Contains("Summoned"))
                enemies.cardTypes = enemies.cardTypes.With("Summoned");

            __instance.populated = true;
            StopWatch.Start();

            usedCards.Clear();
            playerCards.Clear();
            usedPools.Clear();

            StorePlayerCards(); // to separate player/enemy cards
            ProcessCards();     // for player cards
            ProcessBattles();   // for enemy cards

            Debug.LogWarning($"Journal Card Manager Population Done! ({StopWatch.Stop()}ms)");
            return false;
        }
        
        static void StorePlayerCards()
        {
            foreach (ClassData classData in References.Classes)
            {
                if (classData == null)
                {
                    Debug.LogWarning($"[{instance.Title}] Encountered null ClassData in References.Classes");
                    continue;
                };
                if (classData.startingInventory == null)
                    Debug.LogWarning($"[{instance.Title}] Encountered null startingInventory in tribe [{classData}]");
                else
                {
                    if (classData.startingInventory.deck == null)
                        Debug.LogWarning($"[{instance.Title}] Encountered null starting deck in tribe [{classData}]");
                    if (classData.startingInventory.reserve == null)
                        Debug.LogWarning($"[{instance.Title}] Encountered null starting reserve in tribe [{classData}]");
                }

                int i = 0;
                foreach (CardData cardData in classData.leaders) StoreAsPlayerCard(cardData);
                foreach (CardData cardData in classData.startingInventory?.deck) StoreAsPlayerCard(cardData);
                foreach (CardData cardData in classData.startingInventory?.reserve) StoreAsPlayerCard(cardData);
                foreach (RewardPool rewardPool in classData.rewardPools)
                {
                    if (rewardPool == null)
                    {
                        Debug.LogWarning($"[{instance.Title}] Encountered null RewardPool in [{classData}]");
                        continue;
                    };
                    if (usedPools.Add(rewardPool.name))
                    {
                        if (rewardPool.list == null)
                        {
                            Debug.LogWarning($"[{instance.Title}] Encountered null RewardPool.list in [{classData}] pool [{rewardPool}]");
                            continue;
                        }
                        foreach (DataFile dataFile in rewardPool.list)
                        {
                            if (dataFile == null)
                            {
                                Debug.LogWarning($"[{instance.Title}] Encountered null [{dataFile.GetType()}] in [{classData}] pool [{rewardPool}]");
                                continue;
                            }
                            if (dataFile is CardData cardData)
                                StoreAsPlayerCard(cardData);
                        }
                    }
                }
            }
            void StoreAsPlayerCard(CardData cardData)
            {
                if (cardData == null) return;
                if (!playerCards.Add(cardData.name)) return;
                //HandlePlayerCardTypes(cardData);

                foreach (var created in CreatedByThis(cardData))
                    StoreAsPlayerCard(created);
            }
            /*void HandlePlayerCardTypes(CardData cardData)
            {
                if (cardData.cardType.item)


                if (cardData.cardType.unit)
                    if (cardData.cardType.canReserve && populator?.GetCategory("Friendly") is Category friendly)
                        friendly.cardTypes = friendly.cardTypes.With(cardData.cardType.name);
                    else if (populator?.GetCategory("Friendly") is Category enemy)
                    friendly.cardTypes = friendly.cardTypes.With(cardData.cardType.name);

            }*/
        }
        static void ProcessCard(CardData cardData, bool enemy)
        {
            if (!cardData || !usedCards.Add(cardData.name))
                return;

            if (cardData.mainSprite?.name == "Nothing" && !instance.hiddenCards)
                return;

            foreach (var category in populator?.categories)
            {
                if (category.CheckAdd(cardData, enemy))
                    break;
            }

            foreach (var card in CreatedByThis(cardData))
                ProcessCard(card, enemy);
        }
        static void ProcessCards()
        {
            foreach (CardData cardData in AddressableLoader.GetGroup<CardData>("CardData"))
            {
                if (cardData == null) continue;
                if (cardData.scriptableImagePrefab is Leader) continue;

                string cardType = cardData.cardType.name; 
                if (cardType != "Boss" && cardType != "BossSmall" || cardData.name == "FinalBoss2")
                {
                    bool flag = cardType == "Friendly" || cardType == "Item" || playerCards.Contains(cardData.name);
                    ProcessCard(cardData, !flag);
                }
            }
        }
        static void ProcessBattles()
        {
            foreach (BattleData battleData in AddressableLoader.GetGroup<BattleData>("BattleData"))
            {
                foreach (BattleWavePoolData pool in battleData.pools)
                {
                    foreach (BattleWavePoolData.Wave wave in pool.waves)
                    {
                        foreach (CardData unit in wave.units)
                        {
                            //if (unit && unit.cardType.miniboss)
                                ProcessCard(unit, true);
                        }
                    }
                }
            }
        }
        static List<CardData> CreatedByThis(CardData cardData)
        {
            List<CardData> result = [];
            foreach (var s in cardData.startWithEffects)
            {
                var status = s.data;
                if (status is StatusEffectNextPhase phase)
                {
                    if (phase.nextPhase)
                        result.Add(phase.nextPhase);
                    foreach (var summons in phase.splitOptions)
                        result.Add(summons);
                }
                else if (status is StatusEffectSummon summon && summon.summonCard && summon.summonCard.cardType.unit)
                {
                    result.Add(summon.summonCard);
                }
                else if (status is StatusEffectApplyX applyX)
                {
                    if (applyX.effectToApply is StatusEffectInstantSummon appliedSummon
                        && appliedSummon.targetSummon && appliedSummon.targetSummon.summonCard
                        && appliedSummon.targetSummon.summonCard.cardType.unit)
                    {
                        result.Add(appliedSummon.targetSummon.summonCard);
                    }
                    else if (applyX.effectToApply is StatusEffectInstantSplit appliedSplit)
                    {
                        foreach (var profile in appliedSplit.profiles)
                        {
                            CardData summoned = AddressableLoader.Get<CardData>("CardData", profile.changeToCardName);
                            if (summoned)
                                result.Add(summoned);
                        }
                    }
                }
            }
            foreach (CardData.StatusEffectStacks attackEffect in cardData.attackEffects)
            {
                if (attackEffect.data is StatusEffectInstantSummon data && data.targetSummon
                    && data.targetSummon.summonCard && data.targetSummon.summonCard.cardType.unit)
                {
                    result.Add(data.targetSummon.summonCard);
                }
            }
            return result;
        }
    }
}
