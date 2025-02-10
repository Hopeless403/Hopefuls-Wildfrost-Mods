// Decompiled with JetBrains decompiler
// Type: SetVolume
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
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
