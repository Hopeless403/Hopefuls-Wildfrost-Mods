using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using UnityEngine;
using BepInEx;
using Steamworks;
using System;
using System.IO;
using System.Linq;
using static Config;
using Steamworks.Ugc;
using System.Collections.Generic;
using System.Reflection;
using TMPro;
using UnityEngine.SceneManagement;
using System.Collections;
using BCE;
using HarmonyLib.Tools;
using System.Text;
using UnityEngine.UI;
using static UnityEngine.UI.Button;

namespace WildfrostHopeMod.HarmonySuppressor;
public class HarmonySuppressor : WildfrostMod
{
    public HarmonySuppressor(string modDirectory) : base(modDirectory)
    {
        FromConfigs().ReadFromFile(Path.Combine(ModDirectory, "config.cfg"));
        enable = (bool)FromConfigs().Store.First().field.GetValue(this);
        enableError = (bool)FromConfigs().Store.Last().field.GetValue(this);
        Debug.LogError("[Harmony Suppressor] Suppressing Harmony? = " + enable);
        Debug.LogError("[Harmony Suppressor] Quieter Errors? = " + enableError);
        if (!enableError)
            PatchErrorLog.tries++;
        if (!enable) return;
        HarmonyLib.Tools.Logger.ChannelFilter = HarmonyLib.Tools.Logger.LogChannel.Warn | HarmonyLib.Tools.Logger.LogChannel.Error;
        HarmonyInstance.PatchAll();

        Application.logMessageReceived += PatchErrorLog.CheckError;
    }
    [ConfigItem(true, null, "Enable Harmony Suppressor?")]
    public bool enable;
    [ConfigItem(true, null, "Enable Quieter Errors?")]
    public bool enableError;
    static bool Prefix() { Postfix(); return false; }
    static void Postfix() => HarmonyLib.Tools.Logger.ChannelFilter = HarmonyLib.Tools.Logger.LogChannel.None;
    public override string GUID => "hope.wildfrost.harmony";
    public override string[] Depends => new string[0];
    public override string Title => "Harmony Suppressor";
    public override string Description => "Suppress harmony logs and shorten error messages. ONLY INSTALLATION IS REQUIRED!!\r\nCan help with startup and mod load/unloading times, since every INSTALLED mod will try to log the same thing multiple times. Enable/Disable through the configs\r\n\r\nFor example, booting up the game causes every installed mod to announce its existence, but so will every mod before it announce the same thing. So if you have 10 installed mods (+1 for the base game), instead of logging 11 times the game does it 1+2+...+11 = 66 times. It does this for every individual HarmonyPatch too. Insanity.\r\n\r\nAt the very least this makes the job of looking through logs and debugging MUCH more tolerable.";

    //[HarmonyPatch(typeof(ErrorHandlerSystem), nameof(ErrorHandlerSystem.ShowError))]
    public class PatchErrorLog
    {
        internal static int tries = 0;
        public static IEnumerator CheckErrorRoutine()
        {
            yield return null;
            if (ErrorHandlerSystem.errorCount <= 0)
                yield break;

            if (tries > 0)
                yield break;

            ++tries;
            var handler = GameObject.FindObjectOfType<ErrorHandlerSystem>();
            if (!handler)
                yield break;

            if (handler.errorDisplay.activeSelf)
            {
                Debug.LogWarning("[Harmony Suppressor] FIXING");
                string[] lines = handler.errorText.text.Split('\n');
                for (int i = 0; i < lines.Length; i++)
                {
                    int index = lines[i].IndexOf(") (at <");
                    if (index >= 0)
                        lines[i] = lines[i].Substring(0, index+1);
                }
                handler.errorText.text = lines.Join(delimiter: "\n");
            }
            tries = 0;
        }
        public static void CheckError(string log, string stacktrace, LogType type)
        {
            if (type != LogType.Exception)
                return;
            CoroutineManager.Start(CheckErrorRoutine());
        }
    }
}