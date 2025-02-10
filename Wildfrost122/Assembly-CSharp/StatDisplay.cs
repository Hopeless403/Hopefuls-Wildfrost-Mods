// Decompiled with JetBrains decompiler
// Type: StatDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using TMPro;
using UnityEngine;
using UnityEngine.Localization.Components;

#nullable disable
public class StatDisplay : MonoBehaviour
{
  [SerializeField]
  private TMP_Text textElement;
  [SerializeField]
  private LocalizeStringEvent localizeStringEvent;
  private string statValue;

  public void Assign(GameStatData statData, string stringValue)
  {
    this.statValue = stringValue;
    this.localizeStringEvent.StringReference = statData.stringKey;
  }

  public void SetText(string text)
  {
    this.textElement.text = text.Replace("{0}", "<#fff>" + this.statValue);
  }
}
