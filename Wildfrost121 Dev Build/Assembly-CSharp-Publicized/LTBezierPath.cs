// Decompiled with JetBrains decompiler
// Type: LTBezierPath
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
public class LTBezierPath
{
  public Vector3[] pts;
  public float length;
  public bool orientToPath;
  public bool orientToPath2d;
  public LTBezier[] beziers;
  public float[] lengthRatio;
  public int currentBezier;
  public int previousBezier;

  public LTBezierPath()
  {
  }

  public LTBezierPath(Vector3[] pts_) => this.setPoints(pts_);

  public void setPoints(Vector3[] pts_)
  {
    if (pts_.Length < 4)
      LeanTween.logError("LeanTween - When passing values for a vector path, you must pass four or more values!");
    if (pts_.Length % 4 != 0)
      LeanTween.logError("LeanTween - When passing values for a vector path, they must be in sets of four: controlPoint1, controlPoint2, endPoint2, controlPoint2, controlPoint2...");
    this.pts = pts_;
    int index1 = 0;
    this.beziers = new LTBezier[this.pts.Length / 4];
    this.lengthRatio = new float[this.beziers.Length];
    this.length = 0.0f;
    for (int index2 = 0; index2 < this.pts.Length; index2 += 4)
    {
      this.beziers[index1] = new LTBezier(this.pts[index2], this.pts[index2 + 2], this.pts[index2 + 1], this.pts[index2 + 3], 0.05f);
      this.length += this.beziers[index1].length;
      ++index1;
    }
    for (int index3 = 0; index3 < this.beziers.Length; ++index3)
      this.lengthRatio[index3] = this.beziers[index3].length / this.length;
  }

  public float distance => this.length;

  public Vector3 point(float ratio)
  {
    float num = 0.0f;
    for (int index = 0; index < this.lengthRatio.Length; ++index)
    {
      num += this.lengthRatio[index];
      if ((double) num >= (double) ratio)
        return this.beziers[index].point((ratio - (num - this.lengthRatio[index])) / this.lengthRatio[index]);
    }
    return this.beziers[this.lengthRatio.Length - 1].point(1f);
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
    transform.localPosition = this.point(ratio);
    ratio += 1f / 1000f;
    if ((double) ratio > 1.0)
      return;
    Vector3 vector3 = this.point(ratio) - transform.localPosition;
    float z = Mathf.Atan2(vector3.y, vector3.x) * 57.29578f;
    transform.localEulerAngles = new Vector3(0.0f, 0.0f, z);
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
    ratio = Mathf.Clamp01(ratio);
    transform.localPosition = this.point(ratio);
    ratio = Mathf.Clamp01(ratio + 1f / 1000f);
    if ((double) ratio > 1.0)
      return;
    transform.LookAt(transform.parent.TransformPoint(this.point(ratio)), worldUp);
  }

  public void gizmoDraw(float t = -1f)
  {
    Vector3 to = this.point(0.0f);
    for (int index = 1; index <= 120; ++index)
    {
      Vector3 from = this.point((float) index / 120f);
      Gizmos.color = this.previousBezier == this.currentBezier ? Color.magenta : Color.grey;
      Gizmos.DrawLine(from, to);
      to = from;
      this.previousBezier = this.currentBezier;
    }
  }

  public float ratioAtPoint(Vector3 pt, float precision = 0.01f)
  {
    float num1 = float.MaxValue;
    int num2 = 0;
    int num3 = Mathf.RoundToInt(1f / precision);
    for (int index = 0; index < num3; ++index)
    {
      float ratio = (float) index / (float) num3;
      float num4 = Vector3.Distance(pt, this.point(ratio));
      if ((double) num4 < (double) num1)
      {
        num1 = num4;
        num2 = index;
      }
    }
    return (float) num2 / (float) num3;
  }
}
