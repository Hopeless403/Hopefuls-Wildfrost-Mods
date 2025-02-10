// Decompiled with JetBrains decompiler
// Type: TargetingArrowSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;

public class TargetingArrowSystem : GameSystem
{
  public TargetingDisplay offensiveArrow;
  public TargetingDisplay supportiveArrow;
  public TargetingDisplay targetMulti;
  public Entity target;
  public Entity hover;
  public CardContainer snapToContainer;
  private bool active;
  private Vector3 toPosition;
  [SerializeField]
  [Range(0.0f, 1f)]
  private float lerp = 0.4f;
  private TargetingDisplay currentArrow;
  private bool offensive;

  private Vector3 toPositionTarget
  {
    get
    {
      if ((bool) (Object) this.hover)
        return this.hover.transform.position;
      return (bool) (Object) this.snapToContainer ? this.snapToContainer.transform.position : MonoBehaviourSingleton<Cursor3d>.instance.transform.position;
    }
  }

  private static bool CorrectType(Card.PlayType playType) => playType == Card.PlayType.Play;

  private void OnEnable()
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

  private void OnDisable()
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

  private void LateUpdate()
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

  private void UpdateArrow() => this.currentArrow.UpdatePosition(this.target.transform.position, this.toPosition);

  private void Show()
  {
    this.active = true;
    this.currentArrow = this.target.NeedsTarget ? (this.offensive ? this.offensiveArrow : this.supportiveArrow) : this.targetMulti;
    this.currentArrow.gameObject.SetActive(true);
    this.currentArrow.ResetStyle();
    this.toPosition = !TouchInputModule.active ? this.toPositionTarget : this.target.transform.position;
    this.currentArrow.Show(this);
  }

  private void Hide()
  {
    this.active = false;
    this.currentArrow.gameObject.SetActive(false);
    this.currentArrow.Hide();
  }

  private void EntityDrag(Entity entity)
  {
    if (!entity.inPlay || !(bool) (Object) entity || !(bool) (Object) entity.data || !TargetingArrowSystem.CorrectType(entity.data.playType))
      return;
    this.target = entity;
    this.offensive = this.target.IsOffensive();
  }

  private void EntityRelease(Entity entity)
  {
    if (!((Object) this.target == (Object) entity))
      return;
    this.target = (Entity) null;
  }

  private void EntityHover(Entity entity)
  {
    if (!this.active || !(bool) (Object) this.target || this.target.targetMode.TargetRow || this.target.data.playOnSlot)
      return;
    this.hover = entity;
    this.currentArrow.EntityHover(entity);
  }

  private void EntityUnHover(Entity entity)
  {
    if (!((Object) this.hover == (Object) entity))
      return;
    this.hover = (Entity) null;
    if (!this.active || !(bool) (Object) this.currentArrow)
      return;
    this.currentArrow.ResetStyle();
  }

  private void ContainerHover(CardContainer container)
  {
    if (!this.active || !((Object) this.target != (Object) null))
      return;
    this.currentArrow.ContainerHover(container, this);
  }

  private void ContainerUnHover(CardContainer container)
  {
    if (!((Object) this.snapToContainer == (Object) container))
      return;
    this.snapToContainer = (CardContainer) null;
    if (!this.active || !(bool) (Object) this.currentArrow)
      return;
    this.currentArrow.ResetStyle();
  }

  private void SlotHover(CardSlot slot)
  {
    if (!this.active || !(bool) (Object) this.target)
      return;
    this.currentArrow.SlotHover(slot, this);
  }

  private void SlotUnHover(CardSlot slot)
  {
    if (!((Object) this.snapToContainer == (Object) slot))
      return;
    this.snapToContainer = (CardContainer) null;
    if (!this.active || !(bool) (Object) this.currentArrow)
      return;
    this.currentArrow.ResetStyle();
  }
}
