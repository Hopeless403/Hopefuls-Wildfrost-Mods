// Decompiled with JetBrains decompiler
// Type: Bezier
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
[RequireComponent(typeof (LineRenderer))]
public class Bezier : MonoBehaviour
{
  public LineRenderer lineRenderer;
  public int quality = 30;

  public int pointCount => this.lineRenderer.positionCount;

  public Vector3 GetPoint(int index) => this.lineRenderer.GetPosition(index);

  private void Start()
  {
    if (this.lineRenderer != null)
      return;
    this.lineRenderer = this.GetComponent<LineRenderer>();
  }

  public void UpdateCurve(Vector3 p0, Vector3 p1, Vector3 p2)
  {
    this.lineRenderer.positionCount = this.quality + 1;
    this.lineRenderer.SetPosition(0, p0);
    for (int index = 1; index <= this.quality; ++index)
    {
      Vector3 position = this.Calculate((float) index / (float) this.quality, p0, p1, p2);
      this.lineRenderer.SetPosition(index, position);
    }
  }

  public void UpdateCurve(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
  {
    this.lineRenderer.positionCount = this.quality + 1;
    this.lineRenderer.SetPosition(0, p0);
    for (int index = 1; index <= this.quality; ++index)
    {
      Vector3 position = this.Calculate((float) index / (float) this.quality, p0, p1, p2, p3);
      this.lineRenderer.SetPosition(index, position);
    }
  }

  private Vector3 Calculate(float t, Vector3 p0, Vector3 p1, Vector3 p2)
  {
    float num1 = 1f - t;
    double num2 = (double) num1 * (double) num1;
    float num3 = t * t;
    Vector3 vector3 = p0;
    return (float) num2 * vector3 + 2f * num1 * t * p1 + num3 * p2;
  }

  private Vector3 Calculate(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
  {
    float num1 = 1f - t;
    float num2 = t * t;
    float num3 = num1 * num1;
    double num4 = (double) num3 * (double) num1;
    float num5 = num2 * t;
    Vector3 vector3 = p0;
    return (float) num4 * vector3 + 3f * num3 * t * p1 + 3f * num1 * num2 * p2 + num5 * p3;
  }
}
