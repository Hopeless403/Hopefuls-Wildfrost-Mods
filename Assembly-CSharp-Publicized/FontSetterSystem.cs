// Decompiled with JetBrains decompiler
// Type: FontSetterSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

public class FontSetterSystem : GameSystem
{
  [SerializeField]
  public AssetReferenceT<TMP_FontAsset> defaultFontRef;
  [SerializeField]
  public FontSetterSystem.LocaleFont[] localeFonts;
  public static AssetReferenceT<TMP_FontAsset> defaultRef;
  public static AssetReferenceT<TMP_FontAsset> currentRef;
  public static TMP_FontAsset current;
  public static Dictionary<string, AssetReferenceT<TMP_FontAsset>> lookup;
  public static readonly List<FontSetter> fontSetters = new List<FontSetter>();

  public void Awake()
  {
    FontSetterSystem.lookup = new Dictionary<string, AssetReferenceT<TMP_FontAsset>>();
    foreach (FontSetterSystem.LocaleFont localeFont in this.localeFonts)
      FontSetterSystem.lookup[localeFont.localeCode] = localeFont.fontRef;
    FontSetterSystem.defaultRef = this.defaultFontRef;
    FontSetterSystem.LocaleChanged(LocalizationSettings.SelectedLocale);
  }

  public void OnEnable() => LocalizationSettings.Instance.OnSelectedLocaleChanged += new Action<Locale>(FontSetterSystem.LocaleChanged);

  public void OnDisable() => LocalizationSettings.Instance.OnSelectedLocaleChanged -= new Action<Locale>(FontSetterSystem.LocaleChanged);

  public static void Register(FontSetter fontSetter)
  {
    FontSetterSystem.fontSetters.Add(fontSetter);
    if (!((UnityEngine.Object) FontSetterSystem.current != (UnityEngine.Object) null))
      return;
    fontSetter.SetFont(FontSetterSystem.current);
  }

  public static void Unregister(FontSetter fontSetter) => FontSetterSystem.fontSetters.Remove(fontSetter);

  public static void LocaleChanged(Locale locale)
  {
    if ((UnityEngine.Object) FontSetterSystem.current != (UnityEngine.Object) null)
      FontSetterSystem.currentRef.ReleaseAsset();
    FontSetterSystem.currentRef = FontSetterSystem.lookup.ContainsKey(locale.Identifier.Code) ? FontSetterSystem.lookup[locale.Identifier.Code] : FontSetterSystem.defaultRef;
    FontSetterSystem.current = FontSetterSystem.currentRef.LoadAssetAsync().WaitForCompletion();
    FontSetterSystem.UpdateFontSetters();
  }

  public static void UpdateFontSetters()
  {
    foreach (FontSetter fontSetter in FontSetterSystem.fontSetters)
      fontSetter.SetFont(FontSetterSystem.current);
  }

  [Serializable]
  public struct LocaleFont
  {
    public string localeCode;
    public AssetReferenceT<TMP_FontAsset> fontRef;
  }
}
