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
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace WildfrostHopeMod.CardOrganizerMod
{
    public class CardOrganizerMod : WildfrostMod
    {
        public static CardOrganizerMod Mod;
        public CardOrganizerMod(string modDirectory) : base(modDirectory)
        {
            Mod = this;
        }
        public override string GUID => "hope.wildfrost.CardOrganizer";
        public override string[] Depends => new string[] { };
        public override string Title => "CardOrganizer viewer";
        public override string Description => "Enables the button to view the CardOrganizer scene. Only vanilla (and unused) cards for now";
        public override TMP_SpriteAsset SpriteAsset => base.SpriteAsset;
        public static GameObject behaviour;
        public static GameObject backButton { get; internal set; }

        public override void Load()
        {
            base.Load();

            behaviour = new GameObject(Title);
            GameObject.DontDestroyOnLoad(behaviour);
            behaviour.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset |
                                  HideFlags.HideInInspector | HideFlags.NotEditable;

            if (!SceneManager.ActiveSceneName.IsNullOrEmpty())
                OnSceneChanged(SceneManager.GetActive());
            var e = behaviour.AddComponent<CardOrganizerBehaviour>();
            Events.OnSceneChanged += OnSceneChanged;
        }
        public static void OnSceneChanged(Scene scene)
        {
            if (scene.name == "Cards")
            {
                backButton = Resources.FindObjectsOfTypeAll<CardOrganizer>().FirstOrDefault()?.gameObject.FindObject("Back Button");
                if (!backButton)
                {
                    backButton ??= HelpPanelSystem.instance.backButton.InstantiateKeepName();
                    backButton.transform.SetParent(behaviour.transform, true);
                }
                var button = backButton.GetComponentInChildren<ButtonAnimator>().button as Button;
                button.onClick = new();
                button.onClick.AddListener(() =>
                {
                    HelpPanelSystem.instance.gameObject.SetActive(false);
                    new PauseMenu().BackToMainMenu();
                    Camera.main.transform.position = new Vector3(0, 0, -10);
                    backButton.SetActive(false);
                });

                backButton.SetActive(true);
            }
            else backButton = null;

            if (scene.name == "MainMenu")
            {
                var go = GameObject.Find("Canvas/Safe Area/BottomButtons/Cards Button");
                if (!go) return;

                go.GetComponent<DisableForReleaseBuild>().enabled = false;
                go.SetActive(true);
            }
        }

        public override void Unload()
        {
            Events.OnSceneChanged -= OnSceneChanged;
            GameObject.Find("Canvas/Safe Area/BottomButtons/Cards Button")?.SetActive(false);
            base.Unload();
            GameObject.Destroy(behaviour);
            behaviour = null;
        }
    }
}