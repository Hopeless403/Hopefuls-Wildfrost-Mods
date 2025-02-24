using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using LibAPNG;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Localization;
using UnityEngine.UI;
using WildfrostHopeMod.SFX;
using WildfrostHopeMod.Utils;

using Extensions = Deadpan.Enums.Engine.Components.Modding.Extensions;

namespace WildfrostHopeMod.VFX
{
    public partial class StatusIconBuilder
    {
        /// <summary>
        /// Plays an animated GIF or APNG when the status icon is applied, from a custom-defined GIFLoader
        /// </summary>
        /// <param name="vfx"></param>
        /// <param name="animationName"></param>
        /// <returns></returns>
        public StatusIconBuilder WithApplyVFX(GIFLoader vfx, string animationName)
        {
            vfx ??= VFXMod.instance?.VFX;

            var animationPrefab = vfx?.TryGetPrefab(animationName);
            animationPrefab?.RegisterAsApplyEffect(actualIcon.type);
            return this;
        }

        /// <summary>
        /// Plays an animated GIF or APNG when the status icon is applied, from a file
        /// </summary>
        /// <param name="vfx"></param>
        /// <param name="animationName"></param>
        /// <returns></returns>
        public StatusIconBuilder WithApplyVFX(string animationPath)
        {
            if (animationPath == null)
            {
                Debug.LogWarning("[VFX Tools] Animation path for .WithApplyVFX is null");
                return this;
            }
            GIFLoader vfx = VFXMod.instance?.VFX;
            if (vfx == null) return this;
            
            GameObject animationPrefab = vfx.TryGetPrefab(Path.GetFileNameWithoutExtension(animationPath)) 
                ?? Path.GetExtension(animationPath).ToLower() switch
            {
                ".gif" => vfx.LoadGIFFromPath(animationPath),
                ".apng" or ".png" => vfx.LoadAPNGFromPath(animationPath),
                _ => null
            };

            animationPrefab?.RegisterAsApplyEffect(actualIcon.type);
            return this;
        }

        /// <summary>
        /// Plays an animated GIF or APNG when a Hit with this damageType is processed, from a custom-defined GIFLoader. See the code for <seealso cref="StatusEffectSpikes"/>
        /// </summary>
        /// <param name="vfx"></param>
        /// <param name="animationName"></param>
        /// <returns></returns>
        public StatusIconBuilder WithEffectDamageVFX(GIFLoader vfx, string animationName)
        {
            vfx ??= VFXMod.instance?.VFX;

            var animationPrefab = vfx?.TryGetPrefab(animationName);
            animationPrefab?.RegisterAsDamageEffect(actualIcon.type);

            return this;
        }

        /// <summary>
        /// Plays an animated GIF or APNG when a Hit with this damageType is processed, from a file
        /// </summary>
        /// <param name="vfx"></param>
        /// <param name="animationName"></param>
        /// <returns></returns>
        public StatusIconBuilder WithEffectDamageVFX(string animationPath)
        {
            if (animationPath == null)
            {
                Debug.LogWarning("[VFX Tools] Animation path for .WithHitVFX is null");
                return this;
            }
            GIFLoader vfx = VFXMod.instance?.VFX;
            if (vfx == null) return this;

            GameObject animationPrefab = vfx.TryGetPrefab(Path.GetFileNameWithoutExtension(animationPath))
                ?? Path.GetExtension(animationPath).ToLower() switch
                {
                    ".gif" => vfx.LoadGIFFromPath(animationPath),
                    ".apng" or ".png" => vfx.LoadAPNGFromPath(animationPath),
                    _ => null
                };

            animationPrefab?.RegisterAsDamageEffect(actualIcon.type);

            return this;
        }

        /// <summary>
        /// Plays an animated GIF or APNG when an entity with this status icon is hit (eg Bom), from a custom-defined GIFLoader
        /// </summary>
        /// <param name="vfx"></param>
        /// <param name="animationName"></param>
        /// <returns></returns>
        public StatusIconBuilder WithWhenHitVFX(GIFLoader vfx, string animationName)
        {
            vfx ??= VFXMod.instance?.VFX;

            var animationPrefab = vfx?.TryGetPrefab(animationName);
            animationPrefab?.RegisterAsHitEffect(actualIcon.type);
            return this;
        }

        /// <summary>
        /// Plays an animated GIF or APNG when an entity with this status icon is hit (eg Bom), from a file
        /// </summary>
        /// <param name="vfx"></param>
        /// <param name="animationName"></param>
        /// <returns></returns>
        public StatusIconBuilder WithWhenHitVFX(string animationPath)
        {
            if (animationPath == null)
            {
                Debug.LogWarning("[VFX Tools] Animation path for .WithHitVFX is null");
                return this;
            }
            GIFLoader vfx = VFXMod.instance?.VFX;
            if (vfx == null) return this;

            GameObject animationPrefab = vfx.TryGetPrefab(Path.GetFileNameWithoutExtension(animationPath))
                ?? Path.GetExtension(animationPath).ToLower() switch
                {
                    ".gif" => vfx.LoadGIFFromPath(animationPath),
                    ".apng" or ".png" => vfx.LoadAPNGFromPath(animationPath),
                    _ => null
                };

            animationPrefab?.RegisterAsHitEffect(actualIcon.type);

            return this;
        }
    }
}
