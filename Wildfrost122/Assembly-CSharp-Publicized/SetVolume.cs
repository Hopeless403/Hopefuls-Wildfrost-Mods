// Decompiled with JetBrains decompiler
// Type: SetVolume
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
public class SetVolume : MonoBehaviour
{
  [SerializeField]
  public string busName = "Master";
  [SerializeField]
  public Setting<float> setting;

  public void OnEnable()
  {
    if (!((Object) this.setting != (Object) null))
      return;
    this.setting.SetValue(AudioSettingsSystem.GetVolume(this.busName));
  }

  public void Set(float value) => AudioSettingsSystem.Volume(this.busName, value);
}
