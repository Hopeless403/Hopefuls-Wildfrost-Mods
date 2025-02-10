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
using UnityEngine.UI;

namespace WaitForInput
{
    public partial class WaitForInputMod : WildfrostMod
    {
        // it should be named this to show up as a Singleton in UnityExplorer
        public static WaitForInputMod instance;
        public WaitForInputMod(string modDirectory) : base(modDirectory)
        {
            instance = this;
        }
        public override string GUID => "hope.wildfrost.WaitForInput";
        public override string[] Depends => new string[] { };
        public override string Title => "Wait For Input";
        public override string Description => $"Last update: {DateTime.Now}";
        public override TMP_SpriteAsset SpriteAsset => base.SpriteAsset;
        public static GameObject behaviour;
        public static Transform prefabParent;

        public override void Load()
        {
            base.Load();

            behaviour = new GameObject(Title);
            GameObject.DontDestroyOnLoad(behaviour);
            behaviour.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset |
                                  HideFlags.HideInInspector | HideFlags.NotEditable;

            var e = behaviour.AddComponent<WaitForInputModBehaviour>();
        }

        public override void Unload()
        {
            base.Unload();
            GameObject.Destroy(behaviour);
            behaviour = null;
        }

        public static void Log(object message) => Debug.Log($"[{instance.Title}] {message}");
        public static void LogWarning(object message) => Debug.LogWarning($"[{instance.Title} Warning] {message}");
        public static void LogError(object message) => Debug.LogError($"[{instance.Title} Error] {message}");

        public static List<object> assets = new List<object>();
        public override List<T> AddAssets<T, Y>()
        {
            if (assets.OfType<T>().Any())
                Log($"adding {typeof(Y).Name}s: {assets.OfType<T>().Select(a => a._data.name).Join()}");
            return assets.OfType<T>().ToList();
        }
    }
}