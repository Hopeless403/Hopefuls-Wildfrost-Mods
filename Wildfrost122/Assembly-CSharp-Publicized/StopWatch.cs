// Decompiled with JetBrains decompiler
// Type: StopWatch
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
public static class StopWatch
{
  public static float? startTime;
  public static float? stopTime;

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

  public static int GetMilliseconds()
  {
    return StopWatch.startTime.HasValue ? Mathf.RoundToInt((float) (((double) StopWatch.StopTime - (double) StopWatch.startTime.Value) * 1000.0)) : 0;
  }
}
