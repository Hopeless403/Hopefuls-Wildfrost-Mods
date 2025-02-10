using Deadpan.Enums.Engine.Components.Modding;
using FMODUnity;
using HarmonyLib;
using MonoMod.Cil;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Diagnostics.CodeAnalysis;
using static System.ValueTuple;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Localization.Tables;
using UnityEngine.Localization;
using UnityEngine.UI;
using WildfrostHopeMod.DataHelpers;
using static CardData;
using static UnityEngine.Rendering.DebugUI;
using JetBrains.Annotations;
using System.Runtime.Remoting.Messaging;
//using MonoMod.Utils;

namespace WildfrostHopeMod.MapleFrost
{
    [HarmonyPatch(typeof(BuildingDisplay), nameof(BuildingDisplay.Create))]
    internal class Patch
    {
        
        static void Prefix(GameObject prefab)
        {
            Search(prefab.transform, "");
        }
        static void Search(Transform t, string path)
        {
            string newPath = Path.Combine(path, t.name);
            Debug.LogWarning(newPath);
            if (t.childCount == 0)
                return;
            t.GetAllChildren().Update(tt => Search(tt, newPath));
        }
    }

    //[HarmonyPatch(typeof(CardData), nameof(CardData.Clone), typeof(bool))]
    internal class PatchCD
    {
        static void Prefix(CardData __instance)
        {
            Debug.LogWarning("GOING TO CLONE " + __instance + ": " + __instance.ModAdded);
        }
        static void Postfix(CardData __result)
        {
            Debug.LogWarning("CLONED " + __result + ": " + __result.ModAdded);
        }
    }

    public partial class MapleFrostMod : WildfrostMod, IDataFile
    {
        public static MapleFrostMod instance;
        public MapleFrostMod(string modDirectory) : base(modDirectory)
        {
            instance = this;
        }
        public override string GUID => "hope.wildfrost.maplefrost";
        public override string[] Depends => new string[] { "hope.wildfrost.vfx" };
        public override string Title => "MapleFrost";
        public override string Description => $"Last update: {Directory.GetLastWriteTime(new Uri(GetType().Assembly.CodeBase).LocalPath)}";
        public override TMP_SpriteAsset SpriteAsset => base.SpriteAsset;
        public static GameObject behaviour;

        public new T Get<T>(string name) where T : DataFile
            => typeof(StatusEffectData).IsAssignableFrom(typeof(T)) ? base.Get<StatusEffectData>(name) as T : base.Get<T>(name);

        public static GameObject InitPrefab()
        {


            var prefab = AddressableLoader.Get("Event-Muncher");
            Debug.LogWarning("PREFAB FOUND? " + prefab);
            if (prefab)
                Search(prefab.transform, "");
            return prefab;
        }
        static void Search(Transform t, string path)
        {
            string newPath = Path.Combine(path, t.name);
            if (t.childCount == 0)
            {
                Debug.LogWarning(newPath);
                return;
            }
            t.GetAllChildren().Update(tt => Search(tt, newPath));
        }

        public static T CreateScriptable<T>(string name, Action<T> modification = null) where T : ScriptableObject
        {
            var data = ScriptableObject.CreateInstance<T>();
            data.name = name;
            modification?.Invoke(data);
            return data;
        }


        struct myStruct
        {
            public required string? name;

            [MemberNotNull(nameof(name))]
            public string? GetName()
            {
                return name;
            }
        }

        public class StatusEffectTransform : StatusEffectInstant
        {
            public StatusEffectSummon targetSummon;
            public CardData nextPhase;
            public CardData.StatusEffectStacks[] withEffects;

            public override IEnumerator Process()
            {

                return Remove();
            }
        }
        

        public GameObject CreateIcon(string name, string keyword)
        {
            GameObject Icon = new GameObject(name, typeof(RectTransform), typeof(Image), typeof(StatusIcon), typeof(CardPopUpTarget));//, typeof(CardHover));
            GameObject Text = new("Text", typeof(RectTransform), typeof(TextMeshProUGUI)); Text.transform.SetParent(Icon.transform);

            /// Not required
            //GameObject Fill = new("Fill", typeof(RectTransform), typeof(Image)); Fill.transform.SetParent(Icon.transform);
            //GameObject Outline = new("Outline", typeof(RectTransform), typeof(Image)); Outline.transform.SetParent(Icon.transform);
            //GameObject ActualText = new("ActualText", typeof(RectTransform), typeof(TextMeshProUGUI)); ActualText.transform.SetParent(Icon.transform);


            Icon.SetActive(false);
            GameObject.DontDestroyOnLoad(Icon);
            Icon.GetOrAdd<CardHover>().enabled = false;
            Icon.SetActive(true);

            /// Enabled in entityDisplay.SetStatusIcon()
            Icon.GetComponent<CardHover>().enabled = false;

            Icon.GetComponent<Image>().sprite = IconSprite;

            /// Only .keywords is required
            var popup = Icon.GetComponent<CardPopUpTarget>();
            popup.keywords = [Get<KeywordData>("explode")];

            var icon = Icon.GetComponent<StatusIcon>();
            icon.type = name;
            icon.textElement = Text.GetComponent<TMP_Text>();
            icon.textFormat = "{0}";
            icon.onCreate = icon.onDestroy = icon.afterUpdate = new();
            icon.onValueUp = icon.onValueDown = new();

            icon.onCreate.AddListener(icon.Ping);
            icon.onValueUp.AddListener((_,_) => icon.Ping());
            icon.onValueDown.AddListener((_, _) => icon.Ping());
            icon.onValueDown.AddListener(icon.CheckDestroy);

            icon.afterUpdate.AddListener(icon.SetText);

            /// Also not required
            //icon.fill = Fill.GetComponent<Image>();
            //icon.textElement = ActualText.GetComponent<TextMeshProUGUI>();

            icon.alterTextColours = false;

            CardManager.cardIcons[name] = Icon;
            return Icon;
        }

        private T TryGet<T>(string name) where T : DataFile
        {
            T data = default;
            if (data is StatusEffectData)
                data = base.Get<StatusEffectData>(name) as T;
            else if (data is KeywordData)
                data = base.Get<T>(name.ToLower());
            else
                data = base.Get<T>(name);

            if (data == null)
                throw new Exception($"TryGet Error: Could not find a [{typeof(T).Name}] with the name [{name}] or [{Extensions.PrefixGUID(name, this)}]");

            return data;
        }

        static Dictionary<string, List<object>> data = [];
        public override void Load()
        {
            static void formatter(Type type, string menuName, string fileName, ref Dictionary<string, List<object>> dic)
            {
                new StatusEffectApplyToSummon().target.forceKill = true;
                _ = typeof(TriggerBombard);
                Debug.Log((menuName, fileName, type));
                /*if (!menuName.Contains('/'))
                {
                    if (!dic.TryGetValue(menuName, out var list))
                        dic[menuName] = list = [];
                    list.Add((fileName, type.FullName));
                    return;
                }
                string parent = menuName.Split(['/'], 2)[0];
                string child = menuName.Split(['/'], 2)[1];
                Dictionary<string, List<object>> dic2 = [];
                if (!dic.TryGetValue(parent, out var dics))
                    dic[parent] = [dic2];

                formatter(type, child, fileName, ref dic2);*/
            }
            typeof(Card).Assembly.GetTypes()
                                 .Where(t => t.CustomAttributes.Any(a => a.AttributeType == typeof(CreateAssetMenuAttribute)))
                                 .SelectMany(type => type.GetCustomAttributes<CreateAssetMenuAttribute>().Select(att => (type, att)))
                                 .Update(pair => formatter(pair.type, pair.att.menuName, pair.att.fileName, ref data));

            Settings.Save("Assets", data);
            //Debug.Log(JsonUtility.ToJson(data, true));

            CreateIcon("lumin", "");
            /*List<TargetConstraint[]> targets = [];
            List<TargetConstraint[]> applies = [];

            string result = "";
            Func<TargetConstraint, string> format = t => $"{t.name}";// ({t.GetType().Name})";

            var list = AddressableLoader.GetGroup<CardUpgradeData>("CardUpgradeData");
            list.Sort((x, y) => x.title.CompareTo(y.title));
            
            foreach (var s in list)
            {
                Debug.LogWarning(s);
                //var s = Get<StatusEffectData>(st);
                var a = s.targetConstraints;
                //var b = (s as StatusEffectApplyX)?.applyConstraints ?? [];

                List<string> all = [];
                if (a.Any())
                    all.AddRange(a.Select(aa => format(aa)));
                *//*if (b.Any())
                    all.AddRange(b.Select(aa => format(aa)+"(a)"));*//*

                result +=  (all.Any() ? all.Join() : "") + '\n';
            }
            Debug.LogWarning(result);
*/



            _ = typeof(TargetingDisplay);

            //InitPrefab();
            Log("log");
            LogWarning("warning");
            LogError("error");



            string[] everyGeneration = ["w", "o"];
            everyGeneration = everyGeneration.Select(a => Extensions.PrefixGUID(a, this)).ToArray();

            Debug.LogError("DOES IT WORK?");
            foreach (var i in everyGeneration[0..2])
            {
                Debug.LogError(i);
            }

            new CardFramesUnlockedSequence().CreateCards([..from c in everyGeneration select Extensions.PrefixGUID(c, this)]);

            owo.Clear();
            //var cutscene = new GifCutscene(ImagePath("Denying Fate Screen2.gif"));
            //cutscene.Load();
            Debug.LogWarning("Loaded");
            //cutscene.Show();
            Debug.LogWarning("Showing");

            /*var APNG = new APNGLoader(Path.Combine(ModDirectory,"apng"), GIFLoader.PlayType.loopingAnimation, initialize:false);
            APNG.Initialize();
            APNG.RegisterAllAsApplyEffect();*/
            //var GIF = new GIFLoader(ModDirectory, GIFLoader.PlayType.loopingAnimation, false, true);
            //var cursor = GIF.LoadGIFFromPath("cursorapng");
            assets.Clear();
            CreateModAssets();
            base.Load();
            Debug.LogWarning(this.HarmonyInstance.GetPatchedMethods().Select(m => m.Name).DefaultIfEmpty("None").Join());

            /*
                        var array = Get<CardData>("Blue").startWithEffects;
                        var stack = array.First(s => s.data is StatusEffectApplyXWhenUnitLosesY);
                        (stack.data as StatusEffectApplyXWhenUnitLosesY).statusType = "scrap";

                        Debug.LogError((Get<CardData>("Blue").startWithEffects.First(s => s.data is StatusEffectApplyXWhenUnitLosesY).data as StatusEffectApplyXWhenUnitLosesY).statusType);
            */
            behaviour = new GameObject(Title, typeof(UINavigationItem));
            GameObject.DontDestroyOnLoad(behaviour);
            /*Transform parent = Resources.FindObjectsOfTypeAll<AvatarEyePositions>().FirstOrDefault(a => !a.gameObject.scene.IsValid()).transform;
            behaviour.transform.SetParent(parent);
            behaviour.hideFlags = HideFlags.HideAndDontSave;
            Debug.LogWarning(behaviour.transform.parent);
            Debug.LogWarning(behaviour.scene.name);*/

            var e = behaviour.AddComponent<MapleFrostModBehaviour>();
        }

        string names = """
Name
Activate Sacrifice Effects For Other Team
Add Attack & Health To Summon
Apply Haze & Double Attack
Apply Haze
Block
Bombard 1
Bombard 2
Bonus Damage Equal To Darts In Hand
Bonus Damage Equal To Gold Factor 0.02
Bonus Damage Equal To Highest Enemy Attack
Bonus Damage Equal To Juice
Bonus Damage Equal To Scrap On Board
Bonus Damage Equal To Scrap
Bonus Damage Equal To Shell
Bonus Damage Equal To Spice
Boost Effects
Budge
Cannot Increase Max Health
Cannot Recall
Check Has Juice
Cleanse
Combine When 2 Deployed
Copy Effects
Crush
Damage Equal To Health
Damage To Front Allies
Demonize
Destroy After Use
Destroy Self After Turn
Double All Spice When Destroyed
Double Attack
Double Block
Double Ink
Double Juice
Double Negative Effects
Double Overload
Double Shell
Double Shroom
Double Spice
Double Vim
Draw Cards
Eat (Health & Attack)
Eat (Health, Attack & Effects)
Eat Allies In Row (Health & Attack)
Eat Random Ally (Health, Attack & Effects)
Eat Summoned Allies
Eat Summoned
Escape
Fill Board (Final Boss)
FinalBossPhase2
Flee
Free Action (Zoomlin)
Free Action
FrenzyBossPhase2
Frost
Gain Frenzy When Wild Unit Killed
Gain Gold Range (3-6)
Gain Gold
GoatWampusPhase2
Halt Spice With Text
Halt Spice
Haze
Heal & Cleanse (No Ping)
Heal (No Ping)
Heal Front Ally Based On Damage Dealt
Heal Full, Gain Equal Spice
Heal To Front Allies
Heal
High Priority Position
Hit All Crown Enemies
Hit All Enemies In Row
Hit All Enemies
Hit All Inkd Enemies
Hit All Undamaged Enemies
Hit Furthest Target
Hit Random Target
ImmuneToFrost
ImmuneToSnow
ImmuneToSpice
ImmuneToVim
Increase All Spice Applied (No Desc)
Increase Attack & Health (No Constraints)
Increase Attack & Health
Increase Attack & Lose Half Health
Increase Attack Effects
Increase Attack While Alone
Increase Attack While Damaged
Increase Attack
Increase Effects
Increase Max Counter
Increase Max Health (Not Current)
Increase Max Health
Injury
Instant Add Scrap
Instant Apply Attack To Allies
Instant Apply Attack To Applier
Instant Apply Current Attack To Allies
Instant Apply Current Attack To Random Ally
Instant Apply Current Health To Applier
Instant Apply Frenzy (To Card In Hand)
Instant Apply Frenzy (To Item In Hand)
Instant Apply Teeth To Applier
Instant Destroy Junk In Hand And Draw For Each
Instant Draw
Instant Gain Aimless
Instant Gain Fury
Instant Gain Lumin
Instant Gain Noomlin (To Card In Hand)
Instant Gain Soulbound (To Ally)
Instant Gain Soulbound (To Enemy)
Instant Increase Attack To Allies & Summon BlackGoat
Instant Increase Attack To Applier
Instant Summon BlackGoat
Instant Summon Bloo
Instant Summon Bootleg Copy At Appliers Position
Instant Summon Copy At Appliers Position With X Health
Instant Summon Copy Of Item
Instant Summon Copy On Other Side With X Health
Instant Summon Copy With X Health and Attack
Instant Summon Copy
Instant Summon Dregg
Instant Summon Fallow
Instant Summon Gearhammer In Hand
Instant Summon Gunk In Hand
Instant Summon Junk In Hand
Instant Summon SkullMuffin In Hand
Instant Summon SunShard In Hand
Instant Summon TailsFour
Instant Summon TailsOne
Instant Summon TailsThree
Instant Summon TailsTwo
Kill & Increase Attack To Applier
Kill
Last Stand
Lose Half Health
Lose Juice
Lose Scrap
Lose Zoomlin
Low Priority Position
Lower Recycle Requirement
Lumin
MultiHit (Temporary, Not Visible)
MultiHit
Must Have Juice To Trigger
Null
On Card Played Add Fury To Target
On Card Played Add Gearhammer To Hand
On Card Played Add Gunk To Hand
On Card Played Add Junk To Hand
On Card Played Add Scrap To Allies
On Card Played Add Scrap To RandomAlly
On Card Played Add SkullMuffin To Hand
On Card Played Add Soulbound To RandomAlly
On Card Played Add Soulbound To RandomEnemy
On Card Played Add SunShard To Hand
On Card Played Add Zoomlin To Cards In Hand
On Card Played Add Zoomlin To Random Card In Hand
On Card Played Apply Attack To Self
On Card Played Apply Block To RandomAlly
On Card Played Apply Block To RandomEnemy
On Card Played Apply Block To RandomUnit
On Card Played Apply Block To Self
On Card Played Apply Frenzy To Self
On Card Played Apply Frost To RandomEnemy
On Card Played Apply Haze To RandomEnemy
On Card Played Apply Ink To RandomEnemy
On Card Played Apply Overload To FrontEnemy
On Card Played Apply Shell To Allies
On Card Played Apply Shell To RandomAlly
On Card Played Apply Shroom To Enemies
On Card Played Apply Shroom To RandomEnemy
On Card Played Apply Snow To EnemiesInRow
On Card Played Apply Spice To Allies
On Card Played Apply Spice To RandomAlly
On Card Played Apply Teeth To AlliesInRow
On Card Played Apply Teeth To RandomAlly
On Card Played Boost To Allies & Enemies
On Card Played Boost To RandomAlly
On Card Played Boost To RandomEnemy
On Card Played Damage Frosted Enemies
On Card Played Damage Inked Enemies
On Card Played Damage To Self & AlliesInRow
On Card Played Damage To Self
On Card Played Damage Undamaged Enemies
On Card Played Destroy All Junk In Hand And Draw For Each
On Card Played Destroy Random Card In Hand
On Card Played Destroy Random Junk In Hand
On Card Played Destroy Rightmost Card In Hand
On Card Played Double Vim To Self
On Card Played Heal & Cleanse To Allies
On Card Played Lose 1 Juice To Self (No Desc)
On Card Played Lose Health
On Card Played Lose Scrap To Self
On Card Played Lose Zoomlin
On Card Played Reduce Attack Effect 1 To Self
On Card Played Reduce Counter To Allies
On Card Played Sacrifice RandomAlly
On Card Played Take Health From Allies
On Card Played Trigger Against AllyBehind
On Card Played Trigger Against AllyInFrontOf
On Card Played Trigger RandomAlly
On Card Played Use Random Item In Hand Against Random Enemy
On Card Played Vim To Allies
On Card Played Vim To Self
On Card Played Void To Enemies
On Hit Damage Damaged Target
On Hit Damage Frosted Target
On Hit Damage Inked Target
On Hit Damage Shelled Target
On Hit Damage Snowed Target
On Hit Equal Damage To Inked Target
On Hit Equal Heal To FrontAlly
On Hit Equal Overload To Target
On Hit Equal Snow To Target
On Hit Pull Target
On Hit Push Target
On Kill Apply Attack To Self
On Kill Apply Block To Self
On Kill Apply Gold To Self
On Kill Apply Scrap To Allies
On Kill Apply Scrap To AllyBehind
On Kill Apply Scrap To RandomAlly
On Kill Apply Shell To Self
On Kill Apply Spice To Self
On Kill Apply Stealth To Self
On Kill Apply Teeth To Self
On Kill Apply Vim To AllyBehind
On Kill Apply Vim To RandomAlly
On Kill Apply Vim To RandomEnemy
On Kill Count As Sacrifice For Other Team
On Kill Draw
On Kill Heal To Self & AlliesInRow
On Kill Heal To Self
On Kill Increase Health To Self & Allies
On Turn Add Attack To Allies
On Turn Add Health & Attack To Allies
On Turn Add Health & Attack To Summoned Allies
On Turn Apply Attack To Self
On Turn Apply Demonize To Enemies
On Turn Apply Demonize To RandomEnemy
On Turn Apply Ink To Enemies
On Turn Apply Ink To RandomEnemy
On Turn Apply Juice To AllyBehind
On Turn Apply Overload To Enemies
On Turn Apply Overload To RandomEnemy
On Turn Apply Scrap To AllyAhead
On Turn Apply Scrap To AllyBehind
On Turn Apply Scrap To RandomAlly
On Turn Apply Scrap To Self
On Turn Apply Shell To Allies
On Turn Apply Shell To AllyBehind
On Turn Apply Shell To AllyInFrontOf
On Turn Apply Shell To Self
On Turn Apply Snow To Enemies
On Turn Apply Spice To Allies
On Turn Apply Spice To AllyBehind
On Turn Apply Spice To AllyInFrontOf
On Turn Apply Spice To Self
On Turn Apply Teeth To Allies
On Turn Apply Teeth To Self
On Turn Apply Vim To AllyBehind
On Turn Apply Vim To RandomAlly
On Turn Apply Void To Everyone
On Turn Apply Void To RandomEnemy
On Turn Drop Gold
On Turn Eat Random Ally (Health, Attack & Effects)
On Turn Escape To Self
On Turn Heal & Cleanse Allies
On Turn Heal Allies
On Turn Kill Summoned Allies
On Turn Sacrifice Self and Summon BlackGoat
On Turn Summon Bootleg Copy of RandomEnemy
Ongoing Increase Attack
Ongoing Increase Effect Factor
Ongoing Increase Effects
Ongoing Reduce Attack
Ongoing Reduce Effects
Overload
Pre Trigger Copy Effects Of RandomAlly
Pre Trigger Gain Frenzy Equal To Cards In Hand
Pre Trigger Gain Frenzy Equal To Scrap
Pre Trigger Gain Temp MultiHit Equal To Juice - 1
Pre Trigger Gain Temp MultiHit Equal To Scrap - 1
Pre Turn Destroy All Items In Hand & Gain Attack For Each
Pre Turn Destroy All Items In Hand
Pre Turn Destroy Random Card In Hand
Pre Turn Eat Allies In Row (Health & Attack)
Pre Turn Eat Random Ally (Health, Attack & Effects)
Pre Turn Gain Attack For Each Ally
Pre Turn Gain Attack For Each Item In Hand (For Each Card Destroyed)
Pre Turn Gain Temp MultiHit Equal To Juice
Pre Turn Kill Summoned Allies & Gain Attack For Each
Pre Turn Take Attack From Enemies
Pre Turn Take Gold
Pre Turn Take Juice From RandomAlly
Pre Turn Take Scrap From RandomAlly
Pull
Push
Randomize Stats (2-5)
Recycle Junk
Redraw Cards
Reduce Attack Effect 1
Reduce Attack
Reduce Counter
Reduce Effects
Reduce Max Counter
Reduce Max Health (Must be ally)
Reduce Max Health
Remove Effects
ResistShroom
ResistSnow
ResistSpice
Sacrifice Ally & Increase Attack To Applier
Sacrifice Ally & Summon BlackGoat
Sacrifice Ally
Sacrifice Card In Hand
Sacrifice Enemy
Scrap
Set Attack
Set Health
Set Max Health
Shell
Shroom
Snow
SoulboundBossPhase2
Spice
Split
SplitBossPhase2
Stealth
Summon Beepop
Summon Bloo
Summon BoBo
Summon Bonzo
Summon Dregg
Summon Enemy Leech
Summon Enemy Pigeon
Summon Enemy Popper
Summon Fallow
Summon Gearhammer
Summon Gunk
Summon Item
Summon Junk
Summon Plep
Summon SkullMuffin
Summon Snuffer
Summon SunShard
Summon TailsFive
Summon TailsFour
Summon TailsOne
Summon TailsThree
Summon TailsTwo
Summon Tigris
Summon Uzu
Summoned
Take 100 Damage When Soulbound Unit Killed
Take 100 Damage When Soulbound Unit Sacrificed
Take Attack
Take Gold
Take Health
Teeth
Temporary Aimless
Temporary Barrage
Temporary Consume
Temporary Fury
Temporary Noomlin
Temporary Pigheaded
Temporary Soulbound
Temporary Summoned
Temporary Unmovable
Temporary Zoomlin
Trigger (High Prio)
Trigger Against & Reduce Uses
Trigger Against (Don't Count As Trigger)
Trigger Against Ally When Ally Is Hit
Trigger Against Attacker When Hit
Trigger Against Crown Allies When Discarded
Trigger Against Crown Allies When Drawn
Trigger Against Random Ally When Discarded
Trigger Against Random Ally When Drawn
Trigger Against Random Enemy
Trigger Against Random Unit When Discarded
Trigger Against Random Unit When Drawn
Trigger Against When Ally Attacks
Trigger Against When Frost Applied
Trigger Against When Ink Applied
Trigger Against When Snow Applied
Trigger Against When Weakness Applied
Trigger Against
Trigger Applier When Block Lost
Trigger When Ally Attacks
Trigger When Ally In Row Attacks
Trigger When Ally Is Hit
Trigger When Ally or Enemy Is Killed
Trigger When Deployed
Trigger When Enemy Is Killed
Trigger When Junk Destroyed
Trigger When Redraw Hit
Trigger When Self Or Ally Loses Block
Trigger
Unmovable
Weakness
When Ally Is Healed Apply Double Shell
When Ally Is Healed Apply Double Spice
When Ally Is Healed Apply Equal Spice
When Ally Is Healed Trigger To Self
When Ally is Hit Apply Frost To Attacker
When Ally is Hit Apply Shroom To Attacker
When Ally is Hit Apply Teeth To Self
When Ally is Hit Apply Vim To Target
When Ally is Hit Heal To Target
When Ally is Hit Increase Health To Self
When Ally Is Killed Apply Attack To Self
When Ally Is Killed Gain Their Attack
When Ally Is Killed Lose Half Health & Gain Attack
When Ally Is Killed Trigger To Self
When Ally Is Sacrificed Apply Teeth To Self
When Ally Is Sacrificed Draw
When Ally Is Sacrificed Gain Their Attack
When Ally Is Sacrificed Summon Copy With X Health and Attack
When Ally Is Sacrificed Trigger To Self
When Ally or Self is Hit Apply Teeth To Self
When Anyone Takes Shroom Damage Apply Attack To Self
When Block Lost, Damage Enemies
When Built Add Junk To Hand
When Built Apply Vim To Self
When Card Destroyed, Gain Attack & Health
When Card Destroyed, Gain Attack
When Card Destroyed, Gain Frenzy
When Card Destroyed, Gain Juice
When Card Destroyed, Reduce Counter To Self
When Consumed Add Health To Allies
When Consumed Apply Overload To Enemies
When Deployed Add Junk To Hand
When Deployed Apply Block To Self
When Deployed Apply Demonize To Enemies
When Deployed Apply Frenzy To Self
When Deployed Apply Ink To Allies
When Deployed Apply Ink To EnemiesInRow
When Deployed Apply Teeth To Self
When Deployed Copy Effects Of RandomEnemy
When Deployed Copy Effects Of RandomEnemyInRow
When Deployed Fill Board (Final Boss)
When Deployed Lose Zoomlin
When Deployed Summon Copy of Enemies With X Health
When Deployed Summon Copy of RandomEnemy With X Health
When Deployed Summon Wowee
When Destroyed Add Health To Allies
When Destroyed Apply Damage To Allies
When Destroyed Apply Damage To AlliesInRow
When Destroyed Apply Damage To Attacker
When Destroyed Apply Damage To Enemies Equal To Juice
When Destroyed Apply Damage To EnemiesInRow
When Destroyed Apply Frenzy To RandomAlly
When Destroyed Apply Haze & Double Attack To Attacker
When Destroyed Apply Haze To Attacker
When Destroyed Apply Ink To Allies & Enemies
When Destroyed Apply Ink To Allies
When Destroyed Apply Ink To RandomEnemy
When Destroyed Apply Overload To Attacker
When Destroyed Apply Shell To Allies
When Destroyed Apply Spice To Allies
When Destroyed Apply Stealth To AlliesInRow
When Destroyed Summon Dregg
When Destroyed Trigger To Allies
When Drawn Apply Snow To Allies
When Drawn Gain Zoomlin
When Enemies Attack Apply Demonize To Attacker
When Enemy (Shroomed) Is Killed Apply Their Shroom To RandomEnemy
When Enemy Deployed Copy Effects Of Target
When Enemy Deployed Gain Their Health
When Enemy Deployed Ink To Target & Self
When Enemy Deployed Ink To Target
When Enemy Deployed Summon Bootleg Copy Of Target
When Enemy Deployed Take Half Their Health
When Enemy Is Hit By Item Apply Demonize To Them
When Enemy Is Killed Apply Gold To Self
When Enemy Is Killed Apply Shell To Attacker
When Enemy Is Killed Apply Spice To Attacker
When Healed Apply Attack To Self
When Healed Gain Max Health
When Healed Trigger To Self
When Health Lost Apply Equal Attack To Self And Allies
When Health Lost Apply Equal Frost To Self
When Health Lost Apply Equal Shell To Self
When Health Lost Apply Equal Spice To Self
When Hit Add Attack To Ally With Lowest Attack
When Hit Add Attack To Self Or RandomAlly With Highest Attack
When Hit Add Attack To Self Or RandomAlly With Lowest Attack
When Hit Add Frenzy To Self
When Hit Add Gearhammer To Hand
When Hit Add Gunk To Hand
When Hit Add Health Lost To Attacker
When Hit Add Health Lost To RandomAlly
When Hit Add Junk To Hand
When Hit Apply Block To RandomAlly
When Hit Apply Demonize To Attacker
When Hit Apply Frost To Enemies
When Hit Apply Frost To RandomEnemy
When Hit Apply Gold To Attacker (No Ping)
When Hit Apply Ink To Attacker
When Hit Apply Ink To RandomEnemy
When Hit Apply Ink To Self
When Hit Apply Overload To Attacker
When Hit Apply Shell To Allies & Enemies & Self
When Hit Apply Shell To Allies
When Hit Apply Shell To AlliesInRow
When Hit Apply Shell To AllyBehind
When Hit Apply Shell To Self
When Hit Apply Shroom To Attacker
When Hit Apply Shroom To RandomEnemy
When Hit Apply Snow To Attacker
When Hit Apply Snow To Enemies
When Hit Apply Snow To RandomEnemy
When Hit Apply Spice To Allies & Enemies & Self
When Hit Apply Spice To Allies
When Hit Apply Spice To AlliesInRow
When Hit Apply Spice To AllyBehind
When Hit Apply Spice To Self
When Hit Apply Stealth To Self
When Hit Apply Vim To Self
When Hit Apply Void To Attacker
When Hit Apply Weakness To Attacker
When Hit Boost Allies & Enemies
When Hit Boost RandomAlly & RandomEnemy
When Hit Boost RandomUnit
When Hit Damage To Enemies
When Hit Damage To EnemiesInRow
When Hit Draw
When Hit Equal Damage To Attacker
When Hit Gain Attack To Self (No Ping)
When Hit Gain Teeth To Self
When Hit Heal Self
When Hit Increase Attack Effects To Self
When Hit Increase Attack To RandomAlly
When Hit Increase Health To RandomAlly
When Hit Reduce Attack To Attacker
When Hit Reduce Attack To Self
When Hit Reduce Counter To Self
When Hit Trigger To Self
When Hit With Junk Add Frenzy To Self
When Juice Applied To Self Gain Frenzy
When Redraw Hit Apply Attack & Health To Self
When Sacrificed Increase Attack To Allies And Summon BlackGoat

When Sacrificed Summon TailsOne
When Sacrificed Summon TailsThree
When Sacrificed Summon TailsTwo
When Shell Applied To Self Gain Spice Instead
When Shell X Applied To Self Trigger To Self
When Shroom Applied To Anything Double Amount And Lose Scrap
When Shroom Damage Taken Trigger To Self
When Snow Applied To Anything Gain Attack To Self
When Snow Applied To Anything Gain Equal Attack To Self
When Snow Applied To Self Apply Demonize To Enemies
When Snow Applied To Self Gain Equal Attack
When Spice Or Shell Applied To Self Shroom To RandomEnemy
When Spice X Applied To Self Trigger To Self
When Vim Applied To Anything Double Amount
When X Health Lost Split
While Active Add Equal Attack To Junk In Hand
While Active Aimless To Enemies
While Active Barrage To Allies
While Active Barrage To AlliesInRow
While Active Barrage To Enemies
While Active Consume To Items In Hand
While Active Frenzy To Allies
While Active Frenzy To AlliesInRow
While Active Frenzy To Clunker Allies
While Active Frenzy To Crown Allies
While Active Frenzy To Crown AlliesInRow
While Active Frenzy To Uncrowned Allies
While Active Halt Spice To Allies
While Active Increase All Spice Applied
While Active Increase Attack by Current To Allies
While Active Increase Attack by Current To Summoned Allies
While Active Increase Attack To Allies & Enemies
While Active Increase Attack To Allies (No Desc)
While Active Increase Attack To Allies
While Active Increase Attack To AlliesInRow
While Active Increase Attack To Inked Allies & Enemies
While Active Increase Attack To Items In Hand
While Active Increase Attack To Junk In Hand
While Active Increase Effects To Allies & Enemies
While Active Increase Effects To FrontAlly
While Active Increase Effects To Hand
While Active Lower Recycle Requirement To Self & Allies & Enemies & Hand
While Active Pigheaded To Enemies
While Active Reduce Attack To Enemies (No Ping, No Desc)
While Active Reduce Effects To Hand
While Active Snow Immune To Allies
While Active Teeth To Allies
While Active Trigger Applier When Block Lost To Allies & Self
While Active Unmovable To Enemies
While Active Zoomlin When Drawn To Allies In Hand
While In Hand Reduce Attack To Allies
While Last In Hand Double Effects To Self
""";


        [HarmonyPatch(typeof(FinalBossGenerationSettings), nameof(FinalBossGenerationSettings.GenerateBonusEnemies))]
        class PatchFG
        {
            public static void Prefix(ref FinalBossEnemyGenerator[] ___enemyOptions)
            {
                var allItems = AddressableLoader.GetGroup<CardData>("CardData").Where(c => c.cardType.name == "Item");

                foreach (var card in AddressableLoader.GetGroup<CardData>("CardData"))
                {
                    if (card.cardType.name != "Item")
                        continue;
                    var generator = ScriptableObject.CreateInstance<FinalBossEnemyGenerator>();
                }
            }
        }
        [HarmonyPatch(typeof(LocalizationHelper), "GetCollection")]
        class Patch
        {
            [HarmonyPrefix]
            public static bool GetCollection(ref StringTable __result, string name, LocaleIdentifier identifier)
            {
                string code = "";
                switch (identifier.Code)
                {
                    case "zh-hans": code = "zh-Hans"; break;
                    case "zh-hant": code = "zh-Hant"; break;
                    default: code = identifier.Code; break;
                }
                string text = name + "_" + code;
                __result = Addressables.LoadAssetAsync<StringTable>(text).WaitForCompletion();
                return !__result;
            }
        }

        public Action<float> onUpdate;


        public class StatusEffectWhileActiveXAndRefresh : StatusEffectWhileActiveX
        {
            public override void Init()
            {
                base.Init();
                Events.OnEntityMove += Refresh;
                Events.OnEntityDestroyed += Refresh;
            }
            public override void OnDestroy()
            {
                base.OnDestroy();
                Events.OnEntityMove -= Refresh;
                Events.OnEntityDestroyed -= Refresh;
            }
            public void Refresh(Entity entity) => Refresh();
            public void Refresh() => ActionQueue.Add(new ActionRefreshWhileActiveEffect(this));
        }


        public static T Create<T>(string name, Action<T> action) where T : StatusEffectData
        {
            new StatusEffectDataBuilder().SubscribeToAfterAllBuildEvent(d => action.Invoke(d as T));
            return ScriptableObject.CreateInstance<T>();
        }

        public void Log(object message) => Debug.Log($"[{Title}] {message}");
        public void LogWarning(object message) => Debug.LogWarning($"[{Title} Warning] {message}");
        public void LogError(object message) => Debug.LogError($"[{Title} Error] {message}");

        public static readonly List<(UnlockData unlock, DataFile data, object sequenceActionOnStart)> owo = new();
        private void CreateModAssets(bool forRelease = true)
        {
            Debug.LogError(Get<StatusEffectApplyXInstant>("Instant Gain Aimless"));
            (Get<StatusEffectApplyXInstant>("Instant Gain Aimless").effectToApply as StatusEffectTemporaryTrait).trait = Get<TraitData>("Explode");
            Debug.LogError((Get<StatusEffectApplyXInstant>("Instant Gain Aimless").effectToApply as StatusEffectTemporaryTrait).trait);
            

            this.HarmonyInstance.PatchAll();
            Debug.LogWarning(this.HarmonyInstance.GetPatchedMethods().Select(m => m.Name).DefaultIfEmpty("None").Join());
            this.HarmonyInstance.PatchAll();
            Debug.LogWarning(this.HarmonyInstance.GetPatchedMethods().Select(m => m.Name).DefaultIfEmpty("None").Join());

            ChallengeListener listener = new()
            {
                name = "Take 100 Summoned Damage",
                checkType = ChallengeListener.CheckType.MidRun,
                //systemName = "", // used if checkType == CustomSystem
                stat = "damageDealt",
                hasKey = true,
                key = "summoned",
                target = 100,
                ModAdded = this
            };

            //Addressables.InitializeAsync();


            assets.AddRange([
                new StatusEffectDataBuilder(this).Create<StatusEffectInstantSummon>("Instant Summon Junjun with +X Health")
                .WithText("Summon Junjun with <+{a}><keyword=health>")
                .SubscribeToAfterAllBuildEvent(d => {
                    var data = d as StatusEffectInstantSummon;
                    data.summonCopy = false;
                    data.targetSummon = Get<StatusEffectData>("Summon Plep") as StatusEffectSummon;
                    data.withEffects = [
                        Get<StatusEffectData>("Increase Max Health")
                        ];
                })
                ,
                /*new StatusEffectDataBuilder(this).Create<StatusEffectInstantSetHealth>("Set Health Equal To Applier's +1")
                .WithText("Summon a copy of the target with <+{a}><keyword=health>")
                .SubscribeToAfterAllBuildEvent(d => {
                    var data = d as StatusEffectInstantSummon;
                    data.summonCopy = true;
                    data.withEffects = [];
                })
                ,*/
                new StatusEffectDataBuilder(this).Create<StatusEffectInstantMultiple>("Instant Summon Copy And Kill")
                .WithText("Summon a copy of the target with <+{a}><keyword=health> and kill them")
                .SubscribeToAfterAllBuildEvent(d => {
                    var data = d as StatusEffectInstantMultiple;
                    data.effects = [
                        Get<StatusEffectData>("Instant Summon Junjun with +X Health") as StatusEffectInstantSummon,
                        Get<StatusEffectData>("Kill") as StatusEffectInstantKill
                        ];
                })
                ,

                new StatusEffectDataBuilder(this).Create<StatusEffectApplyXInstant>("Instant Summon Junjun With +X Health Equal To Current Health")
                .WithText("Summon JunJun with additional <keyword=health> equal to the summoner")
                .WithStackable(true)
                .WithCanBeBoosted(true)
                .SubscribeToAfterAllBuildEvent(d => {
                    var data = d as StatusEffectApplyXInstant;
                    data.effectToApply = Get<StatusEffectData>("Instant Summon Junjun with +X Health") as StatusEffectInstantSummon;
                    data.applyToFlags = StatusEffectApplyX.ApplyToFlags.Self;
                    data.scriptableAmount = CreateScriptable<ScriptableCurrentHealth>("Current Health (Not Max)", null);
                })
                ,

                


                new StatusEffectDataBuilder(this).Create<StatusEffectInstantProcessTrigger>("Instant Process Trigger")
                .WithText("Instantly trigger the target")
                ,

                new StatusEffectDataBuilder(this).Create<StatusEffectApplyXWhenEnemiesAttack>("Trigger Self When Enemies Attack")
                .WithText("Trigger when enemies attack")
                .WithIsReaction(true)
                .SubscribeToAfterAllBuildEvent(d => {
                    var data = d as StatusEffectApplyXWhenEnemiesAttack;
                    data.effectToApply = Get<StatusEffectData>("Instant Process Trigger");
                    data.applyToFlags = StatusEffectApplyX.ApplyToFlags.Self;
                    data.doPing = true;
                })
                ,


                new StatusEffectDataBuilder(this).Create<StatusEffectInstantReduceStacks>("Instant Reduce Stacks")
                .WithText("Reduce stacks of <\"When Hit Summon\"> by <{a}>")
                .SubscribeToAfterAllBuildEvent(d => {
                    var data = d as StatusEffectInstantReduceStacks;
                    data.statusName = Get<StatusEffectData>("When Hit Summon").name;
                    // Redundant Get, used to validate this status name exists
                    // (if not, causes null ref)
                })
                ,
                new StatusEffectDataBuilder(this).Create<StatusEffectApplyXAfterTurn>("After Turn Taken, Reduce \"When Hit Summon\" By 1")
                .WithText("Reduce stacks of <\"When Hit Summon\"> by <{a}>")
                .WithCanBeBoosted(true)
                .WithStackable(true)
                .SubscribeToAfterAllBuildEvent(d => {
                    var data = d as StatusEffectApplyXAfterTurn;
                    //data.trueOnTurn = true;
                    data.effectToApply = Get<StatusEffectData>("Instant Reduce Stacks");
                    data.applyToFlags = StatusEffectApplyX.ApplyToFlags.Self;
                    data.doPing = true;
                })
                ,

                new StatusEffectDataBuilder(this).Create<StatusEffectApplyXWhenHit>("When Hit Summon")
                .WithText("When hit summon")
                .SubscribeToAfterAllBuildEvent(d => {
                    var data = d as StatusEffectApplyXWhenHit;
                    data.effectToApply = Get<StatusEffectData>("Instant Summon Copy");
                    data.applyToFlags = StatusEffectApplyX.ApplyToFlags.Self;
                    data.attackerConstraints = [
                        CreateScriptable<TargetConstraintIsSpecificCard>("Is Junk",
                            a => a.allowedCards = [Get<CardData>("Junk")]
                            )
                        ];
                })
                ,

                new UnlockDataBuilder(this)
                .Create("Hope 1")
                .WithType(UnlockData.Type.Charm)
                //.WithBuilding(null as string) // determines the text and unlocked display
                .WithLowPriority(1.5f)
                .WithRequires(new string[0])
                .WithUnlockTitle("New reward unlocked! (unlock popup)")
                .WithUnlockDescription(LocalizationHelper.GetCollection("UI Text", new(SystemLanguage.English)).GetString("unlock_charm_desc"))
                .SubscribeToBuildEvent(Debug.LogWarning)
                .SubscribeToAfterAllBuildEvent(data => {
                    Debug.Log("Data exists? " + Get<UnlockData>(data.name));
                })
                ,


                new StatusEffectDataBuilder(this).Create<StatusEffectInstantSplashDamage>("Instant Splash")
                .WithCanBeBoosted(true)
                .WithText("Deal <{a}> splash damage")
                .WithType(""),

                new ChallengeDataBuilder(this)
                .Create("Challenge Hope 1")
                .WithTitle("Eight")
                .WithText("Take damage via <keyword=summoned> 100 times")
                .WithRewardText("New reward unlocked!")
                .WithGoal(100)
                .WithListener(listener)
                .WithIcon(IconSprite)
                .WithRequires(new string[0])
                .WithReward(AddressableLoader.GetGroup<UnlockData>("UnlockData").First(u => u.type == UnlockData.Type.Charm))
                .SubscribeToAfterAllBuildEvent(data => {data = data.WithReward(Get<UnlockData>("Hope 1")); })
                .SubscribeToBuildEvent(Debug.LogWarning)
                ,

                new CardUpgradeDataBuilder(this)
                .Create("default")
                .WithTier(2)
                .WithTitle("Default Charm")
                .WithText("Default Text")
                .WithImage(IconSprite)
                .WithType(CardUpgradeData.Type.Charm)
                .SetAttackEffects([])
                .SetEffects([])
                .SetTraits([])
                .SetScripts([])
                .SetConstraints([])
                .SubscribeToAfterAllBuildEvent(data => {
                    ChallengeData challenge = Get<ChallengeData>("Challenge Hope 1");
                    if (!challenge.reward)
                        challenge.reward = Get<UnlockData>("Hope 1");
                    Debug.Log(challenge);
                    data.AddToCharms(challenge.reward); // add to metaprogression charms
                    GameObject.FindObjectOfType<ChallengeSystem>()?.saveRequired.Add(challenge);
                    GameObject.FindObjectOfType<ChallengeSystem>()?.CheckSave();
                    Debug.LogWarning(GameObject.FindObjectOfType<ChallengeSystem>());
                    GameObject.FindObjectOfType<ChallengeSystem>()?.saveRequired.ForEach(Debug.LogWarning);
                    Debug.Log(challenge.reward);

                    var action = new MonoMod.Cil.RuntimeILReferenceBag.FastDelegateInvokers.Action<ChallengeShrineSequence>(seq => {
                        var layout = seq.transform.Find("Scroller/Challenge Stones").gameObject.GetOrAdd<HorizontalLayoutGroup>();
                        //layout.spacing = 3.5f;
                        layout.childAlignment = TextAnchor.UpperLeft;
                        layout.childControlHeight = false;
                        layout.childControlWidth = false;
                        layout.childForceExpandHeight = false;
                        layout.childForceExpandWidth = false;

                        Debug.LogWarning($"[{Title}]\n Unlocked {data
                            }\n via the challenge {challenge
                            }\n with listener {challenge.listener
                            }\n and rewawrd {challenge.reward}");/*
                        Debug.LogWarning(seq.challengeStones);
                        seq.challengeStones = seq.challengeStones.Subset(0,1);
                        seq.challengeStones?.Update(Debug.Log);*/
                        Debug.LogWarning(seq.challengeStones?.Length);
                        //seq.OnEnable();
                    });

                    owo.Add((challenge.reward, data, action));
                    BuildingSequenceWithUnlocks<ChallengeShrineSequence>.OnStart += action;
                })
                .SubscribeToBuildEvent(Debug.LogWarning)
                ,

                new StatusEffectDataBuilder(this)
                    .Create<StatusEffectInstantSummonInDeck>("Instant Summon Plep In Draw")
                    .SubscribeToAfterAllBuildEvent(d =>
                    {
                        Debug.Log(d.name);
                        var data = (StatusEffectInstantSummonInDeck)(d as StatusEffectInstantSummonInDeck)
                            .WithCanSummonMultiple(false)
                            .WithQueue()
                            .WithSummonCopy(false)
                            .WithWithEffects(new StatusEffectData[]{
                                Get<StatusEffectData>("Snow"),
                            }
                                );
                        data.summonPosition = StatusEffectInstantSummonInDeck.Position.Hand;
                        data.targetSummon = this.Get<StatusEffectData>("Summon Plep") as StatusEffectSummon;
                        data.targetConstraints = [];
                    })
                    .SubscribeToBuildEvent(Debug.LogWarning)
                    ,
                new CardDataBuilder(this)
                    .CreateUnit(name: "HeartmistStations", englishTitle: "Heartmist Stationa", idleAnim: "PulseAnimationProfile")
                    .WithTitle("红心雾台", SystemLanguage.ChineseSimplified)
                    .SetStats(1, 0, 0)
                    .SetSprites(ImagePath("OhNo.png").ToSprite(), IconSprite)
                    .WithPools("ClunkItemPool")
                    .WithValue(50)
                    .SubscribeToAfterAllBuildEvent(card =>
                    {
                        Debug.Log(card.name);
                        card.attackEffects = new StatusEffectStacks[] {
                            new(Get<StatusEffectData>("Instant Summon Plep In Draw"),1),
                            new(Get<StatusEffectData>("Instant Fadeout"),1),
                        };

                        var image = CreateScriptableImage<ScriptableImageGhost>() as ScriptableImageGhost;
                        image.altSprite = ImagePath("Luca_Profile01.png").ToSprite();

                        card.scriptableImagePrefab = CreateScriptableImage<ScriptableImageGhost>();

                        Debug.LogError("WHERE IS GHOST?");
                        Debug.LogError(image.gameObject.scene.name);
                        Debug.LogError(card.scriptableImagePrefab);
                    })
                    .SubscribeToBuildEvent(Debug.LogWarning)
                    ,
                new StatusEffectDataBuilder(this)
                    .Create<StatusEffectInstantRunAction>("Instant Fadeout")
                    .WithText($"<keyword={Extensions.PrefixGUID("obliterate", this)}>")
                    .SubscribeToAfterAllBuildEvent(d =>
                    {
                        Debug.Log(d.name);
                        var data = d as StatusEffectInstantRunAction;
                        data.action = e => {
                            var entity = e as Entity;
                            var go = entity.gameObject;
                            LeanTween.value(go, 1f, 0f, 0.5f)
                            .setOnUpdate(val => (entity.display as Card).canvasGroup.alpha = val)
                            .setOnComplete(() => go.Destroy());
                        };
                        data.targetConstraints = [];
                    })
                    .SubscribeToBuildEvent(Debug.LogWarning)
                    ,
                new KeywordDataBuilder(this)
                    .Create("obliterate")
                    .WithTitle("Obliterate")
                    .WithTitleColour(new Color(0.85f, 0.44f, 0.85f))
                    .WithShowName(true)
                    .WithDescription("Nothing survives its touch")
                    .WithNoteColour(new Color(0.85f, 0.44f, 0.85f))
                    .WithBodyColour(new Color(0.2f, 0.5f, 0.5f))
                    .WithCanStack(false)
                    .SubscribeToBuildEvent(Debug.LogWarning)
                    ,
                /*
                new TraitDataBuilder(this)
                    .Create("Obliterate")
                    .SubscribeToAfterAllBuildEvent(trait =>
                    {
                        trait.keyword = Get<KeywordData>("obliterate");
                        trait.effects = new StatusEffectData[]{
                            Get<StatusEffectData>("Instant Summon Plep In Draw"),
                            Get<StatusEffectData>("Instant Fadeout"),
                        };
                    }),*/

                    new StatusEffectDataBuilder(this)
                    .Create<StatusEffectWhileInHandX>("While In Hand Apply EveryTurnEffect To Self")
                    .WithText("While in hand, apply <+{a}><spr=attack> to self and rightmost card in hand")
                    .WithStackable(true).WithCanBeBoosted(true)
                    .SubscribeToAfterAllBuildEvent(d =>
                    {
                        Debug.Log(d.name);
                        var data = d as StatusEffectWhileInHandX;
                        data.effectToApply = Get<StatusEffectData>("Ongoing Increase Attack");
                        data.applyToFlags = StatusEffectApplyX.ApplyToFlags.Self | StatusEffectApplyX.ApplyToFlags.RightCardInHand;
                    })
                    .SubscribeToBuildEvent(Debug.LogWarning)
                    ,

                    new StatusEffectDataBuilder(this)
                    .Create<StatusEffectApplyXOnCardPlayed>(
                        name:"Apply Snow To Target", 
                        text:"Apply <keyword=snow> to target", 
                        effectToApply:"Snow", 
                        StatusEffectApplyX.ApplyToFlags.Target
                        )
                    ,

                    new CardDataBuilder(this)
                    .CreateItem(name: "ApplyX", englishTitle: "Applier", idleAnim: "PulseAnimationProfile")
                    .WithTitle("红心雾台", SystemLanguage.ChineseSimplified)
                    .SetDamage(0)
                    .SetSprites(ImagePath("OhNo.png").ToSprite(), IconSprite)
                    .WithPools("ClunkItemPool")
                    .WithValue(50)
                    .SubscribeToAfterAllBuildEvent(card =>
                    {
                        card.startWithEffects = [new(Get<StatusEffectData>("Apply Snow To Target"), 1)];
                        card.canPlayOnBoard = true;
                        card.canPlayOnEnemy = true;
                    }),

                    new StatusEffectDataBuilder(this)
                    .Create<StatusEffectChangeTargetMode>("Hit Random Enemy")
                    .WithText("Hits a random enemy with more than <3><sprite=health>")
                    .WithType("")
                    .SubscribeToAfterAllBuildEvent(d => {
                        var data = d as StatusEffectChangeTargetMode;
                        var targetMode = ScriptableObject.CreateInstance<TargetModeColumn>();
                        targetMode.name = "Hit Random Enemy";
                        data.targetMode = targetMode;
                    }),

                    new StatusEffectDataBuilder(this)
                    .Create<StatusEffectApplyXEveryTurn>("On Turn Reduce Counter Of Allies Per 50 Gold")
                    .WithText("Every turn, reduce <spr=counter> of allies for each 50<keyword=blings> owned")
                    .SubscribeToAfterAllBuildEvent(d => {
                        var data = d as StatusEffectApplyXEveryTurn;
                        data.effectToApply = Get<StatusEffectData>("Reduce Counter");
                        data.applyToFlags = StatusEffectApplyX.ApplyToFlags.Allies;
                        data.scriptableAmount = new Func<ScriptableGold>(() => {
                            var script = ScriptableObject.CreateInstance<ScriptableGold>();
                            script.factor = 0.02f;
                            script.name = "50 Gold";
                            return script;
                        })();
                        data.mode = StatusEffectApplyXEveryTurn.Mode.TurnStart;

                        // simple example of using variables in keyword
                        Get<KeywordData>("demonize").WithTitle("Demonize {0}");     // same as title.Replace("{0}", entity.data.upgrades.Count);
                        PatchPopUpStats.titleActions["Demonize"] = (title, entity, keyword) => title.Format(entity.data.upgrades.Count);
                    }),



                    new CardDataBuilder(this)
                    .CreateItem("luck", "Luck of the Draw")
                    .SetStats(1, 0, 1)
                    .SetSprites(ImagePath("Rose Carte Finale (Effect) (3).png").ToSprite(), IconSprite)
                    .SubscribeToAfterAllBuildEvent(c => {
                        c.startWithEffects = new StatusEffectStacks[]{
                            new StatusEffectStacks(Get<StatusEffectData>("Hit Random Enemy"),1),
                            new StatusEffectStacks(Get<StatusEffectData>("On Turn Reduce Counter Of Allies Per 50 Gold"),1),
                        };
                        
                    })
            ]); ; ;

            Debug.LogWarning(this.HarmonyInstance.GetPatchedMethods().Select(m => m.Name).DefaultIfEmpty("None").Join());
            this.HarmonyInstance.UnpatchSelf();
            Debug.LogWarning(this.HarmonyInstance.GetPatchedMethods().Select(m => m.Name).DefaultIfEmpty("None").Join());

        }
        public static string GetStatText(object current, object max, string color = "#FFFFFF")
          => GetColoredText(current + "/" + max, color);
        public static string GetColoredText(object text, string color = "#FFFFFF")
          => "<color={0}>{1}</color>".Format(color, text);

        [HarmonyPatch(typeof(PopUpAddStatsSystem), nameof(PopUpAddStatsSystem.PopupCreated))]
        public static class PatchPopUpStats
        {
            public static Dictionary<string, Func<string, Entity, KeywordData, string>> titleActions = new Dictionary<string, Func<string, Entity, KeywordData, string>>();
            public static Dictionary<string, Func<string, Entity, KeywordData, string>> bodyActions = new Dictionary<string, Func<string, Entity, KeywordData, string>>();
            public static Dictionary<string, Func<string, Entity, KeywordData, string>> noteActions = new Dictionary<string, Func<string, Entity, KeywordData, string>>();

            static void Postfix(PopUpAddStatsSystem __instance, Entity ___hover, KeywordData keyword, CardPopUpPanel panel)
            {
                // NOTE: ___hover is the entity that owns the StatusIcon this popup is for!
                if (!___hover)
                    return;

                if (titleActions.TryGetValue(keyword.name, out var titleAction))
                {
                    panel.titleText = titleAction(panel.titleText, ___hover, keyword);
                    panel.BuildTextElement();
                }

                if (bodyActions.TryGetValue(keyword.name, out var bodyAction))
                {
                    panel.bodyText = bodyAction(panel.bodyText, ___hover, keyword);
                    panel.BuildTextElement();
                }

                if (noteActions.TryGetValue(keyword.name, out var noteAction))
                {
                    panel.noteText = noteAction(panel.noteText, ___hover, keyword);
                    panel.BuildTextElement();
                }
            }
        }

        public GameObject CreateIcon(string name, Sprite sprite, string type, string copyTextFrom, Color textColor, KeywordData[] keys)
        {
            GameObject gameObject = new GameObject(name);
            UnityEngine.Object.DontDestroyOnLoad(gameObject);
            gameObject.SetActive(false);
            StatusIcon icon = gameObject.AddComponent<StatusIcon>();
            Dictionary<string, GameObject> cardIcons = CardManager.cardIcons;
            if (!copyTextFrom.IsNullOrEmpty())
            {
                GameObject text = cardIcons[copyTextFrom].GetComponentInChildren<TextMeshProUGUI>().gameObject.InstantiateKeepName();
                text.transform.SetParent(gameObject.transform);
                icon.textElement = text.GetComponent<TextMeshProUGUI>();
                icon.textColour = textColor;
                icon.textColourAboveMax = textColor;
                icon.textColourBelowMax = textColor;
            }
            icon.onCreate = new UnityEngine.Events.UnityEvent();
            icon.onDestroy = new UnityEngine.Events.UnityEvent();
            icon.onValueDown = new UnityEventStatStat();
            icon.onValueUp = new UnityEventStatStat();
            icon.afterUpdate = new UnityEngine.Events.UnityEvent();
            UnityEngine.UI.Image image = gameObject.AddComponent<UnityEngine.UI.Image>();
            image.sprite = sprite;
            CardHover cardHover = gameObject.AddComponent<CardHover>();
            cardHover.enabled = false;
            cardHover.IsMaster = false;
            CardPopUpTarget cardPopUp = gameObject.AddComponent<CardPopUpTarget>();
            cardPopUp.keywords = keys;
            cardHover.pop = cardPopUp;
            RectTransform rectTransform = gameObject.GetComponent<RectTransform>();
            rectTransform.anchorMin = Vector2.zero;
            rectTransform.anchorMax = Vector2.zero;
            rectTransform.sizeDelta *= 0.012f;
            gameObject.SetActive(true);
            icon.type = type;
            cardIcons[type] = gameObject;

            return gameObject;
        }
        public static List<string> lookup
        {
            get
            {

                foreach (var asset in assets)
                {
                    Debug.LogWarning(asset);
                    Debug.LogError(asset + ": " + (asset.GetType()));
                    Debug.LogError(asset + ": " + (asset.GetType().GetProperty("_data")));
                    Debug.LogError(asset + ": " + (asset.GetType().GetProperty("_data") != null));
                }

                if (assets.Count <= 0)
                    return new();
                return new();
/*
                return databuilders.Select(asset =>
                {
                }).ToList();*/
            }
        }
        public static bool RefreshLookup() => lookup.Any();

        public static List<object> assets = new List<object>();
        public override List<T> AddAssets<T, Y>()
        {
            if (typeof(T).Name == typeof(Y).Name + "Builder")
            {
                if (assets.OfType<T>().Any())
                    Debug.LogWarning($"[{Title}] adding {typeof(Y).Name}s: {assets.OfType<T>().Select(a => a._data.name).Join()}");
                return assets.OfType<T>().ToList();
            }

            return null;
        }

        public ScriptableCardImage CreateScriptableImage<T>() where T : ScriptableCardImage
        {
            // Create a new GameObject that will host the ScriptableImage
            var ghostObject = new GameObject("Ghost", typeof(RectTransform), typeof(Image), typeof(T))
            {
                // HideAndDontSave so it doesn't get touched during gameplay, OR
                hideFlags = HideFlags.HideAndDontSave
            };
            // ensure the GameObject is kept in memory this session
            GameObject.DontDestroyOnLoad(ghostObject);
            //ghostObject.transform.SetParent(Get<CardData>("LilBerry").scriptableImagePrefab.transform.parent);

            // Set the GameObject's size to the card size 
            ghostObject.GetComponent<RectTransform>().sizeDelta = new Vector2(3.8f, 5.7f);

            // The image will try to autofill to fit the RectTransform size
            ghostObject.GetComponent<Image>().preserveAspect = true;
            // This fixes the card being hoverable
            ghostObject.GetComponent<Image>().raycastTarget = false;

            return ghostObject.GetComponent<T>();
        }


        public abstract class DataBuilderBase
        {
            public WildfrostMod Mod => this.GetType().BaseType.GetField("instance").GetValue(null) as WildfrostMod;
            public abstract object GetDataBuilder();
            public virtual Action<T> AfterAllBuilt<T>(T data) where T : DataFile { return null; }
            public virtual Action<T> AfterSelfBuilt<T>(T data) where T : DataFile { return null; }
        }

        public override void Unload()
        {
            var toClear = owo.Clone();
            foreach (var item in owo)
            {
                if (item.data is CardUpgradeData charm)
                {
                    charm.RemoveFromCharms(item.unlock);
                    BuildingSequenceWithUnlocks<ChallengeShrineSequence>.OnStart -= item.sequenceActionOnStart as MonoMod.Cil.RuntimeILReferenceBag.FastDelegateInvokers.Action<ChallengeShrineSequence>;
                    toClear.Remove(item);
                }
            }
            if (toClear.Any())
                throw new Exception("There are metaprogression items not removed!\n" + owo.Select(x => x.ToString()).Join(delimiter:"\n"));
            owo.Clear();

            base.Unload();
            GameObject.Destroy(behaviour);
            behaviour = null;
        }
    }
}

public static class StatusDataBuilderHelpers
{
    public static StatusEffectDataBuilder Create<T>(this StatusEffectDataBuilder builder, string name, string text = "", string effectToApply = null, StatusEffectApplyX.ApplyToFlags applyToFlags = StatusEffectApplyX.ApplyToFlags.Self)
    where T : StatusEffectApplyX//, new()
    {
        return builder.Create<T>(name)
            .WithText(text)
            .SubscribeToAfterAllBuildEvent(d => {
                var data = (d as StatusEffectApplyX);
                data.effectToApply = builder.Mod.Get<StatusEffectData>(effectToApply);
                data.applyToFlags = applyToFlags;
                });
    }
}