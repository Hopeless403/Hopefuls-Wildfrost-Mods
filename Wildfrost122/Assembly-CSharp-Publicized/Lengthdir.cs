// Decompiled with JetBrains decompiler
// Type: Lengthdir
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
public static class Lengthdir
{
  public static float X(float len, float radians) => Mathf.Cos(radians) * len;

  public static float Y(float len, float radians) => Mathf.Sin(radians) * len;

  public static Vector2 ToVector2(float len, float radians)
  {
    return new Vector2(Lengthdir.X(len, radians), Lengthdir.Y(len, radians));
  }
}
