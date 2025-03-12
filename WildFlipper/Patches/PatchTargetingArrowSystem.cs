using HarmonyLib;
using System;
using System.Linq;
using UnityEngine;
using static WildFlipper.WildFlipperMod.BlueBlobble;

/// <summary>
/// Units depend on UnitTargetSystem
/// Items depend on TargetingArrowSystem (no support for aimless)
/// </summary>
[HarmonyPatch(typeof(TargetingArrowSystem))]
public class PatchTargetingArrowSystem
{
    // EMERGENCY GLASS!
    // Just in case other mods want to customise their patch
    /*public static readonly Type[] targetTypes = [
        typeof(TargetModePierce),
                    ];*/

    static TargetingDisplay currentArrow;

    [HarmonyPostfix]
    [HarmonyPatch(nameof(TargetingArrowSystem.Show))]
    public static void Show(TargetingArrowSystem __instance)
    {
        // Break glass in case of emergency (eg random arrows popup on unrelated TargetModes)
        /*if (!targetTypes.Contains(__instance.target?.targetMode.GetType()))
            return;*/

        if (__instance.currentArrow == __instance.targetMulti)
            return;

        currentArrow = __instance.targetMulti;
        currentArrow.gameObject.SetActive(true);
        currentArrow.ResetStyle();
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(TargetingArrowSystem), nameof(TargetingArrowSystem.EntityHover))]
    public static void EntityHover(TargetingArrowSystem __instance, Entity entity)
    {
        if (!currentArrow)
            return;

        Entity[] potentialTargets = __instance.target.targetMode.GetPotentialTargets(__instance.target, entity, null);
        Debug.LogWarning($"potential: {potentialTargets?.Join()}");
        if (potentialTargets == null)
            return;

        if (currentArrow is TargetingMultiple multi)
        {
            multi.entitiesToHit = potentialTargets.Without(entity);
            multi.ShowTargets();
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(TargetingArrowSystem), nameof(TargetingArrowSystem.EntityUnHover))]
    public static void EntityUnHover(TargetingArrowSystem __instance, Entity entity)
    {
        if (!currentArrow)
            return;

        if (currentArrow is TargetingMultiple multi)
        {
            multi.HideTargets();
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(nameof(TargetingArrowSystem.Hide))]
    public static void Hide(TargetingArrowSystem __instance)
    {
        currentArrow?.gameObject.SetActive(false);
        currentArrow = null;
    }
}