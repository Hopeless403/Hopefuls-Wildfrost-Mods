// Decompiled with JetBrains decompiler
// Type: LocalizeActionString
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

public class LocalizeActionString : MonoBehaviour
{
  [SerializeField]
  public LocalizedString mouseString;
  [SerializeField]
  public LocalizedString joystickString;
  [SerializeField]
  public UnityEvent<string> onUpdate;
  [SerializeField]
  public bool preferTextActions;

  public void OnEnable()
  {
    LocalizationSettings.Instance.OnSelectedLocaleChanged += new Action<Locale>(this.LocaleChanged);
    global::Events.OnButtonStyleChanged += new UnityAction(this.ButtonStyleChanged);
    this.UpdateText();
  }

  public void OnDisable()
  {
    LocalizationSettings.Instance.OnSelectedLocaleChanged -= new Action<Locale>(this.LocaleChanged);
    global::Events.OnButtonStyleChanged -= new UnityAction(this.ButtonStyleChanged);
  }

  public void UpdateText() => this.onUpdate?.Invoke(ControllerButtonSystem.ProcessActionTags(MonoBehaviourSingleton<Cursor3d>.instance.usingMouse ? this.mouseString : this.joystickString, this.preferTextActions));

  public void LocaleChanged(Locale locale) => this.UpdateText();

  public void ButtonStyleChanged() => this.UpdateText();
}
