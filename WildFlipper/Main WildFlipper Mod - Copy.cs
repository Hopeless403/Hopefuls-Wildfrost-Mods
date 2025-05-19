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
using UnityEngine.EventSystems;
using System.Threading.Tasks;
using WildfrostHopeMod.Utils;
using Extensions = Deadpan.Enums.Engine.Components.Modding.Extensions;
using UnityEngine.AddressableAssets;


namespace WildFlipper
{
    public partial class WildFlipperMod : WildfrostMod
    {
        
        
        // it should be named this to show up as a Singleton in UnityExplorer
        public static WildFlipperMod instance;
        public WildFlipperMod(string modDirectory) : base(modDirectory)
        {
            instance = this;
        }
        
        public override string GUID => "hope.wildfrost.wildflipper";
        public override string[] Depends => new string[] { 
            //"hope.wildfrost.vfx" 
        };
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


        public static List<T> GetGroup<T>() where T : DataFile
        {
            return AddressableLoader.GetGroup<T>(typeof(T).Name);
        }

        public GameObject SystemsParent => ScreenSystem.instance?.gameObject;
        public static string CatalogFolder => Path.Combine(instance.ModDirectory, "Catalog");
        public static string CatalogPath => Path.Combine(CatalogFolder, "catalog.json");



        public override void Load()
        {
            /*if (!Addressables.ResourceLocators.Any(r => r is ResourceLocationMap map && map.LocatorId == CatalogPath))
                Addressables.LoadContentCatalogAsync(CatalogPath).WaitForCompletion();
            var prefab = GetAsset<GameObject>("Assets/___ EXTERNAL/Event-Companion.prefab");
            Debug.LogWarning(prefab);
            if (prefab)
            {
                var comp = GetGroup<CampaignNodeType>().OfType<CampaignNodeTypeCompanion>().FirstOrDefault();
                comp.routinePrefabRef = new AssetReferenceGameObject("Assets/___ EXTERNAL/Event-Companion.prefab");
            }
            prefab = GetAsset<GameObject>("Assets/___ EXTERNAL/Event-CopyItem.prefab");
            Debug.LogWarning(prefab);
            if (prefab)
            {
                Debug.LogWarning(new EventReference().Guid.ToString());
                var comp = GetGroup<CampaignNodeType>().OfType<CampaignNodeTypeCopyItem>().FirstOrDefault();
                //comp.routinePrefabRef = new AssetReferenceGameObject("Assets/___ EXTERNAL/Event-CopyItem.prefab");
            }

            var unlocks = GetGroup<UnlockData>();
            var rewards = GetGroup<ChallengeData>().Select(c => c.reward);
            foreach (var u in unlocks.Except(rewards))
            {
                Debug.LogError($"Missing unlock: {u}");
            }

            foreach (var u in rewards.Except(unlocks))
            {
                Debug.Log($"Missing reward: {u}");
            }

            List<string> res = [];
            string Localize(LocalizedString key)
            {
                return !key?.IsEmpty ?? false ? key.GetLocalizedString() : "";
            }
            foreach (var c in GetGroup<ChallengeData>())
            {
                res.Add($"{c.name}\t" +
                    $"{Localize(c.titleKey)}\t" +
                    $"{Localize(c.textKey)}\t" +
                    $"{c.requires.Join(cc => cc.name)}\t" +
                    //$"{Localize(c.rewardKey)}\t" + // "New Charm Unlocked!" etc
                    $"{c.reward.name}\t" +
                    //$"{c.reward.active}\t" +
                        /// Note: the other activeInX are literally unused
                    $"{c.reward.requires.Join(cc => cc.name)}\t" + // Unlocks require their related building to be finished
                    $"{c.hidden}\t" + // 1. ChallengeStones show "???"; 2. ChallengeList won't show it in progress
                    $"{c.goal}\t" + // Usually 1, indicating if it's done or not
                    $"{c.listener}");
            }*/
            //GUIUtility.systemCopyBuffer = res.Join(delimiter: "\n");
            //Cursor.SetCursor();

            var system = ScreenSystem.instance?.gameObject.GetOrAdd<BiggerBoardSystem>();
            if (system)
            {
                system.enabled = true;
                system.targetRowCount = 3;
                system.targetSlotCount = 5;
                //system.tryResizing = true;
                system.debugColours = ModDirectory.Contains(Application.streamingAssetsPath);
            }

            int dir = -1;
            Vector2 range = new Vector2(0, 10);
            for (int i = 4; range.InRange(i); i += dir)
            {
                //Debug.LogWarning(i);
                //dir = Dead.PettyRandom.Sign();
            }

            _ = nameof(IReadOnlyList<CardData>);
            //WildFlipperModHelpers.InitAssets();
            _ = typeof(Battle);
            base.Load();
            
            //assets.Add(StatusCopyBoxed<StatusEffectWhileInHandX>("While Active Add Equal Attack To Junk In Hand", "While In Hand Add Equal Attack To Junk In Hand"));

            //Events.OnEntityCreated += ChangeSprite;
            //Events.OnSceneChanged += AddAbilityTargets;
            Events.OnBattleStateBuilt += ChangeRedraw;

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
            var system = ScreenSystem.instance?.gameObject.GetComponents<GameSystem>().FirstOrDefault(g => g.name == nameof(BiggerBoardSystem));
            if (system)
                system.enabled = false;

            base.Unload();
            behaviour.DestroyImmediate();
            //Events.OnEntityCreated -= ChangeSprite;
            //Events.OnSceneChanged -= AddAbilityTargets;
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


        public override List<T> AddAssets<T, Y>()
        {
            //Debug.LogWarning("Requesting type of " + typeof(Y).Name);
            //Debug.Log(assets.Join());
            if (assets.OfType<T>().Any())
                this.Log($"adding {typeof(Y).Name}s: {assets.OfType<T>().Select(a => a._data.name).Join()}");
            return assets.OfType<T>().ToList();
        }

        public class UnreleasedAttribute : Attribute { }
    }
}


