using Rewired;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace WildfrostHopeMod.KeyboardSupport
{
    internal static class Refs
    {


        public static readonly List<(Action action, Pole pole, KeyCode keyCode, ModifierKeyFlags modifiers)> elements = [
            (Action.Up, Pole.Positive, KeyCode.W, ModifierKeyFlags.None),
            (Action.Up, Pole.Negative, KeyCode.S, ModifierKeyFlags.None),
            (Action.Right, Pole.Positive, KeyCode.D, ModifierKeyFlags.None),
            (Action.Right, Pole.Negative, KeyCode.A, ModifierKeyFlags.None),
            (Action.Select, Pole.Positive, KeyCode.E, ModifierKeyFlags.None),
            (Action.Back, Pole.Positive, KeyCode.Q, ModifierKeyFlags.None),
            (Action.Inspect, Pole.Positive, KeyCode.R, ModifierKeyFlags.None),
            (Action.Settings, Pole.Positive, KeyCode.Alpha1, ModifierKeyFlags.LeftShift),
            (Action.Backpack, Pole.Positive, KeyCode.F, ModifierKeyFlags.None),
            (Action.Redraw_Bell, Pole.Positive, KeyCode.T, ModifierKeyFlags.None),
            (Action.Draw, Pole.Positive, KeyCode.Minus, ModifierKeyFlags.None),
            (Action.Discard, Pole.Positive, KeyCode.Equals, ModifierKeyFlags.None),
            ];
        public static void CreateWASDMap()
        {
            var map = new KeyboardMap();
            foreach (var (action, pole, keyCode, modifiers) in elements)
                map.CreateElementMap((int)action, pole, keyCode, modifiers);

            var controllers = RewiredControllerManager.GetPlayerController(0).controllers;
            controllers.maps.AddMap(controllers.Keyboard, map);
        }




        internal static readonly Dictionary<char, KeyCode> charToKeycode = new Dictionary<char, KeyCode>()
        {
          //-------------------------LOGICAL mappings-------------------------
  
          //Lower Case Letters
          {'a', KeyCode.A},
          {'b', KeyCode.B},
          {'c', KeyCode.C},
          {'d', KeyCode.D},
          {'e', KeyCode.E},
          {'f', KeyCode.F},
          {'g', KeyCode.G},
          {'h', KeyCode.H},
          {'i', KeyCode.I},
          {'j', KeyCode.J},
          {'k', KeyCode.K},
          {'l', KeyCode.L},
          {'m', KeyCode.M},
          {'n', KeyCode.N},
          {'o', KeyCode.O},
          {'p', KeyCode.P},
          {'q', KeyCode.Q},
          {'r', KeyCode.R},
          {'s', KeyCode.S},
          {'t', KeyCode.T},
          {'u', KeyCode.U},
          {'v', KeyCode.V},
          {'w', KeyCode.W},
          {'x', KeyCode.X},
          {'y', KeyCode.Y},
          {'z', KeyCode.Z},
  
          //Alphanumeric Numbers
          {'1', KeyCode.Alpha1},
          {'2', KeyCode.Alpha2},
          {'3', KeyCode.Alpha3},
          {'4', KeyCode.Alpha4},
          {'5', KeyCode.Alpha5},
          {'6', KeyCode.Alpha6},
          {'7', KeyCode.Alpha7},
          {'8', KeyCode.Alpha8},
          {'9', KeyCode.Alpha9},
          {'0', KeyCode.Alpha0},
  
          //Other Symbols
          {'!', KeyCode.Exclaim}, //1
          {'"', KeyCode.DoubleQuote},
          {'#', KeyCode.Hash}, //3
          {'$', KeyCode.Dollar}, //4
          {'&', KeyCode.Ampersand}, //7
          {'\'', KeyCode.Quote}, //remember the special forward slash rule... this isnt wrong
          {'(', KeyCode.LeftParen}, //9
          {')', KeyCode.RightParen}, //0
          {'*', KeyCode.Asterisk}, //8
          {'+', KeyCode.Plus},
          {',', KeyCode.Comma},
          {'-', KeyCode.Minus},
          {'.', KeyCode.Period},
          {'/', KeyCode.Slash},
          {':', KeyCode.Colon},
          {';', KeyCode.Semicolon},
          {'<', KeyCode.Less},
          {'=', KeyCode.Equals},
          {'>', KeyCode.Greater},
          {'?', KeyCode.Question},
          {'@', KeyCode.At}, //2
          {'[', KeyCode.LeftBracket},
          {'\\', KeyCode.Backslash}, //remember the special forward slash rule... this isnt wrong
          {']', KeyCode.RightBracket},
          {'^', KeyCode.Caret}, //6
          {'_', KeyCode.Underscore},
          {'`', KeyCode.BackQuote}
                };

        public static readonly List<(Action action, Pole pole, KeyCode keyCode, ModifierKeyFlags modifiers)> elementsKeyCode = [
            (Action.Up, Pole.Positive, KeyCode.UpArrow, ModifierKeyFlags.None),
            (Action.Up, Pole.Negative, KeyCode.DownArrow, ModifierKeyFlags.None),
            (Action.Right, Pole.Positive, KeyCode.RightArrow, ModifierKeyFlags.None),
            (Action.Right, Pole.Negative, KeyCode.LeftArrow, ModifierKeyFlags.None),
            (Action.Select, Pole.Positive, KeyCode.Return, ModifierKeyFlags.None),
            (Action.Back, Pole.Positive, KeyCode.Backspace, ModifierKeyFlags.None),
            (Action.Inspect, Pole.Positive, KeyCode.Space, ModifierKeyFlags.None),
            (Action.Settings, Pole.Positive, KeyCode.Escape, ModifierKeyFlags.None),
            (Action.Backpack, Pole.Positive, KeyCode.Tab, ModifierKeyFlags.None),
            (Action.Redraw_Bell, Pole.Positive, KeyCode.LeftShift, ModifierKeyFlags.None),
            (Action.Draw, Pole.Positive, KeyCode.LeftControl, ModifierKeyFlags.None),
            (Action.Discard, Pole.Positive, KeyCode.LeftAlt, ModifierKeyFlags.None),
            ];
    }
}
