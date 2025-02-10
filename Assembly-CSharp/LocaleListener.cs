// Decompiled with JetBrains decompiler
// Type: LocaleListener
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

public class LocaleListener : MonoBehaviour
{
  [SerializeField]
  private UnityEvent<Locale> OnLocaleChanged;

  private void OnEnable() => LocalizationSettings.Instance.OnSelectedLocaleChanged += new Action<Locale>(this.LocaleChanged);

  private void OnDisable() => LocalizationSettings.Instance.OnSelectedLocaleChanged -= new Action<Locale>(this.LocaleChanged);

  private void LocaleChanged(Locale locale) => this.OnLocaleChanged?.Invoke(locale);
}
