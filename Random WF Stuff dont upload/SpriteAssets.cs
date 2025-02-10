using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using UnityEngine.TextCore.Text;
using UnityEngine;
using Deadpan.Enums.Engine.Components.Modding;
using WildfrostHopeMod;

using UnityEditor;
using System.IO;

namespace WildfrostHopeMod.Randoms
{
    public partial class RandomMod : WildfrostMod
    {
        public static Texture2D MakeReadable(Texture2D texture, Rect cropRect, int dstWidth, int dstHeight, int upperPadding)
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
                //(dstWidth - (int)cropRect.width) / 2, (dstHeight - (int)cropRect.height));
                (dstWidth - (int)cropRect.width) / 2, (dstHeight - upperPadding));
            //(dstWidth - (int)cropRect.width) / 2, (dstHeight - (int)cropRect.height) / 2);
            texture2D.Apply();
            RenderTexture.active = active;
            RenderTexture.ReleaseTemporary(temporary);
            return texture2D;
        }

    }

internal class SpriteAssets
    {
        static readonly WildfrostMod Mod = RandomMod.Mod;

        internal static TMP_SpriteAsset TestOneAtlas()
        {
            /// <sprite="hope.wildfrost.randoms" index=0>

            Sprite[] allSprites = AddressableLoader.GetGroup<CardUpgradeData>("CardUpgradeData")
                //.Where(c => c.type == CardUpgradeData.Type.Charm)
                .Where(c => c.name == "Crown")
                .Select(c => c.image)
                .ToArray();



            // Initialise the texture atlas
            Texture2D atlas = allSprites.First().texture;
            Rect[] rects = allSprites.Select(s => s.textureRect).ToArray();
            var lookup = allSprites.ToLookup(t => rects[allSprites.ToList().IndexOf(t)]);

            // Initialise the material with the texture atlas
            Shader shader = Shader.Find("TextMeshPro/Sprite");
            Material material = new(shader);
            material.SetTexture(ShaderUtilities.ID_MainTex, atlas);

            // Create a new sprite asset
            TMP_SpriteAsset spriteAsset = TMP_Settings.defaultSpriteAsset.InstantiateKeepName();
            new Action<TMP_SpriteAsset>(s => {
                s.name = Mod.GUID;
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
                    glyphRect = new(rect),
                    index = (uint)spriteAsset.spriteGlyphTable.Count, // otherwise defaults to index 0
                    metrics = new(170.6667f, 170.6667f, -10, 150, 150),
                    scale = 1.5f
                };
                spriteAsset.spriteGlyphTable.Add(spriteGlyph);
                TMP_SpriteCharacter spriteCharacter = new(spriteGlyph.index, spriteGlyph) { name = lookup[rect].First().name };
                spriteAsset.spriteCharacterTable.Add(spriteCharacter);
            }

            spriteAsset.UpdateLookupTables();
            TMP_Settings.defaultSpriteAsset.fallbackSpriteAssets.Add(spriteAsset);
            return spriteAsset;
        }
    }
}
