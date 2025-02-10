// Decompiled with JetBrains decompiler
// Type: SettingsLocaleSelector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

#nullable disable
[Serializable]
public class SettingsLocaleSelector : IStartupLocaleSelector
{
  [SerializeField]
  private string settingsKey = "Language";

  public Locale GetStartupLocale(ILocalesProvider availableLocales)
  {
    if (global::Settings.Exists(this.settingsKey))
    {
      string str = global::Settings.Load<string>(this.settingsKey, "");
      if (!str.IsNullOrWhitespace())
        return availableLocales.GetLocale((LocaleIdentifier) str);
    }
    return (Locale) null;
  }
}
