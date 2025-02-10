// Decompiled with JetBrains decompiler
// Type: Lengthdir
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

public static class Lengthdir
{
  public static float X(float len, float radians) => Mathf.Cos(radians) * len;

  public static float Y(float len, float radians) => Mathf.Sin(radians) * len;

  public static Vector2 ToVector2(float len, float radians) => new Vector2(Lengthdir.X(len, radians), Lengthdir.Y(len, radians));
}
