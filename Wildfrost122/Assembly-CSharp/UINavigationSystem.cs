// Decompiled with JetBrains decompiler
// Type: UINavigationSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

#nullable disable
public class UINavigationSystem : MonoBehaviourSingleton<UINavigationSystem>
{
  [Header("Current Status")]
  public UINavigationItem currentNavigationItem;
  public List<UINavigationItem> AvailableNavigationItems = new List<UINavigationItem>();
  public List<UINavigationItem> PossibleNavigationItems = new List<UINavigationItem>();
  public List<UINavigationLayer> NavigationLayers = new List<UINavigationLayer>();
  public static UINavigationLayer ActiveNavigationLayer;
  internal UINavigationLayer lastActiveNavigationLayer;
  [Header("Settings Status")]
  public float navigationControllerDeadzone = 0.05f;
  [ReadOnly]
  public MoveDirection lastMove;
  public float navigationGridThreshold = 1.5f;
  public float minorNavigationGridThreshold = 0.25f;
  public float maxAnyItemCheckBeforeLoopMultiplier = 2.5f;
  public float anglePriority = 1f;
  public float disPriority = 1f;
  public float maxNavAngle = 45f;
  public UnityEvent OnNavigate;
  [Header("References")]
  public Cursor3d virtualCursor;
  [SerializeField]
  private CustomEventSystem eventSystem;
  [SerializeField]
  private GameObject eventSystemObj;
  private bool didNavigate;
  private Vector3 lastNavigationItemPos;
  private bool currentNavigationItemChanged = true;

  private void Start() => NavigationState.Reset();

  private void OnEnable()
  {
    global::Events.OnTransitionEnd += new UnityAction<TransitionType>(this.Events_OnTransitionEnd);
    global::Events.OnUINavigationReset += new UnityAction(this.Events_OnUINavigationReset);
    global::Events.OnEntityFlipComplete += new UnityAction<Entity>(this.Events_OnEntityFlipComplete);
  }

  private void OnDisable()
  {
    global::Events.OnTransitionEnd -= new UnityAction<TransitionType>(this.Events_OnTransitionEnd);
    global::Events.OnUINavigationReset -= new UnityAction(this.Events_OnUINavigationReset);
    global::Events.OnEntityFlipComplete -= new UnityAction<Entity>(this.Events_OnEntityFlipComplete);
  }

  private void Events_OnEntityFlipComplete(Entity entity)
  {
    if (!(bool) (UnityEngine.Object) entity || !(bool) (UnityEngine.Object) this.currentNavigationItem || !((UnityEngine.Object) entity.gameObject == (UnityEngine.Object) this.currentNavigationItem.gameObject))
      return;
    UINavigationDefaultSystem.SetStartingItem();
  }

  private void Events_OnUINavigationReset() => this.ResetState();

  private void Events_OnTransitionEnd(TransitionType transition)
  {
    UINavigationDefaultSystem.SetStartingItem(false, true);
  }

  internal void RemoveActiveLayer()
  {
    this.UnregisterNavigationLayer(UINavigationSystem.ActiveNavigationLayer);
  }

  internal void RegisterSelectable(UINavigationItem uiNavigationItem)
  {
    if (this.AvailableNavigationItems.Contains(uiNavigationItem) || this.AvailableNavigationItems.Count<UINavigationItem>((Func<UINavigationItem, bool>) (x => (UnityEngine.Object) x.gameObject == (UnityEngine.Object) uiNavigationItem.gameObject)) != 0)
      return;
    this.AvailableNavigationItems.Add(uiNavigationItem);
    if (!(bool) (UnityEngine.Object) MonoBehaviourSingleton<UINavigationSystem>.instance || !(bool) (UnityEngine.Object) MonoBehaviourSingleton<UINavigationSystem>.instance.currentNavigationItem || MonoBehaviourSingleton<UINavigationSystem>.instance.currentNavigationItem.selectionPriority != UINavigationItem.SelectionPriority.Lowest && (uiNavigationItem.selectionPriority != UINavigationItem.SelectionPriority.Highest || MonoBehaviourSingleton<UINavigationSystem>.instance.currentNavigationItem.selectionPriority == UINavigationItem.SelectionPriority.Highest))
      return;
    UINavigationDefaultSystem.SetStartingItem();
  }

  internal void UnregisterSelectable(UINavigationItem uiNavigationItem)
  {
    if (!this.AvailableNavigationItems.Contains(uiNavigationItem))
      return;
    this.AvailableNavigationItems.Remove(uiNavigationItem);
  }

  internal void RegisterNavigationLayer(UINavigationLayer navigationLayer)
  {
    this.NavigationLayers.Add(navigationLayer);
    if (!navigationLayer.isOverrideLayer)
      return;
    UINavigationSystem.ActiveNavigationLayer = navigationLayer;
  }

  internal void UnregisterNavigationLayer(UINavigationLayer navigationLayer)
  {
    if (!this.NavigationLayers.Contains(navigationLayer))
      return;
    foreach (UINavigationItem uiNavigationItem in this.AvailableNavigationItems.Where<UINavigationItem>((Func<UINavigationItem, bool>) (item => (UnityEngine.Object) item.navigationLayer == (UnityEngine.Object) navigationLayer)))
      uiNavigationItem.CheckForNavigationLayer(true);
    this.NavigationLayers.Remove(navigationLayer);
    UINavigationHistory.GoBackALayer();
    if (!navigationLayer.isOverrideLayer)
      return;
    UINavigationSystem.ActiveNavigationLayer = this.NavigationLayers.LastOrDefault<UINavigationLayer>((Func<UINavigationLayer, bool>) (x => x.isOverrideLayer));
  }

  private void Update()
  {
    if (MonoBehaviourSingleton<Cursor3d>.instance.usingMouse && (bool) (UnityEngine.Object) this.currentNavigationItem)
    {
      this.SetCurrentNavigationItem((UINavigationItem) null);
    }
    else
    {
      UINavigationLayer activeNavigationLayer = UINavigationSystem.ActiveNavigationLayer;
      if ((bool) (UnityEngine.Object) this.currentNavigationItem && (!this.AvailableNavigationItems.Contains(this.currentNavigationItem) || !this.currentNavigationItem.CheckLayer()))
        this.SetCurrentNavigationItem((UINavigationItem) null);
      if (!(bool) (UnityEngine.Object) this.currentNavigationItem && this.AvailableNavigationItems.Any<UINavigationItem>((Func<UINavigationItem, bool>) (a => (bool) (UnityEngine.Object) a && (UnityEngine.Object) a.navigationLayer == (UnityEngine.Object) activeNavigationLayer)))
        UINavigationDefaultSystem.SetStartingItem();
      else if ((bool) (UnityEngine.Object) this.currentNavigationItem)
      {
        this.CheckForNavigation();
        if ((double) Vector3.Distance(this.currentNavigationItem.Position, this.lastNavigationItemPos) > (double) Mathf.Epsilon)
          this.SetCursor();
      }
      if ((UnityEngine.Object) activeNavigationLayer != (UnityEngine.Object) this.lastActiveNavigationLayer)
        UINavigationHistory.AddLayer(activeNavigationLayer);
      foreach (UINavigationHistory.Layer layer in UINavigationHistory.layers)
      {
        if ((UnityEngine.Object) layer.navigationLayer == (UnityEngine.Object) activeNavigationLayer)
        {
          if (layer.navigationItemHistory.Count > 0)
          {
            if (!((UnityEngine.Object) layer.navigationItemHistory.Last<UINavigationItem>() != (UnityEngine.Object) this.currentNavigationItem))
              break;
          }
          layer.navigationItemHistory.Add(this.currentNavigationItem);
          break;
        }
      }
      this.lastActiveNavigationLayer = activeNavigationLayer;
    }
  }

  private void SetCursor()
  {
    VirtualPointer.Show();
    this.virtualCursor.SetPosition(this.currentNavigationItem.Position);
    this.lastNavigationItemPos = (bool) (UnityEngine.Object) this.currentNavigationItem ? this.currentNavigationItem.Position : this.lastNavigationItemPos;
  }

  internal void ResetState() => UINavigationDefaultSystem.SetStartingItem();

  private void CheckForNavigation()
  {
    if (!this.virtualCursor.showVirtualPointerState || Console.active)
      return;
    if (InputSystem.CheckLongHold())
      this.SetCurrentNavigationItem(this.GetSelectable(this.lastMove));
    int num1 = InputSystem.IsButtonPressed("Move Vertical") ? 1 : (InputSystem.IsButtonPressed("Move Vertical", false) ? -1 : 0);
    int num2 = InputSystem.IsButtonPressed("Move Horizontal") ? 1 : (InputSystem.IsButtonPressed("Move Horizontal", false) ? -1 : 0);
    if ((double) Mathf.Abs(num1) > (double) this.navigationControllerDeadzone || (double) Mathf.Abs(num2) > (double) this.navigationControllerDeadzone)
    {
      if (!this.didNavigate)
      {
        if (Mathf.Abs(num1) > Mathf.Abs(num2))
        {
          if ((double) num1 > (double) this.navigationControllerDeadzone)
            this.SetCurrentNavigationItem(this.GetSelectable(MoveDirection.Up));
          if ((double) num1 < -(double) this.navigationControllerDeadzone)
            this.SetCurrentNavigationItem(this.GetSelectable(MoveDirection.Down));
        }
        else
        {
          if ((double) num2 < -(double) this.navigationControllerDeadzone)
            this.SetCurrentNavigationItem(this.GetSelectable(MoveDirection.Left));
          if ((double) num2 > (double) this.navigationControllerDeadzone)
            this.SetCurrentNavigationItem(this.GetSelectable(MoveDirection.Right));
        }
        this.didNavigate = true;
      }
    }
    else
      this.didNavigate = false;
    if (!this.didNavigate)
      return;
    this.currentNavigationItemChanged = true;
    global::Events.InvokeUINavigation();
  }

  private UINavigationItem GetSelectable(MoveDirection moveDirection)
  {
    this.lastMove = moveDirection;
    if (this.currentNavigationItem.overrideInputs)
    {
      switch (moveDirection)
      {
        case MoveDirection.Left:
          if ((bool) (UnityEngine.Object) this.currentNavigationItem.inputLeft)
            return this.currentNavigationItem.inputLeft;
          break;
        case MoveDirection.Up:
          if ((bool) (UnityEngine.Object) this.currentNavigationItem.inputUp)
            return this.currentNavigationItem.inputUp;
          break;
        case MoveDirection.Right:
          if ((bool) (UnityEngine.Object) this.currentNavigationItem.inputRight)
            return this.currentNavigationItem.inputRight;
          break;
        case MoveDirection.Down:
          if ((bool) (UnityEngine.Object) this.currentNavigationItem.inputDown)
            return this.currentNavigationItem.inputDown;
          break;
      }
    }
    if (this.currentNavigationItem.overrideHorizontal)
    {
      switch (moveDirection)
      {
        case MoveDirection.Left:
          this.currentNavigationItem.OnHorizontalOverride?.Invoke(-1f);
          return this.currentNavigationItem;
        case MoveDirection.Right:
          this.currentNavigationItem.OnHorizontalOverride?.Invoke(1f);
          return this.currentNavigationItem;
      }
    }
    if (this.currentNavigationItem.overrideVertical)
    {
      switch (moveDirection)
      {
        case MoveDirection.Up:
          this.currentNavigationItem.OnVerticalOverride?.Invoke(1f);
          return this.currentNavigationItem;
        case MoveDirection.Down:
          this.currentNavigationItem.OnVerticalOverride?.Invoke(-1f);
          return this.currentNavigationItem;
      }
    }
    this.PossibleNavigationItems = this.AvailableNavigationItems.Where<UINavigationItem>((Func<UINavigationItem, bool>) (x => (bool) (UnityEngine.Object) x && (UnityEngine.Object) x != (UnityEngine.Object) this.currentNavigationItem && x.CheckLayer())).ToList<UINavigationItem>();
    Vector3 position = this.currentNavigationItem.Position;
    UINavigationItem selectable = this.GetSelectable(moveDirection, position);
    return !(bool) (UnityEngine.Object) selectable ? this.currentNavigationItem : selectable;
  }

  private UINavigationItem GetSelectable(MoveDirection moveDirection, Vector3 currentPosition)
  {
    UINavigationItem selectable = (UINavigationItem) null;
    switch (moveDirection)
    {
      case MoveDirection.Left:
        selectable = this.GetSelectable(currentPosition, Vector3.left, (Predicate<UINavigationItem>) (a => (double) currentPosition.x - (double) a.Position.x > (double) this.minorNavigationGridThreshold), (Predicate<UINavigationItem>) (a => (double) Mathf.Abs(a.Position.y - currentPosition.y) < (double) this.navigationGridThreshold * (double) this.maxAnyItemCheckBeforeLoopMultiplier && (double) Mathf.Abs(Vector3.Angle(Vector3.left, currentPosition.GetDirTowardsPoint(a.Position))) < (double) this.maxNavAngle));
        if (!(bool) (UnityEngine.Object) selectable && this.currentNavigationItem.canLoop)
        {
          selectable = this.GetSelectableLoop(currentPosition, Vector3.left, (Predicate<UINavigationItem>) (a => (double) Mathf.Abs(currentPosition.x - a.Position.x) > (double) this.minorNavigationGridThreshold), (Predicate<UINavigationItem>) (a => (double) Mathf.Abs(currentPosition.y - a.Position.y) < (double) this.navigationGridThreshold), (Predicate<UINavigationItem>) (a => (double) a.Position.x - (double) currentPosition.x > (double) this.minorNavigationGridThreshold));
          break;
        }
        break;
      case MoveDirection.Up:
        selectable = this.GetSelectable(currentPosition, Vector3.up, (Predicate<UINavigationItem>) (a => (double) a.Position.y - (double) currentPosition.y > (double) this.minorNavigationGridThreshold), (Predicate<UINavigationItem>) (a => (double) Mathf.Abs(a.Position.x - currentPosition.x) < (double) this.navigationGridThreshold * (double) this.maxAnyItemCheckBeforeLoopMultiplier && (double) Mathf.Abs(Vector3.Angle(Vector3.up, currentPosition.GetDirTowardsPoint(a.Position))) < (double) this.maxNavAngle));
        if (!(bool) (UnityEngine.Object) selectable && this.currentNavigationItem.canLoop)
        {
          selectable = this.GetSelectableLoop(currentPosition, Vector3.up, (Predicate<UINavigationItem>) (a => (double) Mathf.Abs(currentPosition.y - a.Position.y) > (double) this.minorNavigationGridThreshold), (Predicate<UINavigationItem>) (a => (double) Mathf.Abs(currentPosition.x - a.Position.x) < (double) this.navigationGridThreshold), (Predicate<UINavigationItem>) (a => (double) currentPosition.y - (double) a.Position.y > (double) this.minorNavigationGridThreshold));
          break;
        }
        break;
      case MoveDirection.Right:
        selectable = this.GetSelectable(currentPosition, Vector3.right, (Predicate<UINavigationItem>) (a => (double) a.Position.x - (double) currentPosition.x > (double) this.minorNavigationGridThreshold), (Predicate<UINavigationItem>) (a => (double) Mathf.Abs(a.Position.y - currentPosition.y) < (double) this.navigationGridThreshold * (double) this.maxAnyItemCheckBeforeLoopMultiplier && (double) Mathf.Abs(Vector3.Angle(Vector3.right, currentPosition.GetDirTowardsPoint(a.Position))) < (double) this.maxNavAngle));
        if (!(bool) (UnityEngine.Object) selectable && this.currentNavigationItem.canLoop)
        {
          selectable = this.GetSelectableLoop(currentPosition, Vector3.right, (Predicate<UINavigationItem>) (a => (double) Mathf.Abs(currentPosition.x - a.Position.x) > (double) this.minorNavigationGridThreshold), (Predicate<UINavigationItem>) (a => (double) Mathf.Abs(currentPosition.y - a.Position.y) < (double) this.navigationGridThreshold), (Predicate<UINavigationItem>) (a => (double) currentPosition.x - (double) a.Position.x > (double) this.minorNavigationGridThreshold));
          break;
        }
        break;
      case MoveDirection.Down:
        selectable = this.GetSelectable(currentPosition, Vector3.down, (Predicate<UINavigationItem>) (a => (double) currentPosition.y - (double) a.Position.y > (double) this.minorNavigationGridThreshold), (Predicate<UINavigationItem>) (a => (double) Mathf.Abs(a.Position.x - currentPosition.x) < (double) this.navigationGridThreshold * (double) this.maxAnyItemCheckBeforeLoopMultiplier && (double) Mathf.Abs(Vector3.Angle(Vector3.down, currentPosition.GetDirTowardsPoint(a.Position))) < (double) this.maxNavAngle));
        if (!(bool) (UnityEngine.Object) selectable && this.currentNavigationItem.canLoop)
        {
          selectable = this.GetSelectableLoop(currentPosition, Vector3.down, (Predicate<UINavigationItem>) (a => (double) Mathf.Abs(currentPosition.y - a.Position.y) > (double) this.minorNavigationGridThreshold), (Predicate<UINavigationItem>) (a => (double) Mathf.Abs(currentPosition.x - a.Position.x) < (double) this.navigationGridThreshold), (Predicate<UINavigationItem>) (a => (double) a.Position.y - (double) currentPosition.y > (double) this.minorNavigationGridThreshold));
          break;
        }
        break;
    }
    return selectable;
  }

  private UINavigationItem GetSelectable(
    Vector3 currentPosition,
    Vector3 direction,
    Predicate<UINavigationItem> directionCheck,
    Predicate<UINavigationItem> alignmentCheck)
  {
    List<UINavigationItem> list = this.PossibleNavigationItems.Where<UINavigationItem>((Func<UINavigationItem, bool>) (a => directionCheck(a) && alignmentCheck(a))).ToList<UINavigationItem>();
    return list.Any<UINavigationItem>() ? list.OrderBy<UINavigationItem, float>((Func<UINavigationItem, float>) (a => Vector3.Distance(a.Position, currentPosition).RemapProportion(0.0f, this.navigationGridThreshold, 0.0f, this.disPriority) + Mathf.Abs(Vector3.Angle(direction, currentPosition.GetDirTowardsPoint(a.Position))).RemapProportion(0.0f, this.maxNavAngle, 0.0f, this.anglePriority))).First<UINavigationItem>() : (UINavigationItem) null;
  }

  private UINavigationItem GetSelectableLoop(
    Vector3 currentPosition,
    Vector3 direction,
    Predicate<UINavigationItem> directionCheck,
    Predicate<UINavigationItem> alignmentCheck,
    Predicate<UINavigationItem> fallbackCheck)
  {
    List<UINavigationItem> list = this.PossibleNavigationItems.Where<UINavigationItem>((Func<UINavigationItem, bool>) (a => directionCheck(a) && alignmentCheck(a))).ToList<UINavigationItem>();
    if (!list.Any<UINavigationItem>())
      list = this.PossibleNavigationItems.Where<UINavigationItem>((Func<UINavigationItem, bool>) (a => fallbackCheck(a))).ToList<UINavigationItem>();
    if (list.Count <= 0)
      return (UINavigationItem) null;
    UINavigationItem selectableLoop = list.OrderBy<UINavigationItem, float>((Func<UINavigationItem, float>) (a => a.Position.DistanceTo(currentPosition))).Last<UINavigationItem>();
    if (list.Count == 1)
      return selectableLoop;
    Vector3 furthestPosition = (selectableLoop.Position - direction * this.navigationGridThreshold).WithZ(currentPosition.z);
    return list.OrderBy<UINavigationItem, float>((Func<UINavigationItem, float>) (a => Vector3.Distance(a.Position, furthestPosition).RemapProportion(0.0f, this.navigationGridThreshold, 0.0f, this.disPriority) + Mathf.Abs(Vector3.Angle(direction, furthestPosition.GetDirTowardsPoint(a.Position))).RemapProportion(0.0f, this.maxNavAngle, 0.0f, this.anglePriority))).First<UINavigationItem>();
  }

  public void SetCurrentNavigationItem(UINavigationItem navItem)
  {
    if ((bool) (UnityEngine.Object) this.currentNavigationItem)
    {
      if (((object) this.currentNavigationItem).Equals((object) navItem))
        return;
      this.eventSystem.Unhover(this.currentNavigationItem.clickHandler);
    }
    if ((bool) (UnityEngine.Object) navItem && this.AvailableNavigationItems.Any<UINavigationItem>((Func<UINavigationItem, bool>) (a => (UnityEngine.Object) a == (UnityEngine.Object) navItem)))
    {
      this.currentNavigationItem = navItem;
      UINavigationLayer activeNavigationLayer = UINavigationSystem.ActiveNavigationLayer;
      if (!(bool) (UnityEngine.Object) activeNavigationLayer || activeNavigationLayer.forceHover)
        this.eventSystem.Hover(navItem.clickHandler);
      UINavigationHistory.AddItem(navItem);
    }
    else
      this.currentNavigationItem = (UINavigationItem) null;
  }
}
