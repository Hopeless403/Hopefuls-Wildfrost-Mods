using HarmonyLib;
using Steamworks;
using UnityEngine;

[HarmonyPatch(typeof(SteamManager), nameof(SteamManager.Awake))]
static class PatchSteam
{
    static bool Prefix(SteamManager __instance)
    {
        try
        {
            SteamClient.Init((uint)SteamManager.appId);
            Debug.LogWarning("INIT successfully");
        }
        catch (System.Exception ex)
        {
            Debug.LogError($"Steam failed to initialize! ({ex})");
            Debug.LogWarning("[Harmony Suppressor] Continuing without Steam");
            return false;
        }
        SteamClient.Shutdown();
        return true;
    }
}