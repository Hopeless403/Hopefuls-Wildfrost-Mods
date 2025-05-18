using HarmonyLib;
using System.Data;
using System.Linq;
using UnityEngine;
using System.Collections;
using WildfrostHopeMod.Utils;
using Extensions = Deadpan.Enums.Engine.Components.Modding.Extensions;


namespace WildFlipper
{
    public partial class WildFlipperMod
    {
        [HarmonyPatch(typeof(CampaignPopulator), nameof(CampaignPopulator.Populate))]
        public static class PatchPopulator
        {
            public static IEnumerator Postfix(IEnumerator original)
            {
                var poolsToFix = (References.PlayerData.classData, References.PlayerData.classData.rewardPools.Clone());
                if (References.PlayerData?.classData.ModAdded != instance)
                {
                    Debug.LogWarning("Adding custom pools!");
                    if (References.LeaderData.original == instance.TryGet<CardData>("artemys.wildfrost.frostknights.closure"))
                    {
                        var unitPool = new Scriptable<RewardPool>(pool =>
                        {
                            pool.type = "Units";
                            pool.list = instance.DataList<CardData>(
                            "NakedGnomeFriendly",
                            "NakedGnomeFriendly",
                            "NakedGnomeFriendly",
                            "NakedGnomeFriendly",
                            "NakedGnomeFriendly",
                            "NakedGnomeFriendly").Select(c => c.Clone() as DataFile).ToList();
                        });

                        References.PlayerData.classData.rewardPools = new RewardPool[]
                        {
                            unitPool,
                            //Extensions.GetRewardPool("GeneralUnitPool"),
                            Extensions.GetRewardPool("GeneralItemPool"),
                            Extensions.GetRewardPool("GeneralCharmPool"),
                            Extensions.GetRewardPool("GeneralModifierPool"),
                            //Extensions.GetRewardPool("SnowUnitPool"),
                            Extensions.GetRewardPool("SnowItemPool"),
                            Extensions.GetRewardPool("SnowCharmPool"),
                        };
                    }
                }

                yield return original;

                poolsToFix.classData.rewardPools = poolsToFix.Item2 as RewardPool[];
            }
        }
    }
}


