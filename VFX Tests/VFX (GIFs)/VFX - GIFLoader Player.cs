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
using static Deadpan.Enums.Engine.Components.Modding.Extensions;

namespace WildfrostHopeMod.VFX;

public partial class GIFLoader
{
    public GameObject TryPlayEffectFromPath(string path)
    {
        if (!prefabs.ContainsKey(Path.GetFileNameWithoutExtension(path)))
            switch (Path.GetExtension(path))
            {
                case "gif": LoadGIFFromPath(path); break;
                case "png": break;
                default: Debug.LogError(Path.GetFileName(path) + " is not a .GIF or (animated) .PNG"); break;
            }
        return TryPlayEffect(Path.GetFileNameWithoutExtension(path));
    }

    /// <summary>
    /// Plays the effect from this.prefabs if it exists
    /// </summary>
    /// <param name="key">The filename without extension</param>
    /// <returns>true if OK; otherwise false</returns>
    public GameObject TryPlayEffect(string key, Vector3 position = default, Vector3 scale = default, PlayType playAs = PlayType.applyEffect)
    {
        if (prefabs.TryGetValue(PrefixGUID(key, Mod), out GameObject prefab))
            return PlayEffect(prefab, position, scale, playAs);

        else if (prefabs.TryGetValue(key, out prefab))
            return PlayEffect(prefab, position, scale, playAs);

        else Debug.LogWarning($"[VFX Tools] Key [{key}] and [{PrefixGUID(key, Mod)}] doesn't exist");
        return null;
    }
    public static GameObject PlayEffect(GameObject gifPrefab, Vector3 position = default, Vector3 scale = default, PlayType playType = PlayType.applyEffect)
    {
        //Debug.LogWarning($"Creating effect {gifPrefab.name} at {position}");
        GameObject go;
        (go = GameObject.Instantiate(gifPrefab, position, Quaternion.identity)).transform.localScale = scale;
        var ga = go.GetComponent<GIFAnimator>();
        bool destroyOnEnd = playType == PlayType.applyEffect || playType == PlayType.damageEffect;
        int loops = playType == PlayType.loopingAnimation ? -1 : 1;
        ga.destroyOnEnd = destroyOnEnd;
        ga.loops = loops;
        OnEffectPlayed?.Invoke(gifPrefab);
        return go;
    }
    public static GameObject PlayRandomEffect(IEnumerable<GameObject> prefabs, PlayType playAs = PlayType.applyEffect)
    {
        if (!prefabs.Any()) return default;
        GameObject prefab = prefabs.RandomItems(1).First();
        PlayEffect(prefab, playType: playAs);
        return prefab;
    }

    public static void InvokeEffectPlayed(GameObject prefab) => GIFLoader.OnEffectPlayed?.Invoke(prefab);
}