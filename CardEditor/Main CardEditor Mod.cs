using CardEditor.UI;
using CardEditor.UI.Panels;
using CardEditor.Visuals;
using Deadpan.Enums.Engine.Components.Modding;
using FMODUnity;
using HarmonyLib;
using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityExplorer.ObjectExplorer;
using UnityExplorer.UI;
using UniverseLib;
using UniverseLib.UI;
using static CardEditor.Helpers;
using static UnityEngine.Rendering.DebugUI;

namespace CardEditor
{
    public class CardEditorMod : WildfrostMod
    {
        public static CardEditorMod instance;
        public CardEditorMod(string modDirectory) : base(modDirectory)
        {
            instance = this;
        }
        public override string GUID => "hope.wildfrost.CardEditor";
        public override string[] Depends => new string[] { };
        public override string Title => "CardEditor";
        public override string Description => "";
        public string PrefixGUID(string name) => Extensions.PrefixGUID(name, instance);
        public override TMP_SpriteAsset SpriteAsset => base.SpriteAsset;
        public static GameObject behaviour;
        public static Texture2D texture;

        public AsciiPanel ascii;
        internal static UIBase UiBase { get; private set; }
        public static GameObject UIRoot => UiBase?.RootObject;
        public static UnityEngine.Object snowbo;

        public override void Load()
        {
            base.Load();
            Resources.FindObjectsOfTypeAll<Sprite>().Update(SpriteHandler.ExportSprite);


/*
            foreach (var card in AddressableLoader.GetGroup<CardData>("CardData"))
                if (card.mainSprite && card.mainSprite?.name != "Nothing" && !false)
                {
                    //ExportSprite(card);
                    //card.mainSprite = ImagePath($"{card.name} ({card.title}).png").ToSprite();
                }

            _ = typeof(UnityExplorer.ExplorerStandalone) 
             ?? typeof(UnityExplorer.ExplorerCore)
             ?? typeof(UnityExplorer.UI.UIManager);

            UiBase = UniversalUI.RegisterUI(PrefixGUID(DateTime.Now.ToString()), null);
            GameObject.DontDestroyOnLoad(UIRoot);
            UniverseLib.Universe.Init(
                onInitialized: LateInit,
                logHandler: (s, type) => Debug.Log($"[{Title} U] {s}")
                );
            
            behaviour = new GameObject(Title);
            GameObject.DontDestroyOnLoad(behaviour);
            behaviour.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset |
                                  HideFlags.HideInInspector | HideFlags.NotEditable;
            
            var e = behaviour.AddComponent<CardEditorModBehaviour>();

            var map = Addressables.LoadContentCatalogAsync(ImagePath("catalog.json")).WaitForCompletion() as ResourceLocationMap;
            snowbo = Addressables.LoadAssetAsync<UnityEngine.Object>("Assets/_hope.BabySnowbo.asset").WaitForCompletion();
            Debug.LogWarning((snowbo, snowbo?.name, snowbo?.GetType()));
            if (snowbo)
            {
                LogWarning("SNOWBO!!");
                AddressableLoader.AddToGroup<CardData>(typeof(CardData).Name, snowbo as CardData);
            }*/

            //ExportSprite(Get<CardData>("Snoolf"));
            //Get<CardData>("SplitBoss").scriptableImagePrefab = SplitBoss.Build();
            //Get<CardData>("SplitBoss2").mainSprite = Path.Combine(ModDirectory, "Boozle.png").ToSprite();
        }
        [HarmonyPatch(typeof(Console), nameof(Console.Toggle))]
        public class PatchConsole
        {
            static void Postfix() => UniversalUI.SetUIActive(UiBase.ID, !Console.active);
        }

        public override void Unload()
        {
            base.Unload();
            GameObject.Destroy(behaviour);
            behaviour = null;
        }
        private void LateInit()
        {
            Log("Creating UI...");

            //UIManager.InitUI();
            ascii = new AsciiPanel(UiBase);

            Log("UI Initialized");
        }
    }
}