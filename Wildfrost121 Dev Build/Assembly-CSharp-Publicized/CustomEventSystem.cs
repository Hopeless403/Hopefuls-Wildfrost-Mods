// Decompiled with JetBrains decompiler
// Type: CustomEventSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.EventSystems;

#nullable disable
public class CustomEventSystem : MonoBehaviour
{
  [SerializeField]
  public GameObject current;
  [SerializeField]
  public GameObject press;
  public readonly PointerEventData buttonData = new PointerEventData((EventSystem) null);

  public void Update()
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

  public void Press(GameObject obj)
  {
    this.press = obj;
    ExecuteEvents.ExecuteHierarchy<IPointerDownHandler>(obj, (BaseEventData) this.buttonData, ExecuteEvents.pointerDownHandler);
  }

  public void Release(GameObject obj)
  {
    ExecuteEvents.ExecuteHierarchy<IPointerUpHandler>(obj, (BaseEventData) this.buttonData, ExecuteEvents.pointerUpHandler);
    if ((bool) (Object) obj && (bool) (Object) this.current && ((object) obj).Equals((object) this.current))
      ExecuteEvents.ExecuteHierarchy<IPointerClickHandler>(obj, (BaseEventData) this.buttonData, ExecuteEvents.pointerClickHandler);
    this.press = (GameObject) null;
  }
}
