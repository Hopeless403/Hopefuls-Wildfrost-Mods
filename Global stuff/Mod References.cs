using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using TMPro;
using UnityEngine;

namespace WildfrostHopeMod
{
    public class Paths
    {

        public static void LayeredCall(string name) => LoggerCall(name);

        public static void LoggerCall(string name) => 
            Debug.LogWarning($"[{Assembly.GetExecutingAssembly()}] called by [{Assembly.GetCallingAssembly()}]\nLooking for [{name}]");
        // returns that the current assembly (WildfrostHopeMod.Utils) 
        // was called by VFX_Tests


        public string PluginPath { get; private set; }
        public string ImagesPath { get; private set; }
        public string ConfigPath { get; private set; }
        public static string ExecutablePath { get => Application.dataPath + "/../"; }
        // .../steamapps/common/Wildfrost/../

        public static string LogPath { get => Application.persistentDataPath; }
        // .../LocalLow/Deadpan Games/Wildfrost

        public static string ProfilesPath { get => Application.persistentDataPath + "/Profiles/"; }
        // .../LocalLow/Deadpan Games/Wildfrost/Profiles/

        public Paths(string modDirectory)
        {
            PluginPath = modDirectory + '/'; // ...StreamingAssets/Mods/Hope
            ImagesPath = modDirectory + "/images/";
            ConfigPath = Path.Combine(modDirectory, "config.cfg");
        }
    }

    public static partial class Extensions
    {
        public static T? TryCast<T>(this object t) where T : UnityEngine.Object
        {
            if (!typeof(T).IsAssignableFrom(t.GetType())) return null;
            T val = t as T;
            return val ?? null;
        }
        public static T Cast<T>(this object t) where T : UnityEngine.Object
        {
            T? val = t.TryCast<T>();
            if (val == null)
            {
                string str = $"Can't cast object of type {t.GetType()} to type {typeof(T)}";
                throw new InvalidCastException(str);
            }
            return val;
        }
        public static T Get<T>(string assetName) where T : DataFile
        {
            if (typeof(T).IsSubclassOf(typeof(StatusEffectData)))
                return AddressableLoader.groups["StatusEffectData"].lookup[assetName] as T;
            return AddressableLoader.Get<T>(typeof(T).Name, assetName);
        }

        public static object TryGetField<T>(this T t, string name)
        {
            return t.GetAllFields().FirstOrDefault(p => p.Name == name)?.GetValue(t);
        }

        public static bool TrySetField<T>(this T t, string name, object value)
        {
            try 
            { 
                t.GetAllFields().FirstOrDefault(p => p.Name == name).SetValue(t, value);
                return t.GetAllFields().FirstOrDefault(p => p.Name == name).GetValue(t) == value;
            }
            catch { return false; }
        }
        public static T SetFields<T>(this T t, params (string fieldName, object value)[] fieldValues)
        {
            foreach ((string fieldName, object value) in fieldValues)
                t.TrySetField(fieldName, value);
            return t;
        }

        public static T PrintAllProperties<T>(this T t, Type type = null)
        {
            foreach (var property in (type ?? t.GetType()).GetProperties((BindingFlags)0x1FFFFFD))
            {
                try { Debug.Log($"{property.Name}: {property.GetValue(t)}"); }
                catch { Debug.Log($"{property.Name} failed"); }
            }
            return t;
        }
        public static T PrintAllFields<T>(this T t, Type type = null)
        {
            foreach (var field in t.GetAllFields(type))
            {
                try { Debug.Log($"{field.Name}: {field.GetValue(t)}"); }
                catch { Debug.Log($"{field.Name} failed"); }
            }
            return t;
        }
        public static FieldInfo[] GetAllFields<T>(this T t, Type type = null)
        {
            return (type ?? t.GetType()).GetFields((BindingFlags)0x1FFFFFD);//.Concat(typeof(T).GetFields((BindingFlags)0x1FFFFFF)).ToArray();
        }

        public static Card GetCard(this Entity entity) => entity.display as Card;
    }

    public static partial class ActionExt
    {
        public static void TimedInvoke(this Action action)
        {
            StopWatch.Start();
            action();
            StopWatch.Stop();
            Debug.LogWarning("Time elapsed: " + StopWatch.Milliseconds);
        }
    }
    public static partial class StringExt
    {
        public static string ToTitleCase(this string s) => 
            s.Substring(0,1).ToUpperInvariant() + s.Substring(1);
    }

    public static partial class SpriteExt
    {
        public static Texture2D ToTexture(this Sprite sprite, bool squarePadding = false)
        {
            if (!squarePadding) return ToTexture(sprite, (int)sprite.rect.width, (int)sprite.rect.height);
            if (sprite == null) return null;
            if (sprite.textureRect.width == sprite.texture.width) return sprite.texture;
            Texture2D newTex = null;
            new Action(() => newTex = sprite.texture.MakeReadable(sprite.textureRect, squarePadding)).TimedInvoke();
            return newTex;
        }
        public static Texture2D ToTexture(this Sprite sprite, int dstWidth, int dstHeight)
        {
            if (sprite == null) return null;
            if (sprite.textureRect.width != sprite.texture.width)
            {
                Texture2D newTex = null;
                new Action(() => newTex = sprite.texture.MakeReadable(sprite.textureRect, dstWidth, dstHeight)).TimedInvoke();
                return newTex;
            }
            else return sprite.texture;
        }
    }

    public static partial class Texture2DExt
    {
        public static Sprite ToSpriteFullRect(this Texture2D texture) =>
            Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f), 100, 0, SpriteMeshType.FullRect);
        public static Texture2D MakeReadable(this Texture2D texture)
        {
            return MakeReadable(texture, new Rect(0, 0, texture.width, texture.height));
        }
        public static Texture2D MakeReadable(this Texture2D texture, Rect cropRect)
        {
            return MakeReadable(texture, cropRect, Mathf.FloorToInt(cropRect.width), Mathf.FloorToInt(cropRect.height));
        }
        public static Texture2D MakeReadable(this Texture2D texture, Rect cropRect, bool squarePadding)
        {
            int length = Mathf.Max((int)cropRect.width, (int)cropRect.height);
            int dstWidth = squarePadding ? length : (int)cropRect.width;
            int dstHeight = squarePadding ? length : (int)cropRect.height;
            return MakeReadable(texture, cropRect, dstWidth, dstHeight);
        }
        public static Texture2D MakeReadable(this Texture2D texture, Rect cropRect, int dstWidth, int dstHeight)
        {
            // Create a transparent texture with the destination dimensions
            Texture2D texture2D = new(dstWidth, dstHeight, TextureFormat.RGBA32, mipChain: false);
            texture2D.SetPixels(Enumerable.Range(0, dstWidth*dstHeight).Select(_ => Color.clear).ToArray());

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
                (dstWidth-(int)cropRect.width)/2, (dstHeight-(int)cropRect.height)/2);
            texture2D.Apply();
            RenderTexture.active = active;
            RenderTexture.ReleaseTemporary(temporary);
            return texture2D;
        }

        public static void SaveAsPNG(this Texture2D _texture, string _fullPath)
        {
            byte[] _bytes = _texture.EncodeToPNG();
            File.WriteAllBytes(_fullPath, _bytes);
            Debug.Log(_bytes.Length / 1024 + "Kb was saved as: " + _fullPath);
        }
    }

    public static partial class CardDataBuilderExt
    {
        public static CardDataBuilder WithNextPhase(this CardDataBuilder t, CardData nextPhase)
        {
            StatusEffectNextPhase se = t.Mod.Get<StatusEffectData>("FrenzyBossPhase2").Edit<StatusEffectData, StatusEffectDataBuilder>().FreeModify<StatusEffectNextPhase>(
                data =>
                {
                    data.name = t._data.name + "Phase2";
                    data.ModAdded = t.Mod;
                    data.nextPhase = nextPhase;
                }).Build() as StatusEffectNextPhase;
            t = t.SetStartWithEffect(new CardData.StatusEffectStacks(se, 1));
            return t;
        }
    }

    public static partial class HopeUtils
    {
        /// <summary>
        /// Remember to add it via TMP_Settings.defaultSpriteAsset.fallbackSpriteAssets.Add(spriteAsset);
        /// </summary>
        /// <param name="Mod"></param>
        /// <param name="directoryWithPNGs"></param>
        /// <param name="textures"></param>
        /// <param name="sprites"></param>
        /// <returns></returns>
        public static TMP_SpriteAsset CreateSpriteAsset(string name, string directoryWithPNGs = null, Texture2D[] textures = null, Sprite[] sprites = null)
        {
            Texture2D[] allTextures = (
                directoryWithPNGs.IsNullOrWhitespace() ? new Texture2D[0] : Directory.GetFiles(directoryWithPNGs, "*.png", SearchOption.AllDirectories)
                    .Select(p => {
                        Texture2D tex = new(1, 1)
                        { name = Path.GetFileNameWithoutExtension(p) };
                        tex.LoadImage(File.ReadAllBytes(p));
                        Debug.Log(tex.name);
                        return tex;
                    })).Concat(sprites is null ? new Texture2D[0] : sprites.Where(s => s != null)
                    .Select(s => {
                         Texture2D tex = s.ToTexture(false);
                         tex.name = s.name;
                         Debug.Log(tex.name);
                         return tex;
                     })).Concat(textures is null ? new Texture2D[0] : textures.Where(t => t != null && t.width > 0 && t.height > 0)
                     .Select(t => t.isReadable ? t : t.MakeReadable())
                     ).ToArray();

            // Initialise the texture atlas
            Texture2D atlas = new(1 << 12, 1 << 12)
            { name = name + ".Sheet" };
            Rect[] rects = atlas.PackTextures(allTextures, 256);
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
                    /*/// "sprite" is not needed, but this is currently useful to see the name of spriteglyphs
                    sprite = new Func<Sprite>(() => 
                    {
                        Texture2D tex = lookup[rect];
                        Sprite s = null;
                        new Action(() =>
                        {
                            s = Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height), Vector2.zero);
                            s.name = tex.name;
                        })
                        // If need to avoid Sprite.Create for performance, comment this out
                        .TimedInvoke();
                        return s; }).Invoke()*/
                };
                spriteAsset.spriteGlyphTable.Add(spriteGlyph);
                TMP_SpriteCharacter spriteCharacter = new(spriteGlyph.index, spriteGlyph) { name = lookup[rect].name };
                spriteAsset.spriteCharacterTable.Add(spriteCharacter);
            }

            spriteAsset.UpdateLookupTables();
            //TMP_Settings.defaultSpriteAsset.fallbackSpriteAssets.Add(spriteAsset);
            return spriteAsset;
        }
        /*public static void UpdateSpriteAsset(TMP_SpriteAsset spriteAsset, Texture2D texture)
        {
        }*/
    }


    /*
    class LearningReferences
    {
        *//*internal class PatchIEnumerator
        {
            class SimpleEnumerator : IEnumerable
            {
                public IEnumerator enumerator;
                public Action prefixAction, postfixAction;
                public Action<object> preItemAction, postItemAction;
                public Func<object, object> itemAction;
                IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
                public IEnumerator GetEnumerator()
                {
                    prefixAction();
                    while (enumerator.MoveNext())
                    {
                        var item = enumerator.Current;
                        preItemAction(item);
                        yield return itemAction(item);
                        postItemAction(item);
                    }
                    postfixAction();
                }
            }

            static void Postfix(ref IEnumerator __result)
            {
                Action prefixAction = () => { Debug.LogWarning("--> beginning"); };
                Action postfixAction = () => { Debug.LogWarning("--> ending"); };
                Action<object> preItemAction = (item) => { Debug.LogWarning($"--> before {item}"); };
                Action<object> postItemAction = (item) => { Debug.LogWarning($"--> after {item}"); };
                Func<object, object> itemAction = (item) =>
                {
                    var newItem = item + "+";
                    Debug.LogWarning($"--> item {item} => {newItem}");
                    return newItem;
                };
                var myEnumerator = new SimpleEnumerator()
                {
                    enumerator = __result,
                    prefixAction = prefixAction,
                    postfixAction = postfixAction,
                    preItemAction = preItemAction,
                    postItemAction = postItemAction,
                    itemAction = itemAction
                };
                __result = myEnumerator.GetEnumerator();
            }
        }*//*
    }*/
}