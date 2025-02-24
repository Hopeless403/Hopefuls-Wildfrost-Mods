using Deadpan.Enums.Engine.Components.Modding;
using FMODUnity;
using HarmonyLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Elements = UnityEngine.UIElements;
using static UnityEngine.ParticleSystem;
using static CardData;
using static Mono.Security.X509.X520;
using static Rewired.Utils.Classes.Data.TypeWrapper;
using UnityEngine.Localization.SmartFormat.Utilities;
using Unity.Burst.Intrinsics;
using UnityEngine.AddressableAssets;
using UnityEngine.AddressableAssets.ResourceLocators;
using System.Reflection;
using static UnityEngine.UIElements.UxmlAttributeDescription;
using WildfrostHopeMod.Mod1;
using Steamworks;
using UnityEngine.Localization.PropertyVariants.TrackedProperties;
using HarmonyLib.Public.Patching;

public class MyMod : WildfrostMod
{
    public static MyMod instance;

    public static string CatalogFolder
        => Path.Combine(instance.ModDirectory, "Windows");

    public static string CatalogPath 
        => Path.Combine(CatalogFolder, "catalog.json");

    public MyMod(string modDirectory) : base(modDirectory)
    {
        instance = this;

        Debug.LogWarning(HarmonyInstance);
        HarmonyInstance.UnpatchSelf();
        Debug.LogWarning(HarmonyInstance.GetPatchedMethods().Select(m => m.Name).ToArray().DefaultIfEmpty("None").Join());
        HarmonyInstance.PatchAll(typeof(PatchHarmony));
        Debug.LogWarning(HarmonyInstance.GetPatchedMethods().Select(m => m.Name).ToArray().DefaultIfEmpty("None").Join());
        Debug.LogError(HarmonyInstance);
        HarmonyInstance.UnpatchSelf();
        Debug.LogWarning(HarmonyInstance.GetPatchedMethods().Select(m => m.Name).ToArray().DefaultIfEmpty("None").Join());
        HarmonyInstance.PatchAll();
        Debug.LogWarning(HarmonyInstance.GetPatchedMethods().Select(m => m.Name).ToArray().DefaultIfEmpty("None").Join());
    }
    [HarmonyPatch(typeof(WildfrostMod.DebugLoggerTextWriter), nameof(WildfrostMod.DebugLoggerTextWriter.WriteLine))]
    public class PatchHarmony
    {
        static bool Prefix() { Postfix(); return false; }
        static void Postfix() => HarmonyLib.Tools.Logger.ChannelFilter = HarmonyLib.Tools.Logger.LogChannel.Warn | HarmonyLib.Tools.Logger.LogChannel.Error;
    }
    [HarmonyPatch(typeof(WildfrostMod.DebugLoggerTextWriter), nameof(WildfrostMod.DebugLoggerTextWriter.Write))]
    public class PatchHarmony2
    {
        static bool Prefix() { Postfix(); return false; }
        static void Postfix() => HarmonyLib.Tools.Logger.ChannelFilter = HarmonyLib.Tools.Logger.LogChannel.Warn | HarmonyLib.Tools.Logger.LogChannel.Error;
    }
    public override string GUID => "hope.wildfrost.Mod1";
    public override string[] Depends => new string[] { };
    public override string Title => "My mod";
    public override string Description => $"Last update: {Directory.GetLastWriteTime(Assembly.GetExecutingAssembly().Location)}";
    public override TMP_SpriteAsset SpriteAsset => base.SpriteAsset;
    public static GameObject behaviour;


    public override void Load()
    {
        string s = """
            Activate Sacrifice Effects For Other Team
            Add Attack &Health To Summon
            Apply Haze &Double Attack
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
            Eat(Health & Attack)
            Eat(Health, Attack & Effects)
            Eat Allies In Row(Health &Attack)
            Eat Random Ally(Health, Attack & Effects)
            Eat Summoned Allies
            Eat Summoned
            Escape
            Fill Board(Final Boss)
            FinalBossPhase2
            Flee
            Free Action(Zoomlin)
            Free Action
            FrenzyBossPhase2
            Frost
            Gain Frenzy When Wild Unit Killed
            Gain Gold Range(3 - 6)
            Gain Gold
            GoatWampusPhase2
            Halt Spice With Text
            Halt Spice
            Haze
            Heal & Cleanse(No Ping)
            Heal(No Ping)
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
            Increase All Spice Applied(No Desc)
            Increase Attack &Health(No Constraints)
            Increase Attack &Health
            Increase Attack &Lose Half Health
            Increase Attack Effects
            Increase Attack While Alone
            Increase Attack While Damaged
            Increase Attack
            Increase Effects
            Increase Max Counter
            Increase Max Health(Not Current)
            Increase Max Health
            Injury
            Instant Add Scrap
            Instant Apply Attack To Allies
            Instant Apply Attack To Applier
            Instant Apply Current Attack To Allies
            Instant Apply Current Attack To Random Ally
            Instant Apply Current Health To Applier
            Instant Apply Frenzy(To Card In Hand)
            Instant Apply Frenzy(To Item In Hand)
            Instant Apply Teeth To Applier
            Instant Destroy Junk In Hand And Draw For Each
            Instant Draw
            Instant Gain Aimless
            Instant Gain Fury
            Instant Gain Lumin
            Instant Gain Noomlin(To Card In Hand)
            Instant Gain Soulbound(To Ally)
            Instant Gain Soulbound(To Enemy)
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
            MultiHit(Temporary, Not Visible)
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
            On Card Played Damage To Self &AlliesInRow
            On Card Played Damage To Self
            On Card Played Damage Undamaged Enemies
            On Card Played Destroy All Junk In Hand And Draw For Each
            On Card Played Destroy Random Card In Hand
            On Card Played Destroy Random Junk In Hand
            On Card Played Destroy Rightmost Card In Hand
            On Card Played Double Vim To Self
            On Card Played Heal & Cleanse To Allies
            On Card Played Lose 1 Juice To Self(No Desc)
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
            On Turn Add Health &Attack To Allies
            On Turn Add Health &Attack To Summoned Allies
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
            On Turn Eat Random Ally(Health, Attack &Effects)
            On Turn Escape To Self
            On Turn Heal &Cleanse Allies
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
            Pre Trigger Gain Temp MultiHit Equal To Scrap -1
            Pre Turn Destroy All Items In Hand & Gain Attack For Each
            Pre Turn Destroy All Items In Hand
            Pre Turn Destroy Random Card In Hand
            Pre Turn Eat Allies In Row(Health & Attack)
            Pre Turn Eat Random Ally(Health, Attack & Effects)
            Pre Turn Gain Attack For Each Ally
            Pre Turn Gain Attack For Each Item In Hand(For Each Card Destroyed)
            Pre Turn Gain Temp MultiHit Equal To Juice
            Pre Turn Kill Summoned Allies & Gain Attack For Each
            Pre Turn Take Attack From Enemies
            Pre Turn Take Gold
            Pre Turn Take Juice From RandomAlly
            Pre Turn Take Scrap From RandomAlly
            Pull
            Push
            Randomize Stats(2 - 5)
            Recycle Junk
            Redraw Cards
            Reduce Attack Effect 1
            Reduce Attack
            Reduce Counter
            Reduce Effects
            Reduce Max Counter
            Reduce Max Health(Must be ally)
            Reduce Max Health
            Remove Effects
            ResistShroom
            ResistSnow
            ResistSpice
            Sacrifice Ally &Increase Attack To Applier
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
            Trigger(High Prio)
            Trigger Against &Reduce Uses
            Trigger Against(Don't Count As Trigger)
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
            When Deployed Fill Board(Final Boss)
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
            When Enemy(Shroomed) Is Killed Apply Their Shroom To RandomEnemy
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
            When Hit Apply Gold To Attacker(No Ping)
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
            When Hit Gain Attack To Self(No Ping)
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
            When Sacrificed Summon TailsFour
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
            While Active Increase Attack To Allies(No Desc)
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
            While Active Reduce Attack To Enemies(No Ping, No Desc)
            While Active Reduce Effects To Hand
            While Active Snow Immune To Allies
            While Active Teeth To Allies
            While Active Trigger Applier When Block Lost To Allies & Self
            While Active Unmovable To Enemies
            While Active Zoomlin When Drawn To Allies In Hand
            While In Hand Reduce Attack To Allies
            While Last In Hand Double Effects To Self
            """;

        var strings = s.Split(["\r\n"], StringSplitOptions.None);
        foreach (var st in strings)
        {
            var e = AddressableLoader.Get<StatusEffectData>(nameof(StatusEffectData), st);
            if (e is not StatusEffectApplyX applyX) continue;
            //Debug.LogError($"{st}\t{applyX.scriptableAmount?.name} {applyX.contextEqualAmount?.name}{(applyX.contextEqualAmount?.name == null ? "" : "(c)")}");
        }

        _ = typeof(HarmonyManipulator);


        LocalizationHelper.GetCollection("Cards", SystemLanguage.English).SetString("owo", "|Body Text!");
        HelpPanelSystem.Show(LocalizationHelper.GetCollection("Cards", SystemLanguage.English).GetString("owo"));


        /*Debug.LogWarning(typeof(WildfrostMod));
        Debug.LogWarning(Assembly
            .GetAssembly(typeof(WildfrostMod))
            .GetTypes()
            .Where(t => typeof(ScriptableObject).IsAssignableFrom(t))
            .Select(t => t.Name)
            .Join(delimiter:"\n"));*/

        Debug.LogError("MY MOD " + Assembly.GetExecutingAssembly().GetType().AssemblyQualifiedName);
        Events.OnCardDataCreated += c => c.traits.Add(new(Get<TraitData>("Noomlin"), 1));

        /*HarmonyInstance.PatchAll(typeof())

        Debug.LogWarning(map = Addressables.LoadContentCatalogAsync(CatalogPath).WaitForCompletion() as ResourceLocationMap);
        //Debug.LogError(Addressables.LoadAssetAsync<UnityEngine.Object>("Assets/Maybe addressable/Test obj").WaitForCompletion());
        Debug.LogWarning(AddressableLoader.Get("Assets/Scenes/Cube.prefab"));
        Debug.LogWarning(GameObject.Find("Canvas/Safe Area/Menu/Title"));
        GameObject.Instantiate(AddressableLoader.Get("Assets/Scenes/Cube.prefab"), GameObject.Find("Canvas/Safe Area/Menu/Title").transform);

        Debug.LogError(Addressables.LoadAssetAsync<UnityEngine.Object>("my sprite").WaitForCompletion());
*/
        if (assets.Count <= 0)
            CreateModAssets();
        base.Load();




        behaviour = new GameObject(Title);
        GameObject.DontDestroyOnLoad(behaviour);

    }

    /*public class StatusEffectIncreaseAttackWhileX : StatusEffectData
    {
        // Flags that affect this
        public StatusEffectApplyX.ApplyToFlags checkFlags = StatusEffectApplyX.ApplyToFlags.AlliesInRow;

        // Constraints for which entities to check, eg Inked
        public TargetConstraint[] checkConstraints;

        // When should the attack be increased?
        public Predicate<Entity[]> checkPredicate = delegate (Entity[] entities)
        {
            // if there are allies in row, don't increase
            if (entities.Any())
                return false;
            // otherwise, increase attack
            return true;
        };

        private bool active;
        private int currentBonus;

        private void Check()
        {
            
            bool shouldActivate = checkPredicate(target.gett)
            if (!this.active)
            {
                if (num > 0)
                    return;
                this.Activate();
            }
            else
            {
                if (num <= 0)
                    return;
                this.Deactivate();
            }
        }

        private bool CheckConstraints(Entity entity)
        {
            if (checkConstraints == null)
                return true;

            return checkConstraints.All(constraint => constraint.Check(entity));
        }

        public override bool RunCardMoveEvent(Entity entity)
        {
            if (entity == this.target && this.active && !this.CanTrigger())
                this.Deactivate();
            else if ((((IList<CardContainer>)entity.preContainers).ContainsAny<CardContainer>((IEnumerable<CardContainer>)this.target.containers) || ((IList<CardContainer>)this.target.containers).ContainsAny<CardContainer>((IEnumerable<CardContainer>)entity.containers)) && this.CanTrigger())
                this.Check();
            return false;
        }

        public override bool RunEnableEvent(Entity entity)
        {
            this.Check();
            return false;
        }

        public override bool RunEntityDestroyedEvent(Entity entity, DeathType deathType)
        {
            if (this.CanTrigger())
                this.Check();
            return false;
        }

        public override bool RunEffectBonusChangedEvent()
        {
            if (this.active)
            {
                this.Deactivate();
                this.Activate();
            }
            return false;
        }

        

        public override bool HasStackRoutine => this.active;

        public override bool RunStackEvent(int stacks)
        {
            if (this.active)
            {
                this.currentBonus += stacks;
                this.target.tempDamage += stacks;
                this.target.PromptUpdate();
            }
            return false;
        }

        private void Activate()
        {
            this.active = true;
            this.currentBonus = this.GetAmount();
            this.target.tempDamage += this.currentBonus;
            this.target.PromptUpdate();
        }

        private void Deactivate()
        {
            this.active = false;
            this.target.tempDamage -= this.currentBonus;
            this.target.PromptUpdate();
        }

        public override bool CanTrigger() => base.CanTrigger() && Battle.IsOnBoard(this.target);
    }*/

    public class StatusEffectFlipDownHoverable : StatusEffectInstant
    {
        public override IEnumerator Process()
        {
            target.OnDisable();
            target.flipper.FlipDown();
            yield return null;
            yield return new WaitUntil(() => target.flipper.isCompleteFired);
            target.data = AddressableLoader.GetCardDataClone("Lump");
            yield return (target.display as Card).UpdateData(true);
            target.flipper.FlipUp();
            yield return base.Process();
        }
    }

    public class StatusEffectAmmo : StatusEffectData
    {
        public override void Init()
        {
            Events.OnEntityTrigger += CheckTrigger;
        }
        public void OnDestroy()
        {
            Events.OnEntityTrigger -= CheckTrigger;
        }
        public void CheckTrigger(ref Trigger trigger)
        {
            if (trigger.entity == this.target && GetAmount() <= 0)
                trigger.nullified = true;
        }
    }
    public class TargetModeColumn : TargetMode
    {
        public override Entity[] GetTargets(Entity entity, Entity target, CardContainer targetContainer)
        {
            HashSet<Entity> list = new HashSet<Entity>();
            int index = 0;
            if (target.IsAliveAndExists())
            {
                foreach (var container in target.actualContainers)
                {
                    if (container is CardSlot slot && slot?.Group != null && slot.Group is CardSlotLane lane)
                    {
                        index = lane.slots.IndexOf(slot);
                        list.AddRange(Battle.GetCardsOnBoard(target.owner).Where(e => e && e.enabled && e.alive && e.canBeHit && CheckSlot(e, index)));
                    }
                }
            }
            return list.Count <= 0 ? null : list.Distinct().ToArray();
        }
        public override Entity[] GetPotentialTargets(Entity entity, Entity target, CardContainer targetContainer)
        {
            return GetTargets(entity, target, targetContainer);
        }
        public override Entity[] GetSubsequentTargets(Entity entity, Entity target, CardContainer targetContainer)
        {
            return GetTargets(entity, target, targetContainer);
        }
        public bool CheckSlot(Entity entity, int index = 0)
        {
            foreach (CardContainer row in References.Battle.GetRows(entity.owner))
            {
                if (row is not CardSlotLane lane)
                    continue;
                // the row is a proper lane of cards

                if (lane.slots.Count <= index)
                    continue;

                CardSlot rowSlot = lane.slots[index];
                if (entity.actualContainers.Contains(rowSlot))
                    return true;
            }
            return false;
        }
    }

    public class TargetModeAllColumn : TargetModeAll
    {
        public override bool NeedsTarget => true;
        
    }


    public class StatusEffectCombineAllies : StatusEffectInstant
    {
        /// <summary>
        /// Leave null to combine into the owner
        /// </summary>
        public CardData combineInto;

        public override IEnumerator Process()
        {
            Entity resultEntity;
            if (!combineInto)
                resultEntity = target;
            else
                resultEntity = CardManager.Get(combineInto, target.display.hover.controller, target.owner, false, target.owner == Battle.instance.player).entity;

            //ActionQueue.Stack(new ActionCombine([.. target.GetAllAllies(), resultEntity]), true);
            yield return CombineSystem.Combine(target, resultEntity);
            yield return base.Process();
        }
    }


    #region Code dependencies
    public class Scriptable<T> where T : ScriptableObject, new()
    {
        readonly Action<T> modifier;
        public Scriptable() { }
        public Scriptable(Action<T> modifier) { this.modifier = modifier; }
        public static implicit operator T(Scriptable<T> scriptable)
        {
            T result = ScriptableObject.CreateInstance<T>();
            scriptable.modifier?.Invoke(result);
            return result;
        }
    }
    #endregion
    private void CreateModAssets(bool forRelease = true)
    {
        assets.AddRange([
            new StatusEffectDataBuilder(this)
        .Create<StatusEffectChangeTargetMode>("Hit Column")
        .WithText("Hit enemies in column")
        .WithStackable(true)
        .WithCanBeBoosted(false)
        .WithOffensive(false)           // As an attack effect, this is treated as a buff
        .WithMakesOffensive(false)      // As a starting effect, its entity should target allies
        .WithDoesDamage(false)          // Its entity cannot kill with this effect, eg for Bling Charm
        .SubscribeToAfterAllBuildEvent<StatusEffectChangeTargetMode>(data =>
        {
                data.targetMode = new Scriptable<TargetModeColumn>();
        }),


            new StatusEffectDataBuilder(this)
        .Create<StatusEffectTemporaryTrait>("Temporary Aimless")
        .WithStackable(false)
        .WithCanBeBoosted(false)
        .WithOffensive(false)           // As an attack effect, this is treated as a buff
        .WithMakesOffensive(false)      // As a starting effect, its entity should target allies
        .WithDoesDamage(false)          // Its entity cannot kill with this effect, eg for Bling Charm
        .WithIsKeyword(true)    // This effect adds text to the card.
        .SubscribeToAfterAllBuildEvent<StatusEffectTemporaryTrait>(data =>
        {
            data.targetConstraints = new TargetConstraint[]
            {
                        new Scriptable<TargetConstraintDoesAttack>(),
            };
            data.trait = Get<TraitData>("Aimless");
        }),
        new TraitDataBuilder(this)
        .Create("Aimless")
        .SubscribeToAfterAllBuildEvent(data =>
        {
                data.keyword = Get<KeywordData>("Aimless");
                data.effects = new StatusEffectData[]
                {
                        Get<StatusEffectChangeTargetMode>("Hit Random Target"),
                };
                data.overrides = new TraitData[]
                {
                        Get<TraitData>("Barrage"),
                        Get<TraitData>("Longshot"),
                };
        })

        ]);


    //'this' refers to an instance of a WildfrostMod class

    StatusEffectDataBuilder mimikEffect = new StatusEffectDataBuilder(this)
            .Create<StatusEffectTriggerWhenAllyAttacks>("Trigger When Ally Attacks") // internal name
            .WithText("Trigger when an ally attacks") // text shown to the player
            .SubscribeToAfterAllBuildEvent(d =>
            {
                
                StatusEffectTriggerWhenAllyAttacks data = (StatusEffectTriggerWhenAllyAttacks)d;
                data.descColorHex = "F99C61"; // the color hex of reaction effect text
            });

        //Note: making the builder is not the same as loading the StatusEffectData into the game. There is an additional step. 
        //See Tutorial 2.
        DataFileBuilder<StatusEffectData, StatusEffectDataBuilder>.AfterBuildDelegate sub;
        assets.AddRange([
            new StatusEffectDataBuilder(this).Create<StatusEffectFlipDownHoverable>("Flip Down (Hoverable)")
            .WithText("Flip the target")
            ,

            new StatusEffectDataBuilder(this).Create<StatusEffectTriggerWhenAllyAttacks>("Trigger When Deployed")
            .SubscribeToAfterAllBuildEvent(sub = d => { /*whatever*/ })
            .UnubscribeToAfterAllBuildEvent(sub)
            ,
            new StatusEffectDataBuilder(this)
            .Create<StatusEffectChangeTargetMode>("Hit Enemy Not Backline")
            .WithText("Hits enemies not in the last row")
            .WithType("")
            .SubscribeToAfterAllBuildEvent(d => {
                var data = d as StatusEffectChangeTargetMode;
                var targetMode = ScriptableObject.CreateInstance<TargetModeAnticol>();
                targetMode.name = "Hit Enemy Not Backline";
                data.targetMode = targetMode;
            }),
            new TraitDataBuilder(this)
                .Create("Splash2")
                .WithOverrides(Get<TraitData>("Barrage"))
                .SubscribeToAfterAllBuildEvent(trait =>
                {
                    trait.keyword = Get<KeywordData>("snow");
                    trait.effects = [Get<StatusEffectData>("Null")];
                }),
            new KeywordDataBuilder(this)
                .Create("glacial")                               //The internal name for the upgrade.
                .WithTitle("Glacial")                            //The in-game name for the upgrade.
                .WithTitleColour(new Color(0.85f, 0.44f, 0.85f)) //Light purple on the title of the keyword pop-up
                .WithShowName(true)                              //Shows name in Keyword box (as opposed to a nonexistant icon).
                .WithDescription("Apply equal <keyword=snow> or <keyword=frost> when the other is applied|Does not cause infinites!") //Format is body|note.
                .WithNoteColour(new Color(0.85f, 0.44f, 0.85f))  //Somewhat teal
                .WithBodyColour(new Color(0.2f, 0.5f, 0.5f))       //Cyan-ish
                .WithCanStack(false),                             //The keyword does not show its stack number.
            new CardDataBuilder(this)
                .CreateUnit(name: "HeartmistStations", englishTitle: "0Heartmist Stationa", idleAnim: "PulseAnimationProfile")
                .WithTitle("红心雾台", SystemLanguage.ChineseSimplified)
                .SetStats(0, 0, 0)
                .SetSprites(IconSprite, IconSprite)
                .WithPools("ClunkItemPool")
                .WithValue(50)
                .SubscribeToAfterAllBuildEvent(card =>
                {
                    card.attackEffects = new StatusEffectStacks[] {
                        new CardData.StatusEffectStacks(Get<StatusEffectData>("Null"), 1),
                    };
                    card.startWithEffects = new CardData.StatusEffectStacks[]
                    {
                        new CardData.StatusEffectStacks(Get<StatusEffectData>("MultiHit"), 1),
                    };
                    card.traits = new List<CardData.TraitStacks> { new TraitStacks(Get<TraitData>("Barrage"), 1) };
                }),
                new CardDataBuilder(this)
                .CreateUnit(name: "HeartmistStations", englishTitle: "1Heartmist Stationa", idleAnim: "PulseAnimationProfile")
                .WithTitle("红心雾台", SystemLanguage.ChineseSimplified)
                .SetStats(0, 0, 0)
                .SetSprites("Nothing.png".ToSprite(), IconSprite)
                .WithPools("ClunkItemPool")
                .WithValue(50)
                .SubscribeToAfterAllBuildEvent(card =>
                {
                    card.attackEffects = new StatusEffectStacks[] {
                        new CardData.StatusEffectStacks(Get<StatusEffectData>("Null"), 1),
                    };
                    card.startWithEffects = new CardData.StatusEffectStacks[]
                    {
                        new CardData.StatusEffectStacks(Get<StatusEffectData>("MultiHit"), 1),
                    };
                    card.traits = new List<CardData.TraitStacks> { new TraitStacks(Get<TraitData>("Barrage"), 1) };
                })
        ]);
    }

    public static List<object> assets = new List<object>();
    public static List<string> lookup { get
        {
            Action<StatusEffectData> action = delegate (StatusEffectData data)
            {
                var effect = data as StatusEffectAffectAllXApplied;
            };
            foreach (var asset in assets)
            {
                Debug.LogWarning(asset);
                Debug.LogError(asset + ": " + (asset.GetType()));
                Debug.LogError(asset + ": " + (asset.GetType().GetProperty("_data")));
                Debug.LogError(asset + ": " + (asset.GetType().GetProperty("_data") != null));
            }

            if (assets.Count <= 0)
                return new();

            return assets.Select(asset =>
            {
                Debug.LogError(asset + ": " + (asset.GetType().GetProperty("_data") != null));
                var dataFile = asset.GetType().GetProperty("_data").GetValue(asset) as DataFile;
                return dataFile?.name;
                var dataType = dataFile.GetType();
                string title = "";
                if (dataType.GetProperty("title") != null)
                {
                    if (dataType != typeof(KeywordData) || (bool)dataType.GetProperty("HasTitle").GetValue(dataFile))
                        try { title = (string)dataType.GetProperty("title").GetValue(dataFile) ?? ""; }
                        catch
                        {
                            Debug.LogError($"[{instance.Title}] FAILED to get title of {dataFile}");
                        }
                    if (!title.IsNullOrEmpty()) 
                        return $"{dataType} {dataFile.name} ({title})";
                }
                return $"{dataType} {dataFile.name}";
            }).ToList(); 
        } }
    public static bool RefreshLookup() => lookup.Any();
    public override List<T> AddAssets<T, Y>()
    {
        if (assets.OfType<T>().Any())
            Debug.LogWarning($"[{Title}] adding {typeof(Y).Name}: {assets.OfType<T>().Select(d => Path.GetExtension(d._data.name)).Join()}");
        return assets.OfType<T>().ToList();
    }

    public override void Unload()
    {
        base.Unload();
        //assets.Clear();
        GameObject.Destroy(behaviour);
        behaviour = null;
    }
}
