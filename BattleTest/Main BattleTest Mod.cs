using Deadpan.Enums.Engine.Components.Modding;
using FMODUnity;
using HarmonyLib;
using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Localization;
using UnityEngine.Localization.SmartFormat.PersistentVariables;
using UnityEngine.UI;

namespace WildfrostHopeMod.BattleTest
{
    public class BattleTestMod : WildfrostMod
    {
        public FieldInfo[] GetAllFields<T>(T t) => (typeof(T) ?? t.GetType()).GetFields((BindingFlags)0x1FFFFFD);
        public StatusEffectDataBuilder StatusCopyBoxed<T>(string oldName, string newName) where T : StatusEffectData
        {
            StatusEffectData copyFrom = TryGet<StatusEffectData>(oldName);
            StatusEffectDataBuilder builder = new StatusEffectDataBuilder(this).Create<T>($"{GUID}.{newName}");
            foreach (var field in GetAllFields(copyFrom))
            {

                field.SetValue(builder._data, field.GetValue(typeof(T)));
                try { Debug.Log($"{field.Name}: {field.GetValue(typeof(T)) ?? "null"}"); }
                catch { }
            }
            return builder;
        }

        public T TryGet<T>(string name) where T : DataFile => Get<T>(name);
        public class PatchCampaignData
        {
            

            public StatusEffectDataBuilder StatusCopy(string oldName, string newName)
            {
                StatusEffectData data = TryGet<StatusEffectData>(oldName).InstantiateKeepName();
                data.name = GUID + "." + newName;
                data.targetConstraints = new TargetConstraint[0];
                StatusEffectDataBuilder builder = data.Edit<StatusEffectData, StatusEffectDataBuilder>();
                builder.Mod = this;
                return builder;
            }

            public static Task SaveCampaignDatas()
            {
                Debug.LogWarning("~CAMPAIGN GENERATED~");
                string preset = Campaign.instance.preset.text;
                SaveSystem.SaveCampaignData(Campaign.Data.GameMode, $"hope.preset", preset);

                var rewards = References.Player.GetComponent<CharacterRewards>().poolLookup;
                var _rewards = new Dictionary<string, SaveCollection<string>>();
                foreach (string category in rewards.Keys)
                {
                    _rewards[category] = rewards[category].list.ToSaveCollectionOfNames();
                }

                SaveSystem.SaveCampaignData(Campaign.Data.GameMode, "hope.rewards", _rewards);
                return Task.CompletedTask;
            }
            public static void LoadCampaignDatas()
            {
                if (!Campaign.instance || Campaign.Data == null)
                    return;
                Debug.LogWarning("~CAMPAIGN LOADED~");
                string preset = SaveSystem.LoadCampaignData<string>(Campaign.Data.GameMode, "hope.preset", null);
                Campaign.instance.preset ??= new TextAsset(preset);
                Debug.LogWarning("[AConsole] Reusing campaign preset from custom data:\n" + preset);

                var _rewards = SaveSystem.LoadCampaignData<Dictionary<string, SaveCollection<string>>>(Campaign.Data.GameMode, "hope.rewards", []);
                var rewards = new Dictionary<string, CharacterRewards.Pool>();
                foreach (string category in _rewards.Keys)
                {
                    rewards[category] = new CharacterRewards.Pool() { list = [] };
                    foreach (string name in _rewards[category].collection)
                    {
                        Type type = category switch
                        {
                            "Items" or "Units" => typeof(CardData),
                            "Charms" => typeof(CardUpgradeData),
                            "Modifiers" => typeof(GameModifierData),
                            _ => null,
                        };
                        if (type == null)
                        {
                            Debug.LogError($"[AConsole] Unrecognised CharacterReward category [{category}]. Couldn't assign decide which AddressableLoader group it belonged to");
                            continue;
                        }
                        DataFile data = AddressableLoader.Get<DataFile>(type.Name, name);
                        rewards[category].Add(data);
                    }
                }

                var poolLookup = References.Player.GetComponent<CharacterRewards>()?.poolLookup;
                if (poolLookup == null)
                    return;

                foreach (var key in rewards.Keys)
                    poolLookup[key] = rewards[key];
                Debug.LogWarning("[AConsole] Reusing character rewards from custom data:");
                foreach (var pool in poolLookup)
                {
                    Debug.LogWarning($"[AConsole] {pool.Key}");
                    Debug.Log(string.Join(", ", pool.Value.list?.ToArrayOfNames().DefaultIfEmpty("") ?? [""]));
                }
            }
        }


        public BattleTestMod(string modDirectory) : base(modDirectory)
        {

        }
        public override string GUID => "hope?.wildfrost.BattleTest";
        public override string[] Depends => new string[] { };
        public override string Title => "Battle Test?";
        public override string Description => "";

        [ConfigItem(true, "Describe your config here. What does it do?", "Toggle Custom Battle")]
        public bool toggleCustomBattles = true;

        private List<BattleDataEditor> enemyBattle;

        [HarmonyPatch(typeof(FMODUnity.RuntimeManager), nameof(FMODUnity.RuntimeManager.CreateInstance), typeof(FMOD.GUID))]
        [HarmonyPatch(typeof(FMODUnity.RuntimeManager), nameof(FMODUnity.RuntimeManager.CreateInstance), typeof(EventReference))]
        [HarmonyPatch(typeof(FMODUnity.RuntimeManager), nameof(FMODUnity.RuntimeManager.CreateInstance), typeof(string))]
        public class PatchSounds
        {
            static void Postfix(FMOD.Studio.EventInstance __result)
            {
                __result.getDescription(out var description);
                description.getPath(out var path);
                Debug.LogWarning($"AY BOSS WE POSTFIXED THIS GUY {Path.GetFileName(path)}");
                static FMOD.RESULT DialogueCallback(FMOD.Studio.EVENT_CALLBACK_TYPE type, IntPtr instancePtr, IntPtr paramPtr)
                {
                    switch (type)
                    {
                        case FMOD.Studio.EVENT_CALLBACK_TYPE.SOUND_PLAYED:
                            {
                                FMOD.Sound sound = new FMOD.Sound(paramPtr);
                                sound.getName(out string name, 1024);
                                Debug.LogWarning($"AY BOSS WE JUST GOT DA SOUND {name}");
                                break;
                            }
                    }
                    return FMOD.RESULT.OK;
                };
                var dialogueCallback = new FMOD.Studio.EVENT_CALLBACK(DialogueCallback);
                __result.setCallback(dialogueCallback);
            }
        }

        public LocalizedString uwu = EffectText();
        public override void Load()
        {
            static FMOD.RESULT DialogueCallback(FMOD.Studio.EVENT_CALLBACK_TYPE type, IntPtr instancePtr, IntPtr paramPtr)
            {
                switch (type)
                {
                    case FMOD.Studio.EVENT_CALLBACK_TYPE.SOUND_PLAYED:
                        {
                            FMOD.Sound sound = new FMOD.Sound(paramPtr);
                            sound.getName(out string name, 1024);
                            Debug.LogWarning($"AY BOSS WE JUST GOT DA SOUND {name}");
                            break;
                        }
                    case FMOD.Studio.EVENT_CALLBACK_TYPE.CREATE_PROGRAMMER_SOUND:
                        {
                            // Play a sound
                            break;
                        }
                    case FMOD.Studio.EVENT_CALLBACK_TYPE.DESTROY_PROGRAMMER_SOUND:
                        {
                            // Clean up the sound you made before
                            break;
                        }
                    case FMOD.Studio.EVENT_CALLBACK_TYPE.STOPPED:
                        {
                            // The event is being stopped
                            break;
                        }
                    case FMOD.Studio.EVENT_CALLBACK_TYPE.DESTROYED:
                        {
                            // The event is being destroyed
                            break;
                        }
                    }
            return FMOD.RESULT.OK;
            };
            var dialogueCallback = new FMOD.Studio.EVENT_CALLBACK(DialogueCallback);
            //SfxSystem.OneShot(default(EventReference)).setCallback(dialogueCallback);






            FMODUnity.RuntimeManager.StudioSystem.getBankList(out var banks);
            List<string> lines = new List<string>();
            foreach (var bank in banks)
            {
                bank.getPath(out string bankpath);
                //Debug.Log(bankpath);
                bank.getEventList(out var events);

                foreach (var e in events)
                {
                    e.isOneshot(out bool eOne);
                    //Events.InvokeAudioPitchChange("Master", 5);
                    e.getPath(out string path);
                    //Debug.Log(path + ": " + eOne);
                    e.getID(out FMOD.GUID id);

                    List<FMOD.Studio.PARAMETER_DESCRIPTION> descs = [];
                    e.getParameterDescriptionCount(out var parameterDescriptionCount);
                    for (int i = 0; i < parameterDescriptionCount+100; i++)
                    {
                        e.getParameterDescriptionByIndex(i, out var paramDesc);
                        if (paramDesc.guid.Equals(default))
                            continue;

                        descs.Add(paramDesc);
                        

                        Debug.LogWarning($"{path} :   {(string)paramDesc.name} {i}");
                        paramDesc.id.PrintAllFields();
                        paramDesc.PrintAllFields();
                    }
                    //phaseDesc.Next();
                    lines.Add($"{id}\t{descs.Select(d => (string)d.name).Join()}");
                }
            }
            lines.Sort();/*
            foreach (var line in lines)
                Debug.Log(line);*/
            Debug.Log(lines.Join(delimiter: "\n"));

            CoroutineManager.instance.gameObject.AddComponent<BattleTestModBehaviour>();
            
            base.Load();

            




            /*Transform parent = GameObject.FindObjectOfType<PauseMenu>(true).transform;

            // Textbox
            float width = 9;
            float height = 1;

            // Image adds CanvasRenderer, InputFieldKeepFocus adds TMP_InputField
            // Add ContentSizeFitter? VerticalLayoutGroup?
            GameObject container = new GameObject("InputField", typeof(RectTransform), typeof(Image), typeof(InputFieldKeepFocus));
            container.transform.SetParent(parent);
            (container.transform as RectTransform)?.SetSize(width, height);
            // Console settings
            var _image = container.GetOrAdd<Image>();
            _image.color = new Color(0, 0, 0, 0.502f);


            GameObject textContainer = new GameObject("Text", typeof(RectTransform), typeof(TextMeshProUGUI));
            textContainer.transform.SetParent(container.transform);
            (textContainer.transform as RectTransform)?.SetSize(width, height);
            var _text = textContainer.GetOrAdd<TextMeshProUGUI>();
            _text.richText = false;
            *//*_text.color = _console.colorText;
            _text.font = _console.fontFace;
            _text.fontSize = _console.fontSize;*//*
            _text.overflowMode = TextOverflowModes.Overflow;

            GameObject placeholderContainer = new GameObject("Placeholder", typeof(RectTransform), typeof(TextMeshProUGUI));
            placeholderContainer.transform.SetParent(container.transform);
            (placeholderContainer.transform as RectTransform)?.SetSize(width, height);
            var _placeholder = placeholderContainer.GetOrAdd<TextMeshProUGUI>();
            *//*_placeholder.color = new Color(_console.colorText.r, _console.colorText.g, _console.colorText.b, _console.colorText.a / 2);
            _placeholder.font = _console.fontFace;
            _placeholder.fontSize = _console.fontSize;*//*
            //_placeholder.fontStyle = FontStyle.Italic;
            _placeholder.richText = false;
            _placeholder.overflowMode = TextOverflowModes.Overflow;
            _placeholder.text = "Enter command ...";


            // Need to set the TextViewport for where text should be visible
            // Should have a dedicated TextArea, but we lazy
            var _inputField = container.GetOrAdd<TMP_InputField>();
            _inputField.textViewport = container.transform as RectTransform;
            // Extra stuff to define for the input field
            //var _inputField = container.GetOrAdd<TMP_InputField>();
            _inputField.targetGraphic = _image;
            _inputField.textComponent = _text;
            _inputField.placeholder = _placeholder;*/


            //MusicSystem.current.setParameterByName()

            //RuntimeManager.CreateInstance()
            /*foreach (var s in typeof(TargetMode).Assembly.GetTypes().Where(t => t.BaseType == typeof(TargetMode)))
                Debug.LogWarning((s.Name, Addressables.LoadAssetAsync<UnityEngine.Object>(s.Name).WaitForCompletion(), Extensions.GetTargetMode(s.Name)));
*/

            /*foreach (var card in AddressableLoader.GetGroup<CardData>("CardData"))
                card.targetMode = Extensions.GetTargetMode(nameof(TargetModeAll));


            // Enemy battle creation
            enemyBattle = new List<BattleDataEditor>();

            enemyBattle.Add( // test code. delete
                new BattleDataEditor(this, "yada yada battle name", goldGivers: 1)
                //.ConstructWaves(6, 0, some cool formations)
                );

            enemyBattle.Add( // test code. delete
                new BattleDataEditor(this, "yada yada battle name 2: electric boogaloo??", goldGivers: 1)
                //.ConstructWaves(6, 0, harder fight formation?)
                );

            foreach (BattleDataEditor bdEditor in enemyBattle)
            {
                ToggleBattle(bdEditor.bd, this.toggleCustomBattles);
            }
            
            // We have to unhook this in Unload
            ConfigManager.GetConfigSection(this).OnConfigChanged += ToggleBattlesOnConfigChanged;*/
        }


        /*void ToggleBattlesOnConfigChanged(ConfigItem item, object value)
        {
            
            foreach (BattleDataEditor bdEditor in enemyBattle)
            {
                if (bdEditor == null || bdEditor.bd == null)
                {
                    Debug.Log($"[{Title}] Custom battle is null. Ignoring...");
                    continue;
                }

                if (item.fieldName == nameof(this.toggleCustomBattles) && value is bool on)
                {
                    ToggleBattle(bdEditor.bd, on);
                }
            }
        }
        
        void ToggleBattle(BattleData bd, bool on = true)
        {
            GameMode gameMode = Get<GameMode>("GameModeNormal");
            if (bd == null)
                // If BD is null, we should panic
                throw new NullReferenceException("Toggle Battle error: BD is null somehow! Did you put this in the wrong place?");

            // This will delete the battle if config is off
            *//*if (!on)
            {
                gameMode.populator.battleLockers.tiers[tier].battlePool = gameMode.populator.tiers[tier].battlePool.Where(battle => battle != bd).ToArray();
                Debug.Log($"[{Title}] {bd.name} has been removed from tier {tier}");
            }
            else
            {
                gameMode.populator.tiers[tier].battlePool = gameMode.populator.tiers[tier].battlePool.With(bd);
                Debug.Log($"[{Title}] {bd.name} has been added to tier {tier}");
            }*//*
        }

        public override void Unload()
        {
            ConfigManager.GetConfigSection(this).OnConfigChanged -= ToggleBattlesOnConfigChanged;
            base.Unload();
        }*/

        public static LocalizedString EffectText(params string[] keys)
        {
            string result = "";
            return new LocalizedString("Credits_en", "hope_text")
            {
                { "owo", new StringVariable { Value = "Hellowo!" } }
            };

            /*foreach (var key in keys)
            {
                
            }
            new CardDataBuilder()
                .WithText()*/
        }
    }
    /*public static class owo
    {
        public static T PrintAllFields<T>(this T t, Type type = null)
        {
            foreach (var field in t.GetAllFields(type))
            {
                try { Debug.Log($"{field.Name}: {field.GetValue(t) ?? "null"}"); }
                catch { Debug.Log($"{field.Name} failed"); }
            }
            return t;
        }
        public static FieldInfo[] GetAllFields<T>(this T t, Type type = null)
        {
            return (type ?? t.GetType()).GetFields((BindingFlags)0x1FFFFFD);//.Concat(typeof(T).GetFields((BindingFlags)0x1FFFFFF)).ToArray();
        }
    }*/
}