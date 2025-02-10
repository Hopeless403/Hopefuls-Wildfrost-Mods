// Decompiled with JetBrains decompiler
// Type: TargetingArrowSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class TargetingArrowSystem : GameSystem
{
  public TargetingDisplay offensiveArrow;
  public TargetingDisplay supportiveArrow;
  public TargetingDisplay targetMulti;
  public Entity target;
  public Entity hover;
  public CardContainer snapToContainer;
  public bool active;
  public Vector3 toPosition;
  [SerializeField]
  [Range(0.0f, 1f)]
  public float lerp = 0.4f;
  public TargetingDisplay currentArrow;
  public bool offensive;

  public Vector3 toPositionTarget
  {
    get
    {
      if ((bool) (Object) this.hover)
        return this.hover.transform.position;
      return (bool) (Object) this.snapToContainer ? this.snapToContainer.transform.position : MonoBehaviourSingleton<Cursor3d>.instance.transform.position;
    }
  }

  public static bool CorrectType(Card.PlayType playType) => playType == Card.PlayType.Play;

  public void OnEnable()
  {
    global::Events.OnEntityDrag += new UnityAction<Entity>(this.EntityDrag);
    global::Events.OnEntityRelease += new UnityAction<Entity>(this.EntityRelease);
    global::Events.OnEntityHover += new UnityAction<Entity>(this.EntityHover);
    global::Events.OnEntityUnHover += new UnityAction<Entity>(this.EntityUnHover);
    global::Events.OnContainerHover += new UnityAction<CardContainer>(this.ContainerHover);
    global::Events.OnContainerUnHover += new UnityAction<CardContainer>(this.ContainerUnHover);
    global::Events.OnSlotHover += new UnityAction<CardSlot>(this.SlotHover);
    global::Events.OnSlotUnHover += new UnityAction<CardSlot>(this.SlotUnHover);
  }

  public void OnDisable()
  {
    global::Events.OnEntityDrag -= new UnityAction<Entity>(this.EntityDrag);
    global::Events.OnEntityRelease -= new UnityAction<Entity>(this.EntityRelease);
    global::Events.OnEntityHover -= new UnityAction<Entity>(this.EntityHover);
    global::Events.OnEntityUnHover -= new UnityAction<Entity>(this.EntityUnHover);
    global::Events.OnContainerHover -= new UnityAction<CardContainer>(this.ContainerHover);
    global::Events.OnContainerUnHover -= new UnityAction<CardContainer>(this.ContainerUnHover);
    global::Events.OnSlotHover -= new UnityAction<CardSlot>(this.SlotHover);
    global::Events.OnSlotUnHover -= new UnityAction<CardSlot>(this.SlotUnHover);
  }

  public void LateUpdate()
  {
    if (!this.active && (bool) (Object) this.target)
      this.Show();
    if (this.active && !(bool) (Object) this.target)
      this.Hide();
    if (!this.active)
      return;
    this.UpdateArrow();
    this.toPosition = Delta.Lerp(this.toPosition, this.toPositionTarget, this.lerp, Time.deltaTime);
  }

  public void UpdateArrow()
  {
    this.currentArrow.UpdatePosition(this.target.transform.position, this.toPosition);
  }

  public void Show()
  {
    this.active = true;
    this.currentArrow = this.target.NeedsTarget ? (this.offensive ? this.offensiveArrow : this.supportiveArrow) : this.targetMulti;
    this.currentArrow.gameObject.SetActive(true);
    this.currentArrow.ResetStyle();
    this.toPosition = !TouchInputModule.active ? this.toPositionTarget : this.target.transform.position;
    this.currentArrow.Show(this);
  }

  public void Hide()
  {
    this.active = false;
    this.currentArrow.gameObject.SetActive(false);
    this.currentArrow.Hide();
  }

  public void EntityDrag(Entity entity)
  {
    if (!entity.inPlay || !(bool) (Object) entity || !(bool) (Object) entity.data || !TargetingArrowSystem.CorrectType(entity.data.playType))
      return;
    this.target = entity;
    this.offensive = this.target.IsOffensive();
  }

  public void EntityRelease(Entity entity)
  {
    if (!((Object) this.target == (Object) entity))
      return;
    this.target = (Entity) null;
  }

  public void EntityHover(Entity entity)
  {
    if (!this.active || !(bool) (Object) this.target || this.target.targetMode.TargetRow || this.target.data.playOnSlot)
      return;
    this.hover = entity;
    this.currentArrow.EntityHover(entity);
  }

  public void EntityUnHover(Entity entity)
  {
    if (!((Object) this.hover == (Object) entity))
      return;
    this.hover = (Entity) null;
    if (!this.active || !(bool) (Object) this.currentArrow)
      return;
    this.currentArrow.ResetStyle();
  }

  public void ContainerHover(CardContainer container)
  {
    if (!this.active || !((Object) this.target != (Object) null))
      return;
    this.currentArrow.ContainerHover(container, this);
  }

  public void ContainerUnHover(CardContainer container)
  {
    if (!((Object) this.snapToContainer == (Object) container))
      return;
    this.snapToContainer = (CardContainer) null;
    if (!this.active || !(bool) (Object) this.currentArrow)
      return;
    this.currentArrow.ResetStyle();
  }

  public void SlotHover(CardSlot slot)
  {
    if (!this.active || !(bool) (Object) this.target)
      return;
    this.currentArrow.SlotHover(slot, this);
  }

  public void SlotUnHover(CardSlot slot)
  {
    if (!((Object) this.snapToContainer == (Object) slot))
      return;
    this.snapToContainer = (CardContainer) null;
    if (!this.active || !(bool) (Object) this.currentArrow)
      return;
    this.currentArrow.ResetStyle();
  }
}
