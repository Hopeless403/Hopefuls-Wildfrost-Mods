// Decompiled with JetBrains decompiler
// Type: CustomInputModule
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class CustomInputModule : StandaloneInputModule
{
  public static readonly List<GameObject> unhoverCache = new List<GameObject>();
  public static readonly Vector2 offscreen = new Vector2(-1000f, -1000f);

  public override void OnEnable()
  {
    base.OnEnable();
    global::Events.OnCardControllerEnabled += new UnityAction<CardController>(this.CardControllerEnabled);
  }

  public override void OnDisable()
  {
    base.OnDisable();
    global::Events.OnCardControllerEnabled -= new UnityAction<CardController>(this.CardControllerEnabled);
  }

  public void CardControllerEnabled(CardController controller) => this.ForceSetMousePosition(CustomInputModule.offscreen);

  public void ForceSetMousePosition(Vector2 position)
  {
    PointerInputModule.MouseState dataWithPosition = this.GetMousePointerEventDataWithPosition(position);
    PointerInputModule.MouseButtonEventData eventData = dataWithPosition.GetButtonState(PointerEventData.InputButton.Left).eventData;
    this.ProcessMousePress(eventData);
    this.ProcessMove(eventData.buttonData);
    this.ProcessDrag(eventData.buttonData);
    this.ProcessMousePress(dataWithPosition.GetButtonState(PointerEventData.InputButton.Right).eventData);
    this.ProcessDrag(dataWithPosition.GetButtonState(PointerEventData.InputButton.Right).eventData.buttonData);
    this.ProcessMousePress(dataWithPosition.GetButtonState(PointerEventData.InputButton.Middle).eventData);
    this.ProcessDrag(dataWithPosition.GetButtonState(PointerEventData.InputButton.Middle).eventData.buttonData);
    if (Mathf.Approximately(eventData.buttonData.scrollDelta.sqrMagnitude, 0.0f))
      return;
    ExecuteEvents.ExecuteHierarchy<IScrollHandler>(ExecuteEvents.GetEventHandler<IScrollHandler>(eventData.buttonData.pointerCurrentRaycast.gameObject), (BaseEventData) eventData.buttonData, ExecuteEvents.scrollHandler);
  }

  public PointerInputModule.MouseState GetMousePointerEventDataWithPosition(Vector2 forcePosition)
  {
    PointerEventData data1;
    int num = this.GetPointerData(-1, out data1, true) ? 1 : 0;
    data1.Reset();
    if (num != 0)
      data1.position = forcePosition;
    if (Cursor.lockState == CursorLockMode.Locked)
    {
      data1.position = new Vector2(-1f, -1f);
      data1.delta = Vector2.zero;
    }
    else
    {
      data1.delta = forcePosition - data1.position;
      data1.position = forcePosition;
    }
    data1.scrollDelta = this.input.mouseScrollDelta;
    data1.button = PointerEventData.InputButton.Left;
    this.eventSystem.RaycastAll(data1, this.m_RaycastResultCache);
    RaycastResult firstRaycast = BaseInputModule.FindFirstRaycast(this.m_RaycastResultCache);
    data1.pointerCurrentRaycast = firstRaycast;
    this.m_RaycastResultCache.Clear();
    PointerEventData data2;
    this.GetPointerData(-2, out data2, true);
    data2.Reset();
    this.CopyFromTo(data1, data2);
    data2.button = PointerEventData.InputButton.Right;
    PointerEventData data3;
    this.GetPointerData(-3, out data3, true);
    data3.Reset();
    this.CopyFromTo(data1, data3);
    data3.button = PointerEventData.InputButton.Middle;
    PointerInputModule.MouseState dataWithPosition = new PointerInputModule.MouseState();
    dataWithPosition.SetButtonState(PointerEventData.InputButton.Left, this.StateForMouseButton(0), data1);
    dataWithPosition.SetButtonState(PointerEventData.InputButton.Right, this.StateForMouseButton(1), data2);
    dataWithPosition.SetButtonState(PointerEventData.InputButton.Middle, this.StateForMouseButton(2), data3);
    return dataWithPosition;
  }

  public override void ProcessMove(PointerEventData pointerEvent)
  {
    GameObject gameObject = Cursor.lockState == CursorLockMode.Locked ? (GameObject) null : pointerEvent.pointerCurrentRaycast.gameObject;
    CustomInputModule.CustomHandlePointerExitAndEnter(pointerEvent, gameObject);
  }

  public static void CustomHandlePointerExitAndEnter(
    PointerEventData currentPointerData,
    GameObject newEnterTarget)
  {
    if ((Object) newEnterTarget == (Object) null || (Object) currentPointerData.pointerEnter == (Object) null)
    {
      int count = currentPointerData.hovered.Count;
      for (int index = 0; index < count; ++index)
      {
        GameObject target = currentPointerData.hovered[index];
        ExecuteEvents.Execute<IPointerExitHandler>(target, (BaseEventData) currentPointerData, ExecuteEvents.pointerExitHandler);
        CustomInputModule.unhoverCache.Add(target);
      }
      currentPointerData.hovered.Clear();
      if ((Object) newEnterTarget == (Object) null)
      {
        currentPointerData.pointerEnter = (GameObject) null;
        return;
      }
    }
    if ((Object) currentPointerData.pointerEnter == (Object) newEnterTarget && (bool) (Object) newEnterTarget)
      return;
    GameObject commonRoot = BaseInputModule.FindCommonRoot(currentPointerData.pointerEnter, newEnterTarget);
    if ((Object) currentPointerData.pointerEnter != (Object) null)
    {
      for (Transform transform = currentPointerData.pointerEnter.transform; (Object) transform != (Object) null && (!((Object) commonRoot != (Object) null) || !((Object) commonRoot.transform == (Object) transform)); transform = transform.parent)
      {
        ExecuteEvents.Execute<IPointerExitHandler>(transform.gameObject, (BaseEventData) currentPointerData, ExecuteEvents.pointerExitHandler);
        currentPointerData.hovered.Remove(transform.gameObject);
        CustomInputModule.unhoverCache.Add(transform.gameObject);
      }
    }
    currentPointerData.pointerEnter = newEnterTarget;
    if ((Object) newEnterTarget != (Object) null)
    {
      for (Transform transform = newEnterTarget.transform; (Object) transform != (Object) null && (Object) transform.gameObject != (Object) commonRoot; transform = transform.parent)
      {
        ExecuteEvents.Execute<IPointerEnterHandler>(transform.gameObject, (BaseEventData) currentPointerData, ExecuteEvents.pointerEnterHandler);
        currentPointerData.hovered.Add(transform.gameObject);
      }
    }
    foreach (GameObject gameObject in CustomInputModule.unhoverCache)
    {
      if ((bool) (Object) gameObject)
        gameObject.GetComponent<IPointerAfterExitHandler>()?.OnPointerAfterExit(currentPointerData);
    }
    CustomInputModule.unhoverCache.Clear();
  }
}
