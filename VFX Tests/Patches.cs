using Deadpan.Enums.Engine.Components.Modding;
using FMOD.Studio;
using FMODUnity;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using WildfrostHopeMod.SFX;

namespace WildfrostHopeMod.VFX
{
    [HarmonyPatch]
    public static partial class Patches
    {
        [HarmonyPatch(typeof(VfxStatusSystem), nameof(VfxStatusSystem.CreateEffect))]
        public static void Postfix(VfxStatusSystem __instance, GameObject prefab, Vector3 position, Vector3 scale)
        {
            GIFLoader.InvokeEffectPlayed(prefab);
        }

        
        [HarmonyPrefix]
        [HarmonyPatch(typeof(RuntimeManager), nameof(RuntimeManager.CreateInstance), typeof(EventReference))]
        public static bool RuntimeManagerCreateInstance(EventReference eventReference, ref EventInstance __result)
        {
            if (HopeSFXSystem.sounds != null && eventReference.Matches(data1: "hope.wildfrost.vfx", data3: "test"))
            {
                FMOD.Sound sound = HopeSFXSystem.sounds.FirstOrDefault(kvp => eventReference.Matches(data4: kvp.Key)).Value;
                if (sound.hasHandle())
                    return true;
            }

            return true;
            __result = new EventInstance();
        }

        /*[HarmonyPrefix]
        [HarmonyPatch(typeof(RuntimeManager), nameof(RuntimeManager.PlayOneShot), typeof(string), typeof(Vector3))]
        public static bool RuntimeManagerCreateInstance(EventReference eventReference, ref EventInstance __result)
        {
            if (HopeSFXSystem.sounds != null && eventReference.Matches(data1: "hope.wildfrost.vfx", data3: "test"))
            {
                FMOD.Sound sound = HopeSFXSystem.sounds.FirstOrDefault(kvp => eventReference.Matches(data4: kvp.Key)).Value;
                if (sound.hasHandle())
                    return true;
            }

            return true;
            __result = new EventInstance();
        }*/

        internal static bool Matches(this EventReference eventReference, string data1 = null, string data2 = null, string data3 = null, string data4 = null)
        {
            bool result = true;
            if (data1 != null)
                result &= eventReference.Guid.Data1 == data1.GetHashCode();
            if (data2 != null)
                result &= eventReference.Guid.Data2 == data2.GetHashCode();
            if (data3 != null)
                result &= eventReference.Guid.Data3 == data3.GetHashCode();
            if (data4 != null)
                result &= eventReference.Guid.Data4 == data4.GetHashCode();
            return result;
        }
    }
    [HarmonyPatch(typeof(WildfrostMod.DebugLoggerTextWriter), nameof(WildfrostMod.DebugLoggerTextWriter.WriteLine))]
    class PatchHarmony
    {
        static bool Prefix() { Postfix(); return false; }
        static void Postfix() => HarmonyLib.Tools.Logger.ChannelFilter = HarmonyLib.Tools.Logger.LogChannel.Warn | HarmonyLib.Tools.Logger.LogChannel.Error;
    }
}
