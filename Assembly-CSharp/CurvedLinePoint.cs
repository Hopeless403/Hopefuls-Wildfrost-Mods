// Decompiled with JetBrains decompiler
// Type: CurvedLinePoint
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public class CurvedLinePoint : MonoBehaviour
{
  [HideInInspector]
  public bool showGizmo = true;
  [HideInInspector]
  public float gizmoSize = 0.1f;
  [HideInInspector]
  public Color gizmoColor = new Color(1f, 0.0f, 0.0f, 0.5f);

  private void OnDrawGizmos()
  {
    if (!this.showGizmo)
      return;
    Gizmos.color = this.gizmoColor;
    Gizmos.DrawSphere(this.transform.position, this.gizmoSize);
  }

  private void OnDrawGizmosSelected()
  {
    CurvedLineRenderer component = this.transform.parent.GetComponent<CurvedLineRenderer>();
    if (!((Object) component != (Object) null))
      return;
    component.Update();
  }
}
