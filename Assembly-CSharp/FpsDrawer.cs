// Decompiled with JetBrains decompiler
// Type: FpsDrawer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using TMPro;
using UnityEngine;
using UnityEngine.Events;

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

  private void OnDestroy() => global::Events.OnSettingChanged -= new UnityAction<string, object>(this.SettingChanged);

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
