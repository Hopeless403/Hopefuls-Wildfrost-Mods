// Decompiled with JetBrains decompiler
// Type: StatNumberDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using TMPro;
using UnityEngine;

#nullable disable
public class StatNumberDisplay : MonoBehaviour
{
  [SerializeField]
  private bool disableIfZero = true;
  [SerializeField]
  private string statName = "damageDealt";
  [SerializeField]
  private string statKey = "basic";
  [SerializeField]
  private TMP_Text text;

  private void OnEnable()
  {
    int num = OverallStatsSystem.Get().Get(this.statName, this.statKey, 0);
    if (this.disableIfZero && num <= 0)
      this.gameObject.SetActive(false);
    else
      this.text.text = num.ToString();
  }
}
