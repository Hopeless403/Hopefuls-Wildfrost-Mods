// Decompiled with JetBrains decompiler
// Type: SetSettingInt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

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
