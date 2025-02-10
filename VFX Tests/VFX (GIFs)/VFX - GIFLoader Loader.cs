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
    /// <summary>
    /// 
    /// </summary>
    /// <param name="dirPath"></param>
    /// <param name="extensions">without the dot, i.e. "wav"</param>
    /// <returns>Automatically goes into SFXLoader.sounds</returns>
    public List<GameObject> LoadGIFsFromDir(string dirPath, PlayType playType = PlayType.applyEffect) =>
        LoadGIFsFromPaths(Dir.GetFiles(dirPath, "*.gif", SearchOption.TopDirectoryOnly)).ToList();
    /// <summary>
    /// 
    /// </summary>
    /// <param name="paths"></param>
    /// <returns>Automatically goes into SFXLoader.sounds</returns>
    public List<GameObject> LoadGIFsFromPaths(string[] paths, PlayType playType = PlayType.applyEffect) =>
        paths.Select(path => LoadGIFFromPath(path)).ToList();








    /// <summary>
    /// 
    /// </summary>
    /// <param name="path"></param>
    /// <returns>Automatically goes into SFXLoader.sounds</returns>
    /// <exception cref="Exception">The FMOD.Result of createSound</exception>
    public GameObject LoadGIFFromPath(string path, string name = null, PlayType playType = PlayType.applyEffect)
    {
        name ??= Path.GetFileNameWithoutExtension(path);
        if (!name.Contains('.')) 
            name = Deadpan.Enums.Engine.Components.Modding.Extensions.PrefixGUID(name, Mod);

        bool destroyOnEnd = playType == PlayType.applyEffect || playType == PlayType.damageEffect;
        int loops = playType == PlayType.loopingAnimation ? -1 : 1;
        var result = CreateGifPrefab(path, loops, out GameObject prefab, name, destroyOnEnd);

        if (prefab == null || !result)
        {
            Debug.LogWarning($"[VFX Tools] Could not load [{name}] from path {path}");
            return null;
        }
        prefabs[name] = prefab;
        Debug.Log($"[VFX Tools] Loaded [{prefab.name}] from path {path}");
        return prefab;
    }
    public GameObject LoadGIF(string name, PlayType playType = PlayType.applyEffect)
    {
        var path = Dir.GetFiles(Directory, $"{name}.*").First();
        return LoadGIFFromPath(path, name, playType);
    }






    public GameObject LoadSprites(string name, Sprite[] sprites, float delaySeconds, PlayType playType = PlayType.applyEffect)
    {
        bool destroyOnEnd = playType == PlayType.applyEffect || playType == PlayType.damageEffect;
        int loops = playType == PlayType.loopingAnimation ? -1 : 1;
        var result = CreateGifPrefabFromSprites(sprites, delaySeconds, loops, out GameObject prefab, name, destroyOnEnd);
        if (prefab == null || !result)
        {
            Debug.LogWarning($"[VFX Tools] Could not load [{prefab}] from sprites");
            return null;
        }
        prefabs[name] = prefab;
        Debug.Log($"[VFX Tools] Loaded [{prefab}] from sprites");
        return prefab;
    }





}