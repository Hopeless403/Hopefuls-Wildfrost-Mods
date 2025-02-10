// Decompiled with JetBrains decompiler
// Type: StatDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using TMPro;
using UnityEngine;
using UnityEngine.Localization.Components;

public class StatDisplay : MonoBehaviour
{
  [SerializeField]
  public TMP_Text textElement;
  [SerializeField]
  public LocalizeStringEvent localizeStringEvent;
  public string statValue;

  public void Assign(GameStatData statData, string stringValue)
  {
    this.statValue = stringValue;
    this.localizeStringEvent.StringReference = statData.stringKey;
  }

  public void SetText(string text) => this.textElement.text = text.Replace("{0}", "<#fff>" + this.statValue);
}
