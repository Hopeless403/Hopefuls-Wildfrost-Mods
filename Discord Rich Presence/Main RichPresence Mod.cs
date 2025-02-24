using Deadpan.Enums.Engine.Components.Modding;
using DiscordRPC.Logging;
using DiscordRPC;
using FMODUnity;
using HarmonyLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TMPro;
using UnityEngine;
using System.Text.RegularExpressions;

namespace WildfrostHopeMod.Discord_Rich_Presence
{
    public class WildfrostRichPresence : WildfrostMod
    {
        const string currentID = HopefulsCustomAppID;

        const string WildfrostModdedDiscordAppID = "1124355162409029723";
        const string HopefulsCustomAppID = "1341086791515504681";

        public static WildfrostRichPresence instance;
        public readonly DateTime gameStartTime;
        public static Timestamps startTimestamp => instance != null ? new Timestamps(start: instance.gameStartTime) : null;
        public WildfrostRichPresence(string modDirectory) : base(modDirectory)
        {
            instance = this;
            gameStartTime = DateTime.Now;
        }
        public override string GUID => "hope.wildfrost.discord";
        public override string[] Depends => new string[] { };
        public override string Title => "Discord Rich Presence";
        public override string Description => """
            Adds Discord rich presence functionality, showing basic info about your current run.
            The time displayed is how long you spent on the campaign, like for Daily Voyages

            If you want to add your mod images or use custom ones, send me a 1024x1024 .png image to use. I'll have to manually add flag/map/fight images for each mod.
            (Preferably ping me on the Wildfrost Discord's #modding-development @hopeless_phan)


            Will add other languages based on google translate or something eventually lmao
            """;

        public static DiscordRpcClient client;

        //Called when your application first starts.
        //For example, just before your main loop, on OnEnable for unity.
        void Initialize()
        {
            
            Debug.LogWarning("Initialising");
            /*
            Create a Discord client
            NOTE:   If you are using Unity3D, you must use the full constructor and define
                     the pipe connection.
            */
            client = new DiscordRpcClient(currentID) 
            { SkipIdenticalPresence = true };

            //Set the logger
            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };

            //Subscribe to events
            client.OnReady += (sender, e) =>
            {
                Debug.LogWarning("Received Ready from user {0}".Format(e.User.Username));
            };

            client.OnPresenceUpdate += (sender, e) =>
            {
                Debug.LogWarning("Received Ready from user {0}".Format(e.Presence));
            };

            //Connect to the RPC
            client.Initialize();

            //Set the rich presence
            //Call this as many times as you want and anywhere in your code.
            
            EventHandler.RefreshStatus();
            //Utility.SetStatus("Loading...");
        }
        public override void Load()
        {
            Initialize();
            Events.OnGameEnd += Dispose;
            Events.OnBattlePreTurnStart += EventHandler.BattlePreTurnStart;
            Events.OnSceneChanged += EventHandler.SceneChanged;
            base.Load();

        }

        public override void Unload()
        {
            Dispose();
            Events.OnGameEnd -= Dispose;
            Events.OnBattlePreTurnStart -= EventHandler.BattlePreTurnStart;
            Events.OnSceneChanged -= EventHandler.SceneChanged;
            base.Unload();
        }
        public void Dispose()
        {
            client?.Dispose();
        }
    }
}