// Decompiled with JetBrains decompiler
// Type: DateTextSetter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.Localization.Settings;

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
