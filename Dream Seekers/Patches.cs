using HarmonyLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

namespace DreamSeekers
{
    [HarmonyPatch]
    internal class Patches
    {
        [HarmonyPrefix]
        //[HarmonyPatch(typeof(StatusEffectSummon), nameof(StatusEffectSummon.SummonPreMade))]
        [HarmonyPatch(typeof(StatusEffectSummon), nameof(StatusEffectSummon.CreateCard))]
        public static void PatchSummon(CardContainer container, ref UnityAction<Entity> onComplete)
        {
            Debug.LogError($"[] Attempting to patch StatusEffectSummon");
            onComplete = PatchSummonModifier(container, onComplete);
        }
        [HarmonyPostfix]
        [HarmonyPatch(typeof(StatusEffectInstantSummon), nameof(StatusEffectInstantSummon.Process))]
        public static IEnumerator PatchSummon(IEnumerator original, bool ___summonCopy, StatusEffectInstantSummon __instance)
        {
            if (!__instance.queue && (!___summonCopy || !Battle.IsOnBoard(__instance.target)))
            {
                yield return original;
                yield break;
            }
            /*if (container.Count < container.max)
            {
                yield return (object)statusEffectSummon.Summon(container, controller, summonedBy);
            }
            else
            {
                Dictionary<Entity, List<CardSlot>> shoveData;
                if (ShoveSystem.CanShove(container.GetTop(), statusEffectSummon.target, out shoveData))
                {
                    yield return (object)ShoveSystem.DoShove(shoveData, true);
                    yield return (object)statusEffectSummon.Summon(container, controller, summonedBy);
                }
                else if (NoTargetTextSystem.Exists())
                    yield return (object)NoTargetTextSystem.Run(statusEffectSummon.target, NoTargetType.NoSpaceToSummon);
            }*/
            Debug.LogError($"[] Attempting to patch StatusEffectInstantSummon.Process");
            StatusEffectInstantSummon effectInstantSummon = __instance;
            if (effectInstantSummon.canSummonMultiple)
            {
                int amount = effectInstantSummon.GetAmount();
                for (int index = 0; index < amount; ++index)
                {
                    if ((__instance.summonPosition & (StatusEffectInstantSummon.Position.InFrontOf)) != 0)
                    {
                        if (Battle.GetCards(__instance.target.owner).Count - index <= 0)
                        {
                            if (NoTargetTextSystem.Exists())
                            {
                                yield return (object)NoTargetTextSystem.Run(__instance.target, NoTargetType.NoSpaceToSummon);
                            }
                            break;
                        }  
                    }
                    else if ((__instance.summonPosition & (StatusEffectInstantSummon.Position.AppliersPosition)) != 0)
                    {
                        if (Battle.GetCards(__instance.applierOwner).Count - index <= 0)
                        {
                            if (NoTargetTextSystem.Exists())
                            {
                                yield return (object)NoTargetTextSystem.Run(__instance.target, NoTargetType.NoSpaceToSummon);
                            }
                            break;
                        }
                    }

                    Debug.LogError($"[] Will {(effectInstantSummon.summonCopy ? "CreateCopyAndTrySummon" : "TrySummon")}");
                    if (effectInstantSummon.summonCopy)
                        yield return effectInstantSummon.CreateCopyAndTrySummon();
                    else
                        yield return (effectInstantSummon.TrySummon());
                }
            }
            else if (effectInstantSummon.queue)
            {
                if (effectInstantSummon.summonCopy)
                {
                    yield return (effectInstantSummon.CreateCopy(effectInstantSummon.target, new UnityAction<Entity>(e => __instance.toSummon = e)));
                }
                ActionSequence action = new ActionSequence(effectInstantSummon.TrySummon())
                {
                    note = "Instant Summon"
                };
                ActionQueue.Stack(action, true);
            }
            else
                yield return (object)effectInstantSummon.TrySummon();
            yield return __instance.Remove();
        }
        internal static UnityAction<Entity> PatchSummonModifier(CardContainer container, UnityAction<Entity> onComplete)
        {
            return entity =>
            {
                onComplete?.Invoke(entity);
                if (Battle.IsOnBoard(container))
                    container.Add(entity);
            };
        }


    }
}
