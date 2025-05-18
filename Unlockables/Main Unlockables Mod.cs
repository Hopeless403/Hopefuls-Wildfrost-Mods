using Deadpan.Enums.Engine.Components.Modding;
using FMODUnity;
using HarmonyLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;
using static ChallengeListener;
using static Routine;

namespace Unlockables
{
    public static class UnlockDataBuilderHelpers
    {
        /// <param name="builder"></param>
        /// <param name="name"></param>
        /// <param name="displayTitle">Title when going to Town with new unlocks. Leave null to use default: "New Pet Trained!"</param>
        /// <param name="displayDescription">Description when going to Town with new unlocks. Leave null to use default: "Visit the Pet House to discover your new pet!"</param>
        /// <param name="unlocksRequired">Other UnlockDatas that must be completed before this</param>
        /// <returns></returns>
        public static UnlockDataBuilder CreatePetReward(this UnlockDataBuilder builder, string name, string displayTitle = default, string displayDescription = default, params string[] unlocksRequired)
        {
            builder =  builder
                .Create(name)
                .WithType(UnlockData.Type.Pet)
                .SubscribeToAfterAllBuildEvent(data =>
                {
                    data.relatedBuilding = builder.Mod.GetAsset<BuildingType>("Buildings/PetHut.asset");
                    if (!data.relatedBuilding.unlocks.ToArrayOfNames().Contains(data.name))
                        data.relatedBuilding.unlocks = data.relatedBuilding.unlocks.AddToArray(data);

                    data.requires = new UnlockData[]
                    {
                        builder.Mod.Get<UnlockData>("PetHutFinished"),
                    }.AddRangeToArray(unlocksRequired.Select(u => builder.Mod.Get<UnlockData>(u)).ToArray());
                });
            if (displayTitle == default)
                builder = builder.WithUnlockTitle(Extensions.GetLocalizedString("UI Text", "unlock_pet"));
            else
                builder = builder.WithUnlockTitle(displayTitle);

            if (displayDescription == default)
                builder = builder.WithUnlockDescription(Extensions.GetLocalizedString("UI Text", "unlock_pet_desc"));
            else
                builder = builder.WithUnlockDescription(displayDescription);

            return builder;
        }

        /// <param name="builder"></param>
        /// <param name="name"></param>
        /// <param name="displayTitle">Title when going to Town with new unlocks. Leave null to use default: "New Pet Trained!"</param>
        /// <param name="displayDescription">Description when going to Town with new unlocks. Leave null to use default: "Visit the Pet House to discover your new pet!"</param>
        /// <param name="unlocksRequired">Other UnlockDatas that must be completed before this</param>
        /// <returns></returns>
        public static UnlockDataBuilder CreateItemReward(this UnlockDataBuilder builder, string name, string displayTitle = default, string displayDescription = default, params string[] unlocksRequired)
        {
            builder = builder
                .Create(name)
                .WithType(UnlockData.Type.Tribe)
                .SubscribeToAfterAllBuildEvent(data =>
                {
                    data.relatedBuilding = builder.Mod.GetAsset<BuildingType>("Buildings/TribeHut.asset");
                    if (!data.relatedBuilding.unlocks.ToArrayOfNames().Contains(data.name))
                        data.relatedBuilding.unlocks = data.relatedBuilding.unlocks.AddToArray(data);
                    data.requires = new UnlockData[]
                    {
                        builder.Mod.Get<UnlockData>("TribeHutFinished"),
                    }.AddRangeToArray(unlocksRequired.Select(u => builder.Mod.Get<UnlockData>(u)).ToArray());
                });
            if (displayTitle == default)
                builder = builder.WithUnlockTitle(Extensions.GetLocalizedString("UI Text", "unlock_tribe"));
            else
                builder = builder.WithUnlockTitle(displayTitle);

            if (displayDescription == default)
                builder = builder.WithUnlockDescription(Extensions.GetLocalizedString("UI Text", "unlock_tribe_desc"));
            else
                builder = builder.WithUnlockDescription(displayDescription);

            return builder;
        }
    }



    [HarmonyPatch]
    public partial class UnlockablesMod : WildfrostMod
    {
        // it should be named this to show up as a Singleton in UnityExplorer
        public static UnlockablesMod instance;
        public UnlockablesMod(string modDirectory) : base(modDirectory)
        {
            instance = this;
        }
        public override string GUID => "hope.wildfrost.Unlockables";
        public override string[] Depends => new string[] { };
        public override string Title => "Tutorial: Making Unlockables";
        public override string Description => $"Last update: {DateTime.Now}";
        public override void Load()
        {
            

            var unlock = new UnlockDataBuilder(this).CreatePetReward("Unlock Pet IceForge",
                displayTitle: default,
                displayDescription: "What are you doing there?"
                );

            var listener = new ChallengeListenerBuilder(this)
                .Create("IceForge: Achieve a 6x Kill Combo")
                .SubscribeToAfterAllBuildEvent(data =>
                {
                    data.checkType = ChallengeListener.CheckType.MidRun;

                    if (data.checkType == ChallengeListener.CheckType.CustomSystem)
                    {
                        data.systemName = "";
                    }
                    else
                    {
                        data.stat = "totalTriggers";
                        data.hasKey = true;
                        if (data.hasKey)
                            data.key = "basic";
                        Debug.LogWarning($"CURRENT LISTENER: {OverallStatsSystem.Get().Get("totalTriggers", "basic", 0)}/{data.target}");
                    }
                });

            var challenge = new ChallengeDataBuilder(this)
              .Create("Challenge Pet IceForge")
              .WithText("Trigger 1 more time")
              .WithRewardText(Extensions.GetLocalizedString("Challenges", "Reward Pet"))
              .SubscribeToAfterAllBuildEvent(data =>
              {
                  data.goal = OverallStatsSystem.Get().Get("totalTriggers", "basic", 0) + 2;
                  data.listener = Get<ChallengeListener>("IceForge: Achieve a 6x Kill Combo");
                  data.icon = GetImageSprite("icon.png");
                  data.requires = new ChallengeData[] { };
                  data.reward = TryGet<UnlockData>("Unlock Pet IceForge");
              });




            LayoutElement layout = GetAsset<GameObject>("ProgressableCardStack").GetOrAdd<LayoutElement>();
            (layout.preferredWidth, layout.preferredHeight) = (2.5f,3.65f);
            CardStack stack = GetAsset<GameObject>("ProgressableCardStack").GetOrAdd<CardStack>();
            GetAsset<GameObject>("ProgressableCardStack").GetComponentInChildren<ChallengeDisplayCreator>().challenge = null;


            //GetAsset<GameObject>("ProgressableCardStack").GetOrAdd<CardStack>().onAdd.AddListener(onAdd);

            var cards = new CardDataBuilder(instance)
                .CreateUnit(name: "IceForge", englishTitle: "Ice Forge", idleAnim: "FloatAnimationProfile")
                .WithCardType("Clunker")
                .AddPool()
                .SubscribeToAfterAllBuildEvent(data =>
                {
                    /// Note: IsPet breaks because it doesn't have a slotGrid...
                    data.Edit<CardData, CardDataBuilder>().IsItem(Get<ChallengeData>("Challenge Pet IceForge"));
                    TryGet<UnlockData>("Unlock Pet IceForge").type = UnlockData.Type.Item;

                    int extra = 0;
                    for (var i = 0; i < extra; i++)
                    {
                        var c = Get<ChallengeData>("Challenge Pet IceForge").InstantiateKeepName();
                        c.reward = TryGet<UnlockData>("Unlock Pet IceForge").InstantiateKeepName();
                        c.reward.name += i.ToString();
                        data.Edit<CardData, CardDataBuilder>().IsItem(c);
                    }
                    
                    //data.AddToPets(TryGet<UnlockData>("Unlock Pet IceForge").name);
                    _ = nameof(PetHutPatches.UpdatePetChallenges); // data.AddToPets relies on this

                    //data.AddToItems();
                    data.startWithEffects = new CardData.StatusEffectStacks[]
                    {
                                new CardData.StatusEffectStacks(instance.Get<StatusEffectData>("While Active Increase Attack To Allies (No Desc)"), 2),
                                new CardData.StatusEffectStacks(instance.Get<StatusEffectData>("While Active Reduce Attack To Enemies (No Ping, No Desc)"), 2),
                                new CardData.StatusEffectStacks(instance.Get<StatusEffectData>("Scrap"), 2),
                    };
                    data.titleFallback = "Ice Forge";
                });


            

            var card2 = new CardDataBuilder(instance)
                .CreateUnit(name: "IceForge2", englishTitle: "Ice Forge", idleAnim: "FloatAnimationProfile")
                .WithCardType("Clunker")
                .SubscribeToAfterAllBuildEvent(data =>
                {
                    /// Note: IsPet breaks because it doesn't have a slotGrid...
                    data.Edit<CardData, CardDataBuilder>().IsItem(Get<ChallengeData>("Challenge Pet IceForge"));
                    data.AddToPets(TryGet<UnlockData>("Unlock Pet IceForge").name);
                    _ = nameof(PetHutPatches.UpdatePetChallenges); // data.AddToPets relies on this

                    //data.AddToItems();
                    data.startWithEffects = new CardData.StatusEffectStacks[]
                    {
                                new CardData.StatusEffectStacks(instance.Get<StatusEffectData>("While Active Increase Attack To Allies (No Desc)"), 2),
                                new CardData.StatusEffectStacks(instance.Get<StatusEffectData>("While Active Reduce Attack To Enemies (No Ping, No Desc)"), 2),
                                new CardData.StatusEffectStacks(instance.Get<StatusEffectData>("Scrap"), 2),
                    };
                    data.titleFallback = "Ice Forge";
                });

            assets = [unlock, listener, challenge, card2, cards];

            /*Debug.LogWarning("PreLoaded:");
             * Addressables.LoadAssetsAsync<BuildingType>(
                "Buildings", 
                type => type.unlocks.Do(unlock => Debug.LogError((type, unlock)))
            ).WaitForCompletion();*/
            base.Load();
            /*Debug.LogWarning("Loaded:");
            Resources.FindObjectsOfTypeAll<BuildingType>().Do(type =>
            {
                type.unlocks.Do(unlock => Debug.LogError((type, unlock)));
            });*/

            
            RestoreUnlocks();
        }
        /// <summary>
        /// Gains Unlocks (and their requirements) from Completed Challenges
        /// </summary>
        static void RestoreUnlocks()
        {
            SaveSystem.instance.GetComponent<SaveFileChecker>().Start();
        }
        public override void Unload()
        {
            base.Unload();
            FixUnlocks();

            Debug.LogWarning("UnLoaded:");
            Resources.FindObjectsOfTypeAll<BuildingType>().Do(type =>
            {
                type.unlocks.Do(unlock => Debug.LogError((type, unlock)));
            });
        }

        [HarmonyPrefix]
        [HarmonyPatch(typeof(InventorHutSequence), nameof(InventorHutSequence.Start))]
        static void InventorHutSequenceStart(InventorHutSequence __instance)
        {
            __instance.slotGrid = __instance.cardSlots[0].GetComponentInParent<GridLayoutGroup>();
            if (__instance.slotGrid.TryGetComponent<Scroller>(out var scroller))
            {
                __instance.slotGrid.constraint = GridLayoutGroup.Constraint.FixedColumnCount;
                __instance.slotGrid.constraintCount = 6;
                scroller.horizontal = false;
            }

            Transform[] challenges = __instance.slotGrid.transform.parent.Find("Challenge Grid")?.GetAllChildren() ?? [];
            Transform[] slots = __instance.slotGrid.transform.GetAllChildren();
            for (int i = 0; i < challenges.Length; i++)
            {
                Transform challenge = challenges[i];
                if (i < slots.Length && slots[i])
                {
                    challenge.SetParent(slots[i]);
                    challenge.localPosition = new Vector2(1.25f, 1.75f);// Vector2.zero;
                    Debug.LogWarning($"local of {challenge} is {challenge.localPosition}");
                }
            }
            //__instance.slotGrid.transform.parent.Find("Challenge Grid")?.SetParent(__instance.slotGrid.transform);
        }

        /*[HarmonyPostfix]
        [HarmonyPatch(typeof(BuildingSequenceWithUnlocks<InventorHutSequence>), nameof(InventorHutSequence.AddSlot))]
        static void AddSlot(BuildingSequenceWithUnlocks<InventorHutSequence> __instance, ChallengeData unlock)
        {
            if (!unlock || __instance is not InventorHutSequence sequence)
                return;
            
            CardContainer addedSlot = __instance.cardSlots.ToList().Find(a => a.gameObject?.GetComponentInChildren<ChallengeDisplayCreator>()?.challenge == unlock);
            //__instance.building.uncheckedUnlocks.Add(unlock.name);

            *//*List<string> stringList = SaveSystem.LoadProgressData<List<string>>(__instance.building.type.unlockedCheckedKey, new List<string>());
            stringList.Add(unlockDataName);
            SaveSystem.SaveProgressData<List<string>>(__instance.building.type.unlockedCheckedKey, stringList);*//*

            Card card = CardManager.Get(AddressableLoader.Get<CardData>("CardData", assetName), sequence.controller, (Character)null, false, true);
            //yield return (object)card.UpdateData(false);
            CardContainer finalSlot = (__instance.cardSlots).FirstOrDefault<CardContainer>((Func<CardContainer, bool>)(a => a.Empty));
            //yield return (object)inventorHutSequence.cardUnlockSequence.Run(card.entity, finalSlot);
            if ((bool)(UnityEngine.Object)finalSlot)
            {
                Image component = finalSlot.GetComponent<Image>();
                if (component != null)
                    component.enabled = true;
            }
        }*/











        [HarmonyPatch(typeof(Building), nameof(Building.CheckIfUnlocked))]
        [HarmonyPatch(typeof(Building), nameof(Building.RunUpdateEvent))]
        static void Postfix(Building __instance, MethodInfo __originalMethod)
        {
            

            Debug.LogError((__instance.name, __originalMethod.Name));
            if (__instance.type?.unlocks != null && __instance.type.unlocks.Any())
                Debug.LogWarning(__instance.type?.unlocks?.DefaultIfEmpty().Join());

            Debug.LogWarning($"""
                .
                Unlocks: {__instance.unlocks.Join()}
                Unchecked unlocks: {__instance.uncheckedUnlocks.Join()}
                Checked unlocks: {__instance.checkedUnlocks.Join()}
                """);

            if (!__instance.name.StartsWith("Pet"))
                return;
            Dictionary<string, string> petDict = MetaprogressionSystem.GetPetDict();
            List<string> checkedUnlocks = __instance.checkedUnlocks;
            foreach (KeyValuePair<string, string> keyValuePair in petDict)
            {
                string petName = keyValuePair.Key;
                string petChallengeName = keyValuePair.Value;
                Debug.Log(petChallengeName);
                if (petChallengeName == null || checkedUnlocks != null && checkedUnlocks.Contains(petChallengeName))
                {
                    Debug.LogWarning("UNLOCKED PET: " + petName);
                }
                else
                    Debug.LogWarning("");
            }
        }

        public class InventorHutPatches
        {

        }


        [HarmonyPatch(typeof(GameObjectExt), nameof(GameObjectExt.AddComponentByName))]
        public static bool Prefix(ref Component __result, GameObject gameObject, string componentName)
        {
            Type componentType = Type.GetType(componentName) ?? instance.GetType().Assembly.GetType(componentName);
            if (componentType != null)
            {
                __result = gameObject.AddComponent(componentType);
                return false;
            }

            return true;
        }


        //[HarmonyPrefix]
        //[HarmonyPatch(typeof(ChallengeDisplayCreator), nameof(ChallengeDisplayCreator.OnEnable))]
        //[HarmonyPatch(typeof(ChallengeDisplayCreator), nameof(ChallengeDisplayCreator.Check))]
        public static bool ChallengeDisplayCreator(ChallengeDisplayCreator __instance, MethodInfo __originalMethod)
        {
            Debug.LogError($"{__originalMethod.Name}ING DISPLAY: " + __instance.challenge);
            Debug.LogWarning($"""
                >> {(__instance, __instance.challenge?.reward, __instance.challenge?.reward?.IsActive)}
                >> {(SaveSystem.LoadProgressData<List<string>>("completedChallenges", (List<string>)null) ?? new List<string>()).Contains(__instance.challenge?.name)}
                """);
            return true; 
        }
        //[HarmonyPrefix]
        //[HarmonyPatch(typeof(ChallengeProgressDisplay), nameof(ChallengeProgressDisplay.UpdateDisplay))]
        public static bool ChallengeProgressDisplay(ChallengeProgressDisplay __instance)
        {
            Debug.LogError($">>>>>> updatING DISPLAY: " + __instance.challengeData);
            Debug.LogWarning($"""
                >>>>>>>>>>>>> {(__instance, __instance.challengeData?.reward, __instance.challengeData?.reward?.IsActive)}
                >>>>>>>>>>>>>>> {(SaveSystem.LoadProgressData<List<string>>("completedChallenges", (List<string>)null) ?? new List<string>()).Contains(__instance.challengeData?.name)}
                """);
            return true;
        }

        public void FixUnlocks()
        {
            Resources.FindObjectsOfTypeAll<BuildingType>().Do(type =>
            type.unlocks = type.unlocks.Where(unlock => unlock != null && unlock.ModAdded != this).ToArray()
            );
        }

        public new T Get<T>(string name) where T : DataFile => TryGet<T>(name);
        internal T TryGet<T>(string name) where T : DataFile
        {
            T data;
            if (typeof(StatusEffectData).IsAssignableFrom(typeof(T)))
                data = base.Get<StatusEffectData>(name) as T;

            else if (typeof(KeywordData).IsAssignableFrom(typeof(T)))
            {
                string assetName = Extensions.PrefixGUID(name, this).ToLower();
                data = AddressableLoader.Get<KeywordData>(nameof(KeywordData), assetName) as T;
            }

            else
                data = base.Get<T>(name);

            if (data == null)
                throw new Exception($"TryGet Error: Could not find a [{typeof(T).Name}] with the name [{name}] or [{Extensions.PrefixGUID(name, this)}]");

            return data;
        }



        public void Log(object message) => Debug.Log($"[{Title}] {message}");
        public void LogWarning(object message) => Debug.LogWarning($"[{Title} Warning] {message}");
        public void LogError(object message) => Debug.LogError($"[{Title} Error] {message}");

        public static List<object> assets = new List<object>();
        public override List<T> AddAssets<T, Y>()
        {
            if (assets.OfType<T>().Any())
                this.Log($"adding {typeof(Y).Name}s: {assets.OfType<T>().Select(a => a._data.name).Join()}");
            return assets.OfType<T>().ToList();
        }
    }
}