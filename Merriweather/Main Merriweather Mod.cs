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

namespace Merriweather
{
    public partial class MerriweatherMod : WildfrostMod
    {
        // it should be named this to show up as a Singleton in UnityExplorer
        public static MerriweatherMod instance;
        public MerriweatherMod(string modDirectory) : base(modDirectory)
        {
            instance = this;
        }
        public override string GUID => "hope.wildfrost.merriweather";
        public override string[] Depends => new string[] { };
        public override string Title => "Umbra Merriweather";
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

            var e = behaviour.AddComponent<MerriweatherModBehaviour>();
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
        private StatusEffectDataBuilder StatusCopy(string oldName, string newName)
        {
            StatusEffectDataBuilder builder = Get<StatusEffectData>(oldName).InstantiateKeepName()
                .Edit<StatusEffectData, StatusEffectDataBuilder>()
                .FreeModify(data =>
                {
                    data.name = Extensions.PrefixGUID(newName, this);
                    data.targetConstraints = [];
                });
            builder.Mod = this;
            return builder;
        }

        public List<object> assets = [];
        public override List<T> AddAssets<T, Y>()
        {
            if (assets.OfType<T>().Any())
                this.Log($"adding {typeof(Y).Name}s: {assets.OfType<T>().Select(a => a._data.name).Join()}");
            return assets.OfType<T>().ToList();
        }
    }
}