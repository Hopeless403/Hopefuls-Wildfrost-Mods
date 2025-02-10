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

namespace IntroCutscene
{
    public class IntroCutsceneMod : WildfrostMod
    {
        public static IntroCutsceneMod Mod;
        public IntroCutsceneMod(string modDirectory) : base(modDirectory)
        {
            Mod = this;
        }
        public override string GUID => "hope.wildfrost.IntroCutscene";
        public override string[] Depends => new string[] { };
        public override string Title => "Intro Cutscene";
        public override string Description => "";
        public override TMP_SpriteAsset SpriteAsset => base.SpriteAsset;
        public static GameObject behaviour;
        public static string ConfigFolder => Path.Combine(Mod.ModDirectory, "Windows");
        public override void Load()
        {

            base.Load();
        }

        public override void Unload()
        {
            base.Unload();
            GameObject.Destroy(behaviour);
            behaviour = null;
        }
    }
}