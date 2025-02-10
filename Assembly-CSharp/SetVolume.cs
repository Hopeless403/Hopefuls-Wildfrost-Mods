// Decompiled with JetBrains decompiler
// Type: SetVolume
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public class SetVolume : MonoBehaviour
{
  [SerializeField]
  private string busName = "Master";
  [SerializeField]
  private Setting<float> setting;

  private void OnEnable()
  {
    if (!((Object) this.setting != (Object) null))
      return;
    this.setting.SetValue(AudioSettingsSystem.GetVolume(this.busName));
  }

  public void Set(float value) => AudioSettingsSystem.Volume(this.busName, value);
}
