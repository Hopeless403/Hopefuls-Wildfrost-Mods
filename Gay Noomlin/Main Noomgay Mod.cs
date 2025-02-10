using Deadpan.Enums.Engine.Components.Modding;
using FMODUnity;
using HarmonyLib;
using Rewired.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TMPro;
using UnityEngine;

namespace WildfrostHopeMod
{
    public class GayNoomlin : WildfrostMod
    {
        public static GayNoomlin Mod;
        public GayNoomlin(string modDirectory) : base(modDirectory)
        {
            Mod = this;
        }
        public override string GUID => "hope.wildfrost.gaynoomlin";
        public override string[] Depends => new string[] { };
        public override string Title => "Gay Noomlin";
        public override string Description => "The waters are turning the nooms gay";
        public override TMP_SpriteAsset SpriteAsset => base.SpriteAsset;
        Sprite noom;
        Sprite bisc = ToSpriteFull(Path.Combine(Mod.ImagesDirectory, "Noomlin Biscuit (Gay).png"));
        Sprite original;

        public override void Load()
        {
            base.Load();
            new Action(() =>
            {
                var c = Get<CardData>("NoomlinBiscuit");
                original = c.mainSprite;
                c.mainSprite = bisc;
            }).Invoke();

            /*original = Get<CardData>("NoomlinBiscuit").mainSprite;
            var biscTex = Path.Combine(ImagesDirectory, "Noomlin Biscuit (Gay).png").ToTex();
            bisc = Sprite.Create(biscTex, new Rect(0f, 0f, biscTex.width, biscTex.height), 0.5f * Vector2.one);
            Path.Combine(ImagesDirectory, "Noomlin Biscuit (Gay).png").ToSprite();
            Get<CardData>("NoomlinBiscuit").mainSprite = IconSprite;

            noom = Path.Combine(ImagesDirectory, "Face (Gay).png").ToSprite();
            Events.OnNoomlinShow += new UnityEngine.Events.UnityAction<Entity>(NoomlinHandler);
        */}

        void NoomlinHandler(Entity entity) => entity.gameObject.GetComponent<ItemHolderPetNoomlin>().head.sprite = noom;

        public override void Unload()
        {
            base.Unload();
            new Action(() =>
            {
                var c = Get<CardData>("NoomlinBiscuit").mainSprite = original;
            }).Invoke();
        }

        public static Sprite ToSpriteFull(string path)
        {
            var t = new Texture2D(0, 0, TextureFormat.RGBA32, false);
            t.LoadImage(File.ReadAllBytes(path));
            return ToSpriteFull(t);
        }

        public static Sprite ToSpriteFull(Texture2D t) =>
            Sprite.Create(t, new Rect(0, 0, t.width, t.height), new Vector2(0.5f, 0.5f), 100, 0, SpriteMeshType.FullRect);
    }

}