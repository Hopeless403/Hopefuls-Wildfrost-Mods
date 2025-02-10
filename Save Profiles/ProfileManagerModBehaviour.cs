using Deadpan.Enums.Engine.Components.Modding;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;
using UnityEngine.Localization.Components;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace WildfrostHopeMod.ProfileManager
{
    public partial class ProfileManagerModBehaviour : MonoBehaviour
    {
        public static bool editing = false;
        public static bool promptToggleEditor = false;
        public static GameObject buttonGroup = null;
        public static TextMeshProUGUI textAsset = null;
        public static GameObject editButtonPrefab = null;
        internal void Start() => StartCoroutine(Initialize());
        public static void OnProfileChanged() => textAsset?.SetText("Profile: " + SaveSystem.Profile);

        /// <summary>
        /// Create prefabs and keep in the behaviour object
        /// </summary>
        public IEnumerator Initialize()
        {
            yield return new WaitUntil(() => SceneManager.IsLoaded("MainMenu"));
            if (GameObject.Find("Canvas/Safe Area/TopButtons")) yield break;

            buttonGroup = GameObject.Find("Canvas/Safe Area/BottomButtons");
            buttonGroup = GameObject.Instantiate(buttonGroup, buttonGroup.transform.position.WithY(4.5f), Quaternion.identity, ProfileManagerMod.uiItems);
            buttonGroup.name = "TopButtons";

            buttonGroup.transform.GetAllChildren().Update(t =>
            {
                if (t.name != "Card Viewer Button")
                    t.gameObject.SetActive(false);
                else
                {
                    t.GetComponent<DisableForReleaseBuild>().Destroy();
                    t.gameObject.SetActive(true);

                    var button = t.Find("Animator/Button").GetComponent<Button>();
                    button.onClick = new();

                    var textObject = new GameObject("Text", typeof(RectTransform), typeof(CanvasRenderer), typeof(TextMeshProUGUI));
                    textObject.transform.SetParent(buttonGroup.transform);
                    textObject.transform.localScale = Vector3.one;

                    var textAsset = textObject.GetOrAdd<TextMeshProUGUI>();
                    textAsset.text = "Profile: " + SaveSystem.Profile;
                    textAsset.alignment = TextAlignmentOptions.Center;
                    textAsset.enableAutoSizing = true;
                }
            });

            editButtonPrefab = Instantiate(GameObject.FindObjectOfType<MainMenu>().modsButton, ProfileManagerMod.uiItems);
            var button = editButtonPrefab.transform.Find("Animator/Button").GetComponent<Button>();
            button.onClick = new();
            var textAsset = button.GetComponentInChildren<TextMeshProUGUI>();
            textAsset.transform.SetLocalX(0.2f);
            textAsset.text = "Edit";
            textAsset.gameObject.GetComponents<Component>()
                .Update(c =>
                {
                    if (c is FontSetter || c is LocalizeActionString)
                        c.Destroy();
                });

            #region editor buttons
            buttonPrefab = Instantiate(Addressables.LoadAssetAsync<GameObject>("Event-Item").WaitForCompletion()
                .GetComponent<ItemEventRoutine>().skipButton.transform.parent.parent as RectTransform, ProfileManagerMod.uiItems);
            buttonPrefab.gameObject.GetOrAdd<LayoutLink>().enabled = false;
            buttonPrefab.gameObject.GetOrAdd<LinkEnable>().enabled = false;
            //buttonPrefab.gameObject.GetComponent<TweenUI>().enabled = true ? true : false;

            var fitter = buttonPrefab.GetComponentInChildren<TextMeshProUGUI>().gameObject.GetOrAdd<TextFitter>();
            fitter.transforms = [buttonPrefab.transform as RectTransform];

            var textAsset2 = buttonPrefab.Find("Animator/Button").GetComponentInChildren<TextMeshProUGUI>();
            textAsset2.gameObject.GetOrAdd<LocalizeStringEvent>().enabled = false;
            textAsset2.text = "Button";
            textAsset2.maskable = true;
            yield return fitter.FitRoutine();

            var image = buttonPrefab.Find("Animator/Button").GetComponent<Image>();
            image.material = image.defaultMaterial;
            image.maskable = true;

            buttonPrefab.GetComponentInChildren<ButtonAnimator>().interactable = true;
            buttonPrefab.gameObject.SetActive(true);
            #endregion

            OnSceneChanged(SceneManager.GetActive());
            yield break;
        }
        /// <summary>
        /// Creates the actual buttons on the menu
        /// </summary>
        public static void OnSceneChanged(Scene scene)
        {
            if (scene.name != "MainMenu" || !buttonGroup) return;
            Transform bottomButtons = GameObject.Find("Canvas/Safe Area/BottomButtons").transform;
            var buttonGroup2 = GameObject.Instantiate(buttonGroup, bottomButtons.position.WithY(4.5f), Quaternion.identity, bottomButtons.parent);
            buttonGroup2.transform.SetLocalY(4.5f);
            buttonGroup2.name = "TopButtons";
            textAsset = buttonGroup2.GetComponentInChildren<TextMeshProUGUI>();
            textAsset.text = "Profile: " + SaveSystem.Profile;

            var button = buttonGroup2.transform.Find("Card Viewer Button/Animator/Button").GetComponent<Button>();
            button.onClick.AddListener(() => CoroutineManager.Start(OnClick()));
        }

        public static Transform scrollView = null;
        public static Transform content = null;
        public static ModsSceneManager modsSceneManager = null;
        public static GameObject modPrefab = null;
        public static RectTransform buttonPrefab = null;
        /// <summary>
        /// On clicking the profile manager button, show profiles
        /// </summary>
        public static IEnumerator OnClick()
        {
            yield return SceneManager.Load("Mods", SceneType.Temporary);
            editing = false;
            modsSceneManager = GameObject.FindObjectOfType<ModsSceneManager>();

            if (!modPrefab)
            {
                modPrefab = Instantiate(modsSceneManager.ModPrefab, ProfileManagerMod.uiItems);

                var buttonLayout = new GameObject("Editor Buttons", typeof(VerticalLayoutGroup), typeof(ContentSizeFitter));
                (buttonLayout.transform as RectTransform).SetSize(modPrefab.FindObject("Buttons").transform as RectTransform);
                buttonLayout.transform.SetParent(modPrefab.transform);
                buttonLayout.transform.SetLocalPositionAndRotation(new Vector2(3.5f, 0.8f), Quaternion.identity);
                buttonLayout.transform.localScale = new Vector3(0.8f, 0.8f, 1);

                VerticalLayoutGroup layout = buttonLayout.GetComponent<VerticalLayoutGroup>();
                layout.childAlignment = TextAnchor.UpperCenter;
                layout.childControlHeight = false;
                layout.childControlWidth = false;

                foreach (var text in new string[] {"Duplicate", "Delete" })
                {
                    var button = Instantiate(buttonPrefab, buttonLayout.transform);
                    button.name = text;
                    var buttonTransform = button.Find("Animator/Button");
                    buttonTransform.GetComponentInChildren<TextMeshProUGUI>().SetText(text);
                    buttonTransform.GetComponent<Button>().onClick = new();
                }
                buttonLayout.SetActive(false);
                yield return null;
            }

            scrollView = modsSceneManager.Content.transform.parent.parent;
            content = scrollView.Find("Viewport/Content");
            content.DestroyAllChildren();
            profileHolders.Clear();
            foreach (var dir in ES3.GetDirectories(SaveSystem.profileFolder))
            {
                Debug.LogWarning(dir);
                Run(dir);
            }
            CreateMainEditButton();
            CreateNewProfileButton();
        }

        /// <summary>
        /// Create a holder for a profile
        /// </summary>
        public static void Run(string profileName = "Default")
        {
            var gameObject = modPrefab.InstantiateKeepName();
            gameObject.transform.SetParent(content);
            if (profileName.StartsWith("Default"))
                gameObject.transform.SetAsFirstSibling();
            gameObject.transform.SetLocalZ(0);
            gameObject.transform.localScale = Vector3.one;
            gameObject.transform.localRotation = Quaternion.identity;

            ModHolder holder = gameObject.GetComponentInChildren<ModHolder>();
            holder.Mod = new ProfileDisplay(profileName, holder);
            holder.Mod.Load();
            holder.UpdateInfo();
            profileHolders.Add(holder);
            
            Button selector = holder.bellRinger.transform.Find("Button (Base)/Animator/Button").GetComponent<Button>();
            selector.onClick = new();
            selector.onClick.AddListener(() => ProfileDisplay.Select(holder));

        }

        public static List<ModHolder> profileHolders = new();

        
        void Update()
        {
            if (!promptToggleEditor) return;
            promptToggleEditor = false;
            Toggle();
        }
        public void Toggle()
        {
            editing = !editing;
            foreach (var holder in profileHolders)
            {
                holder.gameObject.FindObject("Editor Buttons").SetActive(editing);
                holder.gameObject.FindObject("Buttons").SetActive(!editing);
            }
            Debug.LogWarning("[Profile Manager] Editing? " + editing);
        }

        public static void CreateMainEditButton()
        {
            Transform parent = content.root.Find("SafeArea/Menu");

            var editButton = Instantiate(editButtonPrefab, parent.transform);
            editButton.transform.localRotation = Quaternion.identity;
            editButton.transform.localPosition = parent.Find("Back Button").localPosition.WithY(1.5f);

            var button = editButton.transform.Find("Animator/Button").GetComponent<Button>();
            button.onClick.AddListener(() => promptToggleEditor = true);

            var textAsset = button.GetComponentInChildren<TextMeshProUGUI>();
            textAsset.transform.SetLocalX(0.2f);
            textAsset.text = "Toggle Edit";
        }
        public static void CreateNewProfileButton()
        {
            Transform parent = content.root.Find("SafeArea/Menu");

            var editButton = Instantiate(editButtonPrefab, parent.transform);
            editButton.transform.localRotation = Quaternion.identity;
            editButton.transform.localPosition = parent.Find("Back Button").localPosition.WithY(2.5f);

            var button = editButton.transform.Find("Animator/Button").GetComponent<Button>();
            button.onClick.AddListener(CreateNewProfile);

            var textAsset = button.GetComponentInChildren<TextMeshProUGUI>();
            textAsset.transform.SetLocalX(0.2f);
            textAsset.text = "New Profile";
        }
        static void CreateNewProfile()
        {
            string date = DateTime.Today.ToShortDateString().Replace('/', '.');
            string newFolderName = $"Default - {date}";
            if (ES3.DirectoryExists(newFolderName))
            {
                int i = 1;
                while (ES3.DirectoryExists($"{newFolderName} #{i}"))
                    i++;
                newFolderName = $"{newFolderName} #{i}";
            }
            SaveSystem.SetProfile(newFolderName);
            CoroutineManager.Start(SceneManager.Unload("Mods"));
        }
    }
}