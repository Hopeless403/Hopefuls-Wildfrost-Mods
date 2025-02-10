// Decompiled with JetBrains decompiler
// Type: Page
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Events;

public class Page : MonoBehaviour
{
  [Header("Dragging")]
  public bool canDrag = true;
  [Header("Zooming")]
  public bool canZoom = true;
  [ShowIf("canZoom")]
  [MinMaxSlider(-100f, 100f)]
  public Vector2 zoomRange = new Vector2(0.0f, 80f);
  [ShowIf("canZoom")]
  [Range(0.0f, 1f)]
  public float zoomSpeed = 0.1f;
  private bool dragging;
  private Vector3 dragGrabPos;
  private float zoom;
  private float zoomTarget;
  private bool inspecting;

  private void OnEnable()
  {
    global::Events.OnInspect += new UnityAction<Entity>(this.InspectStart);
    global::Events.OnInspectEnd += new UnityAction<Entity>(this.InspectEnd);
  }

  private void OnDisable()
  {
    global::Events.OnInspect -= new UnityAction<Entity>(this.InspectStart);
    global::Events.OnInspectEnd -= new UnityAction<Entity>(this.InspectEnd);
  }

  private void Update()
  {
    if (this.inspecting)
      return;
    if (this.canDrag)
    {
      if (this.dragging)
        this.Drag();
      if (this.dragging && !Input.GetMouseButton(2))
        this.StopDrag();
      if (Input.GetMouseButtonDown(2))
        this.StartDrag();
    }
    float num = -Input.mouseScrollDelta.y;
    if ((double) num > 0.0)
      this.zoomTarget = Mathf.Min(this.zoomTarget + num * this.zoomSpeed, 1f);
    else if ((double) num < 0.0)
      this.zoomTarget = Mathf.Max(this.zoomTarget + num * this.zoomSpeed, 0.0f);
    if ((double) this.zoom == (double) this.zoomTarget)
      return;
    this.zoom = Delta.Lerp(this.zoom, this.zoomTarget, 0.1f, Time.deltaTime);
    this.transform.localPosition = this.transform.localPosition.WithZ(this.zoomRange.x + (this.zoomRange.y - this.zoomRange.x) * this.zoom);
  }

  private void InspectStart(Entity entity)
  {
    this.inspecting = true;
    this.StopDrag();
  }

  private void InspectEnd(Entity entity) => this.inspecting = false;

  private void StartDrag()
  {
    this.dragging = true;
    this.dragGrabPos = this.transform.position - Cursor3d.PositionWithZ;
  }

  private void Drag() => this.transform.position = Cursor3d.PositionWithZ + this.dragGrabPos;

  private void StopDrag() => this.dragging = false;
}
