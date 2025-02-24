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

namespace WildfrostHopeMod.Leader_Colour_Test
{
    public class Leader_Colour_TestMod : WildfrostMod
    {
        [ConfigItem(6, """
            Number of frames to wait before next colour (6 delay ~ 1s)
            //
            // Smaller delays = More swapping (but might slow down gameplay!)
            """, "Delay")]
        public int delayMax = 10;
        [ConfigItem(100, "Number of total colours to swap between", "Max offset")]
        public int offsetMax = 100;
        [ConfigItem(false, "", "Affect Clothing Colour")]
        public bool affectClothing = false;
        [ConfigItem(true, "", "Affect Hair Colour")]
        public bool affectHair = true;
        [ConfigItem(false, "", "Affect Eye Colour")]
        public bool affectEye = false;
        [ConfigItem(false, "", "Affect Skin Colour")]
        public bool affectSkin = false;
        //[ConfigItem(false, "", "Affect MarkingColour Colour")]
        public bool affectMarking = false;


        public static Sprite RecolourWeapon;


        public static bool IsLocal => Mod?.ModDirectory.Replace('/', '\\').Contains(Application.streamingAssetsPath.Replace('/', '\\')) ?? false;
        public static Leader_Colour_TestMod Mod;
        public Leader_Colour_TestMod(string modDirectory) : base(modDirectory)
        {
            Mod = this;
            RecolourWeapon = GetImageSprite("Weapons0006.png");
        }
        public override string GUID => "hope.wildfrost.Leader_Colour_Test";
        public override string[] Depends => new string[] { };
        public override string Title => "Rainbow Leaders";
        public override string Description => """
            Small mod that cycles leaders' clothes / hair / eyes through a rainbow (adjustable in configs with Config Manager).

            Mainly a proof of concept before working on more customisable leaders
            """;
        public static GameObject behaviour;

        public override void Load()
        {
            base.Load();

            behaviour = new GameObject(Title);
            GameObject.DontDestroyOnLoad(behaviour);
            var e = behaviour.AddComponent<Leader_Colour_TestModBehaviour>();

            Events.OnEntityCreated += Subscribe;
        }

        public override void Unload()
        {
            Events.OnEntityCreated -= Subscribe;

            base.Unload();
            GameObject.Destroy(behaviour);
            behaviour = null;
        }

        internal void Subscribe(Entity entity)
        {
            if (entity.data.scriptableImagePrefab is Leader)
                Leader_Colour_TestModBehaviour.subscribed.Add(entity);
        }

        const ushort clothingMask   = 0b1111000000000000;
        const ushort hairMask       = 0b0000111100000000;
        const ushort eyeMask        = 0b0000000000001000;
        const ushort skinMask       = 0b0000000000000111;

        const string clothing = """
                            Clothing accent: {0}
                            Clothing shadow: {1}
                            Clothing colour: {2}
                            Weapon highlight: {3}
                            """;
        const string hair = """
                            Hair accent: {0}
                            Hair shadow: {1}
                            Hair colour: {2}
                            Hair highlight: {3}
                            """;
        const string skin = """
                            Ear accent: {0}
                            Skin shadow: {1}
                            Skin colour: {2}
                            """;
    }
}