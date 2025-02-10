// Decompiled with JetBrains decompiler
// Type: DailyFetcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Runtime.CompilerServices;

#nullable disable
public static class DailyFetcher
{
  public static int DayOffset;
  [CompilerGenerated]
  public static bool \u003Cfetched\u003Ek__BackingField;
  public static DateTime dateTime;

  public static bool fetched
  {
    get => DailyFetcher.\u003Cfetched\u003Ek__BackingField;
    set => DailyFetcher.\u003Cfetched\u003Ek__BackingField = value;
  }

  public static IEnumerator FetchDateTime()
  {
    DailyFetcher.dateTime = DateTime.Now.AddDays((double) DailyFetcher.DayOffset);
    DailyFetcher.fetched = true;
    yield break;
  }

  public static void CancelFetch() => DailyFetcher.fetched = false;

  public static void SetContinueDateTime()
  {
    DailyFetcher.dateTime = DateTime.ParseExact(SaveSystem.LoadCampaignData<string>(Campaign.Data.GameMode, "startDate", ""), "dd/MM/yyyy", (IFormatProvider) GameManager.CultureInfo);
  }

  public static DateTime GetDateTime() => DailyFetcher.dateTime;

  public static DateTime GetNextDateTime() => DailyFetcher.dateTime.Date.AddDays(1.0);

  public static int GetSeed()
  {
    DateTime dateTime = DailyFetcher.GetDateTime();
    int result;
    int.TryParse(string.Format("{0:yyMMdd}{1:D3}", (object) dateTime, (object) dateTime.DayOfYear), out result);
    return result;
  }

  public static string GetDate() => DailyFetcher.GetDateTime().ToString("dd/MM/yyyy");

  public static string GetLeaderboardName()
  {
    return DailyFetcher.GetLeaderboardName(DailyFetcher.GetDateTime());
  }

  public static string GetLeaderboardName(DateTime dateTime)
  {
    return DailyFetcher.GetLeaderboardName(dateTime.ToString("dd/MM/yyyy"));
  }

  public static string GetLeaderboardName(string dateString) => "Daily-" + dateString;

  public static bool CanPlay()
  {
    string str = SaveSystem.LoadProgressData<string>("dailyPlayed", (string) null);
    DateTime result;
    return str.IsNullOrWhitespace() || !DateTime.TryParse(str, out result) || !DailyFetcher.SameDay(DailyFetcher.GetDateTime(), result);
  }

  public static bool SameDay(DateTime a, DateTime b)
  {
    return a.Year == b.Year && a.DayOfYear == b.DayOfYear;
  }
}
