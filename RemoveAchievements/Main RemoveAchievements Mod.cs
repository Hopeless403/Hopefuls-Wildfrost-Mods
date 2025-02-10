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
using Steamworks;
using Steamworks.Data;
using UnityEngine.AddressableAssets;

namespace WildfrostHopeMod.RemoveAchievements
{
    public class RemoveAchievementsMod : WildfrostMod
    {
        public static RemoveAchievementsMod Mod;
        public RemoveAchievementsMod(string modDirectory) : base(modDirectory)
        {
            Mod = this;
        }
        public override string GUID => "hope.wildfrost." + DateTime.Now;
        public override string[] Depends => new string[] { };
        public override string Title => "Remove Achievements";
        public override string Description => "idk";
        public override TMP_SpriteAsset SpriteAsset => base.SpriteAsset;
        public static GameObject behaviour;

        public override void Load()
        {
            base.Load();
            foreach (Achievement achievement in SteamUserStats.Achievements)
            {
                Debug.Log($"→ {achievement.Name} ({achievement.State})");
            }
            var a = Addressables.LoadAssetAsync<UnityEngine.Object>("Assets/Locales/English (en).asset").WaitForCompletion();
        }
        public override void Unload()
        {
            base.Unload();
            GameObject.Destroy(behaviour);
            behaviour = null;
        }
    }
}