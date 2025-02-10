using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;
using Dir = System.IO.Directory;
using WildfrostHopeMod.Utils;
using UnityEngine.Networking;
using Deadpan.Enums.Engine.Components.Modding;
using static Deadpan.Enums.Engine.Components.Modding.Extensions;

namespace WildfrostHopeMod.VFX;

public partial class GIFLoader
{
    public enum PlayType
    {
        applyEffect, // play once, destroy on end, register to VfxStatusSystem.Profiles
        damageEffect, // play once, destroy on end, register to VfxStatusSystem.DamageProfiles
        loopingAnimation, // play forever, don't destroy on end
        oneshotAnimation, // play once, don't destroy on end
    }

    [Obsolete("Use the version with first argument WildfrostMod", false)]
    public GIFLoader(string directory, PlayType playType = PlayType.applyEffect, bool lookThroughSubfolders = true, bool initialize = true)
    : this(null, directory, playType, lookThroughSubfolders, initialize) { }

    /// <summary>
    /// Create a VFX manager for using animations from GIFs or APNGs (mainly for statuses). Names will use the mod GUID prefix by default
    /// </summary>
    /// <param name="modOrNull">mod to prefix the GUID. Set null if it should be empty</param>
    /// <param name="directory"></param>
    /// <param name="playType"></param>
    /// <param name="lookThroughSubfolders"></param>
    /// <param name="initialize">if true: auto-import all animations now instead of manually</param>
    public GIFLoader(WildfrostMod modOrNull, string directory, PlayType playType = PlayType.applyEffect, bool lookThroughSubfolders = true, bool initialize = true)
    {
        Mod = modOrNull;
        Debug.LogWarning($"[VFX Tools] GIF LOADER for [{modOrNull?.GUID}], init = " + initialize);
        Directory = directory;
        LookThroughSubfolders = lookThroughSubfolders;
        if (initialize) Initialize(playType);// asTask);
    }
    public WildfrostMod Mod { get; }
    public string Directory { get; }
    public bool LookThroughSubfolders { get; }

    public static event Action<GameObject> OnEffectPlayed;

    /// <summary>
    /// Automatically filled whenever any LoadGIF..() is called
    /// </summary>
    public readonly Dictionary<string, GameObject> prefabs = new();

    /// <summary>
    /// Initialize both GIFs and APNGs (.png)
    /// </summary>
    public void Initialize(PlayType playType = PlayType.applyEffect)
    {
        Debug.Log("[VFX Tools] VFX Init");
        SearchOption s = LookThroughSubfolders ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;

        LoadGIFsFromPaths(Dir.GetFiles(Directory, "*.gif", s), playType);
        //Debug.LogWarning($"[VFX Tools] VFX Init result: Count = {prefabs.Count}, Keys = {string.Join(", ", prefabs.Keys)}");

        InitializeAPNGs(playType);
    }
    public void InitializeSprites(PlayType playType = PlayType.applyEffect, params (string name, Sprite[] sprites, float delaySeconds)[] spriteLists)
    {
        Debug.Log("[VFX Tools] VFX Init sprites");
        SearchOption s = LookThroughSubfolders ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;

        foreach (var data in spriteLists)
            LoadSprites(data.name, data.sprites, data.delaySeconds, playType);

        Debug.LogWarning($"[VFX Tools] VFX Init sprites result: Count = {prefabs.Count}, Keys = {string.Join(", ", prefabs.Keys)}");
    }
    public void InitializeAPNGs(PlayType playType = PlayType.applyEffect)
    {
        Debug.Log("[VFX Tools] VFX Init apngs");
        SearchOption s = LookThroughSubfolders ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;

        LoadAPNGsFromPaths(Dir.GetFiles(Directory, "*.png", s), playType);
        LoadAPNGsFromPaths(Dir.GetFiles(Directory, "*.apng", s), playType);
        Debug.LogWarning($"[VFX Tools] VFX Init apngs result: Count = {prefabs.Count}, Keys = {string.Join(", ", prefabs.Keys)}");
    }
    public void InitializeGIFs(PlayType playType = PlayType.applyEffect)
    {
        Debug.Log("[VFX Tools] VFX Init gifs");
        SearchOption s = LookThroughSubfolders ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;

        string[] paths = [];
        LoadGIFsFromPaths(Dir.GetFiles(Directory, "*.gif", s), playType);
        Debug.LogWarning($"[VFX Tools] VFX Init gifs result: Count = {prefabs.Count}, Keys = {string.Join(", ", prefabs.Keys)}");
    }

    public GameObject TryGetPrefab(string name) => prefabs.GetValueOrDefault(PrefixGUID(name, Mod), null) ?? prefabs.GetValueOrDefault(name, null);

    public static bool CreateGifPrefab(string path, int loops, out GameObject prefab, string name = null, bool destroyOnEnd = true)
    {
        if (path == null || !File.Exists(path))
            throw new FileNotFoundException($"[VFX Tools] {path} doesn't exist! Make sure to include \".gif\"");
        name ??= Path.GetFileNameWithoutExtension(path);

        Debug.LogError("Load GIF: " + Path.GetFileName(path));
        
        byte[] data = File.ReadAllBytes(path);



        /*prefab = new GameObject(name, typeof(RectTransform), typeof(ParticleSystem));
        if (VFXMod.parent) prefab.transform.SetParent(VFXMod.parent);
        else GameObject.DontDestroyOnLoad(prefab);
        prefab.SetLayerRecursively(8);
        ParticleSystem particles = prefab.GetComponent<ParticleSystem>();
        ParticleSystem.TextureSheetAnimationModule animation = particles.textureSheetAnimation;


        using (var decoder = new Utils.mgGIF.Decoder(data))
        {
            List<Sprite> frames = new();
            List<float> delays = new();
            float delay = 1 / 24;
            var img = decoder.NextImage();
            var allimg = new List<Utils.mgGIF.Image>();

            bool framesDebugMethod = false;
            while (img != null)
            {
                if (!framesDebugMethod)
                {
                    Texture2D texture = img.CreateTexture();
                    frames.Add(Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f), 100, 0, SpriteMeshType.FullRect));
                }
                allimg.Add(img);
                delays.Add(delay = img.Delay / 1000f);
                img = decoder.NextImage();
            }
            if (framesDebugMethod) frames = ImagesToFrames(allimg);
            foreach (var frame in frames)
                animation.AddSprite(frame);

            animation.mode = ParticleSystemAnimationMode.Sprites;
            ParticleSystem.MinMaxCurve framer = animation.frameOverTime;
            
            framer.curve = new AnimationCurve();
            float cumulativeDelay = 0f;
            for (int i = 0; i < frames.Count; i++)
            {
                framer.curve.AddKey(cumulativeDelay, i);
                cumulativeDelay += delays[i];
            }
            
            animation.frameOverTime = framer;
        }*/

        prefab = new GameObject(name, typeof(SpriteRenderer));
        if (VFXMod.parent) prefab.transform.SetParent(VFXMod.parent);
        else GameObject.DontDestroyOnLoad(prefab);
        prefab.SetLayerRecursively(8);
        prefab.GetComponent<SpriteRenderer>().sortingLayerID = -2147482037;
        var gifAnimator = prefab.AddComponent<GIFAnimator>();
        if (gifAnimator == null) 
            return false;

        gifAnimator.frames = new Sprite[0];
        gifAnimator.originalID = prefab.GetInstanceID();
        gifAnimator.loops = loops;
        gifAnimator.destroyOnEnd = destroyOnEnd;

        using (var decoder = new Utils.mgGIF.Decoder(data))
        {
            List<Sprite> frames = new();
            List<float> delays = new();
            float delay = 1 / 24;
            var img = decoder.NextImage();
            var allimg = new List<Utils.mgGIF.Image>();

            bool framesDebugMethod = false;
            while (img != null)
            {
                if (!framesDebugMethod)
                {
                    Texture2D texture = img.CreateTexture();
                    frames.Add(Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f), 100, 0, SpriteMeshType.FullRect));
                }
                allimg.Add(img);
                delays.Add(delay = img.Delay / 1000f);
                img = decoder.NextImage();
            }
            if (framesDebugMethod) frames = ImagesToFrames(allimg);
            gifAnimator.frames = frames.ToArray();
            gifAnimator.delays = delays.ToArray();
        }


        if (gifAnimator.frames.Length == 0)
        {
            Debug.LogError($"[VFX Tools] {path} cannot be read!");
            prefab.Destroy();
            return false;
        }
        gifAnimator.enabled = true;


        Debug.LogWarning("IS IT OKAY?");
        Debug.LogWarning($"[VFX Tools] Created prefab: [{name}] with ID {prefab.GetInstanceID()}!");
        return true;
    }
    public static bool CreateGifPrefabFromSprites(Sprite[] sprites, float delaySeconds, int loops, out GameObject prefab, string name = null, bool destroyOnEnd = true)
    {
        if (sprites == null || sprites.Length == 0)
            throw new NullReferenceException($"[VFX Tools] Sprites list is empty!");

        int nulls = sprites.ToList().IndexOf(null);
        if (nulls != -1)
            throw new NullReferenceException($"[VFX Tools] There is a null sprite at index {nulls}");
        name ??= sprites.First().name;

        Debug.LogError("GIF from sprites:");

        prefab = new GameObject(name, typeof(SpriteRenderer));
        if (VFXMod.parent) prefab.transform.SetParent(VFXMod.parent);
        else GameObject.DontDestroyOnLoad(prefab);
        prefab.SetLayerRecursively(8);
        prefab.GetComponent<SpriteRenderer>().sortingLayerID = -2147482037;
        var gifAnimator = prefab.AddComponent<GIFAnimator>();
        gifAnimator.frames = new Sprite[0];
        gifAnimator.originalID = prefab.GetInstanceID();
        gifAnimator.loops = loops;
        gifAnimator.destroyOnEnd = destroyOnEnd;

        gifAnimator.frames = sprites;
        gifAnimator.delays = sprites.Select(_ => delaySeconds).ToArray();

        gifAnimator.enabled = true;

        /*prefab = new GameObject(name, typeof(RectTransform), typeof(ParticleSystem));
        Debug.LogWarning("IS IT OKAY?");*/


        Debug.LogWarning($"[VFX Tools] Created prefab: [{name}] with ID {prefab.GetInstanceID()}!");
        return true;
    }

    static List<Sprite> ImagesToFrames(List<Utils.mgGIF.Image> images)
    {
        var img = images.First();
        var raw = new List<Color32>();
        Texture2D texture = new Utils.mgGIF.Image()
        {
            Width = img.Width,
            Height = img.Height * images.Count,
            RawImage = raw.ToArray()
        }.CreateTexture();

        var frames = new List<Sprite>();
        int offset = 0;
        foreach (var image in images)
        {
            frames.Add(
                Sprite.Create(texture, new Rect(0, offset, image.Width, image.Height), new Vector2(0.5f, 0.5f), 100, 0, SpriteMeshType.FullRect)
                );
            offset += image.Height;
        }

        return frames;
    }
}
