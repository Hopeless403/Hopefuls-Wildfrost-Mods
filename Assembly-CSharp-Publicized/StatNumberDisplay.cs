// Decompiled with JetBrains decompiler
// Type: StatNumberDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using TMPro;
using UnityEngine;

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
