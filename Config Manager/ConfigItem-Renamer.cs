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

namespace WildfrostHopeMod.Configs
{
    public partial class ConfigItem
    {

        void CreateRenameButton(GameObject button)
        {
            var input = ConfigManager.renameButton.InstantiateKeepName();
            input.transform.SetParent(button.transform.FindRecursive("Dropdown") ?? button.transform.FindRecursive("Slider"));
            input.transform.localPosition = new Vector3(-0.8f, -0.2f);
            input.GetComponentInChildren<Button>().onClick.AddListener(StartRename);
            input.SetActive(true);
        }
        void StartRename() => CoroutineManager.Start(RenameButtonStuff(button, button.transform.parent));
        IEnumerator RenameButtonStuff(GameObject button, Transform parent)
        {
            if (parent.name == "CardHolder") yield break;
            Type fieldType = con.field.FieldType;
            ConfigManager.renameSeq.transform.Find("Rename/InputField (TMP)/Text Area/Placeholder").GetComponent<TextMeshProUGUI>().text = fieldType.ToString();
            var inputField = ConfigManager.renameSeq.transform.Find("Rename/InputField (TMP)").GetComponent<TMP_InputField>();
            inputField.text = currentValue.ToString();

            promptEndInput = false;
            int index = button.transform.GetSiblingIndex();
            var originalPosition = button.transform.localPosition;
            button.transform.SetParent(ConfigManager.renameSeq.transform.Find("CardHolder"), true);
            modScrollView.gameObject.SetActive(false);
            button.transform.localPosition = Vector3.zero;

            ConfigManager.renameSeq.SetActive(true);
            yield return null;
            inputField.MoveTextEnd(false);

            while (!promptEndInput) yield return null;
            promptEndInput = false;

            string result = ConfigManager.renameSeq.GetComponentInChildren<TMP_InputField>().text;
            if (promptRename && !result.IsNullOrWhitespace())
            {
                SettingOptions options = button.GetComponent<SettingOptions>();
                SettingSlider settingSlider = button.GetComponent<SettingSlider>();
                if (options)
                {
                    var i = options.dropdown.options.Select(o => o.text.ToLowerInvariant()).ToList().IndexOf(result.ToLowerInvariant());
                    Debug.Log("[Config Manager] Using option " + i);
                    //options.onValueChanged.Invoke(Mathf.Max(i,0));
                    options.SetValue(Mathf.Max(i, 0));
                }
                else if (settingSlider)
                {
                    ConfigSliderAttribute csa = (ConfigSliderAttribute)Attribute.GetCustomAttribute(con.field, typeof(ConfigSliderAttribute));
                    var diff = csa.range.y - csa.range.x;
                    float configValue = (float)TypeDescriptor.GetConverter(typeof(float)).ConvertFromInvariantString(result);
                    var val = (configValue - csa.range.x) / diff;
                    settingSlider.SetValue(val);
                }
                else if (fieldType.IsEnum)
                {
                    var configValue = Enum.Parse(fieldType, result);
                    button.transform.FindRecursive("Label").GetComponentInChildren<TextMeshProUGUI>().text = configValue.ToString();
                    ConfigManager.SaveConfig(con, configValue);
                }
                else if (TypeDescriptor.GetConverter(con.field.FieldType).IsValid(result))
                {
                    var configValue = TypeDescriptor.GetConverter(con.field.FieldType).ConvertFromInvariantString(result);
                    button.transform.FindRecursive("Label").GetComponentInChildren<TextMeshProUGUI>().text = configValue.ToString();
                    ConfigManager.SaveConfig(con, configValue);
                }
                else Debug.LogError($"[Config Manager] Wrong type provided. Expected Type: {con.field.FieldType}");
            }

            promptRename = false;
            ConfigManager.renameSeq.GetComponentInChildren<TMP_InputField>().text = "";
            button.transform.SetParent(parent, true);
            button.transform.SetSiblingIndex(index);
            button.transform.localPosition = originalPosition;
            modScrollView.gameObject.SetActive(true);
            ConfigManager.renameSeq.SetActive(false);
        }

    }
}
