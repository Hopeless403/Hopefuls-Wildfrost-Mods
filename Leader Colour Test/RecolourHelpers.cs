using System.Collections.Generic;
using System.Linq;
using Unity.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace WildfrostHopeMod.Leader_Colour_Test
{
    public static class RecolourHelpers
    {
        // Higher numbers seem to work... costing speed
        public const int coloursMax = 25;
        internal static Dictionary<Image, Material> originalMaterials = [];
        internal static void Recolour(this Image image)
        {
            if (!originalMaterials.ContainsKey(image))
                originalMaterials[image] = image.material;

            Texture2D paletteTexture = new Texture2D(coloursMax, 1, TextureFormat.RGBA32, mipChain: false)
            {
                filterMode = FilterMode.Point
            };
            NativeArray<Color32> rawTextureData = paletteTexture.GetRawTextureData<Color32>();
            CharacterAvatar.SetTexturePixels(null, null, rawTextureData, 0, RandomColorSet(coloursMax));
            paletteTexture.Apply();

            if (originalMaterials.TryGetValue(image, out var material) && material != image.material)
            {
                GameObject.Destroy(image.material);
            }

            image.material = GameObject.Instantiate(Leader_Colour_TestMod.RecolourMaterial);
            image.material.SetTexture("_PaletteTex", paletteTexture);
        }
        public static Color RandomColor(int _ = 0)
        {
            return new Color(Dead.PettyRandom.Range(0f, 1f), Dead.PettyRandom.Range(0f, 1f), Dead.PettyRandom.Range(0f, 1f));
        }
        public static ColorSet RandomColorSet(int length)
        {
            return new ColorSet { set = Enumerable.Range(0, length).Select(RandomColor).ToArray() };
        }
        public static ColorSet GraydientMidpoint(int length)
        {
            return new ColorSet
            {
                set = Enumerable.Range(1, length).Select(n =>
                {
                    float midpoint = StartPixel(n - 1, length) + Mathf.Floor((StartPixel(n, length) - StartPixel(n - 1, length)) / 2);
                    float g = midpoint / 255;
                    return new Color(g, g, g);
                }).ToArray()
            };
        }
        public static ColorSet Graydient(int length)
        {
            return new ColorSet 
            { 
                set = Enumerable.Range(1, length).Select(n => 
                {
                    float leftpoint = StartPixel(n-1, length);
                    float g = leftpoint / 255; 
                    return new Color(g, g, g); 
                }).ToArray() 
            };
        }

        internal static int StartPixel(int region, int total)
        {
            if (total == 0) return 0;
            return Mathf.Clamp(Mathf.CeilToInt(255f * region / total), 0, 256);
        }

        /// <summary>
        /// Actual graydient used in Leader sprites. Doesn't match Graydient(25) exactly
        /// </summary>
        public static ColorSet Graydient25 = new ColorSet { set = Enumerable.Range(0, 25).Select(n => { float g = Mathf.RoundToInt(5.2f + 10.2f * n) / 255f; return new Color(g, g, g); }).ToArray() };

        public static Color HexToColor(string hex)
        {
            string[] colors = ["", "", ""];
            hex = hex.TrimStart('#').Trim();
            if (hex?.Length == 6)
            {
                colors[0] = hex.Substring(0,2);
                colors[1] = hex.Substring(2,2);
                colors[2] = hex.Substring(4,2);

                float r = int.Parse(colors[0], System.Globalization.NumberStyles.HexNumber) / 255f;
                float g = int.Parse(colors[1], System.Globalization.NumberStyles.HexNumber) / 255f;
                float b = int.Parse(colors[2], System.Globalization.NumberStyles.HexNumber) / 255f;

                return new Color(r, g, b);
            }
            return Color.black;
        }
    }
}