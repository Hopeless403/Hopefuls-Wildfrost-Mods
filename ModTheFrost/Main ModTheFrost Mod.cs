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

namespace WildfrostHopeMod.ModTheFrost
{
    public class ModTheFrostMod : WildfrostMod
    {
        public static ModTheFrostMod instance;
        public ModTheFrostMod(string modDirectory) : base(modDirectory)
        {
            instance = this;

            string localModsPath = Path.Combine(Application.streamingAssetsPath, "Mods");
            bool isLocal = new DirectoryInfo(modDirectory).Parent.FullName == new DirectoryInfo(localModsPath).FullName;
            Debug.LogWarning((isLocal, Camera.main, Camera.main?.GetComponent<MonoBehaviour>()));
            //Camera.main?.GetComponent<MonoBehaviour>()?.StartCoroutine(SceneManager.Load("Mods", SceneType.Temporary, s => Debug.LogError(s.name)));

        }
        public override string GUID => "hope.wildfrost.ModTheFrost";
        public override string[] Depends => new string[] { };
        public override string Title => "ModTheFrost";
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

            var e = behaviour.AddComponent<ModTheFrostModBehaviour>();
        }

        public override void Unload()
        {
            base.Unload();
            GameObject.Destroy(behaviour);
            behaviour = null;
        }
    }
}