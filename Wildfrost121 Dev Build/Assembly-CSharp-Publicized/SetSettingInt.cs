// Decompiled with JetBrains decompiler
// Type: SetSettingInt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
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
