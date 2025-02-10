// Decompiled with JetBrains decompiler
// Type: HUDCanvas
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Events;

#nullable disable
[RequireComponent(typeof (CanvasGroup))]
public class HUDCanvas : MonoBehaviour
{
  public CanvasGroup _canvasGroup;

  public CanvasGroup canvasGroup
  {
    get => this._canvasGroup ?? (this._canvasGroup = this.GetComponent<CanvasGroup>());
  }

  public void Awake()
  {
    this.canvasGroup.alpha = Settings.Load<float>("HudAlpha", 1f);
    global::Events.OnSettingChanged += new UnityAction<string, object>(this.SettingChanged);
  }

  public void OnDestroy()
  {
    global::Events.OnSettingChanged -= new UnityAction<string, object>(this.SettingChanged);
  }

  public void SettingChanged(string key, object value)
  {
    if (!(key == "HudAlpha") || !(value is float num))
      return;
    this.canvasGroup.alpha = num;
  }
}
