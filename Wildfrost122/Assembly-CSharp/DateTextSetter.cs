// Decompiled with JetBrains decompiler
// Type: DateTextSetter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.Localization.Settings;

#nullable disable
public class DateTextSetter : MonoBehaviour
{
  [SerializeField]
  private TMP_Text textElement;

  private void OnEnable() => this.SetText(0);

  public void SetText(int dayOffset)
  {
    CultureInfo cultureInfo = LocalizationSettings.SelectedLocale.Identifier.CultureInfo;
    this.textElement.text = DailyFetcher.GetDateTime().AddDays((double) dayOffset).ToString("D", (IFormatProvider) cultureInfo);
  }
}
