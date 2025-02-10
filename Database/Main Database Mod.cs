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

namespace WildfrostHopeMod.Database
{
    public class DatabaseMod : WildfrostMod
    {
        public static DatabaseMod Mod;
        public DatabaseMod(string modDirectory) : base(modDirectory)
        {
            Mod = this;
        }
        public override string GUID => "hope.wildfrost.Database";
        public override string[] Depends => new string[] { };
        public override string Title => "Database";
        public override string Description => "";
        public override TMP_SpriteAsset SpriteAsset => base.SpriteAsset;

        public override void Load()
        {

            base.Load();

        }

        public override void Unload()
        {
            base.Unload();
        }
    }
}