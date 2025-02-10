// Decompiled with JetBrains decompiler
// Type: TouchHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.EventSystems;

public class TouchHandler : MonoBehaviour
{
  [SerializeField]
  private bool hoverBeforePress = true;

  public bool CanTouchPress(bool alreadyHovered) => !this.hoverBeforePress | alreadyHovered;

  public void HandleTouchPress(PointerEventData pointer, bool alreadyHovered)
  {
    pointer.pressPosition = pointer.position;
    pointer.pointerPressRaycast = pointer.pointerCurrentRaycast;
    ExecuteEvents.ExecuteHierarchy<IPointerDownHandler>(this.gameObject, (BaseEventData) pointer, ExecuteEvents.pointerDownHandler);
    pointer.pointerDrag = ExecuteEvents.GetEventHandler<IDragHandler>(this.gameObject);
    if (!(bool) (Object) pointer.pointerDrag)
      return;
    ExecuteEvents.Execute<IInitializePotentialDragHandler>(pointer.pointerDrag, (BaseEventData) pointer, ExecuteEvents.initializePotentialDrag);
  }
}
