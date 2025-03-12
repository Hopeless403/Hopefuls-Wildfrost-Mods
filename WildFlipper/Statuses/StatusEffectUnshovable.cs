using HarmonyLib;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using static SaveSystem;

namespace WildFlipper
{
    public partial class WildFlipperMod
    {


        /// <summary>
        /// Note: For fixed positions, set cardData.priorityPosition = 0;
        /// Blocks summoning
        /// </summary>
        [HarmonyPatch(typeof(ShoveSystem))]
        public class StatusEffectUnshovable : StatusEffectData
        {
            [HarmonyPostfix]
            [HarmonyPatch(nameof(ShoveSystem.FindSlots))]
            static void FindSlots(ref CardSlot[] __result, Entity shovee)
            {
                if (shovee.statusEffects.Any(s => s is StatusEffectUnshovable))
                {
                    Debug.LogError($"Preventing [{shovee}] from having slots to shove to?");
                    __result = null;
                }
            }

            public override void Init()
            {
                Events.OnCheckEntityShove += CheckEntityShove;
            }
            public void OnDestroy()
            {
                Events.OnCheckEntityShove -= CheckEntityShove;
            }

            public void CheckEntityShove(ref Entity entity, ref bool flag)
            {
                if (entity == target && target.enabled && !target.silenced)
                    flag = false;
            }
        }
    }
}
