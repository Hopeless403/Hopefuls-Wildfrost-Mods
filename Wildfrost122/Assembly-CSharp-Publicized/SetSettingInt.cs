// Decompiled with JetBrains decompiler
// Type: SetSettingInt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
public class SetSettingInt : MonoBehaviour
{
  [SerializeField]
  public Setting<int> setting;
  [SerializeField]
  public string key = "Language";
  [SerializeField]
  public int defaultValue;

  public string Key => this.key;

  public void OnEnable()
  {
    if (!((Object) this.setting != (Object) null))
      return;
    this.setting.SetValue(Settings.Load<int>(this.key, this.defaultValue));
  }

  public void Set(int value) => Settings.Save<int>(this.key, value);
}
