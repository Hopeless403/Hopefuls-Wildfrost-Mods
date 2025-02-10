// Decompiled with JetBrains decompiler
// Type: StormBellPointLimit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using TMPro;
using UnityEngine;

#nullable disable
public class StormBellPointLimit : MonoBehaviour
{
  [SerializeField]
  public bool setOnAwake = true;
  [SerializeField]
  public TMP_Text text;
  public int _pointLimit;

  public int pointLimit
  {
    get => this._pointLimit;
    set
    {
      this._pointLimit = value;
      this.text.text = value.ToString();
    }
  }

  public void Awake()
  {
    if (!this.setOnAwake)
      return;
    this.pointLimit = Mathf.Min(SaveSystem.LoadProgressData<int>("maxStormPoints", 5), 10);
  }
}
