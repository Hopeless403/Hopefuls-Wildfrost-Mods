using Deadpan.Enums.Engine.Components.Modding;
using FMODUnity;
using HarmonyLib;
using System;
using System.IO;
using TMPro;
using UnityEngine;

namespace WildfrostHopeMod.TemplateMod
{
    public class TemplateMod : WildfrostMod
    {
        public static TemplateMod Mod;
        public TemplateMod(string modDirectory) : base(modDirectory)
        {
            Mod = this;
        }
        public override string GUID => "hope.wildfrost.console";
        public override string[] Depends => new string[] { };
        public override string Title => "Another Console mod";
        public override string Description => "Access to the commands console & extra commands (btw use ~ to open it)\r\n\r\nExtra commands: (See \"help\" if ingame)\r\nexport card <name>: Screenshot the named card against a blank background\r\nexport card: Screenshot the hovered card (with any temporary battle data, charms etc.)\r\nexport all\r\nadd effect: Apply ANY effect in the game (aka the better add status)\r\nadd attackeffect: Give cards the \"Apply <effect>\" effect. Doesn't accept StatusEffectApply statuses to avoid confusion.\r\ngoto <scene>: Go to a scene. Currently limited to \"Town\" and \"MainMenu\".\r\nquick restart: End the current campaign as if you died, and start a new one.\r\ndatabuilder info <datatype> <name>: Prints the fields of any DataFile to the log console.\r\ndatabuilder info: Prints the fields of a hovered card to the log console";
        public override TMP_SpriteAsset SpriteAsset => base.SpriteAsset;
        public static GameObject behaviour;


        //public static Locale ru;
        public override void Load()
        {

            base.Load();

            behaviour = new GameObject("HopeModBehaviour");
            GameObject.DontDestroyOnLoad(behaviour);
            behaviour.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset |
                                  HideFlags.HideInInspector | HideFlags.NotEditable;

            var e = behaviour.AddComponent<HopeModBehaviour>();

            /*

            MonoBehaviour.print(Paths.LogPath); // .../LocalLow/Deadpan Games/Wildfrost
            MonoBehaviour.print(Paths.ExecutablePath); // .../steamapps/common/Wildfrost
            MonoBehaviour.print(Paths.PluginPath); // ...StreamingAssets/Mods/Hope*/
        }


        /*
        [HarmonyPatch(typeof(FontSetterSystem), nameof(FontSetterSystem.LocaleChanged))]
        internal class PatchFSS
        {
            [HarmonyPostfix]
            static void Postfix(FontSetterSystem __instance, ref Locale locale)
            {
                if (FontSetterSystem.current != null)
                {
                    MonoBehaviour.print("non-null fss!!!!!!!" + locale.LocaleName + locale.Identifier);
                    ru ??= LocalizationHelper.TryAddLocale(new LocaleIdentifier(SystemLanguage.Russian));
                    if (locale.Identifier == ru.Identifier)
                    {
                        MonoBehaviour.print("fss patching!!!!");
                        var font = TMP_FontAsset.CreateFontAsset(
                            new Font(Path.Combine(Paths.PluginPath, "Kreon-Regular.ttf"))
                        );
                        var o = Paths.ExecutablePath;
                        FontSetterSystem.current = font;
                        MonoBehaviour.print("fss updating!!!!");
                        FontSetterSystem.UpdateFontSetters();
                        Events.InvokeSettingChanged("Language", "ru");

                    }
                }
            }
        }
        [HarmonyPatch(typeof(SettingsLocaleSelector), nameof(SettingsLocaleSelector.GetStartupLocale))]
        internal class PatchSLS
        {
            static void Postfix(ref Locale __result, SettingsLocaleSelector __instance)
            {
                ru ??= LocalizationHelper.TryAddLocale(new LocaleIdentifier(SystemLanguage.Russian));
                if (__result == null && Settings.Load(__instance.settingsKey, "") == ru.Identifier)
                    // btw can swap out ru.Identifier for "ru"
                    __result = ru;
            }
        }*/


        public new T Get<T>(string assetName) where T : DataFile
        {
            if (typeof(T).IsSubclassOf(typeof(StatusEffectData)))
                return AddressableLoader.groups["StatusEffectData"].lookup[assetName] as T;
            return AddressableLoader.Get<T>(typeof(T).Name, assetName);
        }

        public override void Unload()
        {
            base.Unload();
            GameObject.Destroy(behaviour);
            behaviour = null;
            CoroutineManager.Start(SceneManager.Unload("Console"));
        }
    }



    public class HopeModBehaviour : MonoBehaviour
    {
        internal void Start()
        {
            //if (!SceneManager.IsLoaded("Console")) 
            CoroutineManager.Start(SceneManager.Load("Console", SceneType.Persistent));


        }

        void Update()
        {
            if (Input.GetKey(KeyCode.LeftAlt))
            {
                // ALT+R: Reloar campaign ("The R Key")
                if (Input.GetKeyDown(KeyCode.R))
                    new PauseMenu().QuickRestart();
            }

            if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.T))
                new Menu().GoToTown();

            if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.M))
            {
                Debug.LogWarning("Starting to play");
                //Events.InvokeScreenRumble(0.5f, 5, 0.0f, 1, 10, 1);
                Events.InvokeScreenRumble(0.0f, 0.4f, 0.0f, 0.4f, 0.1f, 0.4f);
                Sequences.WaitForAnimationEnd(Console.hover);
            }
        }
        /*
                    if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.R))
                    {
                        var se = ScriptableObject.CreateInstance<StatusEffectDeployDraw2>();
                        se.name = "Custom effect";
                        se.isStatus = true;
                        se.isReaction = false;
                        se.isKeyword = false;
                        se.type = "snow";
                        se.keyword = "snow";
                        se.stackable = false;
                        se.canBeBoosted = false;
                        se.desc = "Custom desc {0}";
                        se.applyFormat = "owo {0}";
                        se.iconGroupName = "counter";
                        se.visible = true;
                        se.targetConstraints = new TargetConstraint[0];

                        AddressableLoader.groups["StatusEffectData"].list.Add(se);
                        AddressableLoader.groups["StatusEffectData"].lookup.Add(se.name, se);




                        foreach (var c in Enumerable.Cast<CardData>(AddressableLoader.groups["CardData"].list))
                        {
                            if (c.cardType.title == "Leader")
                            {

                                MonoBehaviour.print(c.name);
                                c.attackEffects = c.attackEffects.With(new CardData.StatusEffectStacks(se, 1));
                                c.startWithEffects = c.startWithEffects.With(new CardData.StatusEffectStacks(se, 1));
                            }
                        }

                    }*//*
                }
        */
    }
}