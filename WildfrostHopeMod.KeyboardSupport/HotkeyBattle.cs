using Rewired;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace WildfrostHopeMod.KeyboardSupport
{
    internal class HotkeyBattle : MonoBehaviour
    {
        public static Keyboard keyboard = RewiredControllerManager.leadPlayer.controllers.Keyboard;
        public static List<KeyCode> drawDeck = [KeyCode.Minus];
        public static List<KeyCode> drawDeckShifted = [KeyCode.Minus];
        public static List<KeyCode> discardDeck = [KeyCode.Equals];
        public static List<KeyCode> discardDeckShifted = [KeyCode.Equals];

        public static void Reset()
        {
            drawDeck = [];
            drawDeckShifted = [];
            discardDeck = [];
            discardDeckShifted = [];
        }
        public static void AddKey(string drawOrDiscard, bool shift, KeyCode key)
        {
            switch (drawOrDiscard)
            {
                case "Draw":
                    if (!shift) drawDeck.Add(key);
                    else drawDeckShifted.Add(key);
                    break;
                case "Discard": 
                    if (!shift) discardDeck.Add(key); 
                    else discardDeckShifted.Add(key); 
                    break;
            }
        }
        public void Update()
        {
            if (!Battle.instance?.player) return;
            if (keyboard.GetModifierKey(ModifierKey.Shift))
            {
                foreach (var key in drawDeckShifted) if (Input.GetKeyDown(key))
                    {
                        Switch();
                        UINavigationSystem.instance.SetCurrentNavigationItem(Battle.instance.player.drawContainer?.nav);
                    }
                foreach (var key in discardDeckShifted) if (Input.GetKeyDown(key))
                    {
                        Switch();
                        UINavigationSystem.instance.SetCurrentNavigationItem(Battle.instance.player.discardContainer?.nav);
                    }
            }
            else
            {
                foreach (var key in drawDeck) if (Input.GetKeyDown(key))
                    {
                        Switch();
                        UINavigationSystem.instance.SetCurrentNavigationItem(Battle.instance.player.drawContainer?.nav);
                    }
                foreach (var key in discardDeck) if (Input.GetKeyDown(key))
                    {
                        Switch();
                        UINavigationSystem.instance.SetCurrentNavigationItem(Battle.instance.player.discardContainer?.nav);
                    }
            }
        }
        static void Switch()
        {
            var inputSwitcher = FixSwitchingDuringTyping.inputSwitcher;
            if (inputSwitcher?.currentIndex != 1)
                inputSwitcher?.SwitchTo(1);
        }
    }
}
