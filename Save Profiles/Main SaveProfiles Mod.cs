using Deadpan.Enums.Engine.Components.Modding;
using FMODUnity;
using HarmonyLib;
using NexPlugin;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.Localization;

namespace WildfrostHopeMod.ProfileManager
{
    public class ProfileManagerMod : WildfrostMod
    {
        [HarmonyPatch(typeof(References), nameof(References.Classes), MethodType.Getter)]
        static class FixClassesGetter
        {
            static void Postfix(ref ClassData[] __result) => __result = AddressableLoader.GetGroup<ClassData>("ClassData").ToArray();
        }


        public static ProfileManagerMod Mod;
        public ProfileManagerMod(string modDirectory) : base(modDirectory)
        {
            Mod = this;
        }
        public override string GUID => "hope.wildfrost.profiles";
        public override string[] Depends => new string[] { };
        public override string Title => "Profile Manager";
        public override string Description => "Swap between save profiles located in the AppData\r\nDuplicate, delete, or create a new save profile";
        public override TMP_SpriteAsset SpriteAsset => CreateSpriteAsset(GUID, ImagesDirectory);
        public static GameObject behaviour;
        public static Transform uiItems;
        
        public override void Load()
        {
            base.Load();
            foreach (var field in typeof(Localizers).GetFields())
                if (field.GetValue(null) is LocalizedString) ;

            if (!ProfileManagerModBehaviour.buttonGroup)
            {
                behaviour = new GameObject("Profile Manager");
                GameObject.DontDestroyOnLoad(behaviour);
                behaviour.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset |
                                      HideFlags.HideInInspector | HideFlags.NotEditable;
                uiItems = new GameObject("UI Items").transform;
                uiItems.SetParent(behaviour.transform);
                uiItems.gameObject.SetActive(false);

                var e = behaviour.AddComponent<ProfileManagerModBehaviour>();
            }
            behaviour.SetActive(true);
            GameObject.Find("Canvas/Safe Area/TopButtons")?.SetActive(true);
            Events.OnSaveSystemProfileChanged += OverallStatsSystem.instance.GameStart;
            Events.OnSaveSystemProfileChanged += ProfileManagerModBehaviour.OnProfileChanged;
            Events.OnSceneChanged += ProfileManagerModBehaviour.OnSceneChanged;
        }

        public override void Unload()
        {
            base.Unload();
            behaviour.SetActive(false);/*
            GameObject.Destroy(behaviour);
            behaviour = null;
            uiItems = null;*/
            GameObject.Find("Canvas/Safe Area/TopButtons")?.SetActive(false);
            Events.OnSaveSystemProfileChanged -= OverallStatsSystem.instance.GameStart;

            Events.OnSaveSystemProfileChanged -= ProfileManagerModBehaviour.OnProfileChanged;
            Events.OnSceneChanged -= ProfileManagerModBehaviour.OnSceneChanged;
        }

        public static TMP_SpriteAsset CreateSpriteAsset(string name, string directoryWithPNGs = null, Texture2D[] textures = null, Sprite[] sprites = null)
        {
            Texture2D[] allTextures = (
                directoryWithPNGs.IsNullOrWhitespace() ? new Texture2D[0] : Directory.GetFiles(directoryWithPNGs, "*.png", SearchOption.AllDirectories)
                    .Select(p => {
                        Texture2D tex = new(1, 1)
                        { name = Path.GetFileNameWithoutExtension(p) };
                        tex.LoadImage(File.ReadAllBytes(p));
                        return tex;
                    })).ToArray();

            // Initialise the texture atlas
            Texture2D atlas = new(1 << 12, 1 << 12)
            { name = name + ".Sheet" };
            Rect[] rects = atlas.PackTextures(allTextures, 0);
            Dictionary<Rect, Texture2D> lookup = allTextures.ToDictionary(t => rects[allTextures.ToList().IndexOf(t)]);

            // Initialise the material with the texture atlas
            Shader shader = Shader.Find("TextMeshPro/Sprite");
            Material material = new(shader);
            material.SetTexture(ShaderUtilities.ID_MainTex, atlas);

            // Create a new sprite asset
            TMP_SpriteAsset spriteAsset = TMP_Settings.defaultSpriteAsset.InstantiateKeepName();
            new Action<TMP_SpriteAsset>(s => {
                s.name = name;
                s.spriteGlyphTable.Clear();
                s.spriteCharacterTable.Clear();
                s.material = material;
                s.spriteSheet = atlas;
                s.UpdateLookupTables();
            }).Invoke(spriteAsset);

            // Add each rect as a SpriteCharacter
            foreach (var rect in rects)
            {
                TMP_SpriteGlyph spriteGlyph = new()
                {
                    glyphRect = new((int)(rect.x * atlas.width), (int)(rect.y * atlas.height), (int)(rect.width * atlas.width), (int)(rect.height * atlas.height)),
                    index = (uint)spriteAsset.spriteGlyphTable.Count, // otherwise defaults to index 0
                    metrics = new(170.6667f, 170.6667f, -10, 150, 150),
                    scale = 1.5f,
                };
                spriteAsset.spriteGlyphTable.Add(spriteGlyph);
                TMP_SpriteCharacter spriteCharacter = new(spriteGlyph.index, spriteGlyph) { name = lookup[rect].name };
                spriteAsset.spriteCharacterTable.Add(spriteCharacter);
            }

            spriteAsset.UpdateLookupTables();

            // Uncomment this to automatically put in the thing
            //TMP_Settings.defaultSpriteAsset.fallbackSpriteAssets.Add(spriteAsset);
            return spriteAsset;
        }


        [HarmonyPatch(typeof(ModsSceneManager), nameof(ModsSceneManager.Start))]
        public class PatchModSizes
        {
            public readonly string comment = "this has absolutely nothing to do with the mod kekw";
            public static IEnumerator Postfix(IEnumerator __result, ModsSceneManager __instance)
            {
                while (__result.MoveNext())
                    yield return __result.Current;
                foreach (var transform in __instance.Content.transform.GetAllChildren())
                    transform.localScale = Vector3.one;
            }
        }
    }

}