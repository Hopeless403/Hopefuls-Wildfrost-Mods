// Decompiled with JetBrains decompiler
// Type: CustomEventSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.EventSystems;

#nullable disable
public class CustomEventSystem : MonoBehaviour
{
  [SerializeField]
  private GameObject current;
  [SerializeField]
  private GameObject press;
  private readonly PointerEventData buttonData = new PointerEventData((EventSystem) null);

  private void Update()
  {
    if (!(bool) (Object) this.press)
    {
      if (!InputSystem.IsSelectPressed() || !(bool) (Object) this.current)
        return;
      this.Press(this.current);
    }
    else
    {
      if (InputSystem.IsSelectHeld())
        return;
      this.Release(this.press);
    }
  }

  public void Hover(GameObject obj)
  {
    this.current = obj;
    ExecuteEvents.ExecuteHierarchy<IPointerEnterHandler>(obj, (BaseEventData) this.buttonData, ExecuteEvents.pointerEnterHandler);
  }

  public void Unhover(GameObject obj)
  {
    if ((bool) (Object) this.current && ((object) this.current).Equals((object) obj))
      this.current = (GameObject) null;
    ExecuteEvents.ExecuteHierarchy<IPointerExitHandler>(obj, (BaseEventData) this.buttonData, ExecuteEvents.pointerExitHandler);
  }

  private void Press(GameObject obj)
  {
    this.press = obj;
    ExecuteEvents.ExecuteHierarchy<IPointerDownHandler>(obj, (BaseEventData) this.buttonData, ExecuteEvents.pointerDownHandler);
  }

  private void Release(GameObject obj)
  {
    ExecuteEvents.ExecuteHierarchy<IPointerUpHandler>(obj, (BaseEventData) this.buttonData, ExecuteEvents.pointerUpHandler);
    if ((bool) (Object) obj && (bool) (Object) this.current && ((object) obj).Equals((object) this.current))
      ExecuteEvents.ExecuteHierarchy<IPointerClickHandler>(obj, (BaseEventData) this.buttonData, ExecuteEvents.pointerClickHandler);
    this.press = (GameObject) null;
  }
}
