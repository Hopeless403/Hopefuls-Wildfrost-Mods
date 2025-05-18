using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using UnityEngine;
using BepInEx;
using System;
using System.IO;
using System.Linq;
using Steamworks.Ugc;
using System.Reflection;
using TMPro;
using UnityEngine.SceneManagement;
using System.Collections;
using HarmonyLib.Tools;
using System.Text;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using ICSharpCode.Decompiler.DebugInfo;
using UnityExplorer;
using UnityExplorer.UI;
using UnityEngine.UI;
using FMOD;

namespace WildfrostHopeMod.HarmonySuppressor;
public partial class HarmonySuppressorPlugin : BaseUnityPlugin
{
    [HarmonyPatch(typeof(ModsSceneManager), nameof(ModsSceneManager.Start))]
    [HarmonyPostfix]
    public static IEnumerator FixModsMenu(IEnumerator original, ModsSceneManager __instance)
    {
        yield return original;
        // Sort the mods menu behind the pause menu
        if (SceneManager.Loaded.TryGetValue("Mods", out var scene))
        {
            Canvas canvas = scene.FindObjectOfType<Canvas>()?.transform.Find("SafeArea/Menu")?.GetComponent<Canvas>();
            if (canvas)
                canvas.sortingOrder = -1;
        }
        // Rescale mods properly
        foreach (var transform in __instance.Content.transform.GetAllChildren())
            transform.localScale = Vector3.one;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Bootstrap), nameof(Bootstrap.Start))]
    public static void SkipSplashScreen(Bootstrap __instance)
    {
        __instance.splashScreen = null;
        __instance.startSceneKey = "Town";
    }

    /*[HarmonyPostfix]
    [HarmonyPatch(typeof(ValueType), nameof(ValueType.ToString))]
    public static string StringWrapperToString(string result, ValueType __instance)
    {
        if (__instance is FMOD.StringWrapper wrapper)
            return (string)wrapper;
        else return result;
    }*/
}