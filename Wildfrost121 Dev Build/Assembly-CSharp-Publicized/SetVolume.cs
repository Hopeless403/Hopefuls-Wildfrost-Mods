// Decompiled with JetBrains decompiler
// Type: SetVolume
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
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
