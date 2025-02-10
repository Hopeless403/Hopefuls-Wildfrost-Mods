// Decompiled with JetBrains decompiler
// Type: LocaleListener
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

#nullable disable
public class LocaleListener : MonoBehaviour
{
  [SerializeField]
  private UnityEvent<Locale> OnLocaleChanged;

  private void OnEnable()
  {
    LocalizationSettings.Instance.OnSelectedLocaleChanged += new Action<Locale>(this.LocaleChanged);
  }

  private void OnDisable()
  {
    LocalizationSettings.Instance.OnSelectedLocaleChanged -= new Action<Locale>(this.LocaleChanged);
  }

  private void LocaleChanged(Locale locale) => this.OnLocaleChanged?.Invoke(locale);
}
