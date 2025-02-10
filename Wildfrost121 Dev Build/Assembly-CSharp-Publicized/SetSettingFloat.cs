// Decompiled with JetBrains decompiler
// Type: SetSettingFloat
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
public class SetSettingFloat : MonoBehaviour
{
  [SerializeField]
  public Setting<float> setting;
  [SerializeField]
  public string key = "ScreenShake";
  [SerializeField]
  public float defaultValue = 1f;

  public void OnEnable()
  {
    if (!((Object) this.setting != (Object) null))
      return;
    this.setting.SetValue(Settings.Load<float>(this.key, this.defaultValue));
  }

  public void Set(float value) => Settings.Save<float>(this.key, value);
}
