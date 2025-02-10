// Decompiled with JetBrains decompiler
// Type: UnityEngine.EventSystems.VirtualInputModule
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using UnityEngine.Serialization;

#nullable disable
namespace UnityEngine.EventSystems
{
  [AddComponentMenu("Event/Virtual Input Module")]
  public class VirtualInputModule : PointerInputModule
  {
    private float m_PrevActionTime;
    private Vector2 m_LastMoveVector;
    private int m_ConsecutiveMoveCount;
    private Vector2 m_LastMousePosition;
    private Vector2 m_MousePosition;
    [SerializeField]
    private RectTransform m_VirtualCursor;
    private Camera _cam;
    [SerializeField]
    private string m_HorizontalAxis = "Horizontal";
    [SerializeField]
    private string m_VerticalAxis = "Vertical";
    [SerializeField]
    private string m_SubmitButton = "Submit";
    [SerializeField]
    private string m_CancelButton = "Cancel";
    [SerializeField]
    private float m_InputActionsPerSecond = 10f;
    [SerializeField]
    private float m_RepeatDelay = 0.5f;
    [SerializeField]
    [FormerlySerializedAs("m_AllowActivationOnMobileDevice")]
    private bool m_ForceModuleActive;
    private PointerEventData.FramePressState oldButtonState = PointerEventData.FramePressState.NotChanged;
    private readonly PointerInputModule.MouseState m_MouseState = new PointerInputModule.MouseState();

    protected VirtualInputModule()
    {
    }

    [Obsolete("Mode is no longer needed on input module as it handles both mouse and keyboard simultaneously.", false)]
    public VirtualInputModule.InputMode inputMode => VirtualInputModule.InputMode.Mouse;

    private Camera m_canvasCamera => this._cam ?? (this._cam = Camera.main);

    [Obsolete("allowActivationOnMobileDevice has been deprecated. Use forceModuleActive instead (UnityUpgradable) -> forceModuleActive")]
    public bool allowActivationOnMobileDevice
    {
      get => this.m_ForceModuleActive;
      set => this.m_ForceModuleActive = value;
    }

    public bool forceModuleActive
    {
      get => this.m_ForceModuleActive;
      set => this.m_ForceModuleActive = value;
    }

    public float inputActionsPerSecond
    {
      get => this.m_InputActionsPerSecond;
      set => this.m_InputActionsPerSecond = value;
    }

    public float repeatDelay
    {
      get => this.m_RepeatDelay;
      set => this.m_RepeatDelay = value;
    }

    public string horizontalAxis
    {
      get => this.m_HorizontalAxis;
      set => this.m_HorizontalAxis = value;
    }

    public string verticalAxis
    {
      get => this.m_VerticalAxis;
      set => this.m_VerticalAxis = value;
    }

    public string submitButton
    {
      get => this.m_SubmitButton;
      set => this.m_SubmitButton = value;
    }

    public string cancelButton
    {
      get => this.m_CancelButton;
      set => this.m_CancelButton = value;
    }

    public override void UpdateModule()
    {
      this.m_LastMousePosition = this.m_MousePosition;
      this.m_MousePosition = this.m_VirtualCursor.anchoredPosition;
    }

    public override bool IsModuleSupported() => this.m_ForceModuleActive || Input.mousePresent;

    public override bool ShouldActivateModule()
    {
      if (!base.ShouldActivateModule())
        return false;
      bool flag = this.m_ForceModuleActive | !Mathf.Approximately(Mathf.Abs(RewiredControllerManager.instance.GetAnalog("Move Horizontal")), 0.0f) | !Mathf.Approximately(Mathf.Abs(RewiredControllerManager.instance.GetAnalog("Move Vertical")), 0.0f) | (double) (this.m_MousePosition - this.m_LastMousePosition).sqrMagnitude > 0.0 | RewiredControllerManager.instance.IsButtonPressed("Select");
      if (Console.active)
        flag = false;
      return flag;
    }

    public override void ActivateModule()
    {
      base.ActivateModule();
      this.m_MousePosition = this.m_VirtualCursor.anchoredPosition;
      this.m_LastMousePosition = this.m_VirtualCursor.anchoredPosition;
      GameObject selectedGameObject = this.eventSystem.currentSelectedGameObject;
      if ((UnityEngine.Object) selectedGameObject == (UnityEngine.Object) null)
        selectedGameObject = this.eventSystem.firstSelectedGameObject;
      this.eventSystem.SetSelectedGameObject(selectedGameObject, this.GetBaseEventData());
    }

    public override void DeactivateModule()
    {
      base.DeactivateModule();
      this.ClearSelection();
    }

    public override void Process()
    {
      bool selectedObject = this.SendUpdateEventToSelectedObject();
      if (this.eventSystem.sendNavigationEvents)
      {
        if (!selectedObject)
          selectedObject |= this.SendMoveEventToSelectedObject();
        if (!selectedObject)
          this.SendSubmitEventToSelectedObject();
      }
      this.ProcessMouseEvent();
      this.ProcessRewiredEvent();
    }

    protected bool SendSubmitEventToSelectedObject()
    {
      return !((UnityEngine.Object) this.eventSystem.currentSelectedGameObject == (UnityEngine.Object) null) && this.GetBaseEventData().used;
    }

    private Vector2 GetRawMoveVector()
    {
      Vector2 zero = Vector2.zero with
      {
        x = RewiredControllerManager.instance.GetAnalog("Move Vertical"),
        y = RewiredControllerManager.instance.GetAnalog("Move Horizontal")
      };
      if ((double) Mathf.Abs(RewiredControllerManager.instance.GetAnalog("Move Horizontal")) >= 0.05000000074505806)
      {
        if ((double) zero.x < 0.0)
          zero.x = -1f;
        if ((double) zero.x > 0.0)
          zero.x = 1f;
      }
      if ((double) Mathf.Abs(RewiredControllerManager.instance.GetAnalog("Move Vertical")) >= 0.05000000074505806)
      {
        if ((double) zero.y < 0.0)
          zero.y = -1f;
        if ((double) zero.y > 0.0)
          zero.y = 1f;
      }
      return zero;
    }

    protected bool SendMoveEventToSelectedObject()
    {
      float unscaledTime = Time.unscaledTime;
      Vector2 rawMoveVector = this.GetRawMoveVector();
      if (Mathf.Approximately(rawMoveVector.x, 0.0f) && Mathf.Approximately(rawMoveVector.y, 0.0f))
      {
        this.m_ConsecutiveMoveCount = 0;
        return false;
      }
      bool flag1 = (double) Mathf.Abs(RewiredControllerManager.instance.GetAnalog("Move Vertical")) >= 0.05000000074505806 || (double) Mathf.Abs(RewiredControllerManager.instance.GetAnalog("Move Horizontal")) >= 0.05000000074505806;
      bool flag2 = (double) Vector2.Dot(rawMoveVector, this.m_LastMoveVector) > 0.0;
      if (!flag1)
        flag1 = !flag2 || this.m_ConsecutiveMoveCount != 1 ? (double) unscaledTime > (double) this.m_PrevActionTime + 1.0 / (double) this.m_InputActionsPerSecond : (double) unscaledTime > (double) this.m_PrevActionTime + (double) this.m_RepeatDelay;
      if (!flag1)
        return false;
      AxisEventData axisEventData = this.GetAxisEventData(rawMoveVector.x, rawMoveVector.y, 0.6f);
      ExecuteEvents.Execute<IMoveHandler>(this.eventSystem.currentSelectedGameObject, (BaseEventData) axisEventData, ExecuteEvents.moveHandler);
      if (!flag2)
        this.m_ConsecutiveMoveCount = 0;
      ++this.m_ConsecutiveMoveCount;
      this.m_PrevActionTime = unscaledTime;
      this.m_LastMoveVector = rawMoveVector;
      return axisEventData.used;
    }

    protected void ProcessRewiredEvent()
    {
      PointerInputModule.MouseButtonEventData eventData = this.GetMousePointerEventData(0).GetButtonState(PointerEventData.InputButton.Left).eventData;
      PointerEventData.FramePressState framePressState = PointerEventData.FramePressState.NotChanged;
      if (RewiredControllerManager.instance.IsButtonPressed("Select"))
        framePressState = PointerEventData.FramePressState.Pressed;
      if (RewiredControllerManager.instance.IsButtonReleased("Select"))
        framePressState = PointerEventData.FramePressState.Released;
      if (framePressState == this.oldButtonState)
        framePressState = PointerEventData.FramePressState.NotChanged;
      this.oldButtonState = framePressState;
      if ((UnityEngine.Object) MonoBehaviourSingleton<UINavigationSystem>.instance != (UnityEngine.Object) null && (UnityEngine.Object) MonoBehaviourSingleton<UINavigationSystem>.instance.currentNavigationItem != (UnityEngine.Object) null)
      {
        GameObject clickHandler = MonoBehaviourSingleton<UINavigationSystem>.instance.currentNavigationItem.clickHandler;
      }
      PointerInputModule.MouseButtonEventData data = new PointerInputModule.MouseButtonEventData()
      {
        buttonState = framePressState,
        buttonData = eventData.buttonData
      };
      this.ProcessMousePress(data);
      if (Mathf.Approximately(data.buttonData.scrollDelta.sqrMagnitude, 0.0f))
        return;
      ExecuteEvents.ExecuteHierarchy<IScrollHandler>(ExecuteEvents.GetEventHandler<IScrollHandler>(data.buttonData.pointerCurrentRaycast.gameObject), (BaseEventData) data.buttonData, ExecuteEvents.scrollHandler);
    }

    protected void ProcessMouseEvent() => this.ProcessMouseEvent(0);

    protected void ProcessMouseEvent(int id)
    {
      PointerInputModule.MouseButtonEventData eventData = this.GetMousePointerEventData(id).GetButtonState(PointerEventData.InputButton.Left).eventData;
      if ((UnityEngine.Object) MonoBehaviourSingleton<UINavigationSystem>.instance != (UnityEngine.Object) null && (UnityEngine.Object) MonoBehaviourSingleton<UINavigationSystem>.instance.currentNavigationItem != (UnityEngine.Object) null)
        eventData.buttonData.pointerCurrentRaycast = new RaycastResult()
        {
          gameObject = MonoBehaviourSingleton<UINavigationSystem>.instance.currentNavigationItem.clickHandler
        };
      this.ProcessMove(eventData.buttonData);
      this.ProcessDrag(eventData.buttonData);
      if (Mathf.Approximately(eventData.buttonData.scrollDelta.sqrMagnitude, 0.0f))
        return;
      ExecuteEvents.GetEventHandler<IScrollHandler>(eventData.buttonData.pointerCurrentRaycast.gameObject);
    }

    protected bool SendUpdateEventToSelectedObject()
    {
      if ((UnityEngine.Object) this.eventSystem.currentSelectedGameObject == (UnityEngine.Object) null)
        return false;
      BaseEventData baseEventData = this.GetBaseEventData();
      ExecuteEvents.Execute<IUpdateSelectedHandler>(this.eventSystem.currentSelectedGameObject, baseEventData, ExecuteEvents.updateSelectedHandler);
      return baseEventData.used;
    }

    protected void ProcessMousePress(PointerInputModule.MouseButtonEventData data)
    {
      PointerEventData buttonData = data.buttonData;
      GameObject gameObject1 = buttonData.pointerCurrentRaycast.gameObject;
      if (data.PressedThisFrame())
      {
        buttonData.eligibleForClick = true;
        buttonData.delta = Vector2.zero;
        buttonData.dragging = false;
        buttonData.useDragThreshold = true;
        buttonData.pressPosition = buttonData.position;
        buttonData.pointerPressRaycast = buttonData.pointerCurrentRaycast;
        buttonData.position = this.m_VirtualCursor.anchoredPosition;
        this.DeselectIfSelectionChanged(gameObject1, (BaseEventData) buttonData);
        GameObject gameObject2 = ExecuteEvents.ExecuteHierarchy<IPointerDownHandler>(gameObject1, (BaseEventData) buttonData, ExecuteEvents.pointerDownHandler);
        if ((UnityEngine.Object) gameObject2 == (UnityEngine.Object) null)
          gameObject2 = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject1);
        float unscaledTime = Time.unscaledTime;
        if ((UnityEngine.Object) gameObject2 == (UnityEngine.Object) buttonData.lastPress)
        {
          if ((double) unscaledTime - (double) buttonData.clickTime < 0.30000001192092896)
            ++buttonData.clickCount;
          else
            buttonData.clickCount = 1;
          buttonData.clickTime = unscaledTime;
        }
        else
          buttonData.clickCount = 1;
        buttonData.pointerPress = gameObject2;
        buttonData.rawPointerPress = gameObject1;
        buttonData.clickTime = unscaledTime;
        buttonData.pointerDrag = ExecuteEvents.GetEventHandler<IDragHandler>(gameObject1);
        if ((UnityEngine.Object) buttonData.pointerDrag != (UnityEngine.Object) null)
          ExecuteEvents.Execute<IInitializePotentialDragHandler>(buttonData.pointerDrag, (BaseEventData) buttonData, ExecuteEvents.initializePotentialDrag);
      }
      if (!data.ReleasedThisFrame())
        return;
      GameObject gameObject3 = ExecuteEvents.ExecuteHierarchy<IPointerUpHandler>(gameObject1, (BaseEventData) buttonData, ExecuteEvents.pointerUpHandler);
      if ((UnityEngine.Object) gameObject3 == (UnityEngine.Object) null)
        gameObject3 = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject1);
      buttonData.pointerPress = gameObject3;
      ExecuteEvents.Execute<IPointerUpHandler>(buttonData.pointerPress, (BaseEventData) buttonData, ExecuteEvents.pointerUpHandler);
      GameObject eventHandler = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject1);
      if ((UnityEngine.Object) buttonData.pointerPress == (UnityEngine.Object) eventHandler && buttonData.eligibleForClick)
        ExecuteEvents.Execute<IPointerClickHandler>(buttonData.pointerPress, (BaseEventData) buttonData, ExecuteEvents.pointerClickHandler);
      else if ((UnityEngine.Object) buttonData.pointerDrag != (UnityEngine.Object) null && buttonData.dragging)
        ExecuteEvents.ExecuteHierarchy<IDropHandler>(gameObject1, (BaseEventData) buttonData, ExecuteEvents.dropHandler);
      buttonData.eligibleForClick = false;
      buttonData.pointerPress = (GameObject) null;
      buttonData.rawPointerPress = (GameObject) null;
      if ((UnityEngine.Object) buttonData.pointerDrag != (UnityEngine.Object) null && buttonData.dragging)
        ExecuteEvents.Execute<IEndDragHandler>(buttonData.pointerDrag, (BaseEventData) buttonData, ExecuteEvents.endDragHandler);
      buttonData.dragging = false;
      buttonData.pointerDrag = (GameObject) null;
      if (!((UnityEngine.Object) gameObject1 != (UnityEngine.Object) buttonData.pointerEnter))
        return;
      this.HandlePointerExitAndEnter(buttonData, (GameObject) null);
      this.HandlePointerExitAndEnter(buttonData, gameObject1);
    }

    protected override PointerInputModule.MouseState GetMousePointerEventData(int id)
    {
      PointerEventData data1;
      int num = this.GetPointerData(-1, out data1, true) ? 1 : 0;
      data1.Reset();
      Vector2 screenPoint = RectTransformUtility.WorldToScreenPoint(this.m_canvasCamera, this.m_VirtualCursor.position);
      if (num != 0)
        data1.position = screenPoint;
      Vector2 vector2 = screenPoint;
      data1.delta = vector2 - data1.position;
      data1.position = vector2;
      data1.scrollDelta = Input.mouseScrollDelta;
      data1.button = PointerEventData.InputButton.Left;
      this.eventSystem.RaycastAll(data1, this.m_RaycastResultCache);
      RaycastResult firstRaycast = BaseInputModule.FindFirstRaycast(this.m_RaycastResultCache);
      data1.pointerCurrentRaycast = firstRaycast;
      this.m_RaycastResultCache.Clear();
      PointerEventData data2;
      this.GetPointerData(-2, out data2, true);
      this.CopyFromTo(data1, data2);
      data2.button = PointerEventData.InputButton.Right;
      PointerEventData data3;
      this.GetPointerData(-3, out data3, true);
      this.CopyFromTo(data1, data3);
      data3.button = PointerEventData.InputButton.Middle;
      this.m_MouseState.SetButtonState(PointerEventData.InputButton.Left, this.StateForMouseButton(0), data1);
      this.m_MouseState.SetButtonState(PointerEventData.InputButton.Right, this.StateForMouseButton(1), data2);
      this.m_MouseState.SetButtonState(PointerEventData.InputButton.Middle, this.StateForMouseButton(2), data3);
      return this.m_MouseState;
    }

    [Obsolete("Mode is no longer needed on input module as it handles both mouse and keyboard simultaneously.", false)]
    public enum InputMode
    {
      Mouse,
      Buttons,
    }
  }
}
