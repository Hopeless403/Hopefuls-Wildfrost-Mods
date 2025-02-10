using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

/// <summary>
/// Manages effects that shouldn't be affected by ink
/// Use by calling .Patch_IgnoreSilenced() on a StatusEffectDataBuilder
/// 
/// Note: Patching traits would require adding all its effects to "patchedEffects"
/// Issues: Doesn't work for attack effects
/// </summary>
[HarmonyPatch]
public static class PatchIgnoreSilence
{
    const string credit = "Credit to Hopeless";
    public static readonly HashSet<string> patchedEffects = new HashSet<string>();

    /// <summary>
    /// Use on StatusEffectDataBuilders to try preventing this effect from being affected by ink
    /// </summary>
    public static StatusEffectDataBuilder Patch_IgnoreSilenced(this StatusEffectDataBuilder effectBuilder)
    {
        effectBuilder._data.Patch_IgnoreSilenced();
        return effectBuilder;
    }
    /// <summary>
    /// Use on StatusEffectDatas to try preventing this effect from being affected by ink
    /// </summary>
    public static void Patch_IgnoreSilenced(this StatusEffectData effect)
    {
        if (effect != null)
            patchedEffects.Add(effect.name);
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(StatusEffectData), nameof(StatusEffectData.GetDesc))]
    private static void PatchEffectText(StatusEffectData __instance, ref bool silenced)
    {
        if (__instance == null)
        {
            Debug.LogWarning($"Effect [{__instance}] of [{__instance?.target.name}] is broken");
            return;
        }

        if (patchedEffects.Contains(__instance?.name))
            silenced = false; 
    }
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Card), nameof(Card.GetTraitText))]
    private static void PatchTraitText(Card __instance, TraitData trait, ref bool silenced)
    {
        if (trait == null || trait.effects == null)
        {
            Debug.LogWarning($"TraitData [{trait}] of [{__instance?.name}] is broken");
            return;
        }

        // If all effects are patched, treat the trait as patched too
        if (trait.effects.All(effect => patchedEffects.Contains(effect?.name)))
            silenced = false;
    }
    

    /// <summary>
    /// Certain effects look at target.silenced (or .TargetSilenced()) to determine whether to run
    /// Before that, patch it to false ONLY IF the effect is "patched"
    /// 
    /// Issues: * Only the first of the same class of effect can be patched this way
    ///         eg, Ice Forge's first While Active can be patched, but not its second
    ///         * TargetConstraintHasTrait won't detect patched traits
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(Entity), nameof(Entity.silenced), MethodType.Getter)]
    private static void PatchEntitySilenced(Entity __instance, ref bool __result)
    {
        bool isEffectPatched = false;

        // Get the list of methods that lead here, starting from most recent
        System.Diagnostics.StackFrame[] frames = new System.Diagnostics.StackTrace(fNeedFileInfo: true).GetFrames();
        for (int i = 0; i < frames.Length; i++)
        {
            // Does the method belong to a StatusEffectData class?
            MethodBase method = frames[i].GetMethod();
            if (typeof(StatusEffectData).IsAssignableFrom(method.DeclaringType))
            {
                // Check if the effect is patched
                StatusEffectData effect = __instance.statusEffects.FirstOrDefault(e => e.GetType() == method.DeclaringType);
                if (patchedEffects.Contains(effect?.name))
                {
                    isEffectPatched = true;
                    continue;
                }
            }
        }

        if (isEffectPatched)
            __result = false;
    }

    /// <summary>
    /// To make patched Recycle/Destroy effects show targets
    /// 99% copied from base code
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(DestroyTargetSystem), nameof(DestroyTargetSystem.ShowTargets))]
    private static void PatchDestroyTargetSystem(DestroyTargetSystem __instance, Entity entity, HashSet<Entity> ___toIndicate)
    {
        foreach (StatusEffectData statusEffect in entity.statusEffects.Where(s => patchedEffects.Contains(s?.name)))
        {
            StatusEffectApplyX applyEffect = statusEffect as StatusEffectApplyX;
            if (applyEffect != null && !statusEffect.doesDamage)
            {
                if (DestroyTargetSystem.CheckStatusEffectType(applyEffect))
                {
                    if ((applyEffect.applyToFlags & StatusEffectApplyX.ApplyToFlags.Hand) != 0)
                    {
                        DestroyTargetSystem.CheckShowIconsForHand(applyEffect, ___toIndicate);
                    }

                    if ((applyEffect.applyToFlags & StatusEffectApplyX.ApplyToFlags.RightCardInHand) != 0)
                    {
                        DestroyTargetSystem.CheckShowIconsForRightCardInHand(applyEffect, ___toIndicate);
                    }

                    continue;
                }

                StatusEffectInstantDestroyCardsInHandAndApplyXForEach destroyAllEffect = applyEffect.effectToApply as StatusEffectInstantDestroyCardsInHandAndApplyXForEach;
                if (destroyAllEffect != null)
                {
                    ___toIndicate.AddRange(References.Player.handContainer.Where(
                        card => card != applyEffect.target && destroyAllEffect.CheckConstraints(card)
                        ));
                }
            }
            else
            {
                if (statusEffect is not StatusEffectRecycle statusEffectRecycle)
                {
                    continue;
                }

                int num = statusEffectRecycle.GetAmount();
                foreach (Entity item in References.Player.handContainer)
                {
                    if (item.data.name == statusEffectRecycle.cardToRecycle)
                    {
                        ___toIndicate.Add(item);
                        if (--num <= 0)
                        {
                            break;
                        }
                    }
                }
            }
        }

        foreach (Entity entityToIndicate in ___toIndicate)
        {
            __instance.ShowIcon(entityToIndicate);
        }

        ___toIndicate.Clear();
    }
}