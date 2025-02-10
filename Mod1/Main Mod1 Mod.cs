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
        LocalizationHelper.GetCollection("Cards", SystemLanguage.English).SetString("owo", "|Body Text!");
        HelpPanelSystem.Show(LocalizationHelper.GetCollection("Cards", SystemLanguage.English).GetString("owo"));


        Debug.LogWarning(typeof(WildfrostMod));
        Debug.LogWarning(Assembly
            .GetAssembly(typeof(WildfrostMod))
            .GetTypes()
            .Where(t => typeof(ScriptableObject).IsAssignableFrom(t))
            .Select(t => t.Name)
            .Join(delimiter:"\n"));

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
        public int index = 0;
        public override Entity[] GetTargets(Entity entity, Entity target, CardContainer targetContainer)
        {
            HashSet<Entity> list = new HashSet<Entity>();
            list.AddRange(entity.GetAllEnemies().Where(e => e && e.enabled && e.alive && e.canBeHit && CheckSlot(e, index)));
            return list.Count <= 0 ? null : list.ToArray();
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



    private void CreateModAssets(bool forRelease = true)
    {
        //'this' refers to an instance of a WildfrostMod class

        StatusEffectDataBuilder mimikEffect = new StatusEffectDataBuilder(this)
            .Create<StatusEffectTriggerWhenAllyAttacks>("Trigger When Ally Attacks") // internal name
            .WithText("Trigger when an ally attacks") // text shown to the player
            .SubscribeToAfterAllBuildEvent(delegate (StatusEffectData d)
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
