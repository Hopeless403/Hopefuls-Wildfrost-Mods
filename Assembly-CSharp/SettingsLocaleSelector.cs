// Decompiled with JetBrains decompiler
// Type: SettingsLocaleSelector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

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
