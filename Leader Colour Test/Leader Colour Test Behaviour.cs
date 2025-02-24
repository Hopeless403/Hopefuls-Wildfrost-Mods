using Deadpan.Enums.Engine.Components.Modding;
using FMODUnity;
using HarmonyLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TMPro;
using Unity.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace WildfrostHopeMod.Leader_Colour_Test
{
    public class Leader_Colour_TestModBehaviour : MonoBehaviour
    {
        internal static Color RandomColor(int _ = 0)
        {
            return new Color(Dead.PettyRandom.Range(0f, 1f), Dead.PettyRandom.Range(0f, 1f), Dead.PettyRandom.Range(0f, 1f));
        }
        internal static ColorSet RandomColorSet(int length)
        {
            return new ColorSet { set = Enumerable.Range(0, length).Select(RandomColor).ToArray() };
        }
        internal static ColorSet Graydient = new ColorSet { set = Enumerable.Range(1, 25).Select(n => { float g = Mathf.RoundToInt(5.2f + 10.2f * n)/255f; return new Color(g, g, g); }).ToArray() };

        internal static readonly HashSet<Entity> subscribed = [];

        private static int delay = 0;
        private static int delayMax => Leader_Colour_TestMod.Mod?.delayMax ?? 10;

        private static float offset = 0;
        private static int offsetMax => Leader_Colour_TestMod.Mod?.offsetMax ?? 100;

        internal ColorSet HueShift(bool? locked, ColorSet colorSet, int length)
        {
            if (locked.HasValue && locked.Value && colorSet.set.Length >= length)
            {
                colorSet = new ColorSet { set = colorSet.set.Clone<Color>().ToArray() };
                for (int i = 0; i < length; i++)
                {
                    var color = colorSet.set[i];
                    Color.RGBToHSV(color, out float H, out float S, out float V);
                    H = (H + (offset / offsetMax)) % 1;
                    colorSet.set[i] = Color.HSVToRGB(H, S, V);
                };
            }
            return colorSet;
        }



        void Update()
        {
            if (delay >= 0)
            {
                --delay;
                return;
            }
            else delay = delayMax;

            offset = (offset + 1) % offsetMax;

            var safeSubbed = subscribed.Clone();
            foreach (var entity in safeSubbed)
            {
                if (!entity.IsAliveAndExists())
                {
                    subscribed.Remove(entity);
                    continue;
                }

                if (entity.display is Card card && card.scriptableImage is Leader leader)
                {
                    //Debug.Log("maybe updating?");
                    if (entity.data.TryGetCustomData("CharacterData", out CharacterData data, null))
                    {
                        CharacterType characterType = AssetLoader.Lookup<CharacterType>("CharacterTypes", data.race + data.gender);
                        if (!characterType) return;

                        //data.SetRandomColorSet(false, characterType, "HairColour", ref data.hairColorIndex);
                        //leader.avatar.UpdateDisplay(data);

                        leader.avatar.paletteTexture = new Texture2D(25, 1, TextureFormat.RGBA32, mipChain: false)
                        {
                            filterMode = FilterMode.Point
                        };
                        NativeArray<Color32> rawTextureData = leader.avatar.paletteTexture.GetRawTextureData<Color32>();

                        ColorSet colorSetClothing = CharacterAvatar.GetColorSet(characterType, "ClothingColour", data.clothingColorIndex);
                        //ColorSet colorSetClothing = RandomColorSet(4);
                        string clothing = """
                            Clothing accent: {0}
                            Clothing shadow: {1}
                            Clothing colour: {2}
                            Weapon highlight: {3}
                            """;
                        colorSetClothing = HueShift(Leader_Colour_TestMod.Mod?.affectClothing, colorSetClothing, 4);

                        ColorSet colorSetHair = CharacterAvatar.GetColorSet(characterType, "HairColour", data.hairColorIndex);
                        //ColorSet colorSetHair = RandomColorSet(4);
                        string hair = """
                            Hair accent: {0}
                            Hair shadow: {1}
                            Hair colour: {2}
                            Hair highlight: {3}
                            """;
                        colorSetHair = HueShift(Leader_Colour_TestMod.Mod?.affectHair, colorSetHair, 4);

                        ColorSet colorSetEye = CharacterAvatar.GetColorSet(characterType, "EyeColour", data.eyeColorIndex);
                        colorSetEye = HueShift(Leader_Colour_TestMod.Mod?.affectEye, colorSetEye, 1);

                        ColorSet colorSetSkin = CharacterAvatar.GetColorSet(characterType, "SkinColour", data.skinColorIndex); 
                        string skin = """
                            Ear accent: {0}
                            Skin shadow: {1}
                            Skin colour: {2}
                            """;
                        colorSetSkin = HueShift(Leader_Colour_TestMod.Mod?.affectSkin, colorSetSkin, /*3*/ 2);

                        ColorSet colorSetMarking = CharacterAvatar.GetColorSet(characterType, "MarkingColour", data.markingsColorIndex);
                        colorSetMarking = HueShift(Leader_Colour_TestMod.Mod?.affectMarking, colorSetMarking, 1);

                        CharacterAvatar.SetTexturePixels(characterType, leader.avatar.paletteTexture, rawTextureData, 0, colorSetClothing);
                        CharacterAvatar.SetTexturePixels(characterType, leader.avatar.paletteTexture, rawTextureData, 4, colorSetHair);

                        //CharacterAvatar.SetTexturePixels(characterType, leader.avatar.paletteTexture, rawTextureData, 8, RandomColorSet(5));

                        CharacterAvatar.SetTexturePixels(characterType, leader.avatar.paletteTexture, rawTextureData, 13, colorSetEye);
                        CharacterAvatar.SetTexturePixels(characterType, leader.avatar.paletteTexture, rawTextureData, 14, colorSetSkin);
                        CharacterAvatar.SetTexturePixels(characterType, leader.avatar.paletteTexture, rawTextureData, 17, colorSetMarking);

                        /*if (Leader_Colour_TestMod.IsLocal)
                            CharacterAvatar.SetTexturePixels(null, null, rawTextureData, 0, Graydient);*/

                        

                        leader.avatar.paletteTexture.Apply();
                        if (leader.avatar.recolourMaterialCopy)
                        {
                            GameObject.Destroy(leader.avatar.recolourMaterialCopy);
                        }

                        leader.avatar.recolourMaterialCopy = GameObject.Instantiate(leader.avatar.recolourMaterial);
                        leader.avatar.recolourMaterialCopy.SetTexture("_PaletteTex", leader.avatar.paletteTexture);
                        try
                        {
                            Image[] componentsInChildren = leader.avatar.GetComponentsInChildren<Image>();
                            foreach (Image image in componentsInChildren)
                            {
                                if (image.transform.parent?.name == "Frosteye(Clone)")
                                    continue;
                                if (!image.TryGetComponent<Mask>(out var _))
                                {
                                    image.material = leader.avatar.recolourMaterialCopy;
                                }



                                // TESTING
                                /*if (Leader_Colour_TestMod.Mod?.ModDirectory.Replace('/', '\\').Contains(Application.streamingAssetsPath.Replace('/', '\\')) ?? false)
                                {
                                    if (image.transform.parent?.name.EndsWith("WeaponAnchor") ?? false)
                                    {
                                        image.sprite = Leader_Colour_TestMod.RecolourWeapon;
                                    }
                                }*/
                            }
                        }
                        catch { }
                    }
                }
            }
        }
    }
}