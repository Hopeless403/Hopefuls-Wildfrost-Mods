using Deadpan.Enums.Engine.Components.Modding;
using ExtendedUI.Helpers;
using FMODUnity;
using HarmonyLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

namespace ExtendedUI
{
    public static class GameModeHelper
    {
        public static GameModifierDataBuilder AsHardModeModifier(
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
    }

    public partial class ExtendedUIMod : WildfrostMod
    {
        public static ExtendedUIMod instance;
        public ExtendedUIMod(string modDirectory) : base(modDirectory)
        {
            instance = this;
        }
        public override string GUID => "hope.wildfrost.extendedui";
        public override string[] Depends => new string[] { };
        public override string Title => "Extended UI";
        public override string Description => """
            Mod intended to add more/extendible UI. Currently makes the pets, storm bells and tribe flags scrollable, and adds a class UIFactory to help with certain UI elements.

            Currently the UIFactory allows modders to create card grids as well as a way to populate them, add scroll view (like the Mod Configs), add scrollers (like most ingame scroll) ((haven't added scrollbar yet though))
            """;
        public override TMP_SpriteAsset SpriteAsset => base.SpriteAsset;
        public static GameObject behaviour;
        public static bool IsLocal => instance?.ModDirectory.Replace('/', '\\').Contains(Application.streamingAssetsPath.Replace('/', '\\')) ?? false;

        public override void Load()
        {
            if (IsLocal)
            {
                var container = UIFactory.CreateCardGrid(null);
                var cardController = container.gameObject.GetOrAdd<CardControllerSelectCard>();
                cardController.owner = References.Player;
                cardController.unHoverEvent = new UnityEventEntity();
                cardController.hoverEvent = new UnityEventEntity();
                cardController.pressEvent = new UnityEventEntity();
                cardController.pressEvent.AddListener(e => Debug.LogWarning("OW!" + e));
                container.AssignController(cardController);
                new Routine(Pop());

                IEnumerator Pop()
                {
                    yield return container.Populate(
                        AddressableLoader.GetGroup<CardData>(nameof(CardData))
                        .Where(c => c.mainSprite?.name != "Nothing" && !c.scriptableImagePrefab)
                        .RandomItems(5));
                    container.TweenChildPositions();
                }
            }

            base.Load();

            GameObject.DontDestroyOnLoad(behaviour = new GameObject(Title, typeof(ExtendedUIModBehaviour)));
            Events.OnSceneChanged += TribeFlagsGrid.OnSceneChanged;
            Events.OnSceneChanged += PetGrid.OnSceneChanged;
        }

        public override void Unload()
        {
            Events.OnSceneChanged -= TribeFlagsGrid.OnSceneChanged;
            Events.OnSceneChanged -= PetGrid.OnSceneChanged;
            //References.instance.hardModeModifiers = References.instance.hardModeModifiers.Where(h => !h.modifierData.name.StartsWith(GUID)).ToArray();
            base.Unload();
            GameObject.Destroy(behaviour);
            behaviour = null;
        }
    }
}