// Decompiled with JetBrains decompiler
// Type: SetSettingInt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

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
