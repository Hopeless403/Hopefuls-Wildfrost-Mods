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

namespace Mod2
{
    public class Mod2Mod : WildfrostMod
    {
        public static Mod2Mod instance;
        public Mod2Mod(string modDirectory) : base(modDirectory)
        {
            instance = this;
        }
        public override string GUID => "hope.wildfrost.Mod2";
        public override string[] Depends => new string[] { };
        public override string Title => "Mod2";
        public override string Description => $"Last refresh: {DateTime.Now}";
        public override TMP_SpriteAsset SpriteAsset => base.SpriteAsset;

        public override void Load()
        {
            //if(!preLoaded) { CreateModAssets(); } //preLoaded makes sure that the builders are not made again on the 2nd load.
            base.Load();                          //Actual loading
        }

        public override void Unload()
        {
            base.Unload();
        }

        private void CreateModAssets()
        {
            //Code for new assets

            preLoaded = true;
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