using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Localization.Components;
using WildfrostHopeMod;
using static Routine;

namespace WildfrostHopeMod
{
    public class EnemyCompanionMod : WildfrostMod
    {
        //public static Paths Paths;
        public static EnemyCompanionMod Mod;
        public EnemyCompanionMod(string modDirectory) : base(modDirectory)
        {
            Mod = this; //Paths = new Paths(ModDirectory);
        }
        public override string GUID => "hope.wildfrost.enemycompanions";
        public override string[] Depends => new string[] { };
        public override string Title => "Enemy Companions";
        public override string Description => "Seeing your feeble attempts at taking down the Wildfrost, your enemies have started to come along your adventure. Is it just a game to them?\r\n\r\nYou can choose to allow Minibosses to show up via the Journal/Mod Configs (enabled through the Config Manager).\r\nNote: this doesn't fully replace your normal companions. There's just a lot of enemies...\r\nThere's also a setting to register enemy EyeData for when they're corrupted. Wouldn't recommend it with googly eye mod just yet.";

        [ConfigItem(false, "DOES NOT include Boss cards such as <card=SplitBoss>\r\n//\r\n//DOES include BossSmall cards such as <card=SplitBoss1> and <card=SplitBoss2>", "Minibosses in Rewards")]
        public bool minibossesConfig;

        /*[HideInConfigManager]
        [ConfigItem(false, null, "Enemies have EyeData (mostly finished)")]
        */public bool eyedataConfig;

        public override void Load()
        {

            base.Load();

            var generalPool = CreatePools("Hope.EC.GeneralEnemyPool", true, "Split Boss", "Drek", "Final Boss"); //"Pengoons", "Snowbos", 
            foreach (var classd in Get<GameMode>("GameModeNormal").classes)
            {
                AddEnemies(classd, generalPool);
            }
            AddressableLoader.AddRangeToGroup("EyeData", EyeDataAdder.Eyes());
            FixReserves();
        }

        static void FixReserves()
        {
            Mod.Get<CardType>("Enemy").canReserve = true;
            Mod.Get<CardType>("BossSmall").canReserve = true;
            Mod.Get<CardType>("Miniboss").canReserve = true;
            Mod.Get<CardType>("Boss").canReserve = true;
        }
        static void UnFixReserves()
        {
            Mod.Get<CardType>("Enemy").canReserve = false;
            Mod.Get<CardType>("BossSmall").canReserve = false;
            Mod.Get<CardType>("Miniboss").canReserve = false;
            Mod.Get<CardType>("Boss").canReserve = false;
        }

        static void AddEnemies(ClassData c, params RewardPool[] generalPool)
        {
            c.rewardPools = c.rewardPools.AddRangeToArray(generalPool);
            switch (c.name)
            {
                case "Basic":
                    c.rewardPools = c.rewardPools.AddRangeToArray(CreatePools($"Hope.EC.{c.name}EnemyPool", false,
                        "Shroomers", "Yeti", "Spice Monkeys", "Toadstool Boss"
                        ));
                    break;
                case "Magic":
                    c.rewardPools = c.rewardPools.AddRangeToArray(CreatePools($"Hope.EC.{c.name}EnemyPool", false,
                        "Berries", "Goats", "Blockers", "Spikers", "Husks"
                        ));
                    break;
                case "Clunk":
                    c.rewardPools = c.rewardPools.AddRangeToArray(CreatePools($"Hope.EC.{c.name}EnemyPool", false,
                        "Frosters", "Clunker Boss", "Wildlings", "Frenzy Boss"
                        ));
                    break;
            }
        }


        static RewardPool[] CreatePools(string name, bool general = false, params string[] args)
        {
            RewardPool pool = ScriptableObject.CreateInstance<RewardPool>();
            pool.name = name;
            pool.isGeneralPool = general;
            pool.type = "Units";
            pool.copies = 1;
            pool.list = new();

            RewardPool pool2 = ScriptableObject.CreateInstance<RewardPool>();
            pool2.name = name.Replace("Enemy", "EnemyClunker");
            pool2.isGeneralPool = general;
            pool2.type = "Items";
            pool2.copies = 1;
            pool2.list = new();

            RewardPool pool3 = ScriptableObject.CreateInstance<RewardPool>();
            pool3.name = name.Replace("Enemy", "Miniboss");
            pool3.isGeneralPool = general;
            pool3.type = "Units";
            pool3.copies = 1;
            pool3.list = new();

            foreach (var arg in args)
            {
                var units = Mod.Get<BattleData>(arg).GetUnits();
                if (general) units.AddRange(Mod.Get<BattleData>(arg).goldGiverPool);
                if (arg == "Split Boss") units.AddRange(new List<CardData> { Mod.Get<CardData>("SplitBoss1"), Mod.Get<CardData>("SplitBoss2") });
                if (arg == "Final Boss")
                {
                    var s = GameObject.FindObjectsOfTypeAll(typeof(BattleGenerationScriptFinalBoss)).FirstOrDefault() as BattleGenerationScriptFinalBoss;
                    units.AddRange(s.defaultDeck);
                }
                pool.list.AddRange(units.AsAllies());
                pool2.list.AddRange(units.AsItems());
                pool3.list.AddRange(pool.list.Where(u => (u as CardData).cardType.miniboss));
                pool.list.RemoveMany(pool3.list);
            }
            var result = new List<RewardPool>{ };
            foreach (var p in new List<RewardPool>{pool, pool2, pool3})
                if (p.list.Any())
                {
                    p.list.RemoveDuplicates();
                    Mod.WriteWarn($"Created {p.name} with {args.Length} battle data, and {p.list.Count} enemies");
                    result.Add(p);
                }
            return result.ToArray();
        }

        public override void Unload()
        {
            foreach (var classd in Get<GameMode>("GameModeNormal").classes)
                classd.rewardPools = classd.rewardPools.RemoveFromArray(p => p.name.StartsWith("Hope.EC."));
            
            foreach (var data in EyeDataAdder.Eyes())
            {
                AddressableLoader.RemoveFromGroup("EyeData", data);
            }
            UnFixReserves();
            base.Unload();
        }

        /*[HarmonyPatch(typeof(Journal), nameof(Journal.PagedOpened))]
        internal class PatchJournal
        {
            static void UpdateSetting(int val)
            {
                Mod.minibossesConfig = val == 1 ? true : false;
                var path = Path.Combine(Mod.ModDirectory, "config.cfg");
                string[] strArray = File.ReadAllLines(path);
                for (int i = 0; i < strArray.Length; i++)
                    if (strArray[i].Split(':', '=')[1].Trim() == "Allow minibosses in rewards")
                    {
                        strArray[i] = strArray[i].Remove(strArray[i].IndexOf("=")) + $"= {Mod.minibossesConfig}";
                        File.WriteAllLines(path, strArray);
                        Debug.Log($"Setting Saved [Minibosses in Rewards = {Mod.minibossesConfig}]");
                        return;
                    }
                return;
            }
            static void Postfix(Journal __instance, JournalPage page)
            {
                if (page.name != "GameSettings" || page.transform.Find("Hope.EC.Config")) return;
                var boolType = page.gameObject.GetComponentsInChildren<SettingOptions>(true).FirstOrDefault(s => s.dropdown.options.Count == 2);
                if (boolType)
                {
                    var button = boolType.gameObject.InstantiateKeepName();
                    button.name = "Hope.EC.Config";
                    button.transform.SetParent(page.transform);

                    button.GetComponent<SetSettingInt>().Destroy();
                    SettingOptions setter = button.GetComponent<SettingOptions>();
                    setter.SetValue(Mod.minibossesConfig ? 1 : 0);
                    setter.onValueChanged.AddListener(UpdateSetting);

                    var title = button.GetComponentInChildren<TextMeshProUGUI>();
                    foreach (var e in button.GetComponentsInChildren<LocalizeStringEvent>()) e.enabled = false;
                    foreach (var e in button.GetComponentsInChildren<FontSetter>()) e.enabled = false;
                    title.text = "Minibosses in Rewards";

                    button.gameObject.SetActive(true);
                }
            }
        }*/

        [HarmonyPatch(typeof(CharacterRewards), nameof(CharacterRewards.Populate))]
        internal class PatchRewards
        {
            static void Postfix(CharacterRewards __instance)
            {
                var toRemove = new List<string>();
                if (!Mod.minibossesConfig && __instance.poolLookup.TryGetValue("Units", out CharacterRewards.Pool units))
                {
                    foreach (var pool in References.PlayerData.classData.rewardPools.Where(p => p.name.Contains("Miniboss")))
                    {
                        var minibosses = pool.list.Select(c => c.name);
                        toRemove.AddRange(minibosses);
                    }
                    Debug.LogWarning($"[Enemy Companions] Locked Units: [{string.Join(", ", toRemove)}]");
                    units.Remove(toRemove);
                }
            }
        }
        [HarmonyPatch(typeof(Character), nameof(Character.GetCompanionCount))]
        internal class PatchCompanionsBecauseImLazy
        {
            static void Postfix(Character __instance, ref int __result)
            {
                __result = __instance.data.inventory.deck.FindAll(a => a.cardType.name != "Leader" && a.cardType.canDie && a.cardType.name != "Clunker").Count;
            }
        }
        [HarmonyPatch(typeof(CompanionLimitSequence), nameof(CompanionLimitSequence.Run))]
        internal class PatchCompanionsBecauseImLazy2
        {
            static void Prefix(CompanionLimitSequence __instance)
            {
                
                var companionLimitSequence = __instance;
                foreach (CardData data in companionLimitSequence.owner.data.inventory.deck)
                {
                    if (data.cardType.name != "Friendly" && data.cardType.name != "Leader" && data.cardType.canDie && data.cardType.name != "Clunker")
                        CoroutineManager.Start(companionLimitSequence.CreateCard(companionLimitSequence.activeContainer, data));
                }
                foreach (CardData data in companionLimitSequence.owner.data.inventory.reserve)
                {
                    if (data.cardType.name != "Friendly" && data.cardType.name != "Leader" && data.cardType.canDie && data.cardType.name != "Clunker")
                        CoroutineManager.Start(companionLimitSequence.CreateCard(companionLimitSequence.reserveContainer, data));
                }
            }
        }

        [HarmonyPatch(typeof(DeckDisplayGroup), nameof(DeckDisplayGroup.GetGrid), new Type[] { typeof(CardData) })]
        internal class PatchCompanionsBecauseImLazy3
        {
            static void Postfix(DeckDisplayGroup __instance, CardData cardData, ref CardContainerGrid __result)
            {
                __result = cardData.cardType.canReserve ? __instance.grids.Last() : __result;
            }
        }
    }

    public static class EyeDataAdder
    {
        static Dictionary<string, (int, int, float, float, float)[]> eyeDictionary = new Dictionary<string, (int, int, float, float, float)[]>()
        {// the one with bigger x position is the one on the right (player side). the first eye will be on top
            { "Pengoon", new (int, int, float, float, float)[]{
                (163, 142, 1.3f, 1.3f, 3.0f), (131, 135, 1.1f, 1.1f, -4.0f)
            } },
            { "Burster", new (int, int, float, float, float)[]{
                (151, 186, 0.9f, 0.9f, 3f), (127, 187, 1.0f, 1.0f, 0.0f)
            } },
            { "BabySnowbo", new (int, int, float, float, float)[]{
                (190+4, 155-17, 0.6f, 0.6f, 0.0f), (155, 150-17, 0.6f, 0.6f, 0.0f)
            } },
            { "BerryWitch", new (int, int, float, float, float)[]{
                (194, 113, 0.9f, 0.9f, -3f), (164, 107, 1.0f, 1.0f, -3f)
            } },
            { "BulbHead", new (int, int, float, float, float)[]{
                (129, 184, 1.0f, 1.0f, -13f), (158, 191, 1.0f, 1.0f, -13f)
            } },
            { "BerryMonster", new (int, int, float, float, float)[]{
                (195, 125, 0.7f, 0.7f, 2.0f), (176, 126, 0.8f, 0.8f, 2.0f)
            } },
            { "Frostinger", new (int, int, float, float, float)[]{
                (174, 114, 1.0f, 1.0f, 0.0f)
            } },
            { "Gobbler", new (int, int, float, float, float)[]{
                (178, 99, 0.85f, 0.85f, 9f), (160, 102, 0.9f, 0.9f, 9f)
            } },
            { "Chungoon", new (int, int, float, float, float)[]{
                ( 98, 175, 1.0f, 1.0f, 12.0f), (127, 164, 1.0f, 1.0f, 12.0f)
            } },
            { "Conker", new (int, int, float, float, float)[]{
                (212+4, 208-12, 0.8f, 0.8f, 5.0f), (183+4, 206-12, 1.0f, 1.0f, -3.0f)
            } },
            { "Sno", new (int, int, float, float, float)[]{
                (174,  70, 1.0f, 1.0f, 0.0f), (146,  70, 1.0f, 1.0f, 0.0f)
            } },
            { "Gobling", new (int, int, float, float, float)[]{
                ( 89, 167, 1.0f, 1.0f, 5.0f), (120, 157, 1.0f, 1.0f, 5.0f)
            } },
            { "Smackgoon", new (int, int, float, float, float)[]{
                (138, 160, 1.0f, 1.0f, 4f), (180, 153, 1.0f, 1.0f, 14.0f)
            } },
            { "Gok", new (int, int, float, float, float)[]{
                (154, 117, 0.8f, 0.6f, 0.0f), (162, 106, 0.8f, 1.0f, 0.0f), (174, 117, 1.0f, 0.75f, 0.0f)
            } },
            { "Grink", new (int, int, float, float, float)[]{
                (179, 125, 0.9f, 0.9f, 0.0f), (157, 127, 0.9f, 0.9f, 0.0f)
            } },
            { "Wildling", new (int, int, float, float, float)[]{
                (147, 172, 1.3f, 1.3f, 0.0f), (99, 172, 0.7f, 0.9f, 0.0f)
            } },
            { "JabJoat", new (int, int, float, float, float)[]{
                (187, 116, 1.0f, 1.0f, 0.0f), (157, 117, 1.0f, 1.0f, 0.0f)
            } },
            { "Blockhead", new (int, int, float, float, float)[]{
                (181, 162, 1.0f, 1.0f, 4f), (121, 176, 1.0f, 1.0f, 0.0f)
            } },
            { "Icemason", new (int, int, float, float, float)[]{
                (213, 200, 0.5f, 1.0f, 0.0f), (158, 201, 1.1f, 1.1f, 0.0f)
            } },
            { "Makoko", new (int, int, float, float, float)[]{
                (184, 144, 1.0f, 1.0f, 0.0f), (150, 141, 1.0f, 1.0f, 0.0f)
            } },
            { "Spyke", new (int, int, float, float, float)[]{
                (102, 170, 1.0f, 1.0f, 0.0f), (137, 170, 1.0f, 1.0f, 0.0f)
            } },
            { "Grog", new (int, int, float, float, float)[]{
                (178, 112, 1.1f, 1.1f, 0.0f), (140, 112, 1.1f, 1.1f, 0.0f)
            } },
            { "Noodle", new (int, int, float, float, float)[]{
                (170, 135, 0.9f, 0.9f, 4.0f), (149, 138, 0.9f, 0.9f, 4.0f)
            } },
            { "Grouchy", new (int, int, float, float, float)[]{
                (143, 135-19, 0.9f, 1.0f, 2.0f), (181, 143-19, 1.1f, 1.1f, -3.0f)
            } },
            { "Chunky", new (int, int, float, float, float)[]{
                (195, 141, 1.0f, 1.0f, 0.0f), (155, 140, 1.0f, 1.0f, 0.0f),
            } },
            { "PepperWitch", new (int, int, float, float, float)[]{
                (148, 140, 0.9f, 0.9f, 0.0f), (129, 142, 0.9f, 0.9f, 0.0f),
            } },
            { "Berro", new (int, int, float, float, float)[]{
                (170, 55, 0.9f, 0.9f, 0.0f), (152, 55, 0.9f, 0.9f, 0.0f),
            } },
            { "Popshroom", new (int, int, float, float, float)[]{
                (176, 216, 1.0f, 1.0f, 0.0f), (148, 218, 1.0f, 1.0f, 0.0f),
            } },
            { "Sporkypine", new (int, int, float, float, float)[]{
                (212, 152, 1.0f, 1.0f, 10f), (179, 158, 1.0f, 1.0f, 10f),
            } },
            { "Minimoko", new (int, int, float, float, float)[]{
                (134, 125, 0.9f, 0.9f, 20.0f), (160, 116, 0.9f, 0.9f, 20.0f)
            } },
            { "OobaBear", new (int, int, float, float, float)[]{
                (176, 106, 0.9f, 0.9f, 0.0f), (158, 106, 0.9f, 0.9f, 0.0f),
            } },
            { "Stinghorn", new (int, int, float, float, float)[]{
                (147, 187, 1.0f, 1.0f, 0.0f), (123, 187, 1.0f, 1.0f, 0.0f),
            } },
            { "Pecan", new (int, int, float, float, float)[]{
                (193, 168, 0.7f, 0.7f, 0.0f), (179, 169, 0.7f, 0.7f, 0.0f),
            } },
            { "Puffball", new (int, int, float, float, float)[]{
                (187, 127, 1.8f, 2.0f, 8.0f), (141, 138, 2.0f, 2.0f, 0.0f),
            } },
            { "Pygmy", new (int, int, float, float, float)[]{
                ( 72, 144, 1.0f, 1.25f, -5f), (180, 195, 0.5f, 0.5f, 4f), (251, 202, 1.0f, 1.0f, 11f), (216, 75, 0.7f, 0.75f, -8f)
            } },
            { "Wally", new (int, int, float, float, float)[]{
                (218, 200, 1.0f, 1.0f, 0.0f), (197, 200, 1.0f, 1.0f, 0.0f),
            } },
            { "ShellWitch", new (int, int, float, float, float)[]{
                (123, 139, 0.95f, 0.95f, -27f)//, (224, 98, 1.0f, 1.0f, 0.0f)
            } },
            { "ShroomGobbler", new (int, int, float, float, float)[]{
                (143, 123, 1.0f, 1.0f, 0.0f), (174, 123, 1.0f, 1.0f, 0.0f)
            } },
            { "Shrootles", new (int, int, float, float, float)[]{
                (86, 199, 0.7f, 0.7f, 25.56f), (109, 188, 0.7f, 0.7f, 25.56f),(145, 178, 0.7f, 0.7f, -15.64f), (170, 185, 0.7f , 0.7f, -15.64f), (227, 195, 0.7f , 0.7f, -8.97f), (208, 189, 0.7f , 0.7f, -8.97f)
            } },
            { "Confuddler", new (int, int, float, float, float)[]{
                (149,  73, 1.0f, 1.0f, 0.0f), (186,  74, 1.0f, 1.0f, 0.0f)
            } },
            { "SnowGobbler", new (int, int, float, float, float)[]{
                (169, 134, 0.5f, 0.5f, 0.0f), (157, 135, 0.5f, 0.5f, 0.0f)
            } },
            { "Snowbirb", new (int, int, float, float, float)[]{
                (178,  74, 1.0f, 1.0f, 0.0f), (145,  78, 1.0f, 1.0f, 0.0f), (178, 188, 1.0f, 1.0f, 7.77f), (212, 174, 0.9f, 1.0f, 7f)
            } },
            { "Prickle", new (int, int, float, float, float)[]{
                (192, 170, 1.3f, 1.1f, 3f), (155, 174, 1.3f, 1.1f, 0.0f),
            } },
            { "WoollyDrek", new (int, int, float, float, float)[]{
                (137,  89, 1.0f, 1.0f, 0.0f), (192,  88, 1.0f, 1.0f, 0.0f)
            } },
            { "Snowbo", new (int, int, float, float, float)[]{
                (174, 130-23, 1.1f, 1.1f, 0.0f), (215, 126-23, 1.1f, 1.1f, 0.0f)
            } },
            { "Spuncher", new (int, int, float, float, float)[]{
                (173, 117, 0.7f, 0.7f, -22f), (158, 113, 0.7f, 0.7f, -25f),
            } },
            { "Voido", new (int, int, float, float, float)[]{
                (149, 187, 1.0f, 1.0f, 0.0f), (177, 186, 1.0f, 1.0f, 0.0f)
            } },
            { "Waddlegoons", new (int, int, float, float, float)[]{
                ( 92, 202, 1.0f, 1.0f, 23.63f), (133, 186, 1.0f, 1.0f, 23.63f), (176, 135, 0.7f , 0.7f, -3f), (159, 134, 0.7f , 0.7f, -3f), (194, 211, 0.9f, 0.9f, -15.42f), (223, 219, 0.9f, 0.9f, -15.42f),
            } },
            { "Wrecker", new (int, int, float, float, float)[]{
                (181, 180, 1.0f, 1.0f, 0.0f), (222, 179, 1.0f, 1.0f, 0.0f)
            } },
            { "Snoolf", new (int, int, float, float, float)[]{
                (202+5, 193-12, 0.7f, 0.7f, -6f), (181+5, 194-12, 1.1f, 1f, -8f),
            } },
            { "Burner", new (int, int, float, float, float)[]{
                (153, 154, 1.3f, 1.3f, 0.0f), (202, 152, 0.85f, 1.2f, 5f)
            } },
            { "SnormWorm", new (int, int, float, float, float)[]{
                (196, 110-22, 1.0f, 1.0f, -23f), (172, 101-22, 1.0f, 1.0f, -21f),
            } },

        };
        public static List<EyeData> Eyes()
        {
            var eyes = new List<EyeData>();
            if (!EnemyCompanionMod.Mod.eyedataConfig) return eyes;
            foreach (var item in eyeDictionary)
            {
                var cardName = item.Key;
                //Debug.LogWarning(cardName);
                var data = ScriptableObject.CreateInstance<EyeData>();
                {
                    data.cardData = cardName; data.name = data.cardData + "EyeData";
                    var pairList = item.Value.ToList();
                    foreach (var pair in pairList)
                    {
                        data.eyes = data.eyes
                            .AddItem(new EyeData.Eye()
                            {
                                scale = new Vector2(pair.Item3, pair.Item4),
                                position = (new Vector2(2, 3) - new Vector2(pair.Item1, pair.Item2) / 78) * new Vector2(-1, 1),
                                rotation = pair.Item5
                            }).ToArray();
                    }
                    eyes.Add(data);
                }
            }
            return eyes;
        }
    }

    public static class Ext
    {
        public static List<CardData> GetUnits(this BattleData battle)
        {
            var units = new List<CardData>();
            foreach (var pool in battle.pools)
                foreach (var wave in pool.waves)
                    units.AddRange(wave.units);
            units.AddRange(battle.bonusUnitPool);
            return units.Distinct().ToList();
        }
        public static List<CardData> AsAllies(this List<CardData> cards)
        {
            var units = new List<CardData>();
            foreach (var card in cards)
            {
                if (card.cardType.item || card.isEnemyClunker || card.cardType.name == "Clunker") continue;
                if (card.cardType.name == "Enemy")
                    card.greetMessages = card.greetMessages.AddRangeToArray(new string[] {
                        $"Hello! I'm <#804248><name></color>. I'll madly join your team. Hmph!",
                        $"Hello there! I'm <#804248><name></color>. Don't keep me waiting."
                    });
                if (card.cardType.name == "Miniboss" || card.cardType.name == "BossSmall")
                    card.greetMessages = card.greetMessages.AddRangeToArray(new string[] {
                        $"Greetings! I'm <#804248><name></color>. Let's have a change of pace!"
                    });
                if (card.greetMessages.Any()) units.Add(card);
            }
            return units;
        }
        public static List<CardData> AsItems(this List<CardData> cards)
        {
            var units = new List<CardData>();
            foreach (var card in cards)
            {
                var c = card;
                if (c.cardType.item || c.isEnemyClunker || card.cardType.name == "Clunker")
                {
                    units.Add(c);
                }
            }
            return units;
        }
    }
}