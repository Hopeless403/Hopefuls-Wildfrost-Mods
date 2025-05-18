using HarmonyLib;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace Unlockables
{
    public partial class UnlockablesMod
    {
        [HarmonyPatch]
        public class PetHutPatches
        {
            [HarmonyPostfix]
            [HarmonyPatch(typeof(MetaprogressionSystem), nameof(MetaprogressionSystem.GetLockedItems))]
            public static List<string> GetLockedItems(List<string> result, MetaprogressionSystem __instance, List<UnlockData> remainingUnlocks)
            {
                //MetaprogressionSystem.GetUnlocked()
                return result;
            }




            /// <summary>
            /// For PetHut, set the challenges to be exactly the ones that reward their UnlockData
            /// </summary>
            [HarmonyPostfix]
            [HarmonyPatch(typeof(PetHutSequence), nameof(PetHutSequence.Start))]
            public static void UpdatePetChallenges(PetHutSequence __instance)
            {
                List<ChallengeData> petChallenges = [];
                foreach (var kvp in MetaprogressionSystem.GetPetDict())
                {
                    if (kvp.Value.IsNullOrEmpty())
                        petChallenges.Add(null);
                    else
                    {
                        ChallengeData challenge = ChallengeSystem.GetAllChallenges().FirstOrDefault(c => c.reward.name == kvp.Value);
                        petChallenges.Add(challenge);
                    }
                }

                __instance.challenges = petChallenges.ToArray();
            }

            /// Attempt at fixing the pet hut unlock showcase
            //[HarmonyPostfix]
            //[HarmonyPatch(typeof(MetaprogressionSystem), nameof(MetaprogressionSystem.GetAllPets))]
            static string[] GetAllPets(string[] original)
            {
                var frames = new System.Diagnostics.StackTrace(fNeedFileInfo: true).GetFrames();
                if (frames.Length >= 3)
                {
                    var method = frames[2].GetMethod();
                    Debug.LogError(method.DeclaringType.Name);

                    if (method.DeclaringType.Name.StartsWith("<Unlock>"))
                    {
                        var petDict = MetaprogressionSystem.GetPetDict();
                        return original.Where(p => petDict[p] != null).Prepend(original[0]).ToArray();
                    }
                }
                return original;
            }


            //[HarmonyPostfix]
            //[HarmonyPatch(typeof(PetHutSequence), nameof(PetHutSequence.Unlock))]
            static IEnumerator Unlock(IEnumerator original, PetHutSequence __instance)
            {
                yield return original;
                Entity entity = __instance.lastUnlockedCard;

                if (entity.actualContainers.Any())
                {
                    entity.actualContainers.Do(c =>
                    {
                        var image = c.GetComponent<Image>();
                        if (image) image.enabled = false;
                    });
                    entity.RemoveFromContainers();
                }

                int index = 1 + MetaprogressionSystem.GetAllPets().ToList().FindIndex(kvp => kvp == entity.name);
                CardContainer finalSlot = __instance.cardSlots[index];
                finalSlot.Add(entity);
                finalSlot.TweenChildPositions();
                if (finalSlot)
                {
                    Image component = finalSlot.GetComponent<Image>();
                    if (component != null)
                        component.enabled = true;
                }
            }
        }
    }
}