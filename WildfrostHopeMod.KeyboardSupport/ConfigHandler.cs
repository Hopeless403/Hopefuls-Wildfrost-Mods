using Deadpan.Enums.Engine.Components.Modding;
using Rewired;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static Deadpan.Enums.Engine.Components.Modding.WildfrostMod;

namespace WildfrostHopeMod.KeyboardSupport
{
    public partial class KeyboardMod : WildfrostMod
    {
        [ConfigOptions("Hover over me")]
        [ConfigItem("Hover over me", "Configs are case-insensitive,\n//separated by a space for each entry.\n//\n//Refer to the mod folder for valid entries.txt", "Valid entries")]
        public string explanation;
        [ConfigItem("LeftAlt", "\n//Create a snow effect on the cursor, then logs into the console\n//\n//Mouse over to change", "Where Am I")]
        public string configWhereAmI;
        [ConfigManagerDesc("Toggle keyboard controls, eg for typing\n//\n//Mouse over to change")]
        [ConfigItem("Delete", "\n//Toggle keyboard controls, eg for typing", "Toggle")]
        public string configToggle;
        [ConfigManagerDesc("Mouse over to change")]
        [ConfigItem("W", "", "Up")] public string configUp;
        [ConfigManagerDesc("Mouse over to change")]
        [ConfigItem("S", "", "Down")] public string configDown;
        [ConfigManagerDesc("Mouse over to change")]
        [ConfigItem("D", "", "Right")] public string configRight;
        [ConfigManagerDesc("Mouse over to change")]
        [ConfigItem("A", "", "Left")] public string configLeft;
        [ConfigManagerDesc("Mouse over to change")]
        [ConfigItem("E Enter", "", "Select")] public string configSelect;
        [ConfigManagerDesc("Mouse over to change")]
        [ConfigItem("Q", "", "Back")] public string configBack;
        [ConfigManagerDesc("Mouse over to change")]
        [ConfigItem("R", "", "Inspect")] public string configInspect;
        [ConfigManagerDesc("Mouse over to change")]
        [ConfigItem("O", "", "Settings")] public string configSettings;
        [ConfigManagerDesc("Sometimes used as Left Option\n//\n//Mouse over to change")]
        [ConfigItem("F", "\n//Sometimes used as Left Option", "Backpack")]
        public string configBackpack;
        [ConfigManagerDesc("Sometimes used as Right Option\n//\n//Mouse over to change")]
        [ConfigItem("T", "\n//Sometimes used as Right Option", "Redraw Bell")] 
        public string configRedraw;
        [ConfigManagerDesc("Hover over the Draw Pile. Used in Battles only\n//\n//Mouse over to change")]
        [ConfigItem("-", "", "Draw Pile")] public string configDraw;
        [ConfigManagerDesc("Hover over the Discard Pile. Used in Battles only\n//\n//Mouse over to change")]
        [ConfigItem("Equals", "", "Discard Pile")] public string configDiscard;

        public class ConfigHandler : MonoBehaviour
        {
            public static readonly Dictionary<KeyCode, List<string>> keycodeStrings = new()
            {
                { KeyCode.Alpha0, ["alpha0", "0", "zero"]},
                { KeyCode.Alpha1, ["alpha1", "1", "one"]},
                { KeyCode.Alpha2, ["alpha2", "2", "two"]},
                { KeyCode.Alpha3, ["alpha3", "3", "three"]},
                { KeyCode.Alpha4, ["alpha4", "4", "four"]},
                { KeyCode.Alpha5, ["alpha5", "5", "five"]},
                { KeyCode.Alpha6, ["alpha6", "6", "six"]},
                { KeyCode.Alpha7, ["alpha7", "7", "seven"]},
                { KeyCode.Alpha8, ["alpha8", "8", "eight"]},
                { KeyCode.Alpha9, ["alpha9", "9", "nine"]},
                { KeyCode.A, ["a", "a"]},
                { KeyCode.B, ["b", "b"]},
                { KeyCode.C, ["c", "c"]},
                { KeyCode.D, ["d", "d"]},
                { KeyCode.E, ["e", "e"]},
                { KeyCode.F, ["f", "f"]},
                { KeyCode.G, ["g", "g"]},
                { KeyCode.H, ["h", "h"]},
                { KeyCode.I, ["i", "i"]},
                { KeyCode.J, ["j", "j"]},
                { KeyCode.K, ["k", "k"]},
                { KeyCode.L, ["l", "l"]},
                { KeyCode.M, ["m", "m"]},
                { KeyCode.N, ["n", "n"]},
                { KeyCode.O, ["o", "o"]},
                { KeyCode.P, ["p", "p"]},
                { KeyCode.Q, ["q", "q"]},
                { KeyCode.R, ["r", "r"]},
                { KeyCode.S, ["s", "s"]},
                { KeyCode.T, ["t", "t"]},
                { KeyCode.U, ["u", "u"]},
                { KeyCode.V, ["v", "v"]},
                { KeyCode.W, ["w", "w"]},
                { KeyCode.X, ["x", "x"]},
                { KeyCode.Y, ["y", "y"]},
                { KeyCode.Z, ["z", "z"]},
                { KeyCode.Exclaim, ["exclaim", "!"]},
                { KeyCode.DoubleQuote, ["doublequote", "\""]},
                { KeyCode.Hash, ["hash", "hashtag", "sharp", "#"]},
                { KeyCode.Dollar, ["dollar", "pound", "$"]},
                { KeyCode.Percent, ["percent", "%"]},
                { KeyCode.Ampersand, ["ampersand", "and", "&"]},
                { KeyCode.Quote, ["quote", "'"]},
                { KeyCode.LeftParen, ["leftparen", "leftparenthesis", "("]},
                { KeyCode.RightParen, ["rightparen", "rightparenthesis", ")"]},
                { KeyCode.Asterisk, ["asterisk", "*"]},
                { KeyCode.Plus, ["plus", "+"]},
                { KeyCode.Comma, ["comma", ","]},
                { KeyCode.Minus, ["minus", "-"]},
                { KeyCode.Period, ["period", "."]},
                { KeyCode.Slash, ["slash", "/"]},
                { KeyCode.Colon, ["colon", ":"]},
                { KeyCode.Semicolon, ["semicolon", ";"]},
                { KeyCode.Less, ["less", "<"]},
                { KeyCode.Equals, ["equals", "="]},
                { KeyCode.Greater, ["greater", ">"]},
                { KeyCode.Question, ["question", "?"]},
                { KeyCode.At, ["at", "@"]},
                { KeyCode.LeftBracket, ["leftbracket", "["]},
                { KeyCode.Backslash, ["backslash", "\\"]},
                { KeyCode.RightBracket, ["rightbracket", "]"]},
                { KeyCode.Caret, ["caret", "hat", "^"]},
                { KeyCode.Underscore, ["underscore", "_"]},
                { KeyCode.Tilde, ["tilde", "~"]},
                { KeyCode.LeftCurlyBracket, ["leftcurlybracket", "{"]},
                { KeyCode.Pipe, ["pipe", "|"]},
                { KeyCode.RightCurlyBracket, ["rightcurlybracket", "}"]},
                { KeyCode.None, ["none", "none"]},
                { KeyCode.BackQuote, ["backquote", "`"]},
                { KeyCode.UpArrow, ["uparrow", "up"]},
                { KeyCode.DownArrow, ["downarrow", "down"]},
                { KeyCode.RightArrow, ["rightarrow", "right"]},
                { KeyCode.LeftArrow, ["leftarrow", "left"]},
                { KeyCode.Backspace, ["backspace", "back"]},
                { KeyCode.Tab, ["tab"]},
                { KeyCode.Escape, ["escape", "esc"]},
                { KeyCode.Delete, ["delete", "delete"]},
                { KeyCode.LeftAlt, ["leftalt", "alt"]},
                { KeyCode.RightAlt, ["rightalt"]},
                { KeyCode.LeftShift, ["leftshift", "shift"]},
                { KeyCode.RightShift, ["rightshift"]},
                { KeyCode.LeftControl, ["leftcontrol", "leftctrl", "control", "ctrl"]},
                { KeyCode.RightControl, ["rightcontrol", "rightctrl"]},
                { KeyCode.Return, ["return", "enter"]},
                { KeyCode.Space, ["space"]},
            };
            public static readonly Dictionary<KeyCode, KeyCode> keycodeIsShiftOf = new()
            {
                { KeyCode.RightParen, KeyCode.Alpha0},
                { KeyCode.Exclaim, KeyCode.Alpha1},
                { KeyCode.At, KeyCode.Alpha2},
                { KeyCode.Hash, KeyCode.Alpha3},
                { KeyCode.Dollar, KeyCode.Alpha4},
                { KeyCode.Percent, KeyCode.Alpha5},
                { KeyCode.Caret, KeyCode.Alpha6},
                { KeyCode.Ampersand, KeyCode.Alpha7},
                { KeyCode.Asterisk, KeyCode.Alpha8},
                { KeyCode.LeftParen, KeyCode.Alpha9},
                { KeyCode.Underscore, KeyCode.Minus},
                { KeyCode.Plus, KeyCode.Equals},
                { KeyCode.LeftCurlyBracket, KeyCode.LeftBracket},
                { KeyCode.RightCurlyBracket, KeyCode.RightBracket},
                { KeyCode.Pipe, KeyCode.Backslash},
                { KeyCode.Colon, KeyCode.Semicolon},
                { KeyCode.DoubleQuote, KeyCode.Quote},
                { KeyCode.Less, KeyCode.Comma},
                { KeyCode.Greater, KeyCode.Period},
                { KeyCode.Question, KeyCode.Slash},
            };

            public static KeyCode StringToKeycode(string s)
            {
                if (s.IsNullOrWhitespace())
                    return KeyCode.None;
                var keyCode = keycodeStrings.FirstOrDefault(pair => pair.Value.Contains(s.ToLower()));
                return keyCode.Key;
            }
            public static KeyCode[] ConfigToKeycode(string config)
            {
                IEnumerable<string> strings = Console.Command.Split(config?.Trim() ?? "").DefaultIfEmpty("");
                IEnumerable<KeyCode> keycodes = strings.Select(StringToKeycode).Where(k => k != KeyCode.None).DefaultIfEmpty();
                if (!keycodes.Any()) keycodes = [KeyCode.None];
                return keycodes.ToArray();
            }
            public static List<(Action action, Pole pole, KeyCode keyCode, ModifierKeyFlags modifiers)>
                KeycodeToElement(string title, KeyCode[] keyCodes)
            {
                List<(Action action, Pole pole, KeyCode keyCode, ModifierKeyFlags modifiers)> result = new();
                foreach (var keycode in keyCodes)
                {
                    (Action action, Pole pole) current = new();
                    (current.action, current.pole) = title switch
                    {
                        "Up" => (Action.Up, Pole.Positive),
                        "Down" => (Action.Up, Pole.Negative),
                        "Right" => (Action.Right, Pole.Positive),
                        "Left" => (Action.Right, Pole.Negative),
                        "Select" => (Action.Select, Pole.Positive),
                        "Back" => (Action.Back, Pole.Positive),
                        "Inspect" => (Action.Inspect, Pole.Positive),
                        "Settings" => (Action.Settings, Pole.Positive),
                        "Backpack" => (Action.Backpack, Pole.Positive),
                        "Redraw Bell" => (Action.Redraw_Bell, Pole.Positive),
                        _ => (Action.Invalid, Pole.Positive)
                    };
                    if (keycodeIsShiftOf.TryGetValue(keycode, out var unshifted))
                    {
                        result.AddRange([
                            (current.action, current.pole, unshifted, ModifierKeyFlags.LeftShift),
                            (current.action, current.pole, unshifted, ModifierKeyFlags.RightShift),
                        ]);
                    }
                    else
                        result.Add((current.action, current.pole, keycode, ModifierKeyFlags.None));
                }
                return result;
            }
            public static KeyboardMap currentMap = null;
            public static void CreateMapFromConfigs()
            {
                currentMap = new KeyboardMap();
                HotkeyBattle.Reset();
                HotkeysGlobal.Reset();
                Debug.LogWarning("[Keyboard Support] Creating KeyboardMap");
                foreach (var field in typeof(KeyboardMod).GetFields((BindingFlags)0x1FFFFFD)
                    .Where(f => f.GetCustomAttribute(typeof(ConfigItemAttribute)) != null))
                {
                    string title = field.Name.Replace("config", "");
                    string config = field.GetValue(Mod) as string;
                    var keycodes = ConfigToKeycode(config);
                    var elements = KeycodeToElement(title, keycodes);
                    foreach (var (action, pole, keyCode, modifiers) in elements)
                    {
                        Debug.Log(Keyboard.GetKeyName(keyCode, modifiers) + ": " + (action != Action.Invalid ? action : title));
                        //if (action != Action.Invalid)
                            currentMap.CreateElementMap((int)action, pole, keyCode, modifiers);
                        if (action == Action.Invalid)//else
                        {
                            switch (title)
                            {
                                case ("WhereAmI"):
                                case ("Toggle"):
                                    HotkeysGlobal.AddKey(title, keyCode);
                                    break;
                                case ("Draw"):
                                case ("Discard"):
                                    HotkeyBattle.AddKey(title, modifiers != ModifierKeyFlags.None, keyCode);
                                    break;
                            };
                        }
                    }
                };

                var controllers = RewiredControllerManager.GetPlayerController(0).controllers;
                controllers.maps.AddMap(controllers.Keyboard, currentMap);

            }
            public void OnEnable()
            {
                CreateMapFromConfigs();
                ConfigManager.GetConfigSection(Mod).OnConfigChanged += OnConfigChanged;
            }
            public void OnDisable()
            {
                ConfigManager.GetConfigSection(Mod).OnConfigChanged -= OnConfigChanged;
            }
            bool fixing = false;
            public void OnConfigChanged(Configs.ConfigItem config, object value)
            {
                KeyCode[] fixers = [KeyCode.None, KeyCode.Equals, KeyCode.Colon];

                IEnumerable<string> args = Console.Command.Split(value.ToString());
                Debug.LogWarning("[Keyboard Support] Fixed? "+ 
                    (args.All(a => !fixers.Contains(StringToKeycode(a))) | fixing));
                if (args.Any(a => fixers.Contains(StringToKeycode(a))) && !fixing)
                {
                    args = args.Where(a => StringToKeycode(a) != KeyCode.None)
                               .Select(s => s switch
                                   {
                                       "=" => "Equals",
                                       ":" => "Colon",
                                       _ => s
                                   }
                               );
                    fixing = true;
                    if (config.fieldName != nameof(Mod.explanation))
                        ConfigManager.SaveConfig(config.con, string.Join(" ", args));
                    fixing = false;
                }
                else CreateMapFromConfigs();
            }
        }
    }
}
