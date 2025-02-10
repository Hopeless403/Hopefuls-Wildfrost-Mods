// Decompiled with JetBrains decompiler
// Type: TouchInputModule
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

#nullable disable
public class TouchInputModule : BaseInputModule
{
  [SerializeField]
  private BaseInput input;
  private PointerEventData pointer;
  public static bool touching;
  public static bool active;
  private static int blockScroll;
  private static readonly Vector2 offscreen = new Vector2(-1000f, -1000f);

  public Vector2 MousePosition { get; private set; }

  public Vector2 LastMousePosition { get; private set; }

  public Vector2 MouseMove { get; private set; }

  public GameObject Hover { get; private set; }

  public GameObject Press { get; private set; }

  public static float ScrollX { get; private set; }

  public static float ScrollY { get; private set; }

  protected override void OnEnable()
  {
    base.OnEnable();
    TouchInputModule.active = true;
    this.pointer = new PointerEventData(this.eventSystem);
    global::Events.OnUpdateInputSystem += new UnityAction<bool>(this.ForceUpdate);
    global::Events.OnCardControllerEnabled += new UnityAction<CardController>(this.CardControllerEnabled);
  }

  protected override void OnDisable()
  {
    base.OnDisable();
    TouchInputModule.active = false;
    global::Events.OnUpdateInputSystem -= new UnityAction<bool>(this.ForceUpdate);
    global::Events.OnCardControllerEnabled -= new UnityAction<CardController>(this.CardControllerEnabled);
    TouchInputModule.touching = false;
    TouchInputModule.ScrollX = 0.0f;
    TouchInputModule.ScrollY = 0.0f;
  }

  public static void BlockScroll() => ++TouchInputModule.blockScroll;

  public static void UnblockScroll() => --TouchInputModule.blockScroll;

  public override void Process()
  {
    Touch? touch = this.GetTouch();
    if (touch.HasValue)
    {
      this.ProcessTouch(touch.GetValueOrDefault());
      TouchInputModule.touching = true;
      if (TouchInputModule.blockScroll <= 0)
        return;
      TouchInputModule.ScrollX = 0.0f;
      TouchInputModule.ScrollY = 0.0f;
    }
    else
    {
      TouchInputModule.touching = false;
      TouchInputModule.ScrollX = 0.0f;
      TouchInputModule.ScrollY = 0.0f;
    }
  }

  private void ForceUpdate(bool forceTouch)
  {
    if (forceTouch)
    {
      Touch touch = new Touch()
      {
        position = this.MousePosition,
        deltaTime = Time.deltaTime,
        phase = TouchPhase.Stationary
      };
      GameObject hover = this.Hover;
      this.PopulateTouchPointerData(touch, out bool _, out bool _);
      this.Hover = this.pointer.pointerCurrentRaycast.gameObject;
      this.ProcessTouchMove(hover, this.Hover);
    }
    else
      this.Process();
  }

  public override void UpdateModule() => this.Process();

  private void CardControllerEnabled(CardController controller)
  {
    this.ProcessTouch(this.GetSimulatedTouch(TouchInputModule.offscreen, false, false));
  }

  private Touch? GetTouch()
  {
    if (this.input.touchCount <= 0)
      return new Touch?();
    Touch touch = this.input.GetTouch(0);
    this.LastMousePosition = this.MousePosition;
    this.MousePosition = touch.position;
    this.MouseMove = touch.deltaPosition;
    return new Touch?(touch);
  }

  private Touch GetSimulatedTouch(Vector2 position, bool pressed, bool released)
  {
    this.LastMousePosition = this.MousePosition;
    this.MousePosition = position;
    this.MouseMove = this.MousePosition - this.LastMousePosition;
    Touch simulatedTouch = new Touch()
    {
      position = this.MousePosition,
      rawPosition = this.MousePosition,
      deltaPosition = this.MouseMove,
      phase = TouchPhase.Stationary,
      pressure = 1f,
      maximumPossiblePressure = 1f,
      type = TouchType.Direct,
      tapCount = 1
    };
    if (pressed)
      simulatedTouch.phase = TouchPhase.Began;
    else if (released)
      simulatedTouch.phase = TouchPhase.Ended;
    else if ((double) simulatedTouch.deltaPosition.sqrMagnitude > 0.0)
      simulatedTouch.phase = TouchPhase.Moved;
    return simulatedTouch;
  }

  private void PopulateTouchPointerData(Touch touch, out bool pressed, out bool released)
  {
    this.pointer.Reset();
    pressed = !TouchInputModule.touching;
    ref bool local = ref released;
    TouchPhase phase = touch.phase;
    int num = (phase == TouchPhase.Canceled ? 0 : (phase != TouchPhase.Ended ? 1 : 0)) == 0 ? 1 : 0;
    local = num != 0;
    this.pointer.position = touch.position;
    this.pointer.delta = pressed ? Vector2.zero : touch.deltaPosition;
    this.pointer.button = PointerEventData.InputButton.Left;
    if (touch.phase == TouchPhase.Canceled)
    {
      this.pointer.pointerCurrentRaycast = new RaycastResult();
    }
    else
    {
      this.eventSystem.RaycastAll(this.pointer, this.m_RaycastResultCache);
      this.pointer.pointerCurrentRaycast = TouchInputModule.FindFirstRaycast(this.m_RaycastResultCache);
      this.m_RaycastResultCache.Clear();
    }
  }

  private void ProcessTouch(Touch touch)
  {
    GameObject hover = this.Hover;
    bool pressed;
    bool released;
    this.PopulateTouchPointerData(touch, out pressed, out released);
    this.Hover = this.pointer.pointerCurrentRaycast.gameObject;
    this.ProcessTouchMove(hover, this.Hover);
    if (!pressed && !released)
    {
      TouchInputModule.ScrollX = touch.deltaPosition.x;
      TouchInputModule.ScrollY = touch.deltaPosition.y;
    }
    else
    {
      TouchInputModule.ScrollX = 0.0f;
      TouchInputModule.ScrollY = 0.0f;
    }
    if (released)
      this.ProcessTouchRelease();
    else if (pressed)
      this.ProcessTouchPress(hover);
    if (released || !(bool) (Object) this.pointer.pointerDrag)
      return;
    this.ProcessTouchDrag();
  }

  private void ProcessTouchPress(GameObject preHover)
  {
    if (!(bool) (Object) this.Hover)
      return;
    TouchHandler component = this.Hover.GetComponent<TouchHandler>();
    bool alreadyHovered = (Object) preHover == (Object) this.Hover;
    if ((bool) (Object) component)
    {
      if (!component.CanTouchPress(alreadyHovered))
        return;
      this.Press = this.Hover;
      component.HandleTouchPress(this.pointer, alreadyHovered);
    }
    else
    {
      this.pointer.pressPosition = this.pointer.position;
      this.pointer.pointerPressRaycast = this.pointer.pointerCurrentRaycast;
      this.Press = this.Hover;
      ExecuteEvents.ExecuteHierarchy<IPointerDownHandler>(this.Press, (BaseEventData) this.pointer, ExecuteEvents.pointerDownHandler);
      this.pointer.pointerDrag = ExecuteEvents.GetEventHandler<IDragHandler>(this.Hover);
      if (!(bool) (Object) this.pointer.pointerDrag)
        return;
      ExecuteEvents.Execute<IInitializePotentialDragHandler>(this.pointer.pointerDrag, (BaseEventData) this.pointer, ExecuteEvents.initializePotentialDrag);
    }
  }

  private void ProcessTouchRelease()
  {
    if (!(bool) (Object) this.Press)
      return;
    ExecuteEvents.ExecuteHierarchy<IPointerUpHandler>(this.Press, (BaseEventData) this.pointer, ExecuteEvents.pointerUpHandler);
    if ((Object) this.Hover == (Object) this.Press)
      ExecuteEvents.ExecuteHierarchy<IPointerClickHandler>(this.Press, (BaseEventData) this.pointer, ExecuteEvents.pointerClickHandler);
    if ((bool) (Object) this.pointer.pointerDrag && this.pointer.dragging)
    {
      ExecuteEvents.ExecuteHierarchy<IDropHandler>(this.Hover, (BaseEventData) this.pointer, ExecuteEvents.dropHandler);
      ExecuteEvents.ExecuteHierarchy<IEndDragHandler>(this.pointer.pointerDrag, (BaseEventData) this.pointer, ExecuteEvents.endDragHandler);
      this.pointer.dragging = false;
    }
    this.Press = (GameObject) null;
  }

  private void ProcessTouchMove(GameObject preHover, GameObject hover)
  {
    if (!((Object) preHover != (Object) hover))
      return;
    int num = (bool) (Object) preHover ? 1 : 0;
    if (num != 0)
      ExecuteEvents.ExecuteHierarchy<IPointerExitHandler>(preHover, (BaseEventData) this.pointer, ExecuteEvents.pointerExitHandler);
    if ((bool) (Object) hover)
      ExecuteEvents.ExecuteHierarchy<IPointerEnterHandler>(hover, (BaseEventData) this.pointer, ExecuteEvents.pointerEnterHandler);
    if (num == 0)
      return;
    preHover.GetComponent<IPointerAfterExitHandler>()?.OnPointerAfterExit(this.pointer);
  }

  private void ProcessTouchDrag()
  {
    if (!this.pointer.IsPointerMoving())
      return;
    if (!this.pointer.dragging && TouchInputModule.ShouldStartDrag(this.pointer.pressPosition, this.pointer.position, (float) this.eventSystem.pixelDragThreshold, this.pointer.useDragThreshold))
    {
      ExecuteEvents.Execute<IBeginDragHandler>(this.pointer.pointerDrag, (BaseEventData) this.pointer, ExecuteEvents.beginDragHandler);
      this.pointer.dragging = true;
    }
    if (!this.pointer.dragging)
      return;
    ExecuteEvents.Execute<IDragHandler>(this.pointer.pointerDrag, (BaseEventData) this.pointer, ExecuteEvents.dragHandler);
  }

  private static bool ShouldStartDrag(
    Vector2 pressPos,
    Vector2 currentPos,
    float threshold,
    bool useDragThreshold)
  {
    return !useDragThreshold || (double) (pressPos - currentPos).sqrMagnitude >= (double) threshold * (double) threshold;
  }

  private new static RaycastResult FindFirstRaycast(List<RaycastResult> candidates)
  {
    foreach (RaycastResult candidate in candidates)
    {
      if ((bool) (Object) candidate.gameObject)
        return candidate;
    }
    return new RaycastResult();
  }
}
