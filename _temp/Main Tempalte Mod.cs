using Deadpan.Enums.Engine.Components.Modding;
using FMODUnity;
using HarmonyLib;
using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace WildfrostHopeMod.$safeprojectname$
{
    public class $safeprojectname$Mod : WildfrostMod
    {
        public static $safeprojectname$Mod Mod;
        public $safeprojectname$Mod(string modDirectory) : base(modDirectory)
        {
            Mod = this;
        }
        public override string GUID => "hope.wildfrost.$safeprojectname$";
        public override string[] Depends => new string[] { };
        public override string Title => "$projectname$";
        public override string Description => "";
        public override TMP_SpriteAsset SpriteAsset => base.SpriteAsset;
        public static GameObject behaviour;

        public override void Load()
        {

            base.Load();

            behaviour = new GameObject(Title);
            GameObject.DontDestroyOnLoad(behaviour);

            var e = behaviour.AddComponent<$safeprojectname$ModBehaviour>();
        }

        public override void Unload()
        {
            base.Unload();
            GameObject.Destroy(behaviour);
            behaviour = null;
        }
    }
}