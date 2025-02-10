// Decompiled with JetBrains decompiler
// Type: SetSettingFloat
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

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
