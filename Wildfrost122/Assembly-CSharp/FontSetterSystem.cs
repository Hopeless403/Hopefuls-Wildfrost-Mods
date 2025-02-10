// Decompiled with JetBrains decompiler
// Type: FontSetterSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

#nullable disable
public class FontSetterSystem : GameSystem
{
  [SerializeField]
  private AssetReferenceT<TMP_FontAsset> defaultFontRef;
  [SerializeField]
  private FontSetterSystem.LocaleFont[] localeFonts;
  private static AssetReferenceT<TMP_FontAsset> defaultRef;
  private static AssetReferenceT<TMP_FontAsset> currentRef;
  private static TMP_FontAsset current;
  private static Dictionary<string, AssetReferenceT<TMP_FontAsset>> lookup;
  private static readonly List<FontSetter> fontSetters = new List<FontSetter>();

  private void Awake()
  {
    FontSetterSystem.lookup = new Dictionary<string, AssetReferenceT<TMP_FontAsset>>();
    foreach (FontSetterSystem.LocaleFont localeFont in this.localeFonts)
      FontSetterSystem.lookup[localeFont.localeCode] = localeFont.fontRef;
    FontSetterSystem.defaultRef = this.defaultFontRef;
    FontSetterSystem.LocaleChanged(LocalizationSettings.SelectedLocale);
  }

  private void OnEnable()
  {
    LocalizationSettings.Instance.OnSelectedLocaleChanged += new Action<Locale>(FontSetterSystem.LocaleChanged);
  }

  private void OnDisable()
  {
    LocalizationSettings.Instance.OnSelectedLocaleChanged -= new Action<Locale>(FontSetterSystem.LocaleChanged);
  }

  public static void Register(FontSetter fontSetter)
  {
    FontSetterSystem.fontSetters.Add(fontSetter);
    if (!((UnityEngine.Object) FontSetterSystem.current != (UnityEngine.Object) null))
      return;
    fontSetter.SetFont(FontSetterSystem.current);
  }

  public static void Unregister(FontSetter fontSetter)
  {
    FontSetterSystem.fontSetters.Remove(fontSetter);
  }

  private static void LocaleChanged(Locale locale)
  {
    if ((UnityEngine.Object) FontSetterSystem.current != (UnityEngine.Object) null)
      FontSetterSystem.currentRef.ReleaseAsset();
    FontSetterSystem.currentRef = FontSetterSystem.lookup.ContainsKey(locale.Identifier.Code) ? FontSetterSystem.lookup[locale.Identifier.Code] : FontSetterSystem.defaultRef;
    FontSetterSystem.current = FontSetterSystem.currentRef.LoadAssetAsync().WaitForCompletion();
    FontSetterSystem.UpdateFontSetters();
  }

  private static void UpdateFontSetters()
  {
    foreach (FontSetter fontSetter in FontSetterSystem.fontSetters)
      fontSetter.SetFont(FontSetterSystem.current);
  }

  [Serializable]
  private struct LocaleFont
  {
    public string localeCode;
    public AssetReferenceT<TMP_FontAsset> fontRef;
  }
}
