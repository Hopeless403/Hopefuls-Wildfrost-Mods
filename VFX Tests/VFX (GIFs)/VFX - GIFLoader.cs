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
using static UnityEngine.ParticleSystem;
using HarmonyLib;

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
    public GameObject InstantiatePrefab(string name, bool playOnAwake = false)
    {
        GameObject original = TryGetPrefab(name);
        if (!original) return null;

        if (playOnAwake) return original.InstantiateKeepName();

        original.SetActive(false);
        original.GetComponent<ParticleSystem>().playOnAwake = false;

        var result = original.InstantiateKeepName();
        result.SetActive(true);
        result.GetComponent<ParticleSystem>().playOnAwake = true;

        original.SetActive(true);
        original.GetComponent<ParticleSystem>().playOnAwake = true;

        return result;
    }

    public static bool CreateGifPrefab(string path, int loops, out GameObject prefab, string name = null, bool destroyOnEnd = true)
    {
        if (path == null || !File.Exists(path))
            throw new FileNotFoundException($"[VFX Tools] {path} doesn't exist! Make sure to include \".gif\"");
        name ??= Path.GetFileNameWithoutExtension(path);

        Debug.LogError("Load GIF: " + Path.GetFileName(path));
        
        byte[] data = File.ReadAllBytes(path);

        List<Texture2D> frames = new();
        List<float> delays = new();
        using (var decoder = new Utils.mgGIF.Decoder(data))
        {
            var img = decoder.NextImage();
            while (img != null)
            {
                frames.Add(img.CreateTexture());
                delays.Add(img.Delay / 1000f);
                img = decoder.NextImage();
            }
        }

        ParticleSystem particles = HopeUtils
            .CreateParticleSystem(name, textures: frames.ToArray())
            .WithDelays(delays.ToArray());

        prefab = particles?.gameObject ?? new GameObject(name, typeof(RectTransform), typeof(ParticleSystem));
        particles ??= prefab.GetComponent<ParticleSystem>();

        if (VFXMod.parent) prefab.transform.SetParent(VFXMod.parent);
        else GameObject.DontDestroyOnLoad(prefab);

        var fadeOut = particles.colorOverLifetime;
        fadeOut.enabled = false;

        MainModule main = particles.main;
        main.stopAction = destroyOnEnd ? ParticleSystemStopAction.Destroy : ParticleSystemStopAction.Disable;

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

        ParticleSystem particles;
        if (sprites.All(s => s.texture == sprites[0].texture))
        {
            Debug.Log("creating particle system from one txture: " + sprites[0].texture);
            particles = sprites[0].texture.ToParticleSystem(name, sprites);
        }

        else
        {

            Debug.Log("creating particle system from mulyiple txture: " + sprites.Select(t => t.texture).Distinct().Join()); 
            particles = HopeUtils.CreateParticleSystem(name, sprites: sprites);
        }
            

        prefab = particles?.gameObject ?? new GameObject(name, typeof(RectTransform), typeof(ParticleSystem));
        particles ??= prefab.GetComponent<ParticleSystem>();

        if (VFXMod.parent) prefab.transform.SetParent(VFXMod.parent);
        else GameObject.DontDestroyOnLoad(prefab);

        var fadeOut = particles.colorOverLifetime;
        fadeOut.enabled = false;

        MainModule main = particles.main;
        main.duration = delaySeconds * sprites.Length;
        main.startLifetime = main.duration;
        main.stopAction = destroyOnEnd ? ParticleSystemStopAction.Destroy : ParticleSystemStopAction.Disable;
        main.playOnAwake = true;

        TextureSheetAnimationModule animation = particles.textureSheetAnimation;
        animation.enabled = true;
        animation.startFrame = 0;

        // NOTE: This can be replaced with FPS instead of timer curve
        animation.timeMode = ParticleSystemAnimationTimeMode.Lifetime;
        MinMaxCurve timer = animation.frameOverTime;
        timer.curveMultiplier = 1;
        timer.curve = new AnimationCurve();

        // Both time and value are stored as percentages (between 0 and 1)
        float cumulativeDelay = 0f;
        for (int i = 0; i < sprites.Length; i++) // delays.Length
        {
            timer.curve.AddKey(cumulativeDelay, i * 1f / sprites.Length);
            cumulativeDelay += 1f / sprites.Length;
        }
        // IMPORTANT: Need to reassign the timer
        animation.frameOverTime = timer;

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
