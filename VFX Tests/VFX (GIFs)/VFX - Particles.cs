using HarmonyLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.TextCore.Text;
using UnityEngine.UIElements;
using WildfrostHopeMod.Utils;
using static UnityEngine.ParticleSystem;

namespace WildfrostHopeMod.VFX
{
    public partial class GIFLoader
    {
        public static bool CreateParticleSystemFromSprites(Sprite[] sprites, float framesPerSecond, int loops, out GameObject prefab, string name = null, bool destroyOnEnd = true)
        {
            if (framesPerSecond <= 0)
                throw new DivideByZeroException($"[VFX Tools] FPS must be non-negative!");

            float[] delays = new float[sprites.Length];
            bool flag =  CreateParticleSystemFromSprites(sprites, delays, loops, out prefab, name, destroyOnEnd);
            if (flag)
            {
                ParticleSystem particles = prefab.GetComponent<ParticleSystem>();
                TextureSheetAnimationModule animation = particles.textureSheetAnimation;
                animation.timeMode = ParticleSystemAnimationTimeMode.FPS;
                animation.fps = framesPerSecond;
            }

            return flag;
        }

        public static bool CreateParticleSystemFromSprites(Sprite[] sprites, float[] delays, int loops, out GameObject prefab, string name = null, bool destroyOnEnd = true)
        {
            if (sprites == null || sprites.Length == 0)
                throw new NullReferenceException($"[VFX Tools] Sprites list is empty!");

            if (delays == null || delays.Length == 0)
                throw new NullReferenceException($"[VFX Tools] Delays list is empty!");

            int nulls = sprites.ToList().IndexOf(null);
            if (nulls != -1)
                throw new NullReferenceException($"[VFX Tools] There is a null sprite at index {nulls}");
            name ??= sprites.First().name;

            if (sprites.Length != delays.Length)
                throw new Exception("[VFX Tools] Length mismatch between Sprites and Delays");

            Debug.LogError($"ParticleSystem of {name} from sprites:");

            ParticleSystem particles = HopeUtils.CreateParticleSystem(name, sprites: sprites);
            prefab = particles?.gameObject ?? new GameObject(name, typeof(RectTransform), typeof(ParticleSystem));
            particles ??= prefab.GetComponent<ParticleSystem>();

            if (VFXMod.parent) prefab.transform.SetParent(VFXMod.parent);
            else GameObject.DontDestroyOnLoad(prefab);

            var fadeOut = particles.colorOverLifetime; 
            fadeOut.enabled = false;

            MainModule main = particles.main;
            main.duration = delays.Sum();
            main.startLifetime = main.duration;
            main.stopAction = destroyOnEnd ? ParticleSystemStopAction.Destroy : ParticleSystemStopAction.Disable;
            main.playOnAwake = true;

            TextureSheetAnimationModule animation = particles.textureSheetAnimation;
            animation.enabled = true;
            animation.startFrame = 0;

            // NOTE: This can be replaced with FPS instead of timer curve
            animation.timeMode = ParticleSystemAnimationTimeMode.Lifetime;
            MinMaxCurve timer = animation.frameOverTime;
            timer.curveMultiplier = 1;
            timer.curve = new AnimationCurve();

            // Both time and value are stored as percentages (between 0 and 1)
            float cumulativeDelay = 0f;
            for (int i = 0; i < sprites.Length; i++) // delays.Length
            {
                timer.curve.AddKey(cumulativeDelay, i * 1f/sprites.Length);
                cumulativeDelay += delays[i]/delays.Sum();
            }
            // IMPORTANT: Need to reassign the timer
            animation.frameOverTime = timer;

            Debug.LogWarning($"[VFX Tools] Created prefab: [{name}] with ID {prefab.GetInstanceID()}!");
            return true;
        }

        static void ModifyNextFrame(ParticleSystem ps, Action<ParticleSystem> action)
        {
            CoroutineManager.instance.StartCoroutine(ModifyNextFrameRoutine(ps, action));
        }

        static IEnumerator ModifyNextFrameRoutine(ParticleSystem ps, Action<ParticleSystem> action)
        {
            yield return null;
            action(ps);
        }

    }
}
