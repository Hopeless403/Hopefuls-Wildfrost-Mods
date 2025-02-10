// Decompiled with JetBrains decompiler
// Type: LTBezier
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
public class LTBezier
{
  public float length;
  public Vector3 a;
  public Vector3 aa;
  public Vector3 bb;
  public Vector3 cc;
  public float len;
  public float[] arcLengths;

  public LTBezier(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float precision)
  {
    this.a = a;
    this.aa = -a + 3f * (b - c) + d;
    this.bb = 3f * (a + c) - 6f * b;
    this.cc = 3f * (b - a);
    this.len = 1f / precision;
    this.arcLengths = new float[(int) this.len + 1];
    this.arcLengths[0] = 0.0f;
    Vector3 vector3_1 = a;
    float num = 0.0f;
    for (int index = 1; (double) index <= (double) this.len; ++index)
    {
      Vector3 vector3_2 = this.bezierPoint((float) index * precision);
      num += (vector3_1 - vector3_2).magnitude;
      this.arcLengths[index] = num;
      vector3_1 = vector3_2;
    }
    this.length = num;
  }

  public float map(float u)
  {
    float num1 = u * this.arcLengths[(int) this.len];
    int num2 = 0;
    int num3 = (int) this.len;
    int index = 0;
    while (num2 < num3)
    {
      index = num2 + ((int) ((double) (num3 - num2) / 2.0) | 0);
      if ((double) this.arcLengths[index] < (double) num1)
        num2 = index + 1;
      else
        num3 = index;
    }
    if ((double) this.arcLengths[index] > (double) num1)
      --index;
    if (index < 0)
      index = 0;
    return ((float) index + (float) (((double) num1 - (double) this.arcLengths[index]) / ((double) this.arcLengths[index + 1] - (double) this.arcLengths[index]))) / this.len;
  }

  public Vector3 bezierPoint(float t) => ((this.aa * t + this.bb) * t + this.cc) * t + this.a;

  public Vector3 point(float t) => this.bezierPoint(this.map(t));
}
