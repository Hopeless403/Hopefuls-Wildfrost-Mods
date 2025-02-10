using Deadpan.Enums.Engine.Components.Modding;
using FMODUnity;
using HarmonyLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TMPro;
using UnityEngine.UI;

namespace WildfrostHopeMod.BepInEx
{
    public class BepInExModLoader : WildfrostMod
    {
        public static BepInExModLoader instance;
        public BepInExModLoader(string modDirectory) : base(modDirectory)
        {
            instance = this;
        }
        public override string GUID => "hope.wildfrost.bepinex";
        public override string[] Depends => new string[] { };
        public override string Title => "BepInEx Modloader";
        public override string Description => """
            [h1]What is BepInEx?[/h1]

            """;

        public override void Load()
        {
            // Check if BepInEx is in the correct folder
            if (!BepinexIsInstalled())
            {
                // If not, prompt the player
                /// If player manually loaded the mod, show after exiting mod menu
                if (SceneManager.IsLoaded("MainMenu")) ShowPromptToMoveBepinex();
                /// Else if the mod loaded automatically, show on entering main menu
                else Events.OnGameStart += () => ShowPromptToMoveBepinex();
            }
            UnityEngine.Input.GetKeyDown(UnityEngine.KeyCode.Minus);
            base.Load();
        }

        bool BepinexIsInstalled()
        {
            return false;
        }
        void ShowPromptToMoveBepinex()
        {
            HelpPanelSystem.Show(Localizers.Panel_Format);
            //HelpPanelSystem.SetEmote(this.emote);
            HelpPanelSystem.SetImage(2f, 2f, IconSprite /*this.helpSprite*/);
            HelpPanelSystem.SetBackButtonActive(false);
            HelpPanelSystem.AddButton(HelpPanelSystem.ButtonType.Positive, Localizers.Buttons_cancel, "Select", MoveBepinex);
            //throw new NotImplementedException();
        }

        void MoveBepinex()
        {

            //throw new NotImplementedException();
        }
    }
}