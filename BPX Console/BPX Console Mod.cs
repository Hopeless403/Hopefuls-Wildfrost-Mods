using BepInEx;
using BepInEx.Unity.IL2CPP;
using BepInEx.Unity.IL2CPP.Utils;
using BepInEx.Unity.IL2CPP.Utils.Collections;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization;
using Il2CppSystem.Runtime.InteropServices;
using Il2CppSystem.Linq;
using System.Security.Policy;
using Il2CppSystem.Threading;
using HarmonyLib;
using Steamworks;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Globalization;
using static Console;
using System.Reflection;
//using Il2CppSystem;

namespace MyFirstPlugin;

[BepInPlugin("hopeguid", "hopename", "1.0.0.0")]
public class Plugin : BasePlugin
{
    [HarmonyPatch(typeof(SteamManager), nameof(SteamManager.Awake))]
    class PatchSteam
    {
        static bool Prefix(SteamManager __instance)
        {
            try
            {
                SteamClient.Init((uint)SteamManager.appId);
            }
            catch (System.Exception ex)
            {
                Debug.LogError($"Steam failed to initialize! ({ex})");
                Debug.LogWarning("[Harmony Suppressor] Continuing without Steam");
                return false;
            }
            SteamClient.Shutdown();
            return true;
        }
    }

    [HarmonyPatch(typeof(CheckAchievements), "Start")]
    class PatchAchievements { static bool Prefix() => false; }

    [HarmonyPatch(typeof(ScoreSubmitSystem), nameof(ScoreSubmitSystem.GetScore))]
    class PatchLeaderboard
    {
        static void Postfix()
        {
            Debug.LogWarning("messing with the data...");
            ScoreSubmitSystem.SubmittedTime = -1;
            ScoreSubmitSystem.SubmittedScore = -1;
        }
    }

    static List<string> allCharms = new();

    public class APIGameObject : MonoBehaviour
    {
        public static APIGameObject instance;

        private void Awake()
        {
            instance = this;
            Debug.LogWarning("AWAKEN");
            Harmony.CreateAndPatchAll(GetType().Assembly);

        }
        static IEnumerator TryLoadNulls()
        {
            var dataTypes = new string[]
            {
                "BattleData", "BossRewardData", "CardUpgradeData", "ChallengeListener", "StatusEffectData", "BuildingPlotType", "BuildingType", "TraitData"
            }; 
            foreach (string type in dataTypes)
            {
                Debug.LogWarning("trying to load group: " + type);
                var e = AddressableLoader.LoadGroup(type);
                while (true)
                {
                    object current = null;
                    try
                    {
                        if (e.MoveNext() == false)
                        {
                            break;
                        }
                        current = e.Current;
                    }
                    catch { }
                    yield return current;
                }
            }
            yield break;
                       
        }
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Backslash))
            {
                Debug.LogWarning("owo");
                var array = AddressableLoader.Get<CardData>("Blue").startWithEffects;
                var stack = array.First(s => s.data is StatusEffectApplyXWhenUnitLosesY);
                (stack.data as StatusEffectApplyXWhenUnitLosesY).statusType = "scrap";
                CoroutineManager.Start(SceneManager.Load("Console", SceneType.Persistent));
                Debug.Log("owo");
            }
            if (Input.GetKeyDown(KeyCode.Equals))
            {
                Debug.LogWarning("loading");/*
                CoroutineManager.Start(AddressableLoader.LoadGroup("CardData"));
                CoroutineManager.Start(AddressableLoader.LoadGroup("BossRewardData"));
                CoroutineManager.Start(AddressableLoader.LoadGroup("ChallengeListener"));
                CoroutineManager.Start(AddressableLoader.LoadGroup("BuildingPlotType"));
                CoroutineManager.Start(AddressableLoader.LoadGroup("BuildingType"));*/
                CoroutineManager.Start(TryLoadNulls().WrapToIl2Cpp());
            }
            if (Input.GetKey(KeyCode.LeftAlt) && Input.GetKeyDown(KeyCode.K))
            {
                Debug.LogWarning("owo");
                //_GameObject.StartCoroutine(Routine2("").WrapToIl2Cpp());
                //wikify.GetLeaders();
                //wikify.GetCharms();
                //wikify.GetBattles();
                //wikify.GetFGSubs();
                //wikify.GetWiki();
                //wikify.GetTitan();
                //wikify.GetOtherBellUpgrade();
                //wikify.GetFGChanges();
                //wikify.GetNames();
                //wikify.GetDaily();
                //wikify.GetCharmsData();

                var chall = ChallengeSystem.GetAllChallenges().ToArray();
                var list = MetaprogressionSystem.GetLockedCharms(
                        AddressableLoader.GetGroup<UnlockData>("UnlockData").ToArray()
                        .Where(u => u.type == UnlockData.Type.Charm).ToArray().ToRefArray()
                        .ToList()).ToArray().ToArray().ToList();

                var result = "";
                foreach (var charm in list)
                {
                    Debug.LogWarning(charm);
                    
                    var challenge = chall.FirstOrDefault(c => MetaprogressionSystem.GetLockedCharms(new Il2CppReferenceArray<UnlockData>([c.reward]).ToList()).Contains(charm));
                    Debug.Log(challenge);
                    Debug.Log(challenge?.titleKey.GetLocalizedString());
                    var t = AddressableLoader.GetGroup<CardUpgradeData>("CardUpgradeData").ToArray().First(u => u.name == charm).title;
                    result += $$$"""
                        |-
                        ||[[File:{{{challenge?.titleKey.GetLocalizedString()}}}.jpg|100px|]]
                        |{{#invoke:Cards|GetStat|{{{t}}}|Unlock}}
                        |{{#invoke:Cards|GetStat|{{{t}}}|Challenge}}.
                        |Gain the {{Charm|{{{t}}}}}.

                        """;
                }
                Debug.LogWarning(result);

                /*foreach (var card in AddressableLoader.GetGroup<CardData>("CardData").ToArray().ToArray().Where(c => c.attackEffects.Any()))
                {
                    Debug.LogError(card.title);
                    card.attackEffects.ToArray().ToList().ForEach(Debug.LogWarning);
                    card.startWithEffects.ToArray().ToList().ForEach(Debug.Log);
                }*/

                /*var allCards = AddressableLoader.GetGroup<CardData>("CardData").ToArray().ToArray().ToList();
                allCards.Sort((x,y) => x.title.CompareTo(y.title));

                var gen = Resources.FindObjectsOfTypeAll<FinalBossGenerationSettings>().First();
                *//*gen.ignoreTraits.ToList().ForEach(new Action<TraitData>(c => Debug.LogWarning(c.name)));

                gen.ignoreUpgrades.ToList().ForEach(new Action<CardUpgradeData>(c => Debug.LogWarning(c.title)));
*//*
                var s = WikiData.cards;
                var sub = s;
                List<string> matches = new();
                //var r = new Regex(@"cards\[""(.*?)""\] * = *\{((?:[^{}]|(?1))*)\}"); // "cards[\"([^\"]*?)\"] *= *{((?:[^{}]|(?1))*)}"
                int i = 0;
                int e = 0;
                while (false)
                {
                    i = sub.IndexOf("cards[");
                    if (i == -1) break;
                    e = sub.IndexOf("\n}");
                    matches.Add(sub.Substring(i,  e-i+2));
                    sub = sub.Substring(e+2) + '\n';
                }
                var ss = "";

                //var f = Resources.FindObjectsOfTypeAll<DropGoldSystem>().First().goldFactor;

                var pairs = new Dictionary<string, string>();
                foreach (var match in matches)
                {
                    var splits = match.Split('\t');
                    splits[splits.Length-1] = splits.Last().TrimEnd('}');
                    var unique = splits[0].Split('"')[1];
                    var name = splits.First(s => s.Contains("Name")).Split('"')[1];
                    if (unique != name)
                    {

                        splits = splits.AddItem("UniqueName=\"" + unique + "\"\n}").ToArray();
                        s = s.Replace(match, string.Join("\t", splits));
                    }


*//*

                    var name = splits.First(s => s.Contains("Name")).Split('"')[1];
                    pairs[name] = match;
                    foreach (var card in AddressableLoader.GetGroup<CardData>("CardData"))
                        if (card.title == name)
                        {*//*
                            int drops = (Mathf.RoundToInt(card.value * 0.0275f) - 1);
                            splits = splits.AddItem("Gold=" +  drops + "\n}").ToArray();

                            if (card.hp > 0)
                                splits[splits.ToList().FindIndex(s => s.Contains("Health"))] = "Health=" + card.hp;
                            if (card.hasAttack)
                                splits[splits.ToList().FindIndex(s => s.Contains("Attack"))] = "Attack=" + card.damage;
                            if (card.counter > 0)
                                splits[splits.ToList().FindIndex(s => s.Contains("Counter"))] = "Counter=" + card.counter;
*//*

                            s = s.Replace(match, string.Join("\t", splits));


                            break;
                        }
*//*
                }*/
                //Debug.LogWarning(s);



                /*foreach (var item in Resources.FindObjectsOfTypeAll<ScriptUpgradeEnemies>())
            {
                Debug.LogWarning(item);
            }
            TryCount(2);*/
                //Debug.LogError(MetaprogressionSystem.Get<Il2CppSystem.Collections.Generic.List<string>>("companions").Count);
                //Debug.LogWarning(string.Join(", ", MetaprogressionSystem.Get<Il2CppSystem.Collections.Generic.List<string>>("companions")));

                /*MetaprogressionSystem.GetLockedCharms(AddressableLoader.GetGroup<UnlockData>("UnlockData")).ForEach(new Action<string>(allCharms.Add));
                //foreach (var c in allCharms) Debug.LogWarning(c);

                Debug.LogWarning("create list");
                var list = MetaprogressionSystem.GetLockedCompanions(AddressableLoader.GetGroup<UnlockData>("UnlockData"));
                Debug.LogWarning("create tlist");
                var tlist = new Il2CppManagedEnumerable(list.ToArray().AsEnumerable()).Cast<Il2CppSystem.Collections.Generic.IEnumerable<string>>();
                Debug.LogWarning("check missing cards");
                Debug.LogWarning(MissingCardSystem.HasMissingData(tlist));*/
            }
            //Debug.Log("owo" + SceneManager.ActiveSceneName);
        }



        static void TryCount(int count)
        {
            for (int i = 0; i < 3; ++i) Debug.LogWarning(--count);
        }

        public static List<string> names = new List<string>()
        {
            "Dimona",
            "Octako",
            "Lump",
            "Kraken",
            "Gunkback",
            "Gunk Gobbler",
            "Dungrok",
            "Blaze Beetles",
            "Beeberry",
            "Snuffer",
            "Weevil",
            "Nimbus",
            "Lumako",
            "Bogberry",
            "Zoomlin Wafers",
            "Snuffer Mask",
            "Skull Muffin",
            "Bonescraper",
            "Zula",
            "Toaster",
            "The Baker",
            "Spoof",
            "Roibos",
            "Pimento",
            "Nova",
            "Needle",
            "Mama Tinkerson",
            "Lupa",
            "Knuckles",
            "Gojiber",
            "Fulbert",
            "Binku",
            "Zoomlin Nest",
            "Octobom"
        };


        public IEnumerator Routine(CardData cardData)
        {
            Debug.LogError("Started");
            Card temp = null;
            if (!AddressableLoader.IsGroupLoaded("CardData")) yield return AddressableLoader.LoadGroup("CardData");
            
            if (cardData != null && !(cardData.mainSprite?.name == "Nothing"))
            {
                Card card = temp ?? CardManager.Get(cardData, null, null, false, false);
                card.gameObject.SetLayerRecursively(7);
                yield return card.UpdateData(false);
                card.transform.position = Vector3.zero;
                yield return null;
                GameObject newCameraObject = new GameObject("NewCamera");
                ExportCards exportCards = new();
                exportCards._camera = newCameraObject.AddComponent<Camera>();
                exportCards._camera.CopyFrom(Camera.main);
                exportCards._camera.cullingMask = 1 << card.gameObject.layer;
                exportCards.Screenshot(Paths.PluginPath + "/" + exportCards.folder + "/" + cardData.cardType.name, card.titleText.text + " (" + card.name + ").png");
                yield return null;
                CardManager.ReturnToPool(card);
                card = null;
                cardData = null;
                // exportCards.camera.targetTexture = null; // the MainCamera's target texture has to be null
                // exportCards.camera.cullingMask = -1; // this renders every layer
                newCameraObject.Destroy();
            }
            temp.Destroy();
        }
        public IEnumerator Routine2(string args)
        {
            PromptSystem.instance.prompt.SetText("This may take a while...");
            PromptSystem.Create(Prompt.Anchor.Left, 0, 0, 5, Prompt.Emote.Type.Scared, Prompt.Emote.Position.Above);
            ExportCards exportCards = new();

            var textures = new Dictionary<string, Texture2D>();
            var tnames = new List<string>();

            var cn = new List<string>();
            foreach (var u in MetaprogressionSystem.GetLockedCharms(MetaprogressionSystem.GetRemainingUnlocks()))
            {
                //cn.Add(u);
            }
            
            foreach (var cardData in AddressableLoader.GetGroup<CardUpgradeData>("CardUpgradeData"))
                if (cardData != null && !(cardData.image == null) && !(cardData.image.name == "Nothing") && (cardData.title == "Frozen Heart Charm" || cn.Contains(cardData.name) ))
                {
                    Debug.Log(cardData.title);
                    //yield return Routine(cardData);
                    if (!tnames.Contains(cardData.image.texture.name))
                    {
                        textures[cardData.image.texture.name] = cardData.image.texture.MakeReadable();
                    }

                    var texture = textures[cardData.image.texture.name];
                    var pixels = texture.GetPixels((int)cardData.image.textureRect.x,
                        (int)cardData.image.textureRect.y,
                        (int)cardData.image.textureRect.width,
                        (int)cardData.image.textureRect.height);
                    // exportCards.camera.targetTexture = null; // the MainCamera's target texture has to be null
                    // exportCards.camera.cullingMask = -1; // this renders every layer
                    var s = new Texture2D((int)cardData.image.textureRect.width, (int)cardData.image.textureRect.height);
                    s.SetPixels(pixels);
                    s.Apply();
                    byte[] a = s.EncodeToPNG();
                    File.WriteAllBytes(Paths.PluginPath + "/" + exportCards.folder + "/" + "Charms" +"/" + cardData.title + ".png", a);
                }
            PromptSystem.Hide();
            PromptSystem.instance.prompt.SetText("Thank you for your patience!");
            PromptSystem.Create(Prompt.Anchor.Left, 0, 0, 5, Prompt.Emote.Type.Happy, Prompt.Emote.Position.Above);
            yield return new WaitForSeconds(4);
            PromptSystem.Hide();
        }


        internal class wikify
        {
            public static string GetLua(CardData data, string locale)
            {
                LocalizedString localizedString = data.titleKey;
                localizedString.LocaleOverride = LocalizationSettings.AvailableLocales.GetLocale(locale);
                string s = "";
                try { s = localizedString.GetLocalizedString(); }
                catch { }
                return Wikify(s, locale);
            }
            public static string GetDesc(CardData data, string locale)
            {
                LocalizedString localizedString = data.textKey;
                localizedString.LocaleOverride = LocalizationSettings.AvailableLocales.GetLocale(locale);
                return Wikify(localizedString.GetLocalizedString(), locale);
            }
            public static string GetLua(CardUpgradeData data, string locale)
            {
                LocalizedString localizedString = data.titleKey;
                localizedString.LocaleOverride = LocalizationSettings.AvailableLocales.GetLocale(locale);
                return Wikify(localizedString.GetLocalizedString(), locale);
            }
            public static string GetDesc(CardUpgradeData data, string locale)
            {
                LocalizedString localizedString = data.textKey;
                localizedString.LocaleOverride = LocalizationSettings.AvailableLocales.GetLocale(locale);
                return Wikify(localizedString.GetLocalizedString(), locale);
            }
            public static string InLocale(LocalizedString s, string locale)
            {
                s.LocaleOverride = LocalizationSettings.AvailableLocales.GetLocale(locale);
                var res = s.GetLocalizedString();
                s.LocaleOverride = null;
                return res;
            }

            static Dictionary<string, string> renames = new()
        {
            { "Plep", "JunJun" },
            { "OhNo", "ICGM" },
            { "Vimik", "Bombarder (Enemy)"},
            { "BoostPet", "Lil Gazi"},
            { "LilBerry", "Lil Berry"},
            { "Jummo", "Tinkerson Jr" },
            { "JunjunMask", "JunJun Mask"},
            { "Naked Gnome (Enemy)", "Naked Gnome"},
            { "FrenzyBoss2", "Infernoko (Phase 2)"},
            { "ClunkerBoss2", "Krunker (Phase 2)"},
            { "FinalBoss", "Frost Guardian (Phase 2)" }
        };

            public static string Wikify(string s, string locale = "en")
            {
                // Card.GetDescripion(data);
                string str1 = s;
                for (int index = 0; index < str1.Length; ++index)
                {
                    if (str1[index] == '<')
                    {
                        //Debug.LogWarning("Found keyword");
                        int num = str1.IndexOf('>', index);
                        string str2 = str1.Substring(index + 1, num - index - 1);
                        string newValue = str2;
                        if (int.TryParse(newValue.Replace("x", ""), out int val))
                        {
                            newValue = "'''" + str2 + "'''";
                        }
                        else if (!str2.Contains('='))
                        {
                            if (str2 == "/color") newValue = "</span>";
                            else newValue = "'''" + str2 + "'''";
                        }
                        else
                        {
                            //Debug.LogWarning("Found 2");
                            string[] strArray = str2.Split('=');
                            //Debug.LogWarning(strArray[0].Trim());
                            switch (strArray[0].Trim())
                            {
                                case "color":
                                    if (strArray[1] == "#F99C61")
                                        newValue = "<span style=color:brown>";
                                    break;
                                case "sprite name":
                                    newValue = "{{" + strArray[1].ToTitleCase() + "}}";
                                    break;
                                case "keyword":
                                    KeywordData keyword = Text.ToKeyword(strArray[1]);
                                    if (strArray[1].ToLower() == "blings")
                                        newValue = "{{Bling" + (locale != "en" ? "|" + InLocale(keyword.titleKey, locale) : "") + "}}";
                                    else if (keyword.showIcon)
                                    {
                                        newValue = "{{Stat|" + InLocale(keyword.titleKey, "en") + (locale != "en" ? "|" + InLocale(keyword.titleKey, locale) : "") + "}}";
                                    }
                                    else
                                    {
                                        string? count = null;
                                        if (keyword.canStack && strArray[1].Split(' ').Length > 1)
                                            count = strArray[1].Split(' ')[1];
                                        newValue = "{{Keyword|" + InLocale(keyword.titleKey, "en") + (locale != "en" ? "|" + InLocale(keyword.titleKey, locale) : "") + "}}" + (count != null ? $" '''{count}'''" : "");
                                    }

                                    break;
                                case "card":
                                    var titleKey = AddressableLoader.Get<CardData>("CardData", strArray[1].Trim()).titleKey;
                                    newValue = "[[" + InLocale(titleKey, "en") + (locale != "en" ? "|" + InLocale(titleKey, locale) : "") + "]]";
                                    break;
                            }
                        }
                        str1 = str1.Replace(str1.Substring(index, num - index + 1), newValue);
                        index += newValue.Length - 1;
                    }
                }
                str1 = str1
                    .Replace("\n\n", "<br>")
                    .Replace("\n", "<br>")
                    .Trim()
                    .Replace("'''{{", "''' {{");
                return str1;
            }

            public static void GetNames()
            {
                foreach (var item in Names.instance.assets)
                {
                    foreach (var item1 in item.files)
                    {
                        Debug.LogWarning(item.name + ": " + item1.locale);
                        Debug.Log(item1.textAsset);
                    }

                }
            }

            public static void GetCharmsData()
            {
                var charms = AddressableLoader.GetGroup<CardUpgradeData>("CardUpgradeData");
                var byTier = charms.ToArray().ToLookup(c => c.tier).ToList();
                byTier.Sort((x, y) => x.Key.CompareTo(y.Key));
                int tier = -1;
                string result = "--Cursed Charms";
                var pools = AddressableLoader.GetGroup<ClassData>("ClassData").ToArray().SelectMany(c => c.rewardPools.Where(r => r.type.ToLower() == "charms")).Distinct().ToList();
                var locked = MetaprogressionSystem.GetLockedCharms(AddressableLoader.GetGroup<UnlockData>("UnlockData"));
                var lcharm = AddressableLoader.GetGroup<UnlockData>("UnlockData").ToArray().Where(u => u.type == UnlockData.Type.Charm);
                var chall = ChallengeSystem.GetAllChallenges().ToArray();


                /*chall.ToArray().ToList().ForEach(Debug.LogWarning);
                pools.ForEach(Debug.LogWarning);*/
                

                /*var ccc = Resources.FindObjectsOfTypeAll<CampaignNodeTypeCharmShop>();
                Debug.LogError(ccc.Count);
                foreach (var cc in ccc)
                {
                    Debug.LogWarning(cc.priceRange.ToString());
                    Debug.LogWarning(cc.priceOffset);
                }*/
                foreach (var item in byTier)
                {
                    if (tier < 0 && item.Key >= 0)
                    {
                        result += "\n\n\n--Charms";
                        tier = item.Key;
                    }
                    var charmList = item.Where(c => c.type == CardUpgradeData.Type.Charm).ToList();
                    charmList.Sort((x, y) => x.title.CompareTo(y.title));
                    foreach (var charm in charmList)
                    {
                        var tribes = pools.Where(p => p.list.Contains(charm)).Select(t => t.name.Replace("CharmPool", "").Replace("Magic", "Shademancers").Replace("Clunk", "Clunkmasters").Replace("Basic", "Snowdwellers")).Distinct().ToList();
                        if (pools.Any(p => p.isGeneralPool && p.list.Contains(charm))) tribes.Add("All");
                        tribes.RemoveAll(s => s == "General");
                        if (!tribes.Any()) tribes.Add("Not obtainable as a reward");
                        result += $$"""
                        
                        cards["{{charm.title}}"] = {
                        	Name="{{charm.title}}",
                        	Types={{{(charm.tier < 0 ? "CursedCharm" : "Charm")}}=true},
                        	Desc="{{Wikify(charm.text)}}",
                        	Tier={{charm.tier}},

                        """;
                        if (charm.tier >= 0)
                        {
                            
                            var challenge = chall.FirstOrDefault(c => MetaprogressionSystem.GetLockedCharms(new Il2CppReferenceArray<UnlockData>([c.reward]).ToList()).Contains(charm.name));
                            Debug.LogWarning(challenge?.text);
                            //chall.ToArray().ToList().ForEach(Debug.LogWarning);
                            var unlock = challenge?.text ?? "''Unlocked by default''";
                            var unlockName = challenge?.titleKey.GetLocalizedString() ?? "";
                            //{{15 + charm.tier * 10}}-{{75 + charm.tier * 10}}
                            result += $$"""
                                	Tribes={"{{string.Join("\", \"", tribes)}}"},
                                	Unlock="{{unlockName}}",
                                	Challenge="{{unlock}}",
                                	Price={{45+charm.tier * 10}},

                                """;
                        }
                        result += "}";
                    }
                }
                Debug.Log(result);
            }

            public static void GetDaily()
            {
                var gen = Resources.FindObjectsOfTypeAll<DailyGenerator>().First();
                Debug.LogWarning("deck randomisers");
                gen.deckRandomizers.ToArray().ToList().ForEach(Debug.Log);
                Debug.LogWarning("good randomisers");
                gen.goodModifiers.ToArray().ToList().ForEach(Debug.Log);
                Debug.LogWarning("bad randomisers");
                gen.badModifiers.ToArray().ToList().ForEach(Debug.Log);
                Debug.LogWarning("neut randomisers");
                gen.neutralModifiers.ToArray().ToList().ForEach(Debug.Log);
            }

            public static void GetTLS()
            {
                var cards = AddressableLoader.GetGroup<CardData>("CardData");
                var charms = AddressableLoader.GetGroup<CardUpgradeData>("CardUpgradeData");
                foreach (var card in cards)
                {
                    if (!names.Contains(card.title)) continue;

                }
            }
            public static void GetOtherBellUpgrade()
            {
                var replacers = Resources.FindObjectsOfTypeAll<ScriptUpgradeSpecificEnemies>().First().profiles;
                foreach (var replacer in replacers)
                {
                    /*foreach (var card in replacer.cardDataNames)
                        Debug.LogError(card);*/
                    Debug.LogError(replacer.cardData.title);
                    foreach (var replaced in replacer.upgrades)
                        Debug.LogWarning(replaced.title);
                }
            }
            public static void GetTitan()
            {
                var replacers = Resources.FindObjectsOfTypeAll<ScriptUpgradeMinibosses>().First().profiles;
                foreach (var replacer in replacers)
                {
                    foreach (var card in replacer.cardDataNames)
                    Debug.LogError(card);
                    foreach (var replaced in replacer.possibleUpgrades)
                        Debug.LogWarning(replaced.title);
                }
            }

            public static void GetFGChanges()
            {
                var allCards = AddressableLoader.GetGroup<CardData>("CardData").ToArray().ToArray().ToList().Where(c => c.canPlayOnBoard).ToList();
                var allCharm = AddressableLoader.GetGroup<CardUpgradeData>("CardUpgradeData").ToArray().ToArray().ToList();
                allCharm.Sort((x, y) => x.title.CompareTo(y.title));
                allCards.Sort((x, y) => x.title.CompareTo(y.title));

                var gen = Resources.FindObjectsOfTypeAll<FinalBossGenerationSettings>().First();
                var res = "";
                foreach (var charm in allCharm) res += FGChangedCharm(charm, gen);
                foreach (var card in allCards) res += FGChangedCard(card, gen);
                Debug.LogWarning(res);
            }
            static string FGChangedCard(CardData card, FinalBossGenerationSettings gen)
            {
                var changes = new List<string>();



                if (card.title == "Leader") card.forceTitle = "Leader (" + Card.GetDescription(card) + ")";

                var res = "\n|-\n|{{CardArt|" + card.title + "}}\n|[[" + card.title + "|{{#invoke:Cards|GetStat|" + card.title + "|Name}}]]\n|";

                foreach (TraitData trait in gen.ignoreTraits)
                {
                    CardData.TraitStacks traitStacks = card.traits.ToArray().ToArray().FirstOrDefault<CardData.TraitStacks>((Func<CardData.TraitStacks, bool>)(a => a.data.name == trait.name));
                    if (traitStacks != null)
                    {
                        card.traits.Remove(traitStacks);
                        changes.Add("Removed {{Keyword|" + traitStacks.data.keyword.title + "}}");
                    }
                }
                for (int stackIndex = card.startWithEffects.Length - 1; stackIndex >= 0; --stackIndex)
                {
                    CardData.StatusEffectStacks startWithEffect = card.startWithEffects[stackIndex];
                    FinalBossEffectSwapper bossEffectSwapper;
                    if (startWithEffect.data && (bossEffectSwapper = gen.effectSwappers.ToArray().FirstOrDefault(s => s.effect.name == startWithEffect.data.name)))
                    {
                        string boosted = "";
                        if (bossEffectSwapper.boostRange.Min() == bossEffectSwapper.boostRange.Max()) boosted = (startWithEffect.count + bossEffectSwapper.boostRange.Random()).ToString();
                        else boosted = (startWithEffect.count + bossEffectSwapper.boostRange.Min()).ToString() + '-' + (startWithEffect.count + bossEffectSwapper.boostRange.Max()).ToString();
                        if (bossEffectSwapper.remove)
                        {
                            List<CardData.StatusEffectStacks> list = card.startWithEffects.ToArray().ToList();
                            if (bossEffectSwapper.replaceWithOptions.Length != 0)
                            {
                                bossEffectSwapper.replaceWithOptions = bossEffectSwapper.replaceWithOptions.With(bossEffectSwapper.replaceWithOptions.ToArray().First()).ToArray();
                                /*if (bossEffectSwapper.replaceWithOptions.Length > 1)
                                {
                                    List<string> ops = bossEffectSwapper.replaceWithOptions.ToArray().Select(s => '"' + Wikify(s.GetDesc(startWithEffect.count)) + '"').ToList();
                                    changes.Add("Changed effect from \"" + Wikify(startWithEffect.data.GetDesc(startWithEffect.count)) + "\" to one of " + string.Join(" OR ", ops));
                                }
                                else*/
                                    changes.Add("Changed effect from \"" +  Wikify(startWithEffect.data.GetDesc(startWithEffect.count)) + "\" to \"" + 
                                        Wikify(bossEffectSwapper.replaceWithOptions.First().GetDesc(1989).Replace("1989", boosted) + "\""));
                            }
                            else
                                changes.Add("Removed ability: \"" + Wikify(card.startWithEffects[stackIndex].data.GetDesc(card.startWithEffects[stackIndex].count)) + '"');
                            if (bossEffectSwapper.replaceWithAttackEffect)
                            {
                                changes.Add("Gain \"Apply '''" + boosted + "''' " + bossEffectSwapper.replaceWithAttackEffect.name + '"');
                            }
                        }
                        else
                        {
                            changes.Add("Boosted effect \"" + Wikify(startWithEffect.data.GetDesc(startWithEffect.count)) + "\" to " + boosted);
                        }
                        bossEffectSwapper.Process(card, startWithEffect, stackIndex);
                    }
                }

                FinalBossCardModifier bossCardModifier = gen.cardModifiers.ToArray().FirstOrDefault(a => a.card.name == card.name);
                if (bossCardModifier)
                {
                    foreach (var mod in bossCardModifier.runAll)
                    {
                        changes.Add(mod.name);
                        mod.Run(card);
                    }
                    
                }


                res += "\n|\n|\n|\n|" + Wikify(Card.GetDescription(card))    +"\n|" + string.Join("<br>", changes);
                if (changes.Count == 0) res = "";
                return res;
            }
            static string FGChangedCharm(CardUpgradeData charm, FinalBossGenerationSettings gen)
            {
                var changes = new List<string>();

                var res = "|-\n|{{CardArt|" + charm.title + "}}\n|[[" + charm.title + "|{{#invoke:Cards|GetStat|" + charm.title + "|Name}}]]\n|";

                foreach (TraitData trait in gen.ignoreTraits)
                {
                    CardData.TraitStacks traitStacks = charm.giveTraits.ToArray().FirstOrDefault<CardData.TraitStacks>((Func<CardData.TraitStacks, bool>)(a => a.data.name == trait.name));
                    if (traitStacks != null) changes.Add("Removed {{Keyword|" + traitStacks.data.keyword.title + "}}");
                }
                for (int stackIndex = charm.effects.Length - 1; stackIndex >= 0; --stackIndex)
                {
                    CardData.StatusEffectStacks startWithEffect = charm.effects[stackIndex];
                    FinalBossEffectSwapper bossEffectSwapper;
                    if (startWithEffect.data && (bossEffectSwapper = gen.effectSwappers.ToArray().FirstOrDefault(s => s.effect.name == startWithEffect.data.name)))
                    {
                        string boosted = "";
                        if (bossEffectSwapper.boostRange.Min() == bossEffectSwapper.boostRange.Max()) boosted = (startWithEffect.count + bossEffectSwapper.boostRange.Random()).ToString();
                        else boosted = (startWithEffect.count + bossEffectSwapper.boostRange.Min()).ToString() + '-' + (startWithEffect.count + bossEffectSwapper.boostRange.Max()).ToString();
                        if (bossEffectSwapper.remove)
                        {
                            List<CardData.StatusEffectStacks> list = charm.effects.ToArray().ToList();
                            if (bossEffectSwapper.replaceWithOptions.Length != 0)
                            {
                                if (bossEffectSwapper.replaceWithOptions.Length > 1)
                                {
                                    List<string> ops = bossEffectSwapper.replaceWithOptions.ToArray().Select(s => '"' + Wikify(s.GetDesc(startWithEffect.count)) + '"').ToList();
                                    changes.Add("Changed effect from \"" + Wikify(startWithEffect.data.GetDesc(startWithEffect.count)) + "\" to one of " + string.Join(" OR ", ops));
                                }
                                else
                                    changes.Add("Changed effect from \"" + Wikify(startWithEffect.data.GetDesc(startWithEffect.count)) + "\" to \"" +
                                        Wikify(bossEffectSwapper.replaceWithOptions.First().GetDesc(1989).Replace("1989", boosted) + "\""));
                            }
                            else
                                changes.Add("Removed ability: \"" + Wikify(charm.effects[stackIndex].data.GetDesc(charm.effects[stackIndex].count)) + '"');
                            if (bossEffectSwapper.replaceWithAttackEffect)
                            {
                                changes.Add("Removed ability: \"" + Wikify(charm.effects[stackIndex].data.GetDesc(charm.effects[stackIndex].count)) + "\" and gain '''" + boosted + "''' " + bossEffectSwapper.replaceWithAttackEffect.name);
                            }
                        }
                        else
                        {
                            changes.Add("Boosted effect \"" + Wikify(startWithEffect.data.GetDesc(startWithEffect.count)) + "\" to " + boosted);
                        }
                    }
                }

                FinalBossCardModifier bossCardModifier = gen.cardModifiers.ToArray().FirstOrDefault(a => a.card.name == charm.name);
                if (bossCardModifier)
                {
                    foreach (var mod in bossCardModifier.runAll)
                        changes.Add(mod.name);

                }

                res += "\n|\n|\n|\n|\n|" + string.Join("<br>", changes);
                if (changes.Count == 0) res = "";
                return res;
            }

            public static void GetFGSubs()
            {
                var replacers = Resources.FindObjectsOfTypeAll<FinalBossGenerationSettings>().First().enemyOptions;
                foreach (var replacer in replacers)
                {
                    Debug.LogError(replacer.enemy.title);
                    foreach (var replaced in replacer.fromCards)
                        Debug.LogWarning(replaced.title);
                }
            }

            public static void GetBattles()
            {
                var textures = new Dictionary<string, Texture2D>();
                var tnames = new List<string>();

                ExportCards exportCards = new();

                var allb = new Dictionary<string, Dictionary<string, List<string>>>();
                var pop = AddressableLoader.Get<GameMode>("GameMode", "GameModeNormal").populator;
                foreach (var battle in AddressableLoader.GetGroup<BattleData>("BattleData"))
                {
                    
                    if (battle != null && battle.sprite != null)
                    {
                        Debug.Log(battle.nameRef.GetLocalizedString());
                        battle.title = battle.nameRef.GetLocalizedString();

                        if (!new List<string>() { "The Bog Berries", "The Snow Lumps", "The Gunk Bugs", "The Ink Sacks" }.Contains(battle.title)) continue;

                        var result = battle.title;
                        var currentTiers = new List<CampaignPopulator.Tier>();
                        
                        result += ": " + currentTiers.Find((Predicate<CampaignPopulator.Tier>)(a => a.battles.Contains(battle))).number;
                        

                        /*allb[battle.title] = new Dictionary<string, List<string>>();
                        //yield return Routine(cardData);
                        if (!tnames.Contains(battle.sprite.texture.name))
                        {
                            textures[battle.sprite.texture.name] = battle.sprite.texture.MakeReadable();
                        }
                        var alle = new HashSet<string>();
                        string boss = "boss?";

                        var wavesT = "";

                        if (battle.bonusUnitPool.Any()) allb[battle.title]["Bonus Units"] = new List<string>();
                        foreach (var p in battle.bonusUnitPool) allb[battle.title]["Bonus Units"].Add(p.title);

                        foreach (var pool in battle.pools)
                        {
                            allb[battle.title][pool.name] = new();
                            foreach (var wave in pool.waves)
                            {
                                var thiswave = new List<string>();
                                foreach (var e in wave.units) {
                                    if (e.cardType.miniboss) boss = e.title;
                                    else alle.Add(e.title);
                                    thiswave.Add("[[" + e.title + "]]");
                                }
                                Debug.Log(boss);
                                allb[battle.title][pool.name].Add((wave.fixedOrder ? "'''" : "") + string.Join(", ", thiswave) + (wave.fixedOrder ? "'''" : "") + (wave.CanAddTo() && battle.bonusUnitPool.Count > 0 ? ", " + string.Join(", ", allb[battle.title]["Bonus Units"]) : ""));
                                //Debug.Log("aaddedd");
                            }
                        }


                        foreach (var pool in allb[battle.title])
                        {
                            wavesT += $"\n|rowspan = {pool.Value.Count}|{pool.Key}";
                            foreach (var wave in pool.Value)
                            {
                                wavesT += $"\n|{wave}\n|-";
                            }
                        }
                        wavesT += "\n|}\n\n\n<!--==Other Languages==-->\n\n{{NavboxMapEvents}}";

                        


                        var allelist = new List<string>();
                        foreach (var ss in alle) allelist.Add(ss);







                        *//*var texture = textures[battle.sprite.texture.name];
                        var pixels = texture.GetPixels((int)battle.sprite.textureRect.x,
                            (int)battle.sprite.textureRect.y,
                            (int)battle.sprite.textureRect.width,
                            (int)battle.sprite.textureRect.height);
                        // exportCards.camera.targetTexture = null; // the MainCamera's target texture has to be null
                        // exportCards.camera.cullingMask = -1; // this renders every layer
                        var s = new Texture2D((int)battle.sprite.textureRect.width, (int)battle.sprite.textureRect.height);
                        s.SetPixels(pixels);
                        s.Apply();
                        byte[] a = s.EncodeToPNG();
                        File.WriteAllBytes(Paths.PluginPath + "/" + exportCards.folder + "/" + "Charms" + "/" + battle.title + ".png", a);
*//*

                        var result = $$$"""
                            [[File:{{{battle.title.ReplaceWhiteSpaces("_")}}}.png|thumb|{{{battle.title}}}]]
                            '''{{{battle.title}}}''' is one of the possible fourth fights a player can run into. The fight is won when the [[Enemies#Minibosses|Miniboss]], [[{{{boss}}}]], is defeated.



                            ==Enemies==
                            {{#invoke:Cards|Table|{{{string.Join("|", allelist)}}}|{{{boss}}}|*
                            |Image|Name|Health|Attack|Counter|Other|Desc}}

                            ==Enemy Waves==
                            The encounter consists of three waves. These are all possible enemy spawns each wave.

                            {| class="wikitable" style="text-align:center;"
                            !Wave number
                            !Possible waves
                            |-
                            {{{wavesT}}}
                            """;*/

                        Debug.LogWarning(result);
                    }
                }
                    
            }

            public static void GetCharms()
            {
                var charms = AddressableLoader.GetGroup<CardUpgradeData>("CardUpgradeData");
                
                var result = "";
                var cn = new Dictionary<string, string>();
                var un = new List<string>();
                var ccc = ChallengeSystem.GetAllChallenges().ToList();

                foreach (var uuu in MetaprogressionSystem.GetRemainingUnlocks())
                    if (uuu.type == UnlockData.Type.Charm)
                    {
                        foreach (var cc in ccc)
                            if (cc.reward == uuu)
                                un.Add(cc.text ?? "Unlocked by default");
                    }
                    

                Debug.LogWarning("moving on" + un.Count + MetaprogressionSystem.GetLockedCharms(MetaprogressionSystem.GetRemainingUnlocks()).Count);
                for (var i = 0; i<Math.Min(11,un.Count); i++)
                {
                    Debug.Log(i);
                    cn[MetaprogressionSystem.GetLockedCharms(MetaprogressionSystem.GetRemainingUnlocks())[i]] = un[i];
                }
                cn["CardUpgradeBlue"] = "blok";

                var list = new Dictionary<string, RewardPool>();
                foreach (ClassData classData in AddressableLoader.GetGroup<ClassData>("ClassData"))
                    foreach (var r in (IEnumerable<RewardPool>)classData.rewardPools)
                        list[r.name] = r;

                //foreach (var charm in charms)
                foreach (var charm in charms)
                {
                    if (charm.title != "Frozen Heart Charm" && !cn.Keys.Contains(charm.name)) continue;
                    Debug.LogWarning(charm.name);

                    var te = "";
                    if (list["GeneralCharmPool"].list.Contains(charm)) te = "All";
                    else
                    {
                        var tes = new List<string>();
                        if (list["BasicCharmPool"].list.Contains(charm)) tes.Add("[[Tribes#Snowdwellers|Snowdwellers]]");
                        if (list["MagicCharmPool"].list.Contains(charm)) tes.Add("[[Tribes#Shademancers|Shademancers]]");
                        if (list["ClunkCharmPool"].list.Contains(charm)) tes.Add("[[Tribes#Clunkmasters|Clunkmasters]]");
                        te = string.Join("<br>", tes);
                    }



                    var s = $$$"""
                        |-
                        |{{CharmArt|{{{charm.title}}}}}
                        |[[{{{charm.title}}}]]
                        |{{{Wikify(charm.text)}}}
                        |{{{cn[charm.name]}}}
                        |{{{te}}}
                        """;
                    s += "\n";
                    result += s;
                }
                Debug.Log(result);
            }

            public static void GetWiki()
            {
                var cards = AddressableLoader.GetGroup<CardData>("CardData");
                var charms = AddressableLoader.GetGroup<CardUpgradeData>("CardUpgradeData");
                /*foreach (var card in cards.Where(c => c.IsPet()))
                {
                    GetLua(card, "en");
                }*/
                var result = "";
                //foreach (var charm in charms)
                foreach (var charm in cards)
                {
                    LocalizationSettings.Instance.SetSelectedLocale(LocalizationSettings.AvailableLocales.GetLocale("en"));
                    if (!names.Contains(charm.title)) continue;
                    //if (charm.mainSprite?.name == "Nothing" || charm.title.IsNullOrEmpty()) continue;
                    Debug.LogWarning(charm.name);
                    var s = '\n' + $$"""cards["{{(renames.ContainsKey(charm.name) ? renames[charm.name] : GetLua(charm, "en"))}}"] = {""";
                    Debug.Log(Card.GetDescription(charm));
                    
                    foreach (var loc in new string[] { "en", "zh-Hans", "zh-Hant", "ko", "ja" })
                    {
                        LocalizationSettings.Instance.SetSelectedLocale(LocalizationSettings.AvailableLocales.GetLocale(loc));


                        var desc = Wikify(Card.GetDescription(charm), loc);
                        if (desc.IsNullOrWhitespace())
                        {
                            Debug.LogError("OWO");
                            try { desc = "<i><span style=color:gray>" + Wikify(InLocale(charm.flavourKey, loc), loc) + "</span></i>"; }
                            catch { }
                        }
                        s += $$"""

                        	{{loc.Replace("-Han","")}} = {
                            	Name    = "{{GetLua(charm, loc)}}",
                                Name_rm = "",
                                Name_tl = "",
                                Desc    = "{{desc}}"
                                },
                        """
                                    //.Replace(" =", ":")
                                    .Replace("'", "")
                                    ;
                    }
                    /*,
                                    Desc_rm = "",
                                    Desc_tl = ""
                    */
                    s += "\n}";
                    result += s;
                }
                Debug.Log(result);
            }

            public static void GetLeaders()
            {
                var cards = AddressableLoader.GetGroup<CardData>("CardData");

                var tc = new TargetConstraintHasReaction();
                //foreach (var charm in charms)
                foreach (var loc in new string[] { "en", "zh-Hans", "zh-Hant", "ko", "ja" })
                {
                    string result = "\n\n==Tribes==\n";
                    LocalizationSettings.Instance.SetSelectedLocale(LocalizationSettings.AvailableLocales.GetLocale(loc));
                    foreach (var tribe in AddressableLoader.Get<GameMode>("GameMode","GameModeNormal").classes)
                    {
                        result += $$"""
                    ==={{tribe.name}}===
                    {|class="wikitable sortable" style="text-align:center;"
                    !Description
                    !{{Wikify("<keyword=health>", loc)}}
                    !{{Wikify("<keyword=attack>", loc)}}
                    !{{Wikify("<keyword=counter>", loc)}}
                    !Other
                    |-
                    """;
                        var leaders = new List<CardData>();
                        foreach (var le in tribe.leaders.ToList()) leaders.Add(le);
                        leaders.Sort((x, y) => x.name.CompareTo(y.name));
                        foreach (var card in leaders)
                        {
                            Debug.LogWarning(card.name);
                            string s = "";
                            CardScriptAddRandomBoost owa = null;
                            int? boost = card.createScripts.Any(s => (owa = s.TryCast<CardScriptAddRandomBoost>()) != null) ? owa.boostRange.Max() : null;
                            var desc = Card.GetDescription(card);
                            if (boost != null)
                            {
                                Debug.LogWarning(owa.boostRange.ToString());
                                Debug.LogWarning(boost);
                                Debug.Log("swe");
                                foreach (var ef in card.startWithEffects)
                                {
                                    if (ef.data.canBeBoosted)
                                    {
                                        desc = desc.Replace(ef.data.GetDesc(ef.count), ef.data.GetDesc(1984));
                                        desc = desc.Replace("1984", $"{ef.count}-{ef.count + boost}");
                                    }
                                }
                                Debug.Log("tr");
                                foreach (var ef in card.traits)
                                {
                                    if (ef.data.keyword.canStack)
                                    {
                                        desc = desc.Replace(Card.GetTraitText(ef.data, ef.count), Card.GetTraitText(ef.data, 1984));
                                        desc = desc.Replace("1984", $"{ef.count}-{ef.count + boost}");

                                    }
                                }
                                foreach (var ef in card.attackEffects)
                                {
                                    string ori = "";
                                    string mod = "";
                                    Texture2DExt.AddAttackEffectText(ref ori, new List<CardData.StatusEffectStacks>() { ef });
                                    string owo = ef.count.ToString();
                                    ef.count = 1984;
                                    Texture2DExt.AddAttackEffectText(ref mod, new List<CardData.StatusEffectStacks>() { ef });
                                    ef.count = int.Parse(owo);
                                    desc = desc.Replace(ori, mod);
                                    desc = desc.Replace("1984", $"{ef.count}-{ef.count + boost}");
                                }
                            }
                            desc = Wikify(desc.TrimStart('\n'), loc);
                            if (desc.IsNullOrWhitespace())
                            {
                                Debug.LogError("OWO");
                                try { desc = "<i><span style=color:gray>" + Wikify(InLocale(card.flavourKey, loc), loc) + "</span></i>"; }
                                catch { }
                            }
                            List<string> other = new();
                            var reaction = "<keyword=reaction>";
                            int n = 0;
                            if (card.startWithEffects.Any(effectStacks => effectStacks.data.isReaction))
                            {
                                n = 1;
                            }
                            foreach (var t in card.traits)
                            {
                                if (t.data.isReaction) n = 1;
                            }
                            //Debug.LogError("REACTION FOUND");
                            if (n == 1) other.Add(Wikify(reaction, loc));
                            foreach (var vis in card.startWithEffects.Where(s => s.data.visible))
                                other.Add(Wikify($"{(vis.data.keyword == "frenzy" ? "x" : "")}{vis.count + (vis.data.keyword == "frenzy" ? 1 : 0)} <keyword={vis.data.keyword}>", loc));
                            //Debug.Log(Wikify(reaction));
                            if (other.Count == 0) other.Add("");
                            string counter = (card.createScripts.Any(s => s.TryCast<CardScriptAddRandomCounter>() != null)
                                ? $"{card.counter}-{card.counter + card.createScripts.First(s => s.TryCast<CardScriptAddRandomCounter>() != null).Cast<CardScriptAddRandomCounter>().counterRange.Max()}"
                                : card.counter.ToString());
                            if (counter == "0") counter = "";
                            CardScriptAddRandomHealth h = null;
                            CardScriptAddRandomDamage d = null;
                            s += $$"""

                            |{{desc}}
                            |{{(card.createScripts.Any(s => s.TryCast<CardScriptAddRandomHealth>() != null)
                                ? $"{card.hp}-{card.hp + card.createScripts.First(s => s.TryCast<CardScriptAddRandomHealth>() != null).Cast<CardScriptAddRandomHealth>().healthRange.Max()}"
                                : card.hp)}}
                            |{{(card.createScripts.Any(s => s.TryCast<CardScriptAddRandomDamage>() != null)
                                ? $"{card.damage}-{card.damage + card.createScripts.First(s => s.TryCast<CardScriptAddRandomDamage>() != null).Cast<CardScriptAddRandomDamage>().damageRange.Max()}"
                                : card.damage)}}
                            |{{counter}}
                            |{{string.Join("<br>", other)}}
                            |-
                            """;
                            result += s;
                        }
                        result += "\n|}\n\n";
                    }
                    result += "{{NavboxCards}}";

                    Debug.Log(result);
                }
            }
        }

    }

    string s = """
        cards["Blunky"] = {
        	Name="Blunky",
        	Types={Companion=true, NonPetCompanion=true},
        	Health=1,
        	Attack=1,
        	Counter=2,
        	Desc="When deployed, gain '''1''' {{Stat|Block}}",
        	Tribes={"All"},
        }
        """;

    internal static APIGameObject _GameObject;
    public override void Load()
    {
        //CoroutineManager.Start(SceneManager.Load("Console", SceneType.Persistent));
        // Plugin startup logic
        _GameObject = AddComponent<APIGameObject>();
        Log.LogInfo($"Plugin is loaded!");
    }
    
}
public static partial class Texture2DExt
{
    public static Sprite ToSpriteFull(this Texture2D t) =>
        Sprite.Create(t, new Rect(0, 0, t.width, t.height), new Vector2(0.5f, 0.5f), 100, 0, SpriteMeshType.FullRect);
    public static Texture2D MakeReadable(this Texture2D texture)
    {
        return MakeReadable(texture, new Rect(0, 0, texture.width, texture.height));
    }
    public static Texture2D MakeReadable(this Texture2D texture, Rect cropRect)
    {
        return MakeReadable(texture, cropRect, Mathf.FloorToInt(cropRect.width), Mathf.FloorToInt(cropRect.height));
    }
    public static Texture2D MakeReadable(this Texture2D texture, Rect cropRect, bool squarePadding)
    {
        int length = Mathf.Max((int)cropRect.width, (int)cropRect.height);
        int dstWidth = squarePadding ? length : (int)cropRect.width;
        int dstHeight = squarePadding ? length : (int)cropRect.height;
        return MakeReadable(texture, cropRect, dstWidth, dstHeight);
    }
    public static Texture2D MakeReadable(this Texture2D texture, Rect cropRect, int dstWidth, int dstHeight)
    {
        // Create a transparent texture with the destination dimensions
        Texture2D texture2D = new(dstWidth, dstHeight, TextureFormat.RGBA32, mipChain: false);
        texture2D.SetPixels(System.Linq.Enumerable.Range(0, dstWidth * dstHeight).Select(_ => Color.clear).ToArray());

        // Allocate a temporary RenderTexture with the original image dimensions
        RenderTexture active = RenderTexture.active;
        RenderTexture temporary = RenderTexture.GetTemporary(texture.width, texture.height, 32);

        // Copy the original Texture onto the temporary RenderTexture set active
        Graphics.Blit(texture, temporary);
        RenderTexture.active = temporary;

        // Copy the cropped part
        texture2D.ReadPixels(new Rect(cropRect.x, temporary.height - cropRect.y - cropRect.height, cropRect.width, cropRect.height),
            //0, 0);
            //(dstWidth - (int)cropRect.width) / 2, 0);
            (dstWidth - (int)cropRect.width) / 2, (dstHeight - (int)cropRect.height) / 2);
        texture2D.Apply();
        RenderTexture.active = active;
        RenderTexture.ReleaseTemporary(temporary);
        return texture2D;
    }

    public static void SaveAsPNG(this Texture2D _texture, string _fullPath)
    {
        byte[] _bytes = _texture.EncodeToPNG();
        File.WriteAllBytes(_fullPath, _bytes);
        Debug.Log(_bytes.Length / 1024 + "Kb was saved as: " + _fullPath);
    }
    public static string ToTitleCase(this string str)
    {
        return string.Join(" ",
            str.Split(' ').Select(s =>
                s = s.Substring(0, 1).ToUpperInvariant() + s.Substring(1)
                )
            );
    }

    public static Il2CppReferenceArray<T> ToRefArray<T>(this T[] array) where T : Il2CppObjectBase
    {
        return array;
    }

    public static void AddAttackEffectText(
    ref string text,
    ICollection<CardData.StatusEffectStacks> attackEffects,
    bool silenced = false)
    {
        if (attackEffects.Count <= 0)
            return;
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        foreach (CardData.StatusEffectStacks attackEffect in (IEnumerable<CardData.StatusEffectStacks>)attackEffects)
        {
            string applyFormat = attackEffect.data.GetApplyFormat();
            if (!applyFormat.IsNullOrWhitespace() && !attackEffect.data.keyword.IsNullOrWhitespace())
            {
                if (dictionary.ContainsKey(applyFormat))
                    dictionary[applyFormat] += string.Format(", <{0}><keyword={1}>", attackEffect.count, attackEffect.data.keyword);
                else
                    dictionary[applyFormat] = string.Format("<{0}><keyword={1}>", attackEffect.count, attackEffect.data.keyword);
            }
            else if (!attackEffect.data.textKey.IsEmpty)
                dictionary.Add(attackEffect.data.GetDesc(attackEffect.count), "");
        }
        foreach (KeyValuePair<string, string> keyValuePair in dictionary)
        {
            if (!text.IsNullOrWhitespace())
                text += "\n";
            string str = keyValuePair.Key.Replace("{0}", keyValuePair.Value);
            text += silenced ? "<s>" + str + "</s>" : str;
        }
    }
}