﻿// Decompiled with JetBrains decompiler
// Type: CurvedLineRenderer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
[RequireComponent(typeof (LineRenderer))]
public class CurvedLineRenderer : MonoBehaviour
{
  public float lineSegmentSize = 0.1f;
  public float lineWidth = 0.1f;
  public bool autoUpdate;
  public bool promptUpdate;
  [Header("Gizmos")]
  public bool showGizmos = true;
  public float gizmoSize = 0.1f;
  public Color gizmoColor = new Color(1f, 0.0f, 0.0f, 0.5f);
  public CurvedLinePoint[] linePoints = new CurvedLinePoint[0];
  public Vector3[] linePositions = new Vector3[0];
  public Vector3[] linePositionsOld = new Vector3[0];

  public void Update()
  {
    if (!this.autoUpdate && !this.promptUpdate)
      return;
    this.UpdatePoints();
    this.promptUpdate = false;
  }

  public void UpdatePoints()
  {
    this.GetPoints();
    this.SetPointsToLine();
  }

  public void GetPoints()
  {
    this.linePoints = this.GetComponentsInChildren<CurvedLinePoint>();
    this.linePositions = new Vector3[this.linePoints.Length];
    for (int index = 0; index < this.linePoints.Length; ++index)
      this.linePositions[index] = this.linePoints[index].transform.localPosition;
  }

  public void SetPointsToLine()
  {
    if (this.linePositionsOld.Length != this.linePositions.Length)
      this.linePositionsOld = new Vector3[this.linePositions.Length];
    bool flag = false;
    for (int index = 0; index < this.linePositions.Length; ++index)
    {
      if (this.linePositions[index] != this.linePositionsOld[index])
        flag = true;
    }
    if (!flag)
      return;
    LineRenderer component = this.GetComponent<LineRenderer>();
    Vector3[] positions = LineSmoother.SmoothLine(this.linePositions, this.lineSegmentSize);
    component.positionCount = positions.Length;
    component.SetPositions(positions);
    component.startWidth = this.lineWidth;
    component.endWidth = this.lineWidth;
  }

  public void OnDrawGizmosSelected() => this.Update();

  public void OnDrawGizmos()
  {
    if (this.linePoints.Length == 0)
      this.GetPoints();
    foreach (CurvedLinePoint linePoint in this.linePoints)
    {
      linePoint.showGizmo = this.showGizmos;
      linePoint.gizmoSize = this.gizmoSize;
      linePoint.gizmoColor = this.gizmoColor;
    }
  }
}
