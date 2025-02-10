// Decompiled with JetBrains decompiler
// Type: RandomInclusive
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
public static class RandomInclusive
{
  public static int Range(int min, int max) => Random.Range(min, max + 1);

  public static float Range(float min, float max) => Random.Range(min, max);
}
