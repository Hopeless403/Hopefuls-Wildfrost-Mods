// Decompiled with JetBrains decompiler
// Type: SetSettingFloat
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

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
