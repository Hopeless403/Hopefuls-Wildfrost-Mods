// Decompiled with JetBrains decompiler
// Type: CardControllerBattle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using UnityEngine;

public class CardControllerBattle : CardController
{
  public UINavigationItem useOnHandAnchor;

  protected override void Press()
  {
    if (!(bool) (Object) this.pressEntity || !((Object) this.pressEntity.owner == (Object) this.owner))
      return;
    Debug.Log((object) ("Pressing [" + this.pressEntity.name + "]"));
    if (!this.TryDrag(this.pressEntity))
      return;
    this.UnHover(this.pressEntity);
    NavigationState.Start((INavigationState) new NavigationStateCard(this.pressEntity));
  }

  protected override void DragUpdatePosition()
  {
    Vector3 target = this.GetDragPosition();
    if ((bool) (Object) this.hoverContainer && this.hoverContainer.canBePlacedOn && (Object) this.hoverContainer == (Object) this.owner.discardContainer && this.dragging.CanRecall())
    {
      this.dragging.transform.position = Delta.Lerp(this.dragging.transform.position, this.hoverContainer.transform.position - Vector3.Scale(this.dragging.offset.localPosition, this.dragging.transform.localScale), this.dragLerp, Time.deltaTime);
    }
    else
    {
      if (!(bool) (Object) this.dragging.data)
        return;
      if (this.dragging.data.playType == Card.PlayType.Play)
      {
        if (!this.dragging.NeedsTarget)
        {
          if ((bool) (Object) this.hoverContainer && this.dragging.containers.Length != 0 && (Object) this.hoverContainer == (Object) this.dragging.containers[0])
          {
            Vector3 positionFromContainers = this.dragging.GetPositionFromContainers();
            target = positionFromContainers + Vector3.ClampMagnitude(target - positionFromContainers, 0.2f);
          }
          this.dragging.transform.position = Delta.Lerp(this.dragging.transform.position, target, this.dragLerp, Time.deltaTime);
          return;
        }
        if (this.dragging.NeedsTarget)
        {
          Vector3 vector3 = this.dragging.GetPositionFromContainers();
          if ((!this.dragging.targetMode.TargetRow || !(bool) (Object) this.hoverContainer || !this.hoverContainer.canPlayOn) && (bool) (Object) this.hoverEntity && (Object) this.hoverEntity != (Object) this.dragging && this.hoverEntity.InHand())
          {
            Vector3 position = this.useOnHandAnchor.transform.position;
            vector3 = position.WithX((float) (((double) position.x + (double) target.x) / 2.0));
          }
          if (this.dragging.data.playOnSlot && this.dragging.CanPlayOn((CardContainer) this.hoverSlot))
          {
            Entity top = this.hoverSlot.GetTop();
            Dictionary<Entity, List<CardSlot>> shoveData;
            if (top != null && ShoveSystem.CanShove(top, this.dragging, out shoveData))
              ShoveSystem.ShowShove(this.hoverSlot, shoveData);
          }
          this.dragging.transform.position = Delta.Lerp(this.dragging.transform.position, vector3 + Vector3.ClampMagnitude(target - vector3, 0.2f), this.dragLerp, Time.deltaTime);
          return;
        }
      }
      if (ShoveSystem.Active)
        target = ShoveSystem.Position;
      else if (this.dragging.data.playType == Card.PlayType.Place && (bool) (Object) this.hoverSlot && (Object) ShoveSystem.Slot != (Object) this.hoverSlot && this.hoverSlot.canBePlacedOn && (Object) this.hoverSlot.owner == (Object) this.dragging.owner)
      {
        if (this.hoverSlot.Count < this.hoverSlot.max || this.dragging.actualContainers.Contains((CardContainer) this.hoverSlot))
        {
          target = this.hoverSlot.transform.position - Vector3.Scale(this.dragging.offset.localPosition, this.dragging.transform.localScale);
        }
        else
        {
          Dictionary<Entity, List<CardSlot>> shoveData;
          if (ShoveSystem.CanShove(this.hoverSlot.GetTop(), this.dragging, out shoveData))
          {
            target = this.hoverSlot.transform.position - Vector3.Scale(this.dragging.offset.localPosition, this.dragging.transform.localScale);
            ShoveSystem.ShowShove(this.hoverSlot, shoveData);
          }
        }
      }
      this.dragging.transform.position = Delta.Lerp(this.dragging.transform.position, target, this.dragLerp, Time.deltaTime);
    }
  }

  public override void DragCancel()
  {
    this.dragging.TweenToContainer();
    this.TweenUnHover(this.dragging);
    base.DragCancel();
  }

  protected override void DragEnd()
  {
    base.DragEnd();
    NavigationState.BackToPreviousState();
  }

  protected override void Release()
  {
    if (!(bool) (Object) this.dragging)
      return;
    bool retainPosition = false;
    bool retainRotation = false;
    bool retainScale = false;
    bool retainDrawOrder = false;
    if (this.enabled)
    {
      if (InputSwitcher.justSwitched)
        this.dragging.TweenToContainer();
      else if ((bool) (Object) this.hoverContainer && this.hoverContainer.canBePlacedOn && (Object) this.hoverContainer == (Object) this.owner.discardContainer && (Object) this.dragging.owner == (Object) this.owner)
      {
        if (this.dragging.CanRecall())
        {
          ActionMove action = new ActionMove(this.dragging, new CardContainer[1]
          {
            this.hoverContainer
          });
          if (Events.CheckAction((PlayAction) action))
          {
            Events.InvokeDiscard(this.dragging);
            if (Battle.IsOnBoard(this.dragging))
              this.owner.freeAction = true;
            ActionQueue.Add((PlayAction) action);
            ActionQueue.Add((PlayAction) new ActionEndTurn(this.owner));
            this.enabled = false;
            retainDrawOrder = true;
          }
        }
        this.hoverContainer.UnHover();
      }
      else
      {
        switch (this.dragging.data.playType)
        {
          case Card.PlayType.Play:
            if (!this.dragging.NeedsTarget)
            {
              if (!(bool) (Object) this.hoverContainer || !this.dragging.InContainer(this.hoverContainer))
              {
                ActionTrigger action = new ActionTrigger(this.dragging, this.owner.entity);
                if (Events.CheckAction((PlayAction) action))
                {
                  ActionQueue.Add((PlayAction) action);
                  ActionQueue.Add((PlayAction) new ActionReduceUses(this.dragging));
                  ActionQueue.Add((PlayAction) new ActionResetOffset(this.dragging));
                  ActionQueue.Add((PlayAction) new ActionEndTurn(this.owner));
                  this.enabled = false;
                  retainRotation = true;
                  retainDrawOrder = true;
                  this.dragging.RemoveFromContainers();
                  break;
                }
                break;
              }
              break;
            }
            if (this.dragging.data.playOnSlot)
            {
              CardContainer cardContainer = this.dragging.targetMode.TargetRow ? this.hoverContainer : (CardContainer) this.hoverSlot;
              if (this.dragging.CanPlayOn(cardContainer))
              {
                ActionTriggerAgainst action = new ActionTriggerAgainst(this.dragging, this.owner.entity, (Entity) null, cardContainer);
                if (Events.CheckAction((PlayAction) action))
                {
                  if (ShoveSystem.Active)
                    ShoveSystem.Fix = true;
                  ActionQueue.Add((PlayAction) action);
                  ActionQueue.Add((PlayAction) new ActionReduceUses(this.dragging));
                  ActionQueue.Add((PlayAction) new ActionResetOffset(this.dragging));
                  ActionQueue.Add((PlayAction) new ActionEndTurn(this.owner));
                  this.enabled = false;
                  retainPosition = true;
                  retainRotation = true;
                  retainDrawOrder = true;
                  break;
                }
                break;
              }
              break;
            }
            if (this.dragging.targetMode.TargetRow)
            {
              if (this.dragging.CanPlayOn(this.hoverContainer))
              {
                ActionTriggerAgainst action = new ActionTriggerAgainst(this.dragging, this.owner.entity, (Entity) null, this.hoverContainer);
                if (Events.CheckAction((PlayAction) action))
                {
                  ActionQueue.Add((PlayAction) action);
                  ActionQueue.Add((PlayAction) new ActionReduceUses(this.dragging));
                  ActionQueue.Add((PlayAction) new ActionResetOffset(this.dragging));
                  ActionQueue.Add((PlayAction) new ActionEndTurn(this.owner));
                  this.enabled = false;
                  retainPosition = true;
                  retainRotation = true;
                  retainDrawOrder = true;
                  break;
                }
                break;
              }
              break;
            }
            if ((bool) (Object) this.hoverEntity && (Object) this.hoverEntity != (Object) this.dragging)
            {
              ActionTriggerAgainst action = new ActionTriggerAgainst(this.dragging, this.owner.entity, this.hoverEntity, (CardContainer) null);
              if (Events.CheckAction((PlayAction) action))
              {
                ActionQueue.Add((PlayAction) action);
                ActionQueue.Add((PlayAction) new ActionReduceUses(this.dragging));
                ActionQueue.Add((PlayAction) new ActionResetOffset(this.dragging));
                ActionQueue.Add((PlayAction) new ActionEndTurn(this.owner));
                this.enabled = false;
                retainPosition = true;
                retainRotation = true;
                retainDrawOrder = true;
                break;
              }
              break;
            }
            break;
          case Card.PlayType.Place:
            if ((bool) (Object) this.hoverSlot && !this.dragging.actualContainers.Contains((CardContainer) this.hoverSlot) && this.hoverSlot.canBePlacedOn && (Object) this.hoverSlot.owner == (Object) this.dragging.owner)
            {
              if (this.hoverSlot.Count < this.hoverSlot.max)
              {
                ActionMove action = new ActionMove(this.dragging, new CardContainer[1]
                {
                  (CardContainer) this.hoverSlot
                });
                if (Events.CheckAction((PlayAction) action))
                {
                  bool flag = Battle.IsOnBoard(this.dragging) && Battle.IsOnBoard(this.hoverSlot.Group);
                  Events.InvokeEntityPlace(this.dragging, new CardContainer[1]
                  {
                    (CardContainer) this.hoverSlot
                  }, (flag ? 1 : 0) != 0);
                  ActionQueue.Add((PlayAction) action);
                  ActionQueue.Add((PlayAction) new ActionEndTurn(this.owner));
                  if (flag)
                    this.owner.freeAction = true;
                  this.enabled = false;
                  break;
                }
                break;
              }
              Dictionary<Entity, List<CardSlot>> shoveData;
              if (ShoveSystem.CanShove(this.hoverSlot.GetTop(), this.dragging, out shoveData))
              {
                ActionMove action = new ActionMove(this.dragging, new CardContainer[1]
                {
                  (CardContainer) this.hoverSlot
                });
                if (Events.CheckAction((PlayAction) action))
                {
                  bool flag = Battle.IsOnBoard(this.dragging) && Battle.IsOnBoard(this.hoverSlot.Group);
                  ShoveSystem.Fix = true;
                  Events.InvokeEntityPlace(this.dragging, new CardContainer[1]
                  {
                    (CardContainer) this.hoverSlot
                  }, (flag ? 1 : 0) != 0);
                  ActionQueue.Add((PlayAction) new ActionShove(shoveData));
                  ActionQueue.Add((PlayAction) action);
                  ActionQueue.Add((PlayAction) new ActionEndTurn(this.owner));
                  if (flag)
                    this.owner.freeAction = true;
                  this.enabled = false;
                  break;
                }
                break;
              }
              break;
            }
            break;
        }
      }
      if (ActionQueue.Empty)
        this.dragging.TweenToContainer();
    }
    this.TweenUnHover(this.dragging, retainScale, retainPosition, retainRotation, retainDrawOrder);
    this.DragEnd();
    this.UnHover();
  }
}
