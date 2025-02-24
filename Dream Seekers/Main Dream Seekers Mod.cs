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

namespace DreamSeekers
{
    public class DreamSeekersMod : WildfrostMod
    {
        public DreamSeekersMod(string modDirectory) : base(modDirectory) => instance = this;
        public static DreamSeekersMod instance;
        public override string GUID => "hope.wildfrost.dreamseekers";
        public override string[] Depends => new string[] { };
        public override string Title => "Dream Seekers";
        public override string Description => "";
        public override TMP_SpriteAsset SpriteAsset => base.SpriteAsset;
        public static GameObject behaviour;

        public override void Load()
        {

            base.Load();
        }

        public override void Unload()
        {
            base.Unload();
        }

        public static readonly List<object> assets = [];
        public override List<T> AddAssets<T, Y>()
        {
            if (assets.OfType<T>().Any())
                Debug.LogWarning($"[{Title}] adding {typeof(Y).Name}: {assets.OfType<T>().Join(d => Path.GetExtension(d._data.name))}");
            return assets.OfType<T>().ToList();
        }
    }
}