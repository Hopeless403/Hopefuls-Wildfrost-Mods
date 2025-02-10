// Decompiled with JetBrains decompiler
// Type: CardController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using UnityEngine;

#nullable disable
public class CardController : MonoBehaviour
{
  public Character owner;
  [ReadOnly]
  public GameObject hover;
  [ReadOnly]
  public Entity hoverEntity;
  [ReadOnly]
  public Entity dragging;
  [ReadOnly]
  public CardContainer hoverContainer;
  [ReadOnly]
  public CardSlot hoverSlot;
  public bool canHoverWhileDragging = true;
  [Range(0.0f, 1f)]
  public float dragLerp = 0.25f;
  public float hoverZ = -0.2f;
  public float dragZ = -1f;
  [Header("Hover Tween")]
  public float cardHoverScale = 1.33f;
  public LeanTweenType cardHoverEase = LeanTweenType.easeOutBack;
  public float cardHoverEaseDur = 0.33f;
  public LeanTweenType cardUnHoverEase = LeanTweenType.easeOutBack;
  public float cardUnHoverEaseDur = 0.33f;
  [Header("Draw Order")]
  public int hoverDrawOrder = 100;
  public int dragDrawOrder = 200;
  [Header("Interactables")]
  public bool interactWithInPlay = true;
  public bool interactWithNotInPlay = true;
  public bool canPress = true;
  public bool canPressAndHoverInSameFrame;
  public Vector3 draggingPositionPre;
  public int draggingLayerPre;
  public Entity pressEntity;
  public bool press;

  public static CardController Find(GameObject gameObject)
  {
    return gameObject.GetComponentInParent<CardController>();
  }

  public virtual bool AllowDynamicSelectRelease => InputSystem.AllowDynamicSelectRelease;

  public Vector3 CardHoverScale
  {
    get => new Vector3(this.cardHoverScale * 1f, this.cardHoverScale * 1f, 1f);
  }

  public virtual void Update()
  {
    if (!this.press)
    {
      if (this.canPress && InputSystem.IsSelectPressed())
      {
        this.press = true;
        if (this.canPressAndHoverInSameFrame || !(bool) (Object) this.hoverEntity || this.hoverEntity.display.hover.WasHovering)
        {
          this.pressEntity = this.hoverEntity;
          this.Press();
          if ((bool) (Object) this.pressEntity)
            Events.InvokeEntitySelect(this.pressEntity);
        }
      }
    }
    else if (InputSystem.IsDynamicSelectReleased(this.AllowDynamicSelectRelease && (bool) (Object) this.dragging))
    {
      this.Release();
      this.pressEntity = (Entity) null;
      this.press = false;
    }
    if (!(bool) (Object) this.dragging)
      return;
    this.DragUpdate();
  }

  public void Enable() => this.enabled = true;

  public void OnEnable() => Events.InvokeCardControllerEnabled(this);

  public void Disable()
  {
    this.enabled = false;
    this.Release();
    this.UnHover();
  }

  public void OnDisable() => Events.InvokeCardControllerDisabled(this);

  public virtual void Press()
  {
  }

  public virtual void Release()
  {
  }

  public bool TryDrag(Entity entity)
  {
    if (!Events.CheckEntityDrag(entity))
      return false;
    this.Drag(entity);
    return true;
  }

  public void Drag(Entity entity)
  {
    this.dragging = entity;
    this.draggingLayerPre = this.dragging.gameObject.layer;
    this.dragging.gameObject.layer = LayerMask.NameToLayer("Default");
    entity.dragging = true;
    this.draggingPositionPre = this.dragging.transform.position;
    if (this.dragDrawOrder != 0)
      entity.DrawOrder = this.dragDrawOrder;
    Events.InvokeEntityDrag(entity);
  }

  public virtual void DragEnd()
  {
    Events.InvokeEntityRelease(this.dragging);
    this.dragging.gameObject.layer = this.draggingLayerPre;
    this.dragging.dragging = false;
    this.dragging = (Entity) null;
    this.press = false;
  }

  public virtual void DragUpdate()
  {
    this.DragUpdatePosition();
    Wobbler wobbler = this.dragging.wobbler;
    if (!(bool) (Object) wobbler)
      return;
    Vector3 position = this.dragging.transform.position;
    Vector3 movement = position - this.draggingPositionPre;
    wobbler.Wobble(movement);
    this.draggingPositionPre = position;
  }

  public virtual void DragCancel()
  {
    this.DragEnd();
    this.UnHover(this.dragging);
  }

  public virtual bool CanUseOn(Entity entity, Entity target)
  {
    return (bool) (Object) entity && (bool) (Object) target && entity.data.playType == Card.PlayType.Play && !entity.targetMode.TargetRow && (entity.data.canPlayOnBoard && Battle.IsOnBoard(target) || entity.data.canPlayOnHand && target.containers.Contains<CardContainer>(entity.owner?.handContainer)) && (entity.data.canPlayOnFriendly && (Object) entity.owner == (Object) target.owner || entity.data.canPlayOnEnemy && (Object) entity.owner != (Object) target.owner) && entity.CanPlayOn(target);
  }

  public Vector3 GetDragPosition()
  {
    return (Cursor3d.Position - (this.dragging.offset.position - this.dragging.transform.position)).WithZ(this.dragZ);
  }

  public virtual void DragUpdatePosition()
  {
    this.dragging.transform.position = Delta.Lerp(this.dragging.transform.position, this.GetDragPosition(), this.dragLerp, Time.deltaTime);
  }

  public void Hover(Entity entity)
  {
    if ((bool) (Object) this.dragging && (!this.canHoverWhileDragging || !this.CanUseOn(this.dragging, entity)) || entity.StillExists() && (!entity.inPlay || !this.interactWithInPlay) && (entity.inPlay || !this.interactWithNotInPlay))
      return;
    if ((bool) (Object) this.hoverEntity && (Object) this.dragging != (Object) this.hoverEntity)
      this.UnHover(this.hoverEntity);
    if (!(bool) (Object) entity || !((Object) entity != (Object) this.dragging))
      return;
    this.hoverEntity = entity;
    this.TweenHover(entity);
    Events.InvokeEntityHover(entity);
  }

  public void UnHover(Entity entity)
  {
    if ((bool) (Object) this.dragging && !this.canHoverWhileDragging)
      return;
    if ((Object) this.hoverEntity == (Object) entity)
    {
      this.hoverEntity = (Entity) null;
      Events.InvokeEntityUnHover(entity);
    }
    if (!((Object) this.dragging != (Object) entity))
      return;
    this.TweenUnHover(entity);
  }

  public void UnHover()
  {
    if (!(bool) (Object) this.hoverEntity)
      return;
    this.UnHover(this.hoverEntity);
  }

  public void HoverContainer(CardContainer container)
  {
    this.UnHoverContainer();
    this.hoverContainer = container;
    Events.InvokeContainerHover(container);
  }

  public void UnHoverContainer()
  {
    if (!(bool) (Object) this.hoverContainer)
      return;
    Events.InvokeContainerUnHover(this.hoverContainer);
    this.hoverContainer = (CardContainer) null;
  }

  public void HoverSlot(CardSlot slot)
  {
    if ((bool) (Object) this.dragging && !this.dragging.CanPlayOn((CardContainer) slot))
      return;
    this.UnHoverSlot();
    this.hoverSlot = slot;
    Events.InvokeSlotHover(slot);
  }

  public void UnHoverSlot()
  {
    if (!(bool) (Object) this.hoverSlot)
      return;
    Events.InvokeSlotUnHover(this.hoverSlot);
    this.hoverSlot = (CardSlot) null;
  }

  public void TweenHover(
    Entity entity,
    bool doScale = true,
    bool doMove = true,
    bool doRotate = true,
    bool doDrawOrder = true)
  {
    GameObject gameObject = entity.offset.gameObject;
    LeanTween.cancel(gameObject);
    if (doScale)
      LeanTween.scale(gameObject, this.CardHoverScale, this.cardHoverEaseDur).setEase(this.cardHoverEase);
    if (doMove)
    {
      float y = 0.0f;
      Vector3 v = new Vector3(0.0f, y, 0.0f);
      if (entity.containers.Length != 0)
      {
        foreach (CardContainer container in entity.containers)
        {
          y -= container.GetChildPosition(entity).y / entity.transform.localScale.y;
          v += container.childHoverOffset;
        }
        v /= (float) entity.actualContainers.Count;
      }
      LeanTween.moveLocal(gameObject, v.WithZ(this.hoverZ), this.cardHoverEaseDur * 1.5f).setEase(LeanTweenType.easeOutQuart);
    }
    if (doRotate)
      LeanTween.rotateZ(gameObject, 0.0f, this.cardHoverEaseDur * 1.5f).setEase(LeanTweenType.easeOutQuart);
    if (doDrawOrder && this.hoverDrawOrder != 0)
      entity.DrawOrder = this.hoverDrawOrder;
    if (!(bool) (Object) entity.display || !(bool) (Object) entity.display.hover)
      return;
    entity.display.hover.hovering = true;
  }

  public void TweenUnHover(
    Entity entity,
    bool retainScale = false,
    bool retainPosition = false,
    bool retainRotation = false,
    bool retainDrawOrder = false)
  {
    GameObject gameObject = entity.offset.gameObject;
    LeanTween.cancel(gameObject);
    if (!retainScale)
      LeanTween.scale(gameObject, Vector3.one, this.cardUnHoverEaseDur).setEase(this.cardUnHoverEase);
    if (!retainPosition)
      LeanTween.moveLocal(gameObject, Vector3.zero, this.cardUnHoverEaseDur).setEase(this.cardUnHoverEase);
    if (!retainRotation)
      LeanTween.rotateLocal(gameObject, Vector3.zero, this.cardUnHoverEaseDur).setEase(this.cardUnHoverEase);
    if (!retainDrawOrder)
      entity.ResetDrawOrder();
    if (!(bool) (Object) entity.display || !(bool) (Object) entity.display.hover)
      return;
    entity.display.hover.hovering = false;
  }
}
