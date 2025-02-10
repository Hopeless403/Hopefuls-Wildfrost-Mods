// Decompiled with JetBrains decompiler
// Type: DateTextSetter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class DateTextSetter : MonoBehaviour
{
  [SerializeField]
  public TMP_Text textElement;

  public void OnEnable() => this.SetText(0);

  public void SetText(int dayOffset)
  {
    CultureInfo cultureInfo = LocalizationSettings.SelectedLocale.Identifier.CultureInfo;
    this.textElement.text = DailyFetcher.GetDateTime().AddDays((double) dayOffset).ToString("D", (IFormatProvider) cultureInfo);
  }
}
