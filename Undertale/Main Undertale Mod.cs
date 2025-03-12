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
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;

namespace Undertale
{
    public partial class UndertaleMod : WildfrostMod
    {
        // it should be named this to show up as a Singleton in UnityExplorer
        public static UndertaleMod instance;
        public UndertaleMod(string modDirectory) : base(modDirectory)
        {
            instance = this;
        }
        public static string CatalogFolder => Path.Combine(instance.ModDirectory, "Catalog");
        public static string CatalogPath => Path.Combine(CatalogFolder, "catalog.json");
        public override string GUID => "hope.wildfrost.undertale";
        public override string[] Depends => new string[] { };
        public override string Title => "??";
        public override string Description => $"Last update: {DateTime.Now}";
        public override TMP_SpriteAsset SpriteAsset => base.SpriteAsset;
        public static GameObject behaviour;
        public static Transform prefabParent;

        public override void Load()
        {
            base.Load();

            GameObject.DontDestroyOnLoad(behaviour = new GameObject(Title, typeof(UndertaleModBehaviour)));
            if (!Addressables.ResourceLocators.Any(r => r is ResourceLocationMap map && map.LocatorId == CatalogPath))
                Addressables.LoadContentCatalogAsync(CatalogPath).WaitForCompletion();

            Debug.LogWarning(GetAsset<Sprite>("Assets/Sprites/spr_6thumbsup_small_0.png"));
            Debug.LogWarning(Addressables.LoadSceneAsync("Assets/Scenes/hope.undertale.MainScene.unity", UnityEngine.SceneManagement.LoadSceneMode.Additive).WaitForCompletion());
            //Debug.LogWarning(GetAsset<Sprite>("Assets/Sprites/spr_6thumbsup_small_0.png"));
            //Addressables.LoadSceneAsync("Assets/Scenes/hope.undertale.MainScene.unity");

            //new Routine(SceneManager.Load("Assets/Scenes/hope.undertale.MainScene.unity", SceneType.Temporary));
        }

        public override void Unload()
        {
            base.Unload();
            GameObject.Destroy(behaviour);
            behaviour = null;
        }

        public void Log(object message) => Debug.Log($"[{Title}] {message}");
        public void LogWarning(object message) => Debug.LogWarning($"[{Title} Warning] {message}");
        public void LogError(object message) => Debug.LogError($"[{Title} Error] {message}");

        public static List<object> assets = new List<object>();
        public override List<T> AddAssets<T, Y>()
        {
            if (assets.OfType<T>().Any())
                this.Log($"adding {typeof(Y).Name}s: {assets.OfType<T>().Select(a => a._data.name).Join()}");
            return assets.OfType<T>().ToList();
        }
    }
}