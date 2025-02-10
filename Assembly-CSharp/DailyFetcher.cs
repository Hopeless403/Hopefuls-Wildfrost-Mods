// Decompiled with JetBrains decompiler
// Type: DailyFetcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;

public static class DailyFetcher
{
  internal static int DayOffset;
  private static DateTime dateTime;

  public static bool fetched { get; private set; }

  public static IEnumerator FetchDateTime()
  {
    DailyFetcher.dateTime = DateTime.Now.AddDays((double) DailyFetcher.DayOffset);
    DailyFetcher.fetched = true;
    yield break;
  }

  public static void CancelFetch() => DailyFetcher.fetched = false;

  public static void SetContinueDateTime() => DailyFetcher.dateTime = DateTime.ParseExact(SaveSystem.LoadCampaignData<string>(Campaign.Data.GameMode, "startDate", ""), "dd/MM/yyyy", (IFormatProvider) GameManager.CultureInfo);

  public static DateTime GetDateTime() => DailyFetcher.dateTime;

  internal static DateTime GetNextDateTime() => DailyFetcher.dateTime.Date.AddDays(1.0);

  public static int GetSeed()
  {
    DateTime dateTime = DailyFetcher.GetDateTime();
    int result;
    int.TryParse(string.Format("{0:yyMMdd}{1:D3}", (object) dateTime, (object) dateTime.DayOfYear), out result);
    return result;
  }

  public static string GetDate() => DailyFetcher.GetDateTime().ToString("dd/MM/yyyy");

  public static string GetLeaderboardName() => DailyFetcher.GetLeaderboardName(DailyFetcher.GetDateTime());

  public static string GetLeaderboardName(DateTime dateTime) => DailyFetcher.GetLeaderboardName(dateTime.ToString("dd/MM/yyyy"));

  public static string GetLeaderboardName(string dateString) => "Daily-" + dateString;

  public static bool CanPlay()
  {
    string str = SaveSystem.LoadProgressData<string>("dailyPlayed", (string) null);
    DateTime result;
    return str.IsNullOrWhitespace() || !DateTime.TryParse(str, out result) || !DailyFetcher.SameDay(DailyFetcher.GetDateTime(), result);
  }

  private static bool SameDay(DateTime a, DateTime b) => a.Year == b.Year && a.DayOfYear == b.DayOfYear;
}
