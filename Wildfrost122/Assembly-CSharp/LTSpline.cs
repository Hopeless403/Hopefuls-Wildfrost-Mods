// Decompiled with JetBrains decompiler
// Type: LTSpline
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Serializable]
public class LTSpline
{
  public static int DISTANCE_COUNT = 3;
  public static int SUBLINE_COUNT = 20;
  public float distance;
  public bool constantSpeed = true;
  public Vector3[] pts;
  [NonSerialized]
  public Vector3[] ptsAdj;
  public int ptsAdjLength;
  public bool orientToPath;
  public bool orientToPath2d;
  private int numSections;
  private int currPt;

  public LTSpline(Vector3[] pts) => this.init(pts, true);

  public LTSpline(Vector3[] pts, bool constantSpeed)
  {
    this.constantSpeed = constantSpeed;
    this.init(pts, constantSpeed);
  }

  private void init(Vector3[] pts, bool constantSpeed)
  {
    if (pts.Length < 4)
    {
      LeanTween.logError("LeanTween - When passing values for a spline path, you must pass four or more values!");
    }
    else
    {
      this.pts = new Vector3[pts.Length];
      Array.Copy((Array) pts, (Array) this.pts, pts.Length);
      this.numSections = pts.Length - 3;
      float num1 = float.PositiveInfinity;
      Vector3 pt = this.pts[1];
      float num2 = 0.0f;
      for (int index = 1; index < this.pts.Length - 1; ++index)
      {
        float num3 = Vector3.Distance(this.pts[index], pt);
        if ((double) num3 < (double) num1)
          num1 = num3;
        num2 += num3;
      }
      if (!constantSpeed)
        return;
      float num4 = num2 / (float) (this.numSections * LTSpline.SUBLINE_COUNT) / (float) LTSpline.SUBLINE_COUNT;
      int length = (int) Mathf.Ceil(num2 / num4) * LTSpline.DISTANCE_COUNT;
      if (length <= 1)
        length = 2;
      this.ptsAdj = new Vector3[length];
      Vector3 b = this.interp(0.0f);
      int index1 = 1;
      this.ptsAdj[0] = b;
      this.distance = 0.0f;
      for (int index2 = 0; index2 < length + 1; ++index2)
      {
        float t = (float) index2 / (float) length;
        Vector3 a = this.interp(t);
        float num5 = Vector3.Distance(a, b);
        if ((double) num5 >= (double) num4 || (double) t >= 1.0)
        {
          this.ptsAdj[index1] = a;
          this.distance += num5;
          b = a;
          ++index1;
        }
      }
      this.ptsAdjLength = index1;
    }
  }

  public Vector3 map(float u)
  {
    if ((double) u >= 1.0)
      return this.pts[this.pts.Length - 2];
    double f = (double) u * (double) (this.ptsAdjLength - 1);
    int index1 = (int) Mathf.Floor((float) f);
    int index2 = (int) Mathf.Ceil((float) f);
    if (index1 < 0)
      index1 = 0;
    Vector3 vector3_1 = this.ptsAdj[index1];
    Vector3 vector3_2 = this.ptsAdj[index2];
    float num = (float) f - (float) index1;
    return vector3_1 + (vector3_2 - vector3_1) * num;
  }

  public Vector3 interp(float t)
  {
    this.currPt = Mathf.Min(Mathf.FloorToInt(t * (float) this.numSections), this.numSections - 1);
    float num = t * (float) this.numSections - (float) this.currPt;
    Vector3 pt1 = this.pts[this.currPt];
    Vector3 pt2 = this.pts[this.currPt + 1];
    Vector3 pt3 = this.pts[this.currPt + 2];
    Vector3 pt4 = this.pts[this.currPt + 3];
    return 0.5f * ((-pt1 + 3f * pt2 - 3f * pt3 + pt4) * (num * num * num) + (2f * pt1 - 5f * pt2 + 4f * pt3 - pt4) * (num * num) + (-pt1 + pt3) * num + 2f * pt2);
  }

  public float ratioAtPoint(Vector3 pt)
  {
    float num1 = float.MaxValue;
    int num2 = 0;
    for (int index = 0; index < this.ptsAdjLength; ++index)
    {
      float num3 = Vector3.Distance(pt, this.ptsAdj[index]);
      if ((double) num3 < (double) num1)
      {
        num1 = num3;
        num2 = index;
      }
    }
    return (float) num2 / (float) (this.ptsAdjLength - 1);
  }

  public Vector3 point(float ratio)
  {
    float num = (double) ratio > 1.0 ? 1f : ratio;
    return !this.constantSpeed ? this.interp(num) : this.map(num);
  }

  public void place2d(Transform transform, float ratio)
  {
    transform.position = this.point(ratio);
    ratio += 1f / 1000f;
    if ((double) ratio > 1.0)
      return;
    Vector3 vector3 = this.point(ratio) - transform.position;
    float z = Mathf.Atan2(vector3.y, vector3.x) * 57.29578f;
    transform.eulerAngles = new Vector3(0.0f, 0.0f, z);
  }

  public void placeLocal2d(Transform transform, float ratio)
  {
    if ((UnityEngine.Object) transform.parent == (UnityEngine.Object) null)
    {
      this.place2d(transform, ratio);
    }
    else
    {
      transform.localPosition = this.point(ratio);
      ratio += 1f / 1000f;
      if ((double) ratio > 1.0)
        return;
      Vector3 vector3 = this.point(ratio) - transform.localPosition;
      float z = Mathf.Atan2(vector3.y, vector3.x) * 57.29578f;
      transform.localEulerAngles = new Vector3(0.0f, 0.0f, z);
    }
  }

  public void place(Transform transform, float ratio) => this.place(transform, ratio, Vector3.up);

  public void place(Transform transform, float ratio, Vector3 worldUp)
  {
    transform.position = this.point(ratio);
    ratio += 1f / 1000f;
    if ((double) ratio > 1.0)
      return;
    transform.LookAt(this.point(ratio), worldUp);
  }

  public void placeLocal(Transform transform, float ratio)
  {
    this.placeLocal(transform, ratio, Vector3.up);
  }

  public void placeLocal(Transform transform, float ratio, Vector3 worldUp)
  {
    transform.localPosition = this.point(ratio);
    ratio += 1f / 1000f;
    if ((double) ratio > 1.0)
      return;
    transform.LookAt(transform.parent.TransformPoint(this.point(ratio)), worldUp);
  }

  public void gizmoDraw(float t = -1f)
  {
    if (this.ptsAdj == null || this.ptsAdj.Length == 0)
      return;
    Vector3 from = this.ptsAdj[0];
    for (int index = 0; index < this.ptsAdjLength; ++index)
    {
      Vector3 to = this.ptsAdj[index];
      Gizmos.DrawLine(from, to);
      from = to;
    }
  }

  public void drawGizmo(Color color)
  {
    if (this.ptsAdjLength < 4)
      return;
    Vector3 from = this.ptsAdj[0];
    Color color1 = Gizmos.color;
    Gizmos.color = color;
    for (int index = 0; index < this.ptsAdjLength; ++index)
    {
      Vector3 to = this.ptsAdj[index];
      Gizmos.DrawLine(from, to);
      from = to;
    }
    Gizmos.color = color1;
  }

  public static void drawGizmo(Transform[] arr, Color color)
  {
    if (arr.Length < 4)
      return;
    Vector3[] pts = new Vector3[arr.Length];
    for (int index = 0; index < arr.Length; ++index)
      pts[index] = arr[index].position;
    LTSpline ltSpline = new LTSpline(pts);
    Vector3 from = ltSpline.ptsAdj[0];
    Color color1 = Gizmos.color;
    Gizmos.color = color;
    for (int index = 0; index < ltSpline.ptsAdjLength; ++index)
    {
      Vector3 to = ltSpline.ptsAdj[index];
      Gizmos.DrawLine(from, to);
      from = to;
    }
    Gizmos.color = color1;
  }

  public static void drawLine(Transform[] arr, float width, Color color)
  {
    int length = arr.Length;
  }

  public void drawLinesGLLines(Material outlineMaterial, Color color, float width)
  {
    GL.PushMatrix();
    outlineMaterial.SetPass(0);
    GL.LoadPixelMatrix();
    GL.Begin(1);
    GL.Color(color);
    if (this.constantSpeed)
    {
      if (this.ptsAdjLength >= 4)
      {
        Vector3 v1 = this.ptsAdj[0];
        for (int index = 0; index < this.ptsAdjLength; ++index)
        {
          Vector3 v2 = this.ptsAdj[index];
          GL.Vertex(v1);
          GL.Vertex(v2);
          v1 = v2;
        }
      }
    }
    else if (this.pts.Length >= 4)
    {
      Vector3 v3 = this.pts[0];
      float num1 = (float) (1.0 / ((double) this.pts.Length * 10.0));
      for (float num2 = 0.0f; (double) num2 < 1.0; num2 += num1)
      {
        Vector3 v4 = this.interp(num2 / 1f);
        GL.Vertex(v3);
        GL.Vertex(v4);
        v3 = v4;
      }
    }
    GL.End();
    GL.PopMatrix();
  }

  public Vector3[] generateVectors()
  {
    if (this.pts.Length >= 4)
    {
      List<Vector3> vector3List = new List<Vector3>();
      vector3List.Add(this.pts[0]);
      float num1 = (float) (1.0 / ((double) this.pts.Length * 10.0));
      for (float num2 = 0.0f; (double) num2 < 1.0; num2 += num1)
      {
        Vector3 vector3 = this.interp(num2 / 1f);
        vector3List.Add(vector3);
      }
      vector3List.ToArray();
    }
    return (Vector3[]) null;
  }
}
