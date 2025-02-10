using Deadpan.Enums.Engine.Components.Modding;
using FMODUnity;
using HarmonyLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace WildfrostHopeMod.EveryoneGrows
{
    public class EveryoneGrowsMod(string modDirectory) : WildfrostMod(modDirectory)
    {
        public override string GUID => "hope.wildfrost.EveryoneGrows";
        public override string[] Depends => new string[] { };
        public override string Title => "Everyone Grows";
        public override string Description => "They say every experience makes you grow, but Lil' Berry taught them otherwise";
        public static LilBerry scriptableImage;

        [ConfigItem(false, null, "Unrestrained")]
        public bool unrestrained = false;
        public static EveryoneGrowsMod instance;

        public override void Load()
        {
            base.Load();
            instance = this;
            scriptableImage ??= Get<CardData>("LilBerry").scriptableImagePrefab as LilBerry;
        }

        [HarmonyPatch(typeof(Card), nameof(Card.UpdateDisplay))]
        public class Patch
        {
            internal readonly static Dictionary<ulong, (int currentAttack, float originalScale)> currentAmounts = [];

            static IEnumerator Postfix(IEnumerator __result, Card __instance)
            {
                yield return __result;

                if (!(__instance?.entity?.enabled) ?? true)
                    yield break;

                //Debug.LogError("POSTFIXING FOR " + (__instance, __instance.scriptableImage, __instance.mainImage));
                Transform image = __instance.hasScriptableImage && __instance.scriptableImage ? __instance.scriptableImage?.transform : __instance.mainImage?.transform;

                //Debug.LogWarning("UpdateEvent");
                if (!currentAmounts.TryGetValue(__instance.entity.data.id, out var value))
                {
                    value.currentAttack = __instance.entity.damage.current;
                    value.originalScale = image.transform.localScale.x;
                }
                else if (value.currentAttack == __instance.entity.damage.current)
                    yield break;

                value.currentAttack = __instance.entity.damage.current;
                currentAmounts[__instance.entity.data.id] = value;

                //Debug.LogWarning("SetScale");
                float scaleFrom = Mathf.Lerp(1f, Mathf.Abs(image.transform.localScale.x), 0.5f); // idk what this is -> //Mathf.Lerp(1f, image.transform.localScale.x, 0.5f);
                float scaleTo = instance.unrestrained && value.currentAttack > 2 ? 1+(float)(value.currentAttack - 2)/(float)16 : scriptableImage.scaleCurve.Evaluate(value.currentAttack);
                scaleTo *= Mathf.Abs(value.originalScale);

                //Debug.LogWarning("StartScaleTween");
                float tweenT = 0;
                float sign = Mathf.Sign(image.transform.localScale.x);
                while (tweenT <= 1.2f)
                {
                    tweenT += Time.deltaTime / scriptableImage.tweenDur;
                    float num = scaleFrom + scriptableImage.tweenCurve.Evaluate(tweenT) * (scaleTo - scaleFrom);
                    //Debug.Log(image + ": " + num);
                    image.transform.localScale = new Vector3(sign * num, num, 1f);
                    yield return null;
                }

                //Debug.LogWarning("Done");

            }
        }

        public override void Unload()
        {
            scriptableImage = null;
            Patch.currentAmounts.Clear();
            base.Unload();
        }
    }
}