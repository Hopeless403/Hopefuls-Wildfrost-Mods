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
using LibAPNG;

namespace WildfrostHopeMod.VFX;

public partial class GIFLoader
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="dirPath"></param>
    /// <param name="extensions">without the dot, i.e. "png" or "apng"</param>
    /// <returns>Automatically goes into gifLoader.prefabs</returns>
    public List<GameObject> LoadAPNGsFromDir(string dirPath, PlayType playType = PlayType.applyEffect)
    {
        return
        [
            .. LoadAPNGsFromPaths(Dir.GetFiles(dirPath, "*.png", SearchOption.TopDirectoryOnly)),
            .. LoadAPNGsFromPaths(Dir.GetFiles(dirPath, "*.apng", SearchOption.TopDirectoryOnly)),
        ];
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="paths"></param>
    /// <returns>Automatically goes into gifLoader.prefabs</returns>
    public List<GameObject> LoadAPNGsFromPaths(string[] paths, PlayType playType = PlayType.applyEffect) => 
        paths.Select(path => LoadAPNGFromPath(path)).ToList();

    

    /// <summary>
    /// 
    /// </summary>
    /// <param name="path"></param>
    /// <returns>Automatically goes into SFXLoader.sounds</returns>
    /// <exception cref="Exception">The FMOD.Result of createSound</exception>
    public GameObject LoadAPNGFromPath(string path, string name = null, PlayType playType = PlayType.applyEffect)
    {
        //Debug.LogWarning($"[VFX Tools] Loading from path {path}");
        name ??= Path.GetFileNameWithoutExtension(path);
        if (!name.Contains('.'))
            name = Deadpan.Enums.Engine.Components.Modding.Extensions.PrefixGUID(name, Mod);

        bool destroyOnEnd = playType == PlayType.applyEffect || playType == PlayType.damageEffect;
        int loops = playType == PlayType.loopingAnimation ? -1 : 1;
        var result = CreateAPNGPrefab(path, loops, out GameObject prefab, name, destroyOnEnd);

        if (prefab == null || !result)
        {
            Debug.LogError($"[VFX Tools] Could not load [{name}] from path {path}");
            return null;
        }
        name ??= Path.GetFileNameWithoutExtension(path);
        prefabs[name] = prefab;
        Debug.Log($"[VFX Tools] Loaded [{prefab.name}] from path {path}");
        return prefab;
    }
    public GameObject LoadAPNG(string name, PlayType playType = PlayType.applyEffect)
    {
        var path = Dir.GetFiles(Directory, $"{name}.*").First();
        return LoadAPNGFromPath(path, name, playType);
    }

    public static bool CreateAPNGPrefab(string path, int loops, out GameObject prefab, string name = null, bool destroyOnEnd = true)
    {
        if (!File.Exists(path))
            throw new FileNotFoundException($"[VFX Tools] {path} doesn't exist! Make sure to include \".apng\"");
        var apng = new APNG(path);
        if (apng.IsSimplePNG)
        {
            Debug.LogWarning($"[VFX Tools] {path} isn't animated! Skipping...");
            prefab = null;
            return false;
        }

        name ??= Path.GetFileNameWithoutExtension(path);

        Debug.LogError("Load APNG: " + Path.GetFileName(path));
        
        byte[] data = File.ReadAllBytes(path);

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
        {
            List<Sprite> frames = new();
            List<float> delays = new();
            List<Frame> images = new();

            foreach (var apngFrame in apng.Frames)
            {
                images.Add(apngFrame);
                delays.Add((float)apngFrame.fcTLChunk.DelayNum / apngFrame.fcTLChunk.DelayDen);
            }

            frames = images.Select(FrameToSprite).ToList();
            gifAnimator.frames = frames.ToArray();
            gifAnimator.delays = delays.ToArray();
        }


        if (gifAnimator.frames.Length == 0)
        {
            Debug.LogError($"[VFX Tools] {path} cannot be read!");
            prefab.Destroy();
            return false;
        }
        /*if (gifAnimator.frames.Length == 1)
        {
            Debug.LogError($"[VFX Tools] {path} isn't animated!");
            prefab.Destroy();
            return false;
        }*/
        gifAnimator.enabled = true;
        Debug.LogWarning($"[VFX Tools] Created prefab: [{name}] with ID {prefab.GetInstanceID()}!");
        return true;
    }






    static Sprite FrameToSprite(Frame frame)
    {
        uint xOffset = frame.fcTLChunk.XOffset;
        uint yOffset = frame.fcTLChunk.YOffset;
        int targetWidth = frame.IHDRChunk.Width;
        int targetHeight = frame.IHDRChunk.Height;

        Texture2D texture = new Texture2D(2, 2);
        texture.LoadImage(frame.GetStream().ToArray());
        /*texture = texture.MakeReadable(
            new Rect(0, 0, texture.width, texture.height),
            targetWidth,
            targetHeight,
            (int)xOffset,
            (int)(targetHeight - texture.height - yOffset)
            );*/
        Sprite sprite = texture.ToSpriteFull(); // WIP
        return sprite;
    }




}