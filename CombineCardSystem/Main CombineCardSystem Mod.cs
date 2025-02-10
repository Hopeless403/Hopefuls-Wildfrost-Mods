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

namespace WildfrostHopeMod.CombineCardSystem
{
    public class CombineCardSystemMod : WildfrostMod
    {
        public static CombineCardSystemMod Mod;
        public CombineCardSystemMod(string modDirectory) : base(modDirectory)
        {
            Mod = this;
        }
        public override string GUID => "hope.wildfrost.CombineCardSystem";
        public override string[] Depends => new string[] { };
        public override string Title => "CombineCardSystem and tests";
        public override string Description => "";
        public override TMP_SpriteAsset SpriteAsset => base.SpriteAsset;
        public static GameObject behaviour;

        public override void Load()
        {
            var decompiler = new ICSharpCode.Decompiler.CSharp.CSharpDecompiler(
            fileName: "Wildfrost_Data/Managed/Assembly-CSharp.dll",
            settings: new ICSharpCode.Decompiler.DecompilerSettings(ICSharpCode.Decompiler.CSharp.LanguageVersion.Latest)
            );

            File.WriteAllText(
                path: Path.Combine(Application.persistentDataPath, $"{typeof(Console).Name}.txt"),
                contents: decompiler.DecompileTypeAsString(new(typeof(Console).FullName))
                );

            var bounceCurve = new AnimationCurve(
                new Keyframe(0  , 0 , 4.9192f, 4.9192f, 0, 0.0177f),
                new Keyframe(0.5f, 1, 0, 0, 1f/3f, 1f/3f),
                new Keyframe(0.6512f, 0.9993f, 0, 0, 1f/3f, 1f/3f),
                new Keyframe(1, 0, -7.2545f, -7.2545f, 0.0165f, 0)
                );
/*
            var fadeObj = new GameObject("Fade", typeof(RectTransform), typeof(Image), typeof(Fader));
            var fader = fadeObj.GetComponent<Fader>();
            fader.dur = 0.5f;
            fader.ease = LeanTweenType.easeInOutQuad;*/

            /*var combinePointObj = new GameObject("CombinePoint", typeof(RectTransform));
            combinePointObj.GetComponent<RectTransform>().sizeDelta = Vector2.zero;
            
            var pointObj = new GameObject("Point", typeof(RectTransform));
            pointObj.GetComponent<RectTransform>().sizeDelta = Vector2.zero;

            var flashObj = new GameObject("Fade", typeof(RectTransform), typeof(Image));
            flashObj.SetActive(false);


            var flashCurve = new AnimationCurve(
                new Keyframe(0, 0, 2, 2, 0, 1f/3f),
                new Keyframe(0.5f, 1, 0, 0, 1f / 3f, 1f / 3f),
                new Keyframe(1, 0, -2, -2, 1f/3f, 0)
                );

            Debug.LogWarning(Get<GameMode>("GameModeNormal").campaignSystemNames.Join());
            if (!Get<GameMode>("GameModeNormal").campaignSystemNames.Contains("CombineSystem"))
                Get<GameMode>("GameModeNormal").campaignSystemNames = Get<GameMode>("GameModeNormal").campaignSystemNames.With("CombineSystem");

            Debug.LogWarning(Get<GameMode>("GameModeNormal").campaignSystemNames.Join());

            base.Load();

            behaviour = new GameObject(Title);
            GameObject.DontDestroyOnLoad(behaviour);
            behaviour.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset |
                                  HideFlags.HideInInspector | HideFlags.NotEditable;

            var e = behaviour.AddComponent<CombineCardSystemModBehaviour>();
            Events.OnCampaignLoaded += */
        }

        public override void Unload()
        {
            base.Unload();
            GameObject.Destroy(behaviour);
            behaviour = null;
        }
    }
}