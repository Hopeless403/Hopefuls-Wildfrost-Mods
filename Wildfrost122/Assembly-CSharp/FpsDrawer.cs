// Decompiled with JetBrains decompiler
// Type: FpsDrawer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using TMPro;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class FpsDrawer : MonoBehaviour
{
  public TextMeshProUGUI fpsText;
  [SerializeField]
  private bool @default = true;
  private float deltaTime;

  private void Awake()
  {
    if (!Settings.Load<bool>("ShowFps", this.@default))
      this.gameObject.SetActive(false);
    global::Events.OnSettingChanged += new UnityAction<string, object>(this.SettingChanged);
  }

  private void OnDestroy()
  {
    global::Events.OnSettingChanged -= new UnityAction<string, object>(this.SettingChanged);
  }

  private void SettingChanged(string key, object value)
  {
    if (!(key == "ShowFps") || !(value is bool flag))
      return;
    this.gameObject.SetActive(flag);
  }

  private void Update()
  {
    this.deltaTime += (float) (((double) Time.unscaledDeltaTime - (double) this.deltaTime) * 0.10000000149011612);
    this.fpsText.text = string.Format("{0}\n{1}", (object) Mathf.Ceil(1f / this.deltaTime), (object) Random.seed);
  }
}
