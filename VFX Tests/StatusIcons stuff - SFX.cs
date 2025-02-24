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
        /*public StatusIconBuilder WithApplySFX(SFXLoader sfx, string soundName)
        {
            sfx ??= VFXMod.instance?.SFX;

            var animationPrefab = sfx?.try(animationName);
            animationPrefab?.RegisterAsApplyEffect(actualIcon.type);
            return this;
        }*/

        /// <summary>
        /// Plays a sound when the status icon is applied, from a file. Default cooldown set to 0.05f
        /// </summary>
        /// <param name="audioFilepath"></param>
        /// <returns></returns>
        public StatusIconBuilder WithApplySFX(string audioFilepath)
        {
            return this.WithApplySFX(audioFilepath, cooldown: 0.05f);
        }

        /// <summary>
        /// Plays a sound when the status icon is applied, from a file OR path to an FMOD EventReference starting with "event:/"
        /// </summary>
        /// <param name="audioFilepath"></param>
        /// <param name="cooldown">Cooldown before this sfx can play again (preventing noise if icon applied with Barrage). Default is 0.05f</param>
        /// <returns></returns>
        public StatusIconBuilder WithApplySFX(string audioFilepath, float cooldown)
        {
            if (audioFilepath == null)
            {
                Debug.LogWarning("[SFX Tools] Sound path for .WithApplySFX is null");
                return this;
            }

            FMODUnity.EventReference eventRef = audioFilepath.StartsWith("event:") 
                ? default 
                : FMODUnity.RuntimeManager.PathToEventReference(audioFilepath);
            if (!eventRef.IsNull)
                return this.WithApplySFX(eventRef, cooldown);

            SFXLoader sfx = VFXMod.instance?.SFX;
            if (sfx == null) return this;

            if (!sfx.sounds.TryGetValue(Path.GetFileNameWithoutExtension(audioFilepath), out FMOD.Sound sound))
                sound = sfx.LoadSoundFromPath(audioFilepath);
            SFXLoader.RegisterSoundToGlobal(actualIcon.type, sound, cooldown);

            return this;
        }

        /*/// <summary>
        /// Plays a sound when the status icon is applied, from an event reference of some FMOD bank. 
        /// You may want to use FMODUnity.RuntimeManager.PathToEventReference()
        /// </summary>
        /// <param name="eventRef"></param>
        /// <returns></returns>
        public StatusIconBuilder WithApplySFX(FMODUnity.EventReference eventRef)
        {
            return this.WithApplySFX(eventRef, 0.05f);
        }*/

        /// <summary>
        /// Plays a sound when the status icon is applied, from an event reference of some FMOD bank. 
        /// You may want to use FMODUnity.RuntimeManager.PathToEventReference()
        /// </summary>
        /// <param name="eventRef"></param>
        /// <param name="cooldown">Cooldown before this sfx can play again (preventing noise if icon applied with Barrage). Default is 0.05f</param>
        /// <returns></returns>
        public StatusIconBuilder WithApplySFX(FMODUnity.EventReference eventRef, float cooldown)
        {
            if (eventRef.IsNull)
            {
                Debug.LogWarning($"[SFX Tools] Invalid event reference for [{actualIcon.type}]. " +
                    $"EventReferences must come from some FMOD Bank");
            }
            else
            {
                HopeSFXSystem.eventRefs[actualIcon.type] = eventRef;
                SfxSystem.cooldownTimers[actualIcon.type] = cooldown;
                SfxSystem.cooldowns[actualIcon.type] = new SfxSystem.Cooldown(actualIcon.type, cooldown);
            }
            return this;
        }

        /*public StatusIconBuilder WithApplySFX(SFXLoader sfx, string soundName)
        {
            sfx ??= VFXMod.instance?.SFX;

            var animationPrefab = sfx?.try(animationName);
            animationPrefab?.RegisterAsApplyEffect(actualIcon.type);
            return this;
        }*/


        /// <summary>
        /// Plays a sound when a Hit with this damageType is processed, from a file. Default cooldown set to 0.05f. See the code for <seealso cref="StatusEffectSpikes"/>
        /// </summary>
        /// <param name="audioFilepath"></param>
        /// <returns></returns>
        public StatusIconBuilder WithEffectDamageSFX(string audioFilepath)
        {
            return this.WithEffectDamageSFX(audioFilepath, cooldown: 0.05f);
        }

        /// <summary>
        /// Plays a sound when a Hit with this damageType is processed, from a file OR path to an FMOD EventReference starting with "event:/". See the code for <seealso cref="StatusEffectSpikes"/>
        /// </summary>
        /// <param name="audioFilepath"></param>
        /// <param name="cooldown">Cooldown before this sfx can play again (preventing noise if icon applied with Barrage). Default is 0.05f</param>
        /// <returns></returns>
        public StatusIconBuilder WithEffectDamageSFX(string audioFilepath, float cooldown)
        {
            if (audioFilepath == null)
            {
                Debug.LogWarning("Sound path for .WithEffectDamageSFX is null");
                return this;
            }

            FMODUnity.EventReference eventRef = audioFilepath.StartsWith("event:")
                ? default
                : FMODUnity.RuntimeManager.PathToEventReference(audioFilepath);
            if (!eventRef.IsNull)
                return this.WithEffectDamageSFX(eventRef, cooldown);

            SFXLoader sfx = VFXMod.instance?.SFX;
            if (sfx == null) return this;

            if (!sfx.sounds.TryGetValue(Path.GetFileNameWithoutExtension(audioFilepath), out FMOD.Sound sound))
                sound = sfx.LoadSoundFromPath(audioFilepath);
            SFXLoader.RegisterSoundToGlobal("damage." + actualIcon.type, sound, cooldown);

            return this;
        }

        /*/// <summary>
        /// Plays a sound when a Hit with this damageType is processed, from an event reference of some FMOD bank. See the code for <seealso cref="StatusEffectSpikes"/>
        /// You may want to use FMODUnity.RuntimeManager.PathToEventReference()
        /// </summary>
        /// <param name="eventRef"></param>
        /// <returns></returns>
        public StatusIconBuilder WithApplySFX(FMODUnity.EventReference eventRef)
        {
            return this.WithApplySFX(eventRef, 0.05f);
        }*/

        /// <summary>
        /// Plays a sound when a Hit with this damageType is processed, from an event reference of some FMOD bank. See the code for <seealso cref="StatusEffectSpikes"/>
        /// You may want to use FMODUnity.RuntimeManager.PathToEventReference()
        /// </summary>
        /// <param name="eventRef"></param>
        /// <param name="cooldown">Cooldown before this sfx can play again (preventing noise if icon applied with Barrage). Default is 0.05f</param>
        /// <returns></returns>
        public StatusIconBuilder WithEffectDamageSFX(FMODUnity.EventReference eventRef, float cooldown)
        {
            if (eventRef.IsNull)
            {
                Debug.LogWarning($"[SFX Tools] Invalid event reference for [{actualIcon.type}]. " +
                    $"EventReferences must come from some FMOD Bank");
            }
            else
            {
                HopeSFXSystem.eventRefs["damage." + actualIcon.type] = eventRef;
                SfxSystem.cooldownTimers["damage." + actualIcon.type] = cooldown;
                SfxSystem.cooldowns["damage." + actualIcon.type] = new SfxSystem.Cooldown("damage." + actualIcon.type, cooldown);
            }
            return this;
        }

        /*public StatusIconBuilder WithApplySFX(SFXLoader sfx, string soundName)
        {
            sfx ??= VFXMod.instance?.SFX;

            var animationPrefab = sfx?.try(animationName);
            animationPrefab?.RegisterAsApplyEffect(actualIcon.type);
            return this;
        }*/

        /// <summary>
        /// Plays a sound when an entity with this status icon is hit (eg Bom), from a file. Default cooldown set to 0.05f
        /// </summary>
        /// <param name="audioFilepath"></param>
        /// <returns></returns>
        public StatusIconBuilder WithWhenHitSFX(string audioFilepath)
        {
            return this.WithWhenHitSFX(audioFilepath, cooldown: 0.05f);
        }

        /// <summary>
        /// Plays a sound when an entity with this status icon is hit (eg Bom), from a file OR path to an FMOD EventReference starting with "event:/"
        /// </summary>
        /// <param name="audioFilepath"></param>
        /// <param name="cooldown">Cooldown before this sfx can play again (preventing noise if icon applied with Barrage). Default is 0.05f</param>
        /// <returns></returns>
        public StatusIconBuilder WithWhenHitSFX(string audioFilepath, float cooldown)
        {
            if (audioFilepath == null)
            {
                Debug.LogWarning("Sound path for .WithWhenHitSFX is null");
                return this;
            }

            FMODUnity.EventReference eventRef = audioFilepath.StartsWith("event:")
                ? default
                : FMODUnity.RuntimeManager.PathToEventReference(audioFilepath);
            if (!eventRef.IsNull)
                return this.WithWhenHitSFX(eventRef, cooldown);

            SFXLoader sfx = VFXMod.instance?.SFX;
            if (sfx == null) return this;

            if (!sfx.sounds.TryGetValue(Path.GetFileNameWithoutExtension(audioFilepath), out FMOD.Sound sound))
                sound = sfx.LoadSoundFromPath(audioFilepath);
            SFXLoader.RegisterSoundToGlobal("hit." + actualIcon.type, sound, cooldown);
            HopeSFXSystem.whenHitSounds[actualIcon.type] = sound;

            return this;
        }

        /*/// <summary>
        /// Plays a sound when the status icon is applied, from an event reference of some FMOD bank. 
        /// You may want to use FMODUnity.RuntimeManager.PathToEventReference()
        /// </summary>
        /// <param name="eventRef"></param>
        /// <returns></returns>
        public StatusIconBuilder WithApplySFX(FMODUnity.EventReference eventRef)
        {
            return this.WithApplySFX(eventRef, 0.05f);
        }*/

        /// <summary>
        /// Plays a sound when an entity with this status icon is hit (eg Bom), from an event reference of some FMOD bank. 
        /// You may want to use FMODUnity.RuntimeManager.PathToEventReference()
        /// </summary>
        /// <param name="eventRef"></param>
        /// <param name="cooldown">Cooldown before this sfx can play again (preventing noise if icon applied with Barrage). Default is 0.05f</param>
        /// <returns></returns>
        public StatusIconBuilder WithWhenHitSFX(FMODUnity.EventReference eventRef, float cooldown)
        {
            if (eventRef.IsNull)
            {
                Debug.LogWarning($"[SFX Tools] Invalid event reference for [{actualIcon.type}]. " +
                    $"EventReferences must come from some FMOD Bank");
            }
            else
            {
                HopeSFXSystem.eventRefs["hit." + actualIcon.type] = eventRef;
                SfxSystem.cooldownTimers["hit." + actualIcon.type] = cooldown;
                SfxSystem.cooldowns["hit." + actualIcon.type] = new SfxSystem.Cooldown("hit." + actualIcon.type, cooldown);
            }
            return this;
        }
    }
}
