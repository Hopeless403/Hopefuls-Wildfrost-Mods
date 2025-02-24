using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace DreamSeekers
{
    [HarmonyPatch(typeof(UpgradeHolder), nameof(UpgradeHolder.Create))]
    public class SpecialCardUpgradeData : CardUpgradeData
    {
        //public static 



        [SerializeField]
        CardData _data;

        [HarmonyPostfix]
        static void CreateEntity(CardUpgradeData upgradeData)
        {
            if (upgradeData is not SpecialCardUpgradeData data) return;

            Debug.LogWarning("ya this guy is special: " + data);

        }
    }
}
