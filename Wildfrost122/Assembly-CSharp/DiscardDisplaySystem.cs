// Decompiled with JetBrains decompiler
// Type: DiscardDisplaySystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class DiscardDisplaySystem : GameSystem
{
  [SerializeField]
  private Transform display;
  [SerializeField]
  private TweenUI showTween;
  [SerializeField]
  private TweenUI hideTween;
  private Entity entityDrag;
  private CardContainer hoverDiscardContainer;
  private bool draggingCanDiscard;

  private void OnEnable()
  {
    global::Events.OnEntityDrag += new UnityAction<Entity>(this.EntityDrag);
    global::Events.OnEntityRelease += new UnityAction<Entity>(this.EntityRelease);
    global::Events.OnContainerHover += new UnityAction<CardContainer>(this.ContainerHover);
    global::Events.OnContainerUnHover += new UnityAction<CardContainer>(this.ContainerUnHover);
  }

  private void OnDisable()
  {
    global::Events.OnEntityDrag -= new UnityAction<Entity>(this.EntityDrag);
    global::Events.OnEntityRelease -= new UnityAction<Entity>(this.EntityRelease);
    global::Events.OnContainerHover -= new UnityAction<CardContainer>(this.ContainerHover);
    global::Events.OnContainerUnHover -= new UnityAction<CardContainer>(this.ContainerUnHover);
  }

  private void EntityDrag(Entity entity)
  {
    this.entityDrag = entity;
    this.draggingCanDiscard = entity.CanRecall();
  }

  private void EntityRelease(Entity entity)
  {
    if (!((Object) this.entityDrag == (Object) entity))
      return;
    this.entityDrag = (Entity) null;
    this.Hide();
  }

  private void ContainerHover(CardContainer container)
  {
    if (!((Object) this.entityDrag != (Object) null) || !this.draggingCanDiscard || !((Object) container != (Object) null) || !((Object) this.entityDrag.owner != (Object) null) || !((Object) container == (Object) this.entityDrag.owner.discardContainer))
      return;
    this.hoverDiscardContainer = container;
    this.display.position = container.transform.position;
    this.Show();
  }

  private void ContainerUnHover(CardContainer container)
  {
    if (!((Object) this.hoverDiscardContainer == (Object) container))
      return;
    this.hoverDiscardContainer = (CardContainer) null;
    this.Hide();
  }

  private void Show()
  {
    this.display.gameObject.SetActive(true);
    this.showTween?.Fire();
  }

  private void Hide() => this.StartCoroutine(this.HideRoutine());

  private IEnumerator HideRoutine()
  {
    if ((Object) this.hideTween != (Object) null)
    {
      this.hideTween.Fire();
      yield return (object) Sequences.Wait(this.hideTween.GetDuration());
    }
    this.display.gameObject.SetActive(false);
  }
}
