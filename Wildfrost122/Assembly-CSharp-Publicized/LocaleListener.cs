// Decompiled with JetBrains decompiler
// Type: LocaleListener
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

#nullable disable
public class LocaleListener : MonoBehaviour
{
  [SerializeField]
  public UnityEvent<Locale> OnLocaleChanged;

  public void OnEnable()
  {
    LocalizationSettings.Instance.OnSelectedLocaleChanged += new Action<Locale>(this.LocaleChanged);
  }

  public void OnDisable()
  {
    LocalizationSettings.Instance.OnSelectedLocaleChanged -= new Action<Locale>(this.LocaleChanged);
  }

  public void LocaleChanged(Locale locale) => this.OnLocaleChanged?.Invoke(locale);
}
