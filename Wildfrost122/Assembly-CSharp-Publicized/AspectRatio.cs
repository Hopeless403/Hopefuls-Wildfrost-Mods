// Decompiled with JetBrains decompiler
// Type: AspectRatio
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using UnityEngine;

#nullable disable
public static class AspectRatio
{
  public static Vector2 GetAspectRatio(int x, int y)
  {
    float num = (float) x / (float) y;
    int y1 = 0;
    do
    {
      ++y1;
    }
    while (Math.Round((double) num * (double) y1, 2) != (double) Mathf.RoundToInt(num * (float) y1));
    return new Vector2((float) Math.Round((double) num * (double) y1, 2), (float) y1);
  }

  public static Vector2 GetAspectRatio(Vector2 xy)
  {
    float num = xy.x / xy.y;
    int y = 0;
    do
    {
      ++y;
    }
    while (Math.Round((double) num * (double) y, 2) != (double) Mathf.RoundToInt(num * (float) y));
    return new Vector2((float) Math.Round((double) num * (double) y, 2), (float) y);
  }

  public static Vector2 GetAspectRatio(int x, int y, bool debug)
  {
    float num = (float) x / (float) y;
    int y1 = 0;
    do
    {
      ++y1;
    }
    while (Math.Round((double) num * (double) y1, 2) != (double) Mathf.RoundToInt(num * (float) y1));
    if (debug)
      Debug.Log((object) ("Aspect ratio is " + (num * (float) y1).ToString() + ":" + y1.ToString() + " (Resolution: " + x.ToString() + nameof (x) + y.ToString() + ")"));
    return new Vector2((float) Math.Round((double) num * (double) y1, 2), (float) y1);
  }

  public static Vector2 GetAspectRatio(Vector2 xy, bool debug)
  {
    float num = xy.x / xy.y;
    int y = 0;
    do
    {
      ++y;
    }
    while (Math.Round((double) num * (double) y, 2) != (double) Mathf.RoundToInt(num * (float) y));
    if (debug)
      Debug.Log((object) ("Aspect ratio is " + (num * (float) y).ToString() + ":" + y.ToString() + " (Resolution: " + xy.x.ToString() + "x" + xy.y.ToString() + ")"));
    return new Vector2((float) Math.Round((double) num * (double) y, 2), (float) y);
  }
}
