using Deadpan.Enums.Engine.Components.Modding;
using FMODUnity;
using HarmonyLib;
using System;
using System.IO;
using TMPro;
using UnityEngine;

namespace WildfrostHopeMod.Paths
{
    public class PathsMod : WildfrostMod
    {
        public static PathsMod Mod;
        public PathsMod(string modDirectory) : base(modDirectory)
        {
            Mod = this;
        }
        public override string GUID => "hope.wildfrost.paths";
        public override string[] Depends => new string[] { };
        public override string Title => "More Paths";
        public override string Description => "Change the number of paths on the map. Works well for 1-3 paths, but anything higher is likely to never finish generating.\r\n\r\nAlso I tried separating the method into different chunks which should make patching easier :3";
        public override TMP_SpriteAsset SpriteAsset => base.SpriteAsset;
        public static GameObject behaviour;

        [ConfigItem(2, null, "Number of paths")]
        public int pathNumber;

        [ConfigItem(true, "If enabled, Campaign generation will always succeed", "Ignore errors")]
        public bool ignoreErrors;
    }
}