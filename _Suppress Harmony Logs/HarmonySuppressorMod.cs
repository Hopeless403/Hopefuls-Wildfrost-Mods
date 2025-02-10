using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using UnityEngine;
using System.IO;
using System.Linq;

namespace WildfrostHopeMod.HarmonySuppressor;

public class HarmonySuppressorMod : WildfrostMod
{
    public HarmonySuppressorMod() : base()
    {
        // Prevent conflict with personal Harmony Plugin
        HarmonyInstance.UnpatchSelf();
        //HarmonyInstance.PatchAll();

        // Run based on configs
        FromConfigs().ReadFromFile(Path.Combine(ModDirectory, "config.cfg"));
        enable = (bool)FromConfigs().Store.First().field.GetValue(this);
        Debug.LogError("[Harmony Suppressor] Suppressing Harmony? = " + enable);
        if (!enable) return;

        HarmonyLib.Tools.Logger.ChannelFilter = (HarmonyLib.Tools.Logger.LogChannel)0b011000;
        // Output patched methods: None
        Debug.LogWarning(HarmonyInstance.GetPatchedMethods().Select(m => m.Name).ToArray().DefaultIfEmpty("None").Join());
        // Patch specific method defined in a patch class
        HarmonyInstance.PatchAll(typeof(HarmonySuppressorPlugin.PatchHarmony));
        // Output patched methods: WriteLine
        Debug.LogWarning(HarmonyInstance.GetPatchedMethods().Select(m => m.Name).ToArray().DefaultIfEmpty("None").Join());

    }
    [ConfigItem(true, null, "Enable Harmony Suppressor?")]
    public bool enable;
    static bool Prefix() { Postfix(); return false; }
    static void Postfix() => HarmonyLib.Tools.Logger.ChannelFilter = HarmonyLib.Tools.Logger.LogChannel.None;
    public override string GUID => "hope.wildfrost.harmony";
    public override string[] Depends => new string[0];
    public override string Title => "Harmony Suppressor";
    public override string Description => "Suppress harmony logs. ONLY INSTALLATION IS REQUIRED!!\r\nCan help with startup and mod load/unloading times, since every INSTALLED mod will try to log the same thing multiple times. Enable/Disable through the configs\r\n\r\nFor example, booting up the game causes every installed mod to announce its existence, but so will every mod before it announce the same thing. So if you have 10 installed mods (+1 for the base game), instead of logging 11 times the game does it 1+2+...+11 = 66 times. It does this for every individual HarmonyPatch too. Insanity.\r\n\r\nAt the very least this makes the job of looking through logs and debugging MUCH more tolerable.";
}
