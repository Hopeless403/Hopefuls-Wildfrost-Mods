// Decompiled with JetBrains decompiler
// Type: FpsDrawer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class FpsDrawer : MonoBehaviour
{
  public TextMeshProUGUI fpsText;
  [SerializeField]
  public bool @default = true;
  public float deltaTime;

  public void Awake()
  {
    if (!Settings.Load<bool>("ShowFps", this.@default))
      this.gameObject.SetActive(false);
    global::Events.OnSettingChanged += new UnityAction<string, object>(this.SettingChanged);
  }

  public void OnDestroy() => global::Events.OnSettingChanged -= new UnityAction<string, object>(this.SettingChanged);

  public void SettingChanged(string key, object value)
  {
    if (!(key == "ShowFps") || !(value is bool flag))
      return;
    this.gameObject.SetActive(flag);
  }

  public void Update()
  {
    this.deltaTime += (float) (((double) Time.unscaledDeltaTime - (double) this.deltaTime) * 0.10000000149011612);
    this.fpsText.text = string.Format("{0}\n{1}", (object) Mathf.Ceil(1f / this.deltaTime), (object) Random.seed);
  }
}
