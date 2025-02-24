using Deadpan.Enums.Engine.Components.Modding;
using FMODUnity;
using HarmonyLib;
using JetBrains.Annotations;
using NaughtyAttributes;
using Rewired;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Localization;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static UnityEngine.Rendering.VolumeComponent;
using static WildFlipper.WildFlipperMod;
using static ExtraPopups.PopGroup;
using UnityEngine.Events;
using System.Text;
using static Rewired.Utils.Classes.Data.TypeWrapper;
using static CampaignGenerator;
using System.Text.RegularExpressions;
using Rewired.UI;
using UnityEngine.U2D;
using UnityEngine.AddressableAssets.ResourceLocators;
using WildFlipper;
using Goobers;
using NexPlugin;
using Steamworks;
using System.Collections;
using UnityEngine.EventSystems;

namespace Goobers
{
    public class Goobers { public static SpriteAtlas Cards => AddressablesHandler.Sprites; }
    [HarmonyPatch]
    public class AddressablesHandler
    {
        public static string CatalogFolder => Path.Combine(instance.ModDirectory, "Catalog");//
        public static string CatalogPath => Path.Combine(CatalogFolder, "catalog.json");
        // Adjust these 2 for different mods
        public const string spriteAtlasPath = "Assets/Goobers/Sprites.spriteatlas";
        static WildfrostMod Instance => WildFlipper.WildFlipperMod.instance;
        static SpriteAtlas _Sprites;
        public static SpriteAtlas Sprites { get
            {
                if (!Addressables.ResourceLocators.Any(r => r is ResourceLocationMap map && map.LocatorId == CatalogPath))
                    Addressables.LoadContentCatalogAsync(CatalogPath).WaitForCompletion();
                return _Sprites ??= Addressables.LoadAssetAsync<SpriteAtlas>(spriteAtlasPath).WaitForCompletion();
            } }

        [HarmonyPrefix]
        [HarmonyPatch(typeof(Extensions), nameof(Extensions.ToSprite), typeof(string))]
        static bool PatchPathToSprite(string path, ref Sprite __result)
        {
            var instance = Extensions.GetModFromGuid("okojo.wildfrost.pokemontrainer wildfrost");
            if (instance == default)
                return true;

            if (!new DirectoryInfo(path).FullName.Contains(new DirectoryInfo(instance.ModDirectory).FullName))
                return true;

            string filename = Path.GetFileNameWithoutExtension(path);
            __result = Sprites?.GetSprite(filename);

            return !__result;
        }

        /*[HarmonyPrefix]
        [HarmonyPatch(typeof(ScriptableObject), MethodType.Constructor)]
        static void PatchConstructor(ScriptableObject __instance, ref )
        {
            ScriptableObject.CreateInstance(__instance.GetType());
        }*/
        
        /*[HarmonyPostfix]
        [HarmonyPatch(typeof(RewardPool), MethodType.Constructor)]
        static void PatchConstructor(RewardPool __instance)
        {
            Debug.LogError("THIS IS A CONSTRUCTED POOL + " + __instance);
        }*/
    }
}




namespace WildFlipper
{
    public static class Exts
    {
        /*public static DataFileBuilder OnModUnloaded<DataFile, DataFileBuilder>(this DataFile data, MethodBase unloadMethod)
          where DataFile : global::DataFile
          where DataFileBuilder : DataFileBuilder<DataFile, DataFileBuilder>, new()
        {
            Events.OnModUnloaded += unloadMethod;
            return y;
        }*/

        static TargetConstraint t = new TargetConstraintAttackMoreThan()
        {
            not = true,
        };
    }
    public partial class WildFlipperMod : WildfrostMod
    {
        
        
        // it should be named this to show up as a Singleton in UnityExplorer
        public static WildFlipperMod instance;
        public WildFlipperMod(string modDirectory) : base(modDirectory)
        {
            instance = this;
        }
        
        public override string GUID => "hope.wildfrost.WildFlipper";
        public override string[] Depends => new string[] { };
        public override string Title => "WildFlipper";
        public override string Description => $"Last update: {DateTime.Now}";
        public override TMP_SpriteAsset SpriteAsset => base.SpriteAsset;
        public static GameObject behaviour;
        public static Transform prefabParent;
        UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle handle = default;

        public bool addedHandSprites = false;
        public void AddHandSpritesOnSceneLoaded(Scene scene)
        {
            if (addedHandSprites || scene.name != "UI")
                return;



            addedHandSprites = true;
        }


        public class StatusEffectApplyXWhenAllyAheadIsHit : StatusEffectApplyXWhenAllyIsHit
        {
            public override bool RunPostHitEvent(Hit hit)
            {
                return base.RunPostHitEvent(hit) && IsInFrontOf(hit.target);
            }

            public bool IsInFrontOf(Entity entity)
            {
                foreach (CardContainer cardContainer in target.actualContainers)
                {
                    if (cardContainer is CardSlot cardSlot && cardContainer.Group is CardSlotLane lane)
                    {
                        for (int index = lane.slots.IndexOf(cardSlot) - 1; index >= 0; --index)
                        {
                            if (lane.slots[index].GetTop() == entity)
                                return true;
                        }
                    }
                }
                return false;
            }
        }
        [HarmonyPatch(typeof(Extensions), nameof(Extensions.ToSprite), typeof(string))]
        public class PatchPathToSprite
        {
            static bool Prefix(string path, ref Sprite __result)
            {
                var Cards = new SpriteAtlas();
                var instance = Extensions.GetModFromGuid("okojo.wildfrost.pokemontrainer wildfrost");
                if (instance == default)
                    return true;

                if (!new DirectoryInfo(path).FullName.Contains(new DirectoryInfo(instance.ModDirectory).FullName))
                    return true;

                string filename = Path.GetFileNameWithoutExtension(path);
                __result = Cards?.GetSprite(filename);
                if (!__result)
                    Debug.LogWarning("[Pokemon Trainer] Oh no, we lost " + filename);

                return !__result;
            }
        }
        public override void Load()
        {
/*
            FMODUnity.RuntimeManager.StudioSystem.getBankList(out FMOD.Studio.Bank[] banks);

            foreach (var bank in banks)
            {
                bank.getEventList(out var events);
                foreach (var e in events)
                {
                    e.getID(out FMOD.GUID guid);
                    e.getLength(out int length);
                    e.getPath(out string path);
                    //Debug.Log((path, length, guid));
                }
            }
            //RuntimeManager.PlayOneShot()

            HarmonyInstance.PatchAll(typeof(AddressablesHandler));*/


            InitAssets();

            //base.Load();
            foreach (var card in AddressableLoader.GetGroup<BattleData>(nameof(BattleData)))
            {
                card.sprite = ImagePath("BUGICON.png").ToSprite();
            }
            ImagePath("").ToSprite();
            foreach (var card in AddressableLoader.GetGroup<CardData>(nameof(CardData)))
            {
                /*Debug.Log(card);
                if (card.targetConstraints.Length == 0)
                    card.targetConstraints = [new Scriptable<TargetConstraintInColumn>(t => t.targetColumn = 0)];
                else Debug.LogWarning((card, card.targetConstraints.Join()));
                Debug.LogError(card.targetConstraints.Join());*/
            }
            foreach (var card in AddressableLoader.GetGroup<StatusEffectData>(nameof(StatusEffectData)))
            {
                if (card is StatusEffectApplyX apply && apply.canRetaliate)
                {
                    //Debug.LogWarning(card);
                    //Debug.Log(card.textKey);
                }
                if (!card.isKeyword) continue;
                
                //Debug.Log(card.textKey.IsEmpty ? "" : card.textKey.GetLocalizedString());
            }


            assets.Add(StatusCopyBoxed<StatusEffectWhileInHandX>("While Active Add Equal Attack To Junk In Hand", "While In Hand Add Equal Attack To Junk In Hand"));

            base.Load();


            Vector2 pivot = new Vector2(0.5f, 0.5f);


            //Events.OnEntityCreated += ChangeSprite;
            Events.OnSceneChanged += AddAbilityTargets;
            Events.OnBattleStateBuilt += ChangeRedraw;

        }
        //void ChangeSprite(Entity e) => (e.display as Card).backImage.sprite = s; Sprite s = Sprite.Create(t, new Rect(0f, 0f, t.width, t.height), pivot, 100, 0, SpriteMeshType.FullRect); Texture2D t => instance.ImagePath("pokemon_cardback.jpg").ToTex();
        void ChangeRedraw(BattleSaveData state)
        {
            var system = GameObject.FindObjectOfType<RedrawBellSystem>();
            var image = system?.bell.FindObject("Bell")?.GetComponent<Image>();
            if (!image) return;
            image.type = Image.Type.Filled;
            image.fillMethod = Image.FillMethod.Vertical;
            image.fillAmount = Mathf.Clamp01((float)system.counter.current / system.counter.max);
        }
        public override void Unload()
        {
            base.Unload();
            behaviour.DestroyImmediate();
            //Events.OnEntityCreated -= ChangeSprite;
            Events.OnSceneChanged -= AddAbilityTargets;
            Events.OnBattleStateBuilt -= ChangeRedraw;
        }
        public Dictionary<string, GameObject> targetPrefabs = new Dictionary<string, GameObject>();
        public Transform modParent => new GameObject(Title).FreeModify(g => { GameObject.DontDestroyOnLoad(g); g.SetActive(false); }).transform;
        public void AddAbilityTargets(Scene scene)
        {
            if (scene.name != "Campaign") return;

            var system = scene.FindObjectOfType<AbilityTargetSystem>();
            if (system == null) return;

            if (!targetPrefabs.ContainsKey(Title))
            {
                targetPrefabs[Title] = new GameObject(Title)
                .FreeModify(g =>
                {
                    g.transform.SetParent(modParent);
                    g.GetOrAdd<RectTransform>().sizeDelta = Vector2.one;
                    g.GetOrAdd<SpriteRenderer>().sprite = IconSprite;
                    g.GetOrAdd<SpriteRenderer>().sortingLayerName = "Behind";
                    g.GetOrAdd<SpriteRenderer>().sortingLayerID = -20;
                });
            }
            var anotherSystem = system.gameObject
                .GetComponents<AbilityTargetSystem>()
                .FirstOrDefault(s => s.targetPrefab == targetPrefabs[Title]);


            anotherSystem ??= system.gameObject.AddComponent<AbilityTargetSystem>();
            anotherSystem.targetGroup = system.targetGroup;
            anotherSystem.targetPrefab = targetPrefabs[Title];
        }

        public FieldInfo[] GetAllFields<T>(T t) => (typeof(T) ?? t.GetType()).GetFields((BindingFlags)0x1FFFFFD);
        public StatusEffectDataBuilder StatusCopyBoxed<T>(string oldName, string newName) where T : StatusEffectData
        {
            StatusEffectData copyFrom = TryGet<StatusEffectData>(oldName);
            StatusEffectDataBuilder builder = new StatusEffectDataBuilder(this).Create<T>(newName);
            foreach (var field in GetAllFields(copyFrom).Where(f => f.IsPublic || f.GetCustomAttribute<SerializeField>() != null))
            {
                try
                {
                    var value = field.GetValue(typeof(T));
                    field.SetValue(builder._data, value);
                }
                catch { }
            }
            return builder;
        }

        
        public new T Get<T>(string name) where T : DataFile => TryGet<T>(name);
        private T TryGet<T>(string name) where T : DataFile
        {
            T data;
            if (typeof(StatusEffectData).IsAssignableFrom(typeof(T)))
                data = base.Get<StatusEffectData>(name) as T;
            else
                data = base.Get<T>(name);

            if (data == null)
                throw new Exception($"TryGet Error: Could not find a [{typeof(T).Name}] with the name [{name}] or [{Extensions.PrefixGUID(name, this)}]");

            return data;
        }
        public void Log(object message) => Debug.Log($"[{Title}] {message}");
        public void LogWarning(object message) => Debug.LogWarning($"[{Title} Warning] {message}");
        public void LogError(object message) => Debug.LogError($"[{Title} Error] {message}");

        

        public class StatusEffectIconBuilder : StatusEffectDataBuilder
        {
            public List<object> Builders { get; } = new List<object>();
            public StatusEffectIconBuilder(WildfrostMod mod = null) => new StatusEffectDataBuilder(mod);

            public StatusEffectIconBuilder CreateWithIcon<T>(string name) where T : StatusEffectData
            {
                CreateWithIcon<StatusEffectApplyX>(name);

                Builders.Add(this);
                assets.AddRange(this.Builders);
                return this;

            }

        }
        
        public interface IMultipleDataBuilder<A, B> where A : DataFile where B : DataFile
        {

        }
        public class TraitAndKeywordBuilder : TraitDataBuilder, IMultipleDataBuilder<TraitData, KeywordData>
        {
            public readonly List<object> Builders = new List<object>();
            public TraitAndKeywordBuilder(WildfrostMod mod = null) => new TraitDataBuilder(mod);
            public TraitAndKeywordBuilder CreateWithKeyword(string name) => this;
        }

        public static List<object> assets = new List<object>();
        public static void InitAssets() => assets = [

            new StatusEffectDataBuilder(instance)
            .Create<StatusEffectOngoingMaxCounter>("Ongoing Reduce Max Counter")
            .SubscribeToAfterAllBuildEvent(s => (s as StatusEffectOngoingMaxCounter).reverse = true),

            new StatusEffectDataBuilder(instance)
            .Create<StatusEffectWhileActiveX>("While Active Reduce Max Counter To Allies")
            .WithText("While active, reduce the counter of allies")
            .SubscribeToAfterAllBuildEvent(d =>
            {
                var data = (StatusEffectWhileActiveX)d;
                data.effectToApply = instance.TryGet<StatusEffectOngoingMaxCounter>("Ongoing Reduce Max Counter");
                data.applyToFlags = StatusEffectApplyX.ApplyToFlags.Allies;
                //nameof(Card.AddPassiveEffectText)
            })
            ,
            new StatusEffectDataBuilder(instance)
            .Create<StatusEffectApplyXWhenCardMoves>("When Enemy Moves Apply Spice To Them")
            .WithText("When an enemy moves, apply <{a}><keyword=spice> to them")
            .SubscribeToAfterAllBuildEvent(d =>
            {
                var data = (StatusEffectApplyXWhenCardMoves)d;
                data.effectToApply = instance.TryGet<StatusEffectData>("Spice");
                data.applyToFlags = StatusEffectApplyX.ApplyToFlags.Target;
            })
            ,
            new CardUpgradeDataBuilder(instance)
            .Create("Give Counter Charm")
            .WithType(CardUpgradeData.Type.Charm)
            .WithTitle("Counter Charm")
            .WithText("yada yada")
            .ChangeCounter(10)
            .WithSetCounter(true)
            /*.SubscribeToAfterAllBuildEvent(d =>
            {
                d
            })*/
            ,new StatusEffectDataBuilder(instance)
        .Create<StatusEffectInstantMultiple>("Increase Attack & Health")
        .WithStackable(true)
        .WithCanBeBoosted(true)
        .WithOffensive(false)           // As an attack effect, this is treated as a buff
        .WithMakesOffensive(false)      // As a starting effect, its entity should target allies
        .WithDoesDamage(false)          // Its entity cannot kill with this effect, eg for Bling Charm
        .Create<StatusEffectInstantMultiple>("Increase Attack & Health")
        .WithStackable(true)
        .WithCanBeBoosted(true)
        .WithOffensive(false)           // As an attack effect, this is treated as a buff
        .WithMakesOffensive(false)      // As a starting effect, its entity should target allies
        .WithDoesDamage(false)          // Its entity cannot kill with this effect, eg for Bling Charm
        .SubscribeToAfterAllBuildEvent(d =>
        {
            var data = (StatusEffectInstantMultiple)d;
                data.applyFormatKey = null;
                data.targetConstraints = new TargetConstraint[]
                {
                        new Scriptable<TargetConstraintOr>(t =>
                        {
                                t.not = false;
                                t.constraints = new TargetConstraint[]
                                {
                                        new Scriptable<TargetConstraintHasHealth>(t =>
                                        {
                                                t.not = false;
                                        }),
                                        new Scriptable<TargetConstraintDoesDamage>(t =>
                                        {
                                                t.not = false;
                                        }),
                                };
                        }),
                };
                data.effects = new StatusEffectInstant[]
                {
                        instance.TryGet<StatusEffectInstantIncreaseAttack>("Increase Attack"),
                        instance.TryGet<StatusEffectInstantIncreaseMaxHealth>("Increase Max Health"),
                };
        }),
            new StatusEffectDataBuilder(instance)
            .Create<StatusEffectApplyXWhenCardMoves>("Riptide")
            .WithText("When an enemy moves, deal <{a}> damage to them")
            .SubscribeToAfterAllBuildEvent(d =>
            {
                var data = (StatusEffectApplyXWhenCardMoves)d;
                data.dealDamage = true;
                data.doesDamage = true;
                data.applyToFlags = StatusEffectApplyX.ApplyToFlags.Target;
            })
            ,

            new StatusEffectDataBuilder(instance)
            .Create<StatusEffectApplyXWhenCardMoves>("Riptide")
            .WithText("When an enemy moves, deal <{a}> damage to them")
            .SubscribeToAfterAllBuildEvent(d =>
            {
                var data = (StatusEffectApplyXWhenCardMoves)d;
                data.dealDamage = true;
                data.doesDamage = true;
                data.applyToFlags = StatusEffectApplyX.ApplyToFlags.Target;
            })
            ,

            new StatusEffectDataBuilder(instance)
            .Create<StatusEffectApplyXWhenCardMoves>("Riptide")
            .WithText("When an enemy moves, deal <{a}> damage to them")
            .SubscribeToAfterAllBuildEvent(delegate (StatusEffectApplyXWhenCardMoves d)
            {
                var data = (StatusEffectApplyXWhenCardMoves)d;
                data.dealDamage = true;
                data.doesDamage = true;
                data.applyToFlags = StatusEffectApplyX.ApplyToFlags.Target;
            })
            ,

            
            new StatusEffectDataBuilder(instance)
            .Create<StatusEffectWhileActiveX>("While Active Increase Effects To Allies")
            .WithText("While active, boost allies' effects by {a}")
            .SubscribeToAfterAllBuildEvent(d =>
            {

                var data = (StatusEffectWhileActiveX)d;
                data.effectToApply = instance.TryGet<StatusEffectOngoingEffects>("Ongoing Increase Effects");
                data.applyToFlags = StatusEffectApplyX.ApplyToFlags.AlliesInRow;
                data.canBeBoosted = false;
                //nameof(Card.AddPassiveEffectText)
            })
            ,
            new StatusEffectDataBuilder(instance)
            .Create<StatusEffectApplyXWhenAllyAheadIsHit>("When Ally Ahead Is Hit Damage Attacker")
            .WithText("When Ally Ahead Is Hit Damage Attacker by {a}")
            .SubscribeToAfterAllBuildEvent(d =>
            {
                var data = (StatusEffectApplyXWhenAllyAheadIsHit)d;
                data.dealDamage = true;
                data.applyToFlags = StatusEffectApplyX.ApplyToFlags.Attacker;
            })
            ,

            new KeywordDataBuilder(instance)
            .Create("camaraderie") //Keyword for Camaraderie Effect
            .WithShowName(true)
            .WithTitle("Camaraderie")
            .WithDescription("When an ally who also has Camaraderie attacks, trigger against the target")
            ,
            new TraitAndKeywordBuilder(instance).CreateWithKeyword("").Builders,
            new TraitDataBuilder(instance)
            .Create("Camaraderie") //Trait for Camaraderie
            .SubscribeToAfterAllBuildEvent(
            (trait) =>
            {
                trait.keyword = instance.TryGet<KeywordData>("aimless");
                trait.effects = new StatusEffectData[] { instance.TryGet<StatusEffectData>("Trigger Against Target Hit By Camaraderie Unit") };
            }),

            new StatusEffectDataBuilder(instance)
            .Create<StatusEffectApplyXWhenHit>("Trigger Against Backlines When Hit")
            .WithText("When hit, trigger against backline units")
            .WithIsReaction(true)
            .SubscribeToAfterAllBuildEvent(d =>
            {
                var data = (StatusEffectApplyXWhenHit)d;
                data.descColorHex = "F99C61";   // trigger color
                data.effectToApply = instance.TryGet<StatusEffectData>("Trigger Against");
                data.applyToFlags = StatusEffectApplyX.ApplyToFlags.Enemies;
                data.applyConstraints = [new Scriptable<TargetConstraintInColumn>()];
            })
            ,


            new StatusEffectDataBuilder(instance)
            .Create<StatusEffectApplyXInstant>("Trigger Against Current Target")  //Effect Data for Camaraderie
            .WithText("Trigger the unit against the target") // only shows if this is an attack effect
            .SubscribeToAfterAllBuildEvent(d =>
            {
                const string explanation = "For whomever this effect is applied, they will trigger against whatever was just hit";
                var data = (StatusEffectApplyXInstant)d;
                data.effectToApply = instance.TryGet<StatusEffectInstantTriggerAgainst>("Trigger Against").FreeModify(t => t.countsAsTrigger = false);
                data.applyToFlags = StatusEffectApplyX.ApplyToFlags.Target;
            })
            ,
            new StatusEffectDataBuilder(instance)
            .Create<StatusEffectApplyXWhenUnitIsHit>("Trigger Against Target Hit By Camaraderie Unit")  //Effect Data for Camaraderie
            .WithText("When a {0} unit attacks, trigger against the target")
            .WithTextInsert("<Camaraderie>")
            .WithIsReaction(true)
            .SubscribeToAfterAllBuildEvent(d =>
            {
                const string explanation = "When a Camaraderie unit (regardless of team) attacks, trigger against its target";
                var data = (StatusEffectApplyXWhenUnitIsHit)d;
                data.descColorHex = "F99C61";   // trigger color
                data.effectToApply = instance.TryGet<StatusEffectData>("Trigger Against");
                data.applyToFlags = StatusEffectApplyX.ApplyToFlags.Target;
                data.doPing = false;

                var constraintNotBeingTriggered = ScriptableObject.CreateInstance<TargetConstraintHasStatus>();
                constraintNotBeingTriggered.status = data.effectToApply;
                constraintNotBeingTriggered.not = true;
                data.applyConstraints = [constraintNotBeingTriggered];

                // Activate effects when ally OR enemy is hit
                data.ally = true;
                data.enemy = true;

                var constraintIsCamaraderie = ScriptableObject.CreateInstance<TargetConstraintHasTrait>();
                constraintIsCamaraderie.trait = instance.TryGet<TraitData>("Camaraderie");

                data.attackerConstraints = [constraintIsCamaraderie];


            })
            ,

            //instance.StatusCopyBoxed<StatusEffectWhileInHandX>("While Active Add Equal Attack To Junk In Hand", "While In Hand Add Equal Attack To Junk In Hand"),

            new BlueBlobble().builder.Patch_ExtraPopups(
                ("Aimless", Left),
                ("Snow", Right)
                )
            ,
            new CardDataBuilder(instance)
        .CreateUnit(name:"IceForge", englishTitle:"Ice Forge", idleAnim:"FloatAnimationProfile")
        .WithCardType("Clunker")
        .WithTitle("冰熔炉", SystemLanguage.ChineseSimplified)
        .WithTitle("冰熔爐", SystemLanguage.ChineseTraditional)
        .WithTitle("얼음 용광로", SystemLanguage.Korean)
        .WithTitle("アイスフォージ", SystemLanguage.Japanese)
        .WithText("While active, add <+{s0}><keyword=attack> to all allies and <-{s1}><keyword=attack> to all enemies", SystemLanguage.English)
        .WithText("在场时，所有友军<+{s0}><keyword=attack>，所有敌人<-{s1}><keyword=attack>", SystemLanguage.ChineseSimplified)
        .WithText("在場時，所有隊友<+{s0}><keyword=attack>，所有敵人<-{s1}><keyword=attack>", SystemLanguage.ChineseTraditional)
        .WithText("전장에 있는 동안, 모든 아군의 <keyword=attack><+{s0}>, 모든 적의 <keyword=attack><-{s1}>", SystemLanguage.Korean)
        .WithText("場にある間、すべての味方に<+{s0}><keyword=attack>を、すべての敵に<-{s1}><keyword=attack>を追加する", SystemLanguage.Japanese)
        .SetStats(null, null, 0)
        .SetSprites("IceForge_mainSprite.png", "IceForge_BG.png")
        .WithValue(190)         // Base gold as an enemy: 4-6
        .SubscribeToAfterAllBuildEvent(data =>
        {
                data.startWithEffects = new CardData.StatusEffectStacks[]
                {
                        new CardData.StatusEffectStacks(instance.Get<StatusEffectData>("While Active Increase Attack To Allies (No Desc)"), 2),
                        new CardData.StatusEffectStacks(instance.Get<StatusEffectData>("While Active Reduce Attack To Enemies (No Ping, No Desc)"), 2),
                        new CardData.StatusEffectStacks(instance.Get<StatusEffectData>("Scrap"), 2),
                };
                data.titleFallback = "Ice Forge";
        }),

            new StatusEffectDataBuilder(instance)
            .Create<StatusEffectInstantPhase>("Instant Next Phase Lump", data =>
            {
                data.nextPhase = instance.Get<CardData>("Lump");
            }),
            new StatusEffectDataBuilder(instance)
            .Create<StatusEffectInstantPhase>("Instant Next Phase SplitBoss2", data =>
            {
                data.nextPhase = instance.Get<CardData>("SplitBoss2");
            })
            ,
            new StatusEffectDataBuilder(instance)
            .Create<StatusEffectRecycleX>("Recycle Naked Gnome", data =>
            {
                data.cardToRecycle = "NakedGnome";
            })
            .WithText("Recycle NakedGnome")
            .Patch_IgnoreSilenced()
            ,
            new StatusEffectDataBuilder(instance)
            .Create<StatusEffectMultiHit>("Frenzy?", data =>
            {

            }).WithText("Has {a} frenzy"),

            new StatusEffectDataBuilder(instance)
                .Create<StatusEffectInstantEat>("healer", s =>
                {
                })
            .WithText("On kill, apply to enemies: instant heal <{a}>"),
            new StatusEffectDataBuilder(instance)
                .Create<StatusEffectInstantEat>("golder", s =>
                {
                })
            .WithText("On kill, apply to enemies: instant heal <{a}>"),
            new StatusEffectDataBuilder(instance)
                .Create<StatusEffectWhenCharmedRunScript>("charmy", s =>
                {
                    s.self = false;
                    s.ally = true;
                    s.applyToSelf = true;
                    s.scripts = [new Scriptable<CardScriptGiveRandomUpgrade>(t => {
                        t.fromPool = false;
                    })];
                    //AddressableLoader.GetGroup<TraitData>(nameof(TraitData)).ForEach(t => t.effects.Do(PatchIgnoreSilence.Patch_IgnoreSilenced));
                })
            .WithText("When another card is charmed, randomly gain an upgrade"),
            new StatusEffectDataBuilder(instance)
                .Create<StatusEffectBlockPlayAction>("action", s =>
                {
                    s.actionsNamesToBlock = [nameof(ActionRedraw)];
                })
            .WithText("When a crowned card is charmed, destroy it"),

            new StatusEffectDataBuilder(instance)
                .Create<StatusEffectApplyXOnKill>("Blobby", s =>
                {
                    s.applyToFlags = StatusEffectApplyX.ApplyToFlags.Target;
                    s.effectToApply = instance.Get<StatusEffectData>("golder");
                    s.targetConstraints = [];
                    s.targetMustBeAlive = false;
                })
            .WithText("On kill, apply to enemies: instant heal <{a}>"),
            new StatusEffectDataBuilder(instance)
            .Create<StatusEffectApplyXWhenAllyIsKilled>("When Ally Is Killed Activate Sacrifice Effects")
            .WithText("When an ally is killed, activate <Sacrifice> effects")
            .SubscribeToAfterAllBuildEvent(d =>
            {
                var data = (StatusEffectApplyXWhenAllyIsKilled)d;
                data.effectToApply = instance.TryGet<StatusEffectData>("Activate Sacrifice Effects For Other Team");
                // imagine the lower line doesn't exist and we're actually using the "good bonescraper" effect
                (data.effectToApply as StatusEffectInstantActivateSacrificeEffects).forOtherTeam = false;
                data.applyToFlags = StatusEffectApplyX.ApplyToFlags.Target;
                data.targetMustBeAlive = false;
            }),
            /*new GameModifierDataBuilder(instance)
            .Create("mody") // test code. you get it
            .WithTitle("")
            .WithDescription("")
            .WithBellSprite(instance.IconSprite)
            .WithDingerSprite(instance.IconSprite)
            .SubscribeToAfterAllBuildEvent(d =>
            {
                foreach (ClassData classData in AddressableLoader.GetGroup<ClassData>("ClassData"))
                {
                    foreach (RewardPool rewardPool in classData.rewardPools)
                    {
                        if (rewardPool == null || rewardPool.list == null)
                            continue;

                        if (rewardPool.name == "GeneralModifierPool" && !rewardPool.list.Contains(d))
                            rewardPool.list.Add(d);
                    }
                }
            })
            ,*/
            new KeywordDataBuilder(instance)
                .Create("DisplayJunk")
                .WithTitle("")
                .WithShow(true)
                .WithShowName(true)
                .WithDescription("<card=TailsTwo>"),

            new StatusEffectDataBuilder(instance)
                .Create<StatusEffectApplyXWhenYAppliedTo>("Sustained by Ink", s =>
                {
                    s.applyToFlags = StatusEffectApplyX.ApplyToFlags.Self;
                    s.effectToApply = instance.Get<StatusEffectData>("golder");
                    s.whenAppliedToFlags = StatusEffectApplyX.ApplyToFlags.Self;
                    s.whenAppliedTypes = ["ink", "shroom"];
                    s.instead = true;
                })
            .WithText($"When inked or shroomed, instead gain {{a}} gold and <keyword={Extensions.PrefixGUID("Display Junk", instance).ToLower()}?"),

            new StatusEffectDataBuilder(instance)
                .Create<StatusEffectApplyXWhenYAppliedTo>("Summon by ink", s =>
                {
                    s.applyToFlags = StatusEffectApplyX.ApplyToFlags.Self;
                    s.effectToApply = instance.Get<StatusEffectData>("Instant Summon TailsFour");
                    s.whenAppliedToFlags = StatusEffectApplyX.ApplyToFlags.Self;
                    s.whenAppliedTypes = ["ink", "shroom"];
                    s.instead = true;

                    s.applyEqualAmount = false;
                })
            .WithText("When inked or shroomed, instead gain {a} gold"),

            new StatusEffectDataBuilder(instance)
              .Create<StatusEffectApplyXOnKill>("On Kill Enemy (Snowed) Apply Their Snow To RandomEnemy")
              .WithStackable(true)
              .WithCanBeBoosted(false)
              .SubscribeToAfterAllBuildEvent(d =>
              {
                    var data = (StatusEffectApplyXOnKill)d;
                    data.effectToApply = instance.TryGet<StatusEffectData>("Snow");
                    data.applyConstraints = new TargetConstraint[]
                    {
                      new Scriptable<TargetConstraintOnBoard>(),
                      new Scriptable<TargetConstraintIsAlive>(),
                    };
                    data.applyEqualAmount = true;
                    data.contextEqualAmount = new Scriptable<ScriptableCurrentStatus>(t =>
                    {
                      t.statusType = "snow";
                    });
                    data.applyToFlags = StatusEffectApplyX.ApplyToFlags.RandomEnemy;
                    data.queue = true;
                    data.noTargetType = NoTargetType.NoTargetForStatus;
                    data.noTargetTypeArgs = new string[]
                    {
                      "<sprite name=snow>",
                    };
              })];

        public class CardScriptGiveRandomUpgrade : CardScript
        {
            public bool fromPool = false;
            [ShowIf(nameof(fromPool))]
            public CardUpgradeData[] upgradePool;


            [HideIf(nameof(fromPool))]
            public int? minTier = 0;
            public int? maxTier = null;

            public CardUpgradeData.Type ofType = CardUpgradeData.Type.Charm;
            public string[] illegalUpgrades = ["CardUpgradeMuncher", "CardUpgradeEffigy"];

            public override void Run(CardData target)
            {
                IEnumerable<CardUpgradeData> possibleUpgrades = [];
                if (fromPool)
                {
                    possibleUpgrades = upgradePool?.Where(u => u.CanAssign(target));
                }
                else
                {
                    possibleUpgrades = AddressableLoader.GetGroup<CardUpgradeData>(nameof(CardUpgradeData))
                        .Where(u
                        => u.type == ofType 
                        && (!minTier.HasValue || u.tier >= minTier)
                        && (!maxTier.HasValue || u.tier <= maxTier)
                        && !(illegalUpgrades == null && illegalUpgrades.Contains(u.name))
                        );
                }

                if (possibleUpgrades == null)
                    return;

                Entity targetedEntity = GameObject.FindObjectsOfType<Entity>().FirstOrDefault(e => e.data == target);
                CardUpgradeData chosenUpgrade = possibleUpgrades.InRandomOrder().First().Clone();

                if (targetedEntity != null)
                    chosenUpgrade.Assign(targetedEntity);
                else chosenUpgrade.Assign(target);
                _ = typeof(AssetReference);
                new AssetReference("Assets/Content/Campaign/Presets/preset1 press demo.txt");
                new AssetReferenceGameObject("Assets/Content/Campaign/Presets/preset1 press demo.txt");
            }
        }

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

        public class StatusEffectBlockPlayAction : StatusEffectData
        {
            public string[] actionsNamesToBlock = new string[0];
            private Type[] actionsTypesToBlock => actionsNamesToBlock.Select(AccessTools.TypeByName).ToArray();


            public override void Init()
            {
                Events.OnCheckAction += CheckAction;
            }
            public void OnDestroy()
            {
                Events.OnCheckAction -= CheckAction;
            }

            public void CheckAction(ref PlayAction action, ref bool allowed)
            {
                Debug.LogWarning(action);
                if (actionsNamesToBlock == null)
                    return;

                Debug.LogWarning(actionsNamesToBlock.Length);
                if (actionsNamesToBlock.Any())
                    Debug.LogWarning(actionsNamesToBlock.Join());

                foreach (var name in actionsNamesToBlock)
                {
                    Debug.LogWarning("THIS IS " + name);
                    Type type = AccessTools.TypeByName(name);

                    if (type != null && type.IsAssignableFrom(action.GetType()))
                    {
                        Debug.LogError("WE GOTEM");
                        allowed = false;
                    }
                }

                Debug.LogError("ACTION IS " + allowed);
            }

        }

        public override List<T> AddAssets<T, Y>()
        {
            if (assets.OfType<T>().Any())
                this.Log($"adding {typeof(Y).Name}s: {assets.OfType<T>().Select(a => a._data.name).Join()}");
            return assets.OfType<T>().ToList();
        }

        public class UnreleasedAttribute : Attribute { }
    }
}


