using FMOD.Studio;
using HarmonyLib;
using Rewired;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.EventSystems;
using WildfrostHopeMod.Configs;

namespace WildfrostHopeMod.KeyboardSupport
{
    public class FixSwitchingDuringTyping
    {
        internal static InputSwitcher inputSwitcher => GameObject.FindObjectOfType<InputSwitcher>();
        [HarmonyPatch(typeof(ControllerInputSwitcher), nameof(ControllerInputSwitcher.SwitchTo))]
        public class PatchKeyboardSwitcher
        {
            public static bool Prefix()
            {
                if (Console.active || (PatchInputField.currentlyFocused?.isActiveAndEnabled).GetValueOrDefault(false))
                {
                    inputSwitcher?.SwitchTo(2);
                    PatchInputField.currentlyFocused.focused = false;
                    return false;
                }
                return true;
            }
            public static void Postfix()
            {
                if (RewiredControllerManager.GetPlayerController(0)
                .controllers.Controllers.Any(c => c.type == ControllerType.Keyboard))
                    KeyboardMod.SetKeyboardStyle();
            }
        }
        [HarmonyPatch(typeof(InputFieldKeepFocus), nameof(InputFieldKeepFocus.e), MethodType.Getter)]
        public class PatchInputField
        {
            public static InputFieldKeepFocus currentlyFocused { get; private set; }
            public static void Prefix(InputFieldKeepFocus __instance)
            {
                currentlyFocused = __instance;
                inputSwitcher?.SwitchTo(2);
            }
        }
    }
}
