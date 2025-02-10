// Decompiled with JetBrains decompiler
// Type: CardCharmInteraction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

#nullable disable
[RequireComponent(typeof (UpgradeDisplay))]
public class CardCharmInteraction : 
  MonoBehaviourRect,
  IPointerEnterHandler,
  IEventSystemHandler,
  IPointerExitHandler
{
  [SerializeField]
  private GameObject image;
  public CardCharmDragHandler dragHandler;
  public bool canHover;
  public bool canDrag;
  private bool hover;
  private bool preHover;
  private bool press;
  private bool drag;
  public Vector2 popUpOffset = new Vector2(0.0f, -1f);
  public UnityEvent<UpgradeDisplay> onHover;
  public UnityEvent<UpgradeDisplay> onUnHover;
  public UnityEvent<UpgradeDisplay> onDrag;
  public UnityEvent<UpgradeDisplay> onDragEnd;
  private UpgradeDisplay _upgradeDisplay;

  private UpgradeDisplay upgradeDisplay
  {
    get => this._upgradeDisplay ?? (this._upgradeDisplay = this.GetComponent<UpgradeDisplay>());
  }

  private bool DragHandlerDragging
  {
    get => (bool) (Object) this.dragHandler && this.dragHandler.IsDragging;
  }

  public void LateUpdate()
  {
    if (!this.press)
    {
      if (this.hover && InputSystem.IsSelectPressed())
      {
        this.press = true;
        if (this.preHover)
          this.Press();
      }
    }
    else if ((MonoBehaviourSingleton<Cursor3d>.instance.usingTouch ? (InputSystem.IsSelectReleased() ? 1 : 0) : (InputSystem.IsDynamicSelectReleased(this.drag) ? 1 : 0)) != 0)
    {
      this.Release();
      this.press = false;
      if (MonoBehaviourSingleton<Cursor3d>.instance.usingTouch)
        this.StartCoroutine(this.UpdateInputSystem());
    }
    this.preHover = this.hover;
  }

  private IEnumerator UpdateInputSystem()
  {
    yield return (object) null;
    if (this.upgradeDisplay is CardCharm upgradeDisplay)
      upgradeDisplay.StopWobble();
    yield return (object) null;
    global::Events.InvokeUpdateInputSystem(true);
  }

  public void OnPointerEnter(PointerEventData eventData) => this.Hover();

  public void OnPointerExit(PointerEventData eventData)
  {
    if (this.hover && this.press && !this.drag && MonoBehaviourSingleton<Cursor3d>.instance.usingTouch && (bool) (Object) this.dragHandler)
      this.StartDrag();
    else
      this.UnHover();
  }

  private void Press()
  {
    if (!this.canDrag || !this.hover)
      return;
    this.StartDrag();
  }

  private void Release()
  {
    if (!this.drag)
      return;
    this.StopDrag();
  }

  private void Hover()
  {
    if (!this.canHover || this.drag || this.DragHandlerDragging)
      return;
    if (!this.hover)
    {
      LeanTween.cancel(this.image);
      LeanTween.scale(this.image, Vector3.one * 1.1f, 0.33f).setEase(LeanTweenType.easeOutBack);
    }
    this.hover = true;
    this.onHover?.Invoke(this.upgradeDisplay);
    global::Events.InvokeUpgradeHover(this.upgradeDisplay);
    this.PopUpDescription();
  }

  public void UnHover()
  {
    if (!this.canHover || !this.hover)
      return;
    LeanTween.cancel(this.image);
    LeanTween.scale(this.image, Vector3.one, 0.2f).setEase(LeanTweenType.easeOutQuart);
    this.hover = false;
    this.onUnHover?.Invoke(this.upgradeDisplay);
    this.HideDescription();
  }

  private void StartDrag()
  {
    Debug.Log((object) ("Dragging Card Charm [" + this.name + "]"));
    this.drag = true;
    this.onDrag?.Invoke(this.upgradeDisplay);
    this.UnHover();
    this.upgradeDisplay.CanRaycast = false;
  }

  private void StopDrag()
  {
    Debug.Log((object) ("Dropping Card Charm [" + this.name + "]"));
    this.onDragEnd?.Invoke(this.upgradeDisplay);
    this.drag = false;
    this.upgradeDisplay.CanRaycast = true;
  }

  public void CancelDrag()
  {
    Debug.Log((object) ("Cancelling Card Charm Drag [" + this.name + "]"));
    this.drag = false;
    this.upgradeDisplay.CanRaycast = true;
  }

  public void PopUpDescription()
  {
    CardPopUp.AssignTo(this.rectTransform, this.popUpOffset.x, this.popUpOffset.y);
    CardPopUp.AddPanel(this.upgradeDisplay.data.name, this.upgradeDisplay.data.title, this.upgradeDisplay.data.text);
  }

  public void HideDescription() => CardPopUp.RemovePanel(this.upgradeDisplay.data.name);
}
