using Rewired;
using Rewired.Components;
using System.Collections;
using System.Linq;
using UnityEngine;

namespace WildfrostHopeMod.KeyboardSupport
{
    /*[HarmonyPatch(
     * typeof(HotKeyDisplay), nameof(HotKeyDisplay.Refresh))]
    public class Patch
    {
        public static bool Prefix(HotKeyDisplay __instance)
        {
            Debug.LogWarning(__instance.name + ": " + __instance.actionName);

            __instance.image.enabled = true;
            __instance.image.sprite = KeyboardMod.Mod.IconSprite;
            return false;
        }
    }*/
    public class HopeKeyboardModBehaviour : MonoBehaviour
    {
        internal void Start()
        {
            return;
            foreach (var map in RewiredControllerManager.GetPlayerController(0)
                .controllers.maps.GetAllMaps())
            {
                if (map.controllerType == ControllerType.Keyboard)
                {
                    var buttons = RewiredControllerManager.GetPlayerController(0)
                        .controllers.Keyboard.ButtonElementIdentifiers
                        .ToLookup(a => a.name, a => a.id);
                    var eIndex = RewiredControllerManager.GetPlayerController(0)
                        .controllers.Keyboard.GetButtonIndexByKeyCode(KeyCode.E);

                    for (var i = 0; i < 13; i++)
                    {
                        var assignment = new ElementAssignment(
                            (KeyCode)((int)KeyCode.E+i),
                            ModifierKeyFlags.None, // CTRL / Shift / Alt
                            i, // Action Id: 2 = Inspect
                            Pole.Positive // Axis Contribution
                            );
                        map.ReplaceOrCreateElementMap(assignment);
                    }
                    Debug.LogWarning($"[{map.name}] {map.enabled}: {string.Join(", ", map.ButtonMaps)}");
                }
                
            }
        }

        void Update()
        {
            RewiredControllerManager.leadPlayer.GetAnyButtonDown();
        }
    }
}