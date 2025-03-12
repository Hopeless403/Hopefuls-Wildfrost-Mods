using Deadpan.Enums.Engine.Components.Modding;
using FMODUnity;
using HarmonyLib;
using JetBrains.Annotations;
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
using NexPlugin;
using Steamworks;
using System.Collections;
using UnityEngine.EventSystems;
using System.Threading.Tasks;


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



        public Dictionary<CardData, CardData[]> leaderDeck = [];
        public Dictionary<CardData, CardData[]> leaderReserve = [];



        [HarmonyPatch(typeof(CampaignPopulator), nameof(CampaignPopulator.Populate))]
        public static class PatchPopulator
        {
            public static IEnumerator Postfix(IEnumerator original)
            {
                var poolsToFix = (References.PlayerData.classData, References.PlayerData.classData.rewardPools.Clone());
                if (References.PlayerData?.classData.ModAdded != instance)
                {
                    Debug.LogWarning("Adding custom pools!");
                    if (References.LeaderData.original == instance.TryGet<CardData>("artemys.wildfrost.frostknights.closure"))
                    {
                        var unitPool = new Scriptable<RewardPool>(pool =>
                        {
                            pool.type = "Units";
                            pool.list = instance.DataList<CardData>(
                            "NakedGnomeFriendly",
                            "NakedGnomeFriendly",
                            "NakedGnomeFriendly",
                            "NakedGnomeFriendly",
                            "NakedGnomeFriendly",
                            "NakedGnomeFriendly").Select(c => c.Clone() as DataFile).ToList();
                        });

                        References.PlayerData.classData.rewardPools = new RewardPool[]
                        {
                            unitPool,
                            //Extensions.GetRewardPool("GeneralUnitPool"),
                            Extensions.GetRewardPool("GeneralItemPool"),
                            Extensions.GetRewardPool("GeneralCharmPool"),
                            Extensions.GetRewardPool("GeneralModifierPool"),
                            //Extensions.GetRewardPool("SnowUnitPool"),
                            Extensions.GetRewardPool("SnowItemPool"),
                            Extensions.GetRewardPool("SnowCharmPool"),
                        };
                    }
                }

                yield return original;

                poolsToFix.classData.rewardPools = poolsToFix.Item2 as RewardPool[];
            }
        }

        public (ClassData, RewardPool[]) poolsToFix = (null, null);
        public void PreCampaignPopulate()
        {
            
            // Only applies if the selected tribe is from this mod
            if (References.PlayerData?.classData.ModAdded == this)
                return;
            poolsToFix = (References.PlayerData.classData, References.PlayerData.classData.rewardPools);

            if (References.LeaderData.original == Get<CardData>("artemys.wildfrost.frostknights.closure"))
            {
                var unitPool = new Scriptable<RewardPool>(pool =>
                {
                    pool.type = "Units";
                    pool.list = DataList<CardData>(
                    "NakedGnomeFriendly",
                    "NakedGnomeFriendly",
                    "NakedGnomeFriendly",
                    "NakedGnomeFriendly",
                    "NakedGnomeFriendly",
                    "NakedGnomeFriendly").Select(c => c.Clone() as DataFile).ToList();
                });

                References.PlayerData.classData.rewardPools = new RewardPool[]
                {
                    unitPool,
                    //Extensions.GetRewardPool("GeneralUnitPool"),
                    Extensions.GetRewardPool("GeneralItemPool"),
                    Extensions.GetRewardPool("GeneralCharmPool"),
                    Extensions.GetRewardPool("GeneralModifierPool"),
                    //Extensions.GetRewardPool("SnowUnitPool"),
                    Extensions.GetRewardPool("SnowItemPool"),
                    Extensions.GetRewardPool("SnowCharmPool"),
                };
            }
        }
        public void ResetPoolsOnCampaignGenerated()
        {
            // Only applies if the selected tribe is from this mod
            if (References.PlayerData?.classData.ModAdded != this)
                return;

            if (References.LeaderData.original == Get<CardData>("artemys.wildfrost.frostknights.closure"))
            {
                var unitPool = new Scriptable<RewardPool>(pool =>
                {
                    pool.type = "Units";
                    pool.list = DataList<CardData>(
                    "NakedGnomeFriendly",
                    "NakedGnomeFriendly",
                    "NakedGnomeFriendly",
                    "NakedGnomeFriendly",
                    "NakedGnomeFriendly",
                    "NakedGnomeFriendly").Select(c => c.Clone() as DataFile).ToList();
                });

                References.PlayerData.classData.rewardPools = new RewardPool[]
                {
                    unitPool,
                    //Extensions.GetRewardPool("GeneralUnitPool"),
                    Extensions.GetRewardPool("GeneralItemPool"),
                    Extensions.GetRewardPool("GeneralCharmPool"),
                    Extensions.GetRewardPool("GeneralModifierPool"),
                    //Extensions.GetRewardPool("SnowUnitPool"),
                    Extensions.GetRewardPool("SnowItemPool"),
                    Extensions.GetRewardPool("SnowCharmPool"),
                };
            }
        }
        public override void Load()
        {
            int dir = -1;
            Vector2 range = new Vector2(0, 10);
            for (int i = 4; range.InRange(i); i += dir)
            {
                Debug.LogWarning(i);
                //dir = Dead.PettyRandom.Sign();
            }

            _ = nameof(IReadOnlyList<CardData>);
            WildFlipperModHelpers.
                        InitAssets();

            base.Load();
            

            //assets.Add(StatusCopyBoxed<StatusEffectWhileInHandX>("While Active Add Equal Attack To Junk In Hand", "While In Hand Add Equal Attack To Junk In Hand"));

            //Events.OnEntityCreated += ChangeSprite;
            Events.OnSceneChanged += AddAbilityTargets;
            Events.OnBattleStateBuilt += ChangeRedraw;
            Events.OnPreCampaignPopulate += PreCampaignPopulate;

        }
        private T[] DataList<T>(params string[] names) where T : DataFile => names.Select(TryGet<T>).ToArray();
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
            Events.OnPreCampaignPopulate -= PreCampaignPopulate;
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
        internal T TryGet<T>(string name) where T : DataFile
        {
            T data;
            if (typeof(StatusEffectData).IsAssignableFrom(typeof(T)))
            {
                data = base.Get<StatusEffectData>(name) as T;
            }

            else if (typeof(KeywordData).IsAssignableFrom(typeof(T)))
            {
                string assetName = Extensions.PrefixGUID(name, this).ToLower();
                data = AddressableLoader.Get<KeywordData>(nameof(KeywordData), assetName) as T 
                    ?? base.Get<KeywordData>(name.ToLower()) as T;
            }
            else
            {
                data = base.Get<T>(name);
            }

            if (data == null)
                Debug.LogError($"TryGet Error: Could not find a [{typeof(T).Name}] with the name [{name}] or [{Extensions.PrefixGUID(name, this)}]");
                //throw new Exception($"TryGet Error: Could not find a [{typeof(T).Name}] with the name [{name}] or [{Extensions.PrefixGUID(name, this)}]");

            return data;
        }
        public void Log(object message) => Debug.Log($"[{Title}] {message}");
        public void LogWarning(object message) => Debug.LogWarning($"[{Title} Warning] {message}");
        public void LogError(object message) => Debug.LogError($"[{Title} Error] {message}");

        


        public static List<object> assets = new List<object>();

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

        public override List<T> AddAssets<T, Y>()
        {
            if (assets.OfType<T>().Any())
                this.Log($"adding {typeof(Y).Name}s: {assets.OfType<T>().Select(a => a._data.name).Join()}");
            return assets.OfType<T>().ToList();
        }

        public class UnreleasedAttribute : Attribute { }
    }
}


