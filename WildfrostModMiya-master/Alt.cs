// Decompiled with JetBrains decompiler
// Type: WildfrostModMiya.WildFrostAPIMod
// Assembly: WildfrostModMiya, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 51F56119-3F77-414A-8824-BFF112DF055A
// Assembly location: C:\Users\harri\Downloads\Wildfrost v1.0.4\BepInEx\plugins\WildfrostModMiya.dll

using BepInEx;
using BepInEx.Configuration;
using BepInEx.Core.Logging.Interpolation;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using BepInEx.Unity.IL2CPP.Utils;
using Dead;
using HarmonyLib;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Injection;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.SceneManagement;

namespace WildfrostModMiya
{
    [BepInPlugin("WildFrost.Miya.WildfrostAPI", "WildfrostAPI", "0.1.3.1")]
    public class WildFrostAPIMod : BasePlugin
    {
        public static string ModsFolder = typeof(WildFrostAPIMod).Assembly.Location.Replace("WildfrostModMiya.dll", "");
        public static WildFrostAPIMod Instance;
        public static bool ShouldInjectCards;
        internal static List<CardData> CardDataAdditions = new List<CardData>();
        internal static List<StatusEffectData> StatusEffectDataAdditions = new List<StatusEffectData>();
        internal static List<CardUpgradeData> CardUpgradeDataAdditions = new List<CardUpgradeData>();
        private static int seed = -1;
        internal static List<CardAnimationProfile> VanillaAnimationProfiles;
        internal static List<BloodProfile> VanillaBloodProfiles;
        internal static List<TargetMode> VanillaTargetModes;
        private WildFrostAPIMod.APIGameObject _GameObject;
        private ConfigEntry<bool> configWinBattleButton;
        private ConfigEntry<bool> configGiveDebugCardButton;
        private ConfigEntry<bool> configOpenConsoleButton;
        private ConfigEntry<bool> configSeedManipulation;

        public void AddDebugStuff()
        {
            CardAdder.OnAskForAddingCards += (Action<int>)(i => CardAdder.CreateCardData("API", "DebugCard").SetTitle("Debug Card").SetIsUnit().SetCanPlay(CardAdder.CanPlay.CanPlayOnBoard | CardAdder.CanPlay.CanPlayOnEnemy).SetSprites("CardPortraits\\testPortrait", "CardPortraits\\testBackground").SetStats(new int?(4), new int?(1), 3).SetBloodProfile(CardAdder.VanillaBloodProfiles.BloodProfilePinkWisp).SetIdleAnimationProfile(CardAdder.VanillaCardAnimationProfiles.GoopAnimationProfile).SetStartWithEffects("API.DebugEffect".StatusEffectStack(1)).RegisterCardInApi());
            StatusEffectAdder.OnAskForAddingStatusEffects += (Action<int>)(i => StatusEffectAdder.CreateStatusEffectData<StatusEffectApplyXWhenHit>("API", "DebugEffect").ModifyFields<StatusEffectApplyXWhenHit>((Func<StatusEffectApplyXWhenHit, StatusEffectApplyXWhenHit>)(data =>
            {
                ((StatusEffectApplyX)data).effectToApply = CardAdder.VanillaStatusEffects.Demonize.StatusEffectData();
                data = data.SetText<StatusEffectApplyXWhenHit>("Apply {0} to front enemy when hit");
                ((StatusEffectApplyX)data).applyToFlags = (StatusEffectApplyX.ApplyToFlags)2048;
                ((StatusEffectData)data).textInsert = "<{a}><keyword=demonize>";
                return data;
            })).RegisterStatusEffectInApi<StatusEffectApplyXWhenHit>());
            CardUpgradeAdder.OnAskForAddingCardUpgrades += (Action<int>)(i => CardUpgradeAdder.CreateCardUpgradeData("API", "DebugCardUpgrade").SetAttackEffects(CardAdder.VanillaStatusEffects.Haze.StatusEffectStack(1)).SetText("Gain one <keyword=haze>.").SetTitle("Haze charm").AddToPool(CardAdder.VanillaRewardPools.GeneralCharmPool, CardAdder.VanillaRewardPools.BasicCharmPool, CardAdder.VanillaRewardPools.MagicCharmPool, CardAdder.VanillaRewardPools.ClunkCharmPool).SetUpgradeType((CardUpgradeData.Type)1).SetImage("CardPortraits\\CharmTemplate").RegisterCardUpgradeData());
        }

        private static bool MatchCardName(Object o, string name)
        {
            CardData cardData = ((Il2CppObjectBase)o).Cast<CardData>();
            return ((Object)cardData).name.Equals(name, StringComparison.OrdinalIgnoreCase) || cardData.title.Equals(name, StringComparison.OrdinalIgnoreCase);
        }

        private static IEnumerator DIRTY_ConsoleStuff()
        {
            yield return (object)new WaitUntil(Func<bool>.op_Implicit((Func<bool>)(() => SceneManager.IsLoaded("Console"))));
            Console go = Object.FindObjectOfType<Console>();
            go?.Toggle();
        }

        private static void DIRTY_DebugGui()
        {
            if (WildFrostAPIMod.Instance.configOpenConsoleButton.Value && GUILayout.Button("Try open console?", Array.Empty<GUILayoutOption>()))
            {
                if (!SceneManager.IsLoaded("Console"))
                    CoroutineManager.Start(SceneManager.Load("Console", (SceneType)0, (Action<Scene>)null));
                MonoBehaviourExtensions.StartCoroutine((MonoBehaviour)WildFrostAPIMod.Instance._GameObject, WildFrostAPIMod.DIRTY_ConsoleStuff());
            }
            if (WildFrostAPIMod.Instance.configSeedManipulation.Value)
            {
                WildFrostAPIMod.seed = int.Parse(GUILayout.TextField(WildFrostAPIMod.seed.ToString(), Array.Empty<GUILayoutOption>()));
                if (GUILayout.Button("Randomize Seed", Array.Empty<GUILayoutOption>()))
                    WildFrostAPIMod.seed = Random.Seed();
            }
            if (WildFrostAPIMod.Instance.configWinBattleButton.Value && GUILayout.Button("Try win battle?", Array.Empty<GUILayoutOption>()))
                Battle.instance.PlayerWin();
            if (!WildFrostAPIMod.Instance.configGiveDebugCardButton.Value || !GUILayout.Button("Give me debug card!", Array.Empty<GUILayoutOption>()))
                return;
            CardData cardData1 = (CardData)null;
            foreach (Object o in AddressableLoader.groups["CardData"].list)
            {
                if (WildFrostAPIMod.MatchCardName((Object)o, "API.DebugCard"))
                {
                    cardData1 = ((Il2CppObjectBase)o).Cast<CardData>();
                    break;
                }
            }
            if (Object.op_Inequality((Object)cardData1, (Object)null))
            {
                WildFrostAPIMod.Instance.Log.LogInfo((object)("Gave out card " + cardData1.title));
                CardData cardData2 = cardData1.Clone(true);
                cardData2.original = cardData1;
                Campaign.instance.characters._items[0].data.inventory.deck.Add(cardData2);
                cardData2.id = (ulong)Object.FindObjectsOfType<CardData>().Count * 10UL;
                Campaign.instance.characters._items[0].data.inventory.Save();
            }
            else
                WildFrostAPIMod.Instance.Log.LogInfo((object)"No such card!");
        }

        private static void CreateVanillaAnimationProfiles()
        {
            WildFrostAPIMod.VanillaAnimationProfiles = new List<CardAnimationProfile>();
            foreach (Object typeIncludingAsset in (Il2CppArrayBase<Object>)Object.FindObjectsOfTypeIncludingAssets(Il2CppType.Of<CardAnimationProfile>()))
                WildFrostAPIMod.VanillaAnimationProfiles.Add(((Il2CppObjectBase)typeIncludingAsset).Cast<CardAnimationProfile>());
        }

        private static void CreateVanillaBloodProfiles()
        {
            WildFrostAPIMod.VanillaBloodProfiles = new List<BloodProfile>();
            foreach (Object typeIncludingAsset in (Il2CppArrayBase<Object>)Object.FindObjectsOfTypeIncludingAssets(Il2CppType.Of<BloodProfile>()))
                WildFrostAPIMod.VanillaBloodProfiles.Add(((Il2CppObjectBase)typeIncludingAsset).Cast<BloodProfile>());
        }

        private static void CreateVanillaTargetModes()
        {
            WildFrostAPIMod.VanillaTargetModes = new List<TargetMode>();
            foreach (Object typeIncludingAsset in (Il2CppArrayBase<Object>)Object.FindObjectsOfTypeIncludingAssets(Il2CppType.Of<TargetMode>()))
                WildFrostAPIMod.VanillaTargetModes.Add(((Il2CppObjectBase)typeIncludingAsset).Cast<TargetMode>());
        }

        public virtual void Load()
        {
            this.configWinBattleButton = this.Config.Bind<bool>("Debug.Toggles", "WinBattleButton", false, "Whether or not to show the \"try win battle?\" button");
            this.configGiveDebugCardButton = this.Config.Bind<bool>("Debug.Toggles", "GiveDebugCardButton", false, "Whether or not to show the \"give me debug card!\" button");
            this.configOpenConsoleButton = this.Config.Bind<bool>("Debug.Toggles", "OpenConsoleButton", false, "Whether or not to show the \"OpenConsole!\" button");
            this.configSeedManipulation = this.Config.Bind<bool>("Utils.Toggles", "SeedManipulation", true, "Whether or not to show the seed manipulation ui");
            WildFrostAPIMod.Instance = this;
            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), "WildFrost.Miya.WildfrostAPI");
            ClassInjector.RegisterTypeInIl2Cpp<CardAnimationProfile>();
            ClassInjector.RegisterTypeInIl2Cpp<BloodProfile>();
            ClassInjector.RegisterTypeInIl2Cpp<TargetMode>();
            ClassInjector.RegisterTypeInIl2Cpp<RewardPool>();
            ClassInjector.RegisterTypeInIl2Cpp<WildFrostAPIMod.APIGameObject>();
            this.AddDebugStuff();
            CardAdder.OnAskForAddingCards += new Action<int>(JSONApi.AddJSONCards);
            this._GameObject = this.AddComponent<WildFrostAPIMod.APIGameObject>();
            this.Log.LogInfo((object)"WildFrost API Loaded!");
        }

        [HarmonyPatch(typeof(PreloadAddressableGroup), "Start")]
        private class StartPatch
        {
            [HarmonyPostfix]
            private static void Postfix(PreloadAddressableGroup __instance)
            {
                WildFrostAPIMod.Instance.Log.LogInfo((object)("Preload assets run! " + WildFrostAPIMod.CardDataAdditions.Count.ToString()));
                WildFrostAPIMod.ShouldInjectCards = true;
            }
        }

        [HarmonyPatch(typeof(CampaignData), "Init")]
        private class Patch
        {
            [HarmonyPostfix]
            private static void Postfix(CampaignData __instance)
            {
                if (!WildFrostAPIMod.Instance.configSeedManipulation.Value || WildFrostAPIMod.seed == -1)
                    return;
                __instance.Seed = WildFrostAPIMod.seed;
            }
        }

        [HarmonyPatch(typeof(JournalCardManager), "LoadCardData")]
        private class LoadCardDataPatch
        {
            [HarmonyPostfix]
            private static void Postfix(
              JournalCardManager.Category category,
              JournalCardManager __instance,
              ref List<KeyValuePair<string, CardData>> __result)
            {
                foreach (CardData cardDataAddition in WildFrostAPIMod.CardDataAdditions)
                {
                    if (Object.op_Equality((Object)cardDataAddition.cardType, (Object)((Il2CppObjectBase)((AssetReference)((Il2CppArrayBase<AssetReferenceT<CardData>>)category.cards)[0]).Asset).Cast<CardData>().cardType))
                    {
                        __result.Add(new KeyValuePair<string, CardData>(cardDataAddition.title, cardDataAddition));
                        __instance.discovered.Add(((Object)cardDataAddition).name);
                    }
                }
            }
        }

        public class APIGameObject : MonoBehaviour
        {
            public void OnGUI() => WildFrostAPIMod.DIRTY_DebugGui();

            public void Update()
            {
                if (!WildFrostAPIMod.ShouldInjectCards || !AddressableLoader.groups.ContainsKey("CardData"))
                    return;
                if (!AddressableLoader.IsGroupLoaded("StatusEffectData"))
                    CoroutineManager.Start(AddressableLoader.LoadGroup("StatusEffectData"));
                else if (!AddressableLoader.IsGroupLoaded("CardUpgradeData"))
                    CoroutineManager.Start(AddressableLoader.LoadGroup("CardUpgradeData"));
                else if (!AddressableLoader.IsGroupLoaded("TraitData"))
                {
                    CoroutineManager.Start(AddressableLoader.LoadGroup("TraitData"));
                }
                else
                {
                    WildFrostAPIMod.CreateVanillaAnimationProfiles();
                    if (WildFrostAPIMod.VanillaAnimationProfiles.Count == 0)
                        return;
                    WildFrostAPIMod.CreateVanillaBloodProfiles();
                    if (WildFrostAPIMod.VanillaBloodProfiles.Count == 0)
                        return;
                    WildFrostAPIMod.CreateVanillaTargetModes();
                    if (WildFrostAPIMod.VanillaTargetModes.Count == 0)
                        return;
                    WildFrostAPIMod.StatusEffectDataAdditions = new List<StatusEffectData>();
                    StatusEffectAdder.LaunchEvent();
                    bool flag;
                    for (int index = 0; index < WildFrostAPIMod.StatusEffectDataAdditions.Count; ++index)
                    {
                        StatusEffectData effectDataAddition = WildFrostAPIMod.StatusEffectDataAdditions[index];
                        if (!AddressableLoader.groups["StatusEffectData"].lookup.ContainsKey(((Object)effectDataAddition).name))
                        {
                            AddressableLoader.groups["StatusEffectData"].list.Add((Object)effectDataAddition);
                            AddressableLoader.groups["StatusEffectData"].lookup[((Object)effectDataAddition).name] = (Object)effectDataAddition;
                        }
                        ManualLogSource log = WildFrostAPIMod.Instance.Log;
                        BepInExInfoLogInterpolatedStringHandler interpolatedStringHandler = new BepInExInfoLogInterpolatedStringHandler(33, 1, ref flag);
                        if (flag)
                        {
                            ((BepInExLogInterpolatedStringHandler)interpolatedStringHandler).AppendLiteral("StatusEffect ");
                            ((BepInExLogInterpolatedStringHandler)interpolatedStringHandler).AppendFormatted<string>(((Object)effectDataAddition).name);
                            ((BepInExLogInterpolatedStringHandler)interpolatedStringHandler).AppendLiteral(" is injected by api!");
                        }
                        log.LogInfo(interpolatedStringHandler);
                    }
                    WildFrostAPIMod.CardUpgradeDataAdditions = new List<CardUpgradeData>();
                    CardUpgradeAdder.LaunchEvent();
                    for (int index = 0; index < WildFrostAPIMod.CardUpgradeDataAdditions.Count; ++index)
                    {
                        CardUpgradeData upgradeDataAddition = WildFrostAPIMod.CardUpgradeDataAdditions[index];
                        if (!AddressableLoader.groups["CardUpgradeData"].lookup.ContainsKey(((Object)upgradeDataAddition).name))
                        {
                            AddressableLoader.groups["CardUpgradeData"].list.Add((Object)upgradeDataAddition);
                            AddressableLoader.groups["CardUpgradeData"].lookup[((Object)upgradeDataAddition).name] = (Object)upgradeDataAddition;
                        }
                        ManualLogSource log = WildFrostAPIMod.Instance.Log;
                        BepInExInfoLogInterpolatedStringHandler interpolatedStringHandler = new BepInExInfoLogInterpolatedStringHandler(36, 1, ref flag);
                        if (flag)
                        {
                            ((BepInExLogInterpolatedStringHandler)interpolatedStringHandler).AppendLiteral("CardUpgradeData ");
                            ((BepInExLogInterpolatedStringHandler)interpolatedStringHandler).AppendFormatted<string>(((Object)upgradeDataAddition).name);
                            ((BepInExLogInterpolatedStringHandler)interpolatedStringHandler).AppendLiteral(" is injected by api!");
                        }
                        log.LogInfo(interpolatedStringHandler);
                    }
                    WildFrostAPIMod.CardDataAdditions = new List<CardData>();
                    CardAdder.LaunchEvent();
                    for (int index = 0; index < WildFrostAPIMod.CardDataAdditions.Count; ++index)
                    {
                        CardData cardDataAddition = WildFrostAPIMod.CardDataAdditions[index];
                        if (!AddressableLoader.groups["CardData"].lookup.ContainsKey(((Object)cardDataAddition).name))
                        {
                            AddressableLoader.groups["CardData"].list.Add((Object)cardDataAddition);
                            AddressableLoader.groups["CardData"].lookup.Add(((Object)cardDataAddition).name, (Object)cardDataAddition);
                        }
                        ManualLogSource log = WildFrostAPIMod.Instance.Log;
                        BepInExInfoLogInterpolatedStringHandler interpolatedStringHandler = new BepInExInfoLogInterpolatedStringHandler(25, 1, ref flag);
                        if (flag)
                        {
                            ((BepInExLogInterpolatedStringHandler)interpolatedStringHandler).AppendLiteral("Card ");
                            ((BepInExLogInterpolatedStringHandler)interpolatedStringHandler).AppendFormatted<string>(((Object)cardDataAddition).name);
                            ((BepInExLogInterpolatedStringHandler)interpolatedStringHandler).AppendLiteral(" is injected by api!");
                        }
                        log.LogInfo(interpolatedStringHandler);
                    }
                    WildFrostAPIMod.ShouldInjectCards = false;
                }
            }
        }
    }
}
