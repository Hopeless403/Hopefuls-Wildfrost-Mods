// Decompiled with JetBrains decompiler
// Type: TouchHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.EventSystems;

#nullable disable
public class TouchHandler : MonoBehaviour
{
  [SerializeField]
  public bool hoverBeforePress = true;

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
