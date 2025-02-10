// Decompiled with JetBrains decompiler
// Type: LocalizeActionString
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

#nullable disable
public class LocalizeActionString : MonoBehaviour
{
  [SerializeField]
  private LocalizedString mouseString;
  [SerializeField]
  private LocalizedString joystickString;
  [SerializeField]
  private UnityEvent<string> onUpdate;
  [SerializeField]
  private bool preferTextActions;

  private void OnEnable()
  {
    LocalizationSettings.Instance.OnSelectedLocaleChanged += new Action<Locale>(this.LocaleChanged);
    global::Events.OnButtonStyleChanged += new UnityAction(this.ButtonStyleChanged);
    this.UpdateText();
  }

  private void OnDisable()
  {
    LocalizationSettings.Instance.OnSelectedLocaleChanged -= new Action<Locale>(this.LocaleChanged);
    global::Events.OnButtonStyleChanged -= new UnityAction(this.ButtonStyleChanged);
  }

  private void UpdateText()
  {
    this.onUpdate?.Invoke(ControllerButtonSystem.ProcessActionTags(MonoBehaviourSingleton<Cursor3d>.instance.usingMouse ? this.mouseString : this.joystickString, this.preferTextActions));
  }

  private void LocaleChanged(Locale locale) => this.UpdateText();

  private void ButtonStyleChanged() => this.UpdateText();
}
