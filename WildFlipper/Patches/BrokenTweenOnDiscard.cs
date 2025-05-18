using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;
using WildfrostHopeMod.VFX;

[HarmonyPatch]
public static class BrokenTweenOnDiscard
{
    [HarmonyPrefix]
    [HarmonyPatch(typeof(CardPocket.PositionHandler), nameof(CardPocket.PositionHandler.Update))]
    public static void Update(CardPocket.PositionHandler __instance, float delta)
    {
        if (__instance.pocket != References.Player.discardContainer) return;
        if (__instance.delay > 0) return;
        LeanTween.cancel(__instance.entity.gameObject);
    }
}
