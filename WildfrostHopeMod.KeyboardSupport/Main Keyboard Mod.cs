using Deadpan.Enums.Engine.Components.Modding;
using FMODUnity;
using HarmonyLib;
using NaughtyAttributes;
using Rewired;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Policy;
using TMPro;
using UnityEngine;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization.Tables;
using UnityEngine.Localization;

namespace WildfrostHopeMod.KeyboardSupport
{
    public enum Action
    {
        Invalid = -1,
        Select = 0, // Maps to: A, A, Cross, Left-click
        Back = 1, // Maps to: B, B, Circle, Right-click
        Inspect = 2, // Also: Help, Options
                     // Maps to: X, X, Square, 1-tap
        Right = 7, // Maps to: 
        Up = 8, // Maps to: 
        Settings = 10, // Maps to: 
        Backpack = 11, // Maps to: LB, L, L1, NULL
        Redraw_Bell = 12, // Maps to: RB, R, R1, NULL
    }
    public partial class KeyboardMod : WildfrostMod
    {
        public static KeyboardMod Mod;
        public KeyboardMod(string modDirectory) : base(modDirectory)
        {
            Mod = this;
        }
        public override string GUID => "hope.wildfrost.keyboard";
        public override string[] Depends => new string[] { "hope.wildfrost.configs"};
        public override string Title => "Keyboard Support";
        public override string Description => "Enables the keyboard input. Change the control scheme using Config Manager.\r\nDefaults:\r\nWhereAmI = \"LeftAlt\", Toggle = \"Delete\"\r\nDirectional inputs = WASD\r\nSelect = E or \"Enter\"\r\nBack = Q\r\nInspect = R\r\nSettings = O\r\nBackpack = F\r\nRedraw Bell = T\r\nDraw Pile = \"Minus\"\r\nDiscard Pile = \"Equals\"";
        public override TMP_SpriteAsset SpriteAsset => CreateSpriteAsset();
        public static GameObject behaviour;
        public static readonly string supportedKeys = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ!\"#$%&\'()*+,-./:;<=>?@[\\]^_~{|}";
        public static readonly KeyCode[] supportedKeyCodes = [KeyCode.None, KeyCode.BackQuote,
            KeyCode.UpArrow, KeyCode.DownArrow, KeyCode.RightArrow, KeyCode.LeftArrow, KeyCode.Backspace,
            KeyCode.Tab, KeyCode.Escape, KeyCode.Delete, KeyCode.LeftAlt, KeyCode.RightAlt, KeyCode.LeftShift,
            KeyCode.RightShift, KeyCode.LeftControl, KeyCode.RightControl, KeyCode.Return, KeyCode.Space];
        public static Texture2D buttonSheet;
        public static List<Sprite> buttons = new();

        /// <summary>lookup from KeyCode to element. independent of mapping to Actions. Essentially visual</summary>
        public static JoystickButtonStyle buttonStyle;
        /// <summary>struct of textKey and sprite for this KeyCode</summary>
        public static List<JoystickButtonStyle.ElementButton> buttonStyleElements;
        public static bool init = false;
        public static void Init()
        {
            Player playerController = RewiredControllerManager.GetPlayerController(0);
            Controller controller = playerController.controllers.Keyboard;

            /// create the sprites for each button
            buttonSheet = Path.Combine(Mod.ImagesDirectory, "button sprites.png").ToTex();
            for (int i = 0; i < supportedKeys.Length; i++)
            {
                var rect = new Rect(150 * (i % 10), 150 * Mathf.CeilToInt(9 - i / 10), 150, 150);
                var sprite = Sprite.Create(buttonSheet, rect, 0.5f * Vector2.one, 100, 0, SpriteMeshType.FullRect);
                sprite.name = supportedKeys[i].ToString();
                buttons.Add(sprite);
            }
            for (int i = 0; i < supportedKeyCodes.Length; i++)
            {
                var j = i + supportedKeys.Length;
                var rect = new Rect(150 * (j % 10), 150 * Mathf.CeilToInt(9 - j / 10), 150, 150);
                var sprite = Sprite.Create(buttonSheet, rect, 0.5f * Vector2.one, 100, 0, SpriteMeshType.FullRect);
                sprite.name = Keyboard.GetKeyName(supportedKeyCodes[i]);
                buttons.Add(sprite);
            }

            /// create elements for each button
            buttonStyleElements = [];
            foreach (var button in controller.ButtonElementIdentifiers)
            {
                var element = new JoystickButtonStyle.ElementButton()
                {
                    textKey = CreateString(button.name),
                    elementName = button.name,
                    buttonSprite = buttons.FirstOrDefault(sprite => sprite.name == button.name)
                };
                buttonStyleElements.Add(element);
            }

            /// create the keyboard style
            buttonStyle = new JoystickButtonStyle()
            {
                name = "Keyboard_default",
                type = Rewired.ControllerType.Keyboard,
                elements = [.. buttonStyleElements]
            };
            if (ControllerButtonSystem.instance.styles.All(s => s.name != buttonStyle.name))
                ControllerButtonSystem.instance.styles = ControllerButtonSystem.instance.styles.With(buttonStyle);
            SetKeyboardStyle();
            Debug.LogWarning(("ControllerButtonStyle Set: [" + ControllerButtonSystem.style.name + "]"));
            init = true;

        }
        public static void OnFocusChanged(bool focused)
        {
            if (!focused) GameObject.FindObjectOfType<InputSwitcher>()?.SwitchTo(2);
        }
        public override void Load()
        {
            base.Load();
            if (!init) Init();
            Application.focusChanged += OnFocusChanged;
            RewiredControllerManager.ControllerConnected(new Rewired.ControllerStatusChangedEventArgs("", 0, ControllerType.Keyboard));
            RewiredControllerManager.GetPlayerController(0).controllers.maps.SetAllMapsEnabled(true);

            behaviour = new GameObject(GetType().Name, 
                //typeof(HopeKeyboardModBehaviour), 
                typeof(ConfigHandler),
                typeof(HotkeyBattle),
                typeof(HotkeysGlobal),
                typeof(FixScrollToNavigations),
                typeof(FixScrollingOverTooManyCards)
                //,typeof(FixRecall)
                );
            GameObject.DontDestroyOnLoad(behaviour);
            behaviour.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset |
                                  HideFlags.HideInInspector | HideFlags.NotEditable;

            var inspectSystem = GameObject.FindObjectOfType<InspectSystem>();
            if (inspectSystem)
            {
                inspectSystem.closeInputs = inspectSystem.closeInputs.Without("Inspect").ToArray();
                inspectSystem.inspectCharmsInput = "Inspect";
                var table = LocalizationHelper.GetCollection("UI Text", LocalizationSettings.SelectedLocale.Identifier);
                table.SetString("inspect_charms_gamepad",
                    table.GetString("inspect_charms_gamepad").GetLocalizedString().Replace("<action=Options>", "<action=Inspect>")
                    );
            }
            Resources.FindObjectsOfTypeAll<TMP_SpriteAsset>()
                .FirstOrDefault(sa => sa.name == "Controller ButtonSheet")
                ?.fallbackSpriteAssets.Add(SpriteAsset);

            Debug.LogWarning("APp focused?" + Application.isFocused);
        }


        public static TMP_SpriteAsset CreateSpriteAsset()
        {
            if (!init) Init();
            Texture2D atlas = buttonSheet;
            // Initialise the material with the texture atlas
            Shader shader = Shader.Find("TextMeshPro/Sprite");
            Material material = new(shader);
            material.SetTexture(ShaderUtilities.ID_MainTex, atlas);

            // Create a new sprite asset
            TMP_SpriteAsset spriteAsset = TMP_Settings.defaultSpriteAsset.InstantiateKeepName();
            new Action<TMP_SpriteAsset>(s => {
                s.name = Mod.GUID + ".Sheet";
                s.spriteGlyphTable.Clear();
                s.spriteCharacterTable.Clear();
                s.material = material;
                s.spriteSheet = atlas;
                s.UpdateLookupTables();
            }).Invoke(spriteAsset);

            // Add each rect as a SpriteCharacter
            foreach (var button in buttons)
            {
                var rect = button.textureRect;
                TMP_SpriteGlyph spriteGlyph = new()
                {
                    glyphRect = new((int)rect.x, (int)rect.y, (int)rect.width, (int)rect.height),
                    index = (uint)spriteAsset.spriteGlyphTable.Count, // otherwise defaults to index 0
                    metrics = new(170.6667f, 170.6667f, -10, 150, 150),
                    scale = 1.5f,
                };
                spriteAsset.spriteGlyphTable.Add(spriteGlyph);
                TMP_SpriteCharacter spriteCharacter = new(spriteGlyph.index, spriteGlyph) { name = button.name };
                spriteAsset.spriteCharacterTable.Add(spriteCharacter);
            }

            spriteAsset.UpdateLookupTables();
            return spriteAsset;
        }
        public override void Unload()
        {
            base.Unload();
            Application.focusChanged -= OnFocusChanged;
            RewiredControllerManager.ControllerDisconnected(new Rewired.ControllerStatusChangedEventArgs("", 0, ControllerType.Keyboard));
            //RewiredControllerManager.GetPlayerController(0).controllers.maps.ClearMaps(ControllerType.Keyboard, true);
            var inspectSystem = GameObject.FindObjectOfType<InspectSystem>();
            if (inspectSystem)
            {
                inspectSystem.closeInputs = inspectSystem.closeInputs.With("Inspect").ToArray();
                inspectSystem.inspectCharmsInput = "Options";
                var table = LocalizationHelper.GetCollection("UI Text", LocalizationSettings.SelectedLocale.Identifier);
                table.SetString("inspect_charms_gamepad",
                    table.GetString("inspect_charms_gamepad").GetLocalizedString().Replace("<action=Inspect>", "<action=Options>")
                    );
            }

            GameObject.Destroy(behaviour);
            behaviour = null;
        }

        

        public static LocalizedString CreateString(string text)
        {
            StringTable collection = LocalizationHelper.GetCollection("UI Text", LocalizationSettings.Instance.GetSelectedLocale().Identifier);
            collection.SetString("hope." + text, text);
            return collection.GetString("hope." + text);
        }
        public static void SetKeyboardStyle()
        {
            Player playerController = RewiredControllerManager.GetPlayerController(0);
            Controller controller = playerController.controllers.Keyboard;
            if (controller == null)
                return;

            ControllerButtonSystem.style = buttonStyle;
            if (ControllerButtonSystem.style == null)
                ControllerButtonSystem.style = ControllerButtonSystem.instance.defaultControllerStyle;
            global::Events.InvokeButtonStyleChanged();
        }

    }
}