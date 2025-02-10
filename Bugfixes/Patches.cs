using HarmonyLib;
using NaughtyAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace WildfrostHopeMod.Bugfixes
{
    [HarmonyPatch(typeof(References), nameof(References.Classes), MethodType.Getter)]
    class PatchClassesGetter : Patch
    {
        public override string desc => """
            Keeps the References.Classes synced with AddressableLoader due to changes from mods

            Affects:
            * Tribe flags not appearing for modded cards in base pools
            * Locked tribes being accessible in the Tribe Select screen
            """;
        static void Postfix(ref ClassData[] __result) => __result = AddressableLoader.GetGroup<ClassData>("ClassData").ToArray();
    }
    [HarmonyPatch(typeof(CampaignNodeTypeCurseItems), nameof(CampaignNodeTypeCurseItems.SetUp))]
    class PatchGnomeTravellerIllegalCards : Patch
    {
        public override string desc => """
            Keeps the References.Classes synced with AddressableLoader due to changes from mods

            Affects:
            * Tribe flags not appearing for modded cards in base pools
            * Locked tribes being accessible in the Tribe Select screen
            """;
        static void Prefix(ref ClassData[] ___illegalCards)
        {
            foreach (var card in ___illegalCards)
            {
                Debug.LogWarning((card, card.GetInstanceID()));
                var actual = AddressableLoader.Get<CardData>(card.name);
                Debug.Log((actual, actual.GetInstanceID()));
            }
        }
    }
}
