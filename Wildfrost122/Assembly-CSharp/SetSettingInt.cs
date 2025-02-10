// Decompiled with JetBrains decompiler
// Type: SetSettingInt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
public class SetSettingInt : MonoBehaviour
{
  [SerializeField]
  private Setting<int> setting;
  [SerializeField]
  private string key = "Language";
  [SerializeField]
  private int defaultValue;

  public string Key => this.key;

  private void OnEnable()
  {
    if (!((Object) this.setting != (Object) null))
      return;
    this.setting.SetValue(Settings.Load<int>(this.key, this.defaultValue));
  }

  public void Set(int value) => Settings.Save<int>(this.key, value);
}
