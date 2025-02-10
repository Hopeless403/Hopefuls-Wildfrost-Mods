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
using UnityEngine.EventSystems;
using UnityEngine.Localization;
using UnityEngine.Localization.Components;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization.Tables;
using UnityEngine.UI;

namespace WildfrostHopeMod.MinibossIntro
{
    public class MinibossIntroMod(string modDirectory) : WildfrostMod(modDirectory)
    {
        public override string GUID => "hope.wildfrost.minibossintro";
        public override string[] Depends => [];
        public override string Title => "Miniboss intros";
        public override string Description => "Adds a button in the journal to play discovered miniboss intros\nBosses are boring";
        public static GameObject jingler;
        public static CardAnimationMinibossIntro minibossIntro = null;
        public static BattleMusicSystem system = null;
        public static FMOD.Studio.EventInstance instance = default;
        public static Entity target = null;

        public override void Load()
        {
            base.Load();
            if (!jingler)
            {
                jingler = new GameObject(GetType().Name,
                                         typeof(RectTransform),
                                         typeof(CanvasRenderer), // redundant
                                         typeof(Image),
                                         typeof(Button),
                                         typeof(EventTrigger),
                                         typeof(UINavigationItem));
                jingler.hideFlags = HideFlags.HideAndDontSave;
                GameObject.DontDestroyOnLoad(jingler);

                jingler.GetOrAdd<Image>().sprite = IconSprite;
                var transform = jingler.GetOrAdd<RectTransform>();
                transform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 1);
                transform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 1);
                //jingler.GetOrAdd<Image>().canvas.sortingLayerName = "PauseMenu";

                var fade = new GameObject("Fade", typeof(Image));
                fade.GetOrAdd<Image>().color = new Color(0.0817f, 0.0382f, 0.1321f, 0.7569f);
                fade.transform.SetParent(jingler.transform);
                fade.SetActive(false);

                minibossIntro = AssetLoader.Lookup<CardAnimationMinibossIntro>("CardAnimations", "minibossintro");
                system = Resources.FindObjectsOfTypeAll<BattleMusicSystem>().FirstOrDefault();


                
            }
            Events.OnEntityHover += PatchConsoleHovers.Hover;
        }



        /*public enum Duration
        {
            delayBefore,
            delayAfter,
            pauseBefore,
            pauseAfter,
            focus,
            move,
            unfocus
        }*/

        [HarmonyPatch]
        internal class PatchConsoleHovers
        {
            internal static GameObject currentButton = null;
            [HarmonyPostfix]
            [HarmonyPatch(typeof(JournalCardDisplay), nameof(JournalCardDisplay.UpdateCard))]
            static IEnumerator UpdateCard(IEnumerator __result, JournalCardDisplay __instance, Card card)
            {
                yield return __result;
                if (!card.entity.data.cardType.miniboss)
                    yield break;
                yield return null;
                Bounds bounds = __instance.nameText.textBounds;
                Vector3 position = bounds.center.WithX(bounds.max.x + 0.75f);
                currentButton ??= CreateButton(__instance.nameText.transform, Run);
                currentButton.transform.localPosition = position;
                currentButton.SetActive(true);
            }

            [HarmonyPostfix]
            [HarmonyPatch(typeof(JournalCardDisplay), nameof(JournalCardDisplay.OnDisable))]
            internal static void UnHover()
            {
                currentButton?.SetActive(false);
                target = null;
            }
            internal static void Hover(Entity entity) => target = entity;
        }

        public static bool onCooldown = false;
        public static void Run()
        {
            if (!onCooldown)
            {
                instance = SfxSystem.OneShot(system.minibossIntroLookup.ContainsKey(target?.data.name ?? "") ? system.minibossIntroLookup[target.data.name] : system.minibossIntroDefault);
                CoroutineManager.Start(Cooldown());
            }
            else
                Debug.LogWarning($"[Miniboss Intros] Can't interrupt [{instance}]");
        }
        public static IEnumerator Cooldown()
        {
            onCooldown = true;
            yield return new WaitForSecondsRealtime(0.5f);
            onCooldown = false;
        }

        /*

        public static readonly Dictionary<Duration, float> durations = new()
        {
            { Duration.delayBefore, 0.3f },
            { Duration.delayAfter, 0.2f },
            { Duration.pauseBefore, 0.6f },
            { Duration.pauseAfter, 0.5f },
            { Duration.focus, 0.5f },
            { Duration.move, 0.5f },
            { Duration.unfocus, 0.5f },
        };

        public static IEnumerator Routine()
        {
            Events.InvokeSetWeatherIntensity(1, 1);

            FMOD.Studio.EventInstance instance = default;
            var source = Resources.FindObjectsOfTypeAll<BattleMusicSystem>();

            CinemaBarSystem.SetSortingLayer("Inspect", 1);
            CinemaBarSystem.In();
            Debug.LogWarning("Waiting");
            yield return Duration.delayBefore.Wait();
            if (source.Any())
                instance = SfxSystem.OneShot(source.First().minibossIntros.RandomItem().introEvent);
            Debug.LogWarning("LeanTween.moveLocal");
            yield return Duration.pauseBefore.Wait();
            //PauseMenu.Block();
            yield return Console.hover ? minibossIntro.Routine(Console.hover) : null;
            yield return Duration.pauseAfter.Wait();
            Debug.LogWarning("Finished");
            CinemaBarSystem.Out();
            Events.InvokeSetWeatherIntensity(0.25f, 3f);
            yield return Duration.unfocus.Wait();
            //PauseMenu.Unblock();
            yield return Duration.delayAfter.Wait();
        }*/



        public static GameObject CreateButton(Transform parent, UnityAction onSelect = null)
        {
            var gameObject = GameObject.Instantiate(jingler, parent);
            Button componentInChildren = gameObject.GetComponentInChildren<Button>();
            if (onSelect != null)
                componentInChildren.onClick.AddListener(onSelect);
            return gameObject;
        }

        public override void Unload()
        {
            base.Unload();
            Events.OnEntityHover -= PatchConsoleHovers.Hover;
            jingler.Destroy();
            jingler = null;
            PatchConsoleHovers.currentButton?.Destroy();
            PatchConsoleHovers.currentButton = null;
        }
    }
}