// Decompiled with JetBrains decompiler
// Type: SettingsLocaleSelector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

#nullable disable
[Serializable]
public class SettingsLocaleSelector : IStartupLocaleSelector
{
  [SerializeField]
  public string settingsKey = "Language";

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
