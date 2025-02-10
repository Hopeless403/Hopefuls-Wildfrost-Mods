using Deadpan.Enums.Engine.Components.Modding;
using FMODUnity;
using HarmonyLib;
using System;
using System.IO;
using TMPro;
using UnityEngine;
using System.Windows.Forms;

namespace WildfrostFileBrowser
{
    public class FileBrowser(string modDirectory) : WildfrostMod(modDirectory)
    {
        public override string GUID => "hope.wildfrost.filebrowser";
        public override string[] Depends => new string[] { };
        public override string Title => "File Browser";
        public override string Description => "";
        public override TMP_SpriteAsset SpriteAsset => base.SpriteAsset;
        public static GameObject behaviour;

        public override void Load()
        {

            base.Load();

            behaviour = new GameObject(GetType().Name);
            GameObject.DontDestroyOnLoad(behaviour);
            behaviour.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset |
                                  HideFlags.HideInInspector | HideFlags.NotEditable;

            var e = behaviour.AddComponent<HopeTemplateModBehaviour>();
        }

        public override void Unload()
        {
            base.Unload();
            GameObject.Destroy(behaviour);
            behaviour = null;
        }
    }

    public class HopeTemplateModBehaviour : MonoBehaviour
    {
        internal void Start()
        {
        }

        void Update()
        {
            if (Input.GetKey(KeyCode.LeftAlt))
            {
            }

            if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.T))
            {
            }
        }
    }
}