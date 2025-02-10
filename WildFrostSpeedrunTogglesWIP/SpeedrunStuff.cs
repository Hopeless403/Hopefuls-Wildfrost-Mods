using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine;
using WildfrostModMiya;
using HarmonyLib;
using Il2CppInterop.Runtime.Injection;

namespace WildFrostSpeedrunToggles;

[BepInPlugin("WildFrost.Hope.SpeedrunToggles", "Speedrun Toggles", "0.1.0.0")]
[BepInDependency("WildFrost.Miya.WildfrostAPI")]
public class SpeedrunMod : BasePlugin
{
    internal static SpeedrunMod Instance;
    private ConfigEntry<bool> configRemoveAllUnlockableCharms;

    
    private CharacterSelectScreen screen;
    private static readonly bool[] allowedFactions = new bool[3]
    {
        true,
        true,
        true
    };
    private static readonly string[] factionNames = new string[3]
    {
        "Snowdwellers",
        "Shadermancers",
        "Clunkmasters"
    };

    private void Awake() => this.screen = ((Component)this).GetComponent<CharacterSelectScreen>();

    private void OnGUI()
    {
        List<KeyValuePair<ClassData, CharacterSelectScreen.LeaderPool>> list = new List<KeyValuePair<ClassData, CharacterSelectScreen.LeaderPool>>();
        foreach (KeyValuePair<ClassData, CharacterSelectScreen.LeaderPool> leaderPool in this.screen.leaderPools)
            list.Add(leaderPool);
        this.screen.leaderPools.Clear();
    }
}
public class Plugin : BasePlugin
{
    internal static ManualLogSource Log;

    public virtual void Load()
    {
        Plugin.Log = this.Log;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), (string)null);
    }
}