// Decompiled with JetBrains decompiler
// Type: SetSettingFloat
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
public class SetSettingFloat : MonoBehaviour
{
  [SerializeField]
  private Setting<float> setting;
  [SerializeField]
  private string key = "ScreenShake";
  [SerializeField]
  private float defaultValue = 1f;

  private void OnEnable()
  {
    if (!((Object) this.setting != (Object) null))
      return;
    this.setting.SetValue(Settings.Load<float>(this.key, this.defaultValue));
  }

  public void Set(float value) => Settings.Save<float>(this.key, value);
}
