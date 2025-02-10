using Deadpan.Enums.Engine.Components.Modding;
using FMODUnity;
using HarmonyLib;
using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
using static AvatarPart;
using _ = UnityEngine.UIElements;

namespace WildfrostHopeMod.Fashion
{
    public class FashionMod : WildfrostMod
    {
        public static FashionMod Mod;
        public FashionMod(string modDirectory) : base(modDirectory)
        {
            Mod = this;
        }
        public override string GUID => "hope.wildfrost.fashion";
        public override string[] Depends => new string[] { };
        public override string Title => "Fashion Leaders";
        public override string Description => "... are influential people who introduce new styles which spread throughout fashion culture and become part of fashion. - Wikipedia";
        public override TMP_SpriteAsset SpriteAsset => base.SpriteAsset;
        public static GameObject behaviour;

        public override void Load()
        {

            base.Load();

            behaviour = new GameObject("FashionModBehaviour");
            GameObject.DontDestroyOnLoad(behaviour);
            behaviour.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset |
                                  HideFlags.HideInInspector | HideFlags.NotEditable;

            var e = behaviour.AddComponent<FashionModBehaviour>();
            Debug.LogWarning(Resources.FindObjectsOfTypeAll<GameUpdateDisplayer>().Any());
            behaviour.AddComponent<FashionLeaderSequence>();
        }

        public override void Unload()
        {
            base.Unload();
            GameObject.Destroy(behaviour);
            behaviour = null;
        }

        public static void Randomise(string args = "")
        {
            var entity = Console.hover;
            Leader image;
            string part = "";
            if (!entity || entity.data.cardType.name != "Leader" || !(image = (entity.display as Card).scriptableImage as Leader))
                Debug.LogWarning("You must hover over a card to use this command");
            else
            {
                var script = entity.data.createScripts.First(c => c is CardScriptLeader) as CardScriptLeader;
                if (entity.data.TryGetCustomData("CharacterData", out CharacterData data, null))
                {
                    var profile = script.leaderProfileOptions.RandomItem();
                    var charType = script.characterTypeOptions.RandomItem();
                    profile.Apply(charType);
                    data.Randomize(script.characterTypeOptions.FirstOrDefault());
                    profile.UnApply(charType);
                    entity.data.SetCustomData("CharacterData", data);
                    image.avatar.UpdateDisplay(data);
                    if (Campaign.instance)
                        SaveSystem.SaveCampaignData(Campaign.Data.GameMode, "data", Campaign.instance.Save());
                }
                else
                    Debug.LogWarning($"Entity [{entity.name}] has no CharacterData");
            }
        }
    }

    [HarmonyPatch]
    static class AddFashionButton
    {
        internal static GameObject renameButton = null;
        internal static RenameCompanionSequence renameSeq = null;
        internal static GameObject fashionButton;
        public static bool ready => fashionButton;

        [HarmonyPostfix]
        [HarmonyPatch(typeof(DeckSelectSequence), nameof(DeckSelectSequence.SetEntity))]
        static void Deck(DeckSelectSequence __instance, Entity entity, bool canRename)
        {
            fashionButton = __instance.renameButton.transform.parent.Find("Hope.Fashion")?.gameObject;
            renameButton = __instance.renameButton;
            renameSeq ??= __instance.renameSequence;
            if (!fashionButton && renameButton)
            {
                fashionButton = GameObject.Instantiate(__instance.renameButton, __instance.renameButton.transform.parent);
                fashionButton.name = "Hope.Fashion";

                var button = fashionButton.GetComponentInChildren<Button>();
                button.onClick = new Button.ButtonClickedEvent();
                button.onClick.AddListener(() => Debug.LogWarning("ay who pressed me"));

                var image = button.GetComponent<Image>();
                image.sprite = FashionMod.Mod.IconSprite;
                image.color = image.color.With(0.8f);
            }
            fashionButton.SetActive(entity && entity.data.createScripts.Any(c => c is CardScriptLeader) && canRename);
        }

        [HarmonyPrefix]
        [HarmonyPatch(typeof(InspectNewUnitSequence), nameof(InspectNewUnitSequence.SetUnit), [typeof(Entity), typeof(bool)])]
        static void Inspect(InspectNewUnitSequence __instance, Entity unit, bool updateGreeting)
        {
            fashionButton = __instance.transform.Find("Hope.Fashion")?.gameObject; 
            renameButton = __instance.transform.Find("Rename Button").gameObject;
            renameSeq ??= __instance.renameSequence;
            if (!fashionButton && renameButton)
            {
                fashionButton = GameObject.Instantiate(renameButton, renameButton.transform.parent);
                fashionButton.name = "Hope.Fashion";

                //__instance.transform.Find("AnchorLayout/RenameButtonAnchor")
                //    .SetLocalY(renameButton.transform.localPosition.y + 0.5f*(renameButton.transform as RectTransform).GetHeight());
                fashionButton.transform.SetLocalY(renameButton.transform.localPosition.y - (renameButton.transform as RectTransform).GetHeight());
                //renameButton.transform.SetLocalY(renameButton.transform.localPosition.y + 0.5f*(renameButton.transform as RectTransform).GetHeight());
                
                var copy = fashionButton.AddComponent<CopyRectTransform>();
                copy.copyPosition = false;
                copy.target = renameButton.transform as RectTransform;

                var button = fashionButton.GetComponentInChildren<Button>();
                button.onClick = new Button.ButtonClickedEvent();
                button.onClick.AddListener(() => Debug.LogWarning("ay who pressed me"));

                var image = button.GetComponent<Image>();
                image.sprite = FashionMod.Mod.IconSprite;
                image.color = image.color.With(0.8f);
            }
            fashionButton.gameObject.SetActive(unit && unit.data.createScripts.Any(c => c is CardScriptLeader));
        }
    }

    public class FashionModBehaviour : MonoBehaviour
    {
        [UsedImplicitly]
        void Start() => StartCoroutine(Initialise());

        static Transform parent;
        static Transform scrollView;
        internal static RectTransform content;
        internal static JournalTab journalTab;
        internal static JournalCardDisplay inspector;
        static Scroller scroller => content?.GetComponent<Scroller>();
        public static JournalCard prefab;
        public static Button tabPrefab;
        public static readonly List<string> parts = new()
        {
            "Body",
            "Head",
            "Weapon1",
            "Weapon2",
            "Eyes",
            "Eyebrows",
            "Mouth",
            "Nose", // actually includes beard
            "Ears",
            //"HairTop", // unused?
            "HairBack",
            //"Beard", // included with nose
            /*"HairColour",
            "EyeColour",
            "SkinColour",
            "ClothingColour",
            "MarkingColour"*/
        };
        static IEnumerator Initialise()
        {
            // Find the template JournalCardManager
            yield return new WaitUntil(() => Resources.FindObjectsOfTypeAll<JournalCardManager>().Any());
            var manager = Resources.FindObjectsOfTypeAll<JournalCardManager>().First();

            // Create a copy of the Journal Page
            parent = Instantiate(manager.transform, manager.transform.parent);
            parent.name = "Hope.Fashion";

            scrollView = parent.Find("Scroll View");
            (scrollView as RectTransform).SetSize(6.75f, 7); // REMINDER: Adjust this for the actual thing?
                                                             // REMINDER: This and others use center pivot
            content = scrollView.Find("Viewport/Content") as RectTransform;
            content.DestroyAllChildren();

            // Prepare display prefab
            prefab = Instantiate(manager.cardPrefab, FashionMod.behaviour.transform);
            prefab.nameText.transform.parent.gameObject.SetActive(false); // remove name tag
            prefab.frame.rectTransform.localPosition = Vector3.zero;
            prefab.frame.rectTransform.SetScaleY(1.1f);

            prefab.image.rectTransform.SetSize(0.6f * prefab.frame.rectTransform.GetSize());
            prefab.image.rectTransform.localPosition = new Vector2(0, 0.5f);
            prefab.image.material = prefab.discoveredMaterial;
            prefab.image.color = Color.white;

            // Fix the cutoff at the top (no float Padding rip)
            // REMINDER: Use for HopefulQoL to fix the regular journal?
            prefab.transform.GetAllChildren().Update(t => t.LeanSetLocalPosY(t.localPosition.y - 0.04f)); // use 0.06 for actual cards

            // Prepare tab prefab
            tabPrefab = Instantiate(manager.tabs[1], FashionMod.behaviour.transform);
            tabPrefab.onClick = new();
            tabPrefab.onClick.AddListener(tabPrefab.GetComponent<SfxOneshot>().Fire);

            Transform tabNameTag = Instantiate(manager.cardPrefab.nameText.transform.parent.gameObject, tabPrefab.transform).transform;
            //tabNameTag.name = "Name Tag";
            tabNameTag.SetLocalY(-0.25f);
            tabNameTag.SetScaleX(0.6f);
            tabNameTag.GetAllChildren().Update(t => t.SetScaleX(1 / 0.6f));

            // Create tabs
            // TEMPORARY: Done in journal
            yield return CreateJournalPage();
        }

        private static IEnumerator CreateJournalPage()
        {
            // Use Enemy Card Manager as template
            yield return new WaitUntil(() => Resources.FindObjectsOfTypeAll<JournalTab>().Any(t => t.name == "TabEnemyCards"));
            var journalTabTemplate = Resources.FindObjectsOfTypeAll<JournalTab>().First(t => t.name == "TabEnemyCards");
            journalTab = Instantiate(journalTabTemplate, journalTabTemplate.transform.parent);
            journalTab.transform.SetSiblingIndex(journalTabTemplate.transform.GetSiblingIndex());
            journalTab.transform.Find("Tweener/Selected/Image").GetComponent<Image>().sprite = FashionMod.Mod.IconSprite;
            var tabImage = journalTab.transform.Find("Tweener/NotSelected/Image").GetComponent<Image>();
            tabImage.sprite = FashionMod.Mod.IconSprite;
            tabImage.color = tabImage.color.WithAlpha(0.8f);

            JournalPageMenu journalPage = parent.GetComponent<JournalPageMenu>();
            inspector = journalPage.alsoOpen.GetComponentInChildren<JournalCardDisplay>();
            CardData leader = AddressableLoader.GetCardDataClone("Leader_Tutorial1");

            journalTab.onSelect = new();
            journalTab.onSelect.AddListener(journalPage.Open);
            journalTab.onSelect.AddListener(() => {
                inspector.Display(leader);
                //(inspector.current.scriptableImage as Leader).AssignEvent();
                });

            CreateTabs(parent);
            CreatePart(parts.RandomItem());

            
        }

        public static void CreateTabs(Transform parent)
        {
            Transform tabs = parent.Find("Tabs");
            tabs.DestroyAllChildren();
            foreach (var part in parts)
            {
                Button tab = Instantiate(tabPrefab, tabs);
                if (TryCreateSprite(part.ToLower(), out var sprite))
                {
                    var image = tab.transform.Find("Image").GetComponent<Image>();
                    image.sprite = sprite;
                    (image.transform as RectTransform).sizeDelta = new Vector2(2.5f, 2.5f);
                }
                tab.onClick.AddListener(() => CreatePart(part));
                tab.GetComponentInChildren<TextMeshProUGUI>().text = part;
                //tab.transform.Find("Name Tag")?.SetLocalY(-0.25f);
            } //(tabs as RectTransform).LeanSetPosX(0);
            if (Resources.FindObjectsOfTypeAll<Journal>().Any())
            {
                var journal = Resources.FindObjectsOfTypeAll<Journal>().First();
                (tabs as RectTransform).LeanSetPosX((journal.transform as RectTransform).rect.center.x);
            }
        }

        public static void CreatePart(string part)
        {
            var source = new List<Sprite>()
            .Union(AssetLoader.GetList<CharacterType>("CharacterTypes")
                .SelectMany(c => c.sprites.Where(s => s.name == part).SelectMany(c => c.collection.weightedList.Select(l => l.value)))
                .ToLookup(g => g.name).Select(l => l.First())
                .Distinct())
            .Union(AssetLoader.GetList<CharacterType>("CharacterTypes")
                .SelectMany(c => c.prefabs.Where(s => s.name == part).SelectMany(c => c.collection.weightedList.Select(l => l.value)))
                .ToLookup(g => g.name).Select(l => l.First())
                .Select(p => p.transform.Find("HeadImage")?.GetComponent<Image>().sprite ?? p.GetComponent<Image>().sprite))
            /*.Union(Resources.FindObjectsOfTypeAll<CardScriptLeader>().SelectMany(cs => cs.leaderProfileOptions)
                .SelectMany(c => c.backgroundPool.weightedList.Select(l => l.value))
                .ToLookup(g => g.name).Select(l => l.First()))*/
            ;
            CoroutineManager.Start(CreateFromSource(source));
        }

        public static IEnumerator CreateFromSource(IEnumerable<Sprite> source)
        {
            content.DestroyAllChildren();
            foreach (var sprite in source)
            {
                bool resize = true;
                JournalCard current = Instantiate(prefab, content);
                current.name = sprite.name;
                current.image.sprite = sprite;
                /*current.background.sprite = sprite; 
                current.background.enabled = true; current.image.enabled = false;*/
                if (resize)
                {
                    current.image.sprite = Sprite.Create(sprite.texture, sprite.textureRect, sprite.pivot, sprite.pixelsPerUnit, 0, SpriteMeshType.FullRect);
                    current.image.sprite.name = sprite.name; // for easier identification with UE
                    current.image.rectTransform.SetSize(0.6f * current.image.rectTransform.GetSize());
                    /*var spriteRect = sprite.textureRect;
                    float aspectRatio = Mathf.Min(spriteRect.width, spriteRect.height) / Mathf.Max(spriteRect.width, spriteRect.height);
                    //current.image.rectTransform.SetSize(0.6f * aspectRatio * current.frame.rectTransform.GetSize());*/
                }

                // TEMPORARY: Will need to deal with PicrewSequence or wtv
                // This needs to be on the button since it won't get transferred on Instantiation
                var pauseMenu = GameObject.FindObjectOfType<PauseMenu>(true);
                //current.button.onClick.AddListener(pauseMenu.Close);
                current.button.onClick.AddListener(() =>
                {
                    var charData = inspector.current.entity.data.customData.Get<CharacterData>("CharacterData");
                    Debug.LogWarning(sprite);
                });
            }
            yield return new WaitForEndOfFrame();
            scroller.ScrollTo(0);
        }

        public static void UpdateLeaderDisplay(CharacterType type, string part, int index)
        {
            if (!inspector?.current?.entity?.display)
                return;
            var display = inspector.current.entity.display as Card;
            (display.scriptableImage as Leader).AssignEvent();
        }







        static bool TryCreateSprite(string name, out Sprite s)
        {
            s = null;
            if (string.IsNullOrEmpty(name) || !File.Exists(FashionMod.Mod.ImagePath(name + ".png")))
                return false;
            Texture2D t = FashionMod.Mod.ImagePath(name + ".png").ToTex();
            s = Sprite.Create(t, new Rect(0, 0, t.width, t.height), new Vector2(0.5f, 0.5f), 100, 0, SpriteMeshType.FullRect);
            return s;
        }

        void Update()
        {
            if (Input.GetKey(KeyCode.LeftAlt))
            {
                FashionMod.Randomise();

            }

            if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.T))
            {
                var item = parts.RandomItem();
                Debug.LogWarning("Starting: " + item);
                //StartCoroutine(Insantiate());
                CreatePart(item);
                tabPrefab.GetComponentInChildren<TextMeshProUGUI>().text = item;
                HelpPanelSystem.AddButton(HelpPanelSystem.ButtonType.Negative, (AddressableLoader.groups["CardData"].list.Where(l => ((CardData)l).titleKey != null).ToList().RandomItem() as CardData).titleKey, "Inspect", () => Debug.LogWarning("ouch"));
                HelpPanelSystem.Show((AddressableLoader.groups["CardData"].list.RandomItem() as CardData).titleKey);
                HelpPanelSystem.instance.buttonGroup.GetComponentInChildren<Image>().color = Color.black;
            }
        }
    }
}