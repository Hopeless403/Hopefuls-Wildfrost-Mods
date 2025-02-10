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

namespace WildfrostHopeMod.Template_Test
{
    public class Template_TestMod : WildfrostMod
    {
        public static Template_TestMod Mod;
        public Template_TestMod(string modDirectory) : base(modDirectory)
        {
            Mod = this;
        }
        public override string GUID => "hope.wildfrost.Template_Test";
        public override string[] Depends => new string[] { };
        public override string Title => "Template Test";
        public override string Description => "";
        public override TMP_SpriteAsset SpriteAsset => base.SpriteAsset;
        public static GameObject behaviour;

        public override void Load()
        {

            base.Load();

            behaviour = new GameObject(Title);
            GameObject.DontDestroyOnLoad(behaviour);
            behaviour.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset |
                                  HideFlags.HideInInspector | HideFlags.NotEditable;

            var e = behaviour.AddComponent<Template_TestModBehaviour>();
        }

        public override void Unload()
        {
            base.Unload();
            GameObject.Destroy(behaviour);
            behaviour = null;
        }
    }
}