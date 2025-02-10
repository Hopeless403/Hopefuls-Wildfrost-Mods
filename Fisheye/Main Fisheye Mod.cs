using Deadpan.Enums.Engine.Components.Modding;
using FMODUnity;
using HarmonyLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace WildfrostHopeMod.Fisheye
{
    public class FisheyeMod : WildfrostMod
    {
        public static FisheyeMod Mod;
        public FisheyeMod(string modDirectory) : base(modDirectory)
        {
            Mod = this;
        }
        public override string GUID => "hope.wildfrost.fisheye";
        public override string[] Depends => new string[] { };
        public override string Title => "Fisheye Charm";
        public override string Description => "";
        public override TMP_SpriteAsset SpriteAsset => base.SpriteAsset;
        public static GameObject behaviour;

        public override void Load()
        {

            base.Load();

            foreach (var c in AddressableLoader.GetGroup<CardData>("CardData").Where(cc => cc.cardType.name == "Friendly"))
            {
                Debug.Log(c.title);
                var tex = c.mainSprite.MakeReadable().CreateFisheyeTexture(1.3f);
                c.mainSprite = Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height), new Vector2(0.5f, 0.5f), 100, 0, SpriteMeshType.FullRect);
            }

            behaviour = new GameObject(Title);
            GameObject.DontDestroyOnLoad(behaviour);
            behaviour.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset |
                                  HideFlags.HideInInspector | HideFlags.NotEditable;

            var e = behaviour.AddComponent<FisheyeModBehaviour>();
        }

        public override void Unload()
        {
            base.Unload();
            GameObject.Destroy(behaviour);
            behaviour = null;
        }
    }

    public static class TextureFisheye
    {
        public static Texture2D CreateFisheyeTexture(this Texture2D source, float strength)
        {
            int width = source.width;
            int height = source.height;
            Texture2D result = new Texture2D(width, height, source.format, false);

            Vector2 center = new Vector2(width / 2f, height / 2f);
            float radius = Mathf.Sqrt(width * width + height * height) / 2f;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Vector2 current = new Vector2(x, y);
                    Vector2 dir = current - center;
                    float distance = dir.magnitude;

                    // Calculate distortion
                    float factor = Mathf.Pow(distance / radius, strength);
                    Vector2 sourcePos = center + dir * factor;

                    // Clamp positions to texture boundaries
                    sourcePos.x = Mathf.Clamp(sourcePos.x, 0, width - 1);
                    sourcePos.y = Mathf.Clamp(sourcePos.y, 0, height - 1);

                    // Sample original texture
                    Color color = source.GetPixelBilinear(
                        sourcePos.x / width,
                        sourcePos.y / height
                    );

                    result.SetPixel(x, y, color);
                }
            }

            result.Apply();
            return result;
        }
        public static Texture2D MakeReadable(this Texture2D texture, Rect cropRect, int dstWidth, int dstHeight, int leftOffset, int belowOffset)
        {
            // Create a transparent texture with the destination dimensions
            Texture2D texture2D = new(dstWidth, dstHeight, TextureFormat.RGBA32, mipChain: false);
            texture2D.SetPixels(Enumerable.Range(0, dstWidth * dstHeight).Select(_ => Color.clear).ToArray());

            // Allocate a temporary RenderTexture with the original image dimensions
            RenderTexture active = RenderTexture.active;
            RenderTexture temporary = RenderTexture.GetTemporary(texture.width, texture.height, 32);

            // Copy the original Texture onto the temporary RenderTexture set active
            Graphics.Blit(texture, temporary);
            RenderTexture.active = temporary;

            // Copy the cropped part
            texture2D.ReadPixels(new Rect(cropRect.x, temporary.height - cropRect.y - cropRect.height, cropRect.width, cropRect.height),
                //0, 0);
                //(dstWidth - (int)cropRect.width) / 2, 0);
                leftOffset, belowOffset);
            texture2D.Apply();
            RenderTexture.active = active;
            RenderTexture.ReleaseTemporary(temporary);
            return texture2D;
        }
        public static Texture2D MakeReadable(this Sprite sprite)
        {
            if (sprite.texture.width <= 0 || sprite.texture.height <= 0)
                return null;

            int targetHeight = (int)sprite.rect.height;
            int targetWidth = (int)sprite.rect.width;
            int padAbove = Mathf.RoundToInt(sprite.textureRectOffset.y);
            int padLeft = Mathf.RoundToInt(sprite.textureRectOffset.x);

            return sprite.texture.MakeReadable(sprite.textureRect, targetWidth, targetHeight, padLeft, padAbove);

        }
    }
}