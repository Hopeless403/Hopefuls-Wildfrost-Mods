// Decompiled with JetBrains decompiler
// Type: SetLanguage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

#nullable disable
public class SetLanguage : MonoBehaviour
{
  [SerializeField]
  private TMP_Dropdown dropdown;
  [SerializeField]
  private Setting<int> setting;
  private bool init;

  private IEnumerator Start()
  {
    yield return (object) LocalizationSettings.InitializationOperation;
    this.dropdown.options = LocalizationSettings.AvailableLocales.Locales.Select<Locale, TMP_Dropdown.OptionData>((Func<Locale, TMP_Dropdown.OptionData>) (locale => new TMP_Dropdown.OptionData(locale.name))).ToList<TMP_Dropdown.OptionData>();
    this.init = true;
    this.OnEnable();
  }

  private void OnEnable()
  {
    if (!this.init || !((UnityEngine.Object) this.setting != (UnityEngine.Object) null))
      return;
    this.setting.SetValue(LocalizationSettings.AvailableLocales.Locales.IndexOf(LocalizationSettings.SelectedLocale));
  }

  public void Set(int value)
  {
    global::Settings.Save<string>("Language", LocalizationSettings.AvailableLocales.Locales[value].Identifier.Code);
    LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[value];
  }
}
