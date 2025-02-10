// Decompiled with JetBrains decompiler
// Type: StopWatch
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public static class StopWatch
{
  private static float? startTime;
  private static float? stopTime;

  public static int Milliseconds => StopWatch.GetMilliseconds();

  public static float Seconds => (float) StopWatch.Milliseconds / 1000f;

  public static float StopTime => StopWatch.stopTime ?? Time.realtimeSinceStartup;

  public static void Start()
  {
    StopWatch.startTime = new float?(Time.realtimeSinceStartup);
    StopWatch.stopTime = new float?();
  }

  public static int Stop()
  {
    StopWatch.stopTime = new float?(Time.realtimeSinceStartup);
    return StopWatch.Milliseconds;
  }

  private static int GetMilliseconds() => StopWatch.startTime.HasValue ? Mathf.RoundToInt((float) (((double) StopWatch.StopTime - (double) StopWatch.startTime.Value) * 1000.0)) : 0;
}
