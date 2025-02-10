// Decompiled with JetBrains decompiler
// Type: CardCharmDragHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using Dead;
using FMODUnity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CardCharmDragHandler : MonoBehaviour
{
  [SerializeField]
  private bool canDragMidBattle = true;
  [SerializeField]
  private EventReference denySfxEvent;
  [SerializeField]
  private CardContainer[] assignmentContainers;
  [SerializeField]
  private CardController cardController;
  [SerializeField]
  private UpgradeHolder dragHolder;
  [SerializeField]
  private UnityEvent onAssign;
  [SerializeField]
  private AssignCharmSequence assignSequence;
  [SerializeField]
  private bool instantAssign = true;
  private UpgradeDisplay dragging;
  private UpgradeHolder preHolder;
  private int preIndex;
  private Entity hoverEntity;
  private List<Entity> eligibleCards;
  private List<Entity> ineligibleCards;
  private readonly Routine.Clump flipClump = new Routine.Clump();

  public bool IsDragging { get; private set; }

  private void OnEnable()
  {
    global::Events.OnEntityHover += new UnityAction<Entity>(this.EntityHover);
    global::Events.OnEntityUnHover += new UnityAction<Entity>(this.EntityUnHover);
  }

  private void OnDisable()
  {
    global::Events.OnEntityHover -= new UnityAction<Entity>(this.EntityHover);
    global::Events.OnEntityUnHover -= new UnityAction<Entity>(this.EntityUnHover);
    this.StopAllCoroutines();
  }

  private void LateUpdate()
  {
    if (!this.IsDragging)
      return;
    this.UpdatePosition();
    if (!InputSystem.IsButtonPressed("Back"))
      return;
    this.CancelDrag();
  }

  private void UpdatePosition()
  {
    if (MonoBehaviourSingleton<Cursor3d>.instance.usingMouse)
    {
      this.transform.position = Cursor3d.Position;
    }
    else
    {
      UINavigationItem currentNavigationItem = MonoBehaviourSingleton<UINavigationSystem>.instance.currentNavigationItem;
      if (currentNavigationItem == null)
        return;
      this.transform.position = currentNavigationItem.Position.WithZ(Cursor3d.Position.z);
    }
  }

  public void Drag(UpgradeDisplay upgrade)
  {
    if (!this.canDragMidBattle && (bool) (Object) References.Battle && !References.Battle.ended)
    {
      SfxSystem.OneShot(this.denySfxEvent);
    }
    else
    {
      TouchInputModule.BlockScroll();
      this.preHolder = upgrade.GetComponentInParent<UpgradeHolder>();
      if ((bool) (Object) this.preHolder)
      {
        this.preIndex = this.preHolder.IndexOf(upgrade);
        this.preHolder.Remove(upgrade);
        this.preHolder.SetPositions();
      }
      this.dragHolder.Add(upgrade);
      this.dragHolder.SetPositions();
      this.UpdatePosition();
      global::Events.InvokeUpgradePickup(upgrade);
      this.dragging = upgrade;
      this.IsDragging = true;
      if (this.eligibleCards == null)
        this.eligibleCards = new List<Entity>();
      if (this.ineligibleCards == null)
        this.ineligibleCards = new List<Entity>();
      foreach (CardContainer assignmentContainer in this.assignmentContainers)
      {
        foreach (Entity card in assignmentContainer)
        {
          if (this.dragging.data.CanAssign(card))
          {
            this.eligibleCards.Add(card);
            card.flipper.FlipUp();
          }
          else
          {
            this.ineligibleCards.Add(card);
            card.flipper.flipped = true;
          }
        }
      }
      this.StopAllCoroutines();
      this.StartCoroutine(this.FlipCardsDown((IEnumerable<Entity>) this.ineligibleCards));
      NavigationState.Start((INavigationState) new NavigationStateAssignUpgrade(this.eligibleCards));
      this.cardController.canPress = false;
    }
  }

  public void Release(UpgradeDisplay upgrade)
  {
    if ((Object) this.dragging != (Object) upgrade)
      return;
    if ((bool) (Object) this.hoverEntity && this.eligibleCards != null && this.eligibleCards.Contains(this.hoverEntity))
    {
      this.dragHolder.Remove(this.dragging);
      Routine routine = new Routine(this.Assign(this.dragging, this.hoverEntity));
    }
    else
    {
      if ((bool) (Object) this.preHolder)
        this.ReturnToHolder();
      this.DragEnd();
    }
  }

  private void DragEnd()
  {
    TouchInputModule.UnblockScroll();
    this.dragging = (UpgradeDisplay) null;
    this.IsDragging = false;
    this.StopAllCoroutines();
    this.StartCoroutine(this.FlipCardsUp((IEnumerable<Entity>) this.ineligibleCards.ToArray()));
    this.eligibleCards = (List<Entity>) null;
    this.ineligibleCards = (List<Entity>) null;
    NavigationState.BackToPreviousState();
    this.cardController.canPress = true;
  }

  private void ReturnToHolder()
  {
    this.dragHolder.Remove(this.dragging);
    this.preHolder.Insert(this.preIndex >= 0 ? this.preIndex : 0, this.dragging);
    this.dragging.transform.localPosition = Vector3.zero;
    this.preHolder.SetPositions();
    global::Events.InvokeUpgradeDrop(this.dragging);
  }

  public void CancelDrag()
  {
    if (!this.IsDragging)
      return;
    CardCharmInteraction component = this.dragging.GetComponent<CardCharmInteraction>();
    if (component == null)
      return;
    component.CancelDrag();
    this.ReturnToHolder();
    this.DragEnd();
  }

  private IEnumerator FlipCardsDown(IEnumerable<Entity> cards)
  {
    this.flipClump.Clear();
    foreach (Entity card in cards)
      this.flipClump.Add(CardCharmDragHandler.FlipDown(card, PettyRandom.Range(0.0f, 0.2f)));
    yield return (object) this.flipClump.WaitForEnd();
  }

  private static IEnumerator FlipDown(Entity card, float delay)
  {
    yield return (object) new WaitForSeconds(delay);
    card.flipper.FlipDown(true);
  }

  private IEnumerator FlipCardsUp(IEnumerable<Entity> cards)
  {
    this.flipClump.Clear();
    foreach (Entity card in cards)
      this.flipClump.Add(CardCharmDragHandler.FlipUp(card, PettyRandom.Range(0.0f, 0.2f)));
    yield return (object) this.flipClump.WaitForEnd();
  }

  private static IEnumerator FlipUp(Entity card, float delay)
  {
    yield return (object) new WaitForSeconds(delay);
    card.flipper.FlipUp();
  }

  private IEnumerator Assign(UpgradeDisplay upgrade, Entity entity)
  {
    this.cardController.Disable();
    NavigationState.Start((INavigationState) new NavigationStateWait(true));
    CardUpgradeData upgradeData = upgrade.data;
    upgrade.gameObject.Destroy();
    if (this.instantAssign || upgradeData.type != CardUpgradeData.Type.Charm)
    {
      yield return (object) upgradeData.Assign(entity);
    }
    else
    {
      this.assignSequence.Assign(entity, upgradeData);
      yield return (object) this.assignSequence.Run();
    }
    this.cardController.Enable();
    NavigationState.BackToPreviousState();
    this.DragEnd();
    if ((bool) (Object) this.cardController.owner)
      this.cardController.owner.data.inventory.upgrades.Remove(upgradeData);
    this.onAssign?.Invoke();
  }

  private void EntityHover(Entity entity)
  {
    if (this.eligibleCards == null || !this.eligibleCards.Contains(entity))
      return;
    this.hoverEntity = entity;
  }

  private void EntityUnHover(Entity entity)
  {
    if (!((Object) this.hoverEntity == (Object) entity))
      return;
    this.hoverEntity = (Entity) null;
  }
}
