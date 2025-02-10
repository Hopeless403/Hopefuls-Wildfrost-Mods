// Decompiled with JetBrains decompiler
// Type: StatNumberDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using TMPro;
using UnityEngine;

#nullable disable
public class StatNumberDisplay : MonoBehaviour
{
  [SerializeField]
  public bool disableIfZero = true;
  [SerializeField]
  public string statName = "damageDealt";
  [SerializeField]
  public string statKey = "basic";
  [SerializeField]
  public TMP_Text text;

  public void OnEnable()
  {
    int num = OverallStatsSystem.Get().Get(this.statName, this.statKey, 0);
    if (this.disableIfZero && num <= 0)
      this.gameObject.SetActive(false);
    else
      this.text.text = num.ToString();
  }
}
