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

        public override void Load()
        {
            if (true)
            {
                Entity entity = null;
                entity.GetAllAllies().DoIf(a => a?.traits == null, 
                    a => Debug.LogWarning((a, a?.traits?.Where(t => t != null && t.data != null).Join())));
            }

            base.Load();
            new List<Entity>().Count(a => { Debug.Log()})
            behaviour = new GameObject(Title);
            GameObject.DontDestroyOnLoad(behaviour);
            behaviour.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset |
                                  HideFlags.HideInInspector | HideFlags.NotEditable;

            var e = behaviour.AddComponent<ExtendedUIModBehaviour>();
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