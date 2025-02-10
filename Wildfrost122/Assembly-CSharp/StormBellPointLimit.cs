// Decompiled with JetBrains decompiler
// Type: StormBellPointLimit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using TMPro;
using UnityEngine;

#nullable disable
public class StormBellPointLimit : MonoBehaviour
{
  [SerializeField]
  private bool setOnAwake = true;
  [SerializeField]
  private TMP_Text text;
  private int _pointLimit;

  public int pointLimit
  {
    get => this._pointLimit;
    set
    {
      this._pointLimit = value;
      this.text.text = value.ToString();
    }
  }

  private void Awake()
  {
    if (!this.setOnAwake)
      return;
    this.pointLimit = Mathf.Min(SaveSystem.LoadProgressData<int>("maxStormPoints", 5), 10);
  }
}
