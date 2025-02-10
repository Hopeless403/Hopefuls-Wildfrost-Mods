// Decompiled with JetBrains decompiler
// Type: LocaleListener
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

public class LocaleListener : MonoBehaviour
{
  [SerializeField]
  public UnityEvent<Locale> OnLocaleChanged;

  public void OnEnable() => LocalizationSettings.Instance.OnSelectedLocaleChanged += new Action<Locale>(this.LocaleChanged);

  public void OnDisable() => LocalizationSettings.Instance.OnSelectedLocaleChanged -= new Action<Locale>(this.LocaleChanged);

  public void LocaleChanged(Locale locale) => this.OnLocaleChanged?.Invoke(locale);
}
