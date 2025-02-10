using DeadExtensions;
using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using System.Collections;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.Localization.Components;
using UnityEngine.UI;
using WildfrostHopeMod.Configs;

namespace WildfrostHopeMod
{
    public partial class ConfigManager
    {
        [HarmonyPatch(typeof(Journal), nameof(Journal.PagedOpened))]
        public static class PatchJournal
        {
            public static JournalPageMenu modSettingsPage;
            public static RectTransform modScrollView;
            public static RectTransform modContent;
            public static Button modSettingsButton;


            internal static bool promptEndInput = false;
            internal static bool promptRename = false;

            internal static SettingOptions templateBoolType;
            internal static GameObject templateOption;
            internal static SettingSlider templateSlider;
            internal static Transform templateScrollView;

            const string nothingHere = "Nothing to see here...\r\n<color=#112e0c>_   _\r\n/o\\_/o\\\r\n|    ω    |\r\nU ___ U\r\nU   U";



            /// <summary>
            /// Creates a configSection if it doesn't exist yet, and updates its info
            /// </summary>
            /// <param name="mod"></param>
            /// <returns>true only if the configSection has any items</returns>
            public static bool CreateConfigs(WildfrostMod mod)
            {
                //Debug.LogError(sections.ContainsKey(mod));
                // If mod hasn't loaded before, it doesn't have a configSection
                if (!sections.TryGetValue(mod, out var configSection))
                    configSection = sections[mod] = new ConfigSection(mod);

                // If mod loaded before the rename button was copied, does nothing
                if (!configSection.section)
                    configSection.UpdateInfo();

                //OnModLoaded?.Invoke(mod);
                return sections[mod].items.Count > 0;
            }
            internal static void _CreateConfigs(WildfrostMod mod) => CreateConfigs(mod);

            public static void CreateModSettingsPage(Journal __instance)
            {
                var page2 = __instance.rightPageGroup;
                var newPage = page2.Find("GameSettings").InstantiateKeepName();
                newPage.DestroyAllChildren();
                newPage.name = "ModSettings";
                newPage.SetParent(page2);
                newPage.localRotation = Quaternion.identity;
                UtilityScript.Reset(newPage.transform);

                modSettingsPage = newPage.GetComponent<JournalPageMenu>();
                modSettingsPage.alsoOpen = null;
            }

            public static void CreateModConfigsButton(JournalPage page)
            {
                var newButtonTransform = GameObject.Instantiate(page.transform.Find("Game"), page.transform);
                newButtonTransform.name = "ModSettingsButton";
                newButtonTransform.SetSiblingIndex(page.transform.Find("Detail").GetSiblingIndex());
                newButtonTransform.Normalise();

                // Set button to open the Page2 with each mod's settings
                var newButton = modSettingsButton = newButtonTransform.GetComponentInChildren<Button>();
                newButton.onClick = new();
                newButton.onClick.AddListener(modSettingsPage.Open);

                // Set localized text of "Mod Configs"
                newButton.GetComponentInChildren<LocalizeStringEvent>().StringReference = Localizers.ModConfigs;
            }


            static void Postfix(Journal __instance, JournalPage page)
            {
                switch (page.name)
                {
                    case "SettingsMenu":
                        Run(__instance, page);
                        break;
                    case "ModSettings":
                        CoroutineManager.Start(FixLayout());

                        break;
                    default: return;
                }
            }

            internal static void Run(Journal __instance, JournalPage page)
            {
                templateBoolType ??= __instance.gameObject.GetComponentsInChildren<SettingOptions>(true).FirstOrDefault(s => s.dropdown.options.Count == 2);
                templateOption ??= templateBoolType.transform.FindRecursive("Off").gameObject;
                templateSlider ??= __instance.gameObject.GetComponentsInChildren<SettingSlider>(true).FirstOrDefault(s => s.GetComponents<SetSettingFloat>().Any());
                if (!modSettingsPage)
                {
                    CreateModSettingsPage(__instance);

                    #region Scrollable page
                    var scrollView = templateScrollView = __instance.transform.FindRecursive("Challenges").Find("Scroll View");
                    var newScrollView = modScrollView = scrollView.InstantiateWithoutChildren("Content").ToRectTransform();
                    modContent = modScrollView.FindRecursive("Content").ToRectTransform();
                    modScrollView.Find("Scrollbar Horizontal").gameObject.Destroy();
                    newScrollView.SetParent(modSettingsPage.transform, true);

                    #endregion
                    GetLastMods().Update(mod => CreateConfigs(mod));
                    CreateModConfigsButton(page);

                    #region scroll view position correction
                    newScrollView.SetSize(scrollView.ToRectTransform());
                    newScrollView.position = modSettingsPage.transform.position;
                    newScrollView.Normalise();

                    newScrollView.Find("Scrollbar Vertical").position = scrollView.Find("Scrollbar Vertical").position;
                    newScrollView.GetComponentInChildren<VerticalLayoutGroup>().childAlignment = TextAnchor.UpperCenter;
                    
                    // replaces unnecessary .CreateSpace() in each section
                    newScrollView.GetComponentInChildren<VerticalLayoutGroup>().spacing = 0.5f;
                    scrollView.SetParent(__instance.transform.FindRecursive("Challenges"), true);

                    var scroller = newScrollView.gameObject.AddComponent<ScrollToNavigation>();
                    scroller.scrollRect = newScrollView.GetComponent<SmoothScrollRect>();
                    #endregion

                    CoroutineManager.Start(FixLayout());

                    CreateRenameSequence();
                    ConfigManager.initialised = true;
                }
                page.transform.FindRecursive("ModSettingsButton").gameObject.SetActive(true);
                _ = Localizers.ModConfigs.Localizer;
            }
            static void CreateRenameSequence()
            {
                var sequence = ConfigManager.renameSeq;
                sequence.name = "Rename Card";
                sequence.transform.SetParent(modSettingsPage.transform);
                sequence.transform.localPosition = Vector3.zero;

                sequence.transform.FindRecursive("Cancel Button").GetComponentInChildren<Button>().onClick.AddListener(() => { promptEndInput = true; promptRename = false; });
                sequence.transform.FindRecursive("Confirm Button").GetComponentInChildren<Button>().onClick.AddListener(() => { promptEndInput = true; promptRename = true; });

                sequence.GetComponentsInChildren<LocalizeStringEvent>().Update(e => e.enabled = false);
                //sequence.GetComponentsInChildren<FontSetter>().Update(e => e.enabled = false);
                sequence.transform.FindRecursive("Confirm Button").GetComponentInChildren<TextMeshProUGUI>().text = "Confirm";
                

                sequence.SetActive(false);
            }

            static void NothingToSeeHere()
            {
                if (!modContent.Find("Title")) ConfigSection.CreateTitle(modContent, nothingHere);
                modContent.Find("Title").GetComponent<TextMeshProUGUI>().text = (PettyRandom.value < 0.01f ? nothingHere : "Nothing to see here...");
                modContent.Find("Title").gameObject.SetActive(modContent.GetActiveChildCount() == (modContent.Find("Title").gameObject.activeSelf ? 1 : 0));
            }


            internal static IEnumerator FixLayout()
            {
                yield return null;
                modSettingsButton.transform.Normalise();
                foreach (var child in modSettingsPage.transform.GetAllChildrenDepth(5))
                    child.localRotation = Quaternion.identity;

                if (modSettingsPage.TryGetComponent<VerticalLayoutGroup>(out var layout))
                    layout.enabled = false;
                if (modSettingsPage.TryGetComponent<ContentSizeFitter>(out var fitter))
                    fitter.enabled = false;

                modScrollView.SetSize(templateScrollView .ToRectTransform());
                modScrollView.localPosition = Vector3.zero;
                modScrollView.Normalise();

                modScrollView.Find("Scrollbar Vertical").position = templateScrollView.Find("Scrollbar Vertical").position;
                modScrollView.GetComponentInChildren<VerticalLayoutGroup>().childAlignment = TextAnchor.UpperCenter;

                (modScrollView.Find("Viewport") .ToRectTransform()).pivot = new Vector2(0.5f, 1);
                modScrollView.Find("Viewport").localScale = new Vector3(0.5f, 1, 1);
                modContent.pivot = new Vector2(0.5f, 0.5f);
                modContent.localScale = new Vector3(2, 1, 1);

                foreach (ConfigSection section in sections.Values)
                    section.FixLayout();

                // If no sections visible, swap to empty title
                NothingToSeeHere();

                yield return new WaitForSecondsRealtime(Time.unscaledDeltaTime);
                modScrollView.GetComponent<SmoothScrollRect>().ScrollToTop();
                UINavigationDefaultSystem.SetStartingItem(false);
            }

        }
    }

}