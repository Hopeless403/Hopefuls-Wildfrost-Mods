// Decompiled with JetBrains decompiler
// Type: SetVolume
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

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
