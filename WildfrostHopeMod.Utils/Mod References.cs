using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using System;
using owo = System.Object;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization.Tables;
using UnityEngine.Localization;
using UnityEngine.Events;

namespace WildfrostHopeMod.Utils
{
    public class Paths
    {
        public string PluginPath { get; private set; }
        public string ImagesPath { get; private set; }
        public string ConfigPath { get; private set; }
        public static string ExecutablePath => Application.dataPath + "/../";
        // .../steamapps/common/Wildfrost/../

        public static string LogPath => Application.persistentDataPath;
        // .../LocalLow/Deadpan Games/Wildfrost

        public static string ProfilesPath => Application.persistentDataPath + "/Profiles/";
        // .../LocalLow/Deadpan Games/Wildfrost/Profiles/

        public string modDirectory;
        public string SoundsDirectory { get; private set; }
        public string MusicDirectory { get; private set; }

        public Paths(string modDirectory)
        {
            this.modDirectory = modDirectory;
            PluginPath = modDirectory + '/'; // ...StreamingAssets/Mods/Hope
            ImagesPath = modDirectory + "/images/";
            ConfigPath = Path.Combine(modDirectory, "config.cfg");

            SoundsDirectory = modDirectory + "/sounds/";
            MusicDirectory = modDirectory + "/music/";
        }
        public string GetDirectory(string name) => modDirectory + $"/{name}/";
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
                try { Debug.Log($"{field.Name}: {field.GetValue(t) ?? "null"}"); }
                catch { Debug.Log($"{field.Name} failed"); }
            }
            return t;
        }
        public static FieldInfo[] GetAllFields<T>(this T t, Type type = null)
        {
            return (type ?? t.GetType()).GetFields((BindingFlags)0x1FFFFFD);//.Concat(typeof(T).GetFields((BindingFlags)0x1FFFFFF)).ToArray();
        }

        public static List<FieldInfo> CompareFields<T>(this T t, T other)
        {
            List<FieldInfo> differences = new();
            foreach (var field in t.GetAllFields())
            {
                var val1 = field.GetValue(t);
                var val2 = field.GetValue(other);
                if (Equals(val1, val2))
                    continue;
                differences.Add(field);
                Debug.LogWarning($"{field.Name}: {(val1.GetHashCode(), val2.GetHashCode())}");
            }
            return differences;
        }

        public static Card? GetCard(this Entity entity) => entity.display as Card;
    }
    public static class RectTransformExtensions
    {
        public static Vector2 GetSize(this RectTransform source) => source.rect.size;
        public static float GetWidth(this RectTransform source) => source.rect.size.x;
        public static float GetHeight(this RectTransform source) => source.rect.size.y;

        /// <summary>
        /// Sets the sources RT size to the same as the toCopy's RT size.
        /// </summary>
        public static void SetSize(this RectTransform source, RectTransform toCopy)
        {
            source.SetSize(toCopy.GetSize());
        }

        /// <summary>
        /// Sets the sources RT size to the same as the newSize.
        /// </summary>
        public static void SetSize(this RectTransform source, Vector2 newSize)
        {
            source.SetSize(newSize.x, newSize.y);
        }

        /// <summary>
        /// Sets the sources RT size to the new width and height.
        /// </summary>
        public static void SetSize(this RectTransform source, float width, float height)
        {
            source.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, width);
            source.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, height);
        }

        public static void SetWidth(this RectTransform source, float width)
        {
            source.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, width);
        }

        public static void SetHeight(this RectTransform source, float height)
        {
            source.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, height);
        }
    }

    public static class TransformExtensions
    {
        public static void Normalise(this Transform transform)
        {
            transform.localScale = Vector3.one;
            transform.rotation = Quaternion.identity;
        }
        public static Transform InstantiateWithoutChildren(this Transform transform, string detachFrom = null)
        {
            List<Transform> detached = new();
            Transform detacher = (detachFrom != null ? transform.FindRecursive(detachFrom) : transform);
            foreach (var child in detacher.GetAllChildren())
            {
                detached.Add(child);
                child.SetParent(null);
            }
            var result = transform.InstantiateKeepName();
            detached.Update(child => child.SetParent(detacher));
            return result;
        }
        public static RectTransform ToRectTransform(this Transform transform) => transform as RectTransform;
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
        public static LocalizedString CreateLocalizedString(this string text)
        {
            StringTable collection = LocalizationHelper.GetCollection("UI Text", LocalizationSettings.Instance.GetSelectedLocale().Identifier);
            collection.SetString("hope." + text, text);
            return collection.GetString("hope." + text);
        }

        public static Sprite ToSpriteFull(this string path)
        {
            var t = new Texture2D(0, 0, TextureFormat.RGBA32, false)
            {
                name = Path.GetFileNameWithoutExtension(path)
            };
            t.LoadImage(File.ReadAllBytes(path));
            return t.ToSpriteFull();
        }

        public static string Repeat(this string str, int count, string delimiter = "") =>
            count <= 0 ? "" :
            new StringBuilder((str.Length + delimiter.Length) * count)
                .Insert(0, str)
                .Insert(str.Length, delimiter + str, Mathf.Max(0, count - 1))
            .ToString();

        public static string ToTitleCase(this string str)
        {
            str = string.Join(" ", 
                str.ToLowerInvariant().Split(' ').Select(s => 
                    s = s.Substring(0,1).ToUpperInvariant() + s.Substring(1)
                    )
                );
            return str;
        }
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
        public static Sprite ToSpriteFull(this Texture2D t)
        {
            var sprite = Sprite.Create(t, new Rect(0, 0, t.width, t.height), new Vector2(0.5f, 0.5f), 100, 0, SpriteMeshType.FullRect);
            sprite.name = t.name;
            return sprite;
        }
            
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
            int xOffset = (dstWidth - (int)cropRect.width) / 2;
            int yOffset =  (dstHeight - (int)cropRect.height) / 2;
            return MakeReadable(texture, cropRect, dstWidth, dstHeight, xOffset, yOffset);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="texture"></param>
        /// <param name="cropRect"></param>
        /// <param name="dstWidth"></param>
        /// <param name="dstHeight"></param>
        /// <param name="xOffset">Padding left</param>
        /// <param name="yOffset">Padding below</param>
        /// <returns></returns>
        public static Texture2D MakeReadable(this Texture2D texture, Rect cropRect, int dstWidth, int dstHeight, int xOffset, int yOffset)
        {
            // Create a transparent texture with the destination dimensions
            Texture2D texture2D = new(dstWidth, dstHeight, TextureFormat.RGBA32, mipChain: false)
            {
                name = texture.name
            };
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
                xOffset, yOffset);
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
        /// Remember to override your mod's SpriteAsset, AND use .RegisterSpriteAsset()
        /// </summary>
        /// <param name="Mod"></param>
        /// <param name="directoryWithPNGs"></param>
        /// <param name="textures"></param>
        /// <param name="sprites"></param>
        /// <returns></returns>
        public static TMP_SpriteAsset CreateSpriteAsset(string name, string directoryWithPNGs = null, Texture2D[] textures = null, Sprite[] sprites = null)
        {
            List<Texture2D> allTextures = [];

            IEnumerable<Texture2D> texturesFromPNGs = directoryWithPNGs.IsNullOrWhitespace() ? [] : Directory.GetFiles(directoryWithPNGs, "*.png", SearchOption.AllDirectories)
                    .Select(p =>
                    {
                        Texture2D tex = new(1, 1) { name = Path.GetFileNameWithoutExtension(p) };
                        tex.LoadImage(File.ReadAllBytes(p));
                        //Debug.Log(tex.name);
                        return tex;
                    });
            foreach (var tex in texturesFromPNGs)
                if (tex) allTextures.Add(tex);

            IEnumerable<Texture2D> texturesFromSprites = sprites == null || sprites.Length == 0 
                ? [] : sprites?.Where(s => s != null)
                    .Select(s =>
                    {
                        Texture2D tex = s.ToTexture(false);
                        tex.name = s.name;
                        //Debug.Log(tex.name);
                        return tex;
                    }) ?? [];
            foreach (var tex in texturesFromSprites)
            {
                //Debug.Log("Adding sprte " +  tex.name);
                if (tex) allTextures.Add(tex);
            }

            IEnumerable<Texture2D> texturesProvided = textures == null || textures.Length == 0
                ? [] : textures?.Where(t => t != null && t.width > 0 && t.height > 0)
                     .Select(t => t.isReadable ? t : t.MakeReadable()) ?? [];
            foreach (var tex in texturesProvided)
                if (tex) allTextures.Add(tex);

            //Debug.LogError(name + ".Sheet has " + allTextures.Count);

            // Initialise the texture atlas
            Texture2D atlas = new(1 << 12, 1 << 12)
            { name = name + ".Sheet" };
            Rect[] rects = atlas.PackTextures(allTextures.ToArray(), 2);
            Dictionary<Rect, Texture2D> lookup = allTextures.ToDictionary(t => rects[allTextures.IndexOf(t)]);

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
                Debug.LogWarning($"[{spriteAsset.name}] adds glyph [{lookup[rect].name}]");
                TMP_SpriteCharacter spriteCharacter = new(spriteGlyph.index, spriteGlyph) { name = lookup[rect].name };
                spriteAsset.spriteCharacterTable.Add(spriteCharacter);
            }

            spriteAsset.UpdateLookupTables();
            //TMP_Settings.defaultSpriteAsset.fallbackSpriteAssets.Add(spriteAsset);
            return spriteAsset;
        }

        public static GameObject CreateIcon(WildfrostMod modOrNull, string name, Sprite sprite, string type, string copyTextFrom, Color textColor, KeywordData[] keys)
        {
            GameObject gameObject = new GameObject(name);
            UnityEngine.Object.DontDestroyOnLoad(gameObject);
            gameObject.SetActive(false);
            StatusIcon icon = gameObject.AddComponent<StatusIcon>();
            Dictionary<string, GameObject> cardIcons = CardManager.cardIcons;
            if (!copyTextFrom.IsNullOrEmpty())
            {
                GameObject text = cardIcons[copyTextFrom].GetComponentInChildren<TextMeshProUGUI>().gameObject.InstantiateKeepName();
                text.transform.SetParent(gameObject.transform);
                icon.textElement = text.GetComponent<TextMeshProUGUI>();
                icon.textColour = textColor;
                icon.textColourAboveMax = textColor;
                icon.textColourBelowMax = textColor;
            }
            icon.onCreate = new UnityEngine.Events.UnityEvent();
            icon.onDestroy = new UnityEngine.Events.UnityEvent();
            icon.onValueDown = new UnityEventStatStat();
            icon.onValueUp = new UnityEventStatStat();
            icon.afterUpdate = new UnityEngine.Events.UnityEvent();
            UnityEngine.UI.Image image = gameObject.AddComponent<UnityEngine.UI.Image>();
            image.sprite = sprite;
            CardHover cardHover = gameObject.AddComponent<CardHover>();
            cardHover.enabled = false;
            cardHover.IsMaster = false;
            CardPopUpTarget cardPopUp = gameObject.AddComponent<CardPopUpTarget>();
            cardPopUp.keywords = keys;
            cardHover.pop = cardPopUp;
            RectTransform rectTransform = gameObject.GetComponent<RectTransform>();
            rectTransform.anchorMin = Vector2.zero;
            rectTransform.anchorMax = Vector2.zero;
            rectTransform.sizeDelta *= 0.01f;
            gameObject.SetActive(true);
            icon.type = type;
            cardIcons[type] = gameObject;

            return gameObject;
        }

    }

    //[HarmonyPatch(typeof(PopUpAddStatsSystem), nameof(PopUpAddStatsSystem.PopupCreated))]
    public static class PatchPopUpStats
    {
        public static string GetStatText(object current, object max, string color = "#FFFFFF")
            => GetColoredText(current + "/" + max, color);
        public static string GetColoredText(object text, string color = "#FFFFFF")
            => "<color={0}>{1}</color>".Format(color, text);

        public static Dictionary<string, Func<string, Entity, KeywordData, string>> titleActions = new Dictionary<string, Func<string, Entity, KeywordData, string>>();
        public static Dictionary<string, Func<string, Entity, KeywordData, string>> bodyActions = new Dictionary<string, Func<string, Entity, KeywordData, string>>();
        public static Dictionary<string, Func<string, Entity, KeywordData, string>> noteActions = new Dictionary<string, Func<string, Entity, KeywordData, string>>();

        static void Postfix(PopUpAddStatsSystem __instance, Entity ___hover, KeywordData keyword, CardPopUpPanel panel)
        {
            // NOTE: ___hover is the entity that owns the StatusIcon this popup is for!
            if (!___hover)
                return;

            if (titleActions.TryGetValue(keyword.name, out var titleAction))
            {
                panel.titleText = titleAction(panel.titleText, ___hover, keyword);
                panel.BuildTextElement();
            }

            if (bodyActions.TryGetValue(keyword.name, out var bodyAction))
            {
                panel.bodyText = bodyAction(panel.bodyText, ___hover, keyword);
                panel.BuildTextElement();
            }

            if (noteActions.TryGetValue(keyword.name, out var noteAction))
            {
                panel.noteText = noteAction(panel.noteText, ___hover, keyword);
                panel.BuildTextElement();
            }
        }
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