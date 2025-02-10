// Decompiled with JetBrains decompiler
// Type: Page
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

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
  public bool dragging;
  public Vector3 dragGrabPos;
  public float zoom;
  public float zoomTarget;
  public bool inspecting;

  public void OnEnable()
  {
    global::Events.OnInspect += new UnityAction<Entity>(this.InspectStart);
    global::Events.OnInspectEnd += new UnityAction<Entity>(this.InspectEnd);
  }

  public void OnDisable()
  {
    global::Events.OnInspect -= new UnityAction<Entity>(this.InspectStart);
    global::Events.OnInspectEnd -= new UnityAction<Entity>(this.InspectEnd);
  }

  public void Update()
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

  public void InspectStart(Entity entity)
  {
    this.inspecting = true;
    this.StopDrag();
  }

  public void InspectEnd(Entity entity) => this.inspecting = false;

  public void StartDrag()
  {
    this.dragging = true;
    this.dragGrabPos = this.transform.position - Cursor3d.PositionWithZ;
  }

  public void Drag() => this.transform.position = Cursor3d.PositionWithZ + this.dragGrabPos;

  public void StopDrag() => this.dragging = false;
}
