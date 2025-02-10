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
using UnityEngine.Events;
using UnityEngine.UI;

namespace ExtendedUI
{
    public static partial class UIFactory
    {
        public static Transform CreateScrollView(RectTransform parent, bool horizontal, bool vertical, params Transform[] contentChildren)
        {
            GameObject scrollViewObj = new GameObject("Scroll View", typeof(RectTransform), typeof(SmoothScrollRect), typeof(JoystickScroller), typeof(ScrollToNavigation));
            scrollViewObj.transform.SetParent(parent, false);
            scrollViewObj.GetComponent<ScrollToNavigation>().scrollRect = scrollViewObj.GetComponent<SmoothScrollRect>();

            GameObject viewportObj = new GameObject("Viewport", typeof(RectTransform), typeof(Image), typeof(Mask));
            viewportObj.transform.SetParent(scrollViewObj.transform, false);
            viewportObj.GetComponent<Mask>().showMaskGraphic = false;

            GameObject contentObj = new GameObject("Content", typeof(RectTransform));
            contentObj.transform.SetParent(viewportObj.transform, false);

            scrollViewObj.GetComponent<SmoothScrollRect>().SetContent(contentObj);
            scrollViewObj.GetComponent<SmoothScrollRect>().viewport = viewportObj.transform as RectTransform;
            scrollViewObj.GetComponent<SmoothScrollRect>().horizontal = horizontal;
            scrollViewObj.GetComponent<SmoothScrollRect>().vertical = vertical;

            foreach (Transform contentChild in contentChildren)
                contentChild.SetParent(contentObj.transform);

            return scrollViewObj.transform;
        }

        public class ActivenessListener : MonoBehaviour
        {
            public UnityEvent<GameObject> onEnable = new UnityEvent<GameObject>();
            public UnityEvent<GameObject> onDisable = new UnityEvent<GameObject>();
            public UnityEvent<GameObject> onUpdate = new UnityEvent<GameObject>();

            public void OnEnable() => onEnable?.Invoke(gameObject);
            public void OnDisable() => onDisable?.Invoke(gameObject);
            public void Update() => onUpdate?.Invoke(gameObject);
            public void Start()
            {
                if (gameObject.activeInHierarchy)
                    onEnable?.Invoke(gameObject);
                else
                    onDisable?.Invoke(gameObject);
            }
        }

    }


    [HarmonyPatch(typeof(StormBellManager), nameof(StormBellManager.CreateBell))]
    public static class PatchStormBellsMisaligned
    {
        public static void Prefix(StormBellManager __instance, ref int index)
        {
            index = index switch
            {
                11 => 14,
                14 => 13,
                13 => 11,
                _ => index,
            };
        }
    }

    [HarmonyPatch(typeof(StormBellManager), nameof(StormBellManager.Awake))]
    public static class PatchStormBellsAlignment
    {
        public static void Prefix(StormBellManager __instance)
        {
            __instance.bellGroups = __instance.bellGroups.Distinct().ToArray();
        }
        public static void Postfix(StormBellManager __instance)
        {
            ExtendedUIModBehaviour.bellManager = __instance;
            var columns = __instance.bellGroups.Distinct().ToList();
            for (int i = 0; i < columns.Count; i++)
            {
                Transform col = columns[i];
                var layout = col.GetComponent<LayoutGroup>();
                layout.childAlignment = TextAnchor.UpperCenter;
                if (layout is VerticalLayoutGroup vertical)
                {
                    vertical.spacing = 2;
                    vertical.padding.top = 1+(i % 2);
                    vertical.padding.bottom = 1;
                    vertical.childControlHeight = false;
                }
            }
            foreach (var modifierIcon in __instance.modifierIcons.Keys)
            {
                // regular and gold borders get masked
                if (modifierIcon.transform.Find("Back/Borders"))
                    foreach (var border in modifierIcon.transform.Find("Back/Borders").GetAllChildren())
                    {
                        var image = border.GetComponent<Image>();
                        image.material = image.defaultMaterial;
                        image.maskable = true;
                    }
                // masks the back
                foreach (var image in modifierIcon.GetComponentsInChildren<Image>())
                {
                    image.material = image.defaultMaterial;
                    image.maskable = true;
                }
            }

            __instance.openButton.GetComponentInChildren<Button>().onClick.AddListener(() =>
            {
                GameObject scrollViewObj = GameObject.Find("Canvas/SafeArea/Storm Bell Screen/Bell Panel/Scroll View");
                if (scrollViewObj && scrollViewObj.TryGetComponent(out SmoothScrollRect scrollRect))
                {
                    CoroutineManager.Start(scrollRect.ScrollToTopAfterDelay(Time.deltaTime * 2));
                }
            });

            Transform scrollView = UIFactory.CreateScrollView(
                __instance.bellGroups.First().parent.parent as RectTransform, 
                horizontal: false,
                vertical: true,
                __instance.bellGroups);

            RectTransform viewport = scrollView.Find("Viewport") as RectTransform;
            viewport.sizeDelta = new Vector2(9, 8.6f);

            CustomMaskSwitcher(viewport.GetComponent<Image>());

            RectTransform content = viewport.Find("Content") as RectTransform;
            var fitter = content.gameObject.AddComponent<ContentSizeFitter>();
            fitter.horizontalFit = ContentSizeFitter.FitMode.PreferredSize;
            fitter.verticalFit = ContentSizeFitter.FitMode.PreferredSize;

            var horizontal = content.gameObject.AddComponent<HorizontalLayoutGroup>();
            horizontal.spacing = 0.3f;
            horizontal.childScaleHeight = true;

            if (GameObject.Find("Canvas/SafeArea/Storm Bell Screen/Storm Tower Holder/Storm Tower/Tower")?.TryGetComponent(out Image towerImage) ?? false)
                towerImage.raycastTarget = false;
        }


        public static IEnumerator ScrollToTopAfterDelay(this SmoothScrollRect scrollRect, float delay)
        {
            yield return new WaitForSeconds(delay);
            scrollRect.ScrollToTop();
        }

        static void CustomMaskSwitcher(Image maskImage)
        {
            string pathWithButtons = "Bell Panel Mask (Buttons, Extended).png";
            string pathWithoutButtons = "Bell Panel Mask (No Buttons, Extended).png";
            if (!File.Exists(ExtendedUIMod.instance.ImagePath(pathWithButtons))
                || !File.Exists(ExtendedUIMod.instance.ImagePath(pathWithoutButtons)))
                return;

            GameObject buttonGroup = GameObject.Find("Canvas/SafeArea/Storm Bell Screen/Bell Panel/Additional Buttons");
            if (buttonGroup == null)
                return;

            maskImage.alphaHitTestMinimumThreshold = 0.5f;
            Sprite withButtons = ExtendedUIMod.instance.ImagePath(pathWithButtons).ToSprite();
            Sprite withoutButtons = ExtendedUIMod.instance.ImagePath(pathWithoutButtons).ToSprite();

            var listener = buttonGroup.GetOrAdd<UIFactory.ActivenessListener>();
            listener.onEnable.AddListener(_ =>
            {
                maskImage.sprite = withButtons;
                maskImage.GetComponent<RectTransform>().sizeDelta = new Vector2(9.7f, 10);
            });
            listener.onDisable.AddListener(_ =>
            {
                maskImage.sprite = withoutButtons;
                maskImage.GetComponent<RectTransform>().sizeDelta = new Vector2(9.7f, 10);
            });
            listener.Start();
        }
        
    }
    /*public static GameModifierDataBuilder AsHardModeModifier(
            this GameModifierDataBuilder modifierData,
            int stormPoints)
        {
            var hardModeModifier = ScriptableObject.CreateInstance<HardModeModifierData>();
            hardModeModifier.name = modifierData._data.name;
            modifierData = modifierData.WithLinkedStormBell(hardModeModifier);

            return modifierData.SubscribeToBuildEvent(data =>
            {
                hardModeModifier.modifierData = modifierData._data;
                hardModeModifier.stormPoints = stormPoints;
                hardModeModifier.unlockedByDefault = true;

                References.instance.hardModeModifiers = References.instance.hardModeModifiers.With(hardModeModifier);
            });
        }
        public static GameModifierDataBuilder WithUnlockRequires(
            this GameModifierDataBuilder modifierData,
            params HardModeModifierData[] unlockRequires)
        {
            modifierData.SubscribeToAfterAllBuildEvent(modifier =>
            {
                var hardModeModifier = References.instance.hardModeModifiers.First(bell => bell.name == modifierData._data.name);
                hardModeModifier.unlockedByDefault = false;
                hardModeModifier.unlockRequires = unlockRequires;
            });
            return modifierData;
        }
        public static GameModifierDataBuilder WithUnlockRequires(
            this GameModifierDataBuilder modifierData,
            params string[] unlockRequires)
        {
            modifierData.SubscribeToAfterAllBuildEvent(modifier =>
            {
                var hardModeModifier = References.instance.hardModeModifiers.First(bell => bell.name == modifierData._data.name);
                hardModeModifier.unlockedByDefault = false;
                hardModeModifier.unlockRequires = References.instance.hardModeModifiers.Where(bell => unlockRequires.Contains(bell.name)).ToArray();
            });
            return modifierData;
        }
        public static GameModifierDataBuilder WithUnlockRequiresPoints(
            this GameModifierDataBuilder modifierData,
            int unlockRequiresPoints
            )
        {
            var hardModeModifier = ScriptableObject.CreateInstance<HardModeModifierData>();
            hardModeModifier.modifierData = modifierData._data;
            hardModeModifier.unlockedByDefault = false;
            hardModeModifier.unlockRequiresPoints = unlockRequiresPoints;
            return modifierData;
        }*/
}