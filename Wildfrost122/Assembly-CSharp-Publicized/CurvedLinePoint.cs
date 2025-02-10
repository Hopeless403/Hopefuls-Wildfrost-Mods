// Decompiled with JetBrains decompiler
// Type: CurvedLinePoint
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
public class CurvedLinePoint : MonoBehaviour
{
  [HideInInspector]
  public bool showGizmo = true;
  [HideInInspector]
  public float gizmoSize = 0.1f;
  [HideInInspector]
  public Color gizmoColor = new Color(1f, 0.0f, 0.0f, 0.5f);

  public void OnDrawGizmos()
  {
    if (!this.showGizmo)
      return;
    Gizmos.color = this.gizmoColor;
    Gizmos.DrawSphere(this.transform.position, this.gizmoSize);
  }

  public void OnDrawGizmosSelected()
  {
    CurvedLineRenderer component = this.transform.parent.GetComponent<CurvedLineRenderer>();
    if (!((Object) component != (Object) null))
      return;
    component.Update();
  }
}
