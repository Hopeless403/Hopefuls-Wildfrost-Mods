// Decompiled with JetBrains decompiler
// Type: SetLanguage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

public class SetLanguage : MonoBehaviour
{
  [SerializeField]
  public TMP_Dropdown dropdown;
  [SerializeField]
  public Setting<int> setting;
  public bool init;

  public IEnumerator Start()
  {
    yield return (object) LocalizationSettings.InitializationOperation;
    this.dropdown.options = LocalizationSettings.AvailableLocales.Locales.Select<Locale, TMP_Dropdown.OptionData>((Func<Locale, TMP_Dropdown.OptionData>) (locale => new TMP_Dropdown.OptionData(locale.name))).ToList<TMP_Dropdown.OptionData>();
    this.init = true;
    this.OnEnable();
  }

  public void OnEnable()
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
