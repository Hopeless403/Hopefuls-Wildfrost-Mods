using System;
using System.Collections;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using Deadpan.Enums.Engine.Components.Modding;
using static Deadpan.Enums.Engine.Components.Modding.WildfrostMod;
using static WildfrostHopeMod.ConfigManager.PatchJournal;
using TMPro;
using UnityEngine.Localization.Components;
using System.ComponentModel;
using System.Collections.Generic;
using HarmonyLib;
using UnityEngine.Windows;
using static WildfrostHopeMod.ConfigManager;

namespace WildfrostHopeMod.Configs
{
    public partial class ConfigItem
    {
        public GameObject button;
        public bool visible;
        public readonly string fieldName;
        public readonly ConfigSection parent;
        public readonly ConfigType type;
        /// <summary>
        /// Use ConfigManager.SaveConfig() to set this
        /// </summary>
        public object currentValue { get; internal set; }

        bool takesInput = true;
        public (ConfigItemAttribute atr, System.Reflection.FieldInfo field) con;
        HideIfConfigAttribute[] _hideIf;
        ShowIfConfigAttribute[] _showIf;
        Dictionary<int, HashSet<ConfigItem>> hiders = new();
        Dictionary<int, HashSet<ConfigItem>> showers = new();

        public readonly ConfigManagerTitleAttribute _titleAtr;
        public readonly ConfigManagerDescAttribute _descAtr;
        public readonly ConfigOptionsAttribute _optionsAtr;
        public readonly ConfigSliderAttribute _sliderAtr;
        public ConfigManagerTitleAttribute titleAtr { get; set; }
        public ConfigManagerDescAttribute descAtr { get; set; }
        public ConfigOptionsAttribute optionsAtr { get; set; }
        public ConfigSliderAttribute sliderAtr { get; set; }


        private string _title = "";
        public string title
        {
            get { return _title; }
            set 
            { 
                _title = value;
                UpdateTitle(_title);
            }
        }
        private string _desc = null;
        public string desc
        {
            get { return _desc; }
            set
            {
                _desc = value;
                UpdateDesc(_desc);
            }
        }
        public WildfrostMod Mod => parent.mod;
        public JournalPage Section => parent.section;

        public ConfigItem(ConfigSection parent, (ConfigItemAttribute atr, System.Reflection.FieldInfo field) con)
        {
            this.parent = parent;
            this.con = con;
            fieldName = con.field.Name;
            currentValue = con.field.GetValue(Mod);
            // WIP
            /*
            if (Settings.Exists(Extensions.PrefixGUID(fieldName, Mod)))
            {
                try
                {
                    Debug.LogError(fieldName + " was " + currentValue);
                    var info = ES3.Load(Extensions.PrefixGUID(fieldName, Mod), default(ConfigInfo), Settings.settings);
                    if (info.Title != default(ConfigInfo).Title)
                        currentValue = info.Value;
                    Debug.LogWarning(fieldName + " is " + currentValue);
                }
                catch (Exception message)
                {
                    Debug.LogWarning(message);
                }
            }
            */
            titleAtr = _titleAtr = (ConfigManagerTitleAttribute)Attribute.GetCustomAttribute(con.field, typeof(ConfigManagerTitleAttribute));
            descAtr = _descAtr = (ConfigManagerDescAttribute)Attribute.GetCustomAttribute(con.field, typeof(ConfigManagerDescAttribute)) ?? new(desc);
            
            takesInput = Attribute.IsDefined(con.field, typeof(ConfigInputAttribute));
            optionsAtr = _optionsAtr = (ConfigOptionsAttribute)Attribute.GetCustomAttribute(con.field, typeof(ConfigOptionsAttribute));
            sliderAtr = _sliderAtr = (ConfigSliderAttribute)Attribute.GetCustomAttribute(con.field, typeof(ConfigSliderAttribute));
            type = (optionsAtr != null ? ConfigType.Options : ConfigType.None) | (sliderAtr != null ? ConfigType.Slider : ConfigType.None);
            type |= (takesInput | type == ConfigType.None) ? ConfigType.Input : ConfigType.None;

            _hideIf = Attribute.GetCustomAttributes(con.field, typeof(HideIfConfigAttribute)) as HideIfConfigAttribute[];
            _showIf = Attribute.GetCustomAttributes(con.field, typeof(ShowIfConfigAttribute)) as ShowIfConfigAttribute[];

            visible = CreateItem(con) && !Attribute.IsDefined(con.field, typeof(HideInConfigManagerAttribute));
            SetVisibilityListeners();
            UpdateVisibility();

            parent.OnConfigChanged += (i, v) =>
            {
                if (i != this) return;
                currentValue = v;

                var info = new JSONHandler.ConfigInfo(i);
                JSONHandler.SaveToSettingsJson(Extensions.PrefixGUID(i.fieldName, i.Mod), info);
                FixHeight(i);
            };

        }

        [Flags]
        public enum ConfigType
        {
            None = 0,
            Input = 1,
            Options = 2,
            Slider = 4
        }


        /// <summary>
        /// Result determines whether to show this section
        /// </summary>
        /// <param name="page"></param>
        /// <param name="mod"></param>
        /// <param name="con"></param>
        /// <returns></returns>
        bool CreateItem((ConfigItemAttribute atr, System.Reflection.FieldInfo field) con)
        {
            Type type = con.field.FieldType;
            if (Section.transform.FindRecursive(fieldName))
            {
                button = Section.transform.FindRecursive(fieldName).gameObject;
                button.SetActive(visible);
                return visible;
            }
            if (sliderAtr != null || type == typeof(float)) return CreateSlider(con, sliderAtr?.range ?? new Vector2(0, 1));
            if (optionsAtr == null)
            {
                if (type.IsEnum && !Attribute.IsDefined(type, typeof(FlagsAttribute))) optionsAtr = new ConfigOptionsAttribute(type);
                else if (type == typeof(bool)) optionsAtr = new ConfigOptionsAttribute();
                //else if (type == typeof(int)) optr = new ConfigOptionsAttribute(Enumerable.Range(0, 100).ToArray());
                else takesInput = true;
            }

            button = templateBoolType.gameObject.InstantiateKeepName();
            button.gameObject.SetActive(false);
            button.name = fieldName;
            button.transform.SetParent(Section.transform);
            button.transform.rotation = templateBoolType.transform.rotation;
            button.transform.localScale = templateBoolType.transform.localScale;

            button.GetComponent<UINavigationItem>().navigationLayer = modSettingsPage.GetComponent<UINavigationLayer>();
            button.GetComponent<SetSettingInt>().Destroy();
            CreateButtonLabel(button, optionsAtr);


            var label = button.transform.FindRecursive("Label");
            label.GetComponent<TextMeshProUGUI>().fontSizeMin = 0.17f; // label.GetComponent<TextMeshProUGUI>().fontSizeMax/2;
            label.GetComponent<TextMeshProUGUI>().alignment = TextAlignmentOptions.Top;

            #region onValueChanged listener
            ConfigOptionsAttribute options = optionsAtr;
            button.GetComponent<SettingOptions>().onValueChanged = new();
            button.GetComponent<SettingOptions>().onValueChanged.AddListener(
                new UnityEngine.Events.UnityAction<int>(val =>
                {
                    var configValue = options.values[val];
                    label.GetComponentInChildren<TextMeshProUGUI>().text = options.lookup.First(p => Equals(p.Value, configValue)).Key;
                    ConfigManager.SaveConfig(con, configValue);
                })
            );
            #endregion

            title = _titleAtr?.title ?? con.atr.forceTitle;
            UpdateDesc(_descAtr?.desc ?? con.atr.comment?.Replace("\n//", "\n"), _descAtr?.overridePreprocessing ?? false);
            if (takesInput) CreateRenameButton(button);
            foreach (var image in button.GetComponentsInChildren<Image>())
            {
                image.GetComponentInChildren<Image>().material = Templates.Title.material;
                image.maskable = true;
            }

            button.gameObject.SetActive(true);
            return true;
        }

        void CreateButtonLabel(GameObject button, ConfigOptionsAttribute optr = null)
        {
            var optionName = con.field.GetValue(Mod)?.ToString() ?? "NULL";
            optr ??= new ConfigOptionsAttribute(optionName);
            SettingOptions setter = button.GetComponent<SettingOptions>();

            setter.dropdown.ClearOptions();
            setter.dropdown.AddOptions(optr.lookup.Keys.ToList());
            var label = button.transform.FindRecursive("Label");
            label.DestroyAllChildren();

            var optionSetter = button.GetComponentInChildren<OptionSetter>();
            optionSetter.options = new GameObject[0];
            foreach (var name in optr.lookup.Keys)
            {
                var option = templateOption.InstantiateKeepName();
                option.name = name.Replace('_', ' ').Trim();
                option.transform.SetParent(label);
                option.GetComponentsInChildren<LocalizeStringEvent>().Update(e => e.enabled = false);
                //option.GetComponentsInChildren<FontSetter>().Update(e => e.enabled = false);
                optionSetter.options = optionSetter.options.With(option);
            }

            var defaultIndex = Mathf.Max(optr.lookup.Values.Select(v => v.ToString()).ToList().IndexOf(optionName), optr.lookup.Keys.ToList().IndexOf(optionName), 0);

            setter.SetValue(defaultIndex);
            label.GetComponentInChildren<TextMeshProUGUI>().text = optr.lookup.Keys.ToList()[defaultIndex];
            label.GetComponentInChildren<TextMeshProUGUI>().maskable = true;
            label.GetComponentInChildren<TextMeshProUGUI>().enabled = true;

            if (label.childCount <= 1)
            {
                label.parent.Find("Right").gameObject.Destroy();
                label.parent.Find("Left").gameObject.Destroy();
                setter.Destroy();
            }
        }



        bool CreateSlider((ConfigItemAttribute atr, System.Reflection.FieldInfo field) con, Vector2 range)
        {
            if (range == null) throw new ArgumentNullException(typeof(ConfigSliderAttribute).FullName + ".range");

            var diff = range.y - range.x;

            button = templateSlider.gameObject.InstantiateKeepName();
            button.gameObject.SetActive(false);
            button.name = fieldName;
            button.transform.SetParent(Section.transform);
            button.transform.rotation = templateBoolType.transform.rotation;
            button.transform.localScale = templateBoolType.transform.localScale;

            button.GetComponent<SetSettingFloat>().Destroy();


            var actualTitle = titleAtr?.title ?? con.atr.forceTitle;


            SettingSlider setter = button.GetComponent<SettingSlider>();
            //setter.slider.onValueChanged.RemoveAllListeners();
            setter.slider.onValueChanged = new();
            setter.slider.minValue = 0;
            setter.slider.maxValue = 1;
            ConfigSliderAttribute csa = (ConfigSliderAttribute)Attribute.GetCustomAttribute(con.field, typeof(ConfigSliderAttribute)) ?? new();
            // round to nearest step size if given
            float rounded = Convert.ToSingle(con.field.GetValue(Mod)) - csa.range.x;
            /*float stepSize = csa.stepSize;
            if (stepSize > 0)
            {
                rounded = (float)(Math.Round(rounded/stepSize)*stepSize);
            }*/

            var val = diff == 0 ? 0 : rounded / diff;
            setter.SetValue(val);

            #region onValueChanged listener
            setter.slider.onValueChanged.AddListener(
                new UnityEngine.Events.UnityAction<float>(val =>
                {
                    object configValue = range.x + diff * val;
                    if (con.field.FieldType == typeof(int)) 
                        configValue = Mathf.RoundToInt((float)configValue);
                    title = $"{actualTitle}\n({configValue})";
                    ConfigManager.SaveConfig(con, configValue);
                })
            );
            #endregion
            title = $"{actualTitle}\n({con.field.GetValue(Mod)})";
            UpdateDesc(descAtr?.desc ?? con.atr.comment?.Replace("\n//", "\n"), descAtr?.overridePreprocessing ?? false);
            if (takesInput) CreateRenameButton(button);
            foreach (var image in button.GetComponentsInChildren<Image>())
            {
                image.GetComponentInChildren<Image>().material = Templates.Title.material;
                image.maskable = true;
            }

            button.gameObject.SetActive(true);
            return true;
        }

        internal static void FixHeight(ConfigItem item) => new Routine(FixHeightRoutine(item));
        internal static IEnumerator FixHeightRoutine(ConfigItem item)
        {
            yield return null;
            var button = item.button;
            int titleLineCount = Mathf.Max(button.transform.Find("Animator/Text").GetComponent<TextMeshProUGUI>().textInfo.lineCount - 1, 0);
            int optionLineCount = Mathf.Max(button.transform.Find("Animator/Dropdown/Label")?.GetComponent<TextMeshProUGUI>().textInfo.lineCount - 2 ?? 0, 0);
            if (button.GetComponent<LayoutElement>()) button.GetComponent<LayoutElement>().minHeight = 1 + 0.4f * titleLineCount + 0.2f * optionLineCount;
            foreach (var child in new string[] { "Text", "Dropdown", "Slider" })
            {
                Transform t = button.transform.FindRecursive(child);
                if (t) t.localPosition = new Vector3(0, -0.1f, 0) * (2 * titleLineCount - 1 * optionLineCount);
            }
        }

        public void UpdateLabel()
        {
            string label = currentValue.ToString();
            if (optionsAtr != null && optionsAtr.lookup.Any())
                label = optionsAtr.lookup.FirstOrDefault(pair => pair.Value == currentValue).Key;
            UpdateLabel(label);
        }
        internal void UpdateLabel(string label)
        {
            button.transform.FindRecursive("Label")?.GetComponentInChildren<TextMeshProUGUI>()?.SetText(label);
        }
        public void UpdateTitle(string title)
        {
            TextMeshProUGUI t = button.GetComponentInChildren<TextMeshProUGUI>();
            titleAtr = new(title);
            if (!button.gameObject.activeSelf)
            {
                button.GetComponentsInChildren<LocalizeStringEvent>().Update(e => e.enabled = false);
                button.GetComponentsInChildren<FontSetter>().Update(e => e.enabled = false);
                t.text = titleAtr.title ?? _titleAtr?.title ?? con.atr.forceTitle;
                t.maskable = true;
                t.alignment = TextAlignmentOptions.Bottom;
            }
            t.text = title;
        }
        public void UpdateDesc(string desc = null, bool overridePreprocessing = false)
        {
            descAtr = new(desc, overridePreprocessing);
            EventTriggerDescription? d = !descAtr.desc.IsNullOrWhitespace() ? button.FindObject("Animator")?.GetOrAdd<EventTriggerDescription>() : button.FindObject("Animator")?.GetComponent<EventTriggerDescription>();
            if (!d) return;
            
            d.button = button;
            d.desc = descAtr.desc;
            d.overridePreprocessing = overridePreprocessing;
            d.enabled = !d.desc.IsNullOrWhitespace();


            /*var layout = button.GetOrAdd<FlowLayoutGroup>();
            layout.startAxis = FlowLayoutGroup.Axis.Vertical;
            layout.childAlignment = TextAnchor.UpperLeft;*/
        }

        void SetVisibilityListeners()
        {
            if (Attribute.IsDefined(con.field, typeof(HideInConfigManagerAttribute)))
                hiders[int.MinValue + 1] = new() { this };
            foreach (var atr in _hideIf)
            {
                if (atr.listeningTo == fieldName || !parent.items.TryGetValue(atr.listeningTo, out ConfigItem listeningTo))
                    continue;
                if (!hiders.ContainsKey(atr.priority))
                    hiders[atr.priority] = new();
                parent.OnConfigChanged += (item, val) =>
                {
                    _ = atr.IsSatisfied(val) ? hiders[atr.priority].Add(item) : hiders[atr.priority].Remove(item);
                    UpdateVisibility();
                };
            }
            foreach (var atr in _showIf)
            {
                if (atr.listeningTo == fieldName || !parent.items.TryGetValue(atr.listeningTo, out ConfigItem listeningTo))
                    continue;
                if (!showers.ContainsKey(atr.priority)) 
                    showers[atr.priority] = new();
                parent.OnConfigChanged += (item, val) =>
                {
                    _ = atr.IsSatisfied(val) ? showers[atr.priority].Add(item) : showers[atr.priority].Remove(item);
                    UpdateVisibility();
                };
            }
        }



        public void UpdateVisibility(bool force = false, bool forceVisible = true)
        {
            if (force)
            {
                visible = forceVisible;
                button.gameObject.SetActive(visible);
                return;
            }
            /// Values.Any(Enumerable.Any) is true if exists any nonempty HashSet
            var showPriority = showers.Values.Any(Enumerable.Any) ? showers.Where(kvp => kvp.Value.Any()).Max(kvp => kvp.Key) : int.MinValue;
            var hidePriority = hiders.Values.Any(Enumerable.Any) ? hiders.Where(kvp => kvp.Value.Any()).Max(kvp => kvp.Key) : int.MinValue;
            button.SetActive(showPriority >= hidePriority);
        }


    }



}
