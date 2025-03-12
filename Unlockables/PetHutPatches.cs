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
        public class PetHutPatches
        {
            [HarmonyPatch(typeof(PetHutSequence), nameof(PetHutSequence.Start))]
            static void Postfix(PetHutSequence __instance)
            {
                List<ChallengeData> petChallenges = [];
                foreach (var kvp in MetaprogressionSystem.GetPetDict()) // Ignore the 7 vanilla pets? Hoping that the order is retained
                {
                    if (AddressableLoader.Get<CardData>(nameof(CardData), kvp.Key) == null)
                        continue;

                    ChallengeData challenge = AddressableLoader.GetGroup<ChallengeData>(nameof(ChallengeData)).FirstOrDefault(c => c.reward?.name == kvp.Value);
                    Debug.LogWarning("PETHUT: " + (kvp, challenge));

                    petChallenges.Add(challenge);
                }

                // ISSUE: only the challenges for pets indexed >= __instance.challenges.Length will be shown!
                __instance.challenges = petChallenges.ToArray();
            }


            [HarmonyPostfix]
            [HarmonyPatch(typeof(MetaprogressionSystem), nameof(MetaprogressionSystem.GetAllPets))]
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


            [HarmonyPostfix]
            [HarmonyPatch(typeof(PetHutSequence), nameof(PetHutSequence.Unlock))]
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