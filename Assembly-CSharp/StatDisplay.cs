// Decompiled with JetBrains decompiler
// Type: StatDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using TMPro;
using UnityEngine;
using UnityEngine.Localization.Components;

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

  public void SetText(string text) => this.textElement.text = text.Replace("{0}", "<#fff>" + this.statValue);
}
