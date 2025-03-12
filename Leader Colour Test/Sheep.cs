using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace WildfrostHopeMod.Leader_Colour_Test
{
    // Ensures that the GameObject (prefab) this is attached to will have an Image component
    [RequireComponent(typeof(Image))]
    public class ScriptableImageSheep : ScriptableCardImage
    {
        public Image image => GetComponent<Image>();
        public Sprite sprite;

        readonly Color[] palette = [
            Color.white,
            RecolourHelpers.HexToColor("f2b233"), // Orange
            RecolourHelpers.HexToColor("e57fd8"), // Magenta
            RecolourHelpers.HexToColor("99b2f2"), // Light blue
            RecolourHelpers.HexToColor("e5e533"), // Yellow
            RecolourHelpers.HexToColor("7fcc19"), // Lime
            RecolourHelpers.HexToColor("f2b2cc"), // Pink
            RecolourHelpers.HexToColor("4c4c4c"), // Gray
            RecolourHelpers.HexToColor("999999"), // Silver
            RecolourHelpers.HexToColor("4c99b2"), // Cyan
            RecolourHelpers.HexToColor("3366cc"), // Blue
            RecolourHelpers.HexToColor("b266e5"), // Purple
            RecolourHelpers.HexToColor("667f33"), // Green
            RecolourHelpers.HexToColor("7f6640"), // Brown? 7f664
            RecolourHelpers.HexToColor("cc4c4c"), // Red
            RecolourHelpers.HexToColor("191919"), // Black
            ];
        int totalNumberOfDyeColours => palette.Length;
        int ageId; // Range [0, totalNumberOfDyeColours)
        float offsetId; // Range [0, offsetMax)
        const int offsetMax = 25;

        private int delay = 0;
        private int delayMax = 10;

        public override void AssignEvent()
        {
            ageId = Dead.Random.Range(0, totalNumberOfDyeColours - 1);
            offsetId = Dead.Random.Range(0, offsetMax - 1);
            image.sprite ??= this.entity.data.mainSprite;

            
            var recolour = GetRecolour();
            SetColour(recolour);
        }
        public void Update()
        {
            if (!entity)
                return;

            if (entity.data.title.IsNullOrWhitespace() || entity.data.title != "jeb_")
                return;

            if (delay >= 0)
            {
                --delay;
                return;
            }
            else delay = delayMax;

            offsetId++;
            ageId = (int)(offsetId / offsetMax);

            var recolour = GetRecolour();
            Debug.LogError("Party time: " + recolour);
            SetColour(recolour);
        }

        Color GetRecolour()
        {
            float offset = (offsetId % offsetMax) / offsetMax;
            int age = ageId % totalNumberOfDyeColours;
            int age2 = (ageId + 1) % totalNumberOfDyeColours;

            float r = Mathf.Lerp(palette[age].r, palette[age2].r, offset);
            float g = Mathf.Lerp(palette[age].g, palette[age2].g, offset);
            float b = Mathf.Lerp(palette[age].b, palette[age2].b, offset);

            return new Color(r, g, b);
        }

        void SetColour(Color color)
        {
            Texture2D paletteTexture = new Texture2D(25, 1, TextureFormat.RGBA32, mipChain: false)
            {
                filterMode = FilterMode.Point
            };
            NativeArray<Color32> rawTextureData = paletteTexture.GetRawTextureData<Color32>();
            ColorSet colorSet = new ColorSet { 
                set = Enumerable.Range(17, 8).Select(n => { 
                    float g = Mathf.RoundToInt(5.2f + 10.2f * n) / 255f;
                    Color gray = new Color(g, g, g);
                    Color.RGBToHSV(gray, out float hue, out float saturation, out float brightness);
                    Color.RGBToHSV(color, out hue, out saturation, out _);
                    Color shade = Color.HSVToRGB(hue, saturation, brightness);
                    return shade; }).ToArray() 
            };
            CharacterAvatar.SetTexturePixels(null, null, rawTextureData, 17, colorSet);
            paletteTexture.Apply();

            image.material = GameObject.Instantiate(Leader_Colour_TestMod.RecolourMaterial);
            image.material.SetTexture("_PaletteTex", paletteTexture);
        }
    }
}
