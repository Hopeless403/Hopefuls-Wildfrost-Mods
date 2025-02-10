// Decompiled with JetBrains decompiler
// Type: HUDCanvas
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;

#nullable disable
[RequireComponent(typeof (CanvasGroup))]
public class HUDCanvas : MonoBehaviour
{
  private CanvasGroup _canvasGroup;

  private CanvasGroup canvasGroup
  {
    get => this._canvasGroup ?? (this._canvasGroup = this.GetComponent<CanvasGroup>());
  }

  private void Awake()
  {
    this.canvasGroup.alpha = Settings.Load<float>("HudAlpha", 1f);
    global::Events.OnSettingChanged += new UnityAction<string, object>(this.SettingChanged);
  }

  private void OnDestroy()
  {
    global::Events.OnSettingChanged -= new UnityAction<string, object>(this.SettingChanged);
  }

  private void SettingChanged(string key, object value)
  {
    if (!(key == "HudAlpha") || !(value is float num))
      return;
    this.canvasGroup.alpha = num;
  }
}
