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

namespace WildfrostHopeMod.VFX;

public partial class GIFLoader
{
    /// <param name="paths"></param>
    /// <returns>Automatically goes into SFXLoader.sounds</returns>
    public async Task LoadGIFsFromPathsAsync(string[] paths, PlayType playType = PlayType.applyEffect)
    {
        Debug.LogError("[VFX Tools] Starting LOAD async");
        await Task.WhenAll(paths.Select(path => LoadGIFFromPathAsync(path)));
        Debug.LogError("[VFX Tools] Ending LOAD async");
    }

    public async Task<GameObject> LoadGIFFromPathAsync(string path, string name = null, PlayType playType = PlayType.applyEffect)
    {
        Debug.LogError("[VFX Tools] Starting LOADGIF async");
        bool destroyOnEnd = playType == PlayType.applyEffect || playType == PlayType.damageEffect;
        int loops = playType == PlayType.loopingAnimation ? -1 : 1;
        GameObject prefab = await CreateGifPrefabAsync(path, loops, name, destroyOnEnd);
        Debug.LogError("[VFX Tools] Ending LOADGIF async");
        if (prefab == null)
        {
            Debug.LogWarning($"[VFX Tools] Could not load {prefab} from path {path}");
            return null;
        }
        name ??= Path.GetFileNameWithoutExtension(path);
        prefabs[name] = prefab;
        Debug.Log($"[VFX Tools] Async Loaded {prefab} from path {path}");
        return prefab;
    }
    public static async Task<GameObject> CreateGifPrefabAsync(string path, int loops, string name = null, bool destroyOnEnd = true)
    {
        if (!File.Exists(path))
            throw new FileNotFoundException($"[VFX Tools] {path} doesn't exist! Make sure to include \".gif\"");
        name ??= Path.GetFileNameWithoutExtension(path);

        Debug.LogError("Load vs GIF async");

        byte[] data = new byte[0];
        GameObject prefab = null;
        GIFAnimator gifAnimator = null;
        new Task(new Action(() =>
        {
            StopWatch.Start();
            data = File.ReadAllBytes(path);

            prefab = new GameObject(name, typeof(SpriteRenderer));
            GameObject.DontDestroyOnLoad(prefab);
            prefab.SetLayerRecursively(8);
            prefab.GetComponent<SpriteRenderer>().sortingLayerID = -2147482037;
            gifAnimator = prefab.AddComponent<GIFAnimator>();
            gifAnimator.frames = new Sprite[0];
            gifAnimator.originalID = prefab.GetInstanceID();
            gifAnimator.loops = loops;
            gifAnimator.destroyOnEnd = destroyOnEnd;
            Debug.LogError("load v gif");
        })).RunSynchronously();

        List<Sprite> frames = new();
        List<float> delays = new();
        List<Utils.mgGIF.Image> images = new();

        new Task(() => Debug.LogWarning("frame method " + name)).RunSynchronously();
        using (var decoder = new Utils.mgGIF.Decoder(data))
        {
            float delay = 1 / 24;
            var img = decoder.NextImage();
            while (img != null)
            {
                images.Add(img);
                delays.Add(delay = img.Delay / 1000f);
                img = decoder.NextImage();
            }
        };

        var textures = new List<Texture2D>();
        new Task(() =>
        {
            foreach (var image in images)
            {
                Texture2D texture = image.CreateTexture();
                frames.Add(Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f), 100, 0, SpriteMeshType.FullRect));
            }
            gifAnimator.frames = frames.ToArray();
            gifAnimator.delays = delays.ToArray();
        }).RunSynchronously();

        Debug.LogWarning($"[VFX Tools] Created prefab: [{name}]??");

        if (gifAnimator.frames.Length == 0)
        {
            Debug.LogError($"[VFX Tools] {path} cannot be read!");
            prefab.Destroy();
            return null;
        }
        gifAnimator.enabled = true;
        Debug.LogWarning($"[VFX Tools] Created prefab: [{name}] with ID {prefab.GetInstanceID()}!");
        return prefab;
    }
}