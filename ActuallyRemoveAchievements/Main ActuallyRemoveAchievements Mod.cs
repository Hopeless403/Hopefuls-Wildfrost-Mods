using Deadpan.Enums.Engine.Components.Modding;
using FMODUnity;
using HarmonyLib;
using Steamworks;
using Steamworks.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ActuallyRemoveAchievements
{
    public partial class ActuallyRemoveAchievementsMod : WildfrostMod
    {
        // it should be named this to show up as a Singleton in UnityExplorer
        public static ActuallyRemoveAchievementsMod instance;
        public ActuallyRemoveAchievementsMod(string modDirectory) : base(modDirectory)
        {
            instance = this;
        }
        public override string GUID => "hope.wildfrost.ActuallyRemoveAchievements";
        public override string[] Depends => new string[] { };
        public override string Title => "ActuallyRemoveAchievements";
        public override string Description => $"Last update: {DateTime.Now}";
        public override TMP_SpriteAsset SpriteAsset => base.SpriteAsset;
        public static GameObject behaviour;
        public static Transform prefabParent;

        public override void Load()
        {
            base.Load();

            if (!SteamClient.IsValid) return;

            var iUserStats = AccessTools.FirstProperty(typeof(SteamUserStats), p => p.Name == "Internal").GetValue(null);
            Debug.LogError(iUserStats);
            var setResult = AccessTools.Method(iUserStats.GetType(), "SetAchievement").Invoke(iUserStats, ["Long Live the King"]);
            Debug.LogError(setResult);
            new Achievement("ACHIEVEMENT_26").Trigger();

            foreach (Achievement achievement in SteamUserStats.Achievements)
            {
                
                Debug.Log($"→ {achievement.Name} ({achievement.State})");
                Debug.LogWarning((
                    SteamUserStats.GetStatInt(achievement.Name),
                    SteamUserStats.GetStatFloat(achievement.Name)
                    ))
                    ;
                //SteamUserStats.SetStat()
            }
            //SteamUserStats.ResetAll(true);
            //typeof()
        }

        public override void Unload()
        {
            base.Unload();
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