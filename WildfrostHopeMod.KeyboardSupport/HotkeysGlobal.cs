using Rewired;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace WildfrostHopeMod.KeyboardSupport
{
    internal class HotkeysGlobal : MonoBehaviour
    {
        public static List<KeyCode> whereAmI = [KeyCode.Equals];
        public static List<KeyCode> toggle = [KeyCode.Equals];

        public static void Reset()
        {
            whereAmI = [];
            toggle = [];
        }
        public static void AddKey(string list, KeyCode key)
        {
            switch (list)
            {
                case "WhereAmI": whereAmI.Add(key); break;
                case "Toggle": toggle.Add(key); break;
            }
        }
        public void Update()
        {
            if (RewiredControllerManager.leadPlayer.GetAnyButtonDown() && !InputSystem.IsSelectPressed())
            {
                bool flag = false;
                foreach (var direction in new string[] { "Up", "Down", "Right", "Left" })
                    flag |= RewiredControllerManager.leadPlayer.GetButtonDown(direction);
                if (flag!) FixSwitchingDuringTyping.inputSwitcher?.SwitchTo(1);
            }
            foreach (var key in toggle) if (Input.GetKeyDown(key))
            {
                var keyboardEnabled = RewiredControllerManager.GetPlayerController(0).controllers.Controllers.Any(c => c.type == ControllerType.Keyboard);
                if (keyboardEnabled)
                {
                    RewiredControllerManager.ControllerDisconnected(new Rewired.ControllerStatusChangedEventArgs("", 0, ControllerType.Keyboard));
                    GameObject.FindObjectOfType<InputSwitcher>()?.SwitchTo(2);
                    FloatingText.Create(Cursor3d.Position + Vector3.down * 0.5f, "<size=0.5>Keyboard disabled")
                        .Animate("Spring").Fade("Smooth", 0.5f, 0.5f)
                        .SetSortingLayer("PauseMenu", 0);
                }
                else
                {
                    RewiredControllerManager.ControllerConnected(new Rewired.ControllerStatusChangedEventArgs("", 0, ControllerType.Keyboard));
                    FloatingText.Create(Cursor3d.Position + Vector3.down * 0.5f, "<size=0.5>Keyboard enabled")
                        .Animate("Spring").Fade("Smooth", 0.5f, 0.5f)
                        .SetSortingLayer("PauseMenu", 0);
                }
            }
            foreach (var key in whereAmI) if (Input.GetKeyDown(key))
            {
                var keyboardEnabled = RewiredControllerManager.GetPlayerController(0).controllers.Controllers.Any(c => c.type == ControllerType.Keyboard);
                if (!keyboardEnabled) return;
                if (UINavigationSystem.instance.currentNavigationItem)
                    UINavigationSystem.instance.virtualCursor.SetPosition(UINavigationSystem.instance.currentNavigationItem.Position);
                UINavigationSystem.instance.NavigationLayers.Update(Debug.Log);
                Instantiate(GameObject.FindObjectOfType<VfxStatusSystem>().profileLookup["snow"].applyEffectPrefab,
                    UINavigationSystem.instance.virtualCursor.transform)
                    .transform.localScale *= 0.5f * Mathf.Sqrt(1.5f + UINavigationSystem.instance.virtualCursor.transform.position.z);
            }
        }
    }
}
